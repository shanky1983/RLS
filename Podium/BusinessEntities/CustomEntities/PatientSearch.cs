using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    [Serializable]
    public class PatientSearch
    {
        #region Fields
        private int _OrgID;
        private int _AreaID;
        private string _ReferralStatus;
        private string _AadhaarID = "";
        private string _UniqueHouseNo = "";
        private string _RationNo = "";
        private string _MobileNo = "";
        private string _PatientNumber = "";
        private string _PatientName = "";
        private string _HouseNo = "";
        private DateTime _ReferralDate;
        #endregion

        #region Properties
        public int OrgID
        {
            get
            {
                return _OrgID;
            }
            set
            {
                _OrgID = value;
            }
        }

        public int AreaID
        {
            get
            {
                return _AreaID;
            }
            set
            {
                _AreaID = value;
            }
        }

        public string ReferralStatus
        {
            get
            {
                return _ReferralStatus;
            }
            set
            {
                _ReferralStatus = value;
            }
        }

        public string AadhaarID
        {
            get
            {
                return _AadhaarID;
            }
            set
            {
                _AadhaarID = value;
            }
        }

        public string UniqueHouseNo
        {
            get
            {
                return _UniqueHouseNo;
            }
            set
            {
                _UniqueHouseNo = value;
            }
        }

        public string RationNo
        {
            get
            {
                return _RationNo;
            }
            set
            {
                _RationNo = value;
            }
        }

        public string MobileNo
        {
            get
            {
                return _MobileNo;
            }
            set
            {
                _MobileNo = value;
            }
        }

        public string PatientNumber
        {
            get
            {
                return _PatientNumber;
            }
            set
            {
                _PatientNumber = value;
            }
        }

        public string PatientName
        {
            get
            {
                return _PatientName;
            }
            set
            {
                _PatientName = value;
            }
        }

        public string HouseNo
        {
            get
            {
                return _HouseNo;
            }
            set
            {
                _HouseNo = value;
            }
        }

        public DateTime ReferralDate
        {
            get
            {
                return _ReferralDate;
            }
            set
            {
                _ReferralDate = value;
            }
        }
        #endregion
    }
}
