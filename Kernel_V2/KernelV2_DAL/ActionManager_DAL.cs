using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using Attune.KernelV2.Cmd;
using Attune.KernelV2.DataAccessEngine;
using Attune.KernelV2.Entities;
using Attune.KernelV2.UDT;
using Attune.KernelV2.Utilities;

namespace Attune.KernelV2.DAL
{
    public class ActionManager_DAL : IDisposable
    {
        UI_ContextDetails globalContextDetails;

        public ActionManager_DAL(UI_ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        public List<UI_CommunicationConfig> GetCommunicationConfig(Int32 pOrgID, String pType)
        {
            List<UI_CommunicationConfig> lstCommunicationConfig = null;
            using (DbHelper gateWay = new DbHelper())
            {
                DbDataReader dataReader;
                var cmd = KernelV2_Command.pGetCommunicationConfig_V2Command(pOrgID, pType, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                dataReader = gateWay.ExecuteReader(cmd);
                if (dataReader != null)
                {
                    lstCommunicationConfig = Utility.Tolist<UI_CommunicationConfig>(dataReader).ToList();
                }
            }
            return lstCommunicationConfig;
        }

        public List<UI_PerformingAction> GetPerformingAction(long PageID, string ButtonName, long RoleID, long PatientID, int OrgID, long PatientVisitID, 
            int pSampleID, string pIds)
        {
            List<UI_PerformingAction> lstPerformingAction = null;
            using (DbHelper gateWay = new DbHelper())
            {
                DbDataReader dataReader;
                var cmd = KernelV2_Command.pPerformingNextAction_V2Command(PageID, ButtonName, RoleID, PatientID, OrgID, PatientVisitID, pSampleID, pIds, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                dataReader = gateWay.ExecuteReader(cmd);
                if (dataReader != null)
                {
                    lstPerformingAction = Utility.Tolist<UI_PerformingAction>(dataReader).ToList();
                }
            }
            return lstPerformingAction;
        }

        public long SaveActionDetails(DataTable Dt)
        {
            long returncode;
            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pInsertNotifications_V2Command(Dt, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                returncode = gateWay.ExecuteNonQuery(cmd);
            }
            return returncode;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
