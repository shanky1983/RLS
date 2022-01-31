using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class DrugGeneric
	{
		#region Fields

		private long genericID=0;
		private string stdDose=String.Empty;
		private string minDose=String.Empty;
		private string optDose=String.Empty;
		private string doseperKg=String.Empty;
		private string genericName=String.Empty;
		private string pregnency=String.Empty;
		private string lactation=String.Empty;
		private long createdBy=0;
		private long modifiedBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the GenericID value.
		/// </summary>
		public long GenericID
		{
			get { return genericID; }
			set { genericID = value; }
		}

		/// <summary>
		/// Gets or sets the StdDose value.
		/// </summary>
		public string StdDose
		{
			get { return stdDose; }
			set { stdDose = value; }
		}

		/// <summary>
		/// Gets or sets the MinDose value.
		/// </summary>
		public string MinDose
		{
			get { return minDose; }
			set { minDose = value; }
		}

		/// <summary>
		/// Gets or sets the OptDose value.
		/// </summary>
		public string OptDose
		{
			get { return optDose; }
			set { optDose = value; }
		}

		/// <summary>
		/// Gets or sets the DoseperKg value.
		/// </summary>
		public string DoseperKg
		{
			get { return doseperKg; }
			set { doseperKg = value; }
		}

		/// <summary>
		/// Gets or sets the GenericName value.
		/// </summary>
		public string GenericName
		{
			get { return genericName; }
			set { genericName = value; }
		}

		/// <summary>
		/// Gets or sets the Pregnency value.
		/// </summary>
		public string Pregnency
		{
			get { return pregnency; }
			set { pregnency = value; }
		}

		/// <summary>
		/// Gets or sets the Lactation value.
		/// </summary>
		public string Lactation
		{
			get { return lactation; }
			set { lactation = value; }
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
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public long ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
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
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
		}


		#endregion
}
}
