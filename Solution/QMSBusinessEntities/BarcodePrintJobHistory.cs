using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class BarcodePrintJobHistory
	{
		#region Fields

		private long iD=0;
		private long visitID=0;
		private int orgID=0;
		private long orgAddressID=0;
		private int sampleID=0;
		private string machineID=String.Empty;
		private string status=String.Empty;
		private long created_By=0;
		private DateTime created_At=DateTime.MaxValue;
		private long modified_By=0;
		private DateTime modified_At=DateTime.MaxValue;
		private string barcodeNumber=String.Empty;
		private string headerLine1=String.Empty;
		private string headerLine2=String.Empty;
		private string footerLine1=String.Empty;
		private string footerLine2=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public long ID
		{
			get { return iD; }
			set { iD = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgAddressID value.
		/// </summary>
		public long OrgAddressID
		{
			get { return orgAddressID; }
			set { orgAddressID = value; }
		}

		/// <summary>
		/// Gets or sets the SampleID value.
		/// </summary>
		public int SampleID
		{
			get { return sampleID; }
			set { sampleID = value; }
		}

		/// <summary>
		/// Gets or sets the MachineID value.
		/// </summary>
		public string MachineID
		{
			get { return machineID; }
			set { machineID = value; }
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
		/// Gets or sets the Created_By value.
		/// </summary>
		public long Created_By
		{
			get { return created_By; }
			set { created_By = value; }
		}

		/// <summary>
		/// Gets or sets the Created_At value.
		/// </summary>
		public DateTime Created_At
		{
			get { return created_At; }
			set { created_At = value; }
		}

		/// <summary>
		/// Gets or sets the Modified_By value.
		/// </summary>
		public long Modified_By
		{
			get { return modified_By; }
			set { modified_By = value; }
		}

		/// <summary>
		/// Gets or sets the Modified_At value.
		/// </summary>
		public DateTime Modified_At
		{
			get { return modified_At; }
			set { modified_At = value; }
		}

		/// <summary>
		/// Gets or sets the BarcodeNumber value.
		/// </summary>
		public string BarcodeNumber
		{
			get { return barcodeNumber; }
			set { barcodeNumber = value; }
		}

		/// <summary>
		/// Gets or sets the HeaderLine1 value.
		/// </summary>
		public string HeaderLine1
		{
			get { return headerLine1; }
			set { headerLine1 = value; }
		}

		/// <summary>
		/// Gets or sets the HeaderLine2 value.
		/// </summary>
		public string HeaderLine2
		{
			get { return headerLine2; }
			set { headerLine2 = value; }
		}

		/// <summary>
		/// Gets or sets the FooterLine1 value.
		/// </summary>
		public string FooterLine1
		{
			get { return footerLine1; }
			set { footerLine1 = value; }
		}

		/// <summary>
		/// Gets or sets the FooterLine2 value.
		/// </summary>
		public string FooterLine2
		{
			get { return footerLine2; }
			set { footerLine2 = value; }
		}


		#endregion
}
}
