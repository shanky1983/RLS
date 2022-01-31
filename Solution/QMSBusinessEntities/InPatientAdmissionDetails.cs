using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class InPatientAdmissionDetails
	{
		#region Fields

		private long inPatientRegID=0;
		private long patientID=0;
		private long visitID=0;
		private long purposeOfAdmissionID=0;
		private int conditionOnAdmissionID=0;
		private string contactNo=String.Empty;
		private long primaryPhysicianID=0;
		private long consultingSurgeonID=0;
		private long specialityID=0;
		private bool medicallyInsured=false;
		private bool organDonation=false;
		private string accompaniedBy=String.Empty;
		private long relationshipID=0;
		private string relationContactNo=String.Empty;
		private int knowledgeOfServiceID=0;
		private string serviceProviderName=String.Empty;
		private string informationBy=String.Empty;
		private long patientDietSpecificationID=0;
		private string oxygenRequired=String.Empty;
		private int modeOfOxygenDeliveryID=0;
		private int rateOfDelivery=0;
		private string orientationProvided=String.Empty;
		private string verifyIdentification=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private DateTime admissionDate=DateTime.MaxValue;
		private long dutyOfficerID=0;
		private string notes=String.Empty;
		private string address=String.Empty;
		private string relationshipName=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the InPatientRegID value.
		/// </summary>
		public long InPatientRegID
		{
			get { return inPatientRegID; }
			set { inPatientRegID = value; }
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
		/// Gets or sets the VisitID value.
		/// </summary>
		public long VisitID
		{
			get { return visitID; }
			set { visitID = value; }
		}

		/// <summary>
		/// Gets or sets the PurposeOfAdmissionID value.
		/// </summary>
		public long PurposeOfAdmissionID
		{
			get { return purposeOfAdmissionID; }
			set { purposeOfAdmissionID = value; }
		}

		/// <summary>
		/// Gets or sets the ConditionOnAdmissionID value.
		/// </summary>
		public int ConditionOnAdmissionID
		{
			get { return conditionOnAdmissionID; }
			set { conditionOnAdmissionID = value; }
		}

		/// <summary>
		/// Gets or sets the ContactNo value.
		/// </summary>
		public string ContactNo
		{
			get { return contactNo; }
			set { contactNo = value; }
		}

		/// <summary>
		/// Gets or sets the PrimaryPhysicianID value.
		/// </summary>
		public long PrimaryPhysicianID
		{
			get { return primaryPhysicianID; }
			set { primaryPhysicianID = value; }
		}

		/// <summary>
		/// Gets or sets the ConsultingSurgeonID value.
		/// </summary>
		public long ConsultingSurgeonID
		{
			get { return consultingSurgeonID; }
			set { consultingSurgeonID = value; }
		}

		/// <summary>
		/// Gets or sets the SpecialityID value.
		/// </summary>
		public long SpecialityID
		{
			get { return specialityID; }
			set { specialityID = value; }
		}

		/// <summary>
		/// Gets or sets the MedicallyInsured value.
		/// </summary>
		public bool MedicallyInsured
		{
			get { return medicallyInsured; }
			set { medicallyInsured = value; }
		}

		/// <summary>
		/// Gets or sets the OrganDonation value.
		/// </summary>
		public bool OrganDonation
		{
			get { return organDonation; }
			set { organDonation = value; }
		}

		/// <summary>
		/// Gets or sets the AccompaniedBy value.
		/// </summary>
		public string AccompaniedBy
		{
			get { return accompaniedBy; }
			set { accompaniedBy = value; }
		}

		/// <summary>
		/// Gets or sets the RelationshipID value.
		/// </summary>
		public long RelationshipID
		{
			get { return relationshipID; }
			set { relationshipID = value; }
		}

		/// <summary>
		/// Gets or sets the RelationContactNo value.
		/// </summary>
		public string RelationContactNo
		{
			get { return relationContactNo; }
			set { relationContactNo = value; }
		}

		/// <summary>
		/// Gets or sets the KnowledgeOfServiceID value.
		/// </summary>
		public int KnowledgeOfServiceID
		{
			get { return knowledgeOfServiceID; }
			set { knowledgeOfServiceID = value; }
		}

		/// <summary>
		/// Gets or sets the ServiceProviderName value.
		/// </summary>
		public string ServiceProviderName
		{
			get { return serviceProviderName; }
			set { serviceProviderName = value; }
		}

		/// <summary>
		/// Gets or sets the InformationBy value.
		/// </summary>
		public string InformationBy
		{
			get { return informationBy; }
			set { informationBy = value; }
		}

		/// <summary>
		/// Gets or sets the PatientDietSpecificationID value.
		/// </summary>
		public long PatientDietSpecificationID
		{
			get { return patientDietSpecificationID; }
			set { patientDietSpecificationID = value; }
		}

		/// <summary>
		/// Gets or sets the OxygenRequired value.
		/// </summary>
		public string OxygenRequired
		{
			get { return oxygenRequired; }
			set { oxygenRequired = value; }
		}

		/// <summary>
		/// Gets or sets the ModeOfOxygenDeliveryID value.
		/// </summary>
		public int ModeOfOxygenDeliveryID
		{
			get { return modeOfOxygenDeliveryID; }
			set { modeOfOxygenDeliveryID = value; }
		}

		/// <summary>
		/// Gets or sets the RateOfDelivery value.
		/// </summary>
		public int RateOfDelivery
		{
			get { return rateOfDelivery; }
			set { rateOfDelivery = value; }
		}

		/// <summary>
		/// Gets or sets the OrientationProvided value.
		/// </summary>
		public string OrientationProvided
		{
			get { return orientationProvided; }
			set { orientationProvided = value; }
		}

		/// <summary>
		/// Gets or sets the VerifyIdentification value.
		/// </summary>
		public string VerifyIdentification
		{
			get { return verifyIdentification; }
			set { verifyIdentification = value; }
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
		/// Gets or sets the AdmissionDate value.
		/// </summary>
		public DateTime AdmissionDate
		{
			get { return admissionDate; }
			set { admissionDate = value; }
		}

		/// <summary>
		/// Gets or sets the DutyOfficerID value.
		/// </summary>
		public long DutyOfficerID
		{
			get { return dutyOfficerID; }
			set { dutyOfficerID = value; }
		}

		/// <summary>
		/// Gets or sets the Notes value.
		/// </summary>
		public string Notes
		{
			get { return notes; }
			set { notes = value; }
		}

		/// <summary>
		/// Gets or sets the Address value.
		/// </summary>
		public string Address
		{
			get { return address; }
			set { address = value; }
		}

		/// <summary>
		/// Gets or sets the RelationshipName value.
		/// </summary>
		public string RelationshipName
		{
			get { return relationshipName; }
			set { relationshipName = value; }
		}

		/// <summary>
		/// Gets or sets the PrimaryPhysicianName value.
		/// </summary>
		string _primaryphysicianname;
		public string PrimaryPhysicianName
		{
			get { return _primaryphysicianname; }
			set { _primaryphysicianname = value; }
		}

		/// <summary>
		/// Gets or sets the ConsultingSurgeonName value.
		/// </summary>
		string _consultingsurgeonname;
		public string ConsultingSurgeonName
		{
			get { return _consultingsurgeonname; }
			set { _consultingsurgeonname = value; }
		}

		/// <summary>
		/// Gets or sets the DutyOfficer value.
		/// </summary>
		string _dutyofficer;
		public string DutyOfficer
		{
			get { return _dutyofficer; }
			set { _dutyofficer = value; }
		}


		#endregion
}
}
