using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class IDMaster
	{
		#region Fields

		private long orgID=0;
		private long patientNumber=0;
		private long billNumber=0;
		private long iPNumber=0;
		private long visitNumber=0;
		private long refundNumber=0;
		private long receiptNO=0;
		private long voucherNO=0;
		private long refundVoucherNo=0;
		private long interimBillNo=0;
		private long urnID=0;
		private long coPayNo=0;
		private long closureID=0;
		private long labNo=0;
		private long prescriptionNumber=0;
		private string orderServiceNumber=String.Empty;
		private long orderRefundNo=0;
		private long barcode=0;
		private long employeeNumber=0;
		private long externalNumber=0;
		private string consignmentNo=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public long OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientNumber value.
		/// </summary>
		public long PatientNumber
		{
			get { return patientNumber; }
			set { patientNumber = value; }
		}

		/// <summary>
		/// Gets or sets the BillNumber value.
		/// </summary>
		public long BillNumber
		{
			get { return billNumber; }
			set { billNumber = value; }
		}

		/// <summary>
		/// Gets or sets the IPNumber value.
		/// </summary>
		public long IPNumber
		{
			get { return iPNumber; }
			set { iPNumber = value; }
		}

		/// <summary>
		/// Gets or sets the VisitNumber value.
		/// </summary>
		public long VisitNumber
		{
			get { return visitNumber; }
			set { visitNumber = value; }
		}

		/// <summary>
		/// Gets or sets the RefundNumber value.
		/// </summary>
		public long RefundNumber
		{
			get { return refundNumber; }
			set { refundNumber = value; }
		}

		/// <summary>
		/// Gets or sets the ReceiptNO value.
		/// </summary>
		public long ReceiptNO
		{
			get { return receiptNO; }
			set { receiptNO = value; }
		}

		/// <summary>
		/// Gets or sets the VoucherNO value.
		/// </summary>
		public long VoucherNO
		{
			get { return voucherNO; }
			set { voucherNO = value; }
		}

		/// <summary>
		/// Gets or sets the RefundVoucherNo value.
		/// </summary>
		public long RefundVoucherNo
		{
			get { return refundVoucherNo; }
			set { refundVoucherNo = value; }
		}

		/// <summary>
		/// Gets or sets the InterimBillNo value.
		/// </summary>
		public long InterimBillNo
		{
			get { return interimBillNo; }
			set { interimBillNo = value; }
		}

		/// <summary>
		/// Gets or sets the UrnID value.
		/// </summary>
		public long UrnID
		{
			get { return urnID; }
			set { urnID = value; }
		}

		/// <summary>
		/// Gets or sets the CoPayNo value.
		/// </summary>
		public long CoPayNo
		{
			get { return coPayNo; }
			set { coPayNo = value; }
		}

		/// <summary>
		/// Gets or sets the ClosureID value.
		/// </summary>
		public long ClosureID
		{
			get { return closureID; }
			set { closureID = value; }
		}

		/// <summary>
		/// Gets or sets the LabNo value.
		/// </summary>
		public long LabNo
		{
			get { return labNo; }
			set { labNo = value; }
		}

		/// <summary>
		/// Gets or sets the PrescriptionNumber value.
		/// </summary>
		public long PrescriptionNumber
		{
			get { return prescriptionNumber; }
			set { prescriptionNumber = value; }
		}

		/// <summary>
		/// Gets or sets the OrderServiceNumber value.
		/// </summary>
		public string OrderServiceNumber
		{
			get { return orderServiceNumber; }
			set { orderServiceNumber = value; }
		}

		/// <summary>
		/// Gets or sets the OrderRefundNo value.
		/// </summary>
		public long OrderRefundNo
		{
			get { return orderRefundNo; }
			set { orderRefundNo = value; }
		}

		/// <summary>
		/// Gets or sets the Barcode value.
		/// </summary>
		public long Barcode
		{
			get { return barcode; }
			set { barcode = value; }
		}

		/// <summary>
		/// Gets or sets the EmployeeNumber value.
		/// </summary>
		public long EmployeeNumber
		{
			get { return employeeNumber; }
			set { employeeNumber = value; }
		}

		/// <summary>
		/// Gets or sets the ExternalNumber value.
		/// </summary>
		public long ExternalNumber
		{
			get { return externalNumber; }
			set { externalNumber = value; }
		}

		/// <summary>
		/// Gets or sets the ConsignmentNo value.
		/// </summary>
		public string ConsignmentNo
		{
			get { return consignmentNo; }
			set { consignmentNo = value; }
		}


		#endregion
}
}
