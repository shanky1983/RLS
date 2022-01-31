using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class OrganizationDBMapping
	{
		#region Fields

		private int mapid=0;
		private int orgID=0;
		private string instancename=String.Empty;
		private string dBName=String.Empty;
		private string schemaName=String.Empty;
		private string dBLogin=String.Empty;
		private string dBPwd=String.Empty;
		private bool isPrimary=false;
		private string poolingValue=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Mapid value.
		/// </summary>
		public int Mapid
		{
			get { return mapid; }
			set { mapid = value; }
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
		/// Gets or sets the Instancename value.
		/// </summary>
		public string Instancename
		{
			get { return instancename; }
			set { instancename = value; }
		}

		/// <summary>
		/// Gets or sets the DBName value.
		/// </summary>
		public string DBName
		{
			get { return dBName; }
			set { dBName = value; }
		}

		/// <summary>
		/// Gets or sets the SchemaName value.
		/// </summary>
		public string SchemaName
		{
			get { return schemaName; }
			set { schemaName = value; }
		}

		/// <summary>
		/// Gets or sets the DBLogin value.
		/// </summary>
		public string DBLogin
		{
			get { return dBLogin; }
			set { dBLogin = value; }
		}

		/// <summary>
		/// Gets or sets the DBPwd value.
		/// </summary>
		public string DBPwd
		{
			get { return dBPwd; }
			set { dBPwd = value; }
		}

		/// <summary>
		/// Gets or sets the IsPrimary value.
		/// </summary>
		public bool IsPrimary
		{
			get { return isPrimary; }
			set { isPrimary = value; }
		}

		/// <summary>
		/// Gets or sets the PoolingValue value.
		/// </summary>
		public string PoolingValue
		{
			get { return poolingValue; }
			set { poolingValue = value; }
		}


		#endregion
}
}
