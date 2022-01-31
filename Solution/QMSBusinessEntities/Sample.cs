using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Sample
	{
		#region Fields

		private float sampleCode=0.0F;
		private string sampleDesc=String.Empty;
		private string code=String.Empty;
		private string active=String.Empty;
		private string type=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the SampleCode value.
		/// </summary>
		public float SampleCode
		{
			get { return sampleCode; }
			set { sampleCode = value; }
		}

		/// <summary>
		/// Gets or sets the SampleDesc value.
		/// </summary>
		public string SampleDesc
		{
			get { return sampleDesc; }
			set { sampleDesc = value; }
		}

		/// <summary>
		/// Gets or sets the Code value.
		/// </summary>
		public string Code
		{
			get { return code; }
			set { code = value; }
		}

		/// <summary>
		/// Gets or sets the Active value.
		/// </summary>
		public string Active
		{
			get { return active; }
			set { active = value; }
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
