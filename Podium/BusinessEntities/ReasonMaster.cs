using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ReasonMaster
	{
		#region Fields

		private long reasonID=0;
		private int reasonTypeID=0;
		private string reason=String.Empty;
		private string reasonCode=String.Empty;
		private string status=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int sequenceNo=0;
		private int orgID=0;
		private string langCode=String.Empty;
		private string externalComment=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ReasonID value.
		/// </summary>
		public long ReasonID
		{
			get { return reasonID; }
			set { reasonID = value; }
		}

		/// <summary>
		/// Gets or sets the ReasonTypeID value.
		/// </summary>
		public int ReasonTypeID
		{
			get { return reasonTypeID; }
			set { reasonTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the Reason value.
		/// </summary>
		public string Reason
		{
			get { return reason; }
			set { reason = value; }
		}

		/// <summary>
		/// Gets or sets the ReasonCode value.
		/// </summary>
		public string ReasonCode
		{
			get { return reasonCode; }
			set { reasonCode = value; }
		}

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
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
		/// Gets or sets the SequenceNo value.
		/// </summary>
		public int SequenceNo
		{
			get { return sequenceNo; }
			set { sequenceNo = value; }
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
		/// Gets or sets the LangCode value.
		/// </summary>
		public string LangCode
		{
			get { return langCode; }
			set { langCode = value; }
		}

		/// <summary>
		/// Gets or sets the ExternalComment value.
		/// </summary>
		public string ExternalComment
		{
			get { return externalComment; }
			set { externalComment = value; }
		}

		/// <summary>
		/// Gets or sets the CategoryID value.
		/// </summary>
		private short _categoryID=0;
		public short CategoryID
		{
			get { return  _categoryID; }
			set { _categoryID = value; }
		}


		#endregion
}
}
