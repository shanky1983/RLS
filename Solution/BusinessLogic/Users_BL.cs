using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Attune.Podium.BusinessEntities;
using Attune.Solution.DAL;
using Attune.Podium.Common;


namespace Attune.Solution.BusinessComponent
{
  public  class Users_BL
    {
        ContextDetails globalContextDetails;
        public Users_BL()
        {

        }
        public Users_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long SaveUsers(Users use)
        {
            
            long lresult = -1;
            try
            {
                Users_DAL User = new Users_DAL(globalContextDetails);
               lresult = User.SaveUsers(use);
                
            }
            catch (Exception ex)
            {
             
			CLogger.LogError("Error while executing SaveUsers in Users_BL", ex);

            }

            return lresult;
        }
       
        public long GetCheckUserdetails(string FORENAME, DateTime DOB, string Email)
        {
            long lresult = -1;
            Users_DAL User = new Users_DAL(globalContextDetails);
            lresult = User.GetCheckUserdetails(FORENAME, DOB, Email);
            return lresult;
        }

        public long GetCheckLogindetails(string LoginName)
        {
            long lresult = -1;
            Role_DAL RoleDal = new Role_DAL(globalContextDetails);
            lresult = RoleDal.GetCheckLogindetails(LoginName);
            return lresult;
        }

        public long GetLoginUserName(long LoginID, out string LoginName, out string Passwrd, out string TransPasswrd)
        {

            long returnCode = -1;
            LoginName = "";
            Passwrd = "";
            TransPasswrd = "";
            try
            {
                Users_DAL objUser = new Users_DAL(globalContextDetails);
                returnCode = objUser.GetLoginUserName(LoginID, out LoginName,out Passwrd,out  TransPasswrd);
            }
            catch (Exception excp)
            {
			CLogger.LogError("Error while executing GetLoginUserName in Users_BL", excp);
            }
            return returnCode;
        }

        public long SaveMasterBulkLoad(int pOrgId, long LID, string Sheettype, DataTable objbulkdata)
        {
            long returnCode = -1;
            try
            {
                returnCode = new Users_DAL(globalContextDetails).SaveMasterBulkLoad(pOrgId, LID, Sheettype, objbulkdata);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing SaveMasterBulkLoad in Users_BL", ex);
            }



            return returnCode;
        }

        public long SaveInvLocationUserMap(Users User, List<Locations> lstLoc)
        {

            long lresult = -1;
            try
            {
                Users_DAL UsersDal = new Users_DAL(globalContextDetails);
                lresult = UsersDal.SaveInvLocationUserMap(User, lstLoc);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing SaveInvLocationUserMap in Users_BL", ex);
            }
            return lresult;
        }

      
        public long InsertPasswordPolicy(long OrgID,List<PasswordPolicy> pwdplcy)
       
        {
            long returnCode = -1;
           
            try
            {
                returnCode = new Users_DAL(globalContextDetails).SavePasswordPolicy(OrgID, pwdplcy);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing SaveMasterBulkLoad in Users_BL", ex);
            }



            return returnCode;
        }


     

        public long GetPasswordpolicy(long OrgID, out List<PasswordPolicy> lstpwdplcy)
        {
            long returnCode = -1;

            returnCode = new Users_DAL(globalContextDetails).GetPaasswordPolicy(OrgID,out lstpwdplcy);
            return returnCode;
        }

        public long Checkpreviouspassword(long LId, long OrgId, string Pwd,out int returncode)
        {
            long returnCode = -1;  
           
                returnCode = new Users_DAL(globalContextDetails).Checkpreviouspassword(LId,OrgId,Pwd,out returncode);

                return returnCode;

        }

        public long Checkprevioustransactionpassword(long LId, long OrgId, string Pwd, out int returncode)
        {
            long returnCode = -1;

            returnCode = new Users_DAL(globalContextDetails).Checkprevioustransactionpassword(LId, OrgId, Pwd, out returncode);

            return returnCode;

        }

        public long GetPasswordPolicytotalCount(long OrgId, out int returncode, out int Treturncode)
        {
            long returnCode = -1;

            returnCode = new Users_DAL(globalContextDetails).GetPasswordPolicyCount(OrgId,out returncode,out Treturncode);

            return returnCode;

        }

        public long GetPasswordValidityPeriod(long OrgId, out List<PasswordPolicy> lstpwdplcy, out List<PasswordPolicy> lstTranspwdplcy)
        {
            long returnCode = -1;
            lstpwdplcy = new List<PasswordPolicy>();
            lstTranspwdplcy = new List<PasswordPolicy>();
            returnCode = new Users_DAL(globalContextDetails).GetPasswordValidityPeriod(OrgId, out lstpwdplcy, out lstTranspwdplcy);
            return returnCode;

        }

