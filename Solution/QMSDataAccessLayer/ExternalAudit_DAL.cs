using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Attune.Solution.QMSBusinessEntities;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.Common;
using System.Data.SqlClient;
using System.Data;

namespace Attune.Solution.QMSDataAccessLayer
{
    public class ExternalAudit_DAL
    {
         ContextDetails globalContextDetails;

        public ExternalAudit_DAL()
        {
        }
        public ExternalAudit_DAL(ContextDetails _globalContextDetails)
        {
            globalContextDetails = _globalContextDetails;
        }
   
        public new List<ExternalAudit_QMS> SaveExternalAuditDetails(long OrgID, long AddressID, DateTime FromDate, DateTime ToDate, long AuditNo ,string AuditAgency, int MajorNC, int MinorNC, string Auditors, long DeptID, string Status,string ActionType,out long ANO)
        {
            ANO = -1;
            List<ExternalAudit_QMS> objPs = new List<ExternalAudit_QMS>();
            long returncode = -1;
            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = Command.pSaveLoadExternalauditQMSCommand(OrgID, AddressID, FromDate, ToDate, AuditNo, AuditAgency, MajorNC, MinorNC, Auditors, DeptID, Status,ActionType,out ANO, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                    ANO = Convert.ToInt64(cmd.Parameters["@ANo"].Value);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while loading in pgetGeneralStatistics_DAL", e);
            }
            return objPs;
        }
        public DataSet LoadExternalAuditDetails(long OrgID, long AddressID, DateTime FromDate, DateTime ToDate, long AuditNo, string AuditAgency, int MajorNC, int MinorNC, string Auditors, long DeptID, string Status, string ActionType)
        {
           long  ANo = -1;
            List<ExternalAudit_QMS> objPs = new List<ExternalAudit_QMS>();
            long returncode = -1;
            DataSet ds = new DataSet();
            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = Command.pSaveLoadExternalauditQMSCommand(OrgID, AddressID, FromDate, ToDate,AuditNo, AuditAgency, MajorNC, MinorNC, Auditors, DeptID,Status, ActionType,out ANo, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                   
                    //System.Data.IDataReader IdR = dbEngine.ExecuteReader(cmd);
                    returncode = dbEngine.ExecuteDataSet(cmd, out ds);
                    
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while loading in pgetGeneralStatistics_DAL", e);
            }
            return ds;
        }
    }
}
