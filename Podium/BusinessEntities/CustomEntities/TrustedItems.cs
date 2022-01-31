using System;
using System.Collections.Generic; 
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class TrustedItems
    {
        #region Fields

        private long iD = -1; 
        private string name = String.Empty;  
        private string roleName = String.Empty; 
        private long roleID = -1;  
        private string groupName = String.Empty; 
        private string type = String.Empty;
        private string typeName = String.Empty; 
        private long typeID = -1;

        

        #endregion


        #region Properties

        public string TypeName
        {
            get { return typeName; }
            set { typeName = value; }
        }

        public long TypeID
        {
            get { return typeID; }
            set { typeID = value; }
        }  
        public long ID
        {
            get { return iD; }
            set { iD = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string RoleName
        {
            get { return roleName; }
            set { roleName = value; }
        }

        public long RoleID
        {
            get { return roleID; }
            set { roleID = value; }
        }

        public string GroupName
        {
            get { return groupName; }
            set { groupName = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        
        #endregion
    }
}
