using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class RisUrlMapping
	{
		#region Fields

		private long risID=0;
		private long accessionNumber=0;
		private long orgID=0;
		private string studyInstanceID=String.Empty;
		private string reportURL=String.Empty;
		private string risStatus=String.Empty;
		private string eMessage=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the RisID value.
		/// </summary>
		public long RisID
		{
			get { return risID; }
			set { risID = value; }
		}

		/// <summary>
		/// Gets or sets the AccessionNumber value.
		/// </summary>
		public long AccessionNumber
		{
			get { return accessionNumber; }
			set { accessionNumber = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public long OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the StudyInstanceID value.
		/// </summary>
		public string StudyInstanceID
		{
			get { return studyInstanceID; }
			set { studyInstanceID = value; }
		}

		/// <summary>
		/// Gets or sets the ReportURL value.
		/// </summary>
		public string ReportURL
		{
			get { return reportURL; }
			set { reportURL = value; }
		}

		/// <summary>
		/// Gets or sets the RisStatus value.
		/// </summary>
		public string RisStatus
		{
			get { return risStatus; }
			set { risStatus = value; }
		}

		/// <summary>
		/// Gets or sets the EMessage value.
		/// </summary>
		public string EMessage
		{
			get { return eMessage; }
			set { eMessage = value; }
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
