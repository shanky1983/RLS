using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class TempTATDet
	{
		#region Fields

		private long investigationid=0;
		private string testType=String.Empty;
		private string tatType=String.Empty;
		private decimal labstart=Decimal.Zero;
		private decimal labEnd=Decimal.Zero;
		private decimal reporttime=Decimal.Zero;
		private int processingTime=0;
		private string tatmode=String.Empty;
		private string daynam=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Investigationid value.
		/// </summary>
		public long Investigationid
		{
			get { return investigationid; }
			set { investigationid = value; }
		}

		/// <summary>
		/// Gets or sets the TestType value.
		/// </summary>
		public string TestType
		{
			get { return testType; }
			set { testType = value; }
		}

		/// <summary>
		/// Gets or sets the TatType value.
		/// </summary>
		public string TatType
		{
			get { return tatType; }
			set { tatType = value; }
		}

		/// <summary>
		/// Gets or sets the Labstart value.
		/// </summary>
		public decimal Labstart
		{
			get { return labstart; }
			set { labstart = value; }
		}

		/// <summary>
		/// Gets or sets the LabEnd value.
		/// </summary>
		public decimal LabEnd
		{
			get { return labEnd; }
			set { labEnd = value; }
		}

		/// <summary>
		/// Gets or sets the Reporttime value.
		/// </summary>
		public decimal Reporttime
		{
			get { return reporttime; }
			set { reporttime = value; }
		}

		/// <summary>
		/// Gets or sets the ProcessingTime value.
		/// </summary>
		public int ProcessingTime
		{
			get { return processingTime; }
			set { processingTime = value; }
		}

		/// <summary>
		/// Gets or sets the Tatmode value.
		/// </summary>
		public string Tatmode
		{
			get { return tatmode; }
			set { tatmode = value; }
		}

		/// <summary>
		/// Gets or sets the Daynam value.
		/// </summary>
		public string Daynam
		{
			get { return daynam; }
			set { daynam = value; }
		}


		#endregion
}
}
