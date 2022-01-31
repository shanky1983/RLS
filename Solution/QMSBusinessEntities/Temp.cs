using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Temp
	{
		#region Fields

		private int groupID=0;
		private long investigationID=0;
		private string parent=String.Empty;
		private int sequenceNo=0;
		private string active=String.Empty;
		private string printSeparately=String.Empty;
		private int iD=0;
		private string isReflex=String.Empty;
		private string testName=String.Empty;
		private string tcode=String.Empty;
		private string displaytext=String.Empty;
		private string type=String.Empty;
		private decimal gENERAL=Decimal.Zero;
		private string metrolab_profilecode=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the GroupID value.
		/// </summary>
		public int GroupID
		{
			get { return groupID; }
			set { groupID = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationID value.
		/// </summary>
		public long InvestigationID
		{
			get { return investigationID; }
			set { investigationID = value; }
		}

		/// <summary>
		/// Gets or sets the Parent value.
		/// </summary>
		public string Parent
		{
			get { return parent; }
			set { parent = value; }
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
		/// Gets or sets the ID value.
		/// </summary>
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}

		/// <summary>
		/// Gets or sets the IsReflex value.
		/// </summary>
		public string IsReflex
		{
			get { return isReflex; }
			set { isReflex = value; }
		}

		/// <summary>
		/// Gets or sets the TestName value.
		/// </summary>
		public string TestName
		{
			get { return testName; }
			set { testName = value; }
		}

		/// <summary>
		/// Gets or sets the Tcode value.
		/// </summary>
		public string Tcode
		{
			get { return tcode; }
			set { tcode = value; }
		}

		/// <summary>
		/// Gets or sets the Displaytext value.
		/// </summary>
		public string Displaytext
		{
			get { return displaytext; }
			set { displaytext = value; }
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
		/// Gets or sets the GENERAL value.
		/// </summary>
		public decimal GENERAL
		{
			get { return gENERAL; }
			set { gENERAL = value; }
		}

		/// <summary>
		/// Gets or sets the Metrolab_profilecode value.
		/// </summary>
		public string Metrolab_profilecode
		{
			get { return metrolab_profilecode; }
			set { metrolab_profilecode = value; }
		}


		#endregion
}
}
