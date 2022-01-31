using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class TRFfilemanager
	{
		#region Fields

		private long fileID=0;
		private string fileUrl=String.Empty;
		private long patientID=0;
		private long visitID=0;
		private int orgID=0;
		private long identifyingID=0;
		private string identifyingType=String.Empty;
		private string fileName=String.Empty;
		private string filePath=String.Empty;
		private long createdby=0;
		private DateTime createdat=DateTime.MaxValue;
		private string isactive=String.Empty;
		private Guid tRFGUID=Guid.Empty;
		private byte[] tRFImageData=new byte[0];
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int isFileStream=0;

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
		/// Gets or sets the PatientID value.
		/// </summary>
		public long PatientID
		{
			get { return patientID; }
			set { patientID = value; }
		}

		/// <summary>
		/// Gets or sets the VisitID value.
		/// </summary>
		public long VisitID
		{
			get { return visitID; }
			set { visitID = value; }
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
		public long IdentifyingID
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
		/// Gets or sets the FileName value.
		/// </summary>
		public string FileName
		{
			get { return fileName; }
			set { fileName = value; }
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
		/// Gets or sets the Isactive value.
		/// </summary>
		public string Isactive
		{
			get { return isactive; }
			set { isactive = value; }
		}

		/// <summary>
		/// Gets or sets the TRFGUID value.
		/// </summary>
		public Guid TRFGUID
		{
			get { return tRFGUID; }
			set { tRFGUID = value; }
		}

		/// <summary>
		/// Gets or sets the TRFImageData value.
		/// </summary>
		public byte[] TRFImageData
		{
			get { return tRFImageData; }
			set { tRFImageData = value; }
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

		/// <summary>
		/// Gets or sets the IsFileStream value.
		/// </summary>
		public int IsFileStream
		{
			get { return isFileStream; }
			set { isFileStream = value; }
		}


		#endregion
}
}
