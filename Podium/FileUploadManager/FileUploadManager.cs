using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using Attune.Podium.Common;
using Attune.Podium.BusinessEntities;
using Attune.Podium.DataAccessLayer;
using Attune.Podium.BusinessEntities.CustomEntities;
using System.Windows.Forms;

namespace Attune.Podium.FileUpload
{
    public class FileUploadManager 
    {
        ContextDetails globalContextDetails;
        public FileUploadManager()
        {

        }
        public FileUploadManager(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        //public static string GetFilenameWithURL(string URL, string Filename)
        //{
        //    string UNCPath = string.Empty;
        //    UNCPath= URL + System.DateTime.Now.ToLongDateString() + Filename;
        //    return UNCPath;
        //}
        public   string GetFilename(string Filename)
        {
            string fileName = string.Empty;
            try
            {
                fileName =  System.DateTime.Now.ToString("dd MMM yyyy") + Filename;
                
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While GetFilename Function in FileUploadManager", ex);
            }
            return fileName;
        }
        public    long WriteToDisk(System.Web.HttpPostedFile File, string FilePath)
        {
            long returnCode = -1;
            try
            {
                File.SaveAs(FilePath);
                returnCode = 0;

            }
            catch (Exception ex)
            {
                //
            }
            return returnCode;
        }
        public   void DeleteFromDisk(string url)
        {
            System.IO.File.Delete(url);
        }
     
        public long WriteToDB(string url, string FileType)
        {
            long FileID = -1;

            try
            {
                new FileUpload_DAL(globalContextDetails).SaveFileToDatabase(url, FileType, out FileID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while save File in Database", ex);
                //return FileID = -1;
            }
            return FileID;
        }
        public   long GetFile(long fileID, out Blob blob)
        {
            long returnCode = -1;
            blob = new Blob();

            try
            {
                returnCode = new FileUpload_DAL(globalContextDetails).GetFile(fileID, out blob);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error reading filedetails ", ex);
                //return FileID = -1;
            }
            return returnCode;
        }
        public long SavePatientDetails(DataTable objStockReceived)
        {
            long returnCode = -1;
            try
            {
               returnCode= new FileUpload_DAL().SavePatientDetails(objStockReceived);
            }
            catch (Exception ex)
            {

                CLogger.LogError("Error reading SavePatientDetails ", ex);
            }
            return returnCode;
        }
	/*BEGIN | 128 | Thiyagu | 20163103 | M | Bulk Registration for camps*/
        public long SavePatientDetails(List<CampDetails> lstCampDetails,out List<CampDetails> lstresult)
        {
            long returnCode = -1;
            lstresult=new List<CampDetails>();
            try
            {
                returnCode = new FileUpload_DAL(globalContextDetails).SavePatientDetails(lstCampDetails,out lstresult);
            }
            catch (Exception ex)
            {

                CLogger.LogError("Error reading SavePatientDetails ", ex);
            }
            return returnCode;
        }
		/*END | 128 | Thiyagu | 20163103 | M | Bulk Registration for camps*/
		/*BEGIN | 128 | Thiyagu | 20163103 | A | Bulk Registration for camps*/
        public long ValidateBulkRegistrationDetails(List<CampDetails> BulkReg, out List<CampDetails> lstCamp)
        {
            long returnCode = -1;
            lstCamp = new List<CampDetails>();
            List<TestDetails> lstTestDetails = new List<TestDetails>();
          
            try
            {
                returnCode = new FileUpload_DAL(globalContextDetails).ValidateBulkRegistrationDetails(BulkReg, out lstCamp, out lstTestDetails);
                if (lstTestDetails.Count > 0)
                {
                    foreach (var campdetails in lstCamp)
                    {
                        campdetails.TestInformation = new List<TestDetails>();
                        foreach (var testdetails in lstTestDetails)
                        {
                            if (testdetails.Id == campdetails.Id)
                            {
                                campdetails.TestInformation.Add(testdetails);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error reading ValidateBulkRegistrationDetails ", ex);
            }
            return returnCode;
        }
		/*END | 128 | Thiyagu | 20163103 | A | Bulk Registration for camps*/
         
        public OpenFileDialog ofd = new OpenFileDialog();
        public DialogResult od = new DialogResult();
        public DialogResult ShowDialog()
        {
           
            //OpenFileDialog ofd = new OpenFileDialog();
            return ofd.ShowDialog();
        }
		public long SaveCovidPatientDetails(List<CampDetails> lstCampDetails, out List<CampDetails> lstresult)
        {
            long returnCode = -1;
            lstresult = new List<CampDetails>();
            try
            {
                returnCode = new FileUpload_DAL(globalContextDetails).SaveCovidPatientDetails(lstCampDetails, out lstresult);
            }
            catch (Exception ex)
            {

                CLogger.LogError("Error reading SaveCovidPatientDetails ", ex);
            }
            return returnCode;
        }
		public long ValidateCovidBulkRegistrationDetails(List<CampDetails> BulkReg, out List<CampDetails> lstCamp)
        {
            long returnCode = -1;
            lstCamp = new List<CampDetails>();
            List<TestDetails> lstTestDetails = new List<TestDetails>();

            try
            {
                returnCode = new FileUpload_DAL(globalContextDetails).ValidateCovidBulkRegistrationDetails(BulkReg, out lstCamp, out lstTestDetails);
                if (lstTestDetails.Count > 0)
                {
                    foreach (var campdetails in lstCamp)
                    {
                        campdetails.TestInformation = new List<TestDetails>();
                        foreach (var testdetails in lstTestDetails)
                        {
                            if (testdetails.Id == campdetails.Id)
                            {
                                campdetails.TestInformation.Add(testdetails);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error reading ValidateBulkRegistrationDetails ", ex);
            }
            return returnCode;
        }
    }
	
}
