using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ProcedureSpeciality
	{
		#region Fields

		private int specialityID=0;
		private int procedureID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the SpecialityID value.
		/// </summary>
		public int SpecialityID
		{
			get { return specialityID; }
			set { specialityID = value; }
		}

		/// <summary>
		/// Gets or sets the ProcedureID value.
		/// </summary>
		public int ProcedureID
		{
			get { return procedureID; }
			set { procedureID = value; }
		}


		#endregion
}
}
