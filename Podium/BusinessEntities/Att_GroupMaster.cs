using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Att_GroupMaster
	{
		#region Fields

		private string lAB=String.Empty;
		private string gROUPNAME=String.Empty;
		private string mETRO_COMBINE_CODE=String.Empty;
		private string eDOSCODE=String.Empty;
		private string dISPLAY_NAME=String.Empty;
		private string aBBREVATION=String.Empty;
		private string iS_ORDERABLE=String.Empty;
		private string cLASSIFICATION=String.Empty;
		private string iS_NABL=String.Empty;
		private string iS_CAP=String.Empty;
		private string iS_STAT=String.Empty;
		private string tAT_POLICY=String.Empty;
		private string orgGroupID=String.Empty;
		private long investigationID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the LAB value.
		/// </summary>
		public string LAB
		{
			get { return lAB; }
			set { lAB = value; }
		}

		/// <summary>
		/// Gets or sets the GROUPNAME value.
		/// </summary>
		public string GROUPNAME
		{
			get { return gROUPNAME; }
			set { gROUPNAME = value; }
		}

		/// <summary>
		/// Gets or sets the METRO_COMBINE_CODE value.
		/// </summary>
		public string METRO_COMBINE_CODE
		{
			get { return mETRO_COMBINE_CODE; }
			set { mETRO_COMBINE_CODE = value; }
		}

		/// <summary>
		/// Gets or sets the EDOSCODE value.
		/// </summary>
		public string EDOSCODE
		{
			get { return eDOSCODE; }
			set { eDOSCODE = value; }
		}

		/// <summary>
		/// Gets or sets the DISPLAY_NAME value.
		/// </summary>
		public string DISPLAY_NAME
		{
			get { return dISPLAY_NAME; }
			set { dISPLAY_NAME = value; }
		}

		/// <summary>
		/// Gets or sets the ABBREVATION value.
		/// </summary>
		public string ABBREVATION
		{
			get { return aBBREVATION; }
			set { aBBREVATION = value; }
		}

		/// <summary>
		/// Gets or sets the IS_ORDERABLE value.
		/// </summary>
		public string IS_ORDERABLE
		{
			get { return iS_ORDERABLE; }
			set { iS_ORDERABLE = value; }
		}

		/// <summary>
		/// Gets or sets the CLASSIFICATION value.
		/// </summary>
		public string CLASSIFICATION
		{
			get { return cLASSIFICATION; }
			set { cLASSIFICATION = value; }
		}

		/// <summary>
		/// Gets or sets the IS_NABL value.
		/// </summary>
		public string IS_NABL
		{
			get { return iS_NABL; }
			set { iS_NABL = value; }
		}

		/// <summary>
		/// Gets or sets the IS_CAP value.
		/// </summary>
		public string IS_CAP
		{
			get { return iS_CAP; }
			set { iS_CAP = value; }
		}

		/// <summary>
		/// Gets or sets the IS_STAT value.
		/// </summary>
		public string IS_STAT
		{
			get { return iS_STAT; }
			set { iS_STAT = value; }
		}

		/// <summary>
		/// Gets or sets the TAT_POLICY value.
		/// </summary>
		public string TAT_POLICY
		{
			get { return tAT_POLICY; }
			set { tAT_POLICY = value; }
		}

		/// <summary>
		/// Gets or sets the OrgGroupID value.
		/// </summary>
		public string OrgGroupID
		{
			get { return orgGroupID; }
			set { orgGroupID = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationID value.
		/// </summary>
		public long InvestigationID
		{
			get { return investigationID; }
			set { investigationID = value; }
		}


		#endregion
}
}
