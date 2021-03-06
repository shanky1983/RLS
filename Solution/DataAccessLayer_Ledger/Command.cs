//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5420
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Attune.Solution.DataAccessLayer_Ledger
{
    using System;
    using System.Text;
    using System.Data;
    using System.Data.SqlClient;
    
    
    public class Command {
        
        /** Ledger work **/

        public static System.Data.SqlClient.SqlCommand pInsertClientCreditCommand(System.Data.DataTable pClientCredit, System.Data.DataTable ContextInfo, out long SucessCode)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pInsertClientCredit";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pClientCredit = new System.Data.SqlClient.SqlParameter();
            _pClientCredit.ParameterName = "@pClientCredit";
            _pClientCredit.Size = -1;
            _pClientCredit.Value = pClientCredit;
            cmd.Parameters.Add(_pClientCredit);
            System.Data.SqlClient.SqlParameter _ContextInfo = new System.Data.SqlClient.SqlParameter();
            _ContextInfo.ParameterName = "@ContextInfo";
            _ContextInfo.Size = -1;
            _ContextInfo.Value = ContextInfo;
            cmd.Parameters.Add(_ContextInfo);
            SucessCode = -1;
            System.Data.SqlClient.SqlParameter _SucessCode = new System.Data.SqlClient.SqlParameter();
            _SucessCode.ParameterName = "@SucessCode";
            _SucessCode.Size = -1;
            _SucessCode.Value = SucessCode;
            cmd.Parameters.Add(_SucessCode);
            _SucessCode.Direction = ParameterDirection.Output;
            SucessCode = ((long)(_SucessCode.Value));
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pInsertClientDebitCommand(System.Data.DataTable pClientDebit, System.Data.DataTable ContextInfo, out long SucessCode)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pInsertClientDebit";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pClientDebit = new System.Data.SqlClient.SqlParameter();
            _pClientDebit.ParameterName = "@pClientDebit";
            _pClientDebit.Size = -1;
            _pClientDebit.Value = pClientDebit;
            cmd.Parameters.Add(_pClientDebit);
            System.Data.SqlClient.SqlParameter _ContextInfo = new System.Data.SqlClient.SqlParameter();
            _ContextInfo.ParameterName = "@ContextInfo";
            _ContextInfo.Size = -1;
            _ContextInfo.Value = ContextInfo;
            cmd.Parameters.Add(_ContextInfo);
            SucessCode = -1;
            System.Data.SqlClient.SqlParameter _SucessCode = new System.Data.SqlClient.SqlParameter();
            _SucessCode.ParameterName = "@SucessCode";
            _SucessCode.Size = -1;
            _SucessCode.Value = SucessCode;
            cmd.Parameters.Add(_SucessCode);
            _SucessCode.Direction = ParameterDirection.Output;
            SucessCode = ((long)(_SucessCode.Value));
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pGetClientNarrationCommand(string pType, System.Data.DataTable ContextInfo)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetClientNarration";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pType = new System.Data.SqlClient.SqlParameter();
            _pType.ParameterName = "@pType";
            _pType.Size = 1;
            _pType.Value = pType;
            cmd.Parameters.Add(_pType);
            System.Data.SqlClient.SqlParameter _ContextInfo = new System.Data.SqlClient.SqlParameter();
            _ContextInfo.ParameterName = "@ContextInfo";
            _ContextInfo.Size = -1;
            _ContextInfo.Value = ContextInfo;
            cmd.Parameters.Add(_ContextInfo);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pGetClientOutstandingCommand(int OrgId, string ClientCode)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetClientOutstanding";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _OrgId = new System.Data.SqlClient.SqlParameter();
            _OrgId.ParameterName = "@OrgId";
            _OrgId.Size = -1;
            _OrgId.Value = OrgId;
            cmd.Parameters.Add(_OrgId);
            System.Data.SqlClient.SqlParameter _ClientCode = new System.Data.SqlClient.SqlParameter();
            _ClientCode.ParameterName = "@ClientCode";
            _ClientCode.Size = 50;
            _ClientCode.Value = ClientCode;
            cmd.Parameters.Add(_ClientCode);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pInsertClientBillsCommand(int OrgID)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pInsertClientBills";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _OrgID = new System.Data.SqlClient.SqlParameter();
            _OrgID.ParameterName = "@OrgID";
            _OrgID.Size = -1;
            _OrgID.Value = OrgID;
            cmd.Parameters.Add(_OrgID);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pGetCreditDebitRecommendationCommand(int pOrgId, string pStatus, string pType, string pClientCode, System.Data.DataTable ContextInfo)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetCreditDebitRecommendation";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgId = new System.Data.SqlClient.SqlParameter();
            _pOrgId.ParameterName = "@pOrgId";
            _pOrgId.Size = -1;
            _pOrgId.Value = pOrgId;
            cmd.Parameters.Add(_pOrgId);
            System.Data.SqlClient.SqlParameter _pStatus = new System.Data.SqlClient.SqlParameter();
            _pStatus.ParameterName = "@pStatus";
            _pStatus.Size = 100;
            _pStatus.Value = pStatus;
            cmd.Parameters.Add(_pStatus);
            System.Data.SqlClient.SqlParameter _pType = new System.Data.SqlClient.SqlParameter();
            _pType.ParameterName = "@pType";
            _pType.Size = 100;
            _pType.Value = pType;
            cmd.Parameters.Add(_pType);
            System.Data.SqlClient.SqlParameter _pClientCode = new System.Data.SqlClient.SqlParameter();
            _pClientCode.ParameterName = "@pClientCode";
            _pClientCode.Size = 20;
            _pClientCode.Value = pClientCode;
            cmd.Parameters.Add(_pClientCode);
            System.Data.SqlClient.SqlParameter _ContextInfo = new System.Data.SqlClient.SqlParameter();
            _ContextInfo.ParameterName = "@ContextInfo";
            _ContextInfo.Size = -1;
            _ContextInfo.Value = ContextInfo;
            cmd.Parameters.Add(_ContextInfo);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pGetCreditDebitStatusCommand(int pOrgId, string pType, string pClientCode, string pStatus, System.DateTime pFrom, System.DateTime pTo)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetCreditDebitStatus";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgId = new System.Data.SqlClient.SqlParameter();
            _pOrgId.ParameterName = "@pOrgId";
            _pOrgId.Size = -1;
            _pOrgId.Value = pOrgId;
            cmd.Parameters.Add(_pOrgId);
            System.Data.SqlClient.SqlParameter _pType = new System.Data.SqlClient.SqlParameter();
            _pType.ParameterName = "@pType";
            _pType.Size = 1;
            _pType.Value = pType;
            cmd.Parameters.Add(_pType);
            System.Data.SqlClient.SqlParameter _pClientCode = new System.Data.SqlClient.SqlParameter();
            _pClientCode.ParameterName = "@pClientCode";
            _pClientCode.Size = 20;
            _pClientCode.Value = pClientCode;
            cmd.Parameters.Add(_pClientCode);
            System.Data.SqlClient.SqlParameter _pStatus = new System.Data.SqlClient.SqlParameter();
            _pStatus.ParameterName = "@pStatus";
            _pStatus.Size = 50;
            _pStatus.Value = pStatus;
            cmd.Parameters.Add(_pStatus);
            System.Data.SqlClient.SqlParameter _pFrom = new System.Data.SqlClient.SqlParameter();
            _pFrom.ParameterName = "@pFrom";
            _pFrom.Size = -1;
            _pFrom.Value = pFrom;
            cmd.Parameters.Add(_pFrom);
            System.Data.SqlClient.SqlParameter _pTo = new System.Data.SqlClient.SqlParameter();
            _pTo.ParameterName = "@pTo";
            _pTo.Size = -1;
            _pTo.Value = pTo;
            cmd.Parameters.Add(_pTo);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pUpdateCreditDebitRecommendationCommand(System.Data.DataTable pClientCreditDebit, System.Data.DataTable ContextInfo)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pUpdateCreditDebitRecommendation";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pClientCreditDebit = new System.Data.SqlClient.SqlParameter();
            _pClientCreditDebit.ParameterName = "@pClientCreditDebit";
            _pClientCreditDebit.Size = -1;
            _pClientCreditDebit.Value = pClientCreditDebit;
            cmd.Parameters.Add(_pClientCreditDebit);
            System.Data.SqlClient.SqlParameter _ContextInfo = new System.Data.SqlClient.SqlParameter();
            _ContextInfo.ParameterName = "@ContextInfo";
            _ContextInfo.Size = -1;
            _ContextInfo.Value = ContextInfo;
            cmd.Parameters.Add(_ContextInfo);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pGetClientCreditHistoryCommand(int OrgId, string ClientCode)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetClientCreditHistory";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _OrgId = new System.Data.SqlClient.SqlParameter();
            _OrgId.ParameterName = "@OrgId";
            _OrgId.Size = -1;
            _OrgId.Value = OrgId;
            cmd.Parameters.Add(_OrgId);
            System.Data.SqlClient.SqlParameter _ClientCode = new System.Data.SqlClient.SqlParameter();
            _ClientCode.ParameterName = "@ClientCode";
            _ClientCode.Size = 50;
            _ClientCode.Value = ClientCode;
            cmd.Parameters.Add(_ClientCode);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pGetClientDebitHistoryCommand(int OrgId, string ClientCode)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetClientDebitHistory";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _OrgId = new System.Data.SqlClient.SqlParameter();
            _OrgId.ParameterName = "@OrgId";
            _OrgId.Size = -1;
            _OrgId.Value = OrgId;
            cmd.Parameters.Add(_OrgId);
            System.Data.SqlClient.SqlParameter _ClientCode = new System.Data.SqlClient.SqlParameter();
            _ClientCode.ParameterName = "@ClientCode";
            _ClientCode.Size = 50;
            _ClientCode.Value = ClientCode;
            cmd.Parameters.Add(_ClientCode);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pGetClientReceiptHistoryCommand(int OrgId, string ClientCode)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetClientReceiptHistory";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _OrgId = new System.Data.SqlClient.SqlParameter();
            _OrgId.ParameterName = "@OrgId";
            _OrgId.Size = -1;
            _OrgId.Value = OrgId;
            cmd.Parameters.Add(_OrgId);
            System.Data.SqlClient.SqlParameter _ClientCode = new System.Data.SqlClient.SqlParameter();
            _ClientCode.ParameterName = "@ClientCode";
            _ClientCode.Size = 50;
            _ClientCode.Value = ClientCode;
            cmd.Parameters.Add(_ClientCode);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pGetClientBillHistoryCommand(int OrgId, string ClientCode)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetClientBillHistory";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _OrgId = new System.Data.SqlClient.SqlParameter();
            _OrgId.ParameterName = "@OrgId";
            _OrgId.Size = -1;
            _OrgId.Value = OrgId;
            cmd.Parameters.Add(_OrgId);
            System.Data.SqlClient.SqlParameter _ClientCode = new System.Data.SqlClient.SqlParameter();
            _ClientCode.ParameterName = "@ClientCode";
            _ClientCode.Size = 50;
            _ClientCode.Value = ClientCode;
            cmd.Parameters.Add(_ClientCode);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pGetClientLedgerMonthClosingCommand(int OrgId, string ClientCode, System.DateTime pFrom, System.DateTime pTo)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetClientLedgerMonthClosing";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _OrgId = new System.Data.SqlClient.SqlParameter();
            _OrgId.ParameterName = "@OrgId";
            _OrgId.Size = -1;
            _OrgId.Value = OrgId;
            cmd.Parameters.Add(_OrgId);
            System.Data.SqlClient.SqlParameter _ClientCode = new System.Data.SqlClient.SqlParameter();
            _ClientCode.ParameterName = "@ClientCode";
            _ClientCode.Size = 50;
            _ClientCode.Value = ClientCode;
            cmd.Parameters.Add(_ClientCode);
            System.Data.SqlClient.SqlParameter _pFrom = new System.Data.SqlClient.SqlParameter();
            _pFrom.ParameterName = "@pFrom";
            _pFrom.Size = -1;
            _pFrom.Value = pFrom;
            cmd.Parameters.Add(_pFrom);
            System.Data.SqlClient.SqlParameter _pTo = new System.Data.SqlClient.SqlParameter();
            _pTo.ParameterName = "@pTo";
            _pTo.Size = -1;
            _pTo.Value = pTo;
            cmd.Parameters.Add(_pTo);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pInsertClientReceiptCommand(System.Data.DataTable pClientReceipt, System.Data.DataTable ContextInfo, out long SuccessCode)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pInsertClientReceipt";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pClientReceipt = new System.Data.SqlClient.SqlParameter();
            _pClientReceipt.ParameterName = "@pClientReceipt";
            _pClientReceipt.Size = -1;
            _pClientReceipt.Value = pClientReceipt;
            cmd.Parameters.Add(_pClientReceipt);
            System.Data.SqlClient.SqlParameter _ContextInfo = new System.Data.SqlClient.SqlParameter();
            _ContextInfo.ParameterName = "@ContextInfo";
            _ContextInfo.Size = -1;
            _ContextInfo.Value = ContextInfo;
            cmd.Parameters.Add(_ContextInfo);
            SuccessCode = -1;
            System.Data.SqlClient.SqlParameter _SuccessCode = new System.Data.SqlClient.SqlParameter();
            _SuccessCode.ParameterName = "@SuccessCode";
            _SuccessCode.Size = -1;
            _SuccessCode.Value = SuccessCode;
            cmd.Parameters.Add(_SuccessCode);
            _SuccessCode.Direction = ParameterDirection.Output;
            SuccessCode = ((long)(_SuccessCode.Value));
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pGetReceiptRecommendationCommand(int pOrgId, string pStatus, string pClientCode, System.Data.DataTable ContextInfo)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetReceiptRecommendation";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgId = new System.Data.SqlClient.SqlParameter();
            _pOrgId.ParameterName = "@pOrgId";
            _pOrgId.Size = -1;
            _pOrgId.Value = pOrgId;
            cmd.Parameters.Add(_pOrgId);
            System.Data.SqlClient.SqlParameter _pStatus = new System.Data.SqlClient.SqlParameter();
            _pStatus.ParameterName = "@pStatus";
            _pStatus.Size = 100;
            _pStatus.Value = pStatus;
            cmd.Parameters.Add(_pStatus);
            System.Data.SqlClient.SqlParameter _pClientCode = new System.Data.SqlClient.SqlParameter();
            _pClientCode.ParameterName = "@pClientCode";
            _pClientCode.Size = 20;
            _pClientCode.Value = pClientCode;
            cmd.Parameters.Add(_pClientCode);
            System.Data.SqlClient.SqlParameter _ContextInfo = new System.Data.SqlClient.SqlParameter();
            _ContextInfo.ParameterName = "@ContextInfo";
            _ContextInfo.Size = -1;
            _ContextInfo.Value = ContextInfo;
            cmd.Parameters.Add(_ContextInfo);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pUpdateReceiptRecommendationCommand(System.Data.DataTable pClientReceipt, System.Data.DataTable ContextInfo)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pUpdateReceiptRecommendation";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pClientReceipt = new System.Data.SqlClient.SqlParameter();
            _pClientReceipt.ParameterName = "@pClientReceipt";
            _pClientReceipt.Size = -1;
            _pClientReceipt.Value = pClientReceipt;
            cmd.Parameters.Add(_pClientReceipt);
            System.Data.SqlClient.SqlParameter _ContextInfo = new System.Data.SqlClient.SqlParameter();
            _ContextInfo.ParameterName = "@ContextInfo";
            _ContextInfo.Size = -1;
            _ContextInfo.Value = ContextInfo;
            cmd.Parameters.Add(_ContextInfo);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pGetTSPClientCurrentLedgerStatusCommand(int OrgId, string ClientCode)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetTSPClientCurrentLedgerStatus";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _OrgId = new System.Data.SqlClient.SqlParameter();
            _OrgId.ParameterName = "@OrgId";
            _OrgId.Size = -1;
            _OrgId.Value = OrgId;
            cmd.Parameters.Add(_OrgId);
            System.Data.SqlClient.SqlParameter _ClientCode = new System.Data.SqlClient.SqlParameter();
            _ClientCode.ParameterName = "@ClientCode";
            _ClientCode.Size = 50;
            _ClientCode.Value = ClientCode;
            cmd.Parameters.Add(_ClientCode);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pGetTSPClientDetailsCommand(int pOrgId, long pClientID)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetTSPClientDetails";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgId = new System.Data.SqlClient.SqlParameter();
            _pOrgId.ParameterName = "@pOrgId";
            _pOrgId.Size = -1;
            _pOrgId.Value = pOrgId;
            cmd.Parameters.Add(_pOrgId);
            System.Data.SqlClient.SqlParameter _pClientID = new System.Data.SqlClient.SqlParameter();
            _pClientID.ParameterName = "@pClientID";
            _pClientID.Size = -1;
            _pClientID.Value = pClientID;
            cmd.Parameters.Add(_pClientID);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pGetSelectedTSPCreditDebitCommand(int pOrgId, string pType, long pId)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetSelectedTSPCreditDebit";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgId = new System.Data.SqlClient.SqlParameter();
            _pOrgId.ParameterName = "@pOrgId";
            _pOrgId.Size = -1;
            _pOrgId.Value = pOrgId;
            cmd.Parameters.Add(_pOrgId);
            System.Data.SqlClient.SqlParameter _pType = new System.Data.SqlClient.SqlParameter();
            _pType.ParameterName = "@pType";
            _pType.Size = 50;
            _pType.Value = pType;
            cmd.Parameters.Add(_pType);
            System.Data.SqlClient.SqlParameter _pId = new System.Data.SqlClient.SqlParameter();
            _pId.ParameterName = "@pId";
            _pId.Size = -1;
            _pId.Value = pId;
            cmd.Parameters.Add(_pId);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pGetReceiptStatusCommand(int pOrgId, string pClientCode, string pStatus, System.DateTime pFrom, System.DateTime pTo)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetReceiptStatus";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgId = new System.Data.SqlClient.SqlParameter();
            _pOrgId.ParameterName = "@pOrgId";
            _pOrgId.Size = -1;
            _pOrgId.Value = pOrgId;
            cmd.Parameters.Add(_pOrgId);
            System.Data.SqlClient.SqlParameter _pClientCode = new System.Data.SqlClient.SqlParameter();
            _pClientCode.ParameterName = "@pClientCode";
            _pClientCode.Size = 20;
            _pClientCode.Value = pClientCode;
            cmd.Parameters.Add(_pClientCode);
            System.Data.SqlClient.SqlParameter _pStatus = new System.Data.SqlClient.SqlParameter();
            _pStatus.ParameterName = "@pStatus";
            _pStatus.Size = 20;
            _pStatus.Value = pStatus;
            cmd.Parameters.Add(_pStatus);
            System.Data.SqlClient.SqlParameter _pFrom = new System.Data.SqlClient.SqlParameter();
            _pFrom.ParameterName = "@pFrom";
            _pFrom.Size = -1;
            _pFrom.Value = pFrom;
            cmd.Parameters.Add(_pFrom);
            System.Data.SqlClient.SqlParameter _pTo = new System.Data.SqlClient.SqlParameter();
            _pTo.ParameterName = "@pTo";
            _pTo.Size = -1;
            _pTo.Value = pTo;
            cmd.Parameters.Add(_pTo);
            return cmd;
        }
    }
}
