using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Data.SqlClient;
using Attune.Podium.BusinessEntities;
using Attune.Solution.BusinessComponent;
using System.Collections.Generic;
using Attune.Podium.Common;
using System.Xml;
using System.Xml.Linq;

public partial class CommonControls_INVAttributeUsage : BaseControl
{
    List<Attributes> lstAttributes = new List<Attributes>();
    List<ProductAttributes> lstProductAttributes = new List<ProductAttributes>();
    List<AttributeValue> lstTmpAttributeValue = new List<AttributeValue>();
    List<AttributeValue> lstAttributeValue = new List<AttributeValue>();
    DataTable objAttributes = new DataTable();
    DataTable dtUsageAttValues = new DataTable();
    int QuantityCount = 0;
    long pId = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    public void BindProductAttributes(string XmlValues, string strProduct, string actionFlag)
    {
        long retCode = -1;
        try
        {
            hdnActionFlag.Value = actionFlag;
            Literal1.Text = "";

            string[] strProd = strProduct.Split('~');
            DataTable attDT1 = new DataTable();
            DataSet dsXml = new DataSet();
            DataSet dsAttVal = new DataSet();
            gvAttributeValues.Visible = false;
            pId = Int64.Parse(strProd[0]);
            if (strProd[1] != "Assign")
            {
                hdnRcvdQty.Value = hdnQty.Value = strProd[1];
                lblReceivedQty.Text = hdnRcvdQty.Value;
                QuantityCount = int.Parse(hdnQty.Value);
                //ViewState["UsageQtyCount"] = QuantityCount;

            }
            //retCode = invBL.GetAttributes(OrgID, out lstAttributes);
            //if (lstAttributes.Count > 0)
            //{
            //    Utilities.ConvertFrom(lstAttributes, out attDT1);
            //}
            if (XmlValues != "")
            {
                StringReader stream = new StringReader(XmlValues);
                dsXml.ReadXml(stream);
                if (dsXml.Tables.Count > 0)
               {
                    DataTable dtXml = dsXml.Tables[0];
                    Utilities.ConvertTo(dtXml, out lstProductAttributes);

                    DataColumn Id = objAttributes.Columns.Add("UnitNo");
                    DataColumn pid = objAttributes.Columns.Add("ProductId");
                    Id.AutoIncrement = true;
                    Id.AutoIncrementSeed = 1;
                    pid.DefaultValue = pId;
                    hdnMandatoryFields.Value = "";
                    gvAttributes.DataSource = lstProductAttributes;
                    gvAttributes.DataBind();
                    gvAttributes.Visible = true;
                    ViewState["Attributes"] = objAttributes;
                    DataTable dt = new DataTable();
                    dt = objAttributes.Copy();
                    ViewState["dtTemplate"] = dt;
                
                if (actionFlag == "Add" && strProd[2] != "N")
                {
                    StringReader attStream = new StringReader(strProd[2]);
                    dsAttVal.ReadXml(attStream);
                    if (dsAttVal.Tables.Count > 0)
                    {
                        DataTable dtAttXml = dsAttVal.Tables[0];
                        dtAttXml.Columns.Remove("IsIssued");
                        dtAttXml.Columns.Remove("Description");
                        dtAttXml.AcceptChanges();
                        dtAttXml.Columns["UnitNo"].SetOrdinal(0);
                        dtAttXml.Columns["ProductId"].SetOrdinal(1);
                        objAttributes.Merge(dtAttXml, true, MissingSchemaAction.Ignore);
                        ViewState["Attributes"] = objAttributes;


                    }
                }
                if (actionFlag == "Update" && strProd[2] != "N")
                {
                    StringReader attStream = new StringReader(strProd[2]);
                    dsAttVal.ReadXml(attStream);
                    if (dsAttVal.Tables.Count > 0)
                    {
                        DataTable dtAttXml = dsAttVal.Tables[0];
                        dtAttXml.Columns.Remove("IsIssued");
                        dtAttXml.Columns.Remove("Description");
                        dtAttXml.AcceptChanges();
                        dtAttXml.Columns["UnitNo"].SetOrdinal(0);
                        dtAttXml.Columns["ProductId"].SetOrdinal(1);
                        objAttributes.Merge(dtAttXml, true, MissingSchemaAction.Ignore);
                        ViewState["Attributes"] = objAttributes;
                        gvAttributeValues.DataSource = ViewState["Attributes"]; ;
                        gvAttributeValues.DataBind();
                        gvAttributeValues.Visible = true;
                    }
                }
                ModalPopupExtender1.Show();
            }
            }

        }
        catch (Exception ex)
        {
            CLogger.LogError("Error On Binding Product Attribute Values - INVAttributeUsage.ascx", ex);
        }
    }

