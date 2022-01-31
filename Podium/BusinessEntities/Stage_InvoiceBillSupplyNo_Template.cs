using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class Stage_InvoiceBillSupplyNo_Template
	{
		#region Fields

		private int orgid =0;
		private string sono =String.Empty;
		private string date =String.Empty;
		
		private string attinvno =String.Empty;
		private string billsupplyno =String.Empty;
		private string clientcode =String.Empty;
        private decimal Amount;
		

		#endregion

		#region Properties
		
		public int OrgID
		{
			get { return orgid; }
			set { orgid = value; }
		}

		
		public string SONo
		{
			get { return sono; }
			set { sono = value; }
		}

		
		public string Date
		{
			get { return date; }
			set { date = value; }
		}

		
		public string AttuneInvoiceNo
		{
			get { return attinvno; }
			set { attinvno = value; }
		}

		
		public string BillofSupplyNo
		{
			get { return billsupplyno; }
			set { billsupplyno = value; }
		}

		
		public string ClientCode
		{
			get { return clientcode; }
			set { clientcode = value; }
		}

		
		public decimal Value
		{
            get { return Amount; }
            set { Amount = value; }
		}

		


		#endregion
}
}
