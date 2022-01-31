using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class PackageTrackDetails
    {
        #region Fields
        private long packageId = 0;
        private string packageName = String.Empty;
        private string feeType = String.Empty;
        private long feeID = 0;
        private string feeDescription = string.Empty;
        private long patientID = 0;
        private long visitID = 0;
        private int orgID = 0;
        private long perPhyID = 0;
        private int perPhySpecialityID = 0;
        private int definedSitting_Turns = 0;
        private int availedSitting_Turns = 0;
        private DateTime createdAt = DateTime.MaxValue;
        private long createdBy = 0;
        private DateTime modifiedAt = DateTime.MaxValue;
        private long modifiedBy = 0;
        private int validPeriod = 0;
        private string validPeriodType = String.Empty;
        private string isMasterPackage = "Y";
        private long finalbillid = 0;
        private DateTime packageExpirationDate = DateTime.MaxValue;
        private DateTime serviceExpirationDate = DateTime.MaxValue;
        private long packageTrackingID = 0;

        #endregion
        #region Properties

        public long PackageTrackingID
        {
            get { return packageTrackingID; }
            set { packageTrackingID = value; }
        }

        public long PackageID
        {
            get { return packageId; }
            set { packageId = value; }
        }
        public string PackageName
        {
            get { return packageName; }
            set { packageName = value; }
        }
        public string FeeType
        {
            get { return feeType; }
            set { feeType = value; }
        }
        public long FeeID
        {
            get { return feeID; }
            set { feeID = value; }
        }
        public string FeeDescription
        {
            get { return feeDescription; }
            set { feeDescription = value; }
        }
        public long PatientID
        {
            get { return patientID; }
            set { patientID = value; }
        }
        public long VisitID
        {
            get { return visitID; }
            set { visitID = value; }
        }

        public int OrgID
        {
            get { return orgID; }
            set { orgID = value; }
        }
        public long PerPhyID
        {
            get { return perPhyID; }
            set { perPhyID = value; }
        }
        public int PerPhySpecialityID
        {
            get { return perPhySpecialityID; }
            set { perPhySpecialityID = value; }
        }
        public int DefinedSitting_Turns
        {
            get { return definedSitting_Turns; }
            set { definedSitting_Turns = value; }
        }
        public int AvailedSitting_Turns
        {
            get { return availedSitting_Turns; }
            set { availedSitting_Turns = value; }
        }
        public DateTime CreatedAt
        {
            get { return createdAt; }
            set { createdAt = value; }
        }
        public long CreatedBy
        {
            get { return createdBy; }
            set { createdBy = value; }
        }
        public DateTime ModifiedAt
        {
            get { return modifiedAt; }
            set { modifiedAt = value; }
        }
        public long ModifiedBy
        {
            get { return modifiedBy; }
            set { modifiedBy = value; }
        }
        public int ValidPeriod
        {
            get { return validPeriod; }
            set { validPeriod = value; }
        }
        public string ValidPeriodType
        {
            get { return validPeriodType; }
            set { validPeriodType = value; }
        }
        public string IsMasterPackage
        {
            get { return isMasterPackage; }
            set { isMasterPackage = value; }
        }
        public long FinalBillID
        {
            get { return finalbillid; }
            set { finalbillid = value; }
        }
        public DateTime PackageExpirationDate
        {
            get { return packageExpirationDate; }
            set { packageExpirationDate = value; }
        }
        public DateTime ServiceExpirationDate
        {
            get { return serviceExpirationDate; }
            set { serviceExpirationDate = value; }
        }
        private string isRefunded = string.Empty;
        public string IsRefunded
        {
            get { return isRefunded; }
            set { isRefunded = value; }
        }
        
        #endregion

    }
}
