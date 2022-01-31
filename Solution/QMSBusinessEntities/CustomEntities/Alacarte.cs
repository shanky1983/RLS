using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class Alacarte
    {
        #region Fields
        private int menuID;
        private string menuName;
        private string menuURL;
        private int parentID;
        private Int64 pageID;
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

        /// <summary>
        /// Gets or sets the PageID value.
        /// </summary>
        public Int64 PageID
        {
            get { return pageID; }
            set { pageID = value; }
        }

        private string _headerText;

        public string HeaderText
        {
            get { return _headerText; }
            set { _headerText = value; }
        }

        private string _headerCode;

        public string HeaderCode
        {
            get { return _headerCode; }
            set { _headerCode = value; }
        }

        private string _languageCode;

        public string LanguageCode
        {
            get { return _languageCode; }
            set { _languageCode = value; }
        }

        private long _orgId;

        public long OrgId
        {
            get { return _orgId; }
            set { _orgId = value; }
        }

        private long _roleID;

        public long RoleID
        {
            get { return _roleID; }
            set { _roleID = value; }
        }
        private List<Alacarte> _subMenu;

        public List<Alacarte> SubMenu
        {
            get { return _subMenu; }
            set { _subMenu = value; }
        }

        private string _cssClass;

        public string CssClass
        {
            get { return _cssClass; }
            set { _cssClass = value; }
        }

        #endregion
    }
}
