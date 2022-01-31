<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CreditNoteUpdation.aspx.cs" Inherits="Invoice_CreditNote"
    meta:resourcekey="PageResource1" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<%@ Register Src="../CommonControls/PhysicianHeader.ascx" TagName="PhyHeader"
    TagPrefix="uc7" %>

<%@ Register Src="../CommonControls/DateSelection.ascx" TagName="DateSelection"
    TagPrefix="DateCtrl" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajc" %>
<%@ Register Src="../CommonControls/Attune_OrgHeader.ascx" TagName="Attuneheader"
    TagPrefix="Attune" %>
<%@ Register Src="../CommonControls/Attune_Footer.ascx" TagName="Attunefooter"
    TagPrefix="Attune" %>
<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
    Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<script src="../Scripts/jquery-1.8.1.min.js" language="javascript" type="text/javascript"></script>

<style type="text/css">
    .notification-bubble
    {
        background-color: #F56C7E;
        border-radius: 9px 9px 9px 9px;
        box-shadow: 0 0 0 1px rgba(0, 0, 0, 0.17) inset, 0 1px 1px rgba(0, 0, 0, 0.2);
        color: #FFFFFF;
        font-size: 9px;
        font-weight: bold;
        text-align: center;
        text-shadow: 1px 1px 0 rgba(0, 0, 0, 0.2);
        -moz-transition: all 0.1s ease 0s;
        padding: 2px 3px 2px 3px;
    }
    .OutSrce
    {
        background-color: #D0FA58;
    }
    .AddScroll
    {
        height: 370px;
        width: 1200;
        padding-left: 50px;
        padding-top: 50px;
        overflow: auto;
    }
    .RemoveScroll
    {
        height: 370px;
        width: 1200;
    }
    .btn1, .btn
    {
        position: inherit !important;
    }
    .hidClum
    {
        display: none;
    }
</style>

