using System;
using System.Collections.Generic;

using System.Text;

namespace Attune.Podium.BusinessEntities
{
  public  class VisitSheetDetailsQuotation
    {
        #region Fields        
        private long investiagtionid = 0;
        private string investiagtionname = string.Empty;
        private string sampleid = string.Empty;
        private string sampletype = string.Empty;
        private string sampledescrip = string.Empty;
        private int sampleContainer = 0;
        private string fieldtest = string.Empty;
        private string temperature = string.Empty;
        private string location = string.Empty;
        private string visitnumber = string.Empty;
        private string testnames = string.Empty;
        private string containercount = string.Empty;
        private string investigationnamelist = string.Empty;
        private string vendor = string.Empty;
        private string quality = string.Empty;


        #endregion


        public string VisitNumber
        {
            get { return visitnumber; }
            set { visitnumber = value; }
        }
        public string InvestigationNameList
        {
            get { return investigationnamelist; }
            set { investigationnamelist = value; }
        }
        public string ContainerCount
        {
            get { return containercount; }
            set { containercount = value; }
        }
        public string TestNames
        {
            get { return testnames; }
            set { testnames = value; }
        }

        public long InvestiagtionID
        {
            get { return investiagtionid; }
            set { investiagtionid = value; }
        }
        public string InvestiagtionName
        {
            get { return investiagtionname; }
            set { investiagtionname = value; }
        }
        public string SampleID
        {
            get { return sampleid; }
            set { sampleid = value; }
        }
        public string SampleType
        {
            get { return sampletype; }
            set { sampletype = value; }
        }
        public string SampleDescrip
        {
            get { return sampledescrip; }
            set { sampledescrip = value; }
        }
        public int SampleCount
        {
            get { return sampleContainer; }
            set { sampleContainer = value; }
        }
        public string FieldTest
        {
            get { return fieldtest; }
            set { fieldtest = value; }
        }
        public string Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }
        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public string Vendor
        {
            get { return vendor; }
            set { vendor = value; }
        }

        /// <summary>
        /// Gets or sets the Quality value.
        /// </summary>
        public string Quality
        {
            get { return quality; }
            set { quality = value; }
        }
  
  
  
  
  }
}
