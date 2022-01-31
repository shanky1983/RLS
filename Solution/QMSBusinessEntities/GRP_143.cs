using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class GRP_143
	{
		#region Fields

		private string lAB=String.Empty;
		private string gROUPNAME=String.Empty;
		private string mETRO_COMBINE_CODE=String.Empty;
		private string dISPLAY_NAME=String.Empty;
		private string iS_ORDERABLE=String.Empty;
		private string billing_Name=String.Empty;
		private long orggroupid=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the LAB value.
		/// </summary>
		public string LAB
		{
			get { return lAB; }
			set { lAB = value; }
		}

		/// <summary>
		/// Gets or sets the GROUPNAME value.
		/// </summary>
		public string GROUPNAME
		{
			get { return gROUPNAME; }
			set { gROUPNAME = value; }
		}

		/// <summary>
		/// Gets or sets the METRO_COMBINE_CODE value.
		/// </summary>
		public string METRO_COMBINE_CODE
		{
			get { return mETRO_COMBINE_CODE; }
			set { mETRO_COMBINE_CODE = value; }
		}

		/// <summary>
		/// Gets or sets the DISPLAY_NAME value.
		/// </summary>
		public string DISPLAY_NAME
		{
			get { return dISPLAY_NAME; }
			set { dISPLAY_NAME = value; }
		}

		/// <summary>
		/// Gets or sets the IS_ORDERABLE value.
		/// </summary>
		public string IS_ORDERABLE
		{
			get { return iS_ORDERABLE; }
			set { iS_ORDERABLE = value; }
		}

		/// <summary>
		/// Gets or sets the Billing_Name value.
		/// </summary>
		public string Billing_Name
		{
			get { return billing_Name; }
			set { billing_Name = value; }
		}

		/// <summary>
		/// Gets or sets the Orggroupid value.
		/// </summary>
		public long Orggroupid
		{
			get { return orggroupid; }
			set { orggroupid = value; }
		}


		#endregion
}
}
