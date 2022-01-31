using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ThemeOrgMapping
	{
		#region Fields

		private int themeOrgMappingID=0;
		private int themeID=0;
		private string themeName=String.Empty;
		private string langCode=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ThemeOrgMappingID value.
		/// </summary>
		public int ThemeOrgMappingID
		{
			get { return themeOrgMappingID; }
			set { themeOrgMappingID = value; }
		}

		/// <summary>
		/// Gets or sets the ThemeID value.
		/// </summary>
		public int ThemeID
		{
			get { return themeID; }
			set { themeID = value; }
		}

		/// <summary>
		/// Gets or sets the ThemeName value.
		/// </summary>
		public string ThemeName
		{
			get { return themeName; }
			set { themeName = value; }
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
