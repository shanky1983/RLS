using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PStage_Physician
	{
		#region Fields

		private long sNO=0;
		private string physicianName=String.Empty;
		private string physicianCode=String.Empty;
		private DateTime dOB=DateTime.MaxValue;
		private string aGE=String.Empty;
		private string sex=String.Empty;
		private string qualification=String.Empty;
		private string designation=String.Empty;
		private string address1=String.Empty;
		private string address2=String.Empty;
		private string city=String.Empty;
		private string state=String.Empty;
		private string country=String.Empty;
		private string mobileNumber=String.Empty;
		private string emailid=String.Empty;
		private string landLineNo=String.Empty;
		private string faxNo=String.Empty;
		private string iSCLIENT=String.Empty;
		private decimal discountLimit=Decimal.Zero;
		private DateTime discountValidFrom=DateTime.MaxValue;
		private DateTime discountValidTo=DateTime.MaxValue;
		private string hasReportingSms=String.Empty;
		private string hasReportingEmail=String.Empty;
		private string referalHospitalName=String.Empty;
		private string referalHospitalCode=String.Empty;
		private string flag=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the SNO value.
		/// </summary>
		public long SNO
		{
			get { return sNO; }
			set { sNO = value; }
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
		/// Gets or sets the PhysicianCode value.
		/// </summary>
		public string PhysicianCode
		{
			get { return physicianCode; }
			set { physicianCode = value; }
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
		/// Gets or sets the AGE value.
		/// </summary>
		public string AGE
		{
			get { return aGE; }
			set { aGE = value; }
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
		/// Gets or sets the Qualification value.
		/// </summary>
		public string Qualification
		{
			get { return qualification; }
			set { qualification = value; }
		}

		/// <summary>
		/// Gets or sets the Designation value.
		/// </summary>
		public string Designation
		{
			get { return designation; }
			set { designation = value; }
		}

		/// <summary>
		/// Gets or sets the Address1 value.
		/// </summary>
		public string Address1
		{
			get { return address1; }
			set { address1 = value; }
		}

		/// <summary>
		/// Gets or sets the Address2 value.
		/// </summary>
		public string Address2
		{
			get { return address2; }
			set { address2 = value; }
		}

		/// <summary>
		/// Gets or sets the City value.
		/// </summary>
		public string City
		{
			get { return city; }
			set { city = value; }
		}

		/// <summary>
		/// Gets or sets the State value.
		/// </summary>
		public string State
		{
			get { return state; }
			set { state = value; }
		}

		/// <summary>
		/// Gets or sets the Country value.
		/// </summary>
		public string Country
		{
			get { return country; }
			set { country = value; }
		}

		/// <summary>
		/// Gets or sets the MobileNumber value.
		/// </summary>
		public string MobileNumber
		{
			get { return mobileNumber; }
			set { mobileNumber = value; }
		}

		/// <summary>
		/// Gets or sets the Emailid value.
		/// </summary>
		public string Emailid
		{
			get { return emailid; }
			set { emailid = value; }
		}

		/// <summary>
		/// Gets or sets the LandLineNo value.
		/// </summary>
		public string LandLineNo
		{
			get { return landLineNo; }
			set { landLineNo = value; }
		}

		/// <summary>
		/// Gets or sets the FaxNo value.
		/// </summary>
		public string FaxNo
		{
			get { return faxNo; }
			set { faxNo = value; }
		}

		/// <summary>
		/// Gets or sets the ISCLIENT value.
		/// </summary>
		public string ISCLIENT
		{
			get { return iSCLIENT; }
			set { iSCLIENT = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountLimit value.
		/// </summary>
		public decimal DiscountLimit
		{
			get { return discountLimit; }
			set { discountLimit = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountValidFrom value.
		/// </summary>
		public DateTime DiscountValidFrom
		{
			get { return discountValidFrom; }
			set { discountValidFrom = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountValidTo value.
		/// </summary>
		public DateTime DiscountValidTo
		{
			get { return discountValidTo; }
			set { discountValidTo = value; }
		}

		/// <summary>
		/// Gets or sets the HasReportingSms value.
		/// </summary>
		public string HasReportingSms
		{
			get { return hasReportingSms; }
			set { hasReportingSms = value; }
		}

		/// <summary>
		/// Gets or sets the HasReportingEmail value.
		/// </summary>
		public string HasReportingEmail
		{
			get { return hasReportingEmail; }
			set { hasReportingEmail = value; }
		}

		/// <summary>
		/// Gets or sets the ReferalHospitalName value.
		/// </summary>
		public string ReferalHospitalName
		{
			get { return referalHospitalName; }
			set { referalHospitalName = value; }
		}

		/// <summary>
		/// Gets or sets the ReferalHospitalCode value.
		/// </summary>
		public string ReferalHospitalCode
		{
			get { return referalHospitalCode; }
			set { referalHospitalCode = value; }
		}

		/// <summary>
		/// Gets or sets the Flag value.
		/// </summary>
		public string Flag
		{
			get { return flag; }
			set { flag = value; }
		}


		#endregion
}
}
