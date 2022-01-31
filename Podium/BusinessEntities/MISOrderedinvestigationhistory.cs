using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class MISOrderedinvestigationhistory
	{
		#region Fields

		private long accessionNumber=0;
		private long visitid=0;
		private long id=0;
		private string type=String.Empty;
		private string name=String.Empty;
		private short statusid=0;
		private string status=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long referralID=0;
		private int resCaptureLoc=0;
		private long pkgID=0;
		private string pkgName=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the AccessionNumber value.
		/// </summary>
		public long AccessionNumber
		{
			get { return accessionNumber; }
			set { accessionNumber = value; }
		}

		/// <summary>
		/// Gets or sets the Visitid value.
		/// </summary>
		public long Visitid
		{
			get { return visitid; }
			set { visitid = value; }
		}

		/// <summary>
		/// Gets or sets the Id value.
		/// </summary>
		public long Id
		{
			get { return id; }
			set { id = value; }
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
		/// Gets or sets the Name value.
		/// </summary>
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		/// <summary>
		/// Gets or sets the Statusid value.
		/// </summary>
		public short Statusid
		{
			get { return statusid; }
			set { statusid = value; }
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
		/// Gets or sets the ReferralID value.
		/// </summary>
		public long ReferralID
		{
			get { return referralID; }
			set { referralID = value; }
		}

		/// <summary>
		/// Gets or sets the ResCaptureLoc value.
		/// </summary>
		public int ResCaptureLoc
		{
			get { return resCaptureLoc; }
			set { resCaptureLoc = value; }
		}

		/// <summary>
		/// Gets or sets the PkgID value.
		/// </summary>
		public long PkgID
		{
			get { return pkgID; }
			set { pkgID = value; }
		}

		/// <summary>
		/// Gets or sets the PkgName value.
		/// </summary>
		public string PkgName
		{
			get { return pkgName; }
			set { pkgName = value; }
		}


		#endregion
}
}
