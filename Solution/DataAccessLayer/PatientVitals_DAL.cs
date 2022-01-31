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
    public class PatientVitals_DAL
    {
        ContextDetails globalContextDetails;
        public PatientVitals_DAL()
        {

        }
        public PatientVitals_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long SavePatientVitals(int orgID, int VisitType, List<PatientVitals> lstPatientVitals)
        {
            long returnCode = -1;

            DataTable dtPatientVitals = UDT_DAL.ConvertToPatientVitals(lstPatientVitals);
            
            SqlCommand cmd = Command.pInsertPatientVitalsCommand(orgID, VisitType, dtPatientVitals,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine(false))
            {
                returnCode = dbEngine.ExecuteNonQuery(cmd);

            }





            return returnCode;
        }
        

        public DataSet GetVisitId(DateTime StartDate,DateTime EndDate)
        {
            DataSet ds = new DataSet();
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "Cproc_Get_HC_VisitId";


            objCommand.Parameters.Add("@pStartDate", SqlDbType.DateTime);
            objCommand.Parameters.Add("@pEndDate", SqlDbType.DateTime);



            objCommand.Parameters["@pStartDate"].Value = StartDate;
            objCommand.Parameters["@pEndDate"].Value = EndDate;
           

            Attune.Podium.DataAccessEngine.DBEngine objDB = new DBEngine();


            return ds;
        }

        public DataSet PatientVitals(ArrayList PatientVitals)
        {
            DataSet ds = new DataSet();
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.Text;
            
                Attune.Podium.DataAccessEngine.DBEngine objDB = new DBEngine();
            return ds;
        }

        public long GetVitalsForUI(int iOrgID, string vitalsGroup, out List<VitalsUOMJoin> lstVitalsUOMJoin)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetVitalsForUICommand(iOrgID, vitalsGroup,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            
            lstVitalsUOMJoin = new List<VitalsUOMJoin>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }

                        
            if (ds.Tables.Count > 0)
            {
               returnCode = Utilities.ConvertTo(ds.Tables[0], out lstVitalsUOMJoin);
            }

            return returnCode;
        }

        public long GetVitalsForUpdate(long patientID, int iOrgID, out long visitID, out List<VitalsUOMJoin> lstVitalsUOMJoin)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetVitalsForUpdateCommand(patientID, iOrgID, out visitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstVitalsUOMJoin = new List<VitalsUOMJoin>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }


            if (ds.Tables.Count > 0)
            {
                visitID = Convert.ToInt32(objCommand.Parameters["@VisitID"].Value);
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstVitalsUOMJoin);
            }
            else
            {
                visitID = -1;
            }

            return returnCode;
        }

        public long GetPatientVitals(long patientID, long visitID, out List<VitalsUOMJoin> patientVitals)
        {
            
            long returnCode = -1;
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            patientVitals = new List<VitalsUOMJoin>();
            cmd = Command.pGetPatientVitalsCommand(patientID, visitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dBEngine = new DBEngine(false))
            {
                dBEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out patientVitals);
            }
            return returnCode;
        }

        public long GetVisitStatusForVitals(long patientID, out long visitID, out long vType, out long VitalsCount)
        {
            long returnCode = -1;
            visitID = -1;
            vType = -1;
            VitalsCount = -1;
            DataSet ds = new DataSet();
            SqlCommand cmd = Command.pGetVisitStatusForVitalsCommand(patientID, out visitID, out vType, out VitalsCount,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine(false))
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
                visitID = Convert.ToInt64(cmd.Parameters["@pVisitID"].Value);
                vType = Convert.ToInt64(cmd.Parameters["@pVisitType"].Value);
                VitalsCount = Convert.ToInt64(cmd.Parameters["@pVitalsCount"].Value);   
            }

            return returnCode;
        }


        public long GetSelectOption(long RoleID, out List<VitalsPageOptions> lstvitalspageoption)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetVitalsPageOptionCommand(RoleID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstvitalspageoption = new List<VitalsPageOptions>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }


            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstvitalspageoption);
            }

            return returnCode;
        }

        public long GetANCPatientVisitID(long PatientID, DateTime visitdate, out long visitID)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetANCPatientVisitIDCommand(PatientID, visitdate, out visitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }


            visitID = Convert.ToInt32(objCommand.Parameters["@VisitID"].Value);

            return returnCode;
        }


        public long GetInPatientVitalsForUpdate(long patientVisitID, int iOrgID, out long visitID, out List<VitalsUOMJoin> lstVitalsUOMJoin)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetInPatientVitalsForUpdateCommand(patientVisitID, iOrgID, out visitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstVitalsUOMJoin = new List<VitalsUOMJoin>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                visitID = Convert.ToInt32(objCommand.Parameters["@VisitID"].Value);
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstVitalsUOMJoin);
            }
            else
            {
                visitID = -1;
            }

            return returnCode;
        }


        public long GetIPCaseRecordVitalsForUpdate(long patientVisitID, int iOrgID, out long visitID, out List<VitalsUOMJoin> lstVitalsUOMJoin)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetIPCaseRecordVitalsForUpdateCommand(patientVisitID, iOrgID, out visitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstVitalsUOMJoin = new List<VitalsUOMJoin>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                visitID = Convert.ToInt32(objCommand.Parameters["@VisitID"].Value);
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstVitalsUOMJoin);
            }
            else
            {
                visitID = -1;
            }

            return returnCode;
        }


        public long GetVitalsType(long OrgID, out List<VitalsType> lstVitalsType)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetVitalsTypeCommand(OrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstVitalsType = new List<VitalsType>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }


            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstVitalsType);
            }

            return returnCode;
        }



        public long GetNeonatalNotesVitalsForUpdate(long patientVisitID, int iOrgID, out long visitID, out List<VitalsUOMJoin> lstVitalsUOMJoin)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetNeonatalNotesVitalsForUpdateCommand(patientVisitID, iOrgID, out visitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstVitalsUOMJoin = new List<VitalsUOMJoin>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                visitID = Convert.ToInt32(objCommand.Parameters["@VisitID"].Value);
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstVitalsUOMJoin);
            }
            else
            {
                visitID = -1;
            }

            return returnCode;
        }



    }


}
