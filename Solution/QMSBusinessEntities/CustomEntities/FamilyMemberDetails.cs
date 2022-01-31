using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    [Serializable]
    public class FamilyMemberDetails
    {
        #region Fields

        private long id = 0;
        private long memberDetailsID = 0;
        private long familyDetailsID = 0;
        private string name = String.Empty;
        private long relationShipID = 0;
        private long parentFamilyID = 0;
        private string relationName = String.Empty;
        private int orgID = 0;
        private string gender = String.Empty;
        private int age = 0;
        private DateTime dOB = DateTime.MaxValue;
        private string maritalStatus = String.Empty;
        private string mobileNo = string.Empty;
        private string qualification = String.Empty;
        private int qualificationMetaTypeID = 0;
        private string qualificationMetaValueID = string.Empty;
        private string isPatient = string.Empty;
        private long patientId = 0;
        private int religionId = 0;
        private string bloodGroup = String.Empty;
        private string isActive = string.Empty;
        private string status = String.Empty;
        private string reasonvalue1 = String.Empty;
        private long createdBy = 0;
        private DateTime createdAt = DateTime.MaxValue;
        private long modifiedBy = 0;
        private DateTime modifiedAt = DateTime.MaxValue;
        private string houseHoNo = string.Empty;
        private string uniqueHHNo = string.Empty;
        private string patientNumber = string.Empty;
        private string isMigrant = string.Empty;
        private int migrantTypeID = 0;
        private int migrantDurationTypeID = 0;
        private string category = string.Empty;
        private string povertyGroup = string.Empty;
        private string landlineNo = string.Empty;
        private string stayingType = string.Empty;
        private DateTime stayingPeroid = DateTime.MaxValue;
        private string address = string.Empty;
        private int areaID = 0;
        private int parentOrgID = 0;
        private long userID = 0;
        private string orgCode = string.Empty;
        private string areaCode = string.Empty;
        private string areaName = string.Empty;
        private long reasonID = 0;
        private string reasonValue = string.Empty;
        private string medicalHistory = string.Empty;
        private long pincode = 0;
        private decimal expense = 0;
        private string aadharID = string.Empty;
        private long visitID = 0;
        private string maritalStatusText = string.Empty;
        private long areaUserID = 0;
        private long scUserID = 0;
        private string areaUserName = string.Empty;
        private string scUserName = string.Empty;
        private List<CustMemberIdentity> memberidentity;
        private List<MedicalExpenses> medicalexpenses;
        private List<CertificateInfo> certificateInfo;
        private string certificateNo = string.Empty;
        private DateTime removalDate = DateTime.MaxValue; 
        private string _SC = string.Empty;
        private string _PHC = string.Empty;
        private string _CHC = string.Empty;
        #endregion

        #region Properties

        public List<CustMemberIdentity> MemberIdentity
        {
            get
            {
                return memberidentity;
            }
            set
            {
                memberidentity = value;
            }
        }

        public List<MedicalExpenses> MedicalExpenses
        {
            get
            {
                return medicalexpenses;
            }
            set
            {
                medicalexpenses = value;
            }
        }
        public List<CertificateInfo> CertificateInfo 
        { 
            get
            {
                return certificateInfo;
            }
            set
            {
                certificateInfo = value;
            }
        }

        public DateTime StayingPeroid
        {
            get { return stayingPeroid; }
            set { stayingPeroid = value; }
        }

        public DateTime ModifiedAt
        {
            get { return modifiedAt; }
            set { modifiedAt = value; }
        }

        public DateTime CreatedAt
        {
            get { return createdAt; }
            set { createdAt = value; }
        }

        public DateTime DOB
        {
            get { return dOB; }
            set { dOB = value; }
        }

        public int OrgID
        {
            get { return orgID; }
            set { orgID = value; }
        }

        public int ParentOrgID
        {
            get { return parentOrgID; }
            set { parentOrgID = value; }
        }

        public int AreaID
        {
            get { return areaID; }
            set { areaID = value; }
        }

        public string LandlineNo
        {
            get { return landlineNo; }
            set { landlineNo = value; }
        }


        public int ReligionId
        {
            get { return religionId; }
            set { religionId = value; }
        }

        public long Pincode
        {
            get { return pincode; }
            set { pincode = value; }
        }

        public string MobileNo
        {
            get { return mobileNo; }
            set { mobileNo = value; }
        }
        public string MedicalHistory
        {
            get { return medicalHistory; }
            set { medicalHistory = value; }
        }
        public string ReasonValue
        {
            get { return reasonValue; }
            set { reasonValue = value; }
        }
        public string AreaName
        {
            get { return areaName; }
            set { areaName = value; }
        }
        public string AreaCode
        {
            get { return areaCode; }
            set { areaCode = value; }
        }
        public string OrgCode
        {
            get { return orgCode; }
            set { orgCode = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }



        public string StayingType
        {
            get { return stayingType; }
            set { stayingType = value; }
        }


        public string PovertyGroup
        {
            get { return povertyGroup; }
            set { povertyGroup = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }


        public string IsMigrant
        {
            get { return isMigrant; }
            set { isMigrant = value; }
        }

        public int MigrantTypeID
        {
            get { return migrantTypeID; }
            set { migrantTypeID = value; }
        }

        public int MigrantDurationTypeID
        {
            get { return migrantDurationTypeID; }
            set { migrantDurationTypeID = value; }
        }

        public string UniqueHHNo
        {
            get { return uniqueHHNo; }
            set { uniqueHHNo = value; }
        }

        public string PatientNumber
        {
            get { return patientNumber; }
            set { patientNumber = value; }
        }



        public string HouseHoNo
        {
            get { return houseHoNo; }
            set { houseHoNo = value; }
        }
        public string ReasonValue1
        {
            get { return reasonvalue1; }
            set { reasonvalue1 = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public string IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }

        public string BloodGroup
        {
            get { return bloodGroup; }
            set { bloodGroup = value; }
        }

        public string IsPatient
        {
            get { return isPatient; }
            set { isPatient = value; }
        }

        public int QualificationMetaTypeID
        {
            get { return qualificationMetaTypeID; }
            set { qualificationMetaTypeID = value; }
        }

        public string QualificationMetaValueID
        {
            get { return qualificationMetaValueID; }
            set { qualificationMetaValueID = value; }
        }
        public string Qualification
        {
            get { return qualification; }
            set { qualification = value; }
        }
        public string MaritalStatus
        {
            get { return maritalStatus; }
            set { maritalStatus = value; }
        }

        public string MaritalStatusText
        {
            get { return maritalStatusText; }
            set { maritalStatusText = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string RelationName
        {
            get { return relationName; }
            set { relationName = value; }
        }

        public long ID
        {
            get { return id; }
            set { id = value; }
        }
        public long ReasonID
        {
            get { return reasonID; }
            set { reasonID = value; }
        }
        public long UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        public long CreatedBy
        {
            get { return createdBy; }
            set { createdBy = value; }
        }
        public long ModifiedBy
        {
            get { return modifiedBy; }
            set { modifiedBy = value; }
        }
        public long PatientId
        {
            get { return patientId; }
            set { patientId = value; }
        }
        public long MemberDetailsID
        {
            get { return memberDetailsID; }
            set { memberDetailsID = value; }
        }
        public long FamilyDetailsID
        {
            get { return familyDetailsID; }
            set { familyDetailsID = value; }
        }
        public long RelationShipID
        {
            get { return relationShipID; }
            set { relationShipID = value; }
        }
        public long ParentFamilyID
        {
            get { return parentFamilyID; }
            set { parentFamilyID = value; }
        }

        public decimal Expense
        {
            get { return expense; }
            set { expense = value; }
        }

        public string AadharID
        {
            get { return aadharID; }
            set { aadharID = value; }
        }
        public long VisitID
        {
            get { return visitID; }
            set { visitID = value; }
        }
        public long AreaUserID
        {
            get { return areaUserID; }
            set { areaUserID = value; }
        }
        public long SCUserID
        {
            get { return scUserID; }
            set { scUserID = value; }
        }
        public string AreaUserName
        {
            get { return areaUserName; }
            set { areaUserName = value; }
        }
        public string SCUserName
        {
            get { return scUserName; }
            set { scUserName = value; }
        }
         public string CertificateNo
        {
            get { return certificateNo; }
            set { certificateNo = value; }

        }
        public DateTime RemovalDate
        {
            get { return removalDate; }
            set { removalDate = value; }
        }
        public string SC
        {
            get { return _SC; }
            set { _SC = value; }

        }
        public string PHC
        {
            get { return _PHC; }
            set { _PHC = value; }

        }
        public string CHC
        {
            get { return _CHC; }
            set { _CHC = value; }

        }
        #endregion
    }
}
