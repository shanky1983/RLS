using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InvOrginterpretationMapping_History
	{
		#region Fields

		private long interpretationHistoryID=0;
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
		private long seqNo=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the InterpretationHistoryID value.
		/// </summary>
		public long InterpretationHistoryID
		{
			get { return interpretationHistoryID; }
			set { interpretationHistoryID = value; }
		}

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
		/// Gets or sets the SeqNo value.
		/// </summary>
		public long SeqNo
		{
			get { return seqNo; }
			set { seqNo = value; }
		}


		#endregion
}
}
