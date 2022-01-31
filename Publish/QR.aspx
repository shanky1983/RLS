<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QR.aspx.cs" Inherits="QRCode._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head><title>

</title><meta charset="utf-8" /><meta http-equiv="X-UA-Compatible" content="IE=edge" /><meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no" /><meta name="format-detection" content="telephone=no" />
    <script src="Scripts/LoginJS/modernizr-2.6.2.min.js" type="text/javascript"></script>
    <script src="Scripts/LoginJS/jquery-1.11.1.min.js" type="text/javascript"></script>
    <script src="Scripts/LoginJS/owl.carousel.js"></script>
    <link rel="stylesheet" href="Styles/LoginCSS/owl.carousel.css" /><link rel="stylesheet" href="Styles/LoginCSS/owl.theme.css" /><link href="Styles/LoginCSS/normalize.css" rel="stylesheet" type="text/css" /><link href="Styles/LoginCSS/master.css" rel="stylesheet" type="text/css" /><link href="Styles/Common.css" rel="stylesheet" type="text/css" />
    <!-- responsive table -->
    <link href="Styles/LoginCSS/table.css" rel="stylesheet" type="text/css" />
    <script src="Scripts/LoginJS/table.js" type="text/javascript"></script>
    <link href="Styles/LoginCSS/media-queries.css" rel="stylesheet" type="text/css" />
    <script src="Scripts/KeypressValidation.js" type="text/javascript"></script>
    <script src="Scripts/InputValidation.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
     <div class="header">
            <div class="logoarea">
                <div class="logo">
                    <img src="Images/Login/ril-logo.jpg">
                </div>
               <%-- <div class="portalname">
                    Attune Technology
                </div>--%>
            </div>
          <%--  <div class="headerright">
                <div class="helpdesk">
                    <p>
                        <strong>Helpdesk Number</strong><p>
                            <p>
                                6767 8279 / 8291 / 8298
                            </p>
                </div>
                <div class="helpdeskicon">
                    <img src="Images/Login/helpline-icon.jpg">
                </div> 
                
            </div>--%>
            <div class="headerright">
                <div class="logo">
                    <img src="Images/Login/RLS.jpg">
                </div>
                </div>

        </div>
        <div runat="server" id="divDetails" visible="false">
            <table width="100%">
                <tr>
                    <td align="center">
                        <table>
                            <tr>
                                <td align="center" class="MainTitle">
                                    <asp:Label id="lblPageHeading">Patient Details</span>
                                </td>
                            </tr>
                            <tr id="TrPatientDetails">
	<td align="left">
                                    <table>
                                        <tr>
                                            <td align="left" class="LabelHeaderstyle">Accession Number</td> 
                                            <td class="Labelstyle">: </td>
                                            <td align="left">
                                            <asp:Label  id="lblAccessionNo" runat="server" class="Labelstyle"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="left" class="LabelHeaderstyle">Name Of Patient</td>
                                            <td class="Labelstyle">: </td>
                                            <td align="left">
                                            <asp:Label  id="lblPatientName" runat="server" class="Labelstyle"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr runat="server" visible="false">
                                            <td align="left" class="LabelHeaderstyle">Age</td>
                                            <td class="Labelstyle">: </td>
                                            <td align="left">
                                            <asp:Label  id="lblAge" runat="server" class="Labelstyle"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr  runat="server" visible="false">
                                            <td align="left" class="LabelHeaderstyle">Sex</td>
                                            <td class="Labelstyle">: </td>
                                            <td align="left">
                                            <asp:Label  id="lblSex" runat="server" class="Labelstyle"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr runat="server" visible="false">
                                            <td align="left" class="LabelHeaderstyle">Reason for Referral</td>
                                            <td class="Labelstyle">: </td>
                                            <td align="left">
                                            <asp:Label  id="lblReasonforReferral" runat="server" class="Labelstyle"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr runat="server" visible="false">
                                            <td align="left" class="LabelHeaderstyle">Referred By</td>
                                            <td class="Labelstyle">: </td>
                                            <td align="left">
                                            <asp:Label  id="lblReferredBy" runat="server" class="Labelstyle"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="left" class="LabelHeaderstyle">Collection center</td>
                                            <td class="Labelstyle">: </td>
                                            <td align="left">
                                            <asp:Label  id="lblCollectionCenter" runat="server" class="Labelstyle"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="left" class="LabelHeaderstyle">Date of Collection</td>
                                            <td class="Labelstyle">: </td>
                                            <td align="left">
                                            <asp:Label  id="lblDateofCollection" runat="server" class="Labelstyle"></asp:Label>
                                                
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="left" class="LabelHeaderstyle">Date of Receipt</td>
                                            <td class="Labelstyle">: </td>
                                            <td align="left">
                                            <asp:Label  id="lblDateofReceipt" runat="server" class="Labelstyle"></asp:Label>
                                                
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="left" class="LabelHeaderstyle">Date of Reporting</td>
                                            <td class="Labelstyle">: </td>
                                            <td align="left">
                                            <asp:Label  id="lblDateofReporting" runat="server" class="Labelstyle"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr></tr>
                                    
                                    </table>
                                </td>
                   </tr>
                    <tr> 
                     </tr>

                        </table>
                        <table>
                        <tr><br /> 
                     </tr> 
                         <tr> 
                                        <td align="center" class="footertextname">Thank you for  choosing Reliance MedLab as your health partner.
                                        </td> 
                                        </tr> 
                                        <tr>
                                        <td align="center" class="footertextname">For assistance, please contact us on 1800 890 2444</td>
                                        </tr>
                        </table>
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
