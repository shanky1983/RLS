using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PatientDietMenuHeader
	{
		#region Fields

		private long menuOrderNo=0;
		private long patFoodMenuId=0;
		private DateTime raisedDatetime=DateTime.MaxValue;
		private long raisedBy=0;
		private DateTime expectedDeliveryTime=DateTime.MaxValue;
		private DateTime deliveredDatetime=DateTime.MaxValue;
		private long deliveredBy=0;
		private DateTime receivedTime=DateTime.MaxValue;
		private long receivedBy=0;
		private string status=String.Empty;
		private long patDietMenuMasterId=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the MenuOrderNo value.
		/// </summary>
		public long MenuOrderNo
		{
			get { return menuOrderNo; }
			set { menuOrderNo = value; }
		}

		/// <summary>
		/// Gets or sets the PatFoodMenuId value.
		/// </summary>
		public long PatFoodMenuId
		{
			get { return patFoodMenuId; }
			set { patFoodMenuId = value; }
		}

		/// <summary>
		/// Gets or sets the RaisedDatetime value.
		/// </summary>
		public DateTime RaisedDatetime
		{
			get { return raisedDatetime; }
			set { raisedDatetime = value; }
		}

		/// <summary>
		/// Gets or sets the RaisedBy value.
		/// </summary>
		public long RaisedBy
		{
			get { return raisedBy; }
			set { raisedBy = value; }
		}

		/// <summary>
		/// Gets or sets the ExpectedDeliveryTime value.
		/// </summary>
		public DateTime ExpectedDeliveryTime
		{
			get { return expectedDeliveryTime; }
			set { expectedDeliveryTime = value; }
		}

		/// <summary>
		/// Gets or sets the DeliveredDatetime value.
		/// </summary>
		public DateTime DeliveredDatetime
		{
			get { return deliveredDatetime; }
			set { deliveredDatetime = value; }
		}

		/// <summary>
		/// Gets or sets the DeliveredBy value.
		/// </summary>
		public long DeliveredBy
		{
			get { return deliveredBy; }
			set { deliveredBy = value; }
		}

		/// <summary>
		/// Gets or sets the ReceivedTime value.
		/// </summary>
		public DateTime ReceivedTime
		{
			get { return receivedTime; }
			set { receivedTime = value; }
		}

		/// <summary>
		/// Gets or sets the ReceivedBy value.
		/// </summary>
		public long ReceivedBy
		{
			get { return receivedBy; }
			set { receivedBy = value; }
		}

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the PatDietMenuMasterId value.
		/// </summary>
		public long PatDietMenuMasterId
		{
			get { return patDietMenuMasterId; }
			set { patDietMenuMasterId = value; }
		}


		#endregion
}
}
