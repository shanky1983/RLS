using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Localities
	{
		#region Fields

		private long locality_ID=0;
		private string locality_Value=String.Empty;
		private string type=String.Empty;
		private long nationalityID=0;
		private int iSDCode=0;
		private int parentID=0;
		private int phoneNo_Length=0;
		private string locality_Code=String.Empty;
		private int orgID=0;
		private DateTime createdat=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private string code=String.Empty;
		private string isDefault=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Locality_ID value.
		/// </summary>
		public long Locality_ID
		{
			get { return locality_ID; }
			set { locality_ID = value; }
		}

		/// <summary>
		/// Gets or sets the Locality_Value value.
		/// </summary>
		public string Locality_Value
		{
			get { return locality_Value; }
			set { locality_Value = value; }
		}

		/// <summary>
		/// Gets or sets the Type value.
		/// </summary>
		public string Type
		{
			get { return type; }
			set { type = value; }
		}

		/// <summary>
		/// Gets or sets the NationalityID value.
		/// </summary>
		public long NationalityID
		{
			get { return nationalityID; }
			set { nationalityID = value; }
		}

		/// <summary>
		/// Gets or sets the ISDCode value.
		/// </summary>
		public int ISDCode
		{
			get { return iSDCode; }
			set { iSDCode = value; }
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
		/// Gets or sets the PhoneNo_Length value.
		/// </summary>
		public int PhoneNo_Length
		{
			get { return phoneNo_Length; }
			set { phoneNo_Length = value; }
		}

		/// <summary>
		/// Gets or sets the Locality_Code value.
		/// </summary>
		public string Locality_Code
		{
			get { return locality_Code; }
			set { locality_Code = value; }
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
		/// Gets or sets the Createdat value.
		/// </summary>
		public DateTime Createdat
		{
			get { return createdat; }
			set { createdat = value; }
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
		/// Gets or sets the Code value.
		/// </summary>
		public string Code
		{
			get { return code; }
			set { code = value; }
		}

		/// <summary>
		/// Gets or sets the IsDefault value.
		/// </summary>
		public string IsDefault
		{
			get { return isDefault; }
			set { isDefault = value; }
		}

		/// <summary>
		/// Gets or sets the ParentName value.
		/// </summary>
		string _parentname;
		public string ParentName
		{
			get { return _parentname; }
			set { _parentname = value; }
		}


		#endregion
}
}
