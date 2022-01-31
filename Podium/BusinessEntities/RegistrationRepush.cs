using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class RegistrationRepush
	{
		#region Fields

		private int autoId=0;
		private string attributeName=String.Empty;
		private string isDeflag=String.Empty;
		private string isRepush=String.Empty;
		private string fieldId=String.Empty;
		private string controlId=String.Empty;
		private int orgId=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the AutoId value.
		/// </summary>
		public int AutoId
		{
			get { return autoId; }
			set { autoId = value; }
		}

		/// <summary>
		/// Gets or sets the AttributeName value.
		/// </summary>
		public string AttributeName
		{
			get { return attributeName; }
			set { attributeName = value; }
		}

		/// <summary>
		/// Gets or sets the IsDeflag value.
		/// </summary>
		public string IsDeflag
		{
			get { return isDeflag; }
			set { isDeflag = value; }
		}

		/// <summary>
		/// Gets or sets the IsRepush value.
		/// </summary>
		public string IsRepush
		{
			get { return isRepush; }
			set { isRepush = value; }
		}

		/// <summary>
		/// Gets or sets the FieldId value.
		/// </summary>
		public string FieldId
		{
			get { return fieldId; }
			set { fieldId = value; }
		}

		/// <summary>
		/// Gets or sets the ControlId value.
		/// </summary>
		public string ControlId
		{
			get { return controlId; }
			set { controlId = value; }
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
