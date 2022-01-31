using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class BirthInstructions
	{
		#region Fields

		private long instructionID=0;
		private string instructions=String.Empty;
		private long birthRegID=0;
		private long visitID=0;
		private int orgID=0;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the InstructionID value.
		/// </summary>
		public long InstructionID
		{
			get { return instructionID; }
			set { instructionID = value; }
		}

		/// <summary>
		/// Gets or sets the Instructions value.
		/// </summary>
		public string Instructions
		{
			get { return instructions; }
			set { instructions = value; }
		}

		/// <summary>
		/// Gets or sets the BirthRegID value.
		/// </summary>
		public long BirthRegID
		{
			get { return birthRegID; }
			set { birthRegID = value; }
		}

		/// <summary>
		/// Gets or sets the VisitID value.
		/// </summary>
		public long VisitID
		{
			get { return visitID; }
			set { visitID = value; }
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
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public long ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public long CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedAt value.
		/// </summary>
		public DateTime CreatedAt
		{
			get { return createdAt; }
			set { createdAt = value; }
		}


		#endregion
}
}
