using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Attune.Podium.BusinessEntities;
using Attune.Solution.DAL;
using Attune.Solution.BusinessComponent;
using Attune.Podium.Common;
using Attune.Kernel.PlatForm.Base;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Text.RegularExpressions;

public partial class ChangePassword : BasePage //System.Web.UI.Page
{

    public ChangePassword()
        : base("ChangePassword_ChangePassword_aspx")
    {
    }
    // protected void page_Init(object sender, EventArgs e)
    // {
    //     base.page_Init(sender, e);
    // }
    List<PasswordPolicy> pwdplcy = new List<PasswordPolicy>();
    List<Login_HIST> LHist = new List<Login_HIST>();
    string TransPass = string.Empty;
    string newTransPassword = string.Empty;
    string URL = string.Empty;
    string RedirectURL = string.Empty;
    string AccessPwd = string.Empty;
    string oldtransPassword = string.Empty;
    long returnCode = -1;
    int count = 0;
    int failcount = 0;
    DateTime PasswordExpiryDate = Convert.ToDateTime("1/1/1900 00:00:00");
    DateTime TransationPasswordExpiryDate = Convert.ToDateTime("1/1/1900 00:00:00");
    //change password from live
    int MinPasswordLength = 0;
    string AllowableSplChar1 = string.Empty;
    int UpperCharlen = 0;
    string AlphaNumericPattern = string.Empty;
    //
    //arun changes --- password scope changes
    string NewPswdScope = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        //change password from live
        MinPasswordLength = 6;
        AllowableSplChar1 = "@,$,*,#";
        UpperCharlen = 1;
        AlphaNumericPattern = "^[a-zA-Z0-9]*$";
        //
        // ErrorDisplay3.ShowError = false;
        hdnOrgID.Value = OrgID.ToString();
        hdnLoginName.Value = UserName.ToString();
        TransPass = GetConfigValue("PasswordAuthentication", OrgID);
        //arun changes - password scope changes
        NewPswdScope = GetConfigValue("IsPasswordScope", OrgID);
        hdnPasswordScope.Value = NewPswdScope;
        //
        //btnChange.Attributes.Add("onclick", "TextboxValidation()");
        Loadpwdplcycount();
        LoadExpiryDate();
        if (!IsPostBack)
        {
            txtOldpassword.Attributes.Add("IsMandatory", "1");
            txtNewpassword.Attributes.Add("IsMandatory", "1");
            txtConfirmpassword.Attributes.Add("IsMandatory", "1");
            ModalPopupExtender2.Hide();
            ViewState["PreviousPage"] = Request.UrlReferrer;
            if (!string.IsNullOrEmpty(Request.QueryString["ILF"]))
            {
                btnCancel.Visible = Request.QueryString["ILF"] == "Y" ? false : true;

            }
            if (Request.QueryString["URL"] != null && Request.QueryString.Count > 0)
            {
                ModalPopupExtender1.Show();
                divAccess.Style.Add("display", "block");
                divTpwd.Style.Add("display", "none");
                DivLpwd.Style.Add("display", "none");
                btnChange.Style.Add("display", "none");
                btnCancel.Style.Add("display", "none");
                btnupdate.Style.Add("display", "none");
                btnclose.Style.Add("display", "none");
                txtAccesspwd.Focus();
            }

            else
            {

                if (!String.IsNullOrEmpty(TransPass) && TransPass.Length > 0)
                {
                    if (TransPass == "Y")
                    {
                        ModalPopupExtender1.Hide();
                        divTpwd.Style.Add("display", "block");
                        DivLpwd.Style.Add("display", "block");
                        btnChange.Style.Add("display", "none");
                        btnCancel.Style.Add("display", "none");
                    }
                    else
                    {
                        ModalPopupExtender1.Hide();
                        //divTpwd.Style.Add("display", "block");
                        DivLpwd.Style.Add("display", "block");
                        btnChange.Style.Add("display", "block");
                        btnCancel.Style.Add("display", "block");
                        btnupdate.Style.Add("display", "none");
                        btnclose.Style.Add("display", "none");
                    }
                }
                else
                {
                    ModalPopupExtender1.Hide();
                    DivLpwd.Style.Add("display", "block");
                    divTpwd.Style.Add("display", "none");
                    btnChange.Style.Add("display", "block");
                    btnCancel.Style.Add("display", "block");
                    btnupdate.Style.Add("display", "none");
                    btnclose.Style.Add("display", "none");

                }
                //arun changes - password scope changes
                if (!String.IsNullOrEmpty(NewPswdScope) && NewPswdScope == "Y")
                {
                    divLpwdHint_copy.Style.Add("display", "none");
                    divLpwdHint_copy1.Style.Add("display", "block");
                }
                else
                {
                    divLpwdHint_copy.Style.Add("display", "block");
                    divLpwdHint_copy1.Style.Add("display", "none");
                }
                //
            }
            txtOldpassword.Focus();
           // ErrorDisplay1.Status = "";
          //  ErrorDisplay2.Status = "";
          //ErrorDisplay3.Status = "";
            //imgLogo.Src = LogoPath.Split('/')[1] + "/" + LogoPath.Split('/')[2] + "/" + LogoPath.Split('/')[3];
            string Cdisplayname = Resources.ChangePassword_ClientDisplay.ChangePassword_aspx_01;
            //if (RoleName == "Physician")
            if (RoleName == Cdisplayname)
            {
                //phyHeader.Visible = true;
               // Header1.Visible = false;
                //PatientHeader1.Visible = false;
            }
            else if (RoleName != RoleHelper.Physician && RoleName != RoleHelper.Patient)
            {
               // Header1.Visible = true;
               // phyHeader.Visible = false;
              //  PatientHeader1.Visible = false;
            }
            else if (RoleName == RoleHelper.Patient)
            {
                //Header1.Visible = false;
                //phyHeader.Visible = false;
            }

           // ErrorDisplay1.ShowError = false;
            if (Request.QueryString["ILF"] != null)
            {
                string lblmsg = Resources.ChangePassword_ClientDisplay.ChangePassword_aspx_06;
                string str = lblmsg;
                lblMsg.Visible = true;
                lblMsg.Text = str;

            }
            //arun retrive old password
            long Returncode = -1;
            string strPass = string.Empty;
            string TransPwrd = string.Empty;
            string LoginName = string.Empty;
            Users_BL LoginCheckdetails = new Users_BL(base.ContextInfo);
            Returncode = LoginCheckdetails.GetLoginUserName(LID, out LoginName, out strPass, out TransPwrd);

            string DecryptedString = string.Empty;
            Attune.Cryptography.CCryptography obj = new Attune.Cryptography.CCryptFactory().GetDecryptor();
            obj.Crypt(strPass, out DecryptedString);            
            hdnOldPasswordReturn.Value = DecryptedString;
            //
        }
        else
        {
            ModalPopupExtender1.Show();
        }
    }

    #region gettotaldays
    //TimeSpan timespan = Convert.ToDateTime("2012-06-27").Subtract(Convert.ToDateTime("2012-05-01"));
    //int result = timespan.Days;
    #endregion


    public void Loadpwdplcycount()
    {
        long returncode = -1;
        int count = -1;
        int Tcount = -1;
        List<PasswordPolicy> lstpwdplcy = new List<PasswordPolicy>();
        returncode = new Users_BL(base.ContextInfo).GetPasswordPolicytotalCount(OrgID, out count, out Tcount);

        hdnpwdplcycount.Value = count.ToString();
        hdntranspwdplcycount.Value = Tcount.ToString();

        if (hdnpwdplcycount.Value != "0" && hdntranspwdplcycount.Value != "0")
        {
            trplcy.Style.Add("display", "table-row");
            transplcy.Style.Add("display", "table-row");
            LoadTable(lstpwdplcy);

        }
        else if (hdnpwdplcycount.Value != "0")
        {
            trplcy.Style.Add("display", "table-row");
            transplcy.Style.Add("display", "none");
            LoadTable(lstpwdplcy);
        }
        else if (hdntranspwdplcycount.Value != "0")
        {
            trplcy.Style.Add("display", "none");
            transplcy.Style.Add("display", "table-row");
            LoadTable(lstpwdplcy);

        }

        else
        {
            LoadTable(lstpwdplcy);
            trplcy.Style.Add("display", "none");
            transplcy.Style.Add("display", "none");

        }



    }

    public void LoadExpiryDate()
    {
        long Returncode = -1;

        List<PasswordPolicy> pwdplcy = new List<PasswordPolicy>();
        List<PasswordPolicy> Transpwdplcy = new List<PasswordPolicy>();
        Returncode = new Users_BL(base.ContextInfo).GetPasswordValidityPeriod(OrgID, out pwdplcy, out Transpwdplcy);
        string CdisplayDays = Resources.ChangePassword_ClientDisplay.ChangePassword_aspx_02;
        string Cdisplayweeks = Resources.ChangePassword_ClientDisplay.ChangePassword_aspx_03;
        string CdisplayMonths = Resources.ChangePassword_ClientDisplay.ChangePassword_aspx_04;
        string CdisplayYears = Resources.ChangePassword_ClientDisplay.ChangePassword_aspx_05;
        if (pwdplcy.Count > 0)
        {
          
//            if (pwdplcy[0].ValidityPeriodType == "Days")
            if (pwdplcy[0].ValidityPeriodType == CdisplayDays)
            {
                DateTime startdate = Convert.ToDateTime(new BasePage().OrgDateTimeZone);

                DateTime expiryDate = startdate.AddDays(pwdplcy[0].ValidityPeriod);
                hdnpwdexpdate.Value = expiryDate.ToString();

            }
            else if (pwdplcy[0].ValidityPeriodType == Cdisplayweeks)
            {
                DateTime startdate = Convert.ToDateTime(new BasePage().OrgDateTimeZone);

                DateTime expiryDate = startdate.AddDays((pwdplcy[0].ValidityPeriod) * 7);
                hdnpwdexpdate.Value = expiryDate.ToString();

            }
            else if (pwdplcy[0].ValidityPeriodType == CdisplayMonths)
            {
                DateTime startdate = Convert.ToDateTime(new BasePage().OrgDateTimeZone);

                DateTime expiryDate = startdate.AddMonths(pwdplcy[0].ValidityPeriod);
                hdnpwdexpdate.Value = expiryDate.ToString();

            }
            else if (pwdplcy[0].ValidityPeriodType == CdisplayYears)
            {
                DateTime startdate = Convert.ToDateTime(new BasePage().OrgDateTimeZone);
                DateTime expiryDate = startdate.AddYears(pwdplcy[0].ValidityPeriod);
                hdnpwdexpdate.Value = expiryDate.ToString();

            }
        }
        if (Transpwdplcy.Count > 0)
        {
            if (Transpwdplcy[0].ValidityPeriodType == CdisplayDays)
            {
                DateTime transstartdate = Convert.ToDateTime(new BasePage().OrgDateTimeZone);

                DateTime transexpiryDate = transstartdate.AddDays(Transpwdplcy[0].ValidityPeriod);
                hdntranspwdexpdate.Value = transexpiryDate.ToString();

            }
            else if (Transpwdplcy[0].ValidityPeriodType == Cdisplayweeks)
            {
                DateTime transstartdate = Convert.ToDateTime(new BasePage().OrgDateTimeZone);

                DateTime transexpiryDate = transstartdate.AddDays((Transpwdplcy[0].ValidityPeriod) * 7);
                hdntranspwdexpdate.Value = transexpiryDate.ToString();
            }
            else if (Transpwdplcy[0].ValidityPeriodType == CdisplayMonths)
            {
                DateTime transstartdate = Convert.ToDateTime(new BasePage().OrgDateTimeZone);

                DateTime transexpiryDate = transstartdate.AddMonths(Transpwdplcy[0].ValidityPeriod);
                hdntranspwdexpdate.Value = transexpiryDate.ToString();

            }
            else if (Transpwdplcy[0].ValidityPeriodType == CdisplayYears)
            {
                DateTime transstartdate = Convert.ToDateTime(new BasePage().OrgDateTimeZone);
                DateTime transexpiryDate = transstartdate.AddYears(Transpwdplcy[0].ValidityPeriod);
                hdntranspwdexpdate.Value = transexpiryDate.ToString();

            }

        }




    }

    public void LoadTable(List<PasswordPolicy> lstpwdplcy)
    {
        try
        {
            long returncode = -1;
            returncode = new Users_BL(base.ContextInfo).GetPasswordpolicy(OrgID, out lstpwdplcy);

            if (lstpwdplcy.Count > 0)
            {
                foreach (PasswordPolicy objPP in lstpwdplcy)
                {
                    hdnRecords.Value += objPP.Type + "~" + objPP.PasswordLength + "~" + objPP.Splcharlen + "~" + objPP.Numcharlen + "~" + objPP.ValidityPeriodType + "~" + objPP.ValidityPeriod + "~" + objPP.PreviousPwdcount + "~" + objPP.Id + "^";
                }
            }
            ScriptManager.RegisterStartupScript(Page, this.GetType(), "IsDefault", "binddata();", true);

        }
        catch (Exception ex)
        {
            CLogger.LogError("Error in LoadPasswordPolicy", ex);
        }
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
    protected void btnChange_Click(object sender, EventArgs e)
    {

        //de-crypted password
        string actualoldpswd = DecryptStringAES(txtOldpassword.Text);
        txtOldpassword.Text = actualoldpswd;
        string actualnewpswd = DecryptStringAES(txtNewpassword.Text);
        txtNewpassword.Text = actualnewpswd;
        string actualcnfrmpswd = DecryptStringAES(txtConfirmpassword.Text);
        txtConfirmpassword.Text = actualcnfrmpswd;
        //
        bool IsCheck = true;
        IsCheck = PasswordValidation();
        //IsCheck = true;
        if (IsCheck && Page.IsValid)
        {
            try
            {
                if (hdnpwdplcycount.Value != "0")
                {                   
                    long returnpwd = -1;
                    long returncode = -1;
                    string oldPassword = string.Empty;
                    string newPassword = string.Empty;
                    oldPassword = txtOldpassword.Text;
                    newPassword = txtNewpassword.Text;

                string strEncOldPwd = string.Empty;
                string strEncNewPwd = string.Empty;
                Attune.Cryptography.CCryptography obj = new Attune.Cryptography.CCryptFactory().GetEncryptor();
                if (oldPassword != "")
                {
                    obj.Crypt(oldPassword, out strEncOldPwd);
                }
                oldPassword = strEncOldPwd;
                obj.Crypt(newPassword, out strEncNewPwd);
                newPassword = strEncNewPwd;
                int result = -1;


                Users_BL UsersBL = new Users_BL(base.ContextInfo);
                List<Login_HIST> LHist = new List<Login_HIST>();
                returnpwd = new Users_BL(base.ContextInfo).Checkpreviouspassword(LID, OrgID, newPassword, out result);

                if (result != 0)
                {
                    //arun changes
                    if (result == 1111)
                    {
                        ModalPopupExtender1.Hide();
                        ModalPopupExtender2.Hide();

                        lblPswdAlert.InnerText = "Password should not be exist of last 5";
                        txtNewpassword.Focus();
                        return;
                    }
                    else
                    {
                        lblPswdAlert.InnerText = "";

                        //alert(result);
                        ModalPopupExtender1.Hide();
                        ModalPopupExtender2.Hide();

                        string sPath = Resources.ChangePassword_AppMsg.ChangePassword_aspx_001 == null ? "Given Password Already Exist" : Resources.ChangePassword_AppMsg.ChangePassword_aspx_001;
                        ScriptManager.RegisterStartupScript(Page, this.GetType(), "login", "ShowAlertMsg('" + sPath + "');", true);
                        //ScriptManager.RegisterStartupScript(Page, this.GetType(), "login", "alert('Given Password Already Exist');", true);
                        txtOldpassword.Focus();
                        return;
                    }

                }

                if (hdnpwdexpdate.Value != "" && hdnpwdexpdate.Value != null)
                {
                    PasswordExpiryDate = Convert.ToDateTime(hdnpwdexpdate.Value);



                }



                returncode = new GateWay(base.ContextInfo).ChangePassword(LID, oldPassword, oldtransPassword, newPassword, newTransPassword, PasswordExpiryDate, TransationPasswordExpiryDate);

                if (returncode >= 0)
                {
                    //ErrorDisplay1.ShowError = false;
                    txtOldpassword.Text = string.Empty;
                    txtNewpassword.Text = string.Empty;
                    Session.Add("IsFirstLogin", "Y");
                    ModalPopupExtender1.Hide();
                    ModalPopupExtender2.Show();




                    }
                    else
                    {
                        //ErrorDisplay1.ShowError = true;
                        //chkShowPassword.Checked = false;
                        ScriptManager.RegisterStartupScript(Page, this.GetType(), "Password", "InvalidPassword();", true);
                        //LogErrorEvent.EventLog(Convert.ToInt64(LogErrorEvent.Event.PasswordUpdateFailed), "Password Updation Failed", RoleName, "Invalid old Password has been given", LID, OrgName);
                        Attuneheader.LoadErrorMsg("Password Updation Failed");
                        // ErrorDisplay1.Status = "Password Updation Failed";
                        ModalPopupExtender1.Hide();
                        ModalPopupExtender2.Hide();

                }

            }
            else
            {
                long returncode = -1;
                string oldPassword = string.Empty;
                string newPassword = string.Empty;
                oldPassword = txtOldpassword.Text;
                newPassword = txtNewpassword.Text;

                string strEncOldPwd = string.Empty;
                string strEncNewPwd = string.Empty;
                Attune.Cryptography.CCryptography obj = new Attune.Cryptography.CCryptFactory().GetEncryptor();
                if (oldPassword != "")
                {
                    obj.Crypt(oldPassword, out strEncOldPwd);
                }
                oldPassword = strEncOldPwd;
                obj.Crypt(newPassword, out strEncNewPwd);
                newPassword = strEncNewPwd;

                returncode = new GateWay(base.ContextInfo).ChangePassword(LID, oldPassword, oldtransPassword, newPassword, newTransPassword, PasswordExpiryDate, TransationPasswordExpiryDate);

                if (returncode >= 0)
                {
                  //  ErrorDisplay1.ShowError = false;
                    txtOldpassword.Text = string.Empty;
                    txtNewpassword.Text = string.Empty;
                    Session.Add("IsFirstLogin", "Y");
                    ModalPopupExtender1.Hide();
                    ModalPopupExtender2.Show();
                    btnpopClose.Attributes.Add("autofocus", "");
                    btnpopClose.TabIndex = 0;
                        
                  
                }
                else
                {
                  //  ErrorDisplay1.ShowError = true;
				   //LogErrorEvent.EventLog(Convert.ToInt64(LogErrorEvent.Event.PasswordUpdateFailed), "Password Updation Failed", RoleName, "Invalid old Password has been given", LID, OrgName);
                        ScriptManager.RegisterStartupScript(Page, this.GetType(), "Password", "alert('Provide Valid Old Password');", true);
                        Attuneheader.LoadErrorMsg("Password Updation Failed");
                        //chkShowPassword.Checked = false;
                   // ErrorDisplay1.Status = "Password Updation Failed";
                    ModalPopupExtender1.Hide();
                    ModalPopupExtender2.Hide();
                }

            }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Update Password", ex);
            }
        }
        else
        {
            Response.Redirect("~/ErrorHandling/Error.aspx", true);
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        try
        {
            List<Role> lstUserRole = new List<Role>();
            string path = string.Empty;
            Role role = new Role();
            role.RoleID = RoleID;
            lstUserRole.Add(role);
            returnCode = new Navigation().GetLandingPage(lstUserRole, out path);
            Response.Redirect(Request.ApplicationPath + path, true);
        }
        catch (System.Threading.ThreadAbortException tae)
        {
            string thread = tae.ToString();
        }

    }

    protected void btnupdate_Click(object sender, EventArgs e)
    {

        try
        {
            if (hdnpwdplcycount.Value != "0")
            {
                long returnpwd = -1;
                long returncode = -1;
                int result = -1;
                string oldPassword = string.Empty;
                string newPassword = string.Empty;
                oldPassword = txtOldpassword.Text;
                newPassword = txtNewpassword.Text;

                string strEncOldPwd = string.Empty;
                string strEncNewPwd = string.Empty;
                Attune.Cryptography.CCryptography obj = new Attune.Cryptography.CCryptFactory().GetEncryptor();
                if (oldPassword != "")
                {
                    obj.Crypt(oldPassword, out strEncOldPwd);
                }
                oldPassword = strEncOldPwd;
                Attune.Cryptography.CCryptography obj2 = new Attune.Cryptography.CCryptFactory().GetEncryptor();
                if (newPassword != "")
                {
                    obj2.Crypt(newPassword, out strEncNewPwd);
                }
                newPassword = strEncNewPwd;

                Users_BL UsersBL = new Users_BL(base.ContextInfo);
                List<Login_HIST> LHist = new List<Login_HIST>();
                returnpwd = new Users_BL(base.ContextInfo).Checkpreviouspassword(LID, OrgID, newPassword, out result);

                if (result != 0)
                {
                    ModalPopupExtender1.Hide();
                    ModalPopupExtender2.Hide();
                    string sPath = "ChangePassword\\\\ChangePassword.aspx_3";
                    ScriptManager.RegisterStartupScript(Page, this.GetType(), "login", "ShowAlertMsg('" + sPath + "');", true);
                    //ScriptManager.RegisterStartupScript(Page, this.GetType(), "login", "alert('Given Password Already Exist');", true);
                    txtOldpassword.Focus();
                    return;

                }



                if (TransPass == "Y")
                {

                    string strEncNewTransPwd = string.Empty;
                    oldtransPassword = Txtoldtranspwd.Text;
                    newTransPassword = TxtNewtranspwd.Text;
                    string strEncOldtransPwd = string.Empty;
                    Attune.Cryptography.CCryptography obj1 = new Attune.Cryptography.CCryptFactory().GetEncryptor();
                    if (oldtransPassword != "")
                    {
                        obj1.Crypt(oldtransPassword, out strEncOldtransPwd);
                    }
                    oldtransPassword = strEncOldtransPwd;
                    Attune.Cryptography.CCryptography obj4 = new Attune.Cryptography.CCryptFactory().GetEncryptor();
                    if (newTransPassword != "")
                    {
                        obj4.Crypt(newTransPassword, out strEncNewTransPwd);
                        newTransPassword = strEncNewTransPwd;
                    }
                    if (hdnpwdexpdate.Value != "" && hdnpwdexpdate.Value != null)
                    {
                        PasswordExpiryDate = Convert.ToDateTime(hdnpwdexpdate.Value);



                    }
                    if (hdntranspwdexpdate.Value != "" && hdntranspwdexpdate.Value != null)
                    {
                        TransationPasswordExpiryDate = Convert.ToDateTime(hdntranspwdexpdate.Value);


                    }
                    long transreturnpwd = -1;
                    int transresult = -1;
                    transreturnpwd = new Users_BL(base.ContextInfo).Checkprevioustransactionpassword(LID, OrgID, newTransPassword, out transresult);

                    if (transresult != 0)
                    {
                        ModalPopupExtender1.Hide();
                        ModalPopupExtender2.Hide();

                        string sPath = "ChangePassword\\\\ChangePassword.aspx_4";
                        ScriptManager.RegisterStartupScript(Page, this.GetType(), "login", "ShowAlertMsg('" + sPath + "');", true);
                        //ScriptManager.RegisterStartupScript(Page, this.GetType(), "login", "alert('Given Transaction Password Already Exist');", true);

                        txtOldpassword.Focus();
                        return;

                    }


                }



                returncode = new GateWay(base.ContextInfo).ChangePassword(LID, oldPassword, oldtransPassword, newPassword, newTransPassword, PasswordExpiryDate, TransationPasswordExpiryDate);
                ModalPopupExtender1.Hide();
                if (returncode >= 0)
                {
                    //ErrorDisplay1.ShowError = false;
                  //  ErrorDisplay2.ShowError = false;
                    txtOldpassword.Text = string.Empty;
                    txtNewpassword.Text = string.Empty;
                    Session.Add("IsFirstLogin", "Y");
                    ModalPopupExtender1.Hide();
                    ModalPopupExtender2.Show();


                }
                else
                {
                   // ErrorDisplay1.ShowError = true;
                     Attuneheader.LoadErrorMsg("Password Updation Failed");// ErrorDisplay1.Status = "Password Updation Failed";
                   // ErrorDisplay2.ShowError = true;
                  //  ErrorDisplay2.Status = "Transaction Password Updation Failed";
                    ModalPopupExtender1.Hide();
                    ModalPopupExtender2.Hide();
                }

                ModalPopupExtender1.Hide();
                ModalPopupExtender2.Hide();
            }
            else
            {
                long returncode = -1;
                string oldPassword = string.Empty;
                string newPassword = string.Empty;
                oldPassword = txtOldpassword.Text;
                newPassword = txtNewpassword.Text;

                string strEncOldPwd = string.Empty;
                string strEncNewPwd = string.Empty;
                Attune.Cryptography.CCryptography obj = new Attune.Cryptography.CCryptFactory().GetEncryptor();
                if (oldPassword != "")
                {
                    obj.Crypt(oldPassword, out strEncOldPwd);
                }
                oldPassword = strEncOldPwd;
                Attune.Cryptography.CCryptography obj2 = new Attune.Cryptography.CCryptFactory().GetEncryptor();
                if (newPassword != "")
                {
                    obj2.Crypt(newPassword, out strEncNewPwd);
                }
                newPassword = strEncNewPwd;

                if (TransPass == "Y")
                {

                    string strEncNewTransPwd = string.Empty;
                    oldtransPassword = Txtoldtranspwd.Text;
                    newTransPassword = TxtNewtranspwd.Text;
                    string strEncOldtransPwd = string.Empty;
                    Attune.Cryptography.CCryptography obj1 = new Attune.Cryptography.CCryptFactory().GetEncryptor();
                    if (oldtransPassword != "")
                    {
                        obj1.Crypt(oldtransPassword, out strEncOldtransPwd);
                    }
                    oldtransPassword = strEncOldtransPwd;
                    Attune.Cryptography.CCryptography obj4 = new Attune.Cryptography.CCryptFactory().GetEncryptor();
                    if (newTransPassword != "")
                    {
                        obj4.Crypt(newTransPassword, out strEncNewTransPwd);
                        newTransPassword = strEncNewTransPwd;
                    }



                }

                returncode = new GateWay(base.ContextInfo).ChangePassword(LID, oldPassword, oldtransPassword, newPassword, newTransPassword, PasswordExpiryDate, TransationPasswordExpiryDate);

                if (returncode >= 0)
                {
                   // ErrorDisplay1.ShowError = false;
                   // ErrorDisplay2.ShowError = false;
                    txtOldpassword.Text = string.Empty;
                    txtNewpassword.Text = string.Empty;
                    Session.Add("IsFirstLogin", "Y");
                    ModalPopupExtender1.Hide();
                    ModalPopupExtender2.Show();
                }
                else
                {
                    // ErrorDisplay1.ShowError = true;
                    Attuneheader.LoadErrorMsg("Password Updation Failed");                   // ErrorDisplay1.Status = "Password Updation Failed";
                    //ErrorDisplay2.ShowError = true;
                   // ErrorDisplay2.Status = "Transaction Password Updation Failed";
                    ModalPopupExtender1.Hide();
                    ModalPopupExtender2.Hide();
                }

            }
        }
        catch (Exception ex)
        {
            CLogger.LogError("Error while Update Password", ex);
        }
    }
    protected void btnclose_Click(object sender, EventArgs e)
    {
        try
        {
            List<Role> lstUserRole = new List<Role>();
            string path = string.Empty;
            Role role = new Role();
            role.RoleID = RoleID;
            lstUserRole.Add(role);
            returnCode = new Navigation().GetLandingPage(lstUserRole, out path);
            Response.Redirect(Request.ApplicationPath + path, true);
        }
        catch (System.Threading.ThreadAbortException tae)
        {
            string thread = tae.ToString();
        }

    }
    protected void btngo_Click(object sender, EventArgs e)
    {
        ModalPopupExtender2.Hide();
        long ReturnCode = -1;
        AccessPwd = txtAccesspwd.Text;
        string AccessPwdOutput = string.Empty;
        string strEncAccessPwd = string.Empty;
        Attune.Cryptography.CCryptography obj2 = new Attune.Cryptography.CCryptFactory().GetEncryptor();
        if (AccessPwd != "")
        {
            obj2.Crypt(AccessPwd, out strEncAccessPwd);
            AccessPwd = strEncAccessPwd;

            ReturnCode = new GateWay(base.ContextInfo).CheckTransPassword(LID, AccessPwd, out AccessPwdOutput);


            if (AccessPwd == AccessPwdOutput)
            {
                URL = Request.QueryString["URL"];
                RedirectURL = URL.Replace("'", "").Replace("^", "&");
                Response.Redirect(RedirectURL);

            }
            else
            {
                ModalPopupExtender1.Show();
                ModalPopupExtender2.Hide();

                //ErrorDisplay3.ShowError = true;
                Attuneheader.LoadErrorMsg("Transaction Password Incorrect");               // ErrorDisplay3.Status = "Transaction Password Incorrect";

            }



        }





    }

    protected void btncancelclose_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect(ViewState["PreviousPage"].ToString());
    }

    protected void btnpopClose_Click(object sender, EventArgs e)
    {
        ModalPopupExtender1.Hide();
        try
        {
            //ErrorDisplay1.ShowError = false;
            List<Role> lstUserRole = new List<Role>();
            string path = string.Empty;
            Role role = new Role();
            role.RoleID = RoleID;
            lstUserRole.Add(role);
            returnCode = new Navigation().GetLandingPage(lstUserRole, out path);
            string RedirectPath = Request.ApplicationPath + path;
            Response.Redirect(RedirectPath);
        }
        catch (System.Threading.ThreadAbortException tae)
        {
            string thread = tae.ToString();
        }

    }
    protected bool PasswordValidation()
    {
        bool Ischeck = true;
        MemberService PwdPolicyRule = new MemberService();
        List<PasswordPolicy> getPolicy = PwdPolicyRule.GetPasswordPolicyService(OrgID);
        //check new/confirm password have space
        Ischeck = Ischeck ? string.Compare(txtNewpassword.Text.Replace(" ", ""), txtNewpassword.Text) != 0 ? false : string.Compare(txtConfirmpassword.Text.Replace(" ", ""), txtConfirmpassword.Text) != 0 ? false : true : false;
        if (Ischeck && !string.IsNullOrEmpty(txtOldpassword.Text) && !string.IsNullOrEmpty(txtNewpassword.Text) && !string.IsNullOrEmpty(txtConfirmpassword.Text))
        {
            //check new/confirm password are same
            int valid = string.Compare(txtNewpassword.Text, txtConfirmpassword.Text);
            int valid1 = string.Compare(txtOldpassword.Text, txtNewpassword.Text);
            if (valid == 0 && valid1 != 0)
            {
                if (txtOldpassword.Text.Length <= 15)//if (CheckOldPassword(txtOldpassword.Text, getPolicy))
                {
                    // arun changes- password scope changes
                    if (!String.IsNullOrEmpty(NewPswdScope) && NewPswdScope == "Y")
                    {
                        Ischeck = true;
                        //if (!CheckPasswordNew(txtNewpassword.Text, getPolicy) || !CheckPasswordNew(txtConfirmpassword.Text, getPolicy))
                        //{
                        //    Ischeck = false;
                        //}
                    }
                    else
                    {
                        if (!CheckPassword(txtNewpassword.Text, getPolicy) || !CheckPassword(txtConfirmpassword.Text, getPolicy))
                        {
                            Ischeck = false;
                        }
                    }
                }
                else
                {
                    Ischeck = false;
                }
            }
            else
            {
                Ischeck = false;
            }
        }
        else
        {
            Ischeck = false;
        }
        return Ischeck;
    }

    public bool IsRegExpMatch(string Pattern, string Text)
    {
        Regex regExp = new Regex(Pattern);
        return regExp.IsMatch(Text);
    }
    //public bool CheckOldPassword(string password, List<PasswordPolicy> getPolicy)
    //{
    //    bool valid = true;
    //    Char[] letters = password.ToCharArray();
    //    String AllowableSplChar = getPolicy[0].AllowableSplChar;
    //    if (IsRegExpMatch(AlphaPattern, password))
    //    {
    //        if (getPolicy[0].Numcharlen > 0 || getPolicy[0].Splcharlen > 0)
    //        {
    //            valid = false;
    //        }

    //    }

    //    if (IsRegExpMatch(NumericPattern, password))
    //    {
    //        if (getPolicy[0].Splcharlen > 0 || getPolicy[0].Numcharlen == 0)
    //        {
    //            valid = false;
    //        }
    //    }

    //    if (IsRegExpMatch(AlphaNumericPattern, password))
    //    {
    //        if (getPolicy[0].Splcharlen > 0 || getPolicy[0].Numcharlen == 0)
    //        {
    //            valid = false;
    //        }
    //        if (valid)
    //        {
    //            int numLen = 0;
    //            CheckNumeric(password, out numLen);
    //            if (numLen < getPolicy[0].Numcharlen)
    //            {
    //                valid = false;

    //            }
    //        }
    //    }

    //    //if (!IsRegExpMatch(AlphaNumericPattern, password))
    //    else
    //    {
    //        if (getPolicy[0].Splcharlen > 0 || getPolicy[0].Numcharlen == 0)
    //        {
    //            valid = false;
    //        }
    //        if (valid)
    //        {
    //            int numLen = 0;
    //            CheckNumeric(password, out numLen);
    //            if (numLen < getPolicy[0].Numcharlen)
    //            {
    //                valid = false;
    //            }
    //        }
    //        Char[] splletters = password.ToCharArray();
    //        foreach (Char letter in splletters)
    //        {
    //            if (!IsRegExpMatch(AlphaNumericPattern, letter.ToString()))
    //            {
    //                string[] validSplChar = getPolicy[0].AllowableSplChar.Split(',');
    //                if (!validSplChar.Contains(letter.ToString()))//!char.IsLetterOrDigit(letter)
    //                {
    //                    valid = false;
    //                }
    //            }
    //        }

    //    }

    //    return valid;

    //}



    public bool CheckPassword(string password, List<PasswordPolicy> getPolicy)
    {
        bool valid = true;      

        if (valid && password.Length >= MinPasswordLength && password.Length <= getPolicy[0].PasswordLength)
        {
            Char[] letters = password.ToCharArray();
            String AllowableSplChar = AllowableSplChar1;

            if (valid)
            {
                int ucLen = 0;
                //check upper character length
                CheckUpperCase(password, out ucLen);
                if (ucLen < UpperCharlen)
                {
                    valid = false;
                }
            }
            if (valid)
            {
                int numLen = 0;
                //check numeric length
                CheckNumeric(password, out numLen);
                if (numLen < getPolicy[0].Numcharlen)
                {
                    valid = false;
                }
            }
            if (valid)
            {
                int splLen = 0;
                //check special character length
                Char[] splletters = password.ToCharArray();
                foreach (Char letter in splletters)
                {
                    if (!IsRegExpMatch(AlphaNumericPattern, letter.ToString()))
                    {
                        string[] validSplChar = AllowableSplChar1.Split(',');
                        if (!validSplChar.Contains(letter.ToString()))//!char.IsLetterOrDigit(letter)
                        {
                            valid = false;
                        }
                        else
                        {
                            splLen++;
                        }
                    }
                }
                if (splLen < getPolicy[0].Splcharlen)
                {
                    valid = false;
                }
            }

            if (valid)
            {
                //check password have Username or not
                string Name = UserName.TrimEnd();
                Name = Name.TrimStart();
                string uName = Name.Contains(' ') ? Name.Replace(' ', '_') : Name;
                uName = uName.TrimEnd();

                if (uName.Contains('_'))
                {
                    var UName = uName.Split('_');
                    UName[0] = UName[0].Contains('.') ? UName[0].Split('.')[1] : UName[0];
                    foreach (string name in UName)
                    {
                        if (password.ToUpper().Contains(name.ToUpper()))
                        {
                            valid = false;
                        }
                    }
                }
                else
                {
                    uName = uName.Contains('.') ? uName.Split('.')[1] : uName;
                    //password should not contains user name
                    if (password.ToUpper().Contains(uName.ToUpper()))
                    {
                        valid = false;
                    }
                }
            }
        }
        else
        {
            valid = false;
        }
        return valid;
    }

public bool CheckPasswordNew(string password, List<PasswordPolicy> getPolicy)
    {
        bool valid = true;

            Char[] letters = password.ToCharArray();
            String AllowableSplChar = AllowableSplChar1;
          
            //arun changes -- pasword 
            if (valid)
            {
                int splLen = 0;
                int alphaLen = 0;
                int numericLen = 0;
                int blankLen = 0;
                //check special character length
                Char[] splletters = password.ToCharArray();
                foreach (Char letter in splletters)
                {
                    if (!IsRegExpMatch(AlphaNumericPattern, letter.ToString()))
                    {
                        string[] validSplChar = AllowableSplChar1.Split(',');
                        if (!validSplChar.Contains(letter.ToString()))
                        {
                            valid = false;
                        }
                        else
                        {
                            splLen++;
                        }
                    }
                    if (Char.IsLetter(letter))
                    {
                        alphaLen++;
                    }
                    if (Char.IsDigit(letter))
                    {
                        numericLen++;
                    }
                    if (Char.IsWhiteSpace(letter))
                    {
                        blankLen++;
                    }
                }
                if (blankLen > 0)
                {
                    valid = false;
                }
                if (splletters.Length < 8)
                {
                    valid = false;
                }
                if (splLen < 1)
                {
                    valid = false;
                }
                if (alphaLen < 3)
                {
                    valid = false;
                }
                if (numericLen < 1)
                {
                    valid = false;
                }
            }
            //       
        return valid;
    }


    public void CheckUpperCase(string password, out int ucLen)
    {
        ucLen = 0;
        Char[] letters = password.ToCharArray();
        foreach (Char letter in letters)
        {
            if (char.IsUpper(letter))
            {
                ucLen++;
            }
        }
    }

    public void CheckNumeric(string password, out int numLen)
    {
        numLen = 0;
        Char[] letters = password.ToCharArray();
        foreach (Char letter in letters)
        {
            if (char.IsNumber(letter))
            {
                numLen++;
            }
        }
    }

    //arun pswd decrypt
    public static string DecryptStringAES(string cipherText)
    {
        var keybytes = Encoding.UTF8.GetBytes("8080808080808080");
        var iv = Encoding.UTF8.GetBytes("8080808080808080");

        var encrypted = Convert.FromBase64String(cipherText);
        var decriptedFromJavascript = DecryptStringFromBytes(encrypted, keybytes, iv);
        return string.Format(decriptedFromJavascript);
    }
    private static string DecryptStringFromBytes(byte[] cipherText, byte[] key, byte[] iv)
    {
        // Check arguments.  
        if (cipherText == null || cipherText.Length <= 0)
        {
            throw new ArgumentNullException("cipherText");
        }
        if (key == null || key.Length <= 0)
        {
            throw new ArgumentNullException("key");
        }
        if (iv == null || iv.Length <= 0)
        {
            throw new ArgumentNullException("key");
        }

        // Declare the string used to hold  
        // the decrypted text.  
        string plaintext = null;

        // Create an RijndaelManaged object  
        // with the specified key and IV.  
        using (var rijAlg = new RijndaelManaged())
        {
            //Settings  
            rijAlg.Mode = CipherMode.CBC;
            rijAlg.Padding = PaddingMode.PKCS7;
            rijAlg.FeedbackSize = 128;

            rijAlg.Key = key;
            rijAlg.IV = iv;

            // Create a decrytor to perform the stream transform.  
            var decryptor = rijAlg.CreateDecryptor(rijAlg.Key, rijAlg.IV);

            try
            {
                // Create the streams used for decryption.  
                using (var msDecrypt = new MemoryStream(cipherText))
                {
                    using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {

                        using (var srDecrypt = new StreamReader(csDecrypt))
                        {
                            // Read the decrypted bytes from the decrypting stream  
                            // and place them in a string.  
                            plaintext = srDecrypt.ReadToEnd();

                        }

                    }
                }
            }
            catch
            {
                plaintext = "keyError";
            }
        }

        return plaintext;
    }
    private static byte[] EncryptStringToBytes(string plainText, byte[] key, byte[] iv)
    {
        // Check arguments.  
        if (plainText == null || plainText.Length <= 0)
        {
            throw new ArgumentNullException("plainText");
        }
        if (key == null || key.Length <= 0)
        {
            throw new ArgumentNullException("key");
        }
        if (iv == null || iv.Length <= 0)
        {
            throw new ArgumentNullException("key");
        }
        byte[] encrypted;
        // Create a RijndaelManaged object  
        // with the specified key and IV.  
        using (var rijAlg = new RijndaelManaged())
        {
            rijAlg.Mode = CipherMode.CBC;
            rijAlg.Padding = PaddingMode.PKCS7;
            rijAlg.FeedbackSize = 128;

            rijAlg.Key = key;
            rijAlg.IV = iv;

            // Create a decrytor to perform the stream transform.  
            var encryptor = rijAlg.CreateEncryptor(rijAlg.Key, rijAlg.IV);

            // Create the streams used for encryption.  
            using (var msEncrypt = new MemoryStream())
            {
                using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    using (var swEncrypt = new StreamWriter(csEncrypt))
                    {
                        //Write all data to the stream.  
                        swEncrypt.Write(plainText);
                    }
                    encrypted = msEncrypt.ToArray();
                }
            }
        }

        // Return the encrypted bytes from the memory stream.  
        return encrypted;
    }
    //
}
