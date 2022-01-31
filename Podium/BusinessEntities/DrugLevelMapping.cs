using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class DrugLevelMapping
	{
		#region Fields

		private long levelID=0;
		private string levelName=String.Empty;
        private string drugName = String.Empty;
        private string brandName = String.Empty;
		private long drugID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private bool isActive=true;
		private int orgID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the LevelID value.
		/// </summary>
		public long LevelID
		{
			get { return levelID; }
			set { levelID = value; }
		}

		/// <summary>
		/// Gets or sets the LevelName value.
		/// </summary>
		public string LevelName
		{
			get { return levelName; }
			set { levelName = value; }
		}
        public string DrugName
        {
            get { return drugName; }
            set { drugName = value; }
        }
        public string BrandName
        {
            get { return brandName; }
            set { brandName = value; }
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


		#endregion
}
}
