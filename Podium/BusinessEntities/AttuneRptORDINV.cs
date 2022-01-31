using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class AttuneRptORDINV
	{
		#region Fields

		private long accessionNumber=0;
		private long visitid=0;
		private long iD=0;
		private string type=String.Empty;
		private string name=String.Empty;
		private string status=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long referralID=0;
		private int resCaptureLoc=0;
		private long pkgID=0;
		private string pkgName=String.Empty;
		private DateTime reportDateTime=DateTime.MaxValue;
		private DateTime tatDateTime=DateTime.MaxValue;
		private long referredAccessionNo=0;
		private string labNo=String.Empty;
		private long approvedBy=0;
		private long validatedBy=0;
		private DateTime collectedat=DateTime.MaxValue;
		private DateTime receivedat=DateTime.MaxValue;
		private DateTime transitat=DateTime.MaxValue;
		private DateTime completedat=DateTime.MaxValue;
		private DateTime validatedAt=DateTime.MaxValue;
		private DateTime approvedAt=DateTime.MaxValue;
		private DateTime coauthorizedat=DateTime.MaxValue;
		private long authorizedby=0;
		private long orgid=0;
		private long orgaddressid=0;
		private string isstat=String.Empty;
		private string isSensitive=String.Empty;
		private long completedby=0;
		private long receivedby=0;
		private long collectedby=0;
		private long transferedby=0;

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
		/// Gets or sets the ID value.
		/// </summary>
		public long ID
		{
			get { return iD; }
			set { iD = value; }
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

		/// <summary>
		/// Gets or sets the ReportDateTime value.
		/// </summary>
		public DateTime ReportDateTime
		{
			get { return reportDateTime; }
			set { reportDateTime = value; }
		}

		/// <summary>
		/// Gets or sets the TatDateTime value.
		/// </summary>
		public DateTime TatDateTime
		{
			get { return tatDateTime; }
			set { tatDateTime = value; }
		}

		/// <summary>
		/// Gets or sets the ReferredAccessionNo value.
		/// </summary>
		public long ReferredAccessionNo
		{
			get { return referredAccessionNo; }
			set { referredAccessionNo = value; }
		}

		/// <summary>
		/// Gets or sets the LabNo value.
		/// </summary>
		public string LabNo
		{
			get { return labNo; }
			set { labNo = value; }
		}

		/// <summary>
		/// Gets or sets the ApprovedBy value.
		/// </summary>
		public long ApprovedBy
		{
			get { return approvedBy; }
			set { approvedBy = value; }
		}

		/// <summary>
		/// Gets or sets the ValidatedBy value.
		/// </summary>
		public long ValidatedBy
		{
			get { return validatedBy; }
			set { validatedBy = value; }
		}

		/// <summary>
		/// Gets or sets the Collectedat value.
		/// </summary>
		public DateTime Collectedat
		{
			get { return collectedat; }
			set { collectedat = value; }
		}

		/// <summary>
		/// Gets or sets the Receivedat value.
		/// </summary>
		public DateTime Receivedat
		{
			get { return receivedat; }
			set { receivedat = value; }
		}

		/// <summary>
		/// Gets or sets the Transitat value.
		/// </summary>
		public DateTime Transitat
		{
			get { return transitat; }
			set { transitat = value; }
		}

		/// <summary>
		/// Gets or sets the Completedat value.
		/// </summary>
		public DateTime Completedat
		{
			get { return completedat; }
			set { completedat = value; }
		}

		/// <summary>
		/// Gets or sets the ValidatedAt value.
		/// </summary>
		public DateTime ValidatedAt
		{
			get { return validatedAt; }
			set { validatedAt = value; }
		}

		/// <summary>
		/// Gets or sets the ApprovedAt value.
		/// </summary>
		public DateTime ApprovedAt
		{
			get { return approvedAt; }
			set { approvedAt = value; }
		}

		/// <summary>
		/// Gets or sets the Coauthorizedat value.
		/// </summary>
		public DateTime Coauthorizedat
		{
			get { return coauthorizedat; }
			set { coauthorizedat = value; }
		}

		/// <summary>
		/// Gets or sets the Authorizedby value.
		/// </summary>
		public long Authorizedby
		{
			get { return authorizedby; }
			set { authorizedby = value; }
		}

		/// <summary>
		/// Gets or sets the Orgid value.
		/// </summary>
		public long Orgid
		{
			get { return orgid; }
			set { orgid = value; }
		}

		/// <summary>
		/// Gets or sets the Orgaddressid value.
		/// </summary>
		public long Orgaddressid
		{
			get { return orgaddressid; }
			set { orgaddressid = value; }
		}

		/// <summary>
		/// Gets or sets the Isstat value.
		/// </summary>
		public string Isstat
		{
			get { return isstat; }
			set { isstat = value; }
		}

		/// <summary>
		/// Gets or sets the IsSensitive value.
		/// </summary>
		public string IsSensitive
		{
			get { return isSensitive; }
			set { isSensitive = value; }
		}

		/// <summary>
		/// Gets or sets the Completedby value.
		/// </summary>
		public long Completedby
		{
			get { return completedby; }
			set { completedby = value; }
		}

		/// <summary>
		/// Gets or sets the Receivedby value.
		/// </summary>
		public long Receivedby
		{
			get { return receivedby; }
			set { receivedby = value; }
		}

		/// <summary>
		/// Gets or sets the Collectedby value.
		/// </summary>
		public long Collectedby
		{
			get { return collectedby; }
			set { collectedby = value; }
		}

		/// <summary>
		/// Gets or sets the Transferedby value.
		/// </summary>
		public long Transferedby
		{
			get { return transferedby; }
			set { transferedby = value; }
		}


		#endregion
}
}
