using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class DispatchRuleMapping
	{
		#region Fields

		private long id=0;
		private long clientId=0;
		private string ruleId=String.Empty;
		private string sqlText=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id value.
		/// </summary>
		public long Id
		{
			get { return id; }
			set { id = value; }
		}

		/// <summary>
		/// Gets or sets the ClientId value.
		/// </summary>
		public long ClientId
		{
			get { return clientId; }
			set { clientId = value; }
		}

		/// <summary>
		/// Gets or sets the RuleId value.
		/// </summary>
		public string RuleId
		{
			get { return ruleId; }
			set { ruleId = value; }
		}

		/// <summary>
		/// Gets or sets the SqlText value.
		/// </summary>
		public string SqlText
		{
			get { return sqlText; }
			set { sqlText = value; }
		}


		#endregion
}
}
