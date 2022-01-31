using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InvPackageMapping
	{
		#region Fields

		private int packageID=0;
		private long iD=0;
		private string type=String.Empty;
		private int sequenceNo=0;
		private string active=String.Empty;
		private string printSeparately=String.Empty;
		private long mapid=0;
		private string isReflex=String.Empty;
		private string isReportable=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PackageID value.
		/// </summary>
		public int PackageID
		{
			get { return packageID; }
			set { packageID = value; }
		}

		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public long ID
		{
			get { return iD; }
			set { iD = value; }
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
		/// Gets or sets the SequenceNo value.
		/// </summary>
		public int SequenceNo
		{
			get { return sequenceNo; }
			set { sequenceNo = value; }
		}

		/// <summary>
		/// Gets or sets the Active value.
		/// </summary>
		public string Active
		{
			get { return active; }
			set { active = value; }
		}

		/// <summary>
		/// Gets or sets the PrintSeparately value.
		/// </summary>
		public string PrintSeparately
		{
			get { return printSeparately; }
			set { printSeparately = value; }
		}

		/// <summary>
		/// Gets or sets the Mapid value.
		/// </summary>
		public long Mapid
		{
			get { return mapid; }
			set { mapid = value; }
		}

		/// <summary>
		/// Gets or sets the IsReflex value.
		/// </summary>
		public string IsReflex
		{
			get { return isReflex; }
			set { isReflex = value; }
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
