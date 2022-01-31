using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class CA_InvValues
	{
		#region Fields

		private long investigationValueID=0;
		private string name=String.Empty;
		private string valu=String.Empty;
		private long investigationID=0;
		private int groupID=0;
		private long patientVisitID=0;
		private string status=String.Empty;
		private string groupName=String.Empty;
		private int orgid=0;
		private int packageID=0;
		private string packageName=String.Empty;
		private string deviceID=String.Empty;
		private string deviceValue=String.Empty;
		private string deviceActualValue=String.Empty;
		private string cA_NUM=String.Empty;
		private string cA_ALPHA=String.Empty;
		private string cA_LOW=String.Empty;
		private string cA_HIGH=String.Empty;
		private string cA_TYPE=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the InvestigationValueID value.
		/// </summary>
		public long InvestigationValueID
		{
			get { return investigationValueID; }
			set { investigationValueID = value; }
		}

		/// <summary>
		/// Gets or sets the Name value.
		/// </summary>
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		/// <summary>
		/// Gets or sets the Valu value.
		/// </summary>
		public string Value
		{
			get { return valu; }
			set { valu = value; }
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
		/// Gets or sets the GroupID value.
		/// </summary>
		public int GroupID
		{
			get { return groupID; }
			set { groupID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientVisitID value.
		/// </summary>
		public long PatientVisitID
		{
			get { return patientVisitID; }
			set { patientVisitID = value; }
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
		/// Gets or sets the GroupName value.
		/// </summary>
		public string GroupName
		{
			get { return groupName; }
			set { groupName = value; }
		}

		/// <summary>
		/// Gets or sets the Orgid value.
		/// </summary>
		public int Orgid
		{
			get { return orgid; }
			set { orgid = value; }
		}

		/// <summary>
		/// Gets or sets the PackageID value.
		/// </summary>
		public int PackageID
		{
			get { return packageID; }
			set { packageID = value; }
		}

		/// <summary>
		/// Gets or sets the PackageName value.
		/// </summary>
		public string PackageName
		{
			get { return packageName; }
			set { packageName = value; }
		}

		/// <summary>
		/// Gets or sets the DeviceID value.
		/// </summary>
		public string DeviceID
		{
			get { return deviceID; }
			set { deviceID = value; }
		}

		/// <summary>
		/// Gets or sets the DeviceValue value.
		/// </summary>
		public string DeviceValue
		{
			get { return deviceValue; }
			set { deviceValue = value; }
		}

		/// <summary>
		/// Gets or sets the DeviceActualValue value.
		/// </summary>
		public string DeviceActualValue
		{
			get { return deviceActualValue; }
			set { deviceActualValue = value; }
		}

		/// <summary>
		/// Gets or sets the CA_NUM value.
		/// </summary>
		public string CA_NUM
		{
			get { return cA_NUM; }
			set { cA_NUM = value; }
		}

		/// <summary>
		/// Gets or sets the CA_ALPHA value.
		/// </summary>
		public string CA_ALPHA
		{
			get { return cA_ALPHA; }
			set { cA_ALPHA = value; }
		}

		/// <summary>
		/// Gets or sets the CA_LOW value.
		/// </summary>
		public string CA_LOW
		{
			get { return cA_LOW; }
			set { cA_LOW = value; }
		}

		/// <summary>
		/// Gets or sets the CA_HIGH value.
		/// </summary>
		public string CA_HIGH
		{
			get { return cA_HIGH; }
			set { cA_HIGH = value; }
		}

		/// <summary>
		/// Gets or sets the CA_TYPE value.
		/// </summary>
		public string CA_TYPE
		{
			get { return cA_TYPE; }
			set { cA_TYPE = value; }
		}


		#endregion
}
}
