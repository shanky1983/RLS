using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PatientEpisode
	{
		#region Fields

		private long patientEpisodeID=0;
		private long episodeID=0;
		private DateTime episodeStartDt=DateTime.MaxValue;
		private DateTime episodeEndDt=DateTime.MaxValue;
		private long patientID=0;
		private int orgID=0;
		private string status=String.Empty;
		private int noofSitting=0;
		private string isCreditBill=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int coPaymentLogic=0;
		private decimal copaymentPercent=Decimal.Zero;
		private int referingPhysicianID=0;
		private string referingPhysicianName=String.Empty;
		private string attributeDetail=String.Empty;
		private decimal preAuthAmount=Decimal.Zero;
		private int claimLogic=0;
		private int usedSittings=0;
		private string refType=String.Empty;
		private long refHospitalID=0;
		private string refHospitalName=String.Empty;
		private string preAuthApprovalNumber=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PatientEpisodeID value.
		/// </summary>
		public long PatientEpisodeID
		{
			get { return patientEpisodeID; }
			set { patientEpisodeID = value; }
		}

		/// <summary>
		/// Gets or sets the EpisodeID value.
		/// </summary>
		public long EpisodeID
		{
			get { return episodeID; }
			set { episodeID = value; }
		}

		/// <summary>
		/// Gets or sets the EpisodeStartDt value.
		/// </summary>
		public DateTime EpisodeStartDt
		{
			get { return episodeStartDt; }
			set { episodeStartDt = value; }
		}

		/// <summary>
		/// Gets or sets the EpisodeEndDt value.
		/// </summary>
		public DateTime EpisodeEndDt
		{
			get { return episodeEndDt; }
			set { episodeEndDt = value; }
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
		/// Gets or sets the NoofSitting value.
		/// </summary>
		public int NoofSitting
		{
			get { return noofSitting; }
			set { noofSitting = value; }
		}

		/// <summary>
		/// Gets or sets the IsCreditBill value.
		/// </summary>
		public string IsCreditBill
		{
			get { return isCreditBill; }
			set { isCreditBill = value; }
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
		/// Gets or sets the CoPaymentLogic value.
		/// </summary>
		public int CoPaymentLogic
		{
			get { return coPaymentLogic; }
			set { coPaymentLogic = value; }
		}

		/// <summary>
		/// Gets or sets the CopaymentPercent value.
		/// </summary>
		public decimal CopaymentPercent
		{
			get { return copaymentPercent; }
			set { copaymentPercent = value; }
		}

		/// <summary>
		/// Gets or sets the ReferingPhysicianID value.
		/// </summary>
		public int ReferingPhysicianID
		{
			get { return referingPhysicianID; }
			set { referingPhysicianID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferingPhysicianName value.
		/// </summary>
		public string ReferingPhysicianName
		{
			get { return referingPhysicianName; }
			set { referingPhysicianName = value; }
		}

		/// <summary>
		/// Gets or sets the AttributeDetail value.
		/// </summary>
		public string AttributeDetail
		{
			get { return attributeDetail; }
			set { attributeDetail = value; }
		}

		/// <summary>
		/// Gets or sets the PreAuthAmount value.
		/// </summary>
		public decimal PreAuthAmount
		{
			get { return preAuthAmount; }
			set { preAuthAmount = value; }
		}

		/// <summary>
		/// Gets or sets the ClaimLogic value.
		/// </summary>
		public int ClaimLogic
		{
			get { return claimLogic; }
			set { claimLogic = value; }
		}

		/// <summary>
		/// Gets or sets the UsedSittings value.
		/// </summary>
		public int UsedSittings
		{
			get { return usedSittings; }
			set { usedSittings = value; }
		}

		/// <summary>
		/// Gets or sets the RefType value.
		/// </summary>
		public string RefType
		{
			get { return refType; }
			set { refType = value; }
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
		/// Gets or sets the RefHospitalName value.
		/// </summary>
		public string RefHospitalName
		{
			get { return refHospitalName; }
			set { refHospitalName = value; }
		}

		/// <summary>
		/// Gets or sets the PreAuthApprovalNumber value.
		/// </summary>
		public string PreAuthApprovalNumber
		{
			get { return preAuthApprovalNumber; }
			set { preAuthApprovalNumber = value; }
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
		/// Gets or sets the Address value.
		/// </summary>
		private string _address=String.Empty;
		public string Address
		{
			get { return  _address; }
			set { _address = value; }
		}

		/// <summary>
		/// Gets or sets the PhoneNo value.
		/// </summary>
		private string _phoneNo=String.Empty;
		public string PhoneNo
		{
			get { return  _phoneNo; }
			set { _phoneNo = value; }
		}

		/// <summary>
		/// Gets or sets the PatientVisitId value.
		/// </summary>
		private long _patientVisitId=0;
		public long PatientVisitId
		{
			get { return  _patientVisitId; }
			set { _patientVisitId = value; }
		}

		/// <summary>
		/// Gets or sets the SelectedEpisode value.
		/// </summary>
		private string _selectedEpisode=String.Empty;
		public string SelectedEpisode
		{
			get { return  _selectedEpisode; }
			set { _selectedEpisode = value; }
		}

		/// <summary>
		/// Gets or sets the EpisodeName value.
		/// </summary>
		private string _episodeName=String.Empty;
		public string EpisodeName
		{
			get { return  _episodeName; }
			set { _episodeName = value; }
		}

		/// <summary>
		/// Gets or sets the OrgAddressID value.
		/// </summary>
		private int _orgAddressID=0;
		public int OrgAddressID
		{
			get { return  _orgAddressID; }
			set { _orgAddressID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientNumber value.
		/// </summary>
		private string _patientNumber=String.Empty;
		public string PatientNumber
		{
			get { return  _patientNumber; }
			set { _patientNumber = value; }
		}

		/// <summary>
		/// Gets or sets the PictureName value.
		/// </summary>
		private string _pictureName=String.Empty;
		public string PictureName
		{
			get { return  _pictureName; }
			set { _pictureName = value; }
		}

		/// <summary>
		/// Gets or sets the RateID value.
		/// </summary>
		private int _rateID=0;
		public int RateID
		{
			get { return  _rateID; }
			set { _rateID = value; }
		}

		/// <summary>
		/// Gets or sets the TPAID value.
		/// </summary>
		private int _tPAID=0;
		public int TPAID
		{
			get { return  _tPAID; }
			set { _tPAID = value; }
		}

		/// <summary>
		/// Gets or sets the ClientID value.
		/// </summary>
		private long _clientID=0;
		public long ClientID
		{
			get { return  _clientID; }
			set { _clientID = value; }
		}


		#endregion
}
}
