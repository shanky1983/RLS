using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class CodeMaster
	{
		#region Fields

		private int codeMasterID=0;
		private string codeName=String.Empty;
		private string codeType=String.Empty;
		private int codeSchemeID=0;
		private string codeDesc=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the CodeMasterID value.
		/// </summary>
		public int CodeMasterID
		{
			get { return codeMasterID; }
			set { codeMasterID = value; }
		}

		/// <summary>
		/// Gets or sets the CodeName value.
		/// </summary>
		public string CodeName
		{
			get { return codeName; }
			set { codeName = value; }
		}

		/// <summary>
		/// Gets or sets the CodeType value.
		/// </summary>
		public string CodeType
		{
			get { return codeType; }
			set { codeType = value; }
		}

		/// <summary>
		/// Gets or sets the CodeSchemeID value.
		/// </summary>
		public int CodeSchemeID
		{
			get { return codeSchemeID; }
			set { codeSchemeID = value; }
		}

		/// <summary>
		/// Gets or sets the CodeDesc value.
		/// </summary>
		public string CodeDesc
		{
			get { return codeDesc; }
			set { codeDesc = value; }
		}

		/// <summary>
		/// Gets or sets the CodeLabel value.
		/// </summary>
		private string _codeLabel=String.Empty;
		public string CodeLabel
		{
			get { return  _codeLabel; }
			set { _codeLabel = value; }
		}

		/// <summary>
		/// Gets or sets the CodeTextbox value.
		/// </summary>
		private string _codeTextbox=String.Empty;
		public string CodeTextbox
		{
			get { return  _codeTextbox; }
			set { _codeTextbox = value; }
		}


		#endregion
}
}
