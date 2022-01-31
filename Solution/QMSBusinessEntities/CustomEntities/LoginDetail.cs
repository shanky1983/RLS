using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class LoginDetail
    {
        private long loginID = -1;
        private long roleID = -1;
        private long orgid = 0;
        private string dummyString = string.Empty;


        public long LoginID
        {
            get { return loginID; }
            set { loginID = value; }
        }       
        public long RoleID
        {
            get { return roleID; }
            set { roleID = value; }
        }  
        public long Orgid
        {
            get { return orgid; }
            set { orgid = value; }
        }
        public string DummyString
        {
            get { return dummyString; }
            set { dummyString = value; }
        }
         
    }
}
