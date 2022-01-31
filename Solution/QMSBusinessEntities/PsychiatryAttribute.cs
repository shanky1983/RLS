using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class PsychiatryAttribute
	{
		#region Fields

		private int attributeID=0;
		private string attributeName=String.Empty;
		private int masterExaminationID=0;
		private int sequence=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the AttributeID value.
		/// </summary>
		public int AttributeID
		{
			get { return attributeID; }
			set { attributeID = value; }
		}

		/// <summary>
		/// Gets or sets the AttributeName value.
		/// </summary>
		public string AttributeName
		{
			get { return attributeName; }
			set { attributeName = value; }
		}

		/// <summary>
		/// Gets or sets the MasterExaminationID value.
		/// </summary>
		public int MasterExaminationID
		{
			get { return masterExaminationID; }
			set { masterExaminationID = value; }
		}

		/// <summary>
		/// Gets or sets the Sequence value.
		/// </summary>
		public int Sequence
		{
			get { return sequence; }
			set { sequence = value; }
		}


		#endregion
}
}
