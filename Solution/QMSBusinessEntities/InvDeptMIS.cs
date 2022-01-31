using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class InvDeptMIS
	{
		#region Fields

		private int orgID=0;
		private long visitID=0;
		private int aORGID=0;
		private int aCRPID=0;
		private string aTYPE=String.Empty;
		private int deptid=0;
		private string deptName=String.Empty;
		private decimal mRP=Decimal.Zero;
		private decimal pRFDISC=Decimal.Zero;
		private decimal mRPLESSPR=Decimal.Zero;
		private decimal dISCB2B=Decimal.Zero;
		private decimal dISCB2C=Decimal.Zero;
		private decimal nET=Decimal.Zero;
		private int wL=0;
		private string testName=String.Empty;
		private string tCODE=String.Empty;
		private int proOrgAddressID=0;
		private int ordOrgAddressID=0;
		private int clientID=0;
		private string isReflex=String.Empty;
		private int noOfRuns=0;
		private int feeID=0;
		private string feeType=String.Empty;
		private decimal ordMRP=Decimal.Zero;
		private decimal ordNet=Decimal.Zero;
		private long billingDetailID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
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
		/// Gets or sets the AORGID value.
		/// </summary>
		public int AORGID
		{
			get { return aORGID; }
			set { aORGID = value; }
		}

		/// <summary>
		/// Gets or sets the ACRPID value.
		/// </summary>
		public int ACRPID
		{
			get { return aCRPID; }
			set { aCRPID = value; }
		}

		/// <summary>
		/// Gets or sets the ATYPE value.
		/// </summary>
		public string ATYPE
		{
			get { return aTYPE; }
			set { aTYPE = value; }
		}

		/// <summary>
		/// Gets or sets the Deptid value.
		/// </summary>
		public int Deptid
		{
			get { return deptid; }
			set { deptid = value; }
		}

		/// <summary>
		/// Gets or sets the DeptName value.
		/// </summary>
		public string DeptName
		{
			get { return deptName; }
			set { deptName = value; }
		}

		/// <summary>
		/// Gets or sets the MRP value.
		/// </summary>
		public decimal MRP
		{
			get { return mRP; }
			set { mRP = value; }
		}

		/// <summary>
		/// Gets or sets the PRFDISC value.
		/// </summary>
		public decimal PRFDISC
		{
			get { return pRFDISC; }
			set { pRFDISC = value; }
		}

		/// <summary>
		/// Gets or sets the MRPLESSPR value.
		/// </summary>
		public decimal MRPLESSPR
		{
			get { return mRPLESSPR; }
			set { mRPLESSPR = value; }
		}

		/// <summary>
		/// Gets or sets the DISCB2B value.
		/// </summary>
		public decimal DISCB2B
		{
			get { return dISCB2B; }
			set { dISCB2B = value; }
		}

		/// <summary>
		/// Gets or sets the DISCB2C value.
		/// </summary>
		public decimal DISCB2C
		{
			get { return dISCB2C; }
			set { dISCB2C = value; }
		}

		/// <summary>
		/// Gets or sets the NET value.
		/// </summary>
		public decimal NET
		{
			get { return nET; }
			set { nET = value; }
		}

		/// <summary>
		/// Gets or sets the WL value.
		/// </summary>
		public int WL
		{
			get { return wL; }
			set { wL = value; }
		}

		/// <summary>
		/// Gets or sets the TestName value.
		/// </summary>
		public string TestName
		{
			get { return testName; }
			set { testName = value; }
		}

		/// <summary>
		/// Gets or sets the TCODE value.
		/// </summary>
		public string TCODE
		{
			get { return tCODE; }
			set { tCODE = value; }
		}

		/// <summary>
		/// Gets or sets the ProOrgAddressID value.
		/// </summary>
		public int ProOrgAddressID
		{
			get { return proOrgAddressID; }
			set { proOrgAddressID = value; }
		}

		/// <summary>
		/// Gets or sets the OrdOrgAddressID value.
		/// </summary>
		public int OrdOrgAddressID
		{
			get { return ordOrgAddressID; }
			set { ordOrgAddressID = value; }
		}

		/// <summary>
		/// Gets or sets the ClientID value.
		/// </summary>
		public int ClientID
		{
			get { return clientID; }
			set { clientID = value; }
		}

		/// <summary>
		/// Gets or sets the IsReflex value.
		/// </summary>
		public string IsReflex
		{
			get { return isReflex; }
			set { isReflex = value; }
		}

		/// <summary>
		/// Gets or sets the NoOfRuns value.
		/// </summary>
		public int NoOfRuns
		{
			get { return noOfRuns; }
			set { noOfRuns = value; }
		}

		/// <summary>
		/// Gets or sets the FeeID value.
		/// </summary>
		public int FeeID
		{
			get { return feeID; }
			set { feeID = value; }
		}

		/// <summary>
		/// Gets or sets the FeeType value.
		/// </summary>
		public string FeeType
		{
			get { return feeType; }
			set { feeType = value; }
		}

		/// <summary>
		/// Gets or sets the OrdMRP value.
		/// </summary>
		public decimal OrdMRP
		{
			get { return ordMRP; }
			set { ordMRP = value; }
		}

		/// <summary>
		/// Gets or sets the OrdNet value.
		/// </summary>
		public decimal OrdNet
		{
			get { return ordNet; }
			set { ordNet = value; }
		}

		/// <summary>
		/// Gets or sets the BillingDetailID value.
		/// </summary>
		public long BillingDetailID
		{
			get { return billingDetailID; }
			set { billingDetailID = value; }
		}


		#endregion
}
}
