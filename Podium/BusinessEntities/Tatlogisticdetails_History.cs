using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Tatlogisticdetails_History
	{
		#region Fields

		private int historyid=0;
		private int logisticdetailsid=0;
		private int fromorgid=0;
		private long fromorgaddressid=0;
		private int toorgid=0;
		private long toorgaddressid=0;
		private short transittimevalue=0;
		private string transittimetype=String.Empty;
		private bool isActive=true;
		private long createdby=0;
		private DateTime createdat=DateTime.MaxValue;
		private long modifiedby=0;
		private DateTime modifiedat=DateTime.MaxValue;
		private DateTime mSRNUM=DateTime.Now;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Historyid value.
		/// </summary>
		public int Historyid
		{
			get { return historyid; }
			set { historyid = value; }
		}

		/// <summary>
		/// Gets or sets the Logisticdetailsid value.
		/// </summary>
		public int Logisticdetailsid
		{
			get { return logisticdetailsid; }
			set { logisticdetailsid = value; }
		}

		/// <summary>
		/// Gets or sets the Fromorgid value.
		/// </summary>
		public int Fromorgid
		{
			get { return fromorgid; }
			set { fromorgid = value; }
		}

		/// <summary>
		/// Gets or sets the Fromorgaddressid value.
		/// </summary>
		public long Fromorgaddressid
		{
			get { return fromorgaddressid; }
			set { fromorgaddressid = value; }
		}

		/// <summary>
		/// Gets or sets the Toorgid value.
		/// </summary>
		public int Toorgid
		{
			get { return toorgid; }
			set { toorgid = value; }
		}

		/// <summary>
		/// Gets or sets the Toorgaddressid value.
		/// </summary>
		public long Toorgaddressid
		{
			get { return toorgaddressid; }
			set { toorgaddressid = value; }
		}

		/// <summary>
		/// Gets or sets the Transittimevalue value.
		/// </summary>
		public short Transittimevalue
		{
			get { return transittimevalue; }
			set { transittimevalue = value; }
		}

		/// <summary>
		/// Gets or sets the Transittimetype value.
		/// </summary>
		public string Transittimetype
		{
			get { return transittimetype; }
			set { transittimetype = value; }
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


		#endregion
}
}
