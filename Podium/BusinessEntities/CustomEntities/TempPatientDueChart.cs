using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    [Serializable()]
	public class TempPatientDueChart
	{
		#region Fields

		private long detailsID=0;
		private long visitID=0;
		private long patientID=0;
		private string feeType=String.Empty;
		private long feeID=0;
		private string description=String.Empty;
		private string comments=String.Empty;
        private DateTime fromDate = DateTime.MaxValue;
        private DateTime toDate = DateTime.MaxValue;
		private string status=String.Empty;
		private decimal unit=Decimal.Zero;
		private int createdBy=0;
        private DateTime createdAt = DateTime.MaxValue;
		private int modifiedBy=0;
        private DateTime modifiedAt = DateTime.MaxValue;
		private decimal amount=Decimal.Zero;
		private long packageID=0;
        private string isReimbursable = String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DetailsID value.
		/// </summary>
		public long DetailsID
		{
			get { return detailsID; }
			set { detailsID = value; }
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
		/// Gets or sets the FeeType value.
		/// </summary>
		public string FeeType
		{
			get { return feeType; }
			set { feeType = value; }
		}

		/// <summary>
		/// Gets or sets the FeeID value.
		/// </summary>
		public long FeeID
		{
			get { return feeID; }
			set { feeID = value; }
		}

		/// <summary>
		/// Gets or sets the Description value.
		/// </summary>
		public string Description
		{
			get { return description; }
			set { description = value; }
		}

		/// <summary>
		/// Gets or sets the Comments value.
		/// </summary>
		public string Comments
		{
			get { return comments; }
			set { comments = value; }
		}

		/// <summary>
		/// Gets or sets the FromDate value.
		/// </summary>
		public DateTime FromDate
		{
			get { return fromDate; }
			set { fromDate = value; }
		}

		/// <summary>
		/// Gets or sets the ToDate value.
		/// </summary>
		public DateTime ToDate
		{
			get { return toDate; }
			set { toDate = value; }
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
		/// Gets or sets the Unit value.
		/// </summary>
		public decimal Unit
		{
			get { return unit; }
			set { unit = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public int CreatedBy
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
		public int ModifiedBy
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
		/// Gets or sets the Amount value.
		/// </summary>
		public decimal Amount
		{
			get { return amount; }
			set { amount = value; }
		}

		/// <summary>
		/// Gets or sets the PackageID value.
		/// </summary>
		public long PackageID
		{
			get { return packageID; }
			set { packageID = value; }
		}

		/// <summary>
		/// Gets or sets the RoomTypeName value.
		/// </summary>
		string _roomtypename;
		public string RoomTypeName
		{
			get { return _roomtypename; }
			set { _roomtypename = value; }
		}

		/// <summary>
		/// Gets or sets the AdvanceAmount value.
		/// </summary>
		decimal _advanceamount;
		public decimal AdvanceAmount
		{
			get { return _advanceamount; }
			set { _advanceamount = value; }
		}

		/// <summary>
		/// Gets or sets the RightOff value.
		/// </summary>
		decimal _rightoff;
		public decimal RightOff
		{
			get { return _rightoff; }
			set { _rightoff = value; }
		}

		/// <summary>
		/// Gets or sets the TDS value.
		/// </summary>
		decimal _tds;
		public decimal TDS
		{
			get { return _tds; }
			set { _tds = value; }
		}

		/// <summary>
		/// Gets or sets the BankNameorCardType value.
		/// </summary>
		string _banknameorcardtype;
		public string BankNameorCardType
		{
			get { return _banknameorcardtype; }
			set { _banknameorcardtype = value; }
		}

		/// <summary>
		/// Gets or sets the ChequeorCardNumber value.
		/// </summary>
        string _chequeorcardnumber;
        public string ChequeorCardNumber
		{
			get { return _chequeorcardnumber; }
			set { _chequeorcardnumber = value; }
		}

		/// <summary>
		/// Gets or sets the TypeID value.
		/// </summary>
		int _typeid;
		public int TypeID
		{
			get { return _typeid; }
			set { _typeid = value; }
		}

		/// <summary>
		/// Gets or sets the FromTable value.
		/// </summary>
		string _fromtable;
		public string FromTable
		{
			get { return _fromtable; }
			set { _fromtable = value; }
		}

		/// <summary>
		/// Gets or sets the UserID value.
		/// </summary>
		long _userid;
		public long UserID
		{
			get { return _userid; }
			set { _userid = value; }
		}

		/// <summary>
		/// Gets or sets the SpecialityID value.
		/// </summary>
		int _specialityid;
		public int SpecialityID
		{
			get { return _specialityid; }
			set { _specialityid = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountAmount value.
		/// </summary>
		decimal _discountamount;
		public decimal DiscountAmount
		{
			get { return _discountamount; }
			set { _discountamount = value; }
		}

        /// <summary>
        /// Gets or sets the IsReimbursable value.
        /// </summary>
        public string IsReimbursable
        {
            get { return isReimbursable; }
            set { isReimbursable = value; }
        }

		#endregion
}
}
