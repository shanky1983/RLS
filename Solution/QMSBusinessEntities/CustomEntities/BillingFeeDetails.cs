using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class BillingFeeDetails
    {
        private long sno = 0;
        private Int64 procedureFeeID = 0;
        private Int64 procedureID = 0;
        private decimal amount = 0;
        private string isVariable = String.Empty;
        private string procedureName = String.Empty;
        private string procedureType = String.Empty;
        private string descrip = String.Empty;
        private string isAVisitPurpose = String.Empty;
        private long investigationFeeID = 0;
        private Int64 id = 0;
        private Int64 visitID = 0;
        private Int64 patientID = 0;
        private Int64 orgID = 0;
        private Int64 physicianFeeID = 0;
        private string isGroup = string.Empty;
        private int vaccinationID = 0;
        private string isChecked = string.Empty;
        private string feeType = string.Empty;
        private long quickBillID = 0;
        private string isReimbursable = string.Empty;
        private string isHistoryMandatory = string.Empty;

        public long SNo
        {
            get { return sno; }
            set { sno = value; }
        }

        public Int64 InvestigationFeeID
        {
            get { return investigationFeeID; }
            set { investigationFeeID = value; }
        }
        public Int64 PhysicianFeeID
        {
            get { return physicianFeeID; }
            set { physicianFeeID = value; }
        }
        public Int64 ProcedureFeeID
        {
            get { return procedureFeeID; }
            set { procedureFeeID = value; }
        }
        public Int64 ProcedureID
        {
            get { return procedureID; }
            set { procedureID = value; }

        }
        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }

        }
        public string IsVariable
        {
            get { return isVariable; }
            set { isVariable = value; }

        }
        public string ProcedureName
        {
            get { return procedureName; }
            set { procedureName = value; }
        }
        public string ProcedureType
        {
            get { return procedureType; }
            set { procedureType = value; }
        }
        public string Descrip
        {
            get { return descrip; }
            set { descrip = value; }
        }
        public string IsAVisitPurpose
        {
            get { return isAVisitPurpose; }
            set { isAVisitPurpose = value; }

        }


        public Int64 ID
        {
            get { return id; }
            set { id = value; }
        }
        public Int64 VisitID
        {
            get { return visitID; }
            set { visitID = value; }
        }
        public Int64 PatientID
        {
            get { return patientID; }
            set { patientID = value; }
        }
        public Int64 OrgID
        {
            get { return orgID; }
            set { orgID = value; }
        }

        public string IsGroup
        {
            get { return isGroup; }
            set { isGroup = value; }

        }

        public int VaccinationID
        {
            get { return vaccinationID; }
            set { vaccinationID = value; }
        }
        public string IsChecked
        {
            get { return isChecked; }
            set { isChecked = value; }
        }

        public string FeeType
        {
            get { return feeType; }
            set { feeType = value; }

        }

        public long QuickBillID
        {
            get { return quickBillID; }
            set { quickBillID = value; }
        }

        public string IsReimbursable
        {
            get { return isReimbursable; }
            set { isReimbursable = value; }
        }
        public string IsHistoryMandatory
        {
            get { return isHistoryMandatory; }
            set { isHistoryMandatory = value; }
        }
    }
}
