using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using Attune.Solution.DAL;
using Attune.Podium.BusinessEntities;
using Attune.Podium.Common;
using System.Collections;
using System.Text;
using System.Web;
using System.Collections.Specialized;
using System.Web.Caching;
using System.IO;
using System.Data.SqlClient;
using Attune.Kernel.CacheEngine;
using System.Linq;

namespace Attune.Solution.BusinessComponent
{
    public class MetaData_BL
    {
        ContextDetails globalContextDetails;
        public MetaData_BL()
        {

        }
        public MetaData_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long LoadMetaData(List<MetaData> lstmetadatainput, out  List<MetaData> lstOutMetaData)
        {
            long returnCode = -1;
           
            lstOutMetaData = new List<MetaData>();
                      
            try
            {
                MetaData_DAL titleDAL = new  MetaData_DAL(globalContextDetails);
                returnCode = titleDAL.LoadMetaData(lstmetadatainput, out lstOutMetaData);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetMarital status", excp);
            }
            return returnCode;

        }

        
         public long LoadMetaData_New(List<MetaData> lstDomain, string LangCode, out List<MetaData> lstMetaData)
        {
            long returnCode = -1;
            lstMetaData = new List<MetaData>();
            string Code = string.Empty;
            
           
            string MetaDataValue = string.Empty;
            try
            {
                LoadMetaDataOrgMapping(lstDomain, globalContextDetails.OrgID, LangCode, out lstMetaData);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetBillConfigDetails BL", ex);
            }
            return returnCode;
        }
         public long LoadMetaDataOrgMapping(List<MetaData> lstDomain, long OrgID, string LangCode, out List<MetaData> lstMetaData)
         {
             long returnCode = -1;
             lstMetaData = new List<MetaData>();
             List<MetaData> gMetaData = null;

             try
             {

                 Utilities objUtilities = new Utilities();
                 string KeyValue = string.Empty;
                 objUtilities.GetApplicationValue("MetaDataCache", out KeyValue);
                 if (!string.IsNullOrEmpty(KeyValue) && KeyValue == "Y")
                 {
                     CacheProvider _cp = new CacheProvider(1);
                     string pkey = _cp.getKey(AttCacheKey.MetaDataCache, (int)OrgID);
                     if (_cp.IsInCache(pkey))
                     {
                         gMetaData = _cp.Get<List<MetaData>>(pkey);
                     }
                     else
                     {
                         globalContextDetails.AdditionalInfo = "Y";
                         returnCode = new MetaData_DAL(globalContextDetails).LoadMetaDataOrgMapping(lstDomain, OrgID, LangCode, out gMetaData);
                         if (gMetaData != null && gMetaData.Count > 0)
                         {
                             _cp.Set(pkey, gMetaData);
                         }
                     }

                     lstMetaData = (from t in gMetaData
                                    join d in lstDomain on t.Domain equals d.Domain
                                    where t.LangCode == LangCode
                                    select t
                                    ).ToList();
                     returnCode = 0;
                 }
                 else
                 {
                     returnCode = new MetaData_DAL(globalContextDetails).LoadMetaDataOrgMapping(lstDomain, OrgID, LangCode, out lstMetaData);
                 }

             }
             catch (Exception ex)
             {
                 CLogger.LogError("Error while loading metadataorgmapping", ex);
             }
             return returnCode;
         }
public long pInsertMetaData(MetaData objMetaData, out long returnCode)
        {
            returnCode = -1;
            MetaData_DAL metaDAL = new MetaData_DAL(globalContextDetails);
            try
            {
                returnCode = metaDAL.pInsertMetaData(objMetaData, out returnCode);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pInsertMetaData MetaData_BL", ex);
            }
            return returnCode;
        }

        public long LoadMetaData(out List<MetaData> lstMetaData, out List<LanguageMaster> lstLanguageMaster)
        {
            long returnCode = -1;
            lstMetaData = new List<MetaData>();
            lstLanguageMaster = new List<LanguageMaster>();
            MetaData_DAL objDAL = new MetaData_DAL(globalContextDetails);

            try
            {
                returnCode = objDAL.LoadMetaData(out lstMetaData, out lstLanguageMaster);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing LoadMetaData Meta_BL", excp);
            }
            return returnCode;
        }

    }
}
