using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
  public  class ExpenseReport
  {
      #region Fields
      private string userName = string.Empty;
      private string Vouchernumber = string.Empty;
      private decimal amount = decimal.Zero;
      private string modeOfPayment = string.Empty;
      private string Paidto = string.Empty;
      private DateTime createdOn = DateTime.MaxValue;
      private string Orgname = string.Empty;

      #endregion

      #region Properties
      public string UserName
      {
          get { return userName; }
          set { userName = value; }
      
      }

      public string VoucherNumber
      {
          get { return Vouchernumber; }
          set { Vouchernumber = value; }

      }

      public decimal Amount
      {
          get { return amount; }
          set { amount = value; }

      }

      public string ModeOfPayment
      {
          get { return modeOfPayment; }
          set { modeOfPayment = value; }

      }

      public string PaidTo
      {
          get { return Paidto; }
          set { Paidto = value; }

      }

      public DateTime CreatedOn
      {
          get { return createdOn; }
          set { createdOn = value; }

      }
      public string OrgName
      {
          get { return Orgname; }
          set { Orgname = value; }

      }




      #endregion


  }
}
