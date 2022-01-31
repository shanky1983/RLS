using System;
using System.Collections.Generic;
using System.Text;
using Attune.Podium.BusinessEntities;
using System.Data;
using System.Data.SqlClient;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.Common;
using System.Transactions;

namespace Attune.Solution.DAL
{
    public class Nurse_DAL
    {
         ContextDetails globalContextDetails;
        public Nurse_DAL()
        {

        }
        public Nurse_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }



        public long SaveNurse(Nurse NurseDal)
        {
            long lresult = -1;
            int addressCount = NurseDal.Address.Count;
            SqlCommand[] cmdInsertAddress = new SqlCommand[addressCount];
            int NurseID = 0;
            long addressID = 0;
            int i;
            SqlCommand cmdInsertNurse = Command.pInsertNurseCommand(NurseDal.NurseName, NurseDal.OrgID, NurseDal.Email, NurseDal.CreatedBy,NurseDal.LoginID, NurseDal.WeddingDt, NurseDal.Sex, NurseDal.TitleCode, NurseDal.DOB, NurseDal.Relegion, NurseDal.MaritalStatus, NurseDal.Qualification, out NurseID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdInsertNurse.Parameters.Add("@Return", SqlDbType.Int);
            cmdInsertNurse.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            for (i = 0; i < addressCount; i++)
            {
                cmdInsertAddress[i] = Command.pInsertNurseAddressCommand(NurseID, NurseDal.Address[i].AddressType, NurseDal.Address[i].Add1, NurseDal.Address[i].Add2, NurseDal.Address[i].Add3, NurseDal.Address[i].PostalCode,
                                                    NurseDal.Address[i].CountryID, NurseDal.Address[i].City, NurseDal.Address[i].StateID, NurseDal.Address[i].MobileNumber, NurseDal.Address[i].LandLineNumber, NurseDal.Address[i].CreatedBy, NurseDal.Address[i].OtherCountryName, NurseDal.Address[i].OtherStateName, out addressID, UDT_DAL.ConvertToUDT_Context(globalContextDetails), NurseDal.Address[i].CountryCode, NurseDal.Address[i].StateCode, NurseDal.Address[i].CityCode, NurseDal.Address[i].AddLevel1, NurseDal.Address[i].AddLevel2);
            }
            using (TransactionScope tranScope = new TransactionScope())
            {
                try
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {
                        dbEngine.ExecuteTransactionalNonQuery(cmdInsertNurse);
                        lresult = Convert.ToInt64(cmdInsertNurse.Parameters["@Return"].Value);
                        if (lresult == 0)
                        {
                            NurseID = Convert.ToInt32(cmdInsertNurse.Parameters["@pNurseID"].Value);

                            NurseDal.NurseID = NurseID;
                            for (i = 0; i < addressCount; i++)
                            {
                                cmdInsertAddress[i].Parameters["@pNurseID"].Value = NurseID;
                                dbEngine.ExecuteTransactionalNonQuery(cmdInsertAddress[i]);
                            }
                        }

                    }

                    tranScope.Complete();
                }
                catch (Exception ex)
                {
                    CLogger.LogError("Error while saving Nurse. Query: " + cmdInsertNurse.CommandText, ex);
                    tranScope.Dispose();
                }
            }
            return lresult;
        }


        public long SaveNurseSpeciality(NurseSpeciality NurseSpeciality)
        {
            long lresult = -1;
            SqlCommand cmd = Command.pInsertNurseSpecialityCommand(NurseSpeciality.NurseID, NurseSpeciality.SpecialityID, NurseSpeciality.CreatedBy, NurseSpeciality.ModifiedBy, NurseSpeciality.NurseSpecialityID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    lresult = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveNurseSpeciality" + cmd.CommandText, ex);
            }

            return lresult;
        }

        public long GetActions(long roleID, int searchTypeID, out List<ActionMaster> lstActionMaster)
        {
            long returnCode = -1;
            lstActionMaster = new List<ActionMaster>();
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = Command.pGetActionsCommand(roleID, searchTypeID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstActionMaster);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetActions", ex);
            }

            return returnCode;
        }
        public long GetActions(long roleID, out List<ActionMaster> lstActionMaster)
        {
            long returnCode = -1;
            lstActionMaster = new List<ActionMaster>();
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = Command.pGetActionsforIPOPCommand(roleID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstActionMaster);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetActions", ex);
            }

            return returnCode;
        }

        public long GetActionsIsTrusterdOrg(long roleID, int searchTypeID, out List<ActionMaster> lstActionMaster)
        {
            long returnCode = -1;
            lstActionMaster = new List<ActionMaster>();
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = Command.pGetActionsIsTrusterdOrgCommand(roleID, searchTypeID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstActionMaster);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetActionsIsTrusterdOrg", ex);
            }

            return returnCode;
        }
    }
}
