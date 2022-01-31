using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class InvGrpPkg_Error
	{
		#region Fields

		private string t_code=String.Empty;
		private string errortype=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the T_code value.
		/// </summary>
		public string T_code
		{
			get { return t_code; }
			set { t_code = value; }
		}

		/// <summary>
		/// Gets or sets the Errortype value.
		/// </summary>
		public string Errortype
		{
			get { return errortype; }
			set { errortype = value; }
		}


		#endregion
}
}
