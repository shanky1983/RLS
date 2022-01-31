using Attune.Kernel.LIMSAPI.BL;
using Attune.Kernel.LIMSAPI.BusinessEntities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Description;
using Microsoft.Azure;// Namespace for Azure Configuration Manager //Namespace for CloudConfigurationManager
using Microsoft.WindowsAzure.Storage;// Namespace for Storage Client Library 
using Microsoft.WindowsAzure.Storage.File;// Namespace for Azure Files

namespace LIMSAPI.Controllers
{
    public class ReportsController : ApiController
    {
        /// <summary>
        /// This API validate the User Name and password return respective Login Details along with roles assigned to the particular Login
        /// </summary>
        /// <param name="OrgCode">Orgcode</param>
        /// <param name="LoginName">LoginName of the User</param>
        /// <param name="Type">Type of report</param>
        /// <param name="Password">Password combination of the User</param>
        ///  <param name="ReferenceNumber">ReferenceNumber of the User</param>
        /// <returns></returns>
        [ResponseType(typeof(PatientResultPDF))]
        [HttpGet]
        [Route("Api/Report/GetPDF")]
        public HttpResponseMessage GetPatientLoginPDFfileInfo(string OrgCode, string Type, string LoginName, string Password, string ReferenceNumber)
        {
            long returnCode = -1;
            //System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            //string pOrgCode = string.Empty;

            //if (headers.Contains("orgcode"))
            //{
            //    pOrgCode = headers.GetValues("orgcode").First();
            //}
            Login LoginInfo = new Login();
            List<LoginOrgRoles> lstRoleInfo = new List<LoginOrgRoles>();
            LoginUserAccessDetail lst = new LoginUserAccessDetail();

            var result = new HttpResponseMessage(HttpStatusCode.OK);

            List<PatientResultPDF> lstfileInfo = new List<PatientResultPDF>();
            //    string EncryptedString = string.Empty;
            //Attune.Cryptography.CCryptography obj = new Attune.Cryptography.CCryptFactory().GetEncryptor();
            //obj.Crypt(Password, out EncryptedString);
            //Password = EncryptedString;

            //string DecryptedString = string.Empty;
            //Attune.Cryptography.CCryptography objDecryptor = new Attune.Cryptography.CCryptFactory().GetDecryptor();
            //objDecryptor.Crypt(VisitNumber, out DecryptedString);
            //    VisitNumber = DecryptedString;

            try
            {
                returnCode = new LIMSAPI_BL().GetPatientLoginPDFfile(OrgCode, Type, LoginName, Password, ReferenceNumber, out lstfileInfo);



                if (string.IsNullOrEmpty(ReferenceNumber))
                {
                    ReferenceNumber = string.Empty;
                }



                string PathwithfileName = string.Empty;
                if (returnCode != -1)
                {
                    if (lstfileInfo.Count > 0 && lstfileInfo != null)
                    {
               //       string FilePathName = "\\lissistoragefordbbackup.file.core.windows.net\\liskernel - pdf\\PDF\\REPORT\\202\\2021 / 01 / 11\\Report - 2100518_VIRAT_11 - Jan - 2021_333 PM.pdf";
                        string connstr = AzureConnection();
                        CloudStorageAccount storageAccount = CloudAccount(connstr);
                        string sharepath = storageAccount.FileStorageUri.PrimaryUri.Host;
                        if (File.Exists(lstfileInfo[0].FilePathName))
                        {
                         // if (File.Exists(FilePathName))
                         //   {
                              string filename = System.IO.Path.GetFileName(lstfileInfo[0].FilePathName);
                         //   string filename = FilePathName;
                            byte[] filepathByte = File.ReadAllBytes(lstfileInfo[0].FilePathName);
                        //  byte[] filepathByte = File.ReadAllBytes(FilePathName);
                            MemoryStream memoryStream = new MemoryStream(filepathByte);
                            result.Content = new StreamContent(memoryStream);
                            result.Content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("attachment");
                            result.Content.Headers.ContentDisposition.FileName = filename;
                            result.Content.Headers.ContentType = new MediaTypeHeaderValue("application/pdf");
                            // objPrimaReport.FileBlob = Convert.ToBase64String(filebyte);
                        }
                        else if (lstfileInfo[0].FilePathName.Contains(sharepath))
                        {

                            string filestring = azurefilebytes(lstfileInfo[0].FilePathName);
                            if (!String.IsNullOrEmpty(filestring))
                            {
                                // Restore the byte array.
                                byte[] filepathByte = Convert.FromBase64String(filestring);
                               
                               string filename = System.IO.Path.GetFileName(lstfileInfo[0].FilePathName);
                               
                                // objPrimaReport.FileBlob = filestring;
                                MemoryStream memoryStream = new MemoryStream(filepathByte);
                                result.Content = new StreamContent(memoryStream);
                                result.Content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("attachment");
                                result.Content.Headers.ContentDisposition.FileName = filename;
                                result.Content.Headers.ContentType = new MediaTypeHeaderValue("application/pdf");

                            }
                        }
                    }
                    else
                    {
                        result = new HttpResponseMessage(HttpStatusCode.NotFound);
                    }
                }
                else
                {
                    result = new HttpResponseMessage(HttpStatusCode.NotFound);
                }


            }
            catch (Exception ex)
            {
                result = new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }

            return result;



        }
        // GET: api/Reports

