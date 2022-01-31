using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class InvestigationDetail
    {
        private string iD = string.Empty;
        /// <summary>
        /// Gets or sets the ID value.
        /// </summary>
        public string ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private string name = String.Empty;
        /// <summary>
        /// Gets or sets the Name value.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string type = String.Empty;
        /// <summary>
        /// Gets or sets the Type value.
        /// </summary>
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}
