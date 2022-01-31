using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class QCResultDetails
    {
        private long investigationID = 0;
        private long instrumentID = 0;
        private string loValue = string.Empty;
        private string loQCStatus = string.Empty;
        private string loRole = string.Empty;
        private string ltValue = string.Empty;
        private string ltQCStatus = string.Empty;
        private string ltRole = string.Empty;
        private string leValue = string.Empty;
        private string leQCStatus = string.Empty;
        private string leRole = string.Empty;

        public long InvestigationID
        {
            get { return investigationID; }
            set { investigationID= value; }
        }

        public long InstrumentID
        {
            get { return instrumentID; }
            set { instrumentID = value; }
        }

        public string LOValue
        {
            get { return loValue; }
            set { loValue = value; }
        }

        public string LOQCStatus
        {
            get { return loQCStatus; }
            set { loQCStatus = value; }
        }

        public string LORole
        {
            get { return loRole; }
            set { loRole = value; }
        }

        public string LTValue
        {
            get { return ltValue; }
            set { ltValue = value; }
        }

        public string LTQCStatus
        {
            get { return ltQCStatus; }
            set { ltQCStatus = value; }
        }

        public string LTRole
        {
            get { return ltRole; }
            set { ltRole = value; }
        }

        public string LEValue
        {
            get { return leValue; }
            set { leValue = value; }
        }

        public string LEQCStatus
        {
            get { return leQCStatus; }
            set { leQCStatus = value; }
        }

        public string LERole
        {
            get { return leRole; }
            set { leRole = value; }
        }
    }
}
