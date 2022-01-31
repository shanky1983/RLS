using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ReportSnapshot
	{
		#region Fields

		private long iD=0;
		private byte[] content=new byte[0];
		private string templateID=String.Empty;
		private string status=String.Empty;
		private long visitID=0;
		private int orgID=0;
		private long orgAddressID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private string reportPath=String.Empty;
		private string accessionNumber=String.Empty;
		private int notificationID=0;
		private int seq_Num=0;
		private string type=String.Empty;
		private string hasChangedFolderPath=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public long ID
		{
			get { return iD; }
			set { iD = value; }
		}

		/// <summary>
		/// Gets or sets the Content value.
		/// </summary>
		public byte[] Content
		{
			get { return content; }
			set { content = value; }
		}

		/// <summary>
		/// Gets or sets the TemplateID value.
		/// </summary>
		public string TemplateID
		{
			get { return templateID; }
			set { templateID = value; }
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
		/// Gets or sets the VisitID value.
		/// </summary>
		public long VisitID
		{
			get { return visitID; }
			set { visitID = value; }
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
		/// Gets or sets the OrgAddressID value.
		/// </summary>
		public long OrgAddressID
		{
			get { return orgAddressID; }
			set { orgAddressID = value; }
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
		/// Gets or sets the ReportPath value.
		/// </summary>
		public string ReportPath
		{
			get { return reportPath; }
			set { reportPath = value; }
		}

		/// <summary>
		/// Gets or sets the AccessionNumber value.
		/// </summary>
		public string AccessionNumber
		{
			get { return accessionNumber; }
			set { accessionNumber = value; }
		}

		/// <summary>
		/// Gets or sets the NotificationID value.
		/// </summary>
		public int NotificationID
		{
			get { return notificationID; }
			set { notificationID = value; }
		}

		/// <summary>
		/// Gets or sets the Seq_Num value.
		/// </summary>
		public int Seq_Num
		{
			get { return seq_Num; }
			set { seq_Num = value; }
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
		/// Gets or sets the HasChangedFolderPath value.
		/// </summary>
		public string HasChangedFolderPath
		{
			get { return hasChangedFolderPath; }
			set { hasChangedFolderPath = value; }
		}


		#endregion
}
}
