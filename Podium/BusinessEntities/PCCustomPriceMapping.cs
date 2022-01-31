using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PCCustomPriceMapping
	{
		#region Fields

		private int refPhyID=0;
		private long refOrgID=0;
		private long iD=0;
		private int orgID=0;
		private string type=String.Empty;
		private decimal rate=Decimal.Zero;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the RefPhyID value.
		/// </summary>
		public int RefPhyID
		{
			get { return refPhyID; }
			set { refPhyID = value; }
		}

		/// <summary>
		/// Gets or sets the RefOrgID value.
		/// </summary>
		public long RefOrgID
		{
			get { return refOrgID; }
			set { refOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public long ID
		{
			get { return iD; }
			set { iD = value; }
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
		/// Gets or sets the Type value.
		/// </summary>
		public string Type
		{
			get { return type; }
			set { type = value; }
		}

		/// <summary>
		/// Gets or sets the Rate value.
		/// </summary>
		public decimal Rate
		{
			get { return rate; }
			set { rate = value; }
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


		#endregion
}
}
