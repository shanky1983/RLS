using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class AnalyserMaintanence
	{
		#region Fields

		private long instrumentID=0;
		private DateTime maintenanceDoneDate=DateTime.MaxValue;
		private DateTime maintenanceDueDate=DateTime.MaxValue;
		private long iD=0;
		private int orgid=0;
		private DateTime calibrationDoneDate=DateTime.MaxValue;
		private DateTime calibrationDueDate=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the InstrumentID value.
		/// </summary>
		public long InstrumentID
		{
			get { return instrumentID; }
			set { instrumentID = value; }
		}

		/// <summary>
		/// Gets or sets the MaintenanceDoneDate value.
		/// </summary>
		public DateTime MaintenanceDoneDate
		{
			get { return maintenanceDoneDate; }
			set { maintenanceDoneDate = value; }
		}

		/// <summary>
		/// Gets or sets the MaintenanceDueDate value.
		/// </summary>
		public DateTime MaintenanceDueDate
		{
			get { return maintenanceDueDate; }
			set { maintenanceDueDate = value; }
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
		/// Gets or sets the Orgid value.
		/// </summary>
		public int Orgid
		{
			get { return orgid; }
			set { orgid = value; }
		}

		/// <summary>
		/// Gets or sets the CalibrationDoneDate value.
		/// </summary>
		public DateTime CalibrationDoneDate
		{
			get { return calibrationDoneDate; }
			set { calibrationDoneDate = value; }
		}

		/// <summary>
		/// Gets or sets the CalibrationDueDate value.
		/// </summary>
		public DateTime CalibrationDueDate
		{
			get { return calibrationDueDate; }
			set { calibrationDueDate = value; }
		}


		#endregion
}
}
