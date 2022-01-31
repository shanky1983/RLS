using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class NewInstanceVisitPurpose
	{
		#region Fields

		private int newInstanceWaitID=0;
		private int visitPurposeID=0;
		private string visitPurposeName=String.Empty;
		private string visitType=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the NewInstanceWaitID value.
		/// </summary>
		public int NewInstanceWaitID
		{
			get { return newInstanceWaitID; }
			set { newInstanceWaitID = value; }
		}

		/// <summary>
		/// Gets or sets the VisitPurposeID value.
		/// </summary>
		public int VisitPurposeID
		{
			get { return visitPurposeID; }
			set { visitPurposeID = value; }
		}

		/// <summary>
		/// Gets or sets the VisitPurposeName value.
		/// </summary>
		public string VisitPurposeName
		{
			get { return visitPurposeName; }
			set { visitPurposeName = value; }
		}

		/// <summary>
		/// Gets or sets the VisitType value.
		/// </summary>
		public string VisitType
		{
			get { return visitType; }
			set { visitType = value; }
		}


		#endregion
}
}
