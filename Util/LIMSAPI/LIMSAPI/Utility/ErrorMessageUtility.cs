using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;

namespace LIMSAPI.Utility
{
    public class ErrorMessageUtility
    {
        public HttpStatusCode HttpStatusCode { get; set; }
        public string Message { get; set; }
        public string Status { get; set; }
    }

    public class SucessMessage
    {
        public HttpStatusCode HttpStatusCode { get; set; }
        public string Message { get; set; }
        public string Status { get; set; }
        public string transactionId { get; set; }

    }
}