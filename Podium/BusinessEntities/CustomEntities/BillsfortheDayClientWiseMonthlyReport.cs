using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class BillsfortheDayClientWiseMonthlyReport
    {
        #region Fields
        private decimal m1 =0;  
        private decimal m2 =0;   
        private decimal m3 =0;    
        private decimal m4 =0;   
        private decimal m5 =0;    
        private decimal m6 =0;  
        private decimal m7 =0;   
        private decimal m8 =0;     
        private decimal m9 =0;    
        private decimal m10 =0;
        private decimal m11 = 0;   
        private decimal m12  = 0;
        private long clientid = 0;
        private string clientcode = String.Empty;
        private string clientname = String.Empty;
        private string countryName = String.Empty;
        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the countryName value.
        /// </summary>
        public string CountryName
        {
            get { return countryName; }
            set { countryName = value; }
        }

         /// <summary>
        /// Gets or sets the clientname value.
        /// </summary>
        public string ClientName
        {
            get { return clientname; }
            set { clientname = value; }
        }

        /// <summary>
        /// Gets or sets the clinetcode value.
        /// </summary>
        public string ClientCode
        {
            get { return clientcode; }
            set { clientcode = value; }
        }

        /// <summary>
        /// Gets or sets the clinetid value.
        /// </summary>
        public long Clientid
        {
            get { return clientid; }
            set { clientid = value; }
        }

   
        /// <summary>
        /// Gets or sets the January value.
        /// </summary>
        public decimal M1
        {
            get { return m1; }
            set { m1 = value; }
        }

         /// <summary>
        /// Gets or sets the February value.
        /// </summary>
        public decimal M2
        {
            get { return m2; }
            set { m2  = value; }
        }
       
         /// <summary>
        /// Gets or sets the February value.
        /// </summary>
        public decimal M3
        {
            get { return m3; }
            set { m3 = value; }
        }
       
         /// <summary>
        /// Gets or sets the February value.
        /// </summary>
        public decimal M4
        {
            get { return m4; }
            set { m4 = value; }
        }
       
         /// <summary>
        /// Gets or sets the February value.
        /// </summary>
        public decimal M5
        {
            get { return m5; }
            set { m5 = value; }
        }
       
         /// <summary>
        /// Gets or sets the February value.
        /// </summary>
        public decimal M6
        {
            get { return m6; }
            set { m6 = value; }
        }
       
         /// <summary>
        /// Gets or sets the February value.
        /// </summary>
        public decimal M7
        {
            get { return m7; }
            set { m7 = value; }
        }
       
         /// <summary>
        /// Gets or sets the February value.
        /// </summary>
        public decimal M8
        {
            get { return m8; }
            set { m8 = value; }
        }
       
         /// <summary>
        /// Gets or sets the February value.
        /// </summary>
        public decimal M9
        {
            get { return m9; }
            set { m9 = value; }
        }
       
         /// <summary>
        /// Gets or sets the February value.
        /// </summary>
        public decimal M10
        {
            get { return m10; }
            set { m10 = value; }
        }
       
         /// <summary>
        /// Gets or sets the February value.
        /// </summary>
        public decimal M11
        {
            get { return m11; }
            set { m11 = value; }
        }
       
         /// <summary>
        /// Gets or sets the February value.
        /// </summary>
        public decimal M12
        {
            get { return m12; }
            set { m12 = value; }
        }
       
        #endregion
    }
}
