using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Attune.Solution.QMSBusinessEntities;
using Attune.Solution.QMSDataAccessLayer;
using Attune.Podium.Common;

namespace Attune.Solution.QMSBusinessLogic
{
    public class Filemanager_BL
    {
        ContextDetails globalContextDetails;

        public Filemanager_BL()
        { }

        public Filemanager_BL(ContextDetails _globalContextDetails)
        {
            globalContextDetails = _globalContextDetails;
        }
        
        public long SaveFile_BL(List<QMS_TRFfilemanager> lstfm)
        {
            long returncode = -1;
            Filemanager_DAL objfM = new Filemanager_DAL(globalContextDetails);
            try
            {
                returncode = objfM.SaveFile_DAL(lstfm);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while (SaveFile_DAL) BL", ex);
            }
            return returncode;
        }

    }
}
