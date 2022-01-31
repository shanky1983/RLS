<%@ Page Language="C#" AutoEventWireup="true" CodeFile="POSBillSettlement.aspx.cs" Inherits="Admin_POSBillSettlement" meta:resourcekey="PageResource1" %>

<%@ Register Src="../CommonControls/Attune_OrgHeader.ascx" TagName="Attuneheader" TagPrefix="Attune" %>
<%@ Register Src="../CommonControls/Attune_Footer.ascx" TagName="Attunefooter" TagPrefix="Attune" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
    <title>
<%=Resources.Admin_ClientDisplay.Admin_BillSettlement_aspx_01 %> </title>
    <link href="../StyleSheets/DHEBAdder.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="../Scripts/AutoComplete.js" language="javascript"></script>

    <script type="text/javascript" src="../Scripts/DHEBAdder.js"></script>

    <script src="../Scripts/jquery-1.2.2.pack.js" type="text/javascript"></script>


    <style type="text/css">
        .stylenone
        {
            display: none;
        }
      
    </style>

    <script type="text/javascript">

        function ValidateDate1(sender, args) {
            if (sender._selectedDate < new Date()) {
                alert("You cannot select a day earlier than today!");
                sender._selectedDate = new Date();
                // set the date back to the current date
                sender._textbox.set_Value(sender._selectedDate.format(sender._format))
            }
        }
    </script>

