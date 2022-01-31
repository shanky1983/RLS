using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class RadiologyReport
	{
		#region Fields

		private long patientVisitID=0;
		private long patientID=0;
        private DateTime visitDate = DateTime.MaxValue;
		private long referOrgID=0;
		private int orgID=0;
		private long orgAddressID=0;
		private int physicianID=0;
		
		private long createdBy=0;
        private DateTime createdAt = DateTime.MaxValue;
		private long modifiedBy=0;
        private DateTime modifiedAt = DateTime.MaxValue;
		
		private int clientID=0;
		
		private string physicianName=String.Empty;
		private int priorityID=0;
		private int referingPhysicianID=0;
		private string referingPhysicianName=String.Empty;
		private int hospitalID=0;
		private string hospitalName=String.Empty;
		private string clientName=String.Empty;
		private int collectionCentreID=0;
		private string collectionCentreName=String.Empty;
		
		private int payerID=0;
		private long externalVisitID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PatientVisitId value.
		/// </summary>
		public long PatientVisitID
		{
			get { return patientVisitID; }
			set { patientVisitID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientID value.
		/// </summary>
		public long PatientID
		{
			get { return patientID; }
			set { patientID = value; }
		}

		/// <summary>
		/// Gets or sets the VisitDate value.
		/// </summary>
		public DateTime VisitDate
		{
			get { return visitDate; }
			set { visitDate = value; }
		}

		/// <summary>
		/// Gets or sets the ReferOrgID value.
		/// </summary>
		public long ReferOrgID
		{
			get { return referOrgID; }
			set { referOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
            get { return orgID; }
            set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgAddressID value.
		/// </summary>
		public long OrgAddressID
		{
			get { return orgAddressID; }
			set { orgAddressID = value; }
		}

		/// <summary>
		/// Gets or sets the PhysicianID value.
		/// </summary>
		public int PhysicianID
		{
			get { return physicianID; }
			set { physicianID = value; }
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

		
		/// <summary>
		/// Gets or sets the ClientID value.
		/// </summary>
		public int ClientID
		{
			get { return clientID; }
			set { clientID = value; }
		}

		

		/// <summary>
		/// Gets or sets the PhysicianName value.
		/// </summary>
		public string PhysicianName
		{
			get { return physicianName; }
			set { physicianName = value; }
		}

		/// <summary>
		/// Gets or sets the PriorityID value.
		/// </summary>
		public int PriorityID
		{
			get { return priorityID; }
			set { priorityID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferingPhysicianID value.
		/// </summary>
		public int ReferingPhysicianID
		{
			get { return referingPhysicianID; }
			set { referingPhysicianID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferingPhysicianName value.
		/// </summary>
		public string ReferingPhysicianName
		{
			get { return referingPhysicianName; }
			set { referingPhysicianName = value; }
		}

		/// <summary>
		/// Gets or sets the HospitalID value.
		/// </summary>
		public int HospitalID
		{
			get { return hospitalID; }
			set { hospitalID = value; }
		}

		/// <summary>
		/// Gets or sets the HospitalName value.
		/// </summary>
		public string HospitalName
		{
			get { return hospitalName; }
			set { hospitalName = value; }
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
		/// Gets or sets the CollectionCentreID value.
		/// </summary>
		public int CollectionCentreID
		{
			get { return collectionCentreID; }
			set { collectionCentreID = value; }
		}

		/// <summary>
		/// Gets or sets the CollectionCentreName value.
		/// </summary>
		public string CollectionCentreName
		{
			get { return collectionCentreName; }
			set { collectionCentreName = value; }
		}

	
		/// <summary>
		/// Gets or sets the PayerID value.
		/// </summary>
		public int PayerID
		{
			get { return payerID; }
			set { payerID = value; }
		}

		/// <summary>
		/// Gets or sets the ExternalVisitID value.
		/// </summary>
		public long ExternalVisitID
		{
			get { return externalVisitID; }
			set { externalVisitID = value; }
		}

		
		/// <summary>
		/// Gets or sets the Location value.
		/// </summary>
		string _location;
		public string Location
		{
			get { return _location; }
			set { _location = value; }
		}

		/// <summary>
		/// Gets or sets the Name value.
		/// </summary>
		string _name;
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		/// <summary>
		/// Gets or sets the PatientName value.
		/// </summary>
		string _patientname;
		public string PatientName
		{
			get { return _patientname; }
			set { _patientname = value; }
		}

		/// <summary>
		/// Gets or sets the TitleName value.
		/// </summary>
		string _titlename;
		public string TitleName
		{
			get { return _titlename; }
			set { _titlename = value; }
		}

		
		/// <summary>
		/// Gets or sets the Address value.
		/// </summary>
		string _address;
		public string Address
		{
			get { return _address; }
			set { _address = value; }
		}

		/// <summary>
		/// Gets or sets the PatientNumber value.
		/// </summary>
		string _patientnumber;
		public string PatientNumber
		{
			get { return _patientnumber; }
			set { _patientnumber = value; }
		}

		/// <summary>
		/// Gets or sets the PhoneNumber value.
		/// </summary>
		string _phonenumber;
		public string PhoneNumber
		{
			get { return _phonenumber; }
			set { _phonenumber = value; }
		}

		/// <summary>
		/// Gets or sets the PriorityName value.
		/// </summary>
		string _priorityname;
		public string PriorityName
		{
			get { return _priorityname; }
			set { _priorityname = value; }
		}

        /// <summary>
        /// Gets or sets the ReportedBy value.
        /// </summary>
        string _reportedby;
        public string ReportedBy
        {
            get { return _reportedby; }
            set { _reportedby = value; }
        }

        /// <summary>
        /// Gets or sets the ReportPath value.
        /// </summary>
        string _reportpath;
        public string ReportPath
        {
            get { return _reportpath; }
            set { _reportpath = value; }
        }
        /// <summary>
        /// Gets or sets the AccessionNumber value.
        /// </summary>
        string _accessionnumber;
        public string AccessionNumber
        {
            get { return _accessionnumber; }
            set { _accessionnumber = value; }
        }

		/// <summary>
        /// Gets or sets the InvestigationID value.
		/// </summary>
		long _investigationid;
		public long InvestigationID
		{
            get { return _investigationid; }
            set { _investigationid = value; }
		}

        /// <summary>
        /// Gets or sets the TemplateID value.
        /// </summary>
        int _templateid;
        public int TemplateID
        {
            get { return _templateid; }
            set { _templateid = value; }
        }
		

		/// <summary>
		/// Gets or sets the PatientAge value.
		/// </summary>
		string _patientage;
		public string PatientAge
		{
			get { return _patientage; }
			set { _patientage = value; }
		}

		/// <summary>
		/// Gets or sets the Sex value.
		/// </summary>
		string _sex;
		public string Sex
		{
			get { return _sex; }
			set { _sex = value; }
		}

		/// <summary>
		/// Gets or sets the Add1 value.
		/// </summary>
		string _add1;
		public string Add1
		{
			get { return _add1; }
			set { _add1 = value; }
		}

		/// <summary>
		/// Gets or sets the Add2 value.
		/// </summary>
		string _add2;
		public string Add2
		{
			get { return _add2; }
			set { _add2 = value; }
		}

		/// <summary>
		/// Gets or sets the City value.
		/// </summary>
		string _city;
		public string City
		{
			get { return _city; }
			set { _city = value; }
		}

        /// <summary>
        /// Gets or sets the UID value.
        /// </summary>
        string _uid;
        public string UID
        {
            get { return _uid; }
            set { _uid = value; }
        }

        /// <summary>
        /// Gets or sets the ReportText value.
        /// </summary>
        string _reporttext;
        public string ReportText
        {
            get { return _reporttext; }
            set { _reporttext = value; }
        }
	
		/// <summary>
		/// Gets or sets the URNO value.
		/// </summary>
		string _urno;
		public string URNO
		{
			get { return _urno; }
			set { _urno = value; }
		}

		/// <summary>
		/// Gets or sets the MobileNumber value.
		/// </summary>
		string _mobilenumber;
		public string MobileNumber
		{
			get { return _mobilenumber; }
			set { _mobilenumber = value; }
		}

		/// <summary>
		/// Gets or sets the PerformingPhysicain value.
		/// </summary>
		string _performingphysicain;
		public string PerformingPhysicain
		{
			get { return _performingphysicain; }
			set { _performingphysicain = value; }
		}

		/// <summary>
		/// Gets or sets the Investigation value.
		/// </summary>
		string _investigation;
		public string Investigation
		{
			get { return _investigation; }
			set { _investigation = value; }
		}

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		string _status;
		public string Status
		{
			get { return _status; }
			set { _status = value; }
		}

	

		/// <summary>
		/// Gets or sets the URNofId value.
		/// </summary>
		long _urnofid;
		public long URNofId
		{
			get { return _urnofid; }
			set { _urnofid = value; }
		}

		/// <summary>
		/// Gets or sets the URNTypeId value.
		/// </summary>
		long _urntypeid;
		public long URNTypeId
		{
			get { return _urntypeid; }
			set { _urntypeid = value; }
		}


		#endregion
}
}
