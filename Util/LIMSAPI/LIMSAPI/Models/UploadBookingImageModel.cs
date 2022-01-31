using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LIMSAPI.Models
{
    public class UploadBookingImageModel
    {
        public long BookingID { get; set; }
        public string ExternalRefNo { get; set; }
        public string SourceType { get; set; }
        public string Description { get; set; }

        public string ImageData { get; set; }
     
    }
}