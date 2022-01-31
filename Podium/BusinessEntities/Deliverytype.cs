using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Deliverytype
	{
		#region Fields

		private int typeid=0;
		private string typename=String.Empty;
		private int orgid=0;
		private DateTime createdAt=DateTime.MaxValue;
		private DateTime createdBy=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Typeid value.
		/// </summary>
		public int Typeid
		{
			get { return typeid; }
			set { typeid = value; }
		}

		/// <summary>
		/// Gets or sets the Typename value.
		/// </summary>
		public string Typename
		{
			get { return typename; }
			set { typename = value; }
		}

		/// <summary>
		/// Gets or sets the Orgid value.
		/// </summary>
		public int Orgid
		{
			get { return orgid; }
			set { orgid = value; }
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
		public DateTime CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
		}


		#endregion
}
}
