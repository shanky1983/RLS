using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
   public class PatientDrug
    {

        #region Fields

        private string treatment;
        private string dosage;
        private string frequency;

        #endregion

        #region Properties

        public string Treatment
        {
            get { return treatment; }
            set { treatment = value; }
        }


        public string Dosage
        {
            get { return dosage; }
            set { dosage = value; }
        }

        public string Frequency
        {
            get { return frequency; }
            set { frequency = value; }
        }


        #endregion

    }
}