<script language="javascript" type="text/javascript">
    function setAceWidth(source, eventArgs) {
        document.getElementById('aceDiv').style.width = 'auto';
    }
    
    function ClearFields(Name) {
        if (Name == 'HUB') {
            document.getElementById('hdnHubID').value = '0';
        }
        else if (Name == 'ZON') {
            document.getElementById('hdntxtzoneID').value = '0';
        }
        else if (Name == 'CLIENT') {
            if ($('#txtclient').val() == '') {
                document.getElementById('hdnClientID').value = '0';
            }

        }

    }
	//check given credit number have special character
    var isShift;
    function isAlphaNumeric(keyCode) {
       // debugger;
        return (((keyCode >= 48 && keyCode <= 57) && (isShift == false)) ||
               (keyCode >= 65 && keyCode <= 90) || keyCode == 8 ||
               (keyCode >= 96 && keyCode <= 105))
    }
    //
    //arun
    function Reset() {        
        document.getElementById("txtFrom").value = "";
        document.getElementById("txtTo").value = "";
        document.getElementById('ImgBntCalcFrom').value = "";
        document.getElementById('ImgBntCalcTo').value = "";
        document.getElementById('txtclient').value = "";
        document.getElementById('hdnClientID').value = "0";
        document.getElementById('txtInvoiceNo').value = "";
        $("#ddlcreditnotype").prop("selectedIndex", 0).val();
        return false;
    }
    function CancelFun() {        
        var defaultid = "grdInvoiceBill_ctl0";
        var defaultname = "grdInvoiceBill$ctl0";
        var totalrow = document.getElementById("hdnRowcount").value;
        var loopuntil = parseInt(parseInt(totalrow) + 1);        
        var checkedcount = 0;
        for (var g = 2; g <= loopuntil; g++) {
            if (parseInt(g) > 9) {
                defaultid = defaultid.replace('0', '');
                defaultname = defaultname.replace('0', '');
            }
            var checkboxid = defaultid + g + "_chkInvoiceItemunique";
            var checkboxname = defaultname + g.toString() + "$chkInvoiceItemunique";
            var otherid = defaultid + g;                        
            var textbox = document.getElementById(otherid + '_txtCreditNote');
            if (textbox.disabled) {
                // If disabled, do this                 
            }
            else {
                $('#' + otherid + '_txtCreditNote').val("")
            }

            //if ($('input[name="' + checkboxname + '"]:checked').length > 0) {
                $('input[name="' + checkboxname + '"]').prop("checked", false);
            //}
            }
        //clear the data 
       // return false;
    }
    function SetHiddenValue() {        
        //grdInvoiceBill_ctl02_chkInvoiceItemunique
        //$('input[name="grdInvoiceBill$ctl03$chkInvoiceItemunique"]:checked').length
        var defaultid = "grdInvoiceBill_ctl0";
        var defaultname = "grdInvoiceBill$ctl0";
        var totalrow = document.getElementById("hdnRowcount").value;
        var loopuntil = parseInt(parseInt(totalrow) + 1);
        $('#hdnCreditNotevalues').val("")
        var checkedcount = 0;
        for (var g = 2; g <= loopuntil; g++) {
            if (parseInt(g) > 9) {
                defaultid = defaultid.replace('0', '');
                defaultname = defaultname.replace('0', '');
            }            
            var checkboxid = defaultid + g + "_chkInvoiceItemunique";
            var checkboxname = defaultname + g.toString() + "$chkInvoiceItemunique";
            var otherid = defaultid + g;
            //("#"+checkboxid).checkedcount
            //if(("#"+checkboxid).is(":checked")){
            if ($('input[name="' + checkboxname + '"]:checked').length > 0) {
            checkedcount = parseInt(parseInt(checkedcount)+1);
            var finalbillid = $('#' + otherid+ '_lblFinalbillId').text();
            var billingDetailsId = $('#' + otherid + '_lblBillingDetailsId').text();
            var invoiceID = $('#' + otherid + '_lblInvoiceID').text();
            var clientID = $('#' + otherid + '_lblClientID').text();
            var crditnote = $('#' + otherid + '_txtCreditNote').val() != "" && $('#' + otherid + '_txtCreditNote').val() != undefined &&
                 $('#' + otherid + '_txtCreditNote').val() != null ? $('#' + otherid + '_txtCreditNote').val() : $('#' + otherid + '_txtCreditNote').text();
            crditnote = crditnote == undefined || crditnote == null || crditnote == "" ? "" : crditnote;
            if (crditnote == undefined || crditnote == null || crditnote == "") {
                //Resethdnvalue();
                $('#hdnCreditNotevalues').val("");
                alert("Empty value doesn't allow to update");
                return false;
            }
            else {
                var lstCreditNote = $('#hdnCreditNotevalues').val();
                var overallvalue = finalbillid + "_" + billingDetailsId + "_" + invoiceID + "_" + clientID + "_" + crditnote
                //if (crditnote != null && crditnote != undefined && crditnote != "") {
                if (lstCreditNote != undefined && lstCreditNote != null && lstCreditNote != "" && lstCreditNote != "0") {
                    $('#hdnCreditNotevalues').val(lstCreditNote + "^" + overallvalue);
                }
                else {
                    $('#hdnCreditNotevalues').val(overallvalue);
                }
                //}
            }
         }   
        }
        if (parseInt(checkedcount) == 0) {
            alert("Please select any one checkbox");
            return false;
        }
//        else {
//            window.WebForm_GetElementById("btnSaveCredit").click();
//        }
    }
    function deletecredit(data) {
        debugger;
        var creditnoteid = data.split("_")[0] + '_' + data.split("_")[1] + '_txtCreditNote';
        var crditnote = $("#" + creditnoteid).val();
        if (crditnote != "" && crditnote != null && crditnote != undefined) {
            $("#" + creditnoteid).val("");
        }
        else {
            alert("Credit Note not have value");
            return false;
        }
    }
    function onChange(data) {
        debugger;
//        var lstCreditNote = $('#hdnCreditNotevalues').val();
//        var inCreditNote;
      var currcrditnote = $("#"+data).val();
      var idval = data.split("_");
      var currinvoice = $('#' + data.split("_")[0] + '_' + data.split("_")[1] + '_lblInvoiceID').text();
      var defaultid = "grdInvoiceBill_ctl0";
      var defaultname = "grdInvoiceBill$ctl0";
      //same credit number not applicable for different client      
      var currclientid = $('#' + data.split("_")[0] + '_' + data.split("_")[1] + '_lblClientID').text();
      //
      var totalrow = document.getElementById("hdnRowcount").value;
      var loopuntil = parseInt(parseInt(totalrow) + 1);
      var checkedcount = 0;
      if (currcrditnote != null && currcrditnote != undefined && currcrditnote != "") {
         //check current credit note number available for different client
          for (var g = 2; g <= loopuntil; g++) {
              if (parseInt(g) > 9) {
                  defaultid = defaultid.replace('0', '');
                  defaultname = defaultname.replace('0', '');
              }
              var otherid = defaultid + g;
              var othercreditnote = $('#' + otherid + '_txtCreditNote').val();
              var otherclientid = $('#' + otherid + '_lblClientID').text();
              var otherinvoiceid = $('#' + otherid + '_lblInvoiceID').text();
              if (currclientid != otherclientid && currinvoice != otherinvoiceid && currcrditnote == othercreditnote) {
                  $("#" + data).val("");
                  alert("Given credit note is already associated with different client");
                  $("#" + data).focus();
                  return false;                                    
              }
          }
          //update the same crdit number for the same invoice number if avail
          for (var g = 2; g <= loopuntil; g++) {
              if (parseInt(g) > 9) {
                  defaultid = defaultid.replace('0', '');
                  defaultname = defaultname.replace('0', '');
              }    
              var otherid = defaultid + g;
              var otherinvoiceid = $('#' + otherid + '_lblInvoiceID').text();
              if (currinvoice == otherinvoiceid) {
                  $('#' + otherid + '_txtCreditNote').val("");
                  $('#' + otherid + '_txtCreditNote').val(currcrditnote);
                //  $('#' + otherid + '_txtCreditNote').attr('disabled', 'disabled');
              }
          }
      }     
        
//        
//            var finalbillid = $('#' + data.split("_")[0] + '_' + data.split("_")[1] + '_lblFinalbillId').text();
//            var billingDetailsId = $('#' + data.split("_")[0] + '_' + data.split("_")[1] + '_lblBillingDetailsId').text();
//            var invoiceID = $('#' + data.split("_")[0] + '_' + data.split("_")[1] + '_lblInvoiceID').text();
//            var clientID = $('#' + data.split("_")[0] + '_' + data.split("_")[1] + '_lblClientID').text();

//            var overallvalue = finalbillid + "_" + billingDetailsId + "_" + invoiceID + "_" + clientID + "_" + crditnote
//            if (crditnote != null && crditnote != undefined && crditnote != "") {
//                if (lstCreditNote != undefined && lstCreditNote != null && lstCreditNote != "" && lstCreditNote != "0") {
//                    $('#hdnCreditNotevalues').val(lstCreditNote + "^" + overallvalue);
//                }
//                else {
//                    $('#hdnCreditNotevalues').val(overallvalue);
//                }
//            }
    }
