using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using Attune.KernelV2.Cmd;
using Attune.KernelV2.DataAccessEngine;
using Attune.KernelV2.Entities;
using Attune.KernelV2.UDT;
using Attune.KernelV2.Utilities;

namespace Attune.KernelV2.DAL
{
    public class Patient_DAL : IDisposable
    {
        UI_ContextDetails globalContextDetails;

        public Patient_DAL(UI_ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        public List<UI_PatientVisit> GetPatientLabVisitDetails(long pVisitID, int pOrgID, string UID)
        {
            List<UI_PatientVisit> lstPatientLabVisitDetails;
            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pGetLabVisitDetails_v2Command(pVisitID, pOrgID, UID, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                DbDataReader reader = gateWay.ExecuteReader(cmd);
                lstPatientLabVisitDetails = Utility.Tolist<UI_PatientVisit>(reader).ToList();
            }
            return lstPatientLabVisitDetails;
        }

        public long UpdatePatientVisitChanges(UI_PatientHistory lstPV, int OrgID)
        {
            long returnCode;
            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pupdatePatientvisitchanges_V2Command(lstPV.PatientVisitId, lstPV.PatientHistory, lstPV.RegistrationRemarks, lstPV.HospitalName,
                    lstPV.ReferingPhysicianName, lstPV.ReferingPhysicianID, lstPV.HospitalID, OrgID, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                returnCode = gateWay.ExecuteNonQuery(cmd);
            }
            return returnCode;
        }

        public List<UI_PatientVisitDetails> GetPatientVisitDetails(long VisitID)
        {
            List<UI_PatientVisitDetails> lstPatientVisitDetails;
            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pGetPatientVisitDetails_V2Command(VisitID, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                DbDataReader reader = gateWay.ExecuteReader(cmd);
                lstPatientVisitDetails = Utility.Tolist<UI_PatientVisitDetails>(reader).ToList();
            }
            return lstPatientVisitDetails;
        }

        public UI_PatientandAddress GetPatientDemoandAddress(long PatientID)
        {
            UI_PatientandAddress objPatient = new UI_PatientandAddress();
            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pGetPatientDetailandAddressCommand(PatientID, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                DbDataReader reader = gateWay.ExecuteReader(cmd);
                if (reader != null)
                {
                    objPatient.Patient = Utility.Tolist<UI_PatientBanner>(reader).ToList();
                    if (reader.NextResult())
                    {
                        objPatient.PatientAddress = Utility.Tolist<UI_PatientAddress>(reader).ToList();
                    }
                }
            }

            return objPatient;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
