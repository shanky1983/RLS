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
    public class PatientOldNotes_BL
    {
         ContextDetails globalContextDetails;
        public PatientOldNotes_BL()
        {

        }
        public PatientOldNotes_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        public long getPatientOldNotesBlob(long visitID, out List<Blob> lstBlob, out List<PatientOldNotes> lstPatientOldNotes)
        {
            long returnCode = -1;
            lstBlob = new List<Blob>();
            lstPatientOldNotes = new List<PatientOldNotes>();

            try
            {
                PatientOldNotes_DAL patientOldNotesDAL = new PatientOldNotes_DAL(globalContextDetails);
                returnCode = patientOldNotesDAL.GetPatientOldNotesFileIDs(visitID,out lstBlob, out lstPatientOldNotes);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in getPatientOldNotesBlob BL ", ex);
            }
            return returnCode;

        }
    }
}
