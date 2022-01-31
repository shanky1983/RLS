using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Pagecontext_removeRoundDBprint
	{
		#region Fields

		private long mappingID=0;
		private long pageContextID=0;
		private long roleID=0;
		private int actionTypeID=0;
		private int templateID=0;
		private string contextType=String.Empty;
		private string additionalContext=String.Empty;
		private string description=String.Empty;
		private string isAttachment=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the MappingID value.
		/// </summary>
		public long MappingID
		{
			get { return mappingID; }
			set { mappingID = value; }
		}

		/// <summary>
		/// Gets or sets the PageContextID value.
		/// </summary>
		public long PageContextID
		{
			get { return pageContextID; }
			set { pageContextID = value; }
		}

		/// <summary>
		/// Gets or sets the RoleID value.
		/// </summary>
		public long RoleID
		{
			get { return roleID; }
			set { roleID = value; }
		}

		/// <summary>
		/// Gets or sets the ActionTypeID value.
		/// </summary>
		public int ActionTypeID
		{
			get { return actionTypeID; }
			set { actionTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the TemplateID value.
		/// </summary>
		public int TemplateID
		{
			get { return templateID; }
			set { templateID = value; }
		}

		/// <summary>
		/// Gets or sets the ContextType value.
		/// </summary>
		public string ContextType
		{
			get { return contextType; }
			set { contextType = value; }
		}

		/// <summary>
		/// Gets or sets the AdditionalContext value.
		/// </summary>
		public string AdditionalContext
		{
			get { return additionalContext; }
			set { additionalContext = value; }
		}

		/// <summary>
		/// Gets or sets the Description value.
		/// </summary>
		public string Description
		{
			get { return description; }
			set { description = value; }
		}

		/// <summary>
		/// Gets or sets the IsAttachment value.
		/// </summary>
		public string IsAttachment
		{
			get { return isAttachment; }
			set { isAttachment = value; }
		}


		#endregion
}
}
