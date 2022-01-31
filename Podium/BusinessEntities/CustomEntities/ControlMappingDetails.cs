using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ControlMappingDetails
	{
		#region Fields

		private int controlTypeID=0;
		private string controlName=String.Empty;
		private string controlCode=String.Empty;
		private long controlMappingID=0;
		private string displayText=String.Empty;
		private int orgID=0;
		private long referenceID=0;
		private string referenceType=String.Empty;
		private int sequenceNo=0;
		private long controlValueID=0;
		private string controlValue=String.Empty;
		private string description=String.Empty;
		private long iD=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ControlTypeID value.
		/// </summary>
		public int ControlTypeID
		{
			get { return controlTypeID; }
			set { controlTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the ControlName value.
		/// </summary>
		public string ControlName
		{
			get { return controlName; }
			set { controlName = value; }
		}

		/// <summary>
		/// Gets or sets the ControlCode value.
		/// </summary>
		public string ControlCode
		{
			get { return controlCode; }
			set { controlCode = value; }
		}

		/// <summary>
		/// Gets or sets the ControlMappingID value.
		/// </summary>
		public long ControlMappingID
		{
			get { return controlMappingID; }
			set { controlMappingID = value; }
		}

		/// <summary>
		/// Gets or sets the DispalyText value.
		/// </summary>
		public string DisplayText
		{
            get { return displayText; }
            set { displayText = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceID value.
		/// </summary>
		public long ReferenceID
		{
			get { return referenceID; }
			set { referenceID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceType value.
		/// </summary>
		public string ReferenceType
		{
			get { return referenceType; }
			set { referenceType = value; }
		}

		/// <summary>
		/// Gets or sets the SequenceNo value.
		/// </summary>
		public int SequenceNo
		{
			get { return sequenceNo; }
			set { sequenceNo = value; }
		}

		/// <summary>
		/// Gets or sets the ControlValueID value.
		/// </summary>
		public long ControlValueID
		{
			get { return controlValueID; }
			set { controlValueID = value; }
		}

		/// <summary>
		/// Gets or sets the ControlValue value.
		/// </summary>
		public string ControlValue
		{
			get { return controlValue; }
			set { controlValue = value; }
		}

		/// <summary>
		/// Gets or sets the Description value.
		/// </summary>
		public string Description
		{
			get { return description; }
			set { description = value; }
		}

		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public long ID
		{
			get { return iD; }
			set { iD = value; }
		}


		#endregion
}
}
