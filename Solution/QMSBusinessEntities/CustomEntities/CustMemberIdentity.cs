using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
   public class CustMemberIdentity
    {

        #region Fields
        private string type = string.Empty;
        private long memberIdentityID = 0;
        private long memberDetailsID = 0;
        private long patientID = 0;
        private byte seqNo = 0x00;
        private string valu = String.Empty;
        private int typeID = 0;
        private DateTime createdAt = DateTime.MaxValue;
        private long createdBy = 0;
        private DateTime modifiedAt = DateTime.MaxValue;
        private long modifiedBy = 0;

        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the MemberIdentityID value.
        /// </summary>
        public long MemberIdentityID
        {
            get { return memberIdentityID; }
            set { memberIdentityID = value; }
        }

        /// <summary>
        /// Gets or sets the MemberDetailsID value.
        /// </summary>
        public long MemberDetailsID
        {
            get { return memberDetailsID; }
            set { memberDetailsID = value; }
        }

        /// <summary>
        /// Gets or sets the PatientID value.
        /// </summary>
        public long PatientID
        {
            get { return patientID; }
            set { patientID = value; }
        }

        /// <summary>
        /// Gets or sets the SeqNo value.
        /// </summary>
        public byte SeqNo
        {
            get { return seqNo; }
            set { seqNo = value; }
        }

        /// <summary>
        /// Gets or sets the Valu value.
        /// </summary>
        public string Value
        {
            get { return valu; }
            set { valu = value; }
        }

        /// <summary>
        /// Gets or sets the Valu value.
        /// </summary>
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        /// <summary>
        /// Gets or sets the TypeID value.
        /// </summary>
        public int TypeID
        {
            get { return typeID; }
            set { typeID = value; }
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
        /// Gets or sets the CreatedBy value.
        /// </summary>
        public long CreatedBy
        {
            get { return createdBy; }
            set { createdBy = value; }
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
        /// Gets or sets the ModifiedBy value.
        /// </summary>
        public long ModifiedBy
        {
            get { return modifiedBy; }
            set { modifiedBy = value; }
        }


        #endregion
         
    }
}
