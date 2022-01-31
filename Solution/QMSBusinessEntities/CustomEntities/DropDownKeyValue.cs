using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities.CustomEntities
{
public    class DropDownKeyValue
    {
        private long  id = 0;

        private string name = String.Empty;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Gets or sets the SURNAME value.
        /// </summary>
        public Int64 ID
        {
            get { return id; }
            set { id = value; }
        }
    }
}
