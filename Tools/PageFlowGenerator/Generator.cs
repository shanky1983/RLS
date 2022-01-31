using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.CodeDom.Compiler;
using System.IO;
using System.Data.SqlClient;
using System.CodeDom;
namespace CodeGenerator
{
    public partial class Generator : Form
    {
        public Generator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strCon = string.Empty;
            string strOrgID = string.Empty;
            strOrgID = txtOrgID.Text;
            string className = string.Empty;
            string outputDirectory = string.Empty;
            foreach (string s in strOrgID.Split(','))
            {
                strCon = txtConStr.Text;
                int orgID = Convert.ToInt32(s);
                SqlConnection sqlCon = new SqlConnection(strCon);
                SqlCommand sCommand = new SqlCommand();
                sCommand.CommandText = "spGetOrgPages";
                sCommand.CommandType = CommandType.StoredProcedure;
                System.Data.SqlClient.SqlParameter paramorgID = new System.Data.SqlClient.SqlParameter();
                paramorgID.ParameterName = "@pOrgID";
                paramorgID.Value = orgID;
                paramorgID.DbType = DbType.Int32;
                sCommand.Parameters.Add(paramorgID);
                sCommand.Connection = sqlCon;
                try
                {
                    sqlCon.Open();
                    SqlDataReader dr = sCommand.ExecuteReader(CommandBehavior.CloseConnection);
                    while(dr.Read())
                    {
                        className = dr.GetString(0);
                        className = className.Replace(" ", "");
                        outputDirectory = GenerateAbstract(orgID, className);

                    }
                    dr.NextResult();
                    PopulateData(dr, className, outputDirectory);
                    label3.Text = "Copy the generated files to App_Code folder.";
                }
                catch (Exception ex)
                {
                    label3.Text = ex.Message;
                }
                finally
                {

                }
            }

        }

        private string GenerateAbstract(int orgID, string className)
        {
            string outputDirectory = string.Empty;
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Select an output directory";
                dialog.ShowNewFolderButton = true;
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    outputDirectory = dialog.SelectedPath;
                }
                else
                {
                    return "";
                }
            }

            using (StreamWriter streamWriter = new StreamWriter(Path.Combine(outputDirectory, "PathFinder.cs")))
            {


                streamWriter.WriteLine("using System;");
                streamWriter.WriteLine("using System.Text;");                
                streamWriter.WriteLine("public abstract class PathFinder" );
                streamWriter.WriteLine("{");
                streamWriter.WriteLine("public static PathFinder GetPathFinder(int orgID)");
                streamWriter.WriteLine("{");
                streamWriter.WriteLine("switch(orgID)");
                streamWriter.WriteLine("{");
                streamWriter.WriteLine("case 1:");
                streamWriter.WriteLine("return new "+className+"();");
                streamWriter.WriteLine("break;");
                streamWriter.WriteLine("};");
                streamWriter.WriteLine("return null;");
                streamWriter.WriteLine("}");
                streamWriter.WriteLine("public virtual string GetPath(string actionName)");
                streamWriter.WriteLine("{");
                streamWriter.WriteLine("return string.Empty;");
                streamWriter.WriteLine("}");
                streamWriter.WriteLine("}");                
               
            }

            return outputDirectory;

        }

        private void PopulateData(SqlDataReader dataReader, string className, string outputDirectory)
        {
           
                int nFields = dataReader.FieldCount;

                if (nFields == 2)
                {

                    using (StreamWriter streamWriter = new StreamWriter(Path.Combine(outputDirectory, className + ".cs")))
                    {
                        

                        streamWriter.WriteLine("using System;");                        
                        streamWriter.WriteLine("using System.Text;");
                        streamWriter.WriteLine("public class " + className + ": PathFinder");
                        streamWriter.WriteLine("{");
                        streamWriter.WriteLine("public override string GetPath(string actionName)");
                        streamWriter.WriteLine("{");
                        streamWriter.WriteLine("switch(actionName)");
                        streamWriter.WriteLine("{");
                        while (dataReader.Read())
                        {                            
                            String[] subitems = new String[nFields];                            
                             subitems[0] = dataReader[0].ToString();
                             subitems[1] = dataReader[1].ToString();
                            string eunumName = subitems[0];
                            if (eunumName.Length == 0)
                                eunumName = "None";
                            eunumName = eunumName.Replace(' ', '_');
                            eunumName = eunumName.Replace('/', '_');
                            eunumName = eunumName.Replace('.', '_');
                            streamWriter.WriteLine("case \"" + eunumName + "\": return \"" + subitems[1] +"\";");         

                        }
                        dataReader.Close();


                        streamWriter.WriteLine("};");
                        streamWriter.WriteLine("return null;");
                        streamWriter.WriteLine("}");
                        streamWriter.WriteLine("}");                        
                        
                    }
                }


            }
        }
    }

