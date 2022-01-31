﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Genes2MEBillPrint.ascx.cs" Inherits="CommonControls_Genes2MEBillPrint" %>
<%@ Register Src="ErrorDisplay.ascx" TagName="ErrorDisplay" TagPrefix="uc1" %>
<%@ Register Src="FinalBillHeader.ascx" TagName="FinalBillHeader" TagPrefix="uc3" %>

<style type="text/css">
    .gridView1 th
    {
    background-color: rgb(211, 211, 211);
    }
     .gridView1 tr th
    {
    text-align:center;
    }
    .gridView1 tr td
    {
        border-top:none;
        border-bottom:none;
         
    }
    .AlgRgh
    {
        text-align:left;
    }
    .style1
    {
        width: 10px;
    }
    tHead
    {
        display: table-header-group;
    }
    .style2
    {
        width: 4%;
        height: 18px;
    }
    .style3
    {
        height: 18px;
    }
    .style4
    {
        width: 2%;
        height: 18px;
    }
    .style5
    {
        width: 23%;
        height: 18px;
    }
    .style6
    {
        width: 10%;
        height: 18px;
    }
    .style7
    {
        width: 10px;
        height: 18px;
    }
</style>

<script type="text/javascript" language="javascript">
    function AddTHEAD() {
        var table = document.getElementById('<%=tblGBillPrint.ClientID %>');
        if (table != null) {
            var head = document.createElement("THEAD");
            head.style.display = "table-header-group";
            head.appendChild(table.rows[0]);
            table.insertBefore(head, table.childNodes[0]);
            
            var errortr = document.getElementById('maintable');
            var errortr1 = errortr.rows[1];
            errortr1.setAttribute("style", "display:none");
        }
    }
  
    window.onload = AddTHEAD;

</script>

<script runat="server">
    string _date;
    string GetDate(string Date)
    {
        string[] tempdate = Date.Split(' ');
        string[] tempdate1 = tempdate[0].Split('/');
        if (tempdate1[2] == "1900")
        {
                _date = " ";
        }
        else
        {
            _date = Date;
        }
        //if (Date != "01/Jan/1900")
        //{
        //    if (Date != "01/Jan/1900 12:00:AM")
        //    {
        //        _date = Date;
        //    }
        //    else
        //    {
        //        _date = " ";
        //    }
        //}
        //else
        //{
        //    _date = " ";
        //}
        return _date;
    }
</script>

