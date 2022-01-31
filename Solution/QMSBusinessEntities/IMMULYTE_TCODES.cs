using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class IMMULYTE_TCODES
	{
		#region Fields

		private string tcode=String.Empty;
		private string type=String.Empty;
		private string protocolGroup=String.Empty;

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
		/// Gets or sets the Type value.
		/// </summary>
		public string Type
		{
			get { return type; }
			set { type = value; }
		}

		/// <summary>
		/// Gets or sets the ProtocolGroup value.
		/// </summary>
		public string ProtocolGroup
		{
			get { return protocolGroup; }
			set { protocolGroup = value; }
		}


		#endregion
}
}
