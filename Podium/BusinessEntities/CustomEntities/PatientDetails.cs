using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    [Serializable()]
    public class PatientDetails
    {
        private int orgID = 0;
        private string name = String.Empty;
        private byte tITLECode = 0x00;
        private string sEX = String.Empty;
        private string patientNumber = String.Empty;
        private string nationality = String.Empty;
        private string age = String.Empty;
        private string email = string.Empty;
        /// <summary>
        /// Gets or sets the Age value.
        /// </summary>
        public string PatientNumber
        {
            get { return patientNumber; }
            set { patientNumber = value; }
        }
        /// <summary>
        /// Gets or sets the Age value.
        /// </summary>
        public string Age
        {
            get { return age; }
            set { age = value; }
        }
        /// <summary>
        /// Gets or sets the SEX value.
        /// </summary>
        public string SEX
        {
            get { return sEX; }
            set { sEX = value; }
        }
        /// <summary>
        /// Gets or sets the Nationality value.
        /// </summary>
        public string Nationality
        {
            get { return nationality; }
            set { nationality = value; }
        }
        /// <summary>
        /// Gets or sets the CreatedBy value.
        /// </summary>
        //public long CreatedBy
        //{
        //    get { return createdBy; }
        //    set { createdBy = value; }
        //}
        /// <summary>
        /// Gets or sets the OrgID value.
        /// </summary>
        public int OrgID
        {
            get { return orgID; }
            set { orgID = value; }
        }
        /// <summary>
        /// Gets or sets the Name value.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>
        /// Gets or sets the TITLECode value.
        /// </summary>
        public byte TITLECode
        {
            get { return tITLECode; }
            set { tITLECode = value; }
        }
        private DateTime dOB = DateTime.MinValue;
        /// <summary>
        /// Gets or sets the DOB value.
        /// </summary>
        public DateTime DOB
        {
            get { return dOB; }
            set { dOB = value; }
        }
        public void Serialization()
        {

        }
        public string EMail
        {
            get { return email; }
            set { email = value; }
        }
    }
   
    
}
