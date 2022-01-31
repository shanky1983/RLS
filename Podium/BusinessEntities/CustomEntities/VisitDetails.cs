using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class VisitDetails
    {

        private string _externalVisitID = string.Empty;
        public string ExternalVisitID
        {
            get { return _externalVisitID; }
            set { _externalVisitID = value; }
        }
        private int priorityID = 0;
        /// <summary>
        /// Gets or sets the PriorityID value.
        /// </summary>
        public int PriorityID
        {
            get { return priorityID; }
            set { priorityID = value; }
        }
        //private int referingPhysicianID = 0;
        ///// <summary>
        ///// Gets or sets the ReferingPhysicianID value.
        ///// </summary>
        //public int ReferingPhysicianID
        //{
        //    get { return referingPhysicianID; }
        //    set { referingPhysicianID = value; }
        //}
        private string referingHospitalName = String.Empty;
        /// <summary>
        /// Gets or sets the ReferingPhysicianName value.
        /// </summary>
        public string ReferingHospitalName
        {
            get { return referingHospitalName; }
            set { referingHospitalName = value; }
        }
        private int referinghospitalID = 0;
        /// <summary>
        /// Gets or sets the HospitalID value.
        /// </summary>
        public int ReferinghospitalID
        {
            get { return referinghospitalID; }
            set { referinghospitalID = value; }
        }
        private int clientID = 0;
        /// <summary>
        /// Gets or sets the ClientID value.
        /// </summary>
        public int ClientID
        {
            get { return clientID; }
            set { clientID = value; }
        }		private string clientName = String.Empty;
        /// <summary>
        /// Gets or sets the ClientName value.
        /// </summary>
        public string ClientName
        {
            get { return clientName; }
            set { clientName = value; }
        }
        private string collectionCentreName = String.Empty;
        /// <summary>
        /// Gets or sets the CollectionCentreName value.
        /// </summary>
        public string CollectionCentreName
        {
            get { return collectionCentreName; }
            set { collectionCentreName = value; }
        }

        private int collectionCentreID = 0;
        public int CollectionCentreID
        {
            get { return collectionCentreID; }
            set { collectionCentreID = value; }
        }
        private ReferingPhysician referingPhysician;
        public ReferingPhysician ReferingPhysician
        {
            get { return referingPhysician; }
            set { referingPhysician = value; }
        }
        private int visitType = 0;
        /// <summary>
        /// Gets or sets the VisitType value.
        /// </summary>
        public int VisitType
        {
            get { return visitType; }
            set { visitType = value; }
        }

        private string wardNo = String.Empty;
        /// <summary>
        /// Gets or sets the WardNo value.
        /// </summary>
        public string WardNo
        {
            get { return wardNo; }
            set { wardNo = value; }
        }
        private int isDueBill = 0;
        public int IsDueBill
        {

            get { return isDueBill; }
            set { isDueBill = value; }
        }
        private string referencerange = string.Empty;
        public string ReferenceRange
        {
            get { return referencerange; }
            set { referencerange = value; }
        }
        private string age = string.Empty;
        public string Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}
