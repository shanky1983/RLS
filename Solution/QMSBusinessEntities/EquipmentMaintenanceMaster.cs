using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class EquipmentMaintenanceMaster
	{
		#region Fields

		private long reminderTemplateID=0;
		private DateTime startDate=DateTime.MaxValue;
		private DateTime endDate=DateTime.MaxValue;
		private string notes=String.Empty;
		private string frequency=String.Empty;
		private int orgid=0;
		private DateTime preMaintenanceDate=DateTime.MaxValue;
		private DateTime nextMaintenanceDate=DateTime.MaxValue;
		private string amcProvider=String.Empty;
		private long stockReceivedDetailsId=0;
		private long productID=0;
		private string status=String.Empty;
		private string serialNo=String.Empty;
		private DateTime createdat=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ReminderTemplateID value.
		/// </summary>
		public long ReminderTemplateID
		{
			get { return reminderTemplateID; }
			set { reminderTemplateID = value; }
		}

		/// <summary>
		/// Gets or sets the StartDate value.
		/// </summary>
		public DateTime StartDate
		{
			get { return startDate; }
			set { startDate = value; }
		}

		/// <summary>
		/// Gets or sets the EndDate value.
		/// </summary>
		public DateTime EndDate
		{
			get { return endDate; }
			set { endDate = value; }
		}

		/// <summary>
		/// Gets or sets the Notes value.
		/// </summary>
		public string Notes
		{
			get { return notes; }
			set { notes = value; }
		}

		/// <summary>
		/// Gets or sets the Frequency value.
		/// </summary>
		public string Frequency
		{
			get { return frequency; }
			set { frequency = value; }
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
		/// Gets or sets the PreMaintenanceDate value.
		/// </summary>
		public DateTime PreMaintenanceDate
		{
			get { return preMaintenanceDate; }
			set { preMaintenanceDate = value; }
		}

		/// <summary>
		/// Gets or sets the NextMaintenanceDate value.
		/// </summary>
		public DateTime NextMaintenanceDate
		{
			get { return nextMaintenanceDate; }
			set { nextMaintenanceDate = value; }
		}

		/// <summary>
		/// Gets or sets the AmcProvider value.
		/// </summary>
		public string AmcProvider
		{
			get { return amcProvider; }
			set { amcProvider = value; }
		}

		/// <summary>
		/// Gets or sets the StockReceivedDetailsId value.
		/// </summary>
		public long StockReceivedDetailsId
		{
			get { return stockReceivedDetailsId; }
			set { stockReceivedDetailsId = value; }
		}

		/// <summary>
		/// Gets or sets the ProductID value.
		/// </summary>
		public long ProductID
		{
			get { return productID; }
			set { productID = value; }
		}

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the SerialNo value.
		/// </summary>
		public string SerialNo
		{
			get { return serialNo; }
			set { serialNo = value; }
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


		#endregion
}
}
