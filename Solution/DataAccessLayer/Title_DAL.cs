using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Collections.Generic;
using System.ComponentModel;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.BusinessEntities;
using System.Data.SqlClient;
using Attune.Podium.Common;

namespace Attune.Solution.DAL
{
    public class Title_DAL
    {
        ContextDetails globalContextDetails;
        public Title_DAL()
        {
            
        }
        public Title_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long GetTitles(int OrgID, string LanguageCode,out List<Salutation> titles)
        {
            long returnCode = -1;
           IDataReader dataReader = null;
            titles = new List<Salutation>();
            try
            {
                SqlCommand cmd = Command.pGetSalutationCommand(OrgID, LanguageCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dBEngine = new DBEngine())
                {
                    dataReader = dBEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out titles);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetTitles Title_DAL", e);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            } 
            return returnCode;
        }

      

      
        public long GetMetaData(out List<DateAttributes> lstDate,out List<Gender> lstgender,out List<MaritalStatus> lstMaritalStatus)
        {
            long returnCode = -1;
            DataSet ds = new DataSet();
            lstDate = new List<DateAttributes>();
            lstgender = new List<Gender>();

            lstMaritalStatus = new List<MaritalStatus>();
           
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "pGetMetaData";
          
            try
            {

                using (DBEngine dBEngine = new DBEngine())
                {
                    dBEngine.ExecuteDataSet(sqlCommand, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDate);
                    }
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[1], out lstgender);
                    }
                    if (ds.Tables[2].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[2], out lstMaritalStatus);
                    }
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("There is a problem in loading metadata", ex);
            }
            return returnCode;
        }

        public long GetProgressNotesTemplate(int TemplateID,out List<ProgressiveTemplate> lstTemplate)
        {
            long returnCode = -1;
            lstTemplate = new List<ProgressiveTemplate>();
            SqlCommand cmd = Command.pGetProgressiveTemplateCommand(TemplateID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstTemplate);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting Progress Template", ex);
            }
            return returnCode;
        }

        public long GetTemplate(out List<ProgressiveTemplate> lstProgressTemplate)
        {
            long returnCode = -1;
            DataSet ds = new DataSet();
            lstProgressTemplate = new List<ProgressiveTemplate>();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "pGetProgressTemplate";
            using (DBEngine dBEngine = new DBEngine())
            {
                dBEngine.ExecuteDataSet(sqlCommand, out ds);
                if (ds.Tables.Count > 0)
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstProgressTemplate);
            }
            return returnCode;
        }
        public long InsertProgressTemplate(long PatientID,long PatientVisitID,string Subjective,String Objective, string Assesment,string Plan,string PhysicianName,DateTime ReviewDate)
        {
            long returnCode = -1;

            SqlCommand cmd = Command.pInsertProgressiveNotesCommand(PatientVisitID, PatientID, Subjective, Objective, Assesment, Plan, PhysicianName, ReviewDate, 0, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteNonQuery(cmd);
                }
               
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting Progress Template", ex);
            }
            return returnCode;
        }


        public long GetProgessiveNotes(long PatientVisitID,out List<PatientProgressive> lstPatientProgressive)
        {
            long returnCode = -1;
            lstPatientProgressive = new List<PatientProgressive>();
            SqlCommand cmd = Command.pGetPatientProgressiveCommand(PatientVisitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
             DataSet ds = new DataSet();
            try
            {
                using (DBEngine dBEngine = new DBEngine())
                {
                    dBEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientProgressive);
                    }
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting Progress Template", ex);
            }
            return returnCode;
        }



         
            


    }
}
