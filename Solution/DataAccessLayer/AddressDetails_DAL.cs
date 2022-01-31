using System;
using System.Data;
using System.Data.SqlClient;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.BusinessEntities;
using System.Configuration;
using System.Web;


namespace Attune.Solution.DAL
{
    public class AddressDetails_DAL
    {
        
        ContextDetails globalContextDetails;
        public AddressDetails_DAL()
        {

        }
        public AddressDetails_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
    

        /* Created By : N.Sangeetha
           Created At : 12/08/2008 */

        

        public SqlCommand GetInsertAddressCmd(PatientAddress address)
        {

            SqlCommand sqlAdInsertCommand = new SqlCommand();
            sqlAdInsertCommand.CommandType = CommandType.StoredProcedure;
            sqlAdInsertCommand.CommandText = "pInsertPatientAddress";
            sqlAdInsertCommand.Parameters.Add("@pAddrType", SqlDbType.Char);
            sqlAdInsertCommand.Parameters.Add("@pAddr1", SqlDbType.VarChar);
            sqlAdInsertCommand.Parameters.Add("@pAddr2", SqlDbType.VarChar);
            sqlAdInsertCommand.Parameters.Add("@pAddr3", SqlDbType.VarChar);
            sqlAdInsertCommand.Parameters.Add("@pPostalCode", SqlDbType.Char);
            sqlAdInsertCommand.Parameters.Add("@pCountryID", SqlDbType.SmallInt);
            sqlAdInsertCommand.Parameters.Add("@pCity", SqlDbType.VarChar);
            sqlAdInsertCommand.Parameters.Add("@pStateID", SqlDbType.SmallInt);
            sqlAdInsertCommand.Parameters.Add("@pMobileNumber", SqlDbType.VarChar);
            sqlAdInsertCommand.Parameters.Add("@pLandLineNumber", SqlDbType.VarChar);
            sqlAdInsertCommand.Parameters.Add("@pComments", SqlDbType.VarChar);
            sqlAdInsertCommand.Parameters.Add("@pCreatedBy", SqlDbType.BigInt);
            sqlAdInsertCommand.Parameters.Add("@pModifiedBy", SqlDbType.BigInt);

            sqlAdInsertCommand.Parameters["@pAddrType"].Value = (address.AddressType != null) ? address.AddressType : Convert.DBNull;
            sqlAdInsertCommand.Parameters["@pAddr1"].Value = (address.Add1 != null && address.Add1 != "") ? address.Add1 : Convert.DBNull;
            sqlAdInsertCommand.Parameters["@pAddr2"].Value = (address.Add2 != null && address.Add2 != "") ? address.Add2 : Convert.DBNull;
            sqlAdInsertCommand.Parameters["@pAddr3"].Value = (address.Add3 != null && address.Add3 != "") ? address.Add3 : Convert.DBNull;
            sqlAdInsertCommand.Parameters["@pPostalCode"].Value = (address.PostalCode != null && address.PostalCode != "") ? address.PostalCode : Convert.DBNull;
            sqlAdInsertCommand.Parameters["@pCountryID"].Value = (address.CountryID != 0) ? address.CountryID : Convert.DBNull;
            sqlAdInsertCommand.Parameters["@pCity"].Value = (address.City != null && address.City != "") ? address.City : Convert.DBNull;
            sqlAdInsertCommand.Parameters["@pStateID"].Value = (address.StateID != 0) ? address.StateID : Convert.DBNull;
            sqlAdInsertCommand.Parameters["@pCreatedBy"].Value = (address.CreatedBy != null) ? address.CreatedBy : Convert.DBNull;
            sqlAdInsertCommand.Parameters["@pModifiedBy"].Value = address.ModifiedBy;
            return sqlAdInsertCommand;

        }


        public long SaveAddress(PatientAddress address)
        {
            long lResult = -1;
            SqlCommand cmdInsertAddress = new SqlCommand();
            cmdInsertAddress = GetInsertAddressCmd(address);
            Attune.Podium.DataAccessEngine.DBEngine objDB = new DBEngine();


            return lResult;
        }


    }
}

