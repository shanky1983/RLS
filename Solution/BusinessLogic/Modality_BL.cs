using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using Attune.Solution.DAL;
using Attune.Podium.BusinessEntities;
using Attune.Podium.Common;

/// <summary>
/// Summary description for Physician_BL
/// </summary>
/// 
namespace Attune.Solution.BusinessComponent
{
    public class Modality_BL
    {
         ContextDetails globalContextDetails;
         public Modality_BL()
         {
             //
             // TODO: Add constructor logic here
             //
         }
        public Modality_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
       
        public long GetModalityListByOrg(int orgID, out List<Modality> lstModality)
        {
            long returnCode = -1;
            lstModality = null;
            try
            {

                Modality_DAL ModalityDAL = new  Modality_DAL(globalContextDetails);
                returnCode = ModalityDAL.GetModalityListByOrg(orgID, out lstModality);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetModalityListByOrg", excp);
            }

            return returnCode;
        }

    }
}
