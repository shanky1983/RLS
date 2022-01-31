using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
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
		string _isdefault;
		public string IsDefault
		{
			get { return _isdefault; }
			set { _isdefault = value; }
		}


		#endregion
}
}
