using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ExternalEmployee
	{
		#region Fields

		private long externalID=0;
		private long patientID=0;
		private string externalNumber=String.Empty;
		private string externalTypeNumber=String.Empty;
		private int externalTypeID=0;
		private long relationPatientID=0;
		private long relationParentPatientID=0;
		private long relationExternalID=0;
		private string relationExternalNumber=String.Empty;
		private string relationType=String.Empty;
		private string relationShipType=String.Empty;
		private string relationShipSubType=String.Empty;
		private string relationNumber=String.Empty;
		private int relationNumIndicator=0;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ExternalID value.
		/// </summary>
		public long ExternalID
		{
			get { return externalID; }
			set { externalID = value; }
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
		/// Gets or sets the ExternalNumber value.
		/// </summary>
		public string ExternalNumber
		{
			get { return externalNumber; }
			set { externalNumber = value; }
		}

		/// <summary>
		/// Gets or sets the ExternalTypeNumber value.
		/// </summary>
		public string ExternalTypeNumber
		{
			get { return externalTypeNumber; }
			set { externalTypeNumber = value; }
		}

		/// <summary>
		/// Gets or sets the ExternalTypeID value.
		/// </summary>
		public int ExternalTypeID
		{
			get { return externalTypeID; }
			set { externalTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the RelationPatientID value.
		/// </summary>
		public long RelationPatientID
		{
			get { return relationPatientID; }
			set { relationPatientID = value; }
		}

		/// <summary>
		/// Gets or sets the RelationParentPatientID value.
		/// </summary>
		public long RelationParentPatientID
		{
			get { return relationParentPatientID; }
			set { relationParentPatientID = value; }
		}

		/// <summary>
		/// Gets or sets the RelationExternalID value.
		/// </summary>
		public long RelationExternalID
		{
			get { return relationExternalID; }
			set { relationExternalID = value; }
		}

		/// <summary>
		/// Gets or sets the RelationExternalNumber value.
		/// </summary>
		public string RelationExternalNumber
		{
			get { return relationExternalNumber; }
			set { relationExternalNumber = value; }
		}

		/// <summary>
		/// Gets or sets the RelationType value.
		/// </summary>
		public string RelationType
		{
			get { return relationType; }
			set { relationType = value; }
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
		/// Gets or sets the RelationNumber value.
		/// </summary>
		public string RelationNumber
		{
			get { return relationNumber; }
			set { relationNumber = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
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
