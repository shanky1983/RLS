using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ClinicalEvaluationMaster
	{
		#region Fields

		private int clinicalEvaluationMasterID=0;
		private int orgID=0;
		private int evaluationType=0;
		private string evaluationName=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string cSSClass=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ClinicalEvaluationMasterID value.
		/// </summary>
		public int ClinicalEvaluationMasterID
		{
			get { return clinicalEvaluationMasterID; }
			set { clinicalEvaluationMasterID = value; }
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
		/// Gets or sets the EvaluationType value.
		/// </summary>
		public int EvaluationType
		{
			get { return evaluationType; }
			set { evaluationType = value; }
		}

		/// <summary>
		/// Gets or sets the EvaluationName value.
		/// </summary>
		public string EvaluationName
		{
			get { return evaluationName; }
			set { evaluationName = value; }
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
		/// Gets or sets the CSSClass value.
		/// </summary>
		public string CSSClass
		{
			get { return cSSClass; }
			set { cSSClass = value; }
		}


		#endregion
}
}
