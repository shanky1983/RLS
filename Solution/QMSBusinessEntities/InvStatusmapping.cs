using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class InvStatusmapping
	{
		#region Fields

		private int investigationStatusID=0;
		private string mappingID=String.Empty;
		private int orgID=0;
		private int seqNo=0;
		private int iD=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the InvestigationStatusID value.
		/// </summary>
		public int InvestigationStatusID
		{
			get { return investigationStatusID; }
			set { investigationStatusID = value; }
		}

		/// <summary>
		/// Gets or sets the MappingID value.
		/// </summary>
		public string MappingID
		{
			get { return mappingID; }
			set { mappingID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the SeqNo value.
		/// </summary>
		public int SeqNo
		{
			get { return seqNo; }
			set { seqNo = value; }
		}

		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}


		#endregion
}
}
