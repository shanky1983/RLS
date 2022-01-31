using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class AllergyMaster
	{
		#region Fields

		private int allergyId=0;
		private string allergyName=String.Empty;
		private string allergyType=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the AllergyId value.
		/// </summary>
		public int AllergyId
		{
			get { return allergyId; }
			set { allergyId = value; }
		}

		/// <summary>
		/// Gets or sets the AllergyName value.
		/// </summary>
		public string AllergyName
		{
			get { return allergyName; }
			set { allergyName = value; }
		}

		/// <summary>
		/// Gets or sets the AllergyType value.
		/// </summary>
		public string AllergyType
		{
			get { return allergyType; }
			set { allergyType = value; }
		}


		#endregion
}
}
