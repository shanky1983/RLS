using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Attune.Podium.Common
{
 public   class IntegrationHelper
    {
        private const string Pellucid = "Pellucid";
        private const string Matrixview = "MatrixView";
        public enum ViewerName
        {
            [System.ComponentModel.DescriptionAttribute("Pellucid")]
            Pellucid,
            [System.ComponentModel.DescriptionAttribute("MatrixView")]
            Matrixview

        }
    }
}
