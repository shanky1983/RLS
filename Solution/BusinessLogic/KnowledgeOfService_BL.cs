using System;
using System.Data;
using System.Configuration;
using System.Web;
using Attune.Solution.DAL;
using Attune.Podium.BusinessEntities;
using System.Collections.Generic;
using Attune.Podium.Common;

namespace Attune.Solution.BusinessComponent
{
    public class KnowledgeOfService_BL
    {
        ContextDetails globalContextDetails;
        public KnowledgeOfService_BL()
        {

        }
        public KnowledgeOfService_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long GetKnowledgeOfserviceMasterAndChildByOrgID(int OrgID, out List<KnowledgeOfService> lstKnowledgeOfService, out List<KnowledgeOfServiceAttributes> lstKnowledgeOfServiceAttributes)
        {

            long returnCode = -1;
            lstKnowledgeOfService =new List<KnowledgeOfService>();
            lstKnowledgeOfServiceAttributes = new List<KnowledgeOfServiceAttributes>();
            try
            {

                KnowledgeOfService_DAL KnowledgeOfServiceDAL = new KnowledgeOfService_DAL(globalContextDetails);
                returnCode = KnowledgeOfServiceDAL.GetKnowledgeOfserviceMasterAndChildByOrgID(OrgID, out lstKnowledgeOfService, out lstKnowledgeOfServiceAttributes);
            }

            catch (Exception excep)
            {

                CLogger.LogError("Error while executing GetKnowledgeOfService in Patient_BL", excep);
            }

            return returnCode;
        }
    }
}
