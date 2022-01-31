using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class DrugFrequency
	{
		#region Fields

		private string shortName=String.Empty;
		private string displayText=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private decimal drugCalculation=Decimal.Zero;
		private long drugFrequencyID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ShortName value.
		/// </summary>
		public string ShortName
		{
			get { return shortName; }
			set { shortName = value; }
		}

		/// <summary>
		/// Gets or sets the DisplayText value.
		/// </summary>
		public string DisplayText
		{
			get { return displayText; }
			set { displayText = value; }
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
		/// Gets or sets the DrugCalculation value.
		/// </summary>
		public decimal DrugCalculation
		{
			get { return drugCalculation; }
			set { drugCalculation = value; }
		}

		/// <summary>
		/// Gets or sets the DrugFrequencyID value.
		/// </summary>
		public long DrugFrequencyID
		{
			get { return drugFrequencyID; }
			set { drugFrequencyID = value; }
		}


		#endregion
}
}
