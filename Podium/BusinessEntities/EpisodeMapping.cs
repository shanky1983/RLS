using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class EpisodeMapping
	{
		#region Fields

		private long patientId=0;
		private long visitID=0;
		private long episodeID=0;
		private int sittings=0;
		private long referenceNo=0;
		private string refType=String.Empty;
		private DateTime createdat=DateTime.MaxValue;
		private long createdby=0;
		private int orgid=0;
		private long episodemappingid=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PatientId value.
		/// </summary>
		public long PatientId
		{
			get { return patientId; }
			set { patientId = value; }
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
		/// Gets or sets the EpisodeID value.
		/// </summary>
		public long EpisodeID
		{
			get { return episodeID; }
			set { episodeID = value; }
		}

		/// <summary>
		/// Gets or sets the Sittings value.
		/// </summary>
		public int Sittings
		{
			get { return sittings; }
			set { sittings = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceNo value.
		/// </summary>
		public long ReferenceNo
		{
			get { return referenceNo; }
			set { referenceNo = value; }
		}

		/// <summary>
		/// Gets or sets the RefType value.
		/// </summary>
		public string RefType
		{
			get { return refType; }
			set { refType = value; }
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
		/// Gets or sets the Createdby value.
		/// </summary>
		public long Createdby
		{
			get { return createdby; }
			set { createdby = value; }
		}

		/// <summary>
		/// Gets or sets the Orgid value.
		/// </summary>
		public int Orgid
		{
			get { return orgid; }
			set { orgid = value; }
		}

		/// <summary>
		/// Gets or sets the Episodemappingid value.
		/// </summary>
		public long Episodemappingid
		{
			get { return episodemappingid; }
			set { episodemappingid = value; }
		}


		#endregion
}
}
