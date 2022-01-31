using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ProductMaintenanceRecord
	{
		#region Fields

		private long productMaintenanceID=0;
		private long productID=0;
		private int categoryID=0;
		private int typeID=0;
		private DateTime dateOfMaintenance=DateTime.MaxValue;
		private string probDetails=String.Empty;
		private string correctiveAction=String.Empty;
		private decimal maintenanceCost=Decimal.Zero;
		private string maintenanceType=String.Empty;
		private string status=String.Empty;
		private DateTime actualDateOfMaintenance=DateTime.MaxValue;
		private string servicerDetails=String.Empty;
		private long reminderTemplateID=0;
		private DateTime createdat=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ProductMaintenanceID value.
		/// </summary>
		public long ProductMaintenanceID
		{
			get { return productMaintenanceID; }
			set { productMaintenanceID = value; }
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
		/// Gets or sets the CategoryID value.
		/// </summary>
		public int CategoryID
		{
			get { return categoryID; }
			set { categoryID = value; }
		}

		/// <summary>
		/// Gets or sets the TypeID value.
		/// </summary>
		public int TypeID
		{
			get { return typeID; }
			set { typeID = value; }
		}

		/// <summary>
		/// Gets or sets the DateOfMaintenance value.
		/// </summary>
		public DateTime DateOfMaintenance
		{
			get { return dateOfMaintenance; }
			set { dateOfMaintenance = value; }
		}

		/// <summary>
		/// Gets or sets the ProbDetails value.
		/// </summary>
		public string ProbDetails
		{
			get { return probDetails; }
			set { probDetails = value; }
		}

		/// <summary>
		/// Gets or sets the CorrectiveAction value.
		/// </summary>
		public string CorrectiveAction
		{
			get { return correctiveAction; }
			set { correctiveAction = value; }
		}

		/// <summary>
		/// Gets or sets the MaintenanceCost value.
		/// </summary>
		public decimal MaintenanceCost
		{
			get { return maintenanceCost; }
			set { maintenanceCost = value; }
		}

		/// <summary>
		/// Gets or sets the MaintenanceType value.
		/// </summary>
		public string MaintenanceType
		{
			get { return maintenanceType; }
			set { maintenanceType = value; }
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
		/// Gets or sets the ActualDateOfMaintenance value.
		/// </summary>
		public DateTime ActualDateOfMaintenance
		{
			get { return actualDateOfMaintenance; }
			set { actualDateOfMaintenance = value; }
		}

		/// <summary>
		/// Gets or sets the ServicerDetails value.
		/// </summary>
		public string ServicerDetails
		{
			get { return servicerDetails; }
			set { servicerDetails = value; }
		}

		/// <summary>
		/// Gets or sets the ReminderTemplateID value.
		/// </summary>
		public long ReminderTemplateID
		{
			get { return reminderTemplateID; }
			set { reminderTemplateID = value; }
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
