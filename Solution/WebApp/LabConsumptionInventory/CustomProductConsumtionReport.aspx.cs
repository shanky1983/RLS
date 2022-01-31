using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using Attune.Kernel.BusinessEntities;
using Attune.Kernel.LabConsumptionInventory.BL;
using Attune.Kernel.PlatForm.Base;
using Attune.Kernel.PlatForm.Utility;
using System.Web.Script.Serialization;
using System.Collections.Generic;
using Attune.Kernel.PlatForm.BL;
using Attune.Kernel.BusinessEntities.CustomEntities;

public partial class LabConsumptionInventory_CustomProductConsumtionReport : Attune_BasePage
{

    public LabConsumptionInventory_CustomProductConsumtionReport()
        : base("LabConsumptionInventory_CustomProductConsumtionReport_aspx")
    { }
   


    protected void page_Init(object sender, EventArgs e)
    {
        base.page_Init(sender, e);
    }

    LabConsumptionInventory_BL objConInvBL;

    protected void Page_Load(object sender, EventArgs e)
    {
        hdnOrgid.Value = Convert.ToString(OrgID);
        if (!IsPostBack)
        {
            BindLabDepartment();
            BindAnalyzerName();
            LoadLocationName();
            txtFrom.Text = DateTimeNow.ToExternalDate();
            txtTo.Text = DateTimeNow.ToExternalDate();
            txtFrom.Focus();
        }
    }

    //--------------- GetCustomConsumptionProductReport-------------
    #region GetCustomConsumptionProductReport [GetConsumptionFlex]
    [System.Web.Services.WebMethod]
    public static List<LCMReports> GetCustomConsumptionProductReport(
                                      string strOrgid, string Barcode, string Deviceid,
                                      DateTime fromdate, DateTime todate, string StrLocationid, string deptid,
                                      string investigationID
                                      )
    {


        List<LCMReports> lstReports = new List<LCMReports>();
        LabConsumptionReports_BL ObjBAL = new LabConsumptionReports_BL(new Attune_BaseClass().ContextInfo);
        int cpcLocationID, cpcDepartmentID, cpcOrgID, cpcInvestigationID;


        try
        {
            Int32.TryParse(strOrgid, out cpcOrgID);
            Int32.TryParse(StrLocationid, out cpcLocationID);
            Int32.TryParse(deptid, out cpcDepartmentID);
            Int32.TryParse(investigationID, out cpcInvestigationID);
            ObjBAL.GetCustomConsumptionProductReport(cpcOrgID, Barcode, Deviceid, fromdate, todate, cpcLocationID, cpcDepartmentID, cpcInvestigationID, "", out lstReports);


        }
        catch (Exception ex)
        {
            CLogger.LogError("Error While GetConsumptionFlex in WebService", ex);
        }

        return lstReports;
    }


    #endregion

    private void BindAnalyzerName()
    {
        long ReturnCode = -1;
        objConInvBL = new LabConsumptionInventory_BL(base.ContextInfo);
        List<DeviceIntegrationOrgMapping> lstDevice = new List<DeviceIntegrationOrgMapping>();
        try
        {

            ListItem ddlselect = GetMetaData("Select", "0");
            if (ddlselect == null)
            {
                ddlselect = new ListItem() { Text = "Select", Value = "0" };
            }

            ReturnCode = objConInvBL.GetOrgwiseAnalyzerName(OrgID, out lstDevice);
            ddlAnalyzerName.DataSource = lstDevice;
            ddlAnalyzerName.DataTextField = "InstrumentName";
            ddlAnalyzerName.DataValueField = "DeviceID";
            ddlAnalyzerName.DataBind();
            ddlAnalyzerName.Items.Insert(0, ddlselect);



        }
        catch (Exception ex)
        {
            Attuneheader.LoadErrorMsg("There was a problem in page load. Please contact system administrator");
            CLogger.LogError("Error on Loading BindAnalyzerName in LabConsumptionInventory_DevicesStockUsage.aspx.aspx", ex);
        }
    }

    private void LoadLocationName()
    {
        List<Locations> lstLocation = new List<Locations>();
        try
        {
            int OrgAddid = 0;
            new Master_BL(base.ContextInfo).GetInvLocationDetail(OrgID, OrgAddid, out lstLocation);

            ddlLocation.DataSource = lstLocation;
            ddlLocation.DataTextField = "LocationName";
            ddlLocation.DataValueField = "LocationID";
            ddlLocation.DataBind();
            ListItem ddlselect = GetMetaData("ALL", "0");
            if (ddlselect == null)
            {
                ddlselect = new ListItem() { Text = "ALL", Value = "0" };
            }
            ddlLocation.Items.Insert(0, ddlselect);
            ddlLocation.Items[0].Value = "0";
            ddlLocation.SelectedValue = InventoryLocationID.ToString();
        }
        catch (Exception Ex)
        {
            CLogger.LogError("Error While loading Location Details", Ex);
        }
    }

    private void BindLabDepartment()
    {
        long ReturnCode = -1;
        objConInvBL = new LabConsumptionInventory_BL(base.ContextInfo);
        List<InvDeptMaster> lstDept = new List<InvDeptMaster>();
        try
        {

            ListItem ddlselect = GetMetaData("Select", "0");
            if (ddlselect == null)
            {
                ddlselect = new ListItem() { Text = "Select", Value = "0" };
            }

            ReturnCode = objConInvBL.pGetLabDepartment(OrgID, "RCR", out lstDept);
            ddlLabDepartment.DataSource = lstDept;
            ddlLabDepartment.DataTextField = "DeptName";
            ddlLabDepartment.DataValueField = "DeptID";
            ddlLabDepartment.DataBind();
            ddlLabDepartment.Items.Insert(0, ddlselect);



        }
        catch (Exception ex)
        {
            Attuneheader.LoadErrorMsg("There was a problem in page load. Please contact system administrator");
            CLogger.LogError("Error on Loading BindAnalyzerName in LabConsumptionInventory_ReorderConsumptionReport.aspx", ex);
        }
    }

    protected void btnsearch_Click(object sender, EventArgs e)
    {
        ScriptManager.RegisterStartupScript(this.Page, GetType(), "Javascript", "javascript:callWebservices(); ", true);
    }

}
