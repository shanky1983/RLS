using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class InvestigationLocationMapping_History
	{
		#region Fields

		private long id=0;
		private long investigationID=0;
		private int orgID=0;
		private int locationID=0;
		private long processingOrgID=0;
		private int processingAddressID=0;
		private int type=0;
		private string feeType=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id value.
		/// </summary>
		public long Id
		{
			get { return id; }
			set { id = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the LocationID value.
		/// </summary>
		public int LocationID
		{
			get { return locationID; }
			set { locationID = value; }
		}

		/// <summary>
		/// Gets or sets the ProcessingOrgID value.
		/// </summary>
		public long ProcessingOrgID
		{
			get { return processingOrgID; }
			set { processingOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the ProcessingAddressID value.
		/// </summary>
		public int ProcessingAddressID
		{
			get { return processingAddressID; }
			set { processingAddressID = value; }
		}

		/// <summary>
		/// Gets or sets the Type value.
		/// </summary>
		public int Type
		{
			get { return type; }
			set { type = value; }
		}

		/// <summary>
		/// Gets or sets the FeeType value.
		/// </summary>
		public string FeeType
		{
			get { return feeType; }
			set { feeType = value; }
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
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public long CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
		}


		#endregion
}
}
