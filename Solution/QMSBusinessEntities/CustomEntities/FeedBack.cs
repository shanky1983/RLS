using System;
using System.Collections.Generic;

namespace Attune.Solution.QMSBusinessEntities
{
    [Serializable]
    public class FeedBack : IComparable<FeedBack>
    {
        private int _FbQuestionID;
        public int FbQuestionID
        {
            get
            {
                return _FbQuestionID;
            }
            set
            {
                _FbQuestionID = value;
            }
        }

        private string _Question;
        public string Question
        {
            get
            {
                return _Question;
            }
            set
            {
                _Question = value;
            }
        }

        private int _ControlTypeID;
        public int ControlTypeID
        {
            get
            {
                return _ControlTypeID;
            }
            set
            {
                _ControlTypeID = value;
            }
        }

        private string _ControlCode;
        public string ControlCode
        {
            get
            {
                return _ControlCode;
            }
            set
            {
                _ControlCode = value;
            }
        }

        private string _ControlName;
        public string ControlName
        {
            get
            {
                return _ControlName;
            }
            set
            {
                _ControlName = value;
            }
        }

        private int _FbAnswerID;
        public int FbAnswerID
        {
            get
            {
                return _FbAnswerID;
            }
            set
            {
                _FbAnswerID = value;
            }
        }

        private string _Answer;
        public string Answer
        {
            get
            {
                return _Answer;
            }
            set
            {
                _Answer = value;
            }
        }

        private int _UserFeedBackID;
        public int UserFeedBackID
        {
            get
            {
                return _UserFeedBackID;
            }
            set
            {
                _UserFeedBackID = value;
            }
        }

        private int _OrgID;
        public int OrgID
        {
            get
            {
                return _OrgID;
            }
            set
            {
                _OrgID = value;
            }
        }

        private Boolean _IsActive;
        public Boolean IsActive
        {
            get
            {
                return _IsActive;
            }
            set
            {
                _IsActive = value;
            }
        }

        private Int16 _SequenceNumber;
        public Int16 SequenceNumber
        {
            get
            {
                return _SequenceNumber;
            }
            set
            {
                _SequenceNumber = value;
            }
        }

        #region IComparable<FeedBack> Members

        public int CompareTo(FeedBack SecondObject)
        {
            return this.FbQuestionID.CompareTo(SecondObject.FbQuestionID);
        }

        #endregion

    }
}
