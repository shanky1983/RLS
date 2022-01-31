using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
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
		private long _uRNof=0;
		public long URNof
		{
			get { return  _uRNof; }
			set { _uRNof = value; }
		}

		/// <summary>
		/// Gets or sets the URN value.
		/// </summary>
		private string _uRN=String.Empty;
		public string URN
		{
			get { return  _uRN; }
			set { _uRN = value; }
		}

		/// <summary>
		/// Gets or sets the ExpDate value.
		/// </summary>
		private DateTime _expDate=DateTime.MaxValue;
		public DateTime ExpDate
		{
			get { return  _expDate; }
			set { _expDate = value; }
		}

		/// <summary>
		/// Gets or sets the SeqNo value.
		/// </summary>
		private int _seqNo=0;
		public int SeqNo
		{
			get { return  _seqNo; }
			set { _seqNo = value; }
		}

		/// <summary>
		/// Gets or sets the Displaytext value.
		/// </summary>
		private string _displaytext=String.Empty;
		public string Displaytext
		{
			get { return  _displaytext; }
			set { _displaytext = value; }
		}


		#endregion
}
}
