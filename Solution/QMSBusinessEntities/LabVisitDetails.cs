using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class LabVisitDetails
	{
		#region Fields

		private long visitID=0;
		private long referingPhysicianID=0;
		private string referingPhysicianName=String.Empty;
		private long hospitalID=0;
		private string hospitalName=String.Empty;
		private long clientID=0;
		private string clientName=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the VisitID value.
		/// </summary>
		public long VisitID
		{
			get { return visitID; }
			set { visitID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferingPhysicianID value.
		/// </summary>
		public long ReferingPhysicianID
		{
			get { return referingPhysicianID; }
			set { referingPhysicianID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferingPhysicianName value.
		/// </summary>
		public string ReferingPhysicianName
		{
			get { return referingPhysicianName; }
			set { referingPhysicianName = value; }
		}

		/// <summary>
		/// Gets or sets the HospitalID value.
		/// </summary>
		public long HospitalID
		{
			get { return hospitalID; }
			set { hospitalID = value; }
		}

		/// <summary>
		/// Gets or sets the HospitalName value.
		/// </summary>
		public string HospitalName
		{
			get { return hospitalName; }
			set { hospitalName = value; }
		}

		/// <summary>
		/// Gets or sets the ClientID value.
		/// </summary>
		public long ClientID
		{
			get { return clientID; }
			set { clientID = value; }
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
		/// Gets or sets the PatientName value.
		/// </summary>
		string _patientname;
		public string PatientName
		{
			get { return _patientname; }
			set { _patientname = value; }
		}

		/// <summary>
		/// Gets or sets the TitleName value.
		/// </summary>
		string _titlename;
		public string TitleName
		{
			get { return _titlename; }
			set { _titlename = value; }
		}

		/// <summary>
		/// Gets or sets the PatientAge value.
		/// </summary>
		int _patientage;
		public int PatientAge
		{
			get { return _patientage; }
			set { _patientage = value; }
		}

		/// <summary>
		/// Gets or sets the Sex value.
		/// </summary>
		string _sex;
		public string Sex
		{
			get { return _sex; }
			set { _sex = value; }
		}

		/// <summary>
		/// Gets or sets the PriorityName value.
		/// </summary>
		string _priorityname;
		public string PriorityName
		{
			get { return _priorityname; }
			set { _priorityname = value; }
		}

		/// <summary>
		/// Gets or sets the PreviousDue value.
		/// </summary>
		decimal _previousdue;
		public decimal PreviousDue
		{
			get { return _previousdue; }
			set { _previousdue = value; }
		}

		/// <summary>
		/// Gets or sets the AgeWithUnit value.
		/// </summary>
		string _agewithunit;
		public string AgeWithUnit
		{
			get { return _agewithunit; }
			set { _agewithunit = value; }
		}


		#endregion
}
}
