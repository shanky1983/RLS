using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PCClientMapping
	{
		#region Fields

		private int refPhyID=0;
		private long refOrgID=0;
		private int payerID=0;
		private int clientID=0;
		private int orgID=0;
		private int rateID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the RefPhyID value.
		/// </summary>
		public int RefPhyID
		{
			get { return refPhyID; }
			set { refPhyID = value; }
		}

		/// <summary>
		/// Gets or sets the RefOrgID value.
		/// </summary>
		public long RefOrgID
		{
			get { return refOrgID; }
			set { refOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the PayerID value.
		/// </summary>
		public int PayerID
		{
			get { return payerID; }
			set { payerID = value; }
		}

		/// <summary>
		/// Gets or sets the ClientID value.
		/// </summary>
		public int ClientID
		{
			get { return clientID; }
			set { clientID = value; }
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
		/// Gets or sets the RateID value.
		/// </summary>
		public int RateID
		{
			get { return rateID; }
			set { rateID = value; }
		}

		/// <summary>
		/// Gets or sets the PhysicianName value.
		/// </summary>
		private string _physicianName=String.Empty;
		public string PhysicianName
		{
			get { return  _physicianName; }
			set { _physicianName = value; }
		}

		/// <summary>
		/// Gets or sets the RefOrgName value.
		/// </summary>
		private string _refOrgName=String.Empty;
		public string RefOrgName
		{
			get { return  _refOrgName; }
			set { _refOrgName = value; }
		}

		/// <summary>
		/// Gets or sets the PayerName value.
		/// </summary>
		private string _payerName=String.Empty;
		public string PayerName
		{
			get { return  _payerName; }
			set { _payerName = value; }
		}

		/// <summary>
		/// Gets or sets the RateName value.
		/// </summary>
		private string _rateName=String.Empty;
		public string RateName
		{
			get { return  _rateName; }
			set { _rateName = value; }
		}


		#endregion
}
}
