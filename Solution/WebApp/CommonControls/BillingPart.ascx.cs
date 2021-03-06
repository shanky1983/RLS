using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Attune.Podium.BusinessEntities;
using Attune.Solution.BusinessComponent;
using Attune.Podium.Common;
using System.IO;
using Attune.Podium.BillingEngine;
using System.Data;
using System.Text;
using System.Security.Cryptography;
using System.Collections;
using System.Xml;
using System.Web.Script.Serialization;
using System.Text.RegularExpressions;


public partial class CommonControls_BillingPart : BaseControl
{
    public CommonControls_BillingPart()
        : base("CommonControls_BillingPart_ascx")
    {
    }

    protected long _MappingClientID = 0;
    public long MappingClientID
    {
        get { return _MappingClientID; }
        set { _MappingClientID = value; }
    }

    protected int _RateID = 0;
    public int RateID
    {
        get { return _RateID; }
        set { _RateID = value; }
    }

    protected long _ClientID = 0;
    public long ClientID
    {
        get { return _ClientID; }
        set { _ClientID = value; }
    }

    protected string _DespatchMode = string.Empty;
    public string DespatchMode
    {
        get { return _DespatchMode; }
        set { _DespatchMode = value; }
    }

    protected string _PatientHistory = "";
    public string PatientHistory
    {
        get { return _PatientHistory; }
        set { _PatientHistory = value; }
    }
    protected decimal _PreviousDue = 0;
    public decimal PreviousDue
    {
        get { return _PreviousDue; }
        set { _PreviousDue = value; }
    }
    protected string _Remarks = "";
    public string Remarks
    {
        get { return _Remarks; }
        set { _Remarks = value; }
    }
    protected string _BillingPageType = "";
    public string BillingPageType
    {
        get { return _BillingPageType; }
        set { _BillingPageType = value; }
    }
    protected string _IsCreditBill = string.Empty;
    public string IsCreditBill
    {
        get { return _IsCreditBill; }
        set { _IsCreditBill = value; }
    }
    protected string _IsClientSelected = string.Empty;
    public string IsClientSelected
    {
        get { return _IsClientSelected; }
        set { _IsClientSelected = value; }
    }
    long patientID = -1, patientVisitID = -1, returnCode = -1, taskID = -1;
    string vType = string.Empty;
    protected string _Gender = string.Empty;
    string MyCardActiveDays = string.Empty;
    public string Gender
    {
        get { return _Gender; }
        set { _Gender = value; }
    }
    string sSlabDiscount = string.Empty;
    string sHasMyCard = string.Empty;
    string strHealthCoupon = string.Empty;//"HEALTHCOUPON";
    string HCScheduler = string.Empty; 

    #region "Common Resource Property"

    string strSelect = Resources.CommonControls_ClientDisplay.CommonControls_BillingPart_ascx_03 == null ? "--Select--" : Resources.CommonControls_ClientDisplay.CommonControls_BillingPart_ascx_03;

    #endregion

    #region "Initial"

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            tdMycard.Style.Add("display", "none");
            hdnOrgIDC.Value = OrgID.ToString();
            hndLocationID.Value = ILocationID.ToString();
            AutoCompleteExtender3.ContextKey = OrgID.ToString();
            AutoAuthorizer.ContextKey = OrgID.ToString();
            txtDiscount.Attributes.Add("style", "disabled:false");
            txtDiscount.Attributes.Add("style", "text-align: right");
            sSlabDiscount = GetConfigValue("IsSlabDiscount", OrgID);
            txtTestName.Attributes.Add("onkeydown", "return (event.keyCode!=13);");
            hdnpopuporgid.Value = GetConfigValue("PopupconfigorgidReport", OrgID);
            hdnHealthCardOTP.Value = GetConfigValue("HealthCardOTP", OrgID);

            HCScheduler = GetConfigValue("IsHCSchedulerWorkflow", OrgID);
            string notAllowDiscountforCashClient = GetConfigValue("NotAllowDiscountforCashClient", OrgID);
            hdnNotallowDiscashClient.Value = notAllowDiscountforCashClient != "Y" ? "N" : notAllowDiscountforCashClient;


            if (sSlabDiscount != "")
                hdnIsSlabDiscount.Value = sSlabDiscount;
            if (hdnIsSlabDiscount.Value == "Y")
            {
                trFoc.Visible = true;
            }
            else
            {
                trFoc.Visible = false;
            }
            string DiscountEditCashClient = GetConfigValue("DiscountEditCashClient", OrgID);

            hdnOrgid.Value = DiscountEditCashClient;
            LoadReasonList();
            LoadTax();
            LoadDiscount();
            LoadFeeType();
            HidePaymentPart();
            UcHistory.LoadHistory();
            HealthCouponSetup();

