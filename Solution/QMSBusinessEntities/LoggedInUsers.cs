using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class LoggedInUsers
	{
		#region Fields

		private long loginID=0;
		private string isLogged=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;
		private string sessionID=String.Empty;
		private int roleID=0;
		private int deptID=0;
		private long iD=0;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private int inventoryLocationID=0;
		private string isAccessChanged=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the LoginID value.
		/// </summary>
		public long LoginID
		{
			get { return loginID; }
			set { loginID = value; }
		}

		/// <summary>
		/// Gets or sets the IsLogged value.
		/// </summary>
		public string IsLogged
		{
			get { return isLogged; }
			set { isLogged = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedAt value.
		/// </summary>
		public DateTime CreatedAt
		{
			get { return createdAt; }
			set { createdAt = value; }
		}

		/// <summary>
		/// Gets or sets the SessionID value.
		/// </summary>
		public string SessionID
		{
			get { return sessionID; }
			set { sessionID = value; }
		}

		/// <summary>
		/// Gets or sets the RoleID value.
		/// </summary>
		public int RoleID
		{
			get { return roleID; }
			set { roleID = value; }
		}

		/// <summary>
		/// Gets or sets the DeptID value.
		/// </summary>
		public int DeptID
		{
			get { return deptID; }
			set { deptID = value; }
		}

		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public long ID
		{
			get { return iD; }
			set { iD = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public long CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public long ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}

		/// <summary>
		/// Gets or sets the InventoryLocationID value.
		/// </summary>
		public int InventoryLocationID
		{
			get { return inventoryLocationID; }
			set { inventoryLocationID = value; }
		}

		/// <summary>
		/// Gets or sets the IsAccessChanged value.
		/// </summary>
		public string IsAccessChanged
		{
			get { return isAccessChanged; }
			set { isAccessChanged = value; }
		}


		#endregion
}
}
