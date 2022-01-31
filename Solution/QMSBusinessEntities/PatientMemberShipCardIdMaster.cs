using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class PatientMemberShipCardIdMaster
	{
		#region Fields

		private int iD=0;
		private long orgID=0;
		private long memberShipCardNo=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public long OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the MemberShipCardNo value.
		/// </summary>
		public long MemberShipCardNo
		{
			get { return memberShipCardNo; }
			set { memberShipCardNo = value; }
		}


		#endregion
}
}
