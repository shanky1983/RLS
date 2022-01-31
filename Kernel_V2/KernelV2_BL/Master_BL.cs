using System;
using System.Collections.Generic;
using System.Linq;
using Attune.KernelV2.CacheEngine;
using Attune.KernelV2.DAL;
using Attune.KernelV2.Entities;
using Attune.KernelV2.Utilities;

namespace Attune.KernelV2.BL
{
    public class Master_BL : IDisposable
    {
        UI_ContextDetails globalContextDetails;

        public Master_BL(UI_ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        #region Pages and Menu
        public MenuClass GetMenuItems(long RoleID, int OrgID)
        {
            MenuClass oMenuClass ;
            MenuClass oretMenuClass = new MenuClass();

            Utility objUtilities = new Utility();
            string KeyValue;
            objUtilities.GetApplicationValue("MenuCache", out KeyValue);
            if (!string.IsNullOrEmpty(KeyValue) && KeyValue == "Y")
            {
                CacheProvider _cp = new CacheProvider(1);
                string pkey = _cp.GetKey(CacheKey.MenuCache, OrgID);
                if (_cp.IsInCache(pkey))
                {
                    oMenuClass = _cp.Get<MenuClass>(pkey);
                }
                else
                {
                    using (Master_DAL KernelDAL = new Master_DAL(globalContextDetails))
                    {
                        oMenuClass = KernelDAL.GetAllMenuItems(OrgID, globalContextDetails.LanguageCode, 0, 0);
                        if (oMenuClass != null)
                            _cp.Set(pkey, oMenuClass);
                    }
                }

                if (oMenuClass != null)
                    oretMenuClass.lstMenu = oMenuClass.lstMenu.Where(p => p.RoleID == RoleID).ToList();
            }
            else
            {
                using (Master_DAL KernelDAL = new Master_DAL(globalContextDetails))
                {
                    oretMenuClass = KernelDAL.GetAllMenuItems(OrgID, globalContextDetails.LanguageCode, RoleID, 0);
                }
            }
            return oretMenuClass;
        }

        public UI_Alacarte GetLandingPage(long RoleID)
        {
            UI_Alacarte oAlacarte ;
            using (Master_DAL KernelDAL = new Master_DAL(globalContextDetails))
            {
                oAlacarte = KernelDAL.GetLandingPage(RoleID);

            }
            return oAlacarte;
        }

        public List<UI_Alacarte> GetAllMenuItems(int OrgID, string LangCode, long RoleID, int InvLocationType)
        {

            List<UI_Alacarte> lstMainMenu = null;

            MenuClass lstMenu = GetMenuItems(RoleID, OrgID);

            if (lstMenu != null && lstMenu.lstMenu.Count() > 0)
            {
                lstMainMenu = (from c in lstMenu.lstMenu
                               where c.OrgId == OrgID && c.LanguageCode == LangCode && c.RoleID == RoleID
                               orderby c.ParentID
                               group c by new { c.HeaderText, c.HeaderCode, c.ParentID, c.CssClass, c.faClass } into d
                               select new UI_Alacarte { HeaderText = d.Key.HeaderText, ParentID = d.Key.ParentID, HeaderCode = d.Key.HeaderCode, CssClass = d.Key.CssClass, faClass = d.Key.faClass }).ToList();

                if (lstMainMenu.Any())
                {

                    lstMainMenu.ForEach(o => o.SubMenu = (from c in lstMenu.lstMenu
                                                          where c.OrgId == OrgID && c.LanguageCode == LangCode
                                                          && c.ParentID == o.ParentID && c.RoleID == RoleID
                                                          orderby c.MenuName
                                                          select new UI_Alacarte
                                                          {
                                                              CssClass = c.CssClass,
                                                              HeaderCode = c.HeaderCode,
                                                              HeaderText = c.HeaderText,
                                                              MenuURL = c.MenuURL,
                                                              LanguageCode = c.LanguageCode,
                                                              MenuID = c.MenuID,
                                                              MenuName = c.MenuName == null ? null : c.MenuName,
                                                              OrgId = c.OrgId,
                                                              PageID = c.PageID,
                                                              ParentID = c.ParentID,
                                                              RoleID = c.RoleID,
                                                              SubMenu = c.SubMenu,
                                                              SequenceId = c.SequenceId,
                                                              TemplateUrl = c.TemplateUrl,
                                                              Controller = c.Controller,
                                                              faClass = c.faClass,
                                                              IsMenu = c.IsMenu,
                                                              Dependencies = c.Dependencies
                                                          }).ToList());



                }
            }

            return lstMainMenu;
        }
        #endregion

        #region PaymentType
        public List<UI_PaymentType> GetPaymentType(int OrgID)
        {
            List<UI_PaymentType> lstPaymentType ;
            using (Master_DAL DAL = new Master_DAL(globalContextDetails))
            {
                lstPaymentType = DAL.GetPaymentType(OrgID);
            }
            return lstPaymentType;
        }
        #endregion

        #region Salutation
        public List<UI_Salutation> GetSalutation(int OrgID, string LanguageCode)
        {
            Utility objUtilities = new Utility();
            string KeyValue;
            objUtilities.GetApplicationValue("SalutationCache", out KeyValue);
            List<UI_Salutation> lstSalutation ;
            if (KeyValue.ToUpper() == "Y")
            {
                CacheProvider _cp = new CacheProvider(1);
                string pKey = _cp.GetKey(CacheKey.SalutationCache, OrgID);
                if (_cp.IsInCache(pKey))
                {
                    lstSalutation = _cp.Get<List<UI_Salutation>>(pKey);
                }
                else
                {
                    using (Master_DAL DAL = new Master_DAL(globalContextDetails))
                    {
                        lstSalutation = DAL.GetSalutation(OrgID, LanguageCode);
                    }
                    if (lstSalutation.Count > 0)
                    {
                        _cp.Set(pKey, lstSalutation);
                    }
                }
                return lstSalutation;
            }

            using (Master_DAL DAL = new Master_DAL(globalContextDetails))
            {
                return DAL.GetSalutation(OrgID, LanguageCode);
            }
        }
        #endregion

        #region Species
        public List<UI_Species> GetSpecies(int OrgID)
        {
            List<UI_Species> lstSpecies ;
            using (Master_DAL DAL = new Master_DAL(globalContextDetails))
            {
                lstSpecies = DAL.GetSpecies(OrgID);
            }
            return lstSpecies;
        }
        #endregion

        #region URN
        public UI_URN GetURN()
        {
            UI_URN objURN ;
            using (Master_DAL DAL = new Master_DAL(globalContextDetails))
            {
                objURN = DAL.GetURN();
            }
            return objURN;
        }
        #endregion

        #region CheckURN
        public List<UI_URNTypes> CheckURN(int UrnTypeId, string UrnNo)
        {
            List<UI_URNTypes> lstURN;
            using (Master_DAL DAL = new Master_DAL(globalContextDetails))
            {
                lstURN = DAL.CheckURN(UrnTypeId, UrnNo);
            }
            return lstURN;
        }
        #endregion

        #region Phlebotomist & Logistics
        public List<UI_Department> GetPhlebotomist(string SearchText, string Type, int OrgID)
        {
            List<UI_Department> lstDepartment ;
            using (Master_DAL DAL = new Master_DAL(globalContextDetails))
            {
                lstDepartment = DAL.GetPhlebotomist(SearchText, Type, OrgID);
            }
            return lstDepartment;
        }
        #endregion

        #region Discount
        public List<UI_Discount> GetDiscount(int OrgID)
        {
            List<UI_Discount> lstDiscount ;
            using (Master_DAL DAL = new Master_DAL(globalContextDetails))
            {
                lstDiscount = DAL.GetDiscount(OrgID);
            }
            return lstDiscount;
        }
        #endregion

        #region DiscountReason
        public List<UI_DiscountReason> GetDiscountReason(Int16 ReasonCategoryID, int ReasonTypeID, string ReasonCode)
        {
            List<UI_DiscountReason> lstDiscountReason ;
            using (Master_DAL DAL = new Master_DAL(globalContextDetails))
            {
                lstDiscountReason = DAL.GetDiscountReason(ReasonCategoryID, ReasonTypeID, ReasonCode);
            }
            return lstDiscountReason;
        }
        #endregion

        #region DiscountApprovedBy
        public List<UI_DiscoiuntApproved> GetDiscountApprovedBy(string Name, int OrgID, string Type)
        {
            List<UI_DiscoiuntApproved> lstDiscoiuntApproved ;
            using (Master_DAL DAL = new Master_DAL(globalContextDetails))
            {
                lstDiscoiuntApproved = DAL.GetDiscountApprovedBy(Name, OrgID, Type);

                lstDiscoiuntApproved=(from S in lstDiscoiuntApproved
                                      group S by new { S.Name, S.LoginID } into g
                 select new UI_DiscoiuntApproved
                 {
                     Name = g.Key.Name,
                     LoginID = g.Key.LoginID,
                 }).Distinct().ToList();
            }
            return lstDiscoiuntApproved;
        }
        #endregion

        #region Tax
        public List<UI_Tax> GetTax(int OrgID)
        {
            List<UI_Tax> lstTax ;
            using (Master_DAL DAL = new Master_DAL(globalContextDetails))
            {
                lstTax = DAL.GetTax(OrgID);
            }
            return lstTax;
        }
        #endregion

        #region GetOrgCurrency
        public List<UI_OrgCurrency> GetOrgCurrency(int OrgID)
        {
            List<UI_OrgCurrency> lstOrgCurrency ;
            using (Master_DAL DAL = new Master_DAL(globalContextDetails))
            {
                lstOrgCurrency = DAL.GetOrgCurrency(OrgID);
            }
            return lstOrgCurrency;
        }
        #endregion

        #region GetPaymentDetails
        public UI_PaymentDetails GetPaymentDetails(int OrgID)
        {
            UI_PaymentDetails objPaymentDetails = new UI_PaymentDetails();
            objPaymentDetails.PaymentType = GetPaymentType(OrgID);
            objPaymentDetails.Currency = GetOrgCurrency(OrgID);
            return objPaymentDetails;
        }
        #endregion

        #region GetBankName
        public List<UI_Bank> GetBankName(string SearchText, int OrgID)
        {
            List<UI_Bank> lstBank ;
            using (Master_DAL DAL = new Master_DAL(globalContextDetails))
            {
                lstBank = DAL.GetBankName(SearchText, OrgID);
            }
            return lstBank;
        }
        #endregion

        #region GetCoupon
        public List<UI_Coupon> GetCoupon(string SearchText, int OrgID)
        {
            List<UI_Coupon> lstCoupon ;
            using (Master_DAL DAL = new Master_DAL(globalContextDetails))
            {
                lstCoupon = DAL.GetCoupon(SearchText, OrgID);
            }
            return lstCoupon;
        }
        #endregion

        #region GetConfig
        public string GetConfigDetails(string Configkey, int OrgID)
        {

            List<UI_Config> lstConfig;
            string ConfigValue=string.Empty;

            Utility objUtilities = new Utility();
            string KeyValue;
            objUtilities.GetApplicationValue("ConfigCache", out KeyValue);
            if (!string.IsNullOrEmpty(KeyValue) && KeyValue == "Y")
            {
                CacheProvider _cp = new CacheProvider(1);
                string pkey = _cp.GetKey(CacheKey.ConfigCache, OrgID);
                if (_cp.IsInCache(pkey))
                {
                    lstConfig = _cp.Get<List<UI_Config>>(pkey);
                }
                else
                {
                    using (Master_DAL Dal = new Master_DAL(globalContextDetails))
                    {
                        lstConfig = Dal.GetConfigDetails("", OrgID);
                    }
                    if (lstConfig != null && lstConfig.Count > 0)
                    {
                        _cp.Set(pkey, lstConfig);
                    }
                }
                
            }
            else
            {
                using (Master_DAL Dal = new Master_DAL(globalContextDetails))
                {
                    lstConfig = Dal.GetConfigDetails(Configkey, OrgID);
                }
            }

            if (lstConfig != null && lstConfig.Count > 0)
            {
                var pVal = lstConfig.Find(p => p.ConfigKey == Configkey);
                if (pVal != null)
                {
                    ConfigValue = pVal.ConfigValue;
                }
            }
            return ConfigValue;
        }
        #endregion

        public List<UI_Complaint> GetComplaint(string SearchText)
        {
            List<UI_Complaint> lstComplaint =null;
            using (Master_DAL DAL = new Master_DAL(globalContextDetails))
            {
                lstComplaint = DAL.GetComplaint(SearchText);
            }
            return lstComplaint;
        }



        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}

