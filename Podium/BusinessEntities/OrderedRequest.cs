using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class OrderedRequest
	{
		#region Fields

		private long orderedRequestID=0;
		private long patientID=0;
		private long visitID=0;
		private long physicianID=0;
		private long feeID=0;
		private string feeType=String.Empty;
		private string feeDescription=String.Empty;
		private decimal quantity=Decimal.Zero;
		private decimal amount=Decimal.Zero;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string status=String.Empty;
		private string performerType=String.Empty;
		private long performerID=0;
		private string remarks=String.Empty;
		private int rateID=0;
		private int clientID=0;
		private long orderTaskID=0;
		private long specialityID=0;
		private string isSTAT=String.Empty;
		private DateTime orderedDate=DateTime.MaxValue;
		private DateTime tatDateTime=DateTime.MaxValue;
		private string pageType=String.Empty;
		private long taskID=0;
		private long orderServiceNo=0;
		private long packageID=0;
		private string cancelReason=String.Empty;
		private int patientFollowupID=0;
		private string isReimbursable=String.Empty;
		private string isTaxable=String.Empty;
		private string isDiscountable=String.Empty;
		private string batchNo=String.Empty;
		private DateTime expiryDate=DateTime.MaxValue;
		private decimal taxPercent=Decimal.Zero;
		private int locationID=0;
		private int receivedUniqueNumber=0;
		private long visitConsID=0;
		private string refPhyName=String.Empty;
		private long refPhysicianID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the OrderedRequestID value.
		/// </summary>
		public long OrderedRequestID
		{
			get { return orderedRequestID; }
			set { orderedRequestID = value; }
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
		/// Gets or sets the VisitID value.
		/// </summary>
		public long VisitID
		{
			get { return visitID; }
			set { visitID = value; }
		}

		/// <summary>
		/// Gets or sets the PhysicianID value.
		/// </summary>
		public long PhysicianID
		{
			get { return physicianID; }
			set { physicianID = value; }
		}

		/// <summary>
		/// Gets or sets the FeeID value.
		/// </summary>
		public long FeeID
		{
			get { return feeID; }
			set { feeID = value; }
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
		/// Gets or sets the FeeDescription value.
		/// </summary>
		public string FeeDescription
		{
			get { return feeDescription; }
			set { feeDescription = value; }
		}

		/// <summary>
		/// Gets or sets the Quantity value.
		/// </summary>
		public decimal Quantity
		{
			get { return quantity; }
			set { quantity = value; }
		}

		/// <summary>
		/// Gets or sets the Amount value.
		/// </summary>
		public decimal Amount
		{
			get { return amount; }
			set { amount = value; }
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
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the PerformerType value.
		/// </summary>
		public string PerformerType
		{
			get { return performerType; }
			set { performerType = value; }
		}

		/// <summary>
		/// Gets or sets the PerformerID value.
		/// </summary>
		public long PerformerID
		{
			get { return performerID; }
			set { performerID = value; }
		}

		/// <summary>
		/// Gets or sets the Remarks value.
		/// </summary>
		public string Remarks
		{
			get { return remarks; }
			set { remarks = value; }
		}

		/// <summary>
		/// Gets or sets the RateID value.
		/// </summary>
		public int RateID
		{
			get { return rateID; }
			set { rateID = value; }
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
		/// Gets or sets the OrderTaskID value.
		/// </summary>
		public long OrderTaskID
		{
			get { return orderTaskID; }
			set { orderTaskID = value; }
		}

		/// <summary>
		/// Gets or sets the SpecialityID value.
		/// </summary>
		public long SpecialityID
		{
			get { return specialityID; }
			set { specialityID = value; }
		}

		/// <summary>
		/// Gets or sets the IsSTAT value.
		/// </summary>
		public string IsSTAT
		{
			get { return isSTAT; }
			set { isSTAT = value; }
		}

		/// <summary>
		/// Gets or sets the OrderedDate value.
		/// </summary>
		public DateTime OrderedDate
		{
			get { return orderedDate; }
			set { orderedDate = value; }
		}

		/// <summary>
		/// Gets or sets the TatDateTime value.
		/// </summary>
		public DateTime TatDateTime
		{
			get { return tatDateTime; }
			set { tatDateTime = value; }
		}

		/// <summary>
		/// Gets or sets the PageType value.
		/// </summary>
		public string PageType
		{
			get { return pageType; }
			set { pageType = value; }
		}

		/// <summary>
		/// Gets or sets the TaskID value.
		/// </summary>
		public long TaskID
		{
			get { return taskID; }
			set { taskID = value; }
		}

		/// <summary>
		/// Gets or sets the OrderServiceNo value.
		/// </summary>
		public long OrderServiceNo
		{
			get { return orderServiceNo; }
			set { orderServiceNo = value; }
		}

		/// <summary>
		/// Gets or sets the PackageID value.
		/// </summary>
		public long PackageID
		{
			get { return packageID; }
			set { packageID = value; }
		}

		/// <summary>
		/// Gets or sets the CancelReason value.
		/// </summary>
		public string CancelReason
		{
			get { return cancelReason; }
			set { cancelReason = value; }
		}

		/// <summary>
		/// Gets or sets the PatientFollowupID value.
		/// </summary>
		public int PatientFollowupID
		{
			get { return patientFollowupID; }
			set { patientFollowupID = value; }
		}

		/// <summary>
		/// Gets or sets the IsReimbursable value.
		/// </summary>
		public string IsReimbursable
		{
			get { return isReimbursable; }
			set { isReimbursable = value; }
		}

		/// <summary>
		/// Gets or sets the IsTaxable value.
		/// </summary>
		public string IsTaxable
		{
			get { return isTaxable; }
			set { isTaxable = value; }
		}

		/// <summary>
		/// Gets or sets the IsDiscountable value.
		/// </summary>
		public string IsDiscountable
		{
			get { return isDiscountable; }
			set { isDiscountable = value; }
		}

		/// <summary>
		/// Gets or sets the BatchNo value.
		/// </summary>
		public string BatchNo
		{
			get { return batchNo; }
			set { batchNo = value; }
		}

		/// <summary>
		/// Gets or sets the ExpiryDate value.
		/// </summary>
		public DateTime ExpiryDate
		{
			get { return expiryDate; }
			set { expiryDate = value; }
		}

		/// <summary>
		/// Gets or sets the TaxPercent value.
		/// </summary>
		public decimal TaxPercent
		{
			get { return taxPercent; }
			set { taxPercent = value; }
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
		/// Gets or sets the ReceivedUniqueNumber value.
		/// </summary>
		public int ReceivedUniqueNumber
		{
			get { return receivedUniqueNumber; }
			set { receivedUniqueNumber = value; }
		}

		/// <summary>
		/// Gets or sets the VisitConsID value.
		/// </summary>
		public long VisitConsID
		{
			get { return visitConsID; }
			set { visitConsID = value; }
		}

		/// <summary>
		/// Gets or sets the RefPhyName value.
		/// </summary>
		public string RefPhyName
		{
			get { return refPhyName; }
			set { refPhyName = value; }
		}

		/// <summary>
		/// Gets or sets the RefPhysicianID value.
		/// </summary>
		public long RefPhysicianID
		{
			get { return refPhysicianID; }
			set { refPhysicianID = value; }
		}


		#endregion
}
}
