using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.Common;
using Attune.Podium.BusinessEntities;
using Attune.Solution.DAL;
using Attune.Podium.BusinessEntities.CustomEntities;


namespace Attune.Podium.DataAccessLayer
{
    public class FileUpload_DAL
    {

        ContextDetails globalContextDetails;
        public FileUpload_DAL()
        {

        }
        public FileUpload_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long SaveFileToDatabase(string URL, string FileType, out long FileID)
        {
            FileID = 0;
            long returnCode = -1;
            SqlCommand cmd = Command.pUploadFileCommand(URL, FileType, out returnCode, out FileID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine db = new DBEngine())
            {
                db.ExecuteTransactionalNonQuery(cmd);
                FileID = Convert.ToInt64(cmd.Parameters["@pFileID"].Value);
                returnCode = Convert.ToInt64(cmd.Parameters["@returnStatus"].Value);
            }

            return returnCode;
        }
        public long GetFile(long fileID, out Blob blob)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pGetPatientOldNotesFileDtlsCommand(fileID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            blob = new Blob();
            List<Blob> lstBlob = new List<Blob>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }

            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBlob);
                if (returnCode == 0)
                {
                    blob = lstBlob[0];
                }
                else
                {
                    blob = null;
                }
            }

            return returnCode;
        }
        public long SavePatientDetails(DataTable objStockReceived)
        {


            long returnCode = -1;
            SqlCommand cmd = Command.pInsertBulkPatientRegistrationCommand(objStockReceived, UDT_DAL.ConvertToUDT_Context(globalContextDetails), out returnCode);
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteTransactionalNonQuery(cmd);
                returnCode = Convert.ToInt64(cmd.Parameters["@returnStatus"].Value);
            }

            return returnCode;

        }

        /*BEGIN | 128 | Thiyagu | 20163103 | A | Bulk Registration for camps*/
        public long SavePatientDetails(List<CampDetails> lstCampDetails, out List<CampDetails> lstresult)
        {
            long returnCode = -1;
            DataTable objStockReceived;

            IDataReader dataReader = null;
            lstresult = new List<CampDetails>();
            //SqlCommand cmd = Command.pUploadFileCommand(URL, FileType, out returnCode, out FileID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            objStockReceived = UDT_DAL.ConvertToUDT_TT_UDTCampDetail(lstCampDetails);
            SqlCommand cmd = Command.pInsertBulkPatientRegistrationCommand(objStockReceived, UDT_DAL.ConvertToUDT_Context(globalContextDetails), out returnCode);
            using (DBEngine dbEngine = new DBEngine())
            {
                dataReader = dbEngine.ExecuteReader(cmd);
                if (dataReader != null)
                {
                    Utilities.ConvertTo(dataReader, out lstresult);
                    dataReader.Close();
                }


                //dbEngine.ExecuteTransactionalNonQuery(cmd);
                returnCode = Convert.ToInt64(cmd.Parameters["@returnStatus"].Value);
            }
            return returnCode;
        }
        public long ValidateBulkRegistrationDetails(List<CampDetails> BulkReg, out List<CampDetails> lstCamp, out List<TestDetails> lstTestDetails)
        {
            lstCamp = new List<CampDetails>();
            lstTestDetails = new List<TestDetails>();
            long returncode = -1;
            int rsCount = 0;
            IDataReader dataReader = null;
            DataTable dtBulkReg = UDT_DAL.ConvertToUDT_TT_UDTCampDetail(BulkReg);
            SqlCommand cmd = Command.pValidateBulkRegistrationDetailsCommand(dtBulkReg, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine())
            {
                dataReader = dbEngine.ExecuteReader(cmd);
                if (dataReader != null)
                {
                    do
                    {
                        if (rsCount == 0)
                        {
                            returncode = Utilities.ConvertTo(dataReader, out lstCamp);
                        }
                        else if (rsCount == 1)
                        {
                            returncode = Utilities.ConvertTo(dataReader, out lstTestDetails);
                        }
                        rsCount = rsCount + 1;
                    } while (dataReader.NextResult());
                    dataReader.Close();

                }
            }
            return returncode;

        }
		public long ValidateCovidBulkRegistrationDetails(List<CampDetails> BulkReg, out List<CampDetails> lstCamp, out List<TestDetails> lstTestDetails)
        {
            lstCamp = new List<CampDetails>();
            lstTestDetails = new List<TestDetails>();
            long returncode = -1;
            int rsCount = 0;
            IDataReader dataReader = null;
            DataTable dtBulkReg = UDT_DAL.ConvertToUDT_TT_UDTCampDetail(BulkReg);
            SqlCommand cmd = Command.pValidateCovidBulkRegistrationDetailsCommand(dtBulkReg, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine())
            {
                dataReader = dbEngine.ExecuteReader(cmd);
                if (dataReader != null)
                {
                    do
                    {
                        if (rsCount == 0)
                        {
                            returncode = Utilities.ConvertTo(dataReader, out lstCamp);
                        }
                        else if (rsCount == 1)
                        {
                            returncode = Utilities.ConvertTo(dataReader, out lstTestDetails);
                        }
                        rsCount = rsCount + 1;
                    } while (dataReader.NextResult());
                    dataReader.Close();

                }
            }
            return returncode;

        }
		public long SaveCovidPatientDetails(List<CampDetails> lstCampDetails, out List<CampDetails> lstresult)
        {
            long returnCode = -1;
            DataTable objStockReceived;

            IDataReader dataReader = null;
            lstresult = new List<CampDetails>();
            //SqlCommand cmd = Command.pUploadFileCommand(URL, FileType, out returnCode, out FileID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            objStockReceived = UDT_DAL.ConvertToUDT_TT_UDTCampDetail(lstCampDetails);
            SqlCommand cmd = Command.pInsertCovidBulkPatientRegistrationCommand(objStockReceived, UDT_DAL.ConvertToUDT_Context(globalContextDetails), out returnCode);
            using (DBEngine dbEngine = new DBEngine())
            {
                dataReader = dbEngine.ExecuteReader(cmd);
                if (dataReader != null)
                {
                    Utilities.ConvertTo(dataReader, out lstresult);
                    dataReader.Close();
                }


                //dbEngine.ExecuteTransactionalNonQuery(cmd);
                returnCode = Convert.ToInt64(cmd.Parameters["@returnStatus"].Value);
            }
            return returnCode;
        }
    }
}
