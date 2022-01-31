using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Bk_sep_invpackagemapping
	{
		#region Fields

		private int packageID=0;
		private long iD=0;
		private string type=String.Empty;
		private int sequenceNo=0;
		private string active=String.Empty;
		private string printSeparately=String.Empty;
		private long mapid=0;
		private string isReflex=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PackageID value.
		/// </summary>
		public int PackageID
		{
			get { return packageID; }
			set { packageID = value; }
		}

		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public long ID
		{
			get { return iD; }
			set { iD = value; }
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
		/// Gets or sets the SequenceNo value.
		/// </summary>
		public int SequenceNo
		{
			get { return sequenceNo; }
			set { sequenceNo = value; }
		}

		/// <summary>
		/// Gets or sets the Active value.
		/// </summary>
		public string Active
		{
			get { return active; }
			set { active = value; }
		}

		/// <summary>
		/// Gets or sets the PrintSeparately value.
		/// </summary>
		public string PrintSeparately
		{
			get { return printSeparately; }
			set { printSeparately = value; }
		}

		/// <summary>
		/// Gets or sets the Mapid value.
		/// </summary>
		public long Mapid
		{
			get { return mapid; }
			set { mapid = value; }
		}

		/// <summary>
		/// Gets or sets the IsReflex value.
		/// </summary>
		public string IsReflex
		{
			get { return isReflex; }
			set { isReflex = value; }
		}


		#endregion
}
}
