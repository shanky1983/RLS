using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class EpisodeFileManager
	{
		#region Fields

		private long fileID=0;
		private string fileUrl=String.Empty;
		private string fileName=String.Empty;
		private long episodeID=0;
		private string fileType=String.Empty;
		private int orgID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the FileID value.
		/// </summary>
		public long FileID
		{
			get { return fileID; }
			set { fileID = value; }
		}

		/// <summary>
		/// Gets or sets the FileUrl value.
		/// </summary>
		public string FileUrl
		{
			get { return fileUrl; }
			set { fileUrl = value; }
		}

		/// <summary>
		/// Gets or sets the FileName value.
		/// </summary>
		public string FileName
		{
			get { return fileName; }
			set { fileName = value; }
		}

		/// <summary>
		/// Gets or sets the EpisodeID value.
		/// </summary>
		public long EpisodeID
		{
			get { return episodeID; }
			set { episodeID = value; }
		}

		/// <summary>
		/// Gets or sets the FileType value.
		/// </summary>
		public string FileType
		{
			get { return fileType; }
			set { fileType = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}


		#endregion
}
}
