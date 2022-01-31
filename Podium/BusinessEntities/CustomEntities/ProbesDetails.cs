using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class ProbesDetails
    {
        #region Fields
        private long probeID;
        private string probeName;
        private long resultTypeID;
        private string resultType;
        private string signalPattern;
        private string countedNoofcells;
        private string resultantNoofcells;
        private string results;
        private string images;
        private string description;
        private byte[] imageSource = new byte[0];
        private long probeimageID;
        private long investigationID;
        private long pVisitId;
        private int orgID;
        #endregion
        #region Properties
        /// <summary>
        /// Gets or sets the probeID value.
        /// </summary>
        public long ProbeID
        {
            get { return probeID; }
            set { probeID = value; }
        }
        /// <summary>
        /// Gets or sets the probeName value.
        /// </summary>
        public string ProbeName
        {
            get { return probeName; }
            set { probeName = value; }
        }
        /// <summary>
        /// Gets or sets the resultTypeID value.
        /// </summary>
        public long ResultTypeID
        {
            get { return resultTypeID; }
            set { resultTypeID = value; }
        }
        /// <summary>
        /// Gets or sets the resultType value.
        /// </summary>
        public string ResultType
        {
            get { return resultType; }
            set { resultType = value; }
        }
        /// <summary>
        /// Gets or sets the SignalPattern value.
        /// </summary>
        public string SignalPattern
        {
            get { return signalPattern; }
            set { signalPattern = value; }
        }
        /// <summary>
        /// Gets or sets the CountedNoofcells value.
        /// </summary>
        public string CountedNoofcells
        {
            get { return countedNoofcells; }
            set { countedNoofcells = value; }
        }
        /// <summary>
        /// Gets or sets the resultantNoofcells value.
        /// </summary>
        public string ResultantNoofcells
        {
            get { return resultantNoofcells; }
            set { resultantNoofcells = value; }
        }
        /// <summary>
        /// Gets or sets the Results value.
        /// </summary>
        public string Results
        {
            get { return results; }
            set { results = value; }
        }
        /// <summary>
        /// Gets or sets the Images value.
        /// </summary>
        public string Images
        {
            get { return images; }
            set { images = value; }
        }
        /// <summary>
        /// Gets or sets the description value.
        /// </summary>
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        /// <summary>
        /// Gets or sets the imageSource value.
        /// </summary>
        public byte[] ImageSource
        {
            get { return imageSource; }
            set { imageSource = value; }
        }
        /// <summary>
        /// Gets or sets the probeimageID value.
        /// </summary>
        public long ProbeImageID
        {
            get { return probeimageID; }
            set { probeimageID = value; }
        }
        /// <summary>
        /// Gets or sets the investigationID value.
        /// </summary>
        public long InvestigationID
        {
            get { return investigationID; }
            set { investigationID = value; }
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
        /// Gets or sets the pVisitId value.
        /// </summary>
        public long PVisitId
        {
            get { return pVisitId; }
            set { pVisitId = value; }
        }
        
        #endregion

    }
}
