using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ML_HISTOREGISTRATION
	{
		#region Fields

		private int id=0;
		private string histo_dept=String.Empty;
		private string sidno=String.Empty;
		private string regdate=String.Empty;
		private string regtime=String.Empty;
		private string pat_name=String.Empty;
		private decimal pat_age=Decimal.Zero;
		private string pat_sex=String.Empty;
		private string tcode=String.Empty;
		private string tname=String.Empty;
		private string tresname=String.Empty;
		private string clname=String.Empty;
		private string hrepdate=String.Empty;
		private string hfindate=String.Empty;
		private string dTDATREP=String.Empty;
		private string dTTIME=String.Empty;
		private string remarks=String.Empty;
		private int cuid=0;
		private string cdate=String.Empty;
		private int uuid=0;
		private string udate=String.Empty;
		private int cfreeze=0;
		private string dbType=String.Empty;
		private int finyr=0;
		private int lims_flag=0;
		private string barcode=String.Empty;
		private string attuneBarcode=String.Empty;
		private int orgID=0;
		private long visitID=0;
		private int aCRPID=0;
		private int aORGID=0;
		private string aTYPE=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id value.
		/// </summary>
		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		/// <summary>
		/// Gets or sets the Histo_dept value.
		/// </summary>
		public string Histo_dept
		{
			get { return histo_dept; }
			set { histo_dept = value; }
		}

		/// <summary>
		/// Gets or sets the Sidno value.
		/// </summary>
		public string Sidno
		{
			get { return sidno; }
			set { sidno = value; }
		}

		/// <summary>
		/// Gets or sets the Regdate value.
		/// </summary>
		public string Regdate
		{
			get { return regdate; }
			set { regdate = value; }
		}

		/// <summary>
		/// Gets or sets the Regtime value.
		/// </summary>
		public string Regtime
		{
			get { return regtime; }
			set { regtime = value; }
		}

		/// <summary>
		/// Gets or sets the Pat_name value.
		/// </summary>
		public string Pat_name
		{
			get { return pat_name; }
			set { pat_name = value; }
		}

		/// <summary>
		/// Gets or sets the Pat_age value.
		/// </summary>
		public decimal Pat_age
		{
			get { return pat_age; }
			set { pat_age = value; }
		}

		/// <summary>
		/// Gets or sets the Pat_sex value.
		/// </summary>
		public string Pat_sex
		{
			get { return pat_sex; }
			set { pat_sex = value; }
		}

		/// <summary>
		/// Gets or sets the Tcode value.
		/// </summary>
		public string Tcode
		{
			get { return tcode; }
			set { tcode = value; }
		}

		/// <summary>
		/// Gets or sets the Tname value.
		/// </summary>
		public string Tname
		{
			get { return tname; }
			set { tname = value; }
		}

		/// <summary>
		/// Gets or sets the Tresname value.
		/// </summary>
		public string Tresname
		{
			get { return tresname; }
			set { tresname = value; }
		}

		/// <summary>
		/// Gets or sets the Clname value.
		/// </summary>
		public string Clname
		{
			get { return clname; }
			set { clname = value; }
		}

		/// <summary>
		/// Gets or sets the Hrepdate value.
		/// </summary>
		public string Hrepdate
		{
			get { return hrepdate; }
			set { hrepdate = value; }
		}

		/// <summary>
		/// Gets or sets the Hfindate value.
		/// </summary>
		public string Hfindate
		{
			get { return hfindate; }
			set { hfindate = value; }
		}

		/// <summary>
		/// Gets or sets the DTDATREP value.
		/// </summary>
		public string DTDATREP
		{
			get { return dTDATREP; }
			set { dTDATREP = value; }
		}

		/// <summary>
		/// Gets or sets the DTTIME value.
		/// </summary>
		public string DTTIME
		{
			get { return dTTIME; }
			set { dTTIME = value; }
		}

		/// <summary>
		/// Gets or sets the Remarks value.
		/// </summary>
		public string Remarks
		{
			get { return remarks; }
			set { remarks = value; }
		}

		/// <summary>
		/// Gets or sets the Cuid value.
		/// </summary>
		public int Cuid
		{
			get { return cuid; }
			set { cuid = value; }
		}

		/// <summary>
		/// Gets or sets the Cdate value.
		/// </summary>
		public string Cdate
		{
			get { return cdate; }
			set { cdate = value; }
		}

		/// <summary>
		/// Gets or sets the Uuid value.
		/// </summary>
		public int Uuid
		{
			get { return uuid; }
			set { uuid = value; }
		}

		/// <summary>
		/// Gets or sets the Udate value.
		/// </summary>
		public string Udate
		{
			get { return udate; }
			set { udate = value; }
		}

		/// <summary>
		/// Gets or sets the Cfreeze value.
		/// </summary>
		public int Cfreeze
		{
			get { return cfreeze; }
			set { cfreeze = value; }
		}

		/// <summary>
		/// Gets or sets the DbType value.
		/// </summary>
		public string DbType
		{
			get { return dbType; }
			set { dbType = value; }
		}

		/// <summary>
		/// Gets or sets the Finyr value.
		/// </summary>
		public int Finyr
		{
			get { return finyr; }
			set { finyr = value; }
		}

		/// <summary>
		/// Gets or sets the Lims_flag value.
		/// </summary>
		public int Lims_flag
		{
			get { return lims_flag; }
			set { lims_flag = value; }
		}

		/// <summary>
		/// Gets or sets the Barcode value.
		/// </summary>
		public string Barcode
		{
			get { return barcode; }
			set { barcode = value; }
		}

		/// <summary>
		/// Gets or sets the AttuneBarcode value.
		/// </summary>
		public string AttuneBarcode
		{
			get { return attuneBarcode; }
			set { attuneBarcode = value; }
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
		/// Gets or sets the VisitID value.
		/// </summary>
		public long VisitID
		{
			get { return visitID; }
			set { visitID = value; }
		}

		/// <summary>
		/// Gets or sets the ACRPID value.
		/// </summary>
		public int ACRPID
		{
			get { return aCRPID; }
			set { aCRPID = value; }
		}

		/// <summary>
		/// Gets or sets the AORGID value.
		/// </summary>
		public int AORGID
		{
			get { return aORGID; }
			set { aORGID = value; }
		}

		/// <summary>
		/// Gets or sets the ATYPE value.
		/// </summary>
		public string ATYPE
		{
			get { return aTYPE; }
			set { aTYPE = value; }
		}


		#endregion
}
}
