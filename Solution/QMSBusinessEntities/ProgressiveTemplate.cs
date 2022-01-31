using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ProgressiveTemplate
	{
		#region Fields

		private int templateID=0;
		private string templateType=String.Empty;
		private string subjective=String.Empty;
		private string objective=String.Empty;
		private string assesment=String.Empty;
		private string planning=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the TemplateID value.
		/// </summary>
		public int TemplateID
		{
			get { return templateID; }
			set { templateID = value; }
		}

		/// <summary>
		/// Gets or sets the TemplateType value.
		/// </summary>
		public string TemplateType
		{
			get { return templateType; }
			set { templateType = value; }
		}

		/// <summary>
		/// Gets or sets the Subjective value.
		/// </summary>
		public string Subjective
		{
			get { return subjective; }
			set { subjective = value; }
		}

		/// <summary>
		/// Gets or sets the Objective value.
		/// </summary>
		public string Objective
		{
			get { return objective; }
			set { objective = value; }
		}

		/// <summary>
		/// Gets or sets the Assesment value.
		/// </summary>
		public string Assesment
		{
			get { return assesment; }
			set { assesment = value; }
		}

		/// <summary>
		/// Gets or sets the Planning value.
		/// </summary>
		public string Planning
		{
			get { return planning; }
			set { planning = value; }
		}


		#endregion
}
}
