using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ReportPublishDetails121
	{
		#region Fields

		private long resultPublishDetailsID=0;
		private long resultPublishID=0;
		private long accessionNumber=0;
		private long invID=0;
		private string type=String.Empty;
		private string invName=String.Empty;
		private DateTime disPatchdDate=DateTime.MaxValue;
		private int orgID=0;
		private string status=String.Empty;
		private long addressTypeID=0;
		private long deliveryMode=0;
		private string receiverName=String.Empty;
		private string recipient=String.Empty;
		private string comments=String.Empty;
		private long roleID=0;
		private string dispatchType=String.Empty;
		private string email=String.Empty;
		private string mobileNo=String.Empty;
		private int dispatchMode=0;
		private string despatchDate=String.Empty;
		private long userID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ResultPublishDetailsID value.
		/// </summary>
		public long ResultPublishDetailsID
		{
			get { return resultPublishDetailsID; }
			set { resultPublishDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the ResultPublishID value.
		/// </summary>
		public long ResultPublishID
		{
			get { return resultPublishID; }
			set { resultPublishID = value; }
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
		/// Gets or sets the InvID value.
		/// </summary>
		public long InvID
		{
			get { return invID; }
			set { invID = value; }
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
		/// Gets or sets the InvName value.
		/// </summary>
		public string InvName
		{
			get { return invName; }
			set { invName = value; }
		}

		/// <summary>
		/// Gets or sets the DisPatchdDate value.
		/// </summary>
		public DateTime DisPatchdDate
		{
			get { return disPatchdDate; }
			set { disPatchdDate = value; }
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
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the AddressTypeID value.
		/// </summary>
		public long AddressTypeID
		{
			get { return addressTypeID; }
			set { addressTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the DeliveryMode value.
		/// </summary>
		public long DeliveryMode
		{
			get { return deliveryMode; }
			set { deliveryMode = value; }
		}

		/// <summary>
		/// Gets or sets the ReceiverName value.
		/// </summary>
		public string ReceiverName
		{
			get { return receiverName; }
			set { receiverName = value; }
		}

		/// <summary>
		/// Gets or sets the Recipient value.
		/// </summary>
		public string Recipient
		{
			get { return recipient; }
			set { recipient = value; }
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
		/// Gets or sets the RoleID value.
		/// </summary>
		public long RoleID
		{
			get { return roleID; }
			set { roleID = value; }
		}

		/// <summary>
		/// Gets or sets the DispatchType value.
		/// </summary>
		public string DispatchType
		{
			get { return dispatchType; }
			set { dispatchType = value; }
		}

		/// <summary>
		/// Gets or sets the Email value.
		/// </summary>
		public string Email
		{
			get { return email; }
			set { email = value; }
		}

		/// <summary>
		/// Gets or sets the MobileNo value.
		/// </summary>
		public string MobileNo
		{
			get { return mobileNo; }
			set { mobileNo = value; }
		}

		/// <summary>
		/// Gets or sets the DispatchMode value.
		/// </summary>
		public int DispatchMode
		{
			get { return dispatchMode; }
			set { dispatchMode = value; }
		}

		/// <summary>
		/// Gets or sets the DespatchDate value.
		/// </summary>
		public string DespatchDate
		{
			get { return despatchDate; }
			set { despatchDate = value; }
		}

		/// <summary>
		/// Gets or sets the UserID value.
		/// </summary>
		public long UserID
		{
			get { return userID; }
			set { userID = value; }
		}


		#endregion
}
}
