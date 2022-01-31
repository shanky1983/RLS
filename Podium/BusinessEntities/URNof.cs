using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class URNof
	{
		#region Fields

		private string uRNOf=String.Empty;
		private long uRNOfId=0;
		private string langCode=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the URNOf value.
		/// </summary>
		public string URNOf
		{
			get { return uRNOf; }
			set { uRNOf = value; }
		}

		/// <summary>
		/// Gets or sets the URNOfId value.
		/// </summary>
		public long URNOfId
		{
			get { return uRNOfId; }
			set { uRNOfId = value; }
		}

		/// <summary>
		/// Gets or sets the LangCode value.
		/// </summary>
		public string LangCode
		{
			get { return langCode; }
			set { langCode = value; }
		}


		#endregion
}
}
