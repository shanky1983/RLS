using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ProcedureMaster
	{
		#region Fields

		private long procedureID=0;
		private string procedureName=String.Empty;
		private string procedureType=String.Empty;
		private string procedureDesc=String.Empty;
		private long orgID=0;
		private string isAVisitPurpose=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long parentID=0;
		private string iCDCode=String.Empty;
		private string complaintName=String.Empty;
		private string isAmountEditable=String.Empty;
		private string chartAccCode=String.Empty;
		private string isRefundable=String.Empty;
		private string isTaxable=String.Empty;
		private string isDiscountable=String.Empty;
		private string isActive=String.Empty;
		private string serviceCode=String.Empty;
		private int reOrderPeriod=0;
		private string isAdminChargeApplicable=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ProcedureID value.
		/// </summary>
		public long ProcedureID
		{
			get { return procedureID; }
			set { procedureID = value; }
		}

		/// <summary>
		/// Gets or sets the ProcedureName value.
		/// </summary>
		public string ProcedureName
		{
			get { return procedureName; }
			set { procedureName = value; }
		}

		/// <summary>
		/// Gets or sets the ProcedureType value.
		/// </summary>
		public string ProcedureType
		{
			get { return procedureType; }
			set { procedureType = value; }
		}

		/// <summary>
		/// Gets or sets the ProcedureDesc value.
		/// </summary>
		public string ProcedureDesc
		{
			get { return procedureDesc; }
			set { procedureDesc = value; }
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
		/// Gets or sets the IsAVisitPurpose value.
		/// </summary>
		public string IsAVisitPurpose
		{
			get { return isAVisitPurpose; }
			set { isAVisitPurpose = value; }
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
		/// Gets or sets the ParentID value.
		/// </summary>
		public long ParentID
		{
			get { return parentID; }
			set { parentID = value; }
		}

		/// <summary>
		/// Gets or sets the ICDCode value.
		/// </summary>
		public string ICDCode
		{
			get { return iCDCode; }
			set { iCDCode = value; }
		}

		/// <summary>
		/// Gets or sets the ComplaintName value.
		/// </summary>
		public string ComplaintName
		{
			get { return complaintName; }
			set { complaintName = value; }
		}

		/// <summary>
		/// Gets or sets the IsAmountEditable value.
		/// </summary>
		public string IsAmountEditable
		{
			get { return isAmountEditable; }
			set { isAmountEditable = value; }
		}

		/// <summary>
		/// Gets or sets the ChartAccCode value.
		/// </summary>
		public string ChartAccCode
		{
			get { return chartAccCode; }
			set { chartAccCode = value; }
		}

		/// <summary>
		/// Gets or sets the IsRefundable value.
		/// </summary>
		public string IsRefundable
		{
			get { return isRefundable; }
			set { isRefundable = value; }
		}

		/// <summary>
		/// Gets or sets the IsTaxable value.
		/// </summary>
		public string IsTaxable
		{
			get { return isTaxable; }
			set { isTaxable = value; }
		}

		/// <summary>
		/// Gets or sets the IsDiscountable value.
		/// </summary>
		public string IsDiscountable
		{
			get { return isDiscountable; }
			set { isDiscountable = value; }
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
		/// Gets or sets the ServiceCode value.
		/// </summary>
		public string ServiceCode
		{
			get { return serviceCode; }
			set { serviceCode = value; }
		}

		/// <summary>
		/// Gets or sets the ReOrderPeriod value.
		/// </summary>
		public int ReOrderPeriod
		{
			get { return reOrderPeriod; }
			set { reOrderPeriod = value; }
		}

		/// <summary>
		/// Gets or sets the IsAdminChargeApplicable value.
		/// </summary>
		public string IsAdminChargeApplicable
		{
			get { return isAdminChargeApplicable; }
			set { isAdminChargeApplicable = value; }
		}

		/// <summary>
		/// Gets or sets the Active value.
		/// </summary>
		private String _active=String.Empty;
		public String Active
		{
			get { return  _active; }
			set { _active = value; }
		}

		/// <summary>
		/// Gets or sets the SourceCategoryID value.
		/// </summary>
		private long _sourceCategoryID=0;
		public long SourceCategoryID
		{
			get { return  _sourceCategoryID; }
			set { _sourceCategoryID = value; }
		}


		#endregion
}
}
