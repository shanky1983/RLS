using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class CertificateInfo
	{
		#region Fields

		private long certificateInfoID=0;
		private long memberDetailsID=0;
		private int certificateTypeID=0;
		private string valu=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime certificateDate=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the CertificateInfoID value.
		/// </summary>
		public long CertificateInfoID
		{
			get { return certificateInfoID; }
			set { certificateInfoID = value; }
		}

		/// <summary>
		/// Gets or sets the MemberDetailsID value.
		/// </summary>
		public long MemberDetailsID
		{
			get { return memberDetailsID; }
			set { memberDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the CertificateTypeID value.
		/// </summary>
		public int CertificateTypeID
		{
			get { return certificateTypeID; }
			set { certificateTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the Valu value.
		/// </summary>
		public string Value
		{
			get { return valu; }
			set { valu = value; }
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
		/// Gets or sets the CertificateDate value.
		/// </summary>
		public DateTime CertificateDate
		{
			get { return certificateDate; }
			set { certificateDate = value; }
		}


		#endregion
}
}
