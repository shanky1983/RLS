using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class BookingsData
    {
        public long BookingID { get; set; }
        public long LocationID { get; set; }
        public string Salutation { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PinCode { get; set; }
        public string MobileNumber { get; set; }
        public string EmailID { get; set; }
        public string ClientCode { get; set; }
        public DateTime SampleCollectionTime { get; set; }
        public string DispatchType { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal DueAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public long DiscountID { get; set; }
        public string PaymentStatus { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }
        public long InventoryCount { get; set; }
        public string LoginID { get; set; }
        public string IsCreaditBill { get; set; }
        public List<OrdersData> OrderInfoList { get; set; }
        public List<SampleData> SampleCollectionInfo { get; set; }
    }

    public class BookingsdataInfo
    {
        public string OrgCode { get; set; }
        public long OrgID { get; set; }
        public string Type { get; set; }
        public List<BookingsData> BookingInfo { get; set; }
    }
}
