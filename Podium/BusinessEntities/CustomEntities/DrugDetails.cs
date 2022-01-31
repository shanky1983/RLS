using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class DrugDetails
    {
        private long prescriptionID;
        private long patientVisitID;
        private string drugName;
        private string drugFrm;
        private string drugROA;
        private string drugDose;
        private string drugFrq;
        private string days;
        private string instruction;
        private long createdby;
        private long drugID;
        private DateTime Adate = DateTime.MaxValue;
        private string duration;
        private int complaintId;
        private DateTime createdAt = DateTime.MaxValue;
        private DateTime modifiedAt = DateTime.MaxValue;
        private long modifiedBy;
        private DateTime administeredAtTo = DateTime.MaxValue;
        private long roleid;
        private bool administeredStatus = false;
        private string drugStatus = String.Empty;
        private long sno;
        private string nurseName = String.Empty;
        private string prescriptionType;
        private string drugdource;
        private string prescriptionNumber;
        private long physicianid;
        private DateTime prescribedrugexpirydate = DateTime.MaxValue;
        private long taskID;
        private string direction;
        private string isGeneric = String.Empty;
        private long genericID;
        private long drugFrequencyID=0;
        private int drugInstructionID=0;
        private string itemtype=String.Empty;
        private string reference = string.Empty;
        
        public string ItemType
        {
            get { return itemtype; }
            set { itemtype = value; }
        }
        public string Reference
        {
            get { return reference; }
            set { reference = value; }
        }

        public string Direction
        {
            set { direction = value; }
            get { return direction; }
        }
        private decimal qty;
        public decimal Qty
        {
            set { qty = value; }
            get { return qty; }
        }
        //"RID^"+rowCount.ToString()+ "~DNAME^" + drugName + "~DFRM^" + drugFrm + "~ROA^" + dROA + "~DDOSE^" + dDose + "~FRQ^" + strdFrq + "~DURA^" + tDura.Text + "|";

        /// <summary>
        /// Gets or sets the PatientVisitID value.
        /// </summary>
        public long PrescriptionID
        {
            get { return prescriptionID; }
            set { prescriptionID = value; }
        }

        /// <summary>
        /// Gets or sets the PatientVisitID value.
        /// </summary>
        public long PatientVisitID
        {
            get
            {
                return patientVisitID;
            }
            set
            {
                patientVisitID = value;
            }
        }


        /// <summary>
        /// Gets or sets the DrugId value.
        /// </summary>
        public long DrugID
        {
            get
            {
                return drugID;
            }
            set
            {
                drugID = value;
            }
        }

       
        /// <summary>
        /// Gets or sets the DrugName value.
        /// </summary>
        public string DrugName
        {
            get
            {
                return drugName;
            }
            set
            {
                drugName = value;
            }
        }

        /// <summary>
        /// Gets or sets the DrugTypeName value.
        /// </summary>
        public string DrugFormulation
        {
            get
            {
                return drugFrm;
            }
            set
            {
                drugFrm = value;
            }
        }

        /// <summary>
        /// Gets or sets the DrugFrequency value.
        /// </summary>
        public string DrugFrequency
        {
            get
            {
                return drugFrq;
            }
            set
            {
                drugFrq = value;
            }
        }

        /// <summary>
        /// Gets or sets the Days value.
        /// </summary>
        public string Days
        {
            get
            {
                return days;
            }
            set
            {
                days = value;
            }
        }
        public string Instruction
        {
            get
            {
                return instruction;
            }
            set
            {
                instruction = value;
            }
        }

        public string Dose
        {
            set { drugDose = value; }
            get { return drugDose; }
        }


        public string ROA
        {
            set { drugROA = value; }
            get { return drugROA; }
        }

        public long CreatedBy
        {
            set { createdby = value; }
            get { return createdby; }
        }

        public DateTime AdministeredAtFrom
        {
            set { Adate = value; }
            get { return Adate; }
        }
        public string Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        public int ComplaintId
        {
            get { return complaintId; }
            set { complaintId = value; }
        }
        public DateTime CreatedAt
        {
            set { createdAt = value; }
            get { return createdAt; }
        }
        public DateTime ModifiedAt
        {
            set { modifiedAt = value; }
            get { return modifiedAt; }
        }
        public long ModifiedBy
        {
            set { modifiedBy = value; }
            get { return modifiedBy; }
        }
        public DateTime AdministeredAtTo
        {
            set { administeredAtTo = value; }
            get { return administeredAtTo; }
        }
        public long RoleID
        {
            get { return roleid; }
            set { roleid = value; }
        }
        public bool AdministeredStatus
        {
            get { return administeredStatus; }
            set { administeredStatus = value; }
        }
        
        public string DrugStatus
        {
            get { return drugStatus; }
            set { drugStatus = value; }
        }
        public long Sno
        {
            get { return sno; }
            set { sno = value; }
        }
        public string NurseName
        {
            get { return nurseName; }
            set { nurseName = value; }
        }

        public string PrescriptionType
        {
            get { return prescriptionType; }
            set { prescriptionType = value; }
        }
        public string DrugSource
        {
            get { return drugdource; }
            set { drugdource = value; }
        }
        public string PrescriptionNumber
        {
            get { return prescriptionNumber; }
            set { prescriptionNumber = value; }
        }

        public long PhysicianID
        {
            get { return physicianid; }
            set { physicianid = value; }
        }
        public DateTime PrescribeDrugExpiryDate
        {
            set { prescribedrugexpirydate = value; }
            get { return prescribedrugexpirydate; }
        }
        public long TaskID
        {
            get
            {
                return taskID;
            }
            set
            {
                taskID = value;
            }
        }

        /// <summary>
        /// Gets or sets the IsGeneric value.
        /// </summary>
        public string IsGeneric
        {
            get
            {
                return isGeneric;
            }
            set
            {
                isGeneric = value;
            }
        }


        /// <summary>
        /// Gets or sets the GenericID value.
        /// </summary>
        public long GenericID
        {
            get
            {
                return genericID;
            }
            set
            {
                genericID = value;
            }
        }
        /// <summary>
        /// Gets or sets the DrugFrequencyID value.
        /// </summary>
        public long DrugFrequencyID
        {
            get { return drugFrequencyID; }
            set { drugFrequencyID = value; }
        }

        /// <summary>
        /// Gets or sets the DrugInstructionID value.
        /// </summary>
        public int DrugInstructionID
        {
            get { return drugInstructionID; }
            set { drugInstructionID = value; }
        }

        private decimal _Amount;

        public decimal Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }

       
        private string _PhysicianName;

        public string PhysicianName
        {
            get { return _PhysicianName; }
            set { _PhysicianName = value; }
        }

        private long _OrderTaskID;

        public long OrderTaskID
        {
            get { return _OrderTaskID; }
            set { _OrderTaskID = value; }
        }
        private string _Type;

        public string Type
        {
            get { return _Type; }
            set { _Type = value; }
        }

        private DateTime startDate = DateTime.MaxValue;
        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        private DateTime endDate = DateTime.MaxValue;
        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        private bool sticky = false;
        public bool Sticky
        {
            get { return sticky; }
            set { sticky = value; }
        }

//EMR Integration		
		/// <summary>
        /// Gets or sets the PatientVisitID value.
        /// </summary>
		private long patientID=0;		
        public long PatientID
        {
            get { return patientID; }
            set { patientID = value; }
        }
//EMR Integration	
        private long visitConsID = 0;

        public long VisitConsID
        {
            get { return visitConsID; }
            set { visitConsID = value; }
        }
    }
}
