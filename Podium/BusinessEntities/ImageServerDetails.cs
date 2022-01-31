using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ImageServerDetails
	{
		#region Fields

		private int orgID=0;
		private long orgAddressID=0;
		private string ipAddress=String.Empty;
		private string portNumber=String.Empty;
		private string path=String.Empty;
		private string imgViewerName=String.Empty;
		private string exeFilePath=String.Empty;
		private string userGuidePath=String.Empty;
		private string installationGuidePath=String.Empty;

		#endregion

		#region Properties
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
		public long OrgAddressID
		{
			get { return orgAddressID; }
			set { orgAddressID = value; }
		}

		/// <summary>
		/// Gets or sets the IpAddress value.
		/// </summary>
		public string IpAddress
		{
			get { return ipAddress; }
			set { ipAddress = value; }
		}

		/// <summary>
		/// Gets or sets the PortNumber value.
		/// </summary>
		public string PortNumber
		{
			get { return portNumber; }
			set { portNumber = value; }
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
		/// Gets or sets the ImgViewerName value.
		/// </summary>
		public string ImgViewerName
		{
			get { return imgViewerName; }
			set { imgViewerName = value; }
		}

		/// <summary>
		/// Gets or sets the ExeFilePath value.
		/// </summary>
		public string ExeFilePath
		{
			get { return exeFilePath; }
			set { exeFilePath = value; }
		}

		/// <summary>
		/// Gets or sets the UserGuidePath value.
		/// </summary>
		public string UserGuidePath
		{
			get { return userGuidePath; }
			set { userGuidePath = value; }
		}

		/// <summary>
		/// Gets or sets the InstallationGuidePath value.
		/// </summary>
		public string InstallationGuidePath
		{
			get { return installationGuidePath; }
			set { installationGuidePath = value; }
		}


		#endregion
}
}
