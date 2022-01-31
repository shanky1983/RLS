using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Attune.Podium.BusinessEntities;
using Attune.Solution.BusinessComponent;
using Attune.Podium.BillingEngine;
using Attune.Podium.Common;
using System.Collections;
using Microsoft.Reporting.WebForms;
using System.Net;
using System.Xml;
using System.IO;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using PdfSharp.Pdf.Advanced;
using PdfSharp.Pdf.Security;
using System.Web.UI.HtmlControls;
using Attune.Utilitie.Helper;
using System.Security.Cryptography;
using Attune.Podium.PerformingNextAction;
using Attune.Solution.DAL;
using System.Data;
public partial class Invoice_CreditNote : BasePage, IDisposable
{
    string strSelect = Resources.Invoice_ClientDisplay.Invoice_InvoiceTracker_aspx_006 == null ? "--Select--" : Resources.Invoice_ClientDisplay.Invoice_InvoiceTracker_aspx_006;
    long InvID = 0;
    ActionManager objActionManager;
    public Invoice_CreditNote()
        : base("Invoice_CreditNote_aspx")
    {
    }

    protected void page_Init(object sender, EventArgs e)
    {
        base.page_Init(sender, e);
    }

    BillingEngine bill = new BillingEngine();
    int currentPageNo = 1;
    int PageSize = 50;
    int totalRows = 0;
    int totalpage = 0;
    int ZonalID = -1;
    int HubID = -1;
    ArrayList al = new ArrayList();
    DateTime dtFrom;
    DateTime dtTo;

    static List<ActionMaster> lstActionMaster = new List<ActionMaster>();

