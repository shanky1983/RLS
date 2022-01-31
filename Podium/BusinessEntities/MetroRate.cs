using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class MetroRate
	{
		#region Fields

		private string clientCode=String.Empty;
		private string pRICETYPE=String.Empty;
		private string tESTCODE=String.Empty;
		private string test_Category=String.Empty;
		private decimal rate=Decimal.Zero;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ClientCode value.
		/// </summary>
		public string ClientCode
		{
			get { return clientCode; }
			set { clientCode = value; }
		}

		/// <summary>
		/// Gets or sets the PRICETYPE value.
		/// </summary>
		public string PRICETYPE
		{
			get { return pRICETYPE; }
			set { pRICETYPE = value; }
		}

		/// <summary>
		/// Gets or sets the TESTCODE value.
		/// </summary>
		public string TESTCODE
		{
			get { return tESTCODE; }
			set { tESTCODE = value; }
		}

		/// <summary>
		/// Gets or sets the Test_Category value.
		/// </summary>
		public string Test_Category
		{
			get { return test_Category; }
			set { test_Category = value; }
		}

		/// <summary>
		/// Gets or sets the Rate value.
		/// </summary>
		public decimal Rate
		{
			get { return rate; }
			set { rate = value; }
		}


		#endregion
}
}
