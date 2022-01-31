using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class Paging
    {
        public int TotalRecords { get; set; }
        public int TotalPages { get; set; }
        public int AllowableRecordCount{ get; set; }
    }
    public class Paged
    {
        public int TotalRecords { get; set; }
        public int TotalPages { get; set; }
        public int AllowableRecordCount { get; set; }
    }
}
