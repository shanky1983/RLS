using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Familytree
	{
		#region Fields

		private string externalName=String.Empty;
		private long externalPatientID=0;
		private string externalNoumber=String.Empty;
		private string dependentsName=String.Empty;
		private long dependentsPatientID=0;
		private string dependentsNoumber=String.Empty;
		private string dependentsType=String.Empty;
		private long createdBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ExternalName value.
		/// </summary>
		public string ExternalName
		{
			get { return externalName; }
			set { externalName = value; }
		}

		/// <summary>
		/// Gets or sets the ExternalPatientID value.
		/// </summary>
		public long ExternalPatientID
		{
			get { return externalPatientID; }
			set { externalPatientID = value; }
		}

		/// <summary>
		/// Gets or sets the ExternalNoumber value.
		/// </summary>
		public string ExternalNoumber
		{
			get { return externalNoumber; }
			set { externalNoumber = value; }
		}

		/// <summary>
		/// Gets or sets the DependentsName value.
		/// </summary>
		public string DependentsName
		{
			get { return dependentsName; }
			set { dependentsName = value; }
		}

		/// <summary>
		/// Gets or sets the DependentsPatientID value.
		/// </summary>
		public long DependentsPatientID
		{
			get { return dependentsPatientID; }
			set { dependentsPatientID = value; }
		}

		/// <summary>
		/// Gets or sets the DependentsNoumber value.
		/// </summary>
		public string DependentsNoumber
		{
			get { return dependentsNoumber; }
			set { dependentsNoumber = value; }
		}

		/// <summary>
		/// Gets or sets the DependentsType value.
		/// </summary>
		public string DependentsType
		{
			get { return dependentsType; }
			set { dependentsType = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public long CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
		}


		#endregion
}
}
