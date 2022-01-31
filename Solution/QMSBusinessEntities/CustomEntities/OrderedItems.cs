using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
   public class OrderedItems
    {
        #region Fields
        private long detailsID = 0;
        private long feeId = 0;
        private string feeType = String.Empty;
        private string description = String.Empty;
        private decimal amount = 0;
        private decimal unit = 0;
        private string fromTable = String.Empty;
        private long taskID = 0;
        private string reason = String.Empty;
        private string reasonType = String.Empty;

        #endregion


        public long DetailsID
        {
            get { return detailsID; }
            set { detailsID = value; }
        }
        public long FeeId
        {
            get { return feeId; }
            set { feeId = value; }
        }

        public string FeeType
        {
            get { return feeType; }
            set { feeType = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public decimal Unit
        {
            get { return unit; }
            set { unit = value; }
        }
        public string FromTable
        {
            get { return fromTable; }
            set { fromTable = value; }
        }

        public long TaskID
        {
            get { return taskID; }
            set { taskID = value; }
        }
        public string Reason
        {
            get { return reason; }
            set { reason = value; }
        }
        public string ReasonType
        {
            get { return reasonType; }
            set { reasonType = value; }
        }

        private string deptName = String.Empty;
        public string DeptName
        {
            get { return deptName; }
            set { deptName = value; }
        }

        private string investigationName = String.Empty;
        public string InvestigationName
        {
            get { return investigationName; }
            set { investigationName = value; }
        }


        private DateTime orderDate = DateTime.MaxValue;
        public DateTime  OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }


        private long accessionNumber = 0;
        public long  AccessionNumber
        {
            get { return accessionNumber; }
            set { accessionNumber = value; }
        }

        private string outputFormatName = String.Empty;
        public string OutputFormatName
        {
            get { return outputFormatName; }
            set { outputFormatName = value; }
        }


        private string outputFormatPath = String.Empty;
        public string OutputFormatPath
        {
            get { return outputFormatPath; }
            set { outputFormatPath = value; }
        }

        private string functionName = String.Empty;
        public string FunctionName
        {
            get { return functionName; }
            set { functionName = value; }
        }


    }
}
