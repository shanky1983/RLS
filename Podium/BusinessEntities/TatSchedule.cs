using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class TatSchedule
	{
		#region Fields

		private int scheduleid=0;
		private string schedulecode=String.Empty;
		private string schedulename=String.Empty;
		private string reportedon=String.Empty;
		private short processinghours=0;
		private short processingmins=0;
		private TimeSpan earlyreporttime=TimeSpan.MinValue;
		private byte tatprocesstype=0x00;
		private string scheduleday=String.Empty;
		private byte tatmode=0x00;
		private byte tatcalculationbase=0x00;
		private int orgid=0;
		private long createdby=0;
		private DateTime createdat=DateTime.MaxValue;
		private long modifiedby=0;
		private DateTime modifiedat=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Scheduleid value.
		/// </summary>
		public int Scheduleid
		{
			get { return scheduleid; }
			set { scheduleid = value; }
		}

		/// <summary>
		/// Gets or sets the Schedulecode value.
		/// </summary>
		public string Schedulecode
		{
			get { return schedulecode; }
			set { schedulecode = value; }
		}

		/// <summary>
		/// Gets or sets the Schedulename value.
		/// </summary>
		public string Schedulename
		{
			get { return schedulename; }
			set { schedulename = value; }
		}

		/// <summary>
		/// Gets or sets the Reportedon value.
		/// </summary>
		public string Reportedon
		{
			get { return reportedon; }
			set { reportedon = value; }
		}

		/// <summary>
		/// Gets or sets the Processinghours value.
		/// </summary>
		public short Processinghours
		{
			get { return processinghours; }
			set { processinghours = value; }
		}

		/// <summary>
		/// Gets or sets the Processingmins value.
		/// </summary>
		public short Processingmins
		{
			get { return processingmins; }
			set { processingmins = value; }
		}

		/// <summary>
		/// Gets or sets the Earlyreporttime value.
		/// </summary>
		public TimeSpan Earlyreporttime
		{
			get { return earlyreporttime; }
			set { earlyreporttime = value; }
		}

		/// <summary>
		/// Gets or sets the Tatprocesstype value.
		/// </summary>
		public byte Tatprocesstype
		{
			get { return tatprocesstype; }
			set { tatprocesstype = value; }
		}

		/// <summary>
		/// Gets or sets the Scheduleday value.
		/// </summary>
		public string Scheduleday
		{
			get { return scheduleday; }
			set { scheduleday = value; }
		}

		/// <summary>
		/// Gets or sets the Tatmode value.
		/// </summary>
		public byte Tatmode
		{
			get { return tatmode; }
			set { tatmode = value; }
		}

		/// <summary>
		/// Gets or sets the Tatcalculationbase value.
		/// </summary>
		public byte Tatcalculationbase
		{
			get { return tatcalculationbase; }
			set { tatcalculationbase = value; }
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
		/// Gets or sets the Randombatchid value.
		/// </summary>
		private int _randombatchid=0;
		public int Randombatchid
		{
			get { return  _randombatchid; }
			set { _randombatchid = value; }
		}

		/// <summary>
		/// Gets or sets the Batchstarttime value.
		/// </summary>
		private string _batchstarttime=String.Empty;
		public string Batchstarttime
		{
			get { return  _batchstarttime; }
			set { _batchstarttime = value; }
		}

		/// <summary>
		/// Gets or sets the Cutofftime value.
		/// </summary>
		private string _cutofftime=String.Empty;
		public string Cutofftime
		{
			get { return  _cutofftime; }
			set { _cutofftime = value; }
		}

		/// <summary>
		/// Gets or sets the Flag value.
		/// </summary>
		private string _flag=String.Empty;
		public string Flag
		{
			get { return  _flag; }
			set { _flag = value; }
		}


		#endregion
}
}