        public string AzureConnection()
        {
            string connstr = Microsoft.Azure.CloudConfigurationManager.GetSetting("StorageConnectionString");

            string[] constrarr = connstr.Split(';');
            string accountName = (constrarr[constrarr.Length - 2]);
            string accounKey = constrarr[constrarr.Length - 1];
            string[] aNbyte = accountName.Split('=');
            string[] aKbyte = accounKey.Split('=');
            string aN = aNbyte[aNbyte.Length - 1];
            string aK = aKbyte[aKbyte.Length - 1];

            Attune.Cryptography.CCryptography obj = new Attune.Cryptography.CCryptFactory().GetDecryptor();
            obj.Crypt(aN, out aN);
            obj.Crypt(aK, out aK);
            constrarr[constrarr.Length - 2] = aNbyte[aNbyte.Length - 2] + "=" + aN;
            constrarr[constrarr.Length - 1] = aKbyte[aKbyte.Length - 2] + "=" + aK;
            connstr = constrarr[constrarr.Length - 3] + ";" + aNbyte[aNbyte.Length - 2] + "=" + aN + ";" + aKbyte[aKbyte.Length - 2] + "=" + aK;
            return connstr;
        }
        public CloudStorageAccount CloudAccount(string constr)
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(constr);
            return storageAccount;
        }
        public string azurefilebytes(string path)
        {
            string basesixityfourstring = String.Empty;
            try
            {
                if (!String.IsNullOrEmpty(path))
                {
                    //string path = "\\lissistoragefordbbackup.file.core.windows.net\\liskernel-pdf\\PDF\\REPORT\\220\\2019/05/04\\Report-19PY17842_PADMA_MURALIDHARA_03May2019_193552.pdf";
                    string[] strarr = path.Split('\\');
                    string[] removeemptyarr = strarr.Where(j => !String.IsNullOrEmpty(j)).ToArray();
                    string shareReference = removeemptyarr[1].ToString();
                    string directoryReference = (removeemptyarr[2] + "\\" + removeemptyarr[3] + "\\" + removeemptyarr[4] + "\\" + removeemptyarr[5]).ToString();
                    string filename = System.IO.Path.GetFileName(path);

                    //CloudStorageAccount storageAccount = CloudStorageAccount.Parse(Microsoft.Azure.CloudConfigurationManager.GetSetting("StorageConnectionString"));
                    // Parse the connection string and return a reference to the storage account. 
                    string connstr = AzureConnection();
                    CloudStorageAccount storageAccount = CloudAccount(connstr);
                    // Create a CloudFileClient object for credentialed access to Azure Files.
                    CloudFileClient fileClient = storageAccount.CreateCloudFileClient();

                    // Get a reference to the file share we created previously.
                    //CloudFileShare share = fileClient.GetShareReference("liskernel-pdf");
                    CloudFileShare share = fileClient.GetShareReference(shareReference);

                    // Ensure that the share exists.
                    if (share.Exists())
                    {
                        // Get a reference to the root directory for the share.
                        CloudFileDirectory rootDir = share.GetRootDirectoryReference();

                        // Get a reference to the directory we created previously.
                        //CloudFileDirectory sampleDir = rootDir.GetDirectoryReference("PDF\\REPORT\\220\\2019/05/04");
                        CloudFileDirectory sampleDir = rootDir.GetDirectoryReference(directoryReference);

                        // Ensure that the directory exists.
                        if (sampleDir.Exists())
                        {
                            // Get a reference to the file we created previously.
                            //CloudFile file = sampleDir.GetFileReference("Report-19PY17842_PADMA_MURALIDHARA_03May2019_193552.pdf");
                            CloudFile file = sampleDir.GetFileReference(filename);

                            // Ensure that the file exists.
                            using (var ms = new MemoryStream())
                            {
                                if (file.Exists())
                                {
                                    // Download the stream of the file from cloud storage.
                                    file.DownloadToStream(ms);
                                    byte[] arry = ms.ToArray();
                                    basesixityfourstring = Convert.ToBase64String(arry);

                                    // Download the contents of the file to the local dive.

                                    //string drivepath = "D:\\Attune\\" + filename;
                                    //file.DownloadToFile(drivepath, System.IO.FileMode.OpenOrCreate);
                                    //byte[] localfilebyte = File.ReadAllBytes(drivepath);
                                    //basesixityfourstring = Convert.ToBase64String(localfilebyte).ToString();
                                }
                            }
                        }
                        /////************ Start Copy to Blob storage and Download the stream of the blob *********//
                        //string containerName = "test-container";
                        //CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
                        //CloudBlobContainer container = blobClient.GetContainerReference(containerName.ToLower());
                        //container.CreateIfNotExists();
                        //string fileSas = file.GetSharedAccessSignature(new SharedAccessFilePolicy()
                        //{
                        //    // Only read permissions are required for the source file.
                        //    Permissions = SharedAccessFilePermissions.Read,
                        //    SharedAccessExpiryTime = DateTime.UtcNow.AddHours(24)
                        //});
                        //Uri fileSasUri = new Uri(file.StorageUri.PrimaryUri.ToString() + fileSas);

                        //CloudBlockBlob blockBlob = container.GetBlockBlobReference(filename);

                        //blockBlob.StartCopy(fileSasUri);
                        //using (var blobms = new MemoryStream())
                        //{
                        //    if (blockBlob.Exists())
                        //    {
                        //        blockBlob.DownloadToStream(blobms);
                        //        byte[] blobbyte = blobms.ToArray();
                        //        string bytarr = Convert.ToBase64String(blobbyte);
                        //        blockBlob.DeleteIfExistsAsync();
                        //    }
                        //}
                        /////************ END Copy to Blob storage and Download the stream of the blob *********//
                    }
                }
            }

            catch
            {

            }
            return basesixityfourstring;
        }

