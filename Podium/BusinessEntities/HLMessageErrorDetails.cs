using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class HLMessageErrorDetails
	{
		#region Fields

		private long hLMessageErrorDetailsID=0;
		private string hLMessageError=String.Empty;
		private long hLMessageID=0;
		private long orgID=0;
		private long locationID=0;
		private string hLMessageTable=String.Empty;
		private string hLMessageColumns=String.Empty;
		private string fileNames=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;
		private string locations=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the HLMessageErrorDetailsID value.
		/// </summary>
		public long HLMessageErrorDetailsID
		{
			get { return hLMessageErrorDetailsID; }
			set { hLMessageErrorDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the HLMessageError value.
		/// </summary>
		public string HLMessageError
		{
			get { return hLMessageError; }
			set { hLMessageError = value; }
		}

		/// <summary>
		/// Gets or sets the HLMessageID value.
		/// </summary>
		public long HLMessageID
		{
			get { return hLMessageID; }
			set { hLMessageID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public long OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the LocationID value.
		/// </summary>
		public long LocationID
		{
			get { return locationID; }
			set { locationID = value; }
		}

		/// <summary>
		/// Gets or sets the HLMessageTable value.
		/// </summary>
		public string HLMessageTable
		{
			get { return hLMessageTable; }
			set { hLMessageTable = value; }
		}

		/// <summary>
		/// Gets or sets the HLMessageColumns value.
		/// </summary>
		public string HLMessageColumns
		{
			get { return hLMessageColumns; }
			set { hLMessageColumns = value; }
		}

		/// <summary>
		/// Gets or sets the FileNames value.
		/// </summary>
		public string FileNames
		{
			get { return fileNames; }
			set { fileNames = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedAt value.
		/// </summary>
		public DateTime CreatedAt
		{
			get { return createdAt; }
			set { createdAt = value; }
		}

		/// <summary>
		/// Gets or sets the Locations value.
		/// </summary>
		public string Locations
		{
			get { return locations; }
			set { locations = value; }
		}


		#endregion
}
}
