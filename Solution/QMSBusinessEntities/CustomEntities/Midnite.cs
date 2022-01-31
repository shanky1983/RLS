using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class Midnite
    {
        #region Fields
        private short age = 0;
        private string sex = String.Empty;
        private string wardName = String.Empty;        
        private int maleAdmission = 0;
        private int femaleAdmission = 0;
        private int maleBirth = 0;
        private int femaleBirth = 0;
        private int maleDischarge = 0;
        private int femaleDischarge = 0;
        private int femaleTransferIN = 0;
        private int maleTransferIN = 0;
        private int femaleTransferOut = 0;
        private int maleTransferOut = 0;
        private int maleDeath = 0;
        private int femaleDeath = 0;
        #endregion

        #region methods
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        public string WardName
        {
            get { return wardName; }
            set { wardName = value; }
        }
        public short Age
        {
            get { return age; }
            set { age = value; }
        }
        public int MaleAdmission
        {
            get { return maleAdmission; }
            set { maleAdmission = value; }
        }
        public int FemaleAdmission
        {
            get { return femaleAdmission; }
            set { femaleAdmission = value; }
        }
        public int MaleDischarge
        {
            get { return maleDischarge; }
            set { maleDischarge = value; }
        }
        public int FemaleDischarge
        {
            get { return femaleDischarge; }
            set { femaleDischarge = value; }
        }
        public int FemaleTransferIN
        {
            get { return femaleTransferIN; }
            set { femaleTransferIN = value; }
        }
        public int MaleTransferIN
        {
            get { return maleTransferIN; }
            set { maleTransferIN = value; }
        }
        public int FemaleTransferOut
        {
            get { return femaleTransferOut; }
            set { femaleTransferOut = value; }
        }
        public int MaleTransferOut
        {
            get { return maleTransferOut; }
            set { maleTransferOut = value; }
        }
        public int MaleBirth
        {
            get { return maleBirth; }
            set { maleBirth = value; }
        }
        public int FemaleBirth
        {
            get { return femaleBirth; }
            set { femaleBirth = value; }
        }
        public int MaleDeath
        {
            get { return maleDeath; }
            set { maleDeath = value; }
        }
        public int FemaleDeath
        {
            get { return femaleDeath; }
            set { femaleDeath = value; }
        }
        #endregion

    }
}