    public void BindProductAttributes(string XmlValues, string strProduct, string ProductAttrip, string actionFlag)
    {
        long retCode = -1;
        try
        {
            hdnActionFlag.Value = actionFlag;
            string[] strProd = strProduct.Split('~');
            DataTable attDT1 = new DataTable();
             DataSet dsXml = new DataSet();
            DataSet dsAttVal;
            gvAttributeValues.Visible = false;
            pId = Int64.Parse(strProd[0]);
            if (strProd[1] != "Assign")
            {
                hdnRcvdQty.Value = hdnQty.Value = strProd[1];
                lblReceivedQty.Text = hdnRcvdQty.Value;
                QuantityCount = int.Parse(hdnQty.Value);
            }
            //retCode = invBL.GetAttributes(OrgID, out lstAttributes);
            //if (lstAttributes.Count > 0)
            //{
            //    Utilities.ConvertFrom(lstAttributes, out attDT1);
            //}
            if (XmlValues != "")
            {
                StringReader stream = new StringReader(XmlValues);
                dsXml.ReadXml(stream);
                if (dsXml.Tables.Count > 0)
                {
                    DataTable dtXml = dsXml.Tables[0];
                    Utilities.ConvertTo(dtXml, out lstProductAttributes);


                    DataColumn Id = objAttributes.Columns.Add("UnitNo");
                    DataColumn pid = objAttributes.Columns.Add("ProductId");
                    Id.AutoIncrement = true;
                    Id.AutoIncrementSeed = 1;
                    pid.DefaultValue = pId;
                    hdnMandatoryFields.Value = "";
                    gvAttributes.DataSource = lstProductAttributes;
                    gvAttributes.DataBind();
                    gvAttributes.Visible = true;
                    ViewState["Attributes"] = objAttributes;
                    DataTable dt = new DataTable();
                    dt = objAttributes.Copy();
                    ViewState["dtTemplate"] = dt;

                    if (strProd[2] != "N")
                    {

                        StringReader attStream = new StringReader(strProd[2]);
                        dsAttVal = new DataSet();
                        dsAttVal.ReadXml(attStream);
                        if (dsAttVal.Tables.Count > 0)
                        {
                            DataTable dtAttXml = dsAttVal.Tables[0];
                            dtAttXml.Columns.Remove("IsIssued");
                            dtAttXml.Columns.Remove("Description");
                            dtAttXml.AcceptChanges();
                            dtAttXml.Columns["UnitNo"].SetOrdinal(0);
                            dtAttXml.Columns["ProductId"].SetOrdinal(1);
                            objAttributes.Merge(dtAttXml, true, MissingSchemaAction.Ignore);
                            ViewState["Attributes"] = objAttributes;


                        }
                    }
                    if (actionFlag == "Update" && ProductAttrip != "N")
                    {
                        StringReader attStream = new StringReader(ProductAttrip);
                        dsAttVal = new DataSet();
                        dsAttVal.ReadXml(attStream);
                        if (dsAttVal.Tables.Count > 0)
                        {
                            DataTable dtAttXml = dsAttVal.Tables[0];
                            dtAttXml.Columns.Remove("IsIssued");
                            dtAttXml.Columns.Remove("Description");
                            dtAttXml.AcceptChanges();
                            dt.Columns["UnitNo"].SetOrdinal(0);
                            dt.Columns["ProductId"].SetOrdinal(1);
                            dt.Merge(dtAttXml, true, MissingSchemaAction.Ignore);
                            ViewState["UsageAttributes"] = dt;
                            gvAttributeValues.DataSource = ViewState["UsageAttributes"]; ;
                            gvAttributeValues.DataBind();
                            gvAttributeValues.Visible = true;
                        }
                    }
                    hdnQty.Value = QuantityCount.ToString();
                    ModalPopupExtender1.Show();

                }
            }
        }
        catch (Exception ex)
        {
            CLogger.LogError("Error On Binding Product Attribute Values - INVAttributeUsage.ascx", ex);
        }
    }

