using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Triesta_Rate_master
	{
		#region Fields

		private string tcode=String.Empty;
		private string id=String.Empty;
		private string type=String.Empty;
		private string orgid=String.Empty;
		private float rate=0.0F;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Tcode value.
		/// </summary>
		public string Tcode
		{
			get { return tcode; }
			set { tcode = value; }
		}

		/// <summary>
		/// Gets or sets the Id value.
		/// </summary>
		public string Id
		{
			get { return id; }
			set { id = value; }
		}

		/// <summary>
		/// Gets or sets the Type value.
		/// </summary>
		public string Type
		{
			get { return type; }
			set { type = value; }
		}

		/// <summary>
		/// Gets or sets the Orgid value.
		/// </summary>
		public string Orgid
		{
			get { return orgid; }
			set { orgid = value; }
		}

		/// <summary>
		/// Gets or sets the Rate value.
		/// </summary>
		public float Rate
		{
			get { return rate; }
			set { rate = value; }
		}


		#endregion
}
}
