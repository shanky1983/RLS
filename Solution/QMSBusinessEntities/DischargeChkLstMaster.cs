using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class DischargeChkLstMaster
	{
		#region Fields

		private int chkLstID=0;
		private string chkLstDesc=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ChkLstID value.
		/// </summary>
		public int ChkLstID
		{
			get { return chkLstID; }
			set { chkLstID = value; }
		}

		/// <summary>
		/// Gets or sets the ChkLstDesc value.
		/// </summary>
		public string ChkLstDesc
		{
			get { return chkLstDesc; }
			set { chkLstDesc = value; }
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
		/// Gets or sets the IsChecked value.
		/// </summary>
		string _ischecked;
		public string IsChecked
		{
			get { return _ischecked; }
			set { _ischecked = value; }
		}

		/// <summary>
		/// Gets or sets the Comments value.
		/// </summary>
		string _comments;
		public string Comments
		{
			get { return _comments; }
			set { _comments = value; }
		}


		#endregion
}
}
