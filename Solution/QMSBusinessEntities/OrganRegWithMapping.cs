using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class OrganRegWithMapping
	{
		#region Fields

		private long organRegWithMappingID=0;
		private long patientID=0;
		private short organID=0;
		private string organRegWith=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long visitID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the OrganRegWithMappingID value.
		/// </summary>
		public long OrganRegWithMappingID
		{
			get { return organRegWithMappingID; }
			set { organRegWithMappingID = value; }
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
		/// Gets or sets the OrganID value.
		/// </summary>
		public short OrganID
		{
			get { return organID; }
			set { organID = value; }
		}

		/// <summary>
		/// Gets or sets the OrganRegWith value.
		/// </summary>
		public string OrganRegWith
		{
			get { return organRegWith; }
			set { organRegWith = value; }
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
		/// Gets or sets the VisitID value.
		/// </summary>
		public long VisitID
		{
			get { return visitID; }
			set { visitID = value; }
		}

		/// <summary>
		/// Gets or sets the OrganName value.
		/// </summary>
		string _organname;
		public string OrganName
		{
			get { return _organname; }
			set { _organname = value; }
		}


		#endregion
}
}
