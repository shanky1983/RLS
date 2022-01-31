using System;
using System.Data;
using System.Data.SqlClient;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.BusinessEntities;
using System.Configuration;
using System.Web;
using System.Collections;
using System.Collections.Generic;
using Attune.Podium.Common;
using System.Transactions;

namespace Attune.Solution.DAL
{
    public class PatientOldNotes_DAL
    {
        ContextDetails globalContextDetails;
        public PatientOldNotes_DAL()
        {

        }
        public PatientOldNotes_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long GetPatientOldNotesFileIDs(long visitID, out List<Blob> lstBlob, out List<PatientOldNotes> lstPatientOldNotes)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetPatientOldNotesDetailsCommand(visitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstBlob = new List<Blob>();
            lstPatientOldNotes = new List<PatientOldNotes>();

            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientOldNotes);
            }

            if (ds.Tables[1].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[1], out lstBlob);
            }

            return returnCode;
        }
    }
}
