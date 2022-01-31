using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Attune.Solution.QMSBusinessEntities;
using Attune.Solution.QMSDataAccessLayer;
using Attune.Podium.Common;
using System.Data;
using Attune.Solution.QMSBusinessEntities.CustomEntities;

namespace Attune.Solution.QMSBusinessLogic
{
  public  class PNC_BL
    {
        ContextDetails globalContextDetails;
         public PNC_BL() { 
        }
         public PNC_BL(ContextDetails _globalContextDetails)
        {
            globalContextDetails = _globalContextDetails;
        }


         public long ProcessNonConformance_BL(int orgID, PNCDetails PNC)
         {
             long returncode = -1;
          
             try
             {

                 PNC_DAL Obj_DAL = new PNC_DAL(globalContextDetails);
                 returncode = Obj_DAL.ProcessNonConformance_DAL(orgID, PNC);
             }
             catch (Exception ex)
             {
                 CLogger.LogError("Error In ProcessNonConformance_BL", ex);
             }
             return returncode;
         }


         public long GetPNCDetails(int OrgID, out List<PNCDetails> PNCList, out long PNCNO)
         {
             DataTable FileList = new DataTable();
             long returncode = -1;
             PNCList = new List<PNCDetails>();
             PNCNO = -1;
             PNC_DAL objPNC = new PNC_DAL(globalContextDetails);
             try
             {
                 returncode = objPNC.GetPNCDetails(OrgID, out PNCList,out PNCNO);
             }
             catch (Exception ex)
             {
                 CLogger.LogError("Error while Getting (GetPNCDetails) BL", ex);
             }
             return returncode;
         }
        
    }
}
