using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Speciality
	{
		#region Fields

		private int specialityID=0;
		private string specialityName=String.Empty;
		private string createdBy=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;
		private string modifiedBy=String.Empty;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long attuneID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the SpecialityID value.
		/// </summary>
		public int SpecialityID
		{
			get { return specialityID; }
			set { specialityID = value; }
		}

		/// <summary>
		/// Gets or sets the SpecialityName value.
		/// </summary>
		public string SpecialityName
		{
			get { return specialityName; }
			set { specialityName = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public string CreatedBy
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
		public string ModifiedBy
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
		/// Gets or sets the AttuneID value.
		/// </summary>
		public long AttuneID
		{
			get { return attuneID; }
			set { attuneID = value; }
		}

		/// <summary>
		/// Gets or sets the PhysicianName value.
		/// </summary>
		private string _physicianName=String.Empty;
		public string PhysicianName
		{
			get { return  _physicianName; }
			set { _physicianName = value; }
		}

		/// <summary>
		/// Gets or sets the PhysicianID value.
		/// </summary>
		private long _physicianID=0;
		public long PhysicianID
		{
			get { return  _physicianID; }
			set { _physicianID = value; }
		}

		/// <summary>
		/// Gets or sets the SpecialityCommands value.
		/// </summary>
		private String _specialityCommands=String.Empty;
		public String SpecialityCommands
		{
			get { return  _specialityCommands; }
			set { _specialityCommands = value; }
		}

		/// <summary>
		/// Gets or sets the Active value.
		/// </summary>
		private String _active=String.Empty;
		public String Active
		{
			get { return  _active; }
			set { _active = value; }
		}

		/// <summary>
		/// Gets or sets the PhysicianFeeID value.
		/// </summary>
		private long _physicianFeeID=0;
		public long PhysicianFeeID
		{
			get { return  _physicianFeeID; }
			set { _physicianFeeID = value; }
		}

		/// <summary>
		/// Gets or sets the PerformingPhysicianID value.
		/// </summary>
		private long _performingPhysicianID=0;
		public long PerformingPhysicianID
		{
			get { return  _performingPhysicianID; }
			set { _performingPhysicianID = value; }
		}

		/// <summary>
		/// Gets or sets the PerformingPhysicianName value.
		/// </summary>
		private string _performingPhysicianName=String.Empty;
		public string PerformingPhysicianName
		{
			get { return  _performingPhysicianName; }
			set { _performingPhysicianName = value; }
		}

		/// <summary>
		/// Gets or sets the ProcessedStatus value.
		/// </summary>
		private string _processedStatus=String.Empty;
		public string ProcessedStatus
		{
			get { return  _processedStatus; }
			set { _processedStatus = value; }
		}

		/// <summary>
		/// Gets or sets the Priority value.
		/// </summary>
		private int _priority=0;
		public int Priority
		{
			get { return  _priority; }
			set { _priority = value; }
		}


		#endregion
}
}
