using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Attune.Podium.BusinessEntities;
using Attune.Solution.DAL;
using Attune.Podium.Common;
using Attune.Kernel.CacheEngine;

namespace Attune.Solution.BusinessComponent
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

            List<Alacarte> lstMenuItems1 = new List<Alacarte>();
            try
            {
                Utilities objUtilities = new Utilities();
                string KeyValue = string.Empty;
                objUtilities.GetApplicationValue("MenuCache", out KeyValue);
                if (!string.IsNullOrEmpty(KeyValue) && KeyValue == "Y")
                {
                    CacheProvider _cp = new CacheProvider(1);
                    string pkey = _cp.getKey(AttCacheKey.MenuCache, orgID);
                    if (_cp.IsInCache(pkey))
                    {
                        lstMenuItems1 = _cp.Get<List<Alacarte>>(pkey);
                    }
                    else
                    {
                        RoleMenu_DAL rolemenu_DAL = new RoleMenu_DAL(globalContextDetails);
                        returnCode = rolemenu_DAL.GetMenuItems(0, orgID, 0, out lstMenuItems1);
                        if (lstMenuItems1 != null && lstMenuItems1.Count > 0)
                        {
                            _cp.Set(pkey, lstMenuItems1);
                        }
                    }

                    lstMenuItems = lstMenuItems1.FindAll(p => p.RoleID == roleID); 
                    returnCode = 0;
                }
                else
                {
                    RoleMenu_DAL rolemenu_DAL = new RoleMenu_DAL(globalContextDetails);
                    returnCode = rolemenu_DAL.GetMenuItems(roleID, orgID, parentID, out lstMenuItems);
                }

            }
            catch (Exception excp)
            {
			CLogger.LogError("Error while executing GetMenuItems in RoleMenu_BL", excp);
            }

            return returnCode;
        }

        public long GetLocationPageMap(int locationID, int roleID, int orgID, int parentID, out List<Alacarte> lstLocationPageMap)
        {
            long retCode = -1;
            lstLocationPageMap = null;
            try
            {
                RoleMenu_DAL rolemenu_DAL = new RoleMenu_DAL(globalContextDetails);
                retCode = rolemenu_DAL.GetLocationPageMap(locationID, roleID, orgID, parentID, out lstLocationPageMap);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetLocationPageMap", excp);
            }

            return retCode;
        }

       
    }
}
