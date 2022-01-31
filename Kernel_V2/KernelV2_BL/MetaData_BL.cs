using System;
using System.Collections.Generic;
using Attune.KernelV2.CacheEngine;
using Attune.KernelV2.DAL;
using Attune.KernelV2.Entities;
using Attune.KernelV2.Utilities;
using System.Linq;

namespace Attune.KernelV2.BL
{
    public class MetaData_BL : IDisposable
    {
        UI_ContextDetails globalContextDetails;

        public MetaData_BL(UI_ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        #region MetaData
        public List<UI_MetaData> GetMetaData(string pDomain, int OrgID, string LanguageCode)
        {
            Utility objUtilities = new Utility();
            string KeyValue;
            objUtilities.GetApplicationValue("MetaDataCache", out KeyValue);
            List<UI_MetaData> lstMetaData;
            if (KeyValue.ToUpper() == "Y")
            {
                CacheProvider _cp = new CacheProvider(1);
                string pKey = _cp.GetKey(CacheKey.MetaDataCache, OrgID);
                if (_cp.IsInCache(pKey))
                {
                    lstMetaData = _cp.Get<List<UI_MetaData>>(pKey);
                }
                else
                {
                    using (MetaData_DAL DAL = new MetaData_DAL(globalContextDetails))
                    {
                        lstMetaData = DAL.LoadMetaDataOrgMapping("", OrgID, LanguageCode);
                    }
                    if (lstMetaData.Count > 0)
                    {
                        _cp.Set(pKey, lstMetaData);
                    }
                }
                return lstMetaData.FindAll(p => p.Domain.ToUpper() == pDomain.ToUpper() && (p.LangCode = String.IsNullOrEmpty(p.LangCode) ? "en-GB" : p.LangCode) == LanguageCode);
            }

            using (MetaData_DAL DAL = new MetaData_DAL(globalContextDetails))
            {
                return DAL.LoadMetaDataOrgMapping(pDomain, OrgID, LanguageCode);
            }
        }

        public List<UI_MetaValues> GetMetaValues(string type, int OrgID)
        {
            Utility objUtilities = new Utility();
            string KeyValue;
            objUtilities.GetApplicationValue("MetaValueCache", out KeyValue);
            if (KeyValue.ToUpper() == "Y")
            {
                CacheProvider _cp = new CacheProvider(1);
                string pKey = _cp.GetKey(CacheKey.MetaValueCache, OrgID);
                List<UI_MetaValues> lstMetaValues;
                if (_cp.IsInCache(pKey))
                {
                    lstMetaValues = _cp.Get<List<UI_MetaValues>>(pKey);
                }
                else
                {
                    using (MetaData_DAL DAL = new MetaData_DAL(globalContextDetails))
                    {
                        lstMetaValues = DAL.GetMetaValues(OrgID);
                    }
                    if (lstMetaValues.Count > 0)
                    {
                        _cp.Set(pKey, lstMetaValues);
                    }
                }
                return lstMetaValues.FindAll(p => p.Type == type);
            }

            using (MetaData_DAL DAL = new MetaData_DAL(globalContextDetails))
            {
                return DAL.GetMetaValues(OrgID).FindAll(p => p.Type == type);
            }
        }
        #endregion

        #region Locality
        public List<UI_Country> GetCountryList()
        {
            Utility objUtilities = new Utility();
            string KeyValue;
            objUtilities.GetApplicationValue("CountryCache", out KeyValue);
            List<UI_Country> lstCountry;
            if (KeyValue.ToUpper() == "Y")
            {
                CacheProvider _cp = new CacheProvider(0);
                string pKey = _cp.GetKey(CacheKey.CountryCache, 0);
                if (_cp.IsInCache(pKey))
                {
                    lstCountry = _cp.Get<List<UI_Country>>(pKey);
                }
                else
                {
                    using (MetaData_DAL DAL = new MetaData_DAL(globalContextDetails))
                    {
                        lstCountry = DAL.GetCountryList();
                    }
                    if (lstCountry.Count > 0)
                    {
                        _cp.Set(pKey, lstCountry);
                    }
                }
                return lstCountry;
            }

            using (MetaData_DAL DAL = new MetaData_DAL(globalContextDetails))
            {
                return DAL.GetCountryList();
            }
        }

        public List<UI_State> GetStateByCountry(Int16 CountryId)
        {
            Utility objUtilities = new Utility();
            string KeyValue;
            objUtilities.GetApplicationValue("StateCache", out KeyValue);
            if (KeyValue.ToUpper() == "Y")
            {
                CacheProvider _cp = new CacheProvider(0);
                string pKey = _cp.GetKey(CacheKey.StateCache, 0);
                List<UI_State> lstState;
                if (_cp.IsInCache(pKey))
                {
                    lstState = _cp.Get<List<UI_State>>(pKey);
                }
                else
                {
                    using (MetaData_DAL DAL = new MetaData_DAL(globalContextDetails))
                    {
                        lstState = DAL.GetStateByCountry(0);
                    }
                    if (lstState.Count > 0)
                    {
                        _cp.Set(pKey, lstState);
                    }
                }
                return lstState.FindAll(p => p.CountryID == CountryId);
            }

            using (MetaData_DAL DAL = new MetaData_DAL(globalContextDetails))
            {
                return DAL.GetStateByCountry(CountryId);
            }
        }

        public List<UI_Address> GetPincodeDetails(long Pincode, int OrgID)
        {
            List<UI_Address> lstAddress;
            using (MetaData_DAL DAL = new MetaData_DAL(globalContextDetails))
            {
                lstAddress = DAL.GetPincodeDetails(Pincode, OrgID);
            }

            return lstAddress;
        }
        #endregion

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }


}
