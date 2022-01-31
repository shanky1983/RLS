using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public   class PatientPrescriptions
    {
        public long  PatientPrescriptionID { get; set; }
        public string MappedDrugName { get; set; }
        public string ProductName { get; set; }
        public string BrandName { get; set; }
        public string Dose { get; set; }
        public string Formulation { get; set; }
        public string ROA { get; set; }
        public string DrugFrequency { get; set; }
        public string Duration { get; set; }
        public string Instruction { get; set; }
        public string Direction { get; set; }
        public decimal TotalQty { get; set; }

        public string MappedDrugFrequency { get; set; }        
        public string MappedDose { get; set; }
        public string MappedDuration { get; set; }
        public string MappedInstruction { get; set; }
        public string MappedDirection { get; set; }
        public decimal MappedTotalQty { get; set; }
        public long DrugID { get; set; }
        public long PrescriptionDrugMappingID { get; set; }

    }
}
