using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Invclientmaster_healthplus_30_12
	{
		#region Fields

		private long clientID=0;
		private long orgID=0;
		private string clientName=String.Empty;
		private int clientTypeID=0;
		private string type=String.Empty;
		private string activeYN=String.Empty;
		private string status=String.Empty;
		private int rateTypeId=0;
		private int rateId=0;
		private string clientAttributes=String.Empty;
		private string isAllMedical=String.Empty;
		private DateTime validFrom=DateTime.MaxValue;
		private DateTime validTo=DateTime.MaxValue;
		private int priority=0;
		private long clientMappingDetailsID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private TimeSpan validFromTime=TimeSpan.MinValue;
		private TimeSpan validToTime=TimeSpan.MinValue;
		private string transferRate=String.Empty;
		private string baseRate=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ClientID value.
		/// </summary>
		public long ClientID
		{
			get { return clientID; }
			set { clientID = value; }
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
		/// Gets or sets the ClientName value.
		/// </summary>
		public string ClientName
		{
			get { return clientName; }
			set { clientName = value; }
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
		/// Gets or sets the Type value.
		/// </summary>
		public string Type
		{
			get { return type; }
			set { type = value; }
		}

		/// <summary>
		/// Gets or sets the ActiveYN value.
		/// </summary>
		public string ActiveYN
		{
			get { return activeYN; }
			set { activeYN = value; }
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
		/// Gets or sets the RateTypeId value.
		/// </summary>
		public int RateTypeId
		{
			get { return rateTypeId; }
			set { rateTypeId = value; }
		}

		/// <summary>
		/// Gets or sets the RateId value.
		/// </summary>
		public int RateId
		{
			get { return rateId; }
			set { rateId = value; }
		}

		/// <summary>
		/// Gets or sets the ClientAttributes value.
		/// </summary>
		public string ClientAttributes
		{
			get { return clientAttributes; }
			set { clientAttributes = value; }
		}

		/// <summary>
		/// Gets or sets the IsAllMedical value.
		/// </summary>
		public string IsAllMedical
		{
			get { return isAllMedical; }
			set { isAllMedical = value; }
		}

		/// <summary>
		/// Gets or sets the ValidFrom value.
		/// </summary>
		public DateTime ValidFrom
		{
			get { return validFrom; }
			set { validFrom = value; }
		}

		/// <summary>
		/// Gets or sets the ValidTo value.
		/// </summary>
		public DateTime ValidTo
		{
			get { return validTo; }
			set { validTo = value; }
		}

		/// <summary>
		/// Gets or sets the Priority value.
		/// </summary>
		public int Priority
		{
			get { return priority; }
			set { priority = value; }
		}

		/// <summary>
		/// Gets or sets the ClientMappingDetailsID value.
		/// </summary>
		public long ClientMappingDetailsID
		{
			get { return clientMappingDetailsID; }
			set { clientMappingDetailsID = value; }
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
		/// Gets or sets the ValidFromTime value.
		/// </summary>
		public TimeSpan ValidFromTime
		{
			get { return validFromTime; }
			set { validFromTime = value; }
		}

		/// <summary>
		/// Gets or sets the ValidToTime value.
		/// </summary>
		public TimeSpan ValidToTime
		{
			get { return validToTime; }
			set { validToTime = value; }
		}

		/// <summary>
		/// Gets or sets the TransferRate value.
		/// </summary>
		public string TransferRate
		{
			get { return transferRate; }
			set { transferRate = value; }
		}

		/// <summary>
		/// Gets or sets the BaseRate value.
		/// </summary>
		public string BaseRate
		{
			get { return baseRate; }
			set { baseRate = value; }
		}


		#endregion
}
}
