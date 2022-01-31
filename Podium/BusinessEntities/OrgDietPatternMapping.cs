using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class OrgDietPatternMapping
	{
		#region Fields

		private long orgDietPatternMappingID=0;
		private int dietPatternID=0;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the OrgDietPatternMappingID value.
		/// </summary>
		public long OrgDietPatternMappingID
		{
			get { return orgDietPatternMappingID; }
			set { orgDietPatternMappingID = value; }
		}

		/// <summary>
		/// Gets or sets the DietPatternID value.
		/// </summary>
		public int DietPatternID
		{
			get { return dietPatternID; }
			set { dietPatternID = value; }
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

		/// <summary>
		/// Gets or sets the DietPatternName value.
		/// </summary>
		private string _dietPatternName=String.Empty;
		public string DietPatternName
		{
			get { return  _dietPatternName; }
			set { _dietPatternName = value; }
		}


		#endregion
}
}
