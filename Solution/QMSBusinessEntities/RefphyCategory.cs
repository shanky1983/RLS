using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class RefphyCategory
	{
		#region Fields

		private int refPhyid=0;
		private byte categoryid=0x00;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the RefPhyid value.
		/// </summary>
		public int RefPhyid
		{
			get { return refPhyid; }
			set { refPhyid = value; }
		}

		/// <summary>
		/// Gets or sets the Categoryid value.
		/// </summary>
		public byte Categoryid
		{
			get { return categoryid; }
			set { categoryid = value; }
		}


		#endregion
}
}
