using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class InvInstrumentMaster
	{
		#region Fields

		private long productID=0;
		private string instrumentName=String.Empty;
		private int orgID=0;
		private string status=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=  DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
		private long modifiedBy=0;
        private DateTime modifiedAt = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
		private string qCData=String.Empty;
		private int instrumentType=0;
		private string productCode=String.Empty;
		private string model=String.Empty;
		private string manufacturer=String.Empty;
		private string method=String.Empty;
		private string principle=String.Empty;
		private string processingMode=String.Empty;
		private string sampleVolume=String.Empty;
		private string dataStorage=String.Empty;
		private string throughPut=String.Empty;
		private string direction=String.Empty;
		private int locationID=0;
		private string imagePath=String.Empty;
		private long instrumentID=0;
		private string department=String.Empty;
		private int deptID=0;
		private int processingSequence=0;
        private long methodid = 0;
        private long principleid = 0;
        private string installationdate = String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ProductID value.
		/// </summary>
		public long ProductID
		{
			get { return productID; }
			set { productID = value; }
		}

		/// <summary>
		/// Gets or sets the InstrumentName value.
		/// </summary>
		public string InstrumentName
		{
			get { return instrumentName; }
			set { instrumentName = value; }
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
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
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
		/// Gets or sets the QCData value.
		/// </summary>
		public string QCData
		{
			get { return qCData; }
			set { qCData = value; }
		}

		/// <summary>
		/// Gets or sets the InstrumentType value.
		/// </summary>
		public int InstrumentType
		{
			get { return instrumentType; }
			set { instrumentType = value; }
		}

		/// <summary>
		/// Gets or sets the ProductCode value.
		/// </summary>
		public string ProductCode
		{
			get { return productCode; }
			set { productCode = value; }
		}

		/// <summary>
		/// Gets or sets the Model value.
		/// </summary>
		public string Model
		{
			get { return model; }
			set { model = value; }
		}

		/// <summary>
		/// Gets or sets the Manufacturer value.
		/// </summary>
		public string Manufacturer
		{
			get { return manufacturer; }
			set { manufacturer = value; }
		}

		/// <summary>
		/// Gets or sets the Method value.
		/// </summary>
		public string Method
		{
			get { return method; }
			set { method = value; }
		}

		/// <summary>
		/// Gets or sets the Principle value.
		/// </summary>
		public string Principle
		{
			get { return principle; }
			set { principle = value; }
		}

		/// <summary>
		/// Gets or sets the ProcessingMode value.
		/// </summary>
		public string ProcessingMode
		{
			get { return processingMode; }
			set { processingMode = value; }
		}

		/// <summary>
		/// Gets or sets the SampleVolume value.
		/// </summary>
		public string SampleVolume
		{
			get { return sampleVolume; }
			set { sampleVolume = value; }
		}

		/// <summary>
		/// Gets or sets the DataStorage value.
		/// </summary>
		public string DataStorage
		{
			get { return dataStorage; }
			set { dataStorage = value; }
		}

		/// <summary>
		/// Gets or sets the ThroughPut value.
		/// </summary>
		public string ThroughPut
		{
			get { return throughPut; }
			set { throughPut = value; }
		}

		/// <summary>
		/// Gets or sets the Direction value.
		/// </summary>
		public string Direction
		{
			get { return direction; }
			set { direction = value; }
		}

		/// <summary>
		/// Gets or sets the LocationID value.
		/// </summary>
		public int LocationID
		{
			get { return locationID; }
			set { locationID = value; }
		}

		/// <summary>
		/// Gets or sets the ImagePath value.
		/// </summary>
		public string ImagePath
		{
			get { return imagePath; }
			set { imagePath = value; }
		}

		/// <summary>
		/// Gets or sets the InstrumentID value.
		/// </summary>
		public long InstrumentID
		{
			get { return instrumentID; }
			set { instrumentID = value; }
		}

		/// <summary>
		/// Gets or sets the Department value.
		/// </summary>
		public string Department
		{
			get { return department; }
			set { department = value; }
		}

		/// <summary>
		/// Gets or sets the DeptID value.
		/// </summary>
		public int DeptID
		{
			get { return deptID; }
			set { deptID = value; }
		}

		/// <summary>
		/// Gets or sets the ProcessingSequence value.
		/// </summary>
		public int ProcessingSequence
		{
			get { return processingSequence; }
			set { processingSequence = value; }
		}
        public long MethodID
        {
            get { return methodid; }
            set { methodid = value; }
        }
        public long PrincipleID
        {
            get { return principleid; }
            set { principleid = value; }
        }
        
        public string Installationdate
        {
            get { return installationdate; }
            set { installationdate = value; }
        }
		#endregion
}
}
