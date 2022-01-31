using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class OTReqSurgMapping
	{
		#region Fields

		private long iD=0;
		private long oTRequestID=0;
		private long surgeryMasterID=0;
		private string comments=String.Empty;
		private DateTime oTSurStartTime=DateTime.MaxValue;
		private DateTime oTSurEndTime=DateTime.MaxValue;
		private bool isActive=false;
		private DateTime createdat=DateTime.MaxValue;
		private long createdby=0;
		private DateTime modifiedat=DateTime.MaxValue;
		private long modifiedby=0;
		private long oTOperatingSiteID=0;

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
		/// Gets or sets the OTRequestID value.
		/// </summary>
		public long OTRequestID
		{
			get { return oTRequestID; }
			set { oTRequestID = value; }
		}

		/// <summary>
		/// Gets or sets the SurgeryMasterID value.
		/// </summary>
		public long SurgeryMasterID
		{
			get { return surgeryMasterID; }
			set { surgeryMasterID = value; }
		}

		/// <summary>
		/// Gets or sets the Comments value.
		/// </summary>
		public string Comments
		{
			get { return comments; }
			set { comments = value; }
		}

		/// <summary>
		/// Gets or sets the OTSurStartTime value.
		/// </summary>
		public DateTime OTSurStartTime
		{
			get { return oTSurStartTime; }
			set { oTSurStartTime = value; }
		}

		/// <summary>
		/// Gets or sets the OTSurEndTime value.
		/// </summary>
		public DateTime OTSurEndTime
		{
			get { return oTSurEndTime; }
			set { oTSurEndTime = value; }
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
		/// Gets or sets the OTOperatingSiteID value.
		/// </summary>
		public long OTOperatingSiteID
		{
			get { return oTOperatingSiteID; }
			set { oTOperatingSiteID = value; }
		}


		#endregion
}
}