            string ShowItemLevelDiscount = GetConfigValue("NeedItemLevelDiscount", OrgID);
            hdnitemleveldiscountneed.Value = ShowItemLevelDiscount;
            if (ShowItemLevelDiscount == "Y" && BillingPageType == "")
            {
                LoadItemlevelDiscount();
            }

        }
        string showAddAttributes = GetConfigValue("ShowAttributes", OrgID);
        hdnallowduplicatetesttobill.Value = GetConfigValue("allowduplicatetesttobill", OrgID);
		hdnallowduplicatetesttobill1.Value = GetConfigValue("allowduplicatetesttobill1", OrgID);
        hdnTaxCalFromNetAmt.Value = GetConfigValue("TaxCalculationInNetAmt", OrgID);
        string ClientValidation = string.Empty;
        ClientValidation = GetConfigValue("IsClientmandatory", OrgID);

        hdnIsClientBilling.Value = ClientValidation == "" ? "N" : ClientValidation;
        if (String.IsNullOrEmpty(hdnTaxCalFromNetAmt.Value))
        {
            hdnTaxCalFromNetAmt.Value = "N";
        }
        if (showAddAttributes == "Y")
        {
            //tdAttributes.Attributes.Add("display", "table-cell");
        }
        else
        {
            tdAttributes.Attributes.Add("display", "none");
        }
        hdnZeroAmount.Value = GetConfigValue("IsZeroAmountTest", OrgID);
        string AllowZeroAmount = GetConfigValue("IsAllowZeroAmount", OrgID);
        hdnAllowZeroAmt.Value = AllowZeroAmount;
        string Enabletesthistory = GetConfigValue("EnablehistoryforTest", OrgID);
        hdnEnableHistoryTestConfig.Value = Enabletesthistory;
        
        string B2C_Hide_Billingparts = GetConfigValue("B2C_Hide_Billingparts", OrgID);
        if (B2C_Hide_Billingparts == "Y")
        {
            trDisAmount.Style.Add("display", "none");
            trTaxAmountPart.Style.Add("display", "none");
            trRssHEDChess.Style.Add("display", "none");
            trRsEDSChess.Style.Add("display", "none");
            trServiceCharge.Style.Add("display", "none");
            trRoundOffAmount.Style.Add("display", "none");
        }
  string HideDiscountPartinB2B = GetConfigValue("HideDiscountPartinB2B", OrgID);
        if (HideDiscountPartinB2B == "Y" && BillingPageType == "Client")
        { 
            ddDiscountPercent.Style.Add("display", "none");
            tdDiscountLabel.Style.Add("display", "none");
            btnDiscountPercent.Style.Add("display", "none");
            tdDiscReason.Style.Add("display", "none");
            lblDiscount.Style.Add("display", "none");
            txtDiscount.Style.Add("display", "none");
        }
    }

    private void LoadItemlevelDiscount()

    {
        string ShowItemLevelDiscountType = GetConfigValue("DiscountfromMaterorValue", OrgID);

        if (ShowItemLevelDiscountType != "Y")
        {

            long returncode = -1;
            string domains = "DiscountType";
            List<MetaData> lstmetadataInput = new List<MetaData>();
            List<MetaData> lstmetadataOutput = new List<MetaData>();
            string[] Tempdata = domains.Split(',');

            MetaData objMeta;
            for (int i = 0; i < Tempdata.Length; i++)
            {
                objMeta = new MetaData();
                objMeta.Domain = Tempdata[i];
                lstmetadataInput.Add(objMeta);

            }

            returncode = new MetaData_BL(base.ContextInfo).LoadMetaDataOrgMapping(lstmetadataInput, OrgID, "en-GB", out lstmetadataOutput);
            if (lstmetadataOutput.Count > 0)
            {
                var childItems = from child in lstmetadataOutput
                                 where child.Domain == "DiscountType"
                                 select child;
                if (childItems.Count() > 0)
                {
                    ddlitemdiscountType.DataSource = childItems;
                    ddlitemdiscountType.DataTextField = "DisplayText";
                    ddlitemdiscountType.DataValueField = "Code";
                    ddlitemdiscountType.DataBind();

                    ddlitemdiscountType.Items.Insert(0, new ListItem(strSelect.Trim(), "0"));

                }
            }
        }

        else
        {
            LoadItemlevelDiscountValue();
        }

        LoadItemLevelDiscountReason();

        lblMRP.Visible=true;
        lblclientrate.Visible=true;
        lblitemdiscounttype.Visible = true;
        lblitemdiscountvalue.Visible=true;
        lblitemdiscountreason.Visible=true;
        lblitemAmount.Visible=true;
        txtclientrate.Visible = true;
        txtMRP.Visible = true;
        ddlitemdiscountType.Visible = true;
        txtdiscountvalue.Visible = true;
        ddlitemdiscountReson.Visible = true;
        textdiscountAmount.Visible = true;
    }

    private void LoadItemlevelDiscountValue()
    {
        try
        {

            long retCode = -1;
            List<DiscountMaster> getDiscount = new List<DiscountMaster>();
            Patient_BL patBL = new Patient_BL(base.ContextInfo);
            retCode = patBL.GetLabDiscount(OrgID, out getDiscount);


            ddlitemdiscountType.DataSource = getDiscount;
            ddlitemdiscountType.DataTextField = "DiscountName";
            ddlitemdiscountType.DataValueField = "DiscountReason";
            ddlitemdiscountType.DataBind();
            ddlitemdiscountType.Items.Insert(0, new ListItem(strSelect.Trim(), "0"));
        }
        catch (Exception ex)
        {
            CLogger.LogError("Error While  LoadItemlevelDiscountValue()", ex);
        }
    }

    private void LoadItemLevelDiscountReason()
    {
        try
        {
            long returnCode = -1;
            List<ReasonMaster> lstReasonMaster = new List<ReasonMaster>();
            Master_BL objReasonMaster = new Master_BL(base.ContextInfo);
            returnCode = objReasonMaster.GetReasonMaster(0, 0, "DIS", out lstReasonMaster);
            
                if (lstReasonMaster.Count > 0)
                {
                    
                   ddlitemdiscountReson.DataSource = lstReasonMaster;
                    ddlitemdiscountReson.DataTextField = "Reason";
                    ddlitemdiscountReson.DataValueField = "ReasonCode";
                    ddlitemdiscountReson.DataBind();
                    ddlitemdiscountReson.Items.Insert(0, new ListItem(strSelect.Trim(), "0"));
                }
            }
        
        catch (Exception ex)
        {
            CLogger.LogError("Error While LabQuickBilling_ReasonMaster LoadItemLevelDiscountReason()", ex);
        }
    }

    #endregion

    #region "Methods"

    private void HealthCouponSetup()
    {
        try
        {
            string strOrgHealthecoupon = string.Empty;

            if (Session["HasHealthCard"] != null)
            {
                strOrgHealthecoupon = Session["HasHealthCard"].ToString();
                hdnOrgHealthCoupon.Value = strOrgHealthecoupon;
            }

            sHasMyCard = GetConfigValue("HasMyCard", OrgID);
            if (sHasMyCard != "")
                hdnHasMyCard.Value = sHasMyCard;
            if (hdnHasMyCard.Value == "Y" && hdnIsCashClient.Value == "Y" && strOrgHealthecoupon == "Y")
            {
                string[] sPath = HttpContext.Current.Request.Url.AbsolutePath.Split('/');
                if (sPath[3] != "ClientBilling.aspx")
                {

                    dvHealhcard.Style.Add("display", "block");
                    //CheckMyCard
                    ScriptManager.RegisterStartupScript(Page, this.GetType(), "CheckMyCard", "javascript:CheckMyCard();", true);
                }
                else
                {

                    dvHealhcard.Style.Add("display", "none");
                }
            }
            else
            {

                dvHealhcard.Style.Add("display", "none");
            }


            string showAddAttributes = GetConfigValue("ShowAttributes", OrgID);

            if (showAddAttributes == "Y")
            {
                //tdAttributes.Style.Add("display", "table-cell");
            }
            else
            {
                tdAttributes.Style.Add("display", "none");
            }
            ZeroAmount.Value = GetConfigValue("IsZeroAmountTest", OrgID);
        }
        catch
        {
        }
    }
    public string PassGetAttributeItems()
    {
        string temphdnAttributesList = hdnAttributesList.Value;
        hdnAttributesList.Value = "";
        return temphdnAttributesList;

        //return hdnAttributesList.Value.ToString();
    }

    public void HidePaymentPart()
    {
        string strServiceQuotation = Resources.CommonControls_ClientDisplay.CommonControls_BillingPart_ascx_01 == null ? "Service Quotation Details" : Resources.CommonControls_ClientDisplay.CommonControls_BillingPart_ascx_01;
        string strHomeCollection = Resources.CommonControls_ClientDisplay.CommonControls_BillingPart_ascx_02 == null ? "Home Collection" : Resources.CommonControls_ClientDisplay.CommonControls_BillingPart_ascx_02;

        if (BillingPageType == "Client")
        {
            divPaymentType.Style.Add("display", "none");
            trAmountReceived.Style.Add("display", "none");
            tdPreviousDue.Style.Add("display", "none");
        }
        if (BillingPageType == "Service")
        {
            divPaymentType.Style.Add("display", "none");
            trAmountReceived.Style.Add("display", "none");
            tdPreviousDue.Style.Add("display", "none");
            trDiscountPart.Style.Add("display", "none");
            tdDiscReason.Style.Add("display", "none");
            trAuthorisedBy.Style.Add("display", "none");
            trRSTax.Style.Add("display", "none");
            trHistory.Style.Add("display", "none");
            trRemarks.Style.Add("display", "none");
            trDisAmount.Style.Add("display", "none");
            trServiceCharge.Style.Add("display", "none");
            trTaxAmountPart.Style.Add("display", "none");
            trRsEDSChess.Style.Add("display", "none");
            trRssHEDChess.Style.Add("display", "none");
            trRoundOffAmount.Style.Add("display", "none");
            hdnIsBillable.Value = "N";
            tdAttributes.Style.Add("display", "none");
            dvHealhcard.Style.Add("display", "none");
            LnkAttributes.Style.Add("display", "none");
            LnkHistory.Style.Add("display", "none");
            PanelHistory.Style.Add("display", "none");           
            tdBillDetails.Style.Add("display", "none");
            tdGrossBillDetails.Style.Add("display", "none");
            BillingPanel1.GroupingText = strServiceQuotation.Trim();
        }
        if (BillingPageType == "HomeCollection")
        {
            divPaymentType.Style.Add("display", "none");
            trAmountReceived.Style.Add("display", "none");
            //tdPreviousDue.Style.Add("display", "none");
            trDiscountPart.Style.Add("display", "none");
            tdDiscReason.Style.Add("display", "none");
            trAuthorisedBy.Style.Add("display", "none");
            trRSTax.Style.Add("display", "none");
            trHistory.Style.Add("display", "none");
            trRemarks.Style.Add("display", "none");
            trDisAmount.Style.Add("display", "none");
            trServiceCharge.Style.Add("display", "none");
            trTaxAmountPart.Style.Add("display", "none");
            trRsEDSChess.Style.Add("display", "none");
            trRssHEDChess.Style.Add("display", "none");
            trRoundOffAmount.Style.Add("display", "none");
            trNetValue.Style.Add("display", "none");
            trDue.Style.Add("display", "none");
            hdnIsBillable.Value = "N";
            BillingPanel1.GroupingText = strHomeCollection.Trim();
        }
    }
    public void LoadFeeType()
    {
        #region Load FeeTypes
        long returnCode = -1;
        List<FeeTypeMaster> lstFTM = new List<FeeTypeMaster>();
        returnCode = new BillingEngine(base.ContextInfo).GetFeeType(OrgID, vType, out lstFTM);
        if (lstFTM.Count > 0)
        {
            rblFeeTypes.DataSource = lstFTM;
            rblFeeTypes.DataTextField = "FeeTypeDesc";
            rblFeeTypes.DataValueField = "FeeType";
            rblFeeTypes.DataBind();
            rblFeeTypes.SelectedIndex = 0;
            hdnFeeType1.Value = rblFeeTypes.SelectedValue.ToString();
        }
        AutoCompleteExtender3.ContextKey = hdnFeeType1.Value.ToString() + "~" + OrgID.ToString() + "~" + 0.ToString() + "~" + hndLocationID.Value.ToString();
        //BillingAutoComplete.ContextKey = hdnFeeType1.Value.ToString() + "~" + OrgID.ToString() + "~" + 0.ToString() + "~" + hndLocationID.Value.ToString();
        #endregion
    }
    private void LoadTax()
    {
        List<Taxmaster> lstTaxmaster = new List<Taxmaster>();
        Master_BL masterBL = new Master_BL(base.ContextInfo);
        returnCode = masterBL.GetTaxMaster(OrgID, out lstTaxmaster);
        if (lstTaxmaster.Count > 0)
        {
            lstTaxmaster.RemoveAll(p => p.ReferenceName != "Bill");
            var lstTax = from n in lstTaxmaster
                         select new
                         {
                             TaxName = n.TaxName + "~" + n.TaxPercent,
                             TaxPercent = n.TaxPercent
                         };
            ddlTaxPercent.DataSource = lstTax;
            ddlTaxPercent.DataTextField = "TaxName";
            ddlTaxPercent.DataValueField = "TaxPercent";
            ddlTaxPercent.DataBind();
            ddlTaxPercent.Items.Insert(0, new ListItem(strSelect.Trim(), "0"));
        }
        else
        {
            ddlTaxPercent.Items.Insert(0, new ListItem(strSelect.Trim(), "0"));
        }
    }
    private void LoadReasonList()
    {
        try
        {
            long returnCode = -1;
            List<ReasonMaster> lstReasonMaster = new List<ReasonMaster>();
            Master_BL objReasonMaster = new Master_BL(base.ContextInfo);
            returnCode = objReasonMaster.GetReasonMaster(0, 0, "DIS", out lstReasonMaster);
            if (hdnIsSlabDiscount.Value == "Y")
            {
                ddlDiscountReason.Items.Insert(0, new ListItem(strSelect.Trim(), "0"));

            }
            else
            {
                if (lstReasonMaster.Count > 0)
                {
                    ddlDiscountReason.DataSource = lstReasonMaster;
                    ddlDiscountReason.DataTextField = "Reason";
                    ddlDiscountReason.DataValueField = "ReasonCode";
                    ddlDiscountReason.DataBind();
                    ddlDiscountReason.Items.Insert(0, new ListItem(strSelect.Trim(), "0"));
                }
                else
                {
                    ddlDiscountReason.Items.Insert(0, new ListItem(strSelect.Trim(), "0"));
                }
            }
        }
        catch (Exception ex)
        {
            CLogger.LogError("Error While LabQuickBilling_ReasonMaster LoadReasonList()", ex);
        }
    }
    private void LoadDiscount()
    {
        try
        {
            long retCode = -1;
            Patient_BL patBL = new Patient_BL(base.ContextInfo);
            List<DiscountMaster> getDiscount = new List<DiscountMaster>();
            retCode = patBL.GetLabDiscount(OrgID, out getDiscount);
            if (retCode == 0)
            {

                string sVal = GetConfigValue("HaveMultipleDiscount", OrgID);
                hdnAllowMulDisc.Value = sVal;

                var lstDiscount = from n in getDiscount
                                  select new
                                  {  //DiscountName = n.DiscountName + "~" + n.Discount,
                                      //DiscountPercentage = n.DiscountPercentage,
                                      DiscountName = n.DiscountName,
                                      Discount = n.Discount,
                                      DiscountReason = n.DiscountReason
                                  };

                if (sVal == "Y")
                {
                    gvMultiDisTypes.DataSource = getDiscount;
                    gvMultiDisTypes.DataBind();
                }
                else
                {
                    ddDiscountPercent.DataSource = lstDiscount;
                    ddDiscountPercent.DataTextField = "DiscountName";
                    ddDiscountPercent.DataValueField = "DiscountReason";
                    ddDiscountPercent.DataBind();
                    ddDiscountPercent.Items.Insert(0, new ListItem(strSelect.Trim(), "0"));
                }



                if (getDiscount.Count > 0)
                {
                    if (sVal == "Y")
                    {
                        ddDiscountPercent.Style.Add("display", "none");
                        tdDiscountLabel.Style.Add("display", "table-cell");
                        btnDiscountPercent.Style.Add("display", "block");
                        tdDiscReason.Style.Add("display", "none");
                    }
                    else
                    {
                        ddDiscountPercent.Style.Add("display", "block");
                        tdDiscountLabel.Style.Add("display", "table-cell");
                        btnDiscountPercent.Style.Add("display", "none");
                        tdDiscReason.Style.Add("display", "table-row");
                    }
                }
                else
                {
                    ddDiscountPercent.Style.Add("display", "none");
                    tdDiscountLabel.Style.Add("display", "none");
                    btnDiscountPercent.Style.Add("display", "none");
                    tdDiscReason.Style.Add("display", "none");
                }
            }
            else
            {
                ddDiscountPercent.DataSource = null;
                ddDiscountPercent.DataBind();
                ddDiscountPercent.Items.Insert(0, strSelect.Trim());
                ddDiscountPercent.Items[0].Value = "select";
                ddDiscountPercent.Style.Add("display", "none");
                tdDiscountLabel.Style.Add("display", "none");
                btnDiscountPercent.Style.Add("display", "none");
                hdnAllowMulDisc.Value = string.Empty;
                btnDiscountPercent.Style.Add("display", "none");
            }

        }
        catch (Exception ex)
        {
            CLogger.LogError("Error While Loading Lab Discount Details.", ex);
        }
    }
    public DataTable GetAmountReceivedDetails()
    {
        DataTable dtAmountReceivedDet = null;
        PaymentType.GivenAmount = 0;
        PaymentType.BalanceAmount = 0;
        dtAmountReceivedDet = PaymentType.GetAmountReceivedDetails();
        return dtAmountReceivedDet;
    }

    public string GetPatientDiscountDetails()
    {
        string patientDiscountDtl = hdnDisPercentage.Value.ToString();
        return patientDiscountDtl;
    }

    public List<TaxBillDetails> getTaxDetails()
    {
        List<TaxBillDetails> lstTax = new List<TaxBillDetails>();
        if (hdfTax.Value != null)
        {
            foreach (string sValue in hdfTax.Value.ToString().Split('>'))
            {
                if (sValue != "" && sValue != "0.00")
                {
                    TaxBillDetails tTax = new TaxBillDetails();
                    tTax.TaxID = Convert.ToInt32(sValue.Split('~')[0].Split('#')[1]);
                    tTax.TaxPercent = Convert.ToDecimal(sValue.Split('~')[1]);
                    lstTax.Add(tTax);
                }
            }
        }
        return lstTax;

    }
    public void getUserControlValue()
    {
        RegexOptions options = RegexOptions.None;
        Regex regex = new Regex(@"[ ]{2,}", options);
        PatientHistory = regex.Replace(txtPatientHistory.Text, @" ");

        if (System.Text.RegularExpressions.Regex.IsMatch(txtPatientHistory.Text, @"\r\n"))
        {
            PatientHistory = PatientHistory.Replace("\r\n", " ");
        }
        Remarks = txtRemarks.Text.Trim();
        IsCreditBill = IsClientSelected == "Y" ? hdnIsCashClient.Value == "Y" ? "N" : "Y" : "N";
        lblPreviousDueText.Text = Convert.ToDecimal(PreviousDue).ToString();
    }
    public FinalBill GetFinalBillDetails(out List<VisitClientMapping> lstVisitClientMapping)
    {
        lstVisitClientMapping = new List<VisitClientMapping>();
        VisitClientMapping VisitClientMapping = new VisitClientMapping();
        FinalBill finalBill = new FinalBill();
        decimal AmountReceived = 0, Due = 0, pRoundOff = 0, dServiceCharge = 0, discount = 0, GrossValue = 0, NetValue = 0, TaxAmount = 0, RedeemPoints = 0, RedeemValue = 0;
        string gUID = string.Empty, finalPName = string.Empty, DiscountReason = string.Empty;
        int TPAID = 0;
        long FinalBillID = 0;
        decimal pNonMedicalAmtPaid = decimal.Zero;
        decimal pCoPayment = decimal.Zero;
        decimal pExcess = decimal.Zero;
        try
        {
            decimal.TryParse(hdnAmountReceived.Value, out AmountReceived);
            decimal.TryParse(hdnDue.Value, out Due);
            decimal.TryParse(hdnServiceCharge.Value, out dServiceCharge);
            decimal.TryParse(hdnDiscountAmt.Value, out discount);
            decimal.TryParse(hdnGrossValue.Value, out GrossValue);
            decimal.TryParse(hdnNetAmount.Value, out NetValue);
            decimal.TryParse(hdnTaxAmount.Value, out TaxAmount);
            decimal.TryParse(hdnRoundOff.Value, out pRoundOff);
            decimal.TryParse(hdnRedeemPoints.Value, out RedeemPoints);
            decimal.TryParse(hdnRedeemValue.Value, out RedeemValue);
            NetValue = GrossValue + TaxAmount - discount + dServiceCharge;
            finalBill.FinalBillID = FinalBillID;
            finalBill.OrgID = OrgID;
            finalBill.VisitID = patientVisitID;
            finalBill.StdDedID = 0;
            finalBill.OrgAddressID = ILocationID;
            finalBill.GrossBillValue = Convert.ToDecimal(hdnGrossValue.Value);
            finalBill.DiscountAmount = Convert.ToDecimal(hdnDiscountAmt.Value);
            finalBill.RedeemPoints = Convert.ToDecimal(hdnRedeemPoints.Value);
            finalBill.RedeemValue = Convert.ToDecimal(hdnRedeemValue.Value);
            if (hdnIsSlabDiscount.Value == "N")
            {
                finalBill.DiscountReason = ddlDiscountReason.SelectedItem.Value == "0" ? "" : ddlDiscountReason.SelectedItem.Text;
                ddlDiscountReason.SelectedItem.Value = "0";
                ddlDiscountReason.SelectedItem.Text = "--Select--";
                LoadReasonList();
            }
            else
            {
                if (hdnDiscountReason.Value != "0")
                {
                    string[] ddlDiscountReason = (hdnDiscountReason.Value).Split('~');
                    finalBill.DiscountReason = ddlDiscountReason[1];
                    hdnDiscountReason.Value = "0";
                }
                else
                {
                    finalBill.DiscountReason = "";
                }
            }
            hdnDiscountReason.Value = "0";
            finalBill.DiscountApprovedBy = Convert.ToInt64(hdnDiscountApprovedBy.Value);
            finalBill.RoundOff = pRoundOff;
            finalBill.ServiceCharge = dServiceCharge;
            finalBill.NetValue = Convert.ToDecimal(hdnNetAmount.Value);
            finalBill.AmountReceived = Convert.ToDecimal(hdnAmountReceived.Value);
            finalBill.Due = Due;
            VisitClientMapping.PreAuthAmount = 0;
            finalBill.TaxAmount = Convert.ToDecimal(hdnTaxAmount.Value);
            finalBill.IsCreditBill = IsClientSelected == "Y" ? hdnIsCashClient.Value == "Y" ? "N" : "Y" : "N";// txtClient.Text.Trim() == "" ? "N" : "Y";
            VisitClientMapping.ClientID = ClientID;
            VisitClientMapping.RateID = RateID;
            finalBill.ClientName = "";
            pCoPayment = Convert.ToDecimal(hdnTotalCopayment.Value);
            //VisitClientMapping.CoPayment = pCoPayment;
            VisitClientMapping.NonMedicalAmount = pNonMedicalAmtPaid;
            VisitClientMapping.PreAuthAmount = Convert.ToDecimal(hdnNetAmount.Value);

            finalBill.ExcessAmtRecd = pExcess;
            finalBill.CurrentDue = Due;
            finalBill.TaxAmount = txtTax.Text.Trim() == "" ? 0 : Convert.ToDecimal(txtTax.Text);
            finalBill.CreatedBy = LID;
            long dID = 0;
            Int64.TryParse(hdnDiscountID.Value, out dID);
            finalBill.DiscountID = dID;
            //finalBill.DespatchMode = DespatchMode;
            DateTime ReportCommitedDate = hdnReportCommitedDate.Value == "" ? Convert.ToDateTime("01/01/1753") : Convert.ToDateTime(hdnReportCommitedDate.Value);
            finalBill.TATDate = ReportCommitedDate;
            finalBill.EDCess = Convert.ToDecimal(hdnEDCess.Value);
            finalBill.SHEDCess = Convert.ToDecimal(hdnSHEDCess.Value);
            string DiscountPercent = "";
            if (hdnAllowMulDisc.Value != "Y")
            {
                 DiscountPercent = ddDiscountPercent.SelectedItem.Value;
                 bool IsFoc = false;
                 if (DiscountPercent != "" && DiscountPercent != "0")
                 {
                     string[] DiscountType = DiscountPercent.Split('~');
                     if (DiscountType[3] != "")
                     {
                         if (DiscountType[3] == "Foc")
                         {
                             IsFoc = true;
                         }
                     }
                 }
                 if (IsFoc) { finalBill.IsFoc = "YES"; }
                 else
                 {
                     finalBill.IsFoc = "NO";
                 }
            }

            

            VisitClientMapping.CopaymentPercent = Convert.ToDecimal(hdnCoPaymentPerCentage.Value);
            VisitClientMapping.CoPaymentLogic = Convert.ToInt32(hdnCoPaymentlogicID.Value);
            //VisitClientMapping.PreAuthApprovalNumber = listChild[11];
            //VisitClientMapping.ClientAttributes = listChild[12];
            //VisitClientMapping.IsAllMedical = listChild[4].ToUpper() == "TRUE" ? "Y" : "N";
            VisitClientMapping.ClaimLogic = Convert.ToInt32(hdnClaimID.Value);
            VisitClientMapping.ClaimAmount = Convert.ToDecimal(hdnClaim.Value);
            VisitClientMapping.CoPayment = pCoPayment;
            VisitClientMapping.Remarks = hdnCoPaymentType.Value;

            lstVisitClientMapping.Add(VisitClientMapping);
            return finalBill;
        }
        catch (Exception ex)
        {
            CLogger.LogError("Error while saving patient & Billing details in Lab Quick Bill.", ex);
            return finalBill;
        }
    }
    public List<PatientMembershipCardMapping> GetHeatthCardDetails()
    {
        PatientMembershipCardMapping objPMemberCard = new PatientMembershipCardMapping();
        List<PatientMembershipCardMapping> lstPatientHealthcard = new List<PatientMembershipCardMapping>();
        string otp = string.Empty;
        string strCardTyep = string.Empty;
        MyCardActiveDays = GetConfigValue("MyCardActiveDays", OrgID);

        strHealthCoupon = GetConfigValue("HealthcardCoupon", OrgID);
        bool CreditType = false;

        if (strHealthCoupon.ToString().Trim().ToUpper() == "Y" && ddDiscountPercent.SelectedIndex == 0 && hdnOrgHealthCoupon.Value == "Y" && hdnHasMyCard.Value == "Y" && hdnIsCashClient.Value == "Y")
        {


            if (rbNewCard.Checked == true)
            {
                if (hdnHealthCardOTP.Value == "Y")
                {
                    OTP objOtp = new OTP();
                    string userId = Convert.ToDateTime(new BasePage().OrgDateTimeZone).ToString();
                    otp = OTP.GetOTP(userId);
                }
                else
                {
                    objPMemberCard.OTP = "";
                }
                objPMemberCard.MyCardActiveDays = MyCardActiveDays;
                if (ddDiscountPercent.SelectedIndex == 0)
                {
                    objPMemberCard.MemebershipcardType = "MYCARD";
                    objPMemberCard.HasHealthCard = "Y";
                }

                if (rbNewCard.Checked == true)
                {
                    objPMemberCard.HealthCardType = "New";
                }
                else if (rbExistingCard.Checked == true)
                {
                    objPMemberCard.HealthCardType = "Existing";
                }
                else
                {
                    objPMemberCard.HealthCardType = "Not Applicable";
                }
                objPMemberCard.OTP = otp;
                objPMemberCard.Status = "Active";
                objPMemberCard.CreditRedeemTye = "";

                objPMemberCard.HasHealthCard = "Y";

            }
            else if (rbExistingCard.Checked == true)
            {
                string CreditRedeemType = string.Empty;
                objPMemberCard.Status = "Active";

                objPMemberCard.MemebershipcardType = "MYCARD";
                objPMemberCard.HasHealthCard = "Y";

                objPMemberCard.MyCardActiveDays = MyCardActiveDays;
                objPMemberCard.OTP = "";
                objPMemberCard.HealthCardType = "Existing";
                if (chkCredit.Checked == true)
                {
                    CreditRedeemType = "Credit";
                    if (hdnMycardDetails.Value != "0" && hdnMycardDetails.Value != "")
                    {
                        List<PatientMembershipCardMapping> lstmycardMapDetails = new List<PatientMembershipCardMapping>();
                        string lstMycardDetails = hdnMycardDetails.Value;
                        if (lstMycardDetails != "" && lstMycardDetails != "0")
                        {
                            JavaScriptSerializer serializer = new JavaScriptSerializer();
                            lstmycardMapDetails = serializer.Deserialize<List<PatientMembershipCardMapping>>(lstMycardDetails);
                            foreach (var lstCard in lstmycardMapDetails)
                            {
                                objPMemberCard.MembershipCardMappingID = lstCard.MembershipCardMappingID;
                            }
                        }
                    }
                }
                if (chkRedeem.Checked == true)
                {
                    CreditType = true;
                    if (CreditRedeemType == "")
                    {
                        CreditRedeemType = "Redeem";
                    }
                    else
                    {
                        CreditRedeemType = CreditRedeemType + "~" + "Redeem";
                    }
                    objPMemberCard.CreditRedeemTye = CreditRedeemType;
                    if (hdnMycardDetails.Value != "0" && hdnMycardDetails.Value != "")
                    {
                        List<PatientMembershipCardMapping> lstmycardMapDetails = new List<PatientMembershipCardMapping>();
                        string lstMycardDetails = hdnMycardDetails.Value;
                        if (lstMycardDetails != "" && lstMycardDetails != "0")
                        {
                            JavaScriptSerializer serializer = new JavaScriptSerializer();
                            lstmycardMapDetails = serializer.Deserialize<List<PatientMembershipCardMapping>>(lstMycardDetails);
                            foreach (var lstCard in lstmycardMapDetails)
                            {
                                objPMemberCard.MembershipCardMappingID = lstCard.MembershipCardMappingID;
                                objPMemberCard.TotalRedemPoints = lstCard.TotalRedemPoints;
                                objPMemberCard.TotalRedemValue = lstCard.TotalRedemValue;
                            }
                        }
                    }
                }
                if (CreditType == false)
                {
                    objPMemberCard.CreditRedeemTye = CreditRedeemType;
                }
            }
            else if (strHealthCoupon.ToString().Trim().ToUpper() == "Y" && ddDiscountPercent.SelectedIndex == 0 && hdnOrgHealthCoupon.Value == "Y" && hdnHasMyCard.Value == "Y" && hdnIsCashClient.Value == "Y")
            {

                string CreditRedeemType = string.Empty;
                if (hdnHealthCardOTP.Value == "Y")
                {
                    OTP objOtp = new OTP();
                    string userId = Convert.ToDateTime(new BasePage().OrgDateTimeZone).ToString();
                    otp = OTP.GetOTP(userId);
                }
                else
                {
                    objPMemberCard.OTP = "";
                }
                objPMemberCard.MyCardActiveDays = MyCardActiveDays;
                if (ddDiscountPercent.SelectedIndex == 0)
                {
                    objPMemberCard.MemebershipcardType = "MYCARD";
                    objPMemberCard.HasHealthCard = "Y";
                }


                objPMemberCard.HealthCardType = "HEALTHCOUPON";
                objPMemberCard.OTP = otp;
                objPMemberCard.Status = "Active";
                objPMemberCard.CreditRedeemTye = "";
                objPMemberCard.HasHealthCard = "Y";

                CreditType = true;
                if (CreditRedeemType == "")
                {
                    CreditRedeemType = "Redeem";
                }
                else
                {
                    CreditRedeemType = CreditRedeemType + "~" + "Redeem";
                }
                objPMemberCard.CreditRedeemTye = CreditRedeemType;
                if (hdnMycardDetails.Value != "0" && hdnMycardDetails.Value != "")
                {

                    List<PatientMembershipCardMapping> lstmycardMapDetails = new List<PatientMembershipCardMapping>();
                    string lstMycardDetails = hdnMycardDetails.Value;
                    if (lstMycardDetails != "" && lstMycardDetails != "0")
                    {
                        JavaScriptSerializer serializer = new JavaScriptSerializer();
                        lstmycardMapDetails = serializer.Deserialize<List<PatientMembershipCardMapping>>(lstMycardDetails);
                        foreach (var lstCard in lstmycardMapDetails)
                        {
                            objPMemberCard.MembershipCardMappingID = lstCard.MembershipCardMappingID;
                            objPMemberCard.TotalRedemPoints = lstCard.TotalRedemPoints;
                            objPMemberCard.TotalRedemValue = lstCard.TotalRedemValue;
                        }
                    }
                }

                if (CreditType == false)
                {
                    objPMemberCard.CreditRedeemTye = CreditRedeemType;
                }

            }

        }

        else
        {
            objPMemberCard.MyCardActiveDays = "0";
            objPMemberCard.MemebershipcardType = "";
            objPMemberCard.HealthCardType = "";
            objPMemberCard.Status = "";
            objPMemberCard.CreditRedeemTye = "";
            objPMemberCard.HasHealthCard = "N";
            objPMemberCard.TotalRedemPoints = 0;
            objPMemberCard.TotalRedemValue = 0;
            objPMemberCard.OTP = "0";

        }

        lstPatientHealthcard.Add(objPMemberCard);

        return lstPatientHealthcard;
    }

    public List<PatientDiscount> GetPatientDiscount()
    {
        PatientDiscount objPatientDiscount = new PatientDiscount();
        List<PatientDiscount> lstPatientDueChart = new List<PatientDiscount>();
        long dID = 0;
        Int64.TryParse(hdnDiscountID.Value, out dID);
        objPatientDiscount.DiscountID = dID;
        if (hdnIsSlabDiscount.Value == "Y")
        {
            if (ddDiscountPercent.SelectedValue != "0")
            {
                objPatientDiscount.DiscountName = ddDiscountPercent.SelectedItem.Text;
                string[] sDiscountCode = (ddDiscountPercent.SelectedItem.Value).Split('~');
                objPatientDiscount.DiscountCode = sDiscountCode[2];
            }
            if (hdnDiscountType.Value != "0")
                objPatientDiscount.DiscountType = hdnDiscountType.Value;
            if (hdnSlabPercentAndValue.Value != "0")
            {
                string[] sSlabPercentAndValue = (hdnSlabPercentAndValue.Value).Split('~');
                objPatientDiscount.SlabPercentage = Convert.ToDecimal(sSlabPercentAndValue[0]);
                objPatientDiscount.SlabCeilingValue = Convert.ToDecimal(sSlabPercentAndValue[1]);
                hdnSlabPercentAndValue.Value = "0";
            }
            else
            {
                objPatientDiscount.SlabCeilingValue = 0;
                objPatientDiscount.SlabPercentage = 0;
            }

            if (txtCeiling.Text != "")
                objPatientDiscount.UserDiscountValue = Convert.ToDecimal(txtCeiling.Text);
            if (hdnDiscountCeiling.Value != "0") { objPatientDiscount.DiscountCeilingValue = Convert.ToDecimal(hdnDiscountCeiling.Value); hdnDiscountCeiling.Value = "0"; }
            else
            {
                objPatientDiscount.DiscountCeilingValue = 0;
            }
        }
        else
        {

        }
        lstPatientDueChart.Add(objPatientDiscount);

        return lstPatientDueChart;

    }
    public void setRateId(string id)
    {
        hdnRtID.Value = "";
        hdnRtID.Value = id;
    }
    public List<PatientDueChart> GetBillingItems()//string feeType)
    {
        string prescription = string.Empty;
        string newPrescription = string.Empty;
        string dtoRemove = string.Empty;
        //long tempAdd=0;
        List<PatientDueChart> lstPatientDueChart = new List<PatientDueChart>();

        PatientDueChart objBilling;
        List<PatientDueChart> lstPatientDueChartDate = new List<PatientDueChart>();
        PatientDueChart objBillingDate;
        if (hdfBillType1.Value != null)
            prescription = hdfBillType1.Value.ToString();
        //CLogger.LogWarning(hdfBillType1.Value.ToString());
        string sNewDatas = "";
        sNewDatas = prescription;
        //DataRow dr;
        foreach (string row in sNewDatas.Split('|'))
        {
            objBilling = new PatientDueChart();
            objBillingDate = new PatientDueChart();
            if (row.Trim().Length != 0)
            {
                foreach (string column in row.Split('~'))
                {
                    string[] colNameValue;
                    string colName = string.Empty;
                    string colValue = string.Empty;
                    colNameValue = column.Split('^');
                    colName = colNameValue[0];
                    if (colNameValue.Length > 1)
                        colValue = colNameValue[1];
                    colValue = colValue.Trim();
                    List<string> StringDates = new List<string>();
                    switch (colName)
                    {
                        case "FeeID":
                            objBilling.FeeID = colValue == "" ? 0 : Convert.ToInt64(colValue);
                            break;

                        case "Descrip":
                            objBilling.Description = colValue;
                            break;
                        case "Amount":
                            //objBilling.BaseTestcalculationAmount = colValue == "" ? 0 : Convert.ToDecimal(colValue);
                            objBilling.Amount = colValue == "" ? 0 : Convert.ToDecimal(colValue);
                            if (Convert.ToInt64(hdnAutoCalcGenBillItemID.Value) == objBilling.FeeID)
                            {
                                objBilling.Amount = Convert.ToDecimal(hdnAutoCalcGenBillItemAmt.Value);
                            }
                            if (Convert.ToInt64(hdnStatAutoFeeID.Value) == objBilling.FeeID)
                            {
                                objBilling.Amount = Convert.ToDecimal(hdnStstFee.Value);
                            }
                            break;
                        case "Quantity":
                            objBilling.Unit = colValue == "" ? 0 : Convert.ToDecimal(colValue);
                            break;
                        case "FeeType":
                            if (colValue.ToUpper() == "LAB")
                            {
                                colValue = "INV";
                            }
                            objBilling.FeeType = colValue;
                            break;

                        case "IsReimbursable":
                            if (colValue == "Yes")
                            {
                                objBilling.IsReimbursable = "Y";
                            }
                            else
                            {
                                objBilling.IsReimbursable = "N";
                            }

                            break;

                        case "Remarks":
                            objBilling.Remarks = colValue;
                            break;
                        case "Gender":

                            break;
                        case "ActualAmount":
                            objBilling.ActualAmount = colValue == "" ? 0 : Convert.ToDecimal(colValue);
                            break;
                        case "IsTaxable":
                            objBilling.IsTaxable = colValue;
                            break;
                        case "RateID":
                            objBilling.RateID = colValue == "" ? 0 : Convert.ToInt64(colValue);
                            break;
                        case "IsDiscountable":
                            objBilling.IsDiscountable = colValue;
                            break;
                        case "IsSTAT":
                            objBilling.IsSTAT = colValue;
                            break;
                        case "IsOutSource":
                            objBilling.IsOutSource = colValue;
                            break;
                        case "IsNABL":
                            objBilling.IsNABL = colValue;
                            break;
                        case "ReportDate":
                            objBilling.TatDate = colValue == "" ? Convert.ToDateTime("01/01/1753") : Convert.ToDateTime(colValue);
                            break;
                        case "BillingItemRateID":
                            objBilling.RateID = colValue == "" ? 0 : Convert.ToInt32(colValue);
                            break;
                        //case "BaseRateID":
                        //    objBilling.BaseRateID = colValue == "" ? 0 : Convert.ToInt64(colValue);
                        //    break;
                        case "BaseRateID":
                            objBilling.BaseRateID = colValue == "" || colValue == "undefined" ? 0 : Convert.ToInt64(colValue);
                            break;

                        case "STATAmount":
                            objBilling.Amount = Convert.ToDecimal(hdnStstFee.Value);
                            objBilling.ActualAmount = Convert.ToDecimal(hdnStstFee.Value);
                            break;
                        case "DiscountPolicyID":
                            objBilling.DiscountPolicyID = colValue == "" ? 0 : Convert.ToInt64(colValue);
                            break;
                        case "DiscountCategoryCode":
                            objBilling.DiscountCategoryCode = colValue;
                            break;
                        case "ReportDeliveryDate":
                            objBilling.ReportDeliveryDate = colValue == "" ? Convert.ToDateTime("01/01/1753") : Convert.ToDateTime(colValue);
                            break;
                        case "DiscountValue":
                            objBilling.EligibleAmount = colValue == "" ? 0 : Convert.ToDecimal(colValue);
                            break;
                        case "ItemDiscountPercentage":
                            objBilling.CoSharing = colValue == "" ? 0 : Convert.ToDecimal(colValue);
                            break;
                        case "DiscountReason":
                            objBilling.Performertype = colValue;
                            break;
                        case "ClientRate":
                            objBilling.CoPayValue = colValue == "" ? 0 : Convert.ToDecimal(colValue);
                            break;
                            
                        
                       


                    };
                    if (hdnRtID.Value != "")
                    {
                        objBilling.RateID = Convert.ToInt16(hdnRtID.Value);
                    }
                    objBilling.Status = "Paid";
                    if (hdnBilledDate.Value != "")
                    {
                        objBilling.FromDate = Convert.ToDateTime(hdnBilledDate.Value);
                    }
                    else
                    {
                        objBilling.FromDate = Convert.ToDateTime(Convert.ToDateTime(new BasePage().OrgDateTimeZone).ToString("dd/MM/yyyy hh:mm tt"));
                    }
                    objBilling.ToDate = Convert.ToDateTime(Convert.ToDateTime(new BasePage().OrgDateTimeZone).ToString("dd/MM/yyyy hh:mm tt"));
                }

                string ShowItemLevelDiscount = GetConfigValue("NeedItemLevelDiscount", OrgID);
                if (ShowItemLevelDiscount == "Y")
                {
                    objBilling.Amount = objBilling.Amount + objBilling.EligibleAmount;
                }
                //if (objBilling.DiscountAmount <= 0)
                //{
                //    objBilling.DiscountAmount = 0;
                //}
                //if (ShowItemLevelDiscount == "Y")
                //{
                //    objBilling.DiscountAmount = objBilling.DiscountAmount + objBilling.EligibleAmount;
                //}

                lstPatientDueChart.Add(objBilling);
                lstPatientDueChartDate.Add(objBillingDate);

            }
        }
        List<PatientDueChart> lstItemDiscoutDetails = new List<PatientDueChart>();
        string lstItemsDiscountSlab = hdnDiscountSlab.Value;
        if (lstItemsDiscountSlab != "" && lstItemsDiscountSlab != "0")
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            lstItemDiscoutDetails = serializer.Deserialize<List<PatientDueChart>>(lstItemsDiscountSlab);
            foreach (var lstPatient in lstPatientDueChart)
            {
                foreach (var lstDiscount in lstItemDiscoutDetails)
                {
                    if (lstPatient.FeeID == lstDiscount.FeeID && lstPatient.FeeType == lstDiscount.FeeType)
                    {
                        lstPatient.DiscountAmount = lstDiscount.DiscountAmount;
                        lstPatient.DiscountPercent = lstDiscount.DiscountPercent;
                        lstPatient.FeeType = lstDiscount.FeeType;
                        lstPatient.MaxTestDisPercentage = lstDiscount.MaxTestDisPercentage;
                        lstPatient.MaxTestDisAmount = lstDiscount.MaxTestDisAmount;
                    }
                }
            }
        }
        List<PatientDueChart> lstItemsRedeemPoints = new List<PatientDueChart>();
        string lstHealthCardItems = hdnlstHealthCardItems.Value;
        if (lstHealthCardItems != "" && lstHealthCardItems != "0")
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            lstItemsRedeemPoints = serializer.Deserialize<List<PatientDueChart>>(lstHealthCardItems);
            foreach (var lstItem in lstPatientDueChart)
            {
                foreach (var lstRedeem in lstItemsRedeemPoints)
                {
                    if (lstItem.FeeID == lstRedeem.FeeID)
                    {

                        lstItem.IsRedeem = lstRedeem.IsRedeem;
                        lstItem.RedeemAmount = lstRedeem.RedeemAmount;
                        lstItem.RedeemPoints = lstRedeem.RedeemPoints;
                    }
                }
            }
        }


        if (lstPatientDueChartDate.Count > 0)
        {
            hdnReportCommitedDate.Value = lstPatientDueChartDate.Max(date => date.CreatedAt).ToString();
        }
        return lstPatientDueChart;
    }
    public List<OrderedInvestigations> GetOrderedInvestigations(long visitID, out string gUID)
    {
        string prescription = string.Empty;
        string newPrescription = string.Empty;
        string dtoRemove = string.Empty;
        gUID = Guid.NewGuid().ToString();

        List<OrderedInvestigations> lstOrderedInvestigations = new List<OrderedInvestigations>();
        //long tempAdd = 0;
        OrderedInvestigations PatientInves;
        if (hdfBillType1.Value != null)
            prescription = hdfBillType1.Value.ToString();

        //CLogger.LogWarning(hdfBillType1.Value.ToString());
        string sNewDatas = "";
        sNewDatas = prescription;
        string sVal = GetConfigValue("SampleCollect", OrgID);
        int SeqNo = 0;
        foreach (string row in sNewDatas.Split('|'))
        {
            PatientInves = new OrderedInvestigations();
            SeqNo = SeqNo + 1;
            if (row.Trim().Length != 0)
            {
                foreach (string column in row.Split('~'))
                {
                    string[] colNameValue;
                    string colName = string.Empty;
                    string colValue = string.Empty;
                    colNameValue = column.Split('^');
                    colName = colNameValue[0];
                    if (colNameValue.Length > 1)
                        colValue = colNameValue[1];

                    //"RID^" + 0 + "~FeeType^" + FeeType + "~FeeID^" + FeeID + "~OtherID^" + OtherID + "~Descrip^" + Descrip + "~Quantity^" + Quantity + "~Amount^" + Amount + "~Total^" + Total + "";
                    colValue = colValue.Trim();

                    switch (colName)
                    {
                        case "FeeID":
                            colValue = colValue == "" ? "0" : colValue;
                            PatientInves.ID = Convert.ToInt64(colValue);
                            break;
                        case "Descrip":
                            PatientInves.Name = colValue;
                            break;
                        case "Amount":
                            colValue = colValue == "" ? "0" : colValue;
                            PatientInves.Rate = Convert.ToDecimal(colValue);
                            break;
                        case "FeeType":

                            PatientInves.Type = colValue;
                            break;
                        case "refType":
                            PatientInves.ReferenceType = colValue;
                            break;
                        case "refPhyID":
                            if (colValue != null && colValue != "")
                            {
                                PatientInves.RefPhysicianID = Int64.Parse(colValue);
                            }
                            break;
                        case "refPhyName":
                            PatientInves.RefPhyName = colValue;
                            break;


                    };

                }
                //if (tempAdd == 0)
                //{
                PatientInves.UID = gUID;
                PatientInves.StudyInstanceUId = CreateUniqueDecimalString();
                PatientInves.VisitID = visitID;
                PatientInves.OrgID = OrgID;
                PatientInves.PaymentStatus = "Paid";
                PatientInves.Status = "Ordered";
                PatientInves.CreatedBy = LID;
                PatientInves.SequenceNo = SeqNo;
                if (sVal.Trim() == "N")
                {
                    PatientInves.Status = "Paid";
                }

                if (PatientInves.Type == "INV" || PatientInves.Type == "GRP" || PatientInves.Type == "PKG")
                {
                    lstOrderedInvestigations.Add(PatientInves);
                }
            }
        }
        return lstOrderedInvestigations;
    }
    public List<VisitTemplate> GetVisitTemplateData()
    {
        string templatevalues = string.Empty;
        string text = hdnTemplateValue.Value;
        if (hdnTemplateValue.Value != null)
            templatevalues = hdnTemplateValue.Value.ToString();
        VisitTemplate templates;
        List<VisitTemplate> lstOrderedInvestigations = new List<VisitTemplate>();
        string sNewDatas = "";
        sNewDatas = templatevalues;
        string sVal = GetConfigValue("SampleCollect", OrgID);
        int SeqNo = 0;
        foreach (string row in sNewDatas.Split('|'))
        {
            templates = new VisitTemplate();
            SeqNo = SeqNo + 1;
            if (row.Trim().Length != 0)
            {
                foreach (string column in row.Split('~'))
                {
                    string[] colNameValue;
                    string colName = string.Empty;
                    string colValue = string.Empty;
                  
                    colNameValue = column.Split('^');
                   templates.FeeID= Convert.ToInt64(colNameValue[0]);
                   templates.TemplateID = Convert.ToInt64(colNameValue[1]);
                   templates.FeeType = colNameValue[2];
                   templates.TemplateData = colNameValue[3];
                    //if (colNameValue.Length > 1)
                    //    colValue = colNameValue[1];

                    ////"RID^" + 0 + "~FeeType^" + FeeType + "~FeeID^" + FeeID + "~OtherID^" + OtherID + "~Descrip^" + Descrip + "~Quantity^" + Quantity + "~Amount^" + Amount + "~Total^" + Total + "";
                    //colValue = colValue.Trim();

                    //switch (colName)
                    //{
                    //    case "FeeID":
                    //        colValue = colValue == "" ? "0" : colValue;
                    //        templates.FeeID = Convert.ToInt64(colValue);
                    //        break;
                    //    case "FeeType":
                    //        colValue = colValue == "" ? "0" : colValue;
                    //        templates.FeeType = colValue;
                    //        break;
                    //    case "IsTemplateID":
                    //        colValue = colValue == "" ? "0" : colValue;
                    //        templates.TemplateID = Convert.ToInt64(colValue);
                    //        break;
                    //    //case "IsTemplateText":
                    //    //    colValue = colValue == "" ? "0" : colValue;
                    //    //    templates.TemplateData=hdnTemplateValue.Value;
                    //    // //   templates.TemplateData = colValue;
                    //    //    break;


                    //};

                }
               // templates.TemplateData = hdnTemplateValue.Value;
                templates.OrgID = OrgID;

                if (templates.FeeType == "INV" || templates.FeeType == "GRP" || templates.FeeType == "PKG")
                {
                    lstOrderedInvestigations.Add(templates);
                }
            }
        }
            return lstOrderedInvestigations;


        
    }
    private string CreateUniqueDecimalString()
    {
        string uniqueDecimalString = "1.2.840.113619.";
        uniqueDecimalString += GetUniqueKey() + ".";
        uniqueDecimalString += GetUniqueKey();
        return uniqueDecimalString;
    }
    private string GetUniqueKey()
    {
        int maxSize = 10;
        char[] chars = new char[62];
        string a;
        //a = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
        a = "0123456789012345678901234567890123456789012345678901234567890123456789";
        chars = a.ToCharArray();
        int size = maxSize;
        byte[] data = new byte[1];
        RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
        crypto.GetNonZeroBytes(data);
        size = maxSize;
        data = new byte[size];
        crypto.GetNonZeroBytes(data);
        StringBuilder result = new StringBuilder(size);
        foreach (byte b in data)
        { result.Append(chars[b % (chars.Length - 1)]); }
        return result.ToString();
    }
    public string GetConfigValue(string configKey, int orgID)
    {
        string configValue = string.Empty;
        long returncode = -1;
        GateWay objGateway = new GateWay(base.ContextInfo);
        List<Config> lstConfig = new List<Config>();

        returncode = objGateway.GetConfigDetails(configKey, orgID, out lstConfig);
        if (lstConfig.Count > 0)
            configValue = lstConfig[0].ConfigValue;

        return configValue;
    }
    public void clearControlValues()
    {
        hdnDiscountApprovedBy.Value = "0";
        hdnIsCashClient.Value = "Y";
        hdnReportCommitedDate.Value = "";
        hdfBillType1.Value = "";
        hndLocationID.Value = ILocationID.ToString();
        hdnFeeTypeSelected.Value = "COM";
        hdnName.Value = "";
        hdnAmt.Value = "0";
        hdnID.Value = "";
        hdnReportDate.Value = "";
        hdnRemarks.Value = "";
        hdnIsRemimbursable.Value = "";
        hdnPaymentControlReceivedtemp.Value = "0.00";
        hdnActualAmount.Value = "0";
        hdnIsDiscount.Value = "N";
        hdnIsDiscountableTest.Value = "Y";
        hdnIsTaxable.Value = "Y";
        hdnIsRepeatable.Value = "N";
        hdnIsSTAT.Value = "N";
        hdnIsSMS.Value = "N";
        hdnIsOutSource.Value = "N";
        hdnDiscountableTestTotal.Value = "0";
        hdnTaxableTestToal.Value = "0";
        hdnIsNABL.Value = "N";
        hdnBillingItemRateID.Value = "0";
        hdnInvCode.Value = "0";
        hdnOrgIDC.Value = OrgID.ToString();
        hdnCeilingValue.Value = "0";
        hdnMaxDiscount.Value = "0";
        hdnItems.Value = "0";
        hdnItemLevelPercent.Value = "0";
        hdnItemLevelTotalPercent.Value = "0";
        hdnIsNormalRateCard.Value = "0";
        hdnDiscountSlab.Value = "0";
        hdnIsInvestigationAdded.Value = "0";
        hdnDiscountCeiling.Value = "0";
        hdnSlabPercentAndValue.Value = "0";
        hdnDiscountType.Value = "0";
        txtCeiling.Text = "";
        // hdnHasMyCard.Value = "";
        hdnExistingPatientID.Value = "0";
        hdnMycardDetails.Value = "";
        hdnRedeemPoints.Value = "0";
        hdnRedeemValue.Value = "0";
        hdnMembershipCardMappingID.Value = "0";
        hdnOtpExist.Value = "0";
        hdnHealthCardItems.Value = "";
        hdnlstHealthCardItems.Value = "";
        txtCardNo.Text = "";
        txtOTP.Text = "";

        chkRedeem.Checked = false;
        chkCredit.Checked = false;
        rbExistingCard.Checked = false;
        rbNewCard.Checked = false;
        txtCardNo.Text = "";
        lblCreditPoints.Text = "";
        lblCreditValue.Text = "";
        hdnTotalRedeemPoints.Value = "";
        hdnTotalRedeemAmount.Value = "";
        hdntotalredemPoints.Value = "";

    }
    public List<InvHistoryAttributes> GetHistoryItems()
    {
        string History = string.Empty;
        string newPrescription = string.Empty;
        string dtoRemove = string.Empty;

        List<InvHistoryAttributes> lstInvHistoryAttributes = new List<InvHistoryAttributes>();
        InvHistoryAttributes objHistoryAttributes;
            try
            {
        if (hdnHistoryTableList.Value != null)
        {
            History = hdnHistoryTableList.Value.ToString();
        }
        if (hdnHistoryTableLists.Value != null)
        {
            History += '|' + hdnHistoryTableLists.Value.ToString();
        }

        if (hdnHistoryTableListsP.Value != null)
        {
            History += '|' + hdnHistoryTableListsP.Value.ToString();
        }
        //CLogger.LogWarning(hdnHistoryTableList.Value.ToString());
        string sNewDatas = "";
        sNewDatas = History;

        foreach (string row in sNewDatas.Split('|'))
        {
            objHistoryAttributes = new InvHistoryAttributes();

            if (row.Trim().Length != 0)
            {
                foreach (string column in row.Split('~'))
                {
                    string[] colNameValue;
                    string colName = string.Empty;
                    string colValue = string.Empty;
                    colNameValue = column.Split('^');
                    colName = colNameValue[0];
                    if (colNameValue.Length > 1)
                        colValue = colNameValue[1];
                    colValue = colValue.Trim();
                        if (colValue == "NaN")
                        {
                            colValue = string.Empty;
                        }
                    List<string> StringDates = new List<string>();
                    switch (colName)
                    {
                        case "InvestigationID":
                            objHistoryAttributes.InvestigationID = colValue == "" ? 0 : Convert.ToInt64(colValue);
                            break;

                        case "HistoryID":
                            objHistoryAttributes.HistoryID = colValue == "" ? 0 : Convert.ToInt64(colValue);
                            break;
                        case "HistoryName":
                            objHistoryAttributes.HistoryName = colValue;
                            objHistoryAttributes.Description = colValue;
                            break;
                        case "AttributeID":
                            objHistoryAttributes.AttributeID = colValue == "" ? 0 : Convert.ToInt64(colValue);
                            break;
                        case "Type":
                            objHistoryAttributes.Type = colValue;
                            break;

                        case "HasAttribute":
                            objHistoryAttributes.HasAttribute = colValue;
                            break;

                        case "AttributeName":
                            objHistoryAttributes.AttributeName = colValue;
                            break;
                        case "AttributevalueID":
                            objHistoryAttributes.AttributevalueID = colValue == "" ? 0 : Convert.ToInt64(colValue);
                            break;
                        case "AttributeValueName":
                            objHistoryAttributes.AttributeValueName = colValue;
                            break;

                    };
                }

                lstInvHistoryAttributes.Add(objHistoryAttributes);


            }
            }
        }
        catch (Exception ex)
        {

            CLogger.LogError("Error While getting list from capture history billing part", ex);
        }

        return lstInvHistoryAttributes;
    }
    public List<PatientRedemDetails> redeemPointsDetails()
    {
        List<PatientRedemDetails> lstPatientRedemDetails = new List<PatientRedemDetails>();
        PatientRedemDetails PatientRedeem = new PatientRedemDetails();
        decimal redemAmt = 0;
        if (hdnMycarddetailsSave.Value != "")
        {
            string[] strMycardDetails = hdnMycarddetailsSave.Value.TrimEnd('|').Split('|');

            for (int i = 0; i <= strMycardDetails.Length - 1; i++)
            {


                PatientRedeem = new PatientRedemDetails();
                PatientRedeem.Finalbillid = 0;
                PatientRedeem.MembershipCardMappingID = Convert.ToInt32(strMycardDetails[i].Split('~')[0].ToString());
                PatientRedeem.PatientID = Convert.ToInt64(strMycardDetails[i].Split('~')[1].ToString());
                PatientRedeem.RedemPoints = Convert.ToDecimal(strMycardDetails[i].Split('~')[2].ToString());
                PatientRedeem.RedemValue = Convert.ToDecimal(strMycardDetails[i].Split('~')[3].ToString()); ;
                PatientRedeem.VisitID = 0;
                lstPatientRedemDetails.Add(PatientRedeem);
                //}
                //else
                //{
                //    redemAmt = redemAmt + Convert.ToDecimal(strMycardDetails[i].Split('~')[3].ToString());
                //    if (redemAmt > Convert.ToDecimal(txtGross.Text))
                //    {
                //        PatientRedeem = new PatientRedemDetails();
                //        PatientRedeem.Finalbillid = 0;
                //        PatientRedeem.MembershipCardMappingID = Convert.ToInt32(strMycardDetails[i].Split('~')[0].ToString());
                //        PatientRedeem.PatientID = Convert.ToInt64(strMycardDetails[i].Split('~')[1].ToString());
                //        PatientRedeem.RedemPoints = Convert.ToDecimal(strMycardDetails[i].Split('~')[2].ToString());
                //        PatientRedeem.RedemValue = Convert.ToDecimal(strMycardDetails[i].Split('~')[3].ToString()); ;
                //        PatientRedeem.VisitID = 0;
                //        lstPatientRedemDetails.Add(PatientRedeem);
                //    }
                //    else
                //    {
                //        PatientRedeem = new PatientRedemDetails();
                //        PatientRedeem.Finalbillid = 0;
                //        PatientRedeem.MembershipCardMappingID = Convert.ToInt32(strMycardDetails[i].Split('~')[0].ToString());
                //        PatientRedeem.PatientID = Convert.ToInt64(strMycardDetails[i].Split('~')[1].ToString());
                //        PatientRedeem.RedemPoints = Convert.ToDecimal(strMycardDetails[i].Split('~')[2].ToString());
                //        PatientRedeem.RedemValue = Convert.ToDecimal(strMycardDetails[i].Split('~')[3].ToString()); ;
                //        PatientRedeem.VisitID = 0;
                //        lstPatientRedemDetails.Add(PatientRedeem);
                //    }

                //}
            }
        }
        return lstPatientRedemDetails;
    }

    public void QuotationRegistrationDisplay()
    {
        // divOrder.d

        divOrder.Style.Add("display", "none");
        //  tbCountry.Style.Add("display", "none");
        txtServiceCharge.Style.Add("display", "none");
        trRsEDSChess.Style.Add("display", "none");
        trRssHEDChess.Style.Add("display", "none");
        trHistory.Style.Add("display", "none");

        trRemarks.Style.Add("display", "none");
        Td3.Style.Add("display", "none");
        PanelHistory.Style.Add("display", "none");
        PanelAttributes.Style.Add("display", "none");
        table_GroupItem.Style.Add("display", "none");
        Panel1.Style.Add("display", "none");
        PanelGroup.Style.Add("display", "none");
        //ddDiscountPercent.Style.Add("display", "block");
        //ddlDiscountReason.Style.Add("display", "block");
        //ddlTaxPercent.Style.Add("display", "block");
        //txtAuthorised.Style.Add("display", "block");
        ddDiscountPercent.Enabled = true;
        ddlDiscountReason.Enabled = true;
        ddlTaxPercent.Enabled = true;
        txtAuthorised.Enabled = true;





    }

    #endregion
}
