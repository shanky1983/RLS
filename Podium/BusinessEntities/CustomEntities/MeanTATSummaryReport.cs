using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class MeanTATSummaryReport
    {
        #region Fields

        
        
        private string name = String.Empty;
        private string department = String.Empty;   
        private decimal week1 = Decimal.Zero;
        private decimal week2 = Decimal.Zero;
        private decimal week3 = Decimal.Zero;
        private decimal week4 = Decimal.Zero;
        private decimal week5 = Decimal.Zero;
        private decimal week6 = Decimal.Zero;
        private decimal week7 = Decimal.Zero;
        private decimal week8 = Decimal.Zero;
        

        #endregion

        #region Properties        
        
        /// <summary>
        /// Gets or sets the FeeDescription value.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Gets or sets the Department value.
        /// </summary>
        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        
        /// <summary>
        /// Gets or sets the week1 value.
        /// </summary>
        public decimal W1
        {
            get { return week1; }
            set { week1 = value; }
        }

        /// <summary>
        /// Gets or sets the week2 value.
        /// </summary>
        public decimal W2
        {
            get { return week2; }
            set { week2 = value; }
        }

        /// <summary>
        /// Gets or sets the week3 value.
        /// </summary>
        public decimal W3
        {
            get { return week3; }
            set { week3 = value; }
        }

        /// <summary>
        /// Gets or sets the week4 value.
        /// </summary>
        public decimal W4
        {
            get { return week4; }
            set { week4 = value; }
        }

        /// <summary>
        /// Gets or sets the week5 value.
        /// </summary>
        public decimal W5
        {
            get { return week5; }
            set { week5 = value; }
        }

        /// <summary>
        /// Gets or sets the week6 value.
        /// </summary>
        public decimal W6
        {
            get { return week6; }
            set { week6 = value; }
        }

        /// <summary>
        /// Gets or sets the week7 value.
        /// </summary>
        public decimal W7
        {
            get { return week7; }
            set { week7 = value; }
        }

        /// <summary>
        /// Gets or sets the week8 value.
        /// </summary>
        public decimal W8
        {
            get { return week8; }
            set { week8 = value; }
        }

        


        #endregion
    }
}