        public long GetEmpRegName(int pOrgID, string prefixText, out List<EmployeeRegMaster> lstEmpReg)
        {

            lstEmpReg = new List<EmployeeRegMaster>();
            long returnCode = -1;
            try
            {
                Users_DAL UsersDAL = new Users_DAL(globalContextDetails);
                returnCode = UsersDAL.GetEmpRegName(pOrgID, prefixText, out lstEmpReg);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetEmpRegName in Users_BL", ex);
            }
            return returnCode;
        }
        public long GetReasonforblocking(int pOrgID, out List<MetaValue_Common> lstmeta)
        {

            lstmeta = new List<MetaValue_Common>();
            long returnCode = -1;
            try
            {
                Users_DAL UsersDAL = new Users_DAL(globalContextDetails);
                returnCode = UsersDAL.GetReasonforblocking(pOrgID,out lstmeta);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetReasonforblocking in Users_BL", ex);
            }
            return returnCode;
        }
        public long GetAutoAuthorizeUser(int pOrgID, long pRoleID, out List<Users> lstUsers)
        {
            long returnCode = -1;
            lstUsers = new List<Users>();
            try
            {
                returnCode = new Users_DAL(globalContextDetails).GetAutoAuthorizeUser(pOrgID, pRoleID, out lstUsers);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetAutoAuthorizeUser in Users_BL", ex);
            }
            return returnCode;
        }

        public long GetUserListByRole(int pOrgID, long pRoleID, out List<Users> lstUsers)
        {
            long returnCode = -1;
            lstUsers = new List<Users>();
            try
            {
                returnCode = new Users_DAL(globalContextDetails).GetUserListByRole(pOrgID, pRoleID, out lstUsers);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetUserListByRole in Users_BL", ex);
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
                returnCode = new Users_DAL(globalContextDetails).GetUserListByRoleDept(pOrgID, pdeptid, pRoleID, out lstUsers);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetUserListByRoleDept in Users_BL", ex);
            }
            return returnCode;
        }
		//kapil
		
		 public long LoadPrinterNameAndPath(int OrgID, out  List<LocationPrintMap> lstLocationPrintMap)
        {
            long returnCode = -1;
            lstLocationPrintMap = new List<LocationPrintMap>();
            try
            {
                returnCode = new Users_DAL(globalContextDetails).LoadPrinterNameAndPath(OrgID, out lstLocationPrintMap);
            }
            catch (Exception ex)
            {

                CLogger.LogError("Error while executing LoadTaxDetails in Master_BL", ex);
            }
            return returnCode;
        }
         public long GetUsersByRole(int pOrgID, out List<Users> lstUsers)
         {
             long returnCode = -1;
             lstUsers = new List<Users>();
             try
             {
                 returnCode = new Users_DAL(globalContextDetails).GetUsersByRole(pOrgID,out lstUsers);
             }
             catch (Exception ex)
             {
                 CLogger.LogError("Error while executing GetAutoAuthorizeUser in Users_BL", ex);
             }
             return returnCode;
         }

         public long GetCheckSamplePersonMobileNo(OrgUsers e, string Mode)
         {
             long lresult = -1;
             Role_DAL RoleDal = new Role_DAL(globalContextDetails);
             lresult = RoleDal.GetCheckSamplePersonMobileNo(e, Mode);
            
             return lresult;
         }
		//arun changes- credit note value insert/update/get 
         public long GetCreditNoteDetails(int OrgID, long ClientID, string CreditNoteNumber, DateTime FDate, DateTime TDate, int PageIndex,
               int PageSize, out List<CreditNotesDetails> lstCreditNoteDetail, out int PageCount)
         {
             long returnCode = -1;
             PageCount = 0;
             lstCreditNoteDetail = new List<CreditNotesDetails>();             
             try
             {
                 Users_DAL usersDAL = new Users_DAL(globalContextDetails);
                 returnCode = usersDAL.GetCreditNoteDetails(OrgID,ClientID,CreditNoteNumber,FDate,TDate,PageIndex,PageSize,out lstCreditNoteDetail,out PageCount);
             }
             catch (Exception ex)
             {
                 CLogger.LogError("Error while executing GetCreditNoteDetails in Users_BL", ex);
             }
             return returnCode;
         }
         public long SaveCreditNoteDetails(List<CreditNotesDetails> lstCreditDet, long Lid, int OrgID)
         {
             long returnCode = -1;
             Users_DAL usersDAL = new Users_DAL(globalContextDetails);

             try
             {

                 returnCode = usersDAL.SaveCreditNoteDetails(lstCreditDet, Lid, OrgID);

             }
             catch (Exception excp)
             {
                 CLogger.LogError("Error while executing SaveCreditNoteDetails in Users_BL", excp);
             }
             return returnCode;
         }
      //
    }
}
