using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class TblRateMasterDuplication
	{
		#region Fields

		private int sno=0;
		private long ratetypeid=0;
		private int orgid=0;
		private string testcode=String.Empty;
		private string testtype=String.Empty;
		private string testname=String.Empty;
		private string ratename=String.Empty;
		private decimal rate=Decimal.Zero;
		private string isvalid=String.Empty;
		private long orgtestid=0;
		private long rateid=0;
		private long raterefid=0;
		private int createdby=0;
		private DateTime createdat=DateTime.MaxValue;
		private int id=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Sno value.
		/// </summary>
		public int Sno
		{
			get { return sno; }
			set { sno = value; }
		}

		/// <summary>
		/// Gets or sets the Ratetypeid value.
		/// </summary>
		public long Ratetypeid
		{
			get { return ratetypeid; }
			set { ratetypeid = value; }
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
		/// Gets or sets the Testcode value.
		/// </summary>
		public string Testcode
		{
			get { return testcode; }
			set { testcode = value; }
		}

		/// <summary>
		/// Gets or sets the Testtype value.
		/// </summary>
		public string Testtype
		{
			get { return testtype; }
			set { testtype = value; }
		}

		/// <summary>
		/// Gets or sets the Testname value.
		/// </summary>
		public string Testname
		{
			get { return testname; }
			set { testname = value; }
		}

		/// <summary>
		/// Gets or sets the Ratename value.
		/// </summary>
		public string Ratename
		{
			get { return ratename; }
			set { ratename = value; }
		}

		/// <summary>
		/// Gets or sets the Rate value.
		/// </summary>
		public decimal Rate
		{
			get { return rate; }
			set { rate = value; }
		}

		/// <summary>
		/// Gets or sets the Isvalid value.
		/// </summary>
		public string Isvalid
		{
			get { return isvalid; }
			set { isvalid = value; }
		}

		/// <summary>
		/// Gets or sets the Orgtestid value.
		/// </summary>
		public long Orgtestid
		{
			get { return orgtestid; }
			set { orgtestid = value; }
		}

		/// <summary>
		/// Gets or sets the Rateid value.
		/// </summary>
		public long Rateid
		{
			get { return rateid; }
			set { rateid = value; }
		}

		/// <summary>
		/// Gets or sets the Raterefid value.
		/// </summary>
		public long Raterefid
		{
			get { return raterefid; }
			set { raterefid = value; }
		}

		/// <summary>
		/// Gets or sets the Createdby value.
		/// </summary>
		public int Createdby
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
		/// Gets or sets the Id value.
		/// </summary>
		public int Id
		{
			get { return id; }
			set { id = value; }
		}


		#endregion
}
}
