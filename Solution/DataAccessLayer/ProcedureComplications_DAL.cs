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
    public class ProcedureComplications_DAL
    {
        ContextDetails globalContextDetails;
        public ProcedureComplications_DAL()
        {

        }
        public ProcedureComplications_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long GetComplications(int procedureID,out List<Complication> parent, out List<Complication> child)
        {
            long returnCode = -1;
            using (DBEngine dBEngine = new DBEngine())
            {
                DataSet ds = new DataSet();
                parent = new List<Complication>();
                child = new List<Complication>();

                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetProcedureComplicationsCommand(procedureID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                returnCode = dBEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 1)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out parent);
                    if (returnCode == 0)
                        returnCode = Utilities.ConvertTo(ds.Tables[1], out child);
                }
            }
            return returnCode;
        }
    }
}
