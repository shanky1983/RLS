using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class BillDetails
    {
        private string secret = String.Empty;
        private Int64 facility_id = 0;
        private Int64 client_id = 0;
        private Int64 billing_id = 0;
        private Int64 transaction_id = 0;
        private string test_type = String.Empty;
        private string test_detail = String.Empty;
        private DateTime test_datetime = DateTime.MaxValue;
        private string patient_name = String.Empty;
        private string patient_lastname = String.Empty;
        private string ref_physician = String.Empty;
        private string ref_clinic = string.Empty;
        private string status = String.Empty;
        private DateTime updated_at= DateTime.MaxValue;
        private DateTime created_at = DateTime.MaxValue;
        private long id = 0;

        public string Secret
        {
            get { return secret; }
            set { secret = value; }
        }
        public long Facility_id
        {
            get { return facility_id; }
            set { facility_id = value; }
        }
        public long Client_id
        {
            get { return client_id; }
            set { client_id = value; }
        }
        public Int64 Billing_id
        {
            get { return billing_id; }
            set { billing_id = value; }
        }
        public Int64 Transaction_id
        {
            get { return transaction_id; }
            set { transaction_id = value; }
        }
        public string Test_type
        {
            get { return test_type; }
            set { test_type = value; }
        }
        public string Test_detail
        {
            get { return test_detail; }
            set { test_detail = value; }
        }
        public DateTime Test_datetime
        {
            get { return test_datetime; }
            set { test_datetime = value; }
        }
        public string Patient_name
        {
            get { return patient_name; }
            set { patient_name = value; }
        }
        public string Patient_lastname
        {
            get { return patient_lastname; }
            set { patient_lastname = value; }
        }
        public string Ref_physician
        {
            get { return ref_physician; }
            set { ref_physician = value; }
        }
        public string Ref_clinic
        {
            get { return ref_clinic; }
            set { ref_clinic = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public DateTime Updated_at
        {
            get { return updated_at; }
            set { updated_at = value; }
        }
        public DateTime Created_at
        {
            get { return created_at; }
            set { created_at = value; }
        }
        public long Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
