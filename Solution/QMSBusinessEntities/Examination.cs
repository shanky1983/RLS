using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Examination
	{
		#region Fields

		private int examinationID=0;
		private string examinationName=String.Empty;
		private string examinationDesc=String.Empty;
		private string examinationType=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int parentID=0;
		private string hashAttribute=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ExaminationID value.
		/// </summary>
		public int ExaminationID
		{
			get { return examinationID; }
			set { examinationID = value; }
		}

		/// <summary>
		/// Gets or sets the ExaminationName value.
		/// </summary>
		public string ExaminationName
		{
			get { return examinationName; }
			set { examinationName = value; }
		}

		/// <summary>
		/// Gets or sets the ExaminationDesc value.
		/// </summary>
		public string ExaminationDesc
		{
			get { return examinationDesc; }
			set { examinationDesc = value; }
		}

		/// <summary>
		/// Gets or sets the ExaminationType value.
		/// </summary>
		public string ExaminationType
		{
			get { return examinationType; }
			set { examinationType = value; }
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
		/// Gets or sets the ParentID value.
		/// </summary>
		public int ParentID
		{
			get { return parentID; }
			set { parentID = value; }
		}

		/// <summary>
		/// Gets or sets the HashAttribute value.
		/// </summary>
		public string HashAttribute
		{
			get { return hashAttribute; }
			set { hashAttribute = value; }
		}

		/// <summary>
		/// Gets or sets the HasChild value.
		/// </summary>
		int _haschild;
		public int HasChild
		{
			get { return _haschild; }
			set { _haschild = value; }
		}

		/// <summary>
		/// Gets or sets the ChildNodeCount value.
		/// </summary>
		int _childnodecount;
		public int ChildNodeCount
		{
			get { return _childnodecount; }
			set { _childnodecount = value; }
		}


		#endregion
}
}
