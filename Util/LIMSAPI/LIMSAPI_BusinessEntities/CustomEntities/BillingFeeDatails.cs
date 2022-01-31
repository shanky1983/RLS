using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class BillingFeeDatails
    {
        public decimal Amount { get; set; }
        public string Descrip { get; set; }
        public string FeeType { get; set; }
        public long ID { get; set; }
        public long InvestigationFeeID { get; set; }
        public string IsAVisitPurpose { get; set; }
        public string IsChecked { get; set; }
        public string IsGroup { get; set; }
        public string IsHistoryMandatory { get; set; }
        public string Ishtml { get; set; }
        public string IsReimbursable { get; set; }
        public string IsSpecialTest { get; set; }
        public string IsTemplateText { get; set; }
        public string IsVariable { get; set; }
        public long OrgID { get; set; }
        public long PatientID { get; set; }
        public long PhysicianFeeID { get; set; }
        public long ProcedureFeeID { get; set; }
        public long ProcedureID { get; set; }
        public string ProcedureName { get; set; }
        public string ProcedureType { get; set; }
        public long QuickBillID { get; set; }
        public long SNo { get; set; }
        public long TemplateID { get; set; }
        public int VaccinationID { get; set; }
        public long VisitID { get; set; }
    }

  }
