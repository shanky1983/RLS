using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InvOrgInterpretationMapping
	{
		#region Fields

		private long iD=0;
		private int orgID=0;
		private long identityID=0;
		private string identityType=String.Empty;
		private string gender=String.Empty;
		private string interpretation=String.Empty;
		private string isActive=String.Empty;
		private int ageFrom=0;
		private int ageTo=0;
		private string ageOperator=String.Empty;
		private int clientID=0;
		private DateTime createdAt=DateTime.MaxValue;
		private DateTime modifyAt=DateTime.MaxValue;
		private long modifyBy=0;
		private long createdBy=0;
		private string valueTo=String.Empty;
		private string valueFrom=String.Empty;
		private string speciesType=String.Empty;
		private string ageType=String.Empty;
		private string editer1=String.Empty;
		private string editer2=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public long ID
		{
			get { return iD; }
			set { iD = value; }
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
		/// Gets or sets the IdentityID value.
		/// </summary>
		public long IdentityID
		{
			get { return identityID; }
			set { identityID = value; }
		}

		/// <summary>
		/// Gets or sets the IdentityType value.
		/// </summary>
		public string IdentityType
		{
			get { return identityType; }
			set { identityType = value; }
		}

		/// <summary>
		/// Gets or sets the Gender value.
		/// </summary>
		public string Gender
		{
			get { return gender; }
			set { gender = value; }
		}

		/// <summary>
		/// Gets or sets the Interpretation value.
		/// </summary>
		public string Interpretation
		{
			get { return interpretation; }
			set { interpretation = value; }
		}

		/// <summary>
		/// Gets or sets the IsActive value.
		/// </summary>
		public string IsActive
		{
			get { return isActive; }
			set { isActive = value; }
		}

		/// <summary>
		/// Gets or sets the AgeFrom value.
		/// </summary>
		public int AgeFrom
		{
			get { return ageFrom; }
			set { ageFrom = value; }
		}

		/// <summary>
		/// Gets or sets the AgeTo value.
		/// </summary>
		public int AgeTo
		{
			get { return ageTo; }
			set { ageTo = value; }
		}

		/// <summary>
		/// Gets or sets the AgeOperator value.
		/// </summary>
		public string AgeOperator
		{
			get { return ageOperator; }
			set { ageOperator = value; }
		}

		/// <summary>
		/// Gets or sets the ClientID value.
		/// </summary>
		public int ClientID
		{
			get { return clientID; }
			set { clientID = value; }
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
		/// Gets or sets the ModifyAt value.
		/// </summary>
		public DateTime ModifyAt
		{
			get { return modifyAt; }
			set { modifyAt = value; }
		}

		/// <summary>
		/// Gets or sets the ModifyBy value.
		/// </summary>
		public long ModifyBy
		{
			get { return modifyBy; }
			set { modifyBy = value; }
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
		/// Gets or sets the ValueTo value.
		/// </summary>
		public string ValueTo
		{
			get { return valueTo; }
			set { valueTo = value; }
		}

		/// <summary>
		/// Gets or sets the ValueFrom value.
		/// </summary>
		public string ValueFrom
		{
			get { return valueFrom; }
			set { valueFrom = value; }
		}

		/// <summary>
		/// Gets or sets the SpeciesType value.
		/// </summary>
		public string SpeciesType
		{
			get { return speciesType; }
			set { speciesType = value; }
		}

		/// <summary>
		/// Gets or sets the AgeType value.
		/// </summary>
		public string AgeType
		{
			get { return ageType; }
			set { ageType = value; }
		}

		/// <summary>
		/// Gets or sets the Editer1 value.
		/// </summary>
		public string Editer1
		{
			get { return editer1; }
			set { editer1 = value; }
		}

		/// <summary>
		/// Gets or sets the Editer2 value.
		/// </summary>
		public string Editer2
		{
			get { return editer2; }
			set { editer2 = value; }
		}

		/// <summary>
		/// Gets or sets the GenderCode value.
		/// </summary>
		private string _genderCode=String.Empty;
		public string GenderCode
		{
			get { return  _genderCode; }
			set { _genderCode = value; }
		}


		#endregion
}
}
