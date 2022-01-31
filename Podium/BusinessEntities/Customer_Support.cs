using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Customer_Support
	{
		#region Fields

		private string deptName=String.Empty;
		private DateTime regDate=DateTime.MaxValue;
		private string visitNumber=String.Empty;
		private string patientName=String.Empty;
		private string clientCode=String.Empty;
		private string clientName=String.Empty;
		private string tCODE=String.Empty;
		private string tNAME=String.Empty;
		private string status=String.Empty;
		private string approvedBy=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DeptName value.
		/// </summary>
		public string DeptName
		{
			get { return deptName; }
			set { deptName = value; }
		}

		/// <summary>
		/// Gets or sets the RegDate value.
		/// </summary>
		public DateTime RegDate
		{
			get { return regDate; }
			set { regDate = value; }
		}

		/// <summary>
		/// Gets or sets the VisitNumber value.
		/// </summary>
		public string VisitNumber
		{
			get { return visitNumber; }
			set { visitNumber = value; }
		}

		/// <summary>
		/// Gets or sets the PatientName value.
		/// </summary>
		public string PatientName
		{
			get { return patientName; }
			set { patientName = value; }
		}

		/// <summary>
		/// Gets or sets the ClientCode value.
		/// </summary>
		public string ClientCode
		{
			get { return clientCode; }
			set { clientCode = value; }
		}

		/// <summary>
		/// Gets or sets the ClientName value.
		/// </summary>
		public string ClientName
		{
			get { return clientName; }
			set { clientName = value; }
		}

		/// <summary>
		/// Gets or sets the TCODE value.
		/// </summary>
		public string TCODE
		{
			get { return tCODE; }
			set { tCODE = value; }
		}

		/// <summary>
		/// Gets or sets the TNAME value.
		/// </summary>
		public string TNAME
		{
			get { return tNAME; }
			set { tNAME = value; }
		}

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the ApprovedBy value.
		/// </summary>
		public string ApprovedBy
		{
			get { return approvedBy; }
			set { approvedBy = value; }
		}


		#endregion
}
}
