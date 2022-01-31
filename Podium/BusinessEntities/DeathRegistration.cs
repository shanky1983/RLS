using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class DeathRegistration
	{
		#region Fields

		private long deathRegistrationID=0;
		private long patientVisitID=0;
		private int orgID=0;
		private DateTime dOD=DateTime.MaxValue;
		private long placeOfDeathID=0;
		private string placeOfDeathDes=String.Empty;
		private long deathTypeID=0;
		private string deathTypeDes=String.Empty;
		private string isPregnancy=String.Empty;
		private string pregnancyStatus=String.Empty;
		private string pregnancyDescription=String.Empty;
		private string isResuscitation=String.Empty;
		private long lifeSupportID=0;
		private string isROSC=String.Empty;
		private string roscDescription=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string procedureDesc=String.Empty;
		private string hospitalCourse=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DeathRegistrationID value.
		/// </summary>
		public long DeathRegistrationID
		{
			get { return deathRegistrationID; }
			set { deathRegistrationID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientVisitID value.
		/// </summary>
		public long PatientVisitID
		{
			get { return patientVisitID; }
			set { patientVisitID = value; }
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
		/// Gets or sets the DOD value.
		/// </summary>
		public DateTime DOD
		{
			get { return dOD; }
			set { dOD = value; }
		}

		/// <summary>
		/// Gets or sets the PlaceOfDeathID value.
		/// </summary>
		public long PlaceOfDeathID
		{
			get { return placeOfDeathID; }
			set { placeOfDeathID = value; }
		}

		/// <summary>
		/// Gets or sets the PlaceOfDeathDes value.
		/// </summary>
		public string PlaceOfDeathDes
		{
			get { return placeOfDeathDes; }
			set { placeOfDeathDes = value; }
		}

		/// <summary>
		/// Gets or sets the DeathTypeID value.
		/// </summary>
		public long DeathTypeID
		{
			get { return deathTypeID; }
			set { deathTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the DeathTypeDes value.
		/// </summary>
		public string DeathTypeDes
		{
			get { return deathTypeDes; }
			set { deathTypeDes = value; }
		}

		/// <summary>
		/// Gets or sets the IsPregnancy value.
		/// </summary>
		public string IsPregnancy
		{
			get { return isPregnancy; }
			set { isPregnancy = value; }
		}

		/// <summary>
		/// Gets or sets the PregnancyStatus value.
		/// </summary>
		public string PregnancyStatus
		{
			get { return pregnancyStatus; }
			set { pregnancyStatus = value; }
		}

		/// <summary>
		/// Gets or sets the PregnancyDescription value.
		/// </summary>
		public string PregnancyDescription
		{
			get { return pregnancyDescription; }
			set { pregnancyDescription = value; }
		}

		/// <summary>
		/// Gets or sets the IsResuscitation value.
		/// </summary>
		public string IsResuscitation
		{
			get { return isResuscitation; }
			set { isResuscitation = value; }
		}

		/// <summary>
		/// Gets or sets the LifeSupportID value.
		/// </summary>
		public long LifeSupportID
		{
			get { return lifeSupportID; }
			set { lifeSupportID = value; }
		}

		/// <summary>
		/// Gets or sets the IsROSC value.
		/// </summary>
		public string IsROSC
		{
			get { return isROSC; }
			set { isROSC = value; }
		}

		/// <summary>
		/// Gets or sets the RoscDescription value.
		/// </summary>
		public string RoscDescription
		{
			get { return roscDescription; }
			set { roscDescription = value; }
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
		/// Gets or sets the ProcedureDesc value.
		/// </summary>
		public string ProcedureDesc
		{
			get { return procedureDesc; }
			set { procedureDesc = value; }
		}

		/// <summary>
		/// Gets or sets the HospitalCourse value.
		/// </summary>
		public string HospitalCourse
		{
			get { return hospitalCourse; }
			set { hospitalCourse = value; }
		}

		/// <summary>
		/// Gets or sets the PlaceName value.
		/// </summary>
		private string _placeName=String.Empty;
		public string PlaceName
		{
			get { return  _placeName; }
			set { _placeName = value; }
		}

		/// <summary>
		/// Gets or sets the DeathTypeName value.
		/// </summary>
		private string _deathTypeName=String.Empty;
		public string DeathTypeName
		{
			get { return  _deathTypeName; }
			set { _deathTypeName = value; }
		}

		/// <summary>
		/// Gets or sets the LifeSupportName value.
		/// </summary>
		private string _lifeSupportName=String.Empty;
		public string LifeSupportName
		{
			get { return  _lifeSupportName; }
			set { _lifeSupportName = value; }
		}


		#endregion
}
}
