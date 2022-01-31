using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class MLTURNOVERLIMIT
	{
		#region Fields

		private decimal lMFROM=Decimal.Zero;
		private decimal lMTO=Decimal.Zero;
		private short lMPERCENTAGE=0;
		private string lMLOGIN=String.Empty;
		private DateTime lMDATE=DateTime.MaxValue;
		private int rOWID=0;
		private string uSRLOCK=String.Empty;
		private string lMPRICELISTTYPE=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the LMFROM value.
		/// </summary>
		public decimal LMFROM
		{
			get { return lMFROM; }
			set { lMFROM = value; }
		}

		/// <summary>
		/// Gets or sets the LMTO value.
		/// </summary>
		public decimal LMTO
		{
			get { return lMTO; }
			set { lMTO = value; }
		}

		/// <summary>
		/// Gets or sets the LMPERCENTAGE value.
		/// </summary>
		public short LMPERCENTAGE
		{
			get { return lMPERCENTAGE; }
			set { lMPERCENTAGE = value; }
		}

		/// <summary>
		/// Gets or sets the LMLOGIN value.
		/// </summary>
		public string LMLOGIN
		{
			get { return lMLOGIN; }
			set { lMLOGIN = value; }
		}

		/// <summary>
		/// Gets or sets the LMDATE value.
		/// </summary>
		public DateTime LMDATE
		{
			get { return lMDATE; }
			set { lMDATE = value; }
		}

		/// <summary>
		/// Gets or sets the ROWID value.
		/// </summary>
		public int ROWID
		{
			get { return rOWID; }
			set { rOWID = value; }
		}

		/// <summary>
		/// Gets or sets the USRLOCK value.
		/// </summary>
		public string USRLOCK
		{
			get { return uSRLOCK; }
			set { uSRLOCK = value; }
		}

		/// <summary>
		/// Gets or sets the LMPRICELISTTYPE value.
		/// </summary>
		public string LMPRICELISTTYPE
		{
			get { return lMPRICELISTTYPE; }
			set { lMPRICELISTTYPE = value; }
		}


		#endregion
}
}
