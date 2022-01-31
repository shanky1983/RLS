using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class TblUserMasterDuplication
	{
		#region Fields

		private int id=0;
		private string loginname=String.Empty;
		private string username=String.Empty;
		private int orgid=0;
		private DateTime createdat=DateTime.MaxValue;
		private int createdby=0;

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
		/// Gets or sets the Loginname value.
		/// </summary>
		public string Loginname
		{
			get { return loginname; }
			set { loginname = value; }
		}

		/// <summary>
		/// Gets or sets the Username value.
		/// </summary>
		public string Username
		{
			get { return username; }
			set { username = value; }
		}

		/// <summary>
		/// Gets or sets the Orgid value.
		/// </summary>
		public int Orgid
		{
			get { return orgid; }
			set { orgid = value; }
		}

		/// <summary>
		/// Gets or sets the Createdat value.
		/// </summary>
		public DateTime Createdat
		{
			get { return createdat; }
			set { createdat = value; }
		}

		/// <summary>
		/// Gets or sets the Createdby value.
		/// </summary>
		public int Createdby
		{
			get { return createdby; }
			set { createdby = value; }
		}


		#endregion
}
}
