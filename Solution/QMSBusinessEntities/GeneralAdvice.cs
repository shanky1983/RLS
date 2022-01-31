using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class GeneralAdvice
	{
		#region Fields

		private long generalAdviceID=0;
		private string adviceType=String.Empty;
		private string adviceName=String.Empty;
		private int orgID=0;
		private int seqNo=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the GeneralAdviceID value.
		/// </summary>
		public long GeneralAdviceID
		{
			get { return generalAdviceID; }
			set { generalAdviceID = value; }
		}

		/// <summary>
		/// Gets or sets the AdviceType value.
		/// </summary>
		public string AdviceType
		{
			get { return adviceType; }
			set { adviceType = value; }
		}

		/// <summary>
		/// Gets or sets the AdviceName value.
		/// </summary>
		public string AdviceName
		{
			get { return adviceName; }
			set { adviceName = value; }
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
		/// Gets or sets the SeqNo value.
		/// </summary>
		public int SeqNo
		{
			get { return seqNo; }
			set { seqNo = value; }
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
