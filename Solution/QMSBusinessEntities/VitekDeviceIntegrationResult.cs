using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class VitekDeviceIntegrationResult
	{
		#region Fields

		private long iD=0;
		private long visitID=0;
		private int orgID=0;
		private int groupID=0;
		private long investigationID=0;
		private string deviceCode=String.Empty;
		private string barcode=String.Empty;
		private string organismCode=String.Empty;
		private string organismName=String.Empty;
		private string drugCode=String.Empty;
		private string drugName=String.Empty;
		private string sensitivity=String.Empty;
		private string micValue=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

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
		/// Gets or sets the GroupID value.
		/// </summary>
		public int GroupID
		{
			get { return groupID; }
			set { groupID = value; }
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
		/// Gets or sets the DeviceCode value.
		/// </summary>
		public string DeviceCode
		{
			get { return deviceCode; }
			set { deviceCode = value; }
		}

		/// <summary>
		/// Gets or sets the Barcode value.
		/// </summary>
		public string Barcode
		{
			get { return barcode; }
			set { barcode = value; }
		}

		/// <summary>
		/// Gets or sets the OrganismCode value.
		/// </summary>
		public string OrganismCode
		{
			get { return organismCode; }
			set { organismCode = value; }
		}

		/// <summary>
		/// Gets or sets the OrganismName value.
		/// </summary>
		public string OrganismName
		{
			get { return organismName; }
			set { organismName = value; }
		}

		/// <summary>
		/// Gets or sets the DrugCode value.
		/// </summary>
		public string DrugCode
		{
			get { return drugCode; }
			set { drugCode = value; }
		}

		/// <summary>
		/// Gets or sets the DrugName value.
		/// </summary>
		public string DrugName
		{
			get { return drugName; }
			set { drugName = value; }
		}

		/// <summary>
		/// Gets or sets the Sensitivity value.
		/// </summary>
		public string Sensitivity
		{
			get { return sensitivity; }
			set { sensitivity = value; }
		}

		/// <summary>
		/// Gets or sets the MicValue value.
		/// </summary>
		public string MicValue
		{
			get { return micValue; }
			set { micValue = value; }
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
