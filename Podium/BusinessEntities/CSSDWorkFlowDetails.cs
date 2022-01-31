using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class CSSDWorkFlowDetails
	{
		#region Fields

		private int workFlowDetailsID=0;
		private int workFlowID=0;
		private byte sequence=0x00;
		private string processCode=String.Empty;
		private string equipmentTypeCode=String.Empty;
		private string status=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the WorkFlowDetailsID value.
		/// </summary>
		public int WorkFlowDetailsID
		{
			get { return workFlowDetailsID; }
			set { workFlowDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the WorkFlowID value.
		/// </summary>
		public int WorkFlowID
		{
			get { return workFlowID; }
			set { workFlowID = value; }
		}

		/// <summary>
		/// Gets or sets the Sequence value.
		/// </summary>
		public byte Sequence
		{
			get { return sequence; }
			set { sequence = value; }
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
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
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
