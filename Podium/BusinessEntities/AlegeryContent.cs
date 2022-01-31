using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class AlegeryContent
	{
		#region Fields

		private float groupid=0.0F;
		private float testID=0.0F;
		private string groupname=String.Empty;
		private string itemName=String.Empty;
		private string type=String.Empty;
		private float seqNo=0.0F;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Groupid value.
		/// </summary>
		public float Groupid
		{
			get { return groupid; }
			set { groupid = value; }
		}

		/// <summary>
		/// Gets or sets the TestID value.
		/// </summary>
		public float TestID
		{
			get { return testID; }
			set { testID = value; }
		}

		/// <summary>
		/// Gets or sets the Groupname value.
		/// </summary>
		public string Groupname
		{
			get { return groupname; }
			set { groupname = value; }
		}

		/// <summary>
		/// Gets or sets the ItemName value.
		/// </summary>
		public string ItemName
		{
			get { return itemName; }
			set { itemName = value; }
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
		/// Gets or sets the SeqNo value.
		/// </summary>
		public float SeqNo
		{
			get { return seqNo; }
			set { seqNo = value; }
		}


		#endregion
}
}
