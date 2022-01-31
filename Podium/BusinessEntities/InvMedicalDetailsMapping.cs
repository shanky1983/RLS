using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InvMedicalDetailsMapping
	{
		#region Fields

		private long invMedMappingID=0;
		private long invID=0;
		private int medicalDetailID=0;
		private string medicalDetailType=String.Empty;
		private decimal meanTime=Decimal.Zero;
		private string isInternal=String.Empty;
		private string isMandatory=String.Empty;
		private string invType=String.Empty;
		private int orgId=0;
		private int historySequence=0;
		private string isActive=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the InvMedMappingID value.
		/// </summary>
		public long InvMedMappingID
		{
			get { return invMedMappingID; }
			set { invMedMappingID = value; }
		}

		/// <summary>
		/// Gets or sets the InvID value.
		/// </summary>
		public long InvID
		{
			get { return invID; }
			set { invID = value; }
		}

		/// <summary>
		/// Gets or sets the MedicalDetailID value.
		/// </summary>
		public int MedicalDetailID
		{
			get { return medicalDetailID; }
			set { medicalDetailID = value; }
		}

		/// <summary>
		/// Gets or sets the MedicalDetailType value.
		/// </summary>
		public string MedicalDetailType
		{
			get { return medicalDetailType; }
			set { medicalDetailType = value; }
		}

		/// <summary>
		/// Gets or sets the MeanTime value.
		/// </summary>
		public decimal MeanTime
		{
			get { return meanTime; }
			set { meanTime = value; }
		}

		/// <summary>
		/// Gets or sets the IsInternal value.
		/// </summary>
		public string IsInternal
		{
			get { return isInternal; }
			set { isInternal = value; }
		}

		/// <summary>
		/// Gets or sets the IsMandatory value.
		/// </summary>
		public string IsMandatory
		{
			get { return isMandatory; }
			set { isMandatory = value; }
		}

		/// <summary>
		/// Gets or sets the InvType value.
		/// </summary>
		public string InvType
		{
			get { return invType; }
			set { invType = value; }
		}

		/// <summary>
		/// Gets or sets the OrgId value.
		/// </summary>
		public int OrgId
		{
			get { return orgId; }
			set { orgId = value; }
		}

		/// <summary>
		/// Gets or sets the HistorySequence value.
		/// </summary>
		public int HistorySequence
		{
			get { return historySequence; }
			set { historySequence = value; }
		}

		/// <summary>
		/// Gets or sets the IsActive value.
		/// </summary>
		public string IsActive
		{
			get { return isActive; }
			set { isActive = value; }
		}

		/// <summary>
		/// Gets or sets the TestName value.
		/// </summary>
		private string _testName=String.Empty;
		public string TestName
		{
			get { return  _testName; }
			set { _testName = value; }
		}

		/// <summary>
		/// Gets or sets the TemplateName value.
		/// </summary>
		private string _templateName=String.Empty;
		public string TemplateName
		{
			get { return  _templateName; }
			set { _templateName = value; }
		}

		/// <summary>
		/// Gets or sets the OperationType value.
		/// </summary>
		private string _operationType=String.Empty;
		public string OperationType
		{
			get { return  _operationType; }
			set { _operationType = value; }
		}


		#endregion
}
}
