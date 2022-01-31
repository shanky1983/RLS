using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Referrals
	{
		#region Fields

		private long referralID=0;
		private int referedByOrgID=0;
		private long referedByVisitID=0;
		private int referedToOrgID=0;
		private long referedToLocation=0;
		private long referedByLocation=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string referedToOrgName=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ReferralID value.
		/// </summary>
		public long ReferralID
		{
			get { return referralID; }
			set { referralID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferedByOrgID value.
		/// </summary>
		public int ReferedByOrgID
		{
			get { return referedByOrgID; }
			set { referedByOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferedByVisitID value.
		/// </summary>
		public long ReferedByVisitID
		{
			get { return referedByVisitID; }
			set { referedByVisitID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferedToOrgID value.
		/// </summary>
		public int ReferedToOrgID
		{
			get { return referedToOrgID; }
			set { referedToOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferedToLocation value.
		/// </summary>
		public long ReferedToLocation
		{
			get { return referedToLocation; }
			set { referedToLocation = value; }
		}

		/// <summary>
		/// Gets or sets the ReferedByLocation value.
		/// </summary>
		public long ReferedByLocation
		{
			get { return referedByLocation; }
			set { referedByLocation = value; }
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
		/// Gets or sets the ReferedToOrgName value.
		/// </summary>
		public string ReferedToOrgName
		{
			get { return referedToOrgName; }
			set { referedToOrgName = value; }
		}

		/// <summary>
		/// Gets or sets the ReferedToPhysicianID value.
		/// </summary>
		int _referedtophysicianid;
		public int ReferedToPhysicianID
		{
			get { return _referedtophysicianid; }
			set { _referedtophysicianid = value; }
		}

		/// <summary>
		/// Gets or sets the ReferralNotes value.
		/// </summary>
		string _referralnotes;
		public string ReferralNotes
		{
			get { return _referralnotes; }
			set { _referralnotes = value; }
		}

		/// <summary>
		/// Gets or sets the ReferredOrganization value.
		/// </summary>
		string _referredorganization;
		public string ReferredOrganization
		{
			get { return _referredorganization; }
			set { _referredorganization = value; }
		}


		#endregion
}
}
