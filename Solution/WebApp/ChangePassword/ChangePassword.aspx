<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChangePassword.aspx.cs" Inherits="ChangePassword"
    ValidateRequest="true" EnableEventValidation="false" meta:resourcekey="PageResource2" EnableViewState="true" EnableViewStateMac="true" ViewStateEncryptionMode="Always" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%--<%@ Register Src="../CommonControls/UserHeader.ascx" TagName="Header" TagPrefix="uc3" %>--%>
<%@ Register Src="../CommonControls/PhysicianHeader.ascx" TagName="PhyHeader"
    TagPrefix="uc7" %>
<%@ Register Src="../CommonControls/PatientAccessHeader.ascx" TagName="PatientHeader"
    TagPrefix="uc100" %>
<%@ Register Src="../CommonControls/Attune_OrgHeader.ascx" TagName="Attuneheader"
    TagPrefix="Attune" %>
<%@ Register Src="../CommonControls/Attune_Footer.ascx" TagName="Attunefooter"
    TagPrefix="Attune" %>
<%--<%@ Register Src="../CommonControls/LeftMenu.ascx" TagName="LeftMenu" TagPrefix="uc1" %>
<%@ Register Src="../CommonControls/Footer.ascx" TagName="Footer" TagPrefix="uc5" %>
<%@ Register Src="../CommonControls/ErrorDisplay.ascx" TagName="ErrorDisplay" TagPrefix="uc6" %>
<%@ Register Src="../CommonControls/OrgHeader.ascx" TagName="OrgHeaderForChangePass"
    TagPrefix="uc2" %>
<%@ Register Src="~/CommonControls/Topheader.ascx" TagName="TopHeader" TagPrefix="Top" %>
--%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
    <title>
        <%--Change Password--%><%=Resources.ChangePassword_AppMsg.ChangePassword_aspx_005%>
    </title>
    <%--<link href="../StyleSheets/style.css" rel="stylesheet" type="text/css" />--%>
    <%--   <script src="../Scripts/Common.js" type="text/javascript"></script>--%>
    <%-- <script src="../scripts/MessageHandler.js" language="javascript" type="text/javascript"></script>
--%>

    <script type="text/javascript" language="javascript">
        window.history.forward(1);
    </script>

    <%--new code--%>

    <script type="text/javascript" src="../Scripts/jquery.min.js" language="javascript"></script>

    <script type="text/javascript" src="../Scripts/ddaccordion.js" language="javascript"></script>

    <link href="../StyleSheets/tooltip.css" rel="stylesheet" type="text/css" media="all" />
