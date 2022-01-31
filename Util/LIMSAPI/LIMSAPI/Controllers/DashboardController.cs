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
using System.IO;
using System.Drawing;
using System.Text;

namespace LIMSAPI.Controllers
{
    public class DashboardController : BaseApiController
    {
        /// <summary>
        /// This API validate the User Name and password return respective Login Details along with roles assigned to the particular Login
        /// </summary>
        /// <param name="OrgCode">Orgcode</param>
        /// <param name="FromDate">From Date</param>
        /// <param name="ToDate">To Date</param>
        /// <param name="Type">Type of report</param>      
        /// <returns></returns>
        [ResponseType(typeof(PatientBioCount))]
        [HttpGet]
        [Route("Api/Dashboard/GetPatientDetailsCount")]
        public IHttpActionResult GetPatientDashBoardByDateRange(DateTime FromDate, DateTime ToDate, string Type)
        {
            long returnCode = -1;
            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            string OrgCode = string.Empty;

            if (headers.Contains("orgcode"))
            {
                OrgCode = headers.GetValues("orgcode").First();
            }

            List<PatientBio> lstPatientBio = new List<PatientBio>();


            PatientBio objPatientBio = new PatientBio();
            List<PatientAge> lstPatientAge = null;
            PatientAge objAgedetails = null;
            IHttpActionResult actionResult = null;

            try
            {
                returnCode = new LIMSAPI_BL().GetPatientDashBoardByDateRange(OrgCode, FromDate, ToDate, Type, out lstPatientBio);



                if (returnCode != -1)
                {
                    if (lstPatientBio.Count > 0 && lstPatientBio != null)
                    {
                        //lstPatientAge = new List<PatientAge>();
                        foreach (PatientBio item in lstPatientBio)
                        {
                            objPatientBio.AgewiseDistribution = item.AgewiseDistribution;
                            objPatientBio.GenderwiseDistribution = item.GenderwiseDistribution;
                            objPatientBio.PlayerwiseDistribution = item.PlayerwiseDistribution;
                        }

                        actionResult = Ok(objPatientBio);
                    }
                    else
                    {
                        actionResult = Ok("Result Not Found");
                    }
                }
                else
                {
                    actionResult = Ok("While fetching the data getting an Error.");
                }
            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured");
            }

            return actionResult;



        }
        /// <summary>
        /// This API get client wise revenue
        /// </summary>
        /// <param name="OrgCode">Orgcode</param>
        /// <param name="FromDate">From Date</param>
        /// <param name="ToDate">To Date</param>        
        /// <returns></returns>
        [ResponseType(typeof(ClientRevenue))]
        [HttpGet]
        [Route("Api/Dashboard/GetClientWiseRevenue")]
        public IHttpActionResult GetClientWiseRevenue(DateTime FromDate, DateTime ToDate)
        {
            long returnCode = -1;
            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            string OrgCode = string.Empty;

            if (headers.Contains("orgcode"))
            {
                OrgCode = headers.GetValues("orgcode").First();
            }

            List<ClientRevenue> lstClientRevenue = new List<ClientRevenue>();

            ClientRevenue objClientRevenue = new ClientRevenue();

            //List<PatientAge> lstPatientAge = null;
            //PatientAge objAgedetails = null;
            IHttpActionResult actionResult = null;

            try
            {
                returnCode = new LIMSAPI_BL().GetClientWiseRevenue(OrgCode, FromDate, ToDate, out lstClientRevenue);



                if (returnCode != -1)
                {
                    if (lstClientRevenue.Count > 0 && lstClientRevenue != null)
                    {
                        foreach (ClientRevenue item in lstClientRevenue)
                        {
                            objClientRevenue.ClientRevenueDetails = item.ClientRevenueDetails;
                        }

                        actionResult = Ok(objClientRevenue);
                    }
                    else
                    {
                        actionResult = Ok("Result Not Found");
                    }
                }
                else
                {
                    actionResult = Ok("While fetching the data getting an Error.");
                }
            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured");
            }

            return actionResult;
        }



        /// <summary>
        /// This API get Test wise revenue
        /// </summary>
        /// <param name="OrgCode">Orgcode</param>
        /// <param name="FromDate">From Date</param>
        /// <param name="ToDate">To Date</param>        
        /// <returns></returns>
        [ResponseType(typeof(TestRevenue))]
        [HttpGet]
        [Route("Api/Dashboard/GetTestWiseRevenue")]
        public IHttpActionResult GetTestWiseRevenue(DateTime FromDate, DateTime ToDate)
        {
            long returnCode = -1;
            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            string OrgCode = string.Empty;

            if (headers.Contains("orgcode"))
            {
                OrgCode = headers.GetValues("orgcode").First();
            }

            List<TestRevenue> lstTestRevenue = new List<TestRevenue>();

            TestRevenue objTestRevenue = new TestRevenue();

            //List<PatientAge> lstPatientAge = null;
            //PatientAge objAgedetails = null;
            IHttpActionResult actionResult = null;

            try
            {
                returnCode = new LIMSAPI_BL().GetTestWiseRevenue(OrgCode, FromDate, ToDate, out lstTestRevenue);



                if (returnCode != -1)
                {
                    if (lstTestRevenue.Count > 0 && lstTestRevenue != null)
                    {
                        foreach (TestRevenue item in lstTestRevenue)
                        {
                            objTestRevenue.TestRevenueDetails = item.TestRevenueDetails;
                        }

                        actionResult = Ok(objTestRevenue);
                    }
                    else
                    {
                        actionResult = Ok("Result Not Found");
                    }
                }
                else
                {
                    actionResult = Ok("While fetching the data getting an Error.");
                }
            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured");
            }

            return actionResult;



        }
        /// <summary>
        /// This API get booking status for cancelled and completed count
        /// </summary>
        /// <param name="OrgCode">Orgcode</param>
        /// <param name="FromDate">From Date</param>
        /// <param name="ToDate">To Date</param>
        /// <param name="Type">Type of report</param>      
        /// <returns></returns>
        [ResponseType(typeof(BookingStatusCount))]
        [HttpGet]
        [Route("Api/Dashboard/GetBookingStatusCount")]
        public IHttpActionResult GetBookingStatusCount(DateTime FromDate, DateTime ToDate, string Type)
        {
            long returnCode = -1;
            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            string OrgCode = string.Empty;

            if (headers.Contains("orgcode"))
            {
                OrgCode = headers.GetValues("orgcode").First();
            }

            List<BookingStatusCount> lstBookingStatusCount = new List<BookingStatusCount>();


            BookingStatusCount objBookingStatusCount = new BookingStatusCount();

            IHttpActionResult actionResult = null;

            try
            {
                returnCode = new LIMSAPI_BL().GetBookingStatusCount(OrgCode, FromDate, ToDate, Type, out lstBookingStatusCount);



                if (returnCode != -1)
                {
                    if (lstBookingStatusCount.Count > 0 && lstBookingStatusCount != null)
                    {
                        //lstPatientAge = new List<PatientAge>();
                        foreach (BookingStatusCount item in lstBookingStatusCount)
                        {
                            objBookingStatusCount.BookingStatusCountDetails = item.BookingStatusCountDetails;

                        }

                        actionResult = Ok(objBookingStatusCount);
                    }
                    else
                    {
                        actionResult = Ok("Result Not Found");
                    }
                }
                else
                {
                    actionResult = Ok("While fetching the data getting an Error.");
                }
            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured");
            }

            return actionResult;



        }
    }
}

   
