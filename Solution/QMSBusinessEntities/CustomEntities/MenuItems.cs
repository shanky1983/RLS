using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class MenuItem
    {
        #region Fields
        private int menuID;
        private string menuName;
        private string menuURL;
        private int parentID;

        #endregion
        
        
        #region Properties
        /// <summary>
        /// Gets or sets the mainMenu value.
        /// </summary>
        public int MenuID
        {
            get { return menuID; }
            set { menuID = value; }
        }

        /// <summary>
        /// Gets or sets the MenuURL value.
        /// </summary>
        public string MenuURL
        {
            get { return menuURL; }
            set { menuURL = value; }
        }


          /// <summary>
        /// Gets or sets the MenuURL value.
        /// </summary>
        public string MenuName
        {
            get { return menuName; }
            set { menuName = value; }
        }

        /// <summary>
        /// Gets or sets the SubMenu value.
        /// </summary>
        public int ParentID
        {
            get { return parentID; }
            set { parentID = value; }
        }

        
        #endregion
    }
}
