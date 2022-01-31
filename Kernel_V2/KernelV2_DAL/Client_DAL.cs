using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using Attune.KernelV2.Cmd;
using Attune.KernelV2.DataAccessEngine;
using Attune.KernelV2.Entities;
using Attune.KernelV2.UDT;
using Attune.KernelV2.Utilities;
using System.Data;

namespace Attune.KernelV2.DAL
{
    public class Client_DAL : IDisposable
    {
        UI_ContextDetails globalContextDetails;

        public Client_DAL(UI_ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        public List<UI_ClientMaster> GetClientForBilling(long pClientID, string pPrefixText, int OrgID, int OrgAddressID)
        {
            List<UI_ClientMaster> lstClientMaster = null;
            using (DbHelper gateWay = new DbHelper())
            {

                var cmd = KernelV2_Command.pGetClientForBilling_v2Command(pClientID, pPrefixText, OrgID, OrgAddressID, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                DbDataReader dataReader = gateWay.ExecuteReader(cmd);
                if (dataReader != null)
                {
                    lstClientMaster = Utility.Tolist<UI_ClientMaster>(dataReader).ToList();
                }
            }
            return lstClientMaster;
        }

        public List<UI_ReferringPhysician> GetReferringPhysician(string pPrefixText, long pClientId, int OrgID)
        {
            List<UI_ReferringPhysician> lstReferringPhysician = null;

            using (DbHelper gateWay = new DbHelper())
            {

                var cmd = KernelV2_Command.pGetReferringPhysician_v2Command(OrgID, pPrefixText, pClientId, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                DbDataReader dataReader = gateWay.ExecuteReader(cmd);
                if (dataReader != null)
                {
                    lstReferringPhysician = Utility.Tolist<UI_ReferringPhysician>(dataReader).ToList();
                }
            }
            return lstReferringPhysician;
        }

        public List<UI_ReferringHospital> GetReferringHospital(string pPrefixText, long pClientId, int OrgID)
        {
            List<UI_ReferringHospital> lstReferringHospital = null;
            using (DbHelper gateWay = new DbHelper())
            {

                var cmd = KernelV2_Command.pGetReferringHospital_v2Command(OrgID, pPrefixText, pClientId, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                DbDataReader dataReader = gateWay.ExecuteReader(cmd);
                if (dataReader != null)
                {
                    lstReferringHospital = Utility.Tolist<UI_ReferringHospital>(dataReader).ToList();
                }
            }
            return lstReferringHospital;
        }

        public List<UI_FieldAttributeDetails> ClientAttributesFieldDetails(long ReferenceID, string ReferenceType)
        {
            List<UI_FieldAttributeDetails> lstFieldDetails = null;
            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pGetClientAttributesFieldDetails_V2Command(ReferenceID, ReferenceType, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                DbDataReader dataReader = gateWay.ExecuteReader(cmd);
                if (dataReader != null)
                {
                    lstFieldDetails = Utility.Tolist<UI_FieldAttributeDetails>(dataReader).ToList();
                }
            }
            return lstFieldDetails;
        }

        public long InsertClientAttributesFieldDetails(long PatientVisitID, List<UI_ClientAttributesKeyFields> lstClientAttributes)
        {
            long returncode = -1;
            DataTable dtClientAttributes = UDT_DAL.ConvertToPatientAttributesField(lstClientAttributes);
            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pInsertClientAttributeFieldDetails_V2Command(PatientVisitID, dtClientAttributes, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                returncode = gateWay.ExecuteNonQuery(cmd);
            }
            return returncode;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
