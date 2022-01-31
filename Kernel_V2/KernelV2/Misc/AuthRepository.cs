
using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;
using Attune.KernelV2.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
#pragma warning disable 1998

namespace Attune.KernelV2
{

    public class AuthRepository : IDisposable
    {
        private AuthContext _ctx;

        private UserManager<IdentityUser> _userManager;

        public AuthRepository()
        {
            _ctx = new AuthContext();
            _userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(_ctx));
        }



        public async Task<LoggedInUsers> FindUser(string UniqueKey, string str)
        {
            Guid newID = new Guid(UniqueKey);
            LoggedInUsers loggedinUser =  _ctx.LoggedInUsers.SingleOrDefault(o => o.UniqueKey == newID);
            return loggedinUser;
        }


        public UI_ContextDetails GetClientDtls(string uniqueKey)
        {
            UI_ContextDetails objUser = null;
            Guid newID = new Guid(uniqueKey);
            var client = _ctx.VendorOrgMapping.SingleOrDefault(o => o.UniqueKey == newID);
            if (client != null)
            {
               objUser = _ctx.VendorOrgAddressMapping.Where(o => o.VendorID == client.VendorID).Select(c => new UI_ContextDetails
                {
                    LoginID = c.LoginID ?? 0,
                    RoleID = c.RoleID ?? 0,
                    LanguageCode = "en-GB",
                    OrgID = Convert.ToInt32(client.AttuneOrgID),
                    InventoryLocationID = c.InvLocationID ?? 0,
                    LocationID = Convert.ToInt32(c.AttuneOrgAddressID),
                    OrgAddressID = Convert.ToInt32(c.AttuneOrgAddressID)

                }).FirstOrDefault();

            }
            return objUser;
        }

        public async Task<UI_ContextDetails> FindUser(string UniqueKey)
        {
            Guid newID = new Guid(UniqueKey);
            UI_ContextDetails loggedinUser = (from t in _ctx.LoggedInUsers
                                              join a in _ctx.organizationAddress on t.OrgAddressID equals a.AddressID
                                              join o in _ctx.organization on t.OrgID equals o.OrgID
                                              where a.OrgID == t.OrgID && t.UniqueKey == newID
                                              select new UI_ContextDetails
                                              {
                                                  OrgName=o.OrgDisplayName,
                                                 LoginID = t.LoginID,
                                                 RoleID = t.RoleID ?? 0,
                                                 LanguageCode = "en-GB",
                                                 OrgID = t.OrgID ?? 0,
                                                 InventoryLocationID = t.InventoryLocationID ?? 0,
                                                 LocationID = t.OrgAddressID,
                                                 OrgAddressID = t.OrgAddressID,
                                                 CountryID = a.CountryID ?? 0,
                                                 StateID = a.StateID ?? 0
                                             }).FirstOrDefault();
            return loggedinUser;
        }

