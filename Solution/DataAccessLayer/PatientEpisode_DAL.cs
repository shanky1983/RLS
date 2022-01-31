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
using System.Transactions;

namespace Attune.Solution.DAL
{
    public class PatientEpisode_DAL
    {

        ContextDetails globalContextDetails;
        public PatientEpisode_DAL()
        {
            
        }
        public PatientEpisode_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long InsertPatientEpisodeDAL(PatientEpisode lstPatientEpisode, List<VisitClientMapping> lstVisitClientMapping)
        {
            long returnCode = -1;
            SqlCommand cmdInsertPatEpisode = new SqlCommand();
            cmdInsertPatEpisode = Command.pInsertPatientEpisodeCommand(
                                    lstPatientEpisode.PatientEpisodeID,
                                    lstPatientEpisode.EpisodeID,
                                    lstPatientEpisode.EpisodeName,
                                    lstPatientEpisode.EpisodeStartDt,
                                    lstPatientEpisode.EpisodeEndDt,
                                    lstPatientEpisode.PatientID,
                                    lstPatientEpisode.OrgID,
                                    lstPatientEpisode.Status,
                                    lstPatientEpisode.NoofSitting,
                                    lstPatientEpisode.IsCreditBill,
                                    lstPatientEpisode.CreatedBy,

                                    lstPatientEpisode.ReferingPhysicianID,
                                    lstPatientEpisode.ReferingPhysicianName,

                                    lstPatientEpisode.PatientVisitId,
                                    lstPatientEpisode.OrgAddressID,
                                    lstPatientEpisode.RefType,
                                    lstPatientEpisode.RefHospitalID,
                                    lstPatientEpisode.RefHospitalName,

                                    UDT_DAL.ConvertToVisitClientMapping(lstVisitClientMapping)
                                    , UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmdInsertPatEpisode);
                }
            }

            catch (Exception ex)
            {
                CLogger.LogError("Error while saving patient. Query: " + cmdInsertPatEpisode.CommandText, ex);
            }

            return returnCode;
        }
        public long GetPatientEpisodeDet(long EpisodeID, long PatientID, int OrgID, out List<PatientEpisode> lstEpisode, out List<PatientEpisode> lstEpisode1)
        {
            long returnCode = -1;
            lstEpisode = new List<PatientEpisode>();
            lstEpisode1 = new List<PatientEpisode>();
            try
            {
                SqlCommand objCommand = Command.pGetPatientEpisodeDetCommand(EpisodeID, PatientID, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();

                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstEpisode);
                }

                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstEpisode1);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while get procedure name, pGetProcedureName sp", ex);
            }
            return returnCode;
        }

        public long SearchEpisodePatient(string lPatientNo, string strSmartCardNo, string strPatientName,string strRelation,  string strDOB, string strLocation, string strOccupation,string strCity,string strMobile, int orgID, int parentID,string urno,long urnTypeID,int pageSize,int startRowIndex,string Nationality,string TPAID,string ClientID,DateTime FDate,DateTime TDate, out List<PatientEpisode> lstPatientEpisode)
        {
            long returnCode = -1;
            System.Data.SqlClient.SqlCommand cmd;
            cmd = Command.pSearchEpisodePatientCommand(lPatientNo, strSmartCardNo, strPatientName, strRelation, strDOB, strLocation, strOccupation, strCity, strMobile, orgID, parentID, urno, urnTypeID, pageSize, startRowIndex, Nationality, TPAID, ClientID, FDate, TDate,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstPatientEpisode = new List<PatientEpisode>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }

            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientEpisode);
            }

            return returnCode;
        }
    }
}
