using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LISAPI.BusinessEntities
{
    public class TRFFileManager
    {
       

        public long AccessionNumber { get; set; }
        public DateTime Createdat { get; set; }
        public long Createdby { get; set; }
        public long FileID { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string FileUrl { get; set; }
        public long IdentifyingID { get; set; }
        public string IdentifyingType { get; set; }
        public string Isactive { get; set; }
        public int IsFileStream { get; set; }
        public DateTime ModifiedAt { get; set; }
        public long ModifiedBy { get; set; }
        public int OrgID { get; set; }
        public long PatientID { get; set; }
        public DateTime ReceivedDate { get; set; }
        public string RefID { get; set; }
        public Guid TRFGUID { get; set; }
        public byte[] TRFImageData { get; set; }
        public long VisitID { get; set; }
        public long ExternalRefNo { get; set; }
        public string SourceType { get; set; }
    }
}
