using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ProtocolGroup_Haematology
	{
		#region Fields

		private string test=String.Empty;
		private string tcode=String.Empty;
		private string protocalGroup=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Test value.
		/// </summary>
		public string Test
		{
			get { return test; }
			set { test = value; }
		}

		/// <summary>
		/// Gets or sets the Tcode value.
		/// </summary>
		public string Tcode
		{
			get { return tcode; }
			set { tcode = value; }
		}

		/// <summary>
		/// Gets or sets the ProtocalGroup value.
		/// </summary>
		public string ProtocalGroup
		{
			get { return protocalGroup; }
			set { protocalGroup = value; }
		}


		#endregion
}
}
