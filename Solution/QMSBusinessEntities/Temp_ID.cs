using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Temp_ID
	{
		#region Fields

		private int rowID=0;
		private string nAME=String.Empty;
		private string result=String.Empty;
		private string units=String.Empty;
		private string description=String.Empty;
		private string referenceRange=String.Empty;
		private long investigationID=0;
		private string methodName=String.Empty;
		private string notes=String.Empty;
		private string sampleName=String.Empty;
		private string isAbnormal=String.Empty;
		private string medicalRemarks=String.Empty;
		private string refRangeSuffixtest=String.Empty;
		private long deptID=0;
		private string grpID=String.Empty;
		private string isNonReportable=String.Empty;
		private long approvedBy=0;
		private string approverName=String.Empty;
		private string approverQualification=String.Empty;
		private string rootGroupID=String.Empty;
		private long parentGrpID=0;
		private string deptPrintSeparately=String.Empty;
		private int deptPageNumber=0;
		private string parentPrintSeparately=String.Empty;
		private int parentPageNumber=0;
		private string childPrintSeparately=String.Empty;
		private int childPageNumber=0;
		private long authorizedBy=0;
		private string authorizerName=String.Empty;
		private string authorizerQualification=String.Empty;
		private long patientvisiId=0;
		private string packageName=String.Empty;
		private string applicationURL=String.Empty;
		private string isRejected=String.Empty;
		private string iswithheld=String.Empty;
		private string retestRecheck=String.Empty;
		private string convReferenceRange=String.Empty;
		private string convValue=String.Empty;
		private string convUOMCode=String.Empty;
		private string codeName=String.Empty;
		private string subGroupInterpretation=String.Empty;
		private long patternID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the RowID value.
		/// </summary>
		public int RowID
		{
			get { return rowID; }
			set { rowID = value; }
		}

		/// <summary>
		/// Gets or sets the NAME value.
		/// </summary>
		public string NAME
		{
			get { return nAME; }
			set { nAME = value; }
		}

		/// <summary>
		/// Gets or sets the Result value.
		/// </summary>
		public string Result
		{
			get { return result; }
			set { result = value; }
		}

		/// <summary>
		/// Gets or sets the Units value.
		/// </summary>
		public string Units
		{
			get { return units; }
			set { units = value; }
		}

		/// <summary>
		/// Gets or sets the Description value.
		/// </summary>
		public string Description
		{
			get { return description; }
			set { description = value; }
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
		/// Gets or sets the InvestigationID value.
		/// </summary>
		public long InvestigationID
		{
			get { return investigationID; }
			set { investigationID = value; }
		}

		/// <summary>
		/// Gets or sets the MethodName value.
		/// </summary>
		public string MethodName
		{
			get { return methodName; }
			set { methodName = value; }
		}

		/// <summary>
		/// Gets or sets the Notes value.
		/// </summary>
		public string Notes
		{
			get { return notes; }
			set { notes = value; }
		}

		/// <summary>
		/// Gets or sets the SampleName value.
		/// </summary>
		public string SampleName
		{
			get { return sampleName; }
			set { sampleName = value; }
		}

		/// <summary>
		/// Gets or sets the IsAbnormal value.
		/// </summary>
		public string IsAbnormal
		{
			get { return isAbnormal; }
			set { isAbnormal = value; }
		}

		/// <summary>
		/// Gets or sets the MedicalRemarks value.
		/// </summary>
		public string MedicalRemarks
		{
			get { return medicalRemarks; }
			set { medicalRemarks = value; }
		}

		/// <summary>
		/// Gets or sets the RefRangeSuffixtest value.
		/// </summary>
		public string RefRangeSuffixtest
		{
			get { return refRangeSuffixtest; }
			set { refRangeSuffixtest = value; }
		}

		/// <summary>
		/// Gets or sets the DeptID value.
		/// </summary>
		public long DeptID
		{
			get { return deptID; }
			set { deptID = value; }
		}

		/// <summary>
		/// Gets or sets the GrpID value.
		/// </summary>
		public string GrpID
		{
			get { return grpID; }
			set { grpID = value; }
		}

		/// <summary>
		/// Gets or sets the IsNonReportable value.
		/// </summary>
		public string IsNonReportable
		{
			get { return isNonReportable; }
			set { isNonReportable = value; }
		}

		/// <summary>
		/// Gets or sets the ApprovedBy value.
		/// </summary>
		public long ApprovedBy
		{
			get { return approvedBy; }
			set { approvedBy = value; }
		}

		/// <summary>
		/// Gets or sets the ApproverName value.
		/// </summary>
		public string ApproverName
		{
			get { return approverName; }
			set { approverName = value; }
		}

		/// <summary>
		/// Gets or sets the ApproverQualification value.
		/// </summary>
		public string ApproverQualification
		{
			get { return approverQualification; }
			set { approverQualification = value; }
		}

		/// <summary>
		/// Gets or sets the RootGroupID value.
		/// </summary>
		public string RootGroupID
		{
			get { return rootGroupID; }
			set { rootGroupID = value; }
		}

		/// <summary>
		/// Gets or sets the ParentGrpID value.
		/// </summary>
		public long ParentGrpID
		{
			get { return parentGrpID; }
			set { parentGrpID = value; }
		}

		/// <summary>
		/// Gets or sets the DeptPrintSeparately value.
		/// </summary>
		public string DeptPrintSeparately
		{
			get { return deptPrintSeparately; }
			set { deptPrintSeparately = value; }
		}

		/// <summary>
		/// Gets or sets the DeptPageNumber value.
		/// </summary>
		public int DeptPageNumber
		{
			get { return deptPageNumber; }
			set { deptPageNumber = value; }
		}

		/// <summary>
		/// Gets or sets the ParentPrintSeparately value.
		/// </summary>
		public string ParentPrintSeparately
		{
			get { return parentPrintSeparately; }
			set { parentPrintSeparately = value; }
		}

		/// <summary>
		/// Gets or sets the ParentPageNumber value.
		/// </summary>
		public int ParentPageNumber
		{
			get { return parentPageNumber; }
			set { parentPageNumber = value; }
		}

		/// <summary>
		/// Gets or sets the ChildPrintSeparately value.
		/// </summary>
		public string ChildPrintSeparately
		{
			get { return childPrintSeparately; }
			set { childPrintSeparately = value; }
		}

		/// <summary>
		/// Gets or sets the ChildPageNumber value.
		/// </summary>
		public int ChildPageNumber
		{
			get { return childPageNumber; }
			set { childPageNumber = value; }
		}

		/// <summary>
		/// Gets or sets the AuthorizedBy value.
		/// </summary>
		public long AuthorizedBy
		{
			get { return authorizedBy; }
			set { authorizedBy = value; }
		}

		/// <summary>
		/// Gets or sets the AuthorizerName value.
		/// </summary>
		public string AuthorizerName
		{
			get { return authorizerName; }
			set { authorizerName = value; }
		}

		/// <summary>
		/// Gets or sets the AuthorizerQualification value.
		/// </summary>
		public string AuthorizerQualification
		{
			get { return authorizerQualification; }
			set { authorizerQualification = value; }
		}

		/// <summary>
		/// Gets or sets the PatientvisiId value.
		/// </summary>
		public long PatientvisiId
		{
			get { return patientvisiId; }
			set { patientvisiId = value; }
		}

		/// <summary>
		/// Gets or sets the PackageName value.
		/// </summary>
		public string PackageName
		{
			get { return packageName; }
			set { packageName = value; }
		}

		/// <summary>
		/// Gets or sets the ApplicationURL value.
		/// </summary>
		public string ApplicationURL
		{
			get { return applicationURL; }
			set { applicationURL = value; }
		}

		/// <summary>
		/// Gets or sets the IsRejected value.
		/// </summary>
		public string IsRejected
		{
			get { return isRejected; }
			set { isRejected = value; }
		}

		/// <summary>
		/// Gets or sets the Iswithheld value.
		/// </summary>
		public string Iswithheld
		{
			get { return iswithheld; }
			set { iswithheld = value; }
		}

		/// <summary>
		/// Gets or sets the RetestRecheck value.
		/// </summary>
		public string RetestRecheck
		{
			get { return retestRecheck; }
			set { retestRecheck = value; }
		}

		/// <summary>
		/// Gets or sets the ConvReferenceRange value.
		/// </summary>
		public string ConvReferenceRange
		{
			get { return convReferenceRange; }
			set { convReferenceRange = value; }
		}

		/// <summary>
		/// Gets or sets the ConvValue value.
		/// </summary>
		public string ConvValue
		{
			get { return convValue; }
			set { convValue = value; }
		}

		/// <summary>
		/// Gets or sets the ConvUOMCode value.
		/// </summary>
		public string ConvUOMCode
		{
			get { return convUOMCode; }
			set { convUOMCode = value; }
		}

		/// <summary>
		/// Gets or sets the CodeName value.
		/// </summary>
		public string CodeName
		{
			get { return codeName; }
			set { codeName = value; }
		}

		/// <summary>
		/// Gets or sets the SubGroupInterpretation value.
		/// </summary>
		public string SubGroupInterpretation
		{
			get { return subGroupInterpretation; }
			set { subGroupInterpretation = value; }
		}

		/// <summary>
		/// Gets or sets the PatternID value.
		/// </summary>
		public long PatternID
		{
			get { return patternID; }
			set { patternID = value; }
		}


		#endregion
}
}
