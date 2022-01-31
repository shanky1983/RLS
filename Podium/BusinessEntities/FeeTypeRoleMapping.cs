using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class FeeTypeRoleMapping
	{
		#region Fields

		private long feeTypeRoleID=0;
		private int feeTypeID=0;
		private long roleID=0;
		private string visitType=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the FeeTypeRoleID value.
		/// </summary>
		public long FeeTypeRoleID
		{
			get { return feeTypeRoleID; }
			set { feeTypeRoleID = value; }
		}

		/// <summary>
		/// Gets or sets the FeeTypeID value.
		/// </summary>
		public int FeeTypeID
		{
			get { return feeTypeID; }
			set { feeTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the RoleID value.
		/// </summary>
		public long RoleID
		{
			get { return roleID; }
			set { roleID = value; }
		}

		/// <summary>
		/// Gets or sets the VisitType value.
		/// </summary>
		public string VisitType
		{
			get { return visitType; }
			set { visitType = value; }
		}


		#endregion
}
}
