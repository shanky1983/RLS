using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class GetReportDetails
    {
        private long reportGroupID = 0;
        private long reportID = 0;
        private long roleID = 0;
        private long orgID = 0;

        private string reportGroupText = String.Empty;
        private string reportDisplayText = String.Empty;
        private string reportPath = String.Empty;
        private string redirectURL = String.Empty;
        private string isMapped = String.Empty;

        private string _ShowDatePopup = String.Empty;

        public string ShowDatePopup
        {
            get { return _ShowDatePopup; }
            set { _ShowDatePopup = value; }
        }
        public long ReportGroupID
        {
            get { return reportGroupID; }
            set { reportGroupID = value; }
        }
        public long ReportID
        {
            get { return reportID; }
            set { reportID = value; }
        }
        public long RoleID
        {
            get { return roleID; }
            set { roleID = value; }
        }
        public long OrgID
        {
            get { return orgID; }
            set { orgID = value; }
        }

        public string ReportGroupText
        {
            get { return reportGroupText; }
            set { reportGroupText = value; }
        }
        public string ReportDisplayText
        {
            get { return reportDisplayText; }
            set { reportDisplayText = value; }
        }
        public string ReportPath
        {
            get { return reportPath; }
            set { reportPath = value; }
        }
        public string RedirectURL
        {
            get { return redirectURL; }
            set { redirectURL = value; }
        }
        public string IsMapped
        {
            get { return isMapped; }
            set { isMapped = value; }
        }

    }
}
