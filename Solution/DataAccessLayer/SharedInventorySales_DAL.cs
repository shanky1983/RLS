using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Data.SqlClient;
using System.Collections.Generic;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.BusinessEntities;
using Attune.Podium.Common;
using System.Transactions;
namespace Attune.Solution.DAL
{
   public class SharedInventorySales_DAL
    {
        ContextDetails globalContextDetails;
        public SharedInventorySales_DAL()
        {

        }
        public SharedInventorySales_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }


     
        public long GetClientsName(int OrgID, out List<ClientMaster> lstcustomers)
        {
            long returnCode = -1;
            lstcustomers = new List<ClientMaster>();
            DataSet ds = new DataSet();
            SqlCommand objCommand = Command.pGetCustomerNameCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstcustomers);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing Get Customers list in InventorySales_DAL", ex);
            }
            return returnCode;
        }
    }


}