</head>
<body>
    <form id="frmPatientVitals" runat="server">
    <asp:ScriptManager ID="ctlTaskScriptMgr" runat="server">
    </asp:ScriptManager>
  
      <Attune:Attuneheader ID="Attuneheader" runat="server" />
                    <div class="contentdata">
                    <asp:UpdatePanel ID="UpdatePanel102" runat="server" UpdateMode="Conditional">
            
            <ContentTemplate>
                <asp:UpdateProgress ID="Progressbar1" AssociatedUpdatePanelID="UpdatePanel102" runat="server">
                    <ProgressTemplate>
                        <div id="progressBackgroundFilter" class="a-center">
                        </div>
                        <div id="processMessage" class="a-center w-20p">
                            <asp:Image ID="imgProgressbar1" Width="40px" Height="40px" runat="server" 
                                ImageUrl="../Images/loading.GIF" meta:resourcekey="imgProgressbar1Resource1"
                                 />
                        </div>
                    </ProgressTemplate>
                </asp:UpdateProgress>
                       
                        <div class="a-center" id="printCashClosure">
                            <table class="w-100p searchPanel">
                                <tr>
                                    <td class="a-center">
                                        <%--<asp:Label ID="Rs_ReceivedBy" Text="Received By" runat="server" meta:resourcekey="Rs_ReceivedByResource1"></asp:Label>
                                        --%>
                                    </td>
                                    <td class="a-center">
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td class="a-left" colspan="2">
                                <table class="w-100p">
                                 <tr>
                                 <td>
                                <asp:Label ID="lblFromDate" runat="server" CssClass="a-left padding8" Text="From" 
                                         meta:resourcekey="lblFromDateResource1"></asp:Label>
                               </td>
                               
                                <td>
                                
                                    <asp:TextBox ID="txtFromDate1" runat="server" CssClass="Txtboxsmall" meta:resourcekey="txtFromDate1Resource1" 
                                                   ></asp:TextBox>
                                                    <asp:ImageButton ID="ImgBntCalcFrom1" runat="server" ImageUrl="~/images/Calendar_scheduleHS.png"
                                                                CausesValidation="False" 
                                        meta:resourcekey="ImgBntCalcFrom1Resource1"  />
                                                           
                                                       <cc1:CalendarExtender ID="CalExtender1" runat="server" TargetControlID="txtFromDate1"  
                                                  
                                                                 Format="dd/MM/yyyy" 
                                        PopupButtonID="ImgBntCalcFrom1" Enabled="True" />
                                                                 <%--<cc1:CalendarExtender ID="CalExtender1" runat="server"></cc1:CalendarExtender> <%--  OnClientDateSelectionChanged="ValidateDate1"--%>
                                                               
                               </td>
                               <td>
                                
                                
                                    <asp:Label ID="lblToDate" runat="server"  CssClass="a-left padding8" Text="To"></asp:Label>
                                    
                             
                                </td>
                                <td>
                                
                                    <asp:TextBox ID="txtToDate" runat="server" CssClass="Txtboxsmall" onchange="javascript:ValidateDate();"  
                                                   ></asp:TextBox>
                                                   <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/Calendar_scheduleHS.png"
                                                                CausesValidation="False"  />
                                                            
                                                            <cc1:CalendarExtender ID="CalendarExtender2" runat="server" TargetControlID="txtToDate"
                                                              OnClientDateSelectionChanged="ValidateDate1"
                                                                Format="dd/MM/yyyy" PopupButtonID="ImageButton1" Enabled="True" />
                                     </td>                           
                                   </tr>
                                <tr>
                                <td>
                                 <asp:Label ID="lblLocation" runat="server"  CssClass="a-left padding8" Text="Location"></asp:Label>
                                 </td>
                                 <td>
                                 <asp:DropDownList ID="ddlLocation" runat="server" CssClass="ddl" Width="130px" 
                                >
                            </asp:DropDownList>
                            </td>
                            
                            <td>
                            <asp:Label ID="lblUser" runat="server"  CssClass="a-left padding8" Text="User Name"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlUser" runat="server" 
                                            CssClass="ddl" >
                                        </asp:DropDownList>
                                        </td>
                                        </tr>
                                        <tr>
                                        <td colspan="4" align="center">
                                        <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="btn" OnClientClick="return ValidateDate()" OnClick="btnSearch_click"/>
                                        </td></tr>
                                        </table>
                           </td>
                                </tr>
                                
                                <tr>
                                    <td class="a-Center" colspan="2">
                                        <div class="dataheader2" id="divtimeDisplay" runat="server" style="display:none;">
                                            <asp:Label ID="lblReceivedTime" Style="text-align: left; padding-left: 5px;" runat="server"
                                                ></asp:Label>
                                            <br />
                                            <asp:Label ID="lblRefundTime" Style="text-align: left; padding-left: 5px;" runat="server"
                                               ></asp:Label>
                                            <br />
                                            <asp:Label ID="lblPrintDateTime" Style="text-align: left; padding-left: 5px;" runat="server"
                                               ></asp:Label>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2">
                                        <asp:Panel ID="pnlExam" runat="server" CssClass="defaultfontcolor" >
                                            <div class="dataheader2 a-center">
                                                <table class="w-80p m-auto">
                                                    <tr>
                                                        <td class="w-80p v-top">
                                                            <asp:Panel ID="pnlReceived" runat="server" GroupingText="Received Details" >
                                                                <asp:Label ID="lblgvBillDetails" Visible="False" runat="server" ></asp:Label>
                                                                <asp:GridView ID="gvBillDetails" runat="server" AutoGenerateColumns="False" 
                                                                    OnRowDataBound="gvBillDetails_RowDataBound" CssClass="w-100p gridView" DataKeyNames="FinalBillID" Visible="False"
                                                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px"
                                                                    CellPadding="2" Font-Names="Verdana" Font-Size="9pt" GridLines="Horizontal" OnRowCommand="gvBillDetails_RowCommand"
                                                                   >
                                                                    <RowStyle VerticalAlign="Top" ForeColor="#000066" />
                                                                    <Columns>
                                                                        <asp:BoundField DataField="AMTBillDate" HeaderText="Bill Date" 
                                                                            >
                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                        </asp:BoundField>
                                                                        <asp:TemplateField HeaderText="Bill Number" 
                                                                            >
                                                                            <ItemTemplate>
                                                                                <asp:Label ID="lnkBillNumber" runat="server" 
                                                                                   
                                                                                    Style="color: Black; font-family: Verdana; cursor: pointer;" 
                                                                                    Text='<%# Eval("BillNumber") %>'></asp:Label>
                                                                            </ItemTemplate>
                                                                        </asp:TemplateField>
                                                                        <asp:BoundField DataField="VisitNumber" HeaderText="Visit Number" 
                                                                            >
                                                                            
                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                        </asp:BoundField>
                                                                        <asp:BoundField DataField="FinalBillID" HeaderText="FinalbillID" Visible="false"
                                                                            />
                                                                        <asp:BoundField DataField="PatientName" HeaderText="Patient Name" >
                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                        </asp:BoundField>
                                                                        <asp:TemplateField HeaderText="Description" 
                                                                            Visible="False">
                                                                            <ItemTemplate>
                                                                                <asp:GridView ID="gvChildDetails" runat="server" AutoGenerateColumns="False" 
                                                                                    CssClass="dataheaderInvCtrl w-100p gridView" Font-Names="Verdana" 
                                                                                    Font-Size="9pt" >
                                                                                    <Columns>
                                                                                        <asp:TemplateField HeaderText="Description" 
                                                                                          >
                                                                                            <ItemTemplate>
                                                                                                <asp:Label ID="chkID" runat="server" 
                                                                                                    Style="text-align: left;" Text='<%# Eval("Descriptions") %>'></asp:Label>
                                                                                            </ItemTemplate>
                                                                                            <HeaderStyle HorizontalAlign="Center" />
                                                                                            <ItemStyle HorizontalAlign="Left" Width="60%" />
                                                                                        </asp:TemplateField>
                                                                                        <asp:BoundField DataField="AmtReceived" HeaderText="Billed Amount" 
                                                                                            >
                                                                                            <ItemStyle HorizontalAlign="Right" />
                                                                                        </asp:BoundField>
                                                                                        <asp:BoundField DataField="RefundAmount" DataFormatString="{0:0.00}" 
                                                                                            HeaderText="Amount Refunded" >
                                                                                            <ItemStyle HorizontalAlign="Right" />
                                                                                        </asp:BoundField>
                                                                                    </Columns>
                                                                                </asp:GridView>
                                                                            </ItemTemplate>
                                                                        </asp:TemplateField>
                                                                        <asp:BoundField DataField="AmtReceived" HeaderText="Amount" 
                                                                           >
                                                                            <ItemStyle HorizontalAlign="Right" />
                                                                        </asp:BoundField>
                                                                        <asp:BoundField DataField="AmtReceivedID" HeaderText="UniqueID" 
                                                                           />
                                                                        <asp:BoundField DataField="PaidCurrency" HeaderText="Paid Currency" 
                                                                            Visible="False">
                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                        </asp:BoundField>
                                                                        <asp:BoundField DataField="PaidCurrencyAmount" DataFormatString="{0:0.00}" 
                                                                            HeaderText="Amount Paid" >
                                                                            <ItemStyle HorizontalAlign="Right" />
                                                                        </asp:BoundField>
                                                                    </Columns>
                                                                    <HeaderStyle CssClass="grdcolor" Font-Bold="True" />
                                                                    <RowStyle VerticalAlign="Top" ForeColor="#000066" />
                                                                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                                                                </asp:GridView>
                                                                <asp:GridView ID="gvAllUsers" runat="server" AutoGenerateColumns="False"
                                                                    OnRowDataBound="gvAllUsers_RowDataBound" CssClass="w-100p gridView" Visible="False" OnRowCommand="gvAllUsers_RowCommand"
                                                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                                    CellPadding="3" Font-Names="Verdana" Font-Size="9pt" >
                                                                    <RowStyle ForeColor="#000066" />
                                                                    <Columns>
                                                                    
                                                            <%--   //     Date Name Counted AMount Cash Expected Cash Difference Settleamount Status Action--%>
                                                                       <asp:TemplateField HeaderText="Date"  >
                                                                            <ItemTemplate>
                                                                               
                                                                                    <asp:Label ID="lblcreatedat" runat="server" 
                                                                                     
                                                                                     Text='<%# Eval("ModifiedAt","{0:dd-MM-yyyy}") %>'  ></asp:Label>
                                                                            </ItemTemplate>
                                                                            <ItemStyle HorizontalAlign="center" Width="12%" />
                                                                        </asp:TemplateField>
                                                                        <asp:TemplateField HeaderText="Received By">
                                                                            <ItemTemplate>
                                                                            
                                                                                   
                                                                                <asp:LinkButton ID="lnkReceivedNumber" runat="server" 
                                                                                    CommandArgument='<%# Eval("ReceivedBy") %>' CommandName="UserLink" 
                                                                                     Style="color: Black; text-decoration: underline;
                                                                                    font-family: Verdana; cursor: pointer;" Text='<%# Eval("FinalBillID") %>'></asp:LinkButton>
                                                                            </ItemTemplate>
                                                                        </asp:TemplateField>
                                                                        <asp:TemplateField HeaderText="Amount" 
                                                                           >
                                                                            <ItemTemplate>
                                                                                <asp:Label ID="lblAmtReceived" runat="server" 
                                                                                     Text='<%# bind("AmtReceived") %>'></asp:Label>
                                                                            </ItemTemplate>
                                                                        </asp:TemplateField>
                                                                        <asp:BoundField DataField="AmtReceivedID" HeaderText="UniqueID" 
                                                                          />
                                                                        <asp:BoundField DataField="ReceivedBy" HeaderText="UserID"  
                                                                            />
                                                                       
                                                                        <asp:TemplateField HeaderText="Total Cash Expected" 
                                                                          >
                                                                            <ItemTemplate>
                                                                                <asp:Label ID="lblTotalPendingSettlementAmt" runat="server" 
                                                                                     
                                                                                    Text='<%# Eval("AmtReceived") %>'></asp:Label>
                                                                            <%--   <asp:Label ID="lblTotalPendingSettlementAmt" runat="server" 
                                                                                     
                                                                                    Text='<%# TotalSettlementAmountCalc(Eval("PendingSettlementAmt"),Eval("AmtReceived")) %>'></asp:Label>--%>
                                                                            </ItemTemplate>
                                                                            <ItemStyle HorizontalAlign="Right" Width="20%" />
                                                                        </asp:TemplateField>
                                                                        <asp:TemplateField HeaderText="Settlement Amount" 
                                                                           >
                                                                            <ItemTemplate>
                                                                                <asp:TextBox ID="txtAllUserSettledAmt" runat="server" 
                                                                                   Style="text-align: right;" 
                                                                                    Text="0.00"></asp:TextBox>
                                                                                    <asp:Label ID="lblRefundamt" runat="server" 
                                                                                     Text='<%# bind("RefundAmount") %>' style="display:none;"></asp:Label>
                                                                            </ItemTemplate>
                                                                            <ItemStyle HorizontalAlign="Right" Width="20%" />
                                                                        </asp:TemplateField>
                                                                         <asp:TemplateField HeaderText="Cash Difference" 
                                                                           >
                                                                            <ItemTemplate>
                                                                                <asp:Label ID="lblPedningSettledAmt" runat="server" 
                                                                                     Style="text-align: right;" 
                                                                                    Text='<%# bind("PendingSettlementAmt") %>'></asp:Label>
                                                                            </ItemTemplate>
                                                                            <ItemStyle HorizontalAlign="Right" Width="20%" />
                                                                        </asp:TemplateField>
                                                                        <asp:TemplateField HeaderText="Status" 
                                                                           >
                                                                            <ItemTemplate>
                                                                             <asp:Label ID="lblClosureID" runat="server" Visible="false"
                                                                                     Text='<%#  Eval("BookingID") %>' ></asp:Label>
                                                                                    <asp:Label ID="lblstatus" runat="server" 
                                                                                     Text='<%# Eval("ClosureStatus")  %>' ></asp:Label>
                                                                                     
                                                                            </ItemTemplate>
                                                                            <ItemStyle HorizontalAlign="Center" Width="8%" />
                                                                        </asp:TemplateField>
                                                                         <asp:TemplateField HeaderText="Action">
                                                                            <ItemTemplate>
                                                                            <%--    <asp:LinkButton ID="LinkButtonEdit" runat="server" CommandName="ShowPopup"
                                                                        CommandArgument='<%# Eval("ReceivedBy") %>'>View</asp:LinkButton>--%>
                                                                        <%--  <asp:LinkButton ID="imgbtndetails" runat="server" CommandName="ShowPopup"
                                                                        CommandArgument='<%# Eval("ReceivedBy") %>'>View</asp:LinkButton>--%>
                                                                            <asp:ImageButton  ID="imgbtnadd" runat="server" Text="ADD"  OnClick="imgbtn_Click" ImageUrl="~/Images/adds.png"  CommandArgument='<%# Eval("ReceivedBy") %>'/>
                                                                               <asp:ImageButton  ID="imgbtnview" runat="server" Text="View"  OnClick="imgbtn1_Click" ImageUrl="~/Images/view.png"  CommandArgument='<%# Eval("ReceivedBy") %>'/>
                                                                            <%--    <asp:Label ID="lbluserid" runat="server" Text=""></asp:Label>--%>
                                                                             <asp:Label ID="FinalBillID" runat="server"  Visible=false
                                                                                     
                                                                                     Text='<%# Eval("FinalBillID") %>'   ></asp:Label>
                                                                            <asp:HiddenField ID="hdnFinalBillID" runat="server" Value='<%# Eval("FinalBillID") %>' />
                                                                            </ItemTemplate>
                                                                            <ItemStyle HorizontalAlign="Center" Width="10%" />
                                                                        </asp:TemplateField>
                                                                    </Columns>
                                                                    <HeaderStyle CssClass="grdcolor" Font-Bold="True" />
                                                                    <RowStyle ForeColor="#000066" />
                                                                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                                                                </asp:GridView>
                                                                    <asp:GridView ID="GridView2" runat="server"
                                                                     CssClass="w-100p gridView" Visible="False"
                                                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                                    CellPadding="3" Font-Names="Verdana" Font-Size="9pt" >
                                                                   
                                                                   
                                                                </asp:GridView>
                                                                 <asp:HiddenField ID="hdnFinalBill" runat="server"  />
                                                                    <asp:HiddenField ID="hdnClosureID" runat="server"  />
                                                            </asp:Panel>
                                                            <asp:Panel ID="pnlRefund" runat="server" GroupingText="Refund / Cancel Details" >
                                                                <asp:Label ID="lblgvRefundDetails" Visible="False" runat="server" ></asp:Label>
                                                                <asp:GridView ID="gvRefundDetails" runat="server" AutoGenerateColumns="False" CssClass="w-100p gridView"
                                                                    OnRowDataBound="gvRefundDetails_RowDataBound" Visible="False" BackColor="White"
                                                                    BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Font-Names="Verdana"
                                                                    Font-Size="9pt" >
                                                                    <RowStyle ForeColor="#000066" />
                                                                    <Columns>
                                                                        <asp:TemplateField HeaderText="Bill Number" 
                                                                           >
                                                                            <ItemTemplate>
                                                                                <asp:Label ID="lnkBillNumber" runat="server" 
                                                                                    Style="color: Black; font-family: Verdana;
                                                                                    cursor: pointer;" Text='<%# Eval("BillNumber") %>'></asp:Label>
                                                                            </ItemTemplate>
                                                                        </asp:TemplateField>
                                                                        <asp:BoundField DataField="ReceiptNO" HeaderText="Refund Number" 
                                                                          />
                                                                        <asp:BoundField DataField="PatientName" HeaderText="Patient Name" 
                                                                           />
                                                                        <asp:BoundField DataField="AmtReceived" HeaderText="Amount" 
                                                                           >
                                                                            <ItemStyle HorizontalAlign="Right" />
                                                                        </asp:BoundField>
                                                                        <asp:BoundField DataField="AmtReceivedID" HeaderText="UniqueID" 
                                                                            />
                                                                    </Columns>
                                                                    <FooterStyle BackColor="White" ForeColor="#000066" />
                                                                    <HeaderStyle CssClass="grdcolor" Font-Bold="True" />
                                                                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                                                                    <RowStyle ForeColor="#000066" />
                                                                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                                                                </asp:GridView>
                                                                <asp:GridView ID="gvAllUsersRefund" runat="server" AutoGenerateColumns="False" CssClass="w-100p gridView"
                                                                    OnRowDataBound="gvAllUsersRefund_RowDataBound" Visible="False" BackColor="White"
                                                                    BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Font-Names="Verdana"
                                                                    Font-Size="9pt" >
                                                                    <RowStyle ForeColor="#000066" />
                                                                    <Columns>
                                                                        <asp:TemplateField HeaderText="Refund By" 
                                                                        >
                                                                            <ItemTemplate>
                                                                                <asp:LinkButton ID="lnkReceivedNumber" runat="server" 
                                                                                   Style="color: Black; text-decoration: underline;
                                                                                    font-family: Verdana; cursor: pointer;" Text='<%# Eval("FinalBillID") %>'></asp:LinkButton>
                                                                            </ItemTemplate>
                                                                        </asp:TemplateField>
                                                                        <asp:BoundField DataField="AmtReceived" HeaderText="Amount" 
                                                                         >
                                                                            <ItemStyle HorizontalAlign="Right" />
                                                                        </asp:BoundField>
                                                                        <asp:BoundField DataField="AmtReceivedID" HeaderText="UniqueID" 
                                                                            />
                                                                        <asp:BoundField DataField="ReceivedBy" HeaderText="UserID" 
                                                                           />
                                                                           <%--  <asp:TemplateField HeaderText="Refund By" 
                                                                        >
                                                                            <ItemTemplate>
                                                                                <asp:LinkButton ID="lnkReceivedNumber" runat="server" 
                                                                                   Style="color: Black; text-decoration: underline;
                                                                                    font-family: Verdana; cursor: pointer;" Text='<%# Eval("FinalBillID") %>'></asp:LinkButton>
                                                                            </ItemTemplate>
                                                                        </asp:TemplateField>--%>
                                                                    </Columns>
                                                                    <FooterStyle BackColor="White" ForeColor="#000066" />
                                                                    <HeaderStyle CssClass="grdcolor" Font-Bold="True" />
                                                                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                                                                    <RowStyle ForeColor="#000066" />
                                                                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                                                                </asp:GridView>
                                                            </asp:Panel>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:Panel ID="pnlPayments" runat="server" GroupingText="Payment Details"  Visible="false">
                                                                <asp:Label ID="lblgvPaymentDetails" Visible="False" runat="server" ></asp:Label>
                                                                <asp:GridView ID="gvPaymentDetails" runat="server" AutoGenerateColumns="False" OnRowDataBound="gvPaymentDetails_RowDataBound"
                                                                    Visible="False" CssClass="w-100p gridView" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None"
                                                                    BorderWidth="1px" CellPadding="3" Font-Names="Verdana" Font-Size="9pt" >
                                                                    <RowStyle ForeColor="#000066" />
                                                                    <Columns>
                                                                        <asp:TemplateField HeaderText="Doctor Number" 
                                                                          >
                                                                            <ItemTemplate>
                                                                                <asp:Label ID="lnkBillNumber" runat="server" 
                                                                                    Style="color: Black; font-family: Verdana;
                                                                                    cursor: pointer;" Text='<%# Eval("BillNumber") %>'></asp:Label>
                                                                            </ItemTemplate>
                                                                            <HeaderStyle CssClass="stylenone" />
                                                                            <ItemStyle CssClass="stylenone" />
                                                                        </asp:TemplateField>
                                                                        <asp:BoundField DataField="PatientName" HeaderText="Description" 
                                                                             />
                                                                        <asp:BoundField DataField="AmtReceived" HeaderText="Amount" 
                                                                           >
                                                                            <ItemStyle HorizontalAlign="Right" />
                                                                        </asp:BoundField>
                                                                        <asp:BoundField DataField="AmtReceivedID" HeaderText="UniqueID" 
                                                                           />
                                                                    </Columns>
                                                                    <FooterStyle BackColor="White" ForeColor="#000066" />
                                                                    <HeaderStyle CssClass="grdcolor" Font-Bold="True" />
                                                                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                                                                    <RowStyle ForeColor="#000066" />
                                                                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                                                                </asp:GridView>
                                                                <asp:GridView ID="gvAllUsersPayments" runat="server" AutoGenerateColumns="False"
                                                                    OnRowDataBound="gvAllUsersPayments_RowDataBound" Visible="False" CssClass="w-100p gridView"
                                                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px"
                                                                    CellPadding="3" Font-Names="Verdana" Font-Size="9pt" OnRowCommand="gvAllUsersPayments_RowCommand"
                                                                   >
                                                                    <RowStyle ForeColor="#000066" />
                                                                    <Columns>
                                                                        <asp:TemplateField HeaderText="Paid By" 
                                                                          >
                                                                            <ItemTemplate>
                                                                                <asp:LinkButton ID="lnkReceivedNumber" runat="server" 
                                                                                    CommandArgument='<%# Eval("ReceivedBy") %>' CommandName="UserPaidLink" 
                                                                                     Style="color: Black; text-decoration: underline;
                                                                                    font-family: Verdana;" Text='<%# Eval("FinalBillID") %>'></asp:LinkButton>
                                                                            </ItemTemplate>
                                                                        </asp:TemplateField>
                                                                        <asp:BoundField DataField="AmtReceived" HeaderText="Amount" 
                                                                           >
                                                                            <ItemStyle HorizontalAlign="Right" />
                                                                        </asp:BoundField>
                                                                        <asp:BoundField DataField="AmtReceivedID" HeaderText="UniqueID" 
                                                                            />
                                                                        <asp:BoundField DataField="ReceivedBy" HeaderText="UserID" 
                                                                            />
                                                                    </Columns>
                                                                    <FooterStyle BackColor="White" ForeColor="#000066" />
                                                                    <HeaderStyle CssClass="grdcolor" Font-Bold="True" />
                                                                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                                                                    <RowStyle ForeColor="#000066" />
                                                                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                                                                </asp:GridView>
                                                                <asp:GridView ID="gvAmtPaidDetails" runat="server" AutoGenerateColumns="False" Visible="False"
                                                                   CssClass="w-100p gridView" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px"
                                                                    CellPadding="3" Font-Names="Verdana" Font-Size="9pt" >
                                                                    <RowStyle ForeColor="#000066" />
                                                                    <Columns>
                                                                        <asp:TemplateField HeaderText="Doctor Number" 
                                                                           >
                                                                            <ItemTemplate>
                                                                                <asp:Label ID="lnkBillNumber0" runat="server" 
                                                                                     Style="color: Black; font-family: Verdana;
                                                                                    cursor: pointer;" Text='<%# Eval("ReceiverID") %>'></asp:Label>
                                                                            </ItemTemplate>
                                                                            <HeaderStyle CssClass="stylenone" />
                                                                            <ItemStyle CssClass="stylenone" />
                                                                        </asp:TemplateField>
                                                                        <asp:BoundField DataField="PatientName" HeaderText="Description" 
                                                                            />
                                                                        <asp:BoundField DataField="AmtReceived" HeaderText="Amount" 
                                                                            >
                                                                            <ItemStyle HorizontalAlign="Right" />
                                                                        </asp:BoundField>
                                                                        <asp:BoundField DataField="AmtReceivedID" HeaderText="UniqueID" 
                                                                           />
                                                                    </Columns>
                                                                    <FooterStyle BackColor="White" ForeColor="#000066" />
                                                                    <HeaderStyle CssClass="grdcolor" Font-Bold="True" />
                                                                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                                                                    <RowStyle ForeColor="#000066" />
                                                                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                                                                </asp:GridView>
                                                            </asp:Panel>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:Panel ID="pnlCashIncomeDetails" runat="server" GroupingText="Cash income details"  Visible="false"
                                                               >
                                                                <asp:Label ID="lblgvCashIncomeDetails" Visible="False" runat="server" ></asp:Label>
                                                                <asp:GridView ID="gvCashIncomeDetails" runat="server" AutoGenerateColumns="False"
                                                                    Visible="False" CssClass="w-100p gridView" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None"
                                                                    BorderWidth="1px" CellPadding="3" Font-Names="Verdana" Font-Size="9pt" OnRowCommand="gvAllUsers_RowCommand"
                                                                    OnRowDataBound="gvCashIncomeDetails_RowDataBound" >
                                                                    <RowStyle ForeColor="#000066" />
                                                                    <Columns>
                                                                        <asp:TemplateField HeaderText="Received By" 
                                                                           >
                                                                            <ItemTemplate>
                                                                                <asp:LinkButton ID="lnkReceivedNumber" runat="server" 
                                                                                    CommandArgument='<%# Eval("ReceivedBy") %>' CommandName="UserLink" 
                                                                                     Style="color: Black; text-decoration: underline;
                                                                                    font-family: Verdana; cursor: pointer;" Text='<%# Eval("ReceiptNO") %>'></asp:LinkButton>
                                                                            </ItemTemplate>
                                                                        </asp:TemplateField>
                                                                        <asp:BoundField DataField="Remarks" HeaderText="Description" 
                                                                            />
                                                                        <asp:BoundField DataField="AmtReceived" HeaderText="Amount" 
                                                                           >
                                                                            <ItemStyle HorizontalAlign="Right" />
                                                                        </asp:BoundField>
                                                                        <asp:BoundField DataField="FinalBillID" HeaderText="UniqueID" 
                                                                             Visible="False" />
                                                                    </Columns>
                                                                    <FooterStyle BackColor="White" ForeColor="#000066" />
                                                                    <HeaderStyle CssClass="grdcolor" Font-Bold="True" />
                                                                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                                                                    <RowStyle ForeColor="#000066" />
                                                                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                                                                </asp:GridView>
                                                            </asp:Panel>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="v-top a-right">
                                                            <asp:Label runat="server" ID="lblConsreport" ></asp:Label>
                                                            <table class="w-100p">
                                                                <tr>
                                                                    <td class="a-right w-95p">
                                                                        <asp:Label ID="Rs_TotalCollectedAmount" Text="Total Cash Expected Amount" runat="server"
                                                                            ></asp:Label>
                                                                    </td>
                                                                    <td class="a-right w-5p">
                                                                        <asp:Label ID="lblTotal" runat="server" Text="0.00" ></asp:Label>
                                                                    </td>
                                                                </tr>
                                                                <tr style="display:none">
                                                                    <td class="a-right">
                                                                        <asp:Label ID="lblTotalIncAmount" Text="Total Collected Source Amount" runat="server"
                                                                           ></asp:Label>
                                                                    </td>
                                                                    <td class="a-right">
                                                                        <asp:Label ID="lblTotalInc" runat="server" Text="0.00"></asp:Label>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="a-right">
                                                                        <asp:Label ID="Rs_TotalRefundedAmount" Text="Total Refunded Amount" runat="server"
                                                                           ></asp:Label>
                                                                    </td>
                                                                    <td class="a-right">
                                                                        <asp:Label ID="lblRefund" runat="server" Text="0.00" ></asp:Label>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="a-right">
                                                                        <asp:Label ID="Rs_TotalCancelledBillAmount" Text="Total Cancelled Bill Amount" runat="server"
                                                                           ></asp:Label>
                                                                    </td>
                                                                    <td class="a-right">
                                                                        <asp:Label ID="lblCancelledAmount" runat="server" Text="0.00" ></asp:Label>
                                                                    </td>
                                                                </tr>
                                                                <tr style="display:none">
                                                                    <td class="a-right">
                                                                        <asp:Label ID="Rs_TotalPaidAmounttoPhysician" Text="Total Paid Amount to Physician"
                                                                            runat="server" ></asp:Label>
                                                                    </td>
                                                                    <td class="a-right">
                                                                        <asp:Label ID="lblPhyAmount" runat="server" Text="0.00" ></asp:Label>
                                                                    </td>
                                                                </tr>
                                                                <tr style="display:none">
                                                                    <td class="a-right">
                                                                        <asp:Label ID="Rs_TotalPaidMiscellaneousAmount" Text="Total Paid Miscellaneous Amount"
                                                                            runat="server" ></asp:Label>
                                                                    </td>
                                                                    <td class="a-right">
                                                                        <asp:Label ID="lblOthersAmount" runat="server" Text="0.00" ></asp:Label>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="a-right">
                                                                        <asp:Label ID="Rs_TotalPendingSettledAmt" Text="Total Cash Difference Amount"
                                                                            runat="server" ></asp:Label>
                                                                    </td>
                                                                    <td class="a-right">
                                                                        <asp:Label ID="lblTotalPendingSettledAmt" runat="server" Text="0.00" ></asp:Label>
                                                                    </td>
                                                                </tr>
                                                                <tr style="display:none">
                                                                    <td class="a-right">
                                                                        <asp:Label ID="Rs_ClosingBalance" Text="Closing Balance" runat="server"></asp:Label>
                                                                    </td>
                                                                    <td class="a-right">
                                                                        <asp:Label ID="lblClosingBalance" runat="server" Text="0.00" ></asp:Label>
                                                                    </td>
                                                                </tr>
                                                                <tr id="trSettledAmt" runat="server">
                                                                    <td id="Td1" class="a-right" runat="server">
                                                                        <asp:Label ID="Rs_settledAmt" Text="Settlement Amount" runat="server" ></asp:Label>
                                                                    </td>
                                                                    <td id="Td2" class="a-right" runat="server">
                                                                        <asp:TextBox ID="txtSettledAmt" runat="server" onblur="ChangeFormat();" Style="text-align: right;"
                                                                            CssClass="Txtboxsmall"></asp:TextBox>
                                                                        <asp:HiddenField ID="hdnClosingAmt" runat="server" Value="0" />
                                                                        <asp:HiddenField ID="hdnCashInHand" runat="server" Value="0" />
                                                                    </td>
                                                                </tr>
                                                                <tr id="trCashInHand" runat="server">
                                                                    <td id="Td3" colspan="2" runat="server">
                                                                        <table>
                                                                            <tr>
                                                                                <td colspan="2">
                                                                                    --------------------------------------------------------------------
                                                                                </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td class="v-top a-right bold">
                                                                                    <asp:Label ID="Rs_ClosingCashInHand" Text="Closing Cash In Hand:" runat="server"
                                                                                        ></asp:Label>
                                                                                </td>
                                                                                <td class="a-right">
                                                                                    <asp:Label ID="lblClosingCashInHand" ForeColor="Green" runat="server" Text="0.00"
                                                                                        ></asp:Label>
                                                                                </td>
                                                                            </tr>
                                                                        </table>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="a-center" colspan="2">
                                                                        <asp:Button ID="btnSave" runat="server" CssClass="btn" OnClick="btnSave_Click" onmouseout="this.className='btn'" Visible="false"
                                                                            onmouseover="this.className='btn btnhov'" OnClientClick="javascript:return ValidateAmt();"
                                                                            Text="Settle Amount"  />
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="a-center">
                                                                    </td>
                                                                    <td class="a-center">
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </div>
                                        </asp:Panel>
                                    </td>
                                </tr>
                            </table>
                            <div class="dataheader2">
                                <asp:Panel ID="Panel2" runat="server" GroupingText="Amount Received Breakup For OP"
                                    >
                                    <asp:GridView ID="gvINDAmtReceivedDetails" runat="server" AutoGenerateColumns="False"
                                        Visible="False" CssClass="w-75p gridView mytable1" ForeColor="#333333" OnRowDataBound="gvINDAmtReceivedDetails_RowDataBound"
                                        >
                                        <Columns>
                                            <asp:BoundField DataField="Descriptions" HeaderText="Description">
                                                <ItemStyle HorizontalAlign="Left" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="Qty" HeaderText="Quantity"  />
                                            <asp:BoundField DataField="Amount" HeaderText="Amount" >
                                                <ItemStyle HorizontalAlign="Right" />
                                            </asp:BoundField>
                                        </Columns>
                                        <FooterStyle BackColor="White" ForeColor="#000066" />
                                        <HeaderStyle CssClass="grdcolor" Font-Bold="True" />
                                        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                                        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                                    </asp:GridView>
                                </asp:Panel>
                                <asp:Panel ID="Panel1" runat="server" GroupingText="Amount Received Breakup For IP"
                                   >
                                    <asp:GridView ID="gvIndIPAMountReceived" runat="server" AutoGenerateColumns="False"
                                        Visible="False" CssClass="w-75p gridView mytable1" ForeColor="#333333"  OnRowDataBound="gvINDAmtReceivedDetails_RowDataBound"
                                      >
                                        <Columns>
                                            <asp:BoundField DataField="Descriptions" HeaderText="Description" >
                                                <ItemStyle HorizontalAlign="Left" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="Qty" HeaderText="Quantity" />
                                            <asp:BoundField DataField="Amount" HeaderText="Amount"">
                                                <ItemStyle HorizontalAlign="Right" />
                                            </asp:BoundField>
                                        </Columns>
                                        <FooterStyle BackColor="White" ForeColor="#000066" />
                                        <HeaderStyle CssClass="grdcolor" Font-Bold="True" />
                                        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                                        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                                    </asp:GridView>
                                </asp:Panel>
                                <asp:Panel ID="Panel3" runat="server" Visible="False" GroupingText="Payments Breakup"
                                  >
                                    <asp:GridView ID="gvAmountBreakup" runat="server" AutoGenerateColumns="False" BackColor="White"
                                        BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Font-Bold="False"
                                        Font-Names="Verdana" Font-Overline="False" Font-Size="9pt" Font-Strikeout="False" CssClass="gridView"
                                        Font-Underline="False" >
                                        <RowStyle ForeColor="#000066" />
                                        <Columns>
                                            <asp:BoundField DataField="ClosureStatus" HeaderText="Payment Type" 
                                                 />
                                            <asp:BoundField DataField="AmtReceived" HeaderText="Amount" 
                                                >
                                                <ItemStyle HorizontalAlign="Right" />
                                            </asp:BoundField>
                                        </Columns>
                                        <FooterStyle BackColor="White" ForeColor="#000066" />
                                        <HeaderStyle CssClass="grdcolor" Font-Bold="True" />
                                        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                                        <RowStyle ForeColor="#000066" />
                                        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                                    </asp:GridView>
                                </asp:Panel>
                              
                           



                    
                                <asp:Panel ID="pnlOthers" runat="server" Style="display: none;" CssClass="modalPopup dataheaderPopup"
                                   >
                                    <center>
                                        <div id="divOthers" style="width: 350px; height: 400px; padding-top: 50px; padding-left: 15px">
                                            <table class="a-center w-90p">
                                                <tr>
                                                    <td>
                                                        <asp:GridView ID="gvResult" ShowFooter="True" CellPadding="3" runat="server" AutoGenerateColumns="False"
                                                            CssClass="gridView" Font-Names="Verdana" OnRowDataBound="gvResult_RowDataBound" >
                                                            <Columns>
                                                                <asp:TemplateField HeaderText="S.No" >
                                                                    <ItemTemplate>
                                                                        <%# Container.DataItemIndex + 1 %>
                                                                    </ItemTemplate>
                                                                    <ItemStyle Width="8%" />
                                                                </asp:TemplateField>
                                                                <asp:TemplateField HeaderText="Details" 
                                                                    Visible="False">
                                                                    <ItemTemplate>
                                                                        <asp:Label ID="lblID" runat="server"  Text='<%# DataBinder.Eval(Container.DataItem,"ClosureID") %>'></asp:Label>
                                                                    </ItemTemplate>
                                                                </asp:TemplateField>
                                                                <asp:TemplateField HeaderText="Details" >
                                                                    <ItemTemplate>
                                                                        <asp:Label ID="lblDetail" runat="server"  Text='<%# DataBinder.Eval(Container.DataItem,"Rupees") %>'></asp:Label>
                                                                    </ItemTemplate>
                                                                    <HeaderStyle Width="30px" />
                                                                    <ItemStyle HorizontalAlign="Right" Width="5%" />
                                                                </asp:TemplateField>
                                                                <asp:TemplateField HeaderText="Unit" >
                                                                    <ItemTemplate>
                                                                        <asp:Label ID="lblUnit" runat="server"  Text='<%# DataBinder.Eval(Container.DataItem,"Unit") %>'></asp:Label>
                                                                    </ItemTemplate>
                                                                    <FooterTemplate>
                                                                        <b>
                                                                        <div style="text-align: right">
                                                                            <asp:Label ID="lblTotal" runat="server"  
                                                                                Style="text-align: right" Text="Total:"></asp:Label>
                                                                        </div>
                                                                        </b>
                                                                    </FooterTemplate>
                                                                    <HeaderStyle Width="30px" />
                                                                    <ItemStyle HorizontalAlign="Right" Width="5%" />
                                                                </asp:TemplateField>
                                                                <asp:TemplateField HeaderText="Amount" >
                                                                    <FooterTemplate>
                                                                        <div style="text-align: right">
                                                                            <asp:Label ID="lblTotalSum" runat="server" Font-Bold="True" 
                                                                               ></asp:Label>
                                                                        </div>
                                                                    </FooterTemplate>
                                                                    <ItemTemplate>
                                                                        <asp:Label ID="lblDetail" runat="server"  Text='<%# DataBinder.Eval(Container.DataItem,"Amount") %>'></asp:Label>
                                                                    </ItemTemplate>
                                                                    <HeaderStyle Width="30px" />
                                                                    <ItemStyle HorizontalAlign="Right" Width="5%" />
                                                                </asp:TemplateField>
                                                            </Columns>
                                                            <HeaderStyle CssClass="dataheader1" />
                                                            <PagerStyle CssClass="dataheader1" />
                                                        </asp:GridView>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                    <button id="btnCancel" class="btn">Cancel</button>
                                                    </td>
                                                </tr>
                                            </table>
                                        </div>
                                    </center>
                                </asp:Panel>
                            </div>
                        </div>
                        <div class="dataheader2 a-center">
                           <%-- <input id="btnAdd" type="button" class="btn" value="View Denomination" onclick="showModalPopup(event);" />--%>
                            <%--<button  id="btnAdd" class="btn"   onclick="showModalPopup(event);" >View Denomination</button>--%>
                            <asp:Button ID="btnPrint" runat="server" Text="Print" CssClass="btn"
                                onmouseover="this.className='btn btnhov'" onmouseout="this.className='btn'" OnClientClick="return popupprint();"
                                />
                            <asp:Button ID="btnBack" runat="server" Text="Back" CssClass="btn"
                                onmouseover="this.className='btn btnhov'" onmouseout="this.className='btn'" Visible="False"
                                OnClick="btnBack_Click"  display="none"/>
                            <asp:HiddenField ID="hiddenTargetControlFormpeOthers" runat="server" />
                            <asp:HiddenField ID="hdnShowPopup" runat="server" Value="0" />
                            <asp:HiddenField ID="hdnDenomination" runat="server" Value="0" />
                             <asp:HiddenField ID="hdnclosurestatus" runat="server" Value="" />
                            <ajc:ModalPopupExtender ID="mpeOthers" runat="server" BehaviorID="mpeOthersBehavior"
                                PopupControlID="pnlOthers" CancelControlID="btnCancel" TargetControlID="hiddenTargetControlFormpeOthers"
                                DynamicServicePath="" Enabled="True">
                            </ajc:ModalPopupExtender>
                        </div>
                         <asp:HiddenField ID="hdnuserid" runat="server" Value="0" />
                    <asp:Button ID="btnShowPopup" runat="server" style="display:none" />

        <cc1:ModalPopupExtender ID="ModalPopupExtender1" runat="server" TargetControlID="btnShowPopup" PopupControlID="pnlpopup"

