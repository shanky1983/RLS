<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TextualPattern.ascx.cs"
    Inherits="Investigation_TextualPattern" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="FCKeditorV2" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajc" %>
<style>
.cke_toolbox_main 
{
	overflow:hidden;
	float:left!important;
}
    </style>
<script type="text/javascript" language="javascript">
    function ValidateUpload(id) {
        // alert(id);
        var Upload_Image = document.getElementById(id);
        var myfile = Upload_Image.value;
        //alert(Upload_Image.value);
        if (myfile.indexOf("jpg") > 0 || myfile.indexOf("jpeg") > 0 || myfile.indexOf("Jpeg") > 0 || myfile.indexOf("JPG") > 0) {

        }
        else {
            alert('Invalid File');
        }
    }
    function FCKeditor_OnComplete(editorInstance) {
        try {
            editorInstance.Events.AttachEvent('OnBlur', FCKeditor_OnBlur);
        }
        catch (e) {
        }
    }

    function FCKeditor_OnBlur(editorInstance) {
        try {
            var content = editorInstance.GetHTML();
            if (content != "" && content != "<br />" && content != "<br/>") {
                var editorName = editorInstance.Name;
                prefix = editorName.split('_');
                setCompletedStatus(document.getElementById(prefix[0] + "_hdnGroupName").value, document.getElementById(prefix[0] + "_hdnDDLStatus").value);
            }
        }
        catch (e) {
        }
    }
    
    $(document).ready(function() {
       
        setInterval(function() {
            if (($("#hdnAutoSave").val()) == "Y") {
                if (($("#hdnRoleName").val()) == "Lab Technician" || ($("#hdnRoleName").val()) == "SrLabTech" || ($("#hdnRoleName").val()) == "Doctor" || ($("#hdnRoleName").val()) == "Office Assistant") {
                    fnSaveAsDraftstext();
                }
            }
        }, 50000);


    });
    function fnSaveAsDraftstext() {
    var visitid = $('[ID*=hdnPatientVisitID]').val();
    var loginid = $('[ID*=hdnloginid]').val() == undefined ? '<%=LID %>' : $('[ID*=hdnloginid]').val();
        var orgid = $('[ID=hdnOrgID]').val();
        var LstInvValues = [];
        var lstpatientinv = [];
        var commonstatus = "Pending";
        if (visitid != 0 && visitid != "") {

            if (($("#hdnRoleName").val()) == "Lab Technician" || ($("#hdnRoleName").val()) == "Office Assistant") {
                commonstatus = "Pending";
            }
            else {
                if (($("#hdnDeptwiseLoginRole").val()) == "Y") {
                    if (($("#hdnRoleName").val()) == "Doctor") {
                        commonstatus = "Completed";
                    }
                }
                else {
                    if (($("#hdnRoleName").val()) == "SrLabTech") {
                        commonstatus = "Completed";
                    }
                    else if (($("#hdnRoleName").val()) == "Doctor") {
                        commonstatus = "Validate";
                    }
                }
            }
            var ControlID = $('[ID*=lblName]');
            var ckcontrol = $('[ID*=fckInvDetails]');
//            var InvID = '<%=ControlID %>';
//            var InvName = $('[ID*=lblName]').text();
//            var Value = $('[ID*=fckInvDetails]').val(); 
//            var GroupID = '<%=GroupID %>';
//            var GroupName = '<%=GroupName %>';
            if(ckcontrol.length>0)
            {
            var InvID;
            var InvName;
            var Value;
            var GroupID;
            var GroupName;
            for (var i = 0; i < ckcontrol.length; i++) {
                if (ControlID[i] != null && ckcontrol[i].value != '')
               {
                   InvID = ControlID[i].id.split("~")[0];
                   InvName = ControlID[i].innerHTML;
                   var c = ControlID[0].id.split('_')[0] + '_fckInvDetails';
                   Value = document.getElementById(c).innerText;
                 GroupID = '<%=GroupID %>'; //ckcontrol[i].name.split("~")[0];
                 GroupName = '<%=GroupName %>'; //ckcontrol[i].name.split("~")[0];
                 LstInvValues.push({
                     InvestigationID: InvID,
                     Name: InvName,
                     Value: Value,
                     PatientVisitID: visitid,
                     CreatedBy: loginid,
                     GroupName: GroupName,
                     GroupID: GroupID,
                     Orgid: orgid,
                     Status: commonstatus,
                     PackageID: 0,
                     PackageName: null,
                     SequenceNo: 0
                 });
                 lstpatientinv.push({
                     InvestigationID: InvID,
                     PatientVisitID: visitid,
                     GroupName: GroupName,
                     GroupID: GroupID,
                     Orgid: orgid, //OrgID;
                     Status: commonstatus,
                     Reason: null,
                     MedicalRemarks: null,
                     RemarksID: 0
                 });
               }
             }
            }
            
            var lstinvvalue = [];
            lstinvvalue.push(LstInvValues);
            var vdata = {};
            vdata.LstinvValues = lstinvvalue;
            vdata.lstPatientInvs = lstpatientinv;
            vdata.vid = visitid;
            vdata.guid = $('[ID*=hdnguid]').val();
            vdata.orgid = orgid;
            if (vdata.lstPatientInvs.length > 0) {
                if (($("#hdnRoleName").val()) == "Lab Technician") {
                    $.ajax({
                        type: "POST",
                        url: "InvestigationResultsCapture.aspx/AutoSaveHisto",
                        data: JSON.stringify(vdata),
                        contentType: "application/json; charset=utf-8",
                        dataType: "json",
                        async: true,
                        success: function Success(data) {
                        },
                        error: function(jqXHR, textStatus, errorThrown) {
                            alert(errorThrown);
                        }
                    });
                }
                else {
                    $.ajax({
                        type: "POST",
                        url: "InvestigationApprovel.aspx/AutoSaveHisto",
                        data: JSON.stringify(vdata),
                        contentType: "application/json; charset=utf-8",
                        dataType: "json",
                        async: true,
                        success: function Success(data) {
                        },
                        error: function(jqXHR, textStatus, errorThrown) {
                            alert(errorThrown);
                        }
                    });
                }
            }
        }
    }
