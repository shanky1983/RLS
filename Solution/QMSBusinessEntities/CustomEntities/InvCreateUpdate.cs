using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class InvCreateUpdate
    {
        #region Field
        private string t_Code=string.Empty;
        private string errorType=string.Empty;
        //For Log Info
        private DateTime createdAt=DateTime.MaxValue;
        private string testType = string.Empty;
        private string uploadedFilename = string.Empty;
        private string username = string.Empty;
        private string uploadedStatus = string.Empty;

        #endregion
        #region Properties
        public string T_Code
        {
            get { return t_Code; }
            set { t_Code = value; }
        }
        public string ErrorType
        {
            get { return errorType; }
            set { errorType = value; }
        }
        //For Log Info
        public DateTime CreatedAt
        {
            get { return createdAt; }
            set { createdAt = value; }
        }
        public string TestType
        {
            get { return testType; }
            set { testType = value; }
        }
        public string UploadedFilename
        {
            get { return uploadedFilename; }
            set { uploadedFilename = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string UploadedStatus 
        {
            get { return uploadedStatus; }
            set { uploadedStatus = value; }
        }
     
        #endregion
    }
}
