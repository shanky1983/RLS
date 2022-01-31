using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ReferenceRangeTracker
	{
		#region Fields

		private int iD=0;
		private string old_RefernceRange=String.Empty;
		private string new_RefernceRange=String.Empty;
		private long patientVisitId=0;
		private long investigationID=0;
		private DateTime cRdate=DateTime.MaxValue;
		private int orgid=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}

		/// <summary>
		/// Gets or sets the Old_RefernceRange value.
		/// </summary>
		public string Old_RefernceRange
		{
			get { return old_RefernceRange; }
			set { old_RefernceRange = value; }
		}

		/// <summary>
		/// Gets or sets the New_RefernceRange value.
		/// </summary>
		public string New_RefernceRange
		{
			get { return new_RefernceRange; }
			set { new_RefernceRange = value; }
		}

		/// <summary>
		/// Gets or sets the PatientVisitId value.
		/// </summary>
		public long PatientVisitId
		{
			get { return patientVisitId; }
			set { patientVisitId = value; }
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
		/// Gets or sets the CRdate value.
		/// </summary>
		public DateTime CRdate
		{
			get { return cRdate; }
			set { cRdate = value; }
		}

		/// <summary>
		/// Gets or sets the Orgid value.
		/// </summary>
		public int Orgid
		{
			get { return orgid; }
			set { orgid = value; }
		}


		#endregion
}
}