</script>

<script language="javascript" type="text/javascript">
    jQuery(function($) {
        //debugger;
        var allCkBoxSelector = 'input[id*="chkAllItem"]:checkbox';
        var checkBoxSelector = '#<%=grdInvoiceBill.ClientID%> input[id*="chkInvoiceItem"]:checkbox';
        function ToggleCheckUncheckAllOptionAsNeeded() {
            var totalCkboxes = $(checkBoxSelector),
                    checkedCheckboxes = totalCkboxes.filter(":checked"),
                    noCheckboxesAreChecked = (checkedCheckboxes.length == 0),
                    allCkboxesAreChecked = (totalCkboxes.length == checkedCheckboxes.length);
            $(allCkBoxSelector).attr('checked', allCkboxesAreChecked);
        }

        $(allCkBoxSelector).live('click', function() {
            $(checkBoxSelector).attr('checked', $(this).is(':checked'));
            ToggleCheckUncheckAllOptionAsNeeded();
        });
        $(checkBoxSelector).live('click', ToggleCheckUncheckAllOptionAsNeeded);
        ToggleCheckUncheckAllOptionAsNeeded();
    });
    function isSpclChar(e) {
        var key;
        var isCtrl = false;
        if (window.event) // IE8 and earlier
        {
            key = e.keyCode;
        }
        else if (e.which) // IE9/Firefox/Chrome/Opera/Safari
        {
            key = e.which;
        }
        //*************To block slash(/) into text box change the key value to 48***************************//
        if ((key >= 47 && key <= 57) || (key >= 97 && key <= 122) || (key >= 65 && key <= 90) || (key == 8) || (key == 32)) {
            isCtrl = true;
        }
        return isCtrl;
    }
  
    function validatePageNumber() {
        if (document.getElementById('txtpageNo').value == "") {
            return false;
        }
    }
    function ClearVal() {
        document.getElementById('txtclient').value = "";
        document.getElementById('hdnClientID').value = "0";
    }

    function setContextVal(ID) {
        if ($find('AutoCompleteExtender2') != null) {
            var cusID = 0;
            var Type = 0;
            if (Number(cusID) > Number(0)) {
                var orgID = '<%= OrgID %>';
                $find('AutoCompleteExtender2').set_contextKey(orgID + '~' + Type + '~' + cusID);
            }
            else {
                //                alert('Please select client type');
                //                document.getElementById(ID).value = "";
                //                document.getElementById('drpCustomerType').focus();
                //                return false;
                var orgID = '<%= OrgID %>';
                $find('AutoCompleteExtender2').set_contextKey(orgID + '~' + '0' + '~' + cusID);
            }
        }
    }

    var prevClientID = '';
    function onChaangeChk(obj) {
        var val = $('#' + obj).closest('tr').find('.getClientID').attr('id');
        if ($('#' + obj).closest('table').find('tr input[type="checkbox"]:checked').length == 1) {
            prevClientID = $('#' + val)[0].innerText;
        }
        else {
           var Ckhid = $('#' + val).closest('tr').find('input[type="checkbox"]').attr('id');
//            if ($('#' + val)[0].innerText == prevClientID) {



                $('#' + Ckhid).attr('checked', true);
//            }
//            else {
//                alert('Please Select Particular Client Alone!!!!');
//                $('#' + Ckhid).attr('checked', false);
//            }

        }
        if (prevClientID != '') {

        }
        else {
            prevClientID = $('#' + val)[0].innerText;
        }



        if (document.getElementById(obj).checked) {
            
        }
        else {
            var x = ""; //
            
            for (i = 0; i < x.length; i++) {
                if (x[i] != '') {
                    if (x[i] != obj) {
                        
                    }
                }
            }
        }
    }
    function ClientSelected(source, eventArgs) {
        var list = eventArgs.get_value().split('^');
        var ID = "0";
        if (list[0] != "") {
            ID = list[0];
        }
        document.getElementById('hdnClientID').value = ID;
    }

    function CheckToSaveData() {
        debugger;
        var Reportshow = false;
        document.getElementById('hdnShowReport').value = Reportshow;

        var inVoiceNo = document.getElementById('txtInvoiceNo').value;
        var customerType = 0;

        var frmdt = document.getElementById("txtFrom") != null && document.getElementById("txtFrom") != undefined ? document.getElementById("txtFrom").value : "";
        var todt = document.getElementById("txtTo") != null && document.getElementById("txtTo") != undefined ? document.getElementById("txtTo").value:"";
        if (frmdt != null && frmdt != undefined && frmdt != "" && (todt == null || todt == undefined || todt == "")) {
            alert("Select To Date");
            return false;
        }
        if (todt != null && todt != undefined && todt != "" && (frmdt == null || frmdt == undefined || frmdt == "")) {
            alert("Select From Date");
            return false;
        }
        //check from date should be less than or equal to to date
        var pattern = /(\d{2})\/(\d{2})\/(\d{4})/;        
        if (new Date(frmdt.replace(pattern, '$3-$2-$1')) > new Date(todt.replace(pattern, '$3-$2-$1'))) {
            alert("From Date should not greater than To Date");
            return false;
        }
        //        if (inVoiceNo == "") {
        //            if (customerType == '0') {
        //                alert('Please Select Business Type');
        //                document.getElementById('drpCustomerType').focus();
        //                return false;
        //            }
        //        }
    }


