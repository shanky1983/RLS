using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class HP_group_content
	{
		#region Fields

		private string lAB=String.Empty;
		private string gROUP_CODE=String.Empty;
		private string tEST_CODE=String.Empty;
		private string tEST_NAME=String.Empty;
		private float tEST_SEQUENCE_NO=0.0F;
		private string investigationID=String.Empty;
		private string orgGroupID=String.Empty;
		private string type=String.Empty;
		private string iD=String.Empty;
		private string f10=String.Empty;
		private string f11=String.Empty;

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
		/// Gets or sets the GROUP_CODE value.
		/// </summary>
		public string GROUP_CODE
		{
			get { return gROUP_CODE; }
			set { gROUP_CODE = value; }
		}

		/// <summary>
		/// Gets or sets the TEST_CODE value.
		/// </summary>
		public string TEST_CODE
		{
			get { return tEST_CODE; }
			set { tEST_CODE = value; }
		}

		/// <summary>
		/// Gets or sets the TEST_NAME value.
		/// </summary>
		public string TEST_NAME
		{
			get { return tEST_NAME; }
			set { tEST_NAME = value; }
		}

		/// <summary>
		/// Gets or sets the TEST_SEQUENCE_NO value.
		/// </summary>
		public float TEST_SEQUENCE_NO
		{
			get { return tEST_SEQUENCE_NO; }
			set { tEST_SEQUENCE_NO = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationID value.
		/// </summary>
		public string InvestigationID
		{
			get { return investigationID; }
			set { investigationID = value; }
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
		/// Gets or sets the Type value.
		/// </summary>
		public string Type
		{
			get { return type; }
			set { type = value; }
		}

		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public string ID
		{
			get { return iD; }
			set { iD = value; }
		}

		/// <summary>
		/// Gets or sets the F10 value.
		/// </summary>
		public string F10
		{
			get { return f10; }
			set { f10 = value; }
		}

		/// <summary>
		/// Gets or sets the F11 value.
		/// </summary>
		public string F11
		{
			get { return f11; }
			set { f11 = value; }
		}


		#endregion
}
}
