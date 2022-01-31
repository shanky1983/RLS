using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class AdvancePaidDetails
	{
		#region Fields

		private long advanceID=0;
		private long visitID=0;
		private long patientID=0;
		private decimal advanceAmount=Decimal.Zero;
		private DateTime paidDate=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string status=String.Empty;
		private int typeID=0;
		private string chequeorCardNumber=String.Empty;
		private string bankNameorCardType=String.Empty;
		private string remarks=String.Empty;
		private long advanceTypeID=0;
		private string advanceType=String.Empty;
		private decimal serviceCharge=Decimal.Zero;
		private string receiptNO=String.Empty;
		private int baseCurrencyID=0;
		private int paidCurrencyID=0;
		private decimal otherCurrencyAmount=Decimal.Zero;
		private string versionNo=String.Empty;
		private int roleID=0;
		private int deptID=0;
		private int orgID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the AdvanceID value.
		/// </summary>
		public long AdvanceID
		{
			get { return advanceID; }
			set { advanceID = value; }
		}

		/// <summary>
		/// Gets or sets the VisitID value.
		/// </summary>
		public long VisitID
		{
			get { return visitID; }
			set { visitID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientID value.
		/// </summary>
		public long PatientID
		{
			get { return patientID; }
			set { patientID = value; }
		}

		/// <summary>
		/// Gets or sets the AdvanceAmount value.
		/// </summary>
		public decimal AdvanceAmount
		{
			get { return advanceAmount; }
			set { advanceAmount = value; }
		}

		/// <summary>
		/// Gets or sets the PaidDate value.
		/// </summary>
		public DateTime PaidDate
		{
			get { return paidDate; }
			set { paidDate = value; }
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
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the TypeID value.
		/// </summary>
		public int TypeID
		{
			get { return typeID; }
			set { typeID = value; }
		}

		/// <summary>
		/// Gets or sets the ChequeorCardNumber value.
		/// </summary>
		public string ChequeorCardNumber
		{
			get { return chequeorCardNumber; }
			set { chequeorCardNumber = value; }
		}

		/// <summary>
		/// Gets or sets the BankNameorCardType value.
		/// </summary>
		public string BankNameorCardType
		{
			get { return bankNameorCardType; }
			set { bankNameorCardType = value; }
		}

		/// <summary>
		/// Gets or sets the Remarks value.
		/// </summary>
		public string Remarks
		{
			get { return remarks; }
			set { remarks = value; }
		}

		/// <summary>
		/// Gets or sets the AdvanceTypeID value.
		/// </summary>
		public long AdvanceTypeID
		{
			get { return advanceTypeID; }
			set { advanceTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the AdvanceType value.
		/// </summary>
		public string AdvanceType
		{
			get { return advanceType; }
			set { advanceType = value; }
		}

		/// <summary>
		/// Gets or sets the ServiceCharge value.
		/// </summary>
		public decimal ServiceCharge
		{
			get { return serviceCharge; }
			set { serviceCharge = value; }
		}

		/// <summary>
		/// Gets or sets the ReceiptNO value.
		/// </summary>
		public string ReceiptNO
		{
			get { return receiptNO; }
			set { receiptNO = value; }
		}

		/// <summary>
		/// Gets or sets the BaseCurrencyID value.
		/// </summary>
		public int BaseCurrencyID
		{
			get { return baseCurrencyID; }
			set { baseCurrencyID = value; }
		}

		/// <summary>
		/// Gets or sets the PaidCurrencyID value.
		/// </summary>
		public int PaidCurrencyID
		{
			get { return paidCurrencyID; }
			set { paidCurrencyID = value; }
		}

		/// <summary>
		/// Gets or sets the OtherCurrencyAmount value.
		/// </summary>
		public decimal OtherCurrencyAmount
		{
			get { return otherCurrencyAmount; }
			set { otherCurrencyAmount = value; }
		}

		/// <summary>
		/// Gets or sets the VersionNo value.
		/// </summary>
		public string VersionNo
		{
			get { return versionNo; }
			set { versionNo = value; }
		}

		/// <summary>
		/// Gets or sets the RoleID value.
		/// </summary>
		public int RoleID
		{
			get { return roleID; }
			set { roleID = value; }
		}

		/// <summary>
		/// Gets or sets the DeptID value.
		/// </summary>
		public int DeptID
		{
			get { return deptID; }
			set { deptID = value; }
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
		/// Gets or sets the FinalBillID value.
		/// </summary>
		long _finalbillid;
		public long FinalBillID
		{
			get { return _finalbillid; }
			set { _finalbillid = value; }
		}

		/// <summary>
		/// Gets or sets the Name value.
		/// </summary>
		string _name;
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}


		#endregion
}
}
