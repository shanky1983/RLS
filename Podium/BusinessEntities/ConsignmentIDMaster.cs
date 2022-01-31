using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ConsignmentIDMaster
	{
		#region Fields

		private long iD=0;
		private long consignmentNo=0;
		private int orgid=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public long ID
		{
			get { return iD; }
			set { iD = value; }
		}

		/// <summary>
		/// Gets or sets the ConsignmentNo value.
		/// </summary>
		public long ConsignmentNo
		{
			get { return consignmentNo; }
			set { consignmentNo = value; }
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
