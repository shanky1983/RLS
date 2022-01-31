using Attune.Kernel.LIMSAPI.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LIMSAPI.Models
{
    public class UpdateHCBookingModel
    {
        public List<Bookings> BookingsInfo { get; set; }
        public List<PageContextkeyModel> lstPageContext { get; set; }
        public ContextDetails ContextInfo { get; set; }
    }
    public class UpdateHCBulkBookingModel
    {
        public List<Bookings> BookingsInfo { get; set; }
        public List<PageContextkeyModel> lstPageContext { get; set; }
        public ContextDetails ContextInfo { get; set; }
    }
    public class PageContextkeyModel
    {
        public long ID { get; set; }
        public long PatientID { get; set; }
        public long RoleID { get; set; }
        public long OrgID { get; set; }
        public long PatientVisitID { get; set; }
        public long PageID { get; set; }
        public string ButtonName { get; set; }
        public string ActionType { get; set; }
    }
}