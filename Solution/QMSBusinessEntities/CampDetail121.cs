using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class CampDetail121
	{
		#region Fields

		private int iD=0;
		private int orgid=0;
		private int slNo=0;
		private DateTime pDate=DateTime.MaxValue;
		private DateTime sDate=DateTime.MaxValue;
		private string sCollectedBy=String.Empty;
		private string patID=String.Empty;
		private string title=String.Empty;
		private string nAME=String.Empty;
		private string aGE=String.Empty;
		private string sEX=String.Empty;
		private string lOCATION=String.Empty;
		private string doctor=String.Empty;
		private string refHospital=String.Empty;
		private string priority=String.Empty;
		private string dispatchMode=String.Empty;
		private string tESTSREQUESTED=String.Empty;
		private decimal cHARGED=Decimal.Zero;
		private decimal amountPaid=Decimal.Zero;
		private decimal amountDisocunt=Decimal.Zero;
		private string disocuntReason=String.Empty;
		private string discountAuthorisedBy=String.Empty;
		private string history=String.Empty;
		private string remarks=String.Empty;
		private string mobileNo=String.Empty;
		private long createdBy=0;
		private string clientCode=String.Empty;
		private string emailID=String.Empty;
		private bool errorStatus=false;
		private string errorDesc=String.Empty;
		private long clientID=0;
		private long lOCATIONID=0;
		private long titleID=0;
		private long doctorID=0;
		private long refHospitalID=0;
		private string tESTCODE=String.Empty;
		private long sCollectedByID=0;
		private int priorityID=0;
		private string isClientPatient=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}

		/// <summary>
		/// Gets or sets the Orgid value.
		/// </summary>
		public int Orgid
		{
			get { return orgid; }
			set { orgid = value; }
		}

		/// <summary>
		/// Gets or sets the SlNo value.
		/// </summary>
		public int SlNo
		{
			get { return slNo; }
			set { slNo = value; }
		}

		/// <summary>
		/// Gets or sets the PDate value.
		/// </summary>
		public DateTime PDate
		{
			get { return pDate; }
			set { pDate = value; }
		}

		/// <summary>
		/// Gets or sets the SDate value.
		/// </summary>
		public DateTime SDate
		{
			get { return sDate; }
			set { sDate = value; }
		}

		/// <summary>
		/// Gets or sets the SCollectedBy value.
		/// </summary>
		public string SCollectedBy
		{
			get { return sCollectedBy; }
			set { sCollectedBy = value; }
		}

		/// <summary>
		/// Gets or sets the PatID value.
		/// </summary>
		public string PatID
		{
			get { return patID; }
			set { patID = value; }
		}

		/// <summary>
		/// Gets or sets the Title value.
		/// </summary>
		public string Title
		{
			get { return title; }
			set { title = value; }
		}

		/// <summary>
		/// Gets or sets the NAME value.
		/// </summary>
		public string NAME
		{
			get { return nAME; }
			set { nAME = value; }
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
		/// Gets or sets the SEX value.
		/// </summary>
		public string SEX
		{
			get { return sEX; }
			set { sEX = value; }
		}

		/// <summary>
		/// Gets or sets the LOCATION value.
		/// </summary>
		public string LOCATION
		{
			get { return lOCATION; }
			set { lOCATION = value; }
		}

		/// <summary>
		/// Gets or sets the Doctor value.
		/// </summary>
		public string Doctor
		{
			get { return doctor; }
			set { doctor = value; }
		}

		/// <summary>
		/// Gets or sets the RefHospital value.
		/// </summary>
		public string RefHospital
		{
			get { return refHospital; }
			set { refHospital = value; }
		}

		/// <summary>
		/// Gets or sets the Priority value.
		/// </summary>
		public string Priority
		{
			get { return priority; }
			set { priority = value; }
		}

		/// <summary>
		/// Gets or sets the DispatchMode value.
		/// </summary>
		public string DispatchMode
		{
			get { return dispatchMode; }
			set { dispatchMode = value; }
		}

		/// <summary>
		/// Gets or sets the TESTSREQUESTED value.
		/// </summary>
		public string TESTSREQUESTED
		{
			get { return tESTSREQUESTED; }
			set { tESTSREQUESTED = value; }
		}

		/// <summary>
		/// Gets or sets the CHARGED value.
		/// </summary>
		public decimal CHARGED
		{
			get { return cHARGED; }
			set { cHARGED = value; }
		}

		/// <summary>
		/// Gets or sets the AmountPaid value.
		/// </summary>
		public decimal AmountPaid
		{
			get { return amountPaid; }
			set { amountPaid = value; }
		}

		/// <summary>
		/// Gets or sets the AmountDisocunt value.
		/// </summary>
		public decimal AmountDisocunt
		{
			get { return amountDisocunt; }
			set { amountDisocunt = value; }
		}

		/// <summary>
		/// Gets or sets the DisocuntReason value.
		/// </summary>
		public string DisocuntReason
		{
			get { return disocuntReason; }
			set { disocuntReason = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountAuthorisedBy value.
		/// </summary>
		public string DiscountAuthorisedBy
		{
			get { return discountAuthorisedBy; }
			set { discountAuthorisedBy = value; }
		}

		/// <summary>
		/// Gets or sets the History value.
		/// </summary>
		public string History
		{
			get { return history; }
			set { history = value; }
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
		/// Gets or sets the MobileNo value.
		/// </summary>
		public string MobileNo
		{
			get { return mobileNo; }
			set { mobileNo = value; }
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
		/// Gets or sets the ClientCode value.
		/// </summary>
		public string ClientCode
		{
			get { return clientCode; }
			set { clientCode = value; }
		}

		/// <summary>
		/// Gets or sets the EmailID value.
		/// </summary>
		public string EmailID
		{
			get { return emailID; }
			set { emailID = value; }
		}

		/// <summary>
		/// Gets or sets the ErrorStatus value.
		/// </summary>
		public bool ErrorStatus
		{
			get { return errorStatus; }
			set { errorStatus = value; }
		}

		/// <summary>
		/// Gets or sets the ErrorDesc value.
		/// </summary>
		public string ErrorDesc
		{
			get { return errorDesc; }
			set { errorDesc = value; }
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
		/// Gets or sets the LOCATIONID value.
		/// </summary>
		public long LOCATIONID
		{
			get { return lOCATIONID; }
			set { lOCATIONID = value; }
		}

		/// <summary>
		/// Gets or sets the TitleID value.
		/// </summary>
		public long TitleID
		{
			get { return titleID; }
			set { titleID = value; }
		}

		/// <summary>
		/// Gets or sets the DoctorID value.
		/// </summary>
		public long DoctorID
		{
			get { return doctorID; }
			set { doctorID = value; }
		}

		/// <summary>
		/// Gets or sets the RefHospitalID value.
		/// </summary>
		public long RefHospitalID
		{
			get { return refHospitalID; }
			set { refHospitalID = value; }
		}

		/// <summary>
		/// Gets or sets the TESTCODE value.
		/// </summary>
		public string TESTCODE
		{
			get { return tESTCODE; }
			set { tESTCODE = value; }
		}

		/// <summary>
		/// Gets or sets the SCollectedByID value.
		/// </summary>
		public long SCollectedByID
		{
			get { return sCollectedByID; }
			set { sCollectedByID = value; }
		}

		/// <summary>
		/// Gets or sets the PriorityID value.
		/// </summary>
		public int PriorityID
		{
			get { return priorityID; }
			set { priorityID = value; }
		}

		/// <summary>
		/// Gets or sets the IsClientPatient value.
		/// </summary>
		public string IsClientPatient
		{
			get { return isClientPatient; }
			set { isClientPatient = value; }
		}


		#endregion
}
}