CancelControlID="btnCancelDeno" BackgroundCssClass="modalBackground">

</cc1:ModalPopupExtender>
<%-- <cc1:ModalPopupExtender ID="ModalPopupExtender1" runat="server" TargetControlID="pnlpopup" PopupControlID="pnlpopup"
BehaviorID="mpe"
CancelControlID="btnCancelDeno" BackgroundCssClass="modalBackground">

</cc1:ModalPopupExtender>--%>
                      <asp:Panel ID="pnlpopup" runat="server" CssClass="modalPopup dataheaderPopup"  style="display:none">
                        <center>
                                        <div id="divpopup" style="width: 500px; height: 450px; padding-top: 25px; padding-left: 5px">              
    <asp:Label Font-Bold = "true" ID = "Label4" runat = "server" Text = "Payment Acceptance Screen" ></asp:Label>

   <br />
<br />



<table id="Table1" class="a-center w-90p" runat = "server" style="margin: 15px 0;">
<tr>
<td>
<table id="Table2" runat="server" >
  <tr>
    <td><asp:Label Font-Bold = "true" ID = "lbltwoth" runat = "server" Text = "" Style="text-align: right;width:56px;"></asp:Label></td>
    <td>  <asp:TextBox ID="txttwothous" runat="server" TabIndex="1" AutoPostBack="true" OnTextChanged="txttwothous_TextChanged" Style="text-align: right;width:46px;" Text="0"></asp:TextBox></td>
     <td><asp:Label Font-Bold = "true" ID = "Label1" runat = "server" Text = "=" Style="text-align: right;width:16px;"></asp:Label></td>
                    <td><asp:Label Font-Bold = "true" ID = "lbltwothrup" runat = "server" Text = "" Style="text-align: right;width:46px;"></asp:Label></td>
                     <td><asp:Label Font-Bold = "true" ID = "Label14" runat = "server" Text = "" visible="false" Style="text-align: right;width:16px;"></asp:Label></td>
    <td><asp:Label Font-Bold = "true" ID = "lbloneth" runat = "server" Text = "" Style="text-align: right;width:56px;"></asp:Label></td>
    <td>  <asp:TextBox ID="txtoneth" AutoPostBack="true" TabIndex="2" OnTextChanged="txtoneth_TextChanged" runat="server"  Text="0" Style="text-align: right;width:46px;" ></asp:TextBox></td>
       <td><asp:Label Font-Bold = "true" ID = "Label2" runat = "server" Text = "=" Style="text-align: right;width:16px;"></asp:Label></td>
      <td><asp:Label Font-Bold = "true" ID = "lblonethrup" runat = "server" Text = "" Style="text-align: right;width:46px;"></asp:Label></td>
       <td><asp:Label Font-Bold = "true" ID = "Label20" runat = "server" Text = "" visible="false" Style="text-align: right;width:16px;"></asp:Label></td>
  </tr>
