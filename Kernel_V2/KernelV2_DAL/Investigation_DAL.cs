using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using Attune.KernelV2.Cmd;
using Attune.KernelV2.DataAccessEngine;
using Attune.KernelV2.Entities;
using Attune.KernelV2.UDT;
using Attune.KernelV2.Utilities;

namespace Attune.KernelV2.DAL
{
    public class Investigation_DAL : IDisposable
    {
        UI_ContextDetails globalContextDetails;

        public Investigation_DAL(UI_ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        public List<UI_OrderedInvestigations> GetpatientInvestigationForVisit(long visitID, int orgID, int LocationID, string gUID)
        {
            List<UI_OrderedInvestigations> lstPatientInvestigation;
            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pGetpatientInvestigationForVisit_V2Command(visitID, orgID, LocationID, gUID, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                DbDataReader reader = gateWay.ExecuteReader(cmd);
                lstPatientInvestigation = Utility.Tolist<UI_OrderedInvestigations>(reader).ToList();
            }
            return lstPatientInvestigation;
        }

        public List<UI_ReferenceRangeType> GetReferenceRangeType(int orgid, string LangCode)
        {
            List<UI_ReferenceRangeType> lstReferenceRangeType;
            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pgetReferencerangetypeCommand(orgid, LangCode);
                DbDataReader dataReader = gateWay.ExecuteReader(cmd);

                lstReferenceRangeType = Utility.Tolist<UI_ReferenceRangeType>(dataReader).ToList();

            }
            return lstReferenceRangeType;
        }

        public List<UI_InvReasonMasters> GetInvReasons(int OrgID)
        {
            List<UI_InvReasonMasters> lstInvReasonMasters;

            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pGetInvReasons_V2Command(OrgID, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                DbDataReader dataReader = gateWay.ExecuteReader(cmd);

                lstInvReasonMasters = Utility.Tolist<UI_InvReasonMasters>(dataReader).ToList();

            }
            return lstInvReasonMasters;
        }

        public List<UI_InvQualitativeResultMaster> GetInvQualitativeResult()
        {
            List<UI_InvQualitativeResultMaster> lstInvQualitativeResult;

            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pGetInvQualitativeResultMaster_V2Command(KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                DbDataReader dataReader = gateWay.ExecuteReader(cmd);

                lstInvQualitativeResult = Utility.Tolist<UI_InvQualitativeResultMaster>(dataReader).ToList();

            }
            return lstInvQualitativeResult;
        }

        public UI_InvResultsCapture GetInvestigatonResultsCapture(long VID, int OrgID, long RoleID, string gUID, long DeptID,
            string InvIDs, int LocationID, UI_LoginDetail LDetail, long taskid, string IsTrustedDetails, string status)
        {
            UI_InvResultsCapture lstUI_InvResultsCapture = new UI_InvResultsCapture();


            DataTable DtLDetail = UDT_DAL.ConvertToLoginDetail(LDetail);

            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pGetInvestigationResultsCapture_V2Command(VID, OrgID, RoleID,
                gUID, DeptID, InvIDs, LocationID, taskid, DtLDetail, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails),
                IsTrustedDetails, status);

                DbDataReader dataReader = gateWay.ExecuteReader(cmd);

                lstUI_InvResultsCapture.lstUI_PatientInvestigation = Utility.Tolist<UI_PatientInvestigation>(dataReader).ToList();

                if (dataReader.NextResult())
                {
                    lstUI_InvResultsCapture.InvestigationValues = Utility.Tolist<UI_InvestigationValues>(dataReader).ToList();
                }

                if (dataReader.NextResult())
                {
                    lstUI_InvResultsCapture.lstUI_InvestigationStatus = Utility.Tolist<UI_InvestigationStatus>(dataReader).ToList();
                }

