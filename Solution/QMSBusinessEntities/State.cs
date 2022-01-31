using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class State
	{
		#region Fields

		private short stateID=0;
		private short countryID=0;
		private string stateName=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string isDefault=String.Empty;
		private int stateCode=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the StateID value.
		/// </summary>
		public short StateID
		{
			get { return stateID; }
			set { stateID = value; }
		}

		/// <summary>
		/// Gets or sets the CountryID value.
		/// </summary>
		public short CountryID
		{
			get { return countryID; }
			set { countryID = value; }
		}

		/// <summary>
		/// Gets or sets the StateName value.
		/// </summary>
		public string StateName
		{
			get { return stateName; }
			set { stateName = value; }
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
		/// Gets or sets the IsDefault value.
		/// </summary>
		public string IsDefault
		{
			get { return isDefault; }
			set { isDefault = value; }
		}

		/// <summary>
		/// Gets or sets the StateCode value.
		/// </summary>
		public int StateCode
		{
			get { return stateCode; }
			set { stateCode = value; }
		}

		/// <summary>
		/// Gets or sets the ISDCode value.
		/// </summary>
		int _isdcode;
		public int ISDCode
		{
			get { return _isdcode; }
			set { _isdcode = value; }
		}


		#endregion
}
}
