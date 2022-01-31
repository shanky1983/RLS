using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Attune.Solution.QMSBusinessEntities;
using System.Data.SqlClient;
using Attune.Solution.QMSDataAccessLayer;
using Attune.Podium.Common;
using System.Data;

namespace Attune.Solution.QMSBusinessLogic
{
    public class ExternalAudit_BL
    {
        ContextDetails globalContextDetails;

        public ExternalAudit_BL()
        {
        }
        public ExternalAudit_BL(ContextDetails _globalContextDetails)
        {
            globalContextDetails = _globalContextDetails;
        }
        public new List<ExternalAudit_QMS> SaveExternalAuditDetails(long OrgID, long AddressID, DateTime FromDate, DateTime ToDate, long AuditNo, string AuditAgency, int MajorNC, int MinorNC, string Auditors, long DeptID,string Status, string ActionType,out long ANO)
        {

            List<ExternalAudit_QMS> objPs = new List<ExternalAudit_QMS>();
            long returncode = -1;
            ANO = -1;
            try
            {
                ExternalAudit_DAL objDal = new ExternalAudit_DAL(globalContextDetails);
                objPs = objDal.SaveExternalAuditDetails(OrgID, AddressID, FromDate, ToDate, AuditNo, AuditAgency, MajorNC, MinorNC, Auditors, DeptID, Status, ActionType,out ANO);

            }
            catch (Exception e)
            {
                CLogger.LogError("Error while loading in pgetGeneralStatistics_DAL", e);
            }
            return objPs;
        }
        public DataSet LoadExternalAuditDetails(long OrgID, long AddressID, DateTime FromDate, DateTime ToDate, long AuditNo, string AuditAgency, int MajorNC, int MinorNC, string Auditors, long DeptID, string Status, string ActionType)
        {

            List<ExternalAudit_QMS> objPs = new List<ExternalAudit_QMS>();
            long returncode = -1;
   
            DataSet ds = new DataSet();
            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            try
            {
                ExternalAudit_DAL objDal = new ExternalAudit_DAL(globalContextDetails);
                ds = objDal.LoadExternalAuditDetails(OrgID, AddressID, FromDate, ToDate, AuditNo, AuditAgency, MajorNC, MinorNC, Auditors, DeptID, Status,ActionType);
              
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while loading in pgetGeneralStatistics_DAL", e);
            }
            return ds;
        }


    }
}
