using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ReferenceOrg
	{
		#region Fields

		private long refernceOrgID=0;
		private string referrerName=String.Empty;
		private string referenceOrgName=String.Empty;
		private string referenceOrgDescription=String.Empty;
		private string referenceOrgAddress=String.Empty;
		private string refererMail=String.Empty;
		private long referrerMobile=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the RefernceOrgID value.
		/// </summary>
		public long RefernceOrgID
		{
			get { return refernceOrgID; }
			set { refernceOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferrerName value.
		/// </summary>
		public string ReferrerName
		{
			get { return referrerName; }
			set { referrerName = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceOrgName value.
		/// </summary>
		public string ReferenceOrgName
		{
			get { return referenceOrgName; }
			set { referenceOrgName = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceOrgDescription value.
		/// </summary>
		public string ReferenceOrgDescription
		{
			get { return referenceOrgDescription; }
			set { referenceOrgDescription = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceOrgAddress value.
		/// </summary>
		public string ReferenceOrgAddress
		{
			get { return referenceOrgAddress; }
			set { referenceOrgAddress = value; }
		}

		/// <summary>
		/// Gets or sets the RefererMail value.
		/// </summary>
		public string RefererMail
		{
			get { return refererMail; }
			set { refererMail = value; }
		}

		/// <summary>
		/// Gets or sets the ReferrerMobile value.
		/// </summary>
		public long ReferrerMobile
		{
			get { return referrerMobile; }
			set { referrerMobile = value; }
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
