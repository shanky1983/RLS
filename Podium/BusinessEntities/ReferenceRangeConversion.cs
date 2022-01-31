using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ReferenceRangeConversion
	{
		#region Fields

		private int iD=0;
		private string referenceRange=String.Empty;
		private long investigationid=0;
		private int orgid=0;
		private string outputReferencerane=String.Empty;
		private string ranges=String.Empty;

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
		/// Gets or sets the ReferenceRange value.
		/// </summary>
		public string ReferenceRange
		{
			get { return referenceRange; }
			set { referenceRange = value; }
		}

		/// <summary>
		/// Gets or sets the Investigationid value.
		/// </summary>
		public long Investigationid
		{
			get { return investigationid; }
			set { investigationid = value; }
		}

		/// <summary>
		/// Gets or sets the Orgid value.
		/// </summary>
		public int Orgid
		{
			get { return orgid; }
			set { orgid = value; }
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
