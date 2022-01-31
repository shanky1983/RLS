using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
   public class Status
    {
        #region Fields

        private string status = String.Empty;
        private int id = 0;

        #endregion

        #region Properties

        public string STATUS
        {
            get { return status; }
            set { status = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        #endregion
    }
}
