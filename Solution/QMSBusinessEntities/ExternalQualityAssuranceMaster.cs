using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ExternalQualityAssuranceMaster
	{
		#region Fields

		private long iD=0;
		private long vendorID=0;
		private string cycleIdentification=String.Empty;
		private DateTime dateOfProcessing=DateTime.MaxValue;
		private string interpretation=String.Empty;
		private string hasFile=String.Empty;
		private string fileType=String.Empty;
		private string filePath=String.Empty;
		private long orgId=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string resultType=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public long ID
		{
			get { return iD; }
			set { iD = value; }
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
		/// Gets or sets the CycleIdentification value.
		/// </summary>
		public string CycleIdentification
		{
			get { return cycleIdentification; }
			set { cycleIdentification = value; }
		}

		/// <summary>
		/// Gets or sets the DateOfProcessing value.
		/// </summary>
		public DateTime DateOfProcessing
		{
			get { return dateOfProcessing; }
			set { dateOfProcessing = value; }
		}

		/// <summary>
		/// Gets or sets the Interpretation value.
		/// </summary>
		public string Interpretation
		{
			get { return interpretation; }
			set { interpretation = value; }
		}

		/// <summary>
		/// Gets or sets the HasFile value.
		/// </summary>
		public string HasFile
		{
			get { return hasFile; }
			set { hasFile = value; }
		}

		/// <summary>
		/// Gets or sets the FileType value.
		/// </summary>
		public string FileType
		{
			get { return fileType; }
			set { fileType = value; }
		}

		/// <summary>
		/// Gets or sets the FilePath value.
		/// </summary>
		public string FilePath
		{
			get { return filePath; }
			set { filePath = value; }
		}

		/// <summary>
		/// Gets or sets the OrgId value.
		/// </summary>
		public long OrgId
		{
			get { return orgId; }
			set { orgId = value; }
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
		/// Gets or sets the ResultType value.
		/// </summary>
		public string ResultType
		{
			get { return resultType; }
			set { resultType = value; }
		}


		#endregion
}
}
