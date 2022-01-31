using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class DischargeInvNotes
	{
		#region Fields

		private long dischargeInvNotesID=0;
		private string investigationDetails=String.Empty;
		private string type=String.Empty;
		private long visitID=0;
		private long patientID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DischargeInvNotesID value.
		/// </summary>
		public long DischargeInvNotesID
		{
			get { return dischargeInvNotesID; }
			set { dischargeInvNotesID = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationDetails value.
		/// </summary>
		public string InvestigationDetails
		{
			get { return investigationDetails; }
			set { investigationDetails = value; }
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
		/// Gets or sets the VisitID value.
		/// </summary>
		public long VisitID
		{
			get { return visitID; }
			set { visitID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientID value.
		/// </summary>
		public long PatientID
		{
			get { return patientID; }
			set { patientID = value; }
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
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountAmount value.
		/// </summary>
		private decimal _discountAmount=Decimal.Zero;
		public decimal DiscountAmount
		{
			get { return  _discountAmount; }
			set { _discountAmount = value; }
		}

		/// <summary>
		/// Gets or sets the ActualAmount value.
		/// </summary>
		private decimal _actualAmount=Decimal.Zero;
		public decimal ActualAmount
		{
			get { return  _actualAmount; }
			set { _actualAmount = value; }
		}

		/// <summary>
		/// Gets or sets the SalesAmount value.
		/// </summary>
		private decimal _salesAmount=Decimal.Zero;
		public decimal SalesAmount
		{
			get { return  _salesAmount; }
			set { _salesAmount = value; }
		}

		/// <summary>
		/// Gets or sets the HistoryDetails value.
		/// </summary>
		private string _historyDetails=String.Empty;
		public string HistoryDetails
		{
			get { return  _historyDetails; }
			set { _historyDetails = value; }
		}

		/// <summary>
		/// Gets or sets the TestSequenceOrder value.
		/// </summary>
		private int _testSequenceOrder=0;
		public int TestSequenceOrder
		{
			get { return  _testSequenceOrder; }
			set { _testSequenceOrder = value; }
		}


		#endregion
}
}
