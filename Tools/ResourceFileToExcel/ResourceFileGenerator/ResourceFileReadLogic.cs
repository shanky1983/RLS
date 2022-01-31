using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Data;
using System.Resources;
using System.Collections;
using System.Collections.Specialized;
using System.Reflection;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Xml.Linq;


namespace ResourceToExcel
{
    public static class ResourceFileReadLogic
    {
        public static DataTable ResourceToDT(string folderName, out Dictionary<string, string> uniqueWords)
        {
            List<string> ctrlList = new List<string>();
            DirectoryInfo di = new DirectoryInfo(folderName);
            List<FileInfo> FileInfo = di.GetFilesByExtensions("*.resx").ToList();
            int i = 1;
            DataTable dt = new DataTable();
            dt.Columns.Add("FileName");
            dt.Columns.Add("UniqueKey");
            dt.Columns.Add("ResourceKey");
            dt.Columns.Add("ResourceValue");
            dt.Columns.Add("WordCount");
            uniqueWords = new Dictionary<string, string>();

            foreach (FileInfo item in FileInfo)
            {
                try
                {
                    using (ResXResourceReader resx = new ResXResourceReader(item.FullName))
                    {
                        IDictionaryEnumerator dict = resx.GetEnumerator();

                        while (dict.MoveNext())
                        {
                            Application.DoEvents();
                            DataRow dr = dt.NewRow();
                            dr["FileName"] = item.FullName;
                            dr["UniqueKey"] = Convert.ToString(i);
                            dr["ResourceKey"] = dict.Key;
                            dr["ResourceValue"] = dict.Value;
                            string localizedword = Convert.ToString(dict.Value);
                            string[] words = localizedword.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            dr["WordCount"] = words.Length;
                            dt.Rows.Add(dr);

                            if (!uniqueWords.ContainsKey(Convert.ToString(dict.Value).Trim()))
                            {
                                uniqueWords.Add(Convert.ToString(dict.Value).Trim(), "");
                            }

                            i++;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(item.FullName);
                }
            }
            return dt;
        }

        public static DataSet UniqueWordsforTrans(string XMLPath, string strAppPath)
        {

            Dictionary<string, string> lstWords = new Dictionary<string, string>();
            DataSet ds = new DataSet();
            List<TableforScript> lstTable = new List<TableforScript>();
            if (!string.IsNullOrEmpty(XMLPath))
            {
                lstTable = RetriveXmlData("", XMLPath);
            }
            if (!string.IsNullOrEmpty(strAppPath))
            {
                ResourceToDT(strAppPath, out lstWords);
            }
            if (lstTable.Count > 0)
            {
                for (int i = 0; i < lstTable.Count; i++)
                {
                    Application.DoEvents();
                    for (int j = 0; j < lstTable[i].Rows.Count; j++)
                    {
                        for (int k = 0; k < lstTable[i].Rows[j].Columns.Count; k++)
                        {
                            string _value = lstTable[i].Rows[j].Columns[k].ColValue;
                            if (!lstWords.ContainsKey(_value.Trim()))
                            {
                                lstWords.Add(_value.Trim(), "");
                            }
                        }
                    }

                }

            }

            DataTable dt = new DataTable();
            dt.Columns.Add("OriginalData");
            dt.Columns.Add("TranslatedData");
            List<string> objLst = lstWords.Keys.ToList();
            for (int i = 0; i < objLst.Count; i++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = objLst[i];
                dt.Rows.Add(dr);
            }
            ds.Tables.Add(dt);

            return ds;

        }

        public static List<TableforScript> RetriveXmlData(string ExcelPath, string xmlPath)
        {
            DataTable dt = ReadExcel(ExcelPath);
            List<TranslationExcel> lstExcelData = new List<TranslationExcel>();
            if (dt != null && dt.Rows.Count > 0)
            {
                ConvertTo(dt, out lstExcelData);
            }

            XDocument document = XDocument.Load(xmlPath);
            List<TableforScript> lstTable = new List<TableforScript>();
            var xElement = document.Element("Tables");
            if (xElement != null)
            {

                foreach (var child in xElement.Elements("Table"))
                {
                    Application.DoEvents();
                    TableforScript objTable = new TableforScript();
                    objTable.Name = child.Attribute("Name").Value;
                    objTable.HasIdentity = child.Attribute("IsIdentityBased").Value == "Y";
                    if (child.Attributes("CRUD").Count() != 0)
                    {
                        objTable.Crud = Convert.ToChar(child.Attribute("CRUD").Value);
                    }
                    if (child.Attributes("IsOrgBased").Count() != 0)
                    {
                        objTable.IsOrgBased = Convert.ToChar(child.Attribute("IsOrgBased").Value);
                    }
                    objTable.Rows = new List<Rows>();
                    foreach (var child2 in child.Elements("Row"))
                    {
                        Rows objRow = new Rows();
                        objRow.Columns = new List<Columns>();
                        foreach (var child3 in child2.Elements("Column"))
                        {
                            Columns objColumn = new Columns();
                            objColumn.ColName = child3.Attribute("Name").Value;
                            objColumn.ColValue = child3.Value.Trim();
                            string _transData = lstExcelData.Where(o => o.OriginalData == child3.Value.Trim()).Select(o => o.TranslatedData).FirstOrDefault();
                            if (!string.IsNullOrEmpty(_transData))
                            {
                                objColumn.TransValue = _transData.Trim();
                            }
                            else
                            {
                                objColumn.TransValue = child3.Value.Trim();
                            }
                            objRow.Columns.Add(objColumn);
                        }
                        objTable.Rows.Add(objRow);
                    }
                    lstTable.Add(objTable);
                }
            }
            return lstTable;
        }

        public static DataTable ReadExcel(string excelPath)
        {
            DataTable dt = new DataTable();
            if (!string.IsNullOrEmpty(excelPath))
            {
                using (SpreadsheetDocument spreadSheetDocument = SpreadsheetDocument.Open(excelPath, false))
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

                    foreach (Row row in rows) //this will also include your header row...
                    {
                        DataRow tempRow = dt.NewRow();

                        for (int i = 0; i < row.Descendants<Cell>().Count(); i++)
                        {
                            tempRow[i] = GetCellValue(spreadSheetDocument, row.Descendants<Cell>().ElementAt(i));
                        }

                        dt.Rows.Add(tempRow);

                    }
                    dt.Rows.RemoveAt(0);
                }
            }
            return dt;
        }

        public static string GetCellValue(SpreadsheetDocument document, Cell cell)
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

        public static long ConvertTo<T>(DataTable table, out List<T> entity)
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
        private static List<T> ConvertTo<T>(DataRowCollection rows)
        {
            List<T> list = null;

            if (rows != null)
            {
                list = new List<T>();

                foreach (DataRow row in rows)
                {
                    T item = CreateItem<T>(row);
                    list.Add(item);

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

        public static string GetXML()
        {
            string strFileName = "";
            string folderName = Application.StartupPath;
            DirectoryInfo di = new DirectoryInfo(folderName);
            List<FileInfo> FileInfo = di.GetFilesByExtensions("*LocalizationScriptTemplate.xml").ToList();
            if (FileInfo != null && FileInfo.Count > 0)
            {
                strFileName = FileInfo[0].FullName;
            }
            return strFileName;
        }



    }
}
