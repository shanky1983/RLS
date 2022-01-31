using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class EpisodeReport
    {
        #region Fields

        private string location = String.Empty;
        private string externalVisitID = String.Empty;
        private string patientName = String.Empty;
        private DateTime dOB = DateTime.MaxValue;
        private string testCode = String.Empty;
        private string clientName = String.Empty;
        private decimal netAmount = Decimal.Zero;
        private string createdBy = String.Empty;
        private DateTime createdAt = DateTime.MaxValue;
        private long patientVisitID = 0;
        private long patientID = 0;
        private string investigationName = String.Empty;
        private string discountName = String.Empty;
        private string rateCard = String.Empty;
        private string billnumber = String.Empty;
        private string clientcode = String.Empty;
        private string refphysician = String.Empty;

        #endregion

        #region Properties


        /// <summary>
        /// Gets or sets the billnumber value.
        /// </summary>
        public string BillNumber
        {
            get { return billnumber; }
            set { billnumber = value; }
        }

        /// <summary>
        /// Gets or sets the Location value.
        /// </summary>
        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        /// <summary>
        /// Gets or sets the Location value.
        /// </summary>
        public string InvestigationName
        {
            get { return investigationName; }
            set { investigationName = value; }
        }

        /// <summary>
        /// Gets or sets the ExternalVisitID value.
        /// </summary>
        public string ExternalVisitID
        {
            get { return externalVisitID; }
            set { externalVisitID = value; }
        }

        /// <summary>
        /// Gets or sets the PatientName value.
        /// </summary>
        public string PatientName
        {
            get { return patientName; }
            set { patientName = value; }
        }


        /// <summary>
        /// Gets or sets the DOB value.
        /// </summary>
        public DateTime DOB
        {
            get { return dOB; }
            set { dOB = value; }
        }

        /// <summary>
        /// Gets or sets the CodeName value.
        /// </summary>
        public string TestCode
        {
            get { return testCode; }
            set { testCode = value; }
        }

        /// <summary>
        /// Gets or sets the ClientName value.
        /// </summary>
        public string ClientName
        {
            get { return clientName; }
            set { clientName = value; }
        }

        /// <summary>
        /// Gets or sets the NetAmount value.
        /// </summary>
        public decimal NetAmount
        {
            get { return netAmount; }
            set { netAmount = value; }
        }
        /// <summary>
        /// Gets or sets the CreatedBy value.
        /// </summary>
        public string CreatedBy
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
        /// Gets or sets the CreatedBy value.
        /// </summary>
        public long PatientVisitID
        {
            get { return patientVisitID; }
            set { patientVisitID = value; }
        }

        /// <summary>
        /// Gets or sets the CreatedBy value.
        /// </summary>
        public long PatientID
        {
            get { return patientID; }
            set { patientID = value; }
        }

        /// <summary>
        /// Gets or sets the DiscountName value.
        /// </summary>
        public string DiscountName
        {
            get { return discountName; }
            set { discountName = value; }
        }

        /// <summary>
        /// Gets or sets the RateCard value.
        /// </summary>
        public string RateCard
        {
            get { return rateCard; }
            set { rateCard = value; }
        }

        public string ClientCode
        {
            get { return clientcode; }
            set { clientcode = value; }
        }
        public string RefPhysician
        {
            get { return refphysician; }
            set { refphysician = value; }
        }

        #endregion
    }
}
