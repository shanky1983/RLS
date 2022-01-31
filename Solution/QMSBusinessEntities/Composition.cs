using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Composition
	{
		#region Fields

		private int compositionID=0;
		private string compositionName=String.Empty;
		private string compositionCode=String.Empty;
		private string compositionDesc=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the CompositionID value.
		/// </summary>
		public int CompositionID
		{
			get { return compositionID; }
			set { compositionID = value; }
		}

		/// <summary>
		/// Gets or sets the CompositionName value.
		/// </summary>
		public string CompositionName
		{
			get { return compositionName; }
			set { compositionName = value; }
		}

		/// <summary>
		/// Gets or sets the CompositionCode value.
		/// </summary>
		public string CompositionCode
		{
			get { return compositionCode; }
			set { compositionCode = value; }
		}

		/// <summary>
		/// Gets or sets the CompositionDesc value.
		/// </summary>
		public string CompositionDesc
		{
			get { return compositionDesc; }
			set { compositionDesc = value; }
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


		#endregion
}
}
