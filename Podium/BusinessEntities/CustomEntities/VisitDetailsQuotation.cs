using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class VisitDetailsQuotation
    {
        #region Fields
        private string clientName = string.Empty;
        private string scheduledTime = string.Empty;
        private string contactPerson = string.Empty;
        private string collectionPerson = string.Empty;
        private string address = string.Empty;
        private string rolename = string.Empty;
        private long investiagtionid = 0;
        private string investiagtionname = string.Empty;
        private string sampleid = string.Empty;
        private string sampletype = string.Empty;
        private string sampledescrip = string.Empty;
        private int sampleContainer = 0;
        private string fieldtest = string.Empty;
        private string temperature = string.Empty;
        private string location = string.Empty;
        private string email = string.Empty;
        #endregion


        public long InvestiagtionID
        {
            get { return investiagtionid; }
            set { investiagtionid = value; }
        }

        public string ClientName
        {
            get { return clientName; }
            set { clientName=value;}
        }

        public string ContactPerson
        {
            get { return contactPerson; }
            set { contactPerson = value; }
        }

        public string CollectionPerson
        {
            get { return collectionPerson; }
            set { collectionPerson = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string RoleName
        {
            get { return rolename; }
            set { rolename = value; }
        }

        public string ScheduledTime
        {
            get { return  scheduledTime.ToString(); }
            set { scheduledTime = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }




    }
}
