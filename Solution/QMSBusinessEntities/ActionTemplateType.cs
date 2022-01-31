using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ActionTemplateType
	{
		#region Fields

		private int templateTypeID=0;
		private string templateType=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the TemplateTypeID value.
		/// </summary>
		public int TemplateTypeID
		{
			get { return templateTypeID; }
			set { templateTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the TemplateType value.
		/// </summary>
		public string TemplateType
		{
			get { return templateType; }
			set { templateType = value; }
		}


		#endregion
}
}
