using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Sysdiagrams
	{
		#region Fields

		private string name=String.Empty;
		private int principal_id=0;
		private int diagram_id=0;
		private int version=0;
		private byte[] definition=new byte[0];

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Name value.
		/// </summary>
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		/// <summary>
		/// Gets or sets the Principal_id value.
		/// </summary>
		public int Principal_id
		{
			get { return principal_id; }
			set { principal_id = value; }
		}

		/// <summary>
		/// Gets or sets the Diagram_id value.
		/// </summary>
		public int Diagram_id
		{
			get { return diagram_id; }
			set { diagram_id = value; }
		}

		/// <summary>
		/// Gets or sets the Version value.
		/// </summary>
		public int Version
		{
			get { return version; }
			set { version = value; }
		}

		/// <summary>
		/// Gets or sets the Definition value.
		/// </summary>
		public byte[] Definition
		{
			get { return definition; }
			set { definition = value; }
		}


		#endregion
}
}
