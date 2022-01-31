using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Attune.Kernel.LIMSAPI.BL;
using Attune.KernelV2;
using Attune.Kernel.LIMSAPI.BusinessEntities;
using System.Web.Http.Description;

namespace LIMSAPI.Controllers
{
    public class LoginController : BaseApiController
    {
        /// <summary>
        /// This API validate the User Name and password return respective Login Details along with roles assigned to the particular Login
        /// </summary>
        /// <param name="LoginName">LoginName of the User</param>
        /// <param name="Password">Password combination of the User</param>
        /// <returns></returns>
        [ResponseType(typeof(LoginUserAccessDetail))]
        [HttpGet]
        [Route("Api/Login/LoginValidate")]
        public IHttpActionResult LoginValidate(string LoginName, string Password)
        {
            long returnCode = -1;
            Login LoginInfo = new Login();
            List<LoginOrgRoles> lstRoleInfo = new List<LoginOrgRoles>();
            LoginUserAccessDetail lst = new LoginUserAccessDetail();

            string EncryptedString = string.Empty;
            Attune.Cryptography.CCryptography obj = new Attune.Cryptography.CCryptFactory().GetEncryptor();
            obj.Crypt(Password, out EncryptedString);
            Password = EncryptedString;

            returnCode = new LIMSAPI_BL().AuthenticateUser(LoginName, Password, out LoginInfo, out lstRoleInfo);

            if (LoginInfo != null && LoginInfo.LoginID!=0  && returnCode==0)
            {
                lst.LoginInfo = LoginInfo;
                lst.RoleInfoList = lstRoleInfo;

                return Ok(lst);
            }
            else
            {
                return (IHttpActionResult)Request.CreateResponse<LoginUserAccessDetail>(HttpStatusCode.NoContent, lst);
            }
        }

        /// <summary>
        /// This API give the Role Location information against LoginID and RoleID
        /// </summary>
        /// <param name="pOrgID">OrgID of AttuneLIMS</param>
        /// <param name="pLoginID">LoginID received from LoginValidateAPI</param>
        /// <param name="pRoleID">RoleID received from LoginValidateAPI</param>
        /// <returns></returns>
        [ResponseType(typeof(LoginRoleLocation))]
        [HttpGet]
        [Route("Api/Login/GetRoleLocation")]
        public IHttpActionResult GetRoleLocation(int pOrgID, long pLoginID, long pRoleID)
        {
            long returnCode = -1;
            List<LoginLocation> lstRolelocaion = new List<LoginLocation>();
            LoginRoleLocation objLoginRole = new LoginRoleLocation();

            returnCode = new LIMSAPI_BL().GetRoleLocation(pOrgID, pLoginID, pRoleID, out lstRolelocaion);
            if (lstRolelocaion != null && returnCode == 0)
            {
                objLoginRole.RoleLocationlist = lstRolelocaion;
                return Ok(objLoginRole);
            }
            else
            {
                return (IHttpActionResult)Request.CreateResponse<LoginRoleLocation>(HttpStatusCode.NoContent, objLoginRole);
            }
        }
    }
}
