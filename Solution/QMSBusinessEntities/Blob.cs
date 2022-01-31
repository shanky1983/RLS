using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Blob
	{
		#region Fields

		private long fileID=0;
		private string fileURL=String.Empty;
		private byte[] fileContent=new byte[0];
		private string mIMEType=String.Empty;

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
		/// Gets or sets the FileURL value.
		/// </summary>
		public string FileURL
		{
			get { return fileURL; }
			set { fileURL = value; }
		}

		/// <summary>
		/// Gets or sets the FileContent value.
		/// </summary>
		public byte[] FileContent
		{
			get { return fileContent; }
			set { fileContent = value; }
		}

		/// <summary>
		/// Gets or sets the MIMEType value.
		/// </summary>
		public string MIMEType
		{
			get { return mIMEType; }
			set { mIMEType = value; }
		}


		#endregion
}
}
