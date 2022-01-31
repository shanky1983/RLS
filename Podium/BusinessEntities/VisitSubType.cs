using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class VisitSubType
	{
		#region Fields

		private int visitSubTypeID=0;
		private string description=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the VisitSubTypeID value.
		/// </summary>
		public int VisitSubTypeID
		{
			get { return visitSubTypeID; }
			set { visitSubTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the Description value.
		/// </summary>
		public string Description
		{
			get { return description; }
			set { description = value; }
		}


		#endregion
}
}
