using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;
using Attune.Kernel.LISAPI.BL;
using System.IO;
using System.Net.Http.Headers;
using System.Globalization;
using Attune.KernelV2.Utilities;
using Attune.Kernel.LISAPI.BusinessEntities;
using Attune.KernelV2;
using System.Web.Http.Description;


namespace MobileAppIntegrationAPI.Controllers
{
    public class LIMSOrdersController : BaseApiController
    {
        // GET: LIMSOrders
        [ResponseType(typeof(OrderStatusDetails))]
        [HttpGet]
        [Route("Api/LIMSOrders/GetTestStatusByVisitNumber")]
        /// <summary>
        /// Get This API will give the Current Status of the Investigation(Test) based on VisitNumber
        /// GET: api/Products
        /// </summary>

        public IHttpActionResult GetTestStatusByVisitNumber(int pOrgId, string pVisitNumber)
        {
            long returnCode = -1;
            IHttpActionResult actionResult = null;
            List<PatientBaseInfo> lstPatientBaseInfo = new List<PatientBaseInfo>();
            List<OrderDetailsInfo> lstOrderDetailsInfo = new List<OrderDetailsInfo>();
            OrderStatusDetails lstData = new OrderStatusDetails();
            try
            {
                returnCode = new LISAPI_BL().GetTestStatusByVisitNumber(pOrgId, pVisitNumber, out lstPatientBaseInfo, out lstOrderDetailsInfo);

                if (returnCode != -1)
                {
                    if (lstPatientBaseInfo.Count > 0 && lstPatientBaseInfo != null)
                    {
                        lstData.PatientID = lstPatientBaseInfo[0].PatientID;
                        lstData.Name = lstPatientBaseInfo[0].Name;
                        lstData.Email = lstPatientBaseInfo[0].Email;
                        lstData.TitleName = lstPatientBaseInfo[0].TitleName;
                        lstData.Age = lstPatientBaseInfo[0].Age;
                        lstData.PatientNumber = lstPatientBaseInfo[0].PatientNumber;
                        lstData.PatientType = lstPatientBaseInfo[0].PatientType;
                        lstData.ExternalPatientNumber = lstPatientBaseInfo[0].ExternalPatientNumber;
                        lstData.OrderInfo = lstOrderDetailsInfo;

                    }
                    actionResult = Ok(lstData);
                }
                else
                {
                    actionResult = Ok("Result Not Found");
                }

            }
            catch (Exception excp)
            {
                actionResult = Ok("Error Occured");
            }

            return actionResult;
        }
    }
}