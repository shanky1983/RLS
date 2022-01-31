using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ReferralDetails
	{
		#region Fields

		private long referralDetailsID=0;
		private long referralID=0;
		private int referralVisitPurposeID=0;
		private int referralSpecialityID=0;
		private int referedToPhysicianID=0;
		private string referralNotes=String.Empty;
		private string referralStatus=String.Empty;
		private long performingVisitID=0;
		private string allowCaseSheet=String.Empty;
		private int referedByPhysicianID=0;
		private string referedByPhysicianName=String.Empty;
		private string referedToPhysicianName=String.Empty;
		private string referralSpecialityName=String.Empty;
		private int resultID=0;
		private string resultName=String.Empty;
		private string resultTemplateType=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ReferralDetailsID value.
		/// </summary>
		public long ReferralDetailsID
		{
			get { return referralDetailsID; }
			set { referralDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferralID value.
		/// </summary>
		public long ReferralID
		{
			get { return referralID; }
			set { referralID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferralVisitPurposeID value.
		/// </summary>
		public int ReferralVisitPurposeID
		{
			get { return referralVisitPurposeID; }
			set { referralVisitPurposeID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferralSpecialityID value.
		/// </summary>
		public int ReferralSpecialityID
		{
			get { return referralSpecialityID; }
			set { referralSpecialityID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferedToPhysicianID value.
		/// </summary>
		public int ReferedToPhysicianID
		{
			get { return referedToPhysicianID; }
			set { referedToPhysicianID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferralNotes value.
		/// </summary>
		public string ReferralNotes
		{
			get { return referralNotes; }
			set { referralNotes = value; }
		}

		/// <summary>
		/// Gets or sets the ReferralStatus value.
		/// </summary>
		public string ReferralStatus
		{
			get { return referralStatus; }
			set { referralStatus = value; }
		}

		/// <summary>
		/// Gets or sets the PerformingVisitID value.
		/// </summary>
		public long PerformingVisitID
		{
			get { return performingVisitID; }
			set { performingVisitID = value; }
		}

		/// <summary>
		/// Gets or sets the AllowCaseSheet value.
		/// </summary>
		public string AllowCaseSheet
		{
			get { return allowCaseSheet; }
			set { allowCaseSheet = value; }
		}

		/// <summary>
		/// Gets or sets the ReferedByPhysicianID value.
		/// </summary>
		public int ReferedByPhysicianID
		{
			get { return referedByPhysicianID; }
			set { referedByPhysicianID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferedByPhysicianName value.
		/// </summary>
		public string ReferedByPhysicianName
		{
			get { return referedByPhysicianName; }
			set { referedByPhysicianName = value; }
		}

		/// <summary>
		/// Gets or sets the ReferedToPhysicianName value.
		/// </summary>
		public string ReferedToPhysicianName
		{
			get { return referedToPhysicianName; }
			set { referedToPhysicianName = value; }
		}

		/// <summary>
		/// Gets or sets the ReferralSpecialityName value.
		/// </summary>
		public string ReferralSpecialityName
		{
			get { return referralSpecialityName; }
			set { referralSpecialityName = value; }
		}

		/// <summary>
		/// Gets or sets the ResultID value.
		/// </summary>
		public int ResultID
		{
			get { return resultID; }
			set { resultID = value; }
		}

		/// <summary>
		/// Gets or sets the ResultName value.
		/// </summary>
		public string ResultName
		{
			get { return resultName; }
			set { resultName = value; }
		}

		/// <summary>
		/// Gets or sets the ResultTemplateType value.
		/// </summary>
		public string ResultTemplateType
		{
			get { return resultTemplateType; }
			set { resultTemplateType = value; }
		}


		#endregion
}
}
