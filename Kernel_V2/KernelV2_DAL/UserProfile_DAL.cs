using System;
using System.Data.Common;
using System.Linq;
using Attune.KernelV2.Cmd;
using Attune.KernelV2.DataAccessEngine;
using Attune.KernelV2.Entities;
using Attune.KernelV2.UDT;
using Attune.KernelV2.Utilities;
using System.Net;

namespace Attune.KernelV2.DAL
{
    public class UserProfile_DAL : IDisposable
    {
        UI_ContextDetails globalContextDetails;

        public UserProfile_DAL()
        {

        }

        public UserProfile_DAL(UI_ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        public UI_ProfileInfo GetPrivilegeDetails(long LoginID, string LanguageCode)
        {
            UI_ProfileInfo objProfile = new UI_ProfileInfo();
            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pGetLoginInfo_V2Command(LoginID, LanguageCode, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                DbDataReader reader = gateWay.ExecuteReader(cmd);
                objProfile.UserProfile = Utility.ToObject<UI_Login>(reader);
                if (reader.NextResult())
                {
                    objProfile.Organization = Utility.Tolist<UI_Organization>(reader).ToList();
                }
                if (reader.NextResult())
                {
                    objProfile.Role = Utility.Tolist<UI_Role>(reader).ToList();
                }
                if (reader.NextResult())
                {
                    
                    objProfile.Location = Utility.Tolist<UI_Location>(reader).ToList();
                }
                if (reader.NextResult())
                {
                    objProfile.InvLocation = Utility.Tolist<UI_InvLocation>(reader).ToList();
                }
                if (reader.NextResult())
                {
                    objProfile.Department = Utility.Tolist<UI_Department>(reader).ToList();
                }

            }
            return objProfile;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
