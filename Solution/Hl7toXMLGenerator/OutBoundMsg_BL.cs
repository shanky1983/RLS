using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Attune.Podium.BusinessEntities;
using Attune.Podium.Common;
using Attune.Solution.OutBoundDAL;
using Attune.HL7Integration;
using System.Data;

namespace OutBoundMsgBusinessLogic
{
    public class OutBoundMsg_BL
    {
        ContextDetails globalContextDetails;
        public OutBoundMsg_BL()
        {

        }
        public OutBoundMsg_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long GetOrderedApprovedDetailsForOutBound(int OrgID, long PatientVisitID, long AccesionNumber, string Status, out List<MSH> lstMsh, out List<EVN> lstEvn, out List<PID> lstPID,
            out List<PV1> lstPV1,
            out List<ORC> lstORC, out List<OBR> lstOBR, out List<OBX> lstOBX)
        {
            lstMsh = new List<MSH>();
            lstEvn = new List<EVN>();
            lstPID = new List<PID>();
            lstPV1 = new List<PV1>();
            lstORC = new List<ORC>();
            lstOBR = new List<OBR>();
            lstOBX = new List<OBX>();
            long returnCode = -1;
            try
            {
                OutBoundMsg_DAL OutDAT = new OutBoundMsg_DAL();
                returnCode = OutDAT.GetOrderedApprovedDetailsForOutBound(OrgID, PatientVisitID, AccesionNumber, Status, out lstMsh, out lstEvn, out lstPID, out lstPV1, out lstORC, out lstOBR, out lstOBX);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While GetAuditTrailReport in NewReports_DAL", ex);
            }
            return returnCode;
        }

        public long GetApprovedDataForOutBound(int OrgID, string Status, out List<Hl7OutBoundMessageDetails> lstHl7OutBoundMessageDetails)
        {
            lstHl7OutBoundMessageDetails = new List<Hl7OutBoundMessageDetails>();
            long returnCode = -1;
            try
            {
                OutBoundMsg_DAL OutDAT = new OutBoundMsg_DAL();
                returnCode = OutDAT.GetApprovedDataForOutBound(OrgID, Status, out lstHl7OutBoundMessageDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While GetApprovedDataForOutBound in NewReports_DAL", ex);
            }
            return returnCode;


        }
        public long UpdateOutBoundMsgDetils(long OrgID, DataTable DtApprovedXML)
        {
            long retCode = -1;
            int ret = -1;



            try
            {
                OutBoundMsg_DAL invDAL = new OutBoundMsg_DAL(globalContextDetails);

                retCode = invDAL.UpdateOutBoundMsgDetils(OrgID, DtApprovedXML);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while saving PatientInvestigation Investigation_BL", e);
            }
            return retCode;
        }

        public long getPdfDetails(long OrgID, long VisitID, long AccessionNumber, out List<ContentPDF> lstPDFDetails)
        {
            lstPDFDetails = new List<ContentPDF>();
            long returnCode = -1;
            try
            {
                OutBoundMsg_DAL OutDAT = new OutBoundMsg_DAL();
                returnCode = OutDAT.getPdfDetails(OrgID, VisitID, AccessionNumber, out lstPDFDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While GetApprovedDataForOutBound in NewReports_DAL", ex);
            }
            return returnCode;


        }
        public long GetApprovedDataForOutBoundClinincSys(int OrgID, string Status,string VisitNumber, out List<Hl7OutBoundMessageDetails> lstHl7OutBoundMessageDetails)
        {
            lstHl7OutBoundMessageDetails = new List<Hl7OutBoundMessageDetails>();
            long returnCode = -1;
            try
            {
                OutBoundMsg_DAL OutDAT = new OutBoundMsg_DAL();
                returnCode = OutDAT.GetApprovedDataForOutBoundClinincSys(OrgID, Status,VisitNumber, out lstHl7OutBoundMessageDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While GetApprovedDataForOutBound in NewReports_DAL", ex);
            }
            return returnCode;


        }
    }

}
