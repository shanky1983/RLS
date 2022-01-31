using System;
using System.Collections.Generic;
using System.Linq;
using Attune.KernelV2.DAL;
using Attune.KernelV2.Entities;

namespace Attune.KernelV2.BL
{
    public class Client_BL : IDisposable
    {
        UI_ContextDetails globalContextDetails;

        public Client_BL(UI_ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        public List<UI_ClientMaster> GetClientForBilling(long ClientID, string PrefixText, int OrgID, int OrgAddressID)
        {
            List<UI_ClientMaster> lstClientMaster;
            using (Client_DAL DAL = new Client_DAL(globalContextDetails))
            {
                lstClientMaster = DAL.GetClientForBilling(ClientID, PrefixText, OrgID, OrgAddressID);
            }
            return lstClientMaster;
        }

        public List<UI_ReferringHospital> GetReferringHospital(string PrefixText, long ClientId, int OrgID)
        {
            List<UI_ReferringHospital> lstReferringHospital;
            using (Client_DAL DAL = new Client_DAL(globalContextDetails))
            {
                lstReferringHospital = DAL.GetReferringHospital(PrefixText, ClientId, OrgID);
            }
            return lstReferringHospital;
        }

        public List<UI_ReferringPhysician> GetReferringPhysician(string PrefixText, long ClientId, int OrgID)
        {
            List<UI_ReferringPhysician> lstReferringPhysician;
            using (Client_DAL DAL = new Client_DAL(globalContextDetails))
            {
                lstReferringPhysician = DAL.GetReferringPhysician(PrefixText, ClientId, OrgID);
            }
            return lstReferringPhysician;
        }

        public List<UI_MetaData> GetKnowledgeofService(int OrgID, string LanguageCode)
        {
            List<UI_MetaData> lstKnowledgeofService;
            using (MetaData_BL BL = new MetaData_BL(globalContextDetails))
            {
                lstKnowledgeofService = BL.GetMetaData("KnowledgeOfService", OrgID, LanguageCode);
            }
            return lstKnowledgeofService;
        }

        public UI_ClientMetaData GetClientMetaData(int OrgID, int OrgAddressID, string LanguageCode)
        {
            UI_ClientMetaData objClientMetaData = new UI_ClientMetaData();
            List<UI_ClientMaster> lstClientMaster;
            using (MetaData_BL BL = new MetaData_BL(globalContextDetails))
            {
                objClientMetaData.KnowledgeOfService = BL.GetMetaData("KnowledgeOfService", OrgID, LanguageCode);
                objClientMetaData.VisiType = BL.GetMetaData("VisitType", OrgID, LanguageCode);

            }

            lstClientMaster = GetClientForBilling(0, "General", OrgID, OrgAddressID);
            if (lstClientMaster != null)
            {
                objClientMetaData.Client = lstClientMaster.Where(p => p.ClientCode.ToUpper() == "GENERAL").SingleOrDefault();
            }
            return objClientMetaData;
        }

        public List<UI_FieldAttributeDetails> ClientAttributesFieldDetails(long ReferenceID, string ReferenceType)
        {
            List<UI_FieldAttributeDetails> lstFieldDetails = null;
            using (Client_DAL DAL = new Client_DAL(globalContextDetails))
            {
                lstFieldDetails = DAL.ClientAttributesFieldDetails(ReferenceID, ReferenceType);
            }
            return lstFieldDetails;
        }

        public long InsertClientAttributesFieldDetails(long PatientVisitID, List<UI_ClientAttributesKeyFields> lstClientAttributes)
        {
            long returncode = -1;
            using (Client_DAL DAL = new Client_DAL(globalContextDetails))
            {
                returncode = DAL.InsertClientAttributesFieldDetails(PatientVisitID, lstClientAttributes);
            }
            return returncode;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }

}
