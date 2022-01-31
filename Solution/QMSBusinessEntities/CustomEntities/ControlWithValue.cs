using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class ControlWithValue
    {
        private string _ControlName;

        public string ControlName
        {
            get { return _ControlName; }
            set { _ControlName = value; }
        }

        private string _text;

        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        private string _value;

        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }

        private int _IsCustomControl;

        public int IsCustomControl
        {
            get { return _IsCustomControl; }
            set { _IsCustomControl = value; }
        }       
    }
}
