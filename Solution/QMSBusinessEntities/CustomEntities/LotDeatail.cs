using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class LotDeatail
	{
		#region Fields

		private long lotID=0;
		private string lotCode=String.Empty;
		private string lotName=String.Empty;
		private long metaValueID=0;
		private string valu=String.Empty;
		private string code=String.Empty;
		private string description=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the LotID value.
		/// </summary>
		public long LotID
		{
			get { return lotID; }
			set { lotID = value; }
		}

		/// <summary>
		/// Gets or sets the LotCode value.
		/// </summary>
		public string LotCode
		{
			get { return lotCode; }
			set { lotCode = value; }
		}

		/// <summary>
		/// Gets or sets the LotName value.
		/// </summary>
		public string LotName
		{
			get { return lotName; }
			set { lotName = value; }
		}

		/// <summary>
		/// Gets or sets the MetaValueID value.
		/// </summary>
		public long MetaValueID
		{
			get { return metaValueID; }
			set { metaValueID = value; }
		}

		/// <summary>
		/// Gets or sets the Valu value.
		/// </summary>
		public string Value
		{
			get { return valu; }
			set { valu = value; }
		}

		/// <summary>
		/// Gets or sets the Code value.
		/// </summary>
		public string Code
		{
			get { return code; }
			set { code = value; }
		}

		/// <summary>
		/// Gets or sets the Description value.
		/// </summary>
		public string Description
		{
			get { return description; }
			set { description = value; }
		}


		#endregion
    }
}
