using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class SurgeryBillingDetails
	{
		#region Fields

		private long surgeryBillingDetailsID=0;
		private long surgeryBillingID=0;
		private long physicianID=0;
		private string description=String.Empty;
		private string type=String.Empty;
		private decimal valu=Decimal.Zero;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the SurgeryBillingDetailsID value.
		/// </summary>
		public long SurgeryBillingDetailsID
		{
			get { return surgeryBillingDetailsID; }
			set { surgeryBillingDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the SurgeryBillingID value.
		/// </summary>
		public long SurgeryBillingID
		{
			get { return surgeryBillingID; }
			set { surgeryBillingID = value; }
		}

		/// <summary>
		/// Gets or sets the PhysicianID value.
		/// </summary>
		public long PhysicianID
		{
			get { return physicianID; }
			set { physicianID = value; }
		}

		/// <summary>
		/// Gets or sets the Description value.
		/// </summary>
		public string Description
		{
			get { return description; }
			set { description = value; }
		}

		/// <summary>
		/// Gets or sets the Type value.
		/// </summary>
		public string Type
		{
			get { return type; }
			set { type = value; }
		}

		/// <summary>
		/// Gets or sets the Valu value.
		/// </summary>
		public decimal Value
		{
			get { return valu; }
			set { valu = value; }
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
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public long CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
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
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public long ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}

		/// <summary>
		/// Gets or sets the PhysicianName value.
		/// </summary>
		string _physicianname;
		public string PhysicianName
		{
			get { return _physicianname; }
			set { _physicianname = value; }
		}


		#endregion
}
}
