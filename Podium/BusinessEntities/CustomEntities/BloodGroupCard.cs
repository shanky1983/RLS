using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
   public  class BloodGroupCard
    {
       //select p.Name [Patient name],p.URNO [Patient ID],iv.Value [Result],iv.CreatedAt [Test date],iv.GroupName [Profiles],pv.HospitalName [Orderer]
       //,p.CreatedAt [Order date/time],''[Visit],IV.Name [Analyte],'False' [Printed],pv.ExternalVisitID [Order No.]
        #region fields

        private string patient_name = string.Empty;
        private string patient_id = string.Empty;
        private string result=String.Empty;
        private string test_date = string.Empty;
        private string profiles=string.Empty;
        private string orderer = String.Empty;
        private string order_date_time = string.Empty;
        private string visit = String.Empty;
        private string analyte = String.Empty;
        private string printed = String.Empty;
        private string order_No = String.Empty;
       //Order date/time
        
        
        #endregion


        #region Properties

        /// <summary>
        /// Gets or sets the Name value.
        /// </summary>
        public string Patient_Name
        {
            get { return patient_name; }
            set { patient_name = value; }
        }
       /// <summary>
        /// Gets or sets the URNO value.
        /// </summary>
        public string Patient_ID
        {
            get { return patient_id; }
            set { patient_id = value; }
        }
        /// <summary>
        /// Gets or sets the Valu value.
        /// </summary>
        public string Result
        {
            get { return result; }
            set { result = value; }
        }
        /// <summary>
        /// Gets or sets the CreatedAt value.
        /// </summary>
        public string Test_Date
        {
            get { return test_date; }
            set { test_date = value; }
        }
        /// <summary>
        /// Gets or sets the GroupName value.
        /// </summary>
        public string Profiles
        {
            get { return profiles; }
            set { profiles = value; }
        }
        /// <summary>
        /// Gets or sets the HospitalName value.
        /// </summary>
        public string Orderer
        {
            get { return orderer; }
            set { orderer = value; }
        }
        /// <summary>
        /// Gets or sets the CreatedAt value.
        /// </summary>
        public string Order_date_time
        {
            get { return order_date_time; }
            set { order_date_time = value; }
        }
        public string Visit
        {
            get { return visit; }
            set { visit = value; }
        }
        public string Analyte
        {
            get { return analyte; }
            set { analyte = value; }
        }
        public string Printed
        {
            get { return printed; }
            set { printed = value; }
        }
        public string Order_No
        {
            get { return order_No; }
            set { order_No = value; }
        }
        #endregion
    }
}