                if (dataReader.NextResult())
                {
                    lstUI_InvResultsCapture.lstUI_RoleDeptMap = Utility.Tolist<UI_RoleDeptMap>(dataReader).ToList();
                }
            }
            return lstUI_InvResultsCapture;
        }

        public List<UI_InvValueRangeMaster> GetReflexTestDetails(List<UI_PatientInvestigation> lstPatientInvestigation, int OrgID)
        {
            List<UI_InvValueRangeMaster> lstInvValueRangeMaster;

            DataTable dtPatInvestigation;
            dtPatInvestigation = UDT_DAL.ConvertToPatInvestigation(lstPatientInvestigation);

            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pGetReflexTestDetailsbyInvID_V2Command(dtPatInvestigation, OrgID);
                DbDataReader dataReader = gateWay.ExecuteReader(cmd);

                lstInvValueRangeMaster = Utility.Tolist<UI_InvValueRangeMaster>(dataReader).ToList();

            }
            return lstInvValueRangeMaster;
        }

        public string GetNextBarcode(long OrgID, string IDType, string ID, long OrgAddressID, long RefID, string RefType)
        {
            string Barcode;
            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pGetNextID_V2Command(OrgID, IDType, ID, OrgAddressID, RefID, RefType);
                gateWay.ExecuteNonQuery(cmd);
                Barcode = Convert.ToString(cmd.Parameters["@ID"].Value);
            }
            return Barcode;
        }

        public List<UI_PatientInvestigation> GetInvestigationSamplesCollect(long PatientVisitID, int OrgID, long roleID, string gUID, int LocationID,
            int taskactionID)
        {
            List<UI_PatientInvestigation> lstPatientInvestigation;

            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pGetInvestigationSamples_V2Command(PatientVisitID, OrgID, roleID, gUID, LocationID, taskactionID, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));

                DbDataReader dataReader = gateWay.ExecuteReader(cmd);

                lstPatientInvestigation = Utility.Tolist<UI_PatientInvestigation>(dataReader).ToList();
            }
            return lstPatientInvestigation;
        }

        public List<UI_PatientInvestigation> GetPatientInvestigationStatus(long VisitID, int OrgID)
        {
            List<UI_PatientInvestigation> lstPatientInvestigation;
            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pGetPatientInvestigationStatus_V2Command(VisitID, OrgID, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                DbDataReader dataReader = gateWay.ExecuteReader(cmd);

                lstPatientInvestigation = Utility.Tolist<UI_PatientInvestigation>(dataReader).ToList();
            }
            return lstPatientInvestigation;
        }

        public List<UI_PatientInvestigation> Grouplevelvalidation(long VisitID, int TaskActionID, int OrgID, int Lid,
            List<UI_PatientInvestigation> lstPatientInvestigation)
        {
            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pGetGrouplevelvalidation_V2Command(VisitID, TaskActionID, UDT_DAL.ConvertToPatientInvestigation(lstPatientInvestigation),
                    OrgID, Lid, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                DbDataReader dataReader = gateWay.ExecuteReader(cmd);

                lstPatientInvestigation = Utility.Tolist<UI_PatientInvestigation>(dataReader).ToList();
            }
            return lstPatientInvestigation;
        }

        public long InsertInvQualitativeResult(List<UI_InvestigationBulkData> lstInvestigationBulkData)
        {
            long returncode = -1; int status = -1;

            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pInsertInvQualitativeResultMaster_V2Command(UDT_DAL.ConvertToUDTInvQualitativeResultMaster(lstInvestigationBulkData), out status, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                gateWay.ExecuteNonQuery(cmd);
                returncode = Convert.ToInt64(cmd.Parameters["@returnstatus"].Value);
            }
            return returncode;
        }

        public long InsertINVSampleResults(List<UI_PatientInvSampleResults> lstPatientInvSampleResults, long VisitID, int OrgID)
        {
            long returncode; int status = -1;

            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pInsertinvSampleResults_V2Command(UDT_DAL.ConvertToUDTinvSampleResults(lstPatientInvSampleResults),
                    VisitID, OrgID, out status, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                gateWay.ExecuteNonQuery(cmd);
                returncode = Convert.ToInt32(cmd.Parameters["@pReturnStatus"].Value);
            }
            return returncode;
        }

        public long InsertINVSampleMapping(List<UI_PatientInvSampleMapping> lstPatientInvSampleMapping, long VisitID, int OrgID, int DeptID)
        {
            long returncode; int status = -1;

            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pInsertInvSampleMapping_V2Command(UDT_DAL.ConvertToPatientInvSampleMapping(lstPatientInvSampleMapping),
                    VisitID, OrgID, DeptID, out status, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                gateWay.ExecuteNonQuery(cmd);
                returncode = Convert.ToInt32(cmd.Parameters["@pReturnStatus"].Value);
            }
            return returncode;
        }

        public long InsertInvestigationResults(List<UI_InvestigationValues> lstInvestigationValues, long pSCMID, long VisitID, string GUID, string IsFromDevice)
        {
            long returncode; int status = -1;

            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pInsertInvestigationResults_V2Command(pSCMID, UDT_DAL.ConvertToInvestigationResults(lstInvestigationValues),
                    VisitID, GUID, out status, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails), IsFromDevice);
                gateWay.ExecuteNonQuery(cmd);
                returncode = Convert.ToInt32(cmd.Parameters["@returnstatus"].Value);
            }
            return returncode;
        }

        public long UpdatePatientInvestigationComplete(List<UI_PatientInvestigation> lstPatientInvestigation, List<UI_InvestigationIDs> lstReflexPatientInvestigation, long SCMID,
               long ApprovedBy, string UID)
        {
            long returncode; int status = -1;


            DataTable dtPatientInvestigation = UDT_DAL.ConvertToPatientInvestigation(lstPatientInvestigation);


            DataTable dtReflexPatientInvestigation = UDT_DAL.ConvertToPatInvestigation(lstReflexPatientInvestigation);


            DataTable dtContextInfo = KernelV2_UDT.ConvertToUDT_Context(globalContextDetails);

            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pUpdatePatientInvestigationComplete_V2Command(dtPatientInvestigation, SCMID, ApprovedBy, UID, out status, dtContextInfo, dtReflexPatientInvestigation);
                gateWay.ExecuteNonQuery(cmd);
                returncode = Convert.ToInt32(cmd.Parameters["@pReturnStatus"].Value);
            }
            return returncode;
        }

        public long UpdateGroupComment(List<UI_PatientInvestigation> lstPatientInvestigation, string GUID)
        {
            long returncode; int status = -1;

            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pUpdateGroupComment_V2Command(UDT_DAL.ConvertToPatientInvestigation(lstPatientInvestigation),
                    GUID, out status, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                gateWay.ExecuteNonQuery(cmd);
                returncode = Convert.ToInt32(cmd.Parameters["@pReturnStatus"].Value);
            }
            return returncode;
        }

        public long UpdateInvestigationHoldonApproval(List<UI_PatientInvestigation> lstPInvestigation, string GUID)
        {
            long returncode;

            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pUpdateInvestigationHoldonApproval_V2Command(UDT_DAL.ConvertToPatientInvestigation(lstPInvestigation), GUID, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                returncode = gateWay.ExecuteNonQuery(cmd);
            }
            return returncode;
        }

        public long SavePatientInvSampleNMapping(List<UI_PatientInvSample> LstPinvsample, List<UI_PatientInvSampleMapping> LstPinvsamplemapping, string GUID, int OrgID)
        {
            long returnstatus; int status = -1;
            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pSavePatientInvSampleNMapping_V2Command(UDT_DAL.ConvertToIPInvSamples(LstPinvsample),
                    UDT_DAL.ConvertToPatientInvSampleMapping(LstPinvsamplemapping),
                    GUID, OrgID, out status, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));

                gateWay.ExecuteNonQuery(cmd);
                returnstatus = Convert.ToInt32(cmd.Parameters["@returnstatus"].Value);
            }
            return returnstatus;
        }

        public long SaveInvestigationQueue(List<UI_InvestigationQueue> InvQueue, int OrgID)
        {
            long returncode; int status = -1;

            DataTable dtInvestigationQueue;
            dtInvestigationQueue = UDT_DAL.ConvertToInvestigationQueue(InvQueue);

            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pInsertInvestigationQueue_V2Command(dtInvestigationQueue, OrgID, out status, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                gateWay.ExecuteNonQuery(cmd);
                returncode = Convert.ToInt32(cmd.Parameters["@returnstatus"].Value);
            }
            return returncode;
        }

        public int SavePatientInvestigation(List<UI_PatientInvestigation> PatientInvestigation, long OrgID, string gUID)
        {
            int returnstatus;
            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pInsertInvestigation_V2Command(UDT_DAL.ConvertToPatientInvestigation(PatientInvestigation), OrgID, gUID, out returnstatus, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                gateWay.ExecuteNonQuery(cmd);
                returnstatus = Convert.ToInt32(cmd.Parameters["@returnstatus"].Value);
            }
            return returnstatus;
        }

        public List<UI_PatientInvestigation> GetDeptToTrackSamplesForQucikBill(long PatientVisitID, int OrgID, long roleID, string gUID)
        {
            List<UI_PatientInvestigation> lstPatientInvestigation;

            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pGetDeptToTrackSamplesForQucikBill_V2Command(PatientVisitID, OrgID, roleID, gUID, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                DbDataReader dataReader = gateWay.ExecuteReader(cmd);

                lstPatientInvestigation = Utility.Tolist<UI_PatientInvestigation>(dataReader).ToList();
            }
            return lstPatientInvestigation;
        }

        public long UpdateInvestigationStatus(long patientVisitID, string status, int OrgID, List<UI_InvestigationValues> lstInvValues)
        {
            long returncode = -1;
            int pReturnStatus = 0;
            DataTable dtvalues = UDT_DAL.ConvertToInvestigationResults(lstInvValues);
            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pUpdateInvestigationStatusCommand(patientVisitID, dtvalues, status, OrgID,
                    out pReturnStatus, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));

                returncode = gateWay.ExecuteNonQuery(cmd);
                returncode = Convert.ToInt16(cmd.Parameters["@pReturnStatus"].Value.ToString());
            }

            return returncode;
        }

        public long UpdateOrderedInvestigation(long PatientVisitID, string Labno, int OrgID, long TaskID, string BillNo)
        {
            long returncode = -1;
            int pReturnStatus = 0;
            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.PUpdateOrderedInvestigation_V2Command(PatientVisitID, Labno, OrgID, TaskID, BillNo,
                    out pReturnStatus, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));

                returncode = gateWay.ExecuteNonQuery(cmd);
                returncode = Convert.ToInt16(cmd.Parameters["@pReturnStatus"].Value.ToString());
            }
            return returncode;
        }

        public UI_HealthPackage GetHealthPackageData(int OrgID, int PackaeID)
        {
            UI_HealthPackage objHealthPackage = new UI_HealthPackage();
            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pGetHealthPackageDataCommand(OrgID, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails), PackaeID);
                DbDataReader dataReader = gateWay.ExecuteReader(cmd);
                if (dataReader != null)
                {
                    objHealthPackage.lstPackages = Utility.Tolist<UI_InvGroupMaster>(dataReader).ToList();
                    if (dataReader.NextResult())
                    {
                        objHealthPackage.lstPackageMapping = Utility.Tolist<UI_InvPackageMapping>(dataReader).ToList();
                    }
                    if (dataReader.NextResult())
                    {
                        objHealthPackage.lstPackageContents = Utility.Tolist<UI_PatientInvestigation>(dataReader).ToList();
                    }
                    if (dataReader.NextResult())
                    {
                        objHealthPackage.lstGeneralHealthCheckUpMaster = Utility.Tolist<UI_GeneralHealthCheckUpMaster>(dataReader).ToList();
                    }
                }
            }
            return objHealthPackage;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
