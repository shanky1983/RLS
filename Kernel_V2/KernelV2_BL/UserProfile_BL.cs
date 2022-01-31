using System;
using Attune.KernelV2.DAL;
using Attune.KernelV2.Entities;

namespace Attune.KernelV2.BL
{
    public class UserProfile_BL : IDisposable
    {
        UI_ContextDetails globalContextDetails;

        public UserProfile_BL()
        {

        }

        public UserProfile_BL(UI_ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        public UI_ProfileInfo GetPrivilegeDetails(int OrgID, long LoginID, string LanguageCode)
        {
            UI_ProfileInfo ProfileInfo;
            using (UserProfile_DAL DAL = new UserProfile_DAL(globalContextDetails))
            {
                ProfileInfo = DAL.GetPrivilegeDetails(LoginID, LanguageCode);
                if (ProfileInfo != null)
                {
                    ProfileInfo.Organization.ForEach(p => p.SelectedOrgID = OrgID);
                    ProfileInfo.Role.ForEach(p => p.SelectedRoleID = globalContextDetails.RoleID);
                    ProfileInfo.Location.ForEach(p => p.SelectedAddressID = globalContextDetails.OrgAddressID);
                }
            }

            return ProfileInfo;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
