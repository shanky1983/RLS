using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Ambulance
	{
		#region Fields

		private long ambulanceID=0;
		private int orgid=0;
		private string ambulancecode=String.Empty;
		private string workpermitno=String.Empty;
		private string insuranceno=String.Empty;
		private string description=String.Empty;
		private long createdby=0;
		private DateTime createdat=DateTime.MaxValue;
		private long modifiedby=0;
		private DateTime modifiedat=DateTime.MaxValue;
		private string status=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the AmbulanceID value.
		/// </summary>
		public long AmbulanceID
		{
			get { return ambulanceID; }
			set { ambulanceID = value; }
		}

		/// <summary>
		/// Gets or sets the Orgid value.
		/// </summary>
		public int Orgid
		{
			get { return orgid; }
			set { orgid = value; }
		}

		/// <summary>
		/// Gets or sets the Ambulancecode value.
		/// </summary>
		public string Ambulancecode
		{
			get { return ambulancecode; }
			set { ambulancecode = value; }
		}

		/// <summary>
		/// Gets or sets the Workpermitno value.
		/// </summary>
		public string Workpermitno
		{
			get { return workpermitno; }
			set { workpermitno = value; }
		}

		/// <summary>
		/// Gets or sets the Insuranceno value.
		/// </summary>
		public string Insuranceno
		{
			get { return insuranceno; }
			set { insuranceno = value; }
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
		/// Gets or sets the Createdby value.
		/// </summary>
		public long Createdby
		{
			get { return createdby; }
			set { createdby = value; }
		}

		/// <summary>
		/// Gets or sets the Createdat value.
		/// </summary>
		public DateTime Createdat
		{
			get { return createdat; }
			set { createdat = value; }
		}

		/// <summary>
		/// Gets or sets the Modifiedby value.
		/// </summary>
		public long Modifiedby
		{
			get { return modifiedby; }
			set { modifiedby = value; }
		}

		/// <summary>
		/// Gets or sets the Modifiedat value.
		/// </summary>
		public DateTime Modifiedat
		{
			get { return modifiedat; }
			set { modifiedat = value; }
		}

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
		}


		#endregion
}
}
