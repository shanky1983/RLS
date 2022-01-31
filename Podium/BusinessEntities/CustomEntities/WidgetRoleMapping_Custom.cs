using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class WidgetRoleMapping_Custom
    {
        #region Fields
        private long roleID = 0;
        private long _loginID = 0;
        private long orgID = 0;
        private long wID = 0;
        private long _detailedID = 0;
        private string _wCode = String.Empty;
        private string _wGCode = String.Empty;
        private string _active = String.Empty;
        #endregion

        #region Properties

        public long RoleID
        {
            get { return roleID; }
            set { roleID = value; }
        }

        public long LoginID
        {
            get { return _loginID; }
            set { _loginID = value; }
        }

        public long OrgID
        {
            get { return orgID; }
            set { orgID = value; }
        }

        public long WID
        {
            get { return wID; }
            set { wID = value; }
        }

        public long DetailedID
        {
            get { return _detailedID; }
            set { _detailedID = value; }
        }

        public string WCode
        {
            get { return _wCode; }
            set { _wCode = value; }
        }

        public string WGCode
        {
            get { return _wGCode; }
            set { _wGCode = value; }
        }

        public string Active
        {
            get { return _active; }
            set { _active = value; }
        }


        #endregion
    }
}
