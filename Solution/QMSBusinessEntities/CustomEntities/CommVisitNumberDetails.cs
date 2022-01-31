using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class CommVisitNumberDetails
    {
        private string name = string.Empty;
        private string age = String.Empty;
        private string gender = string.Empty;
        private string orderText = String.Empty;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public string OrderText
        {
            get { return orderText; }
            set { orderText = value; }
        }

    }
}
