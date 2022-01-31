using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class DeviceInvestigationData
    {
        private string abnormalFlag = string.Empty;
        private string containerNo = string.Empty;
        private DateTime createdAt = DateTime.MaxValue;
        private string deviceID = string.Empty;
        private long groupID = 0L;
        private string isProcessed = string.Empty;
        private string messageID = string.Empty;
        private DateTime orderedDTTM = DateTime.MaxValue;
        private string orgName = string.Empty;
        private long patientID = 0L;
        private DateTime processedAt = DateTime.MaxValue;
        private int rawDataLogID = 0;
        private string referenceRange = string.Empty;
        private DateTime resultCompletedDTTM = DateTime.MaxValue;
        private string resultType = string.Empty;
        private string sampleID = string.Empty;
        private DateTime specimenCollectionDTTM = DateTime.MaxValue;
        private string testCode = string.Empty;
        private int uID = 0;
        private string valu = string.Empty;
        private string valueUOM = string.Empty;

        public string AbnormalFlag
        {
            get
            {
                return this.abnormalFlag;
            }
            set
            {
                this.abnormalFlag = value;
            }
        }

        public string ContainerNo
        {
            get
            {
                return this.containerNo;
            }
            set
            {
                this.containerNo = value;
            }
        }

        public DateTime CreatedAt
        {
            get
            {
                return this.createdAt;
            }
            set
            {
                this.createdAt = value;
            }
        }

        public string DeviceID
        {
            get
            {
                return this.deviceID;
            }
            set
            {
                this.deviceID = value;
            }
        }

        public long GroupID
        {
            get
            {
                return this.groupID;
            }
            set
            {
                this.groupID = value;
            }
        }

        public string IsProcessed
        {
            get
            {
                return this.isProcessed;
            }
            set
            {
                this.isProcessed = value;
            }
        }

        public string MessageID
        {
            get
            {
                return this.messageID;
            }
            set
            {
                this.messageID = value;
            }
        }

        public DateTime OrderedDTTM
        {
            get
            {
                return this.orderedDTTM;
            }
            set
            {
                this.orderedDTTM = value;
            }
        }

        public string OrgName
        {
            get
            {
                return this.orgName;
            }
            set
            {
                this.orgName = value;
            }
        }

        public long PatientID
        {
            get
            {
                return this.patientID;
            }
            set
            {
                this.patientID = value;
            }
        }

        public DateTime ProcessedAt
        {
            get
            {
                return this.processedAt;
            }
            set
            {
                this.processedAt = value;
            }
        }

        public int RawDataLogID
        {
            get
            {
                return this.rawDataLogID;
            }
            set
            {
                this.rawDataLogID = value;
            }
        }

        public string ReferenceRange
        {
            get
            {
                return this.referenceRange;
            }
            set
            {
                this.referenceRange = value;
            }
        }

        public DateTime ResultCompletedDTTM
        {
            get
            {
                return this.resultCompletedDTTM;
            }
            set
            {
                this.resultCompletedDTTM = value;
            }
        }

        public string ResultType
        {
            get
            {
                return this.resultType;
            }
            set
            {
                this.resultType = value;
            }
        }

        public string SampleID
        {
            get
            {
                return this.sampleID;
            }
            set
            {
                this.sampleID = value;
            }
        }

        public DateTime SpecimenCollectionDTTM
        {
            get
            {
                return this.specimenCollectionDTTM;
            }
            set
            {
                this.specimenCollectionDTTM = value;
            }
        }

        public string TestCode
        {
            get
            {
                return this.testCode;
            }
            set
            {
                this.testCode = value;
            }
        }

        public int UID
        {
            get
            {
                return this.uID;
            }
            set
            {
                this.uID = value;
            }
        }

        public string Value
        {
            get
            {
                return this.valu;
            }
            set
            {
                this.valu = value;
            }
        }

        public string ValueUOM
        {
            get
            {
                return this.valueUOM;
            }
            set
            {
                this.valueUOM = value;
            }
        }
    }
}
