using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class InvOrgNotifications
	{
		#region Fields

		private int orgNotificationID=0;
		private long investigationID=0;
		private int orgID=0;
		private string type=String.Empty;
		private int actionTypeID=0;
		private int actionTemplateID=0;
		private string notifiedTo=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the OrgNotificationID value.
		/// </summary>
		public int OrgNotificationID
		{
			get { return orgNotificationID; }
			set { orgNotificationID = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationID value.
		/// </summary>
		public long InvestigationID
		{
			get { return investigationID; }
			set { investigationID = value; }
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
		/// Gets or sets the Type value.
		/// </summary>
		public string Type
		{
			get { return type; }
			set { type = value; }
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
		/// Gets or sets the ActionTemplateID value.
		/// </summary>
		public int ActionTemplateID
		{
			get { return actionTemplateID; }
			set { actionTemplateID = value; }
		}

		/// <summary>
		/// Gets or sets the NotifiedTo value.
		/// </summary>
		public string NotifiedTo
		{
			get { return notifiedTo; }
			set { notifiedTo = value; }
		}

		/// <summary>
		/// Gets or sets the ActionType value.
		/// </summary>
		string _actiontype;
		public string ActionType
		{
			get { return _actiontype; }
			set { _actiontype = value; }
		}

		/// <summary>
		/// Gets or sets the ActionTypeTemplateID value.
		/// </summary>
		int _actiontypetemplateid;
		public int ActionTypeTemplateID
		{
			get { return _actiontypetemplateid; }
			set { _actiontypetemplateid = value; }
		}


		#endregion
}
}
