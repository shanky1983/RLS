using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class InvOrgReferenceMapping
	{
		#region Fields

		private long iD=0;
		private long investigationID=0;
		private int orgID=0;
		private long instrumentID=0;
		private long kitID=0;
		private int uOMID=0;
		private string uOMCode=String.Empty;
		private string referenceRange=String.Empty;
		private string isPrimary=String.Empty;
		private string isActive=String.Empty;
		private int clientID=0;
		private string reasonCode=String.Empty;
		private int cONV_UOMID=0;
		private string cONV_UOMCode=String.Empty;
		private int convFac_DecimalPoint=0;
		private decimal cONV_Factor=Decimal.Zero;

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
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
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
		/// Gets or sets the KitID value.
		/// </summary>
		public long KitID
		{
			get { return kitID; }
			set { kitID = value; }
		}

		/// <summary>
		/// Gets or sets the UOMID value.
		/// </summary>
		public int UOMID
		{
			get { return uOMID; }
			set { uOMID = value; }
		}

		/// <summary>
		/// Gets or sets the UOMCode value.
		/// </summary>
		public string UOMCode
		{
			get { return uOMCode; }
			set { uOMCode = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceRange value.
		/// </summary>
		public string ReferenceRange
		{
			get { return referenceRange; }
			set { referenceRange = value; }
		}

		/// <summary>
		/// Gets or sets the IsPrimary value.
		/// </summary>
		public string IsPrimary
		{
			get { return isPrimary; }
			set { isPrimary = value; }
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
		/// Gets or sets the ClientID value.
		/// </summary>
		public int ClientID
		{
			get { return clientID; }
			set { clientID = value; }
		}

		/// <summary>
		/// Gets or sets the ReasonCode value.
		/// </summary>
		public string ReasonCode
		{
			get { return reasonCode; }
			set { reasonCode = value; }
		}

		/// <summary>
		/// Gets or sets the CONV_UOMID value.
		/// </summary>
		public int CONV_UOMID
		{
			get { return cONV_UOMID; }
			set { cONV_UOMID = value; }
		}

		/// <summary>
		/// Gets or sets the CONV_UOMCode value.
		/// </summary>
		public string CONV_UOMCode
		{
			get { return cONV_UOMCode; }
			set { cONV_UOMCode = value; }
		}

		/// <summary>
		/// Gets or sets the ConvFac_DecimalPoint value.
		/// </summary>
		public int ConvFac_DecimalPoint
		{
			get { return convFac_DecimalPoint; }
			set { convFac_DecimalPoint = value; }
		}

		/// <summary>
		/// Gets or sets the CONV_Factor value.
		/// </summary>
		public decimal CONV_Factor
		{
			get { return cONV_Factor; }
			set { cONV_Factor = value; }
		}

		/// <summary>
		/// Gets or sets the InstrumentName value.
		/// </summary>
		string _instrumentname;
		public string InstrumentName
		{
			get { return _instrumentname; }
			set { _instrumentname = value; }
		}

		/// <summary>
		/// Gets or sets the KitName value.
		/// </summary>
		string _kitname;
		public string KitName
		{
			get { return _kitname; }
			set { _kitname = value; }
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
		/// Gets or sets the TestCode value.
		/// </summary>
		string _testcode;
		public string TestCode
		{
			get { return _testcode; }
			set { _testcode = value; }
		}

		/// <summary>
		/// Gets or sets the InstrumentCode value.
		/// </summary>
		string _instrumentcode;
		public string InstrumentCode
		{
			get { return _instrumentcode; }
			set { _instrumentcode = value; }
		}

		/// <summary>
		/// Gets or sets the ReasonName value.
		/// </summary>
		string _reasonname;
		public string ReasonName
		{
			get { return _reasonname; }
			set { _reasonname = value; }
		}

		/// <summary>
		/// Gets or sets the DeviceMappingID value.
		/// </summary>
		long _devicemappingid;
		public long DeviceMappingID
		{
			get { return _devicemappingid; }
			set { _devicemappingid = value; }
		}

		/// <summary>
		/// Gets or sets the IsRRXML value.
		/// </summary>
		bool _isrrxml;
		public bool IsRRXML
		{
			get { return _isrrxml; }
			set { _isrrxml = value; }
		}


		#endregion
}
}
