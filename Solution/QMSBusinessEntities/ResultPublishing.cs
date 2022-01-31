using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ResultPublishing
	{
		#region Fields

		private long patientVisitID=0;
		private int modeID=0;
		private long shippingAddressID=0;
		private string valu=String.Empty;
		private string status=String.Empty;
		private string receiverName=String.Empty;
		private string receiverContactNo=String.Empty;
		private DateTime startDTTM=DateTime.MaxValue;
		private DateTime endDTTM=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int orgID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PatientVisitID value.
		/// </summary>
		public long PatientVisitID
		{
			get { return patientVisitID; }
			set { patientVisitID = value; }
		}

		/// <summary>
		/// Gets or sets the ModeID value.
		/// </summary>
		public int ModeID
		{
			get { return modeID; }
			set { modeID = value; }
		}

		/// <summary>
		/// Gets or sets the ShippingAddressID value.
		/// </summary>
		public long ShippingAddressID
		{
			get { return shippingAddressID; }
			set { shippingAddressID = value; }
		}

		/// <summary>
		/// Gets or sets the Valu value.
		/// </summary>
		public string Value
		{
			get { return valu; }
			set { valu = value; }
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
		/// Gets or sets the ReceiverName value.
		/// </summary>
		public string ReceiverName
		{
			get { return receiverName; }
			set { receiverName = value; }
		}

		/// <summary>
		/// Gets or sets the ReceiverContactNo value.
		/// </summary>
		public string ReceiverContactNo
		{
			get { return receiverContactNo; }
			set { receiverContactNo = value; }
		}

		/// <summary>
		/// Gets or sets the StartDTTM value.
		/// </summary>
		public DateTime StartDTTM
		{
			get { return startDTTM; }
			set { startDTTM = value; }
		}

		/// <summary>
		/// Gets or sets the EndDTTM value.
		/// </summary>
		public DateTime EndDTTM
		{
			get { return endDTTM; }
			set { endDTTM = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the ModeName value.
		/// </summary>
		string _modename;
		public string ModeName
		{
			get { return _modename; }
			set { _modename = value; }
		}


		#endregion
}
}
