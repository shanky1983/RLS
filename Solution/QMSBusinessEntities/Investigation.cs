using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Investigation
	{
		#region Fields

		private long investigationID=0;
		private string investigationName=String.Empty;
		private string description=String.Empty;
		private int uOMID=0;
		private long parentID=0;
		private long headerID=0;
		private string collectionTime=String.Empty;
		private string quantityRequired=String.Empty;
		private string storageTemperature=String.Empty;
		private string isInfective=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the InvestigationID value.
		/// </summary>
		public long InvestigationID
		{
			get { return investigationID; }
			set { investigationID = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationName value.
		/// </summary>
		public string InvestigationName
		{
			get { return investigationName; }
			set { investigationName = value; }
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
		/// Gets or sets the UOMID value.
		/// </summary>
		public int UOMID
		{
			get { return uOMID; }
			set { uOMID = value; }
		}

		/// <summary>
		/// Gets or sets the ParentID value.
		/// </summary>
		public long ParentID
		{
			get { return parentID; }
			set { parentID = value; }
		}

		/// <summary>
		/// Gets or sets the HeaderID value.
		/// </summary>
		public long HeaderID
		{
			get { return headerID; }
			set { headerID = value; }
		}

		/// <summary>
		/// Gets or sets the CollectionTime value.
		/// </summary>
		public string CollectionTime
		{
			get { return collectionTime; }
			set { collectionTime = value; }
		}

		/// <summary>
		/// Gets or sets the QuantityRequired value.
		/// </summary>
		public string QuantityRequired
		{
			get { return quantityRequired; }
			set { quantityRequired = value; }
		}

		/// <summary>
		/// Gets or sets the StorageTemperature value.
		/// </summary>
		public string StorageTemperature
		{
			get { return storageTemperature; }
			set { storageTemperature = value; }
		}

		/// <summary>
		/// Gets or sets the IsInfective value.
		/// </summary>
		public string IsInfective
		{
			get { return isInfective; }
			set { isInfective = value; }
		}

		/// <summary>
		/// Gets or sets the PatternName value.
		/// </summary>
		string _patternname;
		public string PatternName
		{
			get { return _patternname; }
			set { _patternname = value; }
		}

		/// <summary>
		/// Gets or sets the UOMCode value.
		/// </summary>
		string _uomcode;
		public string UOMCode
		{
			get { return _uomcode; }
			set { _uomcode = value; }
		}

		/// <summary>
		/// Gets or sets the HeaderName value.
		/// </summary>
		string _headername;
		public string HeaderName
		{
			get { return _headername; }
			set { _headername = value; }
		}

		/// <summary>
		/// Gets or sets the PatternID value.
		/// </summary>
		long  _patternid;
		public long  PatternID
		{
			get { return _patternid; }
			set { _patternid = value; }
		}

		/// <summary>
		/// Gets or sets the SNo value.
		/// </summary>
		string _sno;
		public string SNo
		{
			get { return _sno; }
			set { _sno = value; }
		}


		#endregion
}
}
