using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ClientFeeTypeRateCustomization
	{
		#region Fields

		private long clientID=0;
		private string feeType=String.Empty;
		private int roomTypeID=0;
		private decimal discOrEnhancePercent=Decimal.Zero;
		private string discOrEnhanceType=String.Empty;
		private string clientType=String.Empty;
		private string applyby=String.Empty;
		private long clientFeeTypeRateCustID=0;
		private long feeID=0;
		private DateTime createdat=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;

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
		/// Gets or sets the FeeType value.
		/// </summary>
		public string FeeType
		{
			get { return feeType; }
			set { feeType = value; }
		}

		/// <summary>
		/// Gets or sets the RoomTypeID value.
		/// </summary>
		public int RoomTypeID
		{
			get { return roomTypeID; }
			set { roomTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the DiscOrEnhancePercent value.
		/// </summary>
		public decimal DiscOrEnhancePercent
		{
			get { return discOrEnhancePercent; }
			set { discOrEnhancePercent = value; }
		}

		/// <summary>
		/// Gets or sets the DiscOrEnhanceType value.
		/// </summary>
		public string DiscOrEnhanceType
		{
			get { return discOrEnhanceType; }
			set { discOrEnhanceType = value; }
		}

		/// <summary>
		/// Gets or sets the ClientType value.
		/// </summary>
		public string ClientType
		{
			get { return clientType; }
			set { clientType = value; }
		}

		/// <summary>
		/// Gets or sets the Applyby value.
		/// </summary>
		public string Applyby
		{
			get { return applyby; }
			set { applyby = value; }
		}

		/// <summary>
		/// Gets or sets the ClientFeeTypeRateCustID value.
		/// </summary>
		public long ClientFeeTypeRateCustID
		{
			get { return clientFeeTypeRateCustID; }
			set { clientFeeTypeRateCustID = value; }
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
		/// Gets or sets the Createdat value.
		/// </summary>
		public DateTime Createdat
		{
			get { return createdat; }
			set { createdat = value; }
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
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
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
		/// Gets or sets the ClientName value.
		/// </summary>
		private string _clientName=String.Empty;
		public string ClientName
		{
			get { return  _clientName; }
			set { _clientName = value; }
		}

		/// <summary>
		/// Gets or sets the FeeTypeId value.
		/// </summary>
		private int _feeTypeId=0;
		public int FeeTypeId
		{
			get { return  _feeTypeId; }
			set { _feeTypeId = value; }
		}

		/// <summary>
		/// Gets or sets the RoomType value.
		/// </summary>
		private string _roomType=String.Empty;
		public string RoomType
		{
			get { return  _roomType; }
			set { _roomType = value; }
		}

		/// <summary>
		/// Gets or sets the FeeTypeDesc value.
		/// </summary>
		private string _feeTypeDesc=String.Empty;
		public string FeeTypeDesc
		{
			get { return  _feeTypeDesc; }
			set { _feeTypeDesc = value; }
		}

		/// <summary>
		/// Gets or sets the ClientRateId value.
		/// </summary>
		private int _clientRateId=0;
		public int ClientRateId
		{
			get { return  _clientRateId; }
			set { _clientRateId = value; }
		}


		#endregion
}
}