    private int getRowCount(string strXml)
    {
        int count = 0;
        StringReader attStream = new StringReader(strXml);
        DataSet dsVal = new DataSet();
        dsVal.ReadXml(attStream);
        if (dsVal.Tables.Count > 0)
        {
            count = dsVal.Tables[0].Rows.Count;
        }
        return count;
    }

    private void SetProductAttributes(List<ProductAttributes> lstAttributes)
    {

        TableRow rowH = new TableRow();
        TableCell cellH1 = new TableCell();
        TableCell cellH2 = new TableCell();
        cellH1.Attributes.Add("align", "left");
        cellH1.Text = "Attributes";
        cellH1.Width = Unit.Percentage(10);
        cellH2.Attributes.Add("align", "left");
        cellH2.Text = "Values";
        cellH2.Width = Unit.Percentage(20);
        rowH.Cells.Add(cellH1);
        rowH.Cells.Add(cellH2);
        rowH.Font.Bold = true;
        rowH.Font.Underline = true;
        rowH.Style.Add("color", "#333");
        // tabAttributes.Rows.Add(rowH);
        objAttributes.Columns.Add("UnitNo");
        foreach (ProductAttributes item in lstAttributes)
        {

            TableRow rowC = new TableRow();
            TextBox txtBoxV = new TextBox();
            TableCell cell1 = new TableCell();
            TableCell cell2 = new TableCell();
            TableCell cell3 = new TableCell();

            cell1.Attributes.Add("align", "center");
            cell1.Text = "Name" + item.AttributeName;
            cell1.Width = Unit.Percentage(10);
            cell2.Attributes.Add("align", "left");
            cell2.Width = Unit.Percentage(20);

            txtBoxV.ID = "ID" + item.AttributeID;

            cell2.Controls.Add(txtBoxV);
            cell3.Attributes.Add("align", "left");
            if (item.IsMandatory == "Y")
            {
                cell3.Text = "<img src=\"../Images/starbutton.png\" align=\"middle\" />";
            }
            else
            {
                cell3.Text = "";
            }
            rowC.Cells.Add(cell1);
            rowC.Cells.Add(cell2);
            rowC.Cells.Add(cell3);
            rowC.Style.Add("color", "#000000");


        }
        ViewState["Attributes"] = objAttributes;

    }

