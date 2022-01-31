using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class EQAMaster
	{
		#region Fields

		private long iD=0;
		private long vendorID=0;
		private string cycleIdentification=String.Empty;
		private string dateOfProcessing=String.Empty;
		private string interpretation=String.Empty;
		private string hasFile=String.Empty;
		private string fileType=String.Empty;
		private string filePath=String.Empty;
        private string resultType = String.Empty;
        private string extras = String.Empty;
        private long deptID = 0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public long DeptID
		{
			get { return deptID; }
			set { deptID = value; }
		}

        public long ID
		{
			get { return iD; }
			set { iD = value; }
		}

		/// <summary>
		/// Gets or sets the VendorID value.
		/// </summary>
		public long VendorID
		{
			get { return vendorID; }
			set { vendorID = value; }
		}

		/// <summary>
		/// Gets or sets the CycleIdentification value.
		/// </summary>
		public string CycleIdentification
		{
			get { return cycleIdentification; }
			set { cycleIdentification = value; }
		}

		/// <summary>
		/// Gets or sets the DateOfProcessing value.
		/// </summary>
		public string DateOfProcessing
		{
			get { return dateOfProcessing; }
			set { dateOfProcessing = value; }
		}

		/// <summary>
		/// Gets or sets the Interpretation value.
		/// </summary>
		public string Interpretation
		{
			get { return interpretation; }
			set { interpretation = value; }
		}

		/// <summary>
		/// Gets or sets the HasFile value.
		/// </summary>
		public string HasFile
		{
			get { return hasFile; }
			set { hasFile = value; }
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
		/// Gets or sets the FilePath value.
		/// </summary>
		public string FilePath
		{
			get { return filePath; }
			set { filePath = value; }
		}

        /// <summary>
        /// Gets or sets the ResultType value.
        /// </summary>
        public string ResultType
        {
            get { return resultType; }
            set { resultType = value; }
        }

        /// <summary>
        /// Gets or sets the Extras value.
        /// </summary>
        public string Extras
        {
            get { return extras; }
            set { extras = value; }
        }


		#endregion
}
}
