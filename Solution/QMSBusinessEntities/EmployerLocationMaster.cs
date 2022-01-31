using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class EmployerLocationMaster
	{
		#region Fields

		private long employerLocationID=0;
		private string employerLocationText=String.Empty;
		private string employerLocationName=String.Empty;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the EmployerLocationID value.
		/// </summary>
		public long EmployerLocationID
		{
			get { return employerLocationID; }
			set { employerLocationID = value; }
		}

		/// <summary>
		/// Gets or sets the EmployerLocationText value.
		/// </summary>
		public string EmployerLocationText
		{
			get { return employerLocationText; }
			set { employerLocationText = value; }
		}

		/// <summary>
		/// Gets or sets the EmployerLocationName value.
		/// </summary>
		public string EmployerLocationName
		{
			get { return employerLocationName; }
			set { employerLocationName = value; }
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
