using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class PatientDietSpecification
	{
		#region Fields

		private long patientDietSpecificationID=0;
		private long orgDietTypeMappingID=0;
		private long orgDietPatternMappingID=0;
		private long orgDietPlanMappingID=0;
		private string fluidRestriction=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PatientDietSpecificationID value.
		/// </summary>
		public long PatientDietSpecificationID
		{
			get { return patientDietSpecificationID; }
			set { patientDietSpecificationID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgDietTypeMappingID value.
		/// </summary>
		public long OrgDietTypeMappingID
		{
			get { return orgDietTypeMappingID; }
			set { orgDietTypeMappingID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgDietPatternMappingID value.
		/// </summary>
		public long OrgDietPatternMappingID
		{
			get { return orgDietPatternMappingID; }
			set { orgDietPatternMappingID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgDietPlanMappingID value.
		/// </summary>
		public long OrgDietPlanMappingID
		{
			get { return orgDietPlanMappingID; }
			set { orgDietPlanMappingID = value; }
		}

		/// <summary>
		/// Gets or sets the FluidRestriction value.
		/// </summary>
		public string FluidRestriction
		{
			get { return fluidRestriction; }
			set { fluidRestriction = value; }
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


		#endregion
}
}
