using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Data.SqlClient;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.BusinessEntities;
using System.Collections.Generic;
using Attune.Podium.Common;
using System.Data.Common;
using System.Transactions;

namespace Attune.Solution.DAL
{
    public class Users_DAL
    {
        ContextDetails globalContextDetails;
        public Users_DAL()
        {
            
        }
        public Users_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long SaveUsers(Users user)
        {
            long lresult = -1;

            int addressCount = user.Address.Count;

            SqlCommand[] cmdInsertAddress = new SqlCommand[addressCount];

            long UserID = 0;
            long addressID = 0;
            int i;
            SqlCommand cmdInsertUsers = Command.pInsertUsersCommand(user.Name, user.DOB, user.SEX, user.Email,
									user.TitleCode, user.Relegion, user.MaritalStatus, user.Qualification, user.OrgID, user.CreatedBy,
									                user.LoginID, user.WeddingDt,user.EmpID, out UserID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            cmdInsertUsers.Parameters.Add("@Return", SqlDbType.Int);
            cmdInsertUsers.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            for (i = 0; i < addressCount; i++)
            {
                cmdInsertAddress[i] = Command.pInsertUsersAddressCommand(UserID, user.Address[i].AddressType, user.Address[i].Add1,
									user.Address[i].Add2, user.Address[i].Add3, user.Address[i].PostalCode, user.Address[i].CountryID, user.Address[i].City,
									                user.Address[i].StateID, user.Address[i].MobileNumber, user.Address[i].LandLineNumber, user.Address[i].CreatedBy,user.Address[i].OtherCountryName,user.Address[i].OtherStateName,user.Address[i].CountryCode,user.Address[i].StateCode,user.Address[i].CityCode,user.Address[i].AddLevel1,user.Address[i].AddLevel2, out addressID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));


            }

            using (TransactionScope tranScope = new TransactionScope())
            {
                try
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {
                        dbEngine.ExecuteTransactionalNonQuery(cmdInsertUsers);
                        lresult = Convert.ToInt64(cmdInsertUsers.Parameters["@Return"].Value);
                        if (lresult == 0)
                        {
                            UserID = Convert.ToInt64(cmdInsertUsers.Parameters["@pUserID"].Value);
                            user.UserID = UserID;
                            for (i = 0; i < addressCount; i++)
                            {
                                cmdInsertAddress[i].Parameters["@pUserID"].Value = UserID;
                                dbEngine.ExecuteTransactionalNonQuery(cmdInsertAddress[i]);
                            }
                        }
                    }

                    tranScope.Complete();
                }
                catch (Exception ex)
                {
                    CLogger.LogError("Error while saving Users. Query: " + cmdInsertUsers.CommandText, ex);
                    tranScope.Dispose();
                }
            }
            return lresult;


        }

        public long GetCheckUserdetails(string FORENAME, DateTime DOB, string Email)
        {
            long lresult = -1;
            SqlCommand cmd = Command.pGetCheckUserExistCommand(FORENAME, DOB, Email,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@return", SqlDbType.Int);
            cmd.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            try
            {

                using (DBEngine dbEngine = new DBEngine(false))
                {
                    lresult = dbEngine.ExecuteNonQuery(cmd);
                    lresult = Convert.ToInt16(cmd.Parameters["@return"].Value.ToString());
                }


            }

            catch (Exception ex)
            {
                CLogger.LogError("Error while Check login details" + cmd.CommandText, ex);
            }

            return lresult;

        }

        public long GetLoginUserName(long LoginID, out string LoginName, out string Passwrd,out string TransPasswrd)
        {
            SqlCommand objCommand = Command.pGetLoginNameCommand(LoginID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            LoginName = "";
            Passwrd = "";
            TransPasswrd = "";
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }

            if (ds.Tables.Count > 0)
            {
                LoginName = ds.Tables[0].Rows[0]["LoginName"].ToString();
                Passwrd = ds.Tables[0].Rows[0]["Password"].ToString();
                TransPasswrd = ds.Tables[0].Rows[0]["Transactionpasssword"].ToString();
            }

            return 0;

        }

        public long SaveMasterBulkLoad(int pOrgId, long LID, string Sheettype, DataTable objbulkdata)
        {

            long returnCode = -1;
            SqlCommand cmd = Command.pInsertMasterBulkLoadCommand(pOrgId, LID, Sheettype, objbulkdata,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);
                }
            }


