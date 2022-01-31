using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class GD_GraphTests
	{
		#region Fields

		private int orgID=0;
		private int identifyingID=0;
		private int attuneID=0;
		private string codeType=String.Empty;
		private string codeName=String.Empty;
		private string codeDesc=String.Empty;
		private string graph_Code=String.Empty;
		private int graph_Code_ID=0;
		private string identifier=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
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
		/// Gets or sets the AttuneID value.
		/// </summary>
		public int AttuneID
		{
			get { return attuneID; }
			set { attuneID = value; }
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
		/// Gets or sets the CodeName value.
		/// </summary>
		public string CodeName
		{
			get { return codeName; }
			set { codeName = value; }
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
		/// Gets or sets the Graph_Code value.
		/// </summary>
		public string Graph_Code
		{
			get { return graph_Code; }
			set { graph_Code = value; }
		}

		/// <summary>
		/// Gets or sets the Graph_Code_ID value.
		/// </summary>
		public int Graph_Code_ID
		{
			get { return graph_Code_ID; }
			set { graph_Code_ID = value; }
		}

		/// <summary>
		/// Gets or sets the Identifier value.
		/// </summary>
		public string Identifier
		{
			get { return identifier; }
			set { identifier = value; }
		}


		#endregion
}
}
