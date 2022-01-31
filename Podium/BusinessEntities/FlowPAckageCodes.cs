using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class FlowPAckageCodes
	{
		#region Fields

		private string testcode=String.Empty;
		private string abbrevation=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Testcode value.
		/// </summary>
		public string Testcode
		{
			get { return testcode; }
			set { testcode = value; }
		}

		/// <summary>
		/// Gets or sets the Abbrevation value.
		/// </summary>
		public string Abbrevation
		{
			get { return abbrevation; }
			set { abbrevation = value; }
		}


		#endregion
}
}
