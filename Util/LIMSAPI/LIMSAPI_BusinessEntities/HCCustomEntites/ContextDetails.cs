using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class ContextDetails
    {

        #region Properties

        public string LanguageCode { get; set; }
        public int OrgID { get; set; }
        public string LogoPath { get; set; }
        public long OrgAddressID { get; set; }
        public int LocationID { get; set; }
        public string Age { get; set; }
        public int InventoryLocationID { get; set; }
        public long PharmacyLocationID { get; set; }
        public string IsTrustedOrg { get; set; }
        public string BaseCurrency { get; set; }
        public string CurrencyFormat { get; set; }
        public int RoleID { get; set; }
        public long CountryID { get; set; }
        public long StateID { get; set; }
        public int ThemeID { get; set; }
        public long LoginID { get; set; }
        public long UserID { get; set; }
        public long PageID { get; set; }
        public string RoleName { get; set; }
        public string OrgName { get; set; }
        public string Name { get; set; }
        public string LoginName { get; set; }
        public string DepartmentName { get; set; }
        public string OrgCurrency { get; set; }
        public string OrgCurrencyFormat { get; set; }
        public string SessionID { get; set; }
        public string AdditionalInfo { get; set; }
        public string OrgTimeZone { get; set; }
        public string DepartmentCode { get; set; }
        public long LoggedUserID { get; set; }
        public string strvar { get; set; }
        #endregion
    }
}
