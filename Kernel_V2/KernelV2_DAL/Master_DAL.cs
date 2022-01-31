using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using Attune.KernelV2.Cmd;
using Attune.KernelV2.DataAccessEngine;
using Attune.KernelV2.Entities;
using Attune.KernelV2.UDT;
using Attune.KernelV2.Utilities;

namespace Attune.KernelV2.DAL
{
    public class Master_DAL : IDisposable
    {
        UI_ContextDetails globalContextDetails;

        public Master_DAL(UI_ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        #region Pages and Menu
        public MenuClass GetAllMenuItems(long orgID, string langCode, long roleID, int locationType)
        {
            MenuClass lstMenuClass = new MenuClass();

            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pGetAllMenuItems_V2Command(orgID, langCode, roleID, locationType, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                DbDataReader reader = gateWay.ExecuteReader(cmd);
                lstMenuClass.lstMenu = Utility.Tolist<UI_Alacarte>(reader).ToList();
                if (reader.NextResult())
                {
                    lstMenuClass.lstInvPageMap = Utility.Tolist<UI_InventoryPageMap>(reader).ToList();
                }

            }
            return lstMenuClass;
        }

        public UI_Alacarte GetLandingPage(long roleID)
        {
            UI_Alacarte oAlacarte;
            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pGetLandingPage_V2Command(roleID, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                DbDataReader reader = gateWay.ExecuteReader(cmd);
                oAlacarte = Utility.ToObject<UI_Alacarte>(reader);

            }
            return oAlacarte;
        }
        #endregion

        #region PaymentType
        public List<UI_PaymentType> GetPaymentType(int OrgID)
        {
            List<UI_PaymentType> lstPaymentType = null;

            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pGetPaymentType_V2Command(OrgID, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                DbDataReader dataReader = gateWay.ExecuteReader(cmd);
                if (dataReader != null)
                {
                    lstPaymentType = Utility.Tolist<UI_PaymentType>(dataReader).ToList();
                }
            }
            return lstPaymentType;
        }
        #endregion

        #region Salutation
        public List<UI_Salutation> GetSalutation(int OrgID, string LanguageCode)
        {
            List<UI_Salutation> lstSalutation = null;

            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pGetSalutation_V2Command(OrgID, LanguageCode, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                DbDataReader dataReader = gateWay.ExecuteReader(cmd);
                if (dataReader != null)
                {
                    lstSalutation = Utility.Tolist<UI_Salutation>(dataReader).ToList();
                }
            }
            return lstSalutation;
        }
        #endregion

        #region Species
        public List<UI_Species> GetSpecies(int OrgID)
        {
            List<UI_Species> lstSpecies = null;

            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pGetSpecies_V2Command(OrgID, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                DbDataReader dataReader = gateWay.ExecuteReader(cmd);
                if (dataReader != null)
                {
                    lstSpecies = Utility.Tolist<UI_Species>(dataReader).ToList();
                }
            }
            return lstSpecies;
        }
        #endregion

        #region URN
        public UI_URN GetURN()
        {
            UI_URN objURN = new UI_URN();

            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pGetURNType_V2Command(KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                DbDataReader dataReader = gateWay.ExecuteReader(cmd);
                if (dataReader != null)
                {
                    objURN.lstURNTypes = Utility.Tolist<UI_URNTypes>(dataReader).ToList();
                    if (dataReader.NextResult())
                    {
                        objURN.lstURNof = Utility.Tolist<UI_URNof>(dataReader).ToList();
                    }
                }
            }
            return objURN;
        }
        #endregion

        #region CheckURN
        public List<UI_URNTypes> CheckURN(int UrnTypeId, string UrnNo)
        {
            List<UI_URNTypes> lstURN = new List<UI_URNTypes>();

            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pGetURN_V2Command(UrnTypeId, UrnNo,KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                DbDataReader dataReader = gateWay.ExecuteReader(cmd);
                if (dataReader != null)
                {
                    lstURN = Utility.Tolist<UI_URNTypes>(dataReader).ToList();                     
                }
            }
            return lstURN;
        }
        #endregion

        #region Phlebotomist & Logistics
        public List<UI_Department> GetPhlebotomist(string searchText, string type, int OrgID)
        {
            List<UI_Department> lstDepartment = null;

            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pGetEmployee_V2Command(OrgID, searchText, type, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                DbDataReader dataReader = gateWay.ExecuteReader(cmd);
                if (dataReader != null)
                {
                    lstDepartment = Utility.Tolist<UI_Department>(dataReader).ToList();
                }
            }
            return lstDepartment;
        }
        #endregion

        #region Discount
        public List<UI_Discount> GetDiscount(int OrgID)
        {
            List<UI_Discount> lstDiscount = null;

            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pGetLabDiscountLis_V2Command(OrgID, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                DbDataReader dataReader = gateWay.ExecuteReader(cmd);
                if (dataReader != null)
                {
                    lstDiscount = Utility.Tolist<UI_Discount>(dataReader).ToList();
                }
            }
            return lstDiscount;
        }
        #endregion

        #region DiscountReason
        public List<UI_DiscountReason> GetDiscountReason(Int16 pReasonCategoryID, int pReasonTypeID, string pReasonCode)
        {
            List<UI_DiscountReason> lstDiscountReason = null;

            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pGetReasonMaster_V2Command(pReasonCategoryID, pReasonTypeID, pReasonCode, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                DbDataReader dataReader = gateWay.ExecuteReader(cmd);
                if (dataReader != null)
                {
                    lstDiscountReason = Utility.Tolist<UI_DiscountReason>(dataReader).ToList();
                }
            }
            return lstDiscountReason;
        }
        #endregion

        #region DiscountApprovedBy
        public List<UI_DiscoiuntApproved> GetDiscountApprovedBy(string Name, int OrgID, string Type)
        {
            List<UI_DiscoiuntApproved> lstDiscoiuntApproved = null;
            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pGetUserNameWithLoginIDLis_V2Command(Name, OrgID, Type, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                DbDataReader dataReader = gateWay.ExecuteReader(cmd);
                if (dataReader != null)
                {
                    lstDiscoiuntApproved = Utility.Tolist<UI_DiscoiuntApproved>(dataReader).ToList();
                }
            }
            return lstDiscoiuntApproved;
        }
        #endregion

        #region Tax
        public List<UI_Tax> GetTax(int OrgID)
        {
            List<UI_Tax> lstTax = null;
            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pGetTaxMaster_V2Command(OrgID, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                DbDataReader dataReader = gateWay.ExecuteReader(cmd);
                if (dataReader != null)
                {
                    lstTax = Utility.Tolist<UI_Tax>(dataReader).ToList();
                }
            }
            return lstTax;
        }
        #endregion

        #region GetOrgCurrency
        public List<UI_OrgCurrency> GetOrgCurrency(int OrgID)
        {
            List<UI_OrgCurrency> lstOrgCurrency = null;

            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pGetOrgWiseCurrency_V2Command(OrgID, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                DbDataReader dataReader = gateWay.ExecuteReader(cmd);
                if (dataReader != null)
                {
                    lstOrgCurrency = Utility.Tolist<UI_OrgCurrency>(dataReader).ToList();
                }
            }
            return lstOrgCurrency;
        }
        #endregion

        #region GetBankName
        public List<UI_Bank> GetBankName(string pSearchText, int OrgID)
        {
            List<UI_Bank> lstBank = null;

            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pGetBankName_V2Command(pSearchText, OrgID, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                DbDataReader dataReader = gateWay.ExecuteReader(cmd);
                if (dataReader != null)
                {
                    lstBank = Utility.Tolist<UI_Bank>(dataReader).ToList();
                }
            }
            return lstBank;
        }
        #endregion

        #region GetCoupon
        public List<UI_Coupon> GetCoupon(string pSearchText, int OrgID)
        {
            List<UI_Coupon> lstCoupon=null;

            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pGetCoupons_V2Command(pSearchText, OrgID, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                DbDataReader dataReader = gateWay.ExecuteReader(cmd);
                if (dataReader != null)
                {
                    lstCoupon = Utility.Tolist<UI_Coupon>(dataReader).ToList();
                }
            }
            return lstCoupon;
        }
        #endregion


        
        public List<UI_Complaint> GetComplaint(string complaintName)
        {
           
            List<UI_Complaint>  complaints=null;
            using (DbHelper gateWay = new DbHelper())
            {
               var cmd = KernelV2_Command.pGetComplaintByNameIDCommand(complaintName, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));

                DbDataReader dataReader = gateWay.ExecuteReader(cmd);
                if (dataReader != null)
                {
                    complaints = Utility.Tolist<UI_Complaint>(dataReader).ToList();
                }

            }  
            return complaints;
        }
       
        public List<UI_Config> GetConfigDetails(string configkey, int orgID)
        {

            List<UI_Config> lstConfig = null;

            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pGetConfigDetails_V2Command(configkey, orgID, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                DbDataReader dataReader = gateWay.ExecuteReader(cmd);
                lstConfig = Utility.Tolist<UI_Config>(dataReader).ToList();
            }
            return lstConfig;

        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }


    }
}