<table width="100%" align="center" id="tblGBillPrint" style="font-family: Arial; font-weight:normal;
    font-size: 11px;" runat="server">
    <%--<tr>
        <td align="center">
            Home
        </td>
    </tr>--%>
    <tr id="tbprint" runat="server">
        <td>
            <table width="100%" id="tblHead" runat="server" border="0" cellspacing="0" cellpadding="0"
                align="center"  style="font-family: Arial;font-size:16px;">
               
                <tr>
                     <%--<td width="20px"></td>--%>
                     <td align="right"  width="200px">
                        <asp:Image ID="imgBillLogo" runat="server" Visible="False" meta:resourcekey="imgBillLogoResource2" />
                    </td>
                    <td align="left" valign="top" width="10px">
                        &nbsp;
                    </td>

                    <td valign="top" style="border: 1px solid grey ;" height="80px;">
                    <table width="100%" cellpadding="3" cellspacing="1">
                    <tr>
                    <td>
                     <label style="font-family: Arial;font-size: 18px;" id="lblHospitalName" runat="server">
                        </label><br />
                        <asp:Label ID="Label8" Text="State Name : " runat="server" Style="font-family: Arial; font-size: 16px;" />
                        <asp:Label ID="Label9" Text="Haryana, Code:06" runat="server"   Style=" font-size:font-family: Arial; font-size: 16px;"/><br />
                        <asp:Label ID="Label10" Text="GSTIN/UIN :" runat="server"  Style="font-family: Arial; font-size: 16px;"/>
                        <asp:Label ID="Label11" Text="06AAQFG1401P1Z8" runat="server"  Style=" font-size:font-family: Arial;  font-size:16px;"/><br />
                        <asp:Label ID="Label12" Text="Mob# 8800023600 " runat="server"  Style="font-family: Arial; font-size: 16px;"/>
                        <asp:Label ID="Label13" Text=" E-Mail: contact@genes2me.com" runat="server"  Style="font-family: Arial; font-size: 14px;"/><br />
                    </td>
                    </tr>
                    </table>
	                   
                    </td>
                   
                </tr>
                <tr>
                    <td colspan="4" align="center"  >
                       <hr noshade="noshade"/> 
                    </td>
                    
                </tr>
                <tr>
                <td colspan="4" align="center">

                <asp:Label ID="lblHeader" runat="server" style="font-weight:bold;" meta:resourcekey="LabelResource1"></asp:Label>

                </td>
                </tr>
                <tr>
                <td colspan="5">
                &nbsp;
                </td>
                </tr>
                <tr>
                    <td id="tblPatientDetails" runat="server" colspan="6">
                        <table width="100%" border="0" cellspacing="0" cellpadding="0">
                            <tr style="display:none;">
                                <td colspan="10" id="tdDupBill" runat="server" align="center" style="display:none;">
                                    <asp:Label ID="lblTypeBill" Style="font-weight: bold;" runat="server" 
                                        meta:resourcekey="lblTypeBillResource1"></asp:Label>
                                    <asp:Label ID="lblDupBill" Style="font-weight: bold;" Text="(Duplicate Copy)" Visible="False"
                                        runat="server" meta:resourcekey="lblDupBillResource1"></asp:Label>
                                </td>
                            </tr>
                            <tr style="display:none;">
                                <td colspan="10" id="tdBarcode" runat="server" visible="false" align="right" valign="top">
                                    <asp:Image ID="imgBarcode" runat="server" Style="display: none" 
                                        meta:resourcekey="imgBarcodeResource1" />
                                </td>
                            </tr>
                            <tr>
                               
                                <td style="width: 2%">
                                </td>                                
                                 <td align="left" nowrap="nowrap">
                                    <asp:Label ID="Rs_PatientName" Text="Patient Name" runat="server" meta:resourcekey="Rs_PatientNameResource2" />
                                </td>
                                <td align="center" nowrap="nowrap" style="width: 5%">
                                    &nbsp;:
                                </td>
                                <td align="left" nowrap="nowrap" style="width: 25%">
                                    <span style="width: 25%">
                                        <asp:Label ID="lblTitleName" runat="server" Style="font-weight: 700" 
                                        meta:resourcekey="lblTitleNameResource1"></asp:Label>
                                        <asp:Label ID="lblName" runat="server" meta:resourcekey="lblNameResource2" Style="font-weight: 700"></asp:Label>
                                    </span>
                                </td>                                
                                <%--<td align="left" nowrap="nowrap" style="width: 3%;" class="style8">
                                    <asp:Label runat="server" Visible="False" ID="lblPhy1" 
                                        Text="Ref. Physician Name" meta:resourcekey="lblPhy1Resource1"></asp:Label>
                                </td>
                                <td id="tdPhysician"  runat="server" align="left" nowrap="nowrap" style="width: 3%">
                                   
                                </td>--%>
                               <%-- <td align="left" nowrap="nowrap" style="width: 13%;">
                                    <asp:Label ID="lblPhysician1" Visible="False" runat="server" 
                                        Style="font-weight: 700;display:none;" meta:resourcekey="lblPhysicianResource2"></asp:Label>
                                </td>--%>
                                <%--<td align="left" nowrap="nowrap" style="width: 10%;">
                                    <asp:Label ID="Rs_BillDate" Text="Bill Date" runat="server" meta:resourcekey="Rs_BillDateResource2" />
                                </td>
                                <td align="left" nowrap="nowrap" style="width: 2%;">
                                    &nbsp;:&nbsp;
                                </td>
                                <td align="left" style="width: 10%;">
                                    <asp:Label ID="lblInvoiceDate" runat="server" Style="font-weight: 700" meta:resourcekey="lblInvoiceDateResource2"></asp:Label>
                                </td>--%>
                                <td align="left" nowrap="nowrap" class="style6">
                                    <asp:Label ID="Rs_PatientNo" Text="Patient No" runat="server" meta:resourcekey="Rs_PatientNoResource1" />
                                </td>                               
                                <td align="center" nowrap="nowrap" style="width: 5%">
                                    &nbsp;:
                                </td>
                                <td align="left" class="style9" style="width:25%">
                                    <span style="width: 23%">
                                        <asp:Label ID="lblPatientNumber" runat="server" Style="font-weight: 700;" meta:resourcekey="lblPatientNumberResource2"></asp:Label>
                                    </span>
                                </td>       
                            </tr>
                             <tr>
                                <td align="left" nowrap="nowrap" style="width: 2%" colspan="3">
                                    &nbsp;
                                </td>
                            </tr>
                              <tr>
                                <td style="width: 2%">
                                </td>
                                <td align="left" nowrap="nowrap">
                                    <asp:Label ID="PatientAge" Text="Age" runat="server" meta:resourcekey="PatientAgeResource2" />
                                    /<asp:Label ID="Rs_sex" Text="Sex" runat="server" meta:resourcekey="Rs_sexResource1" />
                                </td>
                                <td align="center" nowrap="nowrap" class="style1" style="width: 5%">
                                    &nbsp;:&nbsp;
                                </td>
                                <td align="left" nowrap="nowrap" style="width: 25%">
                                    <asp:Label ID="lblAge" runat="server" Style="font-weight: 700" meta:resourcekey="lblAgeResource2"></asp:Label>
                                    /<asp:Label ID="lblSex" runat="server" Style="font-weight: 700" meta:resourcekey="lblSexResource2"></asp:Label>
                                </td>
                                <%--<td align="left" nowrap="nowrap" style="width: 3%;" class="style8">
                                    <asp:Label ID="lblModedelivirey1" Visible="False" runat="server" 
                                        Text="Mode of Delivery" meta:resourcekey="lblModedelivirey1Resource1"></asp:Label>
                                </td>
                                <td align="left"  nowrap="nowrap" class="style1">
                                    
                                </td>--%>
                              <%--  <td align="left" style="width: 13%;" nowrap="nowrap">
                                    <asp:Label ID="lblModetype1" Visible="False" runat="server" 
                                        Style="font-weight: 700" meta:resourcekey="lblModetype1Resource1"></asp:Label>
                                </td>--%>
                                <td align="left" style="width: 10%">
                                    <asp:Label ID="lblmail" runat="server" Text="Email" 
                                        meta:resourcekey="lblmailResource1"></asp:Label>
                                </td>

                               <td align="center" nowrap="nowrap" style="width: 2%">

                                     &nbsp;:&nbsp;

                                </td>
                                <td align="left" style="width: 10%">
                                    <asp:Label ID="lblEmail" runat="server" 
                                        Style="font-weight: 700; text-wrap:normal" meta:resourcekey="lblEmailResource1"></asp:Label>
                                </td>                               
                            </tr>
                            
                            <tr>
                                <td align="left" nowrap="nowrap" style="width: 2%" colspan="2">
                                    &nbsp;
                                </td>
                            </tr>
                              <tr id="Tr1" visible="true" runat="server">
                                <td  style="width: 5%">
                                    &nbsp;
                                </td>
                                  <td align="left" nowrap="nowrap" style="width: 10%">
                                    <asp:Label ID="Rs_PatPhoneNo" Text="Cantact No" runat="server" 
                                        meta:resourcekey="Rs_PatPhoneNoResource1" />
                                </td>
                                <td align="center" nowrap="nowrap" style="width: 2%">

                                   &nbsp;:&nbsp;
                                </td>
                                <td align="left" style="width: 25%">
                                    <asp:Label ID="lblPatPhoneNumber" runat="server" Style="font-weight: 700" 
                                        meta:resourcekey="lblPatPhoneNumberResource1"></asp:Label>
                                </td>                            
                                <%--<td align="left" nowrap="nowrap" style="width: 3%;" id="trLabNo" runat="server" visible="false" 
                                    class="style8">
                                    <asp:Label ID="lblprior" Visible="False" runat="server" Text="Priority" 
                                        meta:resourcekey="lblpriorResource1"></asp:Label>
                                </td>
                                <td align="left"  nowrap="nowrap" id="trLabNo1" runat="server" visible="false">
                                    
                                </td>--%>
                               <td align="left" nowrap="nowrap" style="width: 13%;display:none;" id="trLabNo2" runat="server"
                                    visible="false">
                                    <asp:Label ID="lblpriority" Visible="False" runat="server" 
                                        Style="font-weight: 700" meta:resourcekey="lblpriorityResource1"></asp:Label>
                                </td>
                                                               
                                 <td align="left" nowrap="nowrap">
                                    <asp:Label ID="lLabNo" Visible="False"  runat="server" Text="LabNo" 
                                        meta:resourcekey="lLabNoResource1" />
                                    <asp:Label ID="Rs_VisitNumber" runat="server" Text="/Visit No." Visible="False" 
                                        meta:resourcekey="Rs_VisitNumberResource1" />
                                </td>                               
                                <td align="center" nowrap="nowrap" class="style1" style="width: 2%">
                                    &nbsp;:&nbsp;
                                </td> 
                                <td align="left" nowrap="nowrap">
                                    <asp:Label ID="lblLabNo" runat="server" Style="font-weight: 700" 
                                        meta:resourcekey="lblLabNoResource1"></asp:Label>
                                    <asp:Label ID="lblVisitNumber" runat="server" Style="font-weight: 700" 
                                        Visible="False" meta:resourcekey="lblVisitNumberResource1"></asp:Label>
                                </td> 
                            </tr>
                            <tr>
                                <td align="left" nowrap="nowrap" style="width: 4%">
                                    &nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 2%">
                                    &nbsp;
                                </td> 
                                <%--<td align="left" nowrap="nowrap" class="style6">
                                    <asp:Label ID="Rs_PatientNo" Text="Patient No" runat="server" meta:resourcekey="Rs_PatientNoResource1" />
                                </td>                               
                                <td align="left" nowrap="nowrap" class="style4">
                                    &nbsp;:
                                </td>
                                <td align="left" class="style9">
                                    <span style="width: 23%">
                                        <asp:Label ID="lblPatientNumber" runat="server" Style="font-weight: 700;" meta:resourcekey="lblPatientNumberResource2"></asp:Label>
                                    </span>
                                </td>       --%>  
                                <td align="left" nowrap="nowrap" style="width: 10%">
                                    <asp:Label ID="Rs_BillNo" Text="Invoice No" runat="server" meta:resourcekey="Rs_BillNoResource2" />
                                </td>
                                <td align="center" nowrap="nowrap" style="width: 5%">
                                    &nbsp;:&nbsp;
                                </td>
                                <td align="left" nowrap="nowrap" style="width: 25%">
                                    <asp:Label ID="lblInvoiceNo" runat="server" Style="font-weight: 700" meta:resourcekey="lblInvoiceNoResource2"></asp:Label>
                                </td>                       
                                <%--<td align="left" nowrap="nowrap" style="width: 3%;" class="style6">
                                    <asp:Label ID="lblRefHos" Visible="False" Text="Referring Hos" runat="server" 
                                        meta:resourcekey="lblRefHosResource1" />
                                </td>
                                <td id="tdReferringHos"  runat="server" align="left" nowrap="nowrap" 
                                    class="style3">
                                    
                                </td>--%>
                               <td align="left" nowrap="nowrap" style="width: 13%;display:none;" class="style10">
                                    <asp:Label ID="lblReferringHos" Visible="False" runat="server" 
                                        Style="font-weight: 700" meta:resourcekey="lblReferringHosResource1"></asp:Label>
                                </td>
                                <%--<td align="right" nowrap="nowrap">
                                    Patient No
                                </td>
                                <td align="left" nowrap="nowrap">
                                    &nbsp;:&nbsp;
                                </td>
                                <td align="left" nowrap="nowrap">
                                    <span style="width: 23%">
                                        <asp:Label ID="lblPatientNumber" runat="server" Style="font-weight: 700"></asp:Label>
                                    </span>
                                </td>--%>
                                <td align="left" nowrap="nowrap" style="width: 10%;">
                                    <asp:Label ID="Rs_BillDate" Text="Invoice Date" runat="server" meta:resourcekey="Rs_BillDateResource2" />
                                </td>
                                <td align="center" nowrap="nowrap" style="width: 2%;">
                                    &nbsp;:&nbsp;
                                </td>
                                <td align="left" style="width: 20%;">
                                    <asp:Label ID="lblInvoiceDate" runat="server" Style="font-weight: 700" meta:resourcekey="lblInvoiceDateResource2"></asp:Label>
                                </td>
                               
                            </tr>
                            <tr>
                                <td align="left" nowrap="nowrap" style="width: 4%">
                                    &nbsp;
                                </td>
                            </tr>
                            
                              <tr >
                                <td style="width: 4%">
                                    &nbsp;
                                </td>
                               <td align="left" nowrap="nowrap" style="width: 10%">
                                    <asp:Label ID="lblRefHospital" runat="server" Text="Ref Hospital" 
                                        meta:resourcekey="lblModedelivireyResource1"></asp:Label>
                                </td>

                               <td align="center" nowrap="nowrap" style="width: 5%">

                                     &nbsp;:&nbsp;

                                </td>
                                <td align="left" style="width: 25%;" >
                                    <asp:Label ID="lblRefHospital1" runat="server" Style="font-weight: 700" 
                                        meta:resourcekey="lblModetypeResource1"></asp:Label>
                                </td>
                                <%--<td align="left" nowrap="nowrap" style="width: 3%;" class="style8">
                                    <asp:Label ID="lblHistory1" Visible="False" runat="server" 
                                        Text="Patient History" meta:resourcekey="lblHistory1Resource1"></asp:Label>
                                </td>
                                <td align="left" nowrap="nowrap" class="style1">
                                    
                                </td>--%>
                              <%--  <td align="left" style="width: 13%;" nowrap="nowrap">
                                    <asp:Label ID="lblpatientHistory1" Visible="False" runat="server" 
                                        Style="font-weight: 700" meta:resourcekey="lblpatientHistory1Resource1"></asp:Label>
                                </td>--%>
                              <%--  <td align="left" nowrap="nowrap" style="width: 10%">
                                    <asp:Label ID="lblModedelivirey" runat="server" Text="Mode of Delivery" 
                                        meta:resourcekey="lblModedelivireyResource1"></asp:Label>
                                </td>

                               <td align="left" nowrap="nowrap" style="width: 2%">

                                     <asp:Label ID="lblModedelivirey2" Text="&nbsp;:&nbsp;" runat="server" 

                                        />

                                </td>
                                <td align="left" style="width: 10%;" >
                                    <asp:Label ID="lblModetype" runat="server" Style="font-weight: 700" 
                                        meta:resourcekey="lblModetypeResource1"></asp:Label>
                                </td>--%>
                                 <td align="left" nowrap="nowrap" style="width: 10%">
                                    <asp:Label runat="server" ID="lblPhy" Text="Ref Doctor" 
                                        meta:resourcekey="lblPhyResource1"></asp:Label>
                                </td>
                                <td align="center" nowrap="nowrap" class="style1" style="width: 2%">
                                    &nbsp;: &nbsp;
                                </td>                                
                                <td align="left" nowrap="nowrap" width="8%">
                                    <asp:Label ID="lblPhysician" runat="server" Style="font-weight: 700" meta:resourcekey="lblPhysicianResource2"></asp:Label>
                                </td>
                            </tr>
                          
                            <tr>
                                <td align="left" nowrap="nowrap" style="width: 4%">
                                    &nbsp;
                                </td>
                            </tr>
                            
                            
                          
                            <tr >
                                 <td colspan="8">
                                 <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                 <tr>
                                 <td style="width:0px;"></td>
                                 <td align="left" nowrap="nowrap" colspan="7" style="border : 1px solid grey"  >
                                    <table width="100%" border="0" cellspacing="1px" cellpadding="1px">
                                    <tr>                                    
                                    
                                        <td align="left" nowrap="nowrap" style="width: 40%">
                                        <asp:Label ID="lblPatientAdd" runat="server" Text="Patient Address : " style="margin-left:3px;"></asp:Label>
                                                                   
                                        </td>
                                        <td rowspan="4" style="border-left: 1px solid grey; width:1% "> </div></td>
                                        <td>
                                    
                                        <asp:Label ID="lblClientAdd" runat="server" Text="Client Name : " ></asp:Label>
                                        <asp:Label ID="lblCliName" runat="server" Text="" style="font-weight: 700"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="left" nowrap="nowrap" style="width: 4%">
                                        &nbsp;
                                        </td>
                                    </tr>
                                    <tr>                                    
                                    
                                        <td align="left" nowrap="nowrap" style="width: 40%">
                                        <asp:Label ID="lblPtAddress" runat="server" Text=" " style="margin-left:3px;"></asp:Label><br />
                                        <asp:Label ID="lblPStName" runat="server" Text="STATE NAME : " style="margin-left:3px;"></asp:Label>
                                        <asp:Label ID="lblPStateName" runat="server" Text=""></asp:Label>&nbsp;
                                        <asp:Label ID="lblPGSTSCODE" runat="server" Text=""></asp:Label> <br />
                                        <asp:Label ID="lblPGSTIN" runat="server" Text="GSTIN : " style="margin-left:3px;"></asp:Label>
                                        <asp:Label ID="lblPGSTIN1" runat="server" Text=""></asp:Label>
                                                                   
                                        </td>
                                        <%--<td rowspan="2"><div style=" border-left: 6px solid green;"></div></td>--%>
                                        <td align="left" nowrap="nowrap" style="width: 40%">
                                    
                                        <asp:Label ID="lblClientAddress" runat="server" Text=" " ></asp:Label><br />
                                        <asp:Label ID="lblCStName" runat="server" Text="STATE NAME : "></asp:Label>
                                        <asp:Label ID="lblCStateName" runat="server" Text=""></asp:Label>&nbsp;
                                        <asp:Label ID="lblCGSTSCODE" runat="server" Text=""></asp:Label> <br />
                                        <asp:Label ID="lblCGSTIN" runat="server" Text="GSTIN/UIN : "></asp:Label>
                                        <asp:Label ID="lblCGSTIN1" runat="server" Text=""></asp:Label><br />
                                        <asp:Label ID="lblPan" runat="server" Text="PAN/IT No : "></asp:Label>
                                        <asp:Label ID="lblCPan" runat="server" Text=""></asp:Label>
                                        </td>
                                    </tr>
                                    </table>
                                </td>
                                <td width="5px;"></td>
                                 </tr>
                                 </table>
                                 </td>
                               
                            </tr>
                            
                            
                                                   
                            <tr >
                                <td align="left" nowrap="nowrap" style="width: 4%">
                                    &nbsp;
                                </td>
                            </tr>
                            <tr id="phyDetails" runat="server" style="display:none;">
                                <td class="style2">
                                </td>
                                <td align="left" nowrap="nowrap" class="style6">
                                    <asp:Label ID="lblHistory" runat="server" Text="Patient History" 
                                        meta:resourcekey="lblHistoryResource1"></asp:Label>
                                </td>

                                <td align="left" nowrap="nowrap" style="width: 2%">

                                     <asp:Label ID="lblHistory2" Text="&nbsp;:&nbsp;" runat="server" 

                                        />

                                </td>
                                <td align="left" class="style11">
                                    <asp:Label ID="lblpatientHistory" runat="server" Style="font-weight: 700" 
                                        meta:resourcekey="lblpatientHistoryResource1"></asp:Label>
                                </td>
                                <td align="left" nowrap="nowrap" class="style6">
                                </td>
                                <td align="left" nowrap="nowrap" class="style7">
                                    &nbsp;&nbsp;
                                </td>
                                <td align="left" nowrap="nowrap" class="style3">
                                </td>
                                <td align="left" nowrap="nowrap" class="style6">
                                    <asp:Label ID="lblDeliver"  runat="server" 
                                        Text="HealthCouponNo" meta:resourcekey="lblDeliverResource1"></asp:Label>
                                </td>
                                 <td align="left" nowrap="nowrap" style="width: 2%">

                                    <asp:Label ID="lblDeliver1"  runat="server" 

                                        Text=":"></asp:Label>

                                </td>
                                <td align="left" nowrap="nowrap" style="width: 10%;">
                                    <asp:Label ID="lbldeliverydate"  runat="server" 
                                        Style="font-weight: 700" meta:resourcekey="lbldeliverydateResource1"></asp:Label>
                                    &nbsp;&nbsp;
                                </td>
                            </tr>
                            <tr style="display:none;">
                                <td align="left" nowrap="nowrap" style="width: 4%">
                                    &nbsp;
                                </td>
                            </tr >
                              <tr id="Tr2" runat="server" visible="false" >
                              <td class="style2">
                                </td>
                                <td align="left" nowrap="nowrap" class="style6">
                                    <asp:Label ID="lblpatientaddress" runat="server" Text="Patient Address"></asp:Label>
                                </td>

                                <td align="left" nowrap="nowrap" style="width: 2%">

                                     <asp:Label ID="Label3" Text="&nbsp;:&nbsp;" runat="server" 

                                        />

                                </td>
                                <td align="left" class="style11">
                                    <asp:Label ID="lblpatientaddress2" runat="server" Style="font-weight: 700" ></asp:Label>
                                </td>
                                <td align="left" nowrap="nowrap" class="style6">
                                </td>
                                <td align="left" nowrap="nowrap" class="style7">
                                    &nbsp;&nbsp;
                                </td>
                                <td align="left" nowrap="nowrap" class="style3">
                                </td>
                                <td align="left" nowrap="nowrap" class="style6">
                                   <%-- <asp:Label ID="Label7"  runat="server" 
                                        Text="HealthCouponNo" meta:resourcekey="lblDeliverResource1"></asp:Label>--%>
                                </td>
                                 <td align="left" nowrap="nowrap" style="width: 2%">

                                    <%--<asp:Label ID="Label8"  runat="server" ></asp:Label>--%>
                                </td>
                                <td align="left" nowrap="nowrap" style="width: 10%;">
                                    <%--<asp:Label ID="Label9"  runat="server" 
                                        Style="font-weight: 700" meta:resourcekey="lbldeliverydateResource1"></asp:Label>--%>
                                    &nbsp;&nbsp;
                                </td>
                              
                              </tr> 
                                
                            <tr style="display:none;">
                                <td align="left" nowrap="nowrap" style="width: 4%">
                                    &nbsp;
                                </td>
                            </tr>
                            <tr id="trFinalBillHeader" runat="server" style="display: none;">
                                <td colspan="6" align="center">
                                    <uc3:FinalBillHeader ID="FinalBillHeader1" runat="server" />
                                </td>
                            </tr>
                            
                            <%-- <tr>
                            <td colspan="8">
                                 <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                 <tr>
                                 <td style="width:20px;"></td>
                                 <table>
                                 
                                 </table>
                                 <td width="5px;"></td>
                                 </tr>
                                 </table>
                                 </td>
                            </tr>--%>
                            
                            
                        </table>
                    </td>
                    <%--<td id="tdBarcode" runat="server" visible="false" width="5%">
                      
                    </td>--%>
                </tr>
                <%--<tr>
                    <td colspan="6" style="text-decoration: Underline;">
                        Billing Details
                    </td>
                </tr>--%>
                <tr>
               <%-- <td>&nbsp;</td>--%>
                    <td colspan="4">
                        <asp:GridView ID="gvBillingDetail" runat="server" Width="100%" AutoGenerateColumns="False"
                            BorderStyle="Solid" BorderColor="#B6A8A8" CssClass="w-100p gridView gridView1" BorderWidth="1px" OnRowDataBound="gvBillingDetail_RowDataBound"
                            meta:resourcekey="gvBillingDetailResource2" ShowFooter="true">
                            <Columns>
                                <asp:TemplateField HeaderText="S.No" ItemStyle-Width="4%" 
                                    meta:resourcekey="TemplateFieldResource1">
                                    <ItemTemplate>
                                        <%# Container.DataItemIndex + 1 %>
                                    </ItemTemplate>

                                        <ItemStyle Width="4%"></ItemStyle>
                                </asp:TemplateField>
                                
                                <asp:TemplateField HeaderText="Test Name" meta:resourcekey="TemplateFieldResource2" >
                                    <ItemTemplate>
                                        <asp:Label ID="lblDescription" Text='<%# Bind("FeeDescription") %>' runat="server"
                                            meta:resourcekey="lblDescriptionResource2" CssClass="AlgRgh"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                
                                <asp:BoundField ItemStyle-Width="15%" DataField="ServiceCode" HeaderText="ServiceCode"
                                    meta:resourcekey="BoundFieldResource4" Visible="false">
                                    <ItemStyle Width="15%"></ItemStyle>
                                </asp:BoundField>
                                   
                                <asp:BoundField ItemStyle-Width="8%" DataFormatString="{0:N0}" ItemStyle-HorizontalAlign="Center"
                                    HeaderText="Units" DataField="Quantity" meta:resourcekey="BoundFieldResource5"
                                    Visible="false">
                                    <HeaderStyle HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Right" VerticalAlign="Middle" />
                                </asp:BoundField>
                                
                                
                                <asp:TemplateField HeaderText="Report Date" ItemStyle-Width="18%" 
                                    meta:resourcekey="TemplateFieldResource3" Visible=false>
                                    <ItemTemplate>
                                        <%# GetDate(DataBinder.Eval(Container.DataItem, "ModifiedAt", "{0:dd/MM/yyyy hh:mm:tt}").ToString())%>
                                    </ItemTemplate>

