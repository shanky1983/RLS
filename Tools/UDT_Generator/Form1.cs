using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.CodeDom;
using System.Data.SqlClient;
using System.IO;

namespace UDT_Generator
{
    public partial class Form1 : Form
    {
        private string sqlConnectionString;
        public Form1()
        {
            InitializeComponent();
         }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog opnFil = new FolderBrowserDialog();
            using (RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(@"Software\SourceForge\UDT_Generator"))
            {
                opnFil.SelectedPath = (string)registryKey.GetValue("UDT_Generator_Path", String.Empty);
            }
            if (opnFil.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = opnFil.SelectedPath;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
             

            if (txtName.Text.Trim() == "")
            {
                
            }
            sqlConnectionString = txtConnection.Text;
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(sqlConnectionString);
            SqlCommand cmd = new SqlCommand();
            DataTable _datatable = new DataTable();
            string str="";
            if (txtName.Text.Trim() != "")
            {
                str = " where tt.name='" + txtName.Text.Trim() + "' ";
            }

            cmd.CommandText = "select tt.name [Tablename],c.name [Columnname],c.column_id ColumnId,TYPE_NAME(c.user_type_id) DataType " +
                                "from sys.table_types as tt inner join sys.columns as c "+
                                "on tt.type_table_object_id = c.object_id " +str+ " order by Tablename,column_id";


            cmd.Connection = con;
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            if (ds.Tables.Count > 0)
            {
                _datatable = ds.Tables[0];
            }
            List<Data_Type> lstData_Type=new List<Data_Type>();
           
            Utilities.ConvertTo(_datatable, out lstData_Type);
            GetDateList(lstData_Type);
           
             
        }

        private void GetDateList(List<Data_Type> _Itemlist)
        {
            
            
            var _DistinctDataTable = (from s in _Itemlist
                                     select s.Tablename).Distinct();
            List<Data_Type> lst = new List<Data_Type>();

            using (StreamWriter streamWriter = new StreamWriter(Path.Combine(txtPath.Text.Trim(), "UDTClass.cs")))
            {

                //streamWriter.WriteLine("using System;");
                //streamWriter.WriteLine("using System.Collections;");
                //streamWriter.WriteLine("using System.Collections.Generic;");
                //streamWriter.WriteLine("using System.Text;");

                streamWriter.WriteLine();
                streamWriter.WriteLine("namespace UDT");
                streamWriter.WriteLine("{");

                streamWriter.WriteLine("\tpublic static class UDTClass");
                streamWriter.WriteLine("\t{");
               
                foreach (var _tablename in _DistinctDataTable)
                {
                    streamWriter.WriteLine();
                    streamWriter.WriteLine("\tpublic static System.Data.DataTable ConvertTo" + _tablename + "(this ListName _lstCollection)");
                    streamWriter.WriteLine("\t{");
                    streamWriter.WriteLine("\t //lan");
                    streamWriter.WriteLine("\t\t System.Data.DataTable _datatable=new System.Data.DataTable();");
                    streamWriter.WriteLine("\t");
                    lst=_Itemlist.FindAll(p => p.Tablename.Trim() == _tablename).OrderBy(n => n.ColumnId).ToList();
                    string pval="";
                    foreach (Data_Type _item in lst)
                    {
                        pval = @"_datatable.Columns.Add(""" + _item.Columnname+"\", typeof(" + GetDataType(_item.DataType) + "));";
                        streamWriter.WriteLine("\t\t" + pval);
                    }
                    streamWriter.WriteLine("\t");
                    streamWriter.WriteLine("\t\t DataRow _datarow ;");
                    streamWriter.WriteLine("\t");
                    streamWriter.WriteLine("\t\t foreach (ListName _list in _lstCollection)");
                    streamWriter.WriteLine("\t\t\t{");
                    streamWriter.WriteLine("\t\t\t   _datarow = _datatable.NewRow();");
                    foreach (Data_Type _item in lst)
                    {

                        pval = @"   _datarow[""" + _item.Columnname + "\"]=_list." + _item.Columnname + ";";
                        streamWriter.WriteLine("\t\t\t" + pval);
                        
                    }
                    streamWriter.WriteLine("\t\t\t   _datatable.Rows.Add(_datarow);"); 
                    streamWriter.WriteLine("\t\t\t}");
                    streamWriter.WriteLine("\t\t return _datatable;"); 
                    streamWriter.WriteLine("\t //Test");
                    streamWriter.WriteLine("\t\t}");
                    streamWriter.WriteLine("\t}");
                   
                }
                streamWriter.WriteLine("}");
            }
        }

         
        

        private Type GetDataType(string item)
        {
            Type fieldType;
            if (item.ToLower() == SqlDbType.TinyInt.ToString().ToLower())
                fieldType = typeof(System.Byte);
            else if (item.ToLower() == SqlDbType.SmallInt.ToString().ToLower())
                fieldType = typeof(System.Int16);
            else if (item.ToLower() == SqlDbType.Int.ToString().ToLower())
                fieldType = typeof(System.Int32);
            else if (item.ToLower() == SqlDbType.BigInt.ToString().ToLower())
                fieldType = typeof(System.Int64);
            else if (item.ToLower() == SqlDbType.Money.ToString().ToLower())
                fieldType = typeof(System.Single);
            else if (item.ToLower() == SqlDbType.Float.ToString().ToLower())
                fieldType = typeof(System.Double);
            else if (item.ToLower() == SqlDbType.Char.ToString().ToLower() || item.ToLower() == SqlDbType.NChar.ToString().ToLower() || item.ToLower() == SqlDbType.VarChar.ToString().ToLower() || item.ToLower() == SqlDbType.NVarChar.ToString().ToLower() || item.ToLower() == SqlDbType.Text.ToString().ToLower() || item.ToLower() == SqlDbType.NText.ToString().ToLower() || item.ToLower() == SqlDbType.Xml.ToString().ToLower())
                fieldType = typeof(System.String);
            else if (item.ToLower() == SqlDbType.Decimal.ToString().ToLower() || item.ToLower() == SqlDbType.Real.ToString().ToLower())
                fieldType = typeof(System.Decimal);
            else if (item.ToLower() == SqlDbType.Image.ToString().ToLower() || item.ToLower() == SqlDbType.VarBinary.ToString().ToLower())
                fieldType = typeof(System.Byte[]);
            else if (item.ToLower() == SqlDbType.SmallDateTime.ToString().ToLower() || item.ToLower() == SqlDbType.Date.ToString().ToLower() || item.ToLower() == SqlDbType.DateTime.ToString().ToLower() || item.ToLower() == SqlDbType.DateTime2.ToString().ToLower())
                fieldType = typeof(System.DateTime);
            else if (item.ToLower() == SqlDbType.DateTimeOffset.ToString().ToLower())
                fieldType = typeof(System.DateTimeOffset);
            else if (item.ToLower() == SqlDbType.Bit.ToString().ToLower())
                fieldType = typeof(System.Boolean);
            else if (item.ToLower() == SqlDbType.UniqueIdentifier.ToString().ToLower())
                fieldType = typeof(System.Guid);
            else if (item.ToLower() == "table type")
                fieldType = typeof(System.Data.DataTable);
            else
                fieldType = typeof(System.Object);
            return fieldType;
        }
    }
}