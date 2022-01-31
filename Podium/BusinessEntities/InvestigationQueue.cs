using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
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
		private String _investigationName=String.Empty;
		public String InvestigationName
		{
			get { return  _investigationName; }
			set { _investigationName = value; }
		}

		/// <summary>
		/// Gets or sets the PatientName value.
		/// </summary>
		private String _patientName=String.Empty;
		public String PatientName
		{
			get { return  _patientName; }
			set { _patientName = value; }
		}

		/// <summary>
		/// Gets or sets the PatientID value.
		/// </summary>
		private long _patientID=0;
		public long PatientID
		{
			get { return  _patientID; }
			set { _patientID = value; }
		}

		/// <summary>
		/// Gets or sets the ClientID value.
		/// </summary>
		private int _clientID=0;
		public int ClientID
		{
			get { return  _clientID; }
			set { _clientID = value; }
		}

		/// <summary>
		/// Gets or sets the VisitDate value.
		/// </summary>
		private DateTime _visitDate=DateTime.MaxValue;
		public DateTime VisitDate
		{
			get { return  _visitDate; }
			set { _visitDate = value; }
		}

		/// <summary>
		/// Gets or sets the ReferingPhysicianName value.
		/// </summary>
		private String _referingPhysicianName=String.Empty;
		public String ReferingPhysicianName
		{
			get { return  _referingPhysicianName; }
			set { _referingPhysicianName = value; }
		}

		/// <summary>
		/// Gets or sets the PhoneNo value.
		/// </summary>
		private String _phoneNo=String.Empty;
		public String PhoneNo
		{
			get { return  _phoneNo; }
			set { _phoneNo = value; }
		}

		/// <summary>
		/// Gets or sets the PatientNumber value.
		/// </summary>
		private String _patientNumber=String.Empty;
		public String PatientNumber
		{
			get { return  _patientNumber; }
			set { _patientNumber = value; }
		}

		/// <summary>
		/// Gets or sets the Location value.
		/// </summary>
		private String _location=String.Empty;
		public String Location
		{
			get { return  _location; }
			set { _location = value; }
		}

		/// <summary>
		/// Gets or sets the SampleDesc value.
		/// </summary>
		private String _sampleDesc=String.Empty;
		public String SampleDesc
		{
			get { return  _sampleDesc; }
			set { _sampleDesc = value; }
		}

		/// <summary>
		/// Gets or sets the FromDate value.
		/// </summary>
		private String _fromDate=String.Empty;
		public String FromDate
		{
			get { return  _fromDate; }
			set { _fromDate = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationIDs value.
		/// </summary>
		private String _investigationIDs=String.Empty;
		public String InvestigationIDs
		{
			get { return  _investigationIDs; }
			set { _investigationIDs = value; }
		}

		/// <summary>
		/// Gets or sets the AccessionNumbers value.
		/// </summary>
		private String _accessionNumbers=String.Empty;
		public String AccessionNumbers
		{
			get { return  _accessionNumbers; }
			set { _accessionNumbers = value; }
		}

		/// <summary>
		/// Gets or sets the AddressID value.
		/// </summary>
		private long _addressID=0;
		public long AddressID
		{
			get { return  _addressID; }
			set { _addressID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientStatus value.
		/// </summary>
		private String _patientStatus=String.Empty;
		public String PatientStatus
		{
			get { return  _patientStatus; }
			set { _patientStatus = value; }
		}

		/// <summary>
		/// Gets or sets the BillNumber value.
		/// </summary>
		private String _billNumber=String.Empty;
		public String BillNumber
		{
			get { return  _billNumber; }
			set { _billNumber = value; }
		}

		/// <summary>
		/// Gets or sets the DisplayStatus value.
		/// </summary>
		private string _displayStatus=String.Empty;
		public string DisplayStatus
		{
			get { return  _displayStatus; }
			set { _displayStatus = value; }
		}

		/// <summary>
		/// Gets or sets the LabNo value.
		/// </summary>
		private string _labNo=String.Empty;
		public string LabNo
		{
			get { return  _labNo; }
			set { _labNo = value; }
		}

		/// <summary>
		/// Gets or sets the Reason value.
		/// </summary>
		private string _reason=String.Empty;
		public string Reason
		{
			get { return  _reason; }
			set { _reason = value; }
		}


		#endregion
}
}
