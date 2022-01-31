using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
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
		private int _visitPurposeID=0;
		public int VisitPurposeID
		{
			get { return  _visitPurposeID; }
			set { _visitPurposeID = value; }
		}


		#endregion
}
}
