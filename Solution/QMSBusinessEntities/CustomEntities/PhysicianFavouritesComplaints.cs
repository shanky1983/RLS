using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
   public class PhysicianFavouritesComplaints
    {
        #region Fields

        private long favID = 0;
        private long loginID = 0;
        private long roleID = 0;
        private long feeID = 0;
        private string feeType = String.Empty;
        private long complaintID = 0;
        private long orgID = 0;
        private string createdAt;
        private string modifiedAt;
        private long createdBy = 0;
        private string _InvestigationName = string.Empty;
        private long favourite = 0;




        private long drugID = 0;
        private long drugFrequencyID = 0;
        private long durationID = 0;
        private decimal qTY = 0;


        private string drugName=string.Empty;
        private string durationText;
        private string frequencyText;
        private string instructionText;
        private long genericID;
        private string frequencyShortName;
        private long instructionID;
        
        #endregion
        
        #region Properties
   
       public long InstructionID
        {
            get { return instructionID; }
            set { instructionID = value; }
        }
 
        public string FrequencyShortName
        {
            get { return frequencyShortName; }
            set { frequencyShortName = value; }
        }

        public long GenericID
        {
            get { return genericID; }
            set { genericID = value; }
        }
 

        public string DurationText
        {
            get { return durationText; }
            set { durationText = value; }
        }
 


        public string DrugName
        {
            get { return drugName; }
            set { drugName = value; }
        }
 
        public string FrequencyText
        {
            get { return frequencyText; }
            set { frequencyText = value; }
        }
        public string InstructionText
        {
            get { return instructionText; }
            set { instructionText = value; }
        }

        public long Favourite
        {
            get { return favourite; }
            set { favourite = value; }
        }

        /// <summary>
        /// Gets or sets the FavID value.
        /// </summary>
        public long FavID
        {
            get { return favID; }
            set { favID = value; }
        }

        /// <summary>
        /// Gets or sets the LoginID value.
        /// </summary>
        public long LoginID
        {
            get { return loginID; }
            set { loginID = value; }
        }

        /// <summary>
        /// Gets or sets the RoleID value.
        /// </summary>
        public long RoleID
        {
            get { return roleID; }
            set { roleID = value; }
        }

        /// <summary>
        /// Gets or sets the FeeID value.
        /// </summary>
        public long FeeID
        {
            get { return feeID; }
            set { feeID = value; }
        }

        /// <summary>
        /// Gets or sets the FeeType value.
        /// </summary>
        public string FeeType
        {
            get { return feeType; }
            set { feeType = value; }
        }

        /// <summary>
        /// Gets or sets the ComplaintID value.
        /// </summary>
        public long ComplaintID
        {
            get { return complaintID; }
            set { complaintID = value; }
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
        /// Gets or sets the CreatedAt value.
        /// </summary>
        public string CreatedAt
        {
            get { return createdAt; }
            set { createdAt = value; }
        }

        /// <summary>
        /// Gets or sets the ModifiedAt value.
        /// </summary>
        public string ModifiedAt
        {
            get { return modifiedAt; }
            set { modifiedAt = value; }
        }

        /// <summary>
        /// Gets or sets the CreatedBy value.
        /// </summary>
        public long CreatedBy
        {
            get { return createdBy; }
            set { createdBy = value; }
        }



        public string InvestigationName
        {
            get { return _InvestigationName; }
            set { _InvestigationName = value; }
        }

        public long DrugID
        {
            get { return drugID; }
            set { drugID = value; }
        }


        public long DrugFrequencyID
        {
            get { return drugFrequencyID; }
            set { drugFrequencyID = value; }
        }

        public long DurationID
        {
            get { return durationID; }
            set { durationID = value; }
        }

        public decimal QTY
        {
            get { return qTY; }
            set { qTY = value; }
        }

                        
        #endregion
    }
}
