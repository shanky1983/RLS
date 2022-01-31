using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ReportDiagnostics
	{
		#region Fields

		private int diagnosticsID=0;
		private string title=String.Empty;
		private string description=String.Empty;
		private string imagePath=String.Empty;
		private long physicianID=0;
		private long visitID=0;
		private int specialityID=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private long visitConsID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DiagnosticsID value.
		/// </summary>
		public int DiagnosticsID
		{
			get { return diagnosticsID; }
			set { diagnosticsID = value; }
		}

		/// <summary>
		/// Gets or sets the Title value.
		/// </summary>
		public string Title
		{
			get { return title; }
			set { title = value; }
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
		/// Gets or sets the ImagePath value.
		/// </summary>
		public string ImagePath
		{
			get { return imagePath; }
			set { imagePath = value; }
		}

		/// <summary>
		/// Gets or sets the PhysicianID value.
		/// </summary>
		public long PhysicianID
		{
			get { return physicianID; }
			set { physicianID = value; }
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
		/// Gets or sets the SpecialityID value.
		/// </summary>
		public int SpecialityID
		{
			get { return specialityID; }
			set { specialityID = value; }
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
		/// Gets or sets the VisitConsID value.
		/// </summary>
		public long VisitConsID
		{
			get { return visitConsID; }
			set { visitConsID = value; }
		}


		#endregion
}
}
