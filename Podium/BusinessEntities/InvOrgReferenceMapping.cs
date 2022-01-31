using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
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
		private string _instrumentName=String.Empty;
		public string InstrumentName
		{
			get { return  _instrumentName; }
			set { _instrumentName = value; }
		}

		/// <summary>
		/// Gets or sets the KitName value.
		/// </summary>
		private string _kitName=String.Empty;
		public string KitName
		{
			get { return  _kitName; }
			set { _kitName = value; }
		}

		/// <summary>
		/// Gets or sets the ClientName value.
		/// </summary>
		private string _clientName=String.Empty;
		public string ClientName
		{
			get { return  _clientName; }
			set { _clientName = value; }
		}

		/// <summary>
		/// Gets or sets the TestCode value.
		/// </summary>
		private string _testCode=String.Empty;
		public string TestCode
		{
			get { return  _testCode; }
			set { _testCode = value; }
		}

		/// <summary>
		/// Gets or sets the InstrumentCode value.
		/// </summary>
		private string _instrumentCode=String.Empty;
		public string InstrumentCode
		{
			get { return  _instrumentCode; }
			set { _instrumentCode = value; }
		}

		/// <summary>
		/// Gets or sets the ReasonName value.
		/// </summary>
		private string _reasonName=String.Empty;
		public string ReasonName
		{
			get { return  _reasonName; }
			set { _reasonName = value; }
		}

		/// <summary>
		/// Gets or sets the DeviceMappingID value.
		/// </summary>
		private long _deviceMappingID=0;
		public long DeviceMappingID
		{
			get { return  _deviceMappingID; }
			set { _deviceMappingID = value; }
		}

		/// <summary>
		/// Gets or sets the IsRRXML value.
		/// </summary>
		private bool _isRRXML=false;
		public bool IsRRXML
		{
			get { return  _isRRXML; }
			set { _isRRXML = value; }
		}


		#endregion
}
}
