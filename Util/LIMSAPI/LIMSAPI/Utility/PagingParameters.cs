using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LIMSAPI.Utility
{
    public class PagingParameters
    {
        public int pageNumber { get; set ; }

        private int _pageSize { get; set; } 

        public int pageSize
        {
            get { return _pageSize; }
            set { _pageSize = ( value > _pageSize) ? value : _pageSize;  }
        }
    }
}