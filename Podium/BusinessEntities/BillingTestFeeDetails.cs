using System;
using System.Collections.Generic;
 
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class BillingTestFeeDetails
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
        private string isSpecialtest = string.Empty;
        private string ishtml = string.Empty;
        private long templateid = 0;
        private string istemplatetext = string.Empty;
 
		private bool isMandatoryHis = false;

        public bool IsMandatoryHis
        {
            get { return isMandatoryHis; }
            set { isMandatoryHis = value; }
        }
		
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
        public string IsSpecialTest
        {
            get { return isSpecialtest; }
            set { isSpecialtest = value; }
        }
        public string Ishtml
        {
            get { return ishtml; }
            set { ishtml = value; }
        }
        public long TemplateID
        {
            get { return templateid; }
            set { templateid = value; }
        }
        public string IsTemplateText
        {
            get { return istemplatetext; }
            set { istemplatetext = value; }
        }

        //tat
        private string reportdeliverydate = string.Empty;
        public string ReportDeliveryDate
        {
            get { return reportdeliverydate; }
            set { reportdeliverydate = value; }
        }
        private Int16 logistictimeinmins = 0;
        public Int16 Logistictimeinmins
        {
            get { return logistictimeinmins; }
            set { logistictimeinmins = value; }
        }
        private int processingtimeinmins = 0;

        public int Processingtimeinmins
        {
            get { return processingtimeinmins; }
            set { processingtimeinmins = value; }
        }

        private string labendtime = string.Empty;

        public string Labendtime
        {
            get { return labendtime; }
            set { labendtime = value; }
        }


        private string earlyreporttime = string.Empty;

        public string Earlyreporttime
        {
            get { return earlyreporttime; }
            set { earlyreporttime = value; }
        }
        private string tatprocessdatetype = String.Empty;
        public string TATProcessDateType
        {
            get { return tatprocessdatetype; }
            set { tatprocessdatetype = value; }
        }
        private int tatreferencedatebase = 0;
        public int Tatreferencedatebase
        {
            get { return tatreferencedatebase; }
            set { tatreferencedatebase = value; }
        }

        private string tatreferencedatetime = string.Empty; 
        public string Tatreferencedatetime
        {
            get { return tatreferencedatetime; }
            set { tatreferencedatetime = value; }
        }
        private string tatsamplereceiptdatetime = string.Empty; 
        public string Tatsamplereceiptdatetime
        {
            get { return tatsamplereceiptdatetime; }
            set { tatsamplereceiptdatetime = value; }
        }
        private string tatprocessstartdatetime = string.Empty; 
        public string Tatprocessstartdatetime
        {
            get { return tatprocessstartdatetime; }
            set { tatprocessstartdatetime = value; }
        }
        private string isenabletesthistory = string.Empty;
        public string IsEnableTestHistory
        {
            get { return isenabletesthistory; }
            set { isenabletesthistory = value; }
        }
    }
}
