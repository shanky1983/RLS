using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class EODClient
	{
		#region Fields

		private string clientName=String.Empty;
		private string sampleCount=String.Empty;
		private string grossAmount=String.Empty;
		private string netAmount=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ClientName value.
		/// </summary>
		public string ClientName
		{
			get { return clientName; }
			set { clientName = value; }
		}

		/// <summary>
		/// Gets or sets the SampleCount value.
		/// </summary>
		public string SampleCount
		{
			get { return sampleCount; }
			set { sampleCount = value; }
		}

		/// <summary>
		/// Gets or sets the GrossAmount value.
		/// </summary>
		public string GrossAmount
		{
			get { return grossAmount; }
			set { grossAmount = value; }
		}

		/// <summary>
		/// Gets or sets the NetAmount value.
		/// </summary>
		public string NetAmount
		{
			get { return netAmount; }
			set { netAmount = value; }
		}


		#endregion
}
}
