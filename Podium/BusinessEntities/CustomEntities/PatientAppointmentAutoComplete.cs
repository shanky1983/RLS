using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class PatientAppointmentAutoComplete
    {
        private string _ID;
        private string _Name;
        private string _PatientID;
        private string _PatientAddress;
        private string _ContactNo;
        private string _URNO;

        public string AID { get { return _ID; } set { _ID = value; } }
        public string Name { get { return _Name; } set { _Name = value; } }
        public string PatientID { get { return _PatientID; } set { _PatientID = value; } }
        public string PatientAddress { get { return _PatientAddress; } set { _PatientAddress = value; } }
        public string ContactNo { get { return _ContactNo; } set { _ContactNo = value; } }
        public string URNO{ get { return _URNO; } set { _URNO = value; } }
    }
}
