using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class FoodOrderedDetails
    {
        #region Fields

        private long wardID = 0;
        private string wardname = string.Empty;
        private long foodmenuID = 0;
        private string foodmenuName = string.Empty;
        private long foodID = 0;
        private string foodname = string.Empty;
        private string status = string.Empty;
        private string uom = string.Empty;
        private decimal quantity = 0;
        private DateTime foodordereddate = DateTime.MinValue;
        private long orderBy = 0;
        private decimal totalQuantity = 0;
        private string orderStatus = string.Empty;
        private long foodOrderID = 0;
        private long patientDietPlanID = 0;
        private string name = string.Empty;
        private long patientID = 0;
        private string foodSessionName = string.Empty;
        private DateTime startDate = DateTime.MinValue;
        private DateTime enddate = DateTime.MinValue;
        private string foodOrdersID = string.Empty;
        private long rowID = 0;

        #endregion


        #region Properties

        public long WardID
        {
            get { return wardID; }
            set { wardID = value; }
        }
        public string WardName
        {
            get { return wardname; }
            set { wardname = value; }
        }
        public long FoodMenuID
        {
            get { return foodmenuID; }
            set { foodmenuID = value; }
        }
        public string FoodMenuName
        {
            get { return foodmenuName; }
            set { foodmenuName = value; }
        }
        public long FoodID
        {
            get { return foodID; }
            set { foodID = value; }
        }
        public string FoodName
        {
            get { return foodname; }
            set { foodname = value; }
        }

        public string FoodSessionName
        {
            get { return foodSessionName; }
            set { foodSessionName = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public string UOM
        {
            get { return uom; }
            set { uom = value; }
        }

        public decimal Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public DateTime FoodOrderDate
        {
            get { return foodordereddate; }
            set { foodordereddate = value; }
        }

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public DateTime Enddate
        {
            get { return enddate; }
            set { enddate = value; }
        }

        public long OrderBy
        {
            get { return orderBy; }
            set { orderBy = value; }
        }

        public decimal TotalQuantity
        {
            get { return totalQuantity; }
            set { totalQuantity = value; }
        }

        public string OrderStatus
        {
            get { return orderStatus; }
            set { orderStatus = value; }
        }

        public long FoodOrderID
        {
            get { return foodOrderID; }
            set { foodOrderID = value; }
        }

        public long PatientDietPlanID
        {
            get { return patientDietPlanID; }
            set { patientDietPlanID = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public long PatientID
        {
            get { return patientID; }
            set { patientID = value; }
        }

        public string FoodOrdersID
        {
            get { return foodOrdersID; }
            set { foodOrdersID = value; }
        }


        public long Rowid
        {
            get { return rowID; }
            set { rowID = value; }
        }


        #endregion
    }
}
