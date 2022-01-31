using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class OTRequest
	{
		#region Fields

		private long iD=0;
		private long patientID=0;
		private string patientType=String.Empty;
		private long visitID=0;
		private long primaryPhysicianID=0;
		private long preferredOTID=0;
		private string priority=String.Empty;
		private DateTime requestedAt=DateTime.MaxValue;
		private long requestedBy=0;
		private bool isProvisional=false;
		private bool isActive=false;
		private DateTime createdat=DateTime.MaxValue;
		private long createdby=0;
		private DateTime modifiedat=DateTime.MaxValue;
		private long modifiedby=0;
		private long orgID=0;
		private DateTime oTStartTime=DateTime.MaxValue;
		private DateTime oTEndTime=DateTime.MaxValue;
		private string currentStatus=String.Empty;
		private string oTReqNumber=String.Empty;
		private DateTime actSurEndTime=DateTime.MaxValue;
		private DateTime actSurStartTime=DateTime.MaxValue;

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
		/// Gets or sets the PatientID value.
		/// </summary>
		public long PatientID
		{
			get { return patientID; }
			set { patientID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientType value.
		/// </summary>
		public string PatientType
		{
			get { return patientType; }
			set { patientType = value; }
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
		/// Gets or sets the PrimaryPhysicianID value.
		/// </summary>
		public long PrimaryPhysicianID
		{
			get { return primaryPhysicianID; }
			set { primaryPhysicianID = value; }
		}

		/// <summary>
		/// Gets or sets the PreferredOTID value.
		/// </summary>
		public long PreferredOTID
		{
			get { return preferredOTID; }
			set { preferredOTID = value; }
		}

		/// <summary>
		/// Gets or sets the Priority value.
		/// </summary>
		public string Priority
		{
			get { return priority; }
			set { priority = value; }
		}

		/// <summary>
		/// Gets or sets the RequestedAt value.
		/// </summary>
		public DateTime RequestedAt
		{
			get { return requestedAt; }
			set { requestedAt = value; }
		}

		/// <summary>
		/// Gets or sets the RequestedBy value.
		/// </summary>
		public long RequestedBy
		{
			get { return requestedBy; }
			set { requestedBy = value; }
		}

		/// <summary>
		/// Gets or sets the IsProvisional value.
		/// </summary>
		public bool IsProvisional
		{
			get { return isProvisional; }
			set { isProvisional = value; }
		}

		/// <summary>
		/// Gets or sets the IsActive value.
		/// </summary>
		public bool IsActive
		{
			get { return isActive; }
			set { isActive = value; }
		}

		/// <summary>
		/// Gets or sets the Createdat value.
		/// </summary>
		public DateTime Createdat
		{
			get { return createdat; }
			set { createdat = value; }
		}

		/// <summary>
		/// Gets or sets the Createdby value.
		/// </summary>
		public long Createdby
		{
			get { return createdby; }
			set { createdby = value; }
		}

		/// <summary>
		/// Gets or sets the Modifiedat value.
		/// </summary>
		public DateTime Modifiedat
		{
			get { return modifiedat; }
			set { modifiedat = value; }
		}

		/// <summary>
		/// Gets or sets the Modifiedby value.
		/// </summary>
		public long Modifiedby
		{
			get { return modifiedby; }
			set { modifiedby = value; }
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
		/// Gets or sets the OTStartTime value.
		/// </summary>
		public DateTime OTStartTime
		{
			get { return oTStartTime; }
			set { oTStartTime = value; }
		}

		/// <summary>
		/// Gets or sets the OTEndTime value.
		/// </summary>
		public DateTime OTEndTime
		{
			get { return oTEndTime; }
			set { oTEndTime = value; }
		}

		/// <summary>
		/// Gets or sets the CurrentStatus value.
		/// </summary>
		public string CurrentStatus
		{
			get { return currentStatus; }
			set { currentStatus = value; }
		}

		/// <summary>
		/// Gets or sets the OTReqNumber value.
		/// </summary>
		public string OTReqNumber
		{
			get { return oTReqNumber; }
			set { oTReqNumber = value; }
		}

		/// <summary>
		/// Gets or sets the ActSurEndTime value.
		/// </summary>
		public DateTime ActSurEndTime
		{
			get { return actSurEndTime; }
			set { actSurEndTime = value; }
		}

		/// <summary>
		/// Gets or sets the ActSurStartTime value.
		/// </summary>
		public DateTime ActSurStartTime
		{
			get { return actSurStartTime; }
			set { actSurStartTime = value; }
		}


		#endregion
}
}
