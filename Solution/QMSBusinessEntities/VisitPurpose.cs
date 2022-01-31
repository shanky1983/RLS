using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class VisitPurpose
	{
		#region Fields

		private int visitPurposeID=0;
		private string visitPurposeName=String.Empty;
		private int orgID=0;
		private int taskActionID=0;
		private string paymentMode=String.Empty;
		private string visitType=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the VisitPurposeID value.
		/// </summary>
		public int VisitPurposeID
		{
			get { return visitPurposeID; }
			set { visitPurposeID = value; }
		}

		/// <summary>
		/// Gets or sets the VisitPurposeName value.
		/// </summary>
		public string VisitPurposeName
		{
			get { return visitPurposeName; }
			set { visitPurposeName = value; }
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
		/// Gets or sets the TaskActionID value.
		/// </summary>
		public int TaskActionID
		{
			get { return taskActionID; }
			set { taskActionID = value; }
		}

		/// <summary>
		/// Gets or sets the PaymentMode value.
		/// </summary>
		public string PaymentMode
		{
			get { return paymentMode; }
			set { paymentMode = value; }
		}

		/// <summary>
		/// Gets or sets the VisitType value.
		/// </summary>
		public string VisitType
		{
			get { return visitType; }
			set { visitType = value; }
		}

		/// <summary>
		/// Gets or sets the VisitPurposeIDandPaymentMode value.
		/// </summary>
		string _visitpurposeidandpaymentmode;
		public string VisitPurposeIDandPaymentMode
		{
			get { return _visitpurposeidandpaymentmode; }
			set { _visitpurposeidandpaymentmode = value; }
		}

		/// <summary>
		/// Gets or sets the OrgAddressID value.
		/// </summary>
		long _orgaddressid;
		public long OrgAddressID
		{
			get { return _orgaddressid; }
			set { _orgaddressid = value; }
		}


		#endregion
}
}
