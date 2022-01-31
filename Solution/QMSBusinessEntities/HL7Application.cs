using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class HL7Application
	{
		#region Fields

		private int id=0;
		private string applicationName=String.Empty;
		private string applicationCode=String.Empty;
		private int orgId=0;
		private short countryID=0;
		private short stateID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id value.
		/// </summary>
		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		/// <summary>
		/// Gets or sets the ApplicationName value.
		/// </summary>
		public string ApplicationName
		{
			get { return applicationName; }
			set { applicationName = value; }
		}

		/// <summary>
		/// Gets or sets the ApplicationCode value.
		/// </summary>
		public string ApplicationCode
		{
			get { return applicationCode; }
			set { applicationCode = value; }
		}

		/// <summary>
		/// Gets or sets the OrgId value.
		/// </summary>
		public int OrgId
		{
			get { return orgId; }
			set { orgId = value; }
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
		/// Gets or sets the StateID value.
		/// </summary>
		public short StateID
		{
			get { return stateID; }
			set { stateID = value; }
		}


		#endregion
}
}
