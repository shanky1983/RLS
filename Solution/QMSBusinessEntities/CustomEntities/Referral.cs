using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Referral
	{
		#region Fields

		private long referralID=0;
        private long referralDetailsID = 0;
		private int referedByOrgID=0;
		private long referedByVisitID=0;
		private int referedToOrgID=0;
		private int referralVisitPurposeID=0;
		private int referralSpecialityID=0;
		private int referedToPhysicianID=0;
		private string referralStatus=String.Empty;
		private string referralNotes=String.Empty;
		private long referedToLocation=0;
		private long referedByLocation=0;
        private DateTime createdAt = DateTime.MaxValue;
        private string allowCaseSheet = String.Empty;
        private string orderedInvStatus = String.Empty;

        private string referedToPhysicianName = String.Empty;
        private string referralSpecialityName = String.Empty;
        private int resultID = 0;
        private string resultName = String.Empty;
        private string resultTemplateType = String.Empty;
        private string referedToOrgName = String.Empty;

        private string referedByPhysicianName = String.Empty;
        private int referedByPhysicianID = 0;

		#endregion


		#region Properties

        /// <summary>
        /// Gets or sets the ReferedByPhysicianName value.
        /// </summary>
        public string ReferedByPhysicianName
        {
            get { return referedByPhysicianName; }
            set { referedByPhysicianName = value; }
        }

        /// <summary>
        /// Gets or sets the ReferedByPhysicianID value.
        /// </summary>
        public int ReferedByPhysicianID
        {
            get { return referedByPhysicianID; }
            set { referedByPhysicianID = value; }
        }



        /// <summary>
        /// Gets or sets the ReferedToPhysicianName value.
        /// </summary>
        public string ReferedToPhysicianName
        {
            get { return referedToPhysicianName; }
            set { referedToPhysicianName = value; }
        }

        /// <summary>
        /// Gets or sets the ReferralSpecialityName value.
        /// </summary>
        public string ReferralSpecialityName
        {
            get { return referralSpecialityName; }
            set { referralSpecialityName = value; }
        }


        /// <summary>
        /// Gets or sets the ResultID value.
        /// </summary>
        public int ResultID
        {
            get { return resultID; }
            set { resultID = value; }
        }

        /// <summary>
        /// Gets or sets the ResultName value.
        /// </summary>
        public string ResultName
        {
            get { return resultName; }
            set { resultName = value; }
        }

        /// <summary>
        /// Gets or sets the ResultTemplateType value.
        /// </summary>
        public string ResultTemplateType
        {
            get { return resultTemplateType; }
            set { resultTemplateType = value; }
        }

        /// <summary>
        /// Gets or sets the ReferedToOrgName value.
        /// </summary>
        public string ReferedToOrgName
        {
            get { return referedToOrgName; }
            set { referedToOrgName = value; }
        }


        /// <summary>
        /// Gets or sets the AllowCaseSheet value.
        /// </summary>
        public string OrderedInvStatus
        {
            get { return orderedInvStatus; }
            set { orderedInvStatus = value; }
        }



        /// <summary>
        /// Gets or sets the AllowCaseSheet value.
        /// </summary>
        public string AllowCaseSheet
        {
            get { return allowCaseSheet; }
            set { allowCaseSheet = value; }
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
		/// Gets or sets the ReferralID value.
		/// </summary>
		public long ReferralID
		{
			get { return referralID; }
			set { referralID = value; }
		}
        /// <summary>
        /// Gets or sets the ReferralDetailsID value.
        /// </summary>
        public long ReferralDetailsID
        {
            get { return referralDetailsID; }
            set { referralDetailsID = value; }
        }

		/// <summary>
		/// Gets or sets the ReferedByOrgID value.
		/// </summary>
		public int ReferedByOrgID
		{
			get { return referedByOrgID; }
			set { referedByOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferedByVisitID value.
		/// </summary>
		public long ReferedByVisitID
		{
			get { return referedByVisitID; }
			set { referedByVisitID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferedToOrgID value.
		/// </summary>
		public int ReferedToOrgID
		{
			get { return referedToOrgID; }
			set { referedToOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferralVisitPurposeID value.
		/// </summary>
		public int ReferralVisitPurposeID
		{
			get { return referralVisitPurposeID; }
			set { referralVisitPurposeID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferralSpecialityID value.
		/// </summary>
		public int ReferralSpecialityID
		{
			get { return referralSpecialityID; }
			set { referralSpecialityID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferedToPhysicianID value.
		/// </summary>
		public int ReferedToPhysicianID
		{
			get { return referedToPhysicianID; }
			set { referedToPhysicianID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferralStatus value.
		/// </summary>
		public string ReferralStatus
		{
			get { return referralStatus; }
			set { referralStatus = value; }
		}

		/// <summary>
		/// Gets or sets the ReferralNotes value.
		/// </summary>
		public string ReferralNotes
		{
			get { return referralNotes; }
			set { referralNotes = value; }
		}

		/// <summary>
		/// Gets or sets the ReferedToLocation value.
		/// </summary>
		public long ReferedToLocation
		{
			get { return referedToLocation; }
			set { referedToLocation = value; }
		}

		/// <summary>
		/// Gets or sets the ReferedByLocation value.
		/// </summary>
		public long ReferedByLocation
		{
			get { return referedByLocation; }
			set { referedByLocation = value; }
		}

		string _patientname;
		public string PatientName
		{
			get { return _patientname; }
			set { _patientname = value; }
		}

		/// <summary>
		/// Gets or sets the OrgName value.
		/// </summary>
		string _orgname;
		public string OrgName
		{
			get { return _orgname; }
			set { _orgname = value; }
		}

		/// <summary>
		/// Gets or sets the URN value.
		/// </summary>
		string _urn;
		public string URN
		{
			get { return _urn; }
			set { _urn = value; }
		}

		/// <summary>
		/// Gets or sets the PhoneNo value.
		/// </summary>
		string _phoneno;
		public string PhoneNo
		{
			get { return _phoneno; }
			set { _phoneno = value; }
		}

		/// <summary>
		/// Gets or sets the IsPatient value.
		/// </summary>
		string _ispatient;
		public string IsPatient
		{
			get { return _ispatient; }
			set { _ispatient = value; }
		}

		/// <summary>
		/// Gets or sets the PatientID value.
		/// </summary>
		long _patientid;
		public long PatientID
		{
			get { return _patientid; }
			set { _patientid = value; }
		}
		#endregion
}
}
