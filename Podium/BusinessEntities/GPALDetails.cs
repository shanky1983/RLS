using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class GPALDetails
	{
		#region Fields

		private long patientID=0;
		private long patientVisitID=0;
		private string sexOfChild=String.Empty;
		private string age=String.Empty;
		private int modeOfDeliveryID=0;
		private int birthMaturityID=0;
		private decimal birthWeight=Decimal.Zero;
		private string isGrowthNormal=String.Empty;
		private int growthRate=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PatientID value.
		/// </summary>
		public long PatientID
		{
			get { return patientID; }
			set { patientID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientVisitID value.
		/// </summary>
		public long PatientVisitID
		{
			get { return patientVisitID; }
			set { patientVisitID = value; }
		}

		/// <summary>
		/// Gets or sets the SexOfChild value.
		/// </summary>
		public string SexOfChild
		{
			get { return sexOfChild; }
			set { sexOfChild = value; }
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
		/// Gets or sets the ModeOfDeliveryID value.
		/// </summary>
		public int ModeOfDeliveryID
		{
			get { return modeOfDeliveryID; }
			set { modeOfDeliveryID = value; }
		}

		/// <summary>
		/// Gets or sets the BirthMaturityID value.
		/// </summary>
		public int BirthMaturityID
		{
			get { return birthMaturityID; }
			set { birthMaturityID = value; }
		}

		/// <summary>
		/// Gets or sets the BirthWeight value.
		/// </summary>
		public decimal BirthWeight
		{
			get { return birthWeight; }
			set { birthWeight = value; }
		}

		/// <summary>
		/// Gets or sets the IsGrowthNormal value.
		/// </summary>
		public string IsGrowthNormal
		{
			get { return isGrowthNormal; }
			set { isGrowthNormal = value; }
		}

		/// <summary>
		/// Gets or sets the GrowthRate value.
		/// </summary>
		public int GrowthRate
		{
			get { return growthRate; }
			set { growthRate = value; }
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
		/// Gets or sets the ModeOfDelivery value.
		/// </summary>
		private string _modeOfDelivery=String.Empty;
		public string ModeOfDelivery
		{
			get { return  _modeOfDelivery; }
			set { _modeOfDelivery = value; }
		}

		/// <summary>
		/// Gets or sets the BirthMaturity value.
		/// </summary>
		private string _birthMaturity=String.Empty;
		public string BirthMaturity
		{
			get { return  _birthMaturity; }
			set { _birthMaturity = value; }
		}

		/// <summary>
		/// Gets or sets the Sex value.
		/// </summary>
		private string _sex=String.Empty;
		public string Sex
		{
			get { return  _sex; }
			set { _sex = value; }
		}

		/// <summary>
		/// Gets or sets the GrowthNormal value.
		/// </summary>
		private string _growthNormal=String.Empty;
		public string GrowthNormal
		{
			get { return  _growthNormal; }
			set { _growthNormal = value; }
		}


		#endregion
}
}
