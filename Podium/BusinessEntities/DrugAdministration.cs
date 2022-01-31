using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class DrugAdministration
	{
		#region Fields

		private long prescriptionID=0;
		private DateTime administeredAtFrom=DateTime.MaxValue;
		private DateTime administeredAtTo=DateTime.MaxValue;
		private string drugStatus=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PrescriptionID value.
		/// </summary>
		public long PrescriptionID
		{
			get { return prescriptionID; }
			set { prescriptionID = value; }
		}

		/// <summary>
		/// Gets or sets the AdministeredAtFrom value.
		/// </summary>
		public DateTime AdministeredAtFrom
		{
			get { return administeredAtFrom; }
			set { administeredAtFrom = value; }
		}

		/// <summary>
		/// Gets or sets the AdministeredAtTo value.
		/// </summary>
		public DateTime AdministeredAtTo
		{
			get { return administeredAtTo; }
			set { administeredAtTo = value; }
		}

		/// <summary>
		/// Gets or sets the DrugStatus value.
		/// </summary>
		public string DrugStatus
		{
			get { return drugStatus; }
			set { drugStatus = value; }
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


		#endregion
}
}
