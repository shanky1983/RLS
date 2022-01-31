using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class CodingSchemeMaster
	{
		#region Fields

		private int codeTypeID=0;
		private string codingSchemaName=String.Empty;
		private string versionNo=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the CodeTypeID value.
		/// </summary>
		public int CodeTypeID
		{
			get { return codeTypeID; }
			set { codeTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the CodingSchemaName value.
		/// </summary>
		public string CodingSchemaName
		{
			get { return codingSchemaName; }
			set { codingSchemaName = value; }
		}

		/// <summary>
		/// Gets or sets the VersionNo value.
		/// </summary>
		public string VersionNo
		{
			get { return versionNo; }
			set { versionNo = value; }
		}

		/// <summary>
		/// Gets or sets the IsPrimary value.
		/// </summary>
		string _isprimary;
		public string IsPrimary
		{
			get { return _isprimary; }
			set { _isprimary = value; }
		}

		/// <summary>
		/// Gets or sets the CodeMasterID value.
		/// </summary>
		int _codemasterid;
		public int CodeMasterID
		{
			get { return _codemasterid; }
			set { _codemasterid = value; }
		}

		/// <summary>
		/// Gets or sets the CodeName value.
		/// </summary>
		string _codename;
		public string CodeName
		{
			get { return _codename; }
			set { _codename = value; }
		}


		#endregion
}
}
