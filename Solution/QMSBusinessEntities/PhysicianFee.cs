using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class PhysicianFee
	{
		#region Fields

		private long physicianFeeID=0;
		private long physicianID=0;
		private long orgID=0;
		private decimal amount=Decimal.Zero;
		private string isVariable=String.Empty;
		private decimal iPPercentToHostingOrg=Decimal.Zero;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private decimal oPPercentToHostingOrg=Decimal.Zero;
		private decimal iPAmount=Decimal.Zero;
		private long clientID=0;
		private long specialityID=0;
		private long rateID=0;
		private string isActive=String.Empty;
		private long rateRefID=0;
		private long orgSpecialityMappingID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PhysicianFeeID value.
		/// </summary>
		public long PhysicianFeeID
		{
			get { return physicianFeeID; }
			set { physicianFeeID = value; }
		}

		/// <summary>
		/// Gets or sets the PhysicianID value.
		/// </summary>
		public long PhysicianID
		{
			get { return physicianID; }
			set { physicianID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public long OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the Amount value.
		/// </summary>
		public decimal Amount
		{
			get { return amount; }
			set { amount = value; }
		}

		/// <summary>
		/// Gets or sets the IsVariable value.
		/// </summary>
		public string IsVariable
		{
			get { return isVariable; }
			set { isVariable = value; }
		}

		/// <summary>
		/// Gets or sets the IPPercentToHostingOrg value.
		/// </summary>
		public decimal IPPercentToHostingOrg
		{
			get { return iPPercentToHostingOrg; }
			set { iPPercentToHostingOrg = value; }
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
		/// Gets or sets the OPPercentToHostingOrg value.
		/// </summary>
		public decimal OPPercentToHostingOrg
		{
			get { return oPPercentToHostingOrg; }
			set { oPPercentToHostingOrg = value; }
		}

		/// <summary>
		/// Gets or sets the IPAmount value.
		/// </summary>
		public decimal IPAmount
		{
			get { return iPAmount; }
			set { iPAmount = value; }
		}

		/// <summary>
		/// Gets or sets the ClientID value.
		/// </summary>
		public long ClientID
		{
			get { return clientID; }
			set { clientID = value; }
		}

		/// <summary>
		/// Gets or sets the SpecialityID value.
		/// </summary>
		public long SpecialityID
		{
			get { return specialityID; }
			set { specialityID = value; }
		}

		/// <summary>
		/// Gets or sets the RateID value.
		/// </summary>
		public long RateID
		{
			get { return rateID; }
			set { rateID = value; }
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
		/// Gets or sets the RateRefID value.
		/// </summary>
		public long RateRefID
		{
			get { return rateRefID; }
			set { rateRefID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgSpecialityMappingID value.
		/// </summary>
		public long OrgSpecialityMappingID
		{
			get { return orgSpecialityMappingID; }
			set { orgSpecialityMappingID = value; }
		}

		/// <summary>
		/// Gets or sets the SNo value.
		/// </summary>
		string _sno;
		public string SNo
		{
			get { return _sno; }
			set { _sno = value; }
		}

		/// <summary>
		/// Gets or sets the Descrip value.
		/// </summary>
		string _descrip;
		public string Descrip
		{
			get { return _descrip; }
			set { _descrip = value; }
		}


		#endregion
}
}
