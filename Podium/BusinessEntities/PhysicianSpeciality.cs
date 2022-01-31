using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
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
		private string _specialityName=String.Empty;
		public string SpecialityName
		{
			get { return  _specialityName; }
			set { _specialityName = value; }
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
		/// Gets or sets the LoginID value.
		/// </summary>
		private long _loginID=0;
		public long LoginID
		{
			get { return  _loginID; }
			set { _loginID = value; }
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
		/// Gets or sets the PhysicianSpecialityCommands value.
		/// </summary>
		private String _physicianSpecialityCommands=String.Empty;
		public String PhysicianSpecialityCommands
		{
			get { return  _physicianSpecialityCommands; }
			set { _physicianSpecialityCommands = value; }
		}


		#endregion
}
}
