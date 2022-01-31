using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class LotDeviceMapping
	{
		#region Fields

		private long mappingID=0;
		private long lotID=0;
		private long instrumentID=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdby=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedby=0;
		private string isActive=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the MappingID value.
		/// </summary>
		public long MappingID
		{
			get { return mappingID; }
			set { mappingID = value; }
		}

		/// <summary>
		/// Gets or sets the LotID value.
		/// </summary>
		public long LotID
		{
			get { return lotID; }
			set { lotID = value; }
		}

		/// <summary>
		/// Gets or sets the InstrumentID value.
		/// </summary>
		public long InstrumentID
		{
			get { return instrumentID; }
			set { instrumentID = value; }
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
		/// Gets or sets the Createdby value.
		/// </summary>
		public long Createdby
		{
			get { return createdby; }
			set { createdby = value; }
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
		/// Gets or sets the Modifiedby value.
		/// </summary>
		public long Modifiedby
		{
			get { return modifiedby; }
			set { modifiedby = value; }
		}

		/// <summary>
		/// Gets or sets the IsActive value.
		/// </summary>
		public string IsActive
		{
			get { return isActive; }
			set { isActive = value; }
		}


		#endregion
}
}
