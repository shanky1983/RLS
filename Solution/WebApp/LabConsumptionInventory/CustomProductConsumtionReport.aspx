<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomProductConsumtionReport.aspx.cs"
    Inherits="LabConsumptionInventory_CustomProductConsumtionReport" meta:resourcekey="PageResource1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Product Consumtion Report</title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="True">
    </asp:ScriptManager>
    <Attune:Attuneheader ID="Attuneheader" runat="server" />
    <div class="contentdata">
        <div id="pendingProgress" style="display: none;">
            <div id="progressBackgroundFilter" class="a-center">
            </div>
            <div id="processMessage" class="a-center w-20p">
                <asp:Image ID="imgProgressbar" runat="server" ImageUrl="../PlatForm/Images/loaderNew.GIF"
                    meta:resourcekey="imgProgressbarResource1" />
            </div>
        </div>
  <script language="javascript" type="text/javascript">

        $(document).ready(function() {     


            $("#txtbarcode").autocomplete({
                minLength: 2,
                open: function() { $($('.ui-autocomplete')).css('width', '300px'); },
                source: function(request, response) {
                    var param = { prefixText: $('#txtbarcode').val(), strOrgID: $("#hdnOrgid").val() ,ActionType :"Reports" };

                    $.ajax({
                        url: "../LabConsumptionInventory/WebServices/LabConsumptionInventory.asmx/GetBarCodeJSON",
                        data: JSON.stringify(param),
                        dataType: "json",
                        type: "POST",
                        contentType: "application/json; charset=utf-8",

                        success: function(data) {
                        var lstProductCollection  = [];
                        lstProductCollection = JSON.parse(data.d);

                          response($.map(lstProductCollection, function(item) {
                              return {
                                    label: item.BarcodeNo +" - "+item.ProductName,
                                    value: item.BarcodeNo,
                                    pValue: item

                                }
                             }))

                        },
                        error: function(XMLHttpRequest, textStatus, errorThrown) {
                            var err = eval("(" + XMLHttpRequest.responseText + ")");
 
                        }
                    });
                },
                select: function(e, i) {
                           $("#txtbarcode").val(i.item.pValue.BarcodeNo +" - "+i.item.pValue.ProductName);
                    $("#hdnProductID").val(i.item.pValue.ProductID);
                    $("#hdnBarCode").val(i.item.pValue.BarcodeNo);


                    return false;
                }
            });
            
            
            
              $("#txtTestName").autocomplete({
                    minLength: 2,
                    autoFocus: true,
					open: function() {$($('.ui-autocomplete')).css('width','300px');},
                    source: function(request, response) {
                        var param = { prefixText: $('#txtTestName').val(),strOrgID:$("#hdnOrgid").val(),DeviceID:$("#ddlAnalyzerName option:selected").val(),PageType:"Report"};
                        
                        
                        $.ajax({
                            url: "../LabConsumptionInventory/WebServices/LabConsumptionInventory.asmx/GetInvestigationList",
                            data: JSON.stringify(param),
                            dataType: "json",
                            type: "POST",
                            contentType: "application/json; charset=utf-8",

                            success: function(data) {
                                response($.map(data.d, function(item) {
                                    return {
                                        label: item.split('^')[0],
                                        value: item.split('^')[0],
										Tval: item.split('^')[1]

                                    }
                                }))
                            },
                            error: function(XMLHttpRequest, textStatus, errorThrown) {
                                var err = eval("(" + XMLHttpRequest.responseText + ")");
                                //alert(err.Message)
                                //console.log("Ajax Error!"); 
                                
                            }
                        });
                    },
                    select: function(e, i) {                    
                        $("#txtTestName").val(i.item.label);
                        $("#hdnInvestigationID").val(i.item.Tval);     
                        //alert( $("#hdnInvestigationID").val());               
                        return false;
                    }
                });
        
        });


     

        function callWebservices() {

            //var Barcode = document.getElementById('txtbarcode').value;
            //var ProductName = document.getElementById('txtProductName').value;

            var frm = document.getElementById('txtFrom').value;
            var to = document.getElementById('txtTo').value;
            var today = "";
            var today1 = "";
            if (frm.indexOf('-') > 0) {
                today = document.getElementById('txtFrom').value.split(' ')[0].split('-');
            }
            else {
                today = document.getElementById('txtFrom').value.split(' ')[0].split('/');
            }


            var dd = today[0];
            var mm = today[1];
            var yyyy = today[2];
            var pFromDate = mm + '/' + dd + '/' + yyyy; //+ ' ' + ftime;
            if (to.indexOf('-') > 0) {
                today1 = document.getElementById('txtTo').value.split(' ')[0].split('-');
            }
            else {
                today1 = document.getElementById('txtTo').value.split(' ')[0].split('/');
            }


            var dd1 = today1[0];
            var mm1 = today1[1];
            var yyyy1 = today1[2];
            var pToDate = mm1 + '/' + dd1 + '/' + yyyy1; //+ ' ' + ttime;
                      $.ajax({
                                type: "POST",
                                url: "../LabConsumptionInventory/CustomProductConsumtionReport.aspx/GetCustomConsumptionProductReport",
                                contentType: "application/json;charset=utf-8",
                                data: "{'strOrgid':'"+$("#hdnOrgid").val()+"','Barcode':'" + $("#hdnBarCode").val() + "','Deviceid':'"+ $("#ddlAnalyzerName :selected").val()+"','fromdate':'" + pFromDate + "','todate':'" + pToDate + "','StrLocationid':'" + $('#ddlLocation :selected').val() + "','deptid':'" + $('#ddlLabDepartment :selected').val() + "','investigationID':'" + $('#ddlLabDepartment :selected').val() + "'}", 
                                
                                dataType: "json",
                                async: true,
                                success: AjaxGetFieldData,
                                error: function(xhr, ajaxOptions, thrownError) {
                                    alert("Error");
                                    $('#ProductConsumption').hide();
                                  
                                    //pop.hide();
                                    return false;
                                }
                            });
                            //pop.hide();
                            $('#ProductConsumption').show();
            return false;
        }
        
         function AjaxGetFieldData(result) {

           var RowSpan =true; var RowSpancount=1;
            try {
                var SerialNumber =0;
                var pop = $("#mdlPopup");
         
                var DTD = [];
                if (result != "[]") {
                    
                    $.each(result.d, function(i, obj) {
                                                
                        SerialNumber++;
              
                        Tbl_tr = $('<tr/>');                        
                            var tdSerialNumber = $('<td/>').html(SerialNumber);
                            var tdIDNumber = $('<td/>').html(this.IDNumber );
                            var tdProductCode = $('<td/>').html(this.ProductCode);
                            var tdInvestigationName = $('<td/>').html(this.InvestigationName );
                            var tdMachineName = $('<td/>').html(this.MachineName);
                            var tdProductUsageCount = $('<td/>').html(this.ProductUsageCount);                            
                            var tdDateOpen = $('<td/>').html(new Date(this.DateOpen.match(/\d+/)[0] * 1).toLocaleDateString());
                            var tdDateClosed = $('<td/>').html(new Date(this.DateClosed.match(/\d+/)[0] * 1).toLocaleDateString() );   
                            var tdDeviceTest = $('<td/>').html(this.DeviceTests);
                            var tdCalibration = $('<td/>').html(this.Calibration); 
                            var tdQCControl = $('<td/>').html(this.QCControl); 
                            var tdRerun = $('<td/>').html(this.Rerun);                      
                            var tdOther = $('<td/>').html(this.Other);     
                            var tdTotalTests = $('<td/>').html(this.TotalTests); 
                            var tdVarianceCount = $('<td/>').html(this.VarianceCount);                         

                         Tbl_tr.append(tdSerialNumber).append(tdIDNumber).append(tdProductCode).append(tdInvestigationName).append(tdMachineName).append(tdProductUsageCount).append(tdDateOpen).append(tdDateClosed).append(tdDeviceTest).append(tdCalibration).append(tdQCControl).append(tdRerun).append(tdOther).append(tdTotalTests).append(tdVarianceCount);
                        $('[id$="ProductConsumption"] tbody').append(Tbl_tr);

                  });

                    $('#ProductConsumption').dataTable({
                        "bDestroy": true,
                        "bProcessing": true,
                        "bPaginate": true,
                        "bFooter": true,
                        "bDeferRender": false,
                        "bSortable": false,                      
                        "bJQueryUI": true,
                       // "aaData": DTD,
                        'bSort': false,
                        'bFilter': false,         
                        'sPaginationType': 'full_numbers',
                        //"fnStandingRedraw": function() { pop.show(); },
                        "sDom": '<"H"Tfr>t<"F"ip>',
                        "oTableTools": {
                            "sSwfPath": "../PlatForm/Scripts/DataTable/Media/copy_csv_xls_pdf.swf",
                            "aButtons": [

                                              {
                                                  "sExtends": "xls",
                                                  "sFileName": "ProductConsumption.xls",
                                                  "bFooter": true

                                              },

                                                {
                                                    "sExtends": "csv",
                                                    "sFileName": "ProductConsumption.csv",
                                                    "bFooter": true

                                                },
                                                    {
                                                        "sExtends": "pdf",
                                                        "sFileName": "ProductConsumption.pdf",
                                                        "bFooter": true

                                                    },
                                      


                                          ]
                             },

                    });                                       
                              

                    $('#ProductConsumption').show();
                    $("#pendingProgress").hide();
                    pop.hide();
                }
            }
            catch (e) {
                alert('Exception while binding Data');
            }
            return false;
        }
        </script>

        <table align="center" class="w-100p h-50">
            <tr>
                <td align="left">
                    <asp:Label ID="Labelfrmdt" runat="server" Text="From Date" meta:resourcekey="LabelfrmdtResource1"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtFrom" runat="server" CssClass="small datePickerPres" Width="130px"
                        onkeypress="return ValidateSpecialAndNumeric(this);" TabIndex="1" meta:resourcekey="txtFromResource1" />
                        <img src="../PlatForm/Images/starbutton.png" alt="" class="a-center" />
                </td>
                <td align="left">
                    <asp:Label ID="LabelTodt" runat="server" Text="To Date " meta:resourcekey="LabelTodtResource1"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtTo" runat="server" CssClass="small datePickerPres" Width="130px"
                        onkeypress="return ValidateSpecialAndNumeric(this);" TabIndex="2" meta:resourcekey="txtToResource1" />
                        <img src="../PlatForm/Images/starbutton.png" alt="" class="a-center" />
                </td>
                     
                <td>
                    <asp:Label ID="lblInvLocation" runat="server" Text="Location"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlLocation" runat="server" CssClass="medium">
                    </asp:DropDownList>
                    
                </td>     
                
                <td>
                    <asp:Label ID="lblDepartment" runat="server" Text="Department"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlLabDepartment" runat="server" CssClass="medium">
                    </asp:DropDownList>
                    
                </td>      
            </tr>
            <tr>              
                
                
                <td>
                    <asp:Label ID="lblDevicesName" runat="server" Text="Device Name" meta:resourcekey="lblDevicesNameResource1"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlAnalyzerName" runat="server" CssClass="medium" meta:resourcekey="ddlAnalyzerNameResource1">
                    </asp:DropDownList>
                    
                </td>
        
                <td>
                    <asp:Label ID="lblTestNames" Text="TestName" runat="server"></asp:Label>
                </td>
                
                <td>
                    <asp:TextBox ID="txtTestName" runat="server"></asp:TextBox>
                </td>
                          <td>
                    <asp:Label ID="lblscanbarcode" Text="Barcode" runat="server" meta:resourcekey="lblscanbarcodeResource1"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtbarcode" runat="server" meta:resourcekey="txtbarcodeResource1"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnsearch" runat="server" Text="Search" CssClass="btn" OnClientClick="javascript:return GetData();"
                        meta:resourcekey="btnsearchResource1" OnClick="btnsearch_Click" />
                </td>
            </tr>
            
        </table>
        <br />
        <br />
        <div id="Divshow" runat="server" class="o-auto w-100p-datatable">
            <table id="ProductConsumption" class="responstable w-100p" style="display: none">
                <thead align="left" class="nowrap-wordTh">
                    <tr>
                        <th>
                            <asp:Label ID="lblSNO" runat="server" Text="S.No" meta:resourcekey="lblSNOResource1" />
                        </th>
                        <th>
                            <asp:Label ID="lblIDNumber" runat="server" Text="LOT" meta:resourcekey="lblIDNumberResource1" />
                        </th>                        
                        <th>
                            <asp:Label ID="lblTestCode" runat="server" Text="Code" meta:resourcekey="lblTestCodeResource1" />
                        </th>
                        <th>
                            <asp:Label ID="lblTestname" runat="server" Text="Test Name" meta:resourcekey="lblSTestnameResource1" />
                        </th>
                        <th>
                            <asp:Label ID="lblMachineName" runat="server" Text="Machine Name" meta:resourcekey="lblMachineNameResource1" />
                        </th>
                         <th>
                            <asp:Label ID="lblProductUsageCount" runat="server" Text="Packaging" meta:resourcekey="lblProductUsageCountResource1" />
                        </th>
                        <th>
                            <asp:Label ID="lblDateOpen" runat="server" Text="Date Open" meta:resourcekey="lblDateOpenResource1" />
                        </th>
                        <th>
                            <asp:Label ID="lblDateClosedCount" runat="server" Text="Date Closed" meta:resourcekey="lblDateClosedResource1" />
                        </th>
                        
                        <th>
                            <asp:Label ID="lblCountTests" runat="server" Text="Tests" meta:resourcekey="lblCountTestsResource1" />
                        </th>
                        <th>
                            <asp:Label ID="lblCalibration" runat="server" Text="Calibration" meta:resourcekey="lblCalibrationResource1" />
                        </th>
                        <th>
                            <asp:Label ID="lblQCControl" runat="server" Text="QC" meta:resourcekey="lblQCControl" />
                        </th>
                        <th>
                            <asp:Label ID="lblRerun" runat="server" Text="Rerun" meta:resourcekey="lblRerun" />
                        </th>
                        <th>
                            <asp:Label ID="lblOther" runat="server" Text="Others" meta:resourcekey="lblOtherResource1" />
                        </th>
                        <th>
                            <asp:Label ID="lblTotalTests" runat="server" Text="TotalTests" meta:resourcekey="lblTotalTests" />
                        </th>
                        <th>
                            <asp:Label ID="lblDifferentTestinLIS" runat="server" Text="Variance b/w Packaging and actual tests" meta:resourcekey="lblNoofTestinLISResource1" />
                        </th>
                    </tr>
                </thead>
                <tbody id="tbodyProductConsumption">
                </tbody>
            </table>
            
            
            <asp:HiddenField ID="hdnInvestigationID" runat="server" Value="0" />            
            <asp:HiddenField ID="hdnBarCode" runat="server" Value="0" />
            <asp:HiddenField ID="hdnProductID" runat="server" Value="0" />
            <asp:HiddenField ID="hdnOrgid" runat="server" />
        </div>
    </div>
    <Attune:Attunefooter ID="Attunefooter" runat="server" />
    </form>
    <style>
        .w-100p-datatable
        {
            width: 1360px;
            overflow: auto;
        }
        #ProductConsumption_info
        {
            display: none;
        }
        .nowrap-wordTh tr > th
        {
            word-break: break-word !important;
        }
    </style>

    <script src="../PlatForm/Scripts/DataTable/jquery.dataTables.js" type="text/javascript"></script>

    <script src="../PlatForm/Scripts/DataTable/TableTools.min.js" type="text/javascript"></script>

    <script src="../PlatForm/Scripts/DataTable/ZeroClipboard.js" type="text/javascript"></script>

    <link href="../PlatForm/Scripts/DataTable/css/dataTables.tableTools.css" rel="stylesheet"
        type="text/css" />
    <link href="../PlatForm/StyleSheets/DataTable/jquery.dataTables.css" rel="stylesheet"
        type="text/css" />
    <link href="../PlatForm/StyleSheets/DataTable/demo_table_jui.css" rel="stylesheet"
        type="text/css" />

  

    <script language="javascript" type="text/javascript">
        function GetData() {
            try {             
                
    
        $("#tbodyProductConsumption").empty();
        
        
                var pop = $("#mdlPopup");
                $("#pendingProgress").show();
                pop.show();
                if (document.getElementById('txtFrom').value == '') {
                    alert('Select From Date');
                    return false;
                }
                if (document.getElementById('txtTo').value == '') {
                    alert('select To Date');
                    return false;
                }
                


               
            }
            catch (e) {
                pop.hide();
            }
           
        }


//        function Productkeypress() {
//            $("#hdnProductID").val('0');
//            return false;
//        }
//        function ProductOnchange() {
//            if ($("#hdnProductID").val() == '0') {
//                $("#txtProductName").val('');
//            }
//            if ($.trim($("#txtProductName").val()) == "") {
//                $("#hdnProductID").val('0')
//            }
//            return false;
//        }
    
    </script>

</body>
</html>
