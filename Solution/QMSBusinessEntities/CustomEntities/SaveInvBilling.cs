using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class SaveInvBilling
    {
        private long invID = 0;
        private long gID = 0;
        private decimal amount = 0;
        private string description = String.Empty;
        private string isGroup = "G";

        public long InvID
        {
            get { return invID; }
            set { invID = value; }
        }

        public long GID
        {
            get { return gID; }
            set { gID = value; }
        }
        
        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        
        public string IsGroup
        {
            get { return isGroup; }
            set { isGroup = value; }
        }

    }
}
