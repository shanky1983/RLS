using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace OutBoundMsgExportCommand
{
    public class OutBoundMsgCommand
    {
        public static System.Data.SqlClient.SqlCommand pGetOrderedApprovedDetailsForOutBoundCommand(int OrgID, long PatientVisitID, long AccessionNumber, string Status, System.Data.DataTable Contextinfo)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetOrderedApprovedDetailsForOutBound";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _OrgID = new System.Data.SqlClient.SqlParameter();
            _OrgID.ParameterName = "@OrgID";
            _OrgID.Size = -1;
            _OrgID.Value = OrgID;
            cmd.Parameters.Add(_OrgID);
            System.Data.SqlClient.SqlParameter _PatientVisitID = new System.Data.SqlClient.SqlParameter();
            _PatientVisitID.ParameterName = "@PatientVisitID";
            _PatientVisitID.Size = -1;
            _PatientVisitID.Value = PatientVisitID;
            cmd.Parameters.Add(_PatientVisitID);
            System.Data.SqlClient.SqlParameter _AccessionNumber = new System.Data.SqlClient.SqlParameter();
            _AccessionNumber.ParameterName = "@AccessionNumber";
            _AccessionNumber.Size = -1;
            _AccessionNumber.Value = AccessionNumber;
            cmd.Parameters.Add(_AccessionNumber);
            System.Data.SqlClient.SqlParameter _Status = new System.Data.SqlClient.SqlParameter();
            _Status.ParameterName = "@Status";
            _Status.Size = 500;
            _Status.Value = Status;
            cmd.Parameters.Add(_Status);
            System.Data.SqlClient.SqlParameter _Contextinfo = new System.Data.SqlClient.SqlParameter();
            _Contextinfo.ParameterName = "@Contextinfo";
            _Contextinfo.Size = -1;
            _Contextinfo.Value = Contextinfo;
            cmd.Parameters.Add(_Contextinfo);
            return cmd;
        }


        public static System.Data.SqlClient.SqlCommand pGetApprovedListForOutBoundCommand(long OrgID, string Status, System.Data.DataTable Contextinfo)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetApprovedListForOutBound";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _OrgID = new System.Data.SqlClient.SqlParameter();
            _OrgID.ParameterName = "@OrgID";
            _OrgID.Size = -1;
            _OrgID.Value = OrgID;
            cmd.Parameters.Add(_OrgID);
            System.Data.SqlClient.SqlParameter _Status = new System.Data.SqlClient.SqlParameter();
            _Status.ParameterName = "@Status";
            _Status.Size = 50;
            _Status.Value = Status;
            cmd.Parameters.Add(_Status);
            System.Data.SqlClient.SqlParameter _Contextinfo = new System.Data.SqlClient.SqlParameter();
            _Contextinfo.ParameterName = "@Contextinfo";
            _Contextinfo.Size = -1;
            _Contextinfo.Value = Contextinfo;
            cmd.Parameters.Add(_Contextinfo);
            return cmd;
        }

        public static System.Data.SqlClient.SqlCommand pGetApprovedListForOutBound_ClinicSystemCommand(long OrgID, string VisitNumber, string Status, System.Data.DataTable Contextinfo)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetApprovedListForOutBound_ClinicSystem";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _OrgID = new System.Data.SqlClient.SqlParameter();
            _OrgID.ParameterName = "@OrgID";
            _OrgID.Size = -1;
            _OrgID.Value = OrgID;
            cmd.Parameters.Add(_OrgID);

            System.Data.SqlClient.SqlParameter _VisitNumber = new System.Data.SqlClient.SqlParameter();
            _VisitNumber.ParameterName = "@Status";
            _VisitNumber.Size = 100;
            _VisitNumber.Value = VisitNumber;
            cmd.Parameters.Add(_VisitNumber);

            System.Data.SqlClient.SqlParameter _Status = new System.Data.SqlClient.SqlParameter();
            _Status.ParameterName = "@VisitNumber";
            _Status.Size = 50;
            _Status.Value = Status;
            cmd.Parameters.Add(_Status);
            System.Data.SqlClient.SqlParameter _Contextinfo = new System.Data.SqlClient.SqlParameter();
            _Contextinfo.ParameterName = "@Contextinfo";
            _Contextinfo.Size = -1;
            _Contextinfo.Value = Contextinfo;
            cmd.Parameters.Add(_Contextinfo);
            return cmd;
        }

        public static System.Data.SqlClient.SqlCommand pUpdateOutBoundMsgDetilsCommand(long OrgID, System.Data.DataTable OutBound, System.Data.DataTable Contextinfo)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pUpdateOutBoundMsgDetils";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _OrgID = new System.Data.SqlClient.SqlParameter();
            _OrgID.ParameterName = "@OrgID";
            _OrgID.Size = -1;
            _OrgID.Value = OrgID;
            cmd.Parameters.Add(_OrgID);
            System.Data.SqlClient.SqlParameter _OutBound = new System.Data.SqlClient.SqlParameter();
            _OutBound.ParameterName = "@OutBound";
            _OutBound.Size = -1;
            _OutBound.Value = OutBound;
            cmd.Parameters.Add(_OutBound);
            System.Data.SqlClient.SqlParameter _Contextinfo = new System.Data.SqlClient.SqlParameter();
            _Contextinfo.ParameterName = "@Contextinfo";
            _Contextinfo.Size = -1;
            _Contextinfo.Value = Contextinfo;
            cmd.Parameters.Add(_Contextinfo);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand PgetPdfDetailsCommand(long OrgID, long VisitID, long AccessionNumber)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "PgetPdfDetails";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _OrgID = new System.Data.SqlClient.SqlParameter();
            _OrgID.ParameterName = "@OrgID";
            _OrgID.Size = -1;
            _OrgID.Value = OrgID;
            cmd.Parameters.Add(_OrgID);
            System.Data.SqlClient.SqlParameter _VisitID = new System.Data.SqlClient.SqlParameter();
            _VisitID.ParameterName = "@VisitID";
            _VisitID.Size = -1;
            _VisitID.Value = VisitID;
            cmd.Parameters.Add(_VisitID);
            System.Data.SqlClient.SqlParameter _AccessionNumber = new System.Data.SqlClient.SqlParameter();
            _AccessionNumber.ParameterName = "@AccessionNumber";
            _AccessionNumber.Size = -1;
            _AccessionNumber.Value = AccessionNumber;
            cmd.Parameters.Add(_AccessionNumber);
            return cmd;
        }
    }
}
