using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Complaint
	{
		#region Fields

		private int complaintId=0;
		private string complaintName=String.Empty;
		private string complaintDesc=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int parentID=0;
		private string hashAttribute=String.Empty;
		private string iCDCode=String.Empty;
		private string iCDDescription=String.Empty;
		private string isUserDefined=String.Empty;
		private int orgID=0;
		private string langCode=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ComplaintId value.
		/// </summary>
		public int ComplaintId
		{
			get { return complaintId; }
			set { complaintId = value; }
		}

		/// <summary>
		/// Gets or sets the ComplaintName value.
		/// </summary>
		public string ComplaintName
		{
			get { return complaintName; }
			set { complaintName = value; }
		}

		/// <summary>
		/// Gets or sets the ComplaintDesc value.
		/// </summary>
		public string ComplaintDesc
		{
			get { return complaintDesc; }
			set { complaintDesc = value; }
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
		/// Gets or sets the ParentID value.
		/// </summary>
		public int ParentID
		{
			get { return parentID; }
			set { parentID = value; }
		}

		/// <summary>
		/// Gets or sets the HashAttribute value.
		/// </summary>
		public string HashAttribute
		{
			get { return hashAttribute; }
			set { hashAttribute = value; }
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
		/// Gets or sets the LangCode value.
		/// </summary>
		public string LangCode
		{
			get { return langCode; }
			set { langCode = value; }
		}

		/// <summary>
		/// Gets or sets the PatientVisitID value.
		/// </summary>
		private long _patientVisitID=0;
		public long PatientVisitID
		{
			get { return  _patientVisitID; }
			set { _patientVisitID = value; }
		}


		#endregion
}
}
