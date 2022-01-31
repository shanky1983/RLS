using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class LotMaster
	{
		#region Fields

		private long lotID=0;
		private string lotName=String.Empty;
		private string lotCode=String.Empty;
		private long macID=0;
		private long vendorID=0;
		private string displayText=String.Empty;
		private DateTime expiryDate=DateTime.MaxValue;
		private string isExpired=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdby=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedby=0;
		private int orgID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the LotID value.
		/// </summary>
		public long LotID
		{
			get { return lotID; }
			set { lotID = value; }
		}

		/// <summary>
		/// Gets or sets the LotName value.
		/// </summary>
		public string LotName
		{
			get { return lotName; }
			set { lotName = value; }
		}

		/// <summary>
		/// Gets or sets the LotCode value.
		/// </summary>
		public string LotCode
		{
			get { return lotCode; }
			set { lotCode = value; }
		}

		/// <summary>
		/// Gets or sets the MacID value.
		/// </summary>
		public long MacID
		{
			get { return macID; }
			set { macID = value; }
		}

		/// <summary>
		/// Gets or sets the VendorID value.
		/// </summary>
		public long VendorID
		{
			get { return vendorID; }
			set { vendorID = value; }
		}

		/// <summary>
		/// Gets or sets the DisplayText value.
		/// </summary>
		public string DisplayText
		{
			get { return displayText; }
			set { displayText = value; }
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
		/// Gets or sets the IsExpired value.
		/// </summary>
		public string IsExpired
		{
			get { return isExpired; }
			set { isExpired = value; }
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
		/// Gets or sets the Createdby value.
		/// </summary>
		public long Createdby
		{
			get { return createdby; }
			set { createdby = value; }
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
		/// Gets or sets the Modifiedby value.
		/// </summary>
		public long Modifiedby
		{
			get { return modifiedby; }
			set { modifiedby = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}


		#endregion
}
}
