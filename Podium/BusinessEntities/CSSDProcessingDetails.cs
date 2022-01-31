using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class CSSDProcessingDetails
	{
		#region Fields

		private long processingDetailsID=0;
		private long requestProcessingID=0;
		private string processCode=String.Empty;
		private string equipmentTypeCode=String.Empty;
		private int equipmentID=0;
		private string indicatorCode=String.Empty;
		private DateTime processStartDTTM=DateTime.MaxValue;
		private DateTime processEndDTTM=DateTime.MaxValue;
		private DateTime aerationStartDTTM=DateTime.MaxValue;
		private DateTime aerationEndDTTM=DateTime.MaxValue;
		private string status=String.Empty;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ProcessingDetailsID value.
		/// </summary>
		public long ProcessingDetailsID
		{
			get { return processingDetailsID; }
			set { processingDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the RequestProcessingID value.
		/// </summary>
		public long RequestProcessingID
		{
			get { return requestProcessingID; }
			set { requestProcessingID = value; }
		}

		/// <summary>
		/// Gets or sets the ProcessCode value.
		/// </summary>
		public string ProcessCode
		{
			get { return processCode; }
			set { processCode = value; }
		}

		/// <summary>
		/// Gets or sets the EquipmentTypeCode value.
		/// </summary>
		public string EquipmentTypeCode
		{
			get { return equipmentTypeCode; }
			set { equipmentTypeCode = value; }
		}

		/// <summary>
		/// Gets or sets the EquipmentID value.
		/// </summary>
		public int EquipmentID
		{
			get { return equipmentID; }
			set { equipmentID = value; }
		}

		/// <summary>
		/// Gets or sets the IndicatorCode value.
		/// </summary>
		public string IndicatorCode
		{
			get { return indicatorCode; }
			set { indicatorCode = value; }
		}

		/// <summary>
		/// Gets or sets the ProcessStartDTTM value.
		/// </summary>
		public DateTime ProcessStartDTTM
		{
			get { return processStartDTTM; }
			set { processStartDTTM = value; }
		}

		/// <summary>
		/// Gets or sets the ProcessEndDTTM value.
		/// </summary>
		public DateTime ProcessEndDTTM
		{
			get { return processEndDTTM; }
			set { processEndDTTM = value; }
		}

		/// <summary>
		/// Gets or sets the AerationStartDTTM value.
		/// </summary>
		public DateTime AerationStartDTTM
		{
			get { return aerationStartDTTM; }
			set { aerationStartDTTM = value; }
		}

		/// <summary>
		/// Gets or sets the AerationEndDTTM value.
		/// </summary>
		public DateTime AerationEndDTTM
		{
			get { return aerationEndDTTM; }
			set { aerationEndDTTM = value; }
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


		#endregion
}
}
