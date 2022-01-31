using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class DrugType
	{
		#region Fields

		private int drugTypeID=0;
		private string drugTypeName=String.Empty;
		private string drugDesc=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DrugTypeID value.
		/// </summary>
		public int DrugTypeID
		{
			get { return drugTypeID; }
			set { drugTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the DrugTypeName value.
		/// </summary>
		public string DrugTypeName
		{
			get { return drugTypeName; }
			set { drugTypeName = value; }
		}

		/// <summary>
		/// Gets or sets the DrugDesc value.
		/// </summary>
		public string DrugDesc
		{
			get { return drugDesc; }
			set { drugDesc = value; }
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


		#endregion
}
}
