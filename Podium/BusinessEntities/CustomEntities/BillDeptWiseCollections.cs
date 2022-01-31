using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class BillDeptWiseCollections
	{
		#region Fields

		private long finalBillID=0;
		private long billNumber=0;
		private string patientName=String.Empty;
		private string age=String.Empty;
        private DateTime visitDate = DateTime.MaxValue;
		private string visitType=String.Empty;
		private decimal consultation=Decimal.Zero;
		private decimal xRay=Decimal.Zero;
		private decimal lab=Decimal.Zero;
		private decimal pharmacy=Decimal.Zero;
		private decimal physiotherapy=Decimal.Zero;
		private decimal dialysis=Decimal.Zero;
		private decimal uSG=Decimal.Zero;
		private decimal cT=Decimal.Zero;
		private decimal tMT=Decimal.Zero;
		private decimal endoscopy=Decimal.Zero;
		private decimal others=Decimal.Zero;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the FinalBillID value.
		/// </summary>
		public long FinalBillID
		{
			get { return finalBillID; }
			set { finalBillID = value; }
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
		/// Gets or sets the PatientName value.
		/// </summary>
		public string PatientName
		{
			get { return patientName; }
			set { patientName = value; }
		}

		/// <summary>
		/// Gets or sets the Age value.
		/// </summary>
		public string Age
		{
			get { return age; }
			set { age = value; }
		}

		/// <summary>
		/// Gets or sets the VisitDate value.
		/// </summary>
		public DateTime VisitDate
		{
			get { return visitDate; }
			set { visitDate = value; }
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
		/// Gets or sets the Consultation value.
		/// </summary>
		public decimal Consultation
		{
			get { return consultation; }
			set { consultation = value; }
		}

		/// <summary>
		/// Gets or sets the XRay value.
		/// </summary>
		public decimal XRay
		{
			get { return xRay; }
			set { xRay = value; }
		}

		/// <summary>
		/// Gets or sets the Lab value.
		/// </summary>
		public decimal Lab
		{
			get { return lab; }
			set { lab = value; }
		}

		/// <summary>
		/// Gets or sets the Pharmacy value.
		/// </summary>
		public decimal Pharmacy
		{
			get { return pharmacy; }
			set { pharmacy = value; }
		}

		/// <summary>
		/// Gets or sets the Physiotherapy value.
		/// </summary>
		public decimal Physiotherapy
		{
			get { return physiotherapy; }
			set { physiotherapy = value; }
		}

		/// <summary>
		/// Gets or sets the Dialysis value.
		/// </summary>
		public decimal Dialysis
		{
			get { return dialysis; }
			set { dialysis = value; }
		}

		/// <summary>
		/// Gets or sets the USG value.
		/// </summary>
		public decimal USG
		{
			get { return uSG; }
			set { uSG = value; }
		}

		/// <summary>
		/// Gets or sets the CT value.
		/// </summary>
		public decimal CT
		{
			get { return cT; }
			set { cT = value; }
		}

		/// <summary>
		/// Gets or sets the TMT value.
		/// </summary>
		public decimal TMT
		{
			get { return tMT; }
			set { tMT = value; }
		}

		/// <summary>
		/// Gets or sets the Endoscopy value.
		/// </summary>
		public decimal Endoscopy
		{
			get { return endoscopy; }
			set { endoscopy = value; }
		}

		/// <summary>
		/// Gets or sets the Others value.
		/// </summary>
		public decimal Others
		{
			get { return others; }
			set { others = value; }
		}


		#endregion
}
}
