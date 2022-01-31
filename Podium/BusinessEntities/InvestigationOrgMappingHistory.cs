using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InvestigationOrgMappingHistory
	{
		#region Fields

		private long investigationID=0;
		private int orgID=0;
		private int deptID=0;
		private long headerID=0;
		private string display=String.Empty;
		private string referenceRange=String.Empty;
		private string displayText=String.Empty;
		private int uOMID=0;
		private string uOMCode=String.Empty;
		private int sequenceNo=0;
		private int sampleCode=0;
		private long methodID=0;
		private long principleID=0;
		private long kitID=0;
		private long instrumentID=0;
		private string qCData=String.Empty;
		private string interpretation=String.Empty;
		private int sampleContainerID=0;
		private int processingAddressID=0;
		private int modifiedBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private string panicRange=String.Empty;
		private long autoApproveLoginID=0;
		private string referenceRangeString=String.Empty;
		private string subCategory=String.Empty;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string isNonReportable=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the InvestigationID value.
		/// </summary>
		public long InvestigationID
		{
			get { return investigationID; }
			set { investigationID = value; }
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
		/// Gets or sets the DeptID value.
		/// </summary>
		public int DeptID
		{
			get { return deptID; }
			set { deptID = value; }
		}

		/// <summary>
		/// Gets or sets the HeaderID value.
		/// </summary>
		public long HeaderID
		{
			get { return headerID; }
			set { headerID = value; }
		}

		/// <summary>
		/// Gets or sets the Display value.
		/// </summary>
		public string Display
		{
			get { return display; }
			set { display = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceRange value.
		/// </summary>
		public string ReferenceRange
		{
			get { return referenceRange; }
			set { referenceRange = value; }
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
		/// Gets or sets the UOMID value.
		/// </summary>
		public int UOMID
		{
			get { return uOMID; }
			set { uOMID = value; }
		}

		/// <summary>
		/// Gets or sets the UOMCode value.
		/// </summary>
		public string UOMCode
		{
			get { return uOMCode; }
			set { uOMCode = value; }
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
		/// Gets or sets the SampleCode value.
		/// </summary>
		public int SampleCode
		{
			get { return sampleCode; }
			set { sampleCode = value; }
		}

		/// <summary>
		/// Gets or sets the MethodID value.
		/// </summary>
		public long MethodID
		{
			get { return methodID; }
			set { methodID = value; }
		}

		/// <summary>
		/// Gets or sets the PrincipleID value.
		/// </summary>
		public long PrincipleID
		{
			get { return principleID; }
			set { principleID = value; }
		}

		/// <summary>
		/// Gets or sets the KitID value.
		/// </summary>
		public long KitID
		{
			get { return kitID; }
			set { kitID = value; }
		}

		/// <summary>
		/// Gets or sets the InstrumentID value.
		/// </summary>
		public long InstrumentID
		{
			get { return instrumentID; }
			set { instrumentID = value; }
		}

		/// <summary>
		/// Gets or sets the QCData value.
		/// </summary>
		public string QCData
		{
			get { return qCData; }
			set { qCData = value; }
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
		/// Gets or sets the SampleContainerID value.
		/// </summary>
		public int SampleContainerID
		{
			get { return sampleContainerID; }
			set { sampleContainerID = value; }
		}

		/// <summary>
		/// Gets or sets the ProcessingAddressID value.
		/// </summary>
		public int ProcessingAddressID
		{
			get { return processingAddressID; }
			set { processingAddressID = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public int ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
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
		/// Gets or sets the PanicRange value.
		/// </summary>
		public string PanicRange
		{
			get { return panicRange; }
			set { panicRange = value; }
		}

		/// <summary>
		/// Gets or sets the AutoApproveLoginID value.
		/// </summary>
		public long AutoApproveLoginID
		{
			get { return autoApproveLoginID; }
			set { autoApproveLoginID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceRangeString value.
		/// </summary>
		public string ReferenceRangeString
		{
			get { return referenceRangeString; }
			set { referenceRangeString = value; }
		}

		/// <summary>
		/// Gets or sets the SubCategory value.
		/// </summary>
		public string SubCategory
		{
			get { return subCategory; }
			set { subCategory = value; }
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
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
		}

		/// <summary>
		/// Gets or sets the IsNonReportable value.
		/// </summary>
		public string IsNonReportable
		{
			get { return isNonReportable; }
			set { isNonReportable = value; }
		}


		#endregion
}
}
