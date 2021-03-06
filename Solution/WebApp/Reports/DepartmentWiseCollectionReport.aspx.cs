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
using System.Text;

public partial class Reports_DepartmentWiseCollectionReport : BasePage
{
    long returnCode = -1;
    List<DayWiseCollectionReport> lstCash = new List<DayWiseCollectionReport>();
    List<DayWiseCollectionReport> lstCredit = new List<DayWiseCollectionReport>();
    List<DayWiseCollectionReport> lstTotal = new List<DayWiseCollectionReport>();
    SharedInventory_BL inventoryBL;
    List<Organization> lstorgn = new List<Organization>();
    List<Locations> lstloc = new List<Locations>();
    decimal pTotalDiscount = 0;
    decimal pTotalRefund = 0;
    decimal pTotalDue = 0;
    decimal pTotalGrossAmount = 0;
    decimal pTotalNetAmount = 0;
    decimal pTotalAdvance = 0;
    decimal pCashDiscount = 0;
    decimal pCreditDiscount = 0;
    decimal pTotalDeposit = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        inventoryBL = new SharedInventory_BL(base.ContextInfo);
        txtFDate.Attributes.Add("onchange", "ExcedDate('" + txtFDate.ClientID.ToString() + "','',0,0);");
        txtTDate.Attributes.Add("onchange", "ExcedDate('" + txtTDate.ClientID.ToString() + "','',0,0); ExcedDate('" + txtTDate.ClientID.ToString() + "','txtFDate',1,1);");
        if (!IsPostBack)
        {
            txtFDate.Text = System.DateTime.Today.ToString("dd/MM/yyyy");
            txtTDate.Text = System.DateTime.Today.ToString("dd/MM/yyyy");
            List<Config> lstConfig = new List<Config>();
            new GateWay(base.ContextInfo).GetConfigDetails("No Need Collection Split up", OrgID, out lstConfig);
            if (lstConfig.Count > 0)
                hdnNeedSplitup.Value = lstConfig[0].ConfigValue.Trim();
            LoadOrgan();
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
                ddlTrustedOrg.DataSource = lstOrgList;
                ddlTrustedOrg.DataTextField = "Name";
                ddlTrustedOrg.DataValueField = "OrgID";
                ddlTrustedOrg.DataBind();
                ddlTrustedOrg.SelectedValue = lstOrgList.Find(p => p.OrgID == OrgID).ToString();
                ddlTrustedOrg.Focus();
            }

        }
        catch (Exception ex)
        {
            CLogger.LogError("Error in load TrustedOrg details", ex);
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            DateTime fDate = Convert.ToDateTime(txtFDate.Text);
            DateTime tDate = Convert.ToDateTime(txtTDate.Text);
            int visitType = Convert.ToInt32(rblVisitType.SelectedValue);
            if (ddlTrustedOrg.Items.Count > 0)
                OrgID = Convert.ToInt32(ddlTrustedOrg.SelectedValue);

            if (rblReportType.SelectedValue == "0")
            {
                returnCode = new Report_BL(base.ContextInfo).GetDepartmentWiseCollectionReport(fDate, tDate, OrgID, visitType, out lstCash, out lstCredit, out lstTotal, out pTotalDiscount, out pTotalRefund, out pTotalDue, out pTotalGrossAmount, out pTotalAdvance, out pCashDiscount, out pCreditDiscount, out pTotalDeposit);
               // grdTotal.Columns[0].Visible = false;
               // grdTotal.Columns[1].Visible = true;
            }
            else
            {
                returnCode = new Report_BL(base.ContextInfo).GetDepartmentWiseDetailReport(fDate, tDate, OrgID, visitType, out lstCash, out lstCredit, out lstTotal, out pTotalDiscount, out pTotalRefund, out pTotalDue, out pTotalGrossAmount, out pTotalAdvance, out pCashDiscount, out pCreditDiscount, out pTotalDeposit);
               // grdTotal.Columns[1].Visible = false;
              //  grdTotal.Columns[0].Visible = true;
            }

            if (lstTotal.Count > 0)
            {
                if (visitType == 0)
                {
                    lblTotalDeposit.Text = "Total Deposit Amount: " + pTotalDeposit.ToString("#.00");
                    lblTotalRefund.Text = "Total Refund Amount: " + pTotalRefund.ToString("#.00");
                    lblTotalDue.Text = "Total Due Collection: " + pTotalDue.ToString("#.00");
                    divTotalDue.Visible = true;
                    divTotalRefund.Visible = true;
                    divTotalDeposit.Visible = true;
                    divTotalAdvance.Visible = false;
                }
                if (visitType == 1)
                {
                    lblTotalRefund.Text = "Total Refund Amount: " + pTotalRefund.ToString("#.00");
                    lblTotalAdvance.Text = "Total Advance Collection: " + pTotalAdvance.ToString("#.00");
                    divTotalRefund.Visible = true;
                    divTotalAdvance.Visible = true;
                    divTotalDue.Visible = false;
                    divTotalDeposit.Visible = false;
                }
                if (visitType == -1)
                {
                    lblTotalDeposit.Text = "Total Deposit Amount: " + pTotalDeposit.ToString("#.00");
                    lblTotalRefund.Text = "Total Refund Amount: " + pTotalRefund.ToString("#.00");
                    lblTotalAdvance.Text = "Total Advance Collection: " + pTotalAdvance.ToString("#.00");
                    lblTotalDue.Text = "Total Due Collection: " + pTotalDue.ToString("#.00");
                    divTotalDue.Visible = true;
                    divTotalRefund.Visible = true;
                    divTotalAdvance.Visible = true;
                    divTotalDeposit.Visible = true;
                }
            }


            //// Code modified by Vijay TV on Sep 22 2011 begins - for providing Cash, Card, Cheque, Draft split up for various categories
            //// The formatting (#.00) is done when double is converted ot String - To show decimal format for the amount displayd
            //lblTotalGross.Text = "Total Gross Billed Amount: " + pTotalGrossAmount.ToString("#.00");
            //lblTotalDiscount.Text = "Total Discount Amount: " + pTotalDiscount.ToString("#.00");
            //lblTotalNet.Text = "Total Net Billed Amount: " + (pTotalGrossAmount - pTotalDiscount).ToString("#.00");
            //lblTotalReceived.Text = "Total Received Amount: " + ((pTotalGrossAmount - pTotalDiscount) - pTotalDue).ToString("#.00");
            //lblTotalBalance.Text = "Total Balance Amount: " + (((pTotalGrossAmount - pTotalDiscount) - pTotalDue) - pTotalRefund).ToString("#.00");
            
            
            //if (visitType == 0 || visitType == -1)
            //{
            //    if (visitType == 0)
            //    {
            //        divTotalAdvance.Visible = false;
            //        lblTotalDue.Text = "Total Due Collection: " + pTotalDue.ToString("#.00");
            //    }
            //    else
            //    {
                    
            //    }
            //}
            //else
            //    lblTotalAdvance.Text = "Total Advance Amount: " + pTotalAdvance.ToString("#.00");
            //lblTotalAmountInHand.Text = "Total Balance On Hand: " + ((((pTotalGrossAmount - pTotalDiscount) - pTotalDue) - pTotalRefund) + pTotalAdvance).ToString("#.00");
            // Code modified by Vijay TV on Sep 22 2011 ends

            if (lstCash.Count > 0)
            {
                if (hdnNeedSplitup.Value == "N")
                {
                    grdCash.Visible = true;
                    lblCash.Visible = true;
                    grdCash.DataSource = lstCash;
                    grdCash.DataBind();
                    tblWithSplit.Style.Add("display", "block");
                    tblWithoutSplit.Style.Add("display", "none");
                }
                else
                {
                    tblWithoutSplit.Style.Add("display", "block");
                    tblWithSplit.Style.Add("display", "none");
                    grdCashPatient.DataSource = lstCash;
                    grdCashPatient.DataBind();
                }

            }
            else
            {
                lblCash.Visible = false;
                grdCash.Visible = false;
            }
            if (lstCredit.Count > 0)
            {
                if (hdnNeedSplitup.Value == "N")
                {
                    grdCredit.Visible = true;
                    lblCredit.Visible = true;
                    grdCredit.DataSource = lstCredit;
                    grdCredit.DataBind();
                    tblWithSplit.Style.Add("display", "block");
                    tblWithoutSplit.Style.Add("display", "none");
                }
                else
                {
                    tblWithoutSplit.Style.Add("display", "block");
                    tblWithSplit.Style.Add("display", "none");
                    grdCreditPatient.DataSource = lstCredit;
                    grdCreditPatient.DataBind();
                }
                
            }
            else
            {
                grdCredit.Visible = false;
                lblCredit.Visible = false;
            }
            if (lstTotal.Count > 0)
            {
                if (hdnNeedSplitup.Value == "N")
                {
                    grdTotal.Visible = true;
                    lblTotal.Visible = true;
                    grdTotal.DataSource = lstTotal;
                    grdTotal.DataBind();
                    tblWithSplit.Style.Add("display", "block");
                    tblWithoutSplit.Style.Add("display", "none");
                }
                else
                {
                    tblWithoutSplit.Style.Add("display", "block");
                    tblWithSplit.Style.Add("display", "none");
                    grdCashCreditPatient.DataSource = lstTotal;
                    grdCashCreditPatient.DataBind();
                }

                foreach (DayWiseCollectionReport lst in lstTotal)
                {
                    if (lst.FeeType == "Pharmacy Refund")
                        lblPharmacytotRefund.Text = "Pharmacy Total Refund Amount:" + lst.BillAmount.ToString("#.00");
                    if (lst.FeeType == "Pharmacy Item Refund")
                        lblPharmacyItemRefund.Text = "Pharmacy Item Refund Amount:" + lst.BillAmount.ToString("#.00");
                    if (lst.FeeType == "Refund Date Range")
                        lblPharmacyDateRangeRefund.Text = "Pharmacy Product Item Refund Value:" + lst.BillAmount.ToString("#.00");

                    divPharmacyDateRangeRefund.Visible = true;
                   // divPharmacyItemRefund.Visible = true;
                    divPharmacytotRefund.Visible = true;
                }

                
                
            }
            else
            {
                grdTotal.Visible = false;
                lblTotal.Visible = false;
            }
             
            if (lstTotal.Count() > 0)
            {
                lblMessage.Visible = false;

            }
            else
            {
                lblMessage.Visible = true;
            }
            
        }
        catch (Exception ex)
        {
            CLogger.LogError("Error in Get Report, GetPatientWiseCombinedReport", ex);
        }
    }
    protected void lnkBack_Click(object sender, EventArgs e)
    {
        try
        {
            Response.Redirect("ViewReportList.aspx", true);
        }
        catch (System.Threading.ThreadAbortException tae)
        {
            string exp = tae.ToString();
        }
        catch (Exception ex)
        {
            CLogger.LogError("Error while Redirecting to Home Page", ex);
        }
    }

    protected void btn_export_Click(object sender, EventArgs e)
    {

        try
        {

            ExportToExcel(lblCash); ExportToExcel(grdCash);
            ExportToExcel(lblCredit); ExportToExcel(grdCredit);
            ExportToExcel(lblTotal); ExportToExcel(grdTotal);
           // ExportToExcel(others);
            
        }
        catch (Exception ex)
        {
            CLogger.LogError("Error in Excel Export", ex);

        }

    }
    public void ExportToExcel(Control CTRl)
    {


        Response.Clear();
        Response.AddHeader("content-disposition",
        string.Format("attachment;filename={0}.xls", "Department Wise Collection Report _" + Convert.ToDateTime(new BasePage().OrgDateTimeZone) .ToString()));
        Response.Charset = "";
        Response.ContentType = "application/vnd.xls";

        StringWriter stringWrite = new StringWriter();
        HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
        lblCash.RenderControl(htmlWrite); grdCash.RenderControl(htmlWrite);
        lblCredit.RenderControl(htmlWrite); grdCredit.RenderControl(htmlWrite);

        lblTotal.RenderControl(htmlWrite); grdTotal.RenderControl(htmlWrite);
        //others.RenderControl(htmlWrite);
        //gvSales.RenderControl(htmlWrite);

        Response.Write(stringWrite.ToString());
        Response.End();
    }





  

    public string getBlankTD(int tdCount)
    {
        string strTD = string.Empty;
        if (tdCount > 4)
        {
            tdCount -= 4;
        }
        while (tdCount > 0)
        {
            strTD += "<td></td>";
            tdCount--;
        }
        return strTD;
    }

    public override void VerifyRenderingInServerForm(Control control)
    {

    }

    private void FilterControls(Control gvRst)
    {
        //Removing Hyperlinks and other controls b4 export

        LinkButton lb = new LinkButton();
        HyperLink hl = new HyperLink();
        Literal l = new Literal();
        string name = String.Empty;
        for (int i = 0; i < gvRst.Controls.Count; i++)
        {
            if (gvRst.Controls[i].GetType() == typeof(LinkButton))
            {
                l.Text = (gvRst.Controls[i] as LinkButton).Text;
                gvRst.Controls.Remove(gvRst.Controls[i]);
                gvRst.Controls.AddAt(i, l);
            }
            if (gvRst.Controls[i].GetType() == typeof(HyperLink))
            {
                l.Text = (gvRst.Controls[i] as HyperLink).Text;
                gvRst.Controls.Remove(gvRst.Controls[i]);
                gvRst.Controls.AddAt(i, l);
            }
            if (gvRst.Controls[i].HasControls())
            {
                FilterControls(gvRst.Controls[i]);
            }
        }
    }

    protected void grdTotal_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            int visitType =Convert.ToInt32(rblVisitType.SelectedItem.Value);
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                DayWiseCollectionReport dwcr = new DayWiseCollectionReport();
                dwcr = (DayWiseCollectionReport)e.Row.DataItem;

                if(dwcr.FeeType == "Pharmacy Refund" || dwcr.FeeType == "Pharmacy Item Refund" || dwcr.FeeType == "Refund Date Range")
                {
                    e.Row.Visible = false;
                 
                }


                LinkButton lnkDept = (LinkButton)e.Row.FindControl("lnkDept");
                if ((dwcr.FeeType != "") && (dwcr.FeeType != "TOTAL"))
                {
                    string fType = string.Empty;
                    if (dwcr.FeeType != "")
                    {
                        fType = dwcr.FeeType;
                    }

                    if (dwcr.FeeType != "Total Billed" && dwcr.FeeType != "Total Discount" && dwcr.FeeType != "Grand Total" && dwcr.FeeType != "Total Due Collection" && dwcr.FeeType != "Total Advance Collection" && dwcr.FeeType != "Total Collection" && dwcr.FeeType != "Total Deposit" && rblReportType.SelectedValue == "1")
                    {
                        string url = Request.ApplicationPath + @"/Reports/DepartmentWiseDetailReportPopUp.aspx?isPopup=Y&dpt=" + fType + "&vfdt=" + txtFDate.Text + "&vtdt=" + txtTDate.Text + "&vtype=" + visitType.ToString();       //DPT Refers to Department ...... VDT Refers to Visit Date

                        e.Row.Attributes.Add("onclick", "ReportPopUP('" + url + "')");
                        e.Row.Style.Add(HtmlTextWriterStyle.Cursor, "Pointer");
                        
                    }
                    
                }
            }
        }
        catch (Exception ex)
        {
            CLogger.LogError("Error in grdTotal_RowDataBound DepartmentWiseCollectionReport", ex);
        }
    }
   

    protected void  grdTotal_RowCreated1(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow && rblReportType.SelectedValue == "1")
        {
                e.Row.Attributes.Add("onmouseover", "this.style.backgroundColor='yellow';");
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor='white';");
        }

    }
}
