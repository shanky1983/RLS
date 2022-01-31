using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Physician
	{
		#region Fields

		private long physicianID=0;
		private string physicianName=String.Empty;
		private string email=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string physicianType=String.Empty;
		private string sex=String.Empty;
		private long loginID=0;
		private DateTime weddingDt=DateTime.MaxValue;
		private string titleCode=String.Empty;
		private DateTime dOB=DateTime.MaxValue;
		private string relegion=String.Empty;
		private string maritalStatus=String.Empty;
		private string qualification=String.Empty;
		private int orgID=0;
		private string status=String.Empty;
		private string regNumber=String.Empty;
		private string physicianCode=String.Empty;
		private string last_View=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PhysicianID value.
		/// </summary>
		public long PhysicianID
		{
			get { return physicianID; }
			set { physicianID = value; }
		}

		/// <summary>
		/// Gets or sets the PhysicianName value.
		/// </summary>
		public string PhysicianName
		{
			get { return physicianName; }
			set { physicianName = value; }
		}

		/// <summary>
		/// Gets or sets the Email value.
		/// </summary>
		public string Email
		{
			get { return email; }
			set { email = value; }
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
		/// Gets or sets the PhysicianType value.
		/// </summary>
		public string PhysicianType
		{
			get { return physicianType; }
			set { physicianType = value; }
		}

		/// <summary>
		/// Gets or sets the Sex value.
		/// </summary>
		public string Sex
		{
			get { return sex; }
			set { sex = value; }
		}

		/// <summary>
		/// Gets or sets the LoginID value.
		/// </summary>
		public long LoginID
		{
			get { return loginID; }
			set { loginID = value; }
		}

		/// <summary>
		/// Gets or sets the WeddingDt value.
		/// </summary>
		public DateTime WeddingDt
		{
			get { return weddingDt; }
			set { weddingDt = value; }
		}

		/// <summary>
		/// Gets or sets the TitleCode value.
		/// </summary>
		public string TitleCode
		{
			get { return titleCode; }
			set { titleCode = value; }
		}

		/// <summary>
		/// Gets or sets the DOB value.
		/// </summary>
		public DateTime DOB
		{
			get { return dOB; }
			set { dOB = value; }
		}

		/// <summary>
		/// Gets or sets the Relegion value.
		/// </summary>
		public string Relegion
		{
			get { return relegion; }
			set { relegion = value; }
		}

		/// <summary>
		/// Gets or sets the MaritalStatus value.
		/// </summary>
		public string MaritalStatus
		{
			get { return maritalStatus; }
			set { maritalStatus = value; }
		}

		/// <summary>
		/// Gets or sets the Qualification value.
		/// </summary>
		public string Qualification
		{
			get { return qualification; }
			set { qualification = value; }
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
		public string Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the RegNumber value.
		/// </summary>
		public string RegNumber
		{
			get { return regNumber; }
			set { regNumber = value; }
		}

		/// <summary>
		/// Gets or sets the PhysicianCode value.
		/// </summary>
		public string PhysicianCode
		{
			get { return physicianCode; }
			set { physicianCode = value; }
		}

		/// <summary>
		/// Gets or sets the Last_View value.
		/// </summary>
		public string Last_View
		{
			get { return last_View; }
			set { last_View = value; }
		}

		/// <summary>
		/// Gets or sets the Amount value.
		/// </summary>
		private string _amount=String.Empty;
		public string Amount
		{
			get { return  _amount; }
			set { _amount = value; }
		}

		/// <summary>
		/// Gets or sets the Qty value.
		/// </summary>
		private string _qty=String.Empty;
		public string Qty
		{
			get { return  _qty; }
			set { _qty = value; }
		}

		/// <summary>
		/// Gets or sets the Value value.
		/// </summary>
		private string _value=String.Empty;
		public string Value
		{
			get { return  _value; }
			set { _value = value; }
		}

		/// <summary>
		/// Gets or sets the VisitDate value.
		/// </summary>
		private DateTime _visitDate=DateTime.MaxValue;
		public DateTime VisitDate
		{
			get { return  _visitDate; }
			set { _visitDate = value; }
		}

		/// <summary>
		/// Gets or sets the Address value.
		/// </summary>
		List<PhysicianAddress> _address;
		public List<PhysicianAddress> Address
		{
			get { return _address; }
			set { _address = value; }
		}

		/// <summary>
		/// Gets or sets the SpecialityID value.
		/// </summary>
		private int _specialityID=0;
		public int SpecialityID
		{
			get { return  _specialityID; }
			set { _specialityID = value; }
		}

		/// <summary>
		/// Gets or sets the SpecialityName value.
		/// </summary>
		private string _specialityName=String.Empty;
		public string SpecialityName
		{
			get { return  _specialityName; }
			set { _specialityName = value; }
		}

		/// <summary>
		/// Gets or sets the AmountReceived value.
		/// </summary>
		private decimal _amountReceived=Decimal.Zero;
		public decimal AmountReceived
		{
			get { return  _amountReceived; }
			set { _amountReceived = value; }
		}

		/// <summary>
		/// Gets or sets the OrderTaskID value.
		/// </summary>
		private long _orderTaskID=0;
		public long OrderTaskID
		{
			get { return  _orderTaskID; }
			set { _orderTaskID = value; }
		}

		/// <summary>
		/// Gets or sets the ResourceID value.
		/// </summary>
		private long _resourceID=0;
		public long ResourceID
		{
			get { return  _resourceID; }
			set { _resourceID = value; }
		}

		/// <summary>
		/// Gets or sets the ResourceName value.
		/// </summary>
		private string _resourceName=String.Empty;
		public string ResourceName
		{
			get { return  _resourceName; }
			set { _resourceName = value; }
		}

		/// <summary>
		/// Gets or sets the PhysicianFeeID value.
		/// </summary>
		private long _physicianFeeID=0;
		public long PhysicianFeeID
		{
			get { return  _physicianFeeID; }
			set { _physicianFeeID = value; }
		}


		#endregion
}
}