<%--encryption--%>
<script type="text/javascript" src="../Scripts/crypto-js.js" language="javascript"></script>
 <script type="text/javascript" src="../Scripts/aes.js" language="javascript"></script> 

    <script type="text/javascript">
        $(document).ready(function() {
            //arun            
            document.getElementById('txtOldpassword').value = document.getElementById("hdnOldPasswordReturn").value;
            //
            var errorMsg = SListForAppMsg.Get("ChangePassword_aspx_Error") != null ? SListForAppMsg.Get("ChangePassword_aspx_Error") : "Error";
            var userMsg = SListForAppMsg.Get("ChangePassword_aspx_001") == null ? "Given Password Already Exist" : SListForAppMsg.Get("ChangePassword_aspx_001");
            var userMsg1 = SListForAppMsg.Get("ChangePassword_aspx_002") == null ? "Given Transaction Password Already Exist" : SListForAppMsg.Get("ChangePassword_aspx_002");
        });

        function ShowAlertMsg(key) {

            var userMsg = SListForApplicationMessages.Get(key); //added
            document.getElementById('chkShowPassword').checked = false;
            ShowPassword();
            //added
            if (userMsg != null) {
                // alert(userMsg);
                ValidationWindow(userMsg, errorMsg);
            }
            else if (key == userMsg) {

                ValidationWindow(userMsg, errorMsg);
                // alert('Given Password Already Exist');
            }

            else if (key == userMsg1) {

                ValidationWindow(userMsg1, errorMsg);
                //alert('Given Transaction Password Already Exist');
            }
            else if (key == userMsg) {
                // var userMsg = SListForAppMsg.Get("ChangePassword_aspx_001") == null ? "Given Password Already Exist" : SListForAppMsg.Get("ChangePassword_aspx_001");
                ValidationWindow(userMsg, errorMsg);

                // alert('Given Password Already Exist');
            }

            return true;
        }





        function getElementWidth(objectId) {
            x = document.getElementById(objectId);
            return x.offsetWidth;
        }
        function getAbsoluteLeft(objectId) {
            // Get an object left position from the upper left viewport corner
            o = document.getElementById(objectId)
            oLeft = o.offsetLeft            // Get left position from the parent object
            while (o.offsetParent != null) {   // Parse the parent hierarchy up to the document element
                oParent = o.offsetParent    // Get parent object reference
                oLeft += oParent.offsetLeft // Add parent left position
                o = oParent
            }
            return oLeft
        }

        function getAbsoluteTop(objectId) {
            // Get an object top position from the upper left viewport corner
            o = document.getElementById(objectId)
            oTop = o.offsetTop            // Get top position from the parent object
            while (o.offsetParent != null) { // Parse the parent hierarchy up to the document element
                oParent = o.offsetParent  // Get parent object reference
                oTop += oParent.offsetTop // Add parent top position
                o = oParent
            }
            return oTop
        }
        function showPopup(linkId) {
            var arrowOffset = getElementWidth(linkId) + 11;
            var clickElementx = getAbsoluteLeft(linkId) + arrowOffset; //set x position
            var clickElementy = getAbsoluteTop(linkId) - 3; //set y position
            $('#divLpwdHint').css({ left: clickElementx + "px", top: clickElementy + "px" });
            var pParentProIDs = document.getElementById('hdnRecords').value.split("^");
            for (j = 0; j < pParentProIDs.length; j++) {
                if (pParentProIDs[j] != "") {
                    var test = pParentProIDs[j].split('~');

                    if (test[0] == "L" && test[0] != "") {
                        $('#divLpwdHint').show();
                    }

                }
                else {
                    $('#divLpwdHint').show();
                }
            }

        }

        function showTPopup(linkId) {
            var arrowOffset = getElementWidth(linkId) + 11;
            var clickElementx = getAbsoluteLeft(linkId) + arrowOffset; //set x position
            var clickElementy = getAbsoluteTop(linkId) - 3; //set y position
            $('#divTpwdHint').css({ left: clickElementx + "px", top: clickElementy + "px" });

            var pParentProIDs = document.getElementById('hdnRecords').value.split("^");
            for (j = 0; j < pParentProIDs.length; j++) {
                if (pParentProIDs[j] != "") {
                    var test = pParentProIDs[j].split('~');

                    if (test[0] == "T" && test[0] != "") {
                        $('#divTpwdHint').show();
                    }

                }

                else {
                    $('#divTpwdHint').show();
                }
            }



        }
        
    </script>

    <style type="text/css">
        #passwordStrength
        {
            height: 10px;
            display: block;
            float: left;
        }
        .strength
        {
            width: 250px;
        }
        .strength0
        {
            width: 250px;
            background: #000000;
        }
        .strength1
        {
            width: 50px;
            background: #ff0000;
        }
        .strength2
        {
            width: 100px;
            background: #ff5f5f;
        }
        .strength3
        {
            width: 150px;
            background: #56e500;
        }
        .strength4
        {
            background: #4dcd00;
            width: 200px;
        }
        .strength5
        {
            background: #399800;
            width: 250px;
        }
        .style2
        {
            width: 15%;
        }
    </style>

    <script type="text/javascript" language="javascript">
        function passwordStrength(password) {
            var UsrAlrtMsg1 = SListForAppMsg.Get("ChangePassword_ChangePassword_aspx_006") == null ? "Very Weak" : SListForAppMsg.Get("ChangePassword_ChangePassword_aspx_006");
            var UsrAlrtMsg2 = SListForAppMsg.Get("ChangePassword_ChangePassword_aspx_007") == null ? "Weak" : SListForAppMsg.Get("ChangePassword_ChangePassword_aspx_007");
            var UsrAlrtMsg3 = SListForAppMsg.Get("ChangePassword_ChangePassword_aspx_008") == null ? "Better" : SListForAppMsg.Get("ChangePassword_ChangePassword_aspx_008");
            var UsrAlrtMsg4 = SListForAppMsg.Get("ChangePassword_ChangePassword_aspx_009") == null ? "Medium" : SListForAppMsg.Get("ChangePassword_ChangePassword_aspx_009");
            var UsrAlrtMsg5 = SListForAppMsg.Get("ChangePassword_ChangePassword_aspx_010") == null ? "Strong" : SListForAppMsg.Get("ChangePassword_ChangePassword_aspx_010");
            var UsrAlrtMsg6 = SListForAppMsg.Get("ChangePassword_ChangePassword_aspx_011") == null ? "Strongest" : SListForAppMsg.Get("ChangePassword_ChangePassword_aspx_011");
            var UsrAlrtMsg7 = SListForAppMsg.Get("ChangePassword_ChangePassword_aspx_012") == null ? "strength" : SListForAppMsg.Get("ChangePassword_ChangePassword_aspx_012");
            var desc = new Array();
            desc[0] = UsrAlrtMsg1;
            desc[1] = UsrAlrtMsg2;
            desc[2] = UsrAlrtMsg3;
            desc[3] = UsrAlrtMsg4;
            desc[4] = UsrAlrtMsg5;
            desc[5] = UsrAlrtMsg6;

            var score = 0;
            var passMinlength1 = 6;
            //added
            if (password.length > 0) {
                $('#tdPWDVisualstatus').addClass('show');
                //$('#printANCCS').removeClass().addClass('hide');
            }
            else {
                $('#tdPWDVisualstatus').removeClass().addClass('hide');
            }
//            //if password bigger than half of it's minlength give 1 point
//                        if (password.length > Math.round(Number(passMinlength1) / 2)) score++;

//            //if password has both numeric and uppercase characters, and minlength give 1 point
//                        if ((password.length >= Number(passMinlength1)) && (password.match(/[A-Z]/)) && (password.match(/\d+/))) score++;

//            //if password has both numeric, lowercase and uppercase characters, and minlength give 1 point
//                        if ((password.length >= Number(passMinlength1)) && (password.match(/[a-z]/)) && (password.match(/[A-Z]/)) && (password.match(/\d+/))) score++;

//                        debugger;
//            var newPWD = password;
//            var count = 0;
//            if (newPWD != '') {
//                for (var i = 0; i < newPWD.length; i++) {
//                    getnewPWDChar = newPWD.charAt(i);
//                    var getStatus = checkSplchar(getnewPWDChar);
//                    var splCharlength = getStatus.split('-');
//                    if (splCharlength[1] > 0) {
//                        count++;
//                    }
//                }
//                switch (count) {
//                    //if password has both numeric, lowercase and uppercase characters, atleast 1 valid special character and minlength give 1 point    
//                    case 1:
//                                    if (password.length >= Number(passMinlength1) && (password.match(/[a-z]/)) && (password.match(/\d+/)) && (password.match(/[A-Z]/))) score++;
//                        break;
//                    //if password has both numeric, lowercase and uppercase characters, atleast 2 valid special character and minlength give 2 points     
//                    case 2:
//                                    if (password.length >= Number(passMinlength1) && (password.match(/[a-z]/)) && (password.match(/\d+/)) && (password.match(/[A-Z]/))) score = score + 2;
//                        break;
//                    //if password has both numeric, lowercase and uppercase characters, more than 2 valid special character and minlength give 3 points     
//                    case 3:
//                    case 4:
//                    case 5:
//                                   if (password.length >= Number(passMinlength1) && (password.match(/[a-z]/)) && (password.match(/\d+/)) && (password.match(/[A-Z]/))) score = score + 3;
//                    default:
//                        break;
//                }
//            }
            ////added

            //if password bigger than 6 give 1 point
            if (password.length > 3) score++;

            //if password has both lower and uppercase characters give 1 point
            if ((password.match(/[a-z]/)) && (password.match(/[A-Z]/))) score++;

            //if password has at least one number give 1 point
            if (password.match(/\d+/)) score++;

            //if password has at least one special caracther give 1 point
            if (password.match(/.[!,@,#,$,%,^,&,*,?,_,~,-,(,)]/)) score++;

            //if password bigger than 12 give another 1 point
            if (password.length > 6) score++;

            document.getElementById("passwordDescription").innerHTML = desc[score];
            document.getElementById("passwordStrength").className = "strength" + score;
        }
    </script>

    <script type="text/javascript" language="javascript">
        var userMsg;
        function save(Path) {

            var InformationMsg = SListForAppMsg.Get("ChangePassword_aspx_Information") != null ? SListForAppMsg.Get("ChangePassword_aspx_Information") : "Information";
            var userMsg = SListForAppMsg.Get("ChangePassword_aspx_003") != null ? SListForAppMsg.Get("ChangePassword_aspx_003") : "Updated Successfully..";

            //debugger;
            //userMsg = SListForApplicationMessages.Get('ChangePassword_aspx_003');
            if (userMsg != null) {
                //                alert(userMsg);
                ValidationWindow(userMsg, InformationMsg);
                return false;
            }
            else {
                // var userMsg = SListForAppMsg.Get("ChangePassword_aspx_003") == null ? "Updated Successfully" : SListForAppMsg.Get("ChangePassword_aspx_003");
                ValidationWindow(userMsg, InformationMsg);

                // alert('Updated Successfully');
                return false;

            }
            location.href = Path;
            return true;
        }


        function binddata() {

            var pParentProIDs = document.getElementById('hdnRecords').value.split("^");
            for (j = 0; j < pParentProIDs.length; j++) {
                if (pParentProIDs[j] != "") {
                    var test = pParentProIDs[j].split('~');

                    if (test[0] != "T") {

                        document.getElementById("hdnnumcharlen").value = test[6];
                        document.getElementById("hdnpasslength").value = test[1];
                        document.getElementById("hdnsplcharlen").value = test[2];
                        document.getElementById("hdnnumcharlen").value = test[3];


                        var passlen = document.getElementById("hdnpasslength").value;
                        var splchar = document.getElementById("hdnsplcharlen").value;
                        var numchar = document.getElementById("hdnnumcharlen").value;

                        document.getElementById('lblLpwdHintLenth').innerHTML = passlen;
                        document.getElementById('lblLpwdHintsplchar').innerHTML = splchar;
                        document.getElementById('lblLpwdHintnumchar').innerHTML = numchar;
                        // + " " + "Minimum Special Character Length- " + splchar + " " + " Minimum Number Character Length- " + numchar;

                    }
                    else if (test[0] != "L") {


                        document.getElementById("hdntranspasslength").value = test[1];
                        document.getElementById("hdntranssplcharlen").value = test[2];
                        document.getElementById("hdntransnumcharlen").value = test[3];

                        var transpasslen = document.getElementById("hdntranspasslength").value;
                        var transsplchar = document.getElementById("hdntranssplcharlen").value;
                        var transnumchar = document.getElementById("hdntransnumcharlen").value;

                        document.getElementById('lblTpwdHintLenth').innerHTML = transpasslen;
                        document.getElementById('lblTpwdHintsplchar').innerHTML = transsplchar;
                        document.getElementById('lblTpwdHintnumchar').innerHTML = transnumchar;

                        // document.getElementById('lbltransnewpass').innerHTML = "Transaction Password Hint: " + "Maximum Password Length- " + transpasslen + " " + "Minimum Special Character- " + transsplchar + "   " + " Minimum Number Character- " + transnumchar;
                    }

                }
            }

        }

        function pwdcheck() {
            var InformationMsg = SListForAppMsg.Get("ChangePassword_aspx_Information") != null ? SListForAppMsg.Get("ChangePassword_aspx_Information") : "Information";
            var userMsg1 = SListForAppMsg.Get("ChangePassword_aspx_004") == null ? "Provide Transaction password" : SListForAppMsg.Get("ChangePassword_aspx_004");
            var userMsg2 = SListForAppMsg.Get("ChangePassword_aspx_004") == null ? "Provide Transaction password" : SListForAppMsg.Get("ChangePassword_aspx_004");

            if (document.getElementById('txtAccesspwd').value == '') {
                if (userMsg1 != null) {
                    ValidationWindow(userMsg1, InformationMsg);
                    //alert(userMsg);
                    return false;
                }
                else {
                    ValidationWindow(userMsg2, InformationMsg);

                    //alert('Provide Transaction password');
                    return false;
                }
                document.getElementById('txtAccesspwd').focus();
                return false;
            }
            else {
                return true;
            }
        }
        function checkSubmit(e) {
            var InformationMsg = SListForAppMsg.Get("ChangePassword_aspx_Information") != null ? SListForAppMsg.Get("ChangePassword_aspx_Information") : "Information";
            var userMsgsPwd = SListForAppMsg.Get("ChangePassword_aspx_004") == null ? "Provide Transaction password" : SListForAppMsg.Get("ChangePassword_aspx_004");

            if (e && e.keyCode == 13) {
                if (document.getElementById('txtAccesspwd').value == '') {
                    // userMsg = SListForApplicationMessages.Get('ChangePassword\\ChangePassword.aspx_2');
                    if (userMsgsPwd != null) {
                        // alert(userMsg);
                        ValidationWindow(userMsgsPwd, InformationMsg);
                        return false;
                    }
                    else {
                        // var userMsgsPwd = SListForAppMsg.Get("ChangePassword_aspx_004") == null ? "Provide Transaction password" : SListForAppMsg.Get("ChangePassword_aspx_004");
                        ValidationWindow(userMsgsPwd, errorMsg);

                        // alert('Provide Transaction password');
                        return false;
                    }
                    document.getElementById('txtAccesspwd').focus();
                }
                return false;
            }
        }
        function enterbtnclick(e) {
            document.getElementById('lblPswdAlert').innerHTML = "";
            if (e && e.keyCode == 13) {
                 document.getElementById('btnChange').click();
               // return false;
            }
        }
        //   binddataService();
        var validSpecialchar = "@,$,*,#";
        var PasswordPolicy = [];
        function binddataService() {
            //debugger;
            var SOrgid = $('#hdnOrgID').val();
            var Parameters = { OrgID: SOrgid };
            $.ajax({
                type: "POST",
                url: "../MemberService.asmx/GetPasswordPolicyService",
                data: JSON.stringify(Parameters),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function(response) {
                    //  alert('Success');
                    PasswordPolicy = response.d;
                    // alert(dd[0].Type);
                    if (PasswordPolicy.length > 0) {

                        //{"d":[{"__type":"Attune.Podium.BusinessEntities.PasswordPolicy","Id":1,"Type":"L","PasswordLength":7,"Splcharlen":1,"Numcharlen":2,"ValidityPeriodType":"","ValidityPeriod":0,"PreviousPwdcount":0,"OrgID":0,"CreatedBy":0,"CreatedAt":"\/Date(253402280999999)\/","ModifiedBy":0,"ModifiedAt":"\/Date(253402280999999)\/","AllowableSplChar":"!,@,#,$,.","UpperCharlen":1}]}

                        if (PasswordPolicy[0].Type != "T") {
                            //document.getElementById("hdnnumcharlen").value = PasswordPolicy[0].Numcharlen;
                            //document.getElementById("hdnpasslength").value = PasswordPolicy[0].PasswordLength;
                            //document.getElementById("hdnsplcharlen").value = PasswordPolicy[0].Splcharlen;
                            //document.getElementById("hdnnumcharlen").value = PasswordPolicy[0].Numcharlen;
                            passMaxlength = PasswordPolicy[0].PasswordLength;
                            passMinlength = PasswordPolicy[0].MinPasswordLength
                            splCharlength = PasswordPolicy[0].Splcharlen;
                            numCharlength = PasswordPolicy[0].Numcharlen;
                            upperCaselength = PasswordPolicy[0].UpperCharlen;
                            validSpecialchar = PasswordPolicy[0].AllowableSplChar;
                            //alert(PasswordPolicy[0].AllowableSplChar);



                            document.getElementById('lblLpwdHintLenth').innerHTML = passMaxlength;
                            document.getElementById('lblLpwdHintsplchar').innerHTML = splCharlength;
                            document.getElementById('lblLpwdHintnumchar').innerHTML = numCharlength;
                            document.getElementById('lbletc').innerHTML = '(' + PasswordPolicy[0].AllowableSplChar + ')';
                            document.getElementById('lblUpperCaseCharlen').innerHTML = upperCaselength;
                            // + " " + "Minimum Special Character Length- " + splchar + " " + " Minimum Number Character Length- " + numchar;

                            //lbletc
                            //lblUpperCaseCharlen

                        }
                        else if (PasswordPolicy[0].Type != "L") {


                            document.getElementById("hdntranspasslength").value = PasswordPolicy[0].PasswordLength;
                            document.getElementById("hdntranssplcharlen").value = PasswordPolicy[0].Splcharlen;
                            document.getElementById("hdntransnumcharlen").value = PasswordPolicy[0].Numcharlen;

                            var transpasslen = document.getElementById("hdntranspasslength").value;
                            var transsplchar = document.getElementById("hdntranssplcharlen").value;
                            var transnumchar = document.getElementById("hdntransnumcharlen").value;

                            document.getElementById('lblTpwdHintLenth').innerHTML = transpasslen;
                            document.getElementById('lblTpwdHintsplchar').innerHTML = transsplchar;
                            document.getElementById('lblTpwdHintnumchar').innerHTML = transnumchar;
                            document.getElementById('lbletc').innerHTML = '(' + PasswordPolicy[0].AllowableSplChar + ')';
                            document.getElementById('lblUpperCaseCharacter').innerHTML = PasswordPolicy[0].UpperCharlen;
                            //                            $('#lbletc').html(PasswordPolicy[0].AllowableSplChar);
                            //                            $('#lblUpperCaseCharacter').html(PasswordPolicy[0].UpperCharlen);

                            // document.getElementById('lbltransnewpass').innerHTML = "Transaction Password Hint: " + "Maximum Password Length- " + transpasslen + " " + "Minimum Special Character- " + transsplchar + "   " + " Minimum Number Character- " + transnumchar;
                        }

                    }
                    //                    $.each(dd, function(index, item) {
                    //                        PasswordPolicy.push(item);
                    //                    });
                },
                error: function() {
                    alert("GetPasswordPolicyService Failed to load data");
                }
            });
        }
    </script>

</head>
<body oncontextmenu="return false;">
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ctlTaskScriptMgr" runat="server">
    </asp:ScriptManager>
    <Attune:Attuneheader ID="Attuneheader" runat="server" />
    <%--    <div id="wrapper">
        <div id="header">
            <div class="logoleft" style="z-index: 2;">
                <div class="logowrapper">
                    <img alt="" src="<%=LogoPath%>" class="logostyle" />
                </div>
            </div>
            <div class="middleheader">
                <uc2:OrgHeaderForChangePass ID="OrgHeaderForChangePass1" runat="server" />
                <uc3:Header ID="Header1" runat="server" />
                <uc7:PhyHeader ID="phyHeader" runat="server" />
                <uc100:PatientHeader ID="PatientHeader1" runat="server" />
            </div>
            <div style="float: right;" class="Rightheader">
            </div>
        </div>
        <table border="0" cellpadding="0" cellspacing="0" width="100%" class="tableborder">
            <tr>
                <td valign="top" id="menu" style="display: block;" class="style2">
                    <div id="navigation">
                        <uc1:LeftMenu ID="LeftMenu1" runat="server" />
                    </div>
                </td>
                <td width="85%" valign="top" class="tdspace">
                    <img alt="" onclick="Showmenu();Showhide();" src="../Images/hide.png" id="showmenu"
                        style="cursor: pointer;" />
                    <table border="0" cellpadding="0" cellspacing="0" width="100%">
                        <tr>
                            <td>
                                <Top:TopHeader ID="TopHeader1" runat="server" />
                            </td>
                        </tr>--%>
    <%--                    </table>--%>
    <div class="contentdata">
        <div class="login-bg scheduledataheader2 a-center" id="DivLpwd" runat="server" style="display: none">
            <table cellspacing="5" class="a-center w-100p">
                <tr id="trplcy" runat="server" style="display: none">
                    <td colspan="3" class="a-left">
                    </td>
                </tr>
                
                <tr class="login-title">
                    <td colspan="3">
                        <strong>
                            <asp:Label ID="lblMsg" Text="Login Password" runat="server" meta:resourcekey="lblMsgResource2"></asp:Label>
                        </strong>
                    </td>
                </tr>
                <tr>
                    <td colspan="3" class="a-right">
                        <a href="#" class="jTip" id="one" name="Password must follow these rules:" onmouseover="showPopup(this.id);"
                            onmouseout="$('#divLpwdHint').hide();">
                            <asp:Label ID="lblHint" runat="server" Text="Hint" ForeColor="Red" Font-Bold="True"
                                meta:resourcekey="lblHintResource2"></asp:Label></a>
                    </td>
                </tr>
                <tr>
                    <td class="w-10p"></td>
                    <td class="a-left w-40p h-35" nowrap="nowrap">
                        <asp:Label ID="lblop" runat="server" Text="Old Password" meta:resourcekey="lblopResource2"></asp:Label>
                    </td>
                    <td class="a-left w-50p">
                        <asp:TextBox ID="txtOldpassword" runat="server" CssClass="small" TextMode="Password" TabIndex="1"
                            meta:resourcekey="txtOldpasswordResource2"  onkeydown="return enterbtnclick(event)"> &gt;</asp:TextBox>
                    </td>
                </tr>
                <tr>
                     <td></td>
                    <td class="a-left h-35" nowrap="nowrap">
                        <asp:Label ID="lblnp" runat="server" Text="New Password" meta:resourcekey="lblnpResource2"></asp:Label>
                    </td>
                    <td class="a-left">
                        <asp:TextBox ID="txtNewpassword" runat="server" CssClass="small" TextMode="Password" MaxLength="15" oncut="return false;" oncopy="return false;" onpaste="return false;"
                            TabIndex="2" onkeyup="ValidSpecialchar(this.id);passwordStrength(this.value)" meta:resourcekey="txtNewpasswordResource2" onkeydown="return enterbtnclick(event)"></asp:TextBox>
                    </td>

                </tr>
                <tr>
                     <td></td>
                    <td class="a-left h-35" nowrap="nowrap">
                        <asp:Label ID="lblcpd" runat="server" Text="Confirm password" meta:resourcekey="lblcpdResource2"></asp:Label>
                    </td>
                    <td class="a-left">
                        <asp:TextBox ID="txtConfirmpassword" CssClass="small" runat="server" TextMode="Password" MaxLength="15" oncut="return false;" oncopy="return false;" onpaste="return false;"
                            TabIndex="3" meta:resourcekey="txtConfirmpasswordResource2" onkeyup="javascript:return ValidSpecialchar(this.id);" onkeydown="return enterbtnclick(event)"></asp:TextBox>
                    </td>
                </tr>
				  <tr class="panelContent" style="height: 35px;">
                            <td>
                            </td>
                            <td class="a-left w-10p">
                                <input type="checkbox" id="chkShowPassword" runat="server" onclick="ShowPassword()" />
                                <label for="chkShowPassword">
                                    Show Password</label>
                                <%-- <asp:CheckBox ID="chkShowPassword" runat="server" Text="Show Password" ="return ShowPassword();" />--%>
                            </td>
                            <td class="a-left">
                    </td>
                </tr>
                <tr>
                     <td></td>
                    <td></td>
                    <%--<td>
                    </td>--%>
                    <td id="tdPWDVisualstatus" runat="server"   colspan="2">
                        <div id="passwordDescription">
                        </div>
                        <div id="passwordStrength" class="strength1">
                        </div>
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <br />
                    </td>
                </tr>
                <tr>
                     <td></td>
                    <td align="right">
                        <asp:Button ID="btnChange" runat="server" OnClientClick="return TextboxValidation();"
                            OnClick="btnChange_Click" TabIndex="4" Text="Update" CssClass="btn" onmouseover="this.className='btn btnhov'"
                            onmouseout="this.className='btn'" meta:resourcekey="btnChangeResource2" />
                    </td>
                    <td class="a-left">
                        <asp:Button ID="btnCancel" runat="server" TabIndex="5" Text="Cancel" CssClass="btn"
                            onmouseover="this.className='btn btnhov'" onmouseout="this.className='btn'" OnClick="btnCancel_Click"
                            meta:resourcekey="btnCancelResource2" />
                    </td>
                </tr>
                <tr>
                     <td colspan="3"><label id="lblPswdAlert" runat="server" style="color:red;"></label></td>
                </tr>
                <%--  <tr>
                                    <td colspan="3" height="15px" align="left">
                                        <uc6:ErrorDisplay ID="ErrorDisplay1" runat="server" />
                                    </td>
                                </tr>--%>
            </table>
        </div>
        <div>
            <div id='divLpwdHint' style='width: 300px; height: 225px; display: none;'>
                <div id='divLpwdHint_arrow_left'>
                </div>
                <div id='divLpwdHint_close_left'>
                    <asp:Label ID="lblRules" runat="server" Text="Password must follow these rules:"
                        meta:resourcekey="lblRulesResource2"></asp:Label>
                </div>
                
                <div id='divLpwdHint_copy1' runat="server">
                <strong>
                <br />
                        <asp:Label ID="Label2" runat="server" Text="  1)  Minimum Password Length - 8"></asp:Label>
                        <br />
                        <br />                        
                        <asp:Label ID="Label4" runat="server" Text="  2) Minimum Alphabets Length - 3"></asp:Label>                       
                        <br />
                        <br />
                        <asp:Label ID="Label5" runat="server" Text="  3) Minimum Numeric Character Length - 1"></asp:Label>                       
                        <br />
                        <br />
                        <asp:Label ID="Label7" runat="server" Text="  4) Minimum Special Character Length - 1"></asp:Label>                       
                        <asp:Label ID="Label9" runat="server" Text="(@,$, etc)"></asp:Label>
                        <br />
                        <br />
                        <asp:Label ID="Label10" runat="server" Text="  5)  Allowable Special Character's - @,$,*,#"></asp:Label>                 
                        <br />
                        <br />
                        <asp:Label ID="Label12" runat="server" Text="  6)  Password must not repeat last 5 passwords."></asp:Label>
                    </strong>
                </div>
                <div id='divLpwdHint_copy' runat="server">
                    <strong>                    
                        <asp:Label ID="lblMinimumPasswordLength2" runat="server" Text=" 1)  Minimum Password Length - 6"
                            meta:resourcekey="lblMinimumPasswordLength2Resource1"></asp:Label>
                        <br />
                        <br />
                        <asp:Label ID="lblMaximumPasswordLength2" runat="server" Text="2) Maximum Password Length -"
                            meta:resourcekey="lblMaximumPasswordLength2Resource1"></asp:Label>
                        <asp:Label ID="lblLpwdHintLenth" runat="server" Text="12" meta:resourcekey="lblLpwdHintLenthResource2"></asp:Label>
                        <br />
                        <br />
                        <asp:Label ID="lblNumberCharacterLength" runat="server" Text="3) Number Character Length -"
                            meta:resourcekey="lblNumberCharacterLengthResource1"></asp:Label>
                        <asp:Label ID="lblLpwdHintnumchar" runat="server" Text="1" meta:resourcekey="lblLpwdHintnumcharResource2"></asp:Label>
                        <br />
                        <br />
                        <asp:Label ID="lblSpecialCharacterLength2" runat="server" Text="4) Special Character Length -"
                            meta:resourcekey="lblSpecialCharacterLength2Resource1"></asp:Label>
                        <asp:Label ID="lblLpwdHintsplchar" runat="server" Text="1" meta:resourcekey="lblLpwdHintsplcharResource2"></asp:Label>
                        <asp:Label ID="lbletc" runat="server" Text="(@, %, etc)" meta:resourcekey="lbletcResource1"></asp:Label>
                        <br />
                        <br />
                        <asp:Label ID="Label111" runat="server" Text="5)  Allowable Special Character's - @,$,*,#"
                            meta:resourcekey="lblAllowableSpecialCharacterResource1"></asp:Label>
                        <br />
                        <br />
                        <asp:Label ID="Label112" runat="server" Text="6)  Upper Character Length  - 1"
                            meta:resourcekey="lblUpperCharacterLengthResource1"></asp:Label>
                        <br />
                        <br />
                        <asp:Label ID="Label113" runat="server" Text="7)  Password Should Not Contains Username"
                            meta:resourcekey="lblShouldNotUserNameResource1"></asp:Label>
                    </strong>
                </div>
            </div>
        </div>
        <div>
        </div>
        <div class="scheduledataheader2" id="divTpwd" runat="server" style="display: none">
            <table class="w-100p a-center" cellspacing="5">
                <tr id="transplcy" runat="server" style="display: none">
                    <td class="a-left">
                        <%--  <asp:Label ID="lbltransnewpass" runat="server" CssClass="errorbox"></asp:Label>--%>
                    </td>
                </tr>
                <tr>
                    <td class="a-right">
                        <a href="#" class="jTip" id="two" name="Transaction Password must follow these rules:"
                            onmouseover="showTPopup(this.id);" onmouseout="$('#divTpwdHint').hide();">
                            <asp:Label ID="lblTpp" runat="server" Text="Hint" ForeColor="Red" Font-Bold="True"
                                meta:resourcekey="lblTppResource2"></asp:Label></a>
                    </td>
                </tr>
                <tr>
                    <td class="a-center" colspan="3">
                        <strong>
                            <br />
                            <asp:Label Text="Transaction Password" ID="lblmsg1" runat="server" meta:resourcekey="lblmsg1Resource2"></asp:Label>
                        </strong>
                    </td>
                </tr>
                <tr>
                    <td class="a-left w-17p h-35" nowrap="nowrap">
                        <asp:Label ID="lbltopl" runat="server" Text="Old Transaction Password" meta:resourcekey="lbltoplResource2"></asp:Label>
                    </td>
                    <td class="a-left w-25">
                        <asp:TextBox ID="Txtoldtranspwd" runat="server" TextMode="Password" CssClass="small" TabIndex="6"
                            meta:resourcekey="TxtoldtranspwdResource2"> &gt;</asp:TextBox>
                    </td>
                    <td>
                        &nbsp;
                    </td>
                </tr>
                <tr id="trNTP" runat="server">
                    <td class="a-left w-17p h-35" nowrap="nowrap">
                        <asp:Label ID="lblntp" runat="server" Text="New Transaction Password" meta:resourcekey="lblntpResource2"></asp:Label>
                    </td>
                    <td class="a-left">
                        <asp:TextBox ID="TxtNewtranspwd" TextMode="Password" CssClass="small" runat="server" TabIndex="7"
                            meta:resourcekey="TxtNewtranspwdResource2"></asp:TextBox>
                    </td>
                    <td class="a-left">
                    </td>
                </tr>
                <tr id="trCTP" runat="server">
                    <td class="a-left w-20p h-35" nowrap="nowrap">
                        <asp:Label ID="lblctp" runat="server" Text="Confirm Transaction Password" meta:resourcekey="lblctpResource2"></asp:Label>
                    </td>
                    <td class="a-left">
                        <asp:TextBox ID="TxtconTranspwd" TextMode="Password" CssClass="small" runat="server" TabIndex="8"
                            meta:resourcekey="TxtconTranspwdResource2"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td class="a-right">
                        <asp:Button ID="btnupdate" runat="server" OnClientClick="return Passwordvalidation();"
                            TabIndex="9" Text="Update" CssClass="btn1" onmouseover="this.className='btn1 btnhov1'"
                            onmouseout="this.className='btn1'" OnClick="btnupdate_Click" meta:resourcekey="btnupdateResource2" />
                    </td>
                    <td colspan="2" class="a-left">
                        <asp:Button ID="btnclose" runat="server" TabIndex="10" Text="Cancel" CssClass="btn"
                            onmouseover="this.className='btn btnhov'" onmouseout="this.className='btn'" OnClick="btnclose_Click"
                            meta:resourcekey="btncloseResource2" />
                    </td>
                </tr>
                <%-- <tr>
                                    <td colspan="3" height="15px" align="left">
                                        <uc6:ErrorDisplay ID="ErrorDisplay2" runat="server" />
                                    </td>
                                </tr>--%>
            </table>
        </div>
        <div>
            <div id='divTpwdHint' style='width: 450px; display: none;'>
                <div id='divTpwdHint_arrow_left'>
                </div>
                <div id='divTpwdHint_close_left'>
                    <asp:Label ID="lblTRules" runat="server" Text="Transaction Password must follow these rules:"
                        meta:resourcekey="lblTRulesResource2"></asp:Label>
                </div>
                <div id='divTpwdHint_copy'>
                    <strong>
                        <asp:Label ID="lblMinimumPasswordLength1" runat="server" Text="1)  Minimum Password Length - 6"
                            meta:resourcekey="lblMinimumPasswordLength1Resource1"></asp:Label>
                        <br />
                        <br />
                        <asp:Label ID="lblMaximumPasswordLength1" runat="server" Text=" 2) Maximum Password Length -"
                            meta:resourcekey="lblMaximumPasswordLength1Resource1"></asp:Label>
                        <asp:Label ID="lblTpwdHintLenth" runat="server" Text="12" meta:resourcekey="lblTpwdHintLenthResource2"></asp:Label>
                        <br />
                        <br />
                        <asp:Label ID="lblSpecialCharacter1" runat="server" Text="3) Special Character Length -"
                            meta:resourcekey="lblSpecialCharacter1Resource1"></asp:Label>
                        <asp:Label ID="lblTpwdHintsplchar" runat="server" Text="1" meta:resourcekey="lblTpwdHintsplcharResource2"></asp:Label>
                        <asp:Label ID="lbletc1" runat="server" Text="(@, %, etc)" meta:resourcekey="lbletc1Resource1"></asp:Label>
                        <br />
                        <br />
                        <asp:Label ID="lblNumberCharacter1" runat="server" Text=" 4) Number Character Length - "
                            meta:resourcekey="lblNumberCharacter1Resource1"></asp:Label>
                        <asp:Label ID="lblTpwdHintnumchar" runat="server" Text="1" meta:resourcekey="lblTpwdHintnumcharResource2"></asp:Label>
                    </strong>
                </div>
            </div>
        </div>
        <asp:UpdatePanel ID="UP" runat="server">
            <ContentTemplate>
                <asp:Button ID="hiddenTargetControlForModalPopup" runat="server" Style="display: none"
                    meta:resourcekey="hiddenTargetControlForModalPopupResource2" />
                <cc1:ModalPopupExtender ID="ModalPopupExtender1" runat="server" TargetControlID="hiddenTargetControlForModalPopup"
                    PopupControlID="pnlTpwd" BackgroundCssClass="modalBackground" DynamicServicePath=""
                    Enabled="True" />
                <asp:Panel ID="pnlTpwd" runat="server" Style="display: none" Height="20%" CssClass="modalPopup dataheaderPopup w-35p"
                    meta:resourcekey="pnlTpwdResource2">
                    <div id="divAccess" runat="server">
                        <div class="a-right">
                            <asp:ImageButton ID="btncancelclose" runat="server" ImageUrl="~/Images/CloseIcon.png"
                                AlternateText="Close" ImageAlign="Top" ToolTip="Close" OnClick="btncancelclose_Click"
                                meta:resourcekey="btncancelcloseResource2" />
                        </div>
                        <table class="a-center w-80p" cellspacing="5">
                            <tr>
                                <td colspan="3" class="a-center">
                                </td>
                            </tr>
                            <tr>
                                <td colspan="3" class="a-center">
                                </td>
                            </tr>
                            <tr>
                                <td colspan="3" class="a-right">
                                </td>
                            </tr>
                            <tr>
                                <td class="a-left w-17p h-35" nowrap="nowrap">
                                    <asp:Label ID="lblEnterTransactionPassword" runat="server" Text="Enter Transaction Password"
                                        meta:resourcekey="lblEnterTransactionPasswordResource1"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtAccesspwd" TextMode="Password" runat="server" TabIndex="11" CssClass="small" onKeyPress="return checkSubmit(event)"
                                        meta:resourcekey="txtAccesspwdResource2"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:Button ID="btngo" runat="server" TabIndex="12" Text=" GO " CssClass="btn" onmouseover="this.className='btn btnhov'"
                                        onmouseout="this.className='btn'" OnClick="btngo_Click" OnClientClick="javascript:return pwdcheck();"
                                        meta:resourcekey="btngoResource2" />
                                </td>
                                <tr>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                            </tr>
                            <%-- <tr>
                                                <td colspan="3" height="15px" align="left">
                                                    <uc6:ErrorDisplay ID="ErrorDisplay3" runat="server" />
                                                </td>
                                            </tr>--%>
                        </table>
                    </div>
                </asp:Panel>
                <asp:Button ID="btnmsgpopup" runat="server" Style="display: none" meta:resourcekey="btnmsgpopupResource1" />
                <cc1:ModalPopupExtender ID="ModalPopupExtender2" runat="server" TargetControlID="btnmsgpopup"
                    PopupControlID="pnlOthers" BackgroundCssClass="modalBackground" 
                    Enabled="True" />
                <asp:Panel ID="pnlOthers" runat="server" Style="display: none; width: 250px" CssClass="modalPopup dataheaderPopup" 
                 DefaultButton="btnpopClose"    meta:resourcekey="pnlOthersResource1">
                    <center>
                        <div id="divOthers" class="h-80 paddingT50 paddingL15" style="width: 250px;">
                            <table class="w-90p a-center">
                                <tr class="a-left">
                                    <td>
                                        <table id="tblDiagnosisItems" runat="server" cellpadding="4" class="w-100p">
                                            <tr id="Tr1" runat="server">
                                                <td id="Td1" class="a-center" rowspan="2" runat="server">
                                                    <asp:Label ID="lblmsgs" runat="server" Text="Updated Successfully" Font-Bold="True"
                                                        Font-Size="Medium" meta:resourcekey="lblmsgsResource1"></asp:Label>
                                                    <br />
                                                </td>
                                            </tr>
                                            <tr id="Tr2" runat="server">
                                                <td id="Td2" runat="server">
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="a-center">
                                        <asp:Button ID="btnpopClose" OnClick="btnpopClose_Click" runat="server" class="btn"
                                            Text="Ok" meta:resourcekey="btnpopCloseResource1" />
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </center>
                </asp:Panel>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    <asp:HiddenField ID="hdnOldPasswordReturn" runat="server" />
    <asp:HiddenField ID="hdnPasswordScope" runat="server" />
    <asp:HiddenField ID="hdnLoginName" Value="" runat="server" />
    <asp:HiddenField ID="hdnRecords" runat="server" />
    <asp:HiddenField ID="hdnprepass" runat="server" />
    <asp:HiddenField ID="hdnType" runat="server" />
    <asp:HiddenField ID="hdnpasslength" runat="server" />
    <asp:HiddenField ID="hdnsplcharlen" runat="server" />
    <asp:HiddenField ID="hdnnumcharlen" runat="server" />
    <asp:HiddenField ID="hdntranspasslength" runat="server" />
    <asp:HiddenField ID="hdntranssplcharlen" runat="server" />
    <asp:HiddenField ID="hdntransnumcharlen" runat="server" />
    <asp:HiddenField ID="hdnpwdplcycount" runat="server" />
    <asp:HiddenField ID="hdntranspwdplcycount" runat="server" />
    <asp:HiddenField ID="hdnpwdexpdate" runat="server" />
    <asp:HiddenField ID="hdntranspwdexpdate" runat="server" />
    <Attune:Attunefooter ID="Attunefooter" runat="server" />
    <asp:HiddenField ID="hdnMessages" runat="server" />
    <asp:HiddenField ID="hdnOrgID" runat="server" />    <%-- </div>--%>
	<%--<asp:CustomValidator ID="CV_OldPwd" ValidationGroup="PwdValidation" ValidateEmptyText="true" Display="None" ControlToValidate="txtOldpassword" EnableClientScript="false" 
     runat="server"  OnServerValidate="ServerValidation_TEXT"></asp:CustomValidator>
     <asp:CustomValidator ID="CV_NewPwd" ValidationGroup="PwdValidation" ValidateEmptyText="true" Display="None" ControlToValidate="txtNewpassword" EnableClientScript="false" 
     runat="server"  OnServerValidate="ServerValidation_TEXT"></asp:CustomValidator>
     <asp:CustomValidator ID="CV_ConfirmPwd" ValidationGroup="PwdValidation" ValidateEmptyText="true" Display="None" ControlToValidate="txtConfirmpassword" EnableClientScript="false" 
     runat="server"  OnServerValidate="ServerValidation_TEXT"></asp:CustomValidator>--%>
    </form>

    <script type="text/javascript" language="javascript">
        function show() {
            document.getElementById('pnlOthers').style.display = "block";

        }

        //added
        $(window).on('load', function() {
            $('#pnlOthers').css('top', '30%');
            $('#pnlOthers').css('left', '35%');
        });
        //-- <Start> RIL PasswordPolicy Script - by, Manikandarajan --//
        function checkSplchar(Character) {
            //debugger;
            var allowableChar = /^[A-Za-z0-9]*$/
            var checkChar = Character;
            var splCharcount = 0;
            IsAllow = 0;
            if (!allowableChar.test(checkChar)) {
                IsAllow = 1;
                for (var j = 0; j < getSpecialchar.length; j++) {
                    if (checkChar == getSpecialchar[j]) {
                        splCharcount++;
                    }
                }

            }
            return IsAllow + '-' + splCharcount;
        }
        //added
		 function ValidSpecialchar(getID) {
		     //debugger;
            getSpecialchar = validSpecialchar.split(',');
            var newPWD = $('#' + getID).val();
            var getnewPWDChar = '';
            var splCharcount;
            if (newPWD != '') {
                for (var i = 0; i < newPWD.length; i++) {
                    getnewPWDChar = newPWD.charAt(i);
                    var splCharcount = checkSplchar(getnewPWDChar);
                    getstatus = splCharcount.split('-');
                }
                if (getstatus[0] == 1 && getstatus[1] == 0) {
                    alert("Enter valid special character. Please refer Password Policy.");
                    $('#' + getID).val('');
                    return false;
                }

            }


        }



function checkPWD(getPWD) {
            var pw = getPWD;
            var count = 0;
            var splCharCount = 0;
            var getName = '';
            var NameFound = 0;
            var getChar = '';
            var uppercase = 0;
            var numericChar = 0;
            var IsvalidSpecialchar = 0;
            getSpecialchar = validSpecialchar.split(',');
            var allowableChar = /^[A-Za-z0-9]*$/
            var isUpperCase = /^[A-Z]*$/
            var isLowerCase = /^[a-z]*$/
            var numericOnly = /^[0-9]*$/
            for (var i = 0; i < pw.length; i++) {
                getChar = pw.charAt(i);

                if (Number(upperCaselength) > 0) {
                    if (isUpperCase.test(getChar)) {
                        uppercase++;
                        //getName += getChar;
                    }
                    if (isLowerCase.test(getChar)) {
                        //getName += getChar;
                    }
                }
                if (Number(numCharlength) > 0) {
                    if (numericOnly.test(getChar)) {
                        numericChar++;
                    }
                }
                IsvalidSpecialchar = checkSplchar(getChar);
                getstatus = IsvalidSpecialchar.split('-');
                if (getstatus[0] > 0) {
                    splCharCount++;
                }
            }
            //alert(getName);
            getLoginName = document.getElementById('hdnLoginName').value.toUpperCase();
            LoginName = getLoginName.split(' ');
            var FirstName = LoginName[0].split('.')[1];
            //Check whether the password contain LoginName, if found throw alert.  eg. LoginName = "Dr.FirstName LastName"
            if (getLoginName != '') {
                getName = pw.toUpperCase().match(new RegExp(getLoginName));
                if (getName != null && getLoginName.toUpperCase() == getName) {
                    NameFound++;
                }
            }
            //Check whether the password contain FirstName of LoginName, if found throw alert.  eg. LoginName = "Dr.FirstName LastName"
            if (FirstName != '') {
                var getFirstName = pw.toUpperCase().match(new RegExp(FirstName));
                if (getFirstName != null && FirstName == getFirstName) {
                    NameFound++;
                }
            }
            //Check whether the password contain FirstName with titlecode and Lastname of LoginName, if found throw alert.  eg. LoginName = "Dr.FirstName LastName"
            for (var i = 0; i < LoginName.length; i++) {
                if (LoginName[i] != '') {
                    var nameArray = LoginName[i];
                    var getNameArray = pw.toUpperCase().match(new RegExp(nameArray));
                    if (getNameArray != null && LoginName[i].toUpperCase() == getNameArray) {
                        NameFound++;
                    }
                }
            }
            //If Password contain user name throw alert.
            if (NameFound > 0) {
                count++;
                alert("Don't use user name in Password.");
                document.getElementById('txtNewpassword').value = '';
                document.getElementById('txtConfirmpassword').value = '';
                $('#divLpwdHint').hide();
                $('#tdPWDVisualstatus').removeClass().addClass('hide');
                document.getElementById('txtNewpassword').focus();
                return count;

            }
            //Throw alert only when UpperCase length found in Database ( greater than 0)
            if (Number(upperCaselength) > 0 && uppercase < Number(upperCaselength)) {
                count++;
                alert("Should have atleast " + Number(upperCaselength) + " Uppercase. Please check the Password Policy.");
                document.getElementById('txtNewpassword').value = '';
                document.getElementById('txtConfirmpassword').value = '';
                $('#divLpwdHint').hide();
                $('#tdPWDVisualstatus').removeClass().addClass('hide');
                document.getElementById('txtNewpassword').focus();
                return count;
            }
            //Throw alert only when Numeric length found in Database ( greater than 0)
            if (Number(numCharlength) > 0 && numericChar < Number(numCharlength)) {
                count++;
                alert("Should have atleast " + Number(numCharlength) + " Numeric Character. Please check the Password Policy.");
                document.getElementById('txtNewpassword').value = '';
                document.getElementById('txtConfirmpassword').value = '';
                $('#divLpwdHint').hide();
                $('#tdPWDVisualstatus').removeClass().addClass('hide');
                document.getElementById('txtNewpassword').focus();
                return count;
            }
            //Throw alert when Invalid special character found. ( refer checkSplchar(), ValidSpecialchar() )
            if (getstatus[0] == 1 && getstatus[1] == 0) {
                count++;
                alert("Enter valid special character. Please check the Password Policy.");
                document.getElementById('txtNewpassword').value = '';
                document.getElementById('txtConfirmpassword').value = '';
                $('#divLpwdHint').hide();
                $('#tdPWDVisualstatus').removeClass().addClass('hide');
                document.getElementById('txtNewpassword').focus();
                return count;
            }
            //Throw alert only when Special character length found in Database ( greater than 0)
            if (splCharlength > 0 && splCharCount < Number(splCharlength)) {
                count++;
                alert("Should have atleast " + Number(splCharlength) + " Special Character. Please check the Password Policy.");
                document.getElementById('txtNewpassword').value = '';
                document.getElementById('txtConfirmpassword').value = '';
                $('#divLpwdHint').hide();
                $('#tdPWDVisualstatus').removeClass().addClass('hide');
                document.getElementById('txtNewpassword').focus();
                return count;
            }
            //            if (uppercase == 0 || (getstatus[0] == 1 && getstatus[1] == 0) || !passed) {
            //                alert('Invalid Password. Please check the Password Policy');
            //                document.getElementById('txtNewpassword').value = '';
            //                document.getElementById('txtConfirmpassword').value = '';
            //                $('#divLpwdHint').hide();
            //                document.getElementById('txtNewpassword').focus();
            //                return false;
            //            }
        }
        function TextboxValidation1() {

            if (PasswordPolicy.length > 0) {

                if (document.getElementById('txtOldpassword').value == '') {
                    alert('Provide old password');
                    document.getElementById('txtOldpassword').focus();
                    return false;
                }

                if (document.getElementById('txtNewpassword').value == '') {
                    alert('Provide new password');
                    document.getElementById('txtNewpassword').focus();
                    return false;
                }
                if (document.getElementById('txtConfirmpassword').value == '') {
                    alert('Provide confirm password');
                    document.getElementById('txtConfirmpassword').focus();
                    return false;
                }
                if (document.getElementById('txtNewpassword').value.length < passMinlength) {
                    alert('Password length should be atleast ' + passMinlength + ' characters.');
                    document.getElementById('txtNewpassword').focus();
                    return false;
                }
                if (document.getElementById('txtNewpassword').value.length > Number(passMaxlength)) {
                    alert('Maximum Length Reached. Please check Password Policy.');
                    document.getElementById('txtNewpassword').value = '';
                    $('#tdPWDVisualstatus').removeClass().addClass('hide');
                    document.getElementById('txtConfirmpassword').value = '';
                    document.getElementById('txtNewpassword').focus();
                    return false;
                }
                if (document.getElementById('txtOldpassword').value == document.getElementById('txtNewpassword').value) {
                    alert('New password and old password cannot be same');
                    document.getElementById('txtOldpassword').value = '';
                    document.getElementById('txtNewpassword').value = '';
                    $('#tdPWDVisualstatus').removeClass().addClass('hide');
                    document.getElementById('txtConfirmpassword').value = '';
                    document.getElementById('chkShowPassword').checked = false;
                    ShowPassword();
                    document.getElementById('txtOldpassword').focus();
                    return false;
                }
                if (document.getElementById('txtNewpassword').value != document.getElementById('txtConfirmpassword').value) {
                    alert('There is a password mismatch');
                    document.getElementById('txtNewpassword').value = '';
                    $('#tdPWDVisualstatus').removeClass().addClass('hide');
                    document.getElementById('txtConfirmpassword').value = '';
                    document.getElementById('txtNewpassword').focus();
                    return false;
                }
                if (document.getElementById('txtNewpassword').value == document.getElementById('txtConfirmpassword').value) {
                    var pw = document.getElementById('txtConfirmpassword').value;
                    var getCount = checkPWD(pw);
                    if (getCount > 0) {
                        return false;
                    }
                    else {
                        return true;
                    }
                }


            }
            else {
                if (document.getElementById('txtOldpassword').value == '') {
                    alert('Provide old password');
                    document.getElementById('txtOldpassword').focus();
                    return false;
                }

                if (document.getElementById('txtNewpassword').value == '') {
                    alert('Provide new password');
                    document.getElementById('txtNewpassword').focus();
                    return false;
                }

                if (document.getElementById('txtConfirmpassword').value == '') {
                    alert('Provide confirm password');
                    document.getElementById('txtConfirmpassword').focus();
                    return false;
                }


                if (document.getElementById('txtNewpassword').value.length < PasswordPolicy[0].Numcharlen) {
                    alert('Password length should be atleast 8 characters.');
                    document.getElementById('txtNewpassword').value = '';
                    document.getElementById('txtNewpassword').focus();
                    return false;
                }


                if (document.getElementById('txtOldpassword').value == document.getElementById('txtNewpassword').value) {
                    alert('New password and old password cannot be same');
                    document.getElementById('txtOldpassword').value = '';
                    document.getElementById('txtNewpassword').value = '';
                    document.getElementById('txtConfirmpassword').value = '';
                    document.getElementById('chkShowPassword').checked = false;
                    ShowPassword();
                    document.getElementById('txtOldpassword').focus();
                    return false;
                }

                if (document.getElementById('txtNewpassword').value != document.getElementById('txtConfirmpassword').value) {
                    alert('There is a password mismatch');
                    document.getElementById('txtNewpassword').value = '';
                    document.getElementById('txtConfirmpassword').value = '';
                    document.getElementById('txtNewpassword').focus();
                    return false;
                }



                if (document.getElementById('txtNewpassword').value == document.getElementById('txtConfirmpassword').value) {
                    var pw = document.getElementById('txtConfirmpassword').value;
                    var passed = validatePassword(pw, { alpha: 1, special: 0, numeric: 0 });
                    if (!passed) {
                        alert('Password should contain atleast one special character,an alphabet and a number');
                        document.getElementById('txtNewpassword').value = '';
                        document.getElementById('txtConfirmpassword').value = '';
                        document.getElementById('txtNewpassword').focus();
                        return false;
                    }

                }

            }

            return true;
        }

        function ShowPassword() {

            var oldpwd = document.getElementById('txtOldpassword');
            var newpwd = document.getElementById('txtNewpassword');
            var confirmpwd = document.getElementById('txtConfirmpassword');
            var typeText = 'text'; var typePassword = 'password';
            if ($('#chkShowPassword').is(':checked')) {
                oldpwd.type = typeText;
                newpwd.type = typeText;
                confirmpwd.type = typeText;
                return true;
            }
            else {
                oldpwd.type = typePassword;
                newpwd.type = typePassword;
                confirmpwd.type = typePassword;
                return true;
            }
        }

    </script>

</body>
</html>
