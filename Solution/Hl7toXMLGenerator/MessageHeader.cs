using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Attune.HL7Integration
{
    public class MessageHeader
    {
        string _sending_application = string.Empty;
        public string Sending_Application
        {
            get { return _sending_application; }
            set { _sending_application = value; }
        }

        string _receiving_Application = string.Empty;
        public string Receiving_Application
        {
            get { return _receiving_Application; }
            set { _receiving_Application = value; }
        }
        string _receiving_Facility = string.Empty;
        public string Receiving_Facility
        {
            get { return _receiving_Facility; }
            set { _receiving_Facility = value; }
        }
        string _message_Date_Time = string.Empty;
        public string Message_Date_Time
        {
            get { return _message_Date_Time; }
            set { _message_Date_Time = value; }
        }
        string _message_Type = string.Empty;
        public string Message_Type
        {
            get { return _message_Type; }
            set { _message_Type = value; }
        }
        string _message_Control_Id = string.Empty;
        public string Message_Control_Id
        {
            get { return _message_Control_Id; }
            set { _message_Control_Id = value; }
        }
    }
}
