using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
   public class PatientHistoStatusDetails
    {
       private long patientVisitID = 0;
       
       private DateTime completionTime = DateTime.MaxValue;
       
       private string barcodeNumber = string.Empty;
       private string status = string.Empty;
       private string visitNumber = string.Empty;
       private string patientNumber = string.Empty;
       private string histopathNumber = string.Empty;
       private string patientName = string.Empty;
       private long invID = 0;
    //   private string sampleName = string.Empty;
       private long sampleContainerID = 0;
       private int sampleCode = 0;
       private string tissueType = string.Empty;
       private string fromDate = "";
       private string toDate = "";
       private string blockNo = string.Empty;
       private string blockType = string.Empty;
       private string slideNo = string.Empty;
       private string slideType = string.Empty;
       private string stainType = string.Empty;


       public string BlockNo
       {
           get { return blockNo; }
           set { blockNo = value; }
       }
       public string BlockType
       {
           get { return blockType; }
           set { blockType = value; }
       }
       public string SlideType
       {
           get { return slideType; }
           set { slideType = value; }
       }

       public string StainType
       {
           get { return stainType; }
           set { stainType = value; }
       }


       public string SlideNo
       {
           get { return slideNo; }
           set { slideNo = value; }
       }

       public string FromDate
       {
           get { return fromDate; }
           set { fromDate = value; }
       }
       public string ToDate
       {
           get { return toDate; }
           set { toDate = value; }
       }
       public string TissueType
       {
           get { return tissueType; }
           set { tissueType = value; }
       }

       public int SampleCode
       {
           get { return sampleCode; }
           set { sampleCode = value; }
       }

       public long SampleContainerID
       {
           get { return sampleContainerID; }
           set { sampleContainerID = value; }
       }
       //public string SampleName
       //{
       //    get { return sampleName; }
       //    set { sampleName = value; }
       //}
       public long InvID
       {
           get { return invID; }
           set { invID = value; }
       }
       public string PatientName
       {
           get { return patientName; }
           set { patientName = value; }
       }
       public string VisitNumber
       {
           get { return visitNumber; }
           set { visitNumber = value; }
       }
       public string HistopathNumber
       {
           get { return histopathNumber; }
           set { histopathNumber = value; }
       }
       public string PatientNumber
       {
           get { return patientNumber; }
           set { patientNumber = value; }
       }
       public long PatientVisitID
       {
           get { return patientVisitID; }
           set { patientVisitID = value; }
       }
       public string BarcodeNumber
       {
           get { return barcodeNumber; }
           set { barcodeNumber = value; }
       }
       public DateTime CompletionTime
       {
           get { return completionTime; }
           set { completionTime = value; }
       }
       public string Status
       {
           get { return status; }
           set { status = value; }
       }


    }
}
