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
  public  class Theme_BL
    {
         ContextDetails globalContextDetails;
        public Theme_BL()
        {

        }
        public Theme_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        //code here
        public long UpdateThemeByLID(long lid, long ThemeID)
        {
            long returnCode = -1;

            try
            {
                returnCode = new  Theme_DAL(globalContextDetails).UpdateThemeByLID(lid, ThemeID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL UpdateThemeByLID", ex);
            }

            return returnCode;
        }


        public long GetTheme(out  List<Theme> lstTheme)
        {
            long returnCode = -1;
            lstTheme = new List<Theme>();
            try
            {

                Theme_DAL Themename_DAL = new Theme_DAL(globalContextDetails);
                returnCode = Themename_DAL.GetTheme(out lstTheme);

            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetLocationPageMap", excp);
            }

            return returnCode;
        }

    }
}
