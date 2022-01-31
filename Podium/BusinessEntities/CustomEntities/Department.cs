using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class Department
    {
        #region Fields
        private long deptID = 0;
        private string deptName = String.Empty;
        private int orgID = 0;        
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the DeptID value.
        /// </summary>
        public long DeptID
        {
            get { return deptID; }
            set { deptID = value; }
        }
        /// <summary>
        /// Gets or sets the DeptName value.
        /// </summary>
        public string DeptName
        {
            get { return deptName; }
            set { deptName = value; }
        }
        /// <summary>
        /// Gets or sets the OrgID value.
        /// </summary>
        public int OrgID
        {
            get { return orgID; }
            set { orgID = value; }
        }
        /// <summary>
        /// Gets or sets the OrgAddressID value.
        /// </summary>
        long _orgaddressid;
        public long OrgAddressID
        {
            get { return _orgaddressid; }
            set { _orgaddressid = value; }
        }

        #endregion
    }
}
