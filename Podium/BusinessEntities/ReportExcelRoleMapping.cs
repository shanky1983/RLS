using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ReportExcelRoleMapping
	{
		#region Fields

		private int mapid=0;
		private int reportid=0;
		private int roleid=0;
		private bool isActive=true;
		private DateTime createdat=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Mapid value.
		/// </summary>
		public int Mapid
		{
			get { return mapid; }
			set { mapid = value; }
		}

		/// <summary>
		/// Gets or sets the Reportid value.
		/// </summary>
		public int Reportid
		{
			get { return reportid; }
			set { reportid = value; }
		}

		/// <summary>
		/// Gets or sets the Roleid value.
		/// </summary>
		public int Roleid
		{
			get { return roleid; }
			set { roleid = value; }
		}

		/// <summary>
		/// Gets or sets the IsActive value.
		/// </summary>
		public bool IsActive
		{
			get { return isActive; }
			set { isActive = value; }
		}

		/// <summary>
		/// Gets or sets the Createdat value.
		/// </summary>
		public DateTime Createdat
		{
			get { return createdat; }
			set { createdat = value; }
		}


		#endregion
}
}
