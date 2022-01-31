using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ReferenceRangeMapping
	{
		#region Fields

		private int mappingid=0;
		private long clientid=0;
		private string tag=String.Empty;
		private int rangetype=0;
		private int orgid=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Mappingid value.
		/// </summary>
		public int Mappingid
		{
			get { return mappingid; }
			set { mappingid = value; }
		}

		/// <summary>
		/// Gets or sets the Clientid value.
		/// </summary>
		public long Clientid
		{
			get { return clientid; }
			set { clientid = value; }
		}

		/// <summary>
		/// Gets or sets the Tag value.
		/// </summary>
		public string Tag
		{
			get { return tag; }
			set { tag = value; }
		}

		/// <summary>
		/// Gets or sets the Rangetype value.
		/// </summary>
		public int Rangetype
		{
			get { return rangetype; }
			set { rangetype = value; }
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
