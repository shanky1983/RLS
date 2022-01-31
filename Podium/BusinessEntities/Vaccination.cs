using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Vaccination
	{
		#region Fields

		private int vaccinationID=0;
		private string vaccinationName=String.Empty;
		private string vaccDescription=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the VaccinationID value.
		/// </summary>
		public int VaccinationID
		{
			get { return vaccinationID; }
			set { vaccinationID = value; }
		}

		/// <summary>
		/// Gets or sets the VaccinationName value.
		/// </summary>
		public string VaccinationName
		{
			get { return vaccinationName; }
			set { vaccinationName = value; }
		}

		/// <summary>
		/// Gets or sets the VaccDescription value.
		/// </summary>
		public string VaccDescription
		{
			get { return vaccDescription; }
			set { vaccDescription = value; }
		}

		/// <summary>
		/// Gets or sets the SourceCategoryID value.
		/// </summary>
		private long _sourceCategoryID=0;
		public long SourceCategoryID
		{
			get { return  _sourceCategoryID; }
			set { _sourceCategoryID = value; }
		}

		/// <summary>
		/// Gets or sets the SourceCategoryName value.
		/// </summary>
		private String _sourceCategoryName=String.Empty;
		public String SourceCategoryName
		{
			get { return  _sourceCategoryName; }
			set { _sourceCategoryName = value; }
		}

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		private String _status=String.Empty;
		public String Status
		{
			get { return  _status; }
			set { _status = value; }
		}

		/// <summary>
		/// Gets or sets the ServiceCode value.
		/// </summary>
		private String _serviceCode=String.Empty;
		public String ServiceCode
		{
			get { return  _serviceCode; }
			set { _serviceCode = value; }
		}


		#endregion
}
}
