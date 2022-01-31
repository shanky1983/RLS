using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Species
	{
		#region Fields

		private int speciesID=0;
		private string speciesName=String.Empty;
		private string speciesCode=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the SpeciesID value.
		/// </summary>
		public int SpeciesID
		{
			get { return speciesID; }
			set { speciesID = value; }
		}

		/// <summary>
		/// Gets or sets the SpeciesName value.
		/// </summary>
		public string SpeciesName
		{
			get { return speciesName; }
			set { speciesName = value; }
		}

		/// <summary>
		/// Gets or sets the SpeciesCode value.
		/// </summary>
		public string SpeciesCode
		{
			get { return speciesCode; }
			set { speciesCode = value; }
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