</table><br />

<table id="Table3" runat="server">
  <tr>
      <td><asp:Label Font-Bold = "true" ID = "lblfivehund" runat = "server" Text = "" Style="text-align: right;width:56px;"></asp:Label></td>
    <td>  <asp:TextBox ID="txtfivehund" runat="server" TabIndex="3" AutoPostBack="true" OnTextChanged="txtfivehund_TextChanged" 
                                                                                   Style="text-align: right;width:46px;"
                                                                                    Text="0"></asp:TextBox></td>
    <td><asp:Label Font-Bold = "true" ID = "Label3" runat = "server" Text = "=" Style="text-align: right;width:16px;"></asp:Label></td>
   <td><asp:Label Font-Bold = "true" ID = "lblfivehundrup" runat = "server" Text = "" Style="text-align: right;width:46px;"></asp:Label></td>
   <td><asp:Label Font-Bold = "true" ID = "Label15" runat = "server" Text = "" Style="text-align: right;width:16px;" visible="false"></asp:Label></td>
   <td><asp:Label Font-Bold = "true" ID = "lbltwohund" runat = "server" Text = "" Style="text-align: right;width:56px;"></asp:Label></td>
    <td>  <asp:TextBox ID="txttwohund" runat="server" TabIndex="4" AutoPostBack="true" OnTextChanged="txttwohund_TextChanged" 
                                                                                   Style="text-align: right;width:46px;"
                                                                                    Text="0"></asp:TextBox></td>
    <td><asp:Label Font-Bold = "true" ID = "Label5" runat = "server" Text = "=" Style="text-align: right;width:16px;"></asp:Label></td>
   <td><asp:Label Font-Bold = "true" ID = "lbltwohundrup" runat = "server" Text = "" Style="text-align: right;width:46px;"></asp:Label></td>
    <td><asp:Label Font-Bold = "true" ID = "Label21" runat = "server" Text = "" Style="text-align: right;width:16px;" visible="false"></asp:Label></td>
   
  </tr>
