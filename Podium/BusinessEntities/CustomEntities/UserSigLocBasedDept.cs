using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class UserSigLocBasedDept
    {
        #region Fields

		private long id=0;
        private int deptID = 0;
		private string deptName=String.Empty;
        private long addressID = 0;
		private string location=String.Empty;
        private long userID = 0;
		private string userName=String.Empty;
        private long seqNo = 0;
		private string defaultsig=String.Empty;
        private long rowNo = 0;

		#endregion

		#region Properties

        public long Id
		{
			get { return id; }
			set { id = value; }
		}


        public int DeptID
		{
			get { return deptID; }
			set { deptID = value; }
		}

		
		public string DeptName
		{
			get { return deptName; }
			set { deptName = value; }
		}


        public long AddressID
		{
			get { return addressID; }
			set { addressID = value; }
		}

		public string Location
		{
			get { return location; }
			set { location = value; }
		}


        public long UserID
		{
			get { return userID; }
			set { userID = value; }
		}

        public string UserName
		{
			get { return userName; }
            set { userName = value; }
		}

        public long SeqNo
		{
			get { return seqNo; }
			set { seqNo = value; }
		}

	
		public string Defaultsig
		{
			get { return defaultsig; }
			set { defaultsig = value; }
		}

        public long RowNo
        {
            get { return rowNo; }
            set { rowNo = value; }
        }
		#endregion

    }
}
