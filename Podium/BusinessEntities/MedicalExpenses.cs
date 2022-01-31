using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class MedicalExpenses
	{
		#region Fields

		private long medicalExpenseID=0;
		private long familyDetailsID=0;
		private long memberDetailID=0;
		private string expenseType=String.Empty;
		private decimal expense=Decimal.Zero;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long createdBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the MedicalExpenseID value.
		/// </summary>
		public long MedicalExpenseID
		{
			get { return medicalExpenseID; }
			set { medicalExpenseID = value; }
		}

		/// <summary>
		/// Gets or sets the FamilyDetailsID value.
		/// </summary>
		public long FamilyDetailsID
		{
			get { return familyDetailsID; }
			set { familyDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the MemberDetailID value.
		/// </summary>
		public long MemberDetailID
		{
			get { return memberDetailID; }
			set { memberDetailID = value; }
		}

		/// <summary>
		/// Gets or sets the ExpenseType value.
		/// </summary>
		public string ExpenseType
		{
			get { return expenseType; }
			set { expenseType = value; }
		}

		/// <summary>
		/// Gets or sets the Expense value.
		/// </summary>
		public decimal Expense
		{
			get { return expense; }
			set { expense = value; }
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


		#endregion
}
}
