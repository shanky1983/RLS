namespace Attune.KernelV2.Entities
{
    public class UI_Discount
    {
        public int DiscountID { get; set; }
        public string DiscountName { get; set; }
        public decimal CeilingValue { get; set; }
        public string DiscountType { get; set; }
        public decimal Discount { get; set; }
        public string Code { get; set; }
        public string DiscountPercentage { get; set; }
    }
    public class UI_DiscountReason
    {
        public long ReasonID { get; set; }
        public int ReasonTypeID { get; set; }
        public string Reason { get; set; }
        public string ReasonCode { get; set; }
        public int SequenceNo { get; set; }
    }
    public class UI_DiscoiuntApproved
    {
        public string Name { get; set; }
        public string RoleName { get; set; }
        public string SpecialityName { get; set; }
        public long LoginID { get; set; }
    }
    public class UI_PatientDiscount
    {
        public long DiscountID { get; set; }
        public string DiscountCode { get; set; }
        public string DiscountName { get; set; }
        public string DiscountType { get; set; }
        public int DiscountValue { get; set; }
        public decimal DiscountCeilingValue { get; set; }
        public decimal UserDiscountValue { get; set; }
        public decimal SlabCeilingValue { get; set; }
        public decimal SlabPercentage { get; set; }
        public decimal DiscountPercentage { get; set; }
    }

}
