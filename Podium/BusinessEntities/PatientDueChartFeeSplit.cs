using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PatientDueChartFeeSplit
	{
		#region Fields

		private long patientDueChartFeeSplitID=0;
		private long detailsID=0;
		private long finalBillID=0;
		private long feeId=0;
		private string feeType=String.Empty;
		private string feeDescription=String.Empty;
		private decimal amount=Decimal.Zero;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PatientDueChartFeeSplitID value.
		/// </summary>
		public long PatientDueChartFeeSplitID
		{
			get { return patientDueChartFeeSplitID; }
			set { patientDueChartFeeSplitID = value; }
		}

		/// <summary>
		/// Gets or sets the DetailsID value.
		/// </summary>
		public long DetailsID
		{
			get { return detailsID; }
			set { detailsID = value; }
		}

		/// <summary>
		/// Gets or sets the FinalBillID value.
		/// </summary>
		public long FinalBillID
		{
			get { return finalBillID; }
			set { finalBillID = value; }
		}

		/// <summary>
		/// Gets or sets the FeeId value.
		/// </summary>
		public long FeeId
		{
			get { return feeId; }
			set { feeId = value; }
		}

		/// <summary>
		/// Gets or sets the FeeType value.
		/// </summary>
		public string FeeType
		{
			get { return feeType; }
			set { feeType = value; }
		}

		/// <summary>
		/// Gets or sets the FeeDescription value.
		/// </summary>
		public string FeeDescription
		{
			get { return feeDescription; }
			set { feeDescription = value; }
		}

		/// <summary>
		/// Gets or sets the Amount value.
		/// </summary>
		public decimal Amount
		{
			get { return amount; }
			set { amount = value; }
		}


		#endregion
}
}
