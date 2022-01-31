using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using Attune.Solution.DAL;
using Attune.Podium.Common;
using Attune.Podium.BusinessEntities;
using System.Collections;

namespace Attune.Solution.BusinessComponent
{
    public class Banners_BL 
    {
        ContextDetails globalContextDetails;
        public Banners_BL() 
        {

        }
        public Banners_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long GetBannersText(long pRoleID, long pLoginID, int pOrgID, out List<Banners> lstBanners)
        {
            long returnCode = -1;
            lstBanners = new List<Banners>();
            try
            {
                returnCode = new Banners_DAL(globalContextDetails).GetBannersText(pRoleID, pLoginID, pOrgID, out lstBanners);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Errror in BL GetBannersText", ex);
            }

            return returnCode;
        }
    }
}
