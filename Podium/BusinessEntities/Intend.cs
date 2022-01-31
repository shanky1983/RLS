using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Intend
	{
		#region Fields

		private long intendID=0;
		private DateTime intendDate=DateTime.MaxValue;
		private string intendNo=String.Empty;
		private string status=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long approvedBy=0;
		private DateTime approvedAt=DateTime.MaxValue;
		private int orgID=0;
		private int orgAddressID=0;
		private int locationID=0;
		private string comments=String.Empty;
		private int toLocationID=0;
		private long stockOutFlowID=0;
		private int raiseOrgID=0;
		private int raiseOrgAddID=0;
		private int stockReturnReasonType=0;
		private string stockType=String.Empty;
		private int minimumshelflife=0;
		private DateTime despatchDate=DateTime.MaxValue;
		private string referenceNo=String.Empty;
		private long referenceID=0;
		private string referenceType=String.Empty;
		private string indentType=String.Empty;
		private string rejectComments=String.Empty;
		private long oTRequestID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the IntendID value.
		/// </summary>
		public long IntendID
		{
			get { return intendID; }
			set { intendID = value; }
		}

		/// <summary>
		/// Gets or sets the IntendDate value.
		/// </summary>
		public DateTime IntendDate
		{
			get { return intendDate; }
			set { intendDate = value; }
		}

		/// <summary>
		/// Gets or sets the IntendNo value.
		/// </summary>
		public string IntendNo
		{
			get { return intendNo; }
			set { intendNo = value; }
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
		/// Gets or sets the ApprovedBy value.
		/// </summary>
		public long ApprovedBy
		{
			get { return approvedBy; }
			set { approvedBy = value; }
		}

		/// <summary>
		/// Gets or sets the ApprovedAt value.
		/// </summary>
		public DateTime ApprovedAt
		{
			get { return approvedAt; }
			set { approvedAt = value; }
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
		public int OrgAddressID
		{
			get { return orgAddressID; }
			set { orgAddressID = value; }
		}

		/// <summary>
		/// Gets or sets the LocationID value.
		/// </summary>
		public int LocationID
		{
			get { return locationID; }
			set { locationID = value; }
		}

		/// <summary>
		/// Gets or sets the Comments value.
		/// </summary>
		public string Comments
		{
			get { return comments; }
			set { comments = value; }
		}

		/// <summary>
		/// Gets or sets the ToLocationID value.
		/// </summary>
		public int ToLocationID
		{
			get { return toLocationID; }
			set { toLocationID = value; }
		}

		/// <summary>
		/// Gets or sets the StockOutFlowID value.
		/// </summary>
		public long StockOutFlowID
		{
			get { return stockOutFlowID; }
			set { stockOutFlowID = value; }
		}

		/// <summary>
		/// Gets or sets the RaiseOrgID value.
		/// </summary>
		public int RaiseOrgID
		{
			get { return raiseOrgID; }
			set { raiseOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the RaiseOrgAddID value.
		/// </summary>
		public int RaiseOrgAddID
		{
			get { return raiseOrgAddID; }
			set { raiseOrgAddID = value; }
		}

		/// <summary>
		/// Gets or sets the StockReturnReasonType value.
		/// </summary>
		public int StockReturnReasonType
		{
			get { return stockReturnReasonType; }
			set { stockReturnReasonType = value; }
		}

		/// <summary>
		/// Gets or sets the StockType value.
		/// </summary>
		public string StockType
		{
			get { return stockType; }
			set { stockType = value; }
		}

		/// <summary>
		/// Gets or sets the Minimumshelflife value.
		/// </summary>
		public int Minimumshelflife
		{
			get { return minimumshelflife; }
			set { minimumshelflife = value; }
		}

		/// <summary>
		/// Gets or sets the DespatchDate value.
		/// </summary>
		public DateTime DespatchDate
		{
			get { return despatchDate; }
			set { despatchDate = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceNo value.
		/// </summary>
		public string ReferenceNo
		{
			get { return referenceNo; }
			set { referenceNo = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceID value.
		/// </summary>
		public long ReferenceID
		{
			get { return referenceID; }
			set { referenceID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceType value.
		/// </summary>
		public string ReferenceType
		{
			get { return referenceType; }
			set { referenceType = value; }
		}

		/// <summary>
		/// Gets or sets the IndentType value.
		/// </summary>
		public string IndentType
		{
			get { return indentType; }
			set { indentType = value; }
		}

		/// <summary>
		/// Gets or sets the RejectComments value.
		/// </summary>
		public string RejectComments
		{
			get { return rejectComments; }
			set { rejectComments = value; }
		}

		/// <summary>
		/// Gets or sets the OTRequestID value.
		/// </summary>
		public long OTRequestID
		{
			get { return oTRequestID; }
			set { oTRequestID = value; }
		}

		/// <summary>
		/// Gets or sets the LocName value.
		/// </summary>
		private string _locName=String.Empty;
		public string LocName
		{
			get { return  _locName; }
			set { _locName = value; }
		}

		/// <summary>
		/// Gets or sets the ToLocName value.
		/// </summary>
		private string _toLocName=String.Empty;
		public string ToLocName
		{
			get { return  _toLocName; }
			set { _toLocName = value; }
		}

		/// <summary>
		/// Gets or sets the IntendReceivedID value.
		/// </summary>
		private long _intendReceivedID=0;
		public long IntendReceivedID
		{
			get { return  _intendReceivedID; }
			set { _intendReceivedID = value; }
		}

		/// <summary>
		/// Gets or sets the IntendReceivedDetailID value.
		/// </summary>
		private long _intendReceivedDetailID=0;
		public long IntendReceivedDetailID
		{
			get { return  _intendReceivedDetailID; }
			set { _intendReceivedDetailID = value; }
		}

		/// <summary>
		/// Gets or sets the IntendIssuedDate value.
		/// </summary>
		private DateTime _intendIssuedDate=DateTime.MaxValue;
		public DateTime IntendIssuedDate
		{
			get { return  _intendIssuedDate; }
			set { _intendIssuedDate = value; }
		}

		/// <summary>
		/// Gets or sets the IndentReceivedNo value.
		/// </summary>
		private string _indentReceivedNo=String.Empty;
		public string IndentReceivedNo
		{
			get { return  _indentReceivedNo; }
			set { _indentReceivedNo = value; }
		}

		/// <summary>
		/// Gets or sets the LoginName value.
		/// </summary>
		private string _loginName=String.Empty;
		public string LoginName
		{
			get { return  _loginName; }
			set { _loginName = value; }
		}

		/// <summary>
		/// Gets or sets the Raisedby value.
		/// </summary>
		private string _raisedby=String.Empty;
		public string Raisedby
		{
			get { return  _raisedby; }
			set { _raisedby = value; }
		}

		/// <summary>
		/// Gets or sets the PackingComments value.
		/// </summary>
		private string _packingComments=String.Empty;
		public string PackingComments
		{
			get { return  _packingComments; }
			set { _packingComments = value; }
		}

		/// <summary>
		/// Gets or sets the LocationName value.
		/// </summary>
		private string _locationName=String.Empty;
		public string LocationName
		{
			get { return  _locationName; }
			set { _locationName = value; }
		}

		/// <summary>
		/// Gets or sets the IntendReceivedStatus value.
		/// </summary>
		private string _intendReceivedStatus=String.Empty;
		public string IntendReceivedStatus
		{
			get { return  _intendReceivedStatus; }
			set { _intendReceivedStatus = value; }
		}

		/// <summary>
		/// Gets or sets the PatientName value.
		/// </summary>
		private string _patientName=String.Empty;
		public string PatientName
		{
			get { return  _patientName; }
			set { _patientName = value; }
		}

		/// <summary>
		/// Gets or sets the PatientNo value.
		/// </summary>
		private string _patientNo=String.Empty;
		public string PatientNo
		{
			get { return  _patientNo; }
			set { _patientNo = value; }
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
		/// Gets or sets the TaskId value.
		/// </summary>
		private long _taskId=0;
		public long TaskId
		{
			get { return  _taskId; }
			set { _taskId = value; }
		}


		#endregion
}
}
