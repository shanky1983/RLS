using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class PatientInvSampleResults
	{
		#region Fields

		private long visitID=0;
		private int sampleCode=0;
		private int attributesID=0;
		private string sampleValues=String.Empty;
		private string sampleDesc=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int orgID=0;

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
		/// Gets or sets the SampleCode value.
		/// </summary>
		public int SampleCode
		{
			get { return sampleCode; }
			set { sampleCode = value; }
		}

		/// <summary>
		/// Gets or sets the AttributesID value.
		/// </summary>
		public int AttributesID
		{
			get { return attributesID; }
			set { attributesID = value; }
		}

		/// <summary>
		/// Gets or sets the SampleValues value.
		/// </summary>
		public string SampleValues
		{
			get { return sampleValues; }
			set { sampleValues = value; }
		}

		/// <summary>
		/// Gets or sets the SampleDesc value.
		/// </summary>
		public string SampleDesc
		{
			get { return sampleDesc; }
			set { sampleDesc = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the SampleName value.
		/// </summary>
		string _samplename;
		public string SampleName
		{
			get { return _samplename; }
			set { _samplename = value; }
		}

		/// <summary>
		/// Gets or sets the AttributesName value.
		/// </summary>
		string _attributesname;
		public string AttributesName
		{
			get { return _attributesname; }
			set { _attributesname = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationName value.
		/// </summary>
		string _investigationname;
		public string InvestigationName
		{
			get { return _investigationname; }
			set { _investigationname = value; }
		}


		#endregion
}
}
