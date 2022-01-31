using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResourceToExcel
{
    public class TableforScript
    {
        public TableforScript()
        {

        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private List<Rows> _rows;

        public List<Rows> Rows
        {
            get { return _rows; }
            set { _rows = value; }  
        }

   

        private bool _hasIdentity;

        public bool HasIdentity
        {
            get { return _hasIdentity; }
            set { _hasIdentity = value; }
        }

        private char _crud;

        public char Crud
        {
            get { return _crud; }
            set { _crud = value; }
        }

        private char _isOrgBased;

        public char IsOrgBased
        {
            get { return _isOrgBased; }
            set { _isOrgBased = value; }
        }
    }

    public class Columns
    {
        private string _colName;

        public string ColName
        {
            get { return _colName; }
            set { _colName = value; }
        }
        private string _colValue;

        public string ColValue
        {
            get { return _colValue; }
            set { _colValue = value; }
        }

        private string _transValue;

        public string TransValue
        {
            get { return _transValue; }
            set { _transValue = value; }
        }
       
    }
    public class Rows
    {
        private List<Columns> _columns;

        public List<Columns> Columns
        {
            get { return _columns; }
            set { _columns = value; }
        }
    }

    public class TranslationExcel
    {
        private string _OriginalData;

        public string OriginalData
        {
            get { return _OriginalData; }
            set { _OriginalData = value; }
        }

        private string _TranslatedData;

        public string TranslatedData
        {
            get { return _TranslatedData; }
            set { _TranslatedData = value; }
        }
    }
}
