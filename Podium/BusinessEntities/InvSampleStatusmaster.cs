using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InvSampleStatusmaster
	{
		#region Fields

		private long invSampleStatusID=0;
		private string invSampleStatusDesc=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the InvSampleStatusID value.
		/// </summary>
		public long InvSampleStatusID
		{
			get { return invSampleStatusID; }
			set { invSampleStatusID = value; }
		}

		/// <summary>
		/// Gets or sets the InvSampleStatusDesc value.
		/// </summary>
		public string InvSampleStatusDesc
		{
			get { return invSampleStatusDesc; }
			set { invSampleStatusDesc = value; }
		}

		/// <summary>
		/// Gets or sets the IsDefault value.
		/// </summary>
		private string _isDefault=String.Empty;
		public string IsDefault
		{
			get { return  _isDefault; }
			set { _isDefault = value; }
		}

		/// <summary>
		/// Gets or sets the Displaytext value.
		/// </summary>
		private string _displaytext=String.Empty;
		public string Displaytext
		{
			get { return  _displaytext; }
			set { _displaytext = value; }
		}


		#endregion
}
}
