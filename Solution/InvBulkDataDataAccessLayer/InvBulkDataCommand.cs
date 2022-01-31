using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace InvBulkDataDataAccessLayer
{
    public class InvBulkDataCommand
    {
        public static System.Data.SqlClient.SqlCommand PValidateTestMasterDataCommand(System.Data.DataTable TESTMASTER_data, int pOrgID, System.Data.DataTable ContextInfo)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "PValidateTestMasterData";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _TESTMASTER_data = new System.Data.SqlClient.SqlParameter();
            _TESTMASTER_data.ParameterName = "@TESTMASTER_data";
            _TESTMASTER_data.Size = -1;
            _TESTMASTER_data.Value = TESTMASTER_data;
            cmd.Parameters.Add(_TESTMASTER_data);
            System.Data.SqlClient.SqlParameter _pOrgID = new System.Data.SqlClient.SqlParameter();
            _pOrgID.ParameterName = "@pOrgID";
            _pOrgID.Size = -1;
            _pOrgID.Value = pOrgID;
            cmd.Parameters.Add(_pOrgID);
            System.Data.SqlClient.SqlParameter _ContextInfo = new System.Data.SqlClient.SqlParameter();
            _ContextInfo.ParameterName = "@ContextInfo";
            _ContextInfo.Size = -1;
            _ContextInfo.Value = ContextInfo;
            cmd.Parameters.Add(_ContextInfo);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand PValidateGrpMasterDataCommand(System.Data.DataTable GROUP_MASTER_data, int pOrgID, System.Data.DataTable ContextInfo)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "PValidateGrpMasterData";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _GROUP_MASTER_data = new System.Data.SqlClient.SqlParameter();
            _GROUP_MASTER_data.ParameterName = "@GROUP_MASTER_data";
            _GROUP_MASTER_data.Size = -1;
            _GROUP_MASTER_data.Value = GROUP_MASTER_data;
            cmd.Parameters.Add(_GROUP_MASTER_data);
            System.Data.SqlClient.SqlParameter _pOrgID = new System.Data.SqlClient.SqlParameter();
            _pOrgID.ParameterName = "@pOrgID";
            _pOrgID.Size = -1;
            _pOrgID.Value = pOrgID;
            cmd.Parameters.Add(_pOrgID);
            System.Data.SqlClient.SqlParameter _ContextInfo = new System.Data.SqlClient.SqlParameter();
            _ContextInfo.ParameterName = "@ContextInfo";
            _ContextInfo.Size = -1;
            _ContextInfo.Value = ContextInfo;
            cmd.Parameters.Add(_ContextInfo);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand PValidatePkgMasterDataCommand(System.Data.DataTable Package_Master_data, int pOrgID, System.Data.DataTable ContextInfo)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "PValidatePkgMasterData";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _Package_Master_data = new System.Data.SqlClient.SqlParameter();
            _Package_Master_data.ParameterName = "@Package_Master_data";
            _Package_Master_data.Size = -1;
            _Package_Master_data.Value = Package_Master_data;
            cmd.Parameters.Add(_Package_Master_data);
            System.Data.SqlClient.SqlParameter _pOrgID = new System.Data.SqlClient.SqlParameter();
            _pOrgID.ParameterName = "@pOrgID";
            _pOrgID.Size = -1;
            _pOrgID.Value = pOrgID;
            cmd.Parameters.Add(_pOrgID);
            System.Data.SqlClient.SqlParameter _ContextInfo = new System.Data.SqlClient.SqlParameter();
            _ContextInfo.ParameterName = "@ContextInfo";
            _ContextInfo.Size = -1;
            _ContextInfo.Value = ContextInfo;
            cmd.Parameters.Add(_ContextInfo);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand PValidateGrpContentDataCommand(System.Data.DataTable Group_Content_data, int pOrgID, System.Data.DataTable ContextInfo)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "PValidateGrpContentData";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _Group_Content_data = new System.Data.SqlClient.SqlParameter();
            _Group_Content_data.ParameterName = "@Group_Content_data";
            _Group_Content_data.Size = -1;
            _Group_Content_data.Value = Group_Content_data;
            cmd.Parameters.Add(_Group_Content_data);
            System.Data.SqlClient.SqlParameter _pOrgID = new System.Data.SqlClient.SqlParameter();
            _pOrgID.ParameterName = "@pOrgID";
            _pOrgID.Size = -1;
            _pOrgID.Value = pOrgID;
            cmd.Parameters.Add(_pOrgID);
            System.Data.SqlClient.SqlParameter _ContextInfo = new System.Data.SqlClient.SqlParameter();
            _ContextInfo.ParameterName = "@ContextInfo";
            _ContextInfo.Size = -1;
            _ContextInfo.Value = ContextInfo;
            cmd.Parameters.Add(_ContextInfo);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand PValidatePkgContentDataCommand(System.Data.DataTable Package_Content_data, int pOrgID, System.Data.DataTable ContextInfo)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "PValidatePkgContentData";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _Package_Content_data = new System.Data.SqlClient.SqlParameter();
            _Package_Content_data.ParameterName = "@Package_Content_data";
            _Package_Content_data.Size = -1;
            _Package_Content_data.Value = Package_Content_data;
            cmd.Parameters.Add(_Package_Content_data);
            System.Data.SqlClient.SqlParameter _pOrgID = new System.Data.SqlClient.SqlParameter();
            _pOrgID.ParameterName = "@pOrgID";
            _pOrgID.Size = -1;
            _pOrgID.Value = pOrgID;
            cmd.Parameters.Add(_pOrgID);
            System.Data.SqlClient.SqlParameter _ContextInfo = new System.Data.SqlClient.SqlParameter();
            _ContextInfo.ParameterName = "@ContextInfo";
            _ContextInfo.Size = -1;
            _ContextInfo.Value = ContextInfo;
            cmd.Parameters.Add(_ContextInfo);
            return cmd;
        }

        public static System.Data.SqlClient.SqlCommand PInsertInvGrpPkgLogCommand(int pOrgID, string Type, string Filename, int CreatedBy, string status, System.Data.DataTable ContextInfo)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "PInsertInvGrpPkgLog";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgID = new System.Data.SqlClient.SqlParameter();
            _pOrgID.ParameterName = "@pOrgID";
            _pOrgID.Size = -1;
            _pOrgID.Value = pOrgID;
            cmd.Parameters.Add(_pOrgID);
            System.Data.SqlClient.SqlParameter _Type = new System.Data.SqlClient.SqlParameter();
            _Type.ParameterName = "@Type";
            _Type.Size = 100;
            _Type.Value = Type;
            cmd.Parameters.Add(_Type);
            System.Data.SqlClient.SqlParameter _Filename = new System.Data.SqlClient.SqlParameter();
            _Filename.ParameterName = "@Filename";
            _Filename.Size = 100;
            _Filename.Value = Filename;
            cmd.Parameters.Add(_Filename);
            System.Data.SqlClient.SqlParameter _CreatedBy = new System.Data.SqlClient.SqlParameter();
            _CreatedBy.ParameterName = "@CreatedBy";
            _CreatedBy.Size = -1;
            _CreatedBy.Value = CreatedBy;
            cmd.Parameters.Add(_CreatedBy);
            System.Data.SqlClient.SqlParameter _status = new System.Data.SqlClient.SqlParameter();
            _status.ParameterName = "@status";
            _status.Size = 255;
            _status.Value = status;
            cmd.Parameters.Add(_status);
            System.Data.SqlClient.SqlParameter _ContextInfo = new System.Data.SqlClient.SqlParameter();
            _ContextInfo.ParameterName = "@ContextInfo";
            _ContextInfo.Size = -1;
            _ContextInfo.Value = ContextInfo;
            cmd.Parameters.Add(_ContextInfo);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand PGetInvGrpPkgLogCommand(int pOrgID, System.Data.DataTable ContextInfo)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "PGetInvGrpPkgLog";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgID = new System.Data.SqlClient.SqlParameter();
            _pOrgID.ParameterName = "@pOrgID";
            _pOrgID.Size = -1;
            _pOrgID.Value = pOrgID;
            cmd.Parameters.Add(_pOrgID);
            System.Data.SqlClient.SqlParameter _ContextInfo = new System.Data.SqlClient.SqlParameter();
            _ContextInfo.ParameterName = "@ContextInfo";
            _ContextInfo.Size = -1;
            _ContextInfo.Value = ContextInfo;
            cmd.Parameters.Add(_ContextInfo);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand PGetInvGrpPkgErrorCommand(System.Data.DataTable ContextInfo)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "PGetInvGrpPkgError";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _ContextInfo = new System.Data.SqlClient.SqlParameter();
            _ContextInfo.ParameterName = "@ContextInfo";
            _ContextInfo.Size = -1;
            _ContextInfo.Value = ContextInfo;
            cmd.Parameters.Add(_ContextInfo);
            return cmd;
        }
    }
}