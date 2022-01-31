using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class HistoryMappingmaster
    {
        #region Fields        
        //History name Dropdown list load text and value...
        private string historyName = string.Empty;
        private Int32 historyID;
        //Auto complte load text and value...
        private string codingSchemaName = string.Empty;
        private string codeName = string.Empty;
        private int identifyingID;
        private string identifyingType = string.Empty;
        //Mapping new history to the Test name...
        private decimal meanTime;
        private string isInternal;
        private string isMandatory;
        

        #endregion 

        #region Properties
        public string HistoryName
        {
            get
            {
                return historyName;
            }
            set
            {
                historyName = value;
            }
        }
        public Int32 HistoryID
        {
            get
            {
                return historyID;
            }
            set
            {
                historyID = value;
            }
        }
        public string CodingSchemaName
        {
            get
            {
                return codingSchemaName;
            }
            set
            {
                codingSchemaName = value;
            }
        }
        public string CodeName
        {
            get
            {
                return codeName;
            }
            set
            {
                codeName = value;
            }
        }
        public int IdentifyingID
        {
            get
            {
                return identifyingID;
            }
            set
            {
                identifyingID = value;
            }
        }
        public string IdentifyingType
        {
            get
            {
                return identifyingType;
            }
            set
            {
                identifyingType = value;
            }
        }
        public decimal MeanTime
        {
            get
            {
                return meanTime;
            }
            set
            {
                meanTime = value;
            }
        }
        public string IsInternal
        {
            get
            {
                return isInternal;
            }
            set
            {
                isInternal = value;
            }
        }
        public string IsMandatory
        {
            get
            {
                return isMandatory;
            }
            set
            {
                isMandatory = value;
            }
        }

      

        #endregion
    }
}
