using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class DeviceManufacturer
	{
		#region Fields

		private long macID=0;
		private string manufacturerName=String.Empty;
		private string manufacturerCode=String.Empty;
		private string emailID=String.Empty;
		private string mobileNo=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdby=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedby=0;
		private string isActive=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the MacID value.
		/// </summary>
		public long MacID
		{
			get { return macID; }
			set { macID = value; }
		}

		/// <summary>
		/// Gets or sets the ManufacturerName value.
		/// </summary>
		public string ManufacturerName
		{
			get { return manufacturerName; }
			set { manufacturerName = value; }
		}

		/// <summary>
		/// Gets or sets the ManufacturerCode value.
		/// </summary>
		public string ManufacturerCode
		{
			get { return manufacturerCode; }
			set { manufacturerCode = value; }
		}

		/// <summary>
		/// Gets or sets the EmailID value.
		/// </summary>
		public string EmailID
		{
			get { return emailID; }
			set { emailID = value; }
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
		/// Gets or sets the IsActive value.
		/// </summary>
		public string IsActive
		{
			get { return isActive; }
			set { isActive = value; }
		}


		#endregion
}
}
