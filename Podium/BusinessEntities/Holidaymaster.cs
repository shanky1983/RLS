using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Holidaymaster
	{
		#region Fields

		private int holidayid=0;
		private string holidayname=String.Empty;
		private int orgid=0;
		private long createdby=0;
		private DateTime createdat=DateTime.MaxValue;
		private long modifiedby=0;
		private DateTime modifiedat=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Holidayid value.
		/// </summary>
		public int Holidayid
		{
			get { return holidayid; }
			set { holidayid = value; }
		}

		/// <summary>
		/// Gets or sets the Holidayname value.
		/// </summary>
		public string Holidayname
		{
			get { return holidayname; }
			set { holidayname = value; }
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
		/// Gets or sets the Createdby value.
		/// </summary>
		public long Createdby
		{
			get { return createdby; }
			set { createdby = value; }
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
		/// Gets or sets the Modifiedby value.
		/// </summary>
		public long Modifiedby
		{
			get { return modifiedby; }
			set { modifiedby = value; }
		}

		/// <summary>
		/// Gets or sets the Modifiedat value.
		/// </summary>
		public DateTime Modifiedat
		{
			get { return modifiedat; }
			set { modifiedat = value; }
		}

		/// <summary>
		/// Gets or sets the Scheduleid value.
		/// </summary>
		private int _scheduleid=0;
		public int Scheduleid
		{
			get { return  _scheduleid; }
			set { _scheduleid = value; }
		}


		#endregion
}
}
