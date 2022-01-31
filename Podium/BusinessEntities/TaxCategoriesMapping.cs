using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class TaxCategoriesMapping
	{
		#region Fields

		private int taxCategoriesMappingID=0;
		private int categoriesID=0;
		private int taxTypeID=0;
		private int stateID=0;
		private decimal tax=Decimal.Zero;
		private int orgID=0;
		private bool status=true;
		private DateTime createdat=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private int orgAddressID=0;
		private DateTime validFrom=DateTime.MaxValue;
		private DateTime validTo=DateTime.MaxValue;
		private int outputTaxTypeID=0;
		private decimal outputTax=Decimal.Zero;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the TaxCategoriesMappingID value.
		/// </summary>
		public int TaxCategoriesMappingID
		{
			get { return taxCategoriesMappingID; }
			set { taxCategoriesMappingID = value; }
		}

		/// <summary>
		/// Gets or sets the CategoriesID value.
		/// </summary>
		public int CategoriesID
		{
			get { return categoriesID; }
			set { categoriesID = value; }
		}

		/// <summary>
		/// Gets or sets the TaxTypeID value.
		/// </summary>
		public int TaxTypeID
		{
			get { return taxTypeID; }
			set { taxTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the StateID value.
		/// </summary>
		public int StateID
		{
			get { return stateID; }
			set { stateID = value; }
		}

		/// <summary>
		/// Gets or sets the Tax value.
		/// </summary>
		public decimal Tax
		{
			get { return tax; }
			set { tax = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		public bool Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the Createdat value.
		/// </summary>
		public DateTime Createdat
		{
			get { return createdat; }
			set { createdat = value; }
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
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
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
		/// Gets or sets the OrgAddressID value.
		/// </summary>
		public int OrgAddressID
		{
			get { return orgAddressID; }
			set { orgAddressID = value; }
		}

		/// <summary>
		/// Gets or sets the ValidFrom value.
		/// </summary>
		public DateTime ValidFrom
		{
			get { return validFrom; }
			set { validFrom = value; }
		}

		/// <summary>
		/// Gets or sets the ValidTo value.
		/// </summary>
		public DateTime ValidTo
		{
			get { return validTo; }
			set { validTo = value; }
		}

		/// <summary>
		/// Gets or sets the OutputTaxTypeID value.
		/// </summary>
		public int OutputTaxTypeID
		{
			get { return outputTaxTypeID; }
			set { outputTaxTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the OutputTax value.
		/// </summary>
		public decimal OutputTax
		{
			get { return outputTax; }
			set { outputTax = value; }
		}


		#endregion
}
}
