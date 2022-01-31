using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ClientProductTypeRuleMappingDetails
	{
		#region Fields

		private long clientProRuleMapDetID=0;
		private long clientProRuleMapID=0;
		private decimal marginValue=Decimal.Zero;
		private string discEnhanceType=String.Empty;
		private decimal discEnhanceValue=Decimal.Zero;
		private decimal minimumPrice=Decimal.Zero;
		private decimal maximumPrice=Decimal.Zero;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private long modifiedAt=0;
		private string isActive=String.Empty;
		private string valueType=String.Empty;
		private DateTime validFrom=DateTime.MaxValue;
		private DateTime validTo=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ClientProRuleMapDetID value.
		/// </summary>
		public long ClientProRuleMapDetID
		{
			get { return clientProRuleMapDetID; }
			set { clientProRuleMapDetID = value; }
		}

		/// <summary>
		/// Gets or sets the ClientProRuleMapID value.
		/// </summary>
		public long ClientProRuleMapID
		{
			get { return clientProRuleMapID; }
			set { clientProRuleMapID = value; }
		}

		/// <summary>
		/// Gets or sets the MarginValue value.
		/// </summary>
		public decimal MarginValue
		{
			get { return marginValue; }
			set { marginValue = value; }
		}

		/// <summary>
		/// Gets or sets the DiscEnhanceType value.
		/// </summary>
		public string DiscEnhanceType
		{
			get { return discEnhanceType; }
			set { discEnhanceType = value; }
		}

		/// <summary>
		/// Gets or sets the DiscEnhanceValue value.
		/// </summary>
		public decimal DiscEnhanceValue
		{
			get { return discEnhanceValue; }
			set { discEnhanceValue = value; }
		}

		/// <summary>
		/// Gets or sets the MinimumPrice value.
		/// </summary>
		public decimal MinimumPrice
		{
			get { return minimumPrice; }
			set { minimumPrice = value; }
		}

		/// <summary>
		/// Gets or sets the MaximumPrice value.
		/// </summary>
		public decimal MaximumPrice
		{
			get { return maximumPrice; }
			set { maximumPrice = value; }
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
		public long ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
		}

		/// <summary>
		/// Gets or sets the IsActive value.
		/// </summary>
		public string IsActive
		{
			get { return isActive; }
			set { isActive = value; }
		}

		/// <summary>
		/// Gets or sets the ValueType value.
		/// </summary>
		public string ValueType
		{
			get { return valueType; }
			set { valueType = value; }
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


		#endregion
}
}
