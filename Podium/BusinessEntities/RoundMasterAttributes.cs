using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class RoundMasterAttributes
	{
		#region Fields

		private int iD=0;
		private long roundID=0;
		private int clinicID=0;
		private string type=String.Empty;
		private int sequenceNo=0;
		private string estimatedTime=String.Empty;

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
		/// Gets or sets the RoundID value.
		/// </summary>
		public long RoundID
		{
			get { return roundID; }
			set { roundID = value; }
		}

		/// <summary>
		/// Gets or sets the ClinicID value.
		/// </summary>
		public int ClinicID
		{
			get { return clinicID; }
			set { clinicID = value; }
		}

		/// <summary>
		/// Gets or sets the Type value.
		/// </summary>
		public string Type
		{
			get { return type; }
			set { type = value; }
		}

		/// <summary>
		/// Gets or sets the SequenceNo value.
		/// </summary>
		public int SequenceNo
		{
			get { return sequenceNo; }
			set { sequenceNo = value; }
		}

		/// <summary>
		/// Gets or sets the EstimatedTime value.
		/// </summary>
		public string EstimatedTime
		{
			get { return estimatedTime; }
			set { estimatedTime = value; }
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


		#endregion
}
}
