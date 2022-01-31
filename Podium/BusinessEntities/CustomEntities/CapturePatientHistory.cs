using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class CapturePatientHistory
    {

        #region Fields


        private long patientVisitID = 0;
        private long investigationID = 0;
        private long historyID = 0;
        private string historyName = String.Empty;

        private string hasAttribute = String.Empty;
        private long attributeID = 0;
        private string attributeName = String.Empty;
        private long attributevalueID = 0;
        private string attributeValueName = String.Empty;
        private string type = String.Empty;
        private string familyhistory = String.Empty;
        private string strandcaseid = String.Empty;
        private string keyfinding = String.Empty;
        private string description = String.Empty;
        private string assinee = String.Empty;
        private string referral = String.Empty;
        private string ethinicity = String.Empty;
        private string paneltype = String.Empty;
        private string cancer = String.Empty;
        private int _InvID = 0;
        private long _PatientHistoryAttributeID=0;
        private long _SeqID=0;
      
        private string _ActionType = string.Empty;

        #endregion

        #region Properties


        public string ActionType
        {
            get { return _ActionType; }
            set { _ActionType = value; }
        }


      
        public long SeqID
        {
            get { return _SeqID; }
            set { _SeqID = value; }
        }

        public long PatientHistoryAttributeID
        {
            get { return _PatientHistoryAttributeID; }
            set { _PatientHistoryAttributeID = value; }
        }

        public int InvID
        {
            get { return _InvID; }
            set { _InvID = value; }
        }

        public long PatientVisitID
        {
            get { return patientVisitID; }
            set { patientVisitID = value; }
        }

        /// <summary>
        /// Gets or sets the InvestigationID value.
        /// </summary>
        public long InvestigationID
        {
            get { return investigationID; }
            set { investigationID = value; }
        }

        /// <summary>
        /// Gets or sets the HistoryID value.
        /// </summary>
        public long HistoryID
        {
            get { return historyID; }
            set { historyID = value; }
        }


        /// <summary>
        /// Gets or sets the HistoryName value.
        /// </summary>

        public string HistoryName
        {
            get { return historyName; }
            set { historyName = value; }
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
        /// Gets or sets the HasAttribute value.
        /// </summary>

        public string HasAttribute
        {
            get { return hasAttribute; }
            set { hasAttribute = value; }
        }




        /// <summary>
        /// Gets or sets the AttributeID value.
        /// </summary>
        public long AttributeID
        {
            get { return attributeID; }
            set { attributeID = value; }
        }


        /// <summary>
        /// Gets or sets the AttributeName value.
        /// </summary>

        public string AttributeName
        {
            get { return attributeName; }
            set { attributeName = value; }
        }

        /// <summary>
        /// Gets or sets the AttributevalueID value.
        /// </summary>
        public long AttributevalueID
        {
            get { return attributevalueID; }
            set { attributevalueID = value; }
        }

        /// <summary>
        /// Gets or sets the AttributeValueName value.
        /// </summary>
        public string AttributeValueName
        {
            get { return attributeValueName; }
            set { attributeValueName = value; }
        }

        /// <summary>
        /// Gets or sets the Description value.
        /// </summary>
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string Assinee
        {
            get { return assinee; }
            set { assinee = value; }
        }

        public string Referral
        {
            get { return referral; }
            set { referral = value; }
        }
        public string Ethinicity
        {
            get { return ethinicity; }
            set { ethinicity = value; }
        }

        public string Paneltype
        {
            get { return paneltype; }
            set { paneltype = value; }
        }
        public string Cancer
        {
            get { return cancer; }
            set { cancer = value; }
        }

        public string Familyhistory
        {
            get { return familyhistory; }
            set { familyhistory = value; }
        }
        public string Strandcaseid
        {
            get { return strandcaseid; }
            set { strandcaseid = value; }
        }
        public string Keyfinding
        {
            get { return keyfinding; }
            set { keyfinding = value; }
        }


        #endregion
    }
}
