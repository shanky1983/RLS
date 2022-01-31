using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Web.Hosting;
using System.Xml;
using Attune.Cryptography;
using System.Collections;

namespace Attune.KernelV2.Utilities
{
    public class Utility
    {
        public static IEnumerable<T> Tolist<T>(DbDataReader reader)
        {
            string[] resultFields = reader.GetSchemaTable()
                                              .AsEnumerable()
                                              .Select(row => row.ItemArray[0].ToString())
                                              .ToArray();

            var properties = typeof(T).GetProperties()
                                      .Where(prop => resultFields.Contains(prop.Name))
                                      .ToArray();

            while (reader.Read())
            {
                var obj = Activator.CreateInstance<T>();
                NameValueCollection objDictionary = new NameValueCollection();
                foreach (var property in properties)
                {
                    object value = reader[property.Name];

                    if (value == DBNull.Value)
                    {
                        if (property.PropertyType == typeof(int)
                            || property.PropertyType == typeof(Int16)
                            || property.PropertyType == typeof(Int32)
                            || property.PropertyType == typeof(Int64))
                            value = 0;
                        else if (property.PropertyType == typeof(decimal))
                            value = (decimal)0;
                        else if (property.PropertyType == typeof(float))
                            value = (float)0;
                        else if (property.PropertyType == typeof(double))
                            value = (double)0;


                        else if (property.PropertyType == typeof(bool)) value = false;

                        else if (property.PropertyType == typeof(DateTime)) value = DateTime.MinValue;

                        else if (property.PropertyType == typeof(string))
                            value = string.Empty;

                        else value = null;

                        property.SetValue(obj, value, null);
                    }
                    else if (value.GetType() == property.PropertyType)
                    {
                        if (property.PropertyType == typeof(string) && string.IsNullOrWhiteSpace(value.ToString()))
                            value = string.Empty;

                        property.SetValue(obj, value, null);
                    }
                    else
                    {
                        if (property.PropertyType == typeof(bool))
                            property.SetValue(obj, value.Equals(1) || (value.Equals("1") ? true : false), null);
                        if (property.PropertyType == typeof(Int64) && (value is int || value is short || value is byte))
                            property.SetValue(obj, value, null);
                        if (property.PropertyType == typeof(Int32) && (value is long || value is short || value is byte))
                            property.SetValue(obj, value, null);
                    }

                    if (value != null) objDictionary.Add(property.Name, value.ToString());
                }
                var Actionprop = obj.GetType().GetProperty("ActionTemplateValue");
                if (Actionprop != null)
                {
                    object Actionvalue = objDictionary;
                    Actionprop.SetValue(obj, Actionvalue, null);
                }
                yield return obj;
            }
        }

        public static T ToObject<T>(DbDataReader reader)
        {
            string[] resultFields = reader.GetSchemaTable()
                                              .AsEnumerable()
                                              .Select(row => row.ItemArray[0].ToString())
                                              .ToArray();

            var properties = typeof(T).GetProperties()
                                      .Where(prop => resultFields.Contains(prop.Name))
                                      .ToArray();
            var obj = Activator.CreateInstance<T>();
            while (reader.Read())
            {


                foreach (var property in properties)
                {
                    object value = reader[property.Name];
                    if (value == DBNull.Value)
                    {
                        if (property.PropertyType == typeof(int)
                            || property.PropertyType == typeof(Int16)
                            || property.PropertyType == typeof(Int32)
                            || property.PropertyType == typeof(Int64)
                            || property.PropertyType == typeof(decimal)
                            || property.PropertyType == typeof(float)
                            || property.PropertyType == typeof(double))
                            value = 0;

                        else if (property.PropertyType == typeof(bool)) value = false;

                        else if (property.PropertyType == typeof(DateTime)) value = DateTime.MinValue;

                        else if (property.PropertyType == typeof(string))
                            value = string.Empty;

                        else value = null;

                        property.SetValue(obj, value, null);
                    }
                    else if (value.GetType() == property.PropertyType)
                    {
                        if (property.PropertyType == typeof(string) && string.IsNullOrWhiteSpace(value.ToString()))
                            value = string.Empty;

                        property.SetValue(obj, value, null);
                    }
                    else
                    {
                        if (property.PropertyType == typeof(bool))
                            property.SetValue(obj, value.Equals(1) || (value.Equals("1") ? true : false), null);
                        if (property.PropertyType == typeof(Int64) && (value is int || value is short || value is byte))
                            property.SetValue(obj, value, null);
                        if (property.PropertyType == typeof(Int32) && (value is long || value is short || value is byte))
                            property.SetValue(obj, value, null);
                    }
                }
                return obj;
            }

            return obj;
        }

