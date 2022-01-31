using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class AdditionalTubeMapping
	{
		#region Fields

		private int iD=0;
		private string type=String.Empty;
		private long sampleCode=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public int ID
		{
			get { return iD; }
			set { iD = value; }
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
		/// Gets or sets the SampleCode value.
		/// </summary>
		public long SampleCode
		{
			get { return sampleCode; }
			set { sampleCode = value; }
		}

		/// <summary>
		/// Gets or sets the IsActive value.
		/// </summary>
		private char _isActive=new char();
		public char IsActive
		{
			get { return  _isActive; }
			set { _isActive = value; }
		}


		#endregion
}
}
