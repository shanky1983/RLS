using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class DeviceTestOrgMapping
    {
        private long sNo = 0;
        private string deviceID = String.Empty;
        private string testCode = String.Empty; 
        private string investigationName = String.Empty;
        private long investigationID = 0;
        private string formula=String.Empty;
		private string abnormal=String.Empty;
		private string isActive=String.Empty;
        private string isUpload = String.Empty;
        private string isDownload = String.Empty;
        private int locationID = 0;
        private long orgID = 0;
        private string flag = String.Empty;

        /// <summary>
        /// Gets or sets the SNo value.
        /// </summary>
        public long SNo                
        {
            get { return sNo; }
            set { sNo = value; }
        }
        /// <summary>
        /// Gets or sets the DeviceID value.
        /// </summary>
        public string DeviceID         
        {
            get { return deviceID; }
            set { deviceID = value; }
        }
        /// <summary>
        /// Gets or sets the TestCode value.
        /// </summary>
        public string TestCode         
        {
            get { return testCode; }
            set { testCode = value; }
        }
        /// <summary>
        /// Gets or sets the InvestigationName value.
        /// </summary>
        public string InvestigationName
        {
            get { return investigationName; }
            set { investigationName = value; }
        }
        /// <summary>
        /// Gets or sets the InvestigationID value.
        /// </summary>
        public long InvestigationID    
        {
            get { return investigationID; }
            set { investigationID = value; }
        }
        
        /// <summary>
        /// Gets or sets the Formula value.
        /// </summary>
        public string Formula          
        {
            get { return formula; }
            set { formula = value; }
        }
        /// <summary>
        /// Gets or sets the Abnormal value.
        /// </summary>
        public string Abnormal         
        {
            get { return abnormal; }
            set { abnormal = value; }
        }
        /// <summary>
        /// Gets or sets the IsActive value.
        /// </summary>
        public string IsActive         
        {
            get { return isActive; }
            set { isActive = value; }
        }
        /// <summary>
        /// Gets or sets the IsUpload value.
        /// </summary>
        public string IsUpload         
        {
            get { return isUpload; }
            set { isUpload = value; }
        }
        /// <summary>
        /// Gets or sets the IsDownload value.
        /// </summary>
        public string IsDownload       
        {
            get { return isDownload; }
            set { isDownload = value; }
        }
        /// <summary>
        /// Gets or sets the LocationID value.
        /// </summary>
        public int LocationID          
        {
            get { return locationID; }
            set { locationID = value; }
        }
        /// <summary>
        /// Gets or sets the OrgID value.
        /// </summary>
        public long OrgID
        {
            get { return orgID; }
            set { orgID = value; }
        }
        /// <summary>
        /// Gets or sets the Flag value.
        /// </summary>
        public string Flag             
        {
            get { return flag; }
            set { flag = value; }
        }
    }
}
