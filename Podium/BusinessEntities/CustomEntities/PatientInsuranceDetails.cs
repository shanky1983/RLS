using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class PatientInsuranceDetails
    {
        #region Fields
        private int clientID;
        private string clientName;
        private int clientTypeID;
        private string clientTypeName;
        private string cardNo;
        private int subInsuranceID;
        private string subClientName;
        private string subClientTypeName;
        private int networkTypeID;
        private string networkClientName;
        private string networkClientTypeName;
        private DateTime expirydate;
        private string feeType;
        private int feeID;
        private string feeTypeDesc;
        private decimal coPay;
        private string copaytype;
        public long patientID { get; set; }

       // private long PatientID = 0;

        #endregion

        #region Properties


        
        /// <summary>
        /// Gets or sets the PatientID value.
        /// </summary>
        public long PatientID
        {
            get { return patientID; }
            set { patientID = value; }
        }

        /// <summary>
        /// Gets or sets the ClientName value.
        /// </summary>
        public int ClientID
        {
            get { return clientID; }
            set { clientID = value; }
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
        /// Gets or sets the ClientName value.
        /// </summary>
        public int ClientTypeID
        {
            get { return clientTypeID; }
            set { clientTypeID = value; }
        }
        /// <summary>
        /// Gets or sets the ClientName value.
        /// </summary>
        public string ClientTypeName
        {
            get { return clientTypeName; }
            set { clientTypeName = value; }
        }
        /// <summary>
        /// Gets or sets the CardNo value.
        /// </summary>
        public string CardNo
        {
            get { return cardNo; }
            set { cardNo = value; }
        }
        /// <summary>
        /// Gets or sets the ClientName value.
        /// </summary>
        public int SubInsuranceID
        {
            get { return subInsuranceID; }
            set { subInsuranceID = value; }
        }
        /// <summary>
        /// Gets or sets the SubClientName value.
        /// </summary>
        public string SubClientName
        {
            get { return subClientName; }
            set { subClientName = value; }
        }
        /// <summary>
        /// Gets or sets the ClientName value.
        /// </summary>
        public string SubClientTypeName
        {
            get { return subClientTypeName; }
            set { subClientTypeName = value; }
        }
        /// <summary>
        /// Gets or sets the ClientName value.
        /// </summary>
        public int NetworkTypeID
        {
            get { return networkTypeID; }
            set { networkTypeID = value; }
        }
        /// <summary>
        /// Gets or sets the NetworkClientName value.
        /// </summary>
        public string NetworkClientName
        {
            get { return networkClientName; }
            set { networkClientName = value; }
        }
        /// <summary>
        /// Gets or sets the ClientName value.
        /// </summary>
        public string NetworkClientTypeName
        {
            get { return networkClientTypeName; }
            set { networkClientTypeName = value; }
        }
        /// <summary>
        /// Gets or sets the Expirydate value.
        /// </summary>
        public DateTime Expirydate
        {
            get { return expirydate; }
            set { expirydate = value; }
        }
        /// <summary>
        /// Gets or sets the FeeType value.
        /// </summary>
        public string FeeType
        {
            get { return feeType; }
            set { feeType = value; }
        }
        /// <summary>
        /// Gets or sets the FeeType value.
        /// </summary>
        public int FeeID
        {
            get { return feeID; }
            set { feeID = value; }
        }
        /// <summary>
        /// Gets or sets the Copaytype value.
        /// </summary>
        public string FeeTypeDesc
        {
            get { return feeTypeDesc; }
            set { feeTypeDesc = value; }
        }
        /// <summary>
        /// Gets or sets the CoPay value.
        /// </summary>
        public decimal CoPay
        {
            get { return coPay; }
            set { coPay = value; }
        }
        /// <summary>
        /// Gets or sets the Copaytype value.
        /// </summary>
        public string Copaytype
        {
            get { return copaytype; }
            set { copaytype = value; }
        }
        #endregion
    }
}
