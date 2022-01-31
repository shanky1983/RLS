using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class AdminReports
    {

        #region Fields

        private string name = String.Empty;
        private short age = 0;
        private string sex = String.Empty;
        private string mobileno = String.Empty;
        private string visitPurposeName = String.Empty;
        private string visitPurposeId = String.Empty;

        #endregion


        #region Properties

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public short Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        public string PhoneNumber
        {
            get { return mobileno; }
            set { mobileno = value; }
        }
        public string VisitPurposeName
        {
            get { return visitPurposeName; }
            set { visitPurposeName = value; }
        }
        public string VisitPurposeId
        {
            get { return visitPurposeId; }
            set { visitPurposeId = value; }
        }

        #endregion
    }
}

