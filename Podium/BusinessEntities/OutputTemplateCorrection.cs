using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class OutputTemplateCorrection
	{
		#region Fields

		private float parentOrgGroupID=0.0F;
		private string parentTestCode=String.Empty;
		private float orgGroupID=0.0F;
		private string testCode=String.Empty;
		private string abbrivationCode=String.Empty;
		private string groupName=String.Empty;
		private string groupDisplaytext=String.Empty;
		private string subTestType=String.Empty;
		private float subInvestigationId=0.0F;
		private string subTestCode=String.Empty;
		private string subInvestigationName=String.Empty;
		private string subDisplaytext=String.Empty;
		private float sequenceNo=0.0F;
		private string sampleName=String.Empty;
		private string containerName=String.Empty;
		private string inputPattern=String.Empty;
		private string outPutPattern=String.Empty;
		private string column1=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ParentOrgGroupID value.
		/// </summary>
		public float ParentOrgGroupID
		{
			get { return parentOrgGroupID; }
			set { parentOrgGroupID = value; }
		}

		/// <summary>
		/// Gets or sets the ParentTestCode value.
		/// </summary>
		public string ParentTestCode
		{
			get { return parentTestCode; }
			set { parentTestCode = value; }
		}

		/// <summary>
		/// Gets or sets the OrgGroupID value.
		/// </summary>
		public float OrgGroupID
		{
			get { return orgGroupID; }
			set { orgGroupID = value; }
		}

		/// <summary>
		/// Gets or sets the TestCode value.
		/// </summary>
		public string TestCode
		{
			get { return testCode; }
			set { testCode = value; }
		}

		/// <summary>
		/// Gets or sets the AbbrivationCode value.
		/// </summary>
		public string AbbrivationCode
		{
			get { return abbrivationCode; }
			set { abbrivationCode = value; }
		}

		/// <summary>
		/// Gets or sets the GroupName value.
		/// </summary>
		public string GroupName
		{
			get { return groupName; }
			set { groupName = value; }
		}

		/// <summary>
		/// Gets or sets the GroupDisplaytext value.
		/// </summary>
		public string GroupDisplaytext
		{
			get { return groupDisplaytext; }
			set { groupDisplaytext = value; }
		}

		/// <summary>
		/// Gets or sets the SubTestType value.
		/// </summary>
		public string SubTestType
		{
			get { return subTestType; }
			set { subTestType = value; }
		}

		/// <summary>
		/// Gets or sets the SubInvestigationId value.
		/// </summary>
		public float SubInvestigationId
		{
			get { return subInvestigationId; }
			set { subInvestigationId = value; }
		}

		/// <summary>
		/// Gets or sets the SubTestCode value.
		/// </summary>
		public string SubTestCode
		{
			get { return subTestCode; }
			set { subTestCode = value; }
		}

		/// <summary>
		/// Gets or sets the SubInvestigationName value.
		/// </summary>
		public string SubInvestigationName
		{
			get { return subInvestigationName; }
			set { subInvestigationName = value; }
		}

		/// <summary>
		/// Gets or sets the SubDisplaytext value.
		/// </summary>
		public string SubDisplaytext
		{
			get { return subDisplaytext; }
			set { subDisplaytext = value; }
		}

		/// <summary>
		/// Gets or sets the SequenceNo value.
		/// </summary>
		public float SequenceNo
		{
			get { return sequenceNo; }
			set { sequenceNo = value; }
		}

		/// <summary>
		/// Gets or sets the SampleName value.
		/// </summary>
		public string SampleName
		{
			get { return sampleName; }
			set { sampleName = value; }
		}

		/// <summary>
		/// Gets or sets the ContainerName value.
		/// </summary>
		public string ContainerName
		{
			get { return containerName; }
			set { containerName = value; }
		}

		/// <summary>
		/// Gets or sets the InputPattern value.
		/// </summary>
		public string InputPattern
		{
			get { return inputPattern; }
			set { inputPattern = value; }
		}

		/// <summary>
		/// Gets or sets the OutPutPattern value.
		/// </summary>
		public string OutPutPattern
		{
			get { return outPutPattern; }
			set { outPutPattern = value; }
		}

		/// <summary>
		/// Gets or sets the Column1 value.
		/// </summary>
		public string Column1
		{
			get { return column1; }
			set { column1 = value; }
		}


		#endregion
}
}
