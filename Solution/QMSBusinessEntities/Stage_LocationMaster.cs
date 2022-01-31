using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Stage_LocationMaster
	{
		#region Fields

		private string orgName=String.Empty;
		private string locationName=String.Empty;
		private string locationCode=String.Empty;
		private string address1=String.Empty;
		private string address2=String.Empty;
		private string city=String.Empty;
		private string state=String.Empty;
		private string country=String.Empty;
		private string postalCode=String.Empty;
		private int transitTime=0;
		private string mobile=String.Empty;
		private string landLine=String.Empty;
		private string locationType=String.Empty;
		private string status=String.Empty;
		private string isMappedClients=String.Empty;
		private string clientCode=String.Empty;
		private string clientName=String.Empty;
		private string isDefault=String.Empty;
		private string flag=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the OrgName value.
		/// </summary>
		public string OrgName
		{
			get { return orgName; }
			set { orgName = value; }
		}

		/// <summary>
		/// Gets or sets the LocationName value.
		/// </summary>
		public string LocationName
		{
			get { return locationName; }
			set { locationName = value; }
		}

		/// <summary>
		/// Gets or sets the LocationCode value.
		/// </summary>
		public string LocationCode
		{
			get { return locationCode; }
			set { locationCode = value; }
		}

		/// <summary>
		/// Gets or sets the Address1 value.
		/// </summary>
		public string Address1
		{
			get { return address1; }
			set { address1 = value; }
		}

		/// <summary>
		/// Gets or sets the Address2 value.
		/// </summary>
		public string Address2
		{
			get { return address2; }
			set { address2 = value; }
		}

		/// <summary>
		/// Gets or sets the City value.
		/// </summary>
		public string City
		{
			get { return city; }
			set { city = value; }
		}

		/// <summary>
		/// Gets or sets the State value.
		/// </summary>
		public string State
		{
			get { return state; }
			set { state = value; }
		}

		/// <summary>
		/// Gets or sets the Country value.
		/// </summary>
		public string Country
		{
			get { return country; }
			set { country = value; }
		}

		/// <summary>
		/// Gets or sets the PostalCode value.
		/// </summary>
		public string PostalCode
		{
			get { return postalCode; }
			set { postalCode = value; }
		}

		/// <summary>
		/// Gets or sets the TransitTime value.
		/// </summary>
		public int TransitTime
		{
			get { return transitTime; }
			set { transitTime = value; }
		}

		/// <summary>
		/// Gets or sets the Mobile value.
		/// </summary>
		public string Mobile
		{
			get { return mobile; }
			set { mobile = value; }
		}

		/// <summary>
		/// Gets or sets the LandLine value.
		/// </summary>
		public string LandLine
		{
			get { return landLine; }
			set { landLine = value; }
		}

		/// <summary>
		/// Gets or sets the LocationType value.
		/// </summary>
		public string LocationType
		{
			get { return locationType; }
			set { locationType = value; }
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
		/// Gets or sets the IsMappedClients value.
		/// </summary>
		public string IsMappedClients
		{
			get { return isMappedClients; }
			set { isMappedClients = value; }
		}

		/// <summary>
		/// Gets or sets the ClientCode value.
		/// </summary>
		public string ClientCode
		{
			get { return clientCode; }
			set { clientCode = value; }
		}

		/// <summary>
		/// Gets or sets the ClientName value.
		/// </summary>
		public string ClientName
		{
			get { return clientName; }
			set { clientName = value; }
		}

		/// <summary>
		/// Gets or sets the IsDefault value.
		/// </summary>
		public string IsDefault
		{
			get { return isDefault; }
			set { isDefault = value; }
		}

		/// <summary>
		/// Gets or sets the Flag value.
		/// </summary>
		public string Flag
		{
			get { return flag; }
			set { flag = value; }
		}


		#endregion
}
}
