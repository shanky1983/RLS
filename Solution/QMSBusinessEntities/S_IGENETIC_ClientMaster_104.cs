using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class S_IGENETIC_ClientMaster_104
	{
		#region Fields

		private long oldClientID=0;
		private string clientCode=String.Empty;
		private string clientName=String.Empty;
		private string contactPerson=String.Empty;
		private string termsconditions=String.Empty;
		private string cstNo=String.Empty;
		private int despatchModeID=0;
		private string serviceTaxNo=String.Empty;
		private string panNo=String.Empty;
		private string approvalRequired=String.Empty;
		private string clientStatus=String.Empty;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int orgAddressID=0;
		private string status=String.Empty;
		private int clientTypeID=0;
		private string attributes=String.Empty;
		private long zonalID=0;
		private string sapCode=String.Empty;
		private long salesManID=0;
		private decimal creditLimit=Decimal.Zero;
		private string pathologist=String.Empty;
		private string blockedClient=String.Empty;
		private long customerType=0;
		private string isLoginNeeded=String.Empty;
		private long reportTemplateID=0;
		private long creditDays=0;
		private decimal graceLimit=Decimal.Zero;
		private long graceDays=0;
		private long parentClientID=0;
		private int addressID=0;
		private long collectionCenterID=0;
		private string iSCash=String.Empty;
		private string isDeleted=String.Empty;
		private string isParentPayer=String.Empty;
		private string reason=String.Empty;
		private long referID=0;
		private int hubID=0;
		private int paymentDays=0;
		private int referingID=0;
		private long todID=0;
		private string isDiscount=String.Empty;
		private DateTime blockFrom=DateTime.MaxValue;
		private DateTime blockTo=DateTime.MaxValue;
		private string isMappedItem=String.Empty;
		private string isScheduled=String.Empty;
		private long authorizedBy=0;
		private int transitTimeValue=0;
		private string transitTimeType=String.Empty;
		private string tax=String.Empty;
		private long discountPolicyID=0;
		private long routeID=0;
		private long voLID=0;
		private decimal promisedAmount=Decimal.Zero;
		private long loginID=0;
		private int isClientAccess=0;
		private string billType=String.Empty;
		private long newClientID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the OldClientID value.
		/// </summary>
		public long OldClientID
		{
			get { return oldClientID; }
			set { oldClientID = value; }
		}

		/// <summary>
		/// Gets or sets the ClientCode value.
		/// </summary>
		public string ClientCode
		{
			get { return clientCode; }
			set { clientCode = value; }
		}

		/// <summary>
		/// Gets or sets the ClientName value.
		/// </summary>
		public string ClientName
		{
			get { return clientName; }
			set { clientName = value; }
		}

		/// <summary>
		/// Gets or sets the ContactPerson value.
		/// </summary>
		public string ContactPerson
		{
			get { return contactPerson; }
			set { contactPerson = value; }
		}

		/// <summary>
		/// Gets or sets the Termsconditions value.
		/// </summary>
		public string Termsconditions
		{
			get { return termsconditions; }
			set { termsconditions = value; }
		}

		/// <summary>
		/// Gets or sets the CstNo value.
		/// </summary>
		public string CstNo
		{
			get { return cstNo; }
			set { cstNo = value; }
		}

		/// <summary>
		/// Gets or sets the DespatchModeID value.
		/// </summary>
		public int DespatchModeID
		{
			get { return despatchModeID; }
			set { despatchModeID = value; }
		}

		/// <summary>
		/// Gets or sets the ServiceTaxNo value.
		/// </summary>
		public string ServiceTaxNo
		{
			get { return serviceTaxNo; }
			set { serviceTaxNo = value; }
		}

		/// <summary>
		/// Gets or sets the PanNo value.
		/// </summary>
		public string PanNo
		{
			get { return panNo; }
			set { panNo = value; }
		}

		/// <summary>
		/// Gets or sets the ApprovalRequired value.
		/// </summary>
		public string ApprovalRequired
		{
			get { return approvalRequired; }
			set { approvalRequired = value; }
		}

		/// <summary>
		/// Gets or sets the ClientStatus value.
		/// </summary>
		public string ClientStatus
		{
			get { return clientStatus; }
			set { clientStatus = value; }
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
		/// Gets or sets the OrgAddressID value.
		/// </summary>
		public int OrgAddressID
		{
			get { return orgAddressID; }
			set { orgAddressID = value; }
		}

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the ClientTypeID value.
		/// </summary>
		public int ClientTypeID
		{
			get { return clientTypeID; }
			set { clientTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the Attributes value.
		/// </summary>
		public string Attributes
		{
			get { return attributes; }
			set { attributes = value; }
		}

		/// <summary>
		/// Gets or sets the ZonalID value.
		/// </summary>
		public long ZonalID
		{
			get { return zonalID; }
			set { zonalID = value; }
		}

		/// <summary>
		/// Gets or sets the SapCode value.
		/// </summary>
		public string SapCode
		{
			get { return sapCode; }
			set { sapCode = value; }
		}

		/// <summary>
		/// Gets or sets the SalesManID value.
		/// </summary>
		public long SalesManID
		{
			get { return salesManID; }
			set { salesManID = value; }
		}

		/// <summary>
		/// Gets or sets the CreditLimit value.
		/// </summary>
		public decimal CreditLimit
		{
			get { return creditLimit; }
			set { creditLimit = value; }
		}

		/// <summary>
		/// Gets or sets the Pathologist value.
		/// </summary>
		public string Pathologist
		{
			get { return pathologist; }
			set { pathologist = value; }
		}

		/// <summary>
		/// Gets or sets the BlockedClient value.
		/// </summary>
		public string BlockedClient
		{
			get { return blockedClient; }
			set { blockedClient = value; }
		}

		/// <summary>
		/// Gets or sets the CustomerType value.
		/// </summary>
		public long CustomerType
		{
			get { return customerType; }
			set { customerType = value; }
		}

		/// <summary>
		/// Gets or sets the IsLoginNeeded value.
		/// </summary>
		public string IsLoginNeeded
		{
			get { return isLoginNeeded; }
			set { isLoginNeeded = value; }
		}

		/// <summary>
		/// Gets or sets the ReportTemplateID value.
		/// </summary>
		public long ReportTemplateID
		{
			get { return reportTemplateID; }
			set { reportTemplateID = value; }
		}

		/// <summary>
		/// Gets or sets the CreditDays value.
		/// </summary>
		public long CreditDays
		{
			get { return creditDays; }
			set { creditDays = value; }
		}

		/// <summary>
		/// Gets or sets the GraceLimit value.
		/// </summary>
		public decimal GraceLimit
		{
			get { return graceLimit; }
			set { graceLimit = value; }
		}

		/// <summary>
		/// Gets or sets the GraceDays value.
		/// </summary>
		public long GraceDays
		{
			get { return graceDays; }
			set { graceDays = value; }
		}

		/// <summary>
		/// Gets or sets the ParentClientID value.
		/// </summary>
		public long ParentClientID
		{
			get { return parentClientID; }
			set { parentClientID = value; }
		}

		/// <summary>
		/// Gets or sets the AddressID value.
		/// </summary>
		public int AddressID
		{
			get { return addressID; }
			set { addressID = value; }
		}

		/// <summary>
		/// Gets or sets the CollectionCenterID value.
		/// </summary>
		public long CollectionCenterID
		{
			get { return collectionCenterID; }
			set { collectionCenterID = value; }
		}

		/// <summary>
		/// Gets or sets the ISCash value.
		/// </summary>
		public string ISCash
		{
			get { return iSCash; }
			set { iSCash = value; }
		}

		/// <summary>
		/// Gets or sets the IsDeleted value.
		/// </summary>
		public string IsDeleted
		{
			get { return isDeleted; }
			set { isDeleted = value; }
		}

		/// <summary>
		/// Gets or sets the IsParentPayer value.
		/// </summary>
		public string IsParentPayer
		{
			get { return isParentPayer; }
			set { isParentPayer = value; }
		}

		/// <summary>
		/// Gets or sets the Reason value.
		/// </summary>
		public string Reason
		{
			get { return reason; }
			set { reason = value; }
		}

		/// <summary>
		/// Gets or sets the ReferID value.
		/// </summary>
		public long ReferID
		{
			get { return referID; }
			set { referID = value; }
		}

		/// <summary>
		/// Gets or sets the HubID value.
		/// </summary>
		public int HubID
		{
			get { return hubID; }
			set { hubID = value; }
		}

		/// <summary>
		/// Gets or sets the PaymentDays value.
		/// </summary>
		public int PaymentDays
		{
			get { return paymentDays; }
			set { paymentDays = value; }
		}

		/// <summary>
		/// Gets or sets the ReferingID value.
		/// </summary>
		public int ReferingID
		{
			get { return referingID; }
			set { referingID = value; }
		}

		/// <summary>
		/// Gets or sets the TodID value.
		/// </summary>
		public long TodID
		{
			get { return todID; }
			set { todID = value; }
		}

		/// <summary>
		/// Gets or sets the IsDiscount value.
		/// </summary>
		public string IsDiscount
		{
			get { return isDiscount; }
			set { isDiscount = value; }
		}

		/// <summary>
		/// Gets or sets the BlockFrom value.
		/// </summary>
		public DateTime BlockFrom
		{
			get { return blockFrom; }
			set { blockFrom = value; }
		}

		/// <summary>
		/// Gets or sets the BlockTo value.
		/// </summary>
		public DateTime BlockTo
		{
			get { return blockTo; }
			set { blockTo = value; }
		}

		/// <summary>
		/// Gets or sets the IsMappedItem value.
		/// </summary>
		public string IsMappedItem
		{
			get { return isMappedItem; }
			set { isMappedItem = value; }
		}

		/// <summary>
		/// Gets or sets the IsScheduled value.
		/// </summary>
		public string IsScheduled
		{
			get { return isScheduled; }
			set { isScheduled = value; }
		}

		/// <summary>
		/// Gets or sets the AuthorizedBy value.
		/// </summary>
		public long AuthorizedBy
		{
			get { return authorizedBy; }
			set { authorizedBy = value; }
		}

		/// <summary>
		/// Gets or sets the TransitTimeValue value.
		/// </summary>
		public int TransitTimeValue
		{
			get { return transitTimeValue; }
			set { transitTimeValue = value; }
		}

		/// <summary>
		/// Gets or sets the TransitTimeType value.
		/// </summary>
		public string TransitTimeType
		{
			get { return transitTimeType; }
			set { transitTimeType = value; }
		}

		/// <summary>
		/// Gets or sets the Tax value.
		/// </summary>
		public string Tax
		{
			get { return tax; }
			set { tax = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountPolicyID value.
		/// </summary>
		public long DiscountPolicyID
		{
			get { return discountPolicyID; }
			set { discountPolicyID = value; }
		}

		/// <summary>
		/// Gets or sets the RouteID value.
		/// </summary>
		public long RouteID
		{
			get { return routeID; }
			set { routeID = value; }
		}

		/// <summary>
		/// Gets or sets the VoLID value.
		/// </summary>
		public long VoLID
		{
			get { return voLID; }
			set { voLID = value; }
		}

		/// <summary>
		/// Gets or sets the PromisedAmount value.
		/// </summary>
		public decimal PromisedAmount
		{
			get { return promisedAmount; }
			set { promisedAmount = value; }
		}

		/// <summary>
		/// Gets or sets the LoginID value.
		/// </summary>
		public long LoginID
		{
			get { return loginID; }
			set { loginID = value; }
		}

		/// <summary>
		/// Gets or sets the IsClientAccess value.
		/// </summary>
		public int IsClientAccess
		{
			get { return isClientAccess; }
			set { isClientAccess = value; }
		}

		/// <summary>
		/// Gets or sets the BillType value.
		/// </summary>
		public string BillType
		{
			get { return billType; }
			set { billType = value; }
		}

		/// <summary>
		/// Gets or sets the NewClientID value.
		/// </summary>
		public long NewClientID
		{
			get { return newClientID; }
			set { newClientID = value; }
		}


		#endregion
}
}
