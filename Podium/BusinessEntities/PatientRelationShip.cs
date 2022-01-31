using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PatientRelationShip
	{
		#region Fields

		private long parentPatientID=0;
		private long relatedPatientID=0;
		private long relationShipTypeID=0;
		private string status=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string relationShipType=String.Empty;
		private string relationShipSubType=String.Empty;
		private string patientEmpTypeNumber=String.Empty;
		private string employementTypeNumber=String.Empty;
		private long empID=0;
		private int relationNumIndicator=0;
		private long bookingID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ParentPatientID value.
		/// </summary>
		public long ParentPatientID
		{
			get { return parentPatientID; }
			set { parentPatientID = value; }
		}

		/// <summary>
		/// Gets or sets the RelatedPatientID value.
		/// </summary>
		public long RelatedPatientID
		{
			get { return relatedPatientID; }
			set { relatedPatientID = value; }
		}

		/// <summary>
		/// Gets or sets the RelationShipTypeID value.
		/// </summary>
		public long RelationShipTypeID
		{
			get { return relationShipTypeID; }
			set { relationShipTypeID = value; }
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
		/// Gets or sets the RelationShipType value.
		/// </summary>
		public string RelationShipType
		{
			get { return relationShipType; }
			set { relationShipType = value; }
		}

		/// <summary>
		/// Gets or sets the RelationShipSubType value.
		/// </summary>
		public string RelationShipSubType
		{
			get { return relationShipSubType; }
			set { relationShipSubType = value; }
		}

		/// <summary>
		/// Gets or sets the PatientEmpTypeNumber value.
		/// </summary>
		public string PatientEmpTypeNumber
		{
			get { return patientEmpTypeNumber; }
			set { patientEmpTypeNumber = value; }
		}

		/// <summary>
		/// Gets or sets the EmployementTypeNumber value.
		/// </summary>
		public string EmployementTypeNumber
		{
			get { return employementTypeNumber; }
			set { employementTypeNumber = value; }
		}

		/// <summary>
		/// Gets or sets the EmpID value.
		/// </summary>
		public long EmpID
		{
			get { return empID; }
			set { empID = value; }
		}

		/// <summary>
		/// Gets or sets the RelationNumIndicator value.
		/// </summary>
		public int RelationNumIndicator
		{
			get { return relationNumIndicator; }
			set { relationNumIndicator = value; }
		}

		/// <summary>
		/// Gets or sets the BookingID value.
		/// </summary>
		public long BookingID
		{
			get { return bookingID; }
			set { bookingID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientName value.
		/// </summary>
		private string _patientName=String.Empty;
		public string PatientName
		{
			get { return  _patientName; }
			set { _patientName = value; }
		}

		/// <summary>
		/// Gets or sets the Age value.
		/// </summary>
		private string _age=String.Empty;
		public string Age
		{
			get { return  _age; }
			set { _age = value; }
		}

		/// <summary>
		/// Gets or sets the Sex value.
		/// </summary>
		private string _sex=String.Empty;
		public string Sex
		{
			get { return  _sex; }
			set { _sex = value; }
		}

		/// <summary>
		/// Gets or sets the PatientType value.
		/// </summary>
		private string _patientType=String.Empty;
		public string PatientType
		{
			get { return  _patientType; }
			set { _patientType = value; }
		}

		/// <summary>
		/// Gets or sets the MembershipCardMappingID value.
		/// </summary>
		private long _membershipCardMappingID=0;
		public long MembershipCardMappingID
		{
			get { return  _membershipCardMappingID; }
			set { _membershipCardMappingID = value; }
		}

		/// <summary>
		/// Gets or sets the MembershipCardTypeID value.
		/// </summary>
		private long _membershipCardTypeID=0;
		public long MembershipCardTypeID
		{
			get { return  _membershipCardTypeID; }
			set { _membershipCardTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientID value.
		/// </summary>
		private long _patientID=0;
		public long PatientID
		{
			get { return  _patientID; }
			set { _patientID = value; }
		}

		/// <summary>
		/// Gets or sets the MembershipCardNo value.
		/// </summary>
		private string _membershipCardNo=String.Empty;
		public string MembershipCardNo
		{
			get { return  _membershipCardNo; }
			set { _membershipCardNo = value; }
		}

		/// <summary>
		/// Gets or sets the IncludeDependent value.
		/// </summary>
		private string _includeDependent=String.Empty;
		public string IncludeDependent
		{
			get { return  _includeDependent; }
			set { _includeDependent = value; }
		}

		/// <summary>
		/// Gets or sets the ValidFrom value.
		/// </summary>
		private DateTime _validFrom=DateTime.MaxValue;
		public DateTime ValidFrom
		{
			get { return  _validFrom; }
			set { _validFrom = value; }
		}

		/// <summary>
		/// Gets or sets the ValidTo value.
		/// </summary>
		private DateTime _validTo=DateTime.MaxValue;
		public DateTime ValidTo
		{
			get { return  _validTo; }
			set { _validTo = value; }
		}

		/// <summary>
		/// Gets or sets the Amount value.
		/// </summary>
		private decimal _amount=Decimal.Zero;
		public decimal Amount
		{
			get { return  _amount; }
			set { _amount = value; }
		}


		#endregion
}
}
