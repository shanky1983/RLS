using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class DEVICEINTEGRATIONORGMAPPING_healthplus_06_12
	{
		#region Fields

		private string deviceID=String.Empty;
		private string testCode=String.Empty;
		private long investigationID=0;
		private long orgID=0;
		private string testAttributes=String.Empty;
		private long deviceMappingID=0;
		private string referenceType=String.Empty;
		private long instrumentID=0;
		private string formula=String.Empty;
		private string abnormal=String.Empty;
		private string isActive=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private string reportPath=String.Empty;
		private string accessionNumber=String.Empty;
		private string methodName=String.Empty;
		private string isUpload=String.Empty;
		private string isDownload=String.Empty;
		private int locationID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DeviceID value.
		/// </summary>
		public string DeviceID
		{
			get { return deviceID; }
			set { deviceID = value; }
		}

		/// <summary>
		/// Gets or sets the TestCode value.
		/// </summary>
		public string TestCode
		{
			get { return testCode; }
			set { testCode = value; }
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
		public long OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the TestAttributes value.
		/// </summary>
		public string TestAttributes
		{
			get { return testAttributes; }
			set { testAttributes = value; }
		}

		/// <summary>
		/// Gets or sets the DeviceMappingID value.
		/// </summary>
		public long DeviceMappingID
		{
			get { return deviceMappingID; }
			set { deviceMappingID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceType value.
		/// </summary>
		public string ReferenceType
		{
			get { return referenceType; }
			set { referenceType = value; }
		}

		/// <summary>
		/// Gets or sets the InstrumentID value.
		/// </summary>
		public long InstrumentID
		{
			get { return instrumentID; }
			set { instrumentID = value; }
		}

		/// <summary>
		/// Gets or sets the Formula value.
		/// </summary>
		public string Formula
		{
			get { return formula; }
			set { formula = value; }
		}

		/// <summary>
		/// Gets or sets the Abnormal value.
		/// </summary>
		public string Abnormal
		{
			get { return abnormal; }
			set { abnormal = value; }
		}

		/// <summary>
		/// Gets or sets the IsActive value.
		/// </summary>
		public string IsActive
		{
			get { return isActive; }
			set { isActive = value; }
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
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
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
		/// Gets or sets the MethodName value.
		/// </summary>
		public string MethodName
		{
			get { return methodName; }
			set { methodName = value; }
		}

		/// <summary>
		/// Gets or sets the IsUpload value.
		/// </summary>
		public string IsUpload
		{
			get { return isUpload; }
			set { isUpload = value; }
		}

		/// <summary>
		/// Gets or sets the IsDownload value.
		/// </summary>
		public string IsDownload
		{
			get { return isDownload; }
			set { isDownload = value; }
		}

		/// <summary>
		/// Gets or sets the LocationID value.
		/// </summary>
		public int LocationID
		{
			get { return locationID; }
			set { locationID = value; }
		}


		#endregion
}
}
