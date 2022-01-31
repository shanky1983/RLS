using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Modality
	{
		#region Fields

		private int modalityID=0;
		private string modalityName=String.Empty;
		private string modalityMake=String.Empty;
		private string aETitle=String.Empty;
		private string modalityDescription=String.Empty;
		private int departmentID=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private int orgID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ModalityID value.
		/// </summary>
		public int ModalityID
		{
			get { return modalityID; }
			set { modalityID = value; }
		}

		/// <summary>
		/// Gets or sets the ModalityName value.
		/// </summary>
		public string ModalityName
		{
			get { return modalityName; }
			set { modalityName = value; }
		}

		/// <summary>
		/// Gets or sets the ModalityMake value.
		/// </summary>
		public string ModalityMake
		{
			get { return modalityMake; }
			set { modalityMake = value; }
		}

		/// <summary>
		/// Gets or sets the AETitle value.
		/// </summary>
		public string AETitle
		{
			get { return aETitle; }
			set { aETitle = value; }
		}

		/// <summary>
		/// Gets or sets the ModalityDescription value.
		/// </summary>
		public string ModalityDescription
		{
			get { return modalityDescription; }
			set { modalityDescription = value; }
		}

		/// <summary>
		/// Gets or sets the DepartmentID value.
		/// </summary>
		public int DepartmentID
		{
			get { return departmentID; }
			set { departmentID = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedAt value.
		/// </summary>
		public DateTime CreatedAt
		{
			get { return createdAt; }
			set { createdAt = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public long CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public long ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}


		#endregion
}
}
