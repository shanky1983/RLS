using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InventoryAttributesMaster
	{
		#region Fields

		private int attributeID=0;
		private string attributeName=String.Empty;
		private bool status=true;
		private bool isPreDefined=true;
		private DateTime createdat=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private string showColumn=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the AttributeID value.
		/// </summary>
		public int AttributeID
		{
			get { return attributeID; }
			set { attributeID = value; }
		}

		/// <summary>
		/// Gets or sets the AttributeName value.
		/// </summary>
		public string AttributeName
		{
			get { return attributeName; }
			set { attributeName = value; }
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
		/// Gets or sets the IsPreDefined value.
		/// </summary>
		public bool IsPreDefined
		{
			get { return isPreDefined; }
			set { isPreDefined = value; }
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
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public long CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
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
		/// Gets or sets the ShowColumn value.
		/// </summary>
		public string ShowColumn
		{
			get { return showColumn; }
			set { showColumn = value; }
		}


		#endregion
}
}
