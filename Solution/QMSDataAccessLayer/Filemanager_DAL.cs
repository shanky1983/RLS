using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Attune.Solution.QMSBusinessEntities;
using System.Data.SqlClient;
using Attune.Podium.DataAccessEngine;

namespace Attune.Solution.QMSDataAccessLayer
{
    public class Filemanager_DAL
    {
        ContextDetails globalContextDetails;

        public Filemanager_DAL()
        { }

        public Filemanager_DAL(ContextDetails _globalContextDetails)
        {
            globalContextDetails = _globalContextDetails;
        }

        public long SaveFile_DAL(List<QMS_TRFfilemanager> lstfm)
        {
            long returncode = -1;
            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = Command.pSaveQmsFilesCommand(UDT_DAL.ConvertToUDT_TRFfilemanager_QMS(lstfm), UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception e)
            {
               // CLogger.LogError("Error while executig in QMS_SaveAnalyzermappingDetails_DAL", e);
            }
            return returncode;
        
        }
       
    }
}
