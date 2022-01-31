using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
   public class ClientBatchMasterDetails
    {
       private string reportstatus = String.Empty;
       private string filepath = String.Empty;
       private string clientName = String.Empty;
       private string clientcode = String.Empty;
       private string batchid = String.Empty;
       private DateTime fromdate = DateTime.MaxValue;
       private DateTime todate = DateTime.MaxValue;
       private int clientid=0;
       private int testnameid = 0;
       private string testcode = String.Empty;
       private int orgid = 0;


       public string ReportStatus
       {
           get { return reportstatus; }
           set { reportstatus = value; }

       }

       public string FilePath
       {
           get { return filepath; }
           set { filepath = value; }

       }

       public string ClientCode
       {
           get { return clientcode; }
           set { clientcode = value; }
       }
       /// <summary>
       /// Gets or sets the OrgID value.
       /// </summary>
       public int OrgID
       {
           get { return orgid; }
           set { orgid = value; }
       }
       public string ClientName
       {
           get { return clientName; }
           set { clientName = value; }

       }
       public string Batchid
       {
           get { return batchid; }
           set { batchid = value; }
       }
       public DateTime Fromdate
       {
           get { return fromdate; }
           set { fromdate = value; }
       }
       public DateTime Todate
       {
           get { return todate; }
           set { todate = value; }
       }
       public int Clientid
       {
           get { return clientid; }
           set { clientid = value; }
       }
       public string TestCode
       {
           get { return testcode; }
           set { testcode = value; }
       }
       public int Testnameid
       {
           get { return testnameid; }
           set { testnameid = value; }
       }
       private string _registeredCount = String.Empty;
       public string RegisteredCount
       {
           get { return _registeredCount; }
           set { _registeredCount = value; }
       }
 }
}
