using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class BulkRegistrationDetail
	{
		#region Fields

		private int orgid=0;
		private int slNo=0;
		private DateTime registration_Date=DateTime.MaxValue;
		private DateTime sample_CollectedDateTime=DateTime.MaxValue;
		private string sampleCollectedBy=String.Empty;
		private string uniqueID=String.Empty;
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
		private long patientID=0;
		private string isProcessed=String.Empty;
		private int testCount=0;
		private int testInDetail=0;

		#endregion

		#region Properties
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
		/// Gets or sets the Registration_Date value.
		/// </summary>
		public DateTime Registration_Date
		{
			get { return registration_Date; }
			set { registration_Date = value; }
		}

		/// <summary>
		/// Gets or sets the Sample_CollectedDateTime value.
		/// </summary>
		public DateTime Sample_CollectedDateTime
		{
			get { return sample_CollectedDateTime; }
			set { sample_CollectedDateTime = value; }
		}

		/// <summary>
		/// Gets or sets the SampleCollectedBy value.
		/// </summary>
		public string SampleCollectedBy
		{
			get { return sampleCollectedBy; }
			set { sampleCollectedBy = value; }
		}

		/// <summary>
		/// Gets or sets the UniqueID value.
		/// </summary>
		public string UniqueID
		{
			get { return uniqueID; }
			set { uniqueID = value; }
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
		/// Gets or sets the PatientID value.
		/// </summary>
		public long PatientID
		{
			get { return patientID; }
			set { patientID = value; }
		}

		/// <summary>
		/// Gets or sets the IsProcessed value.
		/// </summary>
		public string IsProcessed
		{
			get { return isProcessed; }
			set { isProcessed = value; }
		}

		/// <summary>
		/// Gets or sets the TestCount value.
		/// </summary>
		public int TestCount
		{
			get { return testCount; }
			set { testCount = value; }
		}

		/// <summary>
		/// Gets or sets the TestInDetail value.
		/// </summary>
		public int TestInDetail
		{
			get { return testInDetail; }
			set { testInDetail = value; }
		}


		#endregion
}
}
