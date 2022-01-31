using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class BulckRateDiffMaster
	{
		#region Fields

		private long bulckID=0;
		private long clientID=0;
		private long newRateID=0;
		private int orgID=0;
		private DateTime createdat=DateTime.MaxValue;
		private DateTime billFromDate=DateTime.MaxValue;
		private DateTime billToDate=DateTime.MaxValue;
		private string billStatus=String.Empty;
		private string remarks=String.Empty;
		private string reason=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the BulckID value.
		/// </summary>
		public long BulckID
		{
			get { return bulckID; }
			set { bulckID = value; }
		}

		/// <summary>
		/// Gets or sets the ClientID value.
		/// </summary>
		public long ClientID
		{
			get { return clientID; }
			set { clientID = value; }
		}

		/// <summary>
		/// Gets or sets the NewRateID value.
		/// </summary>
		public long NewRateID
		{
			get { return newRateID; }
			set { newRateID = value; }
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
		/// Gets or sets the Createdat value.
		/// </summary>
		public DateTime Createdat
		{
			get { return createdat; }
			set { createdat = value; }
		}

		/// <summary>
		/// Gets or sets the BillFromDate value.
		/// </summary>
		public DateTime BillFromDate
		{
			get { return billFromDate; }
			set { billFromDate = value; }
		}

		/// <summary>
		/// Gets or sets the BillToDate value.
		/// </summary>
		public DateTime BillToDate
		{
			get { return billToDate; }
			set { billToDate = value; }
		}

		/// <summary>
		/// Gets or sets the BillStatus value.
		/// </summary>
		public string BillStatus
		{
			get { return billStatus; }
			set { billStatus = value; }
		}

		/// <summary>
		/// Gets or sets the Remarks value.
		/// </summary>
		public string Remarks
		{
			get { return remarks; }
			set { remarks = value; }
		}

		/// <summary>
		/// Gets or sets the Reason value.
		/// </summary>
		public string Reason
		{
			get { return reason; }
			set { reason = value; }
		}


		#endregion
}
}
