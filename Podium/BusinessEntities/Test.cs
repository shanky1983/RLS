using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Test
	{
		#region Fields

		private int id=0;
		private byte[] bbb=new byte[0];

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id value.
		/// </summary>
		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		/// <summary>
		/// Gets or sets the Bbb value.
		/// </summary>
		public byte[] Bbb
		{
			get { return bbb; }
			set { bbb = value; }
		}


		#endregion
}
}
