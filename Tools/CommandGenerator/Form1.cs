using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.CodeDom;
using GetDatabaseSp;
using System.CodeDom.Compiler;
using System.IO;
using System.Data.SqlClient;
using Microsoft.Win32;
using System.Diagnostics;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private string sqlConnectionString;
        public Form1()
        {
            InitializeComponent();
            using (RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(@"Software\SourceForge\CSharpCommandGen"))
            {
                txtConnection.Text = (string)registryKey.GetValue("Connection", String.Empty);
                txtPath.Text = (string)registryKey.GetValue("Path", String.Empty);
                
            }
        }
        private void Filldtsp(out DataTable dtSp)
        {
            DataSet ds = new DataSet();
                SqlConnection con = new SqlConnection(sqlConnectionString);
                SqlCommand cmd = new SqlCommand();
                dtSp = new DataTable();
                cmd.CommandText = "spRetrieveSPDetails";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dtSp = ds.Tables[0];
            

        }
        // set first charachter to LowerCase 
        private string ToLowerFirstChar(string text)
        {
            char[] chars = text.ToCharArray();
            string s = chars[0].ToString();
            s = s.ToLower();
            chars[0] = s[0];
            StringBuilder sb = new StringBuilder();
            foreach (char ch in chars)
            {
                sb.Append(ch);
            }
            return sb.ToString();
        }

        // set first charachter to UpperCase 
        private string ToUpperFirstChar(string text)
        {
            char[] chars = text.ToCharArray();
            string s = chars[0].ToString();
            s = s.ToUpper();
            chars[0] = s[0];
            StringBuilder sb = new StringBuilder();
            foreach (char ch in chars)
            {
                sb.Append(ch);
            }
            return sb.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnectionString = txtConnection.Text;
                string NameSpace = "Attune.Solution.DAL";                           
                string Class = "Command";
                System.Windows.Forms.Application.DoEvents();
                CodeCompileUnit compileUnit = new CodeCompileUnit();
                CodeNamespace ns = new CodeNamespace(NameSpace);
                ns.Imports.Add(new CodeNamespaceImport("System"));
                ns.Imports.Add(new CodeNamespaceImport("System.Text"));
                ns.Imports.Add(new CodeNamespaceImport("System.Data"));
                ns.Imports.Add(new CodeNamespaceImport("System.Data.SqlClient"));

                // create our class
                CodeTypeDeclaration ctd = new CodeTypeDeclaration(Class);
                ctd.IsClass = true;
                ns.Types.Add(ctd);
                compileUnit.Namespaces.Add(ns);
                //GetdtSP
                DataTable dtSPs = new DataTable();
                DataColumn dcSpName = new DataColumn("SpName");
                DataColumn dcParameterName = new DataColumn("ParameterName");
                DataColumn dcSystemType = new DataColumn("SystemType");
                DataColumn dcLength = new DataColumn("Length");
                DataColumn dcIsOutputParameter = new DataColumn("IsOutputParameter");

                dtSPs = new DataTable();
                dtSPs.Columns.Add(dcSpName);
                dtSPs.Columns.Add(dcParameterName);
                dtSPs.Columns.Add(dcSystemType);
                dtSPs.Columns.Add(dcLength);
                dtSPs.Columns.Add(dcIsOutputParameter);
                Filldtsp(out dtSPs);
                if (dtSPs.Rows.Count == 0 || dtSPs == null)
                {
                    MessageBox.Show("Command Creation Failed.Check The Stored Procedure");
                    return;
                }
                DataTable dtHelper = dtSPs.Clone();
                dtHelper.PrimaryKey = new DataColumn[] { dtHelper.Columns[0] };
                foreach (DataRow row in dtSPs.Rows)
                {
                    if (!dtHelper.Rows.Contains(row["SpName"]))
                    {
                        dtHelper.ImportRow(row);
                        DataRow[] rowCol = dtSPs.Select("SpName = '" + row["SpName"].ToString() + "'");
                        StoredProcedureParameterCollection parameterCollection = new StoredProcedureParameterCollection();
                        foreach (DataRow rowParameter in rowCol)
                        {
                            if (rowParameter["ParameterName"] != DBNull.Value)
                            {
                                StoredProcedureParameter parameter = new StoredProcedureParameter();
                                parameter.ParameterName = rowParameter["ParameterName"].ToString();
                                parameter.ParameterType = rowParameter["SystemType"].ToString();
                                parameter.ParameterLength = rowParameter["Length"] != DBNull.Value ? int.Parse(rowParameter["Length"].ToString()) : -1;
                                if (rowParameter["IsOutputParameter"] != DBNull.Value)
                                {
                                    if (rowParameter["IsOutputParameter"].ToString() == "1")
                                        parameter.IsParameterOutput = true;
                                    else
                                        parameter.IsParameterOutput = false;
                                }
                                else
                                {
                                    parameter.IsParameterOutput = false;
                                }
                                parameterCollection.Add(parameter);
                            }
                        }

                        //this.PrintToLog(string.Format("Generating method for {0} ...", row["SpName"]));
                        System.Windows.Forms.Application.DoEvents();
                        // create method for each storedProcedure in this loop and pass parameters to this method as StoredProcedureParameterCollection object
                        this.CreateMethodForExecuteSP(ctd, row["SpName"].ToString(), parameterCollection);
                        // output is in csharp

                        // finally, generate our code to specified codeProvider
                        
                
                    }
                    
                }
                this.GenerateCode(new Microsoft.CSharp.CSharpCodeProvider(), compileUnit, txtPath.Text+"\\" + Class);

                using (RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(@"Software\SourceForge\CSharpCommandGen"))
                {
                    registryKey.SetValue("Connection", txtConnection.Text, RegistryValueKind.String);
                    registryKey.SetValue("Path", txtPath.Text, RegistryValueKind.String);
				}
                MessageBox.Show("Command Sucessfully Created");
                Process.Start(txtPath.Text);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }
        

        public void GenerateCode(Microsoft.CSharp.CSharpCodeProvider provider, CodeCompileUnit compileUnit, string fileName)
        {
            // Build the source file name with the appropriate
            // language extension.
            String sourceFile;
            if (provider.FileExtension[0] == '.')
            {
                sourceFile = fileName + provider.FileExtension;
            }
            else
            {
                sourceFile = fileName + "." + provider.FileExtension;
            }

            // Create an IndentedTextWriter, constructed with
            // a StreamWriter to the source file.
            File.Delete(sourceFile);
            IndentedTextWriter tw = new IndentedTextWriter(new StreamWriter(sourceFile, true), "    ");

            // Generate source code using the code generator.
            provider.GenerateCodeFromCompileUnit(compileUnit, tw, new CodeGeneratorOptions());

            // Close the output file.
            tw.Close();
        }



            private void CreateMethodForExecuteSP(CodeTypeDeclaration ctd, string spName,StoredProcedureParameterCollection parameterCollection)
        {
            int iTimeoutValue = 180;
            StoredProcedureParameter outPutParameterInfo = null;
            CodeVariableDeclarationStatement commandOutputParameterInfo = null;
            CodeAssignStatement assignReturnedValueToOutputParameter = null;

            // declaration method
            CodeMemberMethod method = new CodeMemberMethod();
           method.Attributes =( method.Attributes & ~MemberAttributes.AccessMask) | MemberAttributes.Public;
           method.Attributes = (method.Attributes & ~MemberAttributes.ScopeMask) | MemberAttributes.Static;
            method.ReturnType = new CodeTypeReference(typeof(SqlCommand));
            method.Name = spName+"Command";
                
            
            CodeVariableDeclarationStatement cvds_cmd = new CodeVariableDeclarationStatement(typeof(SqlCommand), "cmd");
            CodeAssignStatement assignment_new_cmd = new CodeAssignStatement(new CodeVariableReferenceExpression(cvds_cmd.Name), new CodeObjectCreateExpression(typeof(SqlCommand)));
            CodeAssignStatement assignment_cmd_commandText = new CodeAssignStatement(new CodePropertyReferenceExpression(new CodeVariableReferenceExpression(cvds_cmd.Name), "CommandText"), new CodePrimitiveExpression(spName));
            CodeAssignStatement assignment_cmd_commandtimeout = new CodeAssignStatement(new CodePropertyReferenceExpression(new CodeVariableReferenceExpression(cvds_cmd.Name), "CommandTimeout"), new CodePrimitiveExpression(iTimeoutValue));
            CodeAssignStatement assignment_cmd_commandType = new CodeAssignStatement(new CodePropertyReferenceExpression(new CodeVariableReferenceExpression(cvds_cmd.Name), "CommandType"), new CodeSnippetExpression("CommandType.StoredProcedure"));
            // return Command object
            CodeMethodReturnStatement return_method = new CodeMethodReturnStatement(new CodeVariableReferenceExpression(cvds_cmd.Name));
                       
            method.Statements.Add(cvds_cmd);
            method.Statements.Add(assignment_new_cmd);
            method.Statements.Add(assignment_cmd_commandText);
            method.Statements.Add(assignment_cmd_commandtimeout);
            method.Statements.Add(assignment_cmd_commandType);
                                 
            // define method parameters
            if (parameterCollection.Count > 0)
            {
                foreach (StoredProcedureParameter parameter in parameterCollection)
                {
                    if (parameter.ParameterName != "NULL")
                    {
                        CodeParameterDeclarationExpression method_parameter = new CodeParameterDeclarationExpression(this.GetParameterType(parameter), parameter.ParameterName.Replace("@", ""));
                        if (parameter.IsParameterOutput)
                            method_parameter.Direction = FieldDirection.Out;
                        method.Parameters.Add(method_parameter);
                        
                        if (parameter.IsParameterOutput)
                        {
                            commandOutputParameterInfo = new CodeVariableDeclarationStatement(this.GetParameterType(parameter), "_" + parameter.ParameterName.Replace("@", ""), new CodeObjectCreateExpression(typeof(System.Data.SqlClient.SqlParameter)));
                            if (this.GetParameterType(parameter) == typeof(int)
                                || this.GetParameterType(parameter) == typeof(Int16)
                                || this.GetParameterType(parameter) == typeof(Int32)
                                || this.GetParameterType(parameter) == typeof(Int64)
                                || this.GetParameterType(parameter) == typeof(decimal)
                                || this.GetParameterType(parameter) == typeof(float)
                                || this.GetParameterType(parameter) == typeof(double))  
                                                     
                            {
                                CodeAssignStatement initializeOutputVariable = new CodeAssignStatement(new CodeVariableReferenceExpression(method_parameter.Name), new CodeSnippetExpression("-1"));                                
                                method.Statements.Add(initializeOutputVariable);
                            }
                            else if (this.GetParameterType(parameter) == typeof(byte))
                            {
                                CodeAssignStatement initializeOutputVariable = new CodeAssignStatement(new CodeVariableReferenceExpression(method_parameter.Name), new CodeSnippetExpression("0"));
                                method.Statements.Add(initializeOutputVariable);
                            }
                            else if (this.GetParameterType(parameter) == typeof(bool))
                            {
                                CodeAssignStatement initializeOutputVariable = new CodeAssignStatement(new CodeVariableReferenceExpression(method_parameter.Name), new CodeSnippetExpression("false"));
                                method.Statements.Add(initializeOutputVariable);
                            }
                            else if (this.GetParameterType(parameter) == typeof(Guid))
                            {
                                CodeAssignStatement initializeOutputVariable = new CodeAssignStatement(new CodeVariableReferenceExpression(method_parameter.Name), new CodeSnippetExpression("System.Guid.Empty"));
                                method.Statements.Add(initializeOutputVariable);
                            }

                            else if (this.GetParameterType(parameter) == typeof(DataTable))
                            {
                                CodeAssignStatement initializeOutputVariable = new CodeAssignStatement(new CodeVariableReferenceExpression(method_parameter.Name), new CodeSnippetExpression("null"));
                                method.Statements.Add(initializeOutputVariable);
                            }

                            else
                            {
                                CodeAssignStatement initializeOutputVariable = new CodeAssignStatement(new CodeVariableReferenceExpression(method_parameter.Name), new CodeSnippetExpression("null"));
                                method.Statements.Add(initializeOutputVariable);
                            }
                        }

                        CodeVariableDeclarationStatement commandParameter = new CodeVariableDeclarationStatement(typeof(System.Data.SqlClient.SqlParameter), "_" + parameter.ParameterName.Replace("@", ""), new CodeObjectCreateExpression(typeof(System.Data.SqlClient.SqlParameter)));
                        CodeAssignStatement assign_parameter_name = new CodeAssignStatement(new CodePropertyReferenceExpression(new CodeVariableReferenceExpression(commandParameter.Name), "ParameterName"), new CodePrimitiveExpression(parameter.ParameterName));
                        CodeAssignStatement assign_parameter_size = new CodeAssignStatement(new CodePropertyReferenceExpression(new CodeVariableReferenceExpression(commandParameter.Name), "Size"), new CodeSnippetExpression(parameter.ParameterLength.ToString()));
                        CodeAssignStatement assign_parameter_value = new CodeAssignStatement(new CodePropertyReferenceExpression(new CodeVariableReferenceExpression(commandParameter.Name), "Value"), new CodeArgumentReferenceExpression(method_parameter.Name));
                        CodeMethodInvokeExpression add_parameter = new CodeMethodInvokeExpression(new CodeVariableReferenceExpression(cvds_cmd.Name), "Parameters.Add", new CodeVariableReferenceExpression(commandParameter.Name));
                        method.Statements.Add(commandParameter);
                        method.Statements.Add(assign_parameter_name);
                        method.Statements.Add(assign_parameter_size);
                        method.Statements.Add(assign_parameter_value);
                        method.Statements.Add(add_parameter);


                        if (parameter.IsParameterOutput)
                        {
                            CodeAssignStatement assign_parameter_direction = new CodeAssignStatement(new CodePropertyReferenceExpression(new CodeVariableReferenceExpression(commandParameter.Name), "Direction"), new CodeSnippetExpression("ParameterDirection.Output"));
                            method.Statements.Add(assign_parameter_direction);

                            // if parameter is output, then copy parameter information to outPutParameterInfo
                            outPutParameterInfo = new StoredProcedureParameter(parameter.ParameterName,parameter.ParameterType,parameter.ParameterLength,parameter.IsParameterOutput);                            
                        }
                    }
                }                

                // check if outPutParameterInfo is not null (output parameter exist in the method) then pass returned value from 
                // storedProcedure parameter to this object
                if (outPutParameterInfo != null)
                {
                    if (commandOutputParameterInfo != null)
                    {                        
                        assignReturnedValueToOutputParameter = new CodeAssignStatement(new CodeVariableReferenceExpression(commandOutputParameterInfo.Name.Replace("_","")), new CodeCastExpression(commandOutputParameterInfo.Type, new CodePropertyReferenceExpression(new CodeVariableReferenceExpression("_" + outPutParameterInfo.ParameterName.Replace("@", "")), "Value")));
                    }
                }
            }           

            if (assignReturnedValueToOutputParameter != null)
                method.Statements.Add(assignReturnedValueToOutputParameter);      
            method.Statements.Add(return_method);
            ctd.Members.Add(method);
        }

        // get type of each stored procedure parameter
        private Type GetParameterType(StoredProcedureParameter item)
        {
            Type fieldType;
            if (item.ParameterType.ToLower() == SqlDbType.TinyInt.ToString().ToLower())
                fieldType = typeof(System.Byte);
            else if (item.ParameterType.ToLower() == SqlDbType.SmallInt.ToString().ToLower())
                fieldType = typeof(System.Int16);
            else if (item.ParameterType.ToLower() == SqlDbType.Int.ToString().ToLower())
                fieldType = typeof(System.Int32);
            else if (item.ParameterType.ToLower() == SqlDbType.BigInt.ToString().ToLower())
                fieldType = typeof(System.Int64);
            else if (item.ParameterType.ToLower() == SqlDbType.Money.ToString().ToLower())
                fieldType = typeof(System.Single);
            else if (item.ParameterType.ToLower() == SqlDbType.Float.ToString().ToLower())
                fieldType = typeof(System.Double);
            else if (item.ParameterType.ToLower() == SqlDbType.Char.ToString().ToLower() || item.ParameterType.ToLower() == SqlDbType.NChar.ToString().ToLower() || item.ParameterType.ToLower() == SqlDbType.VarChar.ToString().ToLower() || item.ParameterType.ToLower() == SqlDbType.NVarChar.ToString().ToLower() || item.ParameterType.ToLower() == SqlDbType.Text.ToString().ToLower() || item.ParameterType.ToLower() == SqlDbType.NText.ToString().ToLower() || item.ParameterType.ToLower() == SqlDbType.Xml.ToString().ToLower())
                fieldType = typeof(System.String);
            else if (item.ParameterType.ToLower() == SqlDbType.Decimal.ToString().ToLower() || item.ParameterType.ToLower() == SqlDbType.Real.ToString().ToLower())
                fieldType = typeof(System.Decimal);
            else if (item.ParameterType.ToLower() == SqlDbType.Image.ToString().ToLower() || item.ParameterType.ToLower() == SqlDbType.VarBinary.ToString().ToLower())
                fieldType = typeof(System.Byte[]);
            else if (item.ParameterType.ToLower() == SqlDbType.SmallDateTime.ToString().ToLower() || item.ParameterType.ToLower() == SqlDbType.Date.ToString().ToLower() || item.ParameterType.ToLower() == SqlDbType.DateTime.ToString().ToLower() || item.ParameterType.ToLower() == SqlDbType.DateTime2.ToString().ToLower())
                fieldType = typeof(System.DateTime);
            else if (item.ParameterType.ToLower() == SqlDbType.DateTimeOffset.ToString().ToLower())
                fieldType = typeof(System.DateTimeOffset);
            else if (item.ParameterType.ToLower() == SqlDbType.Bit.ToString().ToLower())
                fieldType = typeof(System.Boolean);
            else if (item.ParameterType.ToLower() == SqlDbType.UniqueIdentifier.ToString().ToLower())
                fieldType = typeof(System.Guid);
            else if (item.ParameterType.ToLower() == "table type")
                fieldType = typeof(System.Data.DataTable);            
            else
                fieldType = typeof(System.Object);
            return fieldType;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog opnFil = new FolderBrowserDialog();
            using (RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(@"Software\SourceForge\CSharpCommandGen"))
            {
                opnFil.SelectedPath = (string)registryKey.GetValue("Path", String.Empty);
            }
            if (opnFil.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = opnFil.SelectedPath;
            }
        }

       

        }

    }

