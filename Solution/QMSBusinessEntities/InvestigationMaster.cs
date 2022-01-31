using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class InvestigationMaster
	{
		#region Fields

		private long investigationID=0;
		private string investigationName=String.Empty;
		private int uOMID=0;
		private string display=String.Empty;
		private string testCode=String.Empty;
		private string isParameter=String.Empty;
		private DateTime createdat=DateTime.MaxValue;
		private long createdBy=0;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int patternID=0;
		private string codeName=String.Empty;

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
		/// Gets or sets the InvestigationName value.
		/// </summary>
		public string InvestigationName
		{
			get { return investigationName; }
			set { investigationName = value; }
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
		/// Gets or sets the Display value.
		/// </summary>
		public string Display
		{
			get { return display; }
			set { display = value; }
		}

		/// <summary>
		/// Gets or sets the TestCode value.
		/// </summary>
		public string TestCode
		{
			get { return testCode; }
			set { testCode = value; }
		}

		/// <summary>
		/// Gets or sets the IsParameter value.
		/// </summary>
		public string IsParameter
		{
			get { return isParameter; }
			set { isParameter = value; }
		}

		/// <summary>
		/// Gets or sets the Createdat value.
		/// </summary>
		public DateTime Createdat
		{
			get { return createdat; }
			set { createdat = value; }
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
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
		}

		/// <summary>
		/// Gets or sets the PatternID value.
		/// </summary>
		public int PatternID
		{
			get { return patternID; }
			set { patternID = value; }
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
		/// Gets or sets the IsMapped value.
		/// </summary>
		string _ismapped;
		public string IsMapped
		{
			get { return _ismapped; }
			set { _ismapped = value; }
		}

		/// <summary>
		/// Gets or sets the PatternID value.
		/// </summary>
		

		/// <summary>
		/// Gets or sets the CodeName value.
		/// </summary>
	


		#endregion
}
}
