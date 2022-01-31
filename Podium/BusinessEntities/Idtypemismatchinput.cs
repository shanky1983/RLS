using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Idtypemismatchinput
	{
		#region Fields

		private long id=0;
		private string name=String.Empty;
		private long orgid=0;
		private string type=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id value.
		/// </summary>
		public long Id
		{
			get { return id; }
			set { id = value; }
		}

		/// <summary>
		/// Gets or sets the Name value.
		/// </summary>
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		/// <summary>
		/// Gets or sets the Orgid value.
		/// </summary>
		public long Orgid
		{
			get { return orgid; }
			set { orgid = value; }
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
