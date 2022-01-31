using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InvDeltaCheck
	{
		#region Fields

		private long invDeltaCheckId=0;
		private long investigationId=0;
		private string deltaCalculationType=String.Empty;
		private decimal deltaUnit=Decimal.Zero;
		private int timeFrame=0;
		private string timeUnit=String.Empty;
		private long orgid=0;
		private bool isactive=false;
		private long crossParameterId=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the InvDeltaCheckId value.
		/// </summary>
		public long InvDeltaCheckId
		{
			get { return invDeltaCheckId; }
			set { invDeltaCheckId = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationId value.
		/// </summary>
		public long InvestigationId
		{
			get { return investigationId; }
			set { investigationId = value; }
		}

		/// <summary>
		/// Gets or sets the DeltaCalculationType value.
		/// </summary>
		public string DeltaCalculationType
		{
			get { return deltaCalculationType; }
			set { deltaCalculationType = value; }
		}

		/// <summary>
		/// Gets or sets the DeltaUnit value.
		/// </summary>
		public decimal DeltaUnit
		{
			get { return deltaUnit; }
			set { deltaUnit = value; }
		}

		/// <summary>
		/// Gets or sets the TimeFrame value.
		/// </summary>
		public int TimeFrame
		{
			get { return timeFrame; }
			set { timeFrame = value; }
		}

		/// <summary>
		/// Gets or sets the TimeUnit value.
		/// </summary>
		public string TimeUnit
		{
			get { return timeUnit; }
			set { timeUnit = value; }
		}

		/// <summary>
		/// Gets or sets the Orgid value.
		/// </summary>
		public long Orgid
		{
			get { return orgid; }
			set { orgid = value; }
		}

		/// <summary>
		/// Gets or sets the Isactive value.
		/// </summary>
		public bool Isactive
		{
			get { return isactive; }
			set { isactive = value; }
		}

		/// <summary>
		/// Gets or sets the CrossParameterId value.
		/// </summary>
		public long CrossParameterId
		{
			get { return crossParameterId; }
			set { crossParameterId = value; }
		}


		#endregion
}
}
