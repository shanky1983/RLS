using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ResourceConsumption
	{
		#region Fields

		private long patientID=0;
		private long patientVisitID=0;
		private string serviceName=String.Empty;
		private long serviceID=0;
		private string resourceName=String.Empty;
		private long resourceID=0;
		private string consumptionValue=String.Empty;
		private DateTime consumptionDate=DateTime.MaxValue;
		private string comments=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAT=DateTime.MaxValue;
		private long mOdifiedBy=0;
		private string descriptions=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PatientID value.
		/// </summary>
		public long PatientID
		{
			get { return patientID; }
			set { patientID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientVisitID value.
		/// </summary>
		public long PatientVisitID
		{
			get { return patientVisitID; }
			set { patientVisitID = value; }
		}

		/// <summary>
		/// Gets or sets the ServiceName value.
		/// </summary>
		public string ServiceName
		{
			get { return serviceName; }
			set { serviceName = value; }
		}

		/// <summary>
		/// Gets or sets the ServiceID value.
		/// </summary>
		public long ServiceID
		{
			get { return serviceID; }
			set { serviceID = value; }
		}

		/// <summary>
		/// Gets or sets the ResourceName value.
		/// </summary>
		public string ResourceName
		{
			get { return resourceName; }
			set { resourceName = value; }
		}

		/// <summary>
		/// Gets or sets the ResourceID value.
		/// </summary>
		public long ResourceID
		{
			get { return resourceID; }
			set { resourceID = value; }
		}

		/// <summary>
		/// Gets or sets the ConsumptionValue value.
		/// </summary>
		public string ConsumptionValue
		{
			get { return consumptionValue; }
			set { consumptionValue = value; }
		}

		/// <summary>
		/// Gets or sets the ConsumptionDate value.
		/// </summary>
		public DateTime ConsumptionDate
		{
			get { return consumptionDate; }
			set { consumptionDate = value; }
		}

		/// <summary>
		/// Gets or sets the Comments value.
		/// </summary>
		public string Comments
		{
			get { return comments; }
			set { comments = value; }
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
		/// Gets or sets the ModifiedAT value.
		/// </summary>
		public DateTime ModifiedAT
		{
			get { return modifiedAT; }
			set { modifiedAT = value; }
		}

		/// <summary>
		/// Gets or sets the MOdifiedBy value.
		/// </summary>
		public long MOdifiedBy
		{
			get { return mOdifiedBy; }
			set { mOdifiedBy = value; }
		}

		/// <summary>
		/// Gets or sets the Descriptions value.
		/// </summary>
		public string Descriptions
		{
			get { return descriptions; }
			set { descriptions = value; }
		}


		#endregion
}
}
