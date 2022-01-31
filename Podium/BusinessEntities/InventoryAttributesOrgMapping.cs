using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InventoryAttributesOrgMapping
	{
		#region Fields

		private int mappingID=0;
		private int attributeID=0;
		private int controlTypeID=0;
		private string dataType=String.Empty;
		private int controlLength=0;
		private int orgID=0;
		private string displayText=String.Empty;
		private bool status=true;
		private DateTime createdat=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private string pagetype=String.Empty;
		private bool isMandatory=true;
		private string controlValue=String.Empty;
		private string langCode=String.Empty;
		private int seqNo=0;
		private int reportID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the MappingID value.
		/// </summary>
		public int MappingID
		{
			get { return mappingID; }
			set { mappingID = value; }
		}

		/// <summary>
		/// Gets or sets the AttributeID value.
		/// </summary>
		public int AttributeID
		{
			get { return attributeID; }
			set { attributeID = value; }
		}

		/// <summary>
		/// Gets or sets the ControlTypeID value.
		/// </summary>
		public int ControlTypeID
		{
			get { return controlTypeID; }
			set { controlTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the DataType value.
		/// </summary>
		public string DataType
		{
			get { return dataType; }
			set { dataType = value; }
		}

		/// <summary>
		/// Gets or sets the ControlLength value.
		/// </summary>
		public int ControlLength
		{
			get { return controlLength; }
			set { controlLength = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the DisplayText value.
		/// </summary>
		public string DisplayText
		{
			get { return displayText; }
			set { displayText = value; }
		}

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		public bool Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the Createdat value.
		/// </summary>
		public DateTime Createdat
		{
			get { return createdat; }
			set { createdat = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public long CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public long ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}

		/// <summary>
		/// Gets or sets the Pagetype value.
		/// </summary>
		public string Pagetype
		{
			get { return pagetype; }
			set { pagetype = value; }
		}

		/// <summary>
		/// Gets or sets the IsMandatory value.
		/// </summary>
		public bool IsMandatory
		{
			get { return isMandatory; }
			set { isMandatory = value; }
		}

		/// <summary>
		/// Gets or sets the ControlValue value.
		/// </summary>
		public string ControlValue
		{
			get { return controlValue; }
			set { controlValue = value; }
		}

		/// <summary>
		/// Gets or sets the LangCode value.
		/// </summary>
		public string LangCode
		{
			get { return langCode; }
			set { langCode = value; }
		}

		/// <summary>
		/// Gets or sets the SeqNo value.
		/// </summary>
		public int SeqNo
		{
			get { return seqNo; }
			set { seqNo = value; }
		}

		/// <summary>
		/// Gets or sets the ReportID value.
		/// </summary>
		public int ReportID
		{
			get { return reportID; }
			set { reportID = value; }
		}

		/// <summary>
		/// Gets or sets the AttributeName value.
		/// </summary>
		private string _attributeName=String.Empty;
		public string AttributeName
		{
			get { return  _attributeName; }
			set { _attributeName = value; }
		}

		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		private long _iD=0;
		public long ID
		{
			get { return  _iD; }
			set { _iD = value; }
		}

		/// <summary>
		/// Gets or sets the AttributeStatus value.
		/// </summary>
		private bool _attributeStatus=false;
		public bool AttributeStatus
		{
			get { return  _attributeStatus; }
			set { _attributeStatus = value; }
		}

		/// <summary>
		/// Gets or sets the IsPreDefined value.
		/// </summary>
		private bool _isPreDefined=false;
		public bool IsPreDefined
		{
			get { return  _isPreDefined; }
			set { _isPreDefined = value; }
		}

		/// <summary>
		/// Gets or sets the Description value.
		/// </summary>
		private string _description=String.Empty;
		public string Description
		{
			get { return  _description; }
			set { _description = value; }
		}

		/// <summary>
		/// Gets or sets the ControlName value.
		/// </summary>
		private string _controlName=String.Empty;
		public string ControlName
		{
			get { return  _controlName; }
			set { _controlName = value; }
		}

		/// <summary>
		/// Gets or sets the Type value.
		/// </summary>
		private string _type=String.Empty;
		public string Type
		{
			get { return  _type; }
			set { _type = value; }
		}

		/// <summary>
		/// Gets or sets the ControlCode value.
		/// </summary>
		private String _controlCode=String.Empty;
		public String ControlCode
		{
			get { return  _controlCode; }
			set { _controlCode = value; }
		}

		/// <summary>
		/// Gets or sets the IsTableReference value.
		/// </summary>
		private bool _isTableReference=false;
		public bool IsTableReference
		{
			get { return  _isTableReference; }
			set { _isTableReference = value; }
		}

		/// <summary>
		/// Gets or sets the ReportPath value.
		/// </summary>
		private string _reportPath=String.Empty;
		public string ReportPath
		{
			get { return  _reportPath; }
			set { _reportPath = value; }
		}


		#endregion
}
}
