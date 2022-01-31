using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ICDCodes
	{
		#region Fields

		private int iCDCodeID=0;
		private string iCDCode=String.Empty;
		private int iCDCategory=0;
		private string iCDDescription=String.Empty;
		private string isUserDefined=String.Empty;
		private int orgID=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ICDCodeID value.
		/// </summary>
		public int ICDCodeID
		{
			get { return iCDCodeID; }
			set { iCDCodeID = value; }
		}

		/// <summary>
		/// Gets or sets the ICDCode value.
		/// </summary>
		public string ICDCode
		{
			get { return iCDCode; }
			set { iCDCode = value; }
		}

		/// <summary>
		/// Gets or sets the ICDCategory value.
		/// </summary>
		public int ICDCategory
		{
			get { return iCDCategory; }
			set { iCDCategory = value; }
		}

		/// <summary>
		/// Gets or sets the ICDDescription value.
		/// </summary>
		public string ICDDescription
		{
			get { return iCDDescription; }
			set { iCDDescription = value; }
		}

		/// <summary>
		/// Gets or sets the IsUserDefined value.
		/// </summary>
		public string IsUserDefined
		{
			get { return isUserDefined; }
			set { isUserDefined = value; }
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
		/// Gets or sets the CreatedAt value.
		/// </summary>
		public DateTime CreatedAt
		{
			get { return createdAt; }
			set { createdAt = value; }
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
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public long ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}

		/// <summary>
		/// Gets or sets the ComplaintName value.
		/// </summary>
		private string _complaintName=String.Empty;
		public string ComplaintName
		{
			get { return  _complaintName; }
			set { _complaintName = value; }
		}

		/// <summary>
		/// Gets or sets the ComplaintId value.
		/// </summary>
		private int _complaintId=0;
		public int ComplaintId
		{
			get { return  _complaintId; }
			set { _complaintId = value; }
		}


		#endregion
}
}
