using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Category
	{
		#region Fields

		private byte categoryid=0x00;
		private string categoryName=String.Empty;
		private int createdby=0;
		private DateTime createdat=DateTime.MaxValue;
		private int modifiedby=0;
		private DateTime modifiedat=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Categoryid value.
		/// </summary>
		public byte Categoryid
		{
			get { return categoryid; }
			set { categoryid = value; }
		}

		/// <summary>
		/// Gets or sets the CategoryName value.
		/// </summary>
		public string CategoryName
		{
			get { return categoryName; }
			set { categoryName = value; }
		}

		/// <summary>
		/// Gets or sets the Createdby value.
		/// </summary>
		public int Createdby
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
		/// Gets or sets the Modifiedby value.
		/// </summary>
		public int Modifiedby
		{
			get { return modifiedby; }
			set { modifiedby = value; }
		}

		/// <summary>
		/// Gets or sets the Modifiedat value.
		/// </summary>
		public DateTime Modifiedat
		{
			get { return modifiedat; }
			set { modifiedat = value; }
		}


		#endregion
}
}
