using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class DespatchMode
	{
		#region Fields

		private int despatchID=0;
		private string despatch=String.Empty;
		private string description=String.Empty;
		private string isDisplay=String.Empty;
		private string despatchCode=String.Empty;
		private long clientID=0;
		private int actionTypeID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DespatchID value.
		/// </summary>
		public int DespatchID
		{
			get { return despatchID; }
			set { despatchID = value; }
		}

		/// <summary>
		/// Gets or sets the Despatch value.
		/// </summary>
		public string Despatch
		{
			get { return despatch; }
			set { despatch = value; }
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
		/// Gets or sets the IsDisplay value.
		/// </summary>
		public string IsDisplay
		{
			get { return isDisplay; }
			set { isDisplay = value; }
		}

		/// <summary>
		/// Gets or sets the DespatchCode value.
		/// </summary>
		public string DespatchCode
		{
			get { return despatchCode; }
			set { despatchCode = value; }
		}

		/// <summary>
		/// Gets or sets the ClientID value.
		/// </summary>
		public long ClientID
		{
			get { return clientID; }
			set { clientID = value; }
		}

		/// <summary>
		/// Gets or sets the ActionTypeID value.
		/// </summary>
		public int ActionTypeID
		{
			get { return actionTypeID; }
			set { actionTypeID = value; }
		}


		#endregion
}
}
