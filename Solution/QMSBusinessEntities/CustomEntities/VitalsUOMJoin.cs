using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class VitalsUOMJoin
    {
        #region Fields

		private int vitalsID;
		private string vitalsName;
   		private string uOMCode;
        private string vitalsGroup;
        private decimal vitalsValue;
        private string sessionType;
        public long PatientVisitID { get; set; }

        private long patientVitalsID = 0;

        private bool needMinMaxValidation =false;
        private int minimumValue = 0;
        private int maximumValue = 0;
        private bool isPrecisionAllowed = false;
        private string fieldValidation = string.Empty;
        private bool isMandatory = false;
		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the Vital class.
		/// </summary>
		public VitalsUOMJoin()
		{
		}

		#endregion

		#region Properties


        private DateTime _enterDate = System.DateTime.MinValue;
        public DateTime EnterDate
        {
            get { return _enterDate; }
            set { _enterDate = value; }
        }
		/// <summary>
		/// Gets or sets the VitalsID value.
		/// </summary>
		public int VitalsID
		{
			get { return vitalsID; }
			set { vitalsID = value; }
		}

		/// <summary>
		/// Gets or sets the VitalsName value.
		/// </summary>
		public string VitalsName
		{
			get { return vitalsName; }
			set { vitalsName = value; }
		}

        /// <summary>
        /// Gets or sets the GroupName value.
        /// </summary>
        public string VitalsGroup
        {
            get { return vitalsGroup; }
            set { vitalsGroup = value; }
        }

        /// <summary>
		/// Gets or sets the UOMCode value.
		/// </summary>
		public string UOMCode
		{
			get { return uOMCode; }
			set { uOMCode = value; }
		}

        /// <summary>
        /// Gets or sets the UOMCode value.
        /// </summary>
        public decimal VitalsValue
        {
            get { return vitalsValue; }
            set { vitalsValue = value; }
        }

        public string SessionType
        {
            get { return sessionType; }
            set { sessionType = value; }
        }

        /// <summary>
        /// Gets or sets the PatientVitalsID value.
        /// </summary>
        public long PatientVitalsID
        {
            get { return patientVitalsID; }
            set { patientVitalsID = value; }
        }
        public bool NeedMinMaxValidation
        {
            get { return needMinMaxValidation; }
            set { needMinMaxValidation = value; }
        }
        public int MinimumValue
        {
            get { return minimumValue; }
            set { minimumValue = value; }
        }
        public int MaximumValue
        {
            get { return maximumValue; }
            set { maximumValue = value; }
        }
        public bool IsPrecisionAllowed
        {
            get { return isPrecisionAllowed; }
            set { isPrecisionAllowed = value; }
        }
        public string FieldValidation
        {
            get { return fieldValidation; }
            set { fieldValidation = value; }
        }
        public bool IsMandatory
        {
            get { return isMandatory; }
            set { isMandatory = value; }
        }

        private string _VitalsDescription = string.Empty;
        public string VitalsDescription
        {
            get { return _VitalsDescription; }
            set { _VitalsDescription = value; }
        }

		#endregion
	}
}
