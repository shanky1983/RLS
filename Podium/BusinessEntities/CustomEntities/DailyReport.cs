using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class DailyReport
    {
        #region Fields

        private long billID = 0;
        private long referenceBillID = 0;
        private DateTime billDate = DateTime.MaxValue;
        private int orgID = 0;
        private long visitID = 0;
        private long patientID = 0;
        private int clientID = 0;
        private decimal grossAmount = Decimal.Zero;
        private decimal discount = Decimal.Zero;
        private decimal taxPercent = Decimal.Zero;
        private decimal netAmount = Decimal.Zero;
        private decimal amountReceived = Decimal.Zero;
        private decimal amountDue = Decimal.Zero;
        private string isCredit = String.Empty;
        private string isDue = String.Empty;
        private string clientname = string.Empty;
        private string patientname = string.Empty;
        private string age = string.Empty;
        private string hospitalname = string.Empty;
        private string referingphysicianname = string.Empty;
        private string collectioncentrename = string.Empty;
        private string status = string.Empty;
        private string itemName = String.Empty;
        private string deptName = String.Empty;
        private int deptID = 0;
        private long numberofitem = 0;
        private long patientcount = 0;
        private long referingphysicianid = 0;
        private string displayname = String.Empty;
        private string qualification = String.Empty;
        private string headername = String.Empty;
        private long id = 0;
        private string billNumber = String.Empty;

        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the BillID value.
        /// </summary>
        public long BillID
        {
            get { return billID; }
            set { billID = value; }
        }
        /// <summary>
        /// Gets or sets the BillNumber value.
        /// </summary>
        public string BillNumber
        {
            get { return billNumber; }
            set { billNumber = value; }
        }
        public long ReferenceBillID
        {
            get { return referenceBillID; }
            set { referenceBillID = value; }
        }
        /// <summary>
        /// Gets or sets the BillDate value.
        /// </summary>
        public DateTime BillDate
        {
            get { return billDate; }
            set { billDate = value; }
        }

        /// <summary>
        /// Gets or sets the OrgID value.
        /// </summary>
        public int OrgID
        {
            get { return orgID; }
            set { orgID = value; }
        }

        /// <summary>
        /// Gets or sets the VisitID value.
        /// </summary>
        public long VisitID
        {
            get { return visitID; }
            set { visitID = value; }
        }

        /// <summary>
        /// Gets or sets the PatientID value.
        /// </summary>
        public long PatientID
        {
            get { return patientID; }
            set { patientID = value; }
        }

        /// <summary>
        /// Gets or sets the ClientID value.
        /// </summary>
        public int ClientID
        {
            get { return clientID; }
            set { clientID = value; }
        }

        /// <summary>
        /// Gets or sets the GrossAmount value.
        /// </summary>
        public decimal GrossAmount
        {
            get { return grossAmount; }
            set { grossAmount = value; }
        }

        /// <summary>
        /// Gets or sets the Discount value.
        /// </summary>
        public decimal Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        /// <summary>
        /// Gets or sets the TaxPercent value.
        /// </summary>
        public decimal TaxPercent
        {
            get { return taxPercent; }
            set { taxPercent = value; }
        }

        /// <summary>
        /// Gets or sets the NetAmount value.
        /// </summary>
        public decimal NetAmount
        {
            get { return netAmount; }
            set { netAmount = value; }
        }

        /// <summary>
        /// Gets or sets the AmountReceived value.
        /// </summary>
        public decimal AmountReceived
        {
            get { return amountReceived; }
            set { amountReceived = value; }
        }

        /// <summary>
        /// Gets or sets the AmountDue value.
        /// </summary>
        public decimal AmountDue
        {
            get { return amountDue; }
            set { amountDue = value; }
        }

        /// <summary>
        /// Gets or sets the IsCredit value.
        /// </summary>
        public string IsCredit
        {
            get { return isCredit; }
            set { isCredit = value; }
        }

        public string IsDue
        {
            get { return isDue; }
            set { isDue = value; }
        }


        /// <summary>
        /// Gets or sets the ClientName value.
        /// </summary>

        public string ClientName
        {
            get { return clientname; }
            set { clientname = value; }
        }
        public string Name
        {
            get { return patientname; }
            set { patientname = value; }
        }
        public string Age
        {
            get { return age; }
            set { age = value; }
        }
        public string HospitalName
        {
            get { return hospitalname; }
            set { hospitalname = value; }
        }
        public string ReferingPhysicianName
        {
            get { return referingphysicianname; }
            set { referingphysicianname = value; }
        }
        public string CollectionCentreName
        {
            get { return collectioncentrename; }
            set { collectioncentrename = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }


        public string DeptName
        {
            get { return deptName; }
            set { deptName = value; }
        }

        public int DeptID
        {
            get { return deptID; }
            set { deptID = value; }
        }
        public long NumberOfItem
        {
            get { return numberofitem; }
            set { numberofitem = value; }
        }

        public long PatientCount
        {
            get { return patientcount; }
            set { patientcount = value; }
        }

        public long ReferingPhysicianID
        {
            get { return referingphysicianid; }
            set { referingphysicianid = value; }
        }

        public string DisplayName
        {
            get { return displayname; }
            set { displayname = value; }
        }

        public string Qualification
        {
            get { return qualification; }
            set { qualification = value; }
        }
        public string HeaderName
        {
            get { return headername; }
            set { headername = value; }
        }


        public long ID
        {
            get { return id; }
            set { id = value; }
        }


        #endregion
    }
}
