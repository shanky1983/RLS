using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PatientBodyPartDetails
	{
		#region Fields

		private long bodyPartDetailsID=0;
		private long bodyPartsID=0;
		private string position=String.Empty;
		private long childItemID=0;
		private string childItemDescription=String.Empty;
		private string status=String.Empty;
		private long visitID=0;
		private long patientID=0;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the BodyPartDetailsID value.
		/// </summary>
		public long BodyPartDetailsID
		{
			get { return bodyPartDetailsID; }
			set { bodyPartDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the BodyPartsID value.
		/// </summary>
		public long BodyPartsID
		{
			get { return bodyPartsID; }
			set { bodyPartsID = value; }
		}

		/// <summary>
		/// Gets or sets the Position value.
		/// </summary>
		public string Position
		{
			get { return position; }
			set { position = value; }
		}

		/// <summary>
		/// Gets or sets the ChildItemID value.
		/// </summary>
		public long ChildItemID
		{
			get { return childItemID; }
			set { childItemID = value; }
		}

		/// <summary>
		/// Gets or sets the ChildItemDescription value.
		/// </summary>
		public string ChildItemDescription
		{
			get { return childItemDescription; }
			set { childItemDescription = value; }
		}

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the VisitID value.
		/// </summary>
		public long VisitID
		{
			get { return visitID; }
			set { visitID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientID value.
		/// </summary>
		public long PatientID
		{
			get { return patientID; }
			set { patientID = value; }
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
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public long CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
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
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public long ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
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
		/// Gets or sets the Name value.
		/// </summary>
		private string _name=String.Empty;
		public string Name
		{
			get { return  _name; }
			set { _name = value; }
		}

		/// <summary>
		/// Gets or sets the ChildItemName value.
		/// </summary>
		private string _childItemName=String.Empty;
		public string ChildItemName
		{
			get { return  _childItemName; }
			set { _childItemName = value; }
		}


		#endregion
}
}
