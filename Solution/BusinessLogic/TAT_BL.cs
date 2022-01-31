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


namespace Attune.Solution.BusinessComponent
{
    public class TAT_BL
    {
         ContextDetails globalContextDetails;
         public TAT_BL()
        {

        }
         public TAT_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
         public long LoadMetaDataOrgMappingTAT(List<MetaData> lstDomain, long OrgID, string LangCode, out List<MetaData> lstMetaData)
        {
            long returnCode = -1;
            lstMetaData = new List<MetaData>();
            string Code = string.Empty;
            string Domain = "";
            LangCode = "";
            NameValueCollection objectcollection = new NameValueCollection();
            
            string MetaDataValue = string.Empty;
            try
            {
                returnCode = new  TAT_DAL(globalContextDetails).LoadMetaDataOrgMappingTAT(lstDomain, OrgID, LangCode, out objectcollection);

                if (objectcollection.HasKeys())
                {
                    //foreach (k key in objcollection.AllKeys) // 
                    //{
                    //    var temp = objcollection.AllKeys;
                    //  Console.WriteLine(key);"Gender_en-GB"
                    for (int j = 0; j <= objectcollection.AllKeys.Length - 1; j++)
                    {
                        string[] s = objectcollection.AllKeys[j].Split('~');

                        Domain = s[0].ToString();
                        //// sKey +=Code.ToString()+'_';
                        LangCode = s[1].ToString();
                        var skey = Domain.ToString() + '~';
                        skey += LangCode.ToString();
                        MetaDataValue = objectcollection[skey];

                        string[] items = MetaDataValue.Split(',');
                        for (int count = 0; count <= items.Length - 1; count++)
                        {
                            MetaData ObjMetaData = new MetaData();
                            string[] values = items[count].Split('~');

                            ObjMetaData.Code = values[0].ToString();
                            ObjMetaData.DisplayText = values[1].ToString();
                            ObjMetaData.Domain = Domain.ToString();
                            ObjMetaData.LangCode = LangCode.ToString();
                            lstMetaData.Add(ObjMetaData);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading metadataorgmapping", ex);
            }
            return returnCode;
        }
         public long GetTATSchedulecode(int OrgID, string PrefixText, out List<TATSchedule> lstTATSchedulecode)
         {
             lstTATSchedulecode = new List<TATSchedule>();
             long returnCode = -1;
             try
             {
                 returnCode = new TAT_DAL(globalContextDetails).GetTATSchedulecode(OrgID, PrefixText, out lstTATSchedulecode);

             }
             catch (Exception ex)
             {
                 CLogger.LogError("Error while loading in GetTATSchedulecode() in Master_BL", ex);
             }
             return returnCode;
         }


         public long GetTATSchedulecategoryItem(int OrgID, string PrefixText, string SearchType, out List<TATCodingScheme> lstTATSchedulecategoryItem)
         {
             lstTATSchedulecategoryItem = new List<TATCodingScheme>();
             long returnCode = -1;
             try
             {
                 returnCode = new TAT_DAL(globalContextDetails).GetTATSchedulecategoryItem(OrgID, PrefixText, SearchType, out lstTATSchedulecategoryItem);

             }
             catch (Exception ex)
             {
                 CLogger.LogError("Error while loading in GetTATSchedulecode() in Master_BL", ex);
             }
             return returnCode;
         }


         public long getCategoryTestname(int OrgID, string PrefixText, string SearchType, int ItemID, int ConfigID, out List<TATCodingScheme> lstLoadCategoryTestname)
         {
             lstLoadCategoryTestname = new List<TATCodingScheme>();
             long returnCode = -1;
             try
             {
                 returnCode = new TAT_DAL(globalContextDetails).getCategoryTestname(OrgID, PrefixText, SearchType, ItemID, ConfigID, out lstLoadCategoryTestname);

             }
             catch (Exception ex)
             {
                 CLogger.LogError("Error while loading in LoadCategoryTestname() in Master_BL", ex);
             }
             return returnCode;
         }

         public long SaveTestforTAT(List<Tatschedulemapping> lstTATAdded)
         {
             long returnCode = -1;
             try
             {
                 TAT_DAL MasterDAL = new TAT_DAL(globalContextDetails);

                 returnCode = MasterDAL.SaveTestforTAT(lstTATAdded);

             }
             catch (Exception ex)
             {
                 CLogger.LogError("Error while executing SaveTestforTAT", ex);
             }
             return returnCode;
         }


         public long DeleteTestforTAT(List<Tatschedulemapping> lstDeleteAdded)
         {
             long returnCode = -1;
             try
             {
                 TAT_DAL MasterDAL = new TAT_DAL(globalContextDetails);

                 returnCode = MasterDAL.DeleteTestforTAT(lstDeleteAdded);

             }
             catch (Exception ex)
             {
                 CLogger.LogError("Error while executing SaveTestforTAT", ex);
             }
             return returnCode;
         }

         public long LoadtatTestname(int OrgID, int TatID, out List<TATCodingScheme> lstLoadCategoryTestname)
         {
             lstLoadCategoryTestname = new List<TATCodingScheme>();
             long returnCode = -1;
             try
             {
                 returnCode = new TAT_DAL(globalContextDetails).LoadtatTestname(OrgID, TatID, out lstLoadCategoryTestname);

             }
             catch (Exception ex)
             {
                 CLogger.LogError("Error while loading in LoadtatTestname() in Master_BL", ex);
             }
             return returnCode;
         }

         public long LoadtatClientTestname(int OrgID, int TatID, int ClientID, out List<TATCodingScheme> lstLoadCategoryTestname)
         {
             lstLoadCategoryTestname = new List<TATCodingScheme>();
             long returnCode = -1;
             try
             {
                 returnCode = new TAT_DAL(globalContextDetails).LoadtatClientTestname(OrgID, TatID, ClientID, out lstLoadCategoryTestname);
             }
             catch (Exception ex)
             {
                 CLogger.LogError("Error while loading in LoadtatTestname() in Master_BL", ex);
             }
             return returnCode;
         }

         /*BEGIN | Bug ID[154] | SHABIYA BANU C|  A |  TAT MANAGE LOGISTICS DETAILS  */
         public long GetOrgLocationDetails(int OrgID, long LocID, out List<Tatlogisticdetails> lstTatlogisticdetails)
         {
             lstTatlogisticdetails = new List<Tatlogisticdetails>();
             long returnCode = -1;
             try
             {
                 returnCode = new TAT_DAL(globalContextDetails).GetOrgLocationDetails(OrgID, LocID, out lstTatlogisticdetails);

             }
             catch (Exception ex)
             {
                 CLogger.LogError("Error while loading in GetOrgLocationDetails() in Master_BL", ex);
             }
             return returnCode;
         }

         public long LoadTATLogisticsDetails(int OrgID, long LocID, out List<Tatlogisticdetails> lstTatlogistic)
         {
             lstTatlogistic = new List<Tatlogisticdetails>();
             long returnCode = -1;
             try
             {
                 returnCode = new TAT_DAL(globalContextDetails).LoadTATLogisticsDetails(OrgID, LocID, out lstTatlogistic);

             }
             catch (Exception ex)
             {
                 CLogger.LogError("Error while loading in LoadTATLogisticsDetails() in Master_BL", ex);
             }
             return returnCode;
         }

         public long SaveTATLogisticsDetails(List<Tatlogisticdetails> lstTatlogisticdetails)
         {
             long returnCode = -1;
             try
             {
                 TAT_DAL MasterDAL = new TAT_DAL(globalContextDetails);
                 returnCode = MasterDAL.SaveTATLogisticsDetails(lstTatlogisticdetails);

             }
             catch (Exception ex)
             {
                 CLogger.LogError("Error while executing SaveTATLogisticsDetails", ex);
             }
             return returnCode;
         }

         public long UpdateTATLogisticsDetails(List<Tatlogisticdetails> lstTatlogisticdetails)
         {
             long returnCode = -1;
             try
             {
                 TAT_DAL MasterDAL = new TAT_DAL(globalContextDetails);
                 returnCode = MasterDAL.UpdateTATLogisticsDetails(lstTatlogisticdetails);

             }
             catch (Exception ex)
             {
                 CLogger.LogError("Error while executing UpdateTATLogisticsDetails", ex);
             }
             return returnCode;
         }


         public long EditTATLogisticsDetails(int Logisticdetailsid, out List<Tatlogisticdetails> lstTatlogistic)
         {
             lstTatlogistic = new List<Tatlogisticdetails>();
             long returnCode = -1;
             try
             {
                 returnCode = new TAT_DAL(globalContextDetails).EditTATLogisticsDetails(Logisticdetailsid, out lstTatlogistic);

             }
             catch (Exception ex)
             {
                 CLogger.LogError("Error while loading in EditTATLogisticsDetails() in Master_BL", ex);
             }
             return returnCode;
         }

         public long DeleteTATLogisticsDetails(List<Tatlogisticdetails> lstTatlogisticdetails)
         {
             long returnCode = -1;
             try
             {
                 TAT_DAL MasterDAL = new TAT_DAL(globalContextDetails);
                 returnCode = MasterDAL.DeleteTATLogisticsDetails(lstTatlogisticdetails);

             }
             catch (Exception ex)
             {
                 CLogger.LogError("Error while executing DeleteTATLogisticsDetails", ex);
             }
             return returnCode;
         }
         public long SaveLocationWorkingHoursDetail(int OrgID, int OrgAddressId, DateTime Labstart, DateTime Labend, string FrequencyDays, int ID)
         {

             long returnCode = -1;
             try
             {
                 returnCode = new TAT_DAL(globalContextDetails).SaveLocationWorkingHoursDetail(OrgID, OrgAddressId, Labstart, Labend, FrequencyDays, ID);
             }
             catch (Exception ex)
             {
                 CLogger.LogError("Error while saving SaveLocationWorkingHoursDetail", ex);
             }
             return returnCode;
         }
         public long GetLocationWorkingHoursDetail(long orgID, long pLID, long pRID, long LocationID, out List<TATLocationworkinghours> lstTATLocationworkinghours)
         {
             lstTATLocationworkinghours = new List<TATLocationworkinghours>();
             long returnCode = -1;
             try
             {
                 returnCode = new TAT_DAL(globalContextDetails).GetLocationWorkingHoursDetail(orgID, pLID, pRID, LocationID, out lstTATLocationworkinghours);
             }
             catch (Exception ex)
             {
                 CLogger.LogError("Error while loading GetLocation BL", ex);
             }
             return returnCode;
         }
        //public long SaveLocationWorkingHoursDetail(int OrgID, int OrgAddressId, DateTime Labstart, DateTime Labend, string FrequencyDays, int ID)
        //{

        //    long returnCode = -1;
        //    try
        //    {
        //        returnCode = new PatientVisit_DAL(globalContextDetails).SaveLocationWorkingHoursDetail(OrgID, OrgAddressId, Labstart, Labend, FrequencyDays, ID);
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error while saving SaveLocationWorkingHoursDetail", ex);
        //    }
        //    return returnCode;
        //}

         public long GetBillingTestItemsDetails(int OrgID, int FeeID, string FeeType, string Description, long ClientID, long VisitID, string Remarks, string IsCollected, DateTime CollectedDatetime, string locationName, out List<BillingTestFeeDetails> lstBillingFeeDetails)
         {
             long returnCode = -1;
             lstBillingFeeDetails = new List<BillingTestFeeDetails>();
             try
             {
                 returnCode = new TAT_DAL(globalContextDetails).GetBillingTestItemsDetails(OrgID, FeeID, FeeType, Description, ClientID, VisitID, Remarks, IsCollected, CollectedDatetime, locationName, out lstBillingFeeDetails);
             }
             catch (Exception ex)
             {
                 CLogger.LogError("Error in Billing BL - GetBillingItems", ex);
             }

             return returnCode;
         }
		
    }
}
   