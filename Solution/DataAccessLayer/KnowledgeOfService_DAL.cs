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
  public  class KnowledgeOfService_DAL
    {
      ContextDetails globalContextDetails;
        public KnowledgeOfService_DAL()
        {

        }
        public KnowledgeOfService_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
      public long GetKnowledgeOfserviceMasterAndChildByOrgID(int OrgID, out List<KnowledgeOfService> lstKnowledgeOfService, out List<KnowledgeOfServiceAttributes> lstKnowledgeOfServiceAttributes)
      {

          long returnCode = -1;
          lstKnowledgeOfService = new List<KnowledgeOfService>();
          lstKnowledgeOfServiceAttributes = new List<KnowledgeOfServiceAttributes>();
          SqlCommand cmd = Command.pGetKnowledgeOfserviceMasterAndChildByOrgIDCommand(OrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
          DataSet ds = new DataSet();
          try
          {

              using (DBEngine dbEngine = new DBEngine())
              {

                  dbEngine.ExecuteDataSet(cmd, out ds);
              }

              if (ds.Tables[0].Rows.Count > 0)
              {

                  returnCode = Utilities.ConvertTo(ds.Tables[0], out lstKnowledgeOfService);
              }
              if (ds.Tables[1].Rows.Count > 0)
              {

                  returnCode = Utilities.ConvertTo(ds.Tables[1], out lstKnowledgeOfServiceAttributes);
              }

          }

          catch (Exception ex)
          {

              CLogger.LogError("Error while executing Load GetKnowledgeOfService in Patient_DAL", ex);
          }

          return returnCode;
      }
    }
}
