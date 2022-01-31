using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Investigationsamplecontainer_BCK_Lakotia
	{
		#region Fields

		private int sampleContainerID=0;
		private string containerName=String.Empty;
		private string description=String.Empty;
		private string code=String.Empty;
		private string active=String.Empty;
		private int orgID=0;
		private int iD=0;
		private string containerABBR=String.Empty;
		private string containerColor=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the SampleContainerID value.
		/// </summary>
		public int SampleContainerID
		{
			get { return sampleContainerID; }
			set { sampleContainerID = value; }
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
		/// Gets or sets the Description value.
		/// </summary>
		public string Description
		{
			get { return description; }
			set { description = value; }
		}

		/// <summary>
		/// Gets or sets the Code value.
		/// </summary>
		public string Code
		{
			get { return code; }
			set { code = value; }
		}

		/// <summary>
		/// Gets or sets the Active value.
		/// </summary>
		public string Active
		{
			get { return active; }
			set { active = value; }
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
		/// Gets or sets the ID value.
		/// </summary>
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}

		/// <summary>
		/// Gets or sets the ContainerABBR value.
		/// </summary>
		public string ContainerABBR
		{
			get { return containerABBR; }
			set { containerABBR = value; }
		}

		/// <summary>
		/// Gets or sets the ContainerColor value.
		/// </summary>
		public string ContainerColor
		{
			get { return containerColor; }
			set { containerColor = value; }
		}


		#endregion
}
}
