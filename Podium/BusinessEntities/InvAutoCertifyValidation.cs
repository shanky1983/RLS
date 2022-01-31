using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class InvAutoCertifyValidation
    {
        #region Fields

        private int id = 0;
        private long investigationId = 0;
        private string type = String.Empty;
        private int orgid = 0;
        private bool isautocertify = false;
        private bool isDeviceError = false;
        private bool isQCstatus = false;
        private bool isCriticalValue = false;
        private bool isDeltavalue = false;
        private bool isAutoauthorizationrange = false;
        private bool isGroupDependencies = false;
        private bool isCrossParameterCheck = false;
        private bool isTechnicianVerificationNeeded = false;
        private DateTime createdAt;
        private long createdBy = 0;
        private DateTime modifiedAt;
        private long modifiedBy = 0;
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
        /// Gets or sets the InvestigationId value.
        /// </summary>
        public long InvestigationId
        {
            get { return investigationId; }
            set { investigationId = value; }
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
        /// Gets or sets the Orgid value.
        /// </summary>
        public int Orgid
        {
            get { return orgid; }
            set { orgid = value; }
        }

        /// <summary>
        /// Gets or sets the Isautocertify value.
        /// </summary>
        public bool Isautocertify
        {
            get { return isautocertify; }
            set { isautocertify = value; }
        }

        /// <summary>
        /// Gets or sets the IsDeviceError value.
        /// </summary>
        public bool IsDeviceError
        {
            get { return isDeviceError; }
            set { isDeviceError = value; }
        }

        /// <summary>
        /// Gets or sets the IsQCstatus value.
        /// </summary>
        public bool IsQCstatus
        {
            get { return isQCstatus; }
            set { isQCstatus = value; }
        }

        /// <summary>
        /// Gets or sets the IsCriticalValue value.
        /// </summary>
        public bool IsCriticalValue
        {
            get { return isCriticalValue; }
            set { isCriticalValue = value; }
        }

        /// <summary>
        /// Gets or sets the IsDeltavalue value.
        /// </summary>
        public bool IsDeltavalue
        {
            get { return isDeltavalue; }
            set { isDeltavalue = value; }
        }

        /// <summary>
        /// Gets or sets the IsAutoauthorizationrange value.
        /// </summary>
        public bool IsAutoauthorizationrange
        {
            get { return isAutoauthorizationrange; }
            set { isAutoauthorizationrange = value; }
        }

        /// <summary>
        /// Gets or sets the IsGroupDependencies value.
        /// </summary>
        public bool IsGroupDependencies
        {
            get { return isGroupDependencies; }
            set { isGroupDependencies = value; }
        }

        /// <summary>
        /// Gets or sets the IsCrossParameterCheck value.
        /// </summary>
        public bool IsCrossParameterCheck
        {
            get { return isCrossParameterCheck; }
            set { isCrossParameterCheck = value; }
        }

        /// <summary>
        /// Gets or sets the IsTechnicianVerificationNeeded value.
        /// </summary>
        public bool IsTechnicianVerificationNeeded
        {
            get { return isTechnicianVerificationNeeded; }
            set { isTechnicianVerificationNeeded = value; }
        }

        private decimal _deltaLowerLimit = Decimal.Zero;
        public decimal DeltaLowerLimit
        {
            get { return _deltaLowerLimit; }
            set { _deltaLowerLimit = value; }
        }

        private decimal _deltaHigherLimit = Decimal.Zero;
        public decimal DeltaHigherLimit
        {
            get { return _deltaHigherLimit; }
            set { _deltaHigherLimit = value; }
        }

        private string _investigationValue = String.Empty;
        public string InvestigationValue
        {
            get { return _investigationValue; }
            set { _investigationValue = value; }
        }

        private string _qcStatus = String.Empty;
        public string QCStatus
        {
            get { return _qcStatus; }
            set { _qcStatus = value; }
        }

        private string isAutoAuthorize = String.Empty;
        public string IsAutoAuthorize
        {
            get { return isAutoAuthorize; }
            set { isAutoAuthorize = value; }
        }

        private string isAbnormal = String.Empty;
        public string IsAbnormal
        {
            get { return isAbnormal; }
            set { isAbnormal = value; }
        }

        private string _deviceErrorCode = String.Empty;
        public string DeviceErrorCode
        {
            get { return _deviceErrorCode; }
            set { _deviceErrorCode = value; }
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
        #endregion
    }
}
