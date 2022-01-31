using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PIreferece
	{
		#region Fields

		private string referencerange=String.Empty;
		private string referenceranges=String.Empty;
		private long patientvisitid=0;
		private long investigationid=0;
		private long accessionnumber=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Referencerange value.
		/// </summary>
		public string Referencerange
		{
			get { return referencerange; }
			set { referencerange = value; }
		}

		/// <summary>
		/// Gets or sets the Referenceranges value.
		/// </summary>
		public string Referenceranges
		{
			get { return referenceranges; }
			set { referenceranges = value; }
		}

		/// <summary>
		/// Gets or sets the Patientvisitid value.
		/// </summary>
		public long Patientvisitid
		{
			get { return patientvisitid; }
			set { patientvisitid = value; }
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
		/// Gets or sets the Accessionnumber value.
		/// </summary>
		public long Accessionnumber
		{
			get { return accessionnumber; }
			set { accessionnumber = value; }
		}


		#endregion
}
}