</table><br />

<table id="Table4" runat="server">
  <tr>
   <td><asp:Label Font-Bold = "true" ID = "lblhund" runat = "server" Text = "" Style="text-align: right;width:56px;"></asp:Label></td>
    <td>  <asp:TextBox ID="txthund" runat="server" TabIndex="5" AutoPostBack="true" OnTextChanged="txthund_TextChanged" 
                                                                                  Style="text-align: right;width:46px;"
                                                                                    Text="0"></asp:TextBox></td>
    <td><asp:Label Font-Bold = "true" ID = "Label6" runat = "server" Text = "=" Style="text-align: right;width:16px;"></asp:Label></td>
  <td><asp:Label Font-Bold = "true" ID = "lblhundrup" runat = "server" Text = "" Style="text-align: right;width:46px;"></asp:Label></td>
  <td><asp:Label Font-Bold = "true" ID = "Label16" runat = "server" Text = "" Style="text-align: right;width:16px;" visible="false"></asp:Label></td>
     <td><asp:Label Font-Bold = "true" ID = "lblfifty" runat = "server" Text = "" Style="text-align: right;width:56px;"></asp:Label></td>
    <td>  <asp:TextBox ID="txtfifty" runat="server" TabIndex="6" AutoPostBack="true" OnTextChanged="txtfifty_TextChanged" 
                                                                                     Style="text-align: right;width:46px;"
                                                                                    Text="0"></asp:TextBox></td>
    <td><asp:Label Font-Bold = "true" ID = "Label7" runat = "server" Text = "=" Style="text-align: right;width:16px;"></asp:Label></td>
      <td><asp:Label Font-Bold = "true" ID = "lblfftyrup" runat = "server" Text = "" Style="text-align: right;width:46px;"></asp:Label></td>
       <td><asp:Label Font-Bold = "true" ID = "Label22" runat = "server" Text = "" Style="text-align: right;width:16px;" visible="false"></asp:Label></td>

  </tr>
