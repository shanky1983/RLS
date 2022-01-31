using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class RoleVideoMapping
	{
		#region Fields

		private int vidoID=0;
		private int roleID=0;
		private int orgID=0;
		private int videoOrderID=0;
		private string videoDescription=String.Empty;
		private string videoFilePath=String.Empty;
		private int createBy=0;
		private DateTime createAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the VidoID value.
		/// </summary>
		public int VidoID
		{
			get { return vidoID; }
			set { vidoID = value; }
		}

		/// <summary>
		/// Gets or sets the RoleID value.
		/// </summary>
		public int RoleID
		{
			get { return roleID; }
			set { roleID = value; }
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
		/// Gets or sets the VideoOrderID value.
		/// </summary>
		public int VideoOrderID
		{
			get { return videoOrderID; }
			set { videoOrderID = value; }
		}

		/// <summary>
		/// Gets or sets the VideoDescription value.
		/// </summary>
		public string VideoDescription
		{
			get { return videoDescription; }
			set { videoDescription = value; }
		}

		/// <summary>
		/// Gets or sets the VideoFilePath value.
		/// </summary>
		public string VideoFilePath
		{
			get { return videoFilePath; }
			set { videoFilePath = value; }
		}

		/// <summary>
		/// Gets or sets the CreateBy value.
		/// </summary>
		public int CreateBy
		{
			get { return createBy; }
			set { createBy = value; }
		}

		/// <summary>
		/// Gets or sets the CreateAt value.
		/// </summary>
		public DateTime CreateAt
		{
			get { return createAt; }
			set { createAt = value; }
		}


		#endregion
}
}