        public static string GetConnection()
        {
            var transConnection = ConfigurationManager.ConnectionStrings[Constants.DATABASE_CONNECTION_CONFIG_KEY].ConnectionString;
            CCryptography obj = new CCryptFactory().GetDecryptor();
            obj.Crypt(transConnection, out transConnection);
            return transConnection;
        }

        public void GetApplicationValue(string KeyName, out string KeyValue)
        {
            KeyValue = string.Empty;

            XmlDocument Doc = new XmlDocument();
            if (!string.IsNullOrEmpty(HostingEnvironment.ApplicationPhysicalPath))
            {
                string xmlFilePath = Path.Combine(HostingEnvironment.ApplicationPhysicalPath, @"App_Data\ApplicationSettings.XML");
                if (!string.IsNullOrEmpty(xmlFilePath) && File.Exists(xmlFilePath) && KeyName != "")
                {
                    Doc.Load(xmlFilePath);
                    XmlNodeList objXmlNodeList = Doc.GetElementsByTagName(KeyName);
                    if (objXmlNodeList.Count > 0)
                    {
                        KeyValue = objXmlNodeList[0].InnerText;
                    }
                }
            }
        }

        public static string getConfigurationManager(string KeyName)
        {
            var val = ConfigurationManager.AppSettings[KeyName];
            return val ?? "";
        }

        public static long GetHashTable(long taskActionID, long visitID, long physicianID,
        long patientID, string patientName, string physicianName, long procedureID,
        string machineName, long onflowCount, string lastTestTime, long previousTaskID, string feeType,
        out Hashtable displayText, out Hashtable urlValue, string BillID, string patientNumber, long TokenNumber, string gUID)
        {
            long returnCode = 0;
            displayText = new Hashtable();
            urlValue = new Hashtable();
            try
            {
                urlValue.Add("BillID", BillID);
                urlValue.Add("CreatedBy", physicianID);
                urlValue.Add("FeeType", feeType);
                urlValue.Add("PreviousTaskID", previousTaskID);
                urlValue.Add("ProcedureID", procedureID);
                urlValue.Add("PatientID", patientID);
                urlValue.Add("PatientVisitID", visitID);
                urlValue.Add("UID", gUID);
                urlValue.Add("taskactionid", taskActionID);

                displayText.Add("LastTestTime", lastTestTime);
                displayText.Add("MachineName", machineName);
                displayText.Add("OnflowNo", onflowCount);
                displayText.Add("PatientName", patientName);
                displayText.Add("PatientNumber", patientNumber);
                displayText.Add("PhysicianName", physicianName);
                displayText.Add("TokenNumber", TokenNumber);
            }
            catch (Exception ex)
            {
                returnCode = -1;
                CLogger.LogError("Error while creating redirect url hashtable ", ex);
            }
            return returnCode;
        }

        public static long GetHashTable(long taskActionID, long visitID, long physicianID,
            long patientID, string patientName, string physicianName, long procedureID,
            string machineName, long onflowCount, string lastTestTime, long previousTaskID, string feeType,
            out Hashtable displayText, out Hashtable urlValue, string BillID, string patientNumber, long TokenNumber, string gUID, string ExternalVisitID,
            string VisitNumber, string SampleID)
        {
            long returnCode = -1;
            returnCode = GetHashTable(taskActionID, visitID, physicianID, patientID, patientName, physicianName, procedureID, machineName, onflowCount,
                lastTestTime, previousTaskID, feeType, out displayText, out urlValue, BillID, patientNumber, TokenNumber, gUID);
            if (string.IsNullOrEmpty(ExternalVisitID))
            {
                displayText.Add("VisitNumber", VisitNumber);
            }
            else
            {
                displayText.Add("VisitNumber", VisitNumber);
            }
            if (string.IsNullOrEmpty(ExternalVisitID))
            {
                displayText.Add("ExternalVisitId", visitID);
            }
            else
            {
                displayText.Add("ExternalVisitId", ExternalVisitID);
            }

            if (!String.IsNullOrEmpty(SampleID))
            {
                displayText.Add("SampleID", SampleID);//added for Waters(to display SampleID in approval task)
            }

            return returnCode;
        }
    }

    public static class Extension
    {
        public static string CalculateAge(this DateTime dtDOB, DateTime baseDate)
        {
            string dictAge = "";

            if (dtDOB != DateTime.MinValue && dtDOB != DateTime.MaxValue)
            {
                Age objAge = new Age(dtDOB, baseDate);
                //dictAge = objAge.Years + "{0}," + objAge.Months + "," + objAge.Days;
                if (objAge.Years != 0)
                {
                    dictAge += objAge.Years + "{0} ";
                }
                if (objAge.Months != 0)
                {
                    dictAge += objAge.Months + "{1} ";
                }
                if (objAge.Days != 0)
                {
                    dictAge += objAge.Days + "{2} ";
                }
            }
            return dictAge;
        }
    }
}