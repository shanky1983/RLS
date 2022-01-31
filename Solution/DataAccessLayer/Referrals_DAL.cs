using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Data.SqlClient;
using System.Collections.Generic;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.BusinessEntities;
using Attune.Podium.Common;

namespace Attune.Solution.DAL
{
    public class Referrals_DAL
    {
        ContextDetails globalContextDetails;
        public Referrals_DAL()
        {

        }
        public Referrals_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long SaveReferrals(List<Referral> lstReferrals, List<OrderedInvestigations> lstUpdatePatientInvStatusHL, long LID)
        {
            long returnCode = -1;
            try
            {
                DataTable dtReferrals = UDT_DAL.ConvertToReferrals(lstReferrals);
                DataTable dtOrderedInv = UDT_DAL.ConvertToOrderedInvestigation(lstUpdatePatientInvStatusHL);
                SqlCommand cmd = Command.pInsertReferralsCommand(dtReferrals, dtOrderedInv, LID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                cmd.Parameters.Add("@Ret", SqlDbType.Int);
                cmd.Parameters["@Ret"].Direction = ParameterDirection.ReturnValue;
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@Ret"].Value);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveReferrals in Referrals_DAL", ex);
            }
            return returnCode;


        }

        public long GetTestname(int OrgID, out List<InvestigationMaster> Testname)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            Testname = new List<InvestigationMaster>();
            try
            {
                SqlCommand cmd = Command.pGetTestnameCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out Testname);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetALLLocation in Referrals_DAL", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return returnCode;
        }
        public long UpdateReferrals(List<Referral> lstReferrals, long Lid, long referralID, string flag)
        {
            long returnCode = -1;
            try
            {
                DataTable dtReferrals = UDT_DAL.ConvertToReferrals(lstReferrals);

                SqlCommand cmd = Command.pUpdateReferralsCommand(dtReferrals, Lid, referralID, flag, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                cmd.Parameters.Add("@Ret", SqlDbType.Int);
                cmd.Parameters["@Ret"].Direction = ParameterDirection.ReturnValue;
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@Ret"].Value);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateReferrals in Referrals_DAL", ex);
            }
            return returnCode;


        }




