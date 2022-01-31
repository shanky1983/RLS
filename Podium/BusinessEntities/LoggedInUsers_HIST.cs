using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class LoggedInUsers_HIST
	{
		#region Fields

		private long hISTID=0;
		private long loginID=0;
		private string isLogged=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;
		private string sessionID=String.Empty;
		private int roleID=0;
		private int deptID=0;
		private long iD=0;
		private int inventoryLocationID=0;
		private DateTime logOutTime=DateTime.MaxValue;
		private string loginType=String.Empty;
		private string logOutType=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the HISTID value.
		/// </summary>
		public long HISTID
		{
			get { return hISTID; }
			set { hISTID = value; }
		}

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
		/// Gets or sets the InventoryLocationID value.
		/// </summary>
		public int InventoryLocationID
		{
			get { return inventoryLocationID; }
			set { inventoryLocationID = value; }
		}

		/// <summary>
		/// Gets or sets the LogOutTime value.
		/// </summary>
		public DateTime LogOutTime
		{
			get { return logOutTime; }
			set { logOutTime = value; }
		}

		/// <summary>
		/// Gets or sets the LoginType value.
		/// </summary>
		public string LoginType
		{
			get { return loginType; }
			set { loginType = value; }
		}

		/// <summary>
		/// Gets or sets the LogOutType value.
		/// </summary>
		public string LogOutType
		{
			get { return logOutType; }
			set { logOutType = value; }
		}


		#endregion
}
}
