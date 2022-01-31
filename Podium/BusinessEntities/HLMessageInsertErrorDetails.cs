using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class HLMessageInsertErrorDetails
	{
		#region Fields

		private long hLMessageInsertErrorDetailsID=0;
		private string error_err_code=String.Empty;
		private string error_msg_desc=String.Empty;
		private string error_sev_num=String.Empty;
		private string error_proc_nm=String.Empty;
		private long error_line_num=0;
		private DateTime createdAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the HLMessageInsertErrorDetailsID value.
		/// </summary>
		public long HLMessageInsertErrorDetailsID
		{
			get { return hLMessageInsertErrorDetailsID; }
			set { hLMessageInsertErrorDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the Error_err_code value.
		/// </summary>
		public string Error_err_code
		{
			get { return error_err_code; }
			set { error_err_code = value; }
		}

		/// <summary>
		/// Gets or sets the Error_msg_desc value.
		/// </summary>
		public string Error_msg_desc
		{
			get { return error_msg_desc; }
			set { error_msg_desc = value; }
		}

		/// <summary>
		/// Gets or sets the Error_sev_num value.
		/// </summary>
		public string Error_sev_num
		{
			get { return error_sev_num; }
			set { error_sev_num = value; }
		}

		/// <summary>
		/// Gets or sets the Error_proc_nm value.
		/// </summary>
		public string Error_proc_nm
		{
			get { return error_proc_nm; }
			set { error_proc_nm = value; }
		}

		/// <summary>
		/// Gets or sets the Error_line_num value.
		/// </summary>
		public long Error_line_num
		{
			get { return error_line_num; }
			set { error_line_num = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedAt value.
		/// </summary>
		public DateTime CreatedAt
		{
			get { return createdAt; }
			set { createdAt = value; }
		}


		#endregion
}
}
