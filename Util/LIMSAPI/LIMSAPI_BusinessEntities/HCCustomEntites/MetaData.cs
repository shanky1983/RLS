using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class MetaData
    {
        #region Fields

        private int metaDataID = 0;
        private string domain = String.Empty;
        private string code = String.Empty;
        private string displayText = String.Empty;
        private string langCode = String.Empty;
        private long parentID = 0;
        private int seqNo = 0;
        private long createdBy = 0;
        private DateTime createdAt = DateTime.MaxValue;
        private long modifiedBy = 0;
        private DateTime modifiedAt = DateTime.MaxValue;

        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the MetaDataID value.
        /// </summary>
        public int MetaDataID
        {
            get { return metaDataID; }
            set { metaDataID = value; }
        }

        /// <summary>
        /// Gets or sets the Domain value.
        /// </summary>
        public string Domain
        {
            get { return domain; }
            set { domain = value; }
        }

        /// <summary>
        /// Gets or sets the Code value.
        /// </summary>
        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        /// <summary>
        /// Gets or sets the DisplayText value.
        /// </summary>
        public string DisplayText
        {
            get { return displayText; }
            set { displayText = value; }
        }

        /// <summary>
        /// Gets or sets the LangCode value.
        /// </summary>
        public string LangCode
        {
            get { return langCode; }
            set { langCode = value; }
        }

        /// <summary>
        /// Gets or sets the ParentID value.
        /// </summary>
        public long ParentID
        {
            get { return parentID; }
            set { parentID = value; }
        }

        /// <summary>
        /// Gets or sets the SeqNo value.
        /// </summary>
        public int SeqNo
        {
            get { return seqNo; }
            set { seqNo = value; }
        }

        /// <summary>
        /// Gets or sets the CreatedBy value.
        /// </summary>
        public long CreatedBy
        {
            get { return createdBy; }
            set { createdBy = value; }
        }

        /// <summary>
        /// Gets or sets the CreatedAt value.
        /// </summary>
        public DateTime CreatedAt
        {
            get { return createdAt; }
            set { createdAt = value; }
        }

        /// <summary>
        /// Gets or sets the ModifiedBy value.
        /// </summary>
        public long ModifiedBy
        {
            get { return modifiedBy; }
            set { modifiedBy = value; }
        }

        /// <summary>
        /// Gets or sets the ModifiedAt value.
        /// </summary>
        public DateTime ModifiedAt
        {
            get { return modifiedAt; }
            set { modifiedAt = value; }
        }

        /// <summary>
        /// Gets or sets the OrgID value.
        /// </summary>
        private long _orgID = 0;
        public long OrgID
        {
            get { return _orgID; }
            set { _orgID = value; }
        }

        /// <summary>
        /// Gets or sets the Name value.
        /// </summary>
        private string _name = String.Empty;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// Gets or sets the LangName value.
        /// </summary>
        private string _langName = String.Empty;
        public string LangName
        {
            get { return _langName; }
            set { _langName = value; }
        }


        #endregion
    }
}
