using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class InternalExternalQuality
	{
		#region Fields

		private long investigationID=0;
		private string analyteName=String.Empty;
		private string resultValue=String.Empty;
		private string internalResultValue=String.Empty;
		private string externalResultValue=String.Empty;
		private string score=String.Empty;
		private string status=String.Empty;
		private string rootCause=String.Empty;
		private decimal correction=Decimal.Zero;
		private string correctiveActions=String.Empty;
		private string preventiveActions=String.Empty;
		private decimal deviation=Decimal.Zero;
		private long eQMID=0;
        private long Id = 0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the InvestigationID value.
		/// </summary>
		public long InvestigationID
		{
			get { return investigationID; }
			set { investigationID = value; }
		}

		/// <summary>
		/// Gets or sets the AnalyteName value.
		/// </summary>
		public string AnalyteName
		{
			get { return analyteName; }
			set { analyteName = value; }
		}

		/// <summary>
		/// Gets or sets the ResultValue value.
		/// </summary>
		public string ResultValue
		{
			get { return resultValue; }
			set { resultValue = value; }
		}

		/// <summary>
		/// Gets or sets the InternalResultValue value.
		/// </summary>
		public string InternalResultValue
		{
			get { return internalResultValue; }
			set { internalResultValue = value; }
		}

		/// <summary>
		/// Gets or sets the ExternalResultValue value.
		/// </summary>
		public string ExternalResultValue
		{
			get { return externalResultValue; }
			set { externalResultValue = value; }
		}

		/// <summary>
		/// Gets or sets the Score value.
		/// </summary>
		public string Score
		{
			get { return score; }
			set { score = value; }
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
		public decimal Correction
		{
			get { return correction; }
			set { correction = value; }
		}

		/// <summary>
		/// Gets or sets the CorrectiveActions value.
		/// </summary>
		public string CorrectiveActions
		{
			get { return correctiveActions; }
			set { correctiveActions = value; }
		}

		/// <summary>
		/// Gets or sets the PreventiveActions value.
		/// </summary>
		public string PreventiveActions
		{
			get { return preventiveActions; }
			set { preventiveActions = value; }
		}

		/// <summary>
		/// Gets or sets the Deviation value.
		/// </summary>
		public decimal Deviation
		{
			get { return deviation; }
			set { deviation = value; }
		}

		/// <summary>
		/// Gets or sets the EQMID value.
		/// </summary>
		public long EQMID
		{
			get { return eQMID; }
			set { eQMID = value; }
		}

        /// <summary>
        /// Gets or sets the ID value.
        /// </summary>
        public long ID
        {
            get { return Id; }
            set { Id = value; }
        }

		#endregion
}
}
