using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class SurgeonFeeSplit
    {
        private long _PhysicianID;

        public long PhysicianID
        {
            get { return _PhysicianID; }
            set { _PhysicianID = value; }
        }
        private string _PhysicianName;

        public string PhysicianName
        {
            get { return _PhysicianName; }
            set { _PhysicianName = value; }
        }

        private int _PhysicianFee;

        public int PhysicianFee
        {
            get { return _PhysicianFee; }
            set { _PhysicianFee = value; }
        }

        private int _HospitalFee;

        public int HospitalFee
        {
            get
            {
                return _HospitalFee;
            }
            set
            {
                _HospitalFee = value;
            }
        }

        private string _SplitType;

        public string SplitType
        {
            get
            {
                return _SplitType;
            }
            set
            {
                _SplitType = value;
            }
        }   

        private string _Code;

        public string Code
        {
            get
            {
                return _Code;
            }
            set
            {
                _Code = value;
            }
        }

        private long _SurgeryBillingRateMappingID;
        public long SurgeryBillingRateMappingID
        {
            get
            {
                return _SurgeryBillingRateMappingID;
            }
            set
            {
                _SurgeryBillingRateMappingID = value;
            }
        }
    }
}
