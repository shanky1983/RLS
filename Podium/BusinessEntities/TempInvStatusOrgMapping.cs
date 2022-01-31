using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class TempInvStatusOrgMapping
	{
		#region Fields

		private int sno=0;
		private string name=String.Empty;
		private string chineseChar=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Sno value.
		/// </summary>
		public int Sno
		{
			get { return sno; }
			set { sno = value; }
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
		/// Gets or sets the ChineseChar value.
		/// </summary>
		public string ChineseChar
		{
			get { return chineseChar; }
			set { chineseChar = value; }
		}


		#endregion
}
}
