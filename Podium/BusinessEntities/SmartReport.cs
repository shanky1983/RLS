using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
  

   public class SmartReport
   {
       private string entityname = string.Empty;
       public string entityName
       {
           get { return entityname; }
           set { entityname = value; }
       }
       private long entityid = 0;
       public long entityId
       {
           get { return entityid; }
           set { entityid = value; }
       }
       private string externalentityId = string.Empty;
       public string externalEntityId
       {
           get { return externalentityId; }
           set { externalentityId = value; }
       }
       private string entitylocationCode = string.Empty;
       public string entityLocationCode
       {
           get { return entitylocationCode; }
           set { entitylocationCode = value; }
       }
       private string transactionid = string.Empty;
       public string transactionId
       {
           get { return transactionid; }
           set { transactionid = value; }
       }
       private string externalcustomData = string.Empty;
       public string externalCustomData
       {
           get { return externalcustomData; }
           set { externalcustomData = value; }
       }
       private string Title = string.Empty;
       public string title
       {
           get { return Title; }
           set { Title = value; }
       }
       public List<documentAttachments> documentAttachmentsVO { get; set; }
       public personDetails personDetailsVO { get; set; }

       //public List<trends> trendsList { get; set; }
       //public List<summaryNormal> summaryNormal { get; set; }
       //public List<summaryAbnormal> summaryAbnormal { get; set; }
       public List<personResults> personResultsVOList { get; set; } 
   }

   public class documentAttachments
   {
       public string externalURL { get; set; }
       public string fileName { get; set; }
       public byte[] fileBytesContent { get; set; }
       public int fileSize { get; set; }
       public string fileMimeType { get; set; }
   }

   public class personDetails
    {
     /*  private string entityname=string.Empty;
     public string entityName  
     {
         get{return entityname;}
         set{entityname=value;}
     }
       private long entityid =0;
     public long entityId 
     {
         get{return entityid;}
         set{entityid=value;}
     }
       private long externalentityId=0;
     public long externalEntityId 
     {
         get{return externalentityId;}
         set{externalentityId=value;}
     }
       private string enitylocationCode=string.Empty;
     public string enityLocationCode
     {
         get{return enitylocationCode;}
         set{enitylocationCode=value;}
     }
       private long transactionid=0;
     public long transactionId 
     {
         get{return transactionid;}
         set{transactionid=value;}
     }
       private string externalcustomData=string.Empty;
     public string externalCustomData 
     {
         get{return externalcustomData;}
         set{externalcustomData=value;}
     }
       private string Title=string.Empty;
     public string title
     {
         get{return Title;}
         set{Title=value;}
     }*/
       private string Mrn=string.Empty;
     public string mrn 
     {
        get{return Mrn;}
        set{Mrn=value;}
     }
       private string personname=string.Empty;
     public string personName
     {
         get{return personname;}
         set{personname=value;}
     }
     private string Mobile=string.Empty;
     public string mobile
     {
         get{return Mobile;}
         set{Mobile=value;}
     } 
     private string Gender=string.Empty;
     public string gender
     {
         get{return Gender;}
         set{Gender=value;}
     } 
     private string Dob=string.Empty;
     public string dob
     {
         get{return Dob;}
         set{Dob=value;}
     } 
     private string Age;
     public string age
     {
         get{return Age;}
         set{Age=value;}
     } 
     private string VisitOn;
     public string visitOn
     {
         get{return VisitOn;}
         set{VisitOn=value;}
     } 
      private string CollectedOn;
     public string collectedOn
     {
         get{return CollectedOn;}
         set{CollectedOn=value;}
     }
     private string ReportedOn;
     public string reportedOn
     {
         get{return ReportedOn;}
         set{ReportedOn=value;}
     } 
     private string Email;
     public string email
     {
         get{return Email;}
         set{Email=value;}
     } 
     private string VisitNo;
     public string visitNo
     {
         get{return VisitNo;}
         set{VisitNo=value;}
     } 
     private string VisitType;
     public string visitType
     {
         get{return VisitType;}
         set{VisitType=value;}
     } 
     private string ReferingPhysicianName;
     public string referingPhysicianName
     {
         get{return ReferingPhysicianName;}
         set{ReferingPhysicianName=value;}
     } 
      private string SubClientName=string.Empty;
     public string subClientName
     {
         get{return SubClientName;}
         set{SubClientName=value;}
     } 
      private string Address=string.Empty;
     public string address
     {
         get{return Address;}
         set{Address=value;}
     } 
     private string PostalCode=string.Empty;
     public string postalCode
     {
         get{return PostalCode;}
         set{PostalCode=value;}
     } 
     private string ReportPath=string.Empty;
     public string reportPath
     {
         get{return ReportPath;}
         set{ReportPath=value;}
     } 
     private string filename=string.Empty;
     public string fileName
     {
         get{return filename;}
         set{filename=value;}
     }
     private long patientVisitId = -1;
     public long PatientVisitId
     {
         get { return patientVisitId; }
         set { patientVisitId = value; }
     }
    }
   public class trends
    {

       private string  VisitDate;

        private string nAME = string.Empty;


        private string values = string.Empty;
        private string referencerange = string.Empty;
        private string UOMCode = string.Empty;
        private string investigationId = "0";
        private string patientVisitId = "";
        private string SequenceNo = "";


        public string visitDate
        {
            get { return VisitDate; }
            set { VisitDate = value; }
		}

        public string name {
			get { return nAME; }
			set { nAME = value; }
		}


        public string value {
			get { return values; }
			set { values = value; }
		}
        public string referenceRange
        {
			get { return referencerange; }
            set { referencerange = value; }
		}
        public string uOMCode
        {
			get { return UOMCode; }
            set { UOMCode = value; }
		}

        public string investigationID
        {
			get { return investigationId; }
            set { investigationId = value; }
		}
        public string patientVisitid
        {
			get { return patientVisitId; }
            set { patientVisitId = value; }
		}

        public string sequenceNo
        {
			get { return SequenceNo; }
            set { SequenceNo = value; }
		}
    }


    public class summaryNormal
    {

        private long iD = 0;

        private string name = string.Empty;


           public long ID  {
			get { return iD; }
			set { iD = value; }
		}

        public string Name  {
			get { return name; }
			set { name = value; }
		}




    }

    public class summaryAbnormal
    {



        private string nAME = string.Empty;

        private string result = string.Empty;

        private long investigationID = 0;

        private string units = string.Empty;

        private string referenceRange = string.Empty;

        private string Grpid = string.Empty;

        public string NAME  {
			get { return nAME; }
			set { nAME = value; }
		}

        public string Result  {
			get { return result; }
			set { result = value; }
		}

        public long InvestigationID
        {
            get { return investigationID; }
            set { investigationID = value; }
        }

        public string Units
        {
            get { return units; }
            set { units = value; }
        }
         public string ReferenceRange  {
			get { return referenceRange; }
			set { referenceRange = value; }
		
        }
         public string grpid
         {
             get { return Grpid; }
             set { Grpid = value; }

         }
    }

    public class personResults
    {
        public string investigationID { get; set; }
        public string investigationName {get;set;}
        public string sampleName {get;set;}
        public string result { get; set; }
        public string resultStatus { get; set; }
        public string units { get; set; }
        public string approvedBy { get; set; }
        public string approverName { get; set; }
        public string interpretationNotes { get; set; }
        public string medicalRemarks { get; set; }
        public string profileId { get; set; }
        public string profileName { get; set; }
        public long subGroupId { get; set; }
        public string referenceRange { get; set; }
        public List<trends> trendsVOList { get; set; }
       /* private long investigationid = 0;
        private string investigationname = string.Empty;
        private string samplename = string.Empty;
        private string Result = string.Empty;
        private string resultstatus = string.Empty;
        private string Units = string.Empty;
        private long approvedby = -1;
        private string approvername = string.Empty;
        private string interpretationnotes = string.Empty;
        private string medicalremarks = string.Empty;
        private long profileid = -1;
        private string profilename = string.Empty;
        private long subGroupid = -1;
        private string referencerange = string.Empty;*/

    }
    public class personInvResults
    {
        public string investigationID { get; set; }
        public string investigationName { get; set; }
        public string sampleName { get; set; }
        public string result { get; set; }
        public string resultStatus { get; set; }
        public string units { get; set; }
        public string approvedBy { get; set; }
        public string approverName { get; set; }
        public string interpretationNotes { get; set; }
        public string medicalRemarks { get; set; }
        public string profileId { get; set; }
        public string profileName { get; set; }
        public long subGroupId { get; set; }
        public string referenceRange { get; set; } 
    }
}
