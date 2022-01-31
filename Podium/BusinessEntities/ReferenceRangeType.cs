using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ReferenceRangeType
	{
		#region Fields

		private int id=0;
		private string rangeName=String.Empty;
		private string type=String.Empty;
		private string code=String.Empty;
		private int sequenceNo=0;
		private int orgId=0;
		private string color=String.Empty;
		private string languageCode=String.Empty;
		private string bound=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id value.
		/// </summary>
		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		/// <summary>
		/// Gets or sets the RangeName value.
		/// </summary>
		public string RangeName
		{
			get { return rangeName; }
			set { rangeName = value; }
		}

		/// <summary>
		/// Gets or sets the Type value.
		/// </summary>
		public string Type
		{
			get { return type; }
			set { type = value; }
		}

		/// <summary>
		/// Gets or sets the Code value.
		/// </summary>
		public string Code
		{
			get { return code; }
			set { code = value; }
		}

		/// <summary>
		/// Gets or sets the SequenceNo value.
		/// </summary>
		public int SequenceNo
		{
			get { return sequenceNo; }
			set { sequenceNo = value; }
		}

		/// <summary>
		/// Gets or sets the OrgId value.
		/// </summary>
		public int OrgId
		{
			get { return orgId; }
			set { orgId = value; }
		}

		/// <summary>
		/// Gets or sets the Color value.
		/// </summary>
		public string Color
		{
			get { return color; }
			set { color = value; }
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
		/// Gets or sets the Bound value.
		/// </summary>
		public string Bound
		{
			get { return bound; }
			set { bound = value; }
		}


		#endregion
}
}