</table><br />

<table id="Table5" runat="server">
  <tr>
    <td><asp:Label Font-Bold = "true" ID = "lbltwenty" runat = "server" Text = "" Style="text-align: right;width:56px;"></asp:Label></td>
    <td>  <asp:TextBox ID="txttwenty" runat="server" TabIndex="7" AutoPostBack="true" OnTextChanged="txttwenty_TextChanged" 
                                                                                   Style="text-align: right;width:46px;"
                                                                                    Text="0"></asp:TextBox></td>
     <td><asp:Label Font-Bold = "true" ID = "Label8" runat = "server" Text = "=" Style="text-align: right;width:16px;"></asp:Label></td>
    <td><asp:Label Font-Bold = "true" ID = "lbltwtyrup" runat = "server" Text = "" Style="text-align: right;width:46px;"></asp:Label></td>
    <td><asp:Label Font-Bold = "true" ID = "Label17" runat = "server" Text = "" Style="text-align: right;width:16px;" visible="false"></asp:Label></td>
   <td><asp:Label Font-Bold = "true" ID = "lblten" runat = "server" Text = "" Style="text-align: right;width:56px;"></asp:Label></td>
    <td>  <asp:TextBox ID="txtten" runat="server" TabIndex="8" AutoPostBack="true" OnTextChanged="txtten_TextChanged" 
                                                                                     Style="text-align: right;width:46px;"
                                                                                    Text="0"></asp:TextBox></td>
      <td><asp:Label Font-Bold = "true" ID = "Label9" runat = "server" Text = "=" Style="text-align: right;width:16px;"></asp:Label></td>
     <td><asp:Label Font-Bold = "true" ID = "lbltenrup" runat = "server" Text = "" Style="text-align: right;width:46px;"></asp:Label></td>
      <td><asp:Label Font-Bold = "true" ID = "Label23" runat = "server" Text = "" Style="text-align: right;width:16px;" visible="false"></asp:Label></td>
   
  </tr>
