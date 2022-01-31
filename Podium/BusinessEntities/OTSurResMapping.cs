using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class OTSurResMapping
	{
		#region Fields

		private long iD=0;
		private long oTReqSurgMapID=0;
		private long resourceID=0;
		private int specialityID=0;
		private long oTRequestID=0;
		private bool isActive=false;
		private DateTime createdat=DateTime.MaxValue;
		private long createdby=0;
		private DateTime modifiedat=DateTime.MaxValue;
		private long modifiedby=0;
		private string resourceType=String.Empty;

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
		/// Gets or sets the OTReqSurgMapID value.
		/// </summary>
		public long OTReqSurgMapID
		{
			get { return oTReqSurgMapID; }
			set { oTReqSurgMapID = value; }
		}

		/// <summary>
		/// Gets or sets the ResourceID value.
		/// </summary>
		public long ResourceID
		{
			get { return resourceID; }
			set { resourceID = value; }
		}

		/// <summary>
		/// Gets or sets the SpecialityID value.
		/// </summary>
		public int SpecialityID
		{
			get { return specialityID; }
			set { specialityID = value; }
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
		/// Gets or sets the ResourceType value.
		/// </summary>
		public string ResourceType
		{
			get { return resourceType; }
			set { resourceType = value; }
		}


		#endregion
}
}
