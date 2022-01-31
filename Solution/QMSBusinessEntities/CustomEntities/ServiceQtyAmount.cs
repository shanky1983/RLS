using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class ServiceQtyAmount
    {
        #region Fields

        private string _event = String.Empty;
        private int _qty = 0;
        private decimal _amount = 0;

        #endregion

        public string Event
        {
            get { return _event; }
            set { _event = value; }
        }

        public int Qty
        {
            get { return _qty; }
            set { _qty = value; }
        }

        public decimal Amount
        {
            get { return _amount ; }
            set { _amount = value; }
        }
    }
}
