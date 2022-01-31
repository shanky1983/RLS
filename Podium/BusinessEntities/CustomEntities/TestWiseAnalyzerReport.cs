using System;
using System.Collections.Generic;

using System.Text;

namespace Attune.Podium.BusinessEntities.CustomEntities
{
    [Serializable()]
    public class TestWiseAnalyzerReport
    {
        int Reporttype;
        DateTime fDate;
        DateTime tDate;
        int IntOrgid;
        string OrgNm;
        string Analyzernm;
        string Clientlocation;
        string Testnm;
        int count;
        string Devicecode;
        string Orgname;
        string visitid;
        string Patientname;
        string barcode;
        string status;
        string investigationid;
        string patientid;
        public string OrgName
        {
            get { return Orgname; }
            set { Orgname = value; }
        }
        public int ReportType
        {
            get { return Reporttype; }
            set { Reporttype = value; }
        }
        public DateTime Date
        {
            get { return fDate; }
            set { fDate = value; }
        }

        public DateTime CreatedOn
        {
            get { return tDate; }
            set { tDate = value; }
        }
        public int OrgID
        {
            get { return IntOrgid; }
            set { IntOrgid = value; }
        }
        public string Locationname
        {
            get { return Clientlocation; }
            set { Clientlocation = value; }
        }
        public string Testname
        {
            get { return Testnm; }
            set { Testnm = value; }
        }
        public string TestName
        {
            get { return Testnm; }
            set { Testnm = value; }
        }
        public string Analyzername
        {
            get { return Analyzernm; }
            set { Analyzernm = value; }
        }
        public int Count
        {
            get { return count; }
            set { count=value;}
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public string BarcodeNumber
        {
            get { return barcode; }
            set { barcode = value; }
        }
        public string PatientName
        {
            get { return Patientname; }
            set { Patientname = value; }
        }
        public string Patientid
        {
            get { return patientid; }
            set { patientid = value; }
        }
        public string VisitId
        {
            get { return visitid; }
            set { visitid = value; }
        }
    }
}
