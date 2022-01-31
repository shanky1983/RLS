using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Pis146
	{
		#region Fields

		private long visitID=0;
		private int orgID=0;
		private int sampleID=0;
		private long iD=0;
		private string type=String.Empty;
		private int deptID=0;
		private long sampleInstanceID=0;
		private string uID=String.Empty;
		private string barcode=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;
		private long sID=0;
		private long sequeceid=0;
		private long seqeuenceid=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the VisitID value.
		/// </summary>
		public long VisitID
		{
			get { return visitID; }
			set { visitID = value; }
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
		/// Gets or sets the SampleID value.
		/// </summary>
		public int SampleID
		{
			get { return sampleID; }
			set { sampleID = value; }
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
		/// Gets or sets the DeptID value.
		/// </summary>
		public int DeptID
		{
			get { return deptID; }
			set { deptID = value; }
		}

		/// <summary>
		/// Gets or sets the SampleInstanceID value.
		/// </summary>
		public long SampleInstanceID
		{
			get { return sampleInstanceID; }
			set { sampleInstanceID = value; }
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
		/// Gets or sets the Barcode value.
		/// </summary>
		public string Barcode
		{
			get { return barcode; }
			set { barcode = value; }
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
		/// Gets or sets the SID value.
		/// </summary>
		public long SID
		{
			get { return sID; }
			set { sID = value; }
		}

		/// <summary>
		/// Gets or sets the Sequeceid value.
		/// </summary>
		public long Sequeceid
		{
			get { return sequeceid; }
			set { sequeceid = value; }
		}

		/// <summary>
		/// Gets or sets the Seqeuenceid value.
		/// </summary>
		public long Seqeuenceid
		{
			get { return seqeuenceid; }
			set { seqeuenceid = value; }
		}


		#endregion
}
}
