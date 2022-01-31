using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    [Serializable]
    public enum ErrFlgOperationType
    {
        Add,
        Modify,
        Delete,
        None
    }

    [Serializable]
    public class DeviceErrorFlags
    {
        #region Fields

        private long instrumentID = 0;
        private string deviceCode = String.Empty;
        private string errorCategory = String.Empty;
        private string errorCode = String.Empty;
        private string errorDescription = String.Empty;
        private int orgID = 0;
        private int orgAddressID = 0;
        private string symbol = String.Empty;

        private string productName = String.Empty;
        private ErrFlgOperationType _operationType = ErrFlgOperationType.None;
        private string resultValue = String.Empty;
        private string deviceErrorFlagId = String.Empty;//productName+:errorCode
        private int isActive = 0;

        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the InstrumentID value.
        /// </summary>
        public long InstrumentID
        {
            get { return instrumentID; }
            set
            {
                instrumentID = value;
                SetDeviceErrorFlagId();
            }
        }

        /// <summary>
        /// Gets or sets the DeviceCode value.
        /// </summary>
        public string DeviceCode
        {
            get { return deviceCode; }
            set { deviceCode = value; }
        }

        /// <summary>
        /// Gets or sets the ErrorCategory value.
        /// </summary>
        public string ErrorCategory
        {
            get { return errorCategory; }
            set { errorCategory = value; }
        }

        /// <summary>
        /// Gets or sets the ErrorCode value.
        /// </summary>
        public string ErrorCode
        {
            get { return errorCode; }
            set
            {
                errorCode = value;
                SetDeviceErrorFlagId();
            }
        }

        /// <summary>
        /// Gets or sets the ErrorDescription value.
        /// </summary>
        public string ErrorDescription
        {
            get { return errorDescription; }
            set { errorDescription = value; }
        }

        /// <summary>
        /// Gets or sets the OrgID value.
        /// </summary>
        public int OrgID
        {
            get { return orgID; }
            set { orgID = value; }
        }

        /// <summary>
        /// Gets or sets the OrgAddressID value.
        /// </summary>
        public int OrgAddressID
        {
            get { return orgAddressID; }
            set { orgAddressID = value; }
        }

        /// <summary>
        /// Gets or sets the Symbol value.
        /// </summary>
        public string Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }


        /// <summary>
        /// Gets or sets the Result value.
        /// </summary>
        public string ResultValue
        {
            get { return resultValue; }
            set { resultValue = value; }
        }

        /// <summary>
        /// Gets or sets the ProductName value.
        /// </summary>
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }


        public ErrFlgOperationType operationType
        {
            get { return _operationType; }
            set { _operationType = value; }
        }

        public string DeviceErrorFlagId
        {
            get { return deviceErrorFlagId; }
            //set { deviceErrorFlagId = value; }
        }

        /// <summary>
        /// Gets or sets the IsActive value.
        /// </summary>
        /// If 1, its active otherwise inactive
        public int IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }

        public int SNO = 0;
        #endregion

        #region Methods

        private void SetDeviceErrorFlagId()
        {
            deviceErrorFlagId = GetDeviceErrorFlagId(InstrumentID.ToString(), errorCode);
        }

        public static string GetDeviceErrorFlagId(string InstrumentIDstr, string _errorCode)
        {
            string _key = "";
            string speperetor = "|";
            if (!string.IsNullOrEmpty(InstrumentIDstr))
                _key = InstrumentIDstr;

            if (!string.IsNullOrEmpty(_errorCode))
            {
                if (_key != "")
                    _key += speperetor + _errorCode;
                else
                    _key = _errorCode;
            }
            return _key;
        }
        #endregion Methods
    }

    [Serializable]
    public class InstrumentInfoErrorFlag
    {
        #region Fields
        private int orgId;

        private long instrumentId;
        private string productCode;
        private string instrumentName;
        #endregion Fields

        #region Proprties

        public long InstrumentID
        {
            get { return instrumentId; }
            set { instrumentId = value; }
        }

        public string ProductCode
        {
            get { return productCode; }
            set { productCode = value; }
        }
        public string InstrumentName
        {
            get { return instrumentName; }
            set { instrumentName = value; }
        }
        #endregion Proprties
    }
}
