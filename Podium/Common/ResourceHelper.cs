using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Attune.Podium.BusinessEntities;
using System.IO;
using System.Web;
using System.Web.Caching;
using System.Resources;
using System.Collections;

namespace Attune.Podium.Common
{
   public class ResourceHelper
    {
        //public static void ResourceToCache()
        //{
        //    List<MetaData> lstResValues = new List<MetaData>();
        //    lstResValues = ResourceToList(fil);
        //    string fileName = HttpContext.Current.Server.MapPath("~\\App_Data\\ResourceCache.Txt");
        //    if (!File.Exists(fileName))
        //    {
        //        StreamWriter writer = File.CreateText(fileName);
        //        writer.WriteLine(".LOG");
        //        writer.Close();
        //    }
        //    HttpContext.Current.Cache.Insert("ResourceCache", lstResValues, new CacheDependency(fileName));
        //}

        public static List<MetaData> ResourceToList(string fileName)
        {
            string Path = HttpContext.Current.Server.MapPath("~\\App_GlobalResources\\" + fileName);
            List<MetaData> lstResValues = new List<MetaData>();
            if (!string.IsNullOrEmpty(Path))
            {
                //DirectoryInfo DI = new DirectoryInfo(Path);
                
                using (ResXResourceReader obj = new ResXResourceReader (Path))
                {
                    foreach (DictionaryEntry entry in obj)
                    {
                        MetaData objData = new MetaData();
                        //objData.Domain = item.Name;
                        objData.Code = Convert.ToString(entry.Key);
                        string strValue = Convert.ToString(entry.Value);
                        objData.DisplayText = strValue.Replace("'", "&apos;");
                        lstResValues.Add(objData);
                    }
                }
            }
            
            return lstResValues;
        }

        public static List<MetaData> GetResourceByFileName(string FileName)
        {
            List<MetaData> lstResValues = new List<MetaData>();

            //if (HttpContext.Current.Cache["ResourceCache"] != null)
            //{
            //    lstResValues = (List<MetaData>)HttpContext.Current.Cache["ResourceCache"];
            //}
            //else
            //{
                lstResValues = ResourceToList(FileName);
                //string fileName = HttpContext.Current.Server.MapPath("~\\App_Data\\ResourceCache.Txt");
                //if (!File.Exists(fileName))
                //{
                //    StreamWriter writer = File.CreateText(fileName);
                //    writer.WriteLine(".LOG");
                //    writer.Close();
                //}
               // HttpContext.Current.Cache.Insert("ResourceCache", lstResValues, new CacheDependency(fileName));

            //}
            //if (lstResValues != null && lstResValues.Count > 0)
            //{
            //    lstResValues = lstResValues.Where(o => o.Domain == FileName).ToList();
            //}
            return lstResValues;
        }
    }
}