<ItemStyle Width="18%"></ItemStyle>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="MRPAmount" Visible="false"  ItemStyle-Width="15%"  >
                                    <ItemTemplate  >
                                        <asp:Label ID="lblMRPAmount" Text='<%# Bind("BaseTestcalculationAmount") %>' runat="server"  ></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle Width="15%" HorizontalAlign="Right"></ItemStyle>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Discount"  Visible="false"  ItemStyle-Width="13%"    >
                                    <ItemTemplate>
                                        <asp:Label ID="lblMRPDiscount" runat="server" Text='<%#Convert.ToInt32(Eval("BaseTestcalculationAmount")) -Convert.ToInt32(Eval("Amount")) %>'></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle Width="13%" HorizontalAlign="Right"></ItemStyle>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="HSN/SAC" meta:resourcekey="TemplateFieldResource2">
                                    <ItemTemplate>
                                        <asp:Label ID="lblhsn" Text='' runat="server"
                                            meta:resourcekey="lblDescriptionResource2" Visible="true"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                 <asp:TemplateField HeaderText="Quantity" meta:resourcekey="TemplateFieldResource2">
                                    <ItemTemplate>
                                        <asp:Label ID="lblqty" Text="1.00 Nos" runat="server"
                                            meta:resourcekey="lblDescriptionResource2" Visible="true"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField ItemStyle-Width="12%" DataField="Amount" HeaderText="MRP" DataFormatString="{0:F2}"
                                    ItemStyle-HorizontalAlign="Center" meta:resourcekey="BoundFieldResource6">
                                    <HeaderStyle HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Right" VerticalAlign="Middle"></ItemStyle>
                                </asp:BoundField>
                                <asp:BoundField ItemStyle-Width="12%" DataField="DiscountAmount" HeaderText="Discount" DataFormatString="{0:F2}"
                                    ItemStyle-HorizontalAlign="Center"  >
                                    <HeaderStyle HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Right" VerticalAlign="Middle"></ItemStyle>
                                </asp:BoundField>
                                <asp:BoundField ItemStyle-Width="12%" DataField="NetValue" HeaderText="Total Price" DataFormatString="{0:F2}"
                                    ItemStyle-HorizontalAlign="Center" >
                                    <HeaderStyle HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Right" VerticalAlign="Middle"></ItemStyle>
                                </asp:BoundField>
                              
                            </Columns>
                            <HeaderStyle Font-Bold="True" ForeColor="Black" />
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                <%--<td> &nbsp;</td>--%>
                    <td colspan="6">
                        <table width="100%" border="0" cellpadding="1" cellspacing="0">
                            <tr>
                            <td colspan="2" style="border:1px solid grey;border-top:none;border-bottom:none;">
                             <asp:Label ID="lblPayingCurrency2" runat="server" Style=" " text="Amount Chargeble: (in Words):"
                                        meta:resourcekey="lblPayingCurrencyResource2"></asp:Label>
                             <asp:Label ID="lblPayingCurrencyinWords" runat="server" Style="font-weight: 700;
                                        " meta:resourcekey="lblPayingCurrencyinWordsResource2"></asp:Label>
                            </td>
                            </tr>
                            <tr valign="top">
                                <td style="width: 30%;border:1px solid grey;border-right:none;">
                                    <table cellpadding="0" cellspacing="0" border="0" width="100%">
                                        <tr>
                                            <td style="padding-top: 5px;">
                                                <asp:Label Font-Bold="True" ID="lblPayment" Text="Payment Mode : " runat="server" meta:resourcekey="lblPaymentResource2"></asp:Label>
                                                <asp:Label runat="server" ID="lblPaymentMode" meta:resourcekey="lblPaymentModeResource2"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                
                                                <span id="lblPayMode" runat="server"></span>
                                            </td>
                                        </tr>
                                        <tr id="trDeposit" runat="server" style="display: table-row">
                                            <td>
                                                <asp:Label Visible="False" ID="lblDepositAmtUsed" runat="server" meta:resourcekey="lblDepositAmtUsedResource2"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Label runat="server" ID="lblOtherCurrency" meta:resourcekey="lblOtherCurrencyResource2"></asp:Label>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                                <td align="right" style="width: 70%;border:1px solid grey;border-left:none;">
 									<table>
                                        <tr align="right">
                                            <td>
                                    <table id="AmountDetails" runat="server" border="0" cellpadding="0" cellspacing="0"
										style="width: 100%; border-color: #000000">
                                        <tr style="display:none;">
                                            <td align="right" valign="Middle">
                                                <asp:Label ID="Rs_GrossAmount" Text="Gross Amount" runat="server" meta:resourcekey="Rs_GrossAmountResource2" />
                                                :
                                            </td>
                                            <td align="right" >
                                                <asp:Label ID="lblGrossAmount" runat="server" meta:resourcekey="lblGrossAmountResource2" />&nbsp;
                                            </td>
                                        </tr>
                                        <tr style="display: none;">
                                            <td align="right" valign="Middle">
                                                <asp:Label ID="Rs_DeductionAmount" Text="Deduction Amount" runat="server" meta:resourcekey="Rs_DeductionAmountResource2" />
                                                :
                                            </td>
                                            <td align="right">
                                                <asp:Label ID="lblDeduction" runat="server" meta:resourcekey="lblDeductionResource2"   />&nbsp;
                                            </td>
                                        </tr>
                                        <tr id="trServiceCharge" style="display: none;" runat="server">
                                            <td align="right" valign="middle">
                                                <asp:Label ID="Rs_ServiceCharge" Text="Service Charge" runat="server" meta:resourcekey="Rs_ServiceChargeResource2" />
                                                :
                                            </td>
                                            <td align="right" valign="middle">
                                                <asp:Label ID="lblServiceCharge" runat="server" meta:resourcekey="lblServiceChargeResource2" />&nbsp;
                                            </td>
                                        </tr>
                                        <tr id="trDiscount" style="display: none;" runat="server">
                                            <td align="right" valign="middle">
                                                <asp:Label ID="lblDiscountPercent" style="display: none;" runat="server" meta:resourcekey="lblDiscountPercentResource2" />&nbsp;
                                                <%--Discount (-) :--%>
                                                <%=Resources.CommonControls_ClientDisplay.CommonControls_AdvanceBillPrint_ascx_17 %>
                                            </td>
                                            <td align="right" valign="middle">
                                                <asp:Label ID="lblDiscount" runat="server" meta:resourcekey="lblDiscountResource2" />&nbsp;
                                            </td>
                                        </tr>
                                        <tr id="trTaxAmount" style="display: none;" runat="server">
                                            <td align="right" valign="middle">
                                                <asp:Label ID="lblTaxAmounttxt" Text="Tax Amount" runat="server" 
                                                    meta:resourcekey="lblTaxAmounttxtResource1" />
                                                :
                                            </td>
                                            <td align="right" valign="middle">
                                                <asp:Label ID="lblTaxAmount" runat="server" 
                                                    meta:resourcekey="lblTaxAmountResource1" />&nbsp;
                                            </td>
                                        </tr>
                                        <tr id="trEDCess" style="display: none;" runat="server">
                                            <td align="right" valign="middle">
                                                <asp:Label ID="Rs_EDCess" Text="ED Cess" runat="server" 
                                                    meta:resourcekey="Rs_EDCessResource1" />
                                                :
                                            </td>
                                            <td align="right" valign="middle">
                                                <asp:Label ID="lblEDCess" runat="server" 
                                                    meta:resourcekey="lblEDCessResource1" />&nbsp;
                                                <input type="hidden" id="hdnEDCess" runat="server" value="0" />
                                            </td>
                                        </tr>
                                        <tr id="trSHEDCess" style="display: none;" runat="server">
                                            <td align="right" valign="middle">
                                                <asp:Label ID="Rs_SHEDCess" Text="SHED Cess" runat="server" 
                                                    meta:resourcekey="Rs_SHEDCessResource1" />
                                                :
                                            </td>
                                            <td align="right" valign="middle">
                                                <asp:Label ID="lblSHEDCess" runat="server" 
                                                    meta:resourcekey="lblSHEDCessResource1" />&nbsp;
                                                <input id="hdnSHEDCess" type="hidden" runat="server" value="0" />
                                            </td>
                                        </tr>
                                        
                                        <tr id="trRoundoff" style="display: none;" runat="server">
                                            <td align="right" valign="middle">
                                                <asp:Label ID="Rs_RoundOffAmount" Text="Round Off Amount" runat="server" meta:resourcekey="Rs_RoundOffAmountResource2" />
                                                :
                                            </td>
                                            <td align="right" valign="middle">
                                                <asp:Label ID="lblRoundOff" runat="server" Text="0.00" meta:resourcekey="lblRoundOffResource2" />&nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="right" valign="Middle" colspan="2">
                                                <div id="dvTaxDetails" runat="server">
                                                </div>
                                            </td>
                                        </tr>
                                        <tr style="display:none;">
                                            <td align="right" valign="Middle" colspan="2">
                                                -----------------------------------
                                            </td>
                                        </tr>
                                        <tr style="display:none;">
                                            <td align="right" valign="Middle">
                                                <asp:Label ID="Rs_GrandTotal" Text="Grand Total" runat="server" meta:resourcekey="Rs_GrandTotalResource2" />
                                                :
                                            </td>
                                            <td align="right">
                                                <asp:Label ID="lblGrandTotal" runat="server" meta:resourcekey="lblGrandTotalResource2" />&nbsp;
                                            </td>
                                        </tr>
                                        <tr id="trPreviousDue" style="display: none" runat="server">
                                            <td align="right" valign="Middle">
                                                <asp:Label ID="Rs_PreviousDue" Text="Previous Due" runat="server" meta:resourcekey="Rs_PreviousDueResource2" />
                                                :
                                            </td>
                                            <td align="right">
                                                <asp:Label ID="lblPreviousDue" runat="server" meta:resourcekey="lblPreviousDueResource2"></asp:Label>&nbsp;
                                            </td>
                                        </tr>
                                        <tr style="display:none;">
                                            <td align="right" colspan="2" valign="Middle">
                                                -----------------------------------
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="right" valign="middle">
                                                <asp:Label ID="Rs_NetAmount" Text="Net Amount" runat="server" meta:resourcekey="Rs_NetAmountResource2" />
                                                :
                                            </td>
                                            <td align="right">
                                                <asp:Label ID="lblNetValue" runat="server" Style="font-weight: 700" meta:resourcekey="lblNetValueResource2"></asp:Label>&nbsp;
                                            </td>
                                        </tr>
                                        <tr >
                                            <td align="right" valign="middle" colspan="2">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr style="display:none;">
                                            <td align="right" valign="middle" colspan="2">
                                                -----------------------------------
                                            </td>
                                        </tr>
                                        <tr id="trAmountReceived" runat="server">
                                            <td align="right" valign="middle">
                                                <asp:Label ID="Rs_AmountReceived" Text="Amount Received" runat="server" meta:resourcekey="Rs_AmountReceivedResource2" />
                                                :
                                            </td>
                                            <td align="right">
                                                <asp:Label ID="lblAmountRecieved" runat="server" Style="font-weight: 700" meta:resourcekey="lblAmountRecievedResource2" />&nbsp;
                                            </td>
                                        </tr>
                                         <tr >
                                            <td align="right" valign="middle" colspan="2">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr id="trDue" runat="server" style="display: none">
                                            <td align="right" valign="middle">
                                                <asp:Label ID="lblCurrentVisitDueLabel" Text="Due" runat="server" meta:resourcekey="lblCurrentVisitDueLabelResource2"></asp:Label>
                                                &nbsp;:
                                            </td>
                                            <td align="right">
                                                <asp:Label ID="lblCurrentVisitDueText" runat="server" meta:resourcekey="lblCurrentVisitDueTextResource2" />&nbsp;
   </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr align="right">
                                            <td>
                                                <table id="CoPayAmount" runat="server" border="0" cellpadding="0" cellspacing="0"
                                                    style="border-color: #000000; text-align: right; width: 100%;">
                                                    <tr>
                                                        <td align="right" valign="middle">
                                                            <asp:Label ID="lblCoPayment" Text="Received Amount" runat="server" 
                                                                meta:resourcekey="lblCoPaymentResource1" />
                                                            :
                                                        </td>
                                                        <td align="right">
                                                            <asp:Label ID="lblCopayAmount" runat="server" 
                                                                meta:resourcekey="lblCopayAmountResource1" />&nbsp;
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td align="left" nowrap="nowrap" colspan="7" style="border : 1px solid grey" >
                                   
                                    
                                       <table width="100%" border="0" cellspacing="1px" cellpadding="1px">
                                       <tr>
                                       <td width="50%" style="border-right:1px solid grey;">
                                          <table >
                                          <tr>
                                          <td>
                                          <asp:Label ID="lbltaxamt" runat="server" Text="Tax Amount (in words): " ></asp:Label>
                                            <asp:Label ID="lbltaxamt2" runat="server" Text="NIL" ></asp:Label>
                                          </td>
                                          </tr>
                                          <tr>
                                          <td align="left" nowrap="nowrap" style="width: 4%">
                                            &nbsp;
                                            </td>
                                           </tr>
                                           <tr>
                                           <td>
                                           <asp:Label ID="lblcompanypan" runat="server" Text="Company's PAN : " ></asp:Label>
                                            <asp:Label ID="lblcompanypan2" runat="server" Text="AAQFG1401P" ></asp:Label>
                                           </td>
                                           </tr>
                                           <tr>
                                          <td align="left" nowrap="nowrap" style="width: 4%">
                                            
                                            </td>
                                           </tr>
                                           <tr>
                                           <td>
                                           <asp:Label ID="lblDeclaration" runat="server"  ></asp:Label>
                                           </td>
                                           </tr>
                                          </table>
                                       </td>
                                       
                                       <td width="50%" valign="top">
                                       
                                        <table width="100%">
                                        <tr>
                                        <td>
                                        <asp:Label ID="lblBankDetails1" runat="server" Text="Company's Bank Details " ></asp:Label>
                                        </td>
                                        </tr>
                                         <tr>
                                          <td align="left" nowrap="nowrap" style="width: 4%">
                                            &nbsp;
                                            </td>
                                           </tr>
                                        <tr>
                                        <td>
                                        <asp:Label ID="lblbankname" runat="server" Text="Bank Name : " ></asp:Label>
                                        <asp:Label ID="Label2" runat="server" Text="HDFC BANK A/c - 50200028524291" ></asp:Label>
                                        </td>
                                        </tr>
                                        <tr>
                                        <td>
                                        <asp:Label ID="lblaccno" runat="server" Text="A/c No : " ></asp:Label>
                                        <asp:Label ID="Label6" runat="server" Text="50200028524291" ></asp:Label>
                                        </td>
                                        </tr>
                                        <tr>
                                        <td>
                                        <asp:Label ID="lblbranch" runat="server" Text="Branch & IFS Code : " ></asp:Label>
                                        <asp:Label ID="Label7" runat="server" Text="SOUTH CITY II, Gurgaon & HDFC0001721" ></asp:Label>
                                        </td>
                                        </tr>
                                        <tr>
                                        <td align="left" nowrap="nowrap" style="width: 4%">
                                            &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                        <td style="border:1px solid grey;" height=50px;>
                                        <asp:Image ID="imgSign" runat="server" align=right width="30%" height="70%" meta:resourcekey="imgBillLogoResource2" />
                                        </td>
                                        </tr>
                                        </table>
                                       </td>
                                       </tr>
                                  
                                    </table>
                                    
                                    
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2" align="left">
                                    <asp:Label ID="lblrefundamt" runat="server" Visible="False" Style="font-weight: 700"
                                        meta:resourcekey="lblrefundamtResource2"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    &nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td colspan="5" align="center">
                                    This is a Computer Generated Invoice.
                                </td>
                            </tr>
                           <%-- <tr>
                                <td colspan="2">
                                    &nbsp;
                                </td>
                            </tr>--%>
                            <tr>
                                <td colspan="2">
                                    <asp:Image ID="footerLogo" runat="server" width="100%" height="50%" meta:resourcekey="imgBillLogoResource2" />
                                </td>
                            </tr>
                            <tr id="trReportDate" runat="server" style="display:none">
                                <td colspan="2" align="left">
                                    <asp:Label ID="lblReportcommitDate" runat="server" meta:resourcekey="lblReportcommitDateResource1"></asp:Label>
                                </td>
                            </tr>
                <tr id="trGstDetails" runat="server" style="display:none;">
                <td align="left" style="width: 70%">
                               <table id="GST" runat="server" border="0" cellpadding="0" cellspacing="0"
                                                    style="border-color: #000000">
                                                    <tr>
                                                        <td align="left" colspan="2" >
                                                            <asp:Label ID="lblGst" Text="GSTN" runat="server"  />
                                                            :
                                                          
                                                        
                                                              <asp:Label ID="lblGs" runat="server" Text="29AAACC8412H1ZQ" />&nbsp;
                                                        </td>
                                                    </tr>
                                                     <tr>
                                                        <td align="left" >
                                                            <asp:Label ID="Label4" Text="Service Account Code" runat="server"  />
                                                            :
                                                        </td>
                                                        <td align="left">
                                                            <asp:Label ID="Label5" runat="server" />&nbsp;
                                                        </td>
                                                    </tr>
                                                    </table>
                                </td>
                 </tr>
                            <tr id="TRAMTRcvd" runat="server" style="padding-top:10px;display:none;">
                                <td colspan="2" align="left">
                                    <asp:Label ID="lblDisplayAmount" runat="server" Style="font-weight: 700" meta:resourcekey="lblDisplayAmountResource2"></asp:Label>
                                    <asp:Label ID="lblAmount" runat="server" Style="font-weight: 700" meta:resourcekey="lblAmountResource2"></asp:Label>
                                </td>
                            </tr>
                            <tr id="trPayingCurrency" runat="server" style="display: none">
                                <td colspan="2" align="left">
                                    <asp:Label ID="lblPayingCurrency" runat="server" Style="font-weight: 700; display: none;"
                                        meta:resourcekey="lblPayingCurrencyResource2"></asp:Label>
                                    <asp:Label ID="lblPayingCurrencyinWords1" runat="server" Style="font-weight: 700;
                                        display: none;" meta:resourcekey="lblPayingCurrencyinWordsResource2"></asp:Label>
                                </td>
                            </tr>
                            <tr style="display:none">
                                <td align="left" id="TRDueAmt" runat="server" style="display: block">
                                    <asp:Label ID="lblDueAmountinWords" runat="server" Style="font-weight: 700" meta:resourcekey="lblDueAmountinWordsResource2"></asp:Label>
                                    <asp:Label ID="lblDueAmount" runat="server" Style="font-weight: 700" meta:resourcekey="lblDueAmountResource2"></asp:Label>
                                </td>
                                <td align="right" id="tdUserName"  runat="server" style="display: none">
                                    <asp:Label ID="lblUserName" Text="User Name:" runat="server" 
                                        meta:resourcekey="lblUserNameResource1" />
                                    <asp:Label ID="lblLoginName" runat="server" 
                                        meta:resourcekey="lblLoginNameResource1" />
                                </td>
                            </tr>
                            <tr style="display:none">
                                <td  align="left">
                                    <asp:Label ID="Label1" Visible="False" runat="server" Style="font-weight: 700" meta:resourcekey="Label1Resource2"></asp:Label>
                                    <asp:Label ID="RemainDeposit" Visible="False" runat="server" Style="font-weight: 700"
                                        meta:resourcekey="RemainDepositResource2"></asp:Label>
                                </td>
								 <td align="right">
                                   <asp:Label ID="lblPass" Text="Password:" runat="server" Visible="False" 
                                         meta:resourcekey="lblPassResource1"/>
                                    <asp:Label ID="lblPassword" runat="server" 
                                         meta:resourcekey="lblPasswordResource1" />
                                </td>
                            </tr>
                            <tr id="trTaxDetails" runat="server" style="display:none">
                                <td colspan="2" align="left">
                                    <asp:Label ID="lblTaxDetails" Visible="False" runat="server" 
                                        Style="font-weight: 700" meta:resourcekey="lblTaxDetailsResource1"></asp:Label>
                                </td>
                            </tr>
                            <tr style="display:none">
                                <td colspan="2" align="left">
                                    &nbsp;
  <asp:Label ID="lblURL" Visible="False" Text="To view Patient Report log on to" runat="server" 
                                        meta:resourcekey="lblURLResource1" /> 
                                   <asp:Label ID="lblLoginurl" runat="server" 
                                        meta:resourcekey="lblLoginurlResource1" /> 
                                </td>
                            </tr>
                            <tr id="trReportDate1" runat="server" style="display:none">
                                <td colspan="2" align="left">
                                    &nbsp;
                                </td>
                            </tr>
                            <tr id="trReportDate2" runat="server" visible="false">
                                <td colspan="2" align="left">
                                    <asp:Label ID="lblservicetax" runat="server" Style="font-weight: 700" 
                                        Text="Service Tax Registration Number:-AACCP1414ESD001" 
                                        meta:resourcekey="lblservicetaxResource1"></asp:Label>
                                </td>
                            </tr>
                            <tr id="trReportDate3" runat="server" visible="false">
                                <td colspan="2" align="left">
                                    <asp:Label ID="lblCategoryservice" runat="server" Style="font-weight: 700" 
                                        Text="Category Of Service :-Technical Testing &amp; Analysis/Cosmetic &amp; Plastic Surgery." 
                                        meta:resourcekey="lblCategoryserviceResource1"></asp:Label>
                                </td>
                            </tr>
                            <tr id="trReportDate4" runat="server">
                                <td colspan="2" align="left">
                                    &nbsp;
                                </td>
                            </tr>
                            <tr id="trReportDate5" runat="server">
                                <td colspan="2" align="right">
                                    <img id="imgView" runat="server" align="middle" alt="Digital Signature" style="height: 2%;
                                        width: 3%"></img>&nbsp;
                                </td>
                            </tr>
                            <tr style="display:none;">
                                <td colspan="2" align="right">
                                    <asp:Label ID="lblBilledBy" runat="server" meta:resourcekey="lblBilledByResource2" />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblNote" runat="server" meta:resourcekey="lblNoteResource1"></asp:Label>
        </td>
    </tr>
    <tr>
        <td width="100%" runat="server" style="display: none;" id="tdPrint" enableviewstate="false">
        </td>
    </tr>
    <tr>
    <td>
    
    <table><tr>
     <td>
        <asp:Label runat="server" Font-Bold="True" ID="lblRRHeading" Text="Registration Remarks : " meta:resourcekey="lblRRHeadingResource1"></asp:Label>
        </td>
        <td>
            <asp:Label runat="server" ID="lblRegistrationRemarks" ></asp:Label>
        </td>
        </td>
        </tr></table>
    </tr>
