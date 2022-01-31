using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class DialysisRecord
	{
		#region Fields

		private long dialysisRecordID=0;
		private long patientVisitID=0;
		private int hDNo=0;
		private DateTime hDDate=DateTime.MaxValue;
		private DateTime hDStartTime=DateTime.MaxValue;
		private DateTime hDEndTime=DateTime.MaxValue;
		private short accessID=0;
		private string accessSide=String.Empty;
		private int postConditionID=0;
		private string dialyserUsed=String.Empty;
		private string bTS=String.Empty;
		private long orgID=0;
		private string weightGain=String.Empty;
		private DateTime nextHDDateTime=DateTime.MaxValue;
		private string machineName=String.Empty;
		private string remarks=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private decimal dryWeight=Decimal.Zero;
		private string comments=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DialysisRecordID value.
		/// </summary>
		public long DialysisRecordID
		{
			get { return dialysisRecordID; }
			set { dialysisRecordID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientVisitID value.
		/// </summary>
		public long PatientVisitID
		{
			get { return patientVisitID; }
			set { patientVisitID = value; }
		}

		/// <summary>
		/// Gets or sets the HDNo value.
		/// </summary>
		public int HDNo
		{
			get { return hDNo; }
			set { hDNo = value; }
		}

		/// <summary>
		/// Gets or sets the HDDate value.
		/// </summary>
		public DateTime HDDate
		{
			get { return hDDate; }
			set { hDDate = value; }
		}

		/// <summary>
		/// Gets or sets the HDStartTime value.
		/// </summary>
		public DateTime HDStartTime
		{
			get { return hDStartTime; }
			set { hDStartTime = value; }
		}

		/// <summary>
		/// Gets or sets the HDEndTime value.
		/// </summary>
		public DateTime HDEndTime
		{
			get { return hDEndTime; }
			set { hDEndTime = value; }
		}

		/// <summary>
		/// Gets or sets the AccessID value.
		/// </summary>
		public short AccessID
		{
			get { return accessID; }
			set { accessID = value; }
		}

		/// <summary>
		/// Gets or sets the AccessSide value.
		/// </summary>
		public string AccessSide
		{
			get { return accessSide; }
			set { accessSide = value; }
		}

		/// <summary>
		/// Gets or sets the PostConditionID value.
		/// </summary>
		public int PostConditionID
		{
			get { return postConditionID; }
			set { postConditionID = value; }
		}

		/// <summary>
		/// Gets or sets the DialyserUsed value.
		/// </summary>
		public string DialyserUsed
		{
			get { return dialyserUsed; }
			set { dialyserUsed = value; }
		}

		/// <summary>
		/// Gets or sets the BTS value.
		/// </summary>
		public string BTS
		{
			get { return bTS; }
			set { bTS = value; }
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
		/// Gets or sets the WeightGain value.
		/// </summary>
		public string WeightGain
		{
			get { return weightGain; }
			set { weightGain = value; }
		}

		/// <summary>
		/// Gets or sets the NextHDDateTime value.
		/// </summary>
		public DateTime NextHDDateTime
		{
			get { return nextHDDateTime; }
			set { nextHDDateTime = value; }
		}

		/// <summary>
		/// Gets or sets the MachineName value.
		/// </summary>
		public string MachineName
		{
			get { return machineName; }
			set { machineName = value; }
		}

		/// <summary>
		/// Gets or sets the Remarks value.
		/// </summary>
		public string Remarks
		{
			get { return remarks; }
			set { remarks = value; }
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
		/// Gets or sets the DryWeight value.
		/// </summary>
		public decimal DryWeight
		{
			get { return dryWeight; }
			set { dryWeight = value; }
		}

		/// <summary>
		/// Gets or sets the Comments value.
		/// </summary>
		public string Comments
		{
			get { return comments; }
			set { comments = value; }
		}

		/// <summary>
		/// Gets or sets the AccessName value.
		/// </summary>
		private string _accessName=String.Empty;
		public string AccessName
		{
			get { return  _accessName; }
			set { _accessName = value; }
		}


		#endregion
}
}
