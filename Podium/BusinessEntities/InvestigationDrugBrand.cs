using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InvestigationDrugBrand
	{
		#region Fields

		private long drugID=0;
		private long genericID=0;
		private string brandName=String.Empty;
		private string strength=String.Empty;
		private string availableDose=String.Empty;
        private long fMID = 0;
		private string isApproved=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int orgID=0;
		private string code=String.Empty;
		private string langCode=String.Empty;
		private bool isactive=true;
        /* BEGIN | sabari | 20181129 | Dev | Culture Report */
        private string familyName = String.Empty;
        private string _Description = String.Empty;
        /* END | sabari | 20181129 | Dev | Culture Report */
        #endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DrugID value.
		/// </summary>
		public long DrugID
		{
			get { return drugID; }
			set { drugID = value; }
		}

		/// <summary>
		/// Gets or sets the GenericID value.
		/// </summary>
		public long GenericID
		{
			get { return genericID; }
			set { genericID = value; }
		}

		/// <summary>
		/// Gets or sets the BrandName value.
		/// </summary>
		public string BrandName
		{
			get { return brandName; }
			set { brandName = value; }
		}

		/// <summary>
		/// Gets or sets the Strength value.
		/// </summary>
		public string Strength
		{
			get { return strength; }
			set { strength = value; }
		}

		/// <summary>
		/// Gets or sets the AvailableDose value.
		/// </summary>
		public string AvailableDose
		{
			get { return availableDose; }
			set { availableDose = value; }
		}

		/// <summary>
		/// Gets or sets the FMID value.
		/// </summary>
        public long FMID
		{
			get { return fMID; }
			set { fMID = value; }
		}

		/// <summary>
		/// Gets or sets the IsApproved value.
		/// </summary>
		public string IsApproved
		{
			get { return isApproved; }
			set { isApproved = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the Code value.
		/// </summary>
		public string Code
		{
			get { return code; }
			set { code = value; }
		}

		/// <summary>
		/// Gets or sets the LangCode value.
		/// </summary>
		public string LangCode
		{
			get { return langCode; }
			set { langCode = value; }
		}

		/// <summary>
		/// Gets or sets the Isactive value.
		/// </summary>
        public bool IsActive
		{
			get { return isactive; }
			set { isactive = value; }
		}

        
            /// <summary>
        /// Gets or sets the LoginName value.
		/// </summary>
        private string loginName = String.Empty;
        public string LoginName
		{
            get { return loginName; }
            set { loginName = value; }
		}
        /* BEGIN | sabari | 20181129 | Dev | Culture Report */
        public string FamilyName
        {
            get { return familyName; }
            set { familyName = value; }
        }
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        /* END | sabari | 20181129 | Dev | Culture Report */

		#endregion
}
}
