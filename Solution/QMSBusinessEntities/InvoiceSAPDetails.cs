using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class InvoiceSAPDetails
	{
		#region Fields

		private long iNVOICESAPID=0;
		private long iNVOICEID=0;
		private string sAPINVNO=String.Empty;
		private DateTime sAPINVPOSTINGDATE=DateTime.MaxValue;
		private DateTime sAPINVBOOKINGDATE=DateTime.MaxValue;
		private decimal sAPINVAMOUNT=Decimal.Zero;
		private string sAPINVCLCODE=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the INVOICESAPID value.
		/// </summary>
		public long INVOICESAPID
		{
			get { return iNVOICESAPID; }
			set { iNVOICESAPID = value; }
		}

		/// <summary>
		/// Gets or sets the INVOICEID value.
		/// </summary>
		public long INVOICEID
		{
			get { return iNVOICEID; }
			set { iNVOICEID = value; }
		}

		/// <summary>
		/// Gets or sets the SAPINVNO value.
		/// </summary>
		public string SAPINVNO
		{
			get { return sAPINVNO; }
			set { sAPINVNO = value; }
		}

		/// <summary>
		/// Gets or sets the SAPINVPOSTINGDATE value.
		/// </summary>
		public DateTime SAPINVPOSTINGDATE
		{
			get { return sAPINVPOSTINGDATE; }
			set { sAPINVPOSTINGDATE = value; }
		}

		/// <summary>
		/// Gets or sets the SAPINVBOOKINGDATE value.
		/// </summary>
		public DateTime SAPINVBOOKINGDATE
		{
			get { return sAPINVBOOKINGDATE; }
			set { sAPINVBOOKINGDATE = value; }
		}

		/// <summary>
		/// Gets or sets the SAPINVAMOUNT value.
		/// </summary>
		public decimal SAPINVAMOUNT
		{
			get { return sAPINVAMOUNT; }
			set { sAPINVAMOUNT = value; }
		}

		/// <summary>
		/// Gets or sets the SAPINVCLCODE value.
		/// </summary>
		public string SAPINVCLCODE
		{
			get { return sAPINVCLCODE; }
			set { sAPINVCLCODE = value; }
		}


		#endregion
}
}
