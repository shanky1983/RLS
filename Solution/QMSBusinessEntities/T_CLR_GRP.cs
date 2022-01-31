using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class T_CLR_GRP
	{
		#region Fields

		private string gROUPNAME=String.Empty;
		private string type=String.Empty;
		private long groupID=0;
		private string mETRO_COMBINE_CODE=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the GROUPNAME value.
		/// </summary>
		public string GROUPNAME
		{
			get { return gROUPNAME; }
			set { gROUPNAME = value; }
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
		/// Gets or sets the GroupID value.
		/// </summary>
		public long GroupID
		{
			get { return groupID; }
			set { groupID = value; }
		}

		/// <summary>
		/// Gets or sets the METRO_COMBINE_CODE value.
		/// </summary>
		public string METRO_COMBINE_CODE
		{
			get { return mETRO_COMBINE_CODE; }
			set { mETRO_COMBINE_CODE = value; }
		}


		#endregion
}
}
