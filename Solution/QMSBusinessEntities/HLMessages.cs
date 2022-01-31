using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class HLMessages
	{
		#region Fields

		private int id=0;
		private string msgControlId=String.Empty;
		private string parentControlId=String.Empty;
		private int orgId=0;
		private string msgType=String.Empty;
		private string sending_App=String.Empty;
		private string sending_Facility=String.Empty;
		private string rec_App=String.Empty;
		private string rec_Facility=String.Empty;
		private DateTime transferDatetime=DateTime.MaxValue;
		private string msg_Content=String.Empty;
		private string status=String.Empty;
		private string errorList=String.Empty;
		private long patientVisitID=0;
		private string pdf_Generation=String.Empty;
		private DateTime pdf_Generation_Date=DateTime.MaxValue;
		private string roundBPdf_Generation=String.Empty;
		private DateTime roundBPdf_Generation_Date=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id value.
		/// </summary>
		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		/// <summary>
		/// Gets or sets the MsgControlId value.
		/// </summary>
		public string MsgControlId
		{
			get { return msgControlId; }
			set { msgControlId = value; }
		}

		/// <summary>
		/// Gets or sets the ParentControlId value.
		/// </summary>
		public string ParentControlId
		{
			get { return parentControlId; }
			set { parentControlId = value; }
		}

		/// <summary>
		/// Gets or sets the OrgId value.
		/// </summary>
		public int OrgId
		{
			get { return orgId; }
			set { orgId = value; }
		}

		/// <summary>
		/// Gets or sets the MsgType value.
		/// </summary>
		public string MsgType
		{
			get { return msgType; }
			set { msgType = value; }
		}

		/// <summary>
		/// Gets or sets the Sending_App value.
		/// </summary>
		public string Sending_App
		{
			get { return sending_App; }
			set { sending_App = value; }
		}

		/// <summary>
		/// Gets or sets the Sending_Facility value.
		/// </summary>
		public string Sending_Facility
		{
			get { return sending_Facility; }
			set { sending_Facility = value; }
		}

		/// <summary>
		/// Gets or sets the Rec_App value.
		/// </summary>
		public string Rec_App
		{
			get { return rec_App; }
			set { rec_App = value; }
		}

		/// <summary>
		/// Gets or sets the Rec_Facility value.
		/// </summary>
		public string Rec_Facility
		{
			get { return rec_Facility; }
			set { rec_Facility = value; }
		}

		/// <summary>
		/// Gets or sets the TransferDatetime value.
		/// </summary>
		public DateTime TransferDatetime
		{
			get { return transferDatetime; }
			set { transferDatetime = value; }
		}

		/// <summary>
		/// Gets or sets the Msg_Content value.
		/// </summary>
		public string Msg_Content
		{
			get { return msg_Content; }
			set { msg_Content = value; }
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
		/// Gets or sets the ErrorList value.
		/// </summary>
		public string ErrorList
		{
			get { return errorList; }
			set { errorList = value; }
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
		/// Gets or sets the Pdf_Generation value.
		/// </summary>
		public string Pdf_Generation
		{
			get { return pdf_Generation; }
			set { pdf_Generation = value; }
		}

		/// <summary>
		/// Gets or sets the Pdf_Generation_Date value.
		/// </summary>
		public DateTime Pdf_Generation_Date
		{
			get { return pdf_Generation_Date; }
			set { pdf_Generation_Date = value; }
		}

		/// <summary>
		/// Gets or sets the RoundBPdf_Generation value.
		/// </summary>
		public string RoundBPdf_Generation
		{
			get { return roundBPdf_Generation; }
			set { roundBPdf_Generation = value; }
		}

		/// <summary>
		/// Gets or sets the RoundBPdf_Generation_Date value.
		/// </summary>
		public DateTime RoundBPdf_Generation_Date
		{
			get { return roundBPdf_Generation_Date; }
			set { roundBPdf_Generation_Date = value; }
		}


		#endregion
}
}
