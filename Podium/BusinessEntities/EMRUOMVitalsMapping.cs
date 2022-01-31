using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class EMRUOMVitalsMapping
	{
		#region Fields

		private int eMRUOMVitalsMappingID=0;
		private int orgID=0;
		private int uOMID=0;
		private int vitalsID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private bool status=false;
		private int specialityID=0;
		private int evaluationType=0;
		private int gender=0;
		private int age=0;
		private long clinicEvalTemplateID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the EMRUOMVitalsMappingID value.
		/// </summary>
		public int EMRUOMVitalsMappingID
		{
			get { return eMRUOMVitalsMappingID; }
			set { eMRUOMVitalsMappingID = value; }
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
		/// Gets or sets the UOMID value.
		/// </summary>
		public int UOMID
		{
			get { return uOMID; }
			set { uOMID = value; }
		}

		/// <summary>
		/// Gets or sets the VitalsID value.
		/// </summary>
		public int VitalsID
		{
			get { return vitalsID; }
			set { vitalsID = value; }
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
		/// Gets or sets the Status value.
		/// </summary>
		public bool Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the SpecialityID value.
		/// </summary>
		public int SpecialityID
		{
			get { return specialityID; }
			set { specialityID = value; }
		}

		/// <summary>
		/// Gets or sets the EvaluationType value.
		/// </summary>
		public int EvaluationType
		{
			get { return evaluationType; }
			set { evaluationType = value; }
		}

		/// <summary>
		/// Gets or sets the Gender value.
		/// </summary>
		public int Gender
		{
			get { return gender; }
			set { gender = value; }
		}

		/// <summary>
		/// Gets or sets the Age value.
		/// </summary>
		public int Age
		{
			get { return age; }
			set { age = value; }
		}

		/// <summary>
		/// Gets or sets the ClinicEvalTemplateID value.
		/// </summary>
		public long ClinicEvalTemplateID
		{
			get { return clinicEvalTemplateID; }
			set { clinicEvalTemplateID = value; }
		}


		#endregion
}
}
