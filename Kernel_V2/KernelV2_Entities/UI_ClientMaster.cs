using System.Collections.Generic;

namespace Attune.KernelV2.Entities
{
    public class UI_ClientMaster
    {
        public long ClientID { get; set; }
        public string ClientCode { get; set; }
        public string ClientName { get; set; }
        public long ClientMappingDetailsID { get; set; }
        public string IsMappedItem { get; set; }
        public string IsDiscount { get; set; }
        public string IsCashClient { get; set; }
        public string ExAutoAuthorization { get; set; }
        public string Hashealthcoupon { get; set; }
        public decimal ThresholdValue { get; set; }
        public decimal ThresholdValue2 { get; set; }
        public decimal ThresholdValue3 { get; set; }
        public bool IsAdvanceClient { get; set; }
        public string BillType { get; set; }
        public long EnableAttributes { get; set; }
        public int ExtrenalPatientNo { get; set; }
        public string WardNo { get; set; }
        public string RoundNo { get; set; }
        public int VisiTypeCode { get; set; }
        public int KnowledgeOfServiceID { get; set; }
        public UI_CollectionMaster CollectionMaster { get; set; }
        public UI_ReferringHospital ReferringHospital { get; set; }
        public UI_ReferringPhysician ReferringPhysician { get; set; }
        public List<UI_FieldAttributeDetails> ClientAttributes { get; set; }
        public long RateID { get; set; }
        public string IsCreditBill { get; set; }
    }

    public class UI_CollectionMaster
    {
        public long CollectionID { get; set; }
        public long Identificationid { get; set; }
        public decimal TotalDepositAmount { get; set; }
        public decimal TotalDepositUsed { get; set; }
    }

    public class UI_ReferringHospital
    {
        public long ReferringHospitalID { get; set; }
        public string ReferringHospitalName { get; set; }
        public string ReferringType { get; set; }
    }
    public class UI_ReferringPhysician
    {
        public long ReferringPhysicianID { get; set; }
        public string ReferringPhysicianName { get; set; }
    }

    public class UI_ClientMetaData
    {
        public List<UI_MetaData> KnowledgeOfService { get; set; }
        public List<UI_MetaData> VisiType { get; set; }
        public UI_ClientMaster Client { get; set; }
    }

    public class UI_FieldAttributeDetails
    {
        public string ControlType { get; set; }
        public string Domain { get; set; }
        public string LabelName { get; set; }
        public string Valuedata { get; set; }
    }
    public class UI_ClientAttributesKeyFields
    {
        public string Key { get; set; }
        public long ReferenceID { get; set; }
        public string ReferenceType { get; set; }
        public string Valuedata { get; set; }
    }
}
