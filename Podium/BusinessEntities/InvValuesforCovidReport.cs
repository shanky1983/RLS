using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InvValuesforCovidReport
	{
		#region Fields

		private long visitid=0;
		private string invvalue=String.Empty;
		private string medicalremarks=String.Empty;
		private long patientinvid=0;
        private long investigationID = 0;
		private long accessionnumber=0;
		private long investigationvalueid=0;
        private int orgid = 0;

		#endregion

		#region Properties

        public long VisitID
        {
            get { return visitid; }
            set { visitid = value; }
        }
        public string  InvValue
        {
            get { return invvalue; }
            set { invvalue = value; }
        }

        public string  MedicalRemarks
        {
            get { return medicalremarks; }
            set { medicalremarks = value; }
        }

        public long PatientInvID
        {
            get { return patientinvid; }
            set { patientinvid = value; }
        }

        public long InvestigationID
        {
            get { return investigationID; }
            set { investigationID = value; }
        }
        public long AccessionNumber
        {
            get { return accessionnumber; }
            set { accessionnumber = value; }
        }

        public long InvestigationValueID
        {
            get { return investigationvalueid; }
            set { investigationvalueid = value; }
        }

        public int OrgID
        {
            get { return orgid; }
            set { orgid = value; }
        }


		#endregion
}
}
