using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ContainerExel
	{
		#region Fields

		private string tCODE=String.Empty;
		private string container=String.Empty;
		private string iD=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the TCODE value.
		/// </summary>
		public string TCODE
		{
			get { return tCODE; }
			set { tCODE = value; }
		}

		/// <summary>
		/// Gets or sets the Container value.
		/// </summary>
		public string Container
		{
			get { return container; }
			set { container = value; }
		}

		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public string ID
		{
			get { return iD; }
			set { iD = value; }
		}


		#endregion
}
}