        [ResponseType(typeof(PatientResultPDF))]
        [HttpGet]
        [Route("Api/Report/GetPDFAWS")]
        public HttpResponseMessage GetPatientLoginPDFAWSfileInfo(string OrgCode, string Type, string LoginName, string Password, string ReferenceNumber)
        {
            long returnCode = -1;
            //System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            //string pOrgCode = string.Empty;

            //if (headers.Contains("orgcode"))
            //{
            //    pOrgCode = headers.GetValues("orgcode").First();
            //}
            Login LoginInfo = new Login();
            List<LoginOrgRoles> lstRoleInfo = new List<LoginOrgRoles>();
            LoginUserAccessDetail lst = new LoginUserAccessDetail();

            var result = new HttpResponseMessage(HttpStatusCode.OK);

            List<PatientResultPDF> lstfileInfo = new List<PatientResultPDF>();
            //    string EncryptedString = string.Empty;
            //Attune.Cryptography.CCryptography obj = new Attune.Cryptography.CCryptFactory().GetEncryptor();
            //obj.Crypt(Password, out EncryptedString);
            //Password = EncryptedString;

            //string DecryptedString = string.Empty;
            //Attune.Cryptography.CCryptography objDecryptor = new Attune.Cryptography.CCryptFactory().GetDecryptor();
            //objDecryptor.Crypt(VisitNumber, out DecryptedString);
            //    VisitNumber = DecryptedString;

            try
            {
                returnCode = new LIMSAPI_BL().GetPatientLoginPDFAWSfileInfo(OrgCode, Type, LoginName, Password, ReferenceNumber, out lstfileInfo);



                if (string.IsNullOrEmpty(ReferenceNumber))
                {
                    ReferenceNumber = string.Empty;
                }



                string PathwithfileName = string.Empty;
                if (returnCode != -1)
                {
                    if (lstfileInfo.Count > 0 && lstfileInfo != null)
                    {
                        
                    
                            string filename = System.IO.Path.GetFileName(lstfileInfo[0].FilePathName);
                            //   string filename = FilePathName;
                            byte[] filepathByte = File.ReadAllBytes(lstfileInfo[0].FilePathName);
                            //  byte[] filepathByte = File.ReadAllBytes(FilePathName);
                            MemoryStream memoryStream = new MemoryStream(filepathByte);
                            result.Content = new StreamContent(memoryStream);
                            result.Content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("attachment");
                            result.Content.Headers.ContentDisposition.FileName = filename;
                            result.Content.Headers.ContentType = new MediaTypeHeaderValue("application/pdf");
                     
                    }
                    else
                    {
                        result = new HttpResponseMessage(HttpStatusCode.NotFound);
                    }
                }
                else
                {
                    result = new HttpResponseMessage(HttpStatusCode.NotFound);
                }


            }
            catch (Exception ex)
            {
                result = new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }

            return result;



        }
        /// <summary>
        /// This API validate the User Name and password return respective Login Details along with roles assigned to the particular Login
        /// </summary>
        /// <param name="OrgCode">Orgcode</param>
        /// <param name="LoginName">LoginName of the User</param>
        /// <param name="Type">Type of report</param>
        /// <param name="Password">Password combination of the User</param>
        ///  <param name="ReferenceNumber">ReferenceNumber of the User</param>
        /// <returns></returns>
        [ResponseType(typeof(PatientResultPDF))]
        [HttpGet]
        [Route("Api/Report/GetPDFOrgAWS")]
        public HttpResponseMessage GetPatientLoginPDFOrgAWSfileInfo(string OrgCode, string Type, string ReferenceNumber)
        {
            long returnCode = -1;
            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            string pOrgCode = string.Empty;

            if (headers.Contains("orgcode"))
            {
                pOrgCode = headers.GetValues("orgcode").First();
            }
            Login LoginInfo = new Login();
            List<LoginOrgRoles> lstRoleInfo = new List<LoginOrgRoles>();
            LoginUserAccessDetail lst = new LoginUserAccessDetail();

            var result = new HttpResponseMessage(HttpStatusCode.OK);

            List<PatientResultPDF> lstfileInfo = new List<PatientResultPDF>();
            //    string EncryptedString = string.Empty;
            //Attune.Cryptography.CCryptography obj = new Attune.Cryptography.CCryptFactory().GetEncryptor();
            //obj.Crypt(Password, out EncryptedString);
            //Password = EncryptedString;

            //string DecryptedString = string.Empty;
            //Attune.Cryptography.CCryptography objDecryptor = new Attune.Cryptography.CCryptFactory().GetDecryptor();
            //objDecryptor.Crypt(VisitNumber, out DecryptedString);
            //    VisitNumber = DecryptedString;

            if (string.IsNullOrEmpty(ReferenceNumber))
            {
                ReferenceNumber = string.Empty;
            }

            try
            {
                returnCode = new LIMSAPI_BL().GetPatientLoginPDFOrgAWSfileInfo(pOrgCode,Type, ReferenceNumber, out lstfileInfo);



            


                string PathwithfileName = string.Empty;
                if (returnCode != -1)
                {
                    if (lstfileInfo.Count > 0 && lstfileInfo != null)
                    {


                        string filename = System.IO.Path.GetFileName(lstfileInfo[0].FilePathName);
                        //   string filename = FilePathName;
                        byte[] filepathByte = File.ReadAllBytes(lstfileInfo[0].FilePathName);
                        //  byte[] filepathByte = File.ReadAllBytes(FilePathName);
                        MemoryStream memoryStream = new MemoryStream(filepathByte);
                        result.Content = new StreamContent(memoryStream);
                        result.Content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("attachment");
                        result.Content.Headers.ContentDisposition.FileName = filename;
                        result.Content.Headers.ContentType = new MediaTypeHeaderValue("application/pdf");

                    }
                    else
                    {
                        result = new HttpResponseMessage(HttpStatusCode.NotFound);
                    }
                }
                else
                {
                    result = new HttpResponseMessage(HttpStatusCode.NotFound);
                }


            }
            catch (Exception ex)
            {
                result = new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }

            return result;



        }
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Reports/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Reports
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Reports/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Reports/5
        public void Delete(int id)
        {
        }
    }
}
