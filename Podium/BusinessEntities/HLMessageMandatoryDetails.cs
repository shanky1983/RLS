using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class HLMessageMandatoryDetails
	{
		#region Fields

		private long hLMessageMandatoryDetailsID=0;
		private string hLMessageTable=String.Empty;
		private string hLMessageColumns=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private string tableCode=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the HLMessageMandatoryDetailsID value.
		/// </summary>
		public long HLMessageMandatoryDetailsID
		{
			get { return hLMessageMandatoryDetailsID; }
			set { hLMessageMandatoryDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the HLMessageTable value.
		/// </summary>
		public string HLMessageTable
		{
			get { return hLMessageTable; }
			set { hLMessageTable = value; }
		}

		/// <summary>
		/// Gets or sets the HLMessageColumns value.
		/// </summary>
		public string HLMessageColumns
		{
			get { return hLMessageColumns; }
			set { hLMessageColumns = value; }
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
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public long CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
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
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public long ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}

		/// <summary>
		/// Gets or sets the TableCode value.
		/// </summary>
		public string TableCode
		{
			get { return tableCode; }
			set { tableCode = value; }
		}

		/// <summary>
		/// Gets or sets the IsMandatory value.
		/// </summary>
		private string _isMandatory=String.Empty;
		public string IsMandatory
		{
			get { return  _isMandatory; }
			set { _isMandatory = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		private int _orgID=0;
		public int OrgID
		{
			get { return  _orgID; }
			set { _orgID = value; }
		}

		/// <summary>
		/// Gets or sets the LocationID value.
		/// </summary>
		private long _locationID=0;
		public long LocationID
		{
			get { return  _locationID; }
			set { _locationID = value; }
		}

		/// <summary>
		/// Gets or sets the ErrorMessage value.
		/// </summary>
		private string _errorMessage=String.Empty;
		public string ErrorMessage
		{
			get { return  _errorMessage; }
			set { _errorMessage = value; }
		}


		#endregion
}
}
