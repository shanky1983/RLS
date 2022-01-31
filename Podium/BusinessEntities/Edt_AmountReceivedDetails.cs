using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Edt_AmountReceivedDetails
	{
		#region Fields

		private long edtAmtReceivedDetailsID=0;
		private long edtBillMasterID=0;
		private decimal amtReceived=Decimal.Zero;
		private long receivedBy=0;
		private DateTime receivedDate=DateTime.MaxValue;
		private string closureStatus=String.Empty;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int typeID=0;
		private string chequeorCardNumber=String.Empty;
		private string bankNameorCardType=String.Empty;
		private string remarks=String.Empty;
		private decimal serviceCharge=Decimal.Zero;
		private int baseCurrencyID=0;
		private int paidCurrencyID=0;
		private decimal otherCurrencyAmount=Decimal.Zero;
		private int roleID=0;
		private int deptID=0;
		private long referenceID=0;
		private string referenceType=String.Empty;
		private int units=0;
		private string eMIOpted=String.Empty;
		private decimal eMIROI=Decimal.Zero;
		private int eMITenor=0;
		private decimal eMIValue=Decimal.Zero;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the EdtAmtReceivedDetailsID value.
		/// </summary>
		public long EdtAmtReceivedDetailsID
		{
			get { return edtAmtReceivedDetailsID; }
			set { edtAmtReceivedDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the EdtBillMasterID value.
		/// </summary>
		public long EdtBillMasterID
		{
			get { return edtBillMasterID; }
			set { edtBillMasterID = value; }
		}

		/// <summary>
		/// Gets or sets the AmtReceived value.
		/// </summary>
		public decimal AmtReceived
		{
			get { return amtReceived; }
			set { amtReceived = value; }
		}

		/// <summary>
		/// Gets or sets the ReceivedBy value.
		/// </summary>
		public long ReceivedBy
		{
			get { return receivedBy; }
			set { receivedBy = value; }
		}

		/// <summary>
		/// Gets or sets the ReceivedDate value.
		/// </summary>
		public DateTime ReceivedDate
		{
			get { return receivedDate; }
			set { receivedDate = value; }
		}

		/// <summary>
		/// Gets or sets the ClosureStatus value.
		/// </summary>
		public string ClosureStatus
		{
			get { return closureStatus; }
			set { closureStatus = value; }
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
		/// Gets or sets the ServiceCharge value.
		/// </summary>
		public decimal ServiceCharge
		{
			get { return serviceCharge; }
			set { serviceCharge = value; }
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
		/// Gets or sets the ReferenceID value.
		/// </summary>
		public long ReferenceID
		{
			get { return referenceID; }
			set { referenceID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceType value.
		/// </summary>
		public string ReferenceType
		{
			get { return referenceType; }
			set { referenceType = value; }
		}

		/// <summary>
		/// Gets or sets the Units value.
		/// </summary>
		public int Units
		{
			get { return units; }
			set { units = value; }
		}

		/// <summary>
		/// Gets or sets the EMIOpted value.
		/// </summary>
		public string EMIOpted
		{
			get { return eMIOpted; }
			set { eMIOpted = value; }
		}

		/// <summary>
		/// Gets or sets the EMIROI value.
		/// </summary>
		public decimal EMIROI
		{
			get { return eMIROI; }
			set { eMIROI = value; }
		}

		/// <summary>
		/// Gets or sets the EMITenor value.
		/// </summary>
		public int EMITenor
		{
			get { return eMITenor; }
			set { eMITenor = value; }
		}

		/// <summary>
		/// Gets or sets the EMIValue value.
		/// </summary>
		public decimal EMIValue
		{
			get { return eMIValue; }
			set { eMIValue = value; }
		}


		#endregion
}
}
