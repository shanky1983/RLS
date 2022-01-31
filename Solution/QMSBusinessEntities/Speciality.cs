using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
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
		string _physicianname;
		public string PhysicianName
		{
			get { return _physicianname; }
			set { _physicianname = value; }
		}

		/// <summary>
		/// Gets or sets the PhysicianID value.
		/// </summary>
		long _physicianid;
		public long PhysicianID
		{
			get { return _physicianid; }
			set { _physicianid = value; }
		}

		/// <summary>
		/// Gets or sets the SpecialityCommands value.
		/// </summary>
		String _specialitycommands;
		public String SpecialityCommands
		{
			get { return _specialitycommands; }
			set { _specialitycommands = value; }
		}

		/// <summary>
		/// Gets or sets the Active value.
		/// </summary>
		String _active;
		public String Active
		{
			get { return _active; }
			set { _active = value; }
		}


		#endregion
}
}
