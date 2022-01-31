using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Duptcode
	{
		#region Fields

		private string codeName=String.Empty;
		private long investigationID=0;
		private string investigationname=String.Empty;
		private long dup=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the CodeName value.
		/// </summary>
		public string CodeName
		{
			get { return codeName; }
			set { codeName = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationID value.
		/// </summary>
		public long InvestigationID
		{
			get { return investigationID; }
			set { investigationID = value; }
		}

		/// <summary>
		/// Gets or sets the Investigationname value.
		/// </summary>
		public string Investigationname
		{
			get { return investigationname; }
			set { investigationname = value; }
		}

		/// <summary>
		/// Gets or sets the Dup value.
		/// </summary>
		public long Dup
		{
			get { return dup; }
			set { dup = value; }
		}


		#endregion
}
}
