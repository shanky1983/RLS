using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class TabMaster
	{
		#region Fields

		private int tabMasterId=0;
		private string type=String.Empty;
		private string code=String.Empty;
		private string name=String.Empty;
		private int sequenceNo=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the TabMasterId value.
		/// </summary>
		public int TabMasterId
		{
			get { return tabMasterId; }
			set { tabMasterId = value; }
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
		/// Gets or sets the Code value.
		/// </summary>
		public string Code
		{
			get { return code; }
			set { code = value; }
		}

		/// <summary>
		/// Gets or sets the Name value.
		/// </summary>
		public string Name
		{
			get { return name; }
			set { name = value; }
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
		/// Gets or sets the HasAccess value.
		/// </summary>
		private bool _hasAccess=false;
		public bool HasAccess
		{
			get { return  _hasAccess; }
			set { _hasAccess = value; }
		}

		/// <summary>
		/// Gets or sets the Isdefault value.
		/// </summary>
		private bool _isdefault=false;
		public bool Isdefault
		{
			get { return  _isdefault; }
			set { _isdefault = value; }
		}


		#endregion
}
}