        public async Task<LoggedInUsers> FindUser(string username,string password,string ipadd,string browser, string rolename)
        {
            LoggedInUsers oLoggedInUsers;

            login ologin = _ctx.login.FirstOrDefault(p=>p.LoginName== username && p.Password==password && p.Status != "D" &&p.IsLocked == "N");
            if (ologin == null) return null;
            {
                oLoggedInUsers = new LoggedInUsers();
                var oLoggedInProfile = new LoggedInProfile();

                IEnumerable<LoggedInUsers> lstUsers = _ctx.LoggedInUsers.Where(p => p.LoginID == ologin.loginID && p.LoginType=="I");
                _ctx.LoggedInUsers.RemoveRange(lstUsers);

                var lstLoginRole = (from l in _ctx.LoginRole
                    join r in _ctx.Role on l.RoleID equals r.RoleID
                    where l.LoginID == ologin.loginID && r.RoleName== (rolename == "" ? r.RoleName: rolename)
                    select new {l.RoleID,l.LoginID,l.IsDefault,r.OrgID}).ToList();

               
                if(lstLoginRole.Any())
                {
                    var role = lstLoginRole.FirstOrDefault(p => p.IsDefault);
                    oLoggedInUsers.RoleID =(int)(role == null ? lstLoginRole[0].RoleID : role.RoleID) ;
                    oLoggedInUsers.OrgID = (int)(role == null ? lstLoginRole[0].OrgID : role.OrgID);
                }
                else
                {
                    return null;
                }


                IList<LocationUserMap> lstLocationUserMap = _ctx.LocationUserMap.Where(p => p.LoginID == ologin.loginID).ToList();
                if (lstLocationUserMap.Count > 0)
                {
                    var locationUserMap = lstLocationUserMap.FirstOrDefault(p => p.IsDefault == "Y");
                    oLoggedInUsers.InventoryLocationID = locationUserMap == null ? lstLocationUserMap[0].LocationID : locationUserMap.LocationID;
                }
 
                var pOrgAddress = _ctx.organizationAddress.FirstOrDefault(p => p.OrgID == ologin.OrgID);
                oLoggedInProfile.OrgAddressID = (int)(pOrgAddress == null ? 0 : pOrgAddress.AddressID);

                oLoggedInUsers.LoginID = ologin.loginID;
                oLoggedInUsers.CreatedAt = DateTime.Now;
                oLoggedInUsers.CreatedBy = ologin.loginID;
                oLoggedInUsers.LoginType = "I";
                oLoggedInUsers.UniqueKey = Guid.NewGuid();
                oLoggedInUsers.OrgAddressID = (int)(pOrgAddress == null ? 0 : pOrgAddress.AddressID);
                oLoggedInUsers = _ctx.LoggedInUsers.Add(oLoggedInUsers);

                oLoggedInProfile.OrgAddressID = (int)(pOrgAddress == null ? 0 : pOrgAddress.AddressID);
                oLoggedInProfile.BrowserName = browser;
                oLoggedInProfile.CreatedAt = DateTime.Now;
                oLoggedInProfile.CreatedBy = ologin.loginID;
                oLoggedInProfile.IPAddress = ipadd;
                oLoggedInProfile.LoggedInUsersID = oLoggedInUsers.ID;
                oLoggedInProfile.LoginID = ologin.loginID;
                oLoggedInProfile.OrgID = oLoggedInUsers.OrgID;
                oLoggedInProfile= _ctx.LoggedInProfile.Add(oLoggedInProfile);
                _ctx.SaveChanges();
         

                
            }
            return oLoggedInUsers;


        }

        public VendorOrgMapping FindClient(string AppName)
        {
            var vendor = _ctx.VendorMaster.Where(o => o.VendorName == AppName).FirstOrDefault();

            if (vendor != null)
            {
                var vendorMapping = _ctx.VendorOrgMapping.Where(o => o.VendorID == vendor.VendorID).FirstOrDefault();
                if (vendorMapping!=null)
                {
                    VendorOrgMapping orgMapping = new VendorOrgMapping
                    {
                        VendorID = vendorMapping.VendorID,
                        VendorMappingID = vendorMapping.VendorMappingID,
                        VendorOrgID = vendorMapping.VendorOrgID,
                        UniqueKey = vendorMapping.UniqueKey,
                        Status = vendorMapping.Status,
                        SessionTokenLifeTime = vendorMapping.SessionTokenLifeTime,
                        RefreshTokenLifeTime = vendorMapping.RefreshTokenLifeTime,
                        AllowedOrigin = vendorMapping.AllowedOrigin,
                        AppName = vendorMapping.AppName,
                        AttuneOrgID = vendorMapping.AttuneOrgID,
                        IntegrationTypeCode = vendorMapping.IntegrationTypeCode,
                        OrgName = vendorMapping.OrgName,
                        PartnerType = vendor.PartnerType,
                        RequiredRefreshToken = vendorMapping.RequiredRefreshToken,
                        RoleName= vendorMapping.RoleName
                    };
                    return orgMapping;
                }
                
            }
            return null;

        }

        public LoggedInUsers GetClientDtls(string uniqueKey,string str)
        {
            LoggedInUsers objUser = null;
            Guid newID = new Guid(uniqueKey);
            var client = _ctx.VendorOrgMapping.SingleOrDefault(o => o.UniqueKey == newID);
            if (client != null)
            {
                VendorOrgAddressMapping orgMapping = _ctx.VendorOrgAddressMapping.SingleOrDefault(o => o.VendorID == client.VendorID);
                if (orgMapping != null)
                    objUser = new LoggedInUsers
                    {
                        InventoryLocationID = orgMapping.InvLocationID ?? 0,
                        LoginID = orgMapping.LoginID ?? 0,
                        OrgID = Convert.ToInt32(client.AttuneOrgID),
                        OrgAddressID = Convert.ToInt32(orgMapping.AttuneOrgAddressID),
                        RoleID = orgMapping.RoleID ?? 0
                    };
            }
            return objUser;
        }

