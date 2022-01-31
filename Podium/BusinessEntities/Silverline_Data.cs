using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Silverline_Data
	{
		#region Fields

		private string name=String.Empty;
		private string visitNumber=String.Empty;
		private DateTime dOB=DateTime.MaxValue;
		private string eMail=String.Empty;
		private string mobileNumber=String.Empty;
		private string age=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;
		private decimal netValue=Decimal.Zero;
		private decimal amount=Decimal.Zero;
		private decimal grossBillValue=Decimal.Zero;
		private decimal discountAmount=Decimal.Zero;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Name value.
		/// </summary>
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		/// <summary>
		/// Gets or sets the VisitNumber value.
		/// </summary>
		public string VisitNumber
		{
			get { return visitNumber; }
			set { visitNumber = value; }
		}

		/// <summary>
		/// Gets or sets the DOB value.
		/// </summary>
		public DateTime DOB
		{
			get { return dOB; }
			set { dOB = value; }
		}

		/// <summary>
		/// Gets or sets the EMail value.
		/// </summary>
		public string EMail
		{
			get { return eMail; }
			set { eMail = value; }
		}

		/// <summary>
		/// Gets or sets the MobileNumber value.
		/// </summary>
		public string MobileNumber
		{
			get { return mobileNumber; }
			set { mobileNumber = value; }
		}

		/// <summary>
		/// Gets or sets the Age value.
		/// </summary>
		public string Age
		{
			get { return age; }
			set { age = value; }
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
		/// Gets or sets the NetValue value.
		/// </summary>
		public decimal NetValue
		{
			get { return netValue; }
			set { netValue = value; }
		}

		/// <summary>
		/// Gets or sets the Amount value.
		/// </summary>
		public decimal Amount
		{
			get { return amount; }
			set { amount = value; }
		}

		/// <summary>
		/// Gets or sets the GrossBillValue value.
		/// </summary>
		public decimal GrossBillValue
		{
			get { return grossBillValue; }
			set { grossBillValue = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountAmount value.
		/// </summary>
		public decimal DiscountAmount
		{
			get { return discountAmount; }
			set { discountAmount = value; }
		}


		#endregion
}
}
