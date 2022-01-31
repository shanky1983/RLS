using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class CommTypeMaster
	{
		#region Fields

		private int commTypeID=0;
		private string commType=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the CommTypeID value.
		/// </summary>
		public int CommTypeID
		{
			get { return commTypeID; }
			set { commTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the CommType value.
		/// </summary>
		public string CommType
		{
			get { return commType; }
			set { commType = value; }
		}


		#endregion
}
}
