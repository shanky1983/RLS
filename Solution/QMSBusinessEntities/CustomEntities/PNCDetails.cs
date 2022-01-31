using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities.CustomEntities
{
	public class PNCDetails
	{
		#region Fields

		private long conformanceID=0;
		private string processNonConfNo=String.Empty;
		private long deptID=0;
        private string deptName = string.Empty;
		private DateTime processDate=DateTime.MaxValue;
        private string pDate = string.Empty;
        private string pCompDate = string.Empty;      
		private string description=String.Empty;
		private long responsiblePerson=0;
        private string repPersonName = String.Empty;
        private string createdBy = String.Empty;
		private string nCClassification=String.Empty;
		private string rootCause=String.Empty;
		private string correction=String.Empty;
		private string correctiveaction=String.Empty;
		private string preventiveAction=String.Empty;
		private DateTime proposedCompletionDate=DateTime.MaxValue;
		private string actionTaken=String.Empty;
		private string comments=String.Empty;
        private string status = string.Empty;
        

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ConformanceID value.
		/// </summary>
		public long ConformanceID
		{
			get { return conformanceID; }
			set { conformanceID = value; }
		}

		/// <summary>
		/// Gets or sets the ProcessNonConfNo value.
		/// </summary>
		public string ProcessNonConfNo
		{
			get { return processNonConfNo; }
			set { processNonConfNo = value; }
		}

        public string Pdate
        {
            get { return pDate; }
            set { pDate = value; }
        }
        public string PCompDate
        {
            get { return pCompDate; }
            set { pCompDate = value; }
        }

        public string DeptName
		{
			get { return deptName; }
			set { deptName = value; }
		}

        
		/// <summary>
		/// Gets or sets the DeptID value.
		/// </summary>
		public long DeptID
		{
			get { return deptID; }
			set { deptID = value; }
		}

		/// <summary>
		/// Gets or sets the ProcessDate value.
		/// </summary>
		public DateTime ProcessDate
		{
			get { return processDate; }
			set { processDate = value; }
		}

		/// <summary>
		/// Gets or sets the Description value.
		/// </summary>
		public string Description
		{
			get { return description; }
			set { description = value; }
		}

		/// <summary>
		/// Gets or sets the ResponsiblePerson value.
		/// </summary>
		public long ResponsiblePerson
		{
			get { return responsiblePerson; }
			set { responsiblePerson = value; }
		}

		/// <summary>
		/// Gets or sets the NCClassification value.
		/// </summary>
		public string NCClassification
		{
			get { return nCClassification; }
			set { nCClassification = value; }
		}

        public string CreatedBy
		{
            get { return createdBy; }
            set { createdBy = value; }
		}

        

        public string RepPersonName
		{
            get { return repPersonName; }
            set { repPersonName = value; }
		}

        

		/// <summary>
		/// Gets or sets the RootCause value.
		/// </summary>
		public string RootCause
		{
			get { return rootCause; }
			set { rootCause = value; }
		}

		/// <summary>
		/// Gets or sets the Correction value.
		/// </summary>
		public string Correction
		{
			get { return correction; }
			set { correction = value; }
		}

		/// <summary>
		/// Gets or sets the Correctiveaction value.
		/// </summary>
		public string Correctiveaction
		{
			get { return correctiveaction; }
			set { correctiveaction = value; }
		}

		/// <summary>
		/// Gets or sets the PreventiveAction value.
		/// </summary>
		public string PreventiveAction
		{
			get { return preventiveAction; }
			set { preventiveAction = value; }
		}

		/// <summary>
		/// Gets or sets the ProposedCompletionDate value.
		/// </summary>
		public DateTime ProposedCompletionDate
		{
			get { return proposedCompletionDate; }
			set { proposedCompletionDate = value; }
		}

		/// <summary>
		/// Gets or sets the ActionTaken value.
		/// </summary>
		public string ActionTaken
		{
			get { return actionTaken; }
			set { actionTaken = value; }
		}

		/// <summary>
		/// Gets or sets the Comments value.
		/// </summary>
		public string Comments
		{
			get { return comments; }
			set { comments = value; }
		}

        public string Status
        {
            get { return status; }
            set { status = value; }
        }


		#endregion
}
}
