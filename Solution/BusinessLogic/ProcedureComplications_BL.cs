using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using Attune.Solution.DAL;
using Attune.Podium.BusinessEntities;
using System.Collections;
using Attune.Podium.Common;

namespace Attune.Solution.BusinessComponent
{
    public class ProcedureComplications_BL
    {
        ContextDetails globalContextDetails;
        public ProcedureComplications_BL()
        {

        }
        public ProcedureComplications_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long GetComplications(int procedureID, out List<Complication> parent, out List<Complication> child)
        {
            long returnCode = -1;
            parent = new List<Complication>();
            child = new List<Complication>();

            
            try
            {
                ProcedureComplications_DAL ProcComplicationsDAL=new ProcedureComplications_DAL(globalContextDetails);
                returnCode = ProcComplicationsDAL.GetComplications(procedureID, out parent, out child);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in URI_BL.GetComplications : ", ex);
            }

            return returnCode;
        }

    }
}
