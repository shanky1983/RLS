using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class PageContext
	{
		#region Fields

		private long pageContextID=0;
		private long pageID=0;
		private string buttonName=String.Empty;
		private string buttionValue=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PageContextID value.
		/// </summary>
		public long PageContextID
		{
			get { return pageContextID; }
			set { pageContextID = value; }
		}

		/// <summary>
		/// Gets or sets the PageID value.
		/// </summary>
		public long PageID
		{
			get { return pageID; }
			set { pageID = value; }
		}

		/// <summary>
		/// Gets or sets the ButtonName value.
		/// </summary>
		public string ButtonName
		{
			get { return buttonName; }
			set { buttonName = value; }
		}

		/// <summary>
		/// Gets or sets the ButtionValue value.
		/// </summary>
		public string ButtionValue
		{
			get { return buttionValue; }
			set { buttionValue = value; }
		}


		#endregion
}
}
