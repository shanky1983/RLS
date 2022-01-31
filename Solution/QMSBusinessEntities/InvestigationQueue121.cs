using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class InvestigationQueue121
	{
		#region Fields

		private long testID=0;
		private long visitID=0;
		private string uID=String.Empty;
		private int orgID=0;
		private long investigationID=0;
		private string type=String.Empty;
		private string status=String.Empty;
		private string orderedUID=String.Empty;
		private long accessionNumber=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private string isReportable=String.Empty;
		private string isBillable=String.Empty;
		private string parentName=String.Empty;
		private int parentInvId=0;
		private string billableStatus=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the TestID value.
		/// </summary>
		public long TestID
		{
			get { return testID; }
			set { testID = value; }
		}

		/// <summary>
		/// Gets or sets the VisitID value.
		/// </summary>
		public long VisitID
		{
			get { return visitID; }
			set { visitID = value; }
		}

		/// <summary>
		/// Gets or sets the UID value.
		/// </summary>
		public string UID
		{
			get { return uID; }
			set { uID = value; }
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
		/// Gets or sets the InvestigationID value.
		/// </summary>
		public long InvestigationID
		{
			get { return investigationID; }
			set { investigationID = value; }
		}

		/// <summary>
		/// Gets or sets the Type value.
		/// </summary>
		public string Type
		{
			get { return type; }
			set { type = value; }
		}

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the OrderedUID value.
		/// </summary>
		public string OrderedUID
		{
			get { return orderedUID; }
			set { orderedUID = value; }
		}

		/// <summary>
		/// Gets or sets the AccessionNumber value.
		/// </summary>
		public long AccessionNumber
		{
			get { return accessionNumber; }
			set { accessionNumber = value; }
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

		/// <summary>
		/// Gets or sets the IsReportable value.
		/// </summary>
		public string IsReportable
		{
			get { return isReportable; }
			set { isReportable = value; }
		}

		/// <summary>
		/// Gets or sets the IsBillable value.
		/// </summary>
		public string IsBillable
		{
			get { return isBillable; }
			set { isBillable = value; }
		}

		/// <summary>
		/// Gets or sets the ParentName value.
		/// </summary>
		public string ParentName
		{
			get { return parentName; }
			set { parentName = value; }
		}

		/// <summary>
		/// Gets or sets the ParentInvId value.
		/// </summary>
		public int ParentInvId
		{
			get { return parentInvId; }
			set { parentInvId = value; }
		}

		/// <summary>
		/// Gets or sets the BillableStatus value.
		/// </summary>
		public string BillableStatus
		{
			get { return billableStatus; }
			set { billableStatus = value; }
		}


		#endregion
}
}
