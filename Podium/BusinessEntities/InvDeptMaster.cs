using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InvDeptMaster
	{
		#region Fields

		private int deptID=0;
		private string deptName=String.Empty;
		private int orgID=0;
		private string display=String.Empty;
		private int sequenceNo=0;
		private string deptCode=String.Empty;
		private string code=String.Empty;
		private string printSeparately=String.Empty;
		private int invdeptid=0;
		private string isSorting=String.Empty;
		private int attunedeptid=0;
		private string isMLNumber=String.Empty;
		private int processingSequence=0;
		private string pdfGenerationForOutBound=String.Empty;
		private string langCode=String.Empty;
		private string departmentCode=String.Empty;
		private long createdBy=0;
		private long modifiedBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private DateTime modifiedAt=DateTime.MaxValue;
		private bool isShareAble=false;
        private bool isclientsms = true;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DeptID value.
		/// </summary>
		public int DeptID
		{
			get { return deptID; }
			set { deptID = value; }
		}

		/// <summary>
		/// Gets or sets the DeptName value.
		/// </summary>
		public string DeptName
		{
			get { return deptName; }
			set { deptName = value; }
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
		/// Gets or sets the Display value.
		/// </summary>
		public string Display
		{
			get { return display; }
			set { display = value; }
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
		/// Gets or sets the DeptCode value.
		/// </summary>
		public string DeptCode
		{
			get { return deptCode; }
			set { deptCode = value; }
		}

		/// <summary>
		/// Gets or sets the Code value.
		/// </summary>
		public string Code
		{
			get { return code; }
			set { code = value; }
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
		/// Gets or sets the Invdeptid value.
		/// </summary>
		public int Invdeptid
		{
			get { return invdeptid; }
			set { invdeptid = value; }
		}

		/// <summary>
		/// Gets or sets the IsSorting value.
		/// </summary>
		public string IsSorting
		{
			get { return isSorting; }
			set { isSorting = value; }
		}

		/// <summary>
		/// Gets or sets the Attunedeptid value.
		/// </summary>
		public int Attunedeptid
		{
			get { return attunedeptid; }
			set { attunedeptid = value; }
		}

		/// <summary>
		/// Gets or sets the IsMLNumber value.
		/// </summary>
		public string IsMLNumber
		{
			get { return isMLNumber; }
			set { isMLNumber = value; }
		}

		/// <summary>
		/// Gets or sets the ProcessingSequence value.
		/// </summary>
		public int ProcessingSequence
		{
			get { return processingSequence; }
			set { processingSequence = value; }
		}

		/// <summary>
		/// Gets or sets the PdfGenerationForOutBound value.
		/// </summary>
		public string PdfGenerationForOutBound
		{
			get { return pdfGenerationForOutBound; }
			set { pdfGenerationForOutBound = value; }
		}

		/// <summary>
		/// Gets or sets the LangCode value.
		/// </summary>
		public string LangCode
		{
			get { return langCode; }
			set { langCode = value; }
		}

		/// <summary>
		/// Gets or sets the DepartmentCode value.
		/// </summary>
		public string DepartmentCode
		{
			get { return departmentCode; }
			set { departmentCode = value; }
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
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public long ModifiedBy
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
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
		}

		/// <summary>
		/// Gets or sets the IsShareAble value.
		/// </summary>
		public bool IsShareAble
		{
			get { return isShareAble; }
			set { isShareAble = value; }
		}

		/// <summary>
		/// Gets or sets the RoleID value.
		/// </summary>
		private long _roleID=0;
		public long RoleID
		{
			get { return  _roleID; }
			set { _roleID = value; }
		}

		/// <summary>
		/// Gets or sets the Location value.
		/// </summary>
		private string _location=String.Empty;
		public string Location
		{
			get { return  _location; }
			set { _location = value; }
		}

		/// <summary>
		/// Gets or sets the LocationDetails value.
		/// </summary>
		private string _locationDetails=String.Empty;
		public string LocationDetails
		{
			get { return  _locationDetails; }
			set { _locationDetails = value; }
		}

		/// <summary>
		/// Gets or sets the AutoScanIn value.
		/// </summary>
		private string _autoScanIn=String.Empty;
		public string AutoScanIn
		{
			get { return  _autoScanIn; }
			set { _autoScanIn = value; }
		}

		/// <summary>
		/// Gets or sets the IsAutoScanIn value.
		/// </summary>
		private string _isAutoScanIn=String.Empty;
		public string IsAutoScanIn
		{
			get { return  _isAutoScanIn; }
			set { _isAutoScanIn = value; }
		}

		/// <summary>
		/// Gets or sets the IsScanInRequired value.
		/// </summary>
		private bool _isScanInRequired=false;
		public bool IsScanInRequired
		{
			get { return  _isScanInRequired; }
			set { _isScanInRequired = value; }
		}

        public bool IsClientSMS
        {
            get { return isclientsms; }
            set { isclientsms = value; }
        }
		#endregion
}
}
