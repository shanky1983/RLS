﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Resources;
using System.Text;
using Attune.Podium.BusinessEntities;
using Attune.Solution.BusinessComponent;
using System.Data;
using Attune.Podium.Common;
using Attune.Podium.BillingEngine;

public partial class Admin_POSBillSettlement : BasePage
{
    public Admin_POSBillSettlement()
        : base("Admin_POSBillSettlement_aspx")
    {
    }
    #region VariableDecleration
    BillingEngine objBillingEngine;
    List<ReceivedAmount> lstAmountReceivedDetails = new List<ReceivedAmount>();
    List<ReceivedAmount> lstAmountRefundDetails = new List<ReceivedAmount>();
    List<Users> lstUsers = new List<Users>();
    List<AmountClosureDetails> lstAmountClosure = new List<AmountClosureDetails>();
    List<ReceivedAmount> lstINDAmtReceivedDetails = new List<ReceivedAmount>();
    List<ReceivedAmount> lstSplitDetails = new List<ReceivedAmount>();
    List<CurrencyOrgMapping> lstCurrencyInHand = new List<CurrencyOrgMapping>();
    List<CashClosureDenomination> lstCCDeno = new List<CashClosureDenomination>();
    List<CashClosureDenominationDetail> lstCCDenoDetail = new List<CashClosureDenominationDetail>();
    List<CashClosureDenominationDetail> lstCCDenoDetails = new List<CashClosureDenominationDetail>();
    decimal totalAmount = 0;
    decimal refundAmount = 0; decimal cancellationAmount = 0;
    decimal drAmount = 0;
    decimal othersAmount = 0;
    decimal TotalIncAmount = 0;
    decimal TotalPendingSettledAmount = 0;
    string sstatus = string.Empty;
    int ICreatedforUserID = 0;
    long retval = -1;
    string sAllAmtReceivedID = string.Empty;
    int flag = 0;
    DateTime pFDT, pTDT;

    string strAll = Resources.Admin_ClientDisplay.Admin_DaywiseCollection_aspx_04 == null ? "-----All-----" : Resources.Admin_ClientDisplay.Admin_DaywiseCollection_aspx_04;



    #endregion

