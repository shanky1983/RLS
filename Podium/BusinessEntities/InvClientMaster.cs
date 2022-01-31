using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InvClientMaster
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

		/// <summary>
		/// Gets or sets the RateName value.
		/// </summary>
		private string _rateName=String.Empty;
		public string RateName
		{
			get { return  _rateName; }
			set { _rateName = value; }
		}

		/// <summary>
		/// Gets or sets the RateTypeName value.
		/// </summary>
		private string _rateTypeName=String.Empty;
		public string RateTypeName
		{
			get { return  _rateTypeName; }
			set { _rateTypeName = value; }
		}

		/// <summary>
		/// Gets or sets the RecurrenceID value.
		/// </summary>
		private int _recurrenceID=0;
		public int RecurrenceID
		{
			get { return  _recurrenceID; }
			set { _recurrenceID = value; }
		}

		/// <summary>
		/// Gets or sets the ScheduleTemplateID value.
		/// </summary>
		private int _scheduleTemplateID=0;
		public int ScheduleTemplateID
		{
			get { return  _scheduleTemplateID; }
			set { _scheduleTemplateID = value; }
		}

		/// <summary>
		/// Gets or sets the ResourceType value.
		/// </summary>
		private char _resourceType=new char();
		public char ResourceType
		{
			get { return  _resourceType; }
			set { _resourceType = value; }
		}

		/// <summary>
		/// Gets or sets the StartDate value.
		/// </summary>
		private DateTime _startDate=DateTime.MaxValue;
		public DateTime StartDate
		{
			get { return  _startDate; }
			set { _startDate = value; }
		}

		/// <summary>
		/// Gets or sets the CType value.
		/// </summary>
		private char _cType=new char();
		public char CType
		{
			get { return  _cType; }
			set { _cType = value; }
		}

		/// <summary>
		/// Gets or sets the Interval value.
		/// </summary>
		private int _interval=0;
		public int Interval
		{
			get { return  _interval; }
			set { _interval = value; }
		}

		/// <summary>
		/// Gets or sets the Value value.
		/// </summary>
		private string _value=String.Empty;
		public string Value
		{
			get { return  _value; }
			set { _value = value; }
		}

		/// <summary>
		/// Gets or sets the ClientCode value.
		/// </summary>
		private string _clientCode=String.Empty;
		public string ClientCode
		{
			get { return  _clientCode; }
			set { _clientCode = value; }
		}

		/// <summary>
		/// Gets or sets the RateCode value.
		/// </summary>
		private string _rateCode=String.Empty;
		public string RateCode
		{
			get { return  _rateCode; }
			set { _rateCode = value; }
		}

		/// <summary>
		/// Gets or sets the PhysicianID value.
		/// </summary>
		private long _physicianID=0;
		public long PhysicianID
		{
			get { return  _physicianID; }
			set { _physicianID = value; }
		}

		/// <summary>
		/// Gets or sets the Name value.
		/// </summary>
		private String _name=String.Empty;
		public String Name
		{
			get { return  _name; }
			set { _name = value; }
		}

		/// <summary>
		/// Gets or sets the IsMappedItem value.
		/// </summary>
		private String _isMappedItem=String.Empty;
		public String IsMappedItem
		{
			get { return  _isMappedItem; }
			set { _isMappedItem = value; }
		}

		/// <summary>
		/// Gets or sets the IsDiscount value.
		/// </summary>
		private String _isDiscount=String.Empty;
		public String IsDiscount
		{
			get { return  _isDiscount; }
			set { _isDiscount = value; }
		}

		/// <summary>
		/// Gets or sets the ClientTypeName value.
		/// </summary>
		private String _clientTypeName=String.Empty;
		public String ClientTypeName
		{
			get { return  _clientTypeName; }
			set { _clientTypeName = value; }
		}

		/// <summary>
		/// Gets or sets the ReferingID value.
		/// </summary>
		private int _referingID=0;
		public int ReferingID
		{
			get { return  _referingID; }
			set { _referingID = value; }
		}

		/// <summary>
		/// Gets or sets the ClientStatus value.
		/// </summary>
		private String _clientStatus=String.Empty;
		public String ClientStatus
		{
			get { return  _clientStatus; }
			set { _clientStatus = value; }
		}

		/// <summary>
		/// Gets or sets the Reason value.
		/// </summary>
		private String _reason=String.Empty;
		public String Reason
		{
			get { return  _reason; }
			set { _reason = value; }
		}

		/// <summary>
		/// Gets or sets the BlockFrom value.
		/// </summary>
		private String _blockFrom=String.Empty;
		public String BlockFrom
		{
			get { return  _blockFrom; }
			set { _blockFrom = value; }
		}

		/// <summary>
		/// Gets or sets the BlockTo value.
		/// </summary>
		private String _blockTo=String.Empty;
		public String BlockTo
		{
			get { return  _blockTo; }
			set { _blockTo = value; }
		}

		/// <summary>
		/// Gets or sets the IsCashClient value.
		/// </summary>
		private String _isCashClient=String.Empty;
		public String IsCashClient
		{
			get { return  _isCashClient; }
			set { _isCashClient = value; }
		}

		/// <summary>
		/// Gets or sets the Attributes value.
		/// </summary>
		private String _attributes=String.Empty;
		public String Attributes
		{
			get { return  _attributes; }
			set { _attributes = value; }
		}

		/// <summary>
		/// Gets or sets the IsAllAreMedical value.
		/// </summary>
		private String _isAllAreMedical=String.Empty;
		public String IsAllAreMedical
		{
			get { return  _isAllAreMedical; }
			set { _isAllAreMedical = value; }
		}

		/// <summary>
		/// Gets or sets the BPJSINT value.
		/// </summary>
		private String _bPJSINT=String.Empty;
		public String BPJSINT
		{
			get { return  _bPJSINT; }
			set { _bPJSINT = value; }
		}

		/// <summary>
		/// Gets or sets the IsClientHaveAttributes value.
		/// </summary>
		private String _isClientHaveAttributes=String.Empty;
		public String IsClientHaveAttributes
		{
			get { return  _isClientHaveAttributes; }
			set { _isClientHaveAttributes = value; }
		}

		/// <summary>
		/// Gets or sets the ClientValue value.
		/// </summary>
		private String _clientValue=String.Empty;
		public String ClientValue
		{
			get { return  _clientValue; }
			set { _clientValue = value; }
		}


		#endregion
}
}
