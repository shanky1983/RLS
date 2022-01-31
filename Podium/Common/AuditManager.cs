using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Attune.Podium.Common
{
    public class AuditManager
    {

        public class AuditCategoryCode
        {
            public const string Barcode = "Barcode";
            public const string Report = "Report";
            public const string ReprintBarcode = "ReprintBarcode";
            
        }

        public class AuditTypeCode
        {
            public const string Print = "Print";
            public const string Export = "Export";
            public const string Email = "Email";
        }

        public class AuditAttribute
        {
            public const string Visit = "Visit";
            public const string Template = "Template";
            public const string Patient = "Patient";
            public const string SampleId = "SampleId";
    

        }


    }
}
