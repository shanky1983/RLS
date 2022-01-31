using System;
using System.Collections.Generic;

using System.Text;

namespace Attune.Podium.BusinessEntities.CustomEntities
{
    public class FieldAttributeDetails
    {
        private string labelName = string.Empty;
        private string controltype = string.Empty;
        private string controlconstraints = string.Empty;
        private string domain = string.Empty;

        public string LabelName
        {
            get { return labelName; }
            set {  labelName= value; }
        }

        public string ControlType
        {
            get { return controltype; }
            set { controltype = value; }
        }

        public string Domain
        {
            get { return domain; }
            set { domain = value; }
        }
    }
}
