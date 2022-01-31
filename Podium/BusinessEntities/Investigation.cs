using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
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
		private string _patternName=String.Empty;
		public string PatternName
		{
			get { return  _patternName; }
			set { _patternName = value; }
		}

		/// <summary>
		/// Gets or sets the UOMCode value.
		/// </summary>
		private string _uOMCode=String.Empty;
		public string UOMCode
		{
			get { return  _uOMCode; }
			set { _uOMCode = value; }
		}

		/// <summary>
		/// Gets or sets the HeaderName value.
		/// </summary>
		private string _headerName=String.Empty;
		public string HeaderName
		{
			get { return  _headerName; }
			set { _headerName = value; }
		}

		/// <summary>
		/// Gets or sets the PatternID value.
		/// </summary>
		private long _patternID=0;
		public long PatternID
		{
			get { return  _patternID; }
			set { _patternID = value; }
		}

		/// <summary>
		/// Gets or sets the SNo value.
		/// </summary>
		private string _sNo=String.Empty;
		public string SNo
		{
			get { return  _sNo; }
			set { _sNo = value; }
		}


		#endregion
}
}
