using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Attune.Podium.Common;
using Attune.Solution.QMSBusinessEntities;
using Attune.Solution.QMSDataAccessLayer;

namespace Attune.Solution.QMSBusinessLogic
{
    public class RoleMenu_BL
    {
          ContextDetails globalContextDetails;
        public RoleMenu_BL()
        {

        }
        public RoleMenu_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long GetMenuItems(int roleID, int orgID, int parentID, out List<Alacarte> lstMenuItems)
        {
            long returnCode = -1;

            lstMenuItems = null;
            try
            {
                RoleMenu_DAL rolemenu_DAL = new RoleMenu_DAL(globalContextDetails);
                returnCode = rolemenu_DAL.GetMenuItems(roleID, orgID, parentID, out lstMenuItems);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetMenuItems", excp);
            }

            return returnCode;
        }

        //public long GetLocationPageMap(int locationID, int roleID, int orgID, int parentID, out List<Alacarte> lstLocationPageMap)
        //{
        //    long retCode = -1;
        //    lstLocationPageMap = null;
        //    try
        //    {
        //        RoleMenu_DAL rolemenu_DAL = new RoleMenu_DAL(globalContextDetails);
        //        retCode = rolemenu_DAL.GetLocationPageMap(locationID, roleID, orgID, parentID, out lstLocationPageMap);
        //    }
        //    catch (Exception excp)
        //    {
        //        CLogger.LogError("Error while executing GetLocationPageMap", excp);
        //    }

        //    return retCode;
        //}

       
    }
}
