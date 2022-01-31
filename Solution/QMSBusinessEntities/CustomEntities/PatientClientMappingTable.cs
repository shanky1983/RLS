using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class PatientClientMappingTable
    {
        #region Fields
        private int InsuranceProviderId;
        private int SubInsuranceId;
        private int NetworkTypeId;
        private string CardNo;
        private string ExpiryDate;
        private int DetuctableTypeId;
        private decimal DetuctableValue;      
        private int CoInsuranceTypeId;
        private decimal CoInsuranceValue;
        
        #endregion


        #region Properties
        /// <summary>
        /// Gets or sets the FeeType value.
        /// </summary>
        public int insuranceProviderId
        {
            get { return InsuranceProviderId; }
            set { InsuranceProviderId = value; }
        }
        /// <summary>
        /// Gets or sets the FeeType value.
        /// </summary>
        public int subInsuranceId
        {
            get { return SubInsuranceId; }
            set { SubInsuranceId = value; }
        }
        /// <summary>
        /// Gets or sets the FeeType value.
        /// </summary>
        public int networkTypeId
        {
            get { return NetworkTypeId; }
            set { NetworkTypeId = value; }
        }
        /// <summary>
        /// Gets or sets the FeeType value.
        /// </summary>
        public string cardNo
        {
            get { return CardNo; }
            set { CardNo = value; }
        }
        /// <summary>
        /// Gets or sets the FeeType value.
        /// </summary>
        public string expiryDate
        {
            get { return ExpiryDate; }
            set { ExpiryDate = value; }
        }
        /// <summary>
        /// Gets or sets the FeeType value.
        /// </summary>
        public int detuctableTypeId
        {
            get { return DetuctableTypeId; }
            set { DetuctableTypeId = value; }
        }
        /// <summary>
        /// Gets or sets the FeeType value.
        /// </summary>
        public decimal detuctableValue
        {
            get { return DetuctableValue; }
            set { DetuctableValue = value; }
        }
        /// <summary>
        /// Gets or sets the FeeType value.
        /// </summary>
        public int coInsuranceTypeId
        {
            get { return CoInsuranceTypeId; }
            set { CoInsuranceTypeId = value; }
        }
        /// <summary>
        /// Gets or sets the FeeType value.
        /// </summary>
        public decimal coInsuranceValue
        {
            get { return CoInsuranceValue; }
            set { CoInsuranceValue = value; }
        }

        #endregion
    }
}