        public IntegrationTypeMaster FindApp(string AppName)
        {
            var appType = _ctx.IntegrationTypeMaster.SingleOrDefault(o => o.IntegrationTypeCode == AppName);
            return appType;
        }
        public async Task<bool> AddRefreshToken(RefreshTokens token)
        {

            var existingToken = _ctx.RefreshTokens.SingleOrDefault(r => r.Subject == token.Subject && r.ClientId == token.ClientId);

            if (existingToken != null)
            {
                await RemoveRefreshToken(existingToken);
            }

            _ctx.RefreshTokens.Add(token);

            return await _ctx.SaveChangesAsync() > 0;
        }

        public async Task<bool> RemoveRefreshToken(string refreshTokenId)
        {
            var refreshToken = await _ctx.RefreshTokens.FindAsync(refreshTokenId);

            if (refreshToken != null)
            {
                _ctx.RefreshTokens.Remove(refreshToken);
                return await _ctx.SaveChangesAsync() > 0;
            }


            return false;
        }

        private async Task<bool> RemoveRefreshToken(RefreshTokens refreshToken)
        {
            _ctx.RefreshTokens.Remove(refreshToken);
            return await _ctx.SaveChangesAsync() > 0;
        }

        public IList<VendorLocationMpping> GetLocation(string pKey)
        {
            IList<VendorLocationMpping> lst;
            Guid pUniqueKey = new Guid(pKey);
            lst = (from s in _ctx.VendorOrgMapping
                join v in _ctx.VendorOrgAddressMapping on s.VendorID equals v.VendorID
                join a in _ctx.organizationAddress on v.AttuneOrgAddressID equals a.AddressID
                join o in _ctx.organization on a.OrgID equals o.OrgID
                where s.UniqueKey == pUniqueKey
                select new VendorLocationMpping
                {
                    AttLocationId = v.AttGuId,
                    LocationName = o.OrgDisplayName + "-" + a.Location
                }).Distinct().ToList();
            return lst;
        }
        public bool updateProfile(UI_ContextDetails ContextDetails, int pOrgId, long pAddressID, long pRoleID)
        {

            try
            {
                var pContextDetails = _ctx.LoggedInUsers.SingleOrDefault(p => p.LoginID == ContextDetails.LoginID);
                if (pContextDetails != null)
                {
                    pContextDetails.OrgID = pOrgId;
                    pContextDetails.RoleID = (int) pRoleID;
                    pContextDetails.OrgAddressID = (int) pAddressID;
                    pContextDetails.ModifiedAt = DateTime.Now;
                }

                _ctx.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
            
        }

        public LoggedInUsers GetLocationById(Guid AttGuId)
        {
            var oContextDetails = new LoggedInUsers();

            var loc= (from c in _ctx.VendorOrgAddressMapping
                join o in _ctx.organizationAddress on c.AttuneOrgAddressID equals o.AddressID
                where c.AttGuId == AttGuId
                select new 
                {
                    c.AttuneOrgAddressID,
                    o.OrgID,
                    c.InvLocationID,
                    c.RoleID,
                    c.LoginID
                }).SingleOrDefault();

            if (loc == null) return oContextDetails;
            oContextDetails.OrgAddressID = (int)loc.AttuneOrgAddressID;
            oContextDetails.OrgID = loc.OrgID;
            oContextDetails.InventoryLocationID = loc.InvLocationID??0;
            oContextDetails.RoleID = loc.RoleID ?? 0;
            oContextDetails.LoginID = loc.LoginID ?? 0;

            return oContextDetails;
        }

        public async Task<RefreshTokens> FindRefreshToken(string refreshTokenId)
        {
            var refreshToken = await _ctx.RefreshTokens.FindAsync(refreshTokenId);

            return refreshToken;
        }

        public List<RefreshTokens> GetAllRefreshTokens()
        {
            return _ctx.RefreshTokens.ToList();
        }

        public async Task<IdentityUser> FindAsync(UserLoginInfo loginInfo)
        {
            IdentityUser user = await _userManager.FindAsync(loginInfo);

            return user;
        }

        public async Task<IdentityResult> CreateAsync(IdentityUser user)
        {
            var result = await _userManager.CreateAsync(user);

            return result;
        }

        public async Task<IdentityResult> AddLoginAsync(string userId, UserLoginInfo login)
        {
            var result = await _userManager.AddLoginAsync(userId, login);

            return result;
        }

        public void Dispose()
        {
            _ctx.Dispose();
            _userManager.Dispose();

        }
    }
}