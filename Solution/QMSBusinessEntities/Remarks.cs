using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Remarks
	{
		#region Fields

		private long remarksID=0;
		private string remarksCode=String.Empty;
		private string remarksText=String.Empty;
		private string remarksType=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the RemarksID value.
		/// </summary>
		public long RemarksID
		{
			get { return remarksID; }
			set { remarksID = value; }
		}

		/// <summary>
		/// Gets or sets the RemarksCode value.
		/// </summary>
		public string RemarksCode
		{
			get { return remarksCode; }
			set { remarksCode = value; }
		}

		/// <summary>
		/// Gets or sets the RemarksText value.
		/// </summary>
		public string RemarksText
		{
			get { return remarksText; }
			set { remarksText = value; }
		}

		/// <summary>
		/// Gets or sets the RemarksType value.
		/// </summary>
		public string RemarksType
		{
			get { return remarksType; }
			set { remarksType = value; }
		}


		#endregion
}
}
