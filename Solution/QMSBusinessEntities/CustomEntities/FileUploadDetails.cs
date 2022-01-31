using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class FileUploadDetails
    {
        #region Fields
        private Int64 docFileID;
        private string docFileUrl;
        private string docFileName;
        private string identifyingType;
        private int identifyingID;
        private string type;
        private DateTime docDate;
        // private long PatientID = 0;

        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the fileUrl value.
        /// </summary>
        public Int64 DocFileID
        {
            get { return docFileID; }
            set { docFileID = value; }
        }
        /// <summary>
        /// Gets or sets the fileUrl value.
        /// </summary>
        public string DocFileUrl
        {
            get { return docFileUrl; }
            set { docFileUrl = value; }
        }
        /// <summary>
        /// Gets or sets the fileName value.
        /// </summary>
        public string DocFileName
        {
            get { return docFileName; }
            set { docFileName = value; }
        }
        /// <summary>
        /// Gets or sets the IdentifyingType value.
        /// </summary>
        public string IdentifyingType
        {
            get { return identifyingType; }
            set { identifyingType = value; }
        }
        /// <summary>
        /// Gets or sets the IdentifyingID value.
        /// </summary>
        public int IdentifyingID
        {
            get { return identifyingID; }
            set { identifyingID = value; }
        }

        /// <summary>
        /// Gets or sets the IdentifyingID value.
        /// </summary>
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        /// <summary>
        /// Gets or sets the IdentifyingID value.
        /// </summary>
        public DateTime DocDate
        {
            get { return docDate; }
            set { docDate = value; }
        }
        #endregion

    }
}