</script>
<asp:UpdatePanel ID="UpdatePanel102" runat="server" UpdateMode="Conditional">
<Triggers>
                <asp:AsyncPostBackTrigger ControlID="btnGo" EventName="Click"/> 
            </Triggers>
            <ContentTemplate>
                <asp:UpdateProgress ID="Progressbar1" AssociatedUpdatePanelID="UpdatePanel102" runat="server">
                    <ProgressTemplate>
                        <div id="progressBackgroundFilter" class="a-center">
                        </div>
                        <div id="processMessage" class="a-center w-20p">
                            <asp:Image ID="imgProgressbar1" Width="40px" Height="40px" runat="server" ImageUrl="../Images/loading.GIF"
                                meta:resourcekey="img1Resource1" />
                        </div>
                    </ProgressTemplate>
                </asp:UpdateProgress>

<table border="0" width="100%" cellpadding="0" cellspacing="0">
    <tr>
        <td colspan="4">
            <table class="w-100p">
                <tr align="center">
                    <td style="font-weight: normal; font-size: 11px; color: #000; width: 15%;" align="left">
                        <asp:Label runat="server" ID="lblTemplate" Text="Select Template From the List" 
                            meta:resourcekey="lblTemplateResource1"></asp:Label>
                    </td>
                    <td style="font-weight: normal; font-size: 11px; color: #000; width: 2%;" align="left">
                        <asp:DropDownList ForeColor="Black" Width="192px" ID="ddlInvResultTemplate" CssClass="ddlsmall"
                            runat="server" EnableViewState="true" Height="22px"  meta:resourcekey="ddlInvResultTemplateResource1">
                        </asp:DropDownList>
                    </td>
                    <td align="left" style="font-weight: normal; font-size: 11px; color: #000; width: 22%">
                        <asp:Button ID="btnGo" runat="server" Text="Load Template" CssClass="btn" onmouseover="this.className='btn btnhov'"
                            onmouseout="this.className='btn'" OnClick="btnGo_Click" 
                            meta:resourcekey="btnGoResource1"/>
                    </td>
                    <td align="left" style="font-weight: normal; font-size: 11px; color: #000; width: 35%">
                        &nbsp;
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td class="font11 v-top" style="font-weight: normal; color: #000;">
            <asp:Label runat="server" ID="lblName" 
                onclick="javascript:changeTestName(this.id);" 
                meta:resourcekey="lblNameResource1"></asp:Label>
            &nbsp;
            <asp:LinkButton ID="lnkEdit" runat="server" Text="Edit" Visible="False" OnClick="lnkEdit_Click"
                ForeColor="Red" meta:resourcekey="lnkEditResource1"></asp:LinkButton>
            <asp:HiddenField ID="hdnReadonly" runat="server" Value="False" />
            <a id="ATag" runat="server" onclick="lnkEdit_OnClientClick(this.id);" style="color: red;"
                visible="false"><u><%=Resources.Investigation_ClientDisplay.Investigation_CultureandSensitivityReport_aspx_08 %></u></a>
        </td>
        <td class="font11" style="font-weight: normal; color: #000;">
            <asp:Panel ID="pnlenb" runat="server" BorderWidth="0"  Enabled="true" meta:resourcekey="pnlenbResource1">
                <FCKeditorV2:CKEditorControl ID="fckInvDetails"  runat="server" Width="950" Height="280px" meta:resourcekey="fckInvDetailsResource1">
                </FCKeditorV2:CKEditorControl>
            </asp:Panel>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <table>
                <tr>
                    <td class="font11" style="font-weight: normal; color: #000;">
                        <asp:Label runat="server" ID="Label1" Text="Status" 
                            meta:resourcekey="Label1Resource1"></asp:Label>
                    </td>
                    <td>
                        <table>
                            <tr>
                                <td>
                                    &nbsp;
                                </td>
                                <td class="font10 h-10" style="font-weight: normal; color: #000;">
                                    <table id="tdInvStatusReason1" runat="server" style="display: none;">
                                        <tr>
                                            <td>
                                                <asp:Label ID="lblReason" Text="Reason" runat="server" 
                                                    meta:resourcekey="lblReasonResource1"></asp:Label>
                                            </td>
                                        </tr>
                                    </table>
                                    <table id="tdInvStatusOpinion1" runat="server" style="display: none;">
                                        <tr>
                                            <td>
                                                <asp:Label ID="lblOpinionUser" runat="server" Text="User" 
                                                    meta:resourcekey="lblOpinionUserResource1" />
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:DropDownList ForeColor="Black" ID="ddlstatus" runat="server" TabIndex="-1" CssClass="ddlsmall"
                                        onChange="javascript:ShowStatusReason(this.id);" meta:resourcekey="ddlstatusResource1">
                                        <asp:ListItem Text="Completed" meta:resourcekey="ListItemResource1"></asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td>
                                    <table id="tdInvStatusReason2" runat="server" style="display: none;">
                                        <tr>
                                            <td>
                                                <asp:DropDownList ForeColor="Black" ID="ddlStatusReason" runat="server" TabIndex="-1"
                                                    CssClass="ddlsmall" onmousedown="expandDropDownList(this);" 
                                                    onblur="collapseDropDownList(this);" 
                                                    meta:resourcekey="ddlStatusReasonResource1">
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                    </table>
                                    <table id="tdInvStatusOpinion2" runat="server" style="display: none;">
                                        <tr>
                                            <td>
                                                <span class="richcombobox" class="w-100">
                                                    <asp:DropDownList ForeColor="Black" ID="ddlOpinionUser" runat="server" TabIndex="-1"
                                                        CssClass="ddlsmall" meta:resourcekey="ddlOpinionUserResource1">
                                                        <asp:ListItem Text="--Select--" meta:resourcekey="OpinionUserListItemResource1"></asp:ListItem>
                                                    </asp:DropDownList>
                                                </span>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <table>
                <tr>
                    <td>
                        <asp:FileUpload ForeColor="Black" Font-Bold="True" ID="flUpload" onchange='javascript:ValidateUpload(this.id);'
                            runat="server" meta:resourcekey="flUploadResource1" />
                    </td>
                    <td>
                        <asp:FileUpload ForeColor="Black" Font-Bold="True" ID="flUpload1" onchange='javascript:ValidateUpload(this.id);'
                            runat="server" meta:resourcekey="flUpload1Resource1" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:FileUpload ForeColor="Black" Font-Bold="True" ID="flUpload2" onchange='javascript:ValidateUpload(this.id);'
                            runat="server" meta:resourcekey="flUpload2Resource1" />
                    </td>
                    <td>
                        <asp:FileUpload ForeColor="Black" Font-Bold="True" ID="flUpload3" onchange='javascript:ValidateUpload(this.id);'
                            runat="server" meta:resourcekey="flUpload3Resource1" />
                    </td>
                </tr>
            </table>
        </td>
        <td colspan="2">
            <div id="TRFimage" style="display: none;">
                <asp:FileUpload ID="FileUpload1" runat="server" class="multi"  accept="gif|GIF|jpg|JPG|png|PNG|bmp|BMP|jpeg|JPEG|pdf|PDF"   meta:resourcekey="FileUpload1Resource1" />
            </div>
        </td>
    </tr>
    <asp:HiddenField runat="server" ID="hidVal" />
</table>
</ContentTemplate>

</asp:UpdatePanel>
<input id="hdnOpinionUser" runat="server" type="hidden" value="" />
<input id="hdnGroupName" runat="server" type="hidden" value="" />
<input id="hdnDDLStatus" runat="server" type="hidden" value="" />
<asp:HiddenField ID="hdnAccessionNumber" runat="server" Value="" />
<style type="text/css">
    body
    {
        font: normal 12px auto "Trebuchet MS" , Verdana;
        background-color: #ffffff;
        color: #4f6b72;
    }
    .style1
    {
        width: 10%;
        height: 65px;
    }
    .style2
    {
        height: 65px;
    }
</style>
