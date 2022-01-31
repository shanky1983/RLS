using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Attune.Podium.BusinessEntities;
using Attune.Solution.DAL;
using Attune.Podium.Common;

namespace Attune.Solution.BusinessComponent
{
    public class SharedInventorySales_BL
    {

        ContextDetails globalContextDetails;
        public SharedInventorySales_BL()
        {

        }
        public SharedInventorySales_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }


       
        public long GetClientNames(int OrgID, out List<ClientMaster> lstCustomers)
        {
            long returnCode = -1;
            lstCustomers = new List<ClientMaster>();

            SharedInventorySales_DAL inventorySalesDAL = new SharedInventorySales_DAL(globalContextDetails);
            try
            {
                returnCode = inventorySalesDAL.GetClientsName(OrgID, out lstCustomers);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing Get Customer lists in Inventory_BL", ex);
            }
            return returnCode;
        }
    }
}
