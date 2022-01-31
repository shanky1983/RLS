using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class VEH_SCHEMA_LOG
	{
		#region Fields

		private int id=0;
		private string uSER_NAME=String.Empty;
		private string eVT_TYPE=String.Empty;
		private string oBJ_NAME=String.Empty;
		private string oBJ_TYPE=String.Empty;
		private DateTime cREATE_DTTM=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id value.
		/// </summary>
		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		/// <summary>
		/// Gets or sets the USER_NAME value.
		/// </summary>
		public string USER_NAME
		{
			get { return uSER_NAME; }
			set { uSER_NAME = value; }
		}

		/// <summary>
		/// Gets or sets the EVT_TYPE value.
		/// </summary>
		public string EVT_TYPE
		{
			get { return eVT_TYPE; }
			set { eVT_TYPE = value; }
		}

		/// <summary>
		/// Gets or sets the OBJ_NAME value.
		/// </summary>
		public string OBJ_NAME
		{
			get { return oBJ_NAME; }
			set { oBJ_NAME = value; }
		}

		/// <summary>
		/// Gets or sets the OBJ_TYPE value.
		/// </summary>
		public string OBJ_TYPE
		{
			get { return oBJ_TYPE; }
			set { oBJ_TYPE = value; }
		}

		/// <summary>
		/// Gets or sets the CREATE_DTTM value.
		/// </summary>
		public DateTime CREATE_DTTM
		{
			get { return cREATE_DTTM; }
			set { cREATE_DTTM = value; }
		}


		#endregion
}
}
