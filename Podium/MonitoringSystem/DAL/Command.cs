using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MonitoringSystem
{
    class Command
    {
        public static System.Data.SqlClient.SqlCommand pGetAllCategoriesandFoldersCommand(long pFolderID)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetAllCategoriesandFolders";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pFolderID = new System.Data.SqlClient.SqlParameter();
            _pFolderID.ParameterName = "@pFolderID";
            _pFolderID.Size = -1;
            _pFolderID.Value = pFolderID;
            cmd.Parameters.Add(_pFolderID);
            return cmd;
        }

        public static System.Data.SqlClient.SqlCommand pGetParametersforProcedureCommand(long pProcedureID)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetParametersforProcedure";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pProcedureID = new System.Data.SqlClient.SqlParameter();
            _pProcedureID.ParameterName = "@pProcedureID";
            _pProcedureID.Size = -1;
            _pProcedureID.Value = pProcedureID;
            cmd.Parameters.Add(_pProcedureID);
            return cmd;
        }

        public static System.Data.SqlClient.SqlCommand pRenderingReportCommand(long pProcedureID, string StringParam)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pRenderingReport";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pProcedureID = new System.Data.SqlClient.SqlParameter();
            _pProcedureID.ParameterName = "@pProcedureID";
            _pProcedureID.Size = -1;
            _pProcedureID.Value = pProcedureID;
            cmd.Parameters.Add(_pProcedureID);
            System.Data.SqlClient.SqlParameter _pStringParam = new System.Data.SqlClient.SqlParameter();
            _pStringParam.ParameterName = "@pStringParam";
            _pStringParam.Size = 100;
            _pStringParam.Value = StringParam;
            cmd.Parameters.Add(_pStringParam);
            return cmd;
        }

        public static System.Data.SqlClient.SqlCommand pGetDDLValuesForParametersCommand(long pParamQueryID, long lID)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "Pgetddlvaluesforparameters";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pParamQueryID = new System.Data.SqlClient.SqlParameter();
            _pParamQueryID.ParameterName = "@pParamQueryID";
            _pParamQueryID.Size = -1;
            _pParamQueryID.Value = pParamQueryID;
            cmd.Parameters.Add(_pParamQueryID);
            System.Data.SqlClient.SqlParameter _lID = new System.Data.SqlClient.SqlParameter();
            _lID.ParameterName = "@lID";
            _lID.Size = -1;
            _lID.Value = lID;
            cmd.Parameters.Add(_lID);
            return cmd;
        }

    }
}
