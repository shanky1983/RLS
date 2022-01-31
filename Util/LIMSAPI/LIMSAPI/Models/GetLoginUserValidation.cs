using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LIMSAPI.Models
{
    public class GetLoginUserValidation
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FCMInstanceId { get; set; }
        public string DeviceId { get; set; }
        public string AppVersionNo { get; set; }
    }
}