using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Tatrandombatchschedule
	{
		#region Fields

		private int randombatchid=0;
		private int scheduleid=0;
		private TimeSpan batchstarttime=TimeSpan.MinValue;
		private TimeSpan cutofftime=TimeSpan.MinValue;
		private int orgid=0;
		private long createdby=0;
		private DateTime createdat=DateTime.MaxValue;
		private long modifiedby=0;
		private DateTime modifiedat=DateTime.MaxValue;
		private DateTime mSRNUM=DateTime.Now;
		private short cutoffintervalvalue=0;
		private string cutoffintervaltype=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Randombatchid value.
		/// </summary>
		public int Randombatchid
		{
			get { return randombatchid; }
			set { randombatchid = value; }
		}

		/// <summary>
		/// Gets or sets the Scheduleid value.
		/// </summary>
		public int Scheduleid
		{
			get { return scheduleid; }
			set { scheduleid = value; }
		}

		/// <summary>
		/// Gets or sets the Batchstarttime value.
		/// </summary>
		public TimeSpan Batchstarttime
		{
			get { return batchstarttime; }
			set { batchstarttime = value; }
		}

		/// <summary>
		/// Gets or sets the Cutofftime value.
		/// </summary>
		public TimeSpan Cutofftime
		{
			get { return cutofftime; }
			set { cutofftime = value; }
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
		/// Gets or sets the MSRNUM value.
		/// </summary>
		public DateTime MSRNUM
		{
			get { return mSRNUM; }
			set { mSRNUM = value; }
		}

		/// <summary>
		/// Gets or sets the Cutoffintervalvalue value.
		/// </summary>
		public short Cutoffintervalvalue
		{
			get { return cutoffintervalvalue; }
			set { cutoffintervalvalue = value; }
		}

		/// <summary>
		/// Gets or sets the Cutoffintervaltype value.
		/// </summary>
		public string Cutoffintervaltype
		{
			get { return cutoffintervaltype; }
			set { cutoffintervaltype = value; }
		}


		#endregion
}
}
