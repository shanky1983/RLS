using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class PatientRegistration
    {
        #region Fields
        private long regID = 0;
        private string patientNumber = String.Empty;
        private string nIP = String.Empty;
        private string genderID = String.Empty;
        private string genderName = String.Empty;
        private string dOB = String.Empty;
        private string patientName = String.Empty;
        private string patientAddress = String.Empty;
        private string visitNumber = String.Empty;
        private string designationID = String.Empty;
        private string designationName = String.Empty;
        private string fieldArmyID = String.Empty;
        private string fieldArmyName = String.Empty;
        private string deptID = String.Empty;
        private string deptName = String.Empty;
        private string clientID = String.Empty;
        private string clientName = String.Empty;
        private string doctorID = String.Empty;
        private string doctorName = String.Empty;
        private string rateID = String.Empty;
        private string rateName = String.Empty;
        private string wardID = String.Empty;
        private string wardName = String.Empty;
        private string roomID = String.Empty;
        private string roomName = String.Empty;
        private string bedID = String.Empty;
        private string bedName = String.Empty;
        private string regUserID = String.Empty;
        private string regUserName = String.Empty;

        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the RegID value.
        /// </summary>
        public long RegID
        {
            get { return regID; }
            set { regID = value; }
        }

        /// <summary>
        /// Gets or sets the PatientNumber value.
        /// </summary>
        public string PatientNumber
        {
            get { return patientNumber; }
            set { patientNumber = value; }
        }

        /// <summary>
        /// Gets or sets the NIP value.
        /// </summary>
        public string NIP
        {
            get { return nIP; }
            set { nIP = value; }
        }

        /// <summary>
        /// Gets or sets the GenderID value.
        /// </summary>
        public string GenderID
        {
            get { return genderID; }
            set { genderID = value; }
        }

        /// <summary>
        /// Gets or sets the GenderName value.
        /// </summary>
        public string GenderName
        {
            get { return genderName; }
            set { genderName = value; }
        }

        /// <summary>
        /// Gets or sets the DOB value.
        /// </summary>
        public string DOB
        {
            get { return dOB; }
            set { dOB = value; }
        }

        /// <summary>
        /// Gets or sets the PatientName value.
        /// </summary>
        public string PatientName
        {
            get { return patientName; }
            set { patientName = value; }
        }

        /// <summary>
        /// Gets or sets the PatientAddress value.
        /// </summary>
        public string PatientAddress
        {
            get { return patientAddress; }
            set { patientAddress = value; }
        }

        /// <summary>
        /// Gets or sets the VisitNumber value.
        /// </summary>
        public string VisitNumber
        {
            get { return visitNumber; }
            set { visitNumber = value; }
        }

        /// <summary>
        /// Gets or sets the DesignationID value.
        /// </summary>
        public string DesignationID
        {
            get { return designationID; }
            set { designationID = value; }
        }

        /// <summary>
        /// Gets or sets the DesignationName value.
        /// </summary>
        public string DesignationName
        {
            get { return designationName; }
            set { designationName = value; }
        }

        /// <summary>
        /// Gets or sets the FieldArmyID value.
        /// </summary>
        public string FieldArmyID
        {
            get { return fieldArmyID; }
            set { fieldArmyID = value; }
        }

        /// <summary>
        /// Gets or sets the FieldArmyName value.
        /// </summary>
        public string FieldArmyName
        {
            get { return fieldArmyName; }
            set { fieldArmyName = value; }
        }

        /// <summary>
        /// Gets or sets the DeptID value.
        /// </summary>
        public string DeptID
        {
            get { return deptID; }
            set { deptID = value; }
        }

        /// <summary>
        /// Gets or sets the DeptName value.
        /// </summary>
        public string DeptName
        {
            get { return deptName; }
            set { deptName = value; }
        }

        /// <summary>
        /// Gets or sets the ClientID value.
        /// </summary>
        public string ClientID
        {
            get { return clientID; }
            set { clientID = value; }
        }

        /// <summary>
        /// Gets or sets the ClientName value.
        /// </summary>
        public string ClientName
        {
            get { return clientName; }
            set { clientName = value; }
        }

        /// <summary>
        /// Gets or sets the DoctorID value.
        /// </summary>
        public string DoctorID
        {
            get { return doctorID; }
            set { doctorID = value; }
        }

        /// <summary>
        /// Gets or sets the DoctorName value.
        /// </summary>
        public string DoctorName
        {
            get { return doctorName; }
            set { doctorName = value; }
        }

        /// <summary>
        /// Gets or sets the RateID value.
        /// </summary>
        public string RateID
        {
            get { return rateID; }
            set { rateID = value; }
        }

        /// <summary>
        /// Gets or sets the RateName value.
        /// </summary>
        public string RateName
        {
            get { return rateName; }
            set { rateName = value; }
        }

        /// <summary>
        /// Gets or sets the WardID value.
        /// </summary>
        public string WardID
        {
            get { return wardID; }
            set { wardID = value; }
        }

        /// <summary>
        /// Gets or sets the WardName value.
        /// </summary>
        public string WardName
        {
            get { return wardName; }
            set { wardName = value; }
        }

        /// <summary>
        /// Gets or sets the RoomID value.
        /// </summary>
        public string RoomID
        {
            get { return roomID; }
            set { roomID = value; }
        }

        /// <summary>
        /// Gets or sets the RoomName value.
        /// </summary>
        public string RoomName
        {
            get { return roomName; }
            set { roomName = value; }
        }

        /// <summary>
        /// Gets or sets the BedID value.
        /// </summary>
        public string BedID
        {
            get { return bedID; }
            set { bedID = value; }
        }

        /// <summary>
        /// Gets or sets the BedName value.
        /// </summary>
        public string BedName
        {
            get { return bedName; }
            set { bedName = value; }
        }

        /// <summary>
        /// Gets or sets the RegUserID value.
        /// </summary>
        public string RegUserID
        {
            get { return regUserID; }
            set { regUserID = value; }
        }

        /// <summary>
        /// Gets or sets the RegUserName value.
        /// </summary>
        public string RegUserName
        {
            get { return regUserName; }
            set { regUserName = value; }
        }
        private string orderNumber = String.Empty;

        public string OrderNumber
        {
            get { return orderNumber; }
            set { orderNumber = value; }
        }

        private DateTime orderItemDateTime = DateTime.MaxValue;

        public DateTime OrderItemDateTime
        {
            get { return orderItemDateTime; }
            set { orderItemDateTime = value; }
        }

        private string orderItemID = String.Empty;

        public string OrderItemID
        {
            get { return orderItemID; }
            set { orderItemID = value; }
        }
        private string orderItemName = String.Empty;

        public string OrderItemName
        {
            get { return orderItemName; }
            set { orderItemName = value; }
        }

        private string hIS_TEST_ID_ORDER = String.Empty;
        public string HIS_TEST_ID_ORDER
        {
            get { return hIS_TEST_ID_ORDER; }
            set { hIS_TEST_ID_ORDER = value; }
        }

        private string iCDItemID = String.Empty;
        public string ICDItemID
        {
            get { return iCDItemID; }
            set { iCDItemID = value; }
        }
        private string iCDItemName = String.Empty;
        public string ICDItemName
        {
            get { return iCDItemName; }
            set { iCDItemName = value; }
        }
        private string iCDTypeID = String.Empty;
        public string ICDTypeID
        {
            get { return iCDTypeID; }
            set { iCDTypeID = value; }
        }
        private string iCDTypeName = String.Empty;
        public string ICDTypeName
        {
            get { return iCDTypeName; }
            set { iCDTypeName = value; }
        }

        private string invDeptName = String.Empty;
        public string InvDeptName
        {
            get { return invDeptName; }
            set { invDeptName = value; }
        }

        #endregion
    }
}
