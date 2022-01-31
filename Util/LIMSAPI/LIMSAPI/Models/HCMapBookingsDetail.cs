using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Attune.Kernel.LIMSAPI.BusinessEntities;
namespace LIMSAPI.Models
{
    public class HCMapBookingsDetail
    {
        public List<Bookings> BookingsInfo { get; set; }
    }
}