</script>

<style>
    .AutoCompletesearchBox1
    {
        font-family: Arial, Helvetica, sans-serif;
        text-align: left;
        height: 15px;
        width: 150px;
        border: 1px solid #999999;
        font-size: 11px;
        margin-left: 0px;
        background-image: url('../Images/magnifying-glass.png');
        background-repeat: no-repeat;
        padding-left: 20px;
    }
    .AutoCompletesearchBox2
    {
        font-family: Arial, Helvetica, sans-serif;
        text-align: left;
        height: 15px;
        width: 250px;
        border: 1px solid #999999;
        font-size: 11px;
        margin-left: 0px;
        background-image: url('../Images/magnifying-glass.png');
        background-repeat: no-repeat;
        padding-left: 20px;
    }
</style>
<head id="Head1" runat="server">
    <title>
        Credit Note Updation
    </title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="True">
    </asp:ScriptManager>
    <Attune:Attuneheader ID="Attuneheader" runat="server" />
    <div class="contentdata">
        <table class="w-100p">
            <tr>
                <td>
                    <div class="dataheader3">
                        <table class="w-100p">
                            <tr>
                                <td>
                                    <asp:Label ID="lblResult" ForeColor="#000333" runat="server" meta:resourceKey="lblResultResource1"></asp:Label>
                                </td>
                            </tr>
                        </table>
                        <asp:Panel ID="pnlPSearch" runat="server" CssClass="w-100p" meta:resourcekey="pnlPSearchResource1">
                            <table class="dataheader2 defaultfontcolor w-100p">
                                <tr>
                                <td style="width:18% !important;"></td>
                                    <td class="w-8p a-left">
                                        <asp:Label ID="lblInvoiceNo" Text="Cr. Note Number:" runat="server" ></asp:Label>
                                    </td>
                                    <td class="w-10p a-left">
                                        <asp:TextBox ID="txtInvoiceNo" onkeypress="return ValidateSplChar(event.keyCode);"
                                            runat="server" CssClass="small" TabIndex="1" ></asp:TextBox>
                                    </td>                                    
                                    <td class="w-8p">
                                        <asp:Label ID="lblClientName" Text="Select Client:" runat="server"></asp:Label>
                                    </td>
                                    <td class="w-20p a-left" style="padding-left:6px;">
                                        <asp:TextBox ID="txtclient" onkeypress="setContextVal(this.id);" CssClass="AutoCompletesearchBox2 small"
                                            runat="server" TabIndex="3" onchange="javascript:return ClearFields('CLIENT');"
                                            meta:resourcekey="txtclientResource1"></asp:TextBox>
                                        <div id="aceDiv">
                                        </div>
                                        <ajc:AutoCompleteExtender ID="AutoCompleteExtender2" runat="server" TargetControlID="txtclient"
                                            EnableCaching="False" MinimumPrefixLength="1" CompletionInterval="1" FirstRowSelected="True"
                                            CompletionListCssClass="wordWheel listMain .box" CompletionListItemCssClass="wordWheel itemsMain"
                                            CompletionListHighlightedItemCssClass="wordWheel itemsSelected3" ServiceMethod="GetClientNamebyClientType"
                                            ServicePath="~/WebService.asmx" UseContextKey="True" DelimiterCharacters="" Enabled="True"
                                            OnClientItemSelected="ClientSelected" CompletionListElementID="aceDiv" OnClientShown="setAceWidth">
                                        </ajc:AutoCompleteExtender>
                                    </td>
                                </tr>
                             
                                <tr>
                                <td style="width:18% !important;"></td>
                                    <td class="a-left">
                                        <asp:Label ID="lblFrom" Text="From Date:" runat="server"></asp:Label>
                                    </td>
                                    <td class="a-left w-20p">
                                        <asp:TextBox ID="txtFrom" TabIndex="6" CssClass="small" runat="server" meta:resourcekey="txtFromResource1"></asp:TextBox>
                                        <asp:ImageButton ID="ImgBntCalcFrom" runat="server" ImageUrl="~/images/Calendar_scheduleHS.png"
                                            CausesValidation="False" meta:resourcekey="ImgBntCalcFromResource1" /><br />
                                        <ajc:MaskedEditExtender ID="MaskedEditExtender5" runat="server" TargetControlID="txtFrom"
                                            Mask="99/99/9999" MaskType="Date" ErrorTooltipEnabled="True" CultureAMPMPlaceholder=""
                                            CultureCurrencySymbolPlaceholder="" CultureDateFormat="" CultureDatePlaceholder=""
                                            CultureDecimalPlaceholder="" CultureThousandsPlaceholder="" CultureTimePlaceholder=""
                                            Enabled="True" />
                                        <ajc:MaskedEditValidator ID="MaskedEditValidator5" runat="server" ControlExtender="MaskedEditExtender5"
                                            ControlToValidate="txtFrom" EmptyValueMessage="Date is required" InvalidValueMessage="Date is invalid"
                                            Display="Dynamic" TooltipMessage="(dd-mm-yyyy)" EmptyValueBlurredText="*" InvalidValueBlurredMessage="*"
                                            ValidationGroup="MKE" ErrorMessage="MaskedEditValidator5" meta:resourcekey="MaskedEditValidator5Resource1" />
                                        <ajc:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="txtFrom"
                                            Format="dd/MM/yyyy" PopupButtonID="ImgBntCalcFrom" Enabled="True" />
                                    </td>
                                    <td class="a-left w-8p">
                                        <asp:Label ID="lblTo" Text="To Date:" runat="server"></asp:Label>
                                    </td>
                                    <td class="a-left">
                                        &nbsp;<asp:TextBox ID="txtTo" TabIndex="7" CssClass="small" runat="server" meta:resourcekey="txtToResource1"></asp:TextBox>
                                        <asp:ImageButton ID="ImgBntCalcTo" runat="server" ImageUrl="~/images/Calendar_scheduleHS.png"
                                            CausesValidation="False" meta:resourcekey="ImgBntCalcToResource1" /><br />
                                        <ajc:MaskedEditExtender ID="MaskedEditExtender1" runat="server" TargetControlID="txtTo"
                                            Mask="99/99/9999" MaskType="Date" ErrorTooltipEnabled="True" CultureAMPMPlaceholder=""
                                            CultureCurrencySymbolPlaceholder="" CultureDateFormat="" CultureDatePlaceholder=""
                                            CultureDecimalPlaceholder="" CultureThousandsPlaceholder="" CultureTimePlaceholder=""
                                            Enabled="True" />
                                        <ajc:MaskedEditValidator ID="MaskedEditValidator1" runat="server" ControlExtender="MaskedEditExtender5"
                                            ControlToValidate="txtTo" EmptyValueMessage="Date is required" InvalidValueMessage="Date is invalid"
                                            Display="Dynamic" TooltipMessage="(dd-mm-yyyy)" EmptyValueBlurredText="*" InvalidValueBlurredMessage="*"
                                            ValidationGroup="MKE" ErrorMessage="MaskedEditValidator1" meta:resourcekey="MaskedEditValidator1Resource1" />
                                        <ajc:CalendarExtender ID="CalendarExtender2" runat="server" TargetControlID="txtTo"
                                            Format="dd/MM/yyyy" PopupButtonID="ImgBntCalcTo" Enabled="True" />
                                    </td>                                  
                                    <td>
                                      <asp:Label ID="lblcrednitnotype" Text="Credit No Type:"  runat="server"></asp:Label>
                                    </td>               
                                    <td>
                                    <asp:DropDownList ID="ddlcreditnotype" CssClass="ddl" runat="server"></asp:DropDownList>
                                    </td>                  
                                </tr>
                                <tr>
                                    <td colspan="6" class="a-center">
                                        <asp:Button ID="btnSearch" runat="server" Text="Search" OnClientClick="return CheckToSaveData()"
                                            CssClass="btn" OnClick="btnSearch_Click" meta:resourcekey="btnSearchResource1" />
                                 
                                        <asp:Button ID="btnReset" runat="server" Text="Reset" 
                                            CssClass="btn"  Width="50px" OnClientClick="return Reset();" />
                                    </td>
                                </tr>
                            </table>
                    
                            <table runat="server" id="tblgrd" class="w-100p">
                            
                                <tr>
                                    <td>
                                            <asp:UpdatePanel ID="up1" runat="server">
                                        <ContentTemplate>
                                        <div class="dataheader3">
                                            <asp:GridView ID="grdInvoiceBill" runat="server" CssClass="mytable gridView w-100p m-auto"
                                                AutoGenerateColumns="false" DataKeyNames="ClientCode,ClientName,VisitNumber,CancelledDate,BillSupplyNumber,TestCode,TestName,CreditNote"
                                                OnRowDataBound="grdInvoiceBill_RowDataBound" OnRowCommand="grdInvoiceBill_RowCommand" OnPageIndexChanging="grdInvoiceBill_PageIndexChanging">
                                                <Columns>
                                                    <asp:TemplateField HeaderText="" HeaderStyle-HorizontalAlign="Center">
                                                        <HeaderTemplate>
                                                                                    <asp:CheckBox ID="chkAllItem" runat="server" />
                                                                                </HeaderTemplate>
                                                        <ItemTemplate>
                                                            <asp:CheckBox ID="chkInvoiceItemunique" class="CheckClient" runat="server" />
                                                        </ItemTemplate>
                                                        <ItemStyle HorizontalAlign="center"></ItemStyle>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Finalbill ID" HeaderStyle-HorizontalAlign="Center" ItemStyle-CssClass="hidClum" HeaderStyle-CssClass="hidClum">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblFinalbillId" Text='<%# Eval("FinalbillId") %>' runat="server"></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="BillingDetails ID" HeaderStyle-HorizontalAlign="Center" ItemStyle-CssClass="hidClum" HeaderStyle-CssClass="hidClum">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblBillingDetailsId" Text='<%# Eval("BillingDetailsId") %>' runat="server"></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                   <asp:TemplateField HeaderText="Invoice ID" HeaderStyle-HorizontalAlign="Center" ItemStyle-CssClass="hidClum" HeaderStyle-CssClass="hidClum">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblInvoiceID" Text='<%# Eval("InvoiceId") %>' runat="server"></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Client ID" HeaderStyle-HorizontalAlign="Center" ItemStyle-CssClass="hidClum"
                                                        HeaderStyle-CssClass="hidClum">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblClientID" class="getClientID" Text='<%# Eval("ClientId") %>' runat="server"></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                     <asp:TemplateField HeaderText="Client Code" HeaderStyle-HorizontalAlign="Center"
                                                        ItemStyle-HorizontalAlign="Left">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblClientCode" Text='<%# Eval("ClientCode") %>' runat="server"></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Client Name" HeaderStyle-HorizontalAlign="Center"
                                                        ItemStyle-HorizontalAlign="Left">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblClientName" Text='<%# Eval("ClientName") %>' runat="server"></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                     <asp:TemplateField HeaderText="Visit Number" HeaderStyle-HorizontalAlign="Center"
                                                        ItemStyle-HorizontalAlign="Left">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblVisitNumber" Text='<%# Eval("VisitNumber") %>' runat="server"></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:BoundField DataField="CancelledDate" HeaderText="Cancelled Date" DataFormatString="{0:dd MMM yyyy hh:mm tt}"
                                                        HeaderStyle-HorizontalAlign="Center" />
                                                    <asp:TemplateField HeaderText="Bill of Supply Number" HeaderStyle-HorizontalAlign="Center"
                                                        ItemStyle-HorizontalAlign="Left">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblBillSupplyNumber" Text='<%# Eval("BillSupplyNumber") %>' runat="server"></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>                                                                                                       
                                                    <asp:BoundField DataField="AmountCharged" HeaderText="Amount Charged" DataFormatString="{0:0.00}" HeaderStyle-HorizontalAlign="Center" />
                                                     <asp:TemplateField HeaderText="Test Code" HeaderStyle-HorizontalAlign="Center"
                                                        ItemStyle-HorizontalAlign="Left">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblTestCode" Text='<%# Eval("TestCode") %>' runat="server"></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField> 
                                                      <asp:TemplateField HeaderText="Test Name" HeaderStyle-HorizontalAlign="Center"
                                                        ItemStyle-HorizontalAlign="Left">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblTestName" Text='<%# Eval("TestName") %>' runat="server"></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField> 
                                                      <asp:TemplateField HeaderText="Credit Note" HeaderStyle-HorizontalAlign="Center"
                                                        ItemStyle-HorizontalAlign="Left">
                                                        <ItemTemplate>
                                                            <%--<asp:Label ID="lblCreditNote" Text='<%# Eval("CreditNote") %>' runat="server"></asp:Label>--%>
                                                            <asp:TextBox ID="txtCreditNote"  Text='<%# Eval("CreditNote") %>' onkeypress="return ValidateSplChar(event.keyCode);" 
                                            runat="server" CssClass="small" TabIndex="1"></asp:TextBox>                                            
                                                        </ItemTemplate>
                                                    </asp:TemplateField> 
                                                     <asp:TemplateField HeaderText="Action" HeaderStyle-HorizontalAlign="Center" ItemStyle-CssClass="hidClum" HeaderStyle-CssClass="hidClum"
                                                        ItemStyle-HorizontalAlign="Left">
                                                        <ItemTemplate>                                                                                                      
                                            <asp:Image ID="imgClrCreditNote" runat="server" ImageUrl="../Images/delete11.png" class='btndeleteRate pull-right' />
                                                        </ItemTemplate>
                                                    </asp:TemplateField>  
                                                </Columns>
                                                <PagerSettings FirstPageText="" LastPageText="" Mode="NumericFirstLast" NextPageText="&gt;&gt;"
                                                    PageButtonCount="5" PreviousPageText="&lt;&lt;" />
                                                <PagerStyle HorizontalAlign="Center" />
                                            </asp:GridView>
                                        </div>
                                        </ContentTemplate>
                                        </asp:UpdatePanel>
                                        <asp:HiddenField ID="hdnCreditNotevalues" Value="" runat="server" />
                                    </td>
                                </tr>
                                <tr id="GrdFooter" runat="server" style="display: none" class="dataheaderInvCtrl">
                                    <td class="defaultfontcolor a-center">
                                        <asp:Label ID="Label2" runat="server" Text="Page"  meta:resourcekey="Label2Resource11"></asp:Label>
                                        <asp:Label ID="lblCurrent" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                                        <asp:Label ID="Label3" runat="server" Text="Of" meta:resourcekey="Label3Resource11"></asp:Label>
                                        <asp:Label ID="lblTotal" runat="server" Font-Bold="True"></asp:Label>
                                        <asp:Button ID="btnPrevious" runat="server" Text="Previous" CssClass="btn" OnClick="btnPrevious_Click" meta:resourcekey="btnPreviousResource11"/>
                                        <asp:Button ID="btnNext" runat="server" Text="Next" CssClass="btn" OnClick="btnNext_Click" meta:resourcekey="btnNextResource11"/>
                                        <asp:HiddenField ID="hdnCurrent" runat="server" />
                                        <asp:HiddenField ID="hdnRowcount" runat="server" />
                                        <asp:Label ID="Label4" runat="server" Text="Enter The Page To Go:" meta:resourcekey="Label4Resource11"></asp:Label>
                                        <asp:TextBox ID="txtpageNo" runat="server" CssClass="Txtboxsmall w-30"   onkeypress="return ValidateOnlyNumeric(this);"  ></asp:TextBox>
                                        <asp:Button ID="btnGo" runat="server" Text="Go" CssClass="btn" OnClientClick="javascript:return validatePageNumber();"
                                            OnClick="btnGo_Click" meta:resourcekey="btnGoResource11"/>
                                        <asp:HiddenField ID="hdnTrustedlist" runat="server" Value="0" />
                                    </td>
                                </tr>
                            </table>
                            <table id="tblSaveNote" class="w-50p m-auto" runat="server">
                              <tr style="display: none;margin-left: 225px;" id="tr1">
                                                                <td class="w-30p a-right" colspan="2">
                                                                    <asp:Button ID="btnSaveCredit" runat="server" Text="Update" onmouseover="this.className='btn btnhov'" OnClientClick="return SetHiddenValue();"
                                                                        CssClass="btn" onmouseout="this.className='btn'" Width="75px" TabIndex="18" 
                                                                    OnClick="btnSaveCredit_Click"  />
                                                                </td>
                                                                <td colspan="3" class="w-80p a-left">
                                                                    <asp:Button ID="Button2" runat="server" Text="Cancel" 
                                                                        CssClass="btn"  Width="75px" OnClientClick="return CancelFun();"
                                                                        TabIndex="19"  />
                                                                </td>
                                                            </tr>
                                                            </table>

                        </asp:Panel>                                                                                                
                        <input type="hidden" id="hdnPDFType" name="PType" runat="server" />
                        <asp:HiddenField ID="hdnShowReport" runat="server" Value="false" />
                        <asp:HiddenField ID="hdnInvID" Value="0" runat="server" />
                        <asp:HiddenField ID="hdnChkInvoice" Value="0" runat="server" />
                        <asp:HiddenField ID="hdnClientID" runat="server" Value="0" />
                        <input type="hidden" id="hdnHubID" runat="server" value="0" />
                        <input type="hidden" id="hdntxtzoneID" runat="server" value="0" />
						 <input type="hidden" id="hdnInvoiceType" runat="server" />
						 <input type="hidden" runat="server" id="hdnInvoiceMultiplePayment" value="0"/>
                    </div>
                </td>
            </tr>
        </table>
    </div>
    <Attune:Attunefooter ID="Attunefooter" runat="server" />
    <asp:HiddenField ID="hdnMessages" runat="server" />
    </form>
</body>
</html>
