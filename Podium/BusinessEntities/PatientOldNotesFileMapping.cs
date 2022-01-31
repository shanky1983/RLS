using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PatientOldNotesFileMapping
	{
		#region Fields

		private long fileID=0;
		private long patienOldNotesID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the FileID value.
		/// </summary>
		public long FileID
		{
			get { return fileID; }
			set { fileID = value; }
		}

		/// <summary>
		/// Gets or sets the PatienOldNotesID value.
		/// </summary>
		public long PatienOldNotesID
		{
			get { return patienOldNotesID; }
			set { patienOldNotesID = value; }
		}


		#endregion
}
}
