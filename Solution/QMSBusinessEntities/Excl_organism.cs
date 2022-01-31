using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Excl_organism
	{
		#region Fields

		private string testCode=String.Empty;
		private string testName=String.Empty;
		private string organism=String.Empty;
		private string brandName=String.Empty;
		private float sequenceNo=0.0F;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the TestCode value.
		/// </summary>
		public string TestCode
		{
			get { return testCode; }
			set { testCode = value; }
		}

		/// <summary>
		/// Gets or sets the TestName value.
		/// </summary>
		public string TestName
		{
			get { return testName; }
			set { testName = value; }
		}

		/// <summary>
		/// Gets or sets the Organism value.
		/// </summary>
		public string Organism
		{
			get { return organism; }
			set { organism = value; }
		}

		/// <summary>
		/// Gets or sets the BrandName value.
		/// </summary>
		public string BrandName
		{
			get { return brandName; }
			set { brandName = value; }
		}

		/// <summary>
		/// Gets or sets the SequenceNo value.
		/// </summary>
		public float SequenceNo
		{
			get { return sequenceNo; }
			set { sequenceNo = value; }
		}


		#endregion
}
}
