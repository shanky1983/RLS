using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class InvestigationQueue
	{
		#region Fields

		private long testID=0;
		private long visitID=0;
		private string uID=String.Empty;
		private int orgID=0;
		private long investigationID=0;
		private string type=String.Empty;
		private string status=String.Empty;
		private string orderedUID=String.Empty;
		private long accessionNumber=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private string isReportable=String.Empty;
		private string isBillable=String.Empty;
		private string parentName=String.Empty;
		private int parentInvId=0;
		private string billableStatus=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the TestID value.
		/// </summary>
		public long TestID
		{
			get { return testID; }
			set { testID = value; }
		}

		/// <summary>
		/// Gets or sets the VisitID value.
		/// </summary>
		public long VisitID
		{
			get { return visitID; }
			set { visitID = value; }
		}

		/// <summary>
		/// Gets or sets the UID value.
		/// </summary>
		public string UID
		{
			get { return uID; }
			set { uID = value; }
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
		/// Gets or sets the InvestigationID value.
		/// </summary>
		public long InvestigationID
		{
			get { return investigationID; }
			set { investigationID = value; }
		}

		/// <summary>
		/// Gets or sets the Type value.
		/// </summary>
		public string Type
		{
			get { return type; }
			set { type = value; }
		}

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the OrderedUID value.
		/// </summary>
		public string OrderedUID
		{
			get { return orderedUID; }
			set { orderedUID = value; }
		}

		/// <summary>
		/// Gets or sets the AccessionNumber value.
		/// </summary>
		public long AccessionNumber
		{
			get { return accessionNumber; }
			set { accessionNumber = value; }
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
		public long CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
		}

		/// <summary>
		/// Gets or sets the IsReportable value.
		/// </summary>
		public string IsReportable
		{
			get { return isReportable; }
			set { isReportable = value; }
		}

		/// <summary>
		/// Gets or sets the IsBillable value.
		/// </summary>
		public string IsBillable
		{
			get { return isBillable; }
			set { isBillable = value; }
		}

		/// <summary>
		/// Gets or sets the ParentName value.
		/// </summary>
		public string ParentName
		{
			get { return parentName; }
			set { parentName = value; }
		}

		/// <summary>
		/// Gets or sets the ParentInvId value.
		/// </summary>
		public int ParentInvId
		{
			get { return parentInvId; }
			set { parentInvId = value; }
		}

		/// <summary>
		/// Gets or sets the BillableStatus value.
		/// </summary>
		public string BillableStatus
		{
			get { return billableStatus; }
			set { billableStatus = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationName value.
		/// </summary>
		String _investigationname;
		public String InvestigationName
		{
			get { return _investigationname; }
			set { _investigationname = value; }
		}

		/// <summary>
		/// Gets or sets the PatientName value.
		/// </summary>
		String _patientname;
		public String PatientName
		{
			get { return _patientname; }
			set { _patientname = value; }
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

		/// <summary>
		/// Gets or sets the ClientID value.
		/// </summary>
		int _clientid;
		public int ClientID
		{
			get { return _clientid; }
			set { _clientid = value; }
		}

		/// <summary>
		/// Gets or sets the VisitDate value.
		/// </summary>
		DateTime _visitdate;
		public DateTime VisitDate
		{
			get { return _visitdate; }
			set { _visitdate = value; }
		}

		/// <summary>
		/// Gets or sets the ReferingPhysicianName value.
		/// </summary>
		String _referingphysicianname;
		public String ReferingPhysicianName
		{
			get { return _referingphysicianname; }
			set { _referingphysicianname = value; }
		}

		/// <summary>
		/// Gets or sets the PhoneNo value.
		/// </summary>
		String _phoneno;
		public String PhoneNo
		{
			get { return _phoneno; }
			set { _phoneno = value; }
		}

		/// <summary>
		/// Gets or sets the PatientNumber value.
		/// </summary>
		String _patientnumber;
		public String PatientNumber
		{
			get { return _patientnumber; }
			set { _patientnumber = value; }
		}

		/// <summary>
		/// Gets or sets the Location value.
		/// </summary>
		String _location;
		public String Location
		{
			get { return _location; }
			set { _location = value; }
		}

		/// <summary>
		/// Gets or sets the SampleDesc value.
		/// </summary>
		String _sampledesc;
		public String SampleDesc
		{
			get { return _sampledesc; }
			set { _sampledesc = value; }
		}

		/// <summary>
		/// Gets or sets the FromDate value.
		/// </summary>
		String _fromdate;
		public String FromDate
		{
			get { return _fromdate; }
			set { _fromdate = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationIDs value.
		/// </summary>
		String _investigationids;
		public String InvestigationIDs
		{
			get { return _investigationids; }
			set { _investigationids = value; }
		}

		/// <summary>
		/// Gets or sets the AccessionNumbers value.
		/// </summary>
		String _accessionnumbers;
		public String AccessionNumbers
		{
			get { return _accessionnumbers; }
			set { _accessionnumbers = value; }
		}

		/// <summary>
		/// Gets or sets the AddressID value.
		/// </summary>
		long _addressid;
		public long AddressID
		{
			get { return _addressid; }
			set { _addressid = value; }
		}

		/// <summary>
		/// Gets or sets the PatientStatus value.
		/// </summary>
		String _patientstatus;
		public String PatientStatus
		{
			get { return _patientstatus; }
			set { _patientstatus = value; }
		}

		/// <summary>
		/// Gets or sets the BillNumber value.
		/// </summary>
		String _billnumber;
		public String BillNumber
		{
			get { return _billnumber; }
			set { _billnumber = value; }
		}

		/// <summary>
		/// Gets or sets the DisplayStatus value.
		/// </summary>
		string _displaystatus;
		public string DisplayStatus
		{
			get { return _displaystatus; }
			set { _displaystatus = value; }
		}


		#endregion
}
}
