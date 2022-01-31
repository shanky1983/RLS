using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class HL7InvCodeMaster
	{
		#region Fields

		private int id=0;
		private string invCodeName=String.Empty;
		private string hL7InvCodeName=String.Empty;
		private string codeType=String.Empty;
		private string codeDesc=String.Empty;
		private int orgId=0;

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
		/// Gets or sets the InvCodeName value.
		/// </summary>
		public string InvCodeName
		{
			get { return invCodeName; }
			set { invCodeName = value; }
		}

		/// <summary>
		/// Gets or sets the HL7InvCodeName value.
		/// </summary>
		public string HL7InvCodeName
		{
			get { return hL7InvCodeName; }
			set { hL7InvCodeName = value; }
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
		/// Gets or sets the CodeDesc value.
		/// </summary>
		public string CodeDesc
		{
			get { return codeDesc; }
			set { codeDesc = value; }
		}

		/// <summary>
		/// Gets or sets the OrgId value.
		/// </summary>
		public int OrgId
		{
			get { return orgId; }
			set { orgId = value; }
		}


		#endregion
}
}
