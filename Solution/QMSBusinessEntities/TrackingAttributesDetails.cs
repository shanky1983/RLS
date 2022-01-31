using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class TrackingAttributesDetails
	{
		#region Fields

		private long trackingAttributesDetailsID=0;
		private long trackID=0;
		private long trackDetailsID=0;
		private long controlMappingID=0;
		private string attributeskey=String.Empty;
		private string attributesValue=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the TrackingAttributesDetailsID value.
		/// </summary>
		public long TrackingAttributesDetailsID
		{
			get { return trackingAttributesDetailsID; }
			set { trackingAttributesDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the TrackID value.
		/// </summary>
		public long TrackID
		{
			get { return trackID; }
			set { trackID = value; }
		}

		/// <summary>
		/// Gets or sets the TrackDetailsID value.
		/// </summary>
		public long TrackDetailsID
		{
			get { return trackDetailsID; }
			set { trackDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the ControlMappingID value.
		/// </summary>
		public long ControlMappingID
		{
			get { return controlMappingID; }
			set { controlMappingID = value; }
		}

		/// <summary>
		/// Gets or sets the Attributeskey value.
		/// </summary>
		public string Attributeskey
		{
			get { return attributeskey; }
			set { attributeskey = value; }
		}

		/// <summary>
		/// Gets or sets the AttributesValue value.
		/// </summary>
		public string AttributesValue
		{
			get { return attributesValue; }
			set { attributesValue = value; }
		}


		#endregion
}
}
