using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ClientMappingService
	{
		#region Fields

		private long serviceID=0;
		private long clientId=0;
		private long feeID=0;
		private string feeType=String.Empty;
		private string referenceType=String.Empty;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string sCode=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ServiceID value.
		/// </summary>
		public long ServiceID
		{
			get { return serviceID; }
			set { serviceID = value; }
		}

		/// <summary>
		/// Gets or sets the ClientId value.
		/// </summary>
		public long ClientId
		{
			get { return clientId; }
			set { clientId = value; }
		}

		/// <summary>
		/// Gets or sets the FeeID value.
		/// </summary>
		public long FeeID
		{
			get { return feeID; }
			set { feeID = value; }
		}

		/// <summary>
		/// Gets or sets the FeeType value.
		/// </summary>
		public string FeeType
		{
			get { return feeType; }
			set { feeType = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
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
		/// Gets or sets the SCode value.
		/// </summary>
		public string SCode
		{
			get { return sCode; }
			set { sCode = value; }
		}

		/// <summary>
		/// Gets or sets the ClientServiceDetails value.
		/// </summary>
		string _clientservicedetails;
		public string ClientServiceDetails
		{
			get { return _clientservicedetails; }
			set { _clientservicedetails = value; }
		}

		/// <summary>
		/// Gets or sets the ClientName value.
		/// </summary>
		string _clientname;
		public string ClientName
		{
			get { return _clientname; }
			set { _clientname = value; }
		}

		/// <summary>
		/// Gets or sets the ClientTypeCode value.
		/// </summary>
		string _clienttypecode;
		public string ClientTypeCode
		{
			get { return _clienttypecode; }
			set { _clienttypecode = value; }
		}

		/// <summary>
		/// Gets or sets the TestName value.
		/// </summary>
		string _testname;
		public string TestName
		{
			get { return _testname; }
			set { _testname = value; }
		}


		#endregion
}
}
