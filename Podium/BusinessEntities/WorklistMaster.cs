using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class WorklistMaster
	{
		#region Fields

		private int wMID=0;
		private int worklistId=0;
		private string worklistType=String.Empty;
		private int worklistTypeId=0;
		private DateTime fromdate=DateTime.MaxValue;
		private DateTime toDate=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int orgId=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the WMID value.
		/// </summary>
		public int WMID
		{
			get { return wMID; }
			set { wMID = value; }
		}

		/// <summary>
		/// Gets or sets the WorklistId value.
		/// </summary>
		public int WorklistId
		{
			get { return worklistId; }
			set { worklistId = value; }
		}

		/// <summary>
		/// Gets or sets the WorklistType value.
		/// </summary>
		public string WorklistType
		{
			get { return worklistType; }
			set { worklistType = value; }
		}

		/// <summary>
		/// Gets or sets the WorklistTypeId value.
		/// </summary>
		public int WorklistTypeId
		{
			get { return worklistTypeId; }
			set { worklistTypeId = value; }
		}

		/// <summary>
		/// Gets or sets the Fromdate value.
		/// </summary>
		public DateTime Fromdate
		{
			get { return fromdate; }
			set { fromdate = value; }
		}

		/// <summary>
		/// Gets or sets the ToDate value.
		/// </summary>
		public DateTime ToDate
		{
			get { return toDate; }
			set { toDate = value; }
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
		/// Gets or sets the OrgId value.
		/// </summary>
		public int OrgId
		{
			get { return orgId; }
			set { orgId = value; }
		}

		/// <summary>
		/// Gets or sets the Name value.
		/// </summary>
		private string _name=String.Empty;
		public string Name
		{
			get { return  _name; }
			set { _name = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationName value.
		/// </summary>
		private string _investigationName=String.Empty;
		public string InvestigationName
		{
			get { return  _investigationName; }
			set { _investigationName = value; }
		}


		#endregion
}
}
