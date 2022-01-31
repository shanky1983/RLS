using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class VisitConsultationDetails
	{
		#region Fields

		private long visitConsID=0;
		private long visitID=0;
		private int specialityID=0;
		private long physicianFeeID=0;
		private long finalBillID=0;
		private long physicianID=0;
		private long performingPhysicianID=0;
		private string type=String.Empty;
		private string status=String.Empty;
		private long orderTaskID=0;
		private DateTime createdat=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private long patientVisitAttribID=0;
		private DateTime actual_review_date=DateTime.MaxValue;
		private string visitState=String.Empty;
		private int visitPurposeID=0;
		private int tokenNumber=0;
		private string priority=String.Empty;
		private string processedStatus=String.Empty;
		private string admissionSuggested=String.Empty;
		private int bookingID=0;
		private string nxtReviewDate=String.Empty;
		private long parentVisitConsID=0;
		private DateTime actual_ReviewReport_Date=DateTime.MaxValue;
		private string nxtReviewReportDate=String.Empty;
		private string physicianName=String.Empty;
		private string performingPhysicianName=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the VisitConsID value.
		/// </summary>
		public long VisitConsID
		{
			get { return visitConsID; }
			set { visitConsID = value; }
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
		/// Gets or sets the SpecialityID value.
		/// </summary>
		public int SpecialityID
		{
			get { return specialityID; }
			set { specialityID = value; }
		}

		/// <summary>
		/// Gets or sets the PhysicianFeeID value.
		/// </summary>
		public long PhysicianFeeID
		{
			get { return physicianFeeID; }
			set { physicianFeeID = value; }
		}

		/// <summary>
		/// Gets or sets the FinalBillID value.
		/// </summary>
		public long FinalBillID
		{
			get { return finalBillID; }
			set { finalBillID = value; }
		}

		/// <summary>
		/// Gets or sets the PhysicianID value.
		/// </summary>
		public long PhysicianID
		{
			get { return physicianID; }
			set { physicianID = value; }
		}

		/// <summary>
		/// Gets or sets the PerformingPhysicianID value.
		/// </summary>
		public long PerformingPhysicianID
		{
			get { return performingPhysicianID; }
			set { performingPhysicianID = value; }
		}

		/// <summary>
		/// Gets or sets the Type value.
		/// </summary>
		public string Type
		{
			get { return type; }
			set { type = value; }
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
		/// Gets or sets the OrderTaskID value.
		/// </summary>
		public long OrderTaskID
		{
			get { return orderTaskID; }
			set { orderTaskID = value; }
		}

		/// <summary>
		/// Gets or sets the Createdat value.
		/// </summary>
		public DateTime Createdat
		{
			get { return createdat; }
			set { createdat = value; }
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
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
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
		/// Gets or sets the PatientVisitAttribID value.
		/// </summary>
		public long PatientVisitAttribID
		{
			get { return patientVisitAttribID; }
			set { patientVisitAttribID = value; }
		}

		/// <summary>
		/// Gets or sets the Actual_review_date value.
		/// </summary>
		public DateTime Actual_review_date
		{
			get { return actual_review_date; }
			set { actual_review_date = value; }
		}

		/// <summary>
		/// Gets or sets the VisitState value.
		/// </summary>
		public string VisitState
		{
			get { return visitState; }
			set { visitState = value; }
		}

		/// <summary>
		/// Gets or sets the VisitPurposeID value.
		/// </summary>
		public int VisitPurposeID
		{
			get { return visitPurposeID; }
			set { visitPurposeID = value; }
		}

		/// <summary>
		/// Gets or sets the TokenNumber value.
		/// </summary>
		public int TokenNumber
		{
			get { return tokenNumber; }
			set { tokenNumber = value; }
		}

		/// <summary>
		/// Gets or sets the Priority value.
		/// </summary>
		public string Priority
		{
			get { return priority; }
			set { priority = value; }
		}

		/// <summary>
		/// Gets or sets the ProcessedStatus value.
		/// </summary>
		public string ProcessedStatus
		{
			get { return processedStatus; }
			set { processedStatus = value; }
		}

		/// <summary>
		/// Gets or sets the AdmissionSuggested value.
		/// </summary>
		public string AdmissionSuggested
		{
			get { return admissionSuggested; }
			set { admissionSuggested = value; }
		}

		/// <summary>
		/// Gets or sets the BookingID value.
		/// </summary>
		public int BookingID
		{
			get { return bookingID; }
			set { bookingID = value; }
		}

		/// <summary>
		/// Gets or sets the NxtReviewDate value.
		/// </summary>
		public string NxtReviewDate
		{
			get { return nxtReviewDate; }
			set { nxtReviewDate = value; }
		}

		/// <summary>
		/// Gets or sets the ParentVisitConsID value.
		/// </summary>
		public long ParentVisitConsID
		{
			get { return parentVisitConsID; }
			set { parentVisitConsID = value; }
		}

		/// <summary>
		/// Gets or sets the Actual_ReviewReport_Date value.
		/// </summary>
		public DateTime Actual_ReviewReport_Date
		{
			get { return actual_ReviewReport_Date; }
			set { actual_ReviewReport_Date = value; }
		}

		/// <summary>
		/// Gets or sets the NxtReviewReportDate value.
		/// </summary>
		public string NxtReviewReportDate
		{
			get { return nxtReviewReportDate; }
			set { nxtReviewReportDate = value; }
		}

		/// <summary>
		/// Gets or sets the PhysicianName value.
		/// </summary>
		public string PhysicianName
		{
			get { return physicianName; }
			set { physicianName = value; }
		}

		/// <summary>
		/// Gets or sets the PerformingPhysicianName value.
		/// </summary>
		public string PerformingPhysicianName
		{
			get { return performingPhysicianName; }
			set { performingPhysicianName = value; }
		}


		#endregion
}
}
