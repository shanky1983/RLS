using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ErrorLog
	{
		#region Fields

		private int errorLogid=0;
		private int errorLine=0;
		private string errorDesc=String.Empty;
		private string objectName=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ErrorLogid value.
		/// </summary>
		public int ErrorLogid
		{
			get { return errorLogid; }
			set { errorLogid = value; }
		}

		/// <summary>
		/// Gets or sets the ErrorLine value.
		/// </summary>
		public int ErrorLine
		{
			get { return errorLine; }
			set { errorLine = value; }
		}

		/// <summary>
		/// Gets or sets the ErrorDesc value.
		/// </summary>
		public string ErrorDesc
		{
			get { return errorDesc; }
			set { errorDesc = value; }
		}

		/// <summary>
		/// Gets or sets the ObjectName value.
		/// </summary>
		public string ObjectName
		{
			get { return objectName; }
			set { objectName = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedAt value.
		/// </summary>
		public DateTime CreatedAt
		{
			get { return createdAt; }
			set { createdAt = value; }
		}


		#endregion
}
}
