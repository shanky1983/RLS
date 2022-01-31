using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class CustomerType
	{
		#region Fields

		private int customerTypeID=0;
		private string customerTypeName=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the CustomerTypeID value.
		/// </summary>
		public int CustomerTypeID
		{
			get { return customerTypeID; }
			set { customerTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the CustomerTypeName value.
		/// </summary>
		public string CustomerTypeName
		{
			get { return customerTypeName; }
			set { customerTypeName = value; }
		}


		#endregion
}
}
