using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class QuestionayTemplateDetails
    {
        #region Fields

        private long templateID = 0;
        private long orgID = 0;
        private long iD = 0;
        private long createdBy = 0;
        private DateTime createdAt = DateTime.MaxValue;
        private long modifiedBy = 0;
        private DateTime modifiedAt = DateTime.MaxValue;
        private string templateName = String.Empty;
        private string templateText = String.Empty;
        private string invType = String.Empty;
        private string investigation = String.Empty;


        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the ActionID value.
        /// </summary>
        public long TemplateID
        {
            get { return templateID; }
            set { templateID = value; }
        }
        public string InvType
        {
            get { return invType; }
            set { invType = value; }
        }
        public string Investigation
        {
            get { return investigation; }
            set { investigation = value; }
        }

        /// <summary>
        /// Gets or sets the RoleID value.
        /// </summary>
        public long OrgID
        {
            get { return orgID; }
            set { orgID = value; }
        }

        /// <summary>
        /// Gets or sets the RedirectPageID value.
        /// </summary>
        public long ID
        {
            get { return iD; }
            set { iD = value; }
        }

        /// <summary>
        /// Gets or sets the SearchTypeID value.
        /// </summary>
        public string TemplateName
        {
            get { return templateName; }
            set { templateName = value; }
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
        /// Gets or sets the IsMapped value.
        /// </summary>
        public string TemplateText
        {
            get { return templateText; }
            set { templateText = value; }
        }

        /// <summary>
        /// Gets or sets the IsSplAuthorize value.
        /// </summary>


        /// <summary>
        /// Gets or sets the DisplayText value.
        /// </summary>

        #endregion
    }
}
