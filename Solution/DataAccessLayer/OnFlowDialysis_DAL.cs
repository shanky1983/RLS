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
using System.Data.Common;
using System.Transactions;

namespace Attune.Solution.DAL
{
    public class OnFlowDialysis_DAL
    {
        ContextDetails globalContextDetails;
        public OnFlowDialysis_DAL()
        {

        }
        public OnFlowDialysis_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long GetOnFlowDialysis(long PatientVisitID, out DataSet ds)
        {

            long returnCode = -1;
            SqlCommand objCommand = Command.pGetOnFlowDialysisCommand(PatientVisitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            
            ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }



            return returnCode;
        }

        public long GetOnFlowDialysis1(long PatientVisitID, out List<Dialysis> lstDialysis)
        {

            long returnCode = -1;
            SqlCommand objCommand = Command.pGetOnFlowDialysisCommand(PatientVisitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstDialysis = new List<Dialysis>();

            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }

            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDialysis);

            }

            return returnCode;
        }
    }
}
