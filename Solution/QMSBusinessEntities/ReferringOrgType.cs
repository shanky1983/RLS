using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ReferringOrgType
	{
		#region Fields

		private int iD=0;
		private string tYPE=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}

		/// <summary>
		/// Gets or sets the TYPE value.
		/// </summary>
		public string TYPE
		{
			get { return tYPE; }
			set { tYPE = value; }
		}


		#endregion
}
}
