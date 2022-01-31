using System;
using System.Data;
using System.Data.SqlClient;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.BusinessEntities;
using System.Configuration;
using System.Web;
using System.Collections;
using System.Collections.Generic;
using Attune.Podium.Common;

namespace Attune.Solution.DAL
{
    public class PatientCondition_DAL
    {
        ContextDetails globalContextDetails;
        public PatientCondition_DAL()
        {

        }
        public PatientCondition_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long GetPatientConditions(out List<PatientCondition> lstPatientCondition)
        {
            long returnCode = -1;

            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "pGetPatientConditions";
            lstPatientCondition = new List<PatientCondition>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }


            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientCondition);
            }

            return returnCode;
        }

        public DataSet LoadCondition(Attune.Podium.BusinessEntities.PatientCondition objCondition)
        {

            DataSet ds = new DataSet();
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "Cproc_Get_HC_PatientCondition";






            Attune.Podium.DataAccessEngine.DBEngine objDB = new DBEngine();


            return ds;
        }


    }
}
