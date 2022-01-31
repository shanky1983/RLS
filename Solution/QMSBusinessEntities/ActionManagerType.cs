using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ActionManagerType
	{
		#region Fields

		private int actionTypeID=0;
		private string actionType=String.Empty;
		private string isDisplay=String.Empty;
		private string actionCode=String.Empty;
		private string type=String.Empty;
		private string langCode=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ActionTypeID value.
		/// </summary>
		public int ActionTypeID
		{
			get { return actionTypeID; }
			set { actionTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the ActionType value.
		/// </summary>
		public string ActionType
		{
			get { return actionType; }
			set { actionType = value; }
		}

		/// <summary>
		/// Gets or sets the IsDisplay value.
		/// </summary>
		public string IsDisplay
		{
			get { return isDisplay; }
			set { isDisplay = value; }
		}

		/// <summary>
		/// Gets or sets the ActionCode value.
		/// </summary>
		public string ActionCode
		{
			get { return actionCode; }
			set { actionCode = value; }
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
		/// Gets or sets the LangCode value.
		/// </summary>
		public string LangCode
		{
			get { return langCode; }
			set { langCode = value; }
		}


		#endregion
}
}
