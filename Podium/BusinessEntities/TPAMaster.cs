using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class TPAMaster
	{
		#region Fields

		private long tPAID=0;
		private string tPAName=String.Empty;
		private long orgID=0;
		private string activeYN=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string tPAAttributes=String.Empty;
		private int rateTypeId=0;
		private int rateId=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the TPAID value.
		/// </summary>
		public long TPAID
		{
			get { return tPAID; }
			set { tPAID = value; }
		}

		/// <summary>
		/// Gets or sets the TPAName value.
		/// </summary>
		public string TPAName
		{
			get { return tPAName; }
			set { tPAName = value; }
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
		/// Gets or sets the ActiveYN value.
		/// </summary>
		public string ActiveYN
		{
			get { return activeYN; }
			set { activeYN = value; }
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
		/// Gets or sets the TPAAttributes value.
		/// </summary>
		public string TPAAttributes
		{
			get { return tPAAttributes; }
			set { tPAAttributes = value; }
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
		/// Gets or sets the RateName value.
		/// </summary>
		private String _rateName=String.Empty;
		public String RateName
		{
			get { return  _rateName; }
			set { _rateName = value; }
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
		/// Gets or sets the Type value.
		/// </summary>
		private string _type=String.Empty;
		public string Type
		{
			get { return  _type; }
			set { _type = value; }
		}


		#endregion
}
}
