using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ProductsAttributes
	{
		#region Fields

		private long productAttributeID=0;
		private long productID=0;
		private long drugFrequencyID=0;
		private int drugInstructionID=0;
		private string duration=String.Empty;
		private decimal quantity=Decimal.Zero;
		private int orgID=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifyAt=DateTime.MaxValue;
		private long modifyBy=0;
		private string durationType=String.Empty;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ProductAttributeID value.
		/// </summary>
		public long ProductAttributeID
		{
			get { return productAttributeID; }
			set { productAttributeID = value; }
		}

		/// <summary>
		/// Gets or sets the ProductID value.
		/// </summary>
		public long ProductID
		{
			get { return productID; }
			set { productID = value; }
		}

		/// <summary>
		/// Gets or sets the DrugFrequencyID value.
		/// </summary>
		public long DrugFrequencyID
		{
			get { return drugFrequencyID; }
			set { drugFrequencyID = value; }
		}

		/// <summary>
		/// Gets or sets the DrugInstructionID value.
		/// </summary>
		public int DrugInstructionID
		{
			get { return drugInstructionID; }
			set { drugInstructionID = value; }
		}

		/// <summary>
		/// Gets or sets the Duration value.
		/// </summary>
		public string Duration
		{
			get { return duration; }
			set { duration = value; }
		}

		/// <summary>
		/// Gets or sets the Quantity value.
		/// </summary>
		public decimal Quantity
		{
			get { return quantity; }
			set { quantity = value; }
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
		/// Gets or sets the CreatedAt value.
		/// </summary>
		public DateTime CreatedAt
		{
			get { return createdAt; }
			set { createdAt = value; }
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
		/// Gets or sets the ModifyAt value.
		/// </summary>
		public DateTime ModifyAt
		{
			get { return modifyAt; }
			set { modifyAt = value; }
		}

		/// <summary>
		/// Gets or sets the ModifyBy value.
		/// </summary>
		public long ModifyBy
		{
			get { return modifyBy; }
			set { modifyBy = value; }
		}

		/// <summary>
		/// Gets or sets the DurationType value.
		/// </summary>
		public string DurationType
		{
			get { return durationType; }
			set { durationType = value; }
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
		/// Gets or sets the ProductText value.
		/// </summary>
		private string _productText=String.Empty;
		public string ProductText
		{
			get { return  _productText; }
			set { _productText = value; }
		}

		/// <summary>
		/// Gets or sets the FreqTextDes value.
		/// </summary>
		private string _freqTextDes=String.Empty;
		public string FreqTextDes
		{
			get { return  _freqTextDes; }
			set { _freqTextDes = value; }
		}

		/// <summary>
		/// Gets or sets the InstructionText value.
		/// </summary>
		private string _instructionText=String.Empty;
		public string InstructionText
		{
			get { return  _instructionText; }
			set { _instructionText = value; }
		}

		/// <summary>
		/// Gets or sets the FreqText value.
		/// </summary>
		private string _freqText=String.Empty;
		public string FreqText
		{
			get { return  _freqText; }
			set { _freqText = value; }
		}

		/// <summary>
		/// Gets or sets the IsActive value.
		/// </summary>
		private long _isActive=0;
		public long IsActive
		{
			get { return  _isActive; }
			set { _isActive = value; }
		}


		#endregion
}
}
