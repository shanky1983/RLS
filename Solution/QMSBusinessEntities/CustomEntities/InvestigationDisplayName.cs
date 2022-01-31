using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
   public class InvestigationDisplayName
    {
       #region fields

       private string investigationName = string.Empty;
       private string method = string.Empty;
       private long investigationValueID = 0;

       #endregion


        #region properties


       /// <summary>
       /// Gets or sets the InvestigationValueID value.
       /// </summary>
       public long InvestigationID
       {
           get { return investigationValueID; }
           set { investigationValueID = value; }
       }


       public string InvestigationName
       {
           get { return investigationName; }
           set { investigationName = value; }
       }

       public string Method
       {
           get { return method; }
           set { method = value; }
       }



        #endregion
    }
}
