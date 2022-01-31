using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class InvReviewComments
	{
		#region Fields

		private long reViewID=0;
		private long invid=0;
		private string comments=String.Empty;
		private string type=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ReViewID value.
		/// </summary>
		public long ReViewID
		{
			get { return reViewID; }
			set { reViewID = value; }
		}

		/// <summary>
		/// Gets or sets the Invid value.
		/// </summary>
		public long Invid
		{
			get { return invid; }
			set { invid = value; }
		}

		/// <summary>
		/// Gets or sets the Comments value.
		/// </summary>
		public string Comments
		{
			get { return comments; }
			set { comments = value; }
		}

		/// <summary>
		/// Gets or sets the Type value.
		/// </summary>
		public string Type
		{
			get { return type; }
			set { type = value; }
		}


		#endregion
}
}
