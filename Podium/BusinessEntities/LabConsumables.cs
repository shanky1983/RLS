using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class LabConsumables
	{
		#region Fields

		private int consumableID=0;
		private string consumableName=String.Empty;
		private int orgID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ConsumableID value.
		/// </summary>
		public int ConsumableID
		{
			get { return consumableID; }
			set { consumableID = value; }
		}

		/// <summary>
		/// Gets or sets the ConsumableName value.
		/// </summary>
		public string ConsumableName
		{
			get { return consumableName; }
			set { consumableName = value; }
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
		/// Gets or sets the ConsumableNameRate value.
		/// </summary>
		private string _consumableNameRate=String.Empty;
		public string ConsumableNameRate
		{
			get { return  _consumableNameRate; }
			set { _consumableNameRate = value; }
		}

		/// <summary>
		/// Gets or sets the Rate value.
		/// </summary>
		private decimal _rate=Decimal.Zero;
		public decimal Rate
		{
			get { return  _rate; }
			set { _rate = value; }
		}


		#endregion
}
}
