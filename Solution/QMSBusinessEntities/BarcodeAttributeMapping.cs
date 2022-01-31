using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class BarcodeAttributeMapping
	{
		#region Fields

		private long id=0;
		private long barcodeOrgMappingId=0;
		private long barcodeSubAttributeId=0;
		private string valu=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id value.
		/// </summary>
		public long Id
		{
			get { return id; }
			set { id = value; }
		}

		/// <summary>
		/// Gets or sets the BarcodeOrgMappingId value.
		/// </summary>
		public long BarcodeOrgMappingId
		{
			get { return barcodeOrgMappingId; }
			set { barcodeOrgMappingId = value; }
		}

		/// <summary>
		/// Gets or sets the BarcodeSubAttributeId value.
		/// </summary>
		public long BarcodeSubAttributeId
		{
			get { return barcodeSubAttributeId; }
			set { barcodeSubAttributeId = value; }
		}

		/// <summary>
		/// Gets or sets the Valu value.
		/// </summary>
		public string Value
		{
			get { return valu; }
			set { valu = value; }
		}


		#endregion
}
}
