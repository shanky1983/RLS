using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using Attune.Podium.BusinessEntities;
using Attune.Solution.BusinessComponent;
using System.Data;
using Attune.Podium.Common;
using Attune.Podium.BillingEngine;
using Attune.Podium.ExcelExportManager;
using System.IO;
using Attune.Podium.BusinessEntities.CustomEntities;
using System.Web.UI.HtmlControls;

public partial class ReportsLims_ExpanseReport : BasePage
{
    
   
    
    protected void Page_Load(object sender, EventArgs e)
    {
        AutoGname1.ContextKey = OrgID.ToString() + "~" + "users" + "~" + "A";
        if (!IsPostBack)
        {
            txtValidFrom.Text= OrgTimeZone;
            txtValidTo.Text = OrgTimeZone;
            LoadOrgan();
            LoadMetaData();
            tblgrdDynamic.Visible = false;
        }
       
            //txtValidFrom.Attributes.Add("onchange", "validateFrom('" + txtValidFrom.ClientID.ToString() + "','" + txtValidTo.ClientID.ToString() + "');");
            //txtValidTo.Attributes.Add("onchange", "ValidDate('" + txtValidFrom.ClientID.ToString() + "','" + txtValidTo.ClientID.ToString() + "','txtValidFrom',0,0);");
        }
   
    public void LoadMetaData()
    {
        try
        {
            long returncode = -1;
            string domains = "LoadReportType,VisitType1";
            string[] Tempdata = domains.Split(',');
            string LangCode = "en-GB";
            // string LangCode = string.Empty;
            List<MetaData> lstmetadataInput = new List<MetaData>();
            List<MetaData> lstmetadataOutput = new List<MetaData>();

            MetaData objMeta;

            for (int i = 0; i < Tempdata.Length; i++)
            {
                objMeta = new MetaData();
                objMeta.Domain = Tempdata[i];
                lstmetadataInput.Add(objMeta);

            }

           
            returncode = new MetaData_BL(base.ContextInfo).LoadMetaDataOrgMapping(lstmetadataInput, OrgID, LangCode, out lstmetadataOutput);           
            if (lstmetadataOutput.Count > 0)
            {
                var ReportFormat = from child in lstmetadataOutput
                                   where child.Domain == "LoadReportType"
                                   orderby child.DisplayText descending
                                   select child;
                drpRepType.DataSource = ReportFormat;
                drpRepType.DataTextField = "DisplayText";
                drpRepType.DataValueField = "Code";
                drpRepType.DataBind(); 
            }


        }

        catch (Exception ex)
        {
            CLogger.LogError("Error while  loading Search Type  Meta Data like Custom Period,Search Type ... ", ex);

        }
    }
    private void LoadOrgan()
    {
        try
        {
            List<Organization> lstOrgList = new List<Organization>();
            AdminReports_BL objBl = new AdminReports_BL(base.ContextInfo);
            objBl.GetSharingOrganizations(OrgID, out lstOrgList);
            if (lstOrgList.Count > 0)
            {
                drpOrg.DataSource = lstOrgList;
                drpOrg.DataTextField = "Name";
                drpOrg.DataValueField = "OrgID";
                drpOrg.DataBind();
                drpOrg.SelectedValue = lstOrgList.Find(p => p.OrgID == OrgID).ToString();
                drpOrg.Focus();
            }

        }
        catch (Exception ex)
        {
            CLogger.LogError("Error in load TrustedOrg details", ex);
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        LoadGrid();
       

    }


    public void LoadGrid()
    {
        try
        {
            long returnCode = -1;
            Report_BL reportBL = new Report_BL(base.ContextInfo);
            int ReportType = Convert.ToInt16(drpRepType.SelectedValue);
            List<ExpenseReport> ExpenseDetailsIn = new List<ExpenseReport>();
            string fromdateD = (Convert.ToDateTime(txtValidFrom.Text).Date).ToString("dd/MM/yyyy");
            string todateD = (Convert.ToDateTime(txtValidTo.Text).Date).ToString("dd/MM/yyyy");
            // string todateD = Convert.ToDateTime(txtValidTo.Text);
            int OrgID = Convert.ToInt32(drpOrg.SelectedValue);
            string UserName = txtUserName.Text == "" ? "" : txtUserName.Text;
            DateTime fromdate = Convert.ToDateTime(fromdateD);
            DateTime todate = Convert.ToDateTime(todateD);

            returnCode = reportBL.GetExpence(ReportType, fromdate.Date, todate, OrgID, UserName, out ExpenseDetailsIn);

            if (ExpenseDetailsIn.Count > 0)
            {
                tblgrdDynamic.Visible = true;
                if (drpRepType.SelectedValue == "1")
                {
                    grdPendingDetails.DataSource = ExpenseDetailsIn;
                    grdPendingDetails.DataBind();
                    grdPendingDetails.Visible = true;
                    grdSummary.Visible = false;
                    txtSearchDeatils.Visible = true;
                    txtSearchSummary.Visible = false;
                    lblfound.Visible = false;
                    lblTotalExpense.Visible = false;
                }
                else
                {
                    grdPendingDetails.Visible = false;
                }

                if (drpRepType.SelectedValue == "2")
                {
                    lblTotalExpense.Visible = true;
                    var ReportFormat = ExpenseDetailsIn.Select(o => o.Amount).Sum();

                    lblTotalExpense.Text = "Total expendeture " + ReportFormat;
                    grdPendingDetails.Visible = false;
                    grdSummary.Visible = true;
                    grdSummary.DataSource = ExpenseDetailsIn;
                    grdSummary.DataBind();
                    txtSearchDeatils.Visible = false;
                    txtSearchSummary.Visible = true;
                    lblfound.Visible = false;

                }
                else
                {
                    grdSummary.Visible = false;
                }
            }
            else
            {
                tblgrdDynamic.Visible = false;
                grdPendingDetails.Visible = false;
                grdSummary.Visible = false;
                txtSearchSummary.Visible = false;
                txtSearchDeatils.Visible = false;
                lblfound.Visible = true;
                lblfound.Text = "No matching record found";


            }
        }
        catch (Exception ex)
        {

            CLogger.LogError("Error while  Load Grid in Expense report page ... ", ex);
        }

      
     
        

    }

    protected void lnkExportXL_Click(object sender, EventArgs e)
    {
        ExportToXL();
    }
    public override void VerifyRenderingInServerForm(Control control)
    {
        //don't delete this method
        // Confirms that an HtmlForm control is rendered for the
        // specified ASP.NET server control at run time.

    }
    public void ExportToXL()
    {


        Response.Clear();
        Response.AddHeader("content-disposition", "attachment;filename=Expesnses Report.xls");

        Response.Charset = "";

        // If you want the option to open the Excel file without saving than

        // comment out the line below

        // Response.Cache.SetCacheability(HttpCacheability.NoCache);

        Response.ContentType = "application/vnd.xls";

        System.IO.StringWriter stringWrite = new System.IO.StringWriter();

        System.Web.UI.HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);

        tblgrdDynamic.RenderControl(htmlWrite);

        Response.Write(stringWrite.ToString());

        Response.End();

    }
}

  
