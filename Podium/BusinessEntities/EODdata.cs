using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class EODdata
	{
		#region Fields

		private string col=String.Empty;
		private string col2=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Col value.
		/// </summary>
		public string Col
		{
			get { return col; }
			set { col = value; }
		}

		/// <summary>
		/// Gets or sets the Col2 value.
		/// </summary>
		public string Col2
		{
			get { return col2; }
			set { col2 = value; }
		}


		#endregion
}
}
