using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class TATORDTABLE
	{
		#region Fields

		private long tatid=0;
		private string feetype=String.Empty;
		private long feeId=0;
		private DateTime tatdate=DateTime.MaxValue;
		private DateTime reportdate=DateTime.MaxValue;
		private DateTime createdAt=DateTime.MaxValue;
		private string remarks=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Tatid value.
		/// </summary>
		public long Tatid
		{
			get { return tatid; }
			set { tatid = value; }
		}

		/// <summary>
		/// Gets or sets the Feetype value.
		/// </summary>
		public string Feetype
		{
			get { return feetype; }
			set { feetype = value; }
		}

		/// <summary>
		/// Gets or sets the FeeId value.
		/// </summary>
		public long FeeId
		{
			get { return feeId; }
			set { feeId = value; }
		}

		/// <summary>
		/// Gets or sets the Tatdate value.
		/// </summary>
		public DateTime Tatdate
		{
			get { return tatdate; }
			set { tatdate = value; }
		}

		/// <summary>
		/// Gets or sets the Reportdate value.
		/// </summary>
		public DateTime Reportdate
		{
			get { return reportdate; }
			set { reportdate = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedAt value.
		/// </summary>
		public DateTime CreatedAt
		{
			get { return createdAt; }
			set { createdAt = value; }
		}

		/// <summary>
		/// Gets or sets the Remarks value.
		/// </summary>
		public string Remarks
		{
			get { return remarks; }
			set { remarks = value; }
		}


		#endregion
}
}
