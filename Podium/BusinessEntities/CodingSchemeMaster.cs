using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
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
		private string _isPrimary=String.Empty;
		public string IsPrimary
		{
			get { return  _isPrimary; }
			set { _isPrimary = value; }
		}

		/// <summary>
		/// Gets or sets the CodeMasterID value.
		/// </summary>
		private int _codeMasterID=0;
		public int CodeMasterID
		{
			get { return  _codeMasterID; }
			set { _codeMasterID = value; }
		}

		/// <summary>
		/// Gets or sets the CodeName value.
		/// </summary>
		private string _codeName=String.Empty;
		public string CodeName
		{
			get { return  _codeName; }
			set { _codeName = value; }
		}


		#endregion
}
}
