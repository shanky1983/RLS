using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LIMSAPI.Models;
using Attune.Kernel.LIMSAPI.BL;
using Attune.Kernel.LIMSAPI.BusinessEntities;
using System.Web.Http.Description;
using Attune.KernelV2;
using Newtonsoft.Json;
using System.Drawing;
using System.IO.MemoryMappedFiles;
using System.IO;
using System.Web;


using System.Text;
namespace LIMSAPI.Controllers
{
    public class TRFController : BaseApiController
    {

        /// <summary>
        /// This API will receive the TRF file from Home Collection APP and process in Attune LIMS
        /// </summary>
    
        ///<param name="model">Stream of bytes of the Image</param>

        /// <returns>success</returns>

        [ResponseType(typeof(UploadBookingImageModel))]
        [HttpPost]
        [Route("Api/TRFFile/PostHCBookingImage")]
        public IHttpActionResult UploadCustomerImage([FromBody] UploadBookingImageModel model)
        {
            long returnCode = -1;
            long returncode = -1;
            IHttpActionResult actionResult = null;

            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            string pOrgCode = string.Empty;

            if (headers.Contains("orgcode"))
            {
                pOrgCode = headers.GetValues("orgcode").First();
            }

            List<Config> lstConfig = new List<Config>();

            byte[] byteArray = Convert.FromBase64String(model.ImageData);

            var imageDataStream = new MemoryStream (byteArray);
            imageDataStream.Position = 0;

            Image returnImage = Image.FromStream(imageDataStream);
        returncode=  new LIMSAPI_BL().GetConfigHCDetails(pOrgCode, "TRF_UploadPath",out lstConfig);
            string pathname = lstConfig[0].ConfigValue.ToString();

            //DateTime dt = new DateTime();
            //dt = Convert.ToDateTime(new DateTime());

            //int Year = dt.Year;
            //int Month = dt.Month;
            //int Day = dt.Day;
            DateTime dt = DateTime.Now;
            int Year = dt.Year;
            int Month = dt.Month;
            int Day = dt.Day;

            //Root Path =D:\ATTUNE_UPLOAD_FILES\TRF_Upload\67\2013\10\9\123456\14_A.pdf

            String Root = String.Empty;
            String RootPath = String.Empty;
            //Root = ATTUNE_UPLOAD_FILES\TRF_Upload\ + OrgID + '\' + Year + '\' + Month + '\' + Day + '/' + Visitnumber ;
            Root = "TRF_Upload-" + lstConfig[0].OrgID + "-" + Year + "-" + Month + "-" + Day + "-" +  "Home_Collection" + "-";
            Root = Root.Replace("-", "\\\\");
            RootPath = pathname + Root;




            var obj = new ImageConvertor();
            System.Drawing.Image imageIn = obj.ConvertByteArrayToImage(byteArray);
          //  String path = HttpContext.Current.Server.MapPath("~/images/Games"); //Path

            //Check if directory exist
            if (!System.IO.Directory.Exists(RootPath))
            {
                System.IO.Directory.CreateDirectory(RootPath); //Create directory if it doesn't exist
            }
            string imageName = model.BookingID + ".png";

            //set the image path
            string imgPath = Path.Combine(RootPath, imageName);

            string Type = "TRF_Upload_LISWeb_Home_Collection";



            File.WriteAllBytes(imgPath, byteArray);

            returnCode = new LIMSAPI_BL().SaveTRFHCDetails(pOrgCode, imageName, model.BookingID,model.ExternalRefNo, model.BookingID, Type, model.SourceType, RootPath);
            // (pOrgCode, FileName, BookingID, IdentifyingID, IdentifyingType, FilePath);
            //    returncode = patientBL.SaveTRFDetails(pictureName, pno, Vid, OrgID, 0, "TRF_Upload", Root, LID, dt, "Y", 0);


            //  actionResult = Ok(returnImage);

            actionResult = Ok("File Uploaded Successfully");
        
             return actionResult;
        }


     


       
    }
}
