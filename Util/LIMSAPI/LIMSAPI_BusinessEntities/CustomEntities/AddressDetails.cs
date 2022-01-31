using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class AddressDetails
    {
        public long AddressID { get; set; }
        public int AddressTypeID { get; set; }

        public long ReferenceID { get; set; }
        public string ReferenceType { get; set; }
        public string Address1 { get; set; }
        public string City { get; set; }
        public int CountryID { get; set; }
        public string Country { get; set; }

        public int StateID { get; set; }
        public string State { get; set; }
        public string EmailID { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string FaxNumber { get; set; }
        public int OrgID { get; set; }
        public string IsCommunication { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public long ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public int ISDCode { get; set; }
        public string Name { get; set; }
        public string ContactType { get; set; }
        public long EmpID { get; set; }
        public string SubUrban { get; set; }
        public string PostalCode { get; set; }
        public string Address2 { get; set; }
        public string InvoiceEmail { get; set; }

        public long CommunicationConfigID { get; set; }
        public string NotificationCategory { get; set; }
        }
    }
