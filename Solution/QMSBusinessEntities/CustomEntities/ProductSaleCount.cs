using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class ProductSaleCount
    {
        private long _ProductID;

        public long ProductID
        {
            get { return _ProductID; }
            set { _ProductID = value; }
        }

        private string _Period;

        public string Period
        {
            get
            {
                return _Period;
            }
            set
            {
                _Period = value;
            }
        }

        private decimal _Quantity;

        public decimal Quantity
        {
            get
            {
                return _Quantity;
            }
            set
            {
                _Quantity = value;
            }
        }

    }
}
