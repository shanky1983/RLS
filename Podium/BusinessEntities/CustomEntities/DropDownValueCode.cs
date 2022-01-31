using System;
using System.Collections.Generic;

using System.Text;

namespace Attune.Podium.BusinessEntities
{
   public class DropDownValueCode
    {
        private long id = 0;

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
