using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ResourceServiceType
	{
		#region Fields

		private int resourceServiceTypeID=0;
		private string resourceServiceTypeName=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ResourceServiceTypeID value.
		/// </summary>
		public int ResourceServiceTypeID
		{
			get { return resourceServiceTypeID; }
			set { resourceServiceTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the ResourceServiceTypeName value.
		/// </summary>
		public string ResourceServiceTypeName
		{
			get { return resourceServiceTypeName; }
			set { resourceServiceTypeName = value; }
		}


		#endregion
}
}
