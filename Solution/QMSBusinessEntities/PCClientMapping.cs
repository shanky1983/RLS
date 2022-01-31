using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
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
		string _physicianname;
		public string PhysicianName
		{
			get { return _physicianname; }
			set { _physicianname = value; }
		}

		/// <summary>
		/// Gets or sets the RefOrgName value.
		/// </summary>
		string _reforgname;
		public string RefOrgName
		{
			get { return _reforgname; }
			set { _reforgname = value; }
		}

		/// <summary>
		/// Gets or sets the PayerName value.
		/// </summary>
		string _payername;
		public string PayerName
		{
			get { return _payername; }
			set { _payername = value; }
		}

		/// <summary>
		/// Gets or sets the RateName value.
		/// </summary>
		string _ratename;
		public string RateName
		{
			get { return _ratename; }
			set { _ratename = value; }
		}


		#endregion
}
}
