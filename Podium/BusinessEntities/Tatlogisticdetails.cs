using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class Tatlogisticdetails
    {
        #region Fields

        private int logisticdetailsid = 0;
        private int sno = 0;
        private int fromorgid = 0;
        private string fromorgname = String.Empty;

        private long fromorgaddressid = 0;
        private string fromlocationname = String.Empty;

        private int toorgid = 0;
        private string toorgname = String.Empty;

        private long toorgaddressid = 0;
        private string tolocationname = String.Empty;

        private int transittimevalue = 0;
        private string transittimetype = String.Empty;
        private int isActive = 0;
        private string transittimeName = String.Empty;
        private long createdBy = 0;
        private DateTime createdAt = DateTime.MaxValue;
        private long modifiedBy = 0;
        private DateTime modifiedAt = DateTime.MaxValue;


        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the ID value.
        /// </summary>
        public int Logisticdetailsid
        {
            get { return logisticdetailsid; }
            set { logisticdetailsid = value; }
        }

        /// <summary>
        /// Gets or sets the ID value.
        /// </summary>
        public int SNO
        {
            get { return sno; }
            set { sno = value; }
        }

        /// <summary>
        /// Gets or sets the Fromorgid value.
        /// </summary>
        public int Fromorgid
        {
            get { return fromorgid; }
            set { fromorgid = value; }
        }

        /// <summary>
        /// Gets or sets the Fromorgname value.
        /// </summary>
        public string Fromorgname
        {
            get { return fromorgname; }
            set { fromorgname = value; }
        }


        /// <summary>
        /// Gets or sets the Fromorgaddressid value.
        /// </summary>
        public long Fromorgaddressid
        {
            get { return fromorgaddressid; }
            set { fromorgaddressid = value; }
        }

        /// <summary>
        /// Gets or sets the Fromlocationname value.
        /// </summary>
        public string Fromlocationname
        {
            get { return fromlocationname; }
            set { fromlocationname = value; }
        }

        ///////////



        /// <summary>
        /// Gets or sets the Toorgid value.
        /// </summary>
        public int Toorgid
        {
            get { return toorgid; }
            set { toorgid = value; }
        }

        /// <summary>
        /// Gets or sets the Toorgname value.
        /// </summary>
        public string Toorgname
        {
            get { return toorgname; }
            set { toorgname = value; }
        }


        /// <summary>
        /// Gets or sets the Toorgaddressid value.
        /// </summary>
        public long Toorgaddressid
        {
            get { return toorgaddressid; }
            set { toorgaddressid = value; }
        }

        /// <summary>
        /// Gets or sets the Tolocationname value.
        /// </summary>
        public string Tolocationname
        {
            get { return tolocationname; }
            set { tolocationname = value; }
        }


        /// <summary>
        /// Gets or sets the Transittimevalue value.
        /// </summary>
        public int Transittimevalue
        {
            get { return transittimevalue; }
            set { transittimevalue = value; }
        }

        /// <summary>
        /// Gets or sets the Transittimetype value.
        /// </summary>
        public string Transittimetype
        {
            get { return transittimetype; }
            set { transittimetype = value; }
        }

        /// <summary>
        /// Gets or sets the Transittimetype value.
        /// </summary>
        public string TransittimeName
        {
            get { return transittimeName; }
            set { transittimeName = value; }
        }

        /// <summary>
        /// Gets or sets the IsActive value.
        /// </summary>
        public int IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }

        /// <summary>
        /// Gets or sets the CreatedBy value.
        /// </summary>
        public long CreatedBy
        {
            get { return createdBy; }
            set { createdBy = value; }
        }

        /// <summary>
        /// Gets or sets the CreatedAt value.
        /// </summary>
        public DateTime CreatedAt
        {
            get { return createdAt; }
            set { createdAt = value; }
        }

        /// <summary>
        /// Gets or sets the ModifiedBy value.
        /// </summary>
        public long ModifiedBy
        {
            get { return modifiedBy; }
            set { modifiedBy = value; }
        }

        /// <summary>
        /// Gets or sets the ModifiedAt value.
        /// </summary>
        public DateTime ModifiedAt
        {
            get { return modifiedAt; }
            set { modifiedAt = value; }
        }



        #endregion
    }
}
