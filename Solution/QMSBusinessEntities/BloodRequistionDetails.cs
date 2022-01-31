using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class BloodRequistionDetails
	{
		#region Fields

		private long bloodRequisitionDetailsID=0;
		private long bloodReceiveID=0;
		private long bloodComponent=0;
		private long noOfUnits=0;
		private long bloodGroup=0;
		private int productID=0;
		private string productName=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the BloodRequisitionDetailsID value.
		/// </summary>
		public long BloodRequisitionDetailsID
		{
			get { return bloodRequisitionDetailsID; }
			set { bloodRequisitionDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the BloodReceiveID value.
		/// </summary>
		public long BloodReceiveID
		{
			get { return bloodReceiveID; }
			set { bloodReceiveID = value; }
		}

		/// <summary>
		/// Gets or sets the BloodComponent value.
		/// </summary>
		public long BloodComponent
		{
			get { return bloodComponent; }
			set { bloodComponent = value; }
		}

		/// <summary>
		/// Gets or sets the NoOfUnits value.
		/// </summary>
		public long NoOfUnits
		{
			get { return noOfUnits; }
			set { noOfUnits = value; }
		}

		/// <summary>
		/// Gets or sets the BloodGroup value.
		/// </summary>
		public long BloodGroup
		{
			get { return bloodGroup; }
			set { bloodGroup = value; }
		}

		/// <summary>
		/// Gets or sets the ProductID value.
		/// </summary>
		public int ProductID
		{
			get { return productID; }
			set { productID = value; }
		}

		/// <summary>
		/// Gets or sets the ProductName value.
		/// </summary>
		public string ProductName
		{
			get { return productName; }
			set { productName = value; }
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
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public long CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
		}

		/// <summary>
		/// Gets or sets the ComponentName value.
		/// </summary>
		string _componentname;
		public string ComponentName
		{
			get { return _componentname; }
			set { _componentname = value; }
		}

		/// <summary>
		/// Gets or sets the TransfusionScheduledDate value.
		/// </summary>
		DateTime _transfusionscheduleddate;
		public DateTime TransfusionScheduledDate
		{
			get { return _transfusionscheduleddate; }
			set { _transfusionscheduleddate = value; }
		}

		/// <summary>
		/// Gets or sets the BagNumber value.
		/// </summary>
		string _bagnumber;
		public string BagNumber
		{
			get { return _bagnumber; }
			set { _bagnumber = value; }
		}

		/// <summary>
		/// Gets or sets the Rate value.
		/// </summary>
		decimal _rate;
		public decimal Rate
		{
			get { return _rate; }
			set { _rate = value; }
		}

		/// <summary>
		/// Gets or sets the CompatiblityTestingdone value.
		/// </summary>
		string _compatiblitytestingdone;
		public string CompatiblityTestingdone
		{
			get { return _compatiblitytestingdone; }
			set { _compatiblitytestingdone = value; }
		}


		#endregion
}
}
