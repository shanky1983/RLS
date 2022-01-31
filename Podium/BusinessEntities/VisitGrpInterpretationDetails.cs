using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class VisitGrpInterpretationDetails
	{
		#region Fields

		private long iD=0;
		private long visitId=0;
		private int orgID=0;
		private long attGrpId=0;
		private long orgGroupID=0;
		private string identityType=String.Empty;
		private long accessionNumber=0;
		private string interpretation=String.Empty;

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
		/// Gets or sets the VisitId value.
		/// </summary>
		public long VisitId
		{
			get { return visitId; }
			set { visitId = value; }
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
		/// Gets or sets the AttGrpId value.
		/// </summary>
		public long AttGrpId
		{
			get { return attGrpId; }
			set { attGrpId = value; }
		}

		/// <summary>
		/// Gets or sets the OrgGroupID value.
		/// </summary>
		public long OrgGroupID
		{
			get { return orgGroupID; }
			set { orgGroupID = value; }
		}

		/// <summary>
		/// Gets or sets the IdentityType value.
		/// </summary>
		public string IdentityType
		{
			get { return identityType; }
			set { identityType = value; }
		}

		/// <summary>
		/// Gets or sets the AccessionNumber value.
		/// </summary>
		public long AccessionNumber
		{
			get { return accessionNumber; }
			set { accessionNumber = value; }
		}

		/// <summary>
		/// Gets or sets the Interpretation value.
		/// </summary>
		public string Interpretation
		{
			get { return interpretation; }
			set { interpretation = value; }
		}


		#endregion
}
}
