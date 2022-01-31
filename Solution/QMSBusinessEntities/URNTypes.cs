using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class URNTypes
	{
		#region Fields

		private string uRNType=String.Empty;
		private long uRNTypeId=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the URNType value.
		/// </summary>
		public string URNType
		{
			get { return uRNType; }
			set { uRNType = value; }
		}

		/// <summary>
		/// Gets or sets the URNTypeId value.
		/// </summary>
		public long URNTypeId
		{
			get { return uRNTypeId; }
			set { uRNTypeId = value; }
		}

		/// <summary>
		/// Gets or sets the URNof value.
		/// </summary>
		long _urnof;
		public long URNof
		{
			get { return _urnof; }
			set { _urnof = value; }
		}

		/// <summary>
		/// Gets or sets the URN value.
		/// </summary>
		string _urn;
		public string URN
		{
			get { return _urn; }
			set { _urn = value; }
		}

		/// <summary>
		/// Gets or sets the ExpDate value.
		/// </summary>
		DateTime _expdate;
		public DateTime ExpDate
		{
			get { return _expdate; }
			set { _expdate = value; }
		}


		#endregion
}
}
