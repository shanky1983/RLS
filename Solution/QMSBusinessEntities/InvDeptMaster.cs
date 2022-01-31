using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
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
		/// Gets or sets the RoleID value.
		/// </summary>
		long _roleid;
		public long RoleID
		{
			get { return _roleid; }
			set { _roleid = value; }
		}


		#endregion
}
}
