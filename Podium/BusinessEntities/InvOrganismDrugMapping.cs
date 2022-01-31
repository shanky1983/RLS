using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InvOrganismDrugMapping
	{
		#region Fields

		private long iD=0;
		private long investigationID=0;
		private long organismID=0;
		private long drugID=0;
		private int sequenceNo=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private bool isActive=true;
		private int orgID=0;

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
		/// Gets or sets the InvestigationID value.
		/// </summary>
		public long InvestigationID
		{
			get { return investigationID; }
			set { investigationID = value; }
		}

		/// <summary>
		/// Gets or sets the OrganismID value.
		/// </summary>
		public long OrganismID
		{
			get { return organismID; }
			set { organismID = value; }
		}

		/// <summary>
		/// Gets or sets the DrugID value.
		/// </summary>
		public long DrugID
		{
			get { return drugID; }
			set { drugID = value; }
		}

		/// <summary>
		/// Gets or sets the SequenceNo value.
		/// </summary>
		public int SequenceNo
		{
			get { return sequenceNo; }
			set { sequenceNo = value; }
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
		/// Gets or sets the IsActive value.
		/// </summary>
		public bool IsActive
		{
			get { return isActive; }
			set { isActive = value; }
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
		/// Gets or sets the OrganismName value.
		/// </summary>
		private string _organismName=String.Empty;
		public string OrganismName
		{
			get { return  _organismName; }
			set { _organismName = value; }
		}

		/// <summary>
		/// Gets or sets the OrganismCode value.
		/// </summary>
		private string _organismCode=String.Empty;
		public string OrganismCode
		{
			get { return  _organismCode; }
			set { _organismCode = value; }
		}

		/// <summary>
		/// Gets or sets the DrugName value.
		/// </summary>
		private string _drugName=String.Empty;
		public string DrugName
		{
			get { return  _drugName; }
			set { _drugName = value; }
		}

		/// <summary>
		/// Gets or sets the DrugCode value.
		/// </summary>
		private string _drugCode=String.Empty;
		public string DrugCode
		{
			get { return  _drugCode; }
			set { _drugCode = value; }
		}
        /* BEGIN | sabari | 20181129 | Dev | Culture Report */
        private string _investigationName = String.Empty;
        public string InvestigationName
        {
            get { return _investigationName; }
            set { _investigationName = value; }
        }
        /* END | sabari | 20181129 | Dev | Culture Report */

        // Start Added By Jayaramanan For Organism Master Screen
        private string susceptibility = String.Empty;
        public string Susceptibility
        {
            get { return susceptibility; }
            set { susceptibility = value; }
        }
        private string intermediate = String.Empty;
        public string Intermediate
        {
            get { return intermediate; }
            set { intermediate = value; }
        }
        private string resistant = String.Empty;
        public string Resistant
        {
            get { return resistant; }
            set { resistant = value; }
        }
        // End Organism Master Screen
		#endregion
}
}
