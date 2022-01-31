using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class StockReceivedAttributesDetails
	{
		#region Fields

		private long details=0;
		private long stockReceivedDetailsId=0;
		private long categorieMappingID=0;
		private string attributesKey=String.Empty;
		private string attributesValue=String.Empty;
		private int orgID=0;
		private bool status=false;
		private DateTime createdat=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Details value.
		/// </summary>
		public long Details
		{
			get { return details; }
			set { details = value; }
		}

		/// <summary>
		/// Gets or sets the StockReceivedDetailsId value.
		/// </summary>
		public long StockReceivedDetailsId
		{
			get { return stockReceivedDetailsId; }
			set { stockReceivedDetailsId = value; }
		}

		/// <summary>
		/// Gets or sets the CategorieMappingID value.
		/// </summary>
		public long CategorieMappingID
		{
			get { return categorieMappingID; }
			set { categorieMappingID = value; }
		}

		/// <summary>
		/// Gets or sets the AttributesKey value.
		/// </summary>
		public string AttributesKey
		{
			get { return attributesKey; }
			set { attributesKey = value; }
		}

		/// <summary>
		/// Gets or sets the AttributesValue value.
		/// </summary>
		public string AttributesValue
		{
			get { return attributesValue; }
			set { attributesValue = value; }
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


		#endregion
}
}
