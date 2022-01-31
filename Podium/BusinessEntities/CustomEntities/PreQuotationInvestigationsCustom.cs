using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities.CustomEntities
{
    public class PreQuotationInvestigationsCustom
    {
        #region Fields
       private long quotationid = 0;
        private long id = 0;
        private string name = String.Empty;
        private string type = String.Empty;
        private string sampletype = String.Empty;
        private int samplecount = 0;
        private string discounttype = String.Empty;
        private decimal discountvalue = Decimal.Zero;
        private decimal amount = Decimal.Zero;
        private string status = String.Empty;
        private long pkgid = 0;
        private string pkgname = String.Empty;
        private long accessionnumber = 0;
        private decimal pkgamt = Decimal.Zero;
        #endregion

        #region Properties

        public long QuotationID
        {
            get { return quotationid; }
            set { quotationid = value; }

        }

        public long ID
        {
            get { return id; }
            set { id = value; }

        }

        public string Name
        {
            get { return name; }
            set { name = value; }

        }

        public string Type
        {
            get { return type; }
            set { type = value; }

        }
        public string SampleType
        {
            get { return sampletype; }
            set { sampletype = value; }

        }
        public int SampleCount
        {
            get { return samplecount; }
            set { samplecount = value; }

        }
        public string DiscountType
        {
            get { return discounttype; }
            set { discounttype = value; }

        }
        public decimal DiscountValue
        {
            get { return discountvalue; }
            set { discountvalue = value; }

        }
        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }

        }
        public string Status
        {
            get { return status; }
            set { status = value; }

        }
        public long PkgID
        {
            get { return pkgid; }
            set { pkgid = value; }

        }
        public string PkgName
        {
            get { return pkgname; }
            set { pkgname = value; }

        }
        public long AccessionNumber
        {
            get { return accessionnumber; }
            set { accessionnumber = value; }

        }
        public decimal PkgAmt
        {
            get { return pkgamt; }
            set { pkgamt = value; }

        }
        #endregion

    }
}
