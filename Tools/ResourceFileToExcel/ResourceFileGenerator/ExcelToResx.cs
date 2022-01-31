using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Resources;
using System.Collections.Specialized;
using System.Reflection;


namespace ResourceToExcel
{
    public partial class ExcelToResx : Form
    {
        public ExcelToResx()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Excel Files(.xlsx)|*.xlsx";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;
            openFileDialog1.Dispose();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strFileName = Convert.ToString(textBox1.Text);

            DataTable dt = new DataTable();
            if (File.Exists(strFileName))
            {
                //  DataTable sheetTable = loadSingleSheet(strFileName, "Sheet1");

                using (SpreadsheetDocument spreadSheetDocument = SpreadsheetDocument.Open(strFileName, false))
                {

                    WorkbookPart workbookPart = spreadSheetDocument.WorkbookPart;
                    IEnumerable<Sheet> sheets = spreadSheetDocument.WorkbookPart.Workbook.GetFirstChild<Sheets>().Elements<Sheet>();
                    string relationshipId = sheets.First().Id.Value;
                    WorksheetPart worksheetPart = (WorksheetPart)spreadSheetDocument.WorkbookPart.GetPartById(relationshipId);
                    Worksheet workSheet = worksheetPart.Worksheet;
                    SheetData sheetData = workSheet.GetFirstChild<SheetData>();
                    IEnumerable<Row> rows = sheetData.Descendants<Row>();

                    foreach (Cell cell in rows.ElementAt(0))
                    {
                        dt.Columns.Add(GetCellValue(spreadSheetDocument, cell));
                    }
                    progressBar1.Visible = true;
                    progressBar1.Maximum = rows.Count();
                    foreach (Row row in rows) //this will also include your header row...
                    {
                        DataRow tempRow = dt.NewRow();

                        for (int i = 0; i < row.Descendants<Cell>().Count(); i++)
                        {
                            tempRow[i] = GetCellValue(spreadSheetDocument, row.Descendants<Cell>().ElementAt(i));
                        }

                        dt.Rows.Add(tempRow);
                        progressBar1.Value = progressBar1.Value + 1;
                        if (Convert.ToInt32(progressBar1.Value) % 10 == 0)
                        {
                            Application.DoEvents();
                        }
                    }
                    dt.Rows.RemoveAt(0);
                }
                if (dt.Rows.Count > 0)
                {
                    GenerateResource(dt);

                }
                MessageBox.Show("ResourceFiles Generated Successfully...");
            }
            else
            {
                MessageBox.Show("The file is not exists");
            }



        }
        public void GenerateResource(DataTable dt)
        {
            try
            {
               
                Application.DoEvents();
                List<ResourceClass> lstRes = new List<ResourceClass>();
                ConvertTo<ResourceClass>(dt, out lstRes);
                progressBar1.Value = 0;
                List<string> UniqueFile = (from c in lstRes
                                           group c by c.FileName into d
                                           select d.Key).ToList();
                Application.DoEvents();
                for (int i = 0; i < UniqueFile.Count; i++)
                {
                    if (File.Exists(UniqueFile[i]))
                    {
                        File.Delete(UniqueFile[i]);
                    }
                    List<ResourceClass> Res4File = lstRes.Where(o => o.FileName == UniqueFile[i]).ToList();
                    using (ResXResourceWriter ResFile = new ResXResourceWriter(UniqueFile[i]))
                    {
                        for (int j = 0; j < Res4File.Count; j++)
                        {
                            ResFile.AddResource(Res4File[j].ResourceKey, Res4File[j].ResourceValue.Trim());
                            progressBar1.Value = progressBar1.Value + 1;
                            if (j % 10 == 0)
                            {
                                Application.DoEvents();
                            }
                        }
                    }
                    
                   
                }
                progressBar1.Visible = false;
            }
            catch (Exception ex)
            {
                progressBar1.Visible = false;
                MessageBox.Show("It is not a valid excel");
            }
        }

        public string GetCellValue(SpreadsheetDocument document, Cell cell)
        {
            SharedStringTablePart stringTablePart = document.WorkbookPart.SharedStringTablePart;
            if (cell != null && cell.InnerText != null)
            {
                string value = cell.InnerText;

                if (cell != null && cell.DataType != null && cell.DataType.Value == CellValues.SharedString)
                {
                    return stringTablePart.SharedStringTable.ChildElements[Int32.Parse(value)].InnerText;
                }
                else
                {
                    return value;
                }
            }
            return "";
        }

        public long ConvertTo<T>(DataTable table, out List<T> entity)
        {
            long returnCode = -1;
            entity = null;
            if (table == null)
            {
                return -1;
            }

            try
            {
                entity = ConvertTo<T>(table.Rows);
                returnCode = 0;
            }
            catch (Exception ex)
            {
                returnCode = 1000;
                //CLogger.LogError("Error while executing ConverTo<> method in Utilities", ex);
            }
            finally
            {
            }
            return returnCode;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="rows"></param>
        /// <returns></returns>
        private List<T> ConvertTo<T>(DataRowCollection rows)
        {
            List<T> list = null;
            
            if (rows != null)
            {
                list = new List<T>();
                progressBar1.Maximum = rows.Count;
                progressBar1.Value = 0;
                foreach (DataRow row in rows)
                {
                    T item = CreateItem<T>(row);
                    list.Add(item);
                    progressBar1.Value = progressBar1.Value + 1;
                    if (Convert.ToInt32(progressBar1.Value) % 10 == 0)
                    {
                        Application.DoEvents();
                    }
                }
            }

            return list;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="row"></param>
        /// <returns></returns>
        static T CreateItem<T>(DataRow row)
        {
            string str = string.Empty;
            string strObj = string.Empty;

            T obj = default(T);

            if (row != null)
            {
                obj = Activator.CreateInstance<T>();
                strObj = obj.ToString();
                NameValueCollection objDictionary = new NameValueCollection();
                foreach (DataColumn column in row.Table.Columns)
                {

                    PropertyInfo prop = obj.GetType().GetProperty(column.ColumnName);
                    if (prop != null)
                    {
                        str = column.ColumnName;
                        try
                        {
                            objDictionary.Add(str, row[str].ToString());
                            object value = row[column.ColumnName];
                            Type vType = obj.GetType();
                            if (value == DBNull.Value)
                            {
                                if (vType == typeof(int)
                                     || vType == typeof(Int16)
                                     || vType == typeof(Int32)
                                     || vType == typeof(Int64)
                                     || vType == typeof(decimal)
                                     || vType == typeof(float)
                                     || vType == typeof(double)) value = 0;

                                else if (vType == typeof(bool)) value = false;

                                else if (vType == typeof(DateTime)) value = DateTime.MaxValue;

                                else value = null;

                                prop.SetValue(obj, value, null);
                            }
                            else
                            {
                                prop.SetValue(obj, value, null);
                            }

                        }
                        catch (Exception ex)
                        {
                            //  CLogger.LogError("Error while executing CreateItem<> method in Utilities " + " Col: " + str + " Obj: " + strObj, ex);

                        }
                    }
                }
                PropertyInfo Actionprop = obj.GetType().GetProperty("ActionTemplateValue");
                if (Actionprop != null)
                {
                    object Actionvalue = objDictionary;
                    Actionprop.SetValue(obj, Actionvalue, null);
                }
            }

            return obj;
        }
    }
}
