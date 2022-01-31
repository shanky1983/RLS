using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class MLNOMaster
	{
		#region Fields

		private long orgID=0;
		private long mLNumber=0;
		private int rowid=0;
		private long sectionID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public long OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the MLNumber value.
		/// </summary>
		public long MLNumber
		{
			get { return mLNumber; }
			set { mLNumber = value; }
		}

		/// <summary>
		/// Gets or sets the Rowid value.
		/// </summary>
		public int Rowid
		{
			get { return rowid; }
			set { rowid = value; }
		}

		/// <summary>
		/// Gets or sets the SectionID value.
		/// </summary>
		public long SectionID
		{
			get { return sectionID; }
			set { sectionID = value; }
		}


		#endregion
}
}
