using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class InvClientType
	{
		#region Fields

		private int clientTypeID=0;
		private string clientTypeName=String.Empty;
		private string isInternal=String.Empty;
		private string clientTypeCode=String.Empty;
		private string display=String.Empty;
		private string langCode=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ClientTypeID value.
		/// </summary>
		public int ClientTypeID
		{
			get { return clientTypeID; }
			set { clientTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the ClientTypeName value.
		/// </summary>
		public string ClientTypeName
		{
			get { return clientTypeName; }
			set { clientTypeName = value; }
		}

		/// <summary>
		/// Gets or sets the IsInternal value.
		/// </summary>
		public string IsInternal
		{
			get { return isInternal; }
			set { isInternal = value; }
		}

		/// <summary>
		/// Gets or sets the ClientTypeCode value.
		/// </summary>
		public string ClientTypeCode
		{
			get { return clientTypeCode; }
			set { clientTypeCode = value; }
		}

		/// <summary>
		/// Gets or sets the Display value.
		/// </summary>
		public string Display
		{
			get { return display; }
			set { display = value; }
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
