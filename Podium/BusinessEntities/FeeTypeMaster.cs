using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class FeeTypeMaster
	{
		#region Fields

		private int feeTypeID=0;
		private string feeType=String.Empty;
		private string feeTypeDesc=String.Empty;
		private string isBillable=String.Empty;
		private string isServiceable=String.Empty;
		private string languageCode=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the FeeTypeID value.
		/// </summary>
		public int FeeTypeID
		{
			get { return feeTypeID; }
			set { feeTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the FeeType value.
		/// </summary>
		public string FeeType
		{
			get { return feeType; }
			set { feeType = value; }
		}

		/// <summary>
		/// Gets or sets the FeeTypeDesc value.
		/// </summary>
		public string FeeTypeDesc
		{
			get { return feeTypeDesc; }
			set { feeTypeDesc = value; }
		}

		/// <summary>
		/// Gets or sets the IsBillable value.
		/// </summary>
		public string IsBillable
		{
			get { return isBillable; }
			set { isBillable = value; }
		}

		/// <summary>
		/// Gets or sets the IsServiceable value.
		/// </summary>
		public string IsServiceable
		{
			get { return isServiceable; }
			set { isServiceable = value; }
		}

		/// <summary>
		/// Gets or sets the LanguageCode value.
		/// </summary>
		public string LanguageCode
		{
			get { return languageCode; }
			set { languageCode = value; }
		}

		/// <summary>
		/// Gets or sets the FeeEditable value.
		/// </summary>
		private string _feeEditable=String.Empty;
		public string FeeEditable
		{
			get { return  _feeEditable; }
			set { _feeEditable = value; }
		}

		/// <summary>
		/// Gets or sets the AutoCompPrefLen value.
		/// </summary>
		private int _autoCompPrefLen=0;
		public int AutoCompPrefLen
		{
			get { return  _autoCompPrefLen; }
			set { _autoCompPrefLen = value; }
		}


		#endregion
}
}