    protected void gvAttributes_RowDataBound(Object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            ProductAttributes obj = (ProductAttributes)e.Row.DataItem;
            objAttributes.Columns.Add(obj.AttributeName);
            Image img = (Image)e.Row.FindControl("imgIsMandatory");
            if (obj.IsMandatory == "Y")
            {
                TextBox txtAttributeValues = (TextBox)e.Row.FindControl("txtAttributeValues");
                img.Visible = true;
                hdnMandatoryFields.Value += txtAttributeValues.ClientID + "~";
            }


        }
    }

    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        bool flag = false;
        if (hdnActionFlag.Value == "Update")
        {
            hdnQty.Value = (int.Parse(hdnRcvdQty.Value) - gvAttributeValues.Rows.Count).ToString();
        }
        if (hdnQty.Value != null || hdnQty.Value != "0")
        {
            //QuantityCount = Convert.ToInt64(Convert.ToDecimal(ViewState["UsageQtyCount"]));
            QuantityCount = int.Parse(hdnQty.Value);

        }
        if (QuantityCount > 0)
        {
            //  Literal1.Text = "";
            //  Literal1.Visible = true;
            flag = BindAttributeValues(hdnActionFlag.Value);
            if (flag == true)
            {
                QuantityCount--;
                //ViewState["UsageQtyCount"] = QuantityCount;
                hdnQty.Value = QuantityCount.ToString();

            }

        }
        else
        {
            // hdnQty.Value = ViewState["UsageQtyCount"].ToString();
            hdnQty.Value = QuantityCount.ToString();
            string sPath = "CommonControls\\\\INVAttributeUsage.ascx.cs_1";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "QtyExceed", "ShowAlertMsg('"+sPath +"');", true);
                //ScriptManager.RegisterStartupScript(this, this.GetType(), "QtyExceed", "alert('Product quantity has been exceeded');", true);
            //   Literal1.Text = "You Exceed The Product Quantity";
            //   Literal1.Visible = true;

        }
        dtUsageAttValues = (DataTable)ViewState["UsageAttributes"];
        gvAttributeValues.DataSource = dtUsageAttValues;
        gvAttributeValues.DataBind();
        gvAttributeValues.Visible = true;
        ModalPopupExtender1.Show();

    }

    protected bool BindAttributeValues(string pFlag)
    {
        bool retFlag = false;
        try
        {

            bool exist = false;
            DataTable tempAttributes = new DataTable();
            DataTable dtAttributes = new DataTable();
            if (ViewState["Attributes"] != null)
            {
                objAttributes = (DataTable)ViewState["Attributes"];
                dtAttributes = objAttributes.Copy();
                tempAttributes = (DataTable)ViewState["dtTemplate"];
                if (ViewState["UsageAttributes"] != null)
                {
                    dtUsageAttValues = (DataTable)ViewState["UsageAttributes"];
                }
                else
                {
                    dtUsageAttValues.Merge(objAttributes);
                    dtUsageAttValues.Clear();
                }
            }
            tempAttributes.Clear();
            DataRow dr;
            dr = tempAttributes.NewRow();
            foreach (DataRow item in dtAttributes.Rows)
            {
                foreach (GridViewRow row in gvAttributes.Rows)
                {
                    Label AttributeName = (Label)row.FindControl("lblAttributes");
                    TextBox txtAttributeValues = (TextBox)row.FindControl("txtAttributeValues");
                    HiddenField hdnIsMandatory = (HiddenField)row.FindControl("hdnIsMandatory");
                    HiddenField hdnValues = (HiddenField)row.FindControl("hdnValues");
                    if (item[AttributeName.Text].ToString() == txtAttributeValues.Text)
                    {
                        dr[AttributeName.Text] = txtAttributeValues.Text;

                    }
                }
            }

            tempAttributes.Rows.Add(dr);
            Utilities.ConvertTo(dtAttributes, out lstAttributeValue);
            Utilities.ConvertTo(tempAttributes, out lstTmpAttributeValue);
            if (lstTmpAttributeValue.Count > 0)
            {
                if (lstAttributeValue.Exists(P => P.ProductNo == lstTmpAttributeValue[0].ProductNo && P.SerialNo == lstTmpAttributeValue[0].SerialNo))
                {
                    exist = true;
                }
            }
            if (exist)
            {

                dtUsageAttValues.Columns["UnitNo"].SetOrdinal(0);
                Utilities.ConvertTo(dtUsageAttValues, out lstAttributeValue);
                if (lstAttributeValue.Exists(P => P.ProductNo == lstTmpAttributeValue[0].ProductNo && P.SerialNo == lstTmpAttributeValue[0].SerialNo))
                {
                    string sPath = "CommonControls\\\\INVAttributeUsage.ascx.cs_2";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "MultipleAdd", "ShowAlertMsg('"+sPath +"');", true);
               // ScriptManager.RegisterStartupScript(this, this.GetType(), "MultipleAdd", "alert('Cannot be added multiple times')", true);

                    // Literal1.Text = "Cannot Be Added Multiple Times";
                    // Literal1.Visible = true;
                    retFlag = false;
                }
                else
                {
                    dtUsageAttValues.Merge(tempAttributes, true, MissingSchemaAction.Ignore);
                    ViewState["UsageAttributes"] = dtUsageAttValues;
                    //   Literal1.Text = "Product Detail Exist";
                    //   Literal1.Visible = true;
                    retFlag = true;
                }


            }
            else
            {
                string sPath = "CommonControls\\\\INVAttributeUsage.ascx.cs_3";
                //ScriptManager.RegisterStartupScript(this, this.GetType(), "NotExist", "alert('Product Detail Does not Exist')", true);
                ScriptManager.RegisterStartupScript(this, this.GetType(), "NotExist", "ShowAlertMsg('"+sPath +"');", true);
                //Literal1.Text = "Product Detail Doesn't Exist";
                //Literal1.Visible = true;
                retFlag = false;
            }



            #region
            //DataRow dr,dr1;
            //dr = objAttributes.NewRow();
            //dr1 = dtUsageAttValues.NewRow();
            //foreach (GridViewRow item in gvAttributes.Rows)
            //{
            //    Label AttributeName = (Label)item.FindControl("lblAttributes");
            //    TextBox txtAttributeValues = (TextBox)item.FindControl("txtAttributeValues");
            //    HiddenField hdnIsMandatory = (HiddenField)item.FindControl("hdnIsMandatory");
            //    HiddenField hdnValues = (HiddenField)item.FindControl("hdnValues");
            //    dr[AttributeName.Text] = txtAttributeValues.Text;
            //    dr1[AttributeName.Text] = txtAttributeValues.Text;
            //}
            ////DataRow dr1 = dr;
            //dtUsageAttValues.Columns.Remove("UnitNo");
            //dtUsageAttValues.AcceptChanges();
            //dr1.Table.Columns.Remove("UnitNo");
            //dr1.AcceptChanges();

            //foreach (DataRow itemRow in dtUsageAttValues.Rows)
            //{
            //    itemRow.Equals(dr1);

            //}
            //foreach (DataColumn itemTmpCol in dr1.Table.Columns)
            //{

            //    foreach (DataRow itemRow in dtUsageAttValues.Rows)
            //    {
            //        foreach (DataColumn itemCol in itemRow.Table.Columns)
            //        {
            //            if (itemTmpCol[] == itemCol)
            //            {
            //                exist = true;
            //                break;
            //            }
            //        }
            //        if (exist == true)
            //        {
            //            break;
            //        }
            //    }
            //    if (exist == true)
            //    {
            //        break;
            //    }
            //}      
            // dtUsageAttValues.Rows.Add(dr);
            // Utilities.ConvertTo(dtUsageAttValues,out lstTmpProductAttributes);
            //if (pFlag == "Usage")
            //{

            //    if (exist != true)
            //    {
            //        objAttributes.Rows.Add(dr);
            //    }
            //    else
            //    {
            //        Literal1.Text = "Product Detail Already Exist";
            //        Literal1.Visible = true;
            //    }


            //  if (objAttributes.Rows.Contains(dtUsageAttValues.Rows[0]))
            //if(lstProductAttributes.Exists(P=>P.AttributeName==lstTmpProductAttributes[0].AttributeName && P.AttributeValue==lstTmpProductAttributes[0].AttributeValue))
            //{
            //    Literal1.Text = "Product Detail Already Exist";
            //    Literal1.Visible = true;

            //}
            //else
            //{
            //    lstProductAttributes.Add(lstTmpProductAttributes[0]);
            //    Utilities.ConvertFrom(lstProductAttributes, out objAttributes);
            //}
            //}
            #endregion
        }
        catch (Exception ex)
        {
            CLogger.LogError("Error On Checking Product Attribute Values - INVAttributeUsage.ascx", ex);
            retFlag = false;
        }
        return retFlag;
    }

    protected void gvAttributeValues_RowDataBound(Object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {

        }
    }

    protected void gvAttributeValues_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (ViewState["UsageAttributes"] != null)
        {
            dtUsageAttValues = (DataTable)ViewState["UsageAttributes"];
        }
        if (e.CommandName == "rEdit")
        {
            foreach (DataRow item in dtUsageAttValues.Rows)
            {
                if (item["UnitNo"].ToString() == e.CommandArgument.ToString())
                {
                    break;
                }
            }
        }
        if (e.CommandName == "rDelete")
        {
            if (hdnQty.Value != null)
            {
                //   QuantityCount = Convert.ToInt64(Convert.ToDecimal(ViewState["UsageQtyCount"]));
                QuantityCount = int.Parse(hdnQty.Value);
            }
            foreach (DataRow item in dtUsageAttValues.Rows)
            {
                if (item["UnitNo"].ToString() == e.CommandArgument.ToString())
                {
                    dtUsageAttValues.Rows.Remove(item);
                    QuantityCount++;
                    break;
                }
            }
            //ViewState["UsageQtyCount"] = QuantityCount;
            hdnQty.Value = QuantityCount.ToString();
            dtUsageAttValues.AcceptChanges();
        }
        ViewState["UsageAttributes"] = dtUsageAttValues;
        gvAttributeValues.DataSource = dtUsageAttValues;
        gvAttributeValues.DataBind();
        ModalPopupExtender1.Show();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        try
        {
            string resultEx = string.Empty;
            QuantityCount = int.Parse(hdnQty.Value);
            //if (QuantityCount == 0)
            //{
                //For all quantities have been entered
                if (ViewState["UsageAttributes"] != null)
                {
                    dtUsageAttValues = (DataTable)ViewState["UsageAttributes"];

                    hdnAttValue.Value = getProductAttributeValues(dtUsageAttValues);
                    hdnExAttrip.Value  = getProductExAttributeValues((DataTable)ViewState["Attributes"]);
                     
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "getAttrib", "SetAttrib()", true);

                }
            //}
            //else
            //{

            //    if (ViewState["UsageAttributes"] != null)
            //    {
            //        dtUsageAttValues = (DataTable)ViewState["UsageAttributes"];
            //        hdnAttValue.Value = getProductAttributeValues(dtUsageAttValues);
            //        hdnExAttrip.Value = getProductExAttributeValues((DataTable)ViewState["Attributes"]);
            //        ScriptManager.RegisterStartupScript(this, this.GetType(), "getAttrib", "SetAttrib()", true);
            //    }

            //}
        }
        catch (Exception ex)
        {
            CLogger.LogError("Error On Adding Product Attribute Values - INVAttributeUsage.ascx", ex);
        }
        finally
        {
            ViewState.Remove("UsageAttributes");
        }

    }

    protected void btnClose_Click(object sender, EventArgs e)
    {
        ViewState.Remove("UsageAttributes");
        ViewState.Remove("dtTemplate");
        ViewState.Remove("Attributes");
        ScriptManager.RegisterStartupScript(this, this.GetType(), "getAttrib", "SetAttrib()", true);
        ModalPopupExtender1.Hide();
    }

    public string getProductAttributeValues(DataTable dt)
    {
        string strXml = string.Empty;
        bool pFlag;
        try
        {

            XmlDocument xmlDoc = new XmlDocument();
            XmlNode declaration = xmlDoc.CreateNode(XmlNodeType.XmlDeclaration, null, null);
            xmlDoc.AppendChild(declaration);
            XmlElement root;
            root = xmlDoc.CreateElement("AttributeValues");
            xmlDoc.AppendChild(root);
            int i = 1;

            foreach (DataRow item in dt.Rows)
            {

                pFlag = true;
                XmlElement rootElt = xmlDoc.CreateElement("Units");

                root.AppendChild(rootElt);
                foreach (DataColumn col in item.Table.Columns)
                {
                    if (pFlag == true)
                    {
                        XmlAttribute unitAttrib = xmlDoc.CreateAttribute(col.ColumnName);
                        unitAttrib.Value = i.ToString();
                        rootElt.Attributes.Append(unitAttrib);
                        pFlag = false;
                    }
                    else
                    {
                        XmlAttribute prodAttribute = xmlDoc.CreateAttribute(col.ColumnName);
                        prodAttribute.Value = item[col.ColumnName].ToString();
                        rootElt.Attributes.Append(prodAttribute);
                    }
                }
                i++;
                XmlAttribute IsIssued = xmlDoc.CreateAttribute("IsIssued");
                IsIssued.Value = "Y";
                rootElt.Attributes.Append(IsIssued);

                XmlAttribute Description = xmlDoc.CreateAttribute("Description");
                Description.Value = "";
                rootElt.Attributes.Append(Description);

                root.AppendChild(rootElt);
            }
            strXml = xmlDoc.InnerXml;
        }
        catch (Exception ex)
        {
            return "";
        }
        return strXml;
    }

    public string getProductExAttributeValues(DataTable dt1)
    {
        string strXml = string.Empty;
        bool pFlag;
        try
        {
            DataTable dt  = getExdata(dt1, (DataTable)ViewState["UsageAttributes"]);
            
            dt.Columns["UnitNo"].SetOrdinal(0);
            dt.Columns["ProductId"].SetOrdinal(1);
            dt.Columns["Description"].SetOrdinal(dt.Columns.Count-1);
            dt.Columns["IsIssued"].SetOrdinal(dt.Columns.Count-2);
            

            XmlDocument xmlDoc = new XmlDocument();
            XmlNode declaration = xmlDoc.CreateNode(XmlNodeType.XmlDeclaration, null, null);
            xmlDoc.AppendChild(declaration);
            XmlElement root;
            root = xmlDoc.CreateElement("AttributeValues");
            xmlDoc.AppendChild(root);
            int i = 1;



            foreach (DataRow item in dt.Rows)
            {

                pFlag = true;
                XmlElement rootElt = xmlDoc.CreateElement("Units");

                root.AppendChild(rootElt);
                foreach (DataColumn col in item.Table.Columns)
                {
                    if (pFlag == true)
                    {
                        XmlAttribute unitAttrib = xmlDoc.CreateAttribute(col.ColumnName);
                        unitAttrib.Value = i.ToString();
                        rootElt.Attributes.Append(unitAttrib);
                        pFlag = false;
                    }
                    else
                    {
                        XmlAttribute prodAttribute = xmlDoc.CreateAttribute(col.ColumnName);
                        prodAttribute.Value = item[col.ColumnName].ToString();
                        rootElt.Attributes.Append(prodAttribute);
                    }
                }
                i++;


                //XmlAttribute IsIssued = xmlDoc.CreateAttribute("IsIssued");
                //IsIssued.Value = 
                //rootElt.Attributes.Append(IsIssued);

                //XmlAttribute Description = xmlDoc.CreateAttribute("Description");
                //Description.Value = "";
                //rootElt.Attributes.Append(Description);

                root.AppendChild(rootElt);
            }
            strXml = xmlDoc.InnerXml;
           
        }
        catch (Exception ex)
        {
            return "";
        }
        return strXml;
    }

    private DataTable getExdata(DataTable dt1, DataTable objnew)
    {
        DataTable dt = new DataTable();
        List<AttributeValue> lsttempAttributeValue = new List<AttributeValue>();
        Utilities.ConvertTo(dt1, out lstAttributeValue);
        Utilities.ConvertTo(objnew, out lstTmpAttributeValue);
        
        foreach (AttributeValue item in lstAttributeValue)
        {
          AttributeValue item1 =  lstTmpAttributeValue.Find(p => p.ProductNo == item.ProductNo && p.SerialNo==item.SerialNo);
          if (item1 != null)
          {
              item1.IsIssued = "Y";
              lsttempAttributeValue.Add(item1);
          }
          else
          {

              item.IsIssued = "N";
              lsttempAttributeValue.Add(item);
          }
            
        }
        Utilities.ConvertFrom(lsttempAttributeValue, out dt);


        return dt; 

    }
}
