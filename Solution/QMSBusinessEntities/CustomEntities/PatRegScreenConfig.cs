using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class PatRegScreenConfig
    {
        private long _BlockFieldMappingID;

        public long BlockFieldMappingID
        {
            get { return _BlockFieldMappingID; }
            set { _BlockFieldMappingID = value; }
        }

        private string _BlockName;

        public string BlockName
        {
            get { return _BlockName; }
            set { _BlockName = value; }
        }

        private string _BlockDisplayText;

        public string BlockDisplayText
        {
            get { return _BlockDisplayText; }
            set { _BlockDisplayText = value; }
        }

        private long _BlockID;

        public long BlockID
        {
            get { return _BlockID; }
            set { _BlockID = value; }
        }

        private string _IsStatic;

        public string IsStatic
        {
            get { return _IsStatic; }
            set { _IsStatic = value; }
        }

        private string _IsMandatory;

        public string IsMandatory
        {
            get { return _IsMandatory; }
            set
            {
                if (value == null)
                {
                    _IsMandatory = "N";
                }
                else
                {
                    _IsMandatory = value;
                }
            }
        }

        private string _SysMandatory;

        public string SysMandatory
        {
            get { return _SysMandatory; }
            set
            {
                if (value == null)
                {
                    _SysMandatory = "N";
                }
                else
                {
                    _SysMandatory = value;
                }
            }
        }

        private string _FieldName;

        public string FieldName
        {
            get { return _FieldName; }
            set { _FieldName = value; }
        }

        private string _FieldDisplayText;

        public string FieldDisplayText
        {
            get { return _FieldDisplayText; }
            set { _FieldDisplayText = value; }
        }

        private long _FieldID;

        public long FieldID
        {
            get { return _FieldID; }
            set { _FieldID = value; }
        }

        private string _DataType;

        public string DataType
        {
            get { return _DataType; }
            set { _DataType = value; }
        }

        private string _ControlType;

        public string ControlType
        {
            get { return _ControlType; }
            set { _ControlType = value; }
        }

        private string _Domain;

        public string Domain
        {
            get { return _Domain; }
            set { _Domain = value; }
        }

        private int _Position;

        public int Position
        {
            get { return _Position; }
            set { _Position = value; }
        }

        private long _OrgID;

        public long OrgID
        {
            get { return _OrgID; }
            set { _OrgID = value; }
        }

        private string _PageName;

        public string PageName
        {
            get { return _PageName; }
            set { _PageName = value; }
        }

        private int _IsCustomControl;

        public int IsCustomControl
        {
            get { return _IsCustomControl; }
            set { _IsCustomControl = value; }
        }
        private string _IsNeedExpand;

        public string IsNeedExpand
        {
            get { return _IsNeedExpand; }
            set { _IsNeedExpand = value; }
        }

    }
}
