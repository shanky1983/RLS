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
    public class MetaData_DAL : IDisposable
    {
        UI_ContextDetails globalContextDetails;

        public MetaData_DAL(UI_ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        public List<UI_Country> GetCountryList()
        {
            List<UI_Country> lstCountry = null;

            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pGetCountryListLis_V2Command();
                DbDataReader dataReader = gateWay.ExecuteReader(cmd);
                if (dataReader != null)
                {
                    lstCountry = Utility.Tolist<UI_Country>(dataReader).ToList();
                }
            }
            return lstCountry;
        }

        public List<UI_State> GetStateByCountry(Int16 CountryId)
        {
            List<UI_State> lstState = null;

            using (DbHelper gateWay = new DbHelper())
            {

                var cmd = KernelV2_Command.pGetStateByCountryLis_V2Command(CountryId);
                DbDataReader dataReader = gateWay.ExecuteReader(cmd);
                if (dataReader != null)
                {
                    lstState = Utility.Tolist<UI_State>(dataReader).ToList();
                }
            }
            return lstState;
        }

        public List<UI_Address> GetPincodeDetails(long Pincode, int OrgID)
        {
            List<UI_Address> lstAddress = null;

            using (DbHelper gateWay = new DbHelper())
            {

                var cmd = KernelV2_Command.pGetPincodeDetails_V2Command(Pincode, OrgID, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                DbDataReader dataReader = gateWay.ExecuteReader(cmd);
                if (dataReader != null)
                {
                    lstAddress = Utility.Tolist<UI_Address>(dataReader).ToList();
                }
            }
            return lstAddress;
        }

        public List<UI_MetaData> LoadMetaDataOrgMapping(string pDomain, long pOrgID, string pLangCode)
        {
            List<UI_MetaData> lstMetaData = null;


            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pLoadMetaDataOrgMapping_V2Command(pDomain, pOrgID, pLangCode, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                DbDataReader dataReader = gateWay.ExecuteReader(cmd);
                if (dataReader != null)
                {
                    lstMetaData = Utility.Tolist<UI_MetaData>(dataReader).ToList();
                }
            }
            return lstMetaData;
        }

        public List<UI_MetaValues> GetMetaValues(int OrgID)
        {
            List<UI_MetaValues> lstMetaValues = null;

            using (DbHelper gateWay = new DbHelper())
            {

                var cmd = KernelV2_Command.pGetGroupValues_V2Command(OrgID, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                DbDataReader dataReader = gateWay.ExecuteReader(cmd);
                if (dataReader != null)
                {
                    lstMetaValues = Utility.Tolist<UI_MetaValues>(dataReader).ToList();
                }
            }
            return lstMetaValues;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

    }
}
