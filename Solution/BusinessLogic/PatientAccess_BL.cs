using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using Attune.Solution.DAL;
using Attune.Podium.BusinessEntities;
using Attune.Podium.Common;
using System.Data;
using System.IO;

namespace Attune.Solution.BusinessComponent
{
    public class PatientAccess_BL
    {
        ContextDetails globalContextDetails;
        public PatientAccess_BL()
        {

        }
        public PatientAccess_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long pGetVisitSearchDetailByLoginID(long loginID, string fromDate, string toDate, int currentOrgID, string pSearchType, out List<PatientVisit> lstPatientVisit, int startRowIndex, int pageSize, out int totalRows)
        {
            long returnCode = -1;
            totalRows = -1;
            lstPatientVisit = new List<PatientVisit>();
            //DataTable dtOrgIDs = GetOrgIDs(lstTOD);
            try
            {
                returnCode = new PatientAccess_DAL(globalContextDetails).pGetVisitSearchDetailByLoginID(loginID, fromDate, toDate, currentOrgID, pSearchType, out lstPatientVisit, startRowIndex, pageSize, out totalRows);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading pGetVisitSearchDetailbyPNo BL", ex);
            }
            return returnCode;
        }

        public long pCreatePatientLogin(int pOrgID, string pPatientName, long pPatientID, long pLoginID, out string pUName, out string pPwd)
        {
            long returnCode = -1;

            pUName = string.Empty;
            pPwd = string.Empty;

            try
            {
                PatientAccess_DAL PatientDAL = new PatientAccess_DAL(globalContextDetails);
                returnCode = PatientDAL.pCreatePatientLogin(pOrgID, pPatientName, pPatientID, pLoginID, out pUName, out pPwd);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetAdvancePaidDetails", excp);
            }

            return returnCode;
        }

    }
}
