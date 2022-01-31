using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class AuthorisedTypeMaster
	{
		#region Fields

		private long authoriseTypeId=0;
		private string typeName=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the AuthoriseTypeId value.
		/// </summary>
		public long AuthoriseTypeId
		{
			get { return authoriseTypeId; }
			set { authoriseTypeId = value; }
		}

		/// <summary>
		/// Gets or sets the TypeName value.
		/// </summary>
		public string TypeName
		{
			get { return typeName; }
			set { typeName = value; }
		}


		#endregion
}
}
