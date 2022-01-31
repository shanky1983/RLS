using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class LocationPrintMap
	{
		#region Fields

		private long autoID=0;
		private long code=0;
		private string printerName=String.Empty;
		private int orgID=0;
		private int orgAddressID=0;
		private bool isColorPrinter=false;
		private bool isActive=false;
		private string filePathAndName=String.Empty;
		private string fileContent=String.Empty;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private string type=String.Empty;
		private string path=String.Empty;
		private string description=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the AutoID value.
		/// </summary>
		public long AutoID
		{
			get { return autoID; }
			set { autoID = value; }
		}

		/// <summary>
		/// Gets or sets the Code value.
		/// </summary>
		public long Code
		{
			get { return code; }
			set { code = value; }
		}

		/// <summary>
		/// Gets or sets the PrinterName value.
		/// </summary>
		public string PrinterName
		{
			get { return printerName; }
			set { printerName = value; }
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
		/// Gets or sets the OrgAddressID value.
		/// </summary>
		public int OrgAddressID
		{
			get { return orgAddressID; }
			set { orgAddressID = value; }
		}

		/// <summary>
		/// Gets or sets the IsColorPrinter value.
		/// </summary>
		public bool IsColorPrinter
		{
			get { return isColorPrinter; }
			set { isColorPrinter = value; }
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
		/// Gets or sets the FilePathAndName value.
		/// </summary>
		public string FilePathAndName
		{
			get { return filePathAndName; }
			set { filePathAndName = value; }
		}

		/// <summary>
		/// Gets or sets the FileContent value.
		/// </summary>
		public string FileContent
		{
			get { return fileContent; }
			set { fileContent = value; }
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
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public long ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
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
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public long CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
		}

		/// <summary>
		/// Gets or sets the Type value.
		/// </summary>
		public string Type
		{
			get { return type; }
			set { type = value; }
		}

		/// <summary>
		/// Gets or sets the Path value.
		/// </summary>
		public string Path
		{
			get { return path; }
			set { path = value; }
		}

		/// <summary>
		/// Gets or sets the Description value.
		/// </summary>
		public string Description
		{
			get { return description; }
			set { description = value; }
		}

		/// <summary>
		/// Gets or sets the Name value.
		/// </summary>
		private string _name=String.Empty;
		public string Name
		{
			get { return  _name; }
			set { _name = value; }
		}

		/// <summary>
		/// Gets or sets the Location value.
		/// </summary>
		private string _location=String.Empty;
		public string Location
		{
			get { return  _location; }
			set { _location = value; }
		}


		#endregion
}
}
