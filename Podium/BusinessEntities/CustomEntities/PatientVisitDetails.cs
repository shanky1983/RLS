using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class PatientVisitDetails
    {

        #region Fields

        private long patientVisitId = 0;
        private long patientVisitID = 0;
        private long patientID = 0;
        private string patientName = String.Empty;
        private string sex = string.Empty;
        private string address = string.Empty;
        private string city = string.Empty;
        private string state = string.Empty;
        private string country = string.Empty;
        private string mobileNumber = string.Empty;
        private DateTime visitDate = DateTime.MaxValue;
        private long orgID = 0;
        private int physicianID = 0;
        private string physicianName = string.Empty;
        private int complaintId = 0;
        private string complaintName = string.Empty;
        private string complaintDesc = string.Empty;
        private int conditionId = 0;
        private int visitType = 0;
        private long outVisitID = 0;
        private byte visitPurposeID = 0x00;
        private string visitNotes = String.Empty;
        private long createdBy = 0;
        private DateTime createdAt = DateTime.MaxValue;
        private long modifiedBy = 0;
        private DateTime modifiedAt = DateTime.MaxValue;
        private string visitState = String.Empty;
        private string nurseNotes = String.Empty;
        private string accompaniedBy = String.Empty;
        private string titleName = String.Empty;
        private string nextReviewDate = String.Empty;
        private string patientNumber = String.Empty;
        private long tokenNumber = 0;
        string patientVisitType = string.Empty;
        private string status = String.Empty;
        private int referingPhysicianID = 0;
        private long rateID = 0;
        private int clientID = 0;
        private string labno = string.Empty;
        private string patientStatus = string.Empty;
        private long emergencyPatientTrackerID = 0;
        private long emergencySeverityOrgMappingID = 0;
        private string visitnumber = String.Empty;
        private long deptID = 0;
        private string resultEntryType = String.Empty;
        private int titleCode = 0;
        private string reMobilenumber = string.Empty;
        private string reLandline = string.Empty;
        private int TATstatus = 0;
        private string address1 = string.Empty;
        private string address2 = string.Empty;
        private string externalPatientNumber = string.Empty;
        private int speciesID = 0;
        private string previousLabNumber = string.Empty;
        private bool isCumulative = false;
        private string reportMode = string.Empty;
        private string confidential = string.Empty;
        private string reportingCentername = string.Empty;
        #endregion
        private string externalVisitID = String.Empty;

        #region Properties
        /// <summary>
        /// Gets or sets the ExternalVisitID value.
        /// </summary>
        /// 

        public string ReMobilenumber
        {
            get { return reMobilenumber; }
            set { reMobilenumber = value; }
        }

        public string ReLandline
        {
            get { return reLandline; }
            set { reLandline = value; }
        }




        public int TitleCode
        {
            get { return titleCode; }
            set { titleCode = value; }
        }


        public string ExternalVisitID
        {
            get { return externalVisitID; }
            set { externalVisitID = value; }
        }
        public int ClientID
        {
            get { return clientID; }
            set { clientID = value; }
        }

        public long RateID
        {
            get { return rateID; }
            set { rateID = value; }
        }
        public string PatientNumber
        {
            get { return patientNumber; }
            set { patientNumber = value; }
        }

        public long TokenNumber
        {
            get { return tokenNumber; }
            set { tokenNumber = value; }
        }

        /// <summary>
        /// Gets or sets the PatientVisitId value.
        /// </summary>
        public long PatientVisitId
        {
            get { return patientVisitId; }
            set { patientVisitId = value; }
        }

        /// <summary>
        /// Gets or sets the PatientId value.
        /// </summary>
        public long PatientID
        {
            get { return patientID; }
            set { patientID = value; }
        }

        /// <summary>
        /// Gets or sets the VisitDate value.
        /// </summary>
        public DateTime VisitDate
        {
            get { return visitDate; }
            set { visitDate = value; }
        }

        /// <summary>
        /// Gets or sets the OrgID value.
        /// </summary>
        public long OrgID
        {
            get { return orgID; }
            set { orgID = value; }
        }

        public string PatientName
        {
            set
            {
                patientName = value;
            }
            get
            {
                return patientName;
            }
        }

        public string PhysicianName
        {
            set
            {
                physicianName = value;
            }
            get
            {
                return physicianName;
            }
        }


        public string ComplaintDesc
        {

            set { complaintDesc = value; }
            get { return complaintDesc; }

        }
        /// <summary>
        /// Gets or sets the PhysicianID value.
        /// </summary>
        public int PhysicianID
        {
            get { return physicianID; }
            set { physicianID = value; }
        }

        /// <summary>
        /// Gets or sets the ComplaintId value.
        /// </summary>
        public int ComplaintId
        {
            get { return complaintId; }
            set { complaintId = value; }
        }

        public string ComplaintName
        {
            get { return complaintName; }
            set { complaintName = value; }
        }

        /// <summary>
        /// Gets or sets the ConditionId value.
        /// </summary>
        public int ConditionId
        {
            get { return conditionId; }
            set { conditionId = value; }
        }

        /// <summary>
        /// Gets or sets the VisitType value.
        /// </summary>
        public int VisitType
        {
            get { return visitType; }
            set { visitType = value; }
        }

        /// <summary>
        /// Gets or sets the OutVisitID value.
        /// </summary>
        public long OutVisitID
        {
            get { return outVisitID; }
            set { outVisitID = value; }
        }

        /// <summary>
        /// Gets or sets the VisitPurposeID value.
        /// </summary>
        public byte VisitPurposeID
        {
            get { return VisitPurposeID; }
            set { visitPurposeID = value; }
        }

        /// <summary>
        /// Gets or sets the VisitNotes value.
        /// </summary>
        public string VisitNotes
        {
            get { return visitNotes; }
            set { visitNotes = value; }
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
        /// Gets or sets the VisitState value.
        /// </summary>
        public string VisitState
        {
            get { return visitState; }
            set { visitState = value; }
        }

        /// <summary>
        /// Gets or sets the NurseNotes value.
        /// </summary>
        public string NurseNotes
        {
            get { return nurseNotes; }
            set { nurseNotes = value; }
        }

        /// <summary>
        /// Gets or sets the AccompaniedBy value.
        /// </summary>
        public string AccompaniedBy
        {
            get { return accompaniedBy; }
            set { accompaniedBy = value; }
        }

        public string TitleName
        {

            get { return titleName; }
            set { titleName = value; }
        }
        public string NextReviewDate
        {
            get { return nextReviewDate; }
            set { nextReviewDate = value; }
        }

        //public int PatientVisitPurposeID
        //{

        //    get { return patientVisitPurposeID; }
        //    set { patientVisitPurposeID = value; }
        //}
        //public long SpecialityID
        //{

        //    get { return specialityID; }
        //    set { specialityID = value; }
        //}
        private string uID = String.Empty;
        /// <summary>
        /// Gets or sets the UID value.
        /// </summary>
        public string UID
        {
            get { return uID; }
            set { uID = value; }
        }

        private string age = String.Empty;
        public string Age
        {
            get { return age; }
            set { age = value; }
        }

        public string PatientVisitType
        {
            set
            {
                patientVisitType = value;
            }
            get
            {
                return patientVisitType;
            }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public int ReferingPhysicianID
        {
            get { return referingPhysicianID; }
            set { referingPhysicianID = value; }
        }

        public string Labno
        {
            get { return labno; }
            set { labno = value; }
        }

        public string PatientStatus
        {
            get { return patientStatus; }
            set { patientStatus = value; }
        }
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string State
        {
            get { return state; }
            set { state = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public string MobileNumber
        {
            get { return mobileNumber; }
            set { mobileNumber = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public long EmergencyPatientTrackerID
        {
            get { return emergencyPatientTrackerID; }
            set { emergencyPatientTrackerID = value; }
        }
        public long EmergencySeverityOrgMappingID
        {
            get { return emergencySeverityOrgMappingID; }
            set { emergencySeverityOrgMappingID = value; }
        }
        public long PatientVisitID
        {
            get { return patientVisitID; }
            set { patientVisitID = value; }
        }
        public string VisitNumber
        {
            get { return visitnumber; }
            set { visitnumber = value; }
        }

        public long DeptID
        {
            get { return deptID; }
            set { deptID = value; }
        }

        string _Param1;
        public string Param1
        {
            get { return _Param1; }
            set { _Param1 = value; }
        }

        string _Param2;
        public string Param2
        {
            get { return _Param2; }
            set { _Param2 = value; }
        }
        string _Param3;
        public string Param3
        {
            get { return _Param3; }
            set { _Param3 = value; }

        }

        string _Param4;
        public string Param4
        {
            get { return _Param4; }
            set { _Param4 = value; }
        }

        string _Param5;
        public string Param5
        {
            get { return _Param5; }
            set { _Param5 = value; }
        }

        string _Param6;
        public string Param6
        {
            get { return _Param6; }
            set { _Param6 = value; }
        }

        long _id;
        public long ID
        {
            get { return _id; }
            set { _id = value; }
        }

        int _id1;
        public int ID1
        {
            get { return _id1; }
            set { _id1 = value; }
        }

        long _id2;
        public long ID2
        {
            get { return _id2; }
            set { _id2 = value; }
        }
        decimal _dueamount;
        public decimal DueAmount
        {
            get { return _dueamount; }
            set { _dueamount = value; }
        }

        decimal _amountreceived;
        public decimal AmountReceived
        {
            get { return _amountreceived; }
            set { _amountreceived = value; }
        }

        decimal _netamount;
        public decimal NetAmount
        {
            get { return _netamount; }
            set { _netamount = value; }
        }
        string _history;
        public string History
        {
            get { return _history; }
            set { _history = value; }
        }
        string _remarks;
        public string Remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }
        public string ResultEntryType
        {
            get { return resultEntryType; }
            set { resultEntryType = value; }
        }
        #endregion
        public int TATStatus
        {
            get { return TATstatus; }
            set { TATstatus = value; }
        }
        DateTime reporttat;
        public DateTime ReportTat
        {
            get { return reporttat; }
            set { reporttat = value; }
        }
        public string Address1
        {
            get { return address1; }
            set { address1 = value; }
        }
        public string Address2
        {
            get { return address2; }
            set { address2 = value; }
        }
        public string ExternalPatientNumber
        {
            get { return externalPatientNumber; }
            set { externalPatientNumber = value; }
        }

        /// <summary>
        /// Gets or sets the SpeciesID value.
        /// </summary>
        public int SpeciesID
        {
            get { return speciesID; }
            set { speciesID = value; }
        }

        private string _speciesName = String.Empty;
        public string SpeciesName
        {
            get { return _speciesName; }
            set { _speciesName = value; }
        }
        /// <summary>
        /// Gets or sets the PreviousLabNumber value.
        /// </summary>
        public string PreviousLabNumber
        {
            get { return previousLabNumber; }
            set { previousLabNumber = value; }
        }

        /// <summary>
        /// Gets or sets the IsCumulative value.
        /// </summary>
        public bool IsCumulative
        {
            get { return isCumulative; }
            set { isCumulative = value; }
        }
        /// <summary>
        /// Gets or sets the ReportMode value.
        /// </summary>
        public string ReportMode
        {
            get { return reportMode; }
            set { reportMode = value; }
        }
        /// <summary>
        /// Gets or sets the Confidential value.
        /// </summary>
        public string Confidential
        {
            get { return confidential; }
            set { confidential = value; }
        }

        /// <summary>
        /// Gets or sets the ReportingCentername value.
        /// </summary>
        public string ReportingCentername
        {
            get { return reportingCentername; }
            set { reportingCentername = value; }
        }
    }
}
