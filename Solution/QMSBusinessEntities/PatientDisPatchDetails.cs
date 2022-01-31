using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class PatientDisPatchDetails
	{
		#region Fields

		private long patientDispatchID=0;
		private long patientID=0;
		private long visitID=0;
		private int orgID=0;
		private string dispatchType=String.Empty;
		private string dispatchValue=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string valu=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PatientDispatchID value.
		/// </summary>
		public long PatientDispatchID
		{
			get { return patientDispatchID; }
			set { patientDispatchID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientID value.
		/// </summary>
		public long PatientID
		{
			get { return patientID; }
			set { patientID = value; }
		}

		/// <summary>
		/// Gets or sets the VisitID value.
		/// </summary>
		public long VisitID
		{
			get { return visitID; }
			set { visitID = value; }
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
		/// Gets or sets the DispatchType value.
		/// </summary>
		public string DispatchType
		{
			get { return dispatchType; }
			set { dispatchType = value; }
		}

		/// <summary>
		/// Gets or sets the DispatchValue value.
		/// </summary>
		public string DispatchValue
		{
			get { return dispatchValue; }
			set { dispatchValue = value; }
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
		/// Gets or sets the Valu value.
		/// </summary>
		public string Value
		{
			get { return valu; }
			set { valu = value; }
		}

		/// <summary>
		/// Gets or sets the PatientMobileNum value.
		/// </summary>
		string _patientmobilenum;
		public string PatientMobileNum
		{
			get { return _patientmobilenum; }
			set { _patientmobilenum = value; }
		}

		/// <summary>
		/// Gets or sets the ClientMobileNum value.
		/// </summary>
		string _clientmobilenum;
		public string ClientMobileNum
		{
			get { return _clientmobilenum; }
			set { _clientmobilenum = value; }
		}

		/// <summary>
		/// Gets or sets the Content value.
		/// </summary>
		byte _content;
		public byte Content
		{
			get { return _content; }
			set { _content = value; }
		}

		/// <summary>
		/// Gets or sets the IsCreditBill value.
		/// </summary>
		string _iscreditbill;
		public string IsCreditBill
		{
			get { return _iscreditbill; }
			set { _iscreditbill = value; }
		}

		/// <summary>
		/// Gets or sets the ClientEmailID value.
		/// </summary>
		string _clientemailid;
		public string ClientEmailID
		{
			get { return _clientemailid; }
			set { _clientemailid = value; }
		}

		/// <summary>
		/// Gets or sets the PatientEmailID value.
		/// </summary>
		string _patientemailid;
		public string PatientEmailID
		{
			get { return _patientemailid; }
			set { _patientemailid = value; }
		}


		#endregion
}
}
