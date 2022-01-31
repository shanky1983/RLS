using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Attributes
	{
		#region Fields

		private int attributeID=0;
		private string attributeName=String.Empty;

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


		#endregion
}
}
