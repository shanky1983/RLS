using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class QMS_TRFfilemanager
	{
		#region Fields

		private long fileID=0;
		private string fileName=String.Empty;
		private int orgID=0;
		private string identifyingID=String.Empty;
		private string identifyingType=String.Empty;
		private string filePath=String.Empty;
		private string fileType=String.Empty;
		private long pageID=0;
		private long createdby=0;
		private DateTime createdat =DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt =DateTime.MaxValue;
        private string isDelete = String.Empty;
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
		/// Gets or sets the FileName value.
		/// </summary>
		public string FileName
		{
			get { return fileName; }
			set { fileName = value; }
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
		/// Gets or sets the IdentifyingID value.
		/// </summary>
		public string IdentifyingID
		{
			get { return identifyingID; }
			set { identifyingID = value; }
		}

		/// <summary>
		/// Gets or sets the IdentifyingType value.
		/// </summary>
		public string IdentifyingType
		{
			get { return identifyingType; }
			set { identifyingType = value; }
		}

		/// <summary>
		/// Gets or sets the FilePath value.
		/// </summary>
		public string FilePath
		{
			get { return filePath; }
			set { filePath = value; }
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
		/// Gets or sets the PageID value.
		/// </summary>
		public long PageID
		{
			get { return pageID; }
			set { pageID = value; }
		}

		/// <summary>
		/// Gets or sets the Createdby value.
		/// </summary>
		public long Createdby
		{
			get { return createdby; }
			set { createdby = value; }
		}

		/// <summary>
		/// Gets or sets the Createdat value.
		/// </summary>
		public DateTime Createdat
		{
			get { return createdat; }
			set { createdat = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public long ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
		}

        public string IsDelete
        {
            get { return isDelete; }
            set { isDelete = value; }
        }
		#endregion
}
}
