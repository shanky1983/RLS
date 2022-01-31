using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Data.SqlClient;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.BusinessEntities;
using System.Collections.Generic;
using Attune.Podium.Common;
using System.Data.Common;
using System.Transactions;

namespace Attune.Solution.DAL
{
   public  class Speciality_DAL
    {
        ContextDetails globalContextDetails;
        public Speciality_DAL()
        {
            
        }
        public Speciality_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
       public long GetSpeciality(int pOrganizationID,out List<Speciality> lstspeciality)
       {
           long lresult=-1;
              lstspeciality = new List<Speciality >();
           IDataReader dataReader = null;
           SqlCommand cmd = new SqlCommand();
           try
           {
               cmd = Command.pGetSpecialityCommand(pOrganizationID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        lresult = Utilities.ConvertTo(dataReader, out lstspeciality);
                        dataReader.Close();
                    }            
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing speciality" + cmd.CommandText, ex);
            }
           finally
           {
               if (dataReader != null)
               {
                   dataReader.Close();
               }
           } 
            return  lresult;
        }
       public long pViewSpeciality(int pOrganizationID, out List<Speciality> lstspeciality)
       {
           long returnCode = -1;
           DataSet ds = new DataSet();
           lstspeciality = new List<Speciality>();
           SqlCommand cmd = Command.pViewSpecialityCommand(pOrganizationID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
           try
           {
               using (DBEngine dbEngine = new DBEngine())
               {
                   returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
               }
               if (ds.Tables[0].Rows.Count > 0)
               {
                   returnCode = Utilities.ConvertTo(ds.Tables[0], out lstspeciality);
               }
           }
           catch (Exception ex)
           {
               CLogger.LogError("Error while executing speciality" + cmd.CommandText, ex);
           }
           return returnCode;
       }
       public long SearchSpeciality(int OrgID, string specialityName, out List<Speciality> lstspeciality)
       {
           long returnCode = -1;
           SqlCommand objCommand = Command.pSearchSpecialityCommand(OrgID, specialityName,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
           lstspeciality=new List<Speciality>();
           DataSet ds = new DataSet();
           try
           {
               using (DBEngine dbEngine = new DBEngine())
               {
                   dbEngine.ExecuteDataSet(objCommand, out ds);
               }
               if (ds.Tables.Count > 0)
               {
                   returnCode = Utilities.ConvertTo(ds.Tables[0], out lstspeciality);
               }
           }
           catch (Exception excep)
           {
               CLogger.LogError("Error while executing SearchSpeciality in Speciality_DAL", excep);
           }
           return returnCode;
       }
       public long pSaveSpecialityName(Speciality speciality, out long SpecialityID)
       {
           long returnCode = -1;
           SqlCommand cmdSpecialityName = new SqlCommand();
           cmdSpecialityName = Command.pSaveSpecialityNameCommand(speciality.SpecialityName, out SpecialityID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
           cmdSpecialityName.Parameters.Add("@Return", SqlDbType.Int);
           cmdSpecialityName.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

           try
           {
               using (DBEngine dbEngine = new DBEngine(true))
               {
                   dbEngine.ExecuteNonQuery(cmdSpecialityName);
                   returnCode = Convert.ToInt64(cmdSpecialityName.Parameters["@Return"].Value);
                   SpecialityID = Convert.ToInt32(cmdSpecialityName.Parameters["speciality"].Value);
               }
           }
           catch (Exception ex)
           {
               CLogger.LogError("Error while Executing pSaveSpecialityName Speciality_DAL", ex);
           }
           return returnCode;
       }

       public long pUpdateSpecialityName(Speciality speciality)
       {
           long returnCode = -1;
           SqlCommand cmdUpdateSpecialityName = new SqlCommand();
           cmdUpdateSpecialityName = Command.pUpdateSpecialityNameCommand(speciality.SpecialityID, speciality.SpecialityName, speciality.ModifiedBy,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
           cmdUpdateSpecialityName.Parameters.Add("@Return", SqlDbType.Int);
           cmdUpdateSpecialityName.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
           try
           {
               using (DBEngine dbEngine = new DBEngine(true))
               {
                   dbEngine.ExecuteNonQuery(cmdUpdateSpecialityName);
                   returnCode = Convert.ToInt64(cmdUpdateSpecialityName.Parameters["@Return"].Value);
               }
           }
           catch (Exception excep)
           {
               CLogger.LogError("Error while executing pUpdateSpecialityName in Speciality_DAL", excep);
           }
           return returnCode;
       }


       
        
    }
}