</table>
<asp:HiddenField ID="hdnPayingCurrency" runat="server" />
<asp:HiddenField ID="hdnDiscount" runat="server" />
<asp:HiddenField ID="hdnServiceCharge" runat="server" />
<asp:HiddenField ID="hdnTaxAmount" runat="server" />
<asp:HiddenField ID="hdnPreviousDue" runat="server" />
<asp:HiddenField ID="hdnDue" runat="server" />
<asp:HiddenField ID="hdnRoundoff" runat="server" />
<asp:HiddenField ID="hdnRound" runat="server" />
<asp:HiddenField ID="hdfRoundcalc" runat="server" Value="0" />
<asp:HiddenField ID="hdnRoundAmt" runat="server" />
<asp:HiddenField ID="hdnCleintFlag" runat="server" />
<input type="hidden" id="hdnIsRoundOff" value="ON" runat="server" />
<input type="hidden" id="hdncopayamount" runat="server" />

<script type="text/javascript" language="javascript">
    if (document.getElementById('<%=hdnPayingCurrency.ClientID %>').value == "1") {
        document.getElementById('<%=trPayingCurrency.ClientID %>').style.display = "table-row";
    }
    if (document.getElementById('<%=hdnDiscount.ClientID %>').value == "1") {
        document.getElementById('<%=trDiscount.ClientID %>').style.display = "table-row";
    }
    if (document.getElementById('<%=hdnServiceCharge.ClientID %>').value == "1") {
        document.getElementById('<%=trServiceCharge.ClientID %>').style.display = "table-row";
    }
    if (document.getElementById('<%=hdnTaxAmount.ClientID %>').value == "1") {
        document.getElementById('<%=trTaxAmount.ClientID %>').style.display = "table-row";
    }
    if (document.getElementById('<%=hdnCleintFlag.ClientID %>').value != "Y") {
        if (document.getElementById('<%=hdnDue.ClientID %>').value == "1") {
            document.getElementById('<%=trDue.ClientID %>').style.display = "table-row";
        }
    }
    if (document.getElementById('<%=hdnPreviousDue.ClientID %>').value == "1") {
        document.getElementById('<%=trPreviousDue.ClientID %>').style.display = "none";
    }
    if (document.getElementById('<%=hdnRoundoff.ClientID %>').value == "1") {
        document.getElementById('<%=trRoundoff.ClientID %>').style.display = "table-row";
    }
    if (document.getElementById('<%=hdnEDCess.ClientID %>').value == "1") {
        document.getElementById('<%=trEDCess.ClientID %>').style.display = "table-row";
    }
    if (document.getElementById('<%=hdnSHEDCess.ClientID %>').value == "1") {
        document.getElementById('<%=trSHEDCess.ClientID %>').style.display = "table-row";
    }
     
</script>

<uc1:ErrorDisplay ID="ErrorDisplay1" runat="server" />