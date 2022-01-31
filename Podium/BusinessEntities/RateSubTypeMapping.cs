using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class RateSubTypeMapping
	{
		#region Fields

		private int rateSubTypeID=0;
		private int visitSubTypeID=0;
		private string typeOfSubType=String.Empty;
		private int rateID=0;
		private int orgID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the RateSubTypeID value.
		/// </summary>
		public int RateSubTypeID
		{
			get { return rateSubTypeID; }
			set { rateSubTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the VisitSubTypeID value.
		/// </summary>
		public int VisitSubTypeID
		{
			get { return visitSubTypeID; }
			set { visitSubTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the TypeOfSubType value.
		/// </summary>
		public string TypeOfSubType
		{
			get { return typeOfSubType; }
			set { typeOfSubType = value; }
		}

		/// <summary>
		/// Gets or sets the RateID value.
		/// </summary>
		public int RateID
		{
			get { return rateID; }
			set { rateID = value; }
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
		/// Gets or sets the Description value.
		/// </summary>
		private string _description=String.Empty;
		public string Description
		{
			get { return  _description; }
			set { _description = value; }
		}


		#endregion
}
}
