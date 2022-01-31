using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InvValueRangeMaster
	{
		#region Fields

		private long invValueRangeMasterID=0;
		private long investigationID=0;
		private string valueRange=String.Empty;
		private int orgID=0;
		private long reflexInvestigationID=0;
		private string isReportable=String.Empty;
		private string isChargeable=String.Empty;
		private string reflexSampleType=String.Empty;
		private string isActive=String.Empty;
		private string range=String.Empty;
		private string isReflex=String.Empty;
		private string type=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the InvValueRangeMasterID value.
		/// </summary>
		public long InvValueRangeMasterID
		{
			get { return invValueRangeMasterID; }
			set { invValueRangeMasterID = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationID value.
		/// </summary>
		public long InvestigationID
		{
			get { return investigationID; }
			set { investigationID = value; }
		}

		/// <summary>
		/// Gets or sets the ValueRange value.
		/// </summary>
		public string ValueRange
		{
			get { return valueRange; }
			set { valueRange = value; }
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
		/// Gets or sets the ReflexInvestigationID value.
		/// </summary>
		public long ReflexInvestigationID
		{
			get { return reflexInvestigationID; }
			set { reflexInvestigationID = value; }
		}

		/// <summary>
		/// Gets or sets the IsReportable value.
		/// </summary>
		public string IsReportable
		{
			get { return isReportable; }
			set { isReportable = value; }
		}

		/// <summary>
		/// Gets or sets the IsChargeable value.
		/// </summary>
		public string IsChargeable
		{
			get { return isChargeable; }
			set { isChargeable = value; }
		}

		/// <summary>
		/// Gets or sets the ReflexSampleType value.
		/// </summary>
		public string ReflexSampleType
		{
			get { return reflexSampleType; }
			set { reflexSampleType = value; }
		}

		/// <summary>
		/// Gets or sets the IsActive value.
		/// </summary>
		public string IsActive
		{
			get { return isActive; }
			set { isActive = value; }
		}

		/// <summary>
		/// Gets or sets the Range value.
		/// </summary>
		public string Range
		{
			get { return range; }
			set { range = value; }
		}

		/// <summary>
		/// Gets or sets the IsReflex value.
		/// </summary>
		public string IsReflex
		{
			get { return isReflex; }
			set { isReflex = value; }
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
		/// Gets or sets the ReflexInvestigationName value.
		/// </summary>
		private string _reflexInvestigationName=String.Empty;
		public string ReflexInvestigationName
		{
			get { return  _reflexInvestigationName; }
			set { _reflexInvestigationName = value; }
		}


		#endregion
}
}
