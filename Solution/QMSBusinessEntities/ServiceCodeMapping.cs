using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ServiceCodeMapping
	{
		#region Fields

		private long serviceCodeId=0;
		private string serviceCode=String.Empty;
		private long rateID=0;
		private long serviceID=0;
		private string serviceType=String.Empty;
		private string displayText=String.Empty;
		private long rateRefID=0;
		private long clientID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ServiceCodeId value.
		/// </summary>
		public long ServiceCodeId
		{
			get { return serviceCodeId; }
			set { serviceCodeId = value; }
		}

		/// <summary>
		/// Gets or sets the ServiceCode value.
		/// </summary>
		public string ServiceCode
		{
			get { return serviceCode; }
			set { serviceCode = value; }
		}

		/// <summary>
		/// Gets or sets the RateID value.
		/// </summary>
		public long RateID
		{
			get { return rateID; }
			set { rateID = value; }
		}

		/// <summary>
		/// Gets or sets the ServiceID value.
		/// </summary>
		public long ServiceID
		{
			get { return serviceID; }
			set { serviceID = value; }
		}

		/// <summary>
		/// Gets or sets the ServiceType value.
		/// </summary>
		public string ServiceType
		{
			get { return serviceType; }
			set { serviceType = value; }
		}

		/// <summary>
		/// Gets or sets the DisplayText value.
		/// </summary>
		public string DisplayText
		{
			get { return displayText; }
			set { displayText = value; }
		}

		/// <summary>
		/// Gets or sets the RateRefID value.
		/// </summary>
		public long RateRefID
		{
			get { return rateRefID; }
			set { rateRefID = value; }
		}

		/// <summary>
		/// Gets or sets the ClientID value.
		/// </summary>
		public long ClientID
		{
			get { return clientID; }
			set { clientID = value; }
		}


		#endregion
}
}
