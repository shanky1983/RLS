using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class DebitNoteIDMaster
	{
		#region Fields

		private long iD=0;
		private long debitNoteNumber=0;
		private int orgID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public long ID
		{
			get { return iD; }
			set { iD = value; }
		}

		/// <summary>
		/// Gets or sets the DebitNoteNumber value.
		/// </summary>
		public long DebitNoteNumber
		{
			get { return debitNoteNumber; }
			set { debitNoteNumber = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}


		#endregion
}
}
