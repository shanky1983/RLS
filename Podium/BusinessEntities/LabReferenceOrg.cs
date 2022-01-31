using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class LabReferenceOrg
	{
		#region Fields

		private long labRefOrgID=0;
		private string refOrgName=String.Empty;
		private int clientTypeID=0;
		private int orgID=0;
		private string status=String.Empty;
		private string code=String.Empty;
		private string isClient=String.Empty;
		private string referringType=String.Empty;
		private long contactPersonID=0;
		private string folderName=String.Empty;
		private string contactPersonName=String.Empty;
		private string contactPersonTypeID=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the LabRefOrgID value.
		/// </summary>
		public long LabRefOrgID
		{
			get { return labRefOrgID; }
			set { labRefOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the RefOrgName value.
		/// </summary>
		public string RefOrgName
		{
			get { return refOrgName; }
			set { refOrgName = value; }
		}

		/// <summary>
		/// Gets or sets the ClientTypeID value.
		/// </summary>
		public int ClientTypeID
		{
			get { return clientTypeID; }
			set { clientTypeID = value; }
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
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the Code value.
		/// </summary>
		public string Code
		{
			get { return code; }
			set { code = value; }
		}

		/// <summary>
		/// Gets or sets the IsClient value.
		/// </summary>
		public string IsClient
		{
			get { return isClient; }
			set { isClient = value; }
		}

		/// <summary>
		/// Gets or sets the ReferringType value.
		/// </summary>
		public string ReferringType
		{
			get { return referringType; }
			set { referringType = value; }
		}

		/// <summary>
		/// Gets or sets the ContactPersonID value.
		/// </summary>
		public long ContactPersonID
		{
			get { return contactPersonID; }
			set { contactPersonID = value; }
		}

		/// <summary>
		/// Gets or sets the FolderName value.
		/// </summary>
		public string FolderName
		{
			get { return folderName; }
			set { folderName = value; }
		}

		/// <summary>
		/// Gets or sets the ContactPersonName value.
		/// </summary>
		public string ContactPersonName
		{
			get { return contactPersonName; }
			set { contactPersonName = value; }
		}

		/// <summary>
		/// Gets or sets the ContactPersonTypeID value.
		/// </summary>
		public string ContactPersonTypeID
		{
			get { return contactPersonTypeID; }
			set { contactPersonTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the RefOrgNameWithAddress value.
		/// </summary>
		private string _refOrgNameWithAddress=String.Empty;
		public string RefOrgNameWithAddress
		{
			get { return  _refOrgNameWithAddress; }
			set { _refOrgNameWithAddress = value; }
		}

		/// <summary>
		/// Gets or sets the RateId value.
		/// </summary>
		private int _rateId=0;
		public int RateId
		{
			get { return  _rateId; }
			set { _rateId = value; }
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
		/// Gets or sets the IsAllMedical value.
		/// </summary>
		private string _isAllMedical=String.Empty;
		public string IsAllMedical
		{
			get { return  _isAllMedical; }
			set { _isAllMedical = value; }
		}


		#endregion
}
}
