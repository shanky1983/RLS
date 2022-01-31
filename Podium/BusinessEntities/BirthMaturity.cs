using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class BirthMaturity
	{
		#region Fields

		private int birthMaturityID=0;
		private string birthMaturityDesc=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the BirthMaturityID value.
		/// </summary>
		public int BirthMaturityID
		{
			get { return birthMaturityID; }
			set { birthMaturityID = value; }
		}

		/// <summary>
		/// Gets or sets the BirthMaturityDesc value.
		/// </summary>
		public string BirthMaturityDesc
		{
			get { return birthMaturityDesc; }
			set { birthMaturityDesc = value; }
		}


		#endregion
}
}
