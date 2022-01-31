using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Attune.Podium.BusinessEntities;
using Attune.Podium.Common;
using Attune.Solution.DAL;
using System.Web;
using System.Collections.Specialized;
using System.Web.Caching;
using System.Configuration;
using System.IO;

namespace Attune.Solution.BusinessComponent
{
   public class AuditManager_BL
    {
       ContextDetails globalContextDetails;
        public AuditManager_BL()
        {

        }
        public AuditManager_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
       public long InsertAuditTransactions(List<AuditTransactionDetails> lstATD, string CategoryCode, string TypeCode, long LID, int OrgID, int OrgAddressD)
       {
           long returnCode = -1;

           try
           {
               returnCode = new AuditManager_DAL(globalContextDetails).InsertAuditTransaction(lstATD,CategoryCode, TypeCode, LID, OrgID, OrgAddressD);
           }
           catch (Exception ex)
           {
               CLogger.LogError("Error in InsertAuditTransaction", ex);
           }

           return returnCode;
       }

       public long GetAudit_History(long patientID, int OrgID,string Htype, out List<Patient_HIST> lstPatient_HIST)
       {
           long returnCode = -1;
           AuditManager_DAL AuditManageDAL = new AuditManager_DAL(globalContextDetails);
           lstPatient_HIST = new List<Patient_HIST>();
           try
           {
               returnCode = AuditManageDAL.GetAudit_History(patientID, OrgID, Htype, out lstPatient_HIST);
           }
           catch (Exception ex)
           {
               CLogger.LogError("Error while executing GetAudit_History", ex);
           }
           return returnCode;
       }

       public long GetAudit_History(long patientID, int OrgID, string Htype, out List<Login_HIST> lstLogin_HIST, out List<Users_HIST> lstUsers_HIST)
       {
           long returnCode = -1;
           AuditManager_DAL AuditManageDAL = new AuditManager_DAL(globalContextDetails);
           lstLogin_HIST = new List<Login_HIST>();
           lstUsers_HIST = new List<Users_HIST>();
           try
           {
               returnCode = AuditManageDAL.GetAudit_History(patientID, OrgID, Htype, out lstLogin_HIST, out lstUsers_HIST);
           }
           catch (Exception ex)
           {
               CLogger.LogError("Error while executing GetAudit_History", ex);
           }
           return returnCode;
       }

       public long GetAudit_History(long ProductID, int OrgID, string Htype, out List<Products> lstProducts)
       {
           long returnCode = -1;
           AuditManager_DAL AuditManageDAL = new AuditManager_DAL(globalContextDetails); 
           lstProducts = new List<Products>(); 
           try
           {
               returnCode = AuditManageDAL.GetAudit_History(ProductID, OrgID, Htype, out lstProducts);
           }
           catch (Exception ex)
           {
               CLogger.LogError("Error while executing GetAudit_History", ex);
           }
           return returnCode;
       }

       public long GetAudit_History(int SupplierID, int OrgID, string Htype, out List<Suppliers_HIST> lstSuppliers_HIST)
       {
           long returnCode = -1;
           AuditManager_DAL AuditManageDAL = new AuditManager_DAL(globalContextDetails); 
           lstSuppliers_HIST = new List<Suppliers_HIST>();
           try
           {
               returnCode = AuditManageDAL.GetAudit_History(SupplierID, OrgID, Htype, out lstSuppliers_HIST);
           }
           catch (Exception ex)
           {
               CLogger.LogError("Error while executing GetAudit_History", ex);
           }
           return returnCode;
       }

    }
}
