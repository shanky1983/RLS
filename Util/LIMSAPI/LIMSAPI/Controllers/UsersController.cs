using System;
using System.Linq;
using System.Collections.Generic;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using Attune.KernelV2;
using Attune.Kernel.LIMSAPI.BL;
using Attune.Kernel.LIMSAPI.BusinessEntities;


namespace LIMSAPI.Controllers
{
    public class UsersController : BaseApiController
    {
        /// <summary>
        /// This API will provide the list of Users 
        /// </summary>
        /// <param name="pRoleName">pRoleName will return Pathologist roles</param>
        /// <param name="pPathworksUrl">pPathworksUrl will return PathWorksUrl</param>
        /// <returns></returns>

        [ResponseType(typeof(UsersInfo))]
        [HttpGet]
        [Route("Api/Users/InsertUsers")]
        public IHttpActionResult InsertUsers(string pRoleName, string pPathworksUrl)
        {
            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            string pOrgCode = string.Empty;
            
            string url = HttpContext.Current.Request.Url.AbsoluteUri;
            int pos = url.IndexOf("Api/Users/InsertUsers?pRoleName=");
            url = url.Remove(pos);

            if (string.IsNullOrEmpty(pRoleName))
                pRoleName = "Pathologist";

            if (headers.Contains("orgcode"))
                pOrgCode = headers.GetValues("orgcode").First();

            if (string.IsNullOrEmpty(pOrgCode))
                pOrgCode = "LIMSAPI";


            long returnCode = -1;
            IHttpActionResult actionResult = null;
            List<UsersListInfo> UserInfo = new List<UsersListInfo>();

            List<UsersInfo> lstUserInfo = null;
            UsersInfo objUsersList = null;

            try
            {
                returnCode = new LIMSAPI_BL().GetUsers(pPathworksUrl, pOrgCode, pRoleName, out UserInfo);

                if (returnCode != -1)
                {
                    if (UserInfo.Count > 0 && UserInfo != null)
                    {
                        lstUserInfo = new List<UsersInfo>();

                        #region Userinfo for loop iteration
                        for (int i = 0; i < UserInfo.Count(); i++)
                        {
                            #region UserInof foreach user
                            // UserInof foreach user
                            foreach (UsersListInfo item in UserInfo)
                            {
                                objUsersList = new UsersInfo();

                                #region  If User ID is eqal to each User
                                //If User ID is eqal to each User
                                if (UserInfo[i].UserID == item.UserID)
                                {
                                    objUsersList.OrgID = item.OrgID;
                                    objUsersList.UserID = item.UserID;
                                    objUsersList.Name = item.Name;
                                    objUsersList.LoginID = item.LoginID;
                                    objUsersList.LoginName = item.LoginName;
                                    objUsersList.Password = item.LoginPwd;
                                    objUsersList.ServerName = item.ServerName;
                                    objUsersList.CreatedAt = DateTime.MaxValue;
                                    objUsersList.ModifiedAt = DateTime.MaxValue;
                                    objUsersList.URL = item.URL;

                                    if (item.MobileNumber != null)
                                    {
                                        objUsersList.MobileNumber = item.MobileNumber;
                                    }
                                    else
                                    {
                                        objUsersList.MobileNumber = "";
                                    }

                                    lstUserInfo.Add(objUsersList);
                                }
                                //If User ID is eqal to each User
                                #endregion userid is equal to eachuser
                            }
                            //If User ID is eqal to each User
                            #endregion userid is equal to eachuser
                        }
                        #endregion User Info Loop Iteration

                        long returnValue = -1;
                        if (lstUserInfo.Count > 0)
                        {
                            returnValue = new LIMSAPI_BL().InsertUsersList(lstUserInfo);
                        }

                        if (returnValue != -1)
                        {
                            actionResult = Ok("Successfully Inserted.");
                        }
                        else
                        {
                            actionResult = Ok("Error occured while inserting.");
                        }
                    }
                    else
                    {
                        actionResult = Ok("No Data");
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
