using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class AuthoriseUserRoleMapping
	{
		#region Fields

		private long id=0;
		private long authoriseTypeId=0;
		private long userId=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long orgId=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id value.
		/// </summary>
		public long Id
		{
			get { return id; }
			set { id = value; }
		}

		/// <summary>
		/// Gets or sets the AuthoriseTypeId value.
		/// </summary>
		public long AuthoriseTypeId
		{
			get { return authoriseTypeId; }
			set { authoriseTypeId = value; }
		}

		/// <summary>
		/// Gets or sets the UserId value.
		/// </summary>
		public long UserId
		{
			get { return userId; }
			set { userId = value; }
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

		/// <summary>
		/// Gets or sets the OrgId value.
		/// </summary>
		public long OrgId
		{
			get { return orgId; }
			set { orgId = value; }
		}


		#endregion
}
}
