using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class PatientResultPDF
    {
        public string FilePathName { get; set; }
        public long VisitId { get; set; }
        public string FileType { get; set; }
        public string FileFolder { get; set; }
        public string FilePath { get; set; }
        public string FileName { get; set; }
    }
}