    #region pageLoad
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {

            pFDT = Convert.ToDateTime(new BasePage().OrgDateTimeZone);
            pTDT = Convert.ToDateTime(new BasePage().OrgDateTimeZone);

            txtFromDate1.Text = pFDT.ToString("dd/MM/yyyy");
            txtToDate.Text = pTDT.ToString("dd/MM/yyyy");
            LoadLocation();
            BindListofUsers();
            btnSearch_click(sender, e);
            List<Config> lstconfig = new List<Config>();
            new GateWay(base.ContextInfo).GetConfigDetails("CashClosureDescription", OrgID, out lstconfig);
            if (lstconfig.Count > 0 && lstconfig[0].ConfigValue == "N")
                hdnNeedDescription.Value = "N";
            new GateWay(base.ContextInfo).GetConfigDetails("IsCashClosureDeno", OrgID, out lstconfig);
            if (lstconfig.Count > 0 && lstconfig[0].ConfigValue == "Y")
            {
                pnlPayments.Visible = false;
                
                pnlCashIncomeDetails.Visible = false;
            }
        }
        if (OrgID != 11)
        {
            Panel1.Visible = false;
            Panel2.Visible = false;
        }
    }

    protected void gvAllUsers_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "UserLink")
        {
            string userID = e.CommandArgument.ToString();
            ddlUser.SelectedIndex = ddlUser.Items.IndexOf(ddlUser.Items.FindByValue(userID));
            btnSearch_click(sender, e);
        }


    }

 
    #endregion

    #region Custom Functions
    //public void loadUserRole(long loginid)
    //{
    //    long returncode = -1;
    //    GateWay gateway = new GateWay(base.ContextInfo);
    //    Attune.Podium.BusinessEntities.Login login = new Attune.Podium.BusinessEntities.Login();
    //    login.LoginID = loginid;
    //    List<Role> lstuserroles = new List<Role>();
    //    returncode = gateway.GetRoles(login, out lstuserroles);
    //    List<Role> lstRoles = new List<Role>();
    //    lstRoles = (from child in lstuserroles
    //                where child.OrgID == OrgID
    //                orderby child.Description
    //                select new Role { RoleName = child.RoleID + "~" + child.RoleName, Description = child.Description }).Distinct().ToList();

    //    if (lstuserroles.Count > 0)
       
    //   //lstRoles   = lstRoles.Find(O => O.RoleName == Attune.Podium.Common.RoleHelper.Reception);
    //        ddlRoles.DataSource = lstuserroles;
    //        ddlRoles.DataTextField = "Description";
    //        ddlRoles.DataValueField = "RoleName";
    //        ddlRoles.DataBind();
    //        ddlRoles.Items.Insert(0, new ListItem("Select", "0"));
    //        ddlRoles.SelectedValue = "0";// Convert.ToString(lstuserroles[0].RoleID);
    //        returncode = -1;

    //    }
    //}
    protected void BindListofUsers()
    {
        objBillingEngine = new BillingEngine(base.ContextInfo);
        long iOrgID = Int64.Parse(OrgID.ToString());
        retval = objBillingEngine.GetListOfUsersForCollection(OrgID, out lstUsers);
        ddlUser.Items.Clear();
        if (retval == 0)
        {


            if (RoleName == "LabReception")
            { 
               var lst=lstUsers.FindAll(c => c.UserID == LID).ToList();
		  
                if (lst!=null && lst.Count()>0){ 
		 var UserName = lstUsers.Single(c => c.UserID ==  LID ).Name;
                 var UserID = lstUsers.Single(c => c.UserID ==  LID ).UserID;
        	  ddlUser.Items.Insert(0, new ListItem(UserName, UserID.ToString()));
	        }
		else{ddlUser.Items.Insert(0, new ListItem(UserName, LID.ToString()));}
            }
            else
            {
                ddlUser.DataSource = lstUsers;
                ddlUser.DataTextField = "NAME";
                ddlUser.DataValueField = "UserID";
                ddlUser.DataBind();
                ddlUser.Items.Insert(0, new ListItem(strAll, "0"));
            }
        }
       
    }
    #endregion
    protected void imgbtn1_Click(object sender, EventArgs e)
    {
        if (hdnclosurestatus.Value == "Open")
        {
           clear();
            btnUpdate.Visible = false;
            btnUpdate.Enabled = false;
            btnUpdate.Visible = false;
            txtcashdiff.Enabled = false;
            txtcashexp.Enabled = false;
            txtcountamt.Enabled = false;
            txtfifty.Enabled = false;
        //    txtfiftypaise.Enabled = false;
            txtfive.Enabled = false;
            txtfivehund.Enabled = false;
            txthund.Enabled = false;
            txtone.Enabled = false;
            txtoneth.Enabled = false;
            txtten.Enabled = false;
            txttwenty.Enabled = false;
            txttwo.Enabled = false;
            txttwohund.Enabled = false;
            txttwothous.Enabled = false;
        }
        else
        {
            clear();
            btnUpdate.Visible = false;
            btnUpdate.Enabled = false;
            btnUpdate.Visible = false;
            txtcashdiff.Enabled = false;
            txtcashexp.Enabled = false;
            txtcountamt.Enabled = false;
            txtfifty.Enabled = false;
      //      txtfiftypaise.Enabled = false;
            txtfive.Enabled = false;
            txtfivehund.Enabled = false;
            txthund.Enabled = false;
            txtone.Enabled = false;
            txtoneth.Enabled = false;
            txtten.Enabled = false;
            txttwenty.Enabled = false;
            txttwo.Enabled = false;
            txttwohund.Enabled = false;
            txttwothous.Enabled = false;

        }
      
   //       clear();
        ImageButton imgbtndetails = sender as ImageButton;

        GridViewRow gvrow = (GridViewRow)imgbtndetails.NamingContainer;

        hdnclosurestatus.Value = ((Label)gvrow.FindControl("lblstatus")).Text;
        string dates = ((Label)gvrow.FindControl("lblcreatedat")).Text;
        DateTime dat = Convert.ToDateTime(dates.ToString());
        LinkButton Userid = (LinkButton)gvrow.FindControl("lnkReceivedNumber");
        Label cash = (Label)gvrow.FindControl("lblTotalPendingSettlementAmt");
        string closureID = ((Label)gvrow.FindControl("lblClosureID")).Text;
        hdnClosureID.Value = closureID.ToString();
        txtcashexp.Text = cash.Text.ToString();
        //  gvAllUsers.SelectedIndex = gvrow.RowIndex;
        HiddenField finalbillID = (HiddenField)gvrow.FindControl("hdnFinalBillID");
        //   string finalbill = ((Label)gvrow.FindControl("hdnFinalBillID")).Text;
        string FinalBill = finalbillID.Value;
        string[] a = FinalBill.Split('/');
        hdnFinalBill.Value = a[0];

        //  string FinalBill = (LinkButton)gvrow.FindControl("lnkReceivedNumber").ToString();
        //string finalbill = gvrow.Cells[1].Text;
      
        //   lbluserid.Text = gvrow.Cells[4].Text;//   hdnuserid.Value = e.Row.Cells[4].Text;
        hdnuserid.Value = gvrow.Cells[4].Text;
        List<CashClosureDenominationDetail> lstCCDenoDetailssplit = new List<CashClosureDenominationDetail>();
        //    var cashstatus = lstCCDenoDetails.Find(p => p.UserID == Convert.ToInt64(hdnuserid.Value.ToString())).CashStatus;
        txtSettledAmt.Text = "0.00";
        hdnDenomination.Value = "0";
        lblgvPaymentDetails.Visible = false;
        lblgvRefundDetails.Visible = false;
        lblgvBillDetails.Visible = false;
        Panel3.Visible = false;
        List<ReceivedAmount> lstINDIPAmtReceivedDetails = new List<ReceivedAmount>();
        totalAmount = 0;
        refundAmount = 0;
        drAmount = 0;
        TotalIncAmount = 0;
        //  gvBillDetails.Visible = true;
        gvBillDetails.Visible = false;
        btnSave.Enabled = true;
        TotalPendingSettledAmount = 0;
        string sRcvdFromtime = string.Empty;
        string sRcvdTotime = string.Empty;
        string sRefundFromtime = string.Empty;
        string sRefundTotime = string.Empty;
        string sMinStartTime = string.Empty;
        string sMaxEndTime = string.Empty;

        //DateTime pFDT = Convert.ToDateTime(new BasePage().OrgDateTimeZone);
        //DateTime pTDT = Convert.ToDateTime(new BasePage().OrgDateTimeZone);

        pFDT = Convert.ToDateTime(txtFromDate1.Text);
        pTDT = Convert.ToDateTime(txtToDate.Text);
        int locationid;
        if (ddlLocation.SelectedValue == "-----All-----")
        {
            locationid = 0;

        }
        else
        {
            locationid = Convert.ToInt32(ddlLocation.SelectedValue);

        }
        string DispNoPay = Resources.Admin_ClientDisplay.Admin_BillSettlement_aspx_09 == null ? "No Payments Made" : Resources.Admin_ClientDisplay.Admin_BillSettlement_aspx_09;
        string DispNoAmount = Resources.Admin_ClientDisplay.Admin_BillSettlement_aspx_06 == null ? "No Amount Received From patient's" : Resources.Admin_ClientDisplay.Admin_BillSettlement_aspx_06;
        string DispNoamt = Resources.Admin_ClientDisplay.Admin_BillSettlement_aspx_07 == null ? "No amount received" : Resources.Admin_ClientDisplay.Admin_BillSettlement_aspx_07;
        string DispNoRefun = Resources.Admin_ClientDisplay.Admin_BillSettlement_aspx_08 == null ? " No refunds Made" : Resources.Admin_ClientDisplay.Admin_BillSettlement_aspx_08;
        long lUserID = Int64.Parse(ddlUser.SelectedValue);
        List<ReceivedAmount> lstPaymentDetails = new List<ReceivedAmount>();
        List<AmountReceivedDetails> lstreceivedTypes = new List<AmountReceivedDetails>();
        List<AmountReceivedDetails> lstIncSourcePaidDetails = new List<AmountReceivedDetails>();
        //    List<CurrencyMaster> lstCurrencyMaster = new List<CurrencyMaster>();

        //   string date1 = gvrow.Cells[1].Text;
        objBillingEngine = new BillingEngine(base.ContextInfo);
        retval = objBillingEngine.GetAmountReceivedDenoDetails(lUserID, OrgID, pFDT, pTDT, locationid,
                        out lstAmountReceivedDetails,
                        out lstCCDenoDetails,
                        out lstAmountRefundDetails,
                        out lstPaymentDetails,
                        out totalAmount,
                        out refundAmount, out cancellationAmount,
                        out sRcvdFromtime,
                        out sRcvdTotime,
                        out sRefundFromtime,
                        out sRefundTotime,
                        out sMinStartTime,
                        out sMaxEndTime,
                        out drAmount,
                        out othersAmount,
                        out TotalIncAmount,
                        out lstINDAmtReceivedDetails,
                        out lstINDIPAmtReceivedDetails,
                        out lstreceivedTypes,
                        out lstSplitDetails,
                        out lstIncSourcePaidDetails,
                        out lstCurrencyInHand,
                        out lstCCDeno,
                        out TotalPendingSettledAmount
                        );
        if (retval == 0)
        {
         //   lstCCDenoDetailssplit = lstCCDenoDetails
         //.Where(item => (item.UserID == Convert.ToInt64(hdnuserid.Value)  && (item.SettleDate >= dat && item.SettleDate <= dat))).ToList();//&& item.FinalBillID == Convert.ToInt64(hdnFinalBill.Value))).ToList();//(item.FinalBillID >= dat && item.SettleDate <= dat)).ToList();
            lstCCDenoDetailssplit = lstCCDenoDetails
              .Where(item => (item.UserID == Convert.ToInt64(hdnuserid.Value) && item.ClosureID == Convert.ToInt64(hdnClosureID.Value)))
              .ToList();//&& DateTime.Compare(item.SettleDate, dat)  <= 0)).ToList(); //(item.SettleDate.ToString("dd/MM/yyyy") >= dat.ToString("dd/MM/yyyy") && item.SettleDate.ToString("dd/MM/yyyy") <= dat.ToString("dd/MM/yyyy")))).ToList();//(item.FinalBillID >= dat && item.SettleDate <= dat)).ToList();

        }
        //  && item.CreatedAt == dat)
        if (lstCCDenoDetailssplit.Count > 0 && hdnclosurestatus.Value.ToString() == "Closed")
        {
        foreach (var item in lstCCDenoDetailssplit)
        {


            txtcashdiff.Text = item.CashDifference.ToString("0.00");
            txtcashexp.Text = item.CashExpected.ToString("0.00");

            txtcountamt.Text = item.CashCounted.ToString("0.00");



            //if (item.DenoId == 1) //100
            //{
            //    txtfiftypaise.Text = item.CurrencyCount.ToString();
            //    lblfftypa.Text = item.SumValueCurrencyCount.ToString();
            //}
            if (item.DenoId == 2) //200
            {
                txtone.Text = item.CurrencyCount.ToString();
                lblonrup.Text = item.SumValueCurrencyCount.ToString();

            }
            if (item.DenoId == 3)//500
            {
                txttwo.Text = item.CurrencyCount.ToString();
                lbltwrup.Text = item.SumValueCurrencyCount.ToString();

                }
                if (item.DenoId == 4)//1000
                {
                    txtfive.Text = item.CurrencyCount.ToString();
                    lblfiverup.Text = item.SumValueCurrencyCount.ToString();
                }
                if (item.DenoId == 5)//2000
                {
                    txtten.Text = item.CurrencyCount.ToString();
                    lbltenrup.Text = item.SumValueCurrencyCount.ToString();

                }
                if (item.DenoId == 6)//5000
                {
                    txttwenty.Text = item.CurrencyCount.ToString();

                    lbltwtyrup.Text = item.SumValueCurrencyCount.ToString();

                }
                if (item.DenoId == 7)//10000
                {
                    txtfifty.Text = item.CurrencyCount.ToString();
                    lblfftyrup.Text = item.SumValueCurrencyCount.ToString();
                }
                if (item.DenoId == 8)//20000
                {
                    txthund.Text = item.CurrencyCount.ToString();
                    lblhundrup.Text = item.SumValueCurrencyCount.ToString();

            }
            if (item.DenoId == 9)//50000
            {
                txttwohund.Text = item.CurrencyCount.ToString();
                lbltwohundrup.Text = item.SumValueCurrencyCount.ToString();
            }
            if (item.DenoId == 10)//100000
            {
                txtfivehund.Text = item.CurrencyCount.ToString();
                lblfivehundrup.Text = item.SumValueCurrencyCount.ToString();

            }
            if (item.DenoId == 11)//200000
            {
                txtoneth.Text = item.CurrencyCount.ToString();
                lblonethrup.Text = item.SumValueCurrencyCount.ToString();

            }
            if (item.DenoId == 12)//500000
            {
                txttwothous.Text = item.CurrencyCount.ToString();
                lbltwothrup.Text = item.SumValueCurrencyCount.ToString();
            }


            }
        }


        List<CurrencyMaster> lstCurrencyMaster = new List<CurrencyMaster>();
        try
        {
            objBillingEngine = new BillingEngine(base.ContextInfo);
            retval = objBillingEngine.GetCurrencyForOrgMappingCashClosureDeno(OrgID, out  lstCurrencyMaster);
            if (retval == 0)
            {
                if (lstCurrencyMaster.Count > 0)
                {
                    lbltwoth.Text = lstCurrencyMaster[0].MinorCurrencyDisplayText;
                    lbloneth.Text = lstCurrencyMaster[1].MinorCurrencyDisplayText;
                    lblfivehund.Text = lstCurrencyMaster[2].MinorCurrencyDisplayText;
                    lbltwohund.Text = lstCurrencyMaster[3].MinorCurrencyDisplayText;
                    lblhund.Text = lstCurrencyMaster[4].MinorCurrencyDisplayText;
                    lblfifty.Text = lstCurrencyMaster[5].MinorCurrencyDisplayText;
                    lbltwenty.Text = lstCurrencyMaster[6].MinorCurrencyDisplayText;
                    lblten.Text = lstCurrencyMaster[7].MinorCurrencyDisplayText;
                    lblfive.Text = lstCurrencyMaster[8].MinorCurrencyDisplayText;
                    lbltwo.Text = lstCurrencyMaster[9].MinorCurrencyDisplayText;
                    lblone.Text = lstCurrencyMaster[10].MinorCurrencyDisplayText;
                //    lblfiftypaise.Text = lstCurrencyMaster[11].MinorCurrencyDisplayText;



                }
            }

        }
        catch (Exception ex)
        {
            CLogger.LogError("Error While loading Admin POS Bill Settlement.", ex);
            // ErrorDisplay1.ShowError = true;
            //ErrorDisplay1.Status = "There was a problem. Please contact system administrator";
        }
        this.ModalPopupExtender1.Show();
    }
   
    protected void btnSearch_click(object sender, EventArgs e)
    {
        txtSettledAmt.Text = "0.00";
        hdnDenomination.Value = "0";
        lblgvPaymentDetails.Visible = false;
        lblgvRefundDetails.Visible = false;
        lblgvBillDetails.Visible = false;
        Panel3.Visible = false;
        List<ReceivedAmount> lstINDIPAmtReceivedDetails = new List<ReceivedAmount>();
        totalAmount = 0;
        refundAmount = 0;
        drAmount = 0;
        TotalIncAmount = 0;
      //  gvBillDetails.Visible = true;
        gvBillDetails.Visible = false;
        btnSave.Enabled = true;
        TotalPendingSettledAmount = 0;
        string sRcvdFromtime = string.Empty;
        string sRcvdTotime = string.Empty;
        string sRefundFromtime = string.Empty;
        string sRefundTotime = string.Empty;
        string sMinStartTime = string.Empty;
        string sMaxEndTime = string.Empty;

        //DateTime pFDT = Convert.ToDateTime(new BasePage().OrgDateTimeZone);
        //DateTime pTDT = Convert.ToDateTime(new BasePage().OrgDateTimeZone);

        pFDT = Convert.ToDateTime(txtFromDate1.Text);
        pTDT = Convert.ToDateTime(txtToDate.Text);
        int locationid;
        if (ddlLocation.SelectedValue == "-----All-----")
        {
            locationid = 0;

        }
        else
        {
            locationid = Convert.ToInt32(ddlLocation.SelectedValue);

        }
        string DispNoPay = Resources.Admin_ClientDisplay.Admin_BillSettlement_aspx_09 == null ? "No Payments Made" : Resources.Admin_ClientDisplay.Admin_BillSettlement_aspx_09;
        string DispNoAmount = Resources.Admin_ClientDisplay.Admin_BillSettlement_aspx_06 == null ? "No Amount Received From patient's" : Resources.Admin_ClientDisplay.Admin_BillSettlement_aspx_06;
        string DispNoamt = Resources.Admin_ClientDisplay.Admin_BillSettlement_aspx_07 == null ? "No amount received" : Resources.Admin_ClientDisplay.Admin_BillSettlement_aspx_07;
        string DispNoRefun = Resources.Admin_ClientDisplay.Admin_BillSettlement_aspx_08 == null ? " No refunds Made" : Resources.Admin_ClientDisplay.Admin_BillSettlement_aspx_08;
        long lUserID = Int64.Parse(ddlUser.SelectedValue);
        List<ReceivedAmount> lstPaymentDetails = new List<ReceivedAmount>();
        List<AmountReceivedDetails> lstreceivedTypes = new List<AmountReceivedDetails>();
        List<AmountReceivedDetails> lstIncSourcePaidDetails = new List<AmountReceivedDetails>();
        List<CurrencyMaster> lstCurrencyMaster = new List<CurrencyMaster>();
        try
        {
            objBillingEngine = new BillingEngine(base.ContextInfo);
            retval = objBillingEngine.GetAmountReceivedDenoDetails(lUserID, OrgID, pFDT, pTDT, locationid,
                            out lstAmountReceivedDetails,
                            out lstCCDenoDetail,
                            out lstAmountRefundDetails,
                            out lstPaymentDetails,
                            out totalAmount,
                            out refundAmount, out cancellationAmount,
                            out sRcvdFromtime,
                            out sRcvdTotime,
                            out sRefundFromtime,
                            out sRefundTotime,
                            out sMinStartTime,
                            out sMaxEndTime,
                            out drAmount,
                            out othersAmount,
                            out TotalIncAmount,
                            out lstINDAmtReceivedDetails,
                            out lstINDIPAmtReceivedDetails,
                            out lstreceivedTypes,
                            out lstSplitDetails,
                            out lstIncSourcePaidDetails,
                            out lstCurrencyInHand,
                            out lstCCDeno,
                            out TotalPendingSettledAmount
                            );
            if (retval == 0)
            {
                string DispPrintDt = Resources.Admin_ClientDisplay.Admin_BillSettlement_aspx_02 == null ? "Printed Date Yime   : " : Resources.Admin_ClientDisplay.Admin_BillSettlement_aspx_02;
                //lblPrintDateTime.Text = "Printed Date Time      : " + Convert.ToDateTime(new BasePage().OrgDateTimeZone).ToString("dd-MM-yyyy hh:mm:ss tt");
                lblPrintDateTime.Text = DispPrintDt + Convert.ToDateTime(new BasePage().OrgDateTimeZone).ToString("dd-MM-yyyy hh:mm:ss tt");
                if (sRcvdFromtime != null && sRcvdFromtime != "")
                {
                    string DispReceive = Resources.Admin_ClientDisplay.Admin_BillSettlement_aspx_03 == null ? "Received Time From : " : Resources.Admin_ClientDisplay.Admin_BillSettlement_aspx_03;
                    string DispTo = Resources.Admin_ClientDisplay.Admin_BillSettlement_aspx_04 == null ? " To " : Resources.Admin_ClientDisplay.Admin_BillSettlement_aspx_04;
                    lblReceivedTime.Visible = true;
                    //lblReceivedTime.Text = "Received time from : " + sRcvdFromtime + " To " + sRcvdTotime;
                    lblReceivedTime.Text = DispReceive + sRcvdFromtime + DispTo + sRcvdTotime;
                }
                else
                {
                    lblReceivedTime.Visible = false;
                }

                if (sRefundFromtime != "" && sRefundFromtime != null)
                {
                    string DispRefund = Resources.Admin_ClientDisplay.Admin_BillSettlement_aspx_05 == null ? "Refunded time from : " : Resources.Admin_ClientDisplay.Admin_BillSettlement_aspx_05;
                    string DispTo = Resources.Admin_ClientDisplay.Admin_BillSettlement_aspx_04 == null ? " To " : Resources.Admin_ClientDisplay.Admin_BillSettlement_aspx_04;

                    lblRefundTime.Visible = true;
                    //lblRefundTime.Text = "Refunded time from : " + sRefundFromtime + " To " + sRefundTotime;
                    lblRefundTime.Text = DispRefund + sRefundFromtime + DispTo + sRefundTotime;
                }
                else
                {
                    lblRefundTime.Visible = false;
                }
                if (lstreceivedTypes.Count > 0)
                {
                    gvAmountBreakup.DataSource = lstreceivedTypes;
                    gvAmountBreakup.DataBind();
                }
                else
                {
                    Panel3.Visible = false;
                }

             //   if (lUserID == 0)
             //   {
                    trSettledAmt.Style.Add("display", "none");
                    hdnShowPopup.Value = "0";
                    hdnDenomination.Value = "0";
                    btnBack.Visible = false;
                    gvAllUsers.Visible = true;
                 //   GrdUsers.Visible = true;
                    gvAllUsersRefund.Visible = true;
                    gvAllUsersPayments.Visible = true;

                    gvBillDetails.Visible = false;
                    gvRefundDetails.Visible = false;
                    gvPaymentDetails.Visible = false;
                    gvCashIncomeDetails.Visible = false;

                    if (lstAmountReceivedDetails.Count > 0)
                    {
                        gvAllUsers.DataSource = lstAmountReceivedDetails;
                        gvAllUsers.DataBind();
                        gvAllUsers.Visible = true;
                        GridView2.DataSource = lstCCDenoDetail;
                        GridView2.DataBind();
                        GridView1.Visible = false;
                    }
                    else
                    {
                        gvAllUsers.Visible = false;
                        GridView2.Visible = false;
                        lblgvBillDetails.Visible = true;
                        lblgvBillDetails.Text = DispNoAmount;
                        //lblgvBillDetails.Text = "No Amount Received From patient's";
                    }
                    if (lstIncSourcePaidDetails.Count > 0)
                    {
                        gvCashIncomeDetails.DataSource = lstIncSourcePaidDetails;
                        gvCashIncomeDetails.DataBind();
                        gvCashIncomeDetails.Visible = true;
                    }
                    else
                    {
                        lblgvCashIncomeDetails.Visible = true;
                        //lblgvCashIncomeDetails.Text = "No amount received";
                        lblgvCashIncomeDetails.Text = DispNoamt;
                        gvCashIncomeDetails.Visible = false;
                    }
                    if (lstAmountRefundDetails.Count > 0)
                    {
                        gvAllUsersRefund.DataSource = lstAmountRefundDetails;
                        gvAllUsersRefund.DataBind();
                        gvAllUsersRefund.Visible = true;
                    }
                    else
                    {
                        gvAllUsersRefund.Visible = false;
                        lblgvRefundDetails.Visible = true;
                        ////lblgvRefundDetails.Text = "No Refunds Made";
                        lblgvRefundDetails.Text = DispNoRefun;
                    }
                    if (lstPaymentDetails.Count > 0)
                    {
                        gvAllUsersPayments.DataSource = lstPaymentDetails;
                        gvAllUsersPayments.DataBind();
                        gvAllUsersPayments.Visible = true;
                    }
                    else
                    {
                        gvAllUsersPayments.Visible = false;
                        lblgvPaymentDetails.Visible = true;
                        //lblgvPaymentDetails.Text = "No Payments Made";
                        lblgvPaymentDetails.Text = DispNoPay;
                    }
                    if (lstINDAmtReceivedDetails.Count > 0)
                    {
                        gvINDAmtReceivedDetails.Visible = true;
                        gvINDAmtReceivedDetails.DataSource = lstINDAmtReceivedDetails;
                        gvINDAmtReceivedDetails.DataBind();
                        Panel2.Visible = true;
                    }
                    else
                    {
                        gvINDAmtReceivedDetails.Visible = false;
                        Panel2.Visible = false;
                    }
                    if (lstINDIPAmtReceivedDetails.Count > 0)
                    {
                        gvIndIPAMountReceived.Visible = true;
                        gvIndIPAMountReceived.DataSource = lstINDIPAmtReceivedDetails;
                        gvIndIPAMountReceived.DataBind();
                        Panel1.Visible = true;
                    }
                    else
                    {
                        gvIndIPAMountReceived.Visible = false;
                        Panel1.Visible = false;
                    }
               // }
                //else
                //{
                //    trSettledAmt.Style.Add("display", "block");
                //    hdnShowPopup.Value = "1";
                //    //btnBack.Visible = true;
                //    gvAllUsers.Visible = false;
                //    gvAllUsersRefund.Visible = false;
                //    gvAllUsersPayments.Visible = false;

                //    gvBillDetails.Visible = true;
                //    gvRefundDetails.Visible = true;
                //    gvPaymentDetails.Visible = true;

                    if (lstAmountReceivedDetails.Count > 0)
                    {
                        gvBillDetails.DataSource = lstAmountReceivedDetails;
                        gvBillDetails.DataBind();
                        //    gvBillDetails.Visible = true;
                    }
                    else
                    {
                       gvBillDetails.Visible = false;
                      //  lblgvBillDetails.Visible = true;
                        lblgvBillDetails.Text = DispNoAmount; // "No Amount Received From patient's";
                    }
                       if (lstIncSourcePaidDetails.Count > 0)
                       {
                           gvCashIncomeDetails.DataSource = lstIncSourcePaidDetails;
                           gvCashIncomeDetails.DataBind();
                           gvCashIncomeDetails.Visible = true;
                       }
                       else
                       {
                           gvCashIncomeDetails.Visible = false;
                           lblgvCashIncomeDetails.Visible = true;
                           //lblgvCashIncomeDetails.Text = "No amount received";
                           lblgvCashIncomeDetails.Text = DispNoamt;
                       }
                       if (lstAmountRefundDetails.Count > 0)
                       {
                           gvRefundDetails.DataSource = lstAmountRefundDetails;
                           gvRefundDetails.DataBind();
                        //   gvRefundDetails.Visible = true;
                       }
                       else
                       {
                           gvRefundDetails.Visible = false;
                           lblgvRefundDetails.Visible = true;
                           //lblgvRefundDetails.Text = "No Refunds Made";
                           lblgvRefundDetails.Text = DispNoRefun; ;
                       }
                       if (lstPaymentDetails.Count > 0)
                       {
                           gvPaymentDetails.DataSource = lstPaymentDetails;
                           gvPaymentDetails.DataBind();
                       }
                       else
                       {
                           gvPaymentDetails.Visible = false;
                           lblgvPaymentDetails.Visible = true;
                           //lblgvPaymentDetails.Text = "No Payments Made";
                           lblgvPaymentDetails.Text = DispNoPay;
                       }
                       if (lstINDAmtReceivedDetails.Count > 0)
                       {
                           gvINDAmtReceivedDetails.Visible = true;
                           gvINDAmtReceivedDetails.DataSource = lstINDAmtReceivedDetails;
                           gvINDAmtReceivedDetails.DataBind();
                           Panel2.Visible = true;
                       }
                       else
                       {
                           gvINDAmtReceivedDetails.Visible = false;
                           Panel2.Visible = false;
                       }
                       if (lstINDIPAmtReceivedDetails.Count > 0)
                       {
                           gvIndIPAMountReceived.Visible = true;
                           Panel1.Visible = true;
                           gvIndIPAMountReceived.DataSource = lstINDIPAmtReceivedDetails;
                           gvIndIPAMountReceived.DataBind();
                       }
                       else
                       {
                           gvIndIPAMountReceived.Visible = false;
                           Panel1.Visible = false;
                       }
                   //}
           }
            else
            {
                divtimeDisplay.Visible = false;
                lblReceivedTime.Text = "";
                lblRefundTime.Text = "";
                gvBillDetails.Visible = false;
                btnSave.Enabled = false;
                gvAllUsers.Visible = false;
                gvRefundDetails.Visible = false;
                gvAllUsersRefund.Visible = false;

                gvPaymentDetails.Visible = false;
                gvAllUsersPayments.Visible = false;
                gvINDAmtReceivedDetails.Visible = false;
            }
            if (totalAmount > 0)
            {
                lblTotal.Text = totalAmount.ToString("#.00");
            }
            else
            {
                lblTotal.Text = "0.00";
            }
            if (TotalIncAmount > 0)
            {
                lblTotalInc.Text = TotalIncAmount.ToString("#.00");
            }
            else
            {
                lblTotalInc.Text = "0.00";
            }
            if (refundAmount > 0)
            {
                lblRefund.Text = refundAmount.ToString("#.00");

            }
            else
            {
                lblRefund.Text = "0.00";
            }
            if (cancellationAmount > 0)
            {
                lblCancelledAmount.Text = cancellationAmount.ToString();
            }
            else
            {
                lblCancelledAmount.Text = "0.00";
            }
            if (drAmount > 0)
            {
                lblPhyAmount.Text = drAmount.ToString("#.00");
            }
            else
            {
                lblPhyAmount.Text = "0.00";
            }
            if (othersAmount > 0)
            {
                lblOthersAmount.Text = othersAmount.ToString("#.00");
            }
            else
            {
                lblOthersAmount.Text = "0.00";
            }
            if (TotalPendingSettledAmount > 0)
            {
                lblTotalPendingSettledAmt.Text = TotalPendingSettledAmount.ToString("#.00");
            }
            else
            {
                lblTotalPendingSettledAmt.Text = "0.00";
            }

            refundAmount = (refundAmount == -1 ? 0 : refundAmount);
            totalAmount = (totalAmount == -1 ? 0 : totalAmount);
            cancellationAmount = (cancellationAmount == -1 ? 0 : cancellationAmount);
            lblClosingBalance.Text = ((totalAmount + TotalIncAmount + TotalPendingSettledAmount) - refundAmount - cancellationAmount - drAmount - othersAmount).ToString("#.00");
            hdnClosingAmt.Value = ((totalAmount + TotalIncAmount + TotalPendingSettledAmount) - refundAmount - cancellationAmount - drAmount - othersAmount).ToString("#.00");
            string cashInHand = string.Empty;
            foreach (CurrencyOrgMapping objCIH in lstCurrencyInHand)
            {
                cashInHand += objCIH.CurrencyName + " - ";
                if (objCIH.IsBaseCurrency == "Y")
                {
                    cashInHand += (Convert.ToDecimal(objCIH.ConversionRate) - Convert.ToDecimal(((Convert.ToDecimal(totalAmount) + Convert.ToDecimal(TotalIncAmount) + TotalPendingSettledAmount) - Convert.ToDecimal(lblClosingBalance.Text)))).ToString();
                    cashInHand += "<br>";
                }
                else
                {
                    cashInHand += objCIH.ConversionRate.ToString();
                    cashInHand += "<br>";
                }
            }
            lblClosingCashInHand.Text = cashInHand;
            if (lstCurrencyInHand.Count > 1)
            {
                trCashInHand.Style.Add("display", "block");
            }
            else
            {
                trCashInHand.Style.Add("display", "none");
            }
            if (lstCCDeno.Count > 0)
            {
                hdnDenomination.Value = "1";
                gvResult.DataSource = lstCCDeno;
                gvResult.DataBind();
            }
            else
            {
                hdnDenomination.Value = "0";
                gvResult.DataSource = null;
                gvResult.DataBind();
            }

        }
        catch (Exception ex)
        {
            CLogger.LogError("Error While loading Admin Bill Settlement.", ex);
            // ErrorDisplay1.ShowError = true;
            //ErrorDisplay1.Status = "There was a problem. Please contact system administrator";
        }
        if (OrgID != 11)
        {
            Panel1.Visible = false;
            Panel2.Visible = false;
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        string sAllUsersSelected = string.Empty;
        ContextInfo.AdditionalInfo = ddlLocation.SelectedValue.ToString();
        try
        {
            if (txtSettledAmt.Text != "0" || txtSettledAmt.Text != "0.00")
            {
                lstAmountClosure = new List<AmountClosureDetails>();
                //totalAmount = decimal.Parse(lblTotal.Text);
                decimal settledAmt = 0;
                settledAmt = decimal.Parse(txtSettledAmt.Text);
                // totalAmount = decimal.Parse(lblTotal.Text) + decimal.Parse(lblTotalPendingSettledAmt.Text);
                totalAmount = decimal.Parse(lblClosingBalance.Text);
                refundAmount = decimal.Parse(lblRefund.Text);
                sstatus = "Closed";
                int CreatedBYID = Int32.Parse(LID.ToString());
                ICreatedforUserID = Int32.Parse(ddlUser.SelectedValue.ToString());
                objBillingEngine = new BillingEngine(base.ContextInfo);
                if (ddlUser.SelectedValue != "0")
                {
                    DataTable dtAmountReceived = GetAmountReceivedIDTable(out sAllUsersSelected, gvBillDetails, gvAllUsers, true, "");
                    DataTable dtAmountRefund = GetAmountReceivedIDTable(out sAllUsersSelected, gvRefundDetails, gvAllUsersRefund, false, "");
                    DataTable dtPayments = GetAmountReceivedIDTable(out sAllUsersSelected, gvPaymentDetails, gvAllUsersPayments, false, "AmtRec");

                    retval = objBillingEngine.InsertAmountClosureDetails((decimal)totalAmount, (decimal)settledAmt, sstatus, CreatedBYID,
                                                                         ICreatedforUserID, CreatedBYID, ICreatedforUserID,
                                                                         dtAmountReceived, dtAmountRefund, dtPayments, sAllUsersSelected,
                                                                         (decimal)refundAmount, "C");
                }
                else
                {
                    DataTable dtClosureDetails = GetAmountClosureTable();

                    DataTable dtAmountReceived = GetAmountReceivedIDTable(out sAllUsersSelected, gvBillDetails, gvAllUsers, true, "");
                    DataTable dtAmountRefund = GetAmountReceivedIDTable(out sAllUsersSelected, gvRefundDetails, gvAllUsersRefund, false, "");
                    DataTable dtPayments = GetAmountReceivedIDTable(out sAllUsersSelected, gvPaymentDetails, gvAllUsersPayments, false, "");

                    retval = objBillingEngine.InsertAmountClosureDetailsForAllUsers(dtClosureDetails, sstatus, CreatedBYID,
                                                                                    dtAmountReceived, dtAmountRefund, dtPayments, "C");
                }
                BindListofUsers();
                ddlUser.SelectedIndex = 0;
                btnSearch_click(sender, e);
            }
        }
        catch (Exception ex)
        {
            CLogger.LogError("Error While saving Amount Closure Details.", ex);
            // ErrorDisplay1.ShowError = true;
            //ErrorDisplay1.Status = "There was a problem. Please contact system administrator";
        }

    }

    private DataTable GetAmountReceivedIDTable(out string sAllUsers, GridView gvBillDetails, GridView gvAllUser, bool PaymentTable, string pStatus)
    {
        sAllUsers = "";

        System.Data.DataTable dt = new DataTable();

        DataColumn dbCol1 = new DataColumn("ID");
        DataColumn dbCol2 = new DataColumn("Amount");
        DataColumn dbCol3 = new DataColumn("Description");
        DataColumn dbCol4 = new DataColumn("IsGroup");
        DataColumn dbCol5 = new DataColumn("Status");
        DataColumn dbCol6 = new DataColumn("Quantity");
        DataColumn dbCol7 = new DataColumn("Rate");

        //add columns
        dt.Columns.Add(dbCol1);
        dt.Columns.Add(dbCol2);
        dt.Columns.Add(dbCol3);
        dt.Columns.Add(dbCol4);
        dt.Columns.Add(dbCol5);
        dt.Columns.Add(dbCol6);
        dt.Columns.Add(dbCol7);

        DataRow dr;

   //     if (ddlUser.SelectedValue != "0")
     //   {
            foreach (GridViewRow gr in gvBillDetails.Rows)
            {
                dr = dt.NewRow();
                if (PaymentTable)
                {
                    dr["ID"] = Convert.ToInt64(gr.Cells[7].Text);
                }
                else
                {
                    if (pStatus == "AmtRec")
                    {
                        dr["ID"] = Convert.ToDouble(gr.Cells[3].Text);
                    }
                    else
                    {
                        dr["ID"] = Convert.ToDouble(gr.Cells[4].Text);
                    }
                }
                Label lnkBillNumber = (Label)gr.FindControl("lnkBillNumber");
            //    Label amount = (Label)gr.FindControl("lblTotalPendingSettlementAmt");
           //     dr["Amount"] = gr.Cells[6].Text;
                dr["Amount"] =0;
                dr["Description"] = "";
                dr["IsGroup"] = "N";
                dr["Status"] = "Closed";// lnkBillNumber.Text == "" ? "EDIT" : "";
                dr["Quantity"] = 0;
                dr["Rate"] = 0;
                dt.Rows.Add(dr);
            }
           // sAllUsers = "N";
      //  }

        //else
        //{
        //    foreach (GridViewRow gr in gvAllUser.Rows)
        //    {
        //        dr = dt.NewRow();
        //        dr["ID"] = Convert.ToInt64(gr.Cells[2].Text);
        //        dr["Amount"] = 0;
        //        dr["Description"] = gr.Cells[3].Text.Trim();
        //        dr["IsGroup"] = "Y";
        //        dr["Status"] = "";
        //        dr["Quantity"] = 0;
        //        dr["Rate"] = 0;
        //        dt.Rows.Add(dr);
        //    }
        //  //  sAllUsers = "Y";
        //}

        return dt;
    }

    private DataTable GetAmountClosureTable()
    {
        System.Data.DataTable dt = new DataTable();
        try
        {
            DataColumn dbCol1 = new DataColumn("AmountToBeClosed");
            DataColumn dbCol2 = new DataColumn("AmountClosed");
            DataColumn dbCol3 = new DataColumn("Status");
            DataColumn dbCol4 = new DataColumn("ClosedBy");
            DataColumn dbCol5 = new DataColumn("ClosedFor");
            DataColumn dbCol6 = new DataColumn("CreatedBy");
            DataColumn dbCol7 = new DataColumn("AmountRefunded");

            //add columns
            dt.Columns.Add(dbCol1);
            dt.Columns.Add(dbCol2);
            dt.Columns.Add(dbCol7);
            dt.Columns.Add(dbCol3);
            dt.Columns.Add(dbCol4);
            dt.Columns.Add(dbCol5);
            dt.Columns.Add(dbCol6);

            DataRow dr;
            int iUCount = 0;
            int iRefundCount = 0;
            int iUPaymenstCount = 0;
            iUCount = gvAllUsers.Rows.Count;
            iRefundCount = gvAllUsersPayments.Rows.Count;
            iUPaymenstCount = gvAllUsersPayments.Rows.Count;


            foreach (GridViewRow gr in gvAllUsers.Rows)
            {
                decimal d1 = Convert.ToDecimal((gvAllUsers.Rows[gr.RowIndex].FindControl("lblTotalPendingSettlementAmt") as Label).Text);
                decimal d2 = Convert.ToDecimal((gvAllUsers.Rows[gr.RowIndex].FindControl("lblRefundamt") as Label).Text);
                dr = dt.NewRow();
                // dr["AmountToBeClosed"] = Convert.ToDecimal((gvAllUsers.Rows[gr.RowIndex].FindControl("lblTotalPendingSettlementAmt") as Label).Text);
                dr["AmountToBeClosed"] = d1 - d2;
                dr["AmountClosed"] = Convert.ToDecimal((gvAllUsers.Rows[gr.RowIndex].FindControl("txtAllUserSettledAmt") as TextBox).Text);
                dr["AmountRefunded"] = "0";
                dr["Status"] = "Closed";
                dr["ClosedBy"] = Convert.ToInt32(LID);
                dr["ClosedFor"] = Convert.ToInt32(gr.Cells[3].Text);
                dr["CreatedBy"] = Convert.ToInt64(LID);
                dt.Rows.Add(dr);
            }

            int i = 0;

            foreach (GridViewRow gr in gvAllUsersRefund.Rows)
            {
                dt.Rows[i]["AmountRefunded"] = Convert.ToDecimal(gr.Cells[1].Text);
                i++;
                dt.AcceptChanges();
            }
            decimal amtPaid = 0;
            i = 0;
            foreach (GridViewRow gr in gvAllUsersPayments.Rows)
            {
                amtPaid = 0;
                decimal.TryParse(dt.Rows[i]["AmountRefunded"].ToString(), out amtPaid);
                dt.Rows[i]["AmountRefunded"] = amtPaid + Convert.ToDecimal(gr.Cells[1].Text);
                i++;
                dt.AcceptChanges();
            }
        }
        catch (Exception ex)
        {
            CLogger.LogError("Error in GetAmountClosureTable", ex);
        }
        return dt;

    }
  

    private void GetCollectionWiseDetails(long lUserID, string sStartTime, string sEndTime)
    {
        long returnCode = -1;
        decimal totalAdditions = 0;
        decimal totalDeduction = 0;
        BillingEngine be = new BillingEngine(base.ContextInfo);
        List<ServiceQtyAmount> lstInflowDtls = new List<ServiceQtyAmount>();
        List<ServiceQtyAmount> lstOutflowDtls = new List<ServiceQtyAmount>();

        try
        {
            if (sStartTime != "" && sEndTime != "")
            {
                if (lUserID > 0)
                {
                    returnCode = be.GetCollectionDetails(lUserID, sStartTime, sEndTime, OrgID, out totalAdditions, out totalDeduction, out lstInflowDtls, out lstOutflowDtls);
                }
                else
                {
                    returnCode = be.GetCollectionDetails(sStartTime, sEndTime, OrgID, out totalAdditions, out totalDeduction, out lstInflowDtls, out lstOutflowDtls);
                }
            }
            StringBuilder sb = be.BuildCollectionDetailTbl(lstInflowDtls, lstOutflowDtls, totalAdditions, totalDeduction);
            lblConsreport.Text = sb.ToString();

        }
        catch (Exception e1)
        {
            CLogger.LogError("Error retrieving collection details ", e1);
        }
    }
    protected override void Render(HtmlTextWriter writer)
    {
        for (int i = 0; i < this.gvBillDetails.Rows.Count; i++)
        {
            this.Page.ClientScript.RegisterForEventValidation(this.gvBillDetails.UniqueID, "Select$" + i);
        }

        base.Render(writer);
    }
    protected void gvBillDetails_RowCommand(object sender, GridViewCommandEventArgs e)
    {

        long returnCode = -1;
        string strBillNo = "";
        string pagename = "";
        strBillNo = gvBillDetails.DataKeys[Convert.ToInt32(e.CommandArgument)][1].ToString();
        List<Attune.Podium.BusinessEntities.BillSearch> bSearch = new List<Attune.Podium.BusinessEntities.BillSearch>();
        Patient_BL patientBL = new Patient_BL(base.ContextInfo);

        try
        {
            if (e.CommandName == "Select")
            {
                int totalRows = 0;
                returnCode = patientBL.SearchBillOptionDetails(strBillNo, "", "", "", -1, OrgID, "", "", "", "", "", out bSearch, -1, -1, out totalRows, 0);
            }

            if (returnCode == 0 && bSearch.Count > 0)
            {
                foreach (Attune.Podium.BusinessEntities.BillSearch items in bSearch)
                {

                    pagename = "?vid=" + items.PatientVisitId + "&pagetype=BP&bid=" + items.BillID + "";
                }
            }
            string skey = "../Reception/ViewPrintPage.aspx"
                            + pagename
                            + "&IsPopup=" + "Y"
                            + "&CCPage=Y"
                            + "";

            this.Page.RegisterStartupScript("sky",
              "<script language='javascript'> window.open('" + skey + "', '', 'letf=0,top=0,height=640,width=800,toolbar=0,scrollbars=1,status=0');</script>");

        }
        catch (Exception ex)
        {
        }
    }
    protected void gvBillDetails_RowDataBound(object sender, GridViewRowEventArgs e)
    {

        try
        {
            e.Row.Cells[6].Style.Add("display", "none");
            // e.Row.Cells[5].Visible = false;
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //Label lnkReceiptNO = (Label)e.Row.FindControl("lnkReceiptNO");
                //if (lnkReceiptNO.Text == "0")
                //{
                //    lnkReceiptNO.Text = "--";
                //}
                ReceivedAmount lstRcvd = (ReceivedAmount)e.Row.DataItem;
                List<ReceivedAmount> childItems = (from child in lstSplitDetails
                                                   where child.FinalBillID == lstRcvd.FinalBillID && child.ReceiptNO == lstRcvd.ReceiptNO
                                                   select child).ToList();
                string sFeetype = "CON";
                string pagename = "";
                if (childItems.FindAll(P => P.FeeType == "PRM").Count > 0)
                {
                    sFeetype = "PRM";
                    pagename = "?vid=" + lstRcvd.VisitID + "&pagetype=BP&bid=" + lstRcvd.FinalBillID + "";
                }
                if (sFeetype != "PRM")
                {
                    pagename = "?vid=" + lstRcvd.VisitID + "&pagetype=BP&bid=" + lstRcvd.FinalBillID + "";
                }
                e.Row.Cells[1].Attributes.Add("onclick", "openViewBill('" + pagename + "','" + sFeetype + "')");

                if (hdnNeedDescription.Value != "N")
                {

                    GridView childGrid = (GridView)e.Row.FindControl("gvChildDetails");
                    childGrid.DataSource = childItems;
                    childGrid.DataBind();
                }
                Label lnkBillNumber = (Label)e.Row.FindControl("lnkBillNumber");
                if (lnkBillNumber.Text == "")
                {
                    e.Row.BackColor = System.Drawing.Color.LightPink;
                }
            }
        }
        catch (Exception ex)
        {
            CLogger.LogError("Error While Loading Cash Closure Details.", ex);
            //ErrorDisplay1.ShowError = true;
            //ErrorDisplay1.Status = "There was a problem in page load. Please contact system administrator";
        }

    }

    protected void gvPaymentDetails_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            e.Row.Cells[3].Visible = false;
        }
        catch (Exception ex)
        {
            CLogger.LogError("Error While Loading Cash Closure Details.", ex);
            //// ErrorDisplay1.ShowError = true;
            // ErrorDisplay1.Status = "There was a problem in page load. Please contact system administrator";
        }

    }

    protected void gvRefundDetails_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        e.Row.Cells[4].Visible = false;
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            ReceivedAmount ARD = (ReceivedAmount)e.Row.DataItem;
            if (ARD.BillStatus == "CANCELLED")
            {
                e.Row.CssClass = "grdrows";
                e.Row.Cells[0].ToolTip = "This bill has been cancelled";
                e.Row.Cells[1].ToolTip = "This bill has been cancelled";
                e.Row.Cells[2].ToolTip = "This bill has been cancelled";
            }
            else if (ARD.BillStatus == "REFUND")
            {
                e.Row.Cells[0].ToolTip = "This bill has been Refunded";
                e.Row.Cells[1].ToolTip = "This bill has been Refunded";
                e.Row.Cells[2].ToolTip = "This bill has been Refunded";
            }
            Label lnkBillNumber = (Label)e.Row.FindControl("lnkBillNumber");
            if (lnkBillNumber.Text == "")
            {
                e.Row.BackColor = System.Drawing.Color.LightPink;
            }
        }
    }

    protected void gvAllUsers_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        e.Row.Cells[2].Visible = false;
        e.Row.Cells[3].Visible = false;
        e.Row.Cells[4].Visible = false;
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            txtcashexp.Text = "0.00";
            TextBox txtAllUserSettledAmt = (TextBox)e.Row.FindControl("txtAllUserSettledAmt");
            Label lblAmtReceived = (Label)e.Row.FindControl("lblAmtReceived");
            Label lblPendingAmt = (Label)e.Row.FindControl("lblPedningSettledAmt");
            Label lblTotalPendingSettlementAmt = (Label)e.Row.FindControl("lblTotalPendingSettlementAmt");
            Label lblstatus = (Label)e.Row.FindControl("lblstatus");
            string strScript = "CalcItemValidation('" + txtAllUserSettledAmt.ClientID +
                                            "','" + lblTotalPendingSettlementAmt.ClientID +
                                           "');";
            Label lblRefundAmt = (Label)e.Row.FindControl("lblRefundamt");
            txtAllUserSettledAmt.Attributes.Add("onblur", strScript);
            txtAllUserSettledAmt.Text = ((Convert.ToDouble(lblTotalPendingSettlementAmt.Text) - Convert.ToDouble(lblPendingAmt.Text))).ToString();//- Convert.ToDouble(lblRefundAmt.Text)).ToString();
            txtcashexp.Text = lblTotalPendingSettlementAmt.Text.ToString();
            //txtAllUserSettledAmt.Attributes.Add("onchange", strScript);
            hdnclosurestatus.Value = lblstatus.Text.ToString();
            if (lblstatus.Text.ToString() == "Closed")
            {
                txtAllUserSettledAmt.Enabled = false;
            }
            else
            {
                txtAllUserSettledAmt.Enabled = true;
            }
            hdnuserid.Value = e.Row.Cells[4].Text;
        }
    }
  
    protected void gvAllUsersPayments_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        e.Row.Cells[2].Visible = false;
        e.Row.Cells[3].Visible = false;
    }
    protected void gvAllUsersRefund_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        e.Row.Cells[2].Visible = false;
        e.Row.Cells[3].Visible = false;
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            ReceivedAmount ARD = (ReceivedAmount)e.Row.DataItem;
            if (ARD.BillStatus == "CANCELLED")
            {
                e.Row.CssClass = "grdrows";
                e.Row.Cells[0].ToolTip = "This bill has been cancelled";
                e.Row.Cells[1].ToolTip = "This bill has been cancelled";
            }
            else if (ARD.BillStatus == "REFUND")
            {
                e.Row.Cells[0].ToolTip = "This bill has been Refunded";
                e.Row.Cells[1].ToolTip = "This bill has been Refunded";
            }
        }
    }

    protected void gvAllUsersPayments_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "UserPaidLink")
        {
            string userID = e.CommandArgument.ToString();
            ddlUser.SelectedIndex = ddlUser.Items.IndexOf(ddlUser.Items.FindByValue(userID));
            btnSearch_click(sender, e);

        }
    }
    protected void gvINDAmtReceivedDetails_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            ReceivedAmount ra = (ReceivedAmount)e.Row.DataItem;

            flag = flag + ra.Qty;

            if (ra.Amount > 0)
            {
                e.Row.Visible = true;

                if (ra.Descriptions == "Outstanding Amount" || ra.Descriptions == "Discount Amount" || ra.Descriptions == "Refund Amount" || ra.Descriptions == "Other Payments" || ra.Descriptions == "Due Collected By Others" || ra.Descriptions == "Cancelled Bill Amount")
                {
                    e.Row.CssClass = "grdcheck";
                    e.Row.Font.Size = 10;
                }
                if (ra.Descriptions == "Previous Due Received")
                {
                    e.Row.CssClass = "grdchecked";
                    e.Row.Font.Size = 10;
                }
            }
            else
            {
                e.Row.Visible = false;
            }
        }
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Admin/BillSettlement.aspx");
    }
    protected void gvResult_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.Footer)
        {
            Label lblTotalSum = (Label)e.Row.FindControl("lblTotalSum");
            lblTotalSum.Text = lstCCDeno.Sum(p => p.Amount).ToString("0.00");
        }
    }
    protected void gvCashIncomeDetails_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "UserLink")
        {
            string userID = e.CommandArgument.ToString();
            ddlUser.SelectedIndex = ddlUser.Items.IndexOf(ddlUser.Items.FindByValue(userID));
            btnSearch_click(sender, e);
        }

    }
    protected void gvCashIncomeDetails_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (ddlUser.SelectedIndex > 0)
        {
            e.Row.Cells[0].Style.Add("display", "none");
        }
        else
        {
            e.Row.Cells[1].Style.Add("display", "none");
        }
    }
    protected string TotalSettlementAmountCalc(object PendingSettlementAmt, object AmtReceived)
    {
        decimal totalSetAmt = 0;
        totalSetAmt = ((decimal)PendingSettlementAmt + (decimal)AmtReceived);
        return totalSetAmt.ToString();
    }
    string strSelect = Resources.Reception_ClientDisplay.Reception_VisitDetails_aspx_20 == null ? "--Select--" : Resources.Reception_ClientDisplay.Reception_VisitDetails_aspx_20;
    public void LoadLocation()
    {

        PatientVisit_BL PatientVisit_BL = new PatientVisit_BL(base.ContextInfo);
        List<OrganizationAddress> lstOrganizationAddress = new List<OrganizationAddress>();
        List<OrganizationAddress> LoginLoc = new List<OrganizationAddress>();
        List<OrganizationAddress> ParentLoc = new List<OrganizationAddress>();
        PatientVisit_BL.GetLocation(OrgID, LID, 0, out lstOrganizationAddress);
        if (lstOrganizationAddress.Count > 0)
        {
            if (CID > 0)
            {
                LoginLoc = lstOrganizationAddress.FindAll(P => P.AddressID == ILocationID).ToList();
                ParentLoc = (from lst in lstOrganizationAddress
                             join lst1 in LoginLoc on lst.AddressID equals lst1.ParentAddressID
                             select lst).ToList();
                LoginLoc = LoginLoc.Concat(ParentLoc).ToList<OrganizationAddress>();
                ddlLocation.DataSource = LoginLoc;
                ddlLocation.DataValueField = "AddressID";
                ddlLocation.DataTextField = "Location";
                ddlLocation.DataBind();
            }
            else
            {
                ddlLocation.DataSource = lstOrganizationAddress;
                ddlLocation.DataValueField = "AddressID";
                ddlLocation.DataTextField = "Location";
                ddlLocation.DataBind();
            }
        }
        ddlLocation.Items.Insert(0, strAll.Trim());
        //ddlLocation.Items[0].Text = LocationName;
        ddlLocation.SelectedValue = ddlLocation.Items.FindByText(LocationName).Value;
    }
    protected void btnCancelDeno_Click(object sender, EventArgs e)
    {
        this.ModalPopupExtender1.Show();
           }
    protected void imgbtn_Click(object sender, EventArgs e)
    {

        ImageButton btndetails = sender as ImageButton;

        GridViewRow gvrow = (GridViewRow)btndetails.NamingContainer;
        TextBox cash1 = (TextBox)gvrow.FindControl("txtAllUserSettledAmt");
        string closureID = ((Label)gvrow.FindControl("lblClosureID")).Text;
        hdnClosureID.Value = closureID.ToString();
       // hdnClosureID.Value = clsid;
        if (hdnclosurestatus.Value == "Open" && cash1.Enabled == true)
        {
            clear();
            btnUpdate.Visible = true;
            btnUpdate.Enabled = true;
            txtcashexp.Enabled = true;
            txtcountamt.Enabled = true;
            txtfifty.Enabled = true;
        //    txtfiftypaise.Enabled = true;
            txtfive.Enabled = true;
            txtfivehund.Enabled = true;
            txthund.Enabled = true;
            txtone.Enabled = true;
            txtoneth.Enabled = true;
            txtten.Enabled = true;
            txttwenty.Enabled = true;
            txttwo.Enabled = true;
            txttwohund.Enabled = true;
            txttwothous.Enabled = true;
            txtcashdiff.Enabled = true;
        }
        else
        {
            clear();
            btnUpdate.Visible = false;
            btnUpdate.Enabled = false;
            btnUpdate.Visible = false;
            txtcashdiff.Enabled = false;
            txtcashexp.Enabled = false;
            txtcountamt.Enabled = false;
            txtfifty.Enabled = false;
         //   txtfiftypaise.Enabled = false;
            txtfive.Enabled = false;
            txtfivehund.Enabled = false;
            txthund.Enabled = false;
            txtone.Enabled = false;
            txtoneth.Enabled = false;
            txtten.Enabled = false;
            txttwenty.Enabled = false;
            txttwo.Enabled = false;
            txttwohund.Enabled = false;
            txttwothous.Enabled = false;
           
        }
       

        hdnclosurestatus.Value = ((Label)gvrow.FindControl("lblstatus")).Text;
        string dates = ((Label)gvrow.FindControl("lblcreatedat")).Text;
        DateTime dat = Convert.ToDateTime(dates.ToString());
         LinkButton Userid = (LinkButton)gvrow.FindControl("lnkReceivedNumber");
         Label cash = (Label)gvrow.FindControl("lblTotalPendingSettlementAmt");
        Label FinalBill = (Label)gvrow.FindControl("FinalBillID");
         txtcashexp.Text = cash.Text.ToString();
      //  gvAllUsers.SelectedIndex = gvrow.RowIndex;
         HiddenField finalbillID = (HiddenField)gvrow.FindControl("hdnFinalBillID");
            //   string finalbill = ((Label)gvrow.FindControl("hdnFinalBillID")).Text;
            //string FinalBill = finalbillID.Value;
            //string[] a = FinalBill.Split('/');
         hdnFinalBill.Value = gvrow.Cells[4].Text;
            //   clear();
            //  string FinalBill = (LinkButton)gvrow.FindControl("lnkReceivedNumber").ToString();
        //string finalbill = gvrow.Cells[1].Text;
        
     //   lbluserid.Text = gvrow.Cells[4].Text;//   hdnuserid.Value = e.Row.Cells[4].Text;
        hdnuserid.Value = gvrow.Cells[4].Text;
        List<CashClosureDenominationDetail> lstCCDenoDetailssplit = new List<CashClosureDenominationDetail>();
        //    var cashstatus = lstCCDenoDetails.Find(p => p.UserID == Convert.ToInt64(hdnuserid.Value.ToString())).CashStatus;
    //    txtSettledAmt.Text = "0.00";
        hdnDenomination.Value = "0";
        lblgvPaymentDetails.Visible = false;
        lblgvRefundDetails.Visible = false;
        lblgvBillDetails.Visible = false;
        Panel3.Visible = false;
        List<ReceivedAmount> lstINDIPAmtReceivedDetails = new List<ReceivedAmount>();
      //  totalAmount = 0;
      //  refundAmount = 0;
     //   drAmount = 0;
      //  TotalIncAmount = 0;
      //  gvBillDetails.Visible = true;
        gvBillDetails.Visible = false;
        btnSave.Enabled = true;
      //  TotalPendingSettledAmount = 0;
        string sRcvdFromtime = string.Empty;
        string sRcvdTotime = string.Empty;
        string sRefundFromtime = string.Empty;
        string sRefundTotime = string.Empty;
        string sMinStartTime = string.Empty;
        string sMaxEndTime = string.Empty;

        //DateTime pFDT = Convert.ToDateTime(new BasePage().OrgDateTimeZone);
        //DateTime pTDT = Convert.ToDateTime(new BasePage().OrgDateTimeZone);

        pFDT = Convert.ToDateTime(txtFromDate1.Text);
        pTDT = Convert.ToDateTime(txtToDate.Text);
        int locationid;
        if (ddlLocation.SelectedValue == "-----All-----")
        {
            locationid = 0;

        }
        else
        {
            locationid = Convert.ToInt32(ddlLocation.SelectedValue);

        }
        string DispNoPay = Resources.Admin_ClientDisplay.Admin_BillSettlement_aspx_09 == null ? "No Payments Made" : Resources.Admin_ClientDisplay.Admin_BillSettlement_aspx_09;
        string DispNoAmount = Resources.Admin_ClientDisplay.Admin_BillSettlement_aspx_06 == null ? "No Amount Received From patient's" : Resources.Admin_ClientDisplay.Admin_BillSettlement_aspx_06;
        string DispNoamt = Resources.Admin_ClientDisplay.Admin_BillSettlement_aspx_07 == null ? "No amount received" : Resources.Admin_ClientDisplay.Admin_BillSettlement_aspx_07;
        string DispNoRefun = Resources.Admin_ClientDisplay.Admin_BillSettlement_aspx_08 == null ? " No refunds Made" : Resources.Admin_ClientDisplay.Admin_BillSettlement_aspx_08;
        long lUserID = Int64.Parse(ddlUser.SelectedValue);
        List<ReceivedAmount> lstPaymentDetails = new List<ReceivedAmount>();
        List<AmountReceivedDetails> lstreceivedTypes = new List<AmountReceivedDetails>();
        List<AmountReceivedDetails> lstIncSourcePaidDetails = new List<AmountReceivedDetails>();
        //    List<CurrencyMaster> lstCurrencyMaster = new List<CurrencyMaster>();

        //   string date1 = gvrow.Cells[1].Text;
        objBillingEngine = new BillingEngine(base.ContextInfo);
        retval = objBillingEngine.GetAmountReceivedDenoDetails(lUserID, OrgID, pFDT, pTDT, locationid,
                        out lstAmountReceivedDetails,
                        out lstCCDenoDetails,
                        out lstAmountRefundDetails,
                        out lstPaymentDetails,
                        out totalAmount,
                        out refundAmount, out cancellationAmount,
                        out sRcvdFromtime,
                        out sRcvdTotime,
                        out sRefundFromtime,
                        out sRefundTotime,
                        out sMinStartTime,
                        out sMaxEndTime,
                        out drAmount,
                        out othersAmount,
                        out TotalIncAmount,
                        out lstINDAmtReceivedDetails,
                        out lstINDIPAmtReceivedDetails,
                        out lstreceivedTypes,
                        out lstSplitDetails,
                        out lstIncSourcePaidDetails,
                        out lstCurrencyInHand,
                        out lstCCDeno,
                        out TotalPendingSettledAmount
                        );
        //if (retval == 0)
        //{
        //    lstCCDenoDetailssplit = lstCCDenoDetails
        // .Where(item => (item.UserID == Convert.ToInt64(hdnuserid.Value) && item.FinalBillID == Convert.ToInt64(hdnFinalBill.Value))).ToList();//(item.FinalBillID >= dat && item.SettleDate <= dat)).ToList();
        //}
        if (retval == 0)
        {
            lstCCDenoDetailssplit = lstCCDenoDetails
         .Where(item => (item.UserID == Convert.ToInt64(hdnuserid.Value) && item.ClosureID == Convert.ToInt64(hdnClosureID.Value)))
         .ToList();//&& DateTime.Compare(item.SettleDate, dat)  <= 0)).ToList(); //(item.SettleDate.ToString("dd/MM/yyyy") >= dat.ToString("dd/MM/yyyy") && item.SettleDate.ToString("dd/MM/yyyy") <= dat.ToString("dd/MM/yyyy")))).ToList();//(item.FinalBillID >= dat && item.SettleDate <= dat)).ToList();

            //foreach (var itema in lstCCDenoDetails)
            //{





            //}
        
        
        
        
        
        }
       //  && item.CreatedAt == dat)
        if (lstCCDenoDetailssplit.Count > 0 && hdnclosurestatus.Value.ToString() == "Closed")
        {
            foreach (var item in lstCCDenoDetailssplit)
            {


                txtcashdiff.Text = item.CashDifference.ToString("0.00");
                txtcashexp.Text = item.CashExpected.ToString("0.00");
                 
                txtcountamt.Text = item.CashCounted.ToString("0.00");



    //if (item.DenoId == 1) //100
    //{
    //    txtfiftypaise.Text = item.CurrencyCount.ToString();
    //        lblfftypa.Text=item.SumValueCurrencyCount.ToString();
    //}
             if (item.DenoId == 2) //200
    {
                 txtone.Text = item.CurrencyCount.ToString();
        lblonrup.Text= item.SumValueCurrencyCount.ToString();

                }
                if (item.DenoId == 3)//500
                {
                    txttwo.Text = item.CurrencyCount.ToString();
                    lbltwrup.Text = item.SumValueCurrencyCount.ToString();

                }
                if (item.DenoId == 4)//1000
                {
                    txtfive.Text = item.CurrencyCount.ToString();
                    lblfiverup.Text = item.SumValueCurrencyCount.ToString();
                }
                if (item.DenoId == 5)//2000
                {
                    txtten.Text = item.CurrencyCount.ToString();
                    lbltenrup.Text = item.SumValueCurrencyCount.ToString();
                    
                }
                if (item.DenoId == 6)//5000
                {
                    txttwenty.Text = item.CurrencyCount.ToString();

                    lbltwtyrup.Text = item.SumValueCurrencyCount.ToString();
                   
                }
                if (item.DenoId == 7)//10000
                {
                    txtfifty.Text = item.CurrencyCount.ToString();
                    lblfftyrup.Text = item.SumValueCurrencyCount.ToString();
                }
                if (item.DenoId == 8)//20000
                {
                    txthund.Text = item.CurrencyCount.ToString();
                    lblhundrup.Text = item.SumValueCurrencyCount.ToString();

                }
                if (item.DenoId == 9)//50000
                {
                    txttwohund.Text = item.CurrencyCount.ToString();
                    lbltwohundrup.Text = item.SumValueCurrencyCount.ToString();
                }
                if (item.DenoId == 10)//100000
                {
                    txtfivehund.Text = item.CurrencyCount.ToString();
                    lblfivehundrup.Text = item.SumValueCurrencyCount.ToString();

                }
                if (item.DenoId == 11)//200000
                {
                    txtoneth.Text = item.CurrencyCount.ToString();
                    lblonethrup.Text = item.SumValueCurrencyCount.ToString();

                }
                if (item.DenoId == 12)//500000
                {
                    txttwothous.Text = item.CurrencyCount.ToString();
                    lbltwothrup.Text = item.SumValueCurrencyCount.ToString();
                }


            }
        }

         List<CurrencyMaster> lstCurrencyMaster = new List<CurrencyMaster>();
         try
         {
             objBillingEngine = new BillingEngine(base.ContextInfo);
             retval = objBillingEngine.GetCurrencyForOrgMappingCashClosureDeno(OrgID, out  lstCurrencyMaster);
             if (retval == 0)
             {
                 if (lstCurrencyMaster.Count > 0)
                 {
                     lbltwoth.Text = lstCurrencyMaster[0].MinorCurrencyDisplayText;
                     lbloneth.Text = lstCurrencyMaster[1].MinorCurrencyDisplayText;
                     lblfivehund.Text = lstCurrencyMaster[2].MinorCurrencyDisplayText;
                     lbltwohund.Text = lstCurrencyMaster[3].MinorCurrencyDisplayText;
                     lblhund.Text = lstCurrencyMaster[4].MinorCurrencyDisplayText;
                     lblfifty.Text = lstCurrencyMaster[5].MinorCurrencyDisplayText;
                     lbltwenty.Text = lstCurrencyMaster[6].MinorCurrencyDisplayText;
                     lblten.Text = lstCurrencyMaster[7].MinorCurrencyDisplayText;
                     lblfive.Text = lstCurrencyMaster[8].MinorCurrencyDisplayText;
                     lbltwo.Text = lstCurrencyMaster[9].MinorCurrencyDisplayText;
                     lblone.Text = lstCurrencyMaster[10].MinorCurrencyDisplayText;
                 //    lblfiftypaise.Text = lstCurrencyMaster[11].MinorCurrencyDisplayText;
                   
                 
                    
                 }
             }
            
         }
         catch (Exception ex)
         {
             CLogger.LogError("Error While loading Admin POS Bill Settlement.", ex);
             // ErrorDisplay1.ShowError = true;
             //ErrorDisplay1.Status = "There was a problem. Please contact system administrator";
         }
         this.ModalPopupExtender1.Show();
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        DataTable dt = new DataTable();//new DataColumn("CashClosureDenoID"),
        dt.Columns.AddRange(new DataColumn[17] {  new DataColumn("ClosureID"), new DataColumn("UserID"), 
       
        new DataColumn("OrgID"),new DataColumn("DenoId"),new DataColumn("CurrencyCount"),new DataColumn("SumValueCurrencyCount"),
        new DataColumn("SettleDate"),new DataColumn("CashStatus"),new DataColumn("CashExpected"),new DataColumn("CashCounted"),
        new DataColumn("CashDifference"),new DataColumn( "CashRegister"),new DataColumn(
        "CashDeposited"),new DataColumn(
        "Createdby"),new DataColumn(
        "Createdat "),new DataColumn(
        "ModifiedBy"),new DataColumn(
        "ModifiedAt ")});
        dt.Rows.Add(Convert.ToInt32(hdnFinalBill.Value), hdnuserid.Value.ToString(), OrgID, Label14.Text, txttwothous.Text, lbltwothrup.Text, "", "Closed", txtcashexp.Text, txtcountamt.Text, txtcashdiff.Text, 0, txtcashexp.Text, Convert.ToInt64(LID), "", 0, "");
        dt.Rows.Add(Convert.ToInt32(hdnFinalBill.Value), hdnuserid.Value.ToString(), OrgID, Label20.Text, txtoneth.Text, lblonethrup.Text, "", "Closed", txtcashexp.Text, txtcountamt.Text, txtcashdiff.Text, 0, txtcashexp.Text, Convert.ToInt64(LID), "", 0, "");
        dt.Rows.Add(Convert.ToInt32(hdnFinalBill.Value), hdnuserid.Value.ToString(), OrgID, Label15.Text, txtfivehund.Text, lblfivehundrup.Text, "", "Closed", txtcashexp.Text, txtcountamt.Text, txtcashdiff.Text, 0, txtcashexp.Text, Convert.ToInt64(LID), "", 0, "");
        dt.Rows.Add(Convert.ToInt32(hdnFinalBill.Value), hdnuserid.Value.ToString(), OrgID, Label21.Text, txttwohund.Text, lbltwohundrup.Text,  "", "Closed", txtcashexp.Text, txtcountamt.Text, txtcashdiff.Text, 0, txtcashexp.Text, Convert.ToInt64(LID), "", 0, "");
        dt.Rows.Add(Convert.ToInt32(hdnFinalBill.Value), hdnuserid.Value.ToString(), OrgID, Label16.Text, txthund.Text, lblhundrup.Text, "", "Closed", txtcashexp.Text, txtcountamt.Text, txtcashdiff.Text, 0, txtcashexp.Text, Convert.ToInt64(LID), "", 0, "");
        dt.Rows.Add(Convert.ToInt32(hdnFinalBill.Value), hdnuserid.Value.ToString(), OrgID, Label22.Text, txtfifty.Text, lblfftyrup.Text, "", "Closed", txtcashexp.Text, txtcountamt.Text, txtcashdiff.Text, 0, txtcashexp.Text, Convert.ToInt64(LID), "", 0, "");
        dt.Rows.Add(Convert.ToInt32(hdnFinalBill.Value), hdnuserid.Value.ToString(), OrgID, Label17.Text, txttwenty.Text, lbltwtyrup.Text,  "", "Closed", txtcashexp.Text, txtcountamt.Text, txtcashdiff.Text, 0, txtcashexp.Text, Convert.ToInt64(LID), "", 0, "");
        dt.Rows.Add(Convert.ToInt32(hdnFinalBill.Value), hdnuserid.Value.ToString(), OrgID, Label23.Text, txtten.Text, lbltenrup.Text, "", "Closed", txtcashexp.Text, txtcountamt.Text, txtcashdiff.Text, 0, txtcashexp.Text, Convert.ToInt64(LID), "", 0, "");
        dt.Rows.Add(Convert.ToInt32(hdnFinalBill.Value), hdnuserid.Value.ToString(), OrgID, Label18.Text, txtfive.Text, lblfiverup.Text, "", "Closed", txtcashexp.Text, txtcountamt.Text, txtcashdiff.Text, 0, txtcashexp.Text, Convert.ToInt64(LID), "", 0, "");
        dt.Rows.Add(Convert.ToInt32(hdnFinalBill.Value), hdnuserid.Value.ToString(), OrgID, Label24.Text, txttwo.Text, lbltwrup.Text, "", "Closed", txtcashexp.Text, txtcountamt.Text, txtcashdiff.Text, 0, txtcashexp.Text, Convert.ToInt64(LID), "", 0, "");
        dt.Rows.Add(Convert.ToInt32(hdnFinalBill.Value), hdnuserid.Value.ToString(), OrgID, Label19.Text, txtone.Text, lblonrup.Text, "", "Closed", txtcashexp.Text, txtcountamt.Text, txtcashdiff.Text, 0, txtcashexp.Text, Convert.ToInt64(LID), "", 0, "");
      //  dt.Rows.Add(Convert.ToInt32(hdnFinalBill.Value), hdnuserid.Value.ToString(), OrgID, Label25.Text, txtfiftypaise.Text, lblfftypa.Text, "", "Closed", txtcashexp.Text, txtcountamt.Text, txtcashdiff.Text, 0, txtcashexp.Text, Convert.ToInt64(LID), "", 0, "");


        GridView1.DataSource = dt;
        GridView1.DataBind();
       
        string sAllUsersSelected = string.Empty;
        ContextInfo.AdditionalInfo = ddlLocation.SelectedValue.ToString();
        try
        {
            if (txtcashexp.Text != "0" || txtcashexp.Text != "0.00")
            {
                lstAmountClosure = new List<AmountClosureDetails>();
//totalAmount = decimal.Parse(lblTotal.Text);
             //   totalAmount = decimal.Parse(txtcashexp.Text);
                decimal settledAmt = 0;
                settledAmt = decimal.Parse(txtcountamt.Text);
             //   totalAmount = decimal.Parse(txtcountamt.Text) + decimal.Parse(lblTotalPendingSettledAmt.Text);
                decimal totalAmount = 0;
                totalAmount = decimal.Parse(txtcashexp.Text);
                refundAmount = decimal.Parse(lblRefund.Text);
                sstatus = "Closed";
                int CreatedBYID = Int32.Parse(LID.ToString());
                ICreatedforUserID = Int32.Parse(hdnuserid.Value.ToString());  //Int32.Parse(ddlUser.SelectedValue.ToString());
                objBillingEngine = new BillingEngine(base.ContextInfo);
                //if (ddlUser.SelectedValue != "0")
                //{
                DataTable dtClosureDenoDetails = dt;
                DataTable dtAmountReceived = GetAmountReceivedIDTable(out sAllUsersSelected, gvBillDetails, gvAllUsers, true, "");
                DataTable dtAmountRefund = GetAmountReceivedIDTable(out sAllUsersSelected, gvRefundDetails, gvAllUsersRefund, false, "");
                DataTable dtPayments = GetAmountReceivedIDTable(out sAllUsersSelected, gvPaymentDetails, gvAllUsersPayments, false, "AmtRec");

                retval = objBillingEngine.InsertAmountClosureDenoDetails((decimal)totalAmount, (decimal)settledAmt, sstatus, CreatedBYID,
                                                                     ICreatedforUserID, CreatedBYID, ICreatedforUserID, dtClosureDenoDetails,
                                                                     dtAmountReceived, dtAmountRefund, dtPayments, sAllUsersSelected,
                                                                     (decimal)refundAmount, "C");
                //}
                //else
                //{
                //DataTable dtClosureDetails = GetAmountClosureTable();
                //DataTable dtClosureDenoDetails = dt;
                //DataTable dtAmountReceived = GetAmountReceivedIDTable(out sAllUsersSelected, gvBillDetails, gvAllUsers, true, "");
                //DataTable dtAmountRefund = GetAmountReceivedIDTable(out sAllUsersSelected, gvRefundDetails, gvAllUsersRefund, false, "");
                //DataTable dtPayments = GetAmountReceivedIDTable(out sAllUsersSelected, gvPaymentDetails, gvAllUsersPayments, false, "");

                //retval = objBillingEngine.InsertAmountClosureDenoDetailsForAllUsers(dtClosureDenoDetails, dtClosureDetails, sstatus, CreatedBYID,
                //                                                                dtAmountReceived, dtAmountRefund, dtPayments, "C");
                //}
                BindListofUsers();
                ddlUser.SelectedIndex = 0;
                btnSearch_click(sender, e);
            }
        }
        catch (Exception ex)
        {
            CLogger.LogError("Error While saving Amount Closure Details.", ex);
            // ErrorDisplay1.ShowError = true;
            //ErrorDisplay1.Status = "There was a problem. Please contact system administrator";
        }

        this.ModalPopupExtender1.Hide();

    }
    private void BindGrid(DataTable dt, bool rotate)
    {
        GridView1.ShowHeader = !rotate;
        GridView1.DataSource = dt;
        GridView1.DataBind();
        if (rotate)
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                row.Cells[0].CssClass = "header";
            }
        }
    }
  
    private void clear()
    {
        txttwothous.Text = "0";

        txtoneth.Text = "0";
        txtfivehund.Text = "0";
        txthund.Text = "0";
        txttwohund.Text = "0";
        txtfifty.Text = "0";
        txtten.Text = "0";
        txttwenty.Text = "0";
        txtfive.Text = "0";
        txttwo.Text = "0";
        txtone.Text = "0";
       
      //  txtfiftypaise.Text = "0.00";
        lbltwothrup.Text = "0";
        lblonethrup.Text = "0";
        lblfivehundrup.Text = "0";
        lblhundrup.Text = "0";
        lbltwohundrup.Text = "0";
        lblfftyrup.Text = "0";
        lbltenrup.Text = "0";
        lbltwtyrup.Text = "0";
        lblfiverup.Text = "0";
        lbltwrup.Text = "0";
        lblonrup.Text = "0";
      
      //  lblfftypa.Text = "0.00";

        txtcountamt.Text = "0.00";
        txtcashexp.Text = "0.00";
        txtcashdiff.Text = "0.00";
    }
    private void Amountcalc()
    {

        int val2000 = 0;
        int val1000 = 0;
        int val500 = 0;
        int val100 = 0;
        int val200 = 0;
        int val50 = 0;
        int val10 = 0;
        int val20 = 0;
        int val5 = 0;
        int val2 = 0;
        int val1 = 0;
        double val025 = 0;
        double val050 = 0;

        double totamt = 0.00;
        List<CurrencyMaster> lstCurrencyMaster1 = new List<CurrencyMaster>();

        objBillingEngine = new BillingEngine(base.ContextInfo);
        retval = objBillingEngine.GetCurrencyForOrgMappingCashClosureDeno(OrgID, out  lstCurrencyMaster1);

        val2000 = lstCurrencyMaster1[0].CurrencyID * Int32.Parse(string.IsNullOrEmpty(txttwothous.Text) ? "0" : txttwothous.Text);
        val1000 = lstCurrencyMaster1[1].CurrencyID * Int32.Parse(string.IsNullOrEmpty(txtoneth.Text) ? "0" : txtoneth.Text);
        val500 = lstCurrencyMaster1[2].CurrencyID * Int32.Parse(string.IsNullOrEmpty(txtfivehund.Text) ? "0" : txtfivehund.Text);
        val100 = lstCurrencyMaster1[3].CurrencyID * Int32.Parse(string.IsNullOrEmpty(txttwohund.Text) ? "0" : txttwohund.Text);
        val200 = lstCurrencyMaster1[4].CurrencyID * Int32.Parse(string.IsNullOrEmpty(txthund.Text) ? "0" : txthund.Text);
        val50 = lstCurrencyMaster1[5].CurrencyID * Int32.Parse(string.IsNullOrEmpty(txtfifty.Text) ? "0" : txtfifty.Text);
        val10 = lstCurrencyMaster1[6].CurrencyID * Int32.Parse(string.IsNullOrEmpty(txttwenty.Text) ? "0" : txttwenty.Text);
        val20 = lstCurrencyMaster1[7].CurrencyID * Int32.Parse(string.IsNullOrEmpty(txtten.Text) ? "0" : txtten.Text);
        val5 = lstCurrencyMaster1[8].CurrencyID * Int32.Parse(string.IsNullOrEmpty(txtfive.Text) ? "0" : txtfive.Text);
        val2 = lstCurrencyMaster1[9].CurrencyID * Int32.Parse(string.IsNullOrEmpty(txttwo.Text) ? "0" : txttwo.Text);
        val1 = lstCurrencyMaster1[10].CurrencyID * Int32.Parse(string.IsNullOrEmpty(txtone.Text) ? "0" : txtone.Text);

        //val050 = lstCurrencyMaster1[11].CurrencyID * (double)Int32.Parse(string.IsNullOrEmpty(txtfiftypaise.Text) ? "0" : txtfiftypaise.Text);

        Label14.Text =  lstCurrencyMaster1[0].CurrencyName;
        Label20.Text = lstCurrencyMaster1[1].CurrencyName;
        Label15.Text = lstCurrencyMaster1[2].CurrencyName;
        Label21.Text = lstCurrencyMaster1[3].CurrencyName;
        Label16.Text = lstCurrencyMaster1[4].CurrencyName;
        Label22.Text = lstCurrencyMaster1[5].CurrencyName;
        Label17.Text = lstCurrencyMaster1[6].CurrencyName;
        Label23.Text = lstCurrencyMaster1[7].CurrencyName;
        Label18.Text = lstCurrencyMaster1[8].CurrencyName;
        Label24.Text = lstCurrencyMaster1[9].CurrencyName;
        Label19.Text = lstCurrencyMaster1[10].CurrencyName;
     //   Label25.Text = lstCurrencyMaster1[11].CurrencyName;

        lbltwothrup.Text = val2000.ToString();
        lblonethrup.Text = val1000.ToString();
        lblfivehundrup.Text = val500.ToString();
        lbltwohundrup.Text = val100.ToString();
        lblhundrup.Text = val200.ToString(); 
     //   lbltwohundrup.Text = val200.ToString();
 
        lblfftyrup.Text = val50.ToString();
        lbltwtyrup.Text = val10.ToString();
        lbltenrup.Text = val20.ToString();
      
        lblfiverup.Text = val5.ToString();
        lbltwrup.Text = val2.ToString();
        lblonrup.Text = val1.ToString();
     
     //   lblfftypa.Text = val050.ToString();
        totamt = val2000 + val1000 + val500 + val100 + val200 + val50 + val20 + val10 + val5 + val2 + val1 + val025 + val050;
        txtcountamt.Text = totamt.ToString("0.00");
        decimal cashexp = Convert.ToDecimal(txtcashexp.Text);
        decimal diff = Convert.ToDecimal(cashexp) - Convert.ToDecimal(totamt);
        txtcashdiff.Text = diff.ToString();
        
        //  ModalPopupDeno.Show();
        this.ModalPopupExtender1.Show();
    }
    private DataTable GetAmountClosureDenoTable()
    {
        System.Data.DataTable dt = new DataTable();
        try
        {
           
        //    DataColumn dbCol1 = new DataColumn("CashClosureDenoID");
            DataColumn dbCol2 = new DataColumn("ClosureID");
            DataColumn dbCol3 = new DataColumn("UserID");
            DataColumn dbCol4 = new DataColumn("OrgID");
            DataColumn dbCol5 = new DataColumn("DenoId");
            DataColumn dbCol6 = new DataColumn("CurrencyCount");
            DataColumn dbCol7 = new DataColumn("SumValueCurrencyCount");
            DataColumn dbCol8 = new DataColumn("SettleDate");
            DataColumn dbCol9 = new DataColumn("CashStatus");
            DataColumn dbCol10 = new DataColumn("CashExpected");
            DataColumn dbCol11 = new DataColumn("CashCounted");
            DataColumn dbCol12 = new DataColumn("CashDifference");
            DataColumn dbCol13 = new DataColumn("CashRegister");
            DataColumn dbCol14 = new DataColumn("CashDeposited");
            DataColumn dbCol15 = new DataColumn("Createdby");
            DataColumn dbCol16 = new DataColumn("Createdat");
            DataColumn dbCol17 = new DataColumn("ModifiedBy");
            DataColumn dbCol18 = new DataColumn("ModifiedAt");
          
            //add columns
          //  dt.Columns.Add(dbCol1);
            dt.Columns.Add(dbCol2);
           
            dt.Columns.Add(dbCol3);
            dt.Columns.Add(dbCol4);
            dt.Columns.Add(dbCol5);
            dt.Columns.Add(dbCol6);
            dt.Columns.Add(dbCol7);
            dt.Columns.Add(dbCol8);
            dt.Columns.Add(dbCol9);
            dt.Columns.Add(dbCol10);
            dt.Columns.Add(dbCol11);
            dt.Columns.Add(dbCol12);
            dt.Columns.Add(dbCol13);
            dt.Columns.Add(dbCol14);

            dt.Columns.Add(dbCol15);
            dt.Columns.Add(dbCol16);
            dt.Columns.Add(dbCol17);
            dt.Columns.Add(dbCol18);
          


            DataRow dr;
            int iUCount = 0;
        //    int iRefundCount = 0;
        //    int iUPaymenstCount = 0;
            iUCount = gvAllUsers.Rows.Count;
         //   iRefundCount = gvAllUsersPayments.Rows.Count;
        //    iUPaymenstCount = gvAllUsersPayments.Rows.Count;

            dr = dt.NewRow();
            //foreach (GridViewRow gr in gvAllUsers.Rows)
            //{

            //DataTable dt = new DataTable();
            //for (int i = 0; i < GridView1.Columns.Count; i++)
            //{
            //    dt.Columns.Add("column" + i.ToString());
            //}
            //foreach (GridViewRow row in GridView1.Rows)
            //{
            //    DataRow dr = dt.NewRow();
            //    for (int j = 0; j < GridView1.Columns.Count; j++)
            //    {
            //        dr["column" + j.ToString()] = row.Cells[j].Text;
            //    }

            //    dt.Rows.Add(dr);
            //}
                  foreach (GridViewRow gr1 in GridView1.Rows)
            {       
              
              
			//   dr["CashClosureDenoID"] =gr1.Cells[0].Text;
                       dr["ClosureID"] =gr1.Cells[1].Text;
                      dr["UserID"] = gr1.Cells[2].Text;
                     dr["OrgID"] =OrgID;
                dr["DenoId"] =gr1.Cells[4].Text;
                dr["CurrencyCount"] =gr1.Cells[5].Text;
                dr["SumValueCurrencyCount"] =gr1.Cells[6].Text;
                dr["SettleDate"] =gr1.Cells[7].Text;
                  dr["CashStatus"] = "Closed";
                dr["CashExpected"] =gr1.Cells[9].Text;
                dr["CashCounted"] =gr1.Cells[10].Text;
                dr["CashDifference"] =gr1.Cells[11].Text;
                dr["CashRegister"] =gr1.Cells[12].Text;
                dr["CashDeposited"] =gr1.Cells[13].Text;
                dr["CreatedBy"] =gr1.Cells[14].Text;
                dr["CreatedAt"] =gr1.Cells[15].Text;
                dr["ModifiedBy"] =gr1.Cells[16].Text;
                dr["ModifiedAt"] = gr1.Cells[17].Text;
                dt.Rows.Add(dr);
		
                
                  }
              
         //   }

           
        }
        catch (Exception ex)
        {
            CLogger.LogError("Error in GetAmountClosureDenoTable", ex);
        }
        return dt;

    }
    protected void txttwothous_TextChanged(object sender, EventArgs e)
    {

        Amountcalc();
        // this.ModalPopupExtender1.Show();


    }
    protected void txtoneth_TextChanged(object sender, EventArgs e)
    {

        Amountcalc();
        //  
        //  this.ModalPopupExtender1.Show();



    }
    protected void txtfivehund_TextChanged(object sender, EventArgs e)
    {

        Amountcalc();
        //  
        //  this.ModalPopupExtender1.Show();



    }
    protected void txthund_TextChanged(object sender, EventArgs e)
    {

        Amountcalc();
        //  

        //  this.ModalPopupExtender1.Show();


    }
    protected void txttwohund_TextChanged(object sender, EventArgs e)
    {

        Amountcalc();
        //  
        //  this.ModalPopupExtender1.Show();



    }
    protected void txtfifty_TextChanged(object sender, EventArgs e)
    {

        Amountcalc();
        //  
        //    this.ModalPopupExtender1.Show();



    }
    protected void txtten_TextChanged(object sender, EventArgs e)
    {

        Amountcalc();
        //  

        // this.ModalPopupExtender1.Show();


    }
    protected void txttwenty_TextChanged(object sender, EventArgs e)
    {

        Amountcalc();
        //  
        //    this.ModalPopupExtender1.Show();



    }
    protected void txtfive_TextChanged(object sender, EventArgs e)
    {

        Amountcalc();
        //  

        //   this.ModalPopupExtender1.Show();


    }
    protected void txttwo_TextChanged(object sender, EventArgs e)
    {

        Amountcalc();
        //  
        //   this.ModalPopupExtender1.Show();



    }
    protected void txtone_TextChanged(object sender, EventArgs e)
    {

        Amountcalc();
        //  

        // this.ModalPopupExtender1.Show();


    }
   
    protected void txtfiftypaise_TextChanged(object sender, EventArgs e)
    {

        Amountcalc();
        //  
        //  this.ModalPopupExtender1.Show();



    }
}
