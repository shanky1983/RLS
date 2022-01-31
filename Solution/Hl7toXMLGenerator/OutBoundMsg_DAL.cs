using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Attune.Podium.BusinessEntities;
using Attune.Podium.DataAccessLayer;
using OutBoundMsgExportCommand;
using System.Data.SqlClient;
using Attune.HL7Integration;
using OutBoundMsgDataAccessLayer;
using System.Web;
using System.Data;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.Common;

namespace Attune.Solution.OutBoundDAL
{
    public class OutBoundMsg_DAL
    {
        ContextDetails globalContextDetails;
        public OutBoundMsg_DAL()
        {

        }
        public OutBoundMsg_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long GetOrderedApprovedDetailsForOutBound(int OrgID, long PatientVisitID, long AccessionNumber, string Status, out List<MSH> lstMsh, out List<EVN> lstEvn, out List<PID> lstPID,
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
                SqlCommand cmd = new SqlCommand();

                cmd = OutBoundMsgCommand.pGetOrderedApprovedDetailsForOutBoundCommand(OrgID, PatientVisitID, AccessionNumber, Status, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstMsh);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstEvn);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstPID);
                }
                if (ds.Tables[3].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[3], out lstPV1);
                }
                if (ds.Tables[4].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[4], out lstORC);
                }
                if (ds.Tables[5].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[5], out lstOBR);
                }

                if (ds.Tables[6].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[6], out lstOBX);
                }


            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While GetOrderedApprovedDetailsForOutBound in NewReports_DAL", ex);
            }
            return returnCode;
        }
        public long GetApprovedDataForOutBound(int OrgID, string Status, out List<Hl7OutBoundMessageDetails> lstHl7OutBoundMessageDetails)
        {
            lstHl7OutBoundMessageDetails = new List<Hl7OutBoundMessageDetails>();

            long returnCode = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd = OutBoundMsgCommand.pGetApprovedListForOutBoundCommand(OrgID, Status, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstHl7OutBoundMessageDetails);
                }



            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While GetOrderedApprovedDetailsForOutBound in NewReports_DAL", ex);
            }
            return returnCode;
        }
        public long GetApprovedDataForOutBoundClinincSys(int OrgID, string Status, string VisitNumber, out List<Hl7OutBoundMessageDetails> lstHl7OutBoundMessageDetails)
        {
            lstHl7OutBoundMessageDetails = new List<Hl7OutBoundMessageDetails>();

            long returnCode = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd = OutBoundMsgCommand.pGetApprovedListForOutBound_ClinicSystemCommand(OrgID, Status, VisitNumber, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstHl7OutBoundMessageDetails);
                }



            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While GetOrderedApprovedDetailsForOutBound in NewReports_DAL", ex);
            }
            return returnCode;
        }

        public long UpdateOutBoundMsgDetils(long OrgID, DataTable DtApprovedXML)
        {
            int ret = -1;
            long retCode = -1;
            //long LoginId = -1;
            //LoginId = LoginId;
            


            //DataTable invs = UDT_DAL.ConvertToUDTHl7OutBoundMessageDetails(PatientInvestigation);
            SqlCommand cmd = new SqlCommand();

            cmd = OutBoundMsgCommand.pUpdateOutBoundMsgDetilsCommand(OrgID, DtApprovedXML, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmd);

                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while saving PatientInvestigation investigation_DAL", e);
            }
            return retCode;

        }

        public long getPdfDetails(long OrgID, long VisitID, long AccessionNumber, out List<ContentPDF> lstPDFDetails)
        {
            lstPDFDetails = new List<ContentPDF>();

            long returnCode = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd = OutBoundMsgCommand.PgetPdfDetailsCommand(OrgID, VisitID, AccessionNumber);
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPDFDetails);
                }



            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While getPdfDetails in OutBoundMsg_DAL", ex);
            }
            return returnCode;
        }
    }
}
