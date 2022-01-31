using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class CodeMapper
	{
		#region Fields

		private int codeMapperID=0;
		private string identifyingType=String.Empty;
		private int identifyingID=0;
		private int codeMasterID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the CodeMapperID value.
		/// </summary>
		public int CodeMapperID
		{
			get { return codeMapperID; }
			set { codeMapperID = value; }
		}

		/// <summary>
		/// Gets or sets the IdentifyingType value.
		/// </summary>
		public string IdentifyingType
		{
			get { return identifyingType; }
			set { identifyingType = value; }
		}

		/// <summary>
		/// Gets or sets the IdentifyingID value.
		/// </summary>
		public int IdentifyingID
		{
			get { return identifyingID; }
			set { identifyingID = value; }
		}

		/// <summary>
		/// Gets or sets the CodeMasterID value.
		/// </summary>
		public int CodeMasterID
		{
			get { return codeMasterID; }
			set { codeMasterID = value; }
		}


		#endregion
}
}
