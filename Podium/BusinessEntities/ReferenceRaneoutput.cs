using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ReferenceRaneoutput
	{
		#region Fields

		private int id=0;
		private string outputReferencerane=String.Empty;
		private string ranges=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id value.
		/// </summary>
		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		/// <summary>
		/// Gets or sets the OutputReferencerane value.
		/// </summary>
		public string OutputReferencerane
		{
			get { return outputReferencerane; }
			set { outputReferencerane = value; }
		}

		/// <summary>
		/// Gets or sets the Ranges value.
		/// </summary>
		public string Ranges
		{
			get { return ranges; }
			set { ranges = value; }
		}


		#endregion
}
}
