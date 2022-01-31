using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InvestigationDrugFamilyMaster
	{
		#region Fields

		private long familyId=0;
		private string familyname=String.Empty;
		private string familycode=String.Empty;
		private long orgid=0;
		private DateTime createdat=DateTime.MaxValue;
		private long createdby=0;
		private DateTime modifiedat=DateTime.MaxValue;
		private long modifiedby=0;
		private string langCode=String.Empty;
		private bool isactive=false;
        private string _Description = String.Empty;
		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the FamilyId value.
		/// </summary>
		public long FamilyId
		{
			get { return familyId; }
			set { familyId = value; }
		}

		/// <summary>
		/// Gets or sets the Familyname value.
		/// </summary>
		public string Familyname
		{
			get { return familyname; }
			set { familyname = value; }
		}

		/// <summary>
		/// Gets or sets the Familycode value.
		/// </summary>
		public string Familycode
		{
			get { return familycode; }
			set { familycode = value; }
		}

		/// <summary>
		/// Gets or sets the Orgid value.
		/// </summary>
		public long Orgid
		{
			get { return orgid; }
			set { orgid = value; }
		}

		/// <summary>
		/// Gets or sets the Createdat value.
		/// </summary>
		public DateTime Createdat
		{
			get { return createdat; }
			set { createdat = value; }
		}

		/// <summary>
		/// Gets or sets the Createdby value.
		/// </summary>
		public long Createdby
		{
			get { return createdby; }
			set { createdby = value; }
		}

		/// <summary>
		/// Gets or sets the Modifiedat value.
		/// </summary>
		public DateTime Modifiedat
		{
			get { return modifiedat; }
			set { modifiedat = value; }
		}

		/// <summary>
		/// Gets or sets the Modifiedby value.
		/// </summary>
		public long Modifiedby
		{
			get { return modifiedby; }
			set { modifiedby = value; }
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
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

		#endregion
}
}
