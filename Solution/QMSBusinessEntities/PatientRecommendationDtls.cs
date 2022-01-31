using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class PatientRecommendationDtls
	{
		#region Fields

		private long pRecoDtlsID=0;
		private long recoID=0;
		private int resultID=0;
		private string resultValues=String.Empty;
		private int sequenceNO=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PRecoDtlsID value.
		/// </summary>
		public long PRecoDtlsID
		{
			get { return pRecoDtlsID; }
			set { pRecoDtlsID = value; }
		}

		/// <summary>
		/// Gets or sets the RecoID value.
		/// </summary>
		public long RecoID
		{
			get { return recoID; }
			set { recoID = value; }
		}

		/// <summary>
		/// Gets or sets the ResultID value.
		/// </summary>
		public int ResultID
		{
			get { return resultID; }
			set { resultID = value; }
		}

		/// <summary>
		/// Gets or sets the ResultValues value.
		/// </summary>
		public string ResultValues
		{
			get { return resultValues; }
			set { resultValues = value; }
		}

		/// <summary>
		/// Gets or sets the SequenceNO value.
		/// </summary>
		public int SequenceNO
		{
			get { return sequenceNO; }
			set { sequenceNO = value; }
		}

		/// <summary>
		/// Gets or sets the ResultName value.
		/// </summary>
		string _resultname;
		public string ResultName
		{
			get { return _resultname; }
			set { _resultname = value; }
		}


		#endregion
}
}