        public long GetInBoundReferalDetails(long pOrgId, long pLocation, out List<Referral> lstReferrals)
        {
            long returnCode = -1;
            lstReferrals = new List<Referral>();
            SqlCommand cmd = Command.pGetInBoundReferalDetailsCommand(pOrgId, pLocation, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstReferrals);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInBoundReferalDetails in Referrals_DAL", ex);
            }
            return returnCode;
        }

        public long GetOutBoundReferalsDetails(long pOrgId, long pLocation, out List<Referral> lstReferrals)
        {
            long returnCode = -1;
            lstReferrals = new List<Referral>();
            SqlCommand cmd = Command.pGetOutBoundReferalsDetailsCommand(pOrgId, pLocation, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstReferrals);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetOutBoundReferalsDetails in Referrals_DAL", ex);
            }
            return returnCode;
        }

        //Changes of DataSet To DataReader Made By Arivalagan.k
        public long GetALLLocation(int OrgID, out List<OrganizationAddress> lstLocation)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstLocation = new List<OrganizationAddress>();
            try
            {
                SqlCommand cmd = Command.pGetALLLocationCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstLocation);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetALLLocation in Referrals_DAL", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return returnCode;
        }

        public long GetReferralStatus(int RoleID, string Type, out List<ReferralActionOption> lstReferralStatus)
        {
            long returnCode = -1;
            lstReferralStatus = new List<ReferralActionOption>();
            try
            {
                SqlCommand cmd = Command.pGetReferralStatusCommand(RoleID, Type, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstReferralStatus);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetReferralStatus in Referrals_DAL", ex);
            }

            return returnCode;

        }

        public long UpdateReferralStatus(long pReferralId, string Type, long pActionID, long Lid)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pUpdateReferralStatusCommand(pReferralId, pActionID, Lid, Type, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                cmd.Parameters.Add("@retCode", SqlDbType.Int);
                cmd.Parameters["@retCode"].Direction = ParameterDirection.ReturnValue;
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@retCode"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateReferralStatus in Referrals_DAL", ex);
            }

            return returnCode;
        }

        public long GetReferedInvestigation(long patientVisitID, out List<Patient> lstPatient,
                                              out List<OrderedInvestigations> lstInvestigation, out List<Physician> lstPhysician)
        {
            long returnCode = -1;
            lstPatient = new List<Patient>();
            lstInvestigation = new List<OrderedInvestigations>();
            lstPhysician = new List<Physician>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetReferedInvestigationCommand(patientVisitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables[0].Rows.Count > 0) // Patient Detail
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatient);
                    }

                    if (ds.Tables[1].Rows.Count > 0) // Patient Investigation Detail
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[1], out lstInvestigation);
                    }

                    if (ds.Tables[2].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[2], out lstPhysician);
                    }

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading Refered investigation detail", ex);
            }
            return returnCode;
        }
        public long SearchOutBoundReferals(long pOrgId, long pLocation, string ReferedDate, string PatientURN, string ReferedOrg, string ReferedLoc, string Status, out List<Referral> lstReferrals)
        {
            long returnCode = -1;
            lstReferrals = new List<Referral>();
            SqlCommand cmd = Command.pSearchOutBoundReferalsCommand(pOrgId, pLocation, ReferedDate, PatientURN, ReferedOrg, ReferedLoc, Status, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstReferrals);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetOutBoundReferalsDetails in Referrals_DAL", ex);
            }
            return returnCode;
        }

        public long SearchInBoundReferals(long pOrgId, long pLocation, string ReferedDate, string PatientURN, string ReferedOrg, string ReferedLoc, string Status, out List<Referral> lstReferrals)
        {
            long returnCode = -1;
            lstReferrals = new List<Referral>();
            SqlCommand cmd = Command.pSearchInBoundReferalsCommand(pOrgId, pLocation, ReferedDate, PatientURN, ReferedOrg, ReferedLoc, Status, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstReferrals);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SearchInBoundReferals in Referrals_DAL", ex);
            }
            return returnCode;
        }

        public long GetReferralsINVDetails(long patientVisitID, long Rid, out List<Referral> lstInvestigationFeesDetails)
        {
            long returnCode = -1;
            lstInvestigationFeesDetails = new List<Referral>();
            SqlCommand cmd = Command.pGetReferralsINVDetailsCommand(patientVisitID, Rid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvestigationFeesDetails);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetOutBoundReferalsDetails in Referrals_DAL", ex);
            }
            return returnCode;
        }

        public long GetOrgReferrals(int OrgID, int ILocationID, long Rid, out List<Referral> lstReferral)
        {
            long returnCode = -1;
            lstReferral = new List<Referral>();
            SqlCommand cmd = Command.pGetOrgReferralsCommand(OrgID, ILocationID, Rid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstReferral);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetOrgReferrals in Referrals_DAL", ex);
            }
            return returnCode;
        }
        public long GetOrgReferralsInvestigations(long ReferralID, int OrgID, int ILocationID, long patientVisitID, out List<BillingFeeDetails> lstInvestigationFeesDetails)
        {
            long returnCode = -1;

            SqlCommand cmd = Command.pGetOrgReferralsInvestigationsCommand(OrgID, ILocationID, ReferralID, patientVisitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            lstInvestigationFeesDetails = new List<BillingFeeDetails>();
            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
            }

            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvestigationFeesDetails);
            }

            return returnCode;

        }

        public long UpdateReferralDetails(long Rid, long LID, long patientVisitID)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pUpdateReferralDetailsCommand(Rid, LID, patientVisitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                cmd.Parameters.Add("@retCode", SqlDbType.Int);
                cmd.Parameters["@retCode"].Direction = ParameterDirection.ReturnValue;
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@retCode"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateReferralStatus in Referrals_DAL", ex);
            }

            return returnCode;
        }

        public long CheckReferralsAvailable(long ReferedByVisitID, int ReferralVisitPurposeID, out int pCount, out long referralID)
        {
            long returnCode = -1;
            referralID = -1;
            pCount = -1;
            try
            {
                SqlCommand cmd = Command.pCheckReferralsAvailableCommand(ReferedByVisitID, ReferralVisitPurposeID, out pCount, out referralID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    pCount = Convert.ToInt32(cmd.Parameters["@pCount"].Value);
                    referralID = Convert.ToInt32(cmd.Parameters["@pReferralID"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in CheckReferralsAvailable DAL", ex);
            }
            return returnCode;
        }

        public long GetReferralDetailstoEdit(long ReferedByVisitID, int ReferralVisitPurposeID, out List<Referral> lstReferrals)
        {
            long returnCode = -1;
            lstReferrals = new List<Referral>();
            try
            {
                SqlCommand cmd = Command.pGetReferralDetailstoEditCommand(ReferedByVisitID, ReferralVisitPurposeID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstReferrals);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetReferralDetailstoEdit DAL", ex);
            }
            return returnCode;
        }
        public long CheckReferralsInvestigation(List<OrderedInvestigations> lstUpdatePatientInvStatusHL, out List<OrderedInvestigations> lstReferralsInvestigation)
        {
            long returnCode = -1;
            lstReferralsInvestigation = new List<OrderedInvestigations>();
            DataTable dtOrderedInv = UDT_DAL.ConvertToOrderedInvestigation(lstUpdatePatientInvStatusHL);
            try
            {
                SqlCommand cmd = Command.pCheckReferralsInvestigationCommand(dtOrderedInv, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstReferralsInvestigation);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in lstReferralsInvestigation DAL", ex);
            }
            return returnCode;
        }

        public long GetTemplateNameBytemplateID(string TemplateType, int pOrgID, out List<InvResultTemplate> lstInvResultTemplate)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetTemplateNameBytemplateIDCommand(TemplateType, pOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstInvResultTemplate = new List<InvResultTemplate>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvResultTemplate);
            }

            return returnCode;
        }


        public long GetInvResultTemplateByResultName(int OrgID, string ResultName, out List<InvResultTemplate> lstInvResultTemplate)
        {
            long result = -1;
            lstInvResultTemplate = new List<InvResultTemplate>();
            SqlCommand cmd = Command.pGetInvResultTemplateByResultNameCommand(OrgID, ResultName, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        result = Utilities.ConvertTo(ds.Tables[0], out lstInvResultTemplate);
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetInvestigationResultTemplate Investigation_DAL", e);
            }
            return result;
        }


        public long SaveReferralsAndMedicalCertificate(List<Referral> lstReferrals, long LID, out int IsExist)
        {
            long returnCode = -1;
            IsExist = -1;
            try
            {
                DataTable dtReferrals = UDT_DAL.ConvertToReferrals(lstReferrals);
                SqlCommand cmd = Command.pSaveReferralsAndMedicalCertificateCommand(dtReferrals, LID, out IsExist, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    IsExist = Convert.ToInt32(cmd.Parameters["@IsExist"].Value);

                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveReferrals in Referrals_DAL", ex);
            }
            return returnCode;

        }


        public long CheckReferralsAndCertificate(long ReferedByVisitID, out int pCount)
        {
            long returnCode = -1;
            pCount = -1;
            try
            {
                SqlCommand cmd = Command.pCheckReferralsAndCertificateCommand(ReferedByVisitID, out pCount, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    pCount = Convert.ToInt32(cmd.Parameters["@pCount"].Value);

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in CheckReferralsAndCertificateAvailable DAL", ex);
            }
            return returnCode;
        }

        public long GetReferralTemplate(string ResultName, long VisitID, out List<Referral> lstReferrals)
        {
            long returnCode = -1;
            lstReferrals = new List<Referral>();
            try
            {
                SqlCommand cmd = Command.pGetReferralTemplateCommand(ResultName, VisitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstReferrals);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetReferralDetailstoEdit DAL", ex);
            }
            return returnCode;
        }




        public long SaveTrustedOrgReferrals(List<Referral> lstReferrals, long LID, out int IsExist)
        {
            long returnCode = -1;
            IsExist = -1;
            try
            {
                DataTable dtReferrals = UDT_DAL.ConvertToReferrals(lstReferrals);
                SqlCommand cmd = Command.pSaveTrustedOrgReferralsCommand(dtReferrals, LID, out IsExist, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    IsExist = Convert.ToInt32(cmd.Parameters["@IsExist"].Value);

                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveTrustedOrgReferrals in Referrals_DAL", ex);
            }
            return returnCode;

        }


        public long GetReferralAndMedicalDetails(long ReferedByVisitID, int ReferralVisitPurposeID, out List<Referral> lstReferrals)
        {
            long returnCode = -1;
            lstReferrals = new List<Referral>();
            try
            {
                SqlCommand cmd = Command.pGetReferralAndMedicalDetailsCommand(ReferedByVisitID, ReferralVisitPurposeID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstReferrals);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetReferralAndMedicalDetails DAL", ex);
            }
            return returnCode;
        }


        public long GerReferralAndMedicalForEdit(long ReferedByVisitID, int ReferralVisitPurposeID, long ReferralID, out List<Referral> lstReferrals)
        {
            long returnCode = -1;
            lstReferrals = new List<Referral>();
            try
            {
                SqlCommand cmd = Command.pGerReferralAndMedicalForEditCommand(ReferedByVisitID, ReferralVisitPurposeID, ReferralID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstReferrals);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GerReferralAndMedicalForEdit DAL", ex);
            }
            return returnCode;
        }



        public long UpdateReferralsAndMedicalCF(List<Referral> lstReferrals, long Lid, long referralID)
        {
            long returnCode = -1;
            try
            {
                DataTable dtReferrals = UDT_DAL.ConvertToReferrals(lstReferrals);

                SqlCommand cmd = Command.pUpdateReferralsAndMedicalCFCommand(dtReferrals, Lid, referralID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                cmd.Parameters.Add("@Ret", SqlDbType.Int);
                cmd.Parameters["@Ret"].Direction = ParameterDirection.ReturnValue;
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@Ret"].Value);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateReferralsAndMedicalCF in Referrals_DAL", ex);
            }
            return returnCode;


        }
 //Changes of DataSet To DataReader Made By Arivalagan.k
        public long GetProcessingLocation(int OrgID, long LocationID, long InvestigationID, string pType, out List<InvestigationOrgMapping> lstInvestigationOrgMapping, out List<InvestigationOrgMapping> lstInvestigationLocationMapping)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstInvestigationOrgMapping = new List<InvestigationOrgMapping>();
            lstInvestigationLocationMapping = new List<InvestigationOrgMapping>();
            int rsCount = 0;
            try
            {
                SqlCommand cmd = Command.pGetProcessingLocationCommand(OrgID, LocationID, InvestigationID, pType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                     dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstInvestigationOrgMapping);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstInvestigationLocationMapping);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting processing location", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            } 
            return returnCode;
        }
        // changed dataset to datareader by Arivalagan.k
        public long GetCheckCode(string codeType, string Code, int ExecuteType, out int Count, int OrgID, out List<DiscountPolicy> lstDiscountPolicy)
        {
            long returnCode = -1;
            Count = -1;
            lstDiscountPolicy = new List<DiscountPolicy>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetCheckCodeCommand(codeType, Code, out Count, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    if (ExecuteType == 1)
                    {
                        dataReader = dbEngine.ExecuteReader(cmd);
                        if (dataReader != null)
                        {
                            returnCode = Utilities.ConvertTo(dataReader, out lstDiscountPolicy);
                            dataReader.Close();
                        }
                    }
                    else
                    {
                        dataReader = dbEngine.ExecuteReader(cmd);
                        Count = Convert.ToInt32(cmd.Parameters["@pCount"].Value.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetCheckCode", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return returnCode;
        }


        public long GetConsentFormDeatils(long VisitID, int @pTemplateID, string @pTemplateType, long @pOrgID, out List<ConsentTemplateDetails> lstConsentTemplateDetails)
        {
            long returnCode = -1;
            lstConsentTemplateDetails = new List<ConsentTemplateDetails>();
            try
            {
                SqlCommand cmd = Command.pGetTemplateDetailsCommand(0, @pTemplateID, @pTemplateType, @pOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstConsentTemplateDetails);
                    }

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetConsentFormTemplate DAL", ex);
            }
            return returnCode;
        }


        public long GetConsentFormTemplate(long @pOrgID, out List<ConsentTypeMaster> lstConsentTypeMaster)
        {
            long returnCode = -1;
            lstConsentTypeMaster = new List<ConsentTypeMaster>();
            try
            {
                SqlCommand cmd = Command.pGetTemplateMasterCommand(@pOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstConsentTypeMaster);
                    }

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetConsentFormTemplate DAL", ex);
            }
            return returnCode;
        }



        public long SaveConsentletters(long VisitID, int TemplateID, string BeforeSign, string AfterSign)
        {
            long returnCode = -1;

            try
            {
                SqlCommand cmd = Command.PSaveConsentLettersCommand(VisitID, TemplateID, BeforeSign, AfterSign, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);


                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetConsentFormTemplate DAL", ex);
            }
            return returnCode;
        }

        public long GetConsentletters(long VisitID, long typeID, out List<ConsentLetters> lstLetters)
        {
            long returnCode = -1;
            lstLetters = new List<ConsentLetters>();
            try
            {
                SqlCommand cmd = Command.PgetConsentLettersCommand(VisitID, typeID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstLetters);
                    }

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Get ConsentLetters  DAL", ex);
            }
            return returnCode;
        }
        public long GetLocationPrinter(int OrgID, int OrgAddressID,string PrinterType, out List<LocationPrintMap> lstLocation)
        {
            long returnCode = -1;
            lstLocation = new List<LocationPrintMap>();
            try
            {
                SqlCommand cmd = Command.pGetLocationPrinterCommand(OrgID, OrgAddressID, PrinterType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstLocation);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetALLLocation in Referrals_DAL", ex);
            }

            return returnCode;

        }

        public long GetoneALLProcessingLocation(int OrgID, out List<OrganizationAddress> lstLocation)
        {
            long returnCode = -1;
            IDataReader dataReader = null;
            lstLocation = new List<OrganizationAddress>();
            try
            {
                SqlCommand cmd = Command.pGetoneALLProcessingLocationCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);

                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstLocation);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetALLProcessingLocation in Referrals_DAL", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return returnCode;

        }
        //Change dataset to datareader made by Arivalagan.k
        public long GetALLProcessingLocation(int OrgID, out List<OrganizationAddress> lstLocation)
        {
            long returnCode = -1;
            IDataReader dataReader = null;
            lstLocation = new List<OrganizationAddress>();
            try
            {
                SqlCommand cmd = Command.pGetALLProcessingLocationCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);

                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstLocation);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetALLProcessingLocation in Referrals_DAL", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return returnCode;

        }
        //Change dataset to datareader made by Arivalagna.k
        public long GetRegisterLocation(int OrgID, out List<OrganizationAddress> lstLocation)
        {
            long returnCode = -1;
            lstLocation = new List<OrganizationAddress>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetRegisterLocationCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);


                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstLocation);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetRegisterLocation in Referrals_DAL", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return returnCode;
        }
        public long GetLocation_Printer(int OrgID, int OrgAddressID, string PrinterType, out List<LocationPrintMap> lstLocation)
        {
            long returnCode = -1;
            lstLocation = new List<LocationPrintMap>();
            try
            {
                //SqlCommand cmd = Command.pGetLocationPrinterCommand(OrgID, OrgAddressID, PrinterType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                SqlCommand cmd = Command.pGetLocation_PrinterCommand(OrgID, OrgAddressID, PrinterType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstLocation);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetALLLocation in Referrals_DAL", ex);
            }

            return returnCode;

        }
    }
}