    protected void Page_Load(object sender, EventArgs e)
    {
        
        dtFrom = Convert.ToDateTime(new BasePage().OrgDateTimeZone);
        dtTo = Convert.ToDateTime(new BasePage().OrgDateTimeZone);
        objActionManager = new ActionManager(base.ContextInfo);
        bill = new BillingEngine(base.ContextInfo);
        hdnChkInvoice.Value = "0";
        string InvoiceType = string.Empty;
        
        hdnInvoiceType.Value = InvoiceType;
        string InvoiceReceiptPage;
        InvoiceReceiptPage = GetConfigValue("OldInvoiceReceipt", OrgID);
        if (!IsPostBack)
        {
            LoadMeatData();
            string configMultiplePayment;
            configMultiplePayment = GetConfigValue("InvoiceMultiplePayment", OrgID);//Round off is done by config value(orgbased)
           
            hdnInvoiceMultiplePayment.Value = (configMultiplePayment == "Y") ? "1" : "0";

        } 
    }
    public void LoadMeatData()
    {
        try
        {

            long returncode = -1;
            string domains = "CreditNoSeach";
            string[] Tempdata = domains.Split(',');
            string LangCode = "en-GB";
            List<MetaData> lstmetadataInput = new List<MetaData>();
            List<MetaData> lstmetadataOutput = new List<MetaData>();

            MetaData objMeta;

            for (int i = 0; i < Tempdata.Length; i++)
            {
                objMeta = new MetaData();
                objMeta.Domain = Tempdata[i];
                lstmetadataInput.Add(objMeta);

            }
            returncode = new MetaData_BL(base.ContextInfo).LoadMetaDataOrgMapping(lstmetadataInput, OrgID, LanguageCode, out lstmetadataOutput);
            if (lstmetadataOutput.Count > 0)
            {
                ddlcreditnotype.DataSource = lstmetadataOutput;
                ddlcreditnotype.DataTextField = "DisplayText";
                ddlcreditnotype.DataValueField = "Code";
                ddlcreditnotype.DataBind();
            }
           
        }

        catch (Exception ex)
        {
            CLogger.LogError("Error while  loading Type   ", ex);

        }
    } 
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        txtpageNo.Text = "";
        hdnCurrent.Value = "";
        grdInvoiceBill.DataSource = null;
        LoadGrid(e, currentPageNo, PageSize);
    }
    //arun
    protected void btnSaveCredit_Click(object sender, EventArgs e)
    {
        string strAlert = Resources.Admin_AppMsg.Admin_SpecialRateCard_aspx_Alert == null ? "Alert" : Resources.Admin_AppMsg.Admin_SpecialRateCard_aspx_Alert;
        string strSpc04 =  "Credit Notes saved sucessfully";
        string strSpc05 =  "Credit Notes updated sucessfully";
        List<CreditNotesDetails> lstCreditNoteDetail = new List<CreditNotesDetails>();
        try
        {
            long returnCode = -1;
            string MappingType = "Client";            
            foreach (string items in hdnCreditNotevalues.Value.Split('^'))
            {
                if (items != "")
                {
                    CreditNotesDetails objCreditNote = new CreditNotesDetails();
                    objCreditNote.FinalbillId = Convert.ToInt64(items.Split('_')[0]);
                    objCreditNote.BillingDetailsId = Convert.ToInt64(items.Split('_')[1]);
                    objCreditNote.InvoiceId = Convert.ToInt64(items.Split('_')[2]);
                    objCreditNote.ClientId = Convert.ToInt64(items.Split('_')[3]);
                    objCreditNote.CreditNote = items.Split('_')[4].ToString();
                    lstCreditNoteDetail.Add(objCreditNote);
                }
                else
                {
                    CreditNotesDetails objCreditNote = new CreditNotesDetails();
                    objCreditNote.FinalbillId = 0;
                    objCreditNote.BillingDetailsId =0;
                    objCreditNote.InvoiceId = 0;
                    objCreditNote.ClientId = 0;
                    objCreditNote.CreditNote = "";
                    lstCreditNoteDetail.Add(objCreditNote);
                }
            }
            if (lstCreditNoteDetail.Count > 0)
            {
                string RateName = "";
                Users_BL usersBL = new Users_BL(base.ContextInfo);
                returnCode = usersBL.SaveCreditNoteDetails(lstCreditNoteDetail, LID, OrgID);
                //returnCode = objMasterBL.SaveSpecialRateMaster(RateName, OrgID, LID, MappingType, lstRateMaster);
                if (returnCode > 0)
                {
                    ScriptManager.RegisterStartupScript(Page, GetType(), "DisplayTab", "javascript:DisplayTab('CLI')", true);                    
                        ScriptManager.RegisterStartupScript(Page, GetType(), "Alert", "javascript:ValidationWindow('" + strSpc05 + "','" + strAlert + "')", true);                    
                    //reload the grid values
                        LoadData();
                }                
               
            }

        }
        catch (Exception ex)
        {
            CLogger.LogError("Error while Save in btnSaveCredit_Click() in CreditNoteUpdation.aspx", ex);
        }
    }

    protected void grdInvoiceBill_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            long returncode = 0;
            int InvoiceID = 0, ClientID = 0;
            List<TRFfilemanager> lstFiles = new List<TRFfilemanager>();
            List<TRFfilemanager> lstTRF = new List<TRFfilemanager>();
            //Determine the RowIndex of the Row whose Button was clicked.
            int rowIndex = Convert.ToInt32(e.CommandArgument);

            //Reference the GridView Row.
            GridViewRow row = grdInvoiceBill.Rows[rowIndex];

            //Fetch values.
            string lblClientID = (row.FindControl("lblClientID") as Label).Text;
            string lblInvoiceID = (row.FindControl("lblInvoiceID") as Label).Text;
            if (!string.IsNullOrEmpty(lblInvoiceID))
            {
                InvoiceID = Convert.ToInt16(lblInvoiceID);
            }
            if (!string.IsNullOrEmpty(lblClientID))
            {
                ClientID = Convert.ToInt16(lblClientID);
            }
            returncode = new Patient_BL(base.ContextInfo).GetTRFimageDetails(ClientID, InvoiceID, OrgID, "", out lstFiles);

            if (lstFiles.Count > 0)
            {
                lstTRF = lstFiles.FindAll(P => P.IdentifyingType == "Invoice_Upload");
            }

            if (lstTRF.Count > 0)
            {
                //if (lstTRF.Count == 1)
                //{
                    string PictureName = string.Empty;
                    PictureName = lstTRF[0].FileName;
                    string fileName = Path.GetFileNameWithoutExtension(PictureName);
                    string fileExtension = Path.GetExtension(PictureName);                 
                //}
            }
        }
        catch (Exception ex)
        {

        }
    }
    //arun
    protected void grdInvoiceBill_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            CreditNotesDetails Iv = (CreditNotesDetails)e.Row.DataItem;
            string strScript = "javascript:onChaangeChk('" + ((CheckBox)e.Row.Cells[0].FindControl("chkInvoiceItemunique")).ClientID + "')";
            ((CheckBox)e.Row.Cells[0].FindControl("chkInvoiceItemunique")).Attributes.Add("onclick", strScript);

            string strScript2 = "javascript:deletecredit('" + ((Image)e.Row.Cells[0].FindControl("imgClrCreditNote")).ClientID + "')";
            ((Image)e.Row.Cells[0].FindControl("imgClrCreditNote")).Attributes.Add("onclick", strScript2);


            string strScript1 = "javascript:onChange('" + ((TextBox)e.Row.Cells[0].FindControl("txtCreditNote")).ClientID + "')";
            ((TextBox)e.Row.Cells[0].FindControl("txtCreditNote")).Attributes.Add("onblur", strScript1);
            
            if (e.Row != null && DataBinder.Eval(e.Row.DataItem, "CreditNote") != "" && DataBinder.Eval(e.Row.DataItem, "CreditNote") != null)
                ((TextBox)e.Row.Cells[0].FindControl("txtCreditNote")).Enabled = false;
            else
                ((TextBox)e.Row.Cells[0].FindControl("txtCreditNote")).Enabled = true;
            //if(hdnInvoiceMultiplePayment.Value=="1")
            //e.Row.Cells[15].Visible = (hdnInvoiceMultiplePayment.Value == "1") ? true : true;

        }
        else if (e.Row.RowType == DataControlRowType.Header)
        {
          //  e.Row.Style.Add("display", "block");
        }

    }
 
    protected void btnPrevious_Click(object sender, EventArgs e)
    {
        if (hdnCurrent.Value != "")
        {
            currentPageNo = Int32.Parse(hdnCurrent.Value) - 1;
            hdnCurrent.Value = currentPageNo.ToString();
            LoadGrid(e, currentPageNo, PageSize);
        }
        else
        {
            currentPageNo = Int32.Parse(lblCurrent.Text) - 1;
            hdnCurrent.Value = currentPageNo.ToString();
            LoadGrid(e, currentPageNo, PageSize);
        }
        txtpageNo.Text = "";
    }
    //arun
    private void LoadGrid(EventArgs e, int currentPageNo, int PageSize)
    {
        try
        {
            LoadData();
        }
        catch (Exception ex)
        {
            CLogger.LogError("Error Occured to get InvoiceDetails", ex);
        }
    }
    //arun
    public void LoadData()
    {
        try
        {
            long returnCode = -1;
            BillingEngine BE = new BillingEngine(base.ContextInfo);
            //List<Invoice> lstInvoice = new List<Invoice>();
            string InvoiceNo = txtInvoiceNo.Text;
            int ClientID = 0;

            //int businessTypeID = Convert.ToInt32(drpCustomerType.SelectedItem.Value.ToString());

            if (Convert.ToInt32(hdnClientID.Value) > 0)
            {
                ClientID = Convert.ToInt32(hdnClientID.Value);
            }

            if (txtFrom.Text != "")
            {
                dtFrom = Convert.ToDateTime(txtFrom.Text);
            }
            else
            {
                dtFrom = Convert.ToDateTime("1/1/1753 12:00:00");
            }

            if (txtTo.Text != "")
            {
                dtTo = Convert.ToDateTime(txtTo.Text);
            }
            else
            {
                dtTo = Convert.ToDateTime("1/1/1753 12:00:00");

            }

            //arun changes
            string CreditNoteNumber =txtInvoiceNo.Text != null ? txtInvoiceNo.Text.ToString():"";
            long lClientID = Convert.ToInt64(ClientID);
            int PageCount = 0;
            List<CreditNotesDetails> lstCreditNoteDetail = new List<CreditNotesDetails>();
            ContextInfo.AdditionalInfo = ddlcreditnotype.SelectedItem.Value;
            Users_BL usersBL = new Users_BL(base.ContextInfo);
            usersBL.GetCreditNoteDetails(OrgID, lClientID, CreditNoteNumber, dtFrom, dtTo, currentPageNo, PageSize, out lstCreditNoteDetail, out PageCount);//, ddlcreditnotype.SelectedItem.Value);
            ContextInfo.AdditionalInfo = "";
            if (lstCreditNoteDetail.Count > 0)
            {
                tblgrd.Style.Add("display", "table");
                //tblSaveNote.Style.Add("display", "table");
                tr1.Style.Add("display", "table");
                //                tblprintaction.Style.Add("display", "table");
                //                GrdHeader.Style.Add("display", "table");
                GrdFooter.Style.Add("display", "table-row");
                totalpage = PageCount;
                //   totalRows = PageCount;
                // lblTotal.Text = CalculateTotalPages(PageCount).ToString();
                lblTotal.Text = PageCount.ToString();
                hdnRowcount.Value = lstCreditNoteDetail.Count.ToString();
                if (hdnCurrent.Value == "")
                {
                    lblCurrent.Text = currentPageNo.ToString();
                }
                else
                {
                    lblCurrent.Text = hdnCurrent.Value;
                    currentPageNo = Convert.ToInt32(hdnCurrent.Value);
                }
                if (currentPageNo == 1)
                {
                    btnPrevious.Enabled = false;
                    if (Int32.Parse(lblTotal.Text) > 1)
                    {
                        btnNext.Enabled = true;
                    }
                    else
                        btnNext.Enabled = false;
                }
                else
                {
                    btnPrevious.Enabled = true;
                    if (currentPageNo == Int32.Parse(lblTotal.Text))
                        btnNext.Enabled = false;
                    else btnNext.Enabled = true;
                }
            }
            else
            {
                //tblSaveNote.Style.Add("display", "none");
                GrdFooter.Style.Add("display", "none");
                tr1.Style.Add("display", "none");
            }
            if (lstCreditNoteDetail.Count > 0)
            {
                grdInvoiceBill.Visible = true;
                lblResult.Visible = false;
                lblResult.Text = "";
                grdInvoiceBill.DataSource = lstCreditNoteDetail;
                grdInvoiceBill.DataBind();
                //trddl.Style.Add("display", "table-row");
            }
            else
            {
                grdInvoiceBill.Visible = false;
                lblResult.Visible = true;
                //trddl.Style.Add("display", "none");
                lblResult.Text =  "No matching records found" ;//"No matching records found";
            }
        }
        catch (Exception ex)
        {
        }
    }
    private int CalculateTotalPages(double totalRows)
    {
        int totalPages = (int)Math.Ceiling(totalRows / PageSize);
        return totalPages;
    }
    //arun
    protected void grdInvoiceBill_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        if (e.NewPageIndex != -1)
        {
            grdInvoiceBill.PageIndex = e.NewPageIndex;
            currentPageNo = e.NewPageIndex;
            btnSearch_Click(sender, e);
        }
    }
    //arun
    protected void btnNext_Click(object sender, EventArgs e)
    {
        if (hdnCurrent.Value != "")
        {
            currentPageNo = Int32.Parse(hdnCurrent.Value) + 1;
            hdnCurrent.Value = currentPageNo.ToString();
            LoadGrid(e, currentPageNo, PageSize);
        }
        else
        {
            currentPageNo = Int32.Parse(lblCurrent.Text) + 1;
            hdnCurrent.Value = currentPageNo.ToString();
            LoadGrid(e, currentPageNo, PageSize);
        }
        txtpageNo.Text = "";
    }
    //arun
    protected void btnGo_Click(object sender, EventArgs e)
    {

        //if (chkInvDraft.Checked == false)
        //{
            hdnCurrent.Value = txtpageNo.Text;
            LoadGrid(e, Convert.ToInt32(txtpageNo.Text), PageSize);
        //}

    }
 
    public void callpage(object sender, EventArgs e)
    {
        Page_Load(sender, e);
    }
}