</table><br />


<table id="Table6" runat="server">
<tr>
 <td><asp:Label Font-Bold = "true" ID = "lblfive" runat = "server" Text = "" Style="text-align: right;width:56px;"></asp:Label></td>
    <td>  <asp:TextBox ID="txtfive" runat="server" TabIndex="9" AutoPostBack="true" OnTextChanged="txtfive_TextChanged" 
                                                                                  Style="text-align: right;width:46px;"
                                                                                    Text="0"></asp:TextBox></td>
    <td><asp:Label Font-Bold = "true" ID = "Label10" runat = "server" Text = "=" Style="text-align: right;width:16px;"></asp:Label></td>
    <td><asp:Label Font-Bold = "true" ID = "lblfiverup" runat = "server" Text = "" Style="text-align: right;width:46px;"></asp:Label></td>
    <td><asp:Label Font-Bold = "true" ID = "Label18" runat = "server" Text = "" Style="text-align: right;width:16px;" visible="false"></asp:Label></td>
 <td><asp:Label Font-Bold = "true" ID = "lbltwo" runat = "server" Text = "" Style="text-align: right;width:56px;"></asp:Label></td>
    <td><asp:TextBox ID="txttwo" runat="server" TabIndex="10" Text="0" AutoPostBack="true" OnTextChanged="txttwo_TextChanged"  
    Style="text-align: right;width:46px;"></asp:TextBox></td>
  <td><asp:Label Font-Bold = "true" ID = "Label11" runat = "server" Text = "=" Style="text-align: right;width:16px;"></asp:Label></td>
 <td><asp:Label Font-Bold = "true" ID = "lbltwrup" runat = "server" Text = "" Style="text-align: right;width:46px;"></asp:Label></td>
  <td><asp:Label Font-Bold = "true" ID = "Label24" runat = "server" Text = "" Style="text-align: right;width:16px;" visible="false"></asp:Label></td>

</tr>
</table><br />

<table id="Table7" runat="server">
  <tr> <td><asp:Label Font-Bold = "true" ID = "lblone" runat = "server" Text = "" Style="text-align: right;width:56px;"></asp:Label></td>
    <td><asp:TextBox ID="txtone" runat="server"  Text="0" TabIndex="11" AutoPostBack="true" OnTextChanged="txtone_TextChanged" 
    Style="text-align: right;width:46px;"></asp:TextBox></td>
   <td><asp:Label Font-Bold = "true" ID = "Label12" runat = "server" Text = "=" Style="text-align: right;width:16px;"></asp:Label></td>
    <td><asp:Label Font-Bold = "true" ID = "lblonrup" runat = "server" Text = "" Style="text-align: right;width:46px;"></asp:Label></td> 
    <td><asp:Label Font-Bold = "true" ID = "Label19" runat = "server" Text = "" Style="text-align: right;width:16px;" visible="false"></asp:Label></td>  
     <%-- <td><asp:Label Font-Bold = "true" ID = "lblfiftypaise" runat = "server" Text = "" Style="text-align: right;width:56px;"></asp:Label></td>
    <td>  <asp:TextBox ID="txtfiftypaise" runat="server"  TabIndex="12" Text="0" AutoPostBack="true" OnTextChanged="txtfiftypaise_TextChanged" 
    Style="text-align: right;width:46px;"></asp:TextBox></td>
   <td><asp:Label Font-Bold = "true" ID = "Label13" runat = "server" Text = "=" Style="text-align: right;width:16px;"></asp:Label></td>                                                                                    
     <td><asp:Label Font-Bold = "true" ID = "lblfftypa" runat = "server" Text = "" Style="text-align: right;width:46px;"></asp:Label></td>
      <td><asp:Label Font-Bold = "true" ID = "Label25" runat = "server" Text = "" Style="text-align: right;width:16px;" visible="false"></asp:Label></td>--%>
     
  </tr>
</table><br />

<table id="Table8" runat="server">
  <tr>
    <td><asp:Label Font-Bold = "true" ID = "lblcountamt" runat = "server" Text = "Counted" Style="text-align: left;width:100px;"></asp:Label></td>
    <td>  <asp:TextBox ID="txtcountamt" runat="server"  TabIndex="13"
                                                                                  Style="text-align: right;width:100px;"
                                                                                    Text="0.00"></asp:TextBox></td>
    
  </tr>
</table><br />

<table id="Table9" runat="server">
  <tr>
    <td><asp:Label Font-Bold = "true" ID = "lblcashexp" runat = "server" Text = "Cash Expected" Style="text-align: left;width:100px;"></asp:Label></td>
    <td>  <asp:TextBox ID="txtcashexp" runat="server" TabIndex="14"
                                                                                 Style="text-align: right;width:100px;"
                                                                                    Text="0.00"></asp:TextBox></td>
    
  </tr>
</table><br />

<table id="Table10" runat="server">
  <tr>
    <td><asp:Label Font-Bold = "true" ID = "lblcasdiff" runat = "server" Text = "Cash Difference" Style="text-align: left;width:100px;"></asp:Label></td>
    <td>  <asp:TextBox ID="txtcashdiff" runat="server" TabIndex="15"
                                                                                 Style="text-align: right;width:100px;" 
                                                                                    Text="0.00"></asp:TextBox></td>
    
  </tr>
</table>

</td>

</tr>                                        
<tr>
<td>
<br /><br />
<tr>
<td>
<asp:GridView ID="GridView1" CssClass="Grid" HeaderStyle-CssClass="header" runat="server" Visible="false"
    AutoGenerateColumns="true">
</asp:GridView></td></tr>
<table align="center">
<tr>


<td >

<asp:Button ID="btnUpdate" CommandName="Update" runat="server" Text="Update" OnClick="btnUpdate_Click" CommandArgument="2"/>

<asp:Button ID="btnCancelDeno" runat="server" Text="Cancel" OnClick="btnCancelDeno_Click"/>

</td>

</tr>
</table>
</td></tr></table>

</div>
</center>
</asp:Panel>
                         </ContentTemplate>
                     
        </asp:UpdatePanel>
                    </div>
                    
       <Attune:Attunefooter ID="Attunefooter" runat="server" />       

    <script type="text/javascript" language="javascript">
        function DrawTable(BillID) {
            var AlrtWinHdr = SListForAppMsg.Get("Admin_TestInvestigation_aspx_02") != null ? SListForAppMsg.Get("Admin_TestInvestigation_aspx_02") : "Information";
            //alert(BillID);
            ValidationWindow(BillID, Information);
        }
        //if (document.getElementById('hdnShowPopup').value == "1" && document.getElementById('hdnDenomination').value == "1")
            //document.getElementById('btnAdd').style.display = 'block';
        //else
            //document.getElementById('btnAdd').style.display = 'none';
    </script>

    <asp:HiddenField ID="hdnAmtReceivedID" runat="server" />
    <asp:HiddenField ID="hdnNeedDescription" Value="Y" runat="server" />
    <asp:HiddenField ID="hdnMessages" runat="server" />
    </form>
</body>
</html>
<script type="text/javascript">
    function ShowModalPopup() {
        $find("mpe").show();
        return false;
    }
    function HideModalPopup() {
        $find("mpe").hide();
        return false;
    }