            catch (Exception ex)
            {
                CLogger.LogError("Error while Check login details" + cmd.CommandText, ex);
            }


            return returnCode;

        }

        public long SaveInvLocationUserMap(Users User, List<Locations> lstLoc)
        {
            long lresult = -1;
            DataTable dtLoc = new DataTable();
            dtLoc = UDT_DAL .ConvertToUDTInventoryLocations (lstLoc);
            SqlCommand cmd = Command.pInsertInvLocationUserMapCommand(User.OrgID, User.AddressID, User.LoginID, dtLoc,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    lresult = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveInventory" + cmd.CommandText, ex);
            }

            return lresult;


        }

        

        public long SavePasswordPolicy(long OrgID, List<PasswordPolicy> pwdplcy)
        {

            long returnCode = -1;
            DataTable DTvalues = UDT_DAL .ConvertToUDTPasswordPolicy (pwdplcy);
            SqlCommand cmd = Command.pInsertPasswordPolicyCommand(OrgID, DTvalues,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            
            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
          
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);
                }
            }


            catch (Exception ex)
            {
                CLogger.LogError("Error while Check login details" + cmd.CommandText, ex);
            }


            return returnCode;

        }



        public long GetPaasswordPolicy(long Orgid,out List<PasswordPolicy> lstpwdplcy)
        {
            long returnCode = -1;
            IDataReader dataReader = null;
            lstpwdplcy = new List<PasswordPolicy>();
            try
            {
                SqlCommand objCommand = Command.pGetPasswordPolicyCommand(Convert.ToInt32(Orgid), UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstpwdplcy);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetPaasswordPolicy Users_DAL", e);
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

        public long Checkpreviouspassword(long LId,long OrgId,string Pwd,out int returncode)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pGetcheckpreviouspasswordCommand(LId,Convert.ToInt32(OrgId), Pwd,out returncode,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteNonQuery(cmd);
                returncode = Convert.ToInt32(cmd.Parameters["@returncode"].Value);
            }
          
            return returnCode;


        }

        public long Checkprevioustransactionpassword(long LId, long OrgId, string Pwd, out int returncode)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pGetcheckpreviousTransactionpasswordCommand(LId,Convert.ToInt32(OrgId), Pwd, out returncode,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteNonQuery(cmd);
                returncode = Convert.ToInt32(cmd.Parameters["@returncode"].Value);
            }

            return returnCode;


        }

        public long GetPasswordPolicyCount(long OrgId, out int returncode,out int Treturncode)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pGetPasswordPolicyCountCommand(Convert.ToInt32(OrgId), out returncode,out Treturncode,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteNonQuery(cmd);
                returncode = Convert.ToInt32(cmd.Parameters["@returncode"].Value);
                Treturncode = Convert.ToInt32(cmd.Parameters["@Treturncode"].Value);
            }

            return returnCode;


        }

        public long GetPasswordValidityPeriod(long OrgId, out List<PasswordPolicy> lstpwdplcy,out List<PasswordPolicy> lstTranspwdplcy)
        {
            long returnCode = -1;
            lstpwdplcy = new List<PasswordPolicy>();
            lstTranspwdplcy = new List<PasswordPolicy>();
            IDataReader dataReader = null;
            int rsCount = 0;
            try
            {
                SqlCommand cmd = Command.pGetPasswordValidityPeriodCommand(Convert.ToInt32(OrgId), UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstpwdplcy);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstTranspwdplcy);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetPasswordValidityPeriod Users_DAL", e);
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

        public long GetEmpRegName(int pOrgID, string prefixText, out List<EmployeeRegMaster> lstEmpReg)
        {
            long returnCode = -1;
            lstEmpReg = new List<EmployeeRegMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetEmpRegNameandIDCommand(pOrgID, prefixText,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstEmpReg);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL EmployeeRegMaster", ex);
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
        public long GetReasonforblocking(int pOrgID,out List<MetaValue_Common> lstmeta)
        {
            long returnCode = -1;
            lstmeta = new List<MetaValue_Common>();
            SqlCommand cmd = new SqlCommand();
             IDataReader dataReader = null;
            try
            {
                cmd = Command.pGetReasonforBlockUserCommand(pOrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstmeta);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL ReasonforBlock", ex);
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
        public long GetAutoAuthorizeUser(int pOrgID, long pRoleID, out List<Users> lstUsers)
        {
            long returnCode = -1;
            lstUsers = new List<Users>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetAutoAuthorizeUserCommand(pOrgID, pRoleID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(SqlConnectionKey.SharedSecondary))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstUsers);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetAutoAuthorizeUser", ex);
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

        public long GetUserListByRole(int pOrgID, long pRoleID, out List<Users> lstUsers)
        {
            long returnCode = -1;
            lstUsers = new List<Users>();
             IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetUserListByRoleCommand(pOrgID, pRoleID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstUsers);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetUserListByRole", ex);
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
//kapil
        public long GetUserListByRoleDept(int pOrgID, int pdeptid, int pRoleID, out List<Users> lstUsers)
        {
            long returnCode = -1;
            lstUsers = new List<Users>();
            try
            {
                SqlCommand cmd = Command.pGetsortusersCommand(pOrgID, pdeptid, pRoleID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    IDataReader dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstUsers);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetUserListByRole", ex);
            }
            return returnCode;
        }

       public long LoadPrinterNameAndPath(int OrgID, out List<LocationPrintMap> lstLocationPrintMap)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstLocationPrintMap = new List<LocationPrintMap>();
            try
            {

                SqlCommand cmd = Command.pGetddlPrinterNameAndPathCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstLocationPrintMap);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading LoadTaxDetails() in MasterDAL", ex);
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
       #region DropDown Auto For Multiple Role
       public long GetUsersByRole(int pOrgID,out List<Users> lstUsers)
       {
           long returnCode = -1;
           lstUsers = new List<Users>();
           IDataReader dataReader = null;
           try
           {
               SqlCommand cmd = Command.pGetUsersByRoleCommand(Convert.ToInt64(pOrgID), UDT_DAL.ConvertToUDT_Context(globalContextDetails));
               using (DBEngine dbEngine = new DBEngine(SqlConnectionKey.SharedSecondary))
               {
                   dataReader = dbEngine.ExecuteReader(cmd);
                   if (dataReader != null)
                   {
                       returnCode = Utilities.ConvertTo(dataReader, out lstUsers);
                       dataReader.Close();
                   }
               }
           }
           catch (Exception ex)
           {
               CLogger.LogError("Error In DAL GetAutoAuthorizeUser", ex);
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
       #endregion
	   
	   //arun changes- credit note value insert/update/get        
       public long GetCreditNoteDetails(int OrgID, long ClientID, string CreditNoteNumber, DateTime FDate, DateTime TDate, int PageIndex,
               int PageSize, out List<CreditNotesDetails> lstCreditNoteDetail, out int PageCount)
       {
           IDataReader dataReader = null;
           long returnCode = -1;
           PageCount = 0;
           int rsCount = 0;
           SqlCommand cmd = Command.pGetCreditNoteDetailsCommand(OrgID, ClientID, CreditNoteNumber, FDate, TDate, PageIndex, PageSize, out PageCount, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
           lstCreditNoteDetail = new List<CreditNotesDetails>();
           try
           {
               using (DBEngine dbEngine = new DBEngine(false))
               {
                   dataReader = dbEngine.ExecuteReader(cmd);
                   if (dataReader != null)
                   {
                       do
                       {
                           if (rsCount == 0)
                           {
                               returnCode = Utilities.ConvertTo(dataReader, out lstCreditNoteDetail);
                           }
                           rsCount = rsCount + 1;
                       } while (dataReader.NextResult());
                       dataReader.Close();
                   }
                   Int32.TryParse(cmd.Parameters["@PageCount"].Value.ToString(), out PageCount);
               }
           }
           catch (Exception ex)
           {
               CLogger.LogError("Error while loading GetCreditNoteDetails in UserDAL ", ex);
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
       public long SaveCreditNoteDetails(List<CreditNotesDetails> lstCreditDet, long Lid, int OrgID)
       {
           long returnCode = -1;
           try
           {
               SqlCommand cmd = new SqlCommand();               
               DataTable dtCreditDet = UDT_DAL.ConvertToCreditnoteDetails(lstCreditDet);
               cmd = Command.pInsertUpdateCreditNoteDetailsCommand(dtCreditDet, out returnCode, Lid, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
               using (DBEngine dBEngine = new DBEngine(false))
               {
                   dBEngine.ExecuteNonQuery(cmd);
                   returnCode = Convert.ToInt64(cmd.Parameters["@returnStatus"].Value);
               }
           }
           catch (Exception ex)
           {
               CLogger.LogError("Error while Save or Update the SaveCreditNoteDetails in UserDAL ", ex);
           }
           return returnCode;
       }
        //
    }

}
