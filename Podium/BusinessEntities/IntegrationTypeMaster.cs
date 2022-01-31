using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class IntegrationTypeMaster
	{
		#region Fields

		private int integrationTypeID=0;
		private string integrationTypeName=String.Empty;
		private string integrationTypeCode=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private bool status=false;
		private string privateKey=String.Empty;
		private string publicKey=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the IntegrationTypeID value.
		/// </summary>
		public int IntegrationTypeID
		{
			get { return integrationTypeID; }
			set { integrationTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the IntegrationTypeName value.
		/// </summary>
		public string IntegrationTypeName
		{
			get { return integrationTypeName; }
			set { integrationTypeName = value; }
		}

		/// <summary>
		/// Gets or sets the IntegrationTypeCode value.
		/// </summary>
		public string IntegrationTypeCode
		{
			get { return integrationTypeCode; }
			set { integrationTypeCode = value; }
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
		/// Gets or sets the CreatedAt value.
		/// </summary>
		public DateTime CreatedAt
		{
			get { return createdAt; }
			set { createdAt = value; }
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
		/// Gets or sets the Status value.
		/// </summary>
		public bool Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the PrivateKey value.
		/// </summary>
		public string PrivateKey
		{
			get { return privateKey; }
			set { privateKey = value; }
		}

		/// <summary>
		/// Gets or sets the PublicKey value.
		/// </summary>
		public string PublicKey
		{
			get { return publicKey; }
			set { publicKey = value; }
		}


		#endregion
}
}
