using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace OrgChangeTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void BindGrid()
        {
            try
            {
                string connectionString = txtConnection.Text;
                // string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString.ToString();
                //SqlConnection con = new SqlConnection(connectionString);
                //con.Open();
                if (connectionString != null && connectionString != string.Empty)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();

                        StringBuilder sb = new StringBuilder();

                        sb.Append(";With Indexinfo as");
                        sb.AppendLine();
                        sb.Append("(");
                        sb.AppendLine();
                        sb.Append("select OBJECT_NAME(SC.id) as Tablename,Sc.Name as Colname ,ST.name as Datatype ,tp.name as IndexName,tp.indid");
                        sb.AppendLine();
                        sb.Append("from sys.sysobjects SO");
                        sb.AppendLine();
                        sb.Append("Inner join sys.syscolumns SC on SO.id = sc.id");
                        sb.AppendLine();
                        sb.Append("Inner join sys.systypes ST on SC.xusertype = ST.xusertype");
                        sb.AppendLine();
                        sb.Append("outer apply");
                        sb.AppendLine();
                        sb.Append("(");
                        sb.AppendLine();
                        sb.Append("Select SI.name,SI.indid");
                        sb.AppendLine();
                        sb.Append("from sys.partitions Pat");
                        sb.AppendLine();
                        sb.Append("Inner join sys.sysindexes SI on Pat.object_id = SI.id and Pat.index_id = SI.indid");
                        sb.AppendLine();
                        sb.Append("Inner join sys.sysindexkeys  IdxKey (nolock) on SI.id = IdxKey.id and SI.indid = IdxKey.indid");
                        sb.AppendLine();
                        sb.Append("Inner join sys.syscolumns Col (nolock) on IdxKey.id = col.id  and IdxKey.colid = col.colid");
                        sb.AppendLine();
                        sb.Append("where Col.id = SO.id and Col.name = sc.name");
                        sb.AppendLine();
                        sb.Append(") tp");
                        sb.AppendLine();
                        sb.Append("where SO.type = 'U'");
                        sb.AppendLine();
                        sb.Append("and SC.name in ('organizationid','Organisationid')");
                        sb.AppendLine();
                        sb.Append(")");
                        sb.AppendLine();
                        sb.Append("select Tablename,Colname,Datatype,IndexName,ind.indid");
                        sb.AppendLine();
                        sb.Append(",' Drop index '+Ind.IndexName+' on '+Ind.Tablename as Dropindexscript,");
                        sb.AppendLine();
                        sb.Append("'Alter table '+Ind.tablename+' Alter Column '+ind.colname+' int' as ExecuteFirst,");
                        sb.AppendLine();
                        sb.Append("'exec Sp_rename '''+Ind.tablename+'.'+ ind.colname+''', ''OrgID''' as ExecuteSecond,");
                        sb.AppendLine();
                        sb.Append("(Select 'Create '+case when idx.index_id = 1 then 'Clustered Index ' else 'NonClustered Index ' end+");
                        sb.AppendLine();
                        sb.Append("'NIDX_'+obj.name+'_'+");
                        sb.AppendLine();
                        sb.Append("stuff");
                        sb.AppendLine();
                        sb.Append("(");
                        sb.AppendLine();
                        sb.Append("(");
                        sb.AppendLine();
                        sb.Append("Select");
                        sb.AppendLine();
                        sb.Append("'_'+col.name");
                        sb.AppendLine();
                        sb.Append("from sys.sysindexkeys  IdxKey (nolock)");
                        sb.AppendLine();
                        sb.Append("Inner join sys.syscolumns Col (nolock) on IdxKey.id = col.id  and IdxKey.colid = col.colid");
                        sb.AppendLine();
                        sb.Append("where IdxKey.id = idx.object_id and IdxKey.indid = idx.index_id");
                        sb.AppendLine();
                        sb.Append("and IdxKey.keyno <> 0");
                        sb.AppendLine();
                        sb.Append("order by keyno");
                        sb.AppendLine();
                        sb.Append("for xml path('')");
                        sb.AppendLine();
                        sb.Append(")");
                        sb.AppendLine();
                        sb.Append(",1,1,''");
                        sb.AppendLine();
                        sb.Append(")+' on '+obj.name+' ('+");
                        sb.AppendLine();
                        sb.Append("stuff");
                        sb.AppendLine();
                        sb.Append("(");
                        sb.AppendLine();
                        sb.Append("(");
                        sb.AppendLine();
                        sb.Append("Select");
                        sb.AppendLine();
                        sb.Append("','+Quotename(col.name)");
                        sb.AppendLine();
                        sb.Append("from sys.sysindexkeys  IdxKey (nolock)");
                        sb.AppendLine();
                        sb.Append("Inner join sys.syscolumns Col (nolock) on IdxKey.id = col.id  and IdxKey.colid = col.colid");
                        sb.AppendLine();
                        sb.Append("where IdxKey.id = idx.object_id and IdxKey.indid = idx.index_id");
                        sb.AppendLine();
                        sb.Append("and IdxKey.keyno <> 0");
                        sb.AppendLine();
                        sb.Append("order by keyno");
                        sb.AppendLine();
                        sb.Append("for xml path('')),1,1,'')+')'+");
                        sb.AppendLine();
                        sb.Append("Case when");
                        sb.AppendLine();
                        sb.Append("ISNULL(");
                        sb.AppendLine();
                        sb.Append("stuff");
                        sb.AppendLine();
                        sb.Append("(");
                        sb.AppendLine();
                        sb.Append("(");
                        sb.AppendLine();
                        sb.Append("Select");
                        sb.AppendLine();
                        sb.Append("','+Quotename(col.name)");
                        sb.AppendLine();
                        sb.Append("from sys.sysindexkeys  IdxKey (nolock)");
                        sb.AppendLine();
                        sb.Append("Inner join sys.syscolumns Col (nolock) on IdxKey.id = col.id  and IdxKey.colid = col.colid");
                        sb.AppendLine();
                        sb.Append("where IdxKey.id = idx.object_id and IdxKey.indid = idx.index_id");
                        sb.AppendLine();
                        sb.Append("and IdxKey.keyno = 0");
                        sb.AppendLine();
                        sb.Append("order by keyno");
                        sb.AppendLine();
                        sb.Append("for xml path('')");
                        sb.AppendLine();
                        sb.Append(")");
                        sb.AppendLine();
                        sb.Append(",1,1,''");
                        sb.AppendLine();
                        sb.Append("),'') <> '' then ' Include ('+");
                        sb.AppendLine();
                        sb.Append("ISNULL(");
                        sb.AppendLine();
                        sb.Append("stuff");
                        sb.AppendLine();
                        sb.Append("(");
                        sb.AppendLine();
                        sb.Append("(");
                        sb.AppendLine();
                        sb.Append("Select");
                        sb.AppendLine();
                        sb.Append("','+Quotename(col.name)");
                        sb.AppendLine();
                        sb.Append("from sys.sysindexkeys  IdxKey (nolock)");
                        sb.AppendLine();
                        sb.Append("Inner join sys.syscolumns Col (nolock) on IdxKey.id = col.id  and IdxKey.colid = col.colid");
                        sb.AppendLine();
                        sb.Append("where IdxKey.id = idx.object_id and IdxKey.indid = idx.index_id");
                        sb.AppendLine();
                        sb.Append("and IdxKey.keyno = 0");
                        sb.AppendLine();
                        sb.Append("order by keyno");
                        sb.AppendLine();
                        sb.Append("for xml path('')");
                        sb.AppendLine();
                        sb.Append(")");
                        sb.AppendLine();
                        sb.Append(",1,1,''");
                        sb.AppendLine();
                        sb.Append("),'')+')'");
                        sb.AppendLine();
                        sb.Append("Else");
                        sb.AppendLine();
                        sb.Append("'' End");
                        sb.AppendLine();
                        sb.Append("From sys.sysobjects obj(nolock)");
                        sb.AppendLine();
                        sb.Append("Inner Join sys.partitions Idx (nolock) on obj.id = idx.object_id");
                        sb.AppendLine();
                        sb.Append("Inner join Sys.sysindexes SI (nolock) on idx.object_id = SI.id and idx.index_id = si.indid");
                        sb.AppendLine();
                        sb.Append("Where obj.name = ind.Tablename and SI.name = ind.Indexname");
                        sb.AppendLine();
                        sb.Append(") as Indexscript");
                        sb.AppendLine();
                        sb.Append("from Indexinfo ind");
                        sb.AppendLine();
                        sb.Append("Order by indid,Tablename");

                        string Comandstr = sb.ToString();
                        using (SqlCommand cmd = new SqlCommand(Comandstr, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                            {
                                using (DataTable dt = new DataTable())
                                {
                                    sda.Fill(dt);
                                    dataGridView1.DataSource = dt;
                                    dataGridView1.Columns[0].Visible = false;
                                    dataGridView1.Columns[1].Visible = false;
                                    dataGridView1.Columns[2].Visible = false;
                                    dataGridView1.Columns[3].Visible = false;
                                    dataGridView1.Columns[4].Visible = false;
                                    dataGridView1.Columns[5].Visible = false;
                                    dataGridView1.Columns[8].Visible = false;

                                    dataGridView1.Columns[6].Width = 400;
                                    dataGridView1.Columns[7].Width = 400;

                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the connection string");
                }
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.ToString());
            }
           
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindGrid();
        }
    }
}
