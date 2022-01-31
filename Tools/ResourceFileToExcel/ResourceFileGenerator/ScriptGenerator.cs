using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using System.Data.SqlClient;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Collections.Specialized;
using System.Reflection;
using System.Data.Common;
using System.Resources;

namespace ResourceToExcel
{
    public partial class ScriptGenerator : Form
    {
        public ScriptGenerator()
        {
            InitializeComponent();
            txtXMLPath.Text = ResourceFileReadLogic.GetXML();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (cbLanguageCode.Text == "Select")
            {
                MessageBox.Show("Choose language to Generate Script");
                return;
            }

            if (radioButton6.Checked || radioButton8.Checked)
            {
                if (string.IsNullOrEmpty(txtXMLPath.Text.Trim()) || !File.Exists(txtXMLPath.Text.Trim()))
                {
                    MessageBox.Show("Please select valid xml..");
                    return;
                }
                if (string.IsNullOrEmpty(cbDBName.Text))
                {
                    MessageBox.Show("Please select database name...");
                    return;
                }


                if (cbOrgID.Text == "")
                {
                    MessageBox.Show("Select Organization name");
                }
            }
            try
            {
                if (string.IsNullOrEmpty(txtExcelPath.Text.Trim()))
                {
                    DialogResult res = MessageBox.Show("excel file is not selected. The script will be generated based on English text. Do you wish to continue?", "File missing", MessageBoxButtons.OKCancel);
                    if (res == DialogResult.Cancel)
                    {
                        return;
                    }
                }
                if (radioButton6.Checked || radioButton8.Checked)
                {
                    GenerateScript();
                }
                if (radioButton7.Checked || radioButton8.Checked)
                {
                    Dictionary<string, string> strUniqueWords = new Dictionary<string, string>();
                    DataTable dt = ResourceFileReadLogic.ResourceToDT(txtAppPath.Text, out strUniqueWords);

                    Dictionary<string, string> lstUniqueWords = new Dictionary<string, string>();
                    DataTable dt2 = ResourceFileReadLogic.ReadExcel(txtExcelPath.Text);
                    if (dt2.Rows.Count > 0)
                    {
                        lstUniqueWords = dt2.AsEnumerable().ToDictionary(row => row.Field<string>(0), row => row.Field<string>(1));
                    }

                    List<ResourceClass> lstRes = new List<ResourceClass>();
                    //  ResourceFileReadLogic.ConvertTo<ResourceClass>(dt, out lstRes);
                    lstRes = (from DataRow dr in dt.Rows
                              select new ResourceClass
                              {
                                  FileName = Convert.ToString(dr["FileName"]),
                                  ResourceKey = Convert.ToString(dr["ResourceKey"]),
                                  ResourceValue = Convert.ToString(dr["ResourceValue"]),
                                  UniqueKey = Convert.ToString(dr["UniqueKey"]),
                                  WordCount = Convert.ToInt32(dr["UniqueKey"])
                              }).ToList();
                    List<string> UniqueFile = (from c in lstRes
                                               group c by c.FileName into d
                                               select d.Key).ToList();
                    Application.DoEvents();
                    for (int i = 0; i < UniqueFile.Count; i++)
                    {
                        if (File.Exists(UniqueFile[i].Replace(".resx", "." + cbLanguageCode.Text + ".resx")))
                        {
                            File.Delete(UniqueFile[i].Replace(".resx", "." + cbLanguageCode.Text + ".resx"));
                        }
                        List<ResourceClass> Res4File = lstRes.Where(o => o.FileName == UniqueFile[i]).ToList();
                        using (ResXResourceWriter ResFile = new ResXResourceWriter(UniqueFile[i].Replace(".resx", "." + cbLanguageCode.Text + ".resx")))
                        {
                            for (int j = 0; j < Res4File.Count; j++)
                            {
                                string resValue = null;
                                if (lstUniqueWords.ContainsKey(Res4File[j].ResourceValue.Trim()))
                                {
                                    resValue = lstUniqueWords[Res4File[j].ResourceValue.Trim()];
                                }
                                else
                                {
                                    resValue = Res4File[j].ResourceValue.Trim();
                                }

                                ResFile.AddResource(Res4File[j].ResourceKey, resValue == null ? Res4File[j].ResourceValue.Trim() : resValue);
                                if (j % 10 == 0)
                                {
                                    Application.DoEvents();
                                }
                            }
                        }


                    }


                }
                MessageBox.Show("Script Generated successfully...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GenerateScript()
        {
            string OrgID = cbOrgID.Text.Split('|')[0].Trim();

            List<TableforScript> lstTable = ResourceFileReadLogic.RetriveXmlData(txtExcelPath.Text, txtXMLPath.Text);
            if (lstTable.Count > 0)
            {
                string conStr = "Server=" + txtServer.Text.Trim() + ";Database=" + cbDBName.Text + ";uid=" + txtUserName.Text.Trim() + ";pwd=" + txtPassword.Text.Trim() + ";";

                using (SqlConnection con = new SqlConnection(conStr))
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    {
                        return;
                    }
                    string FileName = saveFileDialog1.FileName;
                    StreamWriter sw = new StreamWriter(FileName);
                    sw.WriteLine("--***************************************************");
                    sw.WriteLine("----------LanguageSpecific Table Script Generated on " + DateTime.Now.ToShortDateString() + "------------------");
                    for (int i = 0; i < lstTable.Count; i++)
                    {
                        sw.WriteLine("---------Insert Script for the Table " + lstTable[i].Name);
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "select C.name,C.is_identity,k.type from sys.columns C join sys.tables T on c.object_id=t.object_id left outer join sys.key_constraints K on C.object_id=k.parent_object_id  where t.name='" + lstTable[i].Name + "'";
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        // SqlDataReader dr = cmd.ExecuteReader();
                        sda.Fill(dt);

                        for (int j = 0; j < lstTable[i].Rows.Count; j++)
                        {

                            Application.DoEvents();

                            string strColumns = "";
                            string strColumnValues = "";
                            bool hasIdentity = false;
                            string langCodeColName = "";

                            if (dt.Rows.Count > 0)
                            {
                                string strWhereQry = "";
                                string strWhereQry2 = "";
                                for (int k = 0; k < lstTable[i].Rows[j].Columns.Count; k++)
                                {
                                    strWhereQry = strWhereQry + " and " + lstTable[i].Rows[j].Columns[k].ColName + "=N'" + lstTable[i].Rows[j].Columns[k].TransValue.Replace("'", "''") + "' ";
                                    strWhereQry2 = strWhereQry2 + " and " + lstTable[i].Rows[j].Columns[k].ColName + "='" + lstTable[i].Rows[j].Columns[k].ColValue.Replace("'", "''") + "' ";
                                }

                                if (lstTable[i].IsOrgBased == 'Y')
                                {
                                    strWhereQry = strWhereQry + " and OrgID=" + OrgID;
                                    strWhereQry2 = strWhereQry2 + " and OrgID=" + OrgID;
                                }


                                for (int k = 0; k < dt.Rows.Count; k++)
                                {
                                    string _dbvalue = dt.Rows[k]["Name"].ToString();
                                    if (Convert.ToInt32(dt.Rows[k]["is_identity"]) == 1)
                                    {
                                        hasIdentity = true;
                                    }
                                    if (Convert.ToInt32(dt.Rows[k]["is_identity"]) == 1 && lstTable[i].HasIdentity == false)
                                    {

                                    }
                                    else
                                    {
                                        strColumns = strColumns + "," + _dbvalue;
                                        string _transvalue = null;
                                        if (_dbvalue != "LangCode" && _dbvalue != "LanguageCode")
                                        {
                                            _transvalue = (from c in lstTable[i].Rows[j].Columns
                                                           where c.ColName == _dbvalue
                                                           select c.TransValue).SingleOrDefault();


                                        }
                                        else
                                        {
                                            langCodeColName = _dbvalue;
                                            _dbvalue = "'" + cbLanguageCode.Text + "'";

                                        }
                                        if (!string.IsNullOrEmpty(_transvalue))
                                        {
                                            strColumnValues = strColumnValues + ",N'" + _transvalue.Replace("'", "''") + "'";
                                        }
                                        else
                                        {
                                            if (_dbvalue.ToLower() == "createdat")
                                            {
                                                _dbvalue = "getdate()";
                                            }
                                            else if (_dbvalue.ToLower() == "createdby")
                                            {
                                                _dbvalue = "'9999999'";
                                            }
                                            strColumnValues = strColumnValues + "," + _dbvalue;
                                        }
                                    }
                                }

                                strColumns = strColumns.TrimStart(',');
                                strColumnValues = strColumnValues.TrimStart(',');

                                if (hasIdentity && lstTable[i].HasIdentity)
                                {
                                    sw.WriteLine("SET IDENTITY_INSERT " + lstTable[i].Name + " ON");
                                }

                                sw.WriteLine("IF Not Exists(select * from " + lstTable[i].Name + " where " + langCodeColName + "='" + cbLanguageCode.Text + "' " + strWhereQry + ")");
                                sw.WriteLine("BEGIN");
                                sw.WriteLine("Insert into " + lstTable[i].Name + "(" + strColumns + ") ");
                                sw.WriteLine("Select " + strColumnValues + " from " + lstTable[i].Name + " where isnull(" + langCodeColName + ",'en-GB')='en-GB' " + strWhereQry2);
                                sw.WriteLine("END");
                                sw.WriteLine("GO");

                                if (hasIdentity && lstTable[i].HasIdentity)
                                {
                                    sw.WriteLine("SET IDENTITY_INSERT " + lstTable[i].Name + " OFF");
                                }
                                sw.WriteLine();
                            }
                        }

                    }
                    sw.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtServer.Text.Trim()) && !string.IsNullOrEmpty(txtUserName.Text.Trim()) && !string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                SqlConnection con = new SqlConnection("Server=" + txtServer.Text.Trim() + ";Database=master;uid=" + txtUserName.Text.Trim() + ";pwd=" + txtPassword.Text.Trim() + ";");
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "Select * from Sys.Databases where state_desc='ONLINE'";
                    cmd.Connection = con;
                    if (con.State != ConnectionState.Open)
                        con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    List<string> lstDbNames = new List<string>();
                    while (dr.Read())
                    {
                        lstDbNames.Add(dr["Name"].ToString());
                    }
                    if (lstDbNames.Count > 0)
                    {
                        cbDBName.DataSource = lstDbNames;
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string AppPath = null;
            string xmlPath = null;
            if (radioButton1.Checked || radioButton3.Checked)
            {
                if (string.IsNullOrEmpty(txtXMLPath.Text.Trim()))
                {
                    MessageBox.Show("Select XML Files for extraction");
                    return;
                }
                xmlPath = txtXMLPath.Text;
            }
            if (radioButton2.Checked || radioButton3.Checked)
            {
                if (!string.IsNullOrEmpty(txtAppPath.Text.Trim()))
                {
                    AppPath = txtAppPath.Text.Trim();
                }
                else
                {
                    MessageBox.Show("Select Application path to extract resx values");
                    return;
                }
            }
            gpProgress.Visible = true;
            saveFileDialog2.ShowDialog();
            string strFileName = saveFileDialog2.FileName;
            if (!string.IsNullOrEmpty(strFileName))
            {
                try
                {
                    DataSet ds = ResourceFileReadLogic.UniqueWordsforTrans(xmlPath, AppPath);
                    List<string> sheetNames = new List<string>();
                    sheetNames.Add("DBValues for Translation");
                    Attune.OpenXML.ExportToExcel.ArruntOpenXMLExportToExcel.CreateExcel(strFileName, ds, sheetNames);
                    MessageBox.Show("Data extracted successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    gpProgress.Visible = false;
                }

            }
            else
            {
                MessageBox.Show("Specify valid excel name to extract...");
            }
            gpProgress.Visible = false;
        }



        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtXMLPath.Text = openFileDialog1.FileName;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                txtExcelPath.Text = openFileDialog2.FileName;
            }
        }

        private void cbDBName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDBName.SelectedIndex != -1)
            {
                try
                {
                    string conStr = "Server=" + txtServer.Text.Trim() + ";Database=" + cbDBName.Text + ";uid=" + txtUserName.Text.Trim() + ";pwd=" + txtPassword.Text.Trim() + ";";
                    cbOrgID.Items.Clear();
                    using (SqlConnection con = new SqlConnection(conStr))
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = "select OrgID,Name from organization";
                        cmd.Connection = con;
                        if (con.State != ConnectionState.Open)
                            con.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            cbOrgID.Items.Add(dr["OrgID"].ToString() + " | " + dr["Name"].ToString());
                        }

                    }
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAppPath.Text))
            {
                MessageBox.Show("Select Application path to read resource values");
                return;
            }
            saveFileDialog2.ShowDialog();
            string strFileName = saveFileDialog2.FileName;
            DataSet ds = ResourceFileReadLogic.UniqueWordsforTrans(txtXMLPath.Text, txtAppPath.Text);
            List<string> sheetNames = new List<string>();
            sheetNames.Add("DBValues for Translation");
            Attune.OpenXML.ExportToExcel.ArruntOpenXMLExportToExcel.CreateExcel(strFileName, ds, sheetNames);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            txtAppPath.Text = folderBrowserDialog1.SelectedPath;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            grpAppPath.Visible = true;
            grpXML.Visible = false;
            grpDBValues.Visible = false;
            grpExcel.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            grpAppPath.Visible = true;
            grpXML.Visible = true;
            grpDBValues.Visible = false;
            grpExcel.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            grpAppPath.Visible = false;
            grpDBValues.Visible = false;
            grpXML.Visible = true;
            grpExcel.Visible = false;

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            grpGenerateOption.Visible = false;
            grpDBValues.Visible = false;
            grpXML.Visible = false;
            grpExcel.Visible = false;
            grpAppPath.Visible = false;
            grpExtractOption.Visible = true;
            btnGenerate.Visible = false;
            btnExtract.Visible = true;

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            grpExtractOption.Visible = false;
            grpDBValues.Visible = false;
            grpXML.Visible = false;
            grpExcel.Visible = false;
            grpAppPath.Visible = false;
            grpGenerateOption.Visible = true;
            btnGenerate.Visible = true;
            btnExtract.Visible = false;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            grpDBValues.Visible = true;
            grpXML.Visible = true;
            grpExcel.Visible = true;
            grpAppPath.Visible = false;

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            grpAppPath.Visible = true;
            grpExcel.Visible = true;
            grpDBValues.Visible = false;
            grpXML.Visible = false;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            grpDBValues.Visible = true;
            grpXML.Visible = true;
            grpExcel.Visible = true;
            grpAppPath.Visible = true;
        }

        private void grpGenerateOption_Enter(object sender, EventArgs e)
        {

        }

        private void gpProgress_Enter(object sender, EventArgs e)
        {

        }
    }
}
