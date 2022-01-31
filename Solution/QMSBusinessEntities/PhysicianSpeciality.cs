using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class PhysicianSpeciality
	{
		#region Fields

		private int physicianSpecialityID=0;
		private long physicianID=0;
		private int specialityID=0;
		private string createdBy=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;
		private string modifiedBy=String.Empty;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string isActive=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PhysicianSpecialityID value.
		/// </summary>
		public int PhysicianSpecialityID
		{
			get { return physicianSpecialityID; }
			set { physicianSpecialityID = value; }
		}

		/// <summary>
		/// Gets or sets the PhysicianID value.
		/// </summary>
		public long PhysicianID
		{
			get { return physicianID; }
			set { physicianID = value; }
		}

		/// <summary>
		/// Gets or sets the SpecialityID value.
		/// </summary>
		public int SpecialityID
		{
			get { return specialityID; }
			set { specialityID = value; }
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
		/// Gets or sets the IsActive value.
		/// </summary>
		public string IsActive
		{
			get { return isActive; }
			set { isActive = value; }
		}

		/// <summary>
		/// Gets or sets the SpecialityName value.
		/// </summary>
		string _specialityname;
		public string SpecialityName
		{
			get { return _specialityname; }
			set { _specialityname = value; }
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
		/// Gets or sets the LoginID value.
		/// </summary>
		long _loginid;
		public long LoginID
		{
			get { return _loginid; }
			set { _loginid = value; }
		}

		/// <summary>
		/// Gets or sets the PhysicianFeeID value.
		/// </summary>
		long _physicianfeeid;
		public long PhysicianFeeID
		{
			get { return _physicianfeeid; }
			set { _physicianfeeid = value; }
		}

		/// <summary>
		/// Gets or sets the PhysicianSpecialityCommands value.
		/// </summary>
		String _physicianspecialitycommands;
		public String PhysicianSpecialityCommands
		{
			get { return _physicianspecialitycommands; }
			set { _physicianspecialitycommands = value; }
		}


		#endregion
}
}
