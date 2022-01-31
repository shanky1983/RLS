using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Error_info
	{
		#region Fields

		private short sno=0;
		private string errorDate=String.Empty;
		private string msg=String.Empty;
		private string tp=String.Empty;
		private int startoffset=0;
		private int endoffset=0;
		private int line=0;
		private byte[] planhandle=new byte[0];

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Sno value.
		/// </summary>
		public short Sno
		{
			get { return sno; }
			set { sno = value; }
		}

		/// <summary>
		/// Gets or sets the ErrorDate value.
		/// </summary>
		public string ErrorDate
		{
			get { return errorDate; }
			set { errorDate = value; }
		}

		/// <summary>
		/// Gets or sets the Msg value.
		/// </summary>
		public string Msg
		{
			get { return msg; }
			set { msg = value; }
		}

		/// <summary>
		/// Gets or sets the Tp value.
		/// </summary>
		public string Tp
		{
			get { return tp; }
			set { tp = value; }
		}

		/// <summary>
		/// Gets or sets the Startoffset value.
		/// </summary>
		public int Startoffset
		{
			get { return startoffset; }
			set { startoffset = value; }
		}

		/// <summary>
		/// Gets or sets the Endoffset value.
		/// </summary>
		public int Endoffset
		{
			get { return endoffset; }
			set { endoffset = value; }
		}

		/// <summary>
		/// Gets or sets the Line value.
		/// </summary>
		public int Line
		{
			get { return line; }
			set { line = value; }
		}

		/// <summary>
		/// Gets or sets the Planhandle value.
		/// </summary>
		public byte[] Planhandle
		{
			get { return planhandle; }
			set { planhandle = value; }
		}


		#endregion
}
}
