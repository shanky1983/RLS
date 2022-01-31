using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
  public  class ClientAttributesKeyFields
    {
        private string key = string.Empty;
        private string valuedata = string.Empty;
        private long referenceid = 0;
        private string referencetype = string.Empty;
        private string testtype = string.Empty;
        private string testname = string.Empty;


        public string Key
        {
            get { return key; }
            set { key = value; }
        }


        public string Valuedata
        {
            get { return valuedata; }
            set { valuedata = value; }
        }
        public long ReferenceID
        {
            get { return referenceid; }
            set { referenceid = value; }
        }
        public string ReferenceType
        {
            get { return referencetype; }
            set { referencetype = value; }
        }
        public string TestType
        {
            get { return testtype; }
            set { testtype = value; }
        }
        public string TestName
        {
            get { return testname; }
            set { testname = value; }
        }
    }
}
