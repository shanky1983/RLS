using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Patientmigdetailinfo
	{
		#region Fields

		private long oldid=0;
		private long newpatientid=0;
		private string patientnumber=String.Empty;
		private int orgid=0;
		private DateTime processdate=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Oldid value.
		/// </summary>
		public long Oldid
		{
			get { return oldid; }
			set { oldid = value; }
		}

		/// <summary>
		/// Gets or sets the Newpatientid value.
		/// </summary>
		public long Newpatientid
		{
			get { return newpatientid; }
			set { newpatientid = value; }
		}

		/// <summary>
		/// Gets or sets the Patientnumber value.
		/// </summary>
		public string Patientnumber
		{
			get { return patientnumber; }
			set { patientnumber = value; }
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
		/// Gets or sets the Processdate value.
		/// </summary>
		public DateTime Processdate
		{
			get { return processdate; }
			set { processdate = value; }
		}


		#endregion
}
}
