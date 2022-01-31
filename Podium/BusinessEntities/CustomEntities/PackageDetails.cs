using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities.CustomEntities
{
    public class PackageDetails
    {
        #region Fields

        private string testcode = String.Empty;
        private string testname = String.Empty;
        private string status = String.Empty;
        private string type = String.Empty;
        private string printSeparately = String.Empty;
        private int sequenceno;
        

        #endregion


        #region Properties

        public string TestCode
        {
            get { return testcode; }
            set { testcode = value; }
        }
        public string TestName
        {
            get { return testname; }
            set { testname = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string PrintSeparately
        {
            get { return printSeparately; }
            set { printSeparately = value; }
        }
        public int SequenceNo
        {
            get { return sequenceno; }
            set { sequenceno = value; }
        }
        #endregion

    }
}