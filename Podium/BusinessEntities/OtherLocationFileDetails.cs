using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class OtherLocationFileDetails
	{
		#region Fields

		private long otherLocationFileDetailsID=0;
		private long hLMessageID=0;
		private string exVisitID=String.Empty;
		private string placer_Field1=String.Empty;
		private bool cancelStatus=false;
		private string errorMessage=String.Empty;
		private string hLMessageContent=String.Empty;
		private string fileStatus=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the OtherLocationFileDetailsID value.
		/// </summary>
		public long OtherLocationFileDetailsID
		{
			get { return otherLocationFileDetailsID; }
			set { otherLocationFileDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the HLMessageID value.
		/// </summary>
		public long HLMessageID
		{
			get { return hLMessageID; }
			set { hLMessageID = value; }
		}

		/// <summary>
		/// Gets or sets the ExVisitID value.
		/// </summary>
		public string ExVisitID
		{
			get { return exVisitID; }
			set { exVisitID = value; }
		}

		/// <summary>
		/// Gets or sets the Placer_Field1 value.
		/// </summary>
		public string Placer_Field1
		{
			get { return placer_Field1; }
			set { placer_Field1 = value; }
		}

		/// <summary>
		/// Gets or sets the CancelStatus value.
		/// </summary>
		public bool CancelStatus
		{
			get { return cancelStatus; }
			set { cancelStatus = value; }
		}

		/// <summary>
		/// Gets or sets the ErrorMessage value.
		/// </summary>
		public string ErrorMessage
		{
			get { return errorMessage; }
			set { errorMessage = value; }
		}

		/// <summary>
		/// Gets or sets the HLMessageContent value.
		/// </summary>
		public string HLMessageContent
		{
			get { return hLMessageContent; }
			set { hLMessageContent = value; }
		}

		/// <summary>
		/// Gets or sets the FileStatus value.
		/// </summary>
		public string FileStatus
		{
			get { return fileStatus; }
			set { fileStatus = value; }
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
