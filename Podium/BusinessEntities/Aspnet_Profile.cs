using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Aspnet_Profile
	{
		#region Fields

		private Guid userId=Guid.Empty;
		private string propertyNames=String.Empty;
		private string propertyValuesString=String.Empty;
		private byte[] propertyValuesBinary=new byte[0];
		private DateTime lastUpdatedDate=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the UserId value.
		/// </summary>
		public Guid UserId
		{
			get { return userId; }
			set { userId = value; }
		}

		/// <summary>
		/// Gets or sets the PropertyNames value.
		/// </summary>
		public string PropertyNames
		{
			get { return propertyNames; }
			set { propertyNames = value; }
		}

		/// <summary>
		/// Gets or sets the PropertyValuesString value.
		/// </summary>
		public string PropertyValuesString
		{
			get { return propertyValuesString; }
			set { propertyValuesString = value; }
		}

		/// <summary>
		/// Gets or sets the PropertyValuesBinary value.
		/// </summary>
		public byte[] PropertyValuesBinary
		{
			get { return propertyValuesBinary; }
			set { propertyValuesBinary = value; }
		}

		/// <summary>
		/// Gets or sets the LastUpdatedDate value.
		/// </summary>
		public DateTime LastUpdatedDate
		{
			get { return lastUpdatedDate; }
			set { lastUpdatedDate = value; }
		}


		#endregion
}
}
