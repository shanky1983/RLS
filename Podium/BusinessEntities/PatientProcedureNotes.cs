using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PatientProcedureNotes
	{
		#region Fields

		private long detailsID=0;
		private long visitID=0;
		private long patientID=0;
		private long identifyID=0;
		private DateTime procedureDate=DateTime.MaxValue;
		private string status=String.Empty;
		private int createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private int modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string identifyType=String.Empty;
		private long visitConsID=0;
		private long orderServiceNo=0;
		private long templateID=0;
		private string templateName=String.Empty;
		private string templateValue=String.Empty;
		private string orderedRequestType=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DetailsID value.
		/// </summary>
		public long DetailsID
		{
			get { return detailsID; }
			set { detailsID = value; }
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
		/// Gets or sets the PatientID value.
		/// </summary>
		public long PatientID
		{
			get { return patientID; }
			set { patientID = value; }
		}

		/// <summary>
		/// Gets or sets the IdentifyID value.
		/// </summary>
		public long IdentifyID
		{
			get { return identifyID; }
			set { identifyID = value; }
		}

		/// <summary>
		/// Gets or sets the ProcedureDate value.
		/// </summary>
		public DateTime ProcedureDate
		{
			get { return procedureDate; }
			set { procedureDate = value; }
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
		public int CreatedBy
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
		public int ModifiedBy
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
		/// Gets or sets the IdentifyType value.
		/// </summary>
		public string IdentifyType
		{
			get { return identifyType; }
			set { identifyType = value; }
		}

		/// <summary>
		/// Gets or sets the VisitConsID value.
		/// </summary>
		public long VisitConsID
		{
			get { return visitConsID; }
			set { visitConsID = value; }
		}

		/// <summary>
		/// Gets or sets the OrderServiceNo value.
		/// </summary>
		public long OrderServiceNo
		{
			get { return orderServiceNo; }
			set { orderServiceNo = value; }
		}

		/// <summary>
		/// Gets or sets the TemplateID value.
		/// </summary>
		public long TemplateID
		{
			get { return templateID; }
			set { templateID = value; }
		}

		/// <summary>
		/// Gets or sets the TemplateName value.
		/// </summary>
		public string TemplateName
		{
			get { return templateName; }
			set { templateName = value; }
		}

		/// <summary>
		/// Gets or sets the TemplateValue value.
		/// </summary>
		public string TemplateValue
		{
			get { return templateValue; }
			set { templateValue = value; }
		}

		/// <summary>
		/// Gets or sets the OrderedRequestType value.
		/// </summary>
		public string OrderedRequestType
		{
			get { return orderedRequestType; }
			set { orderedRequestType = value; }
		}


		#endregion
}
}
