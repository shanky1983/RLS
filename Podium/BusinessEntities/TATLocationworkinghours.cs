using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class TATLocationworkinghours
    {
        #region Fields


        private int iD = 0;
        private int orgID = 0;
        private long orgAddressId = 0;
        private int weekdayno = 0;
        public string labstart = string.Empty;
        public string labend = string.Empty;
        public long createdby = 0;
        public long modifiedby = 0;
        private DateTime createdat = DateTime.MaxValue;
        private DateTime modifiedat = DateTime.MaxValue;
        private string location = string.Empty;
        private string organizationName = string.Empty;
        private string frequencyDays = string.Empty;
        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the ID value.
        /// </summary>
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        /// <summary>
        /// Gets or sets the OrgID value.
        /// </summary>
        public int OrgID
        {
            get { return orgID; }
            set { orgID = value; }
        }


        public long OrgAddressId
        {
            get { return orgAddressId; }
            set { orgAddressId = value; }
        }

        /// <summary>
        /// Gets or sets the Weekdayno value.
        /// </summary>
        public int Weekdayno
        {
            get { return weekdayno; }
            set { weekdayno = value; }
        }

        public string Labstart
        {
            get { return labstart; }
            set { labstart = value; }
        }
        public string Labend
        {
            get { return labend; }
            set { labend = value; }
        }

        public long Createdby
        {
            get { return createdby; }
            set { createdby = value; }
        }

        public long Modifiedby
        {
            get { return modifiedby; }
            set { modifiedby = value; }
        }
        public DateTime Createdat
        {
            get { return createdat; }
            set { createdat = value; }
        }
        public DateTime Modifiedat
        {
            get { return modifiedat; }
            set { modifiedat = value; }
        }
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        public string FrequencyDays
        {
            get { return frequencyDays; }
            set { frequencyDays = value; }
        }
        public string OrganizationName
        {
            get { return organizationName; }
            set { organizationName = value; }
        }
        #endregion
    }
}
