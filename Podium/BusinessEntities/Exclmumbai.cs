using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Exclmumbai
	{
		#region Fields

		private long id=0;
		private string vid=String.Empty;
		private decimal amount=Decimal.Zero;
		private long visitid=0;
		private long finalbillid=0;
		private long createdby=0;
		private DateTime createdat=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id value.
		/// </summary>
		public long Id
		{
			get { return id; }
			set { id = value; }
		}

		/// <summary>
		/// Gets or sets the Vid value.
		/// </summary>
		public string Vid
		{
			get { return vid; }
			set { vid = value; }
		}

		/// <summary>
		/// Gets or sets the Amount value.
		/// </summary>
		public decimal Amount
		{
			get { return amount; }
			set { amount = value; }
		}

		/// <summary>
		/// Gets or sets the Visitid value.
		/// </summary>
		public long Visitid
		{
			get { return visitid; }
			set { visitid = value; }
		}

		/// <summary>
		/// Gets or sets the Finalbillid value.
		/// </summary>
		public long Finalbillid
		{
			get { return finalbillid; }
			set { finalbillid = value; }
		}

		/// <summary>
		/// Gets or sets the Createdby value.
		/// </summary>
		public long Createdby
		{
			get { return createdby; }
			set { createdby = value; }
		}

		/// <summary>
		/// Gets or sets the Createdat value.
		/// </summary>
		public DateTime Createdat
		{
			get { return createdat; }
			set { createdat = value; }
		}


		#endregion
}
}
