using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Attune.Solution.QMSBusinessEntities;
using Attune.Podium.Common;
using Attune.Podium.DataAccessEngine;
using System.Data.SqlClient;
using Attune.Solution.QMSBusinessEntities.CustomEntities;

namespace Attune.Solution.QMSDataAccessLayer
{
    public class PNC_DAL
    {
        ContextDetails globalContextDetails;
         public PNC_DAL() { 
        }
         public PNC_DAL(ContextDetails _globalContextDetails)
        {
            globalContextDetails = _globalContextDetails;
        }

         public long ProcessNonConformance_DAL(int orgID, PNCDetails PNC)
        {
            long returnCode = -1;
            try
            {


             
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pSaveProcessNonConformanceCommand(orgID,PNC.ProcessNonConfNo,PNC.DeptID,PNC.ProcessDate,PNC.Description,PNC.ResponsiblePerson,PNC.NCClassification,
                   PNC.RootCause,
                   PNC.Correction,
                   PNC. Correctiveaction,
                   PNC. PreventiveAction,
                   PNC. ProposedCompletionDate,
                   PNC. ActionTaken,
                   PNC. Comments,
                   PNC. Status,  UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in  ProcessNonConformance DAL", ex);
            }
            return returnCode;
        }



         public long GetPNCDetails(int pOrgID, out List<PNCDetails> PNCList, out long PNCNO)
        {
           
            long returncode = -1;
            PNCList = new List<PNCDetails>();
            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            PNCNO = -1;
            try
            {

                cmd = Command.PgetPNCDetailsCommand(pOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails), out PNCNO);
                using (DBEngine dbEngine = new DBEngine())
                {
                    System.Data.IDataReader IdR = dbEngine.ExecuteReader(cmd);
                    returncode = Attune.Podium.Common.Utilities.ConvertTo<PNCDetails>(IdR, out PNCList);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Getting PNCDetails DAL", ex);
            }
            return returncode;
        }
    }
}
