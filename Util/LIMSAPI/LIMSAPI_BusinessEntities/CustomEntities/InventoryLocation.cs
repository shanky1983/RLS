using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
	public class InventoryLocation
	{
		#region Fields

		private long locationID=0;
		private string locationName=String.Empty;
		private long pincode=0;
		private long cityID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string isDefault=String.Empty;
		private short stateID=0;
        private string locationcode = String.Empty;
        

        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the LocationID value.
        /// </summary>
        public long LocationID
		{
			get { return locationID; }
			set { locationID = value; }
		}

		/// <summary>
		/// Gets or sets the LocationName value.
		/// </summary>
		public string LocationName
		{
			get { return locationName; }
			set { locationName = value; }
		}

        /// <summary>
        /// Gets or sets the LocationCode value.
        /// </summary>
        public string LocationCode
        {
            get { return locationcode; }
            set { locationcode = value; }
        }


        

        /// <summary>
        /// Gets or sets the Pincode value.
        /// </summary>
        public long Pincode
		{
			get { return pincode; }
			set { pincode = value; }
		}

		/// <summary>
		/// Gets or sets the CityID value.
		/// </summary>
		public long CityID
		{
			get { return cityID; }
			set { cityID = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public long CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedAt value.
		/// </summary>
		public DateTime CreatedAt
		{
			get { return createdAt; }
			set { createdAt = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public long ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
		}

		/// <summary>
		/// Gets or sets the IsDefault value.
		/// </summary>
		public string IsDefault
		{
			get { return isDefault; }
			set { isDefault = value; }
		}

		/// <summary>
		/// Gets or sets the StateID value.
		/// </summary>
		public short StateID
		{
			get { return stateID; }
			set { stateID = value; }
		}


		#endregion
}
}
