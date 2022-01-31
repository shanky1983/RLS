using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Resources;
using Microsoft.Win32;
using System.Collections;
using ResourceToExcel;

namespace ResourceFileGenerator
{
    public partial class ResourceGenerator : Form
    {
        public ResourceGenerator()
        {
            InitializeComponent();
            using (RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(@"Software\Attune\ResourceGen"))
            {
                textBox1.Text = (string)registryKey.GetValue("Path", String.Empty);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();


            if (fd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = fd.SelectedPath;
            }
            using (RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(@"Software\Attune\ResourceGen"))
            {
                registryKey.SetValue("Path", fd.SelectedPath, RegistryValueKind.String);
            }
        }

        private bool validataion()
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please select a path");
                return false;
            }
            else if (!Directory.Exists(textBox1.Text))
            {
                MessageBox.Show("Please select a valid path");
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validataion())
            {

                button1.Enabled = false;
                progressBar1.Visible = true;
                DataSet ds = new DataSet();
                Dictionary<string, string> lstUniqueWords;
                ds.Tables.Add(ResourceFileReadLogic.ResourceToDT(textBox1.Text, out lstUniqueWords));
                List<string> sheetNames = new List<string>();
                sheetNames.Add("Product Resources");
                Attune.OpenXML.ExportToExcel.ArruntOpenXMLExportToExcel.CreateExcel(textBox1.Text + "\\ResourceFile.xlsx", ds, sheetNames);

            }
            MessageBox.Show("Completed Successfully");
            progressBar1.Visible = false;
            button1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ExcelToResx Form2 = new ExcelToResx();
            Form2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ScriptGenerator form5 = new ScriptGenerator();
            form5.Show();
        }

        private void ResourceGenerator_Load(object sender, EventArgs e)
        {

        }
    }





}
public static class ExtensionClass
{
    public static IEnumerable<FileInfo> GetFilesByExtensions(this DirectoryInfo dir, params string[] extensions)
    {
        if (extensions == null)
            throw new ArgumentNullException("extensions");
        IEnumerable<FileInfo> files = Enumerable.Empty<FileInfo>();
        foreach (string ext in extensions)
        {
            files = files.Concat(dir.GetFiles(ext, SearchOption.AllDirectories));
        }
        return files;
    }
}

