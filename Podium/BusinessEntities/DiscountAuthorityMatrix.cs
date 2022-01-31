using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class DiscountAuthorityMatrix
	{
		#region Fields

		private int id=0;
		private string name=String.Empty;
		private int orgID=0;
		private int aMaxLimit=0;
		private string aType=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id value.
		/// </summary>
		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		/// <summary>
		/// Gets or sets the Name value.
		/// </summary>
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the AMaxLimit value.
		/// </summary>
		public int AMaxLimit
		{
			get { return aMaxLimit; }
			set { aMaxLimit = value; }
		}

		/// <summary>
		/// Gets or sets the AType value.
		/// </summary>
		public string AType
		{
			get { return aType; }
			set { aType = value; }
		}


		#endregion
}
}
