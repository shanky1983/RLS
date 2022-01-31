using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ReferingPhyCategoryMapping
	{
		#region Fields

		private long mapid=0;
		private int referingPhysicianID=0;
		private string category=String.Empty;
		private decimal rate=Decimal.Zero;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Mapid value.
		/// </summary>
		public long Mapid
		{
			get { return mapid; }
			set { mapid = value; }
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
		/// Gets or sets the Category value.
		/// </summary>
		public string Category
		{
			get { return category; }
			set { category = value; }
		}

		/// <summary>
		/// Gets or sets the Rate value.
		/// </summary>
		public decimal Rate
		{
			get { return rate; }
			set { rate = value; }
		}


		#endregion
}
}
