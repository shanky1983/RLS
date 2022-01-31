using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class BarcodePrintJob
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
		private string sequenceno=String.Empty;
		private string rightHeaderLine1=String.Empty;
		private string rightHeaderLine2=String.Empty;
		private string rightHeaderLine3=String.Empty;
		private string rightHeaderLine4=String.Empty;
		private string rightHeaderLine5=String.Empty;
		private string rightHeaderLine6=String.Empty;
		private string rightHeaderLine7=String.Empty;
		private string printerName=String.Empty;

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

		/// <summary>
		/// Gets or sets the Sequenceno value.
		/// </summary>
		public string Sequenceno
		{
			get { return sequenceno; }
			set { sequenceno = value; }
		}

		/// <summary>
		/// Gets or sets the RightHeaderLine1 value.
		/// </summary>
		public string RightHeaderLine1
		{
			get { return rightHeaderLine1; }
			set { rightHeaderLine1 = value; }
		}

		/// <summary>
		/// Gets or sets the RightHeaderLine2 value.
		/// </summary>
		public string RightHeaderLine2
		{
			get { return rightHeaderLine2; }
			set { rightHeaderLine2 = value; }
		}

		/// <summary>
		/// Gets or sets the RightHeaderLine3 value.
		/// </summary>
		public string RightHeaderLine3
		{
			get { return rightHeaderLine3; }
			set { rightHeaderLine3 = value; }
		}

		/// <summary>
		/// Gets or sets the RightHeaderLine4 value.
		/// </summary>
		public string RightHeaderLine4
		{
			get { return rightHeaderLine4; }
			set { rightHeaderLine4 = value; }
		}

		/// <summary>
		/// Gets or sets the RightHeaderLine5 value.
		/// </summary>
		public string RightHeaderLine5
		{
			get { return rightHeaderLine5; }
			set { rightHeaderLine5 = value; }
		}

		/// <summary>
		/// Gets or sets the RightHeaderLine6 value.
		/// </summary>
		public string RightHeaderLine6
		{
			get { return rightHeaderLine6; }
			set { rightHeaderLine6 = value; }
		}

		/// <summary>
		/// Gets or sets the RightHeaderLine7 value.
		/// </summary>
		public string RightHeaderLine7
		{
			get { return rightHeaderLine7; }
			set { rightHeaderLine7 = value; }
		}

		/// <summary>
		/// Gets or sets the PrinterName value.
		/// </summary>
		public string PrinterName
		{
			get { return printerName; }
			set { printerName = value; }
		}

		/// <summary>
		/// Gets or sets the UID value.
		/// </summary>
		private string _uID=String.Empty;
		public string UID
		{
			get { return  _uID; }
			set { _uID = value; }
		}

		/// <summary>
		/// Gets or sets the MachineName value.
		/// </summary>
		private string _machineName=String.Empty;
		public string MachineName
		{
			get { return  _machineName; }
			set { _machineName = value; }
		}


		#endregion
}
}
