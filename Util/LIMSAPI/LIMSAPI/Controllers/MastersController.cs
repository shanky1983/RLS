using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Attune.Kernel.LIMSAPI.BL;
using Attune.Kernel.LIMSAPI.BusinessEntities;
using Attune.KernelV2;
using System.Web.Http.Description;
using LIMSAPI.Utility;
using System.IO;
using System.Web;
using Newtonsoft.Json;
using System.Globalization;
using LIMSAPI.Models;

namespace LIMSAPI.Controllers
{
    public class MastersController : BaseApiController
    {


        string TimeZone1 = string.Empty;
        #region  

        /// <summary>
        /// This API will return the Locations of particular Organization or Labs(Processing Locations,Collection Centers) based on OrgCode
        /// </summary>
        /// <param name="pCategoryCode">Default Value is OrgLocations</param>
        /// <returns></returns>

        [ResponseType(typeof(OrganizationDetails))]
        [HttpGet]
        [Route("Api/Masters/OrgLocation")]
        public IHttpActionResult GetOrganizationLocations(string pCategoryCode)
        {
            long returnCode = -1;
            IHttpActionResult actionResult = null;

            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            string pOrgCode = string.Empty;

            if (headers.Contains("orgcode"))
            {
                pOrgCode = headers.GetValues("orgcode").First();
            }

            if (string.IsNullOrEmpty(pCategoryCode))
            {
                pCategoryCode = string.Empty;
            }

            List<OrganizationInfo> lstOrgInfo = new List<OrganizationInfo>();

            List<OrganizationDetails> lstOrgdetails = new List<OrganizationDetails>();
            List<OrgLocations> lstOrglocations = null;
            OrgLocations objOrglocation = null;

            try
            {
                returnCode = new LIMSAPI_BL().GetOrglocations(pOrgCode, pCategoryCode, out lstOrgInfo);

                if (returnCode != -1)
                {
                    if (lstOrgInfo.Count > 0 && lstOrgInfo != null)
                    {
                        for (int i = 0; i < lstOrgInfo.Count(); i++)
                        {
                            lstOrglocations = new List<OrgLocations>();

                            foreach (OrganizationInfo item in lstOrgInfo)
                            {
                                objOrglocation = new OrgLocations();

                                if (lstOrgInfo[i].OrgID == item.OrgID)
                                {
                                    objOrglocation.LocationCode = item.LocationCode;
                                    objOrglocation.LocationName = item.LocationName;
                                    objOrglocation.Status = item.Status;
                                    objOrglocation.ProcessingLocation = item.ProcessingLocation;

                                    lstOrglocations.Add(objOrglocation);
                                }
                            }

                            if (!lstOrgdetails.Select(n => n.OrgID).Contains(lstOrgInfo[i].OrgID))
                            {
                                lstOrgdetails.Add(new OrganizationDetails()
                                {
                                    OrgID = lstOrgInfo[i].OrgID,
                                    Type = "Locations",
                                    ClientID = lstOrgInfo[i].ClientID,
                                    LocationInfo = lstOrglocations
                                });
                            }
                        }

                        actionResult = Ok(lstOrgdetails);
                    }
                    else
                    {
                        actionResult = Ok("Result not Found");
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
        /// This API will provide the list of Users along with Roles and Location 
        /// </summary>
        /// <param name="pRoleName">Empty RoleName will return all roles</param>
        /// <param name="Page">Parameter to handle Paging</param>
        /// <param name="Size">Parameter to specify No.Of.Records in single page</param>
        /// <returns></returns>
        [ResponseType(typeof(UserDataInfo))]
        [HttpGet]
        [Route("Api/Masters/GetUserList")]
        public IHttpActionResult GetUserList(string pRoleName, int Page, int Size)
        {
            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            string pOrgCode = string.Empty;

            if (headers.Contains("orgcode"))
            {
                pOrgCode = headers.GetValues("orgcode").First();
            }

            long returnCode = -1;
            IHttpActionResult actionResult = null;
            List<UsersListInfo> UserInfo = new List<UsersListInfo>();
            List<RoleLogin> RolInfo = new List<RoleLogin>();
            List<Paging> lstPages = new List<Paging>();
            List<RoleDeptIn> RoleDept = new List<RoleDeptIn>();
            List<RoleLocationIn> RoleLoc = new List<RoleLocationIn>();

            List<UsersList> lstUserInfo = null;
            UsersList objUsersList = null;

            List<RoleInfo> lstRoleInfo = null;
            RoleInfo objRoleList = null;

            List<DeptIn> lstDeptInfo = null;
            DeptIn objDeptList = null;

            List<LocationIn> lstLocInfo = null;
            LocationIn ObjLocList = null;

            try
            {
                returnCode = new LIMSAPI_BL().GetUserList(pOrgCode, pRoleName, Page, Size, out UserInfo, out RolInfo, out RoleDept, out RoleLoc, out lstPages);

                if (returnCode != -1)
                {
                    if (UserInfo.Count > 0 && UserInfo != null)
                    {

                        lstUserInfo = new List<UsersList>();

                        #region Userinfo for loop iteration
                        for (int i = 0; i < UserInfo.Count(); i++)
                        {
                            #region UserInof foreach user
                            // UserInof foreach user
                            foreach (UsersListInfo item in UserInfo)
                            {
                                objUsersList = new UsersList();

                                #region  If User ID is eqal to each User
                                //If User ID is eqal to each User
                                if (UserInfo[i].UserID == item.UserID)
                                {
                                    objUsersList.Gender = item.Gender;
                                    objUsersList.UserID = item.UserID;
                                    objUsersList.Name = item.Name;
                                    objUsersList.LoginID = item.LoginID;
                                    objUsersList.LoginName = item.LoginName;
                                    objUsersList.Password = item.Password;
                                    objUsersList.TitleName = item.TitleName;
                                    if (item.FirstName != null)
                                    {
                                        objUsersList.FirstName = item.FirstName;
                                    }
                                    else
                                    {
                                        objUsersList.FirstName = "";
                                    }
                                    if (item.MiddleName != null)
                                    {
                                        objUsersList.MiddleName = item.MiddleName;
                                    }
                                    else
                                    {
                                        objUsersList.MiddleName = "";
                                    }
                                    if (item.LastName != null)
                                    {
                                        objUsersList.LastName = item.LastName;
                                    }
                                    else
                                    {
                                        objUsersList.LastName = "";
                                    }
                                    objUsersList.DateofBirth = item.DateofBirth;
                                    if (item.MobileNumber != null)
                                    {
                                        objUsersList.MobileNumber = item.MobileNumber;
                                    }
                                    else
                                    {
                                        objUsersList.MobileNumber = "";
                                    }
                                    objUsersList.EmailID = item.EmailID;
                                    objUsersList.Status = item.Status;
                                    //objUsersList.City = item.City;
                                    //objUsersList.State = item.State;
                                    //objUsersList.Country = item.Country;

                                    #region Role
                                    #region Role Info Count
                                    //RoleInfo count start
                                    if (RolInfo.Count > 0 && RolInfo != null)
                                    {
                                        //  objRoleData = new RoleInfo();
                                        //  List<RoleLogin> lstRoleInfodata = new List<RoleLogin>();
                                        #region Roleinfo for loop iteration
                                        // Roleinfo for loop iteration
                                        //      for (int j = 0; j < RolInfo.Count(); j++)
                                        //    {
                                        lstRoleInfo = new List<RoleInfo>();
                                        #region UserInof foreach user
                                        // RoleInof foreach Role
                                        foreach (RoleLogin Rolitem in RolInfo)
                                        {
                                            objRoleList = new RoleInfo();
                                            #region  If Role ID is eqal to each role
                                            //If Role ID is eqal to each Role
                                            if (UserInfo[i].LoginID == Rolitem.LoginID)
                                            {
                                                objUsersList.City = Rolitem.City;
                                                objUsersList.State = Rolitem.State;
                                                objUsersList.Country = Rolitem.Country;
                                                objRoleList.RoleID = Rolitem.RoleID;
                                                objRoleList.RoleName = Rolitem.RoleName;

                                                /*** Dept ***/
                                                #region Dept



                                                #region Dept Info Count
                                                //DeptInfo count start
                                                if (RoleDept.Count > 0 && RoleDept != null)

                                                {


                                                    #region Deptinfo for loop iteration
                                                    // Deptinfo for loop iteration
                                                    for (int d = 0; d < RoleDept.Count(); d++)
                                                    {
                                                        lstDeptInfo = new List<DeptIn>();
                                                        #region DeptInof foreach Dept
                                                        // DeptInof foreach Dept
                                                        foreach (RoleDeptIn Depitem in RoleDept)
                                                        {

                                                            #region  If Dept ID is eqal to each Dept
                                                            //If Dept ID is eqal to eachDept
                                                            if (UserInfo[i].LoginID == Depitem.LoginID)
                                                            {
                                                                if (Rolitem.RoleID == Depitem.RoleID)
                                                                {
                                                                    objDeptList = new DeptIn();
                                                                    objDeptList.DeptID = Depitem.DeptID;
                                                                    objDeptList.DeptName = Depitem.DeptName;

                                                                    lstDeptInfo.Add(objDeptList);
                                                                }


                                                            } //If Dept ID is eqal to each Dept
                                                            #endregion Deptid is equal to eachDept

                                                        } // DeptInof foreach Dept

                                                        #endregion Dept In of forEach Dept





                                                    }  // Deptinfo for loop iteration

                                                    #endregion Dept Info Loop Iteration





                                                    #region Deptinfo to Deptinfo
                                                    if (lstDeptInfo.Count > 0 && lstDeptInfo != null)
                                                    {

                                                        objRoleList.DeptInfo = lstDeptInfo;
                                                    }
                                                    #endregion Deptinfo to Dept info
                                                }  //DeptInfo count end
                                                #endregion DeptInfo Count


                                                #endregion Dept
                                                /*** Dept ***/

                                                /*** Loc ***/
                                                #region Loc



                                                #region Loc Info Count
                                                //LcoInfo count start
                                                if (RoleLoc.Count > 0 && RoleLoc != null)

                                                {


                                                    #region Locinfo for loop iteration
                                                    // Locinfo for loop iteration
                                                    for (int d = 0; d < RoleLoc.Count(); d++)
                                                    {
                                                        lstLocInfo = new List<LocationIn>();
                                                        #region LocInof foreach Loc
                                                        // DeptInof foreach Dept
                                                        foreach (RoleLocationIn Locitem in RoleLoc)
                                                        {

                                                            #region  If Loc ID is eqal to each Loc
                                                            //If Dept ID is eqal to eachDept
                                                            if (UserInfo[i].LoginID == Convert.ToString(Locitem.LoginID))
                                                            {
                                                                if (Rolitem.RoleID == Locitem.RoleID)
                                                                {
                                                                    ObjLocList = new LocationIn();
                                                                    ObjLocList.LocationID = Locitem.LocationID;
                                                                    ObjLocList.LocationName = Locitem.LocationName;

                                                                    lstLocInfo.Add(ObjLocList);
                                                                }

                                                            } //If Loc ID is eqal to each Loc
                                                            #endregion Locid is equal to eachLoc

                                                        } // LocInof foreach Loc

                                                        #endregion Loc In of forEach Loc





                                                    }  // Locinfo for loop iteration

                                                    #endregion Loc Info Loop Iteration

                                                    #region Locinfo to Locinfo
                                                    if (lstLocInfo.Count > 0 && lstLocInfo != null)
                                                    {

                                                        objRoleList.LocationInfo = lstLocInfo;
                                                    }
                                                    #endregion Locinfo to Loc info


                                                }  //LocInfo count end
                                                #endregion LocInfo Count




                                                #endregion Loc
                                                /*** Loc ***/

                                                lstRoleInfo.Add(objRoleList);


                                            } //If Role ID is eqal to each Role
                                            #endregion Roleid is equal to eachRole

                                        } // RoleInof foreach Role

                                        #endregion Role In of forEach user
                                        //   }  // Roleinfo for loop iteration

                                        #endregion Role Info Loop Iteration

                                        #region rolinfo to userinfo
                                        if (lstRoleInfo.Count > 0 && lstRoleInfo != null)
                                        {

                                            objUsersList.RoleInfo = lstRoleInfo;
                                        }
                                        #endregion rolinfo to user info

                                    }  //RoleInfo count end
                                    #endregion RoleInfo Count
                                    #endregion 

                                    lstUserInfo.Add(objUsersList);
                                }
                                //If User ID is eqal to each User
                                #endregion userid is equal to eachuser
                            }
                            //If User ID is eqal to each User
                            #endregion userid is equal to eachuser
                        }

                        #endregion User Info Loop Iteration

                        UserDataInfo objUserData = new UserDataInfo();
                        objUserData.OrgCode = pOrgCode;
                        objUserData.Type = pRoleName;
                        objUserData.OrgID = UserInfo[0].OrgID;
                        objUserData.LocationID = UserInfo[0].LocationID;

                        objUserData.Userinfo = lstUserInfo;
                        objUserData.TotalRecords = lstPages[0].TotalRecords;
                        objUserData.TotalPages = lstPages[0].TotalPages;
                        objUserData.AllowableRecordCount = lstPages[0].AllowableRecordCount;

                        actionResult = Ok(objUserData);
                    }
                    else
                    {
                        actionResult = Ok("Invalid Request");
                    }


                    //userInfo count end
                    //     #endregion

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

        /// </summary>
        ///
        ///<param name = "pRoleName" >RoleName AttuneLIMS</param >
        ///<param name = "pPage" >Parameter to handle paging logic</param >
        ///<param name = "pSize" >Parameter to specify No.of.Records in Single Page</param >
        /// <returns>success</returns>
        [ResponseType(typeof(SampleCollectionPersonData))]
        [HttpGet]
        [Route("Api/Masters/GetSampleCollectionpersonInfo")]
        public IHttpActionResult GetSampleCollectionPerson(string pRoleName, int pPage, int pSize)
        {
            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            string pOrgCode = string.Empty;

            if (headers.Contains("orgcode"))
            {
                pOrgCode = headers.GetValues("orgcode").First();
            }

            long returnCode = -1;
            IHttpActionResult actionResult = null;
            List<SampleCollectionpersonInfo> lstSampleCollectionpersonInfo = new List<SampleCollectionpersonInfo>();
            List<RoleLogin> lstRolesInfo = new List<RoleLogin>();
            List<Paging> lstPages = new List<Paging>();
            List<RoleDeptIn> RoleDept = new List<RoleDeptIn>();
            List<RoleLocationIn> RoleLoc = new List<RoleLocationIn>();

            List<Users> lstSampleCollpersonInfo = null;
            Users objUsersList = null;


            List<RoleIn> lstRoleInfo = null;

            RoleIn objRoleList = null;

            List<DeptIn> lstDeptInfo = null;

            DeptIn objDeptList = null;


            List<LocationIn> lstLocInfo = null;
            LocationIn ObjLocList = null;

            try
            {

                returnCode = new LIMSAPI_BL().GetSampleCollectionPerson__LIMSAPI(pOrgCode, pRoleName, pPage, pSize, out lstSampleCollectionpersonInfo, out lstRolesInfo, out RoleDept, out RoleLoc, out lstPages);

                if (returnCode != -1)
                {
                    //   #region User Info Count
                    //userInfo count start
                    if (lstSampleCollectionpersonInfo.Count > 0 && lstSampleCollectionpersonInfo != null)
                    {

                        lstSampleCollpersonInfo = new List<Users>();
                        #region Userinfo for loop iteration
                        // Userinfo for loop iteration
                        for (int i = 0; i < lstSampleCollectionpersonInfo.Count(); i++)
                        {


                            #region UserInof foreach user
                            // UserInof foreach user
                            foreach (SampleCollectionpersonInfo item in lstSampleCollectionpersonInfo)
                            {

                                objUsersList = new Users();

                                #region  If User ID is eqal to each User
                                //If User ID is eqal to each User
                                if (lstSampleCollectionpersonInfo[i].UserID == item.UserID)
                                {
                                    objUsersList.Gender = item.Gender;
                                    objUsersList.UserID = item.UserID;
                                    objUsersList.Name = item.Name;
                                    objUsersList.LoginID = item.LoginID;
                                    objUsersList.LoginName = item.LoginName;
                                    objUsersList.Password = item.Password;
                                    objUsersList.TitleName = item.TitleName;
                                    if (item.FirstName != null)
                                    {
                                        objUsersList.FirstName = item.FirstName;
                                    }
                                    else
                                    {
                                        objUsersList.FirstName = "";
                                    }
                                    if (item.MiddleName != null)
                                    {
                                        objUsersList.MiddleName = item.MiddleName;
                                    }
                                    else
                                    {
                                        objUsersList.MiddleName = "";
                                    }
                                    if (item.LastName != null)
                                    {
                                        objUsersList.LastName = item.LastName;
                                    }
                                    else
                                    {
                                        objUsersList.LastName = "";
                                    }
                                    objUsersList.DateofBirth = item.DateofBirth;
                                    if (item.MobileNumber != null)
                                    {
                                        objUsersList.MobileNumber = item.MobileNumber;
                                    }
                                    else
                                    {
                                        objUsersList.MobileNumber = "";
                                    }
                                    objUsersList.EmailID = item.EmailID;
                                  //  objUsersList.Status = item.Status;
                                 //   objUsersList.State = item.State;
                                 //   objUsersList.Country = item.Country;


                                    /*** Role ***/
                                    #region Role

                                    #region Role Info Count
                                    //RoleInfo count start
                                    if (lstRolesInfo.Count > 0 && lstRolesInfo != null)

                                    {

                                        //   objRoleData = new RoleInfo();


                                        #region Roleinfo for loop iteration
                                        // Roleinfo for loop iteration
                                        //   for (int j = 0; j < lstRolesInfo.Count(); j++)
                                        //   {
                                        lstRoleInfo = new List<RoleIn>();
                                        #region UserInof foreach user
                                        // RoleInof foreach Role
                                        foreach (RoleLogin Rolitem in lstRolesInfo)
                                        {
                                            objRoleList = new RoleIn();
                                            #region  If Role ID is eqal to each role
                                            //If Role ID is eqal to each Role
                                            if (lstSampleCollectionpersonInfo[i].LoginID == Rolitem.LoginID)
                                            {
											  objUsersList.City = Rolitem.City;
                                                objUsersList.State = Rolitem.State;
                                                objUsersList.Country = Rolitem.Country;
                                                objRoleList.RoleID = Rolitem.RoleID;
                                                objRoleList.RoleName = Rolitem.RoleName;

                                                /*** Dept ***/
                                                #region Dept



                                                #region Dept Info Count
                                                //DeptInfo count start
                                                if (RoleDept.Count > 0 && RoleDept != null)

                                                {


                                                    #region Deptinfo for loop iteration
                                                    // Deptinfo for loop iteration
                                                    for (int d = 0; d < RoleDept.Count(); d++)
                                                    {
                                                        lstDeptInfo = new List<DeptIn>();
                                                        #region DeptInof foreach Dept
                                                        // DeptInof foreach Dept
                                                        foreach (RoleDeptIn Depitem in RoleDept)
                                                        {
                                                            objDeptList = new DeptIn();
                                                            #region  If Dept ID is eqal to each Dept
                                                            //If Dept ID is eqal to eachDept
                                                            if (lstSampleCollectionpersonInfo[i].LoginID == Depitem.LoginID)
                                                            {
                                                                if (Rolitem.RoleID == Depitem.RoleID)
                                                                {
                                                                    objDeptList = new DeptIn();
                                                                    objDeptList.DeptID = Depitem.DeptID;
                                                                    objDeptList.DeptName = Depitem.DeptName;

                                                                    lstDeptInfo.Add(objDeptList);
                                                                }

                                                            } //If Dept ID is eqal to each Dept
                                                            #endregion Deptid is equal to eachDept

                                                        } // DeptInof foreach Dept

                                                        #endregion Dept In of forEach Dept





                                                    }  // Deptinfo for loop iteration

                                                    #endregion Dept Info Loop Iteration



                                                    #endregion DeptInfo Count



                                                    #region Deptinfo to Deptinfo
                                                    if (lstDeptInfo.Count > 0 && lstDeptInfo != null)
                                                    {

                                                        objRoleList.DeptInfo = lstDeptInfo;
                                                    }
                                                    #endregion Deptinfo to Dept info
                                                }  //DeptInfo count end
                                                #endregion DeptInfo Count


                                                #endregion Dept
                                                /*** Dept ***/

                                                /*** Loc ***/
                                                #region Loc



                                                #region Loc Info Count
                                                //LcoInfo count start
                                                if (RoleLoc.Count > 0 && RoleLoc != null)

                                                {


                                                    #region Locinfo for loop iteration
                                                    // Locinfo for loop iteration
                                                    for (int d = 0; d < RoleLoc.Count(); d++)
                                                    {
                                                        lstLocInfo = new List<LocationIn>();
                                                        #region LocInof foreach Loc
                                                        // DeptInof foreach Dept
                                                        foreach (RoleLocationIn Locitem in RoleLoc)
                                                        {

                                                            #region  If Loc ID is eqal to each Loc
                                                            //If Dept ID is eqal to eachDept
                                                            if (lstSampleCollectionpersonInfo[i].LoginID == Convert.ToString(Locitem.LoginID))
                                                            {
                                                                ObjLocList = new LocationIn();
                                                                if (Rolitem.RoleID == Locitem.RoleID)
                                                                {
                                                                    ObjLocList.LocationID = Locitem.LocationID;
                                                                    ObjLocList.LocationName = Locitem.LocationName;

                                                                    lstLocInfo.Add(ObjLocList);
                                                                }

                                                            } //If Loc ID is eqal to each Loc
                                                            #endregion Locid is equal to eachLoc

                                                        } // LocInof foreach Loc

                                                        #endregion Loc In of forEach Loc





                                                    }  // Locinfo for loop iteration

                                                    #endregion Loc Info Loop Iteration

                                                    #region Locinfo to Locinfo
                                                    if (lstLocInfo.Count > 0 && lstLocInfo != null)
                                                    {

                                                        objRoleList.LocationInfo = lstLocInfo;
                                                    }
                                                    #endregion Locinfo to Loc info
                                                }  //LocInfo count end
                                                #endregion LocInfo Count






                                                #endregion Loc
                                                /*** Loc ***/

                                                lstRoleInfo.Add(objRoleList);


                                            } //If Role ID is eqal to each Role
                                            #endregion Roleid is equal to eachRole

                                            //     } // RoleInof foreach Role

                                            #endregion Role In of forEach user





                                        }  // Roleinfo for loop iteration

                                        #endregion Role Info Loop Iteration


                                    }  //RoleInfo count end
                                    #endregion RoleInfo Count



                                    #region rolinfo to userinfo
                                    if (lstRoleInfo.Count > 0 && lstRoleInfo != null)
                                    {

                                        objUsersList.RoleInfo = lstRoleInfo;
                                    }
                                    #endregion rolinfo to user info









                                    #endregion Role
                                    /*** Role ***/














                                    lstSampleCollpersonInfo.Add(objUsersList);

                                }
                                //If User ID is eqal to each User
                                #endregion userid is equal to eachuser


                            }
                            //If User ID is eqal to each User
                            #endregion userid is equal to eachuser





                        }
                        // Userinfo for loop iteration

                        #endregion User Info Loop Iteration
                        SampleCollectionPersonData objUserData = new SampleCollectionPersonData();
                        objUserData.OrgCode = pOrgCode;
                        objUserData.Type = pRoleName;
                        objUserData.OrgID = lstSampleCollectionpersonInfo[0].OrgID;
                        objUserData.LocationID = lstSampleCollectionpersonInfo[0].LocationID;

                        objUserData.UserInfo = lstSampleCollpersonInfo;
                        objUserData.TotalRecords = lstPages[0].TotalRecords;
                        objUserData.TotalPages = lstPages[0].TotalPages;
                        objUserData.AllowableRecordCount = lstPages[0].AllowableRecordCount;

                        actionResult = Ok(objUserData);
                    }
                    else
                    {
                        actionResult = Ok("Invalid Request");
                    }


                    //userInfo count end
                    //     #endregion

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
        /// This API will retuns the list of Refering Physicians
        /// </summary>
        /// <returns>success</returns>
        [ResponseType(typeof(PhysicianDataInfo))]
        [HttpGet]
        [Route("Api/Masters/GetPhysicianName")]
        public IHttpActionResult GetPhysicianName(int Page, int Size)
        {
            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            string pOrgCode = string.Empty;

            if (headers.Contains("orgcode"))
            {
                pOrgCode = headers.GetValues("orgcode").First();
            }

            long returnCode = -1;
            IHttpActionResult actionResult = null;
            List<PhysicianInfo> lstPhysician = new List<PhysicianInfo>();
            List<PhysicianDetailInfo> lstPhysicianDetail = new List<PhysicianDetailInfo>();
            PhysicianDataInfo objPhysicianData = new PhysicianDataInfo();
            List<Paging> lstPages = new List<Paging>();
            try
            {
                returnCode = new LIMSAPI_BL().GetPhysicianName(pOrgCode, Page, Size, out lstPhysician, out lstPages);

                if (returnCode != -1)
                {
                    if (lstPhysician.Count > 0 && lstPhysician != null)
                    {
                        for (int i = 0; i < lstPhysician.Count; i++)
                        {
                            if (lstPhysician[i].UserId > 0 && lstPhysician[i].UserId != 0)
                            {
                                if (!lstPhysicianDetail.Select(n => n.UserId).Contains(lstPhysician[i].UserId))
                                {
                                    lstPhysicianDetail.Add(new PhysicianDetailInfo()
                                    {
                                        UserId = lstPhysician[i].UserId,
                                        Salutation = lstPhysician[i].Salutation,
                                        PhysicianName = lstPhysician[i].PhysicianName,
                                        PhysicianCode = lstPhysician[i].PhysicianCode != null ? lstPhysician[i].PhysicianCode : "",
                                        MobileNo = lstPhysician[i].MobileNo != null ? lstPhysician[i].MobileNo : "",
                                        Gender = lstPhysician[i].Gender != null ? lstPhysician[i].Gender : "",
                                        DOB = lstPhysician[i].DOB != null ? lstPhysician[i].DOB : "",
                                        Email = lstPhysician[i].Email != null ? lstPhysician[i].Email : "",
                                        Qualification = lstPhysician[i].Qualification != null ? lstPhysician[i].Qualification : "",
                                        PortalAccess = lstPhysician[i].PortalAccess == "0" ? "N" : "Y",
                                        IsClient = lstPhysician[i].IsClient,
                                        ContactPersonType = lstPhysician[i].ContactPersonType != null ? lstPhysician[i].ContactPersonType : "",
                                        ContactPersonName = lstPhysician[i].ContactPersonName != null ? lstPhysician[i].ContactPersonName : "",
                                        ContactPersonMobileNumber = lstPhysician[i].ContactPersonMobileNumber != null ? lstPhysician[i].ContactPersonMobileNumber : "",
                                        ContactPersonEmailID = lstPhysician[i].ContactPersonEmailID != null ? lstPhysician[i].ContactPersonEmailID : "",
                                        Status = lstPhysician[i].Status != null ? lstPhysician[i].Status : "",
                                        HasReportingEmail = lstPhysician[i].HasReportingEmail == false ? "N" : "Y",
                                        HasReportingSms = lstPhysician[i].HasReportingSms == false ? "N" : "Y"
                                    });
                                }
                            }
                        }

                        objPhysicianData.OrgCode = pOrgCode;
                        objPhysicianData.OrgID = lstPhysician[0].OrgID;
                        objPhysicianData.LocationID = lstPhysician[0].LocationID;
                        objPhysicianData.Type = "ReferingPhysician";
                        objPhysicianData.UserInfo = lstPhysicianDetail;

                        objPhysicianData.TotalRecords = lstPages[0].TotalRecords;
                        objPhysicianData.TotalPages = lstPages[0].TotalPages;
                        objPhysicianData.AllowableRecordCount = lstPages[0].AllowableRecordCount;

                        actionResult = Ok(objPhysicianData);
                    }
                }
                else
                {
                    actionResult = Ok("Result Not Found");
                }
            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured");
            }

            return actionResult;
        }


        /// <summary>
        /// This API returns ClientName and details header  "pOrgCode"
        /// which includes Corporates,Refering Doctors,Refering Hospitals
        ///<param name = "pPage" ></param >
        ///<param name = "pSize" ></param >
        /// </summary>
        ///

        /// <returns>success</returns>
        [ResponseType(typeof(ClientNameData))]
        [HttpGet]
        [Route("Api/Masters/GetClientNameInfo")]
        public IHttpActionResult GetClientNameInfo(int pPage, int pSize)
        {
            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            string pOrgCode = string.Empty;

            if (headers.Contains("orgcode"))
            {
                pOrgCode = headers.GetValues("orgcode").First();
            }
            long returnCode = -1;
            IHttpActionResult actionResult = null;
            List<ClientNameInfo> lstClientNameInfo = new List<ClientNameInfo>();


            List<Paging> lstPages = new List<Paging>();
            ClientNameData objClientNameData = new ClientNameData();
            try
            {
                returnCode = new LIMSAPI_BL().GetClientName__LIMSAPI(pOrgCode, pPage, pSize, out lstClientNameInfo, out lstPages);

                if (returnCode != -1)
                {
                    var lstClientNameInfoDetails = new List<ClientNameDetailsInfo>();




                    if (lstClientNameInfo.Count > 0 && lstClientNameInfo != null)
                    {


                        lstClientNameInfoDetails = lstClientNameInfo.Select(i => new ClientNameDetailsInfo
                        {

                            ClientType = i.ClientType,
                            Salutation = i.Salutation,
                            ClientName = i.ClientName,
                            ClientCode = i.ClientCode,
                            Businesstype = i.Businesstype,
                            PanNo = i.PanNo,
                            ClientAccess = i.ClientAccess == 1 ? "Yes" : "No",
                            RemoteRegistration = i.RemoteRegistration == 1 ? "Yes" : "No",
                            Password = i.Password,

                            ClientPaymentType = i.ClientPaymentType,
                            InvoiceCycleDuration = i.InvoiceCycleDuration,
                            ContactPersonType = i.ContactPersonType,
                            ContactPersonName = i.ContactPersonName,
                            ContactPersonMobileNumber = i.ContactPersonMobileNumber,
                            ContactPersonEmailID = i.ContactPersonEmailID,
                            Status = i.Status



                        }).ToList();





                        objClientNameData.OrgCode = pOrgCode;
                        objClientNameData.OrgID = lstClientNameInfo[0].OrgID;
                        objClientNameData.LocationID = lstClientNameInfo[0].LocationID;
                        objClientNameData.Type = lstClientNameInfo[0].Type;//ClientMaster
                        objClientNameData.ClientInfo = lstClientNameInfoDetails;
                        objClientNameData.TotalRecords = lstPages[0].TotalRecords;
                        objClientNameData.TotalPages = lstPages[0].TotalPages;
                        objClientNameData.AllowableRecordCount = lstPages[0].AllowableRecordCount;

                        actionResult = Ok(objClientNameData);





                    }
                    else
                    {
                        actionResult = Ok("Result not Found");
                    }
                }
                else
                {
                    actionResult = Ok("Result Not Found");
                }

            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured");
            }

            return actionResult;
        }
        /// <summary>
        /// This API returns Investigation or Group Master List with TestCodes
        /// If testcode is given respective Test details will be returned
        /// </summary>
        ///
        ///<param name="pType">INV-Investigation,GRP-Group</param>
        ///<param name = "TestCode" >Providing Testcode will return respective Test details and empty will return all Testmaster Information based on Type </param >
        ///<param name = "Page" >Parameter to handle paging in case of Bulk Data</param >
        ///<param name = "Size" >Parameter to handle number of records in Single Page</param >

        /// <returns>success</returns>
        [ResponseType(typeof(TestMasterDetails))]
        [HttpGet]
        [Route("Api/Masters/GetTestMasterDetails")]
        public IHttpActionResult GetTestMasterInfo(string pType, string TestCode, int Page, int Size)
        {
            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            string pOrgCode = string.Empty;

            if (headers.Contains("orgcode"))
            {
                pOrgCode = headers.GetValues("orgcode").First();
            }
            if (string.IsNullOrEmpty(TestCode))
            {
                TestCode = string.Empty;
            }
            long returnCode = -1;
            IHttpActionResult actionResult = null;
            List<TestMasterDetInfo> lstTestMaster = new List<TestMasterDetInfo>();
            TestMasterinvInfo ObjTestMasterDet = null;
            TestMasterDetails objTestMasterDatGRP = null;
            List<TestMasterinvInfo> lstTestMasterDetals = null;
            List<TestMasterDetails> lstTestMasterDetalsGRP = null;
            List<TestMasterData> lstTestMasterDetails = new List<TestMasterData>();
            List<TestMasterDataGRP> lstTestMasterDetailsGRP = new List<TestMasterDataGRP>();
             List <Paging> lstPages = new List<Paging>();
            TestMasterData objTestMasterData = new TestMasterData();
            TestMasterDataGRP objTestMasterDataGRP = new TestMasterDataGRP();
            TestMasterDataPKG objTestMasterDataPKG = new TestMasterDataPKG();
            TestMasterDetails objTestMasterDatPKG = null;
            List<TestMasterDetails> lstTestMasterDetalsPKG = null;
            List<TestMasterDataPKG> lstTestMasterDetailsPKG = new List<TestMasterDataPKG>();
            List<TestInv> lstTestInv = null ;
            List<TestInv> lstTestInvPKG = null;
            TestInv ObjTestInv = null;
            TestInv ObjTestInvPKG = null;
            try
            {
                returnCode = new LIMSAPI_BL().GetTestMasterInfo__LIMSAPI(pOrgCode, pType, TestCode, Page, Size, out lstTestMaster,out lstPages);

                if (returnCode != -1)
                {
                    if (lstTestMaster.Count > 0 && lstTestMaster != null)
                    {
                        if (pType == "INV")
                        {
                            for (int i = 0; i < lstTestMaster.Count(); i++)
                            {

                                lstTestMasterDetals = new List<TestMasterinvInfo>();


                                foreach (TestMasterDetInfo item in lstTestMaster)
                                {

                                    ObjTestMasterDet = new TestMasterinvInfo();
                                    if (lstTestMaster[i].Type == item.Type)
                                    {
                                        ObjTestMasterDet.TestCode = item.TestCode;
                                        ObjTestMasterDet.TestName = item.TestName;
                                        ObjTestMasterDet.Type = item.Type;

                                        ObjTestMasterDet.Gender = item.Gender;
                                        ObjTestMasterDet.SampleID = item.SampleID;
                                        ObjTestMasterDet.SampleName = item.SampleName;

                                        ObjTestMasterDet.ContainerID = item.ContainerID;
                                        ObjTestMasterDet.ContainerName = item.ContainerName;
                                        ObjTestMasterDet.SampleContainerColour = item.SampleContainerColour;
                                        ObjTestMasterDet.Price = item.Price;
                                        ObjTestMasterDet.DepartmentName = item.DepartmentName;
                                        ObjTestMasterDet.DepartmentID = item.DepartmentID;
                                        ObjTestMasterDet.Status = item.Status;

                                        lstTestMasterDetals.Add(ObjTestMasterDet);
                                    }
                                }



                             



                            }
                            objTestMasterData.OrgCode = pOrgCode;

                                objTestMasterData.ParameterInfoList = lstTestMasterDetals;
                                objTestMasterData.TotalRecords = lstPages[0].TotalRecords;
                                objTestMasterData.TotalPages = lstPages[0].TotalPages;
                                objTestMasterData.AllowableRecordCount = lstPages[0].AllowableRecordCount;

                                lstTestMasterDetails.Add(objTestMasterData);




                            
                            actionResult = Ok(lstTestMasterDetails);
                        }



                        else if (pType == "GRP")
                        {
                           
                            var lstTestMasterInfo = new List<TestMasterDetInfo>();


                            var result = lstTestMaster.GroupBy(x => new {
                                x.TestCode,
                                x.TestName,
                                x.Type,
                                x.Gender,
                                x.SampleID,
                                x.SampleName,
                                x.ContainerID,
                                x.ContainerName,
                                x.SampleContainerColour,
                              x.Price,
                                x.GRPPrice,
                                x.DepartmentName,
                                x.DepartmentID,
                                x.Status
                            })
                               .Select(y => new {
                                    y.Key.TestCode,
                                   y.Key.TestName,
                                    y.Key.Type,

                                   y.Key.Gender,
                                   y.Key.SampleID,
                                    y.Key.SampleName,

                                    y.Key.ContainerID,
                                   y.Key.ContainerName,
                                   y.Key.SampleContainerColour,
                                  y.Key.Price,
                                 y.Key.GRPPrice,
                                  y.Key.DepartmentName,
                                   y.Key.DepartmentID,
                                   y.Key.Status, MyCount = y.Count() }).ToList();


                         
                          
                           
                            var res = (from a in lstTestMaster
                                       group a by TestCode into tmp
                                       select new
                                       {
                                           Name = tmp.Key,
                                           
                                          

                                       }).ToList();
                            lstTestMasterDetalsGRP = new List<TestMasterDetails>();
                        
                            for (int j = 0; j < result.Count; j++)
                           {
                                objTestMasterDatGRP = new TestMasterDetails();



                             

                                lstTestInv = new List<TestInv>();

                                objTestMasterDatGRP.TestCode = result[j].TestCode;
                                objTestMasterDatGRP.TestName = result[j].TestName;
                                objTestMasterDatGRP.Type = result[j].Type;
                                objTestMasterDatGRP.SampleID = result[j].SampleID;
                                objTestMasterDatGRP.SampleName = result[j].SampleName;

                                objTestMasterDatGRP.ContainerID = result[j].ContainerID;
                                objTestMasterDatGRP.ContainerName = result[j].TestName;
                                objTestMasterDatGRP.SampleContainerColour = result[j].SampleContainerColour;
                                objTestMasterDatGRP.Price = result[j].GRPPrice;


                                objTestMasterDatGRP.DepartmentName = result[j].DepartmentName;
                                objTestMasterDatGRP.DepartmentID = result[j].DepartmentID;
                                objTestMasterDatGRP.Status = result[j].Status;
                                
                                foreach (TestMasterDetInfo item in lstTestMaster)
                                {

                                    ObjTestInv = new TestInv();
                                    if (item.TestCode == result[j].TestCode)
                                    {

                                        ObjTestInv.TestCode = item.INVTestCode;
                                        ObjTestInv.TestName = item.INVInvestigationName;
                                        ObjTestInv.Type = "INV";

                                        ObjTestInv.Gender = item.Gender;
                                        ObjTestInv.SampleID = item.SampleID;
                                        ObjTestInv.SampleName = item.SampleName;

                                        ObjTestInv.ContainerID = item.ContainerID;
                                        ObjTestInv.ContainerName = item.ContainerName;
                                        ObjTestInv.SampleContainerColour = item.SampleContainerColour;
                                    //    ObjTestInv.Price = item.Price;
                                        ObjTestInv.DepartmentName = item.DepartmentName;
                                        ObjTestInv.DepartmentID = item.DepartmentID;
                                        ObjTestInv.Status = item.Status;
                                       
                                        lstTestInv.Add(ObjTestInv);
                                          
                                           
                                        }
                                    objTestMasterDatGRP.TestInfo = lstTestInv;
                                }
                                   
                                     lstTestMasterDetalsGRP.Add(objTestMasterDatGRP);
                                }
                              










                        
                            objTestMasterDataGRP.OrgCode = pOrgCode;
                            objTestMasterDataGRP.ParameterInfoList = lstTestMasterDetalsGRP;
                            objTestMasterDataGRP.TotalRecords = lstPages[0].TotalRecords;
                            objTestMasterDataGRP.TotalPages = lstPages[0].TotalPages;
                            objTestMasterDataGRP.AllowableRecordCount = lstPages[0].AllowableRecordCount;

                            lstTestMasterDetailsGRP.Add(objTestMasterDataGRP);

                            actionResult = Ok(lstTestMasterDetailsGRP);
                        }
                        else if (pType == "PKG")
                        {
                         
                            var lstTestMasterInfo = new List<TestMasterDetInfo>();


                            var result = lstTestMaster.GroupBy(x => new {
                                x.TestCode,
                                x.TestName,
                                x.Type,
                                x.Gender,
                                x.SampleID,
                                x.SampleName,
                                x.ContainerID,
                                x.ContainerName,
                                x.SampleContainerColour,
                               x.Price,
                             x.PKGPrice,
                                x.DepartmentName,
                                x.DepartmentID,
                                x.Status
                            })
                               .Select(y => new {
                                   y.Key.TestCode,
                                   y.Key.TestName,
                                   y.Key.Type,

                                   y.Key.Gender,
                                   y.Key.SampleID,
                                   y.Key.SampleName,

                                   y.Key.ContainerID,
                                   y.Key.ContainerName,
                                   y.Key.SampleContainerColour,
                                   y.Key.Price,
                                   y.Key.PKGPrice,
                                   y.Key.DepartmentName,
                                   y.Key.DepartmentID,
                                   y.Key.Status,
                                   MyCount = y.Count()
                               }).ToList();


                          


                            var res = (from a in lstTestMaster
                                       group a by TestCode into tmp
                                       select new
                                       {
                                           Name = tmp.Key,



                                       }).ToList();
                            lstTestMasterDetalsPKG = new List<TestMasterDetails>();

                            for (int j = 0; j < result.Count; j++)
                            {
                                objTestMasterDatPKG = new TestMasterDetails();



                              

                                lstTestInvPKG = new List<TestInv>();

                                objTestMasterDatPKG.TestCode = result[j].TestCode;
                                objTestMasterDatPKG.TestName = result[j].TestName;
                                objTestMasterDatPKG.Type = result[j].Type;
                                objTestMasterDatPKG.SampleID = result[j].SampleID;
                                objTestMasterDatPKG.SampleName = result[j].SampleName;

                                objTestMasterDatPKG.ContainerID = result[j].ContainerID;
                                objTestMasterDatPKG.ContainerName = result[j].ContainerName;
                                objTestMasterDatPKG.SampleContainerColour = result[j].SampleContainerColour;
                                objTestMasterDatPKG.Price = result[j].PKGPrice;
                                objTestMasterDatPKG.DepartmentName = result[j].DepartmentName;
                                objTestMasterDatPKG.DepartmentID = result[j].DepartmentID;
                                objTestMasterDatPKG.Status = result[j].Status;
                               
                                foreach (TestMasterDetInfo item in lstTestMaster)
                                {

                                    ObjTestInvPKG = new TestInv();
                                    if (item.TestCode == result[j].TestCode)
                                    {

                                        ObjTestInvPKG.TestCode = item.INVTestCode;
                                        ObjTestInvPKG.TestName = item.INVInvestigationName;
                                        ObjTestInvPKG.Type = "INV";

                                        ObjTestInvPKG.Gender = item.Gender;
                                        ObjTestInvPKG.SampleID = item.SampleID;
                                        ObjTestInvPKG.SampleName = item.SampleName;

                                        ObjTestInvPKG.ContainerID = item.ContainerID;
                                        ObjTestInvPKG.ContainerName = item.ContainerName;
                                        ObjTestInvPKG.SampleContainerColour = item.SampleContainerColour;
                                    //    ObjTestInvPKG.Price = item.Price;
                                        ObjTestInvPKG.DepartmentName = item.DepartmentName;
                                        ObjTestInvPKG.DepartmentID = item.DepartmentID;
                                        ObjTestInvPKG.Status = item.Status;
                                     
                                        lstTestInvPKG.Add(ObjTestInvPKG);


                                    }
                                    objTestMasterDatPKG.TestInfo = lstTestInvPKG;
                                }

                                lstTestMasterDetalsPKG.Add(objTestMasterDatPKG);
                            }
                          
                       
                            objTestMasterDataPKG.OrgCode = pOrgCode;
                            objTestMasterDataPKG.ParameterInfoList = lstTestMasterDetalsPKG;
                            objTestMasterDataPKG.TotalRecords = lstPages[0].TotalRecords;
                            objTestMasterDataPKG.TotalPages = lstPages[0].TotalPages;
                            objTestMasterDataPKG.AllowableRecordCount = lstPages[0].AllowableRecordCount;

                            lstTestMasterDetailsPKG.Add(objTestMasterDataPKG);

                            actionResult = Ok(lstTestMasterDetailsPKG);
                        }
                        else
                        {
                            actionResult = Ok("Invalid Request");
                        }
                    }
                
            
                    
                    }
                    else
                    {
                        actionResult = Ok("Result not Found");
                    }

            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured");
            }

            return actionResult;
        }

        /// <summary>
        /// This API will provide the User Login details and Roles based on OrgCode
        
        
        
        
       
        #region 

        /// <summary>
        /// This API will give the Master data of Country,State and City based on Type
        /// </summary>
        /// <param name="pCategoryCode"></param>
        /// <param name="pText"></param>
        /// <param name="pPage"></param>
        /// <param name="pSize"></param>
        /// <returns></returns>
        [ResponseType(typeof(LocalityData))]
        [HttpGet]
        [Route("Api/Masters/Locality")]
        public IHttpActionResult GetLocalityMaster(string pCategoryCode, string pText, int pPage, int pSize)
        {
            long returnCode = -1;
            IHttpActionResult actionResult = null;

            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            string pOrgCode = string.Empty;

            if (headers.Contains("orgcode"))
            {
                pOrgCode = headers.GetValues("orgcode").First();
            }

            if (string.IsNullOrEmpty(pText))
            {
                pText = string.Empty;
            }

            List<LocalityInfo> lstLocality = new List<LocalityInfo>();
            List<Paging> lstPages = new List<Paging>();
            LocalityData objlocality = new LocalityData();
            try
            {
                returnCode = new LIMSAPI_BL().GetLocality(pOrgCode, pCategoryCode, pText, pPage, pSize, out lstLocality, out lstPages);

                if (returnCode != -1)
                {
                    if (lstLocality.Count > 0 && lstLocality != null)
                    {
                        objlocality.OrgCode = pOrgCode;
                        objlocality.Type = pCategoryCode;
                        objlocality.Locality = lstLocality;

                        objlocality.TotalRecords = lstPages[0].TotalRecords;
                        objlocality.TotalPages = lstPages[0].TotalPages;
                        objlocality.AllowableRecordCount = lstPages[0].AllowableRecordCount;

                        actionResult = Ok(objlocality);
                    }
                    else
                    {
                        actionResult = Ok("Result not Found");
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

        

        
        #endregion

      
 #region //Seetha
 
  /// <summary>
        /// This API will help for client insertion in Master
        /// </summary>
        /// <param name="lstClientDetails">Client details which is need to be save in LIS as List</param>
        /// <returns></returns>
 
        [ResponseType(typeof(ClientMasterDetails))]
        [Route("Api/Masters/InsertClientMaster")]
        [HttpPost]
        public IHttpActionResult InsertClientMaster(ClientMasterDetails lstClientDetails)
        {
            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            string pOrgCode = string.Empty;

            if (headers.Contains("orgcode"))
            {
                pOrgCode = headers.GetValues("orgcode").First();
            }

            long returnCode = -1;
            IHttpActionResult actionResult = null;

            



            try
            {
                if (lstClientDetails != null && lstClientDetails.payload.Count > 0)
                {
                    string clientcode = string.Empty;
                    List<payload> lstpay = new List<payload>();
                    lstpay = lstClientDetails.payload;
                    foreach (payload cla in lstpay)
                    {
                        List<ClientDetailsLIMSAPI> lstclientdetails = new List<ClientDetailsLIMSAPI>();

                        List<AddressDetails> lstaddressdetails = new List<AddressDetails>();
                        ClientDetailsLIMSAPI objclientdetails = new ClientDetailsLIMSAPI();
                        AddressDetails objaddressdetails = new AddressDetails();
                        AddressDetails objpermanentaddressdetails = new AddressDetails();
                         
                      
                        //   objclientdetails.ClientName = cla.account_information.client_name;
                      
                        objclientdetails.CompanyID = cla.company_id.ToString();
                        //   objclientdetails.ClientType = 4;
                        objclientdetails.ClientType = cla.account_information.customer_segment;
                        objclientdetails.ClientName = cla.account_information.client_name;
                        objclientdetails.ClientCode = cla.account_information.client_code.ToString();
                        objclientdetails.BusinessType = cla.account_information.business_type;
                        //    objclientdetails.ClientCategory = cla.account_information.client_type;
                        objclientdetails.ISCash = cla.account_information.client_type;
                        objclientdetails.Status = cla.account_information.status;
                        //  objclientdetails.ISCash = "N";
                        objclientdetails.OrgID = 0;
                        lstclientdetails.Add(objclientdetails);

                           objpermanentaddressdetails.AddressTypeID = 1;
                        objpermanentaddressdetails.Address2 = cla.account_information.address;
                        objpermanentaddressdetails.City = cla.account_information.city;
                        objpermanentaddressdetails.EmailID = cla.account_information.owner;
                        objpermanentaddressdetails.Country = cla.account_information.country;
                        objpermanentaddressdetails.State = cla.account_information.state;
                     //   objpermanentaddressdetails.CountryID = 186;
                      //  objpermanentaddressdetails.StateID = 3716;
                        lstaddressdetails.Add(objpermanentaddressdetails);

                        objaddressdetails.AddressTypeID = 0;
                        if (cla.contact_information.Count > 0)
                        {
                            if (cla.contact_information[0].work_email != null && cla.contact_information[0].work_email.Count > 0)
                            {
                                objaddressdetails.EmailID = cla.contact_information[0].work_email[0];
                            }
                            //objaddressdetails.EmailID = lstClientDetails.payload[0].contact_information[0].work_email[0];
                            //    objaddressdetails.CountryID = 186;
                            //   objaddressdetails.StateID = 3716;
                            objaddressdetails.CountryID = Convert.ToInt32(cla.account_information.country_id);
                            objaddressdetails.StateID = Convert.ToInt32(cla.account_information.state_id);
                            objaddressdetails.Name = cla.contact_information[0].title + '.' + cla.contact_information[0].name;
                            //   objaddressdetails.ContactType = "CLT";
                            if (cla.account_information.mobile_phone != null)
                            {
                                objaddressdetails.Mobile = cla.account_information.mobile_phone;
                            }
                            objaddressdetails.ContactType = cla.contact_information[0].contact_type;
                            if (cla.contact_information[0].work_phone != null && cla.contact_information[0].work_phone.Count > 0)
                            {
                                objaddressdetails.Phone = cla.contact_information[0].work_phone[0];
                            }
                            //objaddressdetails.Phone = lstClientDetails.payload[0].contact_information[0].work_phone[0];
                        }
                        lstaddressdetails.Add(objaddressdetails);

                        string JsonValue = JsonConvert.SerializeObject(lstClientDetails);

                        if (objclientdetails != null)
                        {
                            returnCode = new LIMSAPI_BL().InsertClientMaster(pOrgCode, lstclientdetails, lstaddressdetails, JsonValue);
                            clientcode += cla.account_information.client_code.ToString() + ",";
                            if (returnCode != -1)
                            {
                                actionResult = Ok("Following Client Codes are : " + clientcode.Substring(0,clientcode.Length-1) + " Successfully processed.");
                            }
                            else
                            {
                                return Content(HttpStatusCode.ExpectationFailed, "Result not found");
                            }
                        }
                    }
                }
                else
                {
				 return Content(HttpStatusCode.ExpectationFailed, "Client Information not found");
                    
                }
            }
            catch (Exception ex)
            {
			
                return Content(HttpStatusCode.ExpectationFailed, "Error Occured");

            }

            return actionResult;
        }

  /// <summary>
        /// This API will be provide list of Rates for Investigation, Group and Package with Client Details.
        /// </summary>
        /// <param name="OrgCode">Orgcode of integrated org</param>
        /// <param name="Page">Parameter to handle paging in case of Bulk Data</param>
        /// <param name="Size">Parameter to handle number of records in Single Page</param>
        /// <returns></returns>
        [ResponseType(typeof(ClientRateInfo))]
        [HttpGet]
        [Route("Api/Masters/GetRateCardDetails")]
        public IHttpActionResult GetRateCardDetails(string OrgCode,int Page, int Size)
        {
            long returnCode = -1;
            IHttpActionResult actionResult = null;

            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            string pOrgCode = string.Empty;

            if (headers.Contains("orgcode"))
            {
                pOrgCode = headers.GetValues("orgcode").First();
            }

           
            List<ClientListRate> lstClientRateInfoDetails = new List<ClientListRate>();

            List<ClientRateInfo> lstClientRateInfo = new List<ClientRateInfo>();
            List<Paging> lstpages = new List<Paging>();

            List<RateCardDetails> lstRateDetails = new List<RateCardDetails>();
            List<ClientRateDetails> lstClientRateDetails = new List<ClientRateDetails>();
          
            List<TestRateDetails> lstTestRate = new List<TestRateDetails>();
            TestRateDetails objTestRate = null;
            ClientRateDetails ObjClientRateDetails = new ClientRateDetails();
            List<ClientMasterInfo> lstClientMasterInfo = new List<ClientMasterInfo>();
            List<RateCardDetailsInfo> lstRateCardDetailsInfo = new List<RateCardDetailsInfo>();

            try
            {
                returnCode = new LIMSAPI_BL().GetRateCardDetails(pOrgCode,Page,Size, out lstClientRateInfo,out lstpages);

                if (returnCode != -1)
                {
                    if (lstClientRateInfo.Count > 0 && lstClientRateInfo != null)
                    {
                        ObjClientRateDetails.OrgCode = OrgCode;
                        for (int i = 0; i < lstClientRateInfo.Count(); i++)
                        {
                            lstRateDetails = new List<RateCardDetails>();
                            ClientMasterInfo ObjClient = new ClientMasterInfo();

                            lstRateCardDetailsInfo = new List<RateCardDetailsInfo>();
                            foreach (ClientRateInfo item in lstClientRateInfo)
                            {
                                
                                RateCardDetailsInfo objRateCardDetailsInfo = new RateCardDetailsInfo();
                               

                               
                              

                                if (lstClientRateInfo[i].ClientCode == item.ClientCode)
                                {

                                    objRateCardDetailsInfo.RateCardName = item.RateCardName;
                                    objRateCardDetailsInfo.RateCardCode = item.RateCardCode;

                                    objRateCardDetailsInfo.RateCardType = item.RateCardType;
                                    objRateCardDetailsInfo.RateSubType = item.RateSubType;
                                    objRateCardDetailsInfo.ValidaityFrom = item.ValidaityFrom;

                                    objRateCardDetailsInfo.ValidaityTo = item.ValidaityTo;
                                    objRateCardDetailsInfo.RateIsActive = item.IsActive;
                                    objRateCardDetailsInfo.Priority = item.Priority;
                                    objRateCardDetailsInfo.RateComments = item.RateComments;
                                    objRateCardDetailsInfo.TestName = item.TestName;
                                    objRateCardDetailsInfo.TestID = item.TestID;
                                    objRateCardDetailsInfo.FeeType = item.FeeType;
                                    objRateCardDetailsInfo.CreatedAt = item.CreatedAt;
                                    objRateCardDetailsInfo.UpdatedAt = item.UpdatedAt;
                                    objRateCardDetailsInfo.TestCode = item.TestCode;
                                    objRateCardDetailsInfo.Rate = item.Rate;
                                    objRateCardDetailsInfo.LonicCode = item.LonicCode;
                                    objRateCardDetailsInfo.Comments = item.TestComments;
                                    objRateCardDetailsInfo.IsActive = item.TestActive;
                                    lstRateCardDetailsInfo.Add(objRateCardDetailsInfo);
                                  

                                    
                                   
                                }
                            }

                            if (lstRateCardDetailsInfo.Count > 0 && lstRateCardDetailsInfo != null)

                            {
                                for (int j = 0; j < lstRateCardDetailsInfo.Count(); j++)
                                {
                                    RateCardDetails objRateDetails = new RateCardDetails();
                                    lstTestRate = new List<TestRateDetails>();
                                    foreach (RateCardDetailsInfo item in lstRateCardDetailsInfo)

                                    {
                                        objTestRate = new TestRateDetails();
                                        
                                        if (lstRateCardDetailsInfo[j].RateCardCode == item.RateCardCode)
                                        {
                                            
                                            objTestRate.TestName = item.TestName;

                                            objTestRate.FeeType = item.FeeType;
                                            objTestRate.TestID = item.TestID;
                                            objTestRate.TestCode = item.TestCode;
                                            objTestRate.Rate = item.Rate;
                                            objTestRate.LonicCode = item.LonicCode;
                                            objTestRate.Comments = item.Comments;
                                            objTestRate.IsActive = item.IsActive;

                                            objTestRate.CreatedAt = item.CreatedAt;
                                            objTestRate.UpdatedAt = item.UpdatedAt;
                                            lstTestRate.Add(objTestRate);
                                           
                                        }

                                        }
                                    if (!lstRateDetails.Select(n => n.RateCardCode).Contains(lstRateCardDetailsInfo[j].RateCardCode))
                                    {
                                        objRateDetails.RateCardName = lstRateCardDetailsInfo[j].RateCardName;
                                        objRateDetails.RateCardCode = lstRateCardDetailsInfo[j].RateCardCode;

                                        objRateDetails.RateCardType = lstRateCardDetailsInfo[j].RateCardType;
                                        objRateDetails.RateSubType = lstRateCardDetailsInfo[j].RateSubType;
                                        objRateDetails.ValidaityFrom = lstRateCardDetailsInfo[j].ValidaityFrom;

                                        objRateDetails.ValidaityTo = lstRateCardDetailsInfo[j].ValidaityTo;
                                        objRateDetails.IsActive = lstRateCardDetailsInfo[j].RateIsActive;
                                        objRateDetails.Priority = lstRateCardDetailsInfo[j].Priority;
                                        objRateDetails.Comments = lstRateCardDetailsInfo[j].RateComments;
                                        objRateDetails.TestRateDetails = lstTestRate;
                                        lstRateDetails.Add(objRateDetails);
                                        

                                    }




                                }
                            }

                                ClientListRate objclientlist = new ClientListRate();
                           
                           

                            if (!lstClientRateInfoDetails.Select(n => n.ClientCode).Contains(lstClientRateInfo[i].ClientCode))
                            {


                                objclientlist.ClientCode = lstClientRateInfo[i].ClientCode;
                                objclientlist.ClientName = lstClientRateInfo[i].ClientName;
                                objclientlist.RateCardDetails = lstRateDetails;
                                ObjClient.ClientRateInfo = objclientlist;
                                lstClientRateInfoDetails.Add(objclientlist);
                                lstClientMasterInfo.Add(ObjClient);

                            }

                        }

                        if (lstpages != null && lstpages.Count > 0)
                        {
                            ObjClientRateDetails.TotalPages = lstpages[0].TotalPages;
                            ObjClientRateDetails.TotalRecords = lstpages[0].TotalRecords;
                            ObjClientRateDetails.AllowableRecordCount = lstpages[0].AllowableRecordCount;
                        }

                        ObjClientRateDetails.ClientRateListInfo = lstClientRateInfoDetails;

                        //lstClientRateDetails.Add(ObjClientRateDetails);
                        actionResult = Ok(ObjClientRateDetails);
                    }
                    else
                    {
                        actionResult = Ok("Result not Found");
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
 
 #endregion
     
  /// <summary>
        /// This API provides the package master details with packge contents
        /// </summary>
        /// <param name="OrgCode">Orgcode of integrated org</param> 
        ///<param name = "Page" >Parameter to handle paging in case of Bulk Data</param >
        ///<param name = "Size" >Parameter to handle number of records in Single Page</param >
        /// <returns></returns>
        [ResponseType(typeof(PackageMasterDetails))]
        [HttpGet]
        [Route("Api/Masters/GetPackageMasterDetails")]
        public IHttpActionResult GetPackageMasterDetails(string OrgCode,string TestCode, int Page, int Size)
        {
            if (TestCode == null)
                TestCode = string.Empty;
            long returnCode = -1;
            IHttpActionResult actionResult = null;
            List<PackageDetail> lstPackage = new List<PackageDetail>();
            List<PackageDetail> lstPackageDetail = new List<PackageDetail>();
            List<Paging> lstPages = new List<Paging>();
            List<PackageMaster> lstpkg = new List<PackageMaster>(); 
            PackageMasterDetails objOrder = new PackageMasterDetails(); 
            try
            {
                returnCode = new LIMSAPI_BL().GetPackageMasterDetails(OrgCode, TestCode, Page,Size, out lstPackage, out lstPackageDetail, out lstPages);
                if (returnCode != -1)
                {

                    if (lstPackage != null && lstPackage.Count > 0)
                    {
                        objOrder.OrgCode = OrgCode;
                        foreach (PackageDetail objpack in lstPackage)
                        {
                            TestMasterList objlist = new TestMasterList();
                            PackageMaster objpkg = new PackageMaster();
                            objpkg.TestCode = objpack.PkgCode;
                            objpkg.TestName = objpack.PkgName;
                            objpkg.Type = objpack.PkgType;
                            objpkg.TestID = objpack.TestID;
                            objpkg.Gender = objpack.PKGGender;
                            objpkg.SampleID = objpack.SampleID;
                            objpkg.SampleName = objpack.SampleName;
                            objpkg.ContainerID = objpack.ContainerID;
                            objpkg.ContainerName = objpack.ContainerName;
                            objpkg.SampleContainerColour = objpack.SampleContainerColour;
                            objpkg.Price = objpack.Price;
                            objpkg.DepartmentName = objpack.DepartmentName;
                            objpkg.DepartmentID = objpack.DepartmentID;
                            objpkg.Status = objpack.PkgStatus;
                            objpkg.Orderable = objpack.Orderable;
                            TimeZone1 = objpack.TimeZone;
                            objpkg.CreatedAt =GetTimeZoneTime(objpack.CreatedAt);
                            objpkg.UpdatedAt = GetTimeZoneTime(objpack.UpdatedAt);
                            if (lstPackageDetail != null && lstPackageDetail.Count > 0)
                            {
                                List<PackageGroupMaster> lstpkgcnt = new List<PackageGroupMaster>();


                                var Contentpkg = lstPackageDetail.FindAll(p => p.PkgCode == objpack.PkgCode && p.GroupID == 0);
                                //  var Contentpkgparam = lstPatOrderDetails.FindAll(p => p.GroupID == inv.GroupID);
                                var Contentpkgparam = lstPackageDetail.GroupBy(test => test.GroupID)
                                             .Select(grp => grp.First())
                                             .Where(t => t.GroupID != 0 && t.PkgCode == objpack.PkgCode)
                                               .ToList();
                                var Contentpkgparam1 = lstPackageDetail.FindAll(p => p.PkgID == objpack.PkgID);
                                foreach (PackageDetail tall in Contentpkg)
                                {
                                    PackageGroupMaster objcont = new PackageGroupMaster();
                                    objcont.TestCode = tall.TestCode;
                                    objcont.TestName = tall.TestName;
                                    objcont.Type = tall.Type;
                                    objcont.TestID = tall.TestID;
                                    objcont.Gender = tall.Gender;
                                    objcont.SampleID = tall.SampleID;
                                    objcont.SampleName = tall.SampleName;
                                    objcont.ContainerID = tall.ContainerID;
                                    objcont.ContainerName = tall.ContainerName;
                                    objcont.SampleContainerColour = tall.SampleContainerColour;
                                    objcont.DepartmentName = tall.DepartmentName;
                                    objcont.DepartmentID = tall.DepartmentID;
                                    objcont.Status = tall.Status;
                                    objcont.CreatedAt = GetTimeZoneTime(tall.CreatedAt);
                                    objcont.UpdatedAt = GetTimeZoneTime(tall.UpdatedAt);
                                    lstpkgcnt.Add(objcont);

                                }
                                foreach (PackageDetail tall in Contentpkgparam)
                                {
                                    PackageGroupMaster objcont = new PackageGroupMaster();
                                    objcont.TestCode = tall.GroupCode;
                                    objcont.TestName = tall.GroupName;
                                    objcont.Type = "GRP";
                                    objcont.TestID = tall.AttGroupID;
                                    objcont.Gender = tall.GroupGender;
                                    objcont.SampleID = tall.SampleID;
                                    objcont.SampleName = tall.SampleName;
                                    objcont.ContainerID = tall.ContainerID;
                                    objcont.ContainerName = tall.ContainerName;
                                    objcont.SampleContainerColour = tall.SampleContainerColour;
                                    objcont.DepartmentName = tall.DepartmentName;
                                    objcont.DepartmentID = tall.DepartmentID;
                                    objcont.Status = tall.Status;
                                    objcont.CreatedAt = GetTimeZoneTime(tall.CreatedAt);
                                    objcont.UpdatedAt = GetTimeZoneTime(tall.UpdatedAt);
                                    List<PackageTestMaster> lstpkgparam = new List<PackageTestMaster>();
                                    foreach (PackageDetail objp in Contentpkgparam1)
                                    {
                                        PackageTestMaster objcontpar = new PackageTestMaster();
                                        if (tall.GroupID == objp.GroupID)// && objp.SubGroupID == "0")
                                        {
                                            objcontpar.TestCode = objp.TestCode;
                                            objcontpar.TestName = objp.TestName;
                                            objcontpar.Type = objp.Type;
                                            objcontpar.TestID = objp.TestID;
                                            objcontpar.Gender = objp.Gender;
                                            objcontpar.SampleID = tall.SampleID;
                                            objcontpar.SampleName = tall.SampleName;
                                            objcontpar.ContainerID = tall.ContainerID;
                                            objcontpar.ContainerName = tall.ContainerName;
                                            objcontpar.SampleContainerColour = tall.SampleContainerColour;
                                            objcontpar.DepartmentName = tall.DepartmentName;
                                            objcontpar.DepartmentID = tall.DepartmentID;
                                            objcontpar.Status = tall.Status;
                                            objcontpar.CreatedAt = GetTimeZoneTime(tall.CreatedAt);
                                            objcontpar.UpdatedAt = GetTimeZoneTime(tall.UpdatedAt);
                                            lstpkgparam.Add(objcontpar);
                                        }
                                    }
                                    objcont.ParameterListInfo = lstpkgparam;
                                    lstpkgcnt.Add(objcont);

                                }
                                objpkg.TestContentListInfo = lstpkgcnt;
                                //objlist.TestMasterInfo = objpkg;
                            }
                            lstpkg.Add(objpkg);
                        }
                        objOrder.TestMasterListInfo = lstpkg;
                    }
                    if (lstPages != null && lstPages.Count > 0)
                    {
                        objOrder.TotalPages = lstPages[0].TotalPages;
                        objOrder.TotalRecords = lstPages[0].TotalRecords;
                        objOrder.AllowableRecordCount= lstPages[0].AllowableRecordCount;
                    }
                   actionResult = Ok(objOrder);
                }
                else
                {
                    actionResult = Ok("While fetching the data getting an Error.");
                }
            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured" + ex.ToString());
            }
            return actionResult;
        }
        /// <summary>
        /// This API provides the group master details with its contents
        /// </summary>
        /// <param name="OrgCode">Orgcode of integrated org</param> 
        ///<param name = "Page" >Parameter to handle paging in case of Bulk Data</param >
        ///<param name = "Size" >Parameter to handle number of records in Single Page</param >
        /// <returns></returns>
        [ResponseType(typeof(PackageMasterDetails))]
        [HttpGet]
        [Route("Api/Masters/GetGroupMasterDetails")]
        public IHttpActionResult GetGroupMasterDetails(string OrgCode, string TestCode, int Page, int Size)
        {
            if (TestCode == null)
                TestCode = string.Empty;
            long returnCode = -1;
            IHttpActionResult actionResult = null;
            List<PackageDetail> lstPackage = new List<PackageDetail>();
            List<PackageDetail> lstPackageDetail = new List<PackageDetail>();
            List<Paging> lstPages = new List<Paging>();
            List<PackageMaster> lstpkg = new List<PackageMaster>();
            PackageMasterDetails objOrder = new PackageMasterDetails();
            try
            {
                returnCode = new LIMSAPI_BL().GetGroupMasterDetails(OrgCode, TestCode, Page, Size, out lstPackage, out lstPackageDetail, out lstPages);
                if (returnCode != -1)
                {

                    if (lstPackage != null && lstPackage.Count > 0)
                    {
                        objOrder.OrgCode = OrgCode;
                        foreach (PackageDetail objpack in lstPackage)
                        {
                            TestMasterList objlist = new TestMasterList();
                            PackageMaster objpkg = new PackageMaster();
                            objpkg.TestCode = objpack.PkgCode;
                            objpkg.TestName = objpack.PkgName;
                            objpkg.Type = objpack.PkgType;
                            objpkg.TestID = objpack.TestID;
                            objpkg.Gender = objpack.PKGGender;
                            objpkg.SampleID = objpack.SampleID;
                            objpkg.SampleName = objpack.SampleName;
                            objpkg.ContainerID = objpack.ContainerID;
                            objpkg.ContainerName = objpack.ContainerName;
                            objpkg.SampleContainerColour = objpack.SampleContainerColour;
                            objpkg.Price = objpack.Price;
                            objpkg.DepartmentName = objpack.DepartmentName;
                            objpkg.DepartmentID = objpack.DepartmentID;
                            objpkg.Status = objpack.PkgStatus;
                            TimeZone1 = objpack.TimeZone;
                            objpkg.CreatedAt = GetTimeZoneTime(objpack.CreatedAt);
                            objpkg.UpdatedAt = GetTimeZoneTime(objpack.UpdatedAt);
                            objpkg.Orderable = objpack.Orderable;
                            if (lstPackageDetail != null && lstPackageDetail.Count > 0)
                            {
                                List<PackageGroupMaster> lstpkgcnt = new List<PackageGroupMaster>();


                                var Contentpkg = lstPackageDetail.FindAll(p => p.PkgCode == objpack.PkgCode && p.GroupID == 0);
                                //  var Contentpkgparam = lstPatOrderDetails.FindAll(p => p.GroupID == inv.GroupID);
                                var Contentpkgparam = lstPackageDetail.GroupBy(test => test.GroupID)
                                             .Select(grp => grp.First())
                                             .Where(t => t.GroupID != 0 && t.PkgCode == objpack.PkgCode)
                                               .ToList();
                                var Contentpkgparam1 = lstPackageDetail.FindAll(p => p.PkgID == objpack.PkgID);
                                foreach (PackageDetail tall in Contentpkg)
                                {
                                    PackageGroupMaster objcont = new PackageGroupMaster();
                                    objcont.TestCode = tall.TestCode;
                                    objcont.TestName = tall.TestName;
                                    objcont.Type = tall.Type;
                                    objcont.TestID = tall.TestID;
                                    objcont.Gender = tall.Gender;
                                    objcont.SampleID = tall.SampleID;
                                    objcont.SampleName = tall.SampleName;
                                    objcont.ContainerID = tall.ContainerID;
                                    objcont.ContainerName = tall.ContainerName;
                                    objcont.SampleContainerColour = tall.SampleContainerColour;
                                    objcont.DepartmentName = tall.DepartmentName;
                                    objcont.DepartmentID = tall.DepartmentID;
                                    objcont.Status = tall.Status;
                                    objcont.CreatedAt = GetTimeZoneTime(tall.CreatedAt);
                                    objcont.UpdatedAt = GetTimeZoneTime(tall.UpdatedAt);
                                    lstpkgcnt.Add(objcont);

                                }
                                foreach (PackageDetail tall in Contentpkgparam)
                                {
                                    PackageGroupMaster objcont = new PackageGroupMaster();
                                    objcont.TestCode = tall.GroupCode;
                                    objcont.TestName = tall.GroupName;
                                    objcont.Type = "GRP";
                                    objcont.TestID = tall.AttGroupID;
                                    objcont.Gender = tall.GroupGender;
                                    objcont.SampleID = tall.SampleID;
                                    objcont.SampleName = tall.SampleName;
                                    objcont.ContainerID = tall.ContainerID;
                                    objcont.ContainerName = tall.ContainerName;
                                    objcont.SampleContainerColour = tall.SampleContainerColour;
                                    objcont.DepartmentName = tall.DepartmentName;
                                    objcont.DepartmentID = tall.DepartmentID;
                                    objcont.Status = tall.Status;
                                    objcont.CreatedAt = GetTimeZoneTime(tall.CreatedAt);
                                    objcont.UpdatedAt = GetTimeZoneTime(tall.UpdatedAt);
                                    List<PackageTestMaster> lstpkgparam = new List<PackageTestMaster>();
                                    foreach (PackageDetail objp in Contentpkgparam1)
                                    {
                                        PackageTestMaster objcontpar = new PackageTestMaster();
                                        if (tall.GroupID == objp.GroupID)// && objp.SubGroupID == "0")
                                        {
                                            objcontpar.TestCode = objp.TestCode;
                                            objcontpar.TestName = objp.TestName;
                                            objcontpar.Type = objp.Type;
                                            objcontpar.TestID = objp.TestID;
                                            objcontpar.Gender = objp.Gender;
                                            objcontpar.SampleID = tall.SampleID;
                                            objcontpar.SampleName = tall.SampleName;
                                            objcontpar.ContainerID = tall.ContainerID;
                                            objcontpar.ContainerName = tall.ContainerName;
                                            objcontpar.SampleContainerColour = tall.SampleContainerColour;
                                            objcontpar.DepartmentName = tall.DepartmentName;
                                            objcontpar.DepartmentID = tall.DepartmentID;
                                            objcontpar.Status = tall.Status;
                                            objcontpar.CreatedAt = GetTimeZoneTime(tall.CreatedAt);
                                            objcontpar.UpdatedAt = GetTimeZoneTime(tall.UpdatedAt);
                                            lstpkgparam.Add(objcontpar);
                                        }
                                    }
                                    objcont.ParameterListInfo = lstpkgparam;
                                    lstpkgcnt.Add(objcont);

                                }
                                objpkg.TestContentListInfo = lstpkgcnt;
                                //objlist.TestMasterInfo = objpkg;
                            }
                            lstpkg.Add(objpkg);
                        }
                        objOrder.TestMasterListInfo = lstpkg;
                    }
                    if (lstPages != null && lstPages.Count > 0)
                    {
                        objOrder.TotalPages = lstPages[0].TotalPages;
                        objOrder.TotalRecords = lstPages[0].TotalRecords;
                        objOrder.AllowableRecordCount = lstPages[0].AllowableRecordCount;
                    }
                    actionResult = Ok(objOrder);
                }
                else
                {
                    actionResult = Ok("While fetching the data getting an Error.");
                }
            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured" + ex.ToString());
            }
            return actionResult;
        }
        /// <summary>
        /// This API provides the test master details with its contents
        /// </summary>
        /// <param name="OrgCode">Orgcode of integrated org</param> 
        ///<param name = "Page" >Parameter to handle paging in case of Bulk Data</param >
        ///<param name = "Size" >Parameter to handle number of records in Single Page</param >
        /// <returns></returns>
        [ResponseType(typeof(PackageMasterDetails))]
        [HttpGet]
        [Route("Api/Masters/GetTestMasterDetails")]
        public IHttpActionResult GetTestMasterDetails(string OrgCode, string TestCode, int Page, int Size)
        {
            if (TestCode == null)
                TestCode = string.Empty;
            long returnCode = -1;
            IHttpActionResult actionResult = null;
            List<PackageMaster> lsttest= new List<PackageMaster>();
            List<PackageDetail> lstPackage = new List<PackageDetail>();
            List<Paging> lstPages = new List<Paging>();
            PackageMasterDetails objOrder = new PackageMasterDetails();
            try
            {
                returnCode = new LIMSAPI_BL().GetTestMasterDetails(OrgCode, TestCode, Page, Size, out lstPackage, out lstPages);
                if (returnCode != -1)
                {

                    if (lstPackage != null && lstPackage.Count > 0)
                    {
                        objOrder.OrgCode = OrgCode;
                        foreach (PackageDetail objpack in lstPackage)
                        {
                            PackageMaster objpkg = new PackageMaster();
                            objpkg.TestCode = objpack.TestCode;
                            objpkg.TestName = objpack.TestName;
                            objpkg.Type = objpack.Type;
                            objpkg.TestID = objpack.TestID;
                            objpkg.Gender = objpack.Gender;
                            objpkg.SampleID = objpack.SampleID;
                            objpkg.SampleName = objpack.SampleName;
                            objpkg.ContainerID = objpack.ContainerID;
                            objpkg.ContainerName = objpack.ContainerName;
                            objpkg.SampleContainerColour = objpack.SampleContainerColour;
                            objpkg.Price = objpack.Price;
                            objpkg.DepartmentName = objpack.DepartmentName;
                            objpkg.DepartmentID = objpack.DepartmentID;
                            objpkg.Status = objpack.Status;
                            objpkg.Price = objpack.Price;
                            TimeZone1 = objpack.TimeZone;
                            objpkg.CreatedAt = GetTimeZoneTime(objpack.CreatedAt);
                            objpkg.UpdatedAt = GetTimeZoneTime(objpack.UpdatedAt);
                            objpkg.Orderable = objpack.Orderable;
                            lsttest.Add(objpkg);
                        }
                        objOrder.TestMasterListInfo = lsttest;
                    }
                    if (lstPages != null && lstPages.Count > 0)
                    {
                        objOrder.TotalPages = lstPages[0].TotalPages;
                        objOrder.TotalRecords = lstPages[0].TotalRecords;
                        objOrder.AllowableRecordCount = lstPages[0].AllowableRecordCount;
                    }
                    actionResult = Ok(objOrder);
                }
                else
                {
                    actionResult = Ok("While fetching the data getting an Error.");
                }
            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured" + ex.ToString());
            }
            return actionResult;
        }
        /// <summary>
        /// This API provides the test master details with its contents
        /// </summary>
        /// <param name="OrgCode">Orgcode of integrated org</param> 
        ///<param name = "Page" >Parameter to handle paging in case of Bulk Data</param >
        ///<param name = "Size" >Parameter to handle number of records in Single Page</param >
        /// <returns></returns>
        [ResponseType(typeof(TestMasterSampleDetails))]
        [HttpGet]
        [Route("Api/Masters/GetTestMasterWithSample")]
        public IHttpActionResult GetTestMasterWithSample(string OrgCode,string Type, string TestCode, int Page, int Size)
        {
            if (TestCode == null)
                TestCode = string.Empty;
            long returnCode = -1;
            IHttpActionResult actionResult = null;
            List<TestAllResultdetails> lstresult = new List<TestAllResultdetails>();
            List<TestAllSampledetails> lstsample = new List<TestAllSampledetails>();
            List<Paging> lstPages = new List<Paging>();
            List<TestResultdetails> lsttestresult = new List<TestResultdetails>();
           
            List<TestContentDetails> lsttestcontent = new List<TestContentDetails>();
            List<SampleList> lsttestsamplelist = new List<SampleList>();
            TestMasterSampleDetails objOrder = new TestMasterSampleDetails();
             
            try
            {
                returnCode = new LIMSAPI_BL().GetTestMasterWithSample(OrgCode,Type, TestCode, Page, Size, out lstresult,out lstsample, out lstPages);
                if (returnCode != -1)
                {
                    if (Type == "INV")
                    {
                        if (lstresult != null && lstresult.Count > 0)
                        {
                            objOrder.OrgCode = OrgCode;
                            foreach (TestAllResultdetails objpack in lstresult)
                            {
                                TestResultdetails objinv = new TestResultdetails();
                                objinv.TestID = objpack.InvestigationID;
                                objinv.TestCode = objpack.TestCode;
                                objinv.TestName = objpack.TestName;
                                objinv.Type = objpack.Type;
                                objinv.Gender = objpack.Gender;
                                objinv.SampleID = objpack.SampleID;
                                objinv.SampleName = objpack.SampleName;
                                objinv.ContainerID = objpack.ContainerID;
                                objinv.ContainerName = objpack.ContainerName;
                                objinv.SampleContainerColour = objpack.SampleContainerColor;
                                objinv.Price = objpack.Price;
                                objinv.DepartmentName = objpack.DepartmentName;
                                objinv.DepartmentID = objpack.DepartmentID;
                                objinv.Status = objpack.Status;
                                objinv.Price = objpack.Price;
                                if (lstsample != null && lstsample.Count > 0)
                                {
                                    var lstsample1 = lstsample.FindAll(p => p.PackageID == objpack.InvestigationID);
                                    List<TestSampledetails> lsttestsample = new List<TestSampledetails>();
                                    foreach (TestAllSampledetails objsample in lstsample1)
                                    {
                                        TestSampledetails objinv1 = new TestSampledetails();
                                        objinv1.SampleID = objsample.SampleID;
                                        objinv1.SampleName = objsample.SampleName;
                                        objinv1.ContainerID = objsample.SampleContainerID;
                                        objinv1.ContainerName = objsample.ContainerName;
                                        objinv1.SampleContainerColour = objsample.SampleContainerColor;
                                        lsttestsample.Add(objinv1);

                                    }
                                    objinv.SampleListInfo = lsttestsample;
                                }

                                lsttestresult.Add(objinv);
                            }
                            objOrder.TestMasterListInfo = lsttestresult;
                        }
                        
                        if (lstPages != null && lstPages.Count > 0)
                        {
                            objOrder.TotalPages = lstPages[0].TotalPages;
                            objOrder.TotalRecords = lstPages[0].TotalRecords;
                            objOrder.AllowableRecordCount = lstPages[0].AllowableRecordCount;
                        }
                    }
                    if(Type=="GRP")
                    {
                        if (lstresult != null && lstresult.Count > 0)
                        {
                            objOrder.OrgCode = OrgCode;
                            var lstgrp = lstresult.GroupBy(grp => new { grp.InvestigationID }).Select(grp => grp.First()).ToList();
                            foreach (TestAllResultdetails objgrp in lstgrp)
                            {
                                TestResultdetails objinv = new TestResultdetails();
                                objinv.TestID = objgrp.InvestigationID;
                                objinv.TestCode = objgrp.InvestigationCode;
                                objinv.TestName = objgrp.InvestigationName;
                                objinv.Type = "GRP";
                                objinv.Gender = objgrp.Gender;
                                objinv.SampleID = 0;
                                objinv.SampleName = "";
                                objinv.ContainerID = 0;
                                objinv.ContainerName = "";
                                objinv.SampleContainerColour = "";
                                objinv.Price = objgrp.GRPPrice;
                                objinv.DepartmentName = "";
                                objinv.DepartmentID = 0;
                                objinv.Status = objgrp.InvStatus; 
                                foreach (TestAllResultdetails objpack in lstresult)
                                {
                                    if (objpack.InvestigationID == objgrp.InvestigationID)
                                    {
                                        var lstcontent = lstresult.FindAll(p => p.InvestigationID == objpack.InvestigationID);
                                        List<TestContentDetails> lstcont = new List<TestContentDetails>();
                                        foreach (TestAllResultdetails objcnt in lstcontent)
                                        {
                                            TestContentDetails objcontent = new TestContentDetails();
											objcontent.TestID = objcnt.TestID;
                                            objcontent.TestCode = objcnt.TestCode;
                                            objcontent.TestName = objcnt.TestName;
                                            objcontent.Type = objcnt.Type;
                                            objcontent.Status = objcnt.Status;
                                            objcontent.DepartmentID = objcnt.DepartmentID;
                                            objcontent.DepartmentName = objcnt.DepartmentName;
                                            lstcont.Add(objcontent);
                                        }
                                        objinv.TestContentInfo = lstcont;
                                        if (lstsample != null && lstsample.Count > 0)
                                        {
                                            var lstsample1 = lstsample.FindAll(p => p.PackageID == objpack.InvestigationID);
                                            List<TestSampledetails> lsttestsample = new List<TestSampledetails>();
                                            var lstsamplegrp = lstsample1.Where(p => p.PackageID == objpack.InvestigationID).GroupBy(test => new { test.SampleID, test.SampleContainerID }).Select(grp => grp.First()).ToList();
                                            foreach (TestAllSampledetails objsample in lstsamplegrp)
                                            {
                                                var lstsampletest = lstsample1.Where(p => p.SampleID == objsample.SampleID && p.SampleContainerID == objsample.SampleContainerID).ToList();
                                                TestSampledetails objinv1 = new TestSampledetails();
                                                objinv1.SampleID = objsample.SampleID;
                                                objinv1.SampleName = objsample.SampleName;
                                                objinv1.ContainerID = objsample.SampleContainerID;
                                                objinv1.ContainerName = objsample.ContainerName;
                                                objinv1.SampleContainerColour = objsample.SampleContainerColor;
                                                List<SampleList> lstsampletestinfo = new List<SampleList>();
                                                foreach (TestAllSampledetails objsamptest in lstsampletest)
                                                {
                                                    SampleList objsample1 = new SampleList();
                                                    objsample1.TestCode = objsamptest.TestCode;
                                                    objsample1.TestName = objsamptest.TestName;
                                                    objsample1.Type = objsamptest.Type;
                                                    lstsampletestinfo.Add(objsample1);
                                                }
                                                objinv1.TestInfoList = lstsampletestinfo;
                                                lsttestsample.Add(objinv1);

                                            }
                                            objinv.SampleListInfo = lsttestsample;
                                        }

                                    }
                                }
                                lsttestresult.Add(objinv);
                            }

                            objOrder.TestMasterListInfo = lsttestresult;
                        }
                        if (lstPages != null && lstPages.Count > 0)
                        {
                            objOrder.TotalPages = lstPages[0].TotalPages;
                            objOrder.TotalRecords = lstPages[0].TotalRecords;
                            objOrder.AllowableRecordCount = lstPages[0].AllowableRecordCount;
                        }

                    }
                    if (Type == "PKG")
                    {
                        if (lstresult != null && lstresult.Count > 0)
                        {
                            objOrder.OrgCode = OrgCode;
                            var lstgrp = lstresult.GroupBy(grp => new { grp.InvestigationID }).Select(grp => grp.First()).ToList();
                            foreach (TestAllResultdetails objgrp in lstgrp)
                            {
                                TestResultdetails objinv = new TestResultdetails();
                                objinv.TestID = objgrp.InvestigationID;
                                objinv.TestCode = objgrp.InvestigationCode;
                                objinv.TestName = objgrp.InvestigationName;
                                objinv.Type = "PKG";
                                objinv.Gender = objgrp.Gender;
                                objinv.SampleID = 0;
                                objinv.SampleName = "";
                                objinv.ContainerID = 0;
                                objinv.ContainerName = "";
                                objinv.SampleContainerColour = "";
                                objinv.Price = objgrp.PKGPrice;
                                objinv.DepartmentName = "";
                                objinv.DepartmentID = 0;
                                objinv.Status = objgrp.InvStatus;
                                foreach (TestAllResultdetails objpack in lstresult)
                                {
                                    if (objpack.InvestigationID == objgrp.InvestigationID)
                                    {
                                        var lstcontent = lstresult.FindAll(p => p.InvestigationID == objpack.InvestigationID);
                                        List<TestContentDetails> lstcont = new List<TestContentDetails>();
                                        foreach (TestAllResultdetails objcnt in lstcontent)
                                        {
                                            TestContentDetails objcontent = new TestContentDetails();
											objcontent.TestID = objcnt.TestID;
                                            objcontent.TestCode = objcnt.TestCode;
                                            objcontent.TestName = objcnt.TestName;
                                            objcontent.Type = objcnt.Type;
                                            objcontent.Status = objcnt.Status;
                                            objcontent.DepartmentID = objcnt.DepartmentID;
                                            objcontent.DepartmentName = objcnt.DepartmentName;
                                            lstcont.Add(objcontent);
                                        }
                                        objinv.TestContentInfo = lstcont;
                                        if (lstsample != null && lstsample.Count > 0)
                                        {
                                            var lstsample1 = lstsample.FindAll(p => p.PackageID == objpack.InvestigationID);
                                            List<TestSampledetails> lsttestsample = new List<TestSampledetails>();
                                            var lstsamplegrp = lstsample1.Where(p => p.PackageID == objpack.InvestigationID).GroupBy(test => new { test.SampleID, test.SampleContainerID }).Select(grp => grp.First()).ToList();
                                            foreach (TestAllSampledetails objsample in lstsamplegrp)
                                            {
                                                var lstsampletest = lstsample1.Where(p => p.SampleID == objsample.SampleID && p.SampleContainerID == objsample.SampleContainerID).ToList();
                                                TestSampledetails objinv1 = new TestSampledetails();
                                                objinv1.SampleID = objsample.SampleID;
                                                objinv1.SampleName = objsample.SampleName;
                                                objinv1.ContainerID = objsample.SampleContainerID;
                                                objinv1.ContainerName = objsample.ContainerName;
                                                objinv1.SampleContainerColour = objsample.SampleContainerColor;
                                                List<SampleList> lstsampletestinfo = new List<SampleList>();
                                                foreach (TestAllSampledetails objsamptest in lstsampletest)
                                                {
                                                    SampleList objsample1 = new SampleList();
                                                    objsample1.TestCode = objsamptest.TestCode;
                                                    objsample1.TestName = objsamptest.TestName;
                                                    objsample1.Type = objsamptest.Type;
                                                    lstsampletestinfo.Add(objsample1);
                                                }
                                                objinv1.TestInfoList = lstsampletestinfo;
                                                lsttestsample.Add(objinv1);

                                            }
                                            objinv.SampleListInfo = lsttestsample;
                                        }

                                    }
                                }
                                lsttestresult.Add(objinv);
                            }

                            objOrder.TestMasterListInfo = lsttestresult;
                        }
                        if (lstPages != null && lstPages.Count > 0)
                        {
                            objOrder.TotalPages = lstPages[0].TotalPages;
                            objOrder.TotalRecords = lstPages[0].TotalRecords;
                            objOrder.AllowableRecordCount = lstPages[0].AllowableRecordCount;
                        }

                    }
                    actionResult = Ok(objOrder);
                }
                else
                {
                    actionResult = Ok("While fetching the data getting an Error.");
                }
            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured" + ex.ToString());
            }
            return actionResult;
        }
        public string GetTimeZoneTime(DateTime SDate)
        {

            string t = string.Empty;
            if (SDate != null && SDate.ToString("yyyy") != "0001")
            {
                TimeZoneInfo tzObject1 = TimeZoneInfo.FindSystemTimeZoneById(TimeZone1);
                DateTime tstTime2 = TimeZoneInfo.ConvertTime(SDate, tzObject1, tzObject1);
                DateTime ut1 = TimeZoneInfo.ConvertTimeToUtc(tstTime2, tzObject1);

                //TimeZoneInfo tzObject2 = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
                //DateTime tstTime3 = TimeZoneInfo.ConvertTime(ut1, TimeZoneInfo.Utc, tzObject2); 
                t = ut1.ToString("o", CultureInfo.InvariantCulture);
            }
            return t;
        }

        #region MastersData
        /// <summary>
        /// This API will return the Locations of particular Organization or Labs(Processing Locations,Collection Centers) based on OrgCode
        /// </summary>
        /// <param name="pCategoryCode">Default Value is OrgLocations</param>
        /// <returns></returns>

        [ResponseType(typeof(MasterDataDetails))]
        [HttpGet]
        [Route("Api/Masters/MasterData")]
        public IHttpActionResult GetMasterData(string OrgCode,string Type, int Page, int Size)
        {
            long returnCode = -1;
            IHttpActionResult actionResult = null;

            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            string pOrgCode = string.Empty;

            if (headers.Contains("orgcode"))
            {
                pOrgCode = headers.GetValues("orgcode").First();
            }

            if (string.IsNullOrEmpty(Type))
            {
                Type = "All";
            }
            CountryDetails objCountry = new CountryDetails();
            StateDetails objState = new StateDetails();
            GenderDetails objGender = new GenderDetails();
           SalutationDetails objSalutation = new SalutationDetails();
            URNTypesDetails objURNTypes = new URNTypesDetails();
            LocationDetails objLocation = new LocationDetails();
            List<CountryDetails> lstCountryInfo = new List<CountryDetails>();
            List <StateDetails> lstStateInfo = new List<StateDetails>();
            List<GenderDetails> lstGenderInfo = new List<GenderDetails>();
            List<SalutationDetails> lstSalutationInfo = new List<SalutationDetails>();
            List<URNTypesDetails> lstURNTypesInfo = new List<URNTypesDetails>();
            List<LocationDetails> lstLocationInfo = new List<LocationDetails>();
            List<Paging> lstPages = new List<Paging>();
            List<MasterDataDetails> lstMasterDatadetails = new List<MasterDataDetails>();
            List<GenderData>  lstGenderData = new List<GenderData>();
            List<CountryData>  lstCountryData = new List<CountryData>();
            List<StateData>  lstStateData = new List<StateData>();
            List<SalutationData>  lstSalutationData = new List<SalutationData>();
            List<URNTypesData>  lstURNTypesData = new List<URNTypesData>();
            List<LocationData>  lstLocationData = new List<LocationData>();
            List<CountryData> lstCountryDatas = null;
            CountryData objCountryData = null;
            List<StateData> lstStateDatas = null;
            StateData objStateData = null;
            List<GenderData> lstGenderDatas = null;
            GenderData objGenderData = null;
            List<SalutationData> lstSalutationDatas = null;
            List<URNTypesData> lstURNTypesDatas = null;
            List<LocationData> lstLocationDatas = null;
            SalutationData objSalutationData = null;
            URNTypesData objURNTypesData = null;
            LocationData objLocationData = null;
            MasterDataDetails objMasterDataDetails = null;
            MasterData objMasterData = null;
            List<MasterData> lstMasterData = null;
            try
            {
                returnCode = new LIMSAPI_BL().GetMasterData(OrgCode, Type, Page, Size , out lstGenderData,  out lstCountryData, out lstStateData, 
                     out lstSalutationData, out lstURNTypesData, out lstLocationData, out lstPages);

                if (returnCode != -1)
                {
                    #region country
                    if (Type == "Country")
                    {
                        if (lstCountryData.Count > 0 && lstCountryData != null)
                        {
                            for (int i = 0; i < lstCountryData.Count(); i++)
                            {
                                lstCountryDatas = new List<CountryData>();

                                foreach (CountryData item in lstCountryData)
                                {
                                    objCountryData = new CountryData();


                                    objCountryData.CountryID = item.CountryID;
                                    objCountryData.CountryName = item.CountryName;
                                    objCountryData.CountryCode = item.CountryCode;


                                    lstCountryDatas.Add(objCountryData);

                                }
                                objCountry.OrgCode = OrgCode;
                                objCountry.CountryListInfo = lstCountryDatas;

                                if (lstPages != null && lstPages.Count > 0)
                                {
                                    objCountry.TotalPages = lstPages[0].TotalPages;
                                    objCountry.TotalRecords = lstPages[0].TotalRecords;
                                    objCountry.AllowableRecordCount = lstPages[0].AllowableRecordCount;
                                }

                            }

                            actionResult = Ok(objCountry);
                        }
                        else
                        {
                            actionResult = Ok("Result not Found");
                        }
                    }
                    #endregion country
                    #region State
                    if (Type == "State")
                    {
                        if (lstStateData.Count > 0 && lstStateData != null)
                        {
                            for (int i = 0; i < lstStateData.Count(); i++)
                            {
                                lstStateDatas = new List<StateData>();

                                foreach (StateData item in lstStateData)
                                {
                                    objStateData = new StateData();


                                    objStateData.StateID = item.StateID;
                                    objStateData.StateName = item.StateName;



                                    lstStateDatas.Add(objStateData);

                                }
                                objState.OrgCode = OrgCode;
                                objState.StateListInfo = lstStateDatas;

                                if (lstPages != null && lstPages.Count > 0)
                                {
                                    objState.TotalPages = lstPages[0].TotalPages;
                                    objState.TotalRecords = lstPages[0].TotalRecords;
                                    objState.AllowableRecordCount = lstPages[0].AllowableRecordCount;
                                }

                            }

                            actionResult = Ok(objState);
                        }
                        else
                        {
                            actionResult = Ok("Result not Found");
                        }
                    }
                    #endregion state
                    #region Gender
                    if (Type == "Gender")
                    {
                        if (lstGenderData.Count > 0 && lstGenderData != null)
                        {
                            for (int i = 0; i < lstGenderData.Count(); i++)
                            {
                                lstGenderDatas = new List<GenderData>();

                                foreach (GenderData item in lstGenderData)
                                {
                                    objGenderData = new GenderData();


                                    objGenderData.Code = item.Code;
                                    objGenderData.DisplayText = item.DisplayText;



                                    lstGenderDatas.Add(objGenderData);

                                }
                                objGender.OrgCode = OrgCode;
                                objGender.GenderListInfo = lstGenderDatas;

                                if (lstPages != null && lstPages.Count > 0)
                                {
                                    objGender.TotalPages = lstPages[0].TotalPages;
                                    objGender.TotalRecords = lstPages[0].TotalRecords;
                                    objGender.AllowableRecordCount = lstPages[0].AllowableRecordCount;
                                }

                            }

                            actionResult = Ok(objGender);
                        }
                        else
                        {
                            actionResult = Ok("Result not Found");
                        }
                    }
                    #endregion Gender
                    #region Salutation
                    if (Type == "Salutation")
                    {
                        if (lstSalutationData.Count > 0 && lstSalutationData != null)
                        {
                            for (int i = 0; i < lstSalutationData.Count(); i++)
                            {
                                lstSalutationDatas = new List<SalutationData>();

                                foreach (SalutationData item in lstSalutationData)
                                {
                                    objSalutationData = new SalutationData();


                                    objSalutationData.TitleID = item.TitleID;
                                    objSalutationData.TitleName = item.TitleName;



                                    lstSalutationDatas.Add(objSalutationData);

                                }
                                objSalutation.OrgCode = OrgCode;
                                objSalutation.SalutationListInfo = lstSalutationDatas;

                                if (lstPages != null && lstPages.Count > 0)
                                {
                                    objSalutation.TotalPages = lstPages[0].TotalPages;
                                    objSalutation.TotalRecords = lstPages[0].TotalRecords;
                                    objSalutation.AllowableRecordCount = lstPages[0].AllowableRecordCount;
                                }

                            }

                            actionResult = Ok(objSalutation);
                        }
                        else
                        {
                            actionResult = Ok("Result not Found");
                        }
                    }
                    #endregion Salutation
                    #region URNTypes
                    if (Type == "URNTypes")
                    {
                        if (lstURNTypesData.Count > 0 && lstURNTypesData != null)
                        {
                            for (int i = 0; i < lstURNTypesData.Count(); i++)
                            {
                                lstURNTypesDatas = new List<URNTypesData>();

                                foreach (URNTypesData item in lstURNTypesData)
                                {
                                    objURNTypesData = new URNTypesData();


                                    objURNTypesData.URNTypeId = item.URNTypeId;
                                    objURNTypesData.URNType = item.URNType;



                                    lstURNTypesDatas.Add(objURNTypesData);

                                }
                                objURNTypes.OrgCode = OrgCode;
                                objURNTypes.URNTypesListInfo = lstURNTypesDatas;

                                if (lstPages != null && lstPages.Count > 0)
                                {
                                    objURNTypes.TotalPages = lstPages[0].TotalPages;
                                    objURNTypes.TotalRecords = lstPages[0].TotalRecords;
                                    objURNTypes.AllowableRecordCount = lstPages[0].AllowableRecordCount;
                                }

                            }

                            actionResult = Ok(objURNTypes);
                        }
                        else
                        {
                            actionResult = Ok("Result not Found");
                        }
                    }
                    #endregion URNTypes
                    #region Location
                    if (Type == "Location")
                    {
                        if (lstLocationData.Count > 0 && lstLocationData != null)
                        {
                            for (int i = 0; i < lstLocationData.Count(); i++)
                            {
                                lstLocationDatas = new List<LocationData>();

                                foreach (LocationData item in lstLocationData)
                                {
                                    objLocationData = new LocationData();


                                    objLocationData.LocationID = item.LocationID;
                                    objLocationData.LocationName = item.LocationName;
                                    objLocationData.IsProcessingLocationYN = item.IsProcessingLocationYN;
                                    objLocationData.CollectionCenterYN = item.CollectionCenterYN;

                                    lstLocationDatas.Add(objLocationData);

                                }
                                objLocation.OrgCode = OrgCode;
                                objLocation.LocationListInfo = lstLocationDatas;

                                if (lstPages != null && lstPages.Count > 0)
                                {
                                    objLocation.TotalPages = lstPages[0].TotalPages;
                                    objLocation.TotalRecords = lstPages[0].TotalRecords;
                                    objLocation.AllowableRecordCount = lstPages[0].AllowableRecordCount;
                                }

                            }

                            actionResult = Ok(objLocation);
                        }
                        else
                        {
                            actionResult = Ok("Result not Found");
                        }
                    }
                    #endregion Location
                    #region All
                    if (Type == "All")
                    {
                        #region country
                        if (lstCountryData.Count > 0 && lstCountryData != null)
                        {
                            for (int i = 0; i < lstCountryData.Count(); i++)
                            {
                                lstCountryDatas = new List<CountryData>();

                                foreach (CountryData item in lstCountryData)
                                {
                                    objCountryData = new CountryData();


                                    objCountryData.CountryID = item.CountryID;
                                    objCountryData.CountryName = item.CountryName;
                                    objCountryData.CountryCode = item.CountryCode;


                                    lstCountryDatas.Add(objCountryData);

                                }
                                objCountry.OrgCode = OrgCode;
                                objCountry.CountryListInfo = lstCountryDatas;

                                if (lstPages != null && lstPages.Count > 0)
                                {
                                    objCountry.TotalPages = lstPages[0].TotalPages;
                                    objCountry.TotalRecords = lstPages[0].TotalRecords;
                                    objCountry.AllowableRecordCount = lstPages[0].AllowableRecordCount;
                                }

                            }

                            actionResult = Ok(objCountry);
                        }
                        else
                        {
                            actionResult = Ok("Result not Found");
                        }
                        #endregion country
                        #region State
                        if (lstStateData.Count > 0 && lstStateData != null)
                        {
                            for (int i = 0; i < lstStateData.Count(); i++)
                            {
                                lstStateDatas = new List<StateData>();

                                foreach (StateData item in lstStateData)
                                {
                                    objStateData = new StateData();


                                    objStateData.StateID = item.StateID;
                                    objStateData.StateName = item.StateName;



                                    lstStateDatas.Add(objStateData);

                                }
                                objState.OrgCode = OrgCode;
                                objState.StateListInfo = lstStateDatas;

                                if (lstPages != null && lstPages.Count > 0)
                                {
                                    objState.TotalPages = lstPages[0].TotalPages;
                                    objState.TotalRecords = lstPages[0].TotalRecords;
                                    objState.AllowableRecordCount = lstPages[0].AllowableRecordCount;
                                }

                            }

                            actionResult = Ok(objState);
                        }
                        else
                        {
                            actionResult = Ok("Result not Found");
                        }
                        #endregion state
                        #region Gender
                        if (lstGenderData.Count > 0 && lstGenderData != null)
                        {
                            for (int i = 0; i < lstGenderData.Count(); i++)
                            {
                                lstGenderDatas = new List<GenderData>();

                                foreach (GenderData item in lstGenderData)
                                {
                                    objGenderData = new GenderData();


                                    objGenderData.Code = item.Code;
                                    objGenderData.DisplayText = item.DisplayText;



                                    lstGenderDatas.Add(objGenderData);

                                }
                                objGender.OrgCode = OrgCode;
                                objGender.GenderListInfo = lstGenderDatas;

                                if (lstPages != null && lstPages.Count > 0)
                                {
                                    objGender.TotalPages = lstPages[0].TotalPages;
                                    objGender.TotalRecords = lstPages[0].TotalRecords;
                                    objGender.AllowableRecordCount = lstPages[0].AllowableRecordCount;
                                }

                            }

                            actionResult = Ok(objGender);
                        }
                        else
                        {
                            actionResult = Ok("Result not Found");
                        }
                        #endregion Gender
                        #region Salutation
                        if (lstSalutationData.Count > 0 && lstSalutationData != null)
                        {
                            for (int i = 0; i < lstSalutationData.Count(); i++)
                            {
                                lstSalutationDatas = new List<SalutationData>();

                                foreach (SalutationData item in lstSalutationData)
                                {
                                    objSalutationData = new SalutationData();


                                    objSalutationData.TitleID = item.TitleID;
                                    objSalutationData.TitleName = item.TitleName;



                                    lstSalutationDatas.Add(objSalutationData);

                                }
                                objSalutation.OrgCode = OrgCode;
                                objSalutation.SalutationListInfo = lstSalutationDatas;

                                if (lstPages != null && lstPages.Count > 0)
                                {
                                    objSalutation.TotalPages = lstPages[0].TotalPages;
                                    objSalutation.TotalRecords = lstPages[0].TotalRecords;
                                    objSalutation.AllowableRecordCount = lstPages[0].AllowableRecordCount;
                                }

                            }

                            actionResult = Ok(objSalutation);
                        }
                        else
                        {
                            actionResult = Ok("Result not Found");
                        }
                        #endregion Salutation
                        #region URNTypes
                        if (lstURNTypesData.Count > 0 && lstURNTypesData != null)
                        {
                            for (int i = 0; i < lstURNTypesData.Count(); i++)
                            {
                                lstURNTypesDatas = new List<URNTypesData>();

                                foreach (URNTypesData item in lstURNTypesData)
                                {
                                    objURNTypesData = new URNTypesData();


                                    objURNTypesData.URNTypeId = item.URNTypeId;
                                    objURNTypesData.URNType = item.URNType;



                                    lstURNTypesDatas.Add(objURNTypesData);

                                }
                                objURNTypes.OrgCode = OrgCode;
                                objURNTypes.URNTypesListInfo = lstURNTypesDatas;

                                if (lstPages != null && lstPages.Count > 0)
                                {
                                    objURNTypes.TotalPages = lstPages[0].TotalPages;
                                    objURNTypes.TotalRecords = lstPages[0].TotalRecords;
                                    objURNTypes.AllowableRecordCount = lstPages[0].AllowableRecordCount;
                                }

                            }

                            actionResult = Ok(objURNTypes);
                        }
                        else
                        {
                            actionResult = Ok("Result not Found");
                        }
                        #endregion URNTypes
                        #region Location
                        if (lstLocationData.Count > 0 && lstLocationData != null)
                        {
                            for (int i = 0; i < lstLocationData.Count(); i++)
                            {
                                lstLocationDatas = new List<LocationData>();

                                foreach (LocationData item in lstLocationData)
                                {
                                    objLocationData = new LocationData();


                                    objLocationData.LocationID = item.LocationID;
                                    objLocationData.LocationName = item.LocationName;
                                    objLocationData.IsProcessingLocationYN = item.IsProcessingLocationYN;
                                    objLocationData.CollectionCenterYN = item.CollectionCenterYN;

                                    lstLocationDatas.Add(objLocationData);

                                }
                                objLocation.OrgCode = OrgCode;
                                objLocation.LocationListInfo = lstLocationDatas;

                                if (lstPages != null && lstPages.Count > 0)
                                {
                                    objLocation.TotalPages = lstPages[0].TotalPages;
                                    objLocation.TotalRecords = lstPages[0].TotalRecords;
                                    objLocation.AllowableRecordCount = lstPages[0].AllowableRecordCount;
                                }

                            }

                            actionResult = Ok(objLocation);
                        }
                        else
                        {
                            actionResult = Ok("Result not Found");
                        }
                        #endregion Location
                        if (lstGenderDatas != null && lstLocationDatas != null && lstSalutationDatas != null && lstStateDatas != null && lstURNTypesDatas != null
                            && lstCountryDatas != null)
                        {
                            objMasterData = new MasterData();
                            if (lstGenderDatas.Count > 0 && lstGenderDatas != null)
                            {

                                objMasterData.GenderListInfo = lstGenderDatas;
                            }
                            if (lstLocationDatas.Count > 0 && lstLocationDatas != null)
                            {
                                objMasterData.LocationListInfo = lstLocationDatas;
                            }
                            if (lstSalutationDatas.Count > 0 && lstSalutationDatas != null)
                            {
                                objMasterData.SalutationListInfo = lstSalutationDatas;
                            }
                            if (lstStateDatas.Count > 0 && lstStateDatas != null)
                            {
                                objMasterData.StateListInfo = lstStateDatas;
                            }
                            if (lstURNTypesDatas.Count > 0 && lstURNTypesDatas != null)
                            {
                                objMasterData.URNTypesListInfo = lstURNTypesDatas;
                            }
                            if (lstCountryDatas.Count > 0 && lstCountryDatas != null)
                            {
                                objMasterData.CountryListInfo = lstCountryDatas;
                            }


                            lstMasterData = new List<MasterData>();
                            lstMasterData.Add(objMasterData);

                            if (lstMasterData.Count > 0 && lstMasterData != null)
                            {
                                objMasterDataDetails = new MasterDataDetails();
                                objMasterDataDetails.OrgCode = OrgCode;
                                objMasterDataDetails.MasterListInfo = lstMasterData;

                                if (lstPages != null && lstPages.Count > 0)
                                {
                                    objMasterDataDetails.TotalPages = lstPages[0].TotalPages;
                                    objMasterDataDetails.TotalRecords = lstPages[0].TotalRecords;
                                    objMasterDataDetails.AllowableRecordCount = lstPages[0].AllowableRecordCount;
                                }



                                actionResult = Ok(objMasterDataDetails);
                            }
                        }
                        else
                        {
                            actionResult = Ok("Result not Found");
                        }
                    }
                    #endregion All
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

        #endregion MastersData
    }
}