</script>
<script language="javascript" type="text/javascript">
    function openViewBill(obj, ftype) {
        if (ftype == "PRM") {
            var skey = "../Inventory/PrintBill.aspx"
                           + obj
                           + "&IsPopup=" + "Y"
                           + "&CCPage=Y"
                           + "";

            window.open(skey, 'ViewBill', 'letf=0,top=0,height=640,width=800,toolbar=0,scrollbars=1,status=0');
        }
        else {
            var skey = "../Reception/ViewPrintPage.aspx"
                           + obj
                           + "&IsPopup=" + "Y"
                           + "&CCPage=Y"
                           + "";

            window.open(skey, 'ViewBill', 'letf=0,top=0,height=640,width=800,toolbar=0,scrollbars=1,status=0');
        }
    }
    function popupprint() {
        var prtContent = document.getElementById('printCashClosure');
        var WinPrint = window.open('', '', 'letf=0,top=0,toolbar=0,scrollbars=0,status=0');
        //alert(WinPrint);
        WinPrint.document.write(prtContent.innerHTML);
        WinPrint.document.close();
        WinPrint.focus();
        WinPrint.print();
        WinPrint.close();
    }
    function showModalPopup(evt, footDescID, footAmtID) {

        document.getElementById('<%= pnlOthers.ClientID %>').style.display = "none";
        var modalPopupBehavior = $find('mpeOthersBehavior');
        modalPopupBehavior.show();
    }

    function ValidateAmt() {
        var AlrtWinHdr = SListForAppMsg.Get("Admin_BillSettlement_aspx_03") != null ? SListForAppMsg.Get("Admin_BillSettlement_aspx_03") : "Information";
        var userMsg = SListForAppMsg.Get("Admin_BillSettlement_aspx_01") != null ? SListForAppMsg.Get("Admin_BillSettlement_aspx_01") : "Settlement amount cannot be greater than closing balance amount";
        var userMsg1 = SListForAppMsg.Get("Admin_BillSettlement_aspx_02") != null ? SListForAppMsg.Get("Admin_BillSettlement_aspx_02") : "Please provide settlement amount";
    //    if (document.getElementById('ddlUser').value != 0) {
            if (Number($('[id$="txtSettledAmt"]').val()) > 0) {
                if (Number($('[id$="txtSettledAmt"]').val()) > Number($('[id$="hdnClosingAmt"]').val())) {

                    //var userMsg = SListForApplicationMessages.Get("Admin\\BillSettlement.aspx_1");
                    if (userMsg != null) {
                        //alert(userMsg);
                        ValidationWindow(userMsg, AlrtWinHdr);
                        return false;
                    }
                    else {
                        //alert('Settlement amount cannot be greater than closing balance amount');
                        ValidationWindow(userMsg, AlrtWinHdr);
                        return false;
                    }
                    return false;
                }
            }
            else {
                //var userMsg = SListForApplicationMessages.Get("Admin\\BillSettlement.aspx_2");
                if (userMsg1 != null) {
                    // alert(userMsg);
                    ValidationWindow(userMsg1, AlrtWinHdr);
                    return false;
                }
                else {
                    //alert('Please provide settlement amount');
                    ValidationWindow(userMsg1, AlrtWinHdr);
                    return false;
                }
                return false;
            }
      //  }
      //  else {
            try {
                var flag = 0, Amtflag = 0;
                var grid = document.getElementById('gvAllUsers');
                var grdlength = grid.rows.length;
                for (var i = 1; i < grdlength; i++) {
                    if (grid.rows[i].cells[4].childNodes[1].value == '' || Number(grid.rows[i].cells[4].childNodes[1].value) <= 0) {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 1) {
                    // var userMsg = SListForApplicationMessages.Get("Admin\\BillSettlement.aspx_3");
                    if (userMsg1 != null) {
                        //alert(userMsg);
                        ValidationWindow(userMsg1, AlrtWinHdr);
                        return false;
                    }
                    else {
                        //alert('Provide the settlement Amount');
                        ValidationWindow(userMsg1, AlrtWinHdr);
                        return false;
                    }
                    return false;
                }
            } catch (e) {

            }
            return true;
      //  }


    }
    function ChangeFormat() {
        var AlrtWinHdr = SListForAppMsg.Get("Admin_BillSettlement_aspx_03") != null ? SListForAppMsg.Get("Admin_BillSettlement_aspx_03") : "Information";
        var userMsg = SListForAppMsg.Get("Admin_BillSettlement_aspx_01") != null ? SListForAppMsg.Get("Admin_BillSettlement_aspx_01") : "Settlement amount cannot be greater than closing balance amount";
        document.getElementById('txtSettledAmt').value = format_number(document.getElementById('txtSettledAmt').value, 2);
        if (Number($('[id$="txtSettledAmt"]').val()) > Number($('[id$="hdnClosingAmt"]').val())) {
            // var userMsg = SListForApplicationMessages.Get("Admin\\BillSettlement.aspx_4");
            if (userMsg != null) {
                // alert(userMsg);
                ValidationWindow(userMsg, AlrtWinHdr);
                return false;
            }
            else {
                //alert('Settlement amount cannot be greater than closing balance amount');
                ValidationWindow(userMsg, AlrtWinHdr);
                return false;
            }
            $('[id$="txtSettledAmt"]').val("0.00");
            return false;
        }
    }
    function CalcItemValidation(objtxtAllUserSettledAmt, objlblAmtReceived) {
        var AlrtWinHdr = SListForAppMsg.Get("Admin_BillSettlement_aspx_03") != null ? SListForAppMsg.Get("Admin_BillSettlement_aspx_03") : "Information";
        var userMsg = SListForAppMsg.Get("Admin_BillSettlement_aspx_01") != null ? SListForAppMsg.Get("Admin_BillSettlement_aspx_01	") : "Settlement amount cannot be greater than closing balance amount";

        var objtxtAmountValue = document.getElementById(objtxtAllUserSettledAmt).value;
        var objlblAmtReceivedValue = document.getElementById(objlblAmtReceived).innerHTML;
        if (parseFloat(objtxtAmountValue) > parseFloat(objlblAmtReceivedValue)) {
            //var userMsg = SListForApplicationMessages.Get("Admin\\BillSettlement.aspx_5");
            if (userMsg != null) {
                // alert(userMsg);
                ValidationWindow(userMsg, AlrtWinHdr);
                return false;
            }
            else {
                //alert('Settlement amount cannot be greater than Net amount');
                ValidationWindow(userMsg, AlrtWinHdr);
                return false;
            }
            document.getElementById(objtxtAllUserSettledAmt).value = '0.00';
            document.getElementById(objtxtAllUserSettledAmt).focus();
            return false;
        }
    }
     function ValidateDate() {
         var AlrtWinHdr = SListForAppMsg.Get("Reception_BillSettlementIndividual_aspx_alert") != null ? SListForAppMsg.Get("Reception_BillSettlementIndividual_aspx_alert") : "Alert";
         var UsrAlrtMsg3 = SListForAppMsg.Get("Reception_BillSettlementIndividual_aspx_11") != null ? SListForAppMsg.Get("Reception_BillSettlementIndividual_aspx_11") : "Please select valid ToDate!!!";

         if (document.getElementById('txtFromDate1').value != "") {

             var getDate = document.getElementById('<%= txtFromDate1.ClientID %>').value;
             var getDate2 = document.getElementById('<%= txtToDate.ClientID %>').value;
             var Flag = true;
//             if (getDate2.substr(6, 4) >= getDate.substr(6, 4)) {
//                 if (getDate2.substr(3, 2) == getDate.substr(3, 2)) {
//                     if (getDate2.substr(0, 2) >= getDate.substr(0, 2)) {
//                         Flag = false;
//                     }
//                 }
//                 else if (getDate2.substr(3, 2) > getDate.substr(3, 2)) {
//                     Flag = false;
//                 }

             //             }

             if (getDate.substr(6, 4) > getDate2.substr(6, 4)) {
                 Flag = false;
             } else if ((getDate.substr(6, 4) == getDate2.substr(6, 4)) && (getDate.substr(3, 2) > getDate2.substr(3, 2))) {
                 Flag = false;
             } else if ((getDate.substr(3, 2) == getDate2.substr(3, 2)) && (getDate.substr(0, 2) > getDate2.substr(0, 2))) {
                 Flag = false;
             }
             if (Flag == false) {
                 ValidationWindow(UsrAlrtMsg3, AlrtWinHdr);
                 document.getElementById('txtToDate').value = new Date().format('dd/MM/yyyy');
             }
         }
         return Flag;
     }
    </script>