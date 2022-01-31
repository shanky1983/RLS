using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ReasonType
	{
		#region Fields

		private int typeID=0;
		private short categoryID=0;
		private string displayText=String.Empty;
		private string typeCode=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the TypeID value.
		/// </summary>
		public int TypeID
		{
			get { return typeID; }
			set { typeID = value; }
		}

		/// <summary>
		/// Gets or sets the CategoryID value.
		/// </summary>
		public short CategoryID
		{
			get { return categoryID; }
			set { categoryID = value; }
		}

		/// <summary>
		/// Gets or sets the DisplayText value.
		/// </summary>
		public string DisplayText
		{
			get { return displayText; }
			set { displayText = value; }
		}

		/// <summary>
		/// Gets or sets the TypeCode value.
		/// </summary>
		public string TypeCode
		{
			get { return typeCode; }
			set { typeCode = value; }
		}


		#endregion
}
}
