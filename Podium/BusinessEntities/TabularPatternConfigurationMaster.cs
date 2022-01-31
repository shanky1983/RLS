using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class TabularPatternConfigurationMaster
	{
		#region Fields

		private int iD=0;
		private long investigationID=0;
		private int orgID=0;
		private string headerName=String.Empty;
		private string controlType=String.Empty;
		private bool isActive=false;
		private int height=0;
		private int width=0;
		private string langCode=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public int ID
		{
			get { return iD; }
			set { iD = value; }
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
		/// Gets or sets the HeaderName value.
		/// </summary>
		public string HeaderName
		{
			get { return headerName; }
			set { headerName = value; }
		}

		/// <summary>
		/// Gets or sets the ControlType value.
		/// </summary>
		public string ControlType
		{
			get { return controlType; }
			set { controlType = value; }
		}

		/// <summary>
		/// Gets or sets the IsActive value.
		/// </summary>
		public bool IsActive
		{
			get { return isActive; }
			set { isActive = value; }
		}

		/// <summary>
		/// Gets or sets the Height value.
		/// </summary>
		public int Height
		{
			get { return height; }
			set { height = value; }
		}

		/// <summary>
		/// Gets or sets the Width value.
		/// </summary>
		public int Width
		{
			get { return width; }
			set { width = value; }
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
