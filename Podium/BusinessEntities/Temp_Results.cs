using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Temp_Results
	{
		#region Fields

		private string orgname=String.Empty;
		private string location=String.Empty;
		private string hQ=String.Empty;
		private string zonename=String.Empty;
		private string zonecode=String.Empty;
		private string sapCode=String.Empty;
		private string clientType=String.Empty;
		private string clientCode=String.Empty;
		private string clientName=String.Empty;
		private decimal grossValue=Decimal.Zero;
		private decimal collectionCharges=Decimal.Zero;
		private decimal billdiscount=Decimal.Zero;
		private decimal netvalue=Decimal.Zero;
		private decimal tOD=Decimal.Zero;
		private decimal finalnet=Decimal.Zero;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Orgname value.
		/// </summary>
		public string Orgname
		{
			get { return orgname; }
			set { orgname = value; }
		}

		/// <summary>
		/// Gets or sets the Location value.
		/// </summary>
		public string Location
		{
			get { return location; }
			set { location = value; }
		}

		/// <summary>
		/// Gets or sets the HQ value.
		/// </summary>
		public string HQ
		{
			get { return hQ; }
			set { hQ = value; }
		}

		/// <summary>
		/// Gets or sets the Zonename value.
		/// </summary>
		public string Zonename
		{
			get { return zonename; }
			set { zonename = value; }
		}

		/// <summary>
		/// Gets or sets the Zonecode value.
		/// </summary>
		public string Zonecode
		{
			get { return zonecode; }
			set { zonecode = value; }
		}

		/// <summary>
		/// Gets or sets the SapCode value.
		/// </summary>
		public string SapCode
		{
			get { return sapCode; }
			set { sapCode = value; }
		}

		/// <summary>
		/// Gets or sets the ClientType value.
		/// </summary>
		public string ClientType
		{
			get { return clientType; }
			set { clientType = value; }
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
		/// Gets or sets the GrossValue value.
		/// </summary>
		public decimal GrossValue
		{
			get { return grossValue; }
			set { grossValue = value; }
		}

		/// <summary>
		/// Gets or sets the CollectionCharges value.
		/// </summary>
		public decimal CollectionCharges
		{
			get { return collectionCharges; }
			set { collectionCharges = value; }
		}

		/// <summary>
		/// Gets or sets the Billdiscount value.
		/// </summary>
		public decimal Billdiscount
		{
			get { return billdiscount; }
			set { billdiscount = value; }
		}

		/// <summary>
		/// Gets or sets the Netvalue value.
		/// </summary>
		public decimal Netvalue
		{
			get { return netvalue; }
			set { netvalue = value; }
		}

		/// <summary>
		/// Gets or sets the TOD value.
		/// </summary>
		public decimal TOD
		{
			get { return tOD; }
			set { tOD = value; }
		}

		/// <summary>
		/// Gets or sets the Finalnet value.
		/// </summary>
		public decimal Finalnet
		{
			get { return finalnet; }
			set { finalnet = value; }
		}


		#endregion
}
}
