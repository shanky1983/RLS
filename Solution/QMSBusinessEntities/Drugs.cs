using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Drugs
	{
		#region Fields

		private long drugID=0;
		private string drugCode=String.Empty;
		private string drugName=String.Empty;
		private int drugTypeId=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string dosage=String.Empty;
		private string isApproved=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DrugID value.
		/// </summary>
		public long DrugID
		{
			get { return drugID; }
			set { drugID = value; }
		}

		/// <summary>
		/// Gets or sets the DrugCode value.
		/// </summary>
		public string DrugCode
		{
			get { return drugCode; }
			set { drugCode = value; }
		}

		/// <summary>
		/// Gets or sets the DrugName value.
		/// </summary>
		public string DrugName
		{
			get { return drugName; }
			set { drugName = value; }
		}

		/// <summary>
		/// Gets or sets the DrugTypeId value.
		/// </summary>
		public int DrugTypeId
		{
			get { return drugTypeId; }
			set { drugTypeId = value; }
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
		/// Gets or sets the Dosage value.
		/// </summary>
		public string Dosage
		{
			get { return dosage; }
			set { dosage = value; }
		}

		/// <summary>
		/// Gets or sets the IsApproved value.
		/// </summary>
		public string IsApproved
		{
			get { return isApproved; }
			set { isApproved = value; }
		}


		#endregion
}
}
