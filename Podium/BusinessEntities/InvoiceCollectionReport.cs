using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    [Serializable()]
    public class InvoiceCollectionReport
    {
        #region Fields
        private string contactnumber = String.Empty;
        private long patientID = 0;
        private long patientVisitId = 0;
        private string patientName = String.Empty;
        private long finalBillID = 0;
        private string billNumber = String.Empty;
        private decimal totalAmount = Decimal.Zero;
        private decimal cash = Decimal.Zero;
        private decimal cards = Decimal.Zero;
        private decimal cheque = Decimal.Zero;
        private decimal dD = Decimal.Zero;
        private long collectedBY = 0;
        private string collectedName = "";
        private string consultantName = "";
        private long physicianID = 0;
        private string visitType = "";
        private string visitNumber = "";
        private string roomName = String.Empty;
        private DateTime visitDate = DateTime.Now;
        private string billDate;
        private int rowID;
        private decimal receivedAmount = Decimal.Zero;
        private decimal due = Decimal.Zero;
        private string age = String.Empty;
        private string patientNumber = String.Empty;
        private decimal consultation = 0;
        private decimal procedures = 0;
        private decimal pharmacy = 0;
        private decimal registrationfees = 0;
        private decimal others = 0;
        private decimal packages = 0;
        private decimal casualty = 0;
        private decimal labs = 0;
        private decimal imaging = 0;
        private decimal discount = 0;
        private decimal surgeryAdvance = 0;
        private decimal iPAdvance = 0;
        private decimal billAmount = 0;
        private decimal previousDue = 0;
        private decimal netValue = 0;
        private decimal taxAmount = 0;
        private decimal serviceCharge = 0;
        private string qty = String.Empty;
        private string feeType = string.Empty;
        private decimal itemAmount = 0;
        private decimal itemQuantity = 0;
        private string roomTypeName = string.Empty;
        private string bedName = string.Empty;
        private string bedOccName = string.Empty;
        private string deptName = string.Empty;
        private int totalCounts = 0;
        private DateTime orderedDate = DateTime.MaxValue;
        private string pOA = string.Empty;
        private string specialityName = string.Empty;
        private int lengthofStay = 0;
        private string dutyDoctor = string.Empty;
        private string city = string.Empty;
        private string aDMDiagnosis = string.Empty;
        private string dISDiagnosis = string.Empty;
        private string ipnumber = string.Empty;
        private string address = string.Empty;
        private string placeofDeath = string.Empty;
        private string typeofDeath = string.Empty;
        private DateTime doAdmission = DateTime.MaxValue;
        private DateTime doDischarge = DateTime.MaxValue;
        private string insuranceName = string.Empty;
        private string mLCNo = string.Empty;
        private string referredBy = string.Empty;
        private string typeofSurgery = string.Empty;
        private string surgeonName = string.Empty;
        private string anaesthetist = string.Empty;
        private string typeofAnaesthesia = string.Empty;
        private string dischargeStatus = string.Empty;
        private DateTime dateofSurgery = DateTime.MaxValue;
        private decimal billedAmount = 0;
        private decimal amountReceived = 0;
        private long rowNUM = 0;
        private decimal amountRefund = 0;
        private string description = string.Empty;
        private string physicianName = string.Empty;
        private int referingPhysicianID = 0;
        private int wardID = 0;
        private string isDuePaidBill = string.Empty;
        private string wardName = string.Empty;
        private string refphysicianName = string.Empty;
        private string paidCurrency = string.Empty;
        private decimal paidCurrencyAmount = 0;
        private decimal depositUsed = 0;
        private string isCreditBill = string.Empty;
        private decimal creditDue = 0;
        private string period = string.Empty;
        private long openingBal = 0;
        private long admitedpatient = 0;
        private long dischargedpatient = 0;
        private long closingbalance = 0;
        private string receiptNo = String.Empty;
        private string dueChartNo = String.Empty;
        private Decimal medicalamt = 0;
        private Decimal nonmedicalamt = 0;
        private Decimal preauthamt = 0;
        private Decimal advancepaid = 0;
        private Decimal amtreceivedservicecharge = 0;
        private Decimal advpaidservicecharge = 0;
        private Decimal roundoff = 0;
        private Decimal copercent = 0;
        private Decimal copayment = 0;
        private string isTPApatient = string.Empty;
        private string creditordebitcard = string.Empty;
        private string visitstate = string.Empty;
        private string category = string.Empty;
        private int noOfCases = 0;
        private int noOfTests = 0;
        private decimal actualBilled = 0;
        private decimal stdBillAmount = 0;
        private string refundNo = String.Empty;
        private decimal prmReceived = 0;
        private decimal prmRefund = 0;
        private decimal hosRefund = 0;
        private decimal hosReceived = 0;
        private long orgId = 0;
        private string organisationName = String.Empty;
        private string clientName = String.Empty;
        private long clientID = 0;
        private decimal coupon = Decimal.Zero;
        private string clientTypeName = string.Empty;
        private int clientTypeID = 0;
        private string discountReason = string.Empty;
        private string location = string.Empty;
        private string userName = string.Empty;
        private string qualification = string.Empty;
        private string physicianCode = string.Empty;
        private string emailID = string.Empty;
        private decimal writeOffAmount = Decimal.Zero;
        private decimal refundAmt = Decimal.Zero;

        private string Investigationname = string.Empty;
        private DateTime Registrationdate = DateTime.MaxValue;
        private DateTime paymentCollectionDate = DateTime.MaxValue;
        private DateTime invoiceDate = DateTime.MaxValue;

        private DateTime SampleCollecteddate = DateTime.MaxValue;
        private DateTime Approvedat = DateTime.MaxValue;
        private DateTime Despatchdate = DateTime.MaxValue;
        private string status = string.Empty;
        private string Receivername = string.Empty;
        private string isRefunded = string.Empty;
        private int patientcount = 0;
        private string userWise = string.Empty;
        private decimal invoiceAmount = 0;
        private decimal pendingAmount = 0;
        private decimal tDS = 0;
        private string invoiceNumber = string.Empty;
        private string paymentType = string.Empty;
        private string paymentDetails = string.Empty;         			




        


        #endregion

        #region Properties
        public string PaymentDetails
        {
            get { return paymentDetails; }
            set { paymentDetails = value; }
        }
        public string PaymentType
        {
            get { return paymentType; }
            set { paymentType = value; }
        }
        public string InvoiceNumber
        {
            get { return invoiceNumber; }
            set { invoiceNumber = value; }
        }
        public DateTime InvoiceDate
        {
            get { return invoiceDate; }
            set { invoiceDate = value; }
        }
        public decimal InvoiceAmount
        {
            get { return invoiceAmount; }
            set { invoiceAmount = value; }
        }
        public decimal TDS
        {
            get { return tDS; }
            set { tDS = value; }
        }
        public decimal PendingAmount
        {
            get { return pendingAmount; }
            set { pendingAmount = value; }
        }

        public string ContactNumber
        {
            get { return contactnumber; }
            set { contactnumber = value; }
        }
        public long PatientID
        {
            get { return patientID; }
            set { patientID = value; }
        }
        public long PatientVisitId
        {
            get { return patientVisitId; }
            set { patientVisitId = value; }
        }
        public int RowID
        {
            get { return rowID; }
            set { rowID = value; }
        }
        public string PatientName
        {
            get { return patientName; }
            set { patientName = value; }
        }
        public string Qty
        {
            get { return qty; }
            set { qty = value; }
        }
        public string RoomName
        {
            get { return roomName; }
            set { roomName = value; }
        }
        public long FinalBillID
        {
            get { return finalBillID; }
            set { finalBillID = value; }
        }
        public string BillNumber
        {
            get { return billNumber; }
            set { billNumber = value; }
        }
        public decimal TotalAmount
        {
            get { return totalAmount; }
            set { totalAmount = value; }
        }
        public decimal Cash
        {
            get { return cash; }
            set { cash = value; }
        }
        public decimal Cards
        {
            get { return cards; }
            set { cards = value; }
        }
        public decimal Cheque
        {
            get { return cheque; }
            set { cheque = value; }
        }
        public decimal DD
        {
            get { return dD; }
            set { dD = value; }
        }
        public long CollectedBY
        {
            get { return collectedBY; }
            set { collectedBY = value; }
        }
        public string CollectedName
        {
            get { return collectedName; }
            set { collectedName = value; }
        }
        public string ConsultantName
        {
            get { return consultantName; }
            set { consultantName = value; }
        }
        public long PhysicianID
        {
            get { return physicianID; }
            set { physicianID = value; }
        }
        public string VisitType
        {
            get { return visitType; }
            set { visitType = value; }
        }
        public string VisitNumber
        {
            get { return visitNumber; }
            set { visitNumber = value; }
        }
        public DateTime VisitDate
        {
            get { return visitDate; }
            set { visitDate = value; }
        }
        public DateTime PaymentCollectionDate
        {
            get { return paymentCollectionDate; }
            set { paymentCollectionDate = value; }
        }
        
        public string BillDate
        {
            get { return billDate; }
            set { billDate = value; }
        }

        public decimal ReceivedAmount
        {
            get { return receivedAmount; }
            set { receivedAmount = value; }
        }
        public decimal Due
        {
            get { return due; }
            set { due = value; }
        }
        public string Age
        {
            get { return age; }
            set { age = value; }
        }

        public string PatientNumber
        {
            get { return patientNumber; }
            set { patientNumber = value; }
        }
        public decimal Consultation
        {
            get { return consultation; }
            set { consultation = value; }
        }
        public decimal Procedures
        {
            get { return procedures; }
            set { procedures = value; }
        }
        public decimal Pharmacy
        {
            get { return pharmacy; }
            set { pharmacy = value; }
        }
        public decimal Registrationfees
        {
            get { return registrationfees; }
            set { registrationfees = value; }
        }
        public decimal Others
        {
            get { return others; }
            set { others = value; }
        }
        public decimal Packages
        {
            get { return packages; }
            set { packages = value; }
        }
        public decimal Casualty
        {
            get { return casualty; }
            set { casualty = value; }
        }
        public decimal Labs
        {
            get { return labs; }
            set { labs = value; }
        }
        public decimal Imaging
        {
            get { return imaging; }
            set { imaging = value; }
        }
        public decimal Discount
        {
            get { return discount; }
            set { discount = value; }
        }
        public decimal SurgeryAdvance
        {
            get { return surgeryAdvance; }
            set { surgeryAdvance = value; }
        }
        public decimal IPAdvance
        {
            get { return iPAdvance; }
            set { iPAdvance = value; }
        }

        public decimal BillAmount
        {
            get { return billAmount; }
            set { billAmount = value; }
        }
        public decimal PreviousDue
        {
            get { return previousDue; }
            set { previousDue = value; }
        }
        public decimal NetValue
        {
            get { return netValue; }
            set { netValue = value; }
        }

        public decimal TaxAmount
        {
            get { return taxAmount; }
            set { taxAmount = value; }
        }
        public decimal ServiceCharge
        {
            get { return serviceCharge; }
            set { serviceCharge = value; }
        }
        public string FeeType
        {
            get { return feeType; }
            set { feeType = value; }
        }
        public decimal ItemAmount
        {
            get { return itemAmount; }
            set { itemAmount = value; }
        }
        public decimal ItemQuantity
        {
            get { return itemQuantity; }
            set { itemQuantity = value; }
        }
        public string RoomTypeName
        {
            get { return roomTypeName; }
            set { roomTypeName = value; }
        }
        public string BedName
        {
            get { return bedName; }
            set { bedName = value; }
        }
        public string BedOccName
        {
            get { return bedOccName; }
            set { bedOccName = value; }
        }
        public string DeptName
        {
            get { return deptName; }
            set { deptName = value; }
        }
        public int TotalCounts
        {
            get { return totalCounts; }
            set { totalCounts = value; }
        }
        public DateTime OrderedDate
        {
            get { return orderedDate; }
            set { orderedDate = value; }
        }
        public string POA
        {
            get { return pOA; }
            set { pOA = value; }
        }
        public string SpecialityName
        {
            get { return specialityName; }
            set { specialityName = value; }
        }
        public int LengthofStay
        {
            get { return lengthofStay; }
            set { lengthofStay = value; }
        }
        public string DutyDoctor
        {
            get { return dutyDoctor; }
            set { dutyDoctor = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string ADMDiagnosis
        {
            get { return aDMDiagnosis; }
            set { aDMDiagnosis = value; }
        }
        public string DISDiagnosis
        {
            get { return dISDiagnosis; }
            set { dISDiagnosis = value; }
        }
        public string IPNumber
        {
            get { return ipnumber; }
            set { ipnumber = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string PlaceofDeath
        {
            get { return placeofDeath; }
            set { placeofDeath = value; }
        }
        public string TypeofDeath
        {
            get { return typeofDeath; }
            set { typeofDeath = value; }
        }
        public DateTime DoAdmission
        {
            get { return doAdmission; }
            set { doAdmission = value; }
        }

        public DateTime DoDischarge
        {
            get { return doDischarge; }
            set { doDischarge = value; }
        }

        public string InsuranceName
        {
            get { return insuranceName; }
            set { insuranceName = value; }
        }
        public string MLCNo
        {
            get { return mLCNo; }
            set { mLCNo = value; }
        }
        public string ReferredBy
        {
            get { return referredBy; }
            set { referredBy = value; }
        }
        public string TypeofSurgery
        {
            get { return typeofSurgery; }
            set { typeofSurgery = value; }
        }
        public string SurgeonName
        {
            get { return surgeonName; }
            set { surgeonName = value; }
        }
        public string Anaesthetist
        {
            get { return anaesthetist; }
            set { anaesthetist = value; }
        }
        public string TypeofAnaesthesia
        {
            get { return typeofAnaesthesia; }
            set { typeofAnaesthesia = value; }
        }
        public string DischargeStatus
        {
            get { return dischargeStatus; }
            set { dischargeStatus = value; }
        }
        public DateTime DateofSurgery
        {
            get { return dateofSurgery; }
            set { dateofSurgery = value; }
        }

        public decimal BilledAmount
        {
            get { return billedAmount; }
            set { billedAmount = value; }
        }
        public decimal AmountReceived
        {
            get { return amountReceived; }
            set { amountReceived = value; }
        }
        public long RowNUM
        {
            get { return rowNUM; }
            set { rowNUM = value; }
        }
        public decimal AmountRefund
        {
            get { return amountRefund; }
            set { amountRefund = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string PhysicianName
        {
            get { return physicianName; }
            set { physicianName = value; }
        }

        DateTime dateofAdmission = DateTime.MaxValue;
        public DateTime DateofAdmission
        {
            get { return dateofAdmission; }
            set { dateofAdmission = value; }
        }

        string treatmentName = string.Empty;
        public string TreatmentName
        {
            get { return treatmentName; }
            set { treatmentName = value; }
        }

        string mLCtype = string.Empty;
        public string MLCtype
        {
            get { return mLCtype; }
            set { mLCtype = value; }
        }

        string payertype = string.Empty;
        public string Payertype
        {
            get { return payertype; }
            set { payertype = value; }
        }


        public string WardName
        {
            get { return wardName; }
            set { wardName = value; }
        }

        public string RefphysicianName
        {
            get { return refphysicianName; }
            set { refphysicianName = value; }
        }

        public int ReferingPhysicianID
        {
            get { return referingPhysicianID; }
            set { referingPhysicianID = value; }
        }

        public int WardID
        {
            get { return wardID; }
            set { wardID = value; }
        }
        public string IsDuePaidBill
        {
            get { return isDuePaidBill; }
            set { isDuePaidBill = value; }

        }

        public string PaidCurrency
        {
            get { return paidCurrency; }
            set { paidCurrency = value; }

        }
        public decimal PaidCurrencyAmount
        {
            get { return paidCurrencyAmount; }
            set { paidCurrencyAmount = value; }

        }
        public decimal DepositUsed
        {
            get { return depositUsed; }
            set { depositUsed = value; }

        }



        public string IsCreditBill
        {
            get { return isCreditBill; }
            set { isCreditBill = value; }
        }

        public decimal CreditDue
        {
            get { return creditDue; }
            set { creditDue = value; }

        }
        public string Period
        {
            get
            {
                return period;
            }
            set
            {
                period = value;
            }
        }
        public long OpeningBalance
        {
            get
            {
                return openingBal;
            }
            set
            {
                openingBal = value;
            }
        }
        public long AdmitedPatient
        {
            get
            {
                return admitedpatient;
            }
            set
            {
                admitedpatient = value;
            }
        }
        public long DischargedPatient
        {
            get
            {
                return dischargedpatient;
            }
            set
            {
                dischargedpatient = value;
            }
        }
        public long ClosingBalance
        {
            get
            {
                return closingbalance;
            }
            set
            {
                closingbalance = value;
            }
        }
        public string ReceiptNo
        {
            get { return receiptNo; }
            set { receiptNo = value; }

        }
        public string DueChartNo
        {
            get { return dueChartNo; }
            set { dueChartNo = value; }

        }
        public decimal MedicalAmt
        {
            get { return medicalamt; }
            set { medicalamt = value; }

        }
        public decimal NonMedicalAmt
        {
            get { return nonmedicalamt; }
            set { nonmedicalamt = value; }

        }
        public decimal PreAuthAmt
        {
            get { return preauthamt; }
            set { preauthamt = value; }

        }
        public decimal AdvancePaid
        {
            get { return advancepaid; }
            set { advancepaid = value; }

        }
        public decimal AmtReceivedServiceCharge
        {
            get { return amtreceivedservicecharge; }
            set { amtreceivedservicecharge = value; }

        }
        public decimal AdvPaidServiceCharge
        {
            get { return advpaidservicecharge; }
            set { advpaidservicecharge = value; }

        }
        public decimal RoundOff
        {
            get { return roundoff; }
            set { roundoff = value; }

        }
        public decimal CoPercent
        {
            get { return copercent; }
            set { copercent = value; }

        }
        public decimal CoPayment
        {
            get { return copayment; }
            set { copayment = value; }

        }
        public string IsTPAPatient
        {
            get { return isTPApatient; }
            set { isTPApatient = value; }

        }
        public string CreditorDebitCard
        {
            get { return creditordebitcard; }
            set { creditordebitcard = value; }

        }
        public string VisitState
        {
            get { return visitstate; }
            set { visitstate = value; }

        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        private string subCategory = string.Empty;

        public string SubCategory
        {
            get { return subCategory; }
            set { subCategory = value; }
        }
        public decimal ActualBilled
        {
            get { return actualBilled; }
            set { actualBilled = value; }
        }


        public decimal StdBillAmount
        {
            get { return stdBillAmount; }
            set { stdBillAmount = value; }
        }

        public int NoOfTests
        {
            get { return noOfTests; }
            set { noOfTests = value; }
        }

        public int NoOfCases
        {
            get { return noOfCases; }
            set { noOfCases = value; }
        }
        public string RefundNo
        {
            get { return refundNo; }
            set { refundNo = value; }
        }
        public decimal PRMReceived
        {
            get { return prmReceived; }
            set { prmReceived = value; }
        }
        public decimal HOSReceived
        {
            get { return hosReceived; }
            set { hosReceived = value; }
        }
        public decimal PRMRefund
        {
            get { return prmRefund; }
            set { prmRefund = value; }
        }
        public decimal HOSRefund
        {
            get { return hosRefund; }
            set { hosRefund = value; }
        }
        public long OrgID
        {
            get { return orgId; }
            set { orgId = value; }
        }
        public string OrganisationName
        {
            get { return organisationName; }
            set { organisationName = value; }
        }
        public string ClientName
        {
            get { return clientName; }
            set { clientName = value; }
        }
        public long ClientID
        {
            get { return clientID; }
            set { clientID = value; }
        }
        public decimal Coupon
        {
            get { return coupon; }
            set { coupon = value; }
        }     

        public string ClientTypeName
        {
            get { return clientTypeName; }
            set { clientTypeName = value; }
        }
        public int ClientTypeID
        {
            get { return clientTypeID; }
            set { clientTypeID = value; }
        }
        public string DiscountReason
        {
            get { return discountReason; }
            set { discountReason = value; }
        }
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public string Userwise
        {
            get { return userWise; }
            set { userWise = value; }
        }
        public string Qualification
        {
            get { return qualification; }
            set { qualification = value; }
        }
        public string PhysicianCode
        {
            get { return physicianCode; }
            set { physicianCode = value; }
        }
        public string EmailID
        {
            get { return emailID; }
            set { emailID = value; }






        }
        public decimal WriteOffAmount
        {
            get { return writeOffAmount; }
            set { writeOffAmount = value; }
        }
        public decimal RefundAmt
        {
            get { return refundAmt; }
            set { refundAmt = value; }
        } 

        public string InvestigationName
        {
            get { return Investigationname; }
            set { Investigationname = value; }
        }

     

        public DateTime RegistrationDate
        {
            get { return Registrationdate; }
            set { Registrationdate = value; }
        }

        public DateTime SampleCollectedDate
        {
            get { return SampleCollecteddate; }
            set { SampleCollecteddate = value; }
        }

        public DateTime ApprovedAt
        {
            get { return Approvedat; }
            set { Approvedat = value; }
        }

        public DateTime DespatchDate
        {
            get { return Despatchdate; }
            set { Despatchdate = value; }
        }     

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public string ReceiverName
        {
            get { return Receivername; }
            set { Receivername = value; }
        }
        public string IsRefunded
        {
            get { return isRefunded; }
            set { isRefunded = value; }
        }

        public int PatientCount
        {
            get { return patientcount; }
            set { patientcount = value; }
        }
    }

        #endregion
}