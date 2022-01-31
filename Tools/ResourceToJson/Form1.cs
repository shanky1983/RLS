using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Linq;
using Microsoft.Win32;

namespace ResourceToJson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog oF = new FolderBrowserDialog();
            if (oF.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = oF.SelectedPath;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog oF = new FolderBrowserDialog();
            if (oF.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = oF.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                XDocument xDocument = XDocument.Load("LanguageCode.xml");
                var query = from xEle in xDocument.Descendants("LanguageCode")
                            select new { name = xEle.Element("Name").Value, Code = xEle.Element("Code").Value };

                foreach (var item in query)
                {
                    ResourceToList(item.Code);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Json file not created");
                return;
            }

            using (RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(@"Software\SourceForge\ResourceToJson"))
            {
                registryKey.SetValue("ResourceToJson_Path1", textBox1.Text);
                registryKey.SetValue("ResourceToJson_Path2", textBox2.Text);
            }


            MessageBox.Show("Json file successfully created");


        }
        bool ResourceToList(string langCode)
        {
            string Path = textBox1.Text.Trim();

            List<Att_Resource> lstResValues = new List<Att_Resource>();
            Att_Resource objData = null;
            DirectoryInfo DI = new DirectoryInfo(Path);
            string tlangCode = "";
            if (langCode == "en-GB")
            {
                tlangCode = ".resx";
            }
            else
            {
                tlangCode = "." + langCode + ".resx";
            }
            objData = NewMethod(langCode, lstResValues, objData, DI, "*_ClientDisplay" + tlangCode);
            var diobj = lstResValues.Select(m => new { m.Code, m.DisplayText }).Distinct().ToList();
            var json = "var Att_ResourceKey_AppDisplay =" + JsonConvert.SerializeObject(diobj);

            objData = NewMethod(langCode, lstResValues, objData, DI, "*_AppMsg" + tlangCode);

            diobj = lstResValues.Select(m => new { m.Code, m.DisplayText }).Distinct().ToList();
            json = json + ";var Att_ResourceKey_AppMsg =" + JsonConvert.SerializeObject(diobj) + ";";
            System.IO.File.WriteAllText(textBox2.Text.Trim()+@"\ResourceJson_" + langCode + ".js", json);
            return true;
        }

        private static Att_Resource NewMethod(string langCode, List<Att_Resource> lstResValues, Att_Resource objData, DirectoryInfo DI, string tlangCode)
        {
            foreach (FileInfo item in DI.GetFiles(tlangCode))
            {
                var pcon = item.Name.Split('.');
                if (pcon.Length == 2 && langCode == "en-GB")
                {
                    using (ResXResourceReader obj = new ResXResourceReader(item.FullName))
                    {
                        foreach (DictionaryEntry entry in obj)
                        {
                            objData = new Att_Resource();
                            objData.Code = Convert.ToString(entry.Key);
                            objData.DisplayText = Convert.ToString(entry.Value).Replace("'", "&apos;");
                            lstResValues.Add(objData);
                        }
                    }
                }
                if (pcon.Length == 3 && langCode != "en-GB")
                {
                    using (ResXResourceReader obj = new ResXResourceReader(item.FullName))
                    {
                        foreach (DictionaryEntry entry in obj)
                        {
                            objData = new Att_Resource();
                            objData.Code = Convert.ToString(entry.Key);
                            objData.DisplayText = Convert.ToString(entry.Value).Replace("'", "&apos;");
                            lstResValues.Add(objData);
                        }
                    }
                }

            }

            return objData;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(@"Software\SourceForge\ResourceToJson"))
            {
                textBox1.Text = (string)registryKey.GetValue("ResourceToJson_Path1", String.Empty);
                textBox2.Text = (string)registryKey.GetValue("ResourceToJson_Path2", String.Empty);
            }
            
        }
    }

    public class Att_Resource
    {
        public string Code { get; set; }
        public string DisplayText { get; set; }
    }
}
