using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class Widgetmaster_Custom
    {
        #region Fields

        private long wID = 0;
        private string wName = String.Empty;
        private string wCode = String.Empty;
        private DateTime createdat = DateTime.MaxValue;
        private long createdby = 0;
        private DateTime modifiedAt = DateTime.MaxValue;
        private long modifiedby = 0;
        private long _detailedID = 0;
        private string _detailedName = String.Empty;
        private string _icon = String.Empty;
        private int _showReport = 0;
        private string _wGCode = String.Empty;

        #endregion

        #region Properties
        public long WID
        {
            get { return wID; }
            set { wID = value; }
        }

    
        public string WName
        {
            get { return wName; }
            set { wName = value; }
        }

  
        public string WCode
        {
            get { return wCode; }
            set { wCode = value; }
        }

     
        public DateTime Createdat
        {
            get { return createdat; }
            set { createdat = value; }
        }

     
        public long Createdby
        {
            get { return createdby; }
            set { createdby = value; }
        }

     
        public DateTime ModifiedAt
        {
            get { return modifiedAt; }
            set { modifiedAt = value; }
        }

        public long Modifiedby
        {
            get { return modifiedby; }
            set { modifiedby = value; }
        }

     
       
        public long DetailedID
        {
            get { return _detailedID; }
            set { _detailedID = value; }
        }

      
       
        public string DetailedName
        {
            get { return _detailedName; }
            set { _detailedName = value; }
        }

      
       
        public string Icon
        {
            get { return _icon; }
            set { _icon = value; }
        }

   
   
        public int ShowReport
        {
            get { return _showReport; }
            set { _showReport = value; }
        }

        
       
        public string WGCode
        {
            get { return _wGCode; }
            set { _wGCode = value; }
        }


        #endregion
    }
}
