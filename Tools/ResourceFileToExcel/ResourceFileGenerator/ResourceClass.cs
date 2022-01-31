using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResourceToExcel
{
    public class ResourceClass
    {
        private string _FileName;

        public string FileName
        {
            get { return _FileName; }
            set { _FileName = value; }
        }
        private string _UniqueKey;

        public string UniqueKey
        {
            get { return _UniqueKey; }
            set { _UniqueKey = value; }
        }

        private string _ResourceKey;

        public string ResourceKey
        {
            get { return _ResourceKey; }
            set { _ResourceKey = value; }
        }

        private string _ResourceValue;

        public string ResourceValue
        {
            get { return _ResourceValue; }
            set { _ResourceValue = value; }
        }

        private int _WordCount;

        public int WordCount
        {
            get { return _WordCount; }
            set { _WordCount = value; }
        }
    }

    public class UniqueWords
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
