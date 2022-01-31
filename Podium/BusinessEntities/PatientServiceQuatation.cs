using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PatientServiceQuatation
	{
		#region Fields

		private long quatationID=0;
		private long patientID=0;
		private long visitID=0;
		private long serviceID=0;
		private string serviceCode=String.Empty;
		private string serviceName=String.Empty;
		private string serviceType=String.Empty;
		private decimal amount=Decimal.Zero;
		private decimal advance=Decimal.Zero;
		private long orderID=0;
		private long performerID=0;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int quantity=0;
		private decimal discount=Decimal.Zero;
		private decimal copayment=Decimal.Zero;
		private long parentQuatationID=0;
		private string recordType=String.Empty;
		private string remarks=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the QuatationID value.
		/// </summary>
		public long QuatationID
		{
			get { return quatationID; }
			set { quatationID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientID value.
		/// </summary>
		public long PatientID
		{
			get { return patientID; }
			set { patientID = value; }
		}

		/// <summary>
		/// Gets or sets the VisitID value.
		/// </summary>
		public long VisitID
		{
			get { return visitID; }
			set { visitID = value; }
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
		/// Gets or sets the ServiceCode value.
		/// </summary>
		public string ServiceCode
		{
			get { return serviceCode; }
			set { serviceCode = value; }
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
		/// Gets or sets the ServiceType value.
		/// </summary>
		public string ServiceType
		{
			get { return serviceType; }
			set { serviceType = value; }
		}

		/// <summary>
		/// Gets or sets the Amount value.
		/// </summary>
		public decimal Amount
		{
			get { return amount; }
			set { amount = value; }
		}

		/// <summary>
		/// Gets or sets the Advance value.
		/// </summary>
		public decimal Advance
		{
			get { return advance; }
			set { advance = value; }
		}

		/// <summary>
		/// Gets or sets the OrderID value.
		/// </summary>
		public long OrderID
		{
			get { return orderID; }
			set { orderID = value; }
		}

		/// <summary>
		/// Gets or sets the PerformerID value.
		/// </summary>
		public long PerformerID
		{
			get { return performerID; }
			set { performerID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
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
		/// Gets or sets the CreatedAt value.
		/// </summary>
		public DateTime CreatedAt
		{
			get { return createdAt; }
			set { createdAt = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public long ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
		}

		/// <summary>
		/// Gets or sets the Quantity value.
		/// </summary>
		public int Quantity
		{
			get { return quantity; }
			set { quantity = value; }
		}

		/// <summary>
		/// Gets or sets the Discount value.
		/// </summary>
		public decimal Discount
		{
			get { return discount; }
			set { discount = value; }
		}

		/// <summary>
		/// Gets or sets the Copayment value.
		/// </summary>
		public decimal Copayment
		{
			get { return copayment; }
			set { copayment = value; }
		}

		/// <summary>
		/// Gets or sets the ParentQuatationID value.
		/// </summary>
		public long ParentQuatationID
		{
			get { return parentQuatationID; }
			set { parentQuatationID = value; }
		}

		/// <summary>
		/// Gets or sets the RecordType value.
		/// </summary>
		public string RecordType
		{
			get { return recordType; }
			set { recordType = value; }
		}

		/// <summary>
		/// Gets or sets the Remarks value.
		/// </summary>
		public string Remarks
		{
			get { return remarks; }
			set { remarks = value; }
		}


		#endregion
}
}
