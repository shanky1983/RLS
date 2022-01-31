using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ClientCodeMapping
	{
		#region Fields

		private int iD=0;
		private string code=String.Empty;
		private long clientID=0;
		private int referingPhysicianID=0;
		private long labRefOrgID=0;
		private int orgID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}

		/// <summary>
		/// Gets or sets the Code value.
		/// </summary>
		public string Code
		{
			get { return code; }
			set { code = value; }
		}

		/// <summary>
		/// Gets or sets the ClientID value.
		/// </summary>
		public long ClientID
		{
			get { return clientID; }
			set { clientID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferingPhysicianID value.
		/// </summary>
		public int ReferingPhysicianID
		{
			get { return referingPhysicianID; }
			set { referingPhysicianID = value; }
		}

		/// <summary>
		/// Gets or sets the LabRefOrgID value.
		/// </summary>
		public long LabRefOrgID
		{
			get { return labRefOrgID; }
			set { labRefOrgID = value; }
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
		/// Gets or sets the Value value.
		/// </summary>
		private string _value=String.Empty;
		public string Value
		{
			get { return  _value; }
			set { _value = value; }
		}

		/// <summary>
		/// Gets or sets the ClientName value.
		/// </summary>
		private string _clientName=String.Empty;
		public string ClientName
		{
			get { return  _clientName; }
			set { _clientName = value; }
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
		/// Gets or sets the HospitalName value.
		/// </summary>
		private string _hospitalName=String.Empty;
		public string HospitalName
		{
			get { return  _hospitalName; }
			set { _hospitalName = value; }
		}


		#endregion
}
}
