using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class HL7Segments
	{
		#region Fields

		private long hL7SegmentsID=0;
		private string hL7SegmentsName=String.Empty;
		private string hL7ControlType=String.Empty;
		private string isRequired=String.Empty;
		private long seqOrder=0;
		private int orgID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the HL7SegmentsID value.
		/// </summary>
		public long HL7SegmentsID
		{
			get { return hL7SegmentsID; }
			set { hL7SegmentsID = value; }
		}

		/// <summary>
		/// Gets or sets the HL7SegmentsName value.
		/// </summary>
		public string HL7SegmentsName
		{
			get { return hL7SegmentsName; }
			set { hL7SegmentsName = value; }
		}

		/// <summary>
		/// Gets or sets the HL7ControlType value.
		/// </summary>
		public string HL7ControlType
		{
			get { return hL7ControlType; }
			set { hL7ControlType = value; }
		}

		/// <summary>
		/// Gets or sets the IsRequired value.
		/// </summary>
		public string IsRequired
		{
			get { return isRequired; }
			set { isRequired = value; }
		}

		/// <summary>
		/// Gets or sets the SeqOrder value.
		/// </summary>
		public long SeqOrder
		{
			get { return seqOrder; }
			set { seqOrder = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}


		#endregion
}
}
