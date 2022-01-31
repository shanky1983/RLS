using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class ClaimEntities
    {
        //General Map

        long finalBillID = 0;
        public long FinalBillID
        {
            get { return finalBillID; }
            set { finalBillID = value; }
        }

        long pID = 0;
        public long PID
        {
            get { return pID; }
            set { pID = value; }
        }

        long visitID = 0;
        public long VisitID
        {
            get { return visitID; }
            set { visitID = value; }
        }

        string billNumber = string.Empty;
        public string BillNumber
        {
            get { return billNumber; }
            set { billNumber = value; }
        }

        string patientNumber = string.Empty;
        public string PatientNumber
        {
            get { return patientNumber; }
            set { patientNumber = value; }
        }

        int clientID = 0;
        public int ClientID
        {
            get { return clientID; }
            set { clientID = value; }
        }

        string clientName = string.Empty;
        public string ClientName
        {
            get { return clientName; }
            set { clientName = value; }
        }

        string senderID = string.Empty;
        public string SenderID
        {
            get { return senderID; }
            set { senderID = value; }
        }
        string receiverID = string.Empty;
        public string ReceiverID
        {
            get { return receiverID; }
            set { receiverID = value; }
        }
        string transactionDate = string.Empty;
        public string TransactionDate
        {
            get { return transactionDate; }
            set { transactionDate = value; }
        }
        string recordCount = string.Empty;
        public string RecordCount
        {
            get { return recordCount; }
            set { recordCount = value; }
        }
        string dispositionFlag = string.Empty;
        public string DispositionFlag
        {
            get { return dispositionFlag; }
            set { dispositionFlag = value; }
        }




        string claimID = string.Empty;
        public string ClaimID
        {
            get { return claimID; }
            set { claimID = value; }
        }
        string memberID = string.Empty;
        public string MemberID
        {
            get { return memberID; }
            set { memberID = value; }
        }
        string payerID = string.Empty;
        public string PayerID
        {
            get { return payerID; }
            set { payerID = value; }
        }
        string providerID = string.Empty;
        public string ProviderID
        {
            get { return providerID; }
            set { providerID = value; }
        }
        string emiratesIDNumber = string.Empty;
        public string EmiratesIDNumber
        {
            get { return emiratesIDNumber; }
            set { emiratesIDNumber = value; }
        }
        string gross = string.Empty;
        public string Gross
        {
            get { return gross; }
            set { gross = value; }
        }
        string patientShare = string.Empty;
        public string PatientShare
        {
            get { return patientShare; }
            set { patientShare = value; }
        }
        string net = string.Empty;
        public string Net
        {
            get { return net; }
            set { net = value; }
        }



        string facilityID = string.Empty;
        public string FacilityID
        {
            get { return facilityID; }
            set { facilityID = value; }
        }
        string encounterType = string.Empty;
        public string EncounterType
        {
            get { return encounterType; }
            set { encounterType = value; }
        }
        string patientID = string.Empty;
        public string PatientID
        {
            get { return patientID; }
            set { patientID = value; }
        }
        string encounterstart = string.Empty;
        public string EncounterStart
        {
            get { return encounterstart; }
            set { encounterstart = value; }
        }
        string encounterend = string.Empty;
        public string EncounterEnd
        {
            get { return encounterend; }
            set { encounterend = value; }
        }
        string startType = string.Empty;
        public string StartType
        {
            get { return startType; }
            set { startType = value; }
        }
        string endType = string.Empty;
        public string EndType
        {
            get { return endType; }
            set { endType = value; }
        }



        string diagnosisType = string.Empty;
        public string DiagnosisType
        {
            get { return diagnosisType; }
            set { diagnosisType = value; }
        }
        string diagnosisCode = string.Empty;
        public string DiagnosisCode
        {
            get { return diagnosisCode; }
            set { diagnosisCode = value; }
        }



        string activityID = string.Empty;
        public string ActivityID
        {
            get { return activityID; }
            set { activityID = value; }
        }
        string activityStart = string.Empty;
        public string ActivityStart
        {
            get { return activityStart; }
            set { activityStart = value; }
        }
        string activityType = string.Empty;
        public string ActivityType
        {
            get { return activityType; }
            set { activityType = value; }
        }
        string activityCode = string.Empty;
        public string ActivityCode
        {
            get { return activityCode; }
            set { activityCode = value; }
        }
        string quantity = string.Empty;
        public string Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        string activityNet = string.Empty;
        public string ActivityNet
        {
            get { return activityNet; }
            set { activityNet = value; }
        }
        string clinician = string.Empty;
        public string Clinician
        {
            get { return clinician; }
            set { clinician = value; }
        }


        string observationType = string.Empty;
        public string ObservationType
        {
            get { return observationType; }
            set { observationType = value; }
        }
        string observationCode = string.Empty;
        public string ObservationCode
        {
            get { return observationCode; }
            set { observationCode = value; }
        }
        string observationValue = string.Empty;
        public string ObservationValue
        {
            get { return observationValue; }
            set { observationValue = value; }
        }
        string valueType = string.Empty;
        public string ValueType
        {
            get { return valueType; }
            set { valueType = value; }
        }

        string feeType = string.Empty;
        public string FeeType
        {
            get { return feeType; }
            set { feeType = value; }
        }

        long billingDetailsID = 0;
        public long BillingDetailsID
        {
            get { return billingDetailsID; }
            set { billingDetailsID = value; }
        }

        string claimStatus = string.Empty;
        public string ClaimStatus
        {
            get { return claimStatus; }
            set { claimStatus = value; }
        }

        string resubmissionType = string.Empty;
        public string ReSubmissionType
        {
            get { return resubmissionType; }
            set { resubmissionType = value; }
        }

        string comments = string.Empty;
        public string Comments
        {
            get { return comments; }
            set { comments = value; }
        }

        string addtionvalue = string.Empty;
        public string Addtionvalue
        {
            get { return addtionvalue; }
            set { addtionvalue = value; }
        }

    }
}
