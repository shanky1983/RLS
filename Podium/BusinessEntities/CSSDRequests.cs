using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class CSSDRequests
	{
		#region Fields

		private long requestID=0;
		private string requestCode=String.Empty;
		private long sourceIdentifyingID=0;
		private string sourceIdentifyingType=String.Empty;
		private byte requestMode=0x00;
		private string requestTypeCode=String.Empty;
		private string requestStatusCode=String.Empty;
		private long deliveryStaffID=0;
		private string deliveryStaffName=String.Empty;
		private long pickupStaffID=0;
		private string pickupStaffName=String.Empty;
		private string serologyResult=String.Empty;
		private string comments=String.Empty;
		private string billNumber=String.Empty;
		private string itemName=String.Empty;
		private string itemType=String.Empty;
		private long itemID=0;
		private DateTime performedDTTM=DateTime.MaxValue;
		private long performedBy=0;
		private string status=String.Empty;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the RequestID value.
		/// </summary>
		public long RequestID
		{
			get { return requestID; }
			set { requestID = value; }
		}

		/// <summary>
		/// Gets or sets the RequestCode value.
		/// </summary>
		public string RequestCode
		{
			get { return requestCode; }
			set { requestCode = value; }
		}

		/// <summary>
		/// Gets or sets the SourceIdentifyingID value.
		/// </summary>
		public long SourceIdentifyingID
		{
			get { return sourceIdentifyingID; }
			set { sourceIdentifyingID = value; }
		}

		/// <summary>
		/// Gets or sets the SourceIdentifyingType value.
		/// </summary>
		public string SourceIdentifyingType
		{
			get { return sourceIdentifyingType; }
			set { sourceIdentifyingType = value; }
		}

		/// <summary>
		/// Gets or sets the RequestMode value.
		/// </summary>
		public byte RequestMode
		{
			get { return requestMode; }
			set { requestMode = value; }
		}

		/// <summary>
		/// Gets or sets the RequestTypeCode value.
		/// </summary>
		public string RequestTypeCode
		{
			get { return requestTypeCode; }
			set { requestTypeCode = value; }
		}

		/// <summary>
		/// Gets or sets the RequestStatusCode value.
		/// </summary>
		public string RequestStatusCode
		{
			get { return requestStatusCode; }
			set { requestStatusCode = value; }
		}

		/// <summary>
		/// Gets or sets the DeliveryStaffID value.
		/// </summary>
		public long DeliveryStaffID
		{
			get { return deliveryStaffID; }
			set { deliveryStaffID = value; }
		}

		/// <summary>
		/// Gets or sets the DeliveryStaffName value.
		/// </summary>
		public string DeliveryStaffName
		{
			get { return deliveryStaffName; }
			set { deliveryStaffName = value; }
		}

		/// <summary>
		/// Gets or sets the PickupStaffID value.
		/// </summary>
		public long PickupStaffID
		{
			get { return pickupStaffID; }
			set { pickupStaffID = value; }
		}

		/// <summary>
		/// Gets or sets the PickupStaffName value.
		/// </summary>
		public string PickupStaffName
		{
			get { return pickupStaffName; }
			set { pickupStaffName = value; }
		}

		/// <summary>
		/// Gets or sets the SerologyResult value.
		/// </summary>
		public string SerologyResult
		{
			get { return serologyResult; }
			set { serologyResult = value; }
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
		/// Gets or sets the BillNumber value.
		/// </summary>
		public string BillNumber
		{
			get { return billNumber; }
			set { billNumber = value; }
		}

		/// <summary>
		/// Gets or sets the ItemName value.
		/// </summary>
		public string ItemName
		{
			get { return itemName; }
			set { itemName = value; }
		}

		/// <summary>
		/// Gets or sets the ItemType value.
		/// </summary>
		public string ItemType
		{
			get { return itemType; }
			set { itemType = value; }
		}

		/// <summary>
		/// Gets or sets the ItemID value.
		/// </summary>
		public long ItemID
		{
			get { return itemID; }
			set { itemID = value; }
		}

		/// <summary>
		/// Gets or sets the PerformedDTTM value.
		/// </summary>
		public DateTime PerformedDTTM
		{
			get { return performedDTTM; }
			set { performedDTTM = value; }
		}

		/// <summary>
		/// Gets or sets the PerformedBy value.
		/// </summary>
		public long PerformedBy
		{
			get { return performedBy; }
			set { performedBy = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
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


		#endregion
}
}
