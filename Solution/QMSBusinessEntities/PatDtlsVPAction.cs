using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class PatDtlsVPAction
	{
		#region Fields

		private int vPActionID=0;
		private string vPActionName=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the VPActionID value.
		/// </summary>
		public int VPActionID
		{
			get { return vPActionID; }
			set { vPActionID = value; }
		}

		/// <summary>
		/// Gets or sets the VPActionName value.
		/// </summary>
		public string VPActionName
		{
			get { return vPActionName; }
			set { vPActionName = value; }
		}

		/// <summary>
		/// Gets or sets the VisitPurposeID value.
		/// </summary>
		int _visitpurposeid;
		public int VisitPurposeID
		{
			get { return _visitpurposeid; }
			set { _visitpurposeid = value; }
		}


		#endregion
}
}
