using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using System.Configuration;
using System.Collections.Specialized;
using System.Xml;
using System.Web;
using Attune.Kernel.CacheEngine;

namespace Attune.Podium.Common
{

    /// <summary>
    /// Summary description for Utilities
    /// </summary>
    /// 

    //public interface IInvestigationPattern
    //{
    //    int GroupID
    //    {
    //        get;
    //        set;
    //    }

    //    string GroupName
    //    {
    //        get;
    //        set;
    //    }

    //    string Name
    //    {
    //        get;
    //        set;
    //    }

    //    string UOM
    //    {
    //        get;
    //        set;
    //    }

    //    string ControlID
    //    {
    //        get;
    //        set;
    //    }

    //    string Value
    //    {
    //        get;
    //        set;
    //    }

    //    int PackageID
    //    {
    //        get;
    //        set;

    //    }
    //    string PackageName
    //    {
    //        get;
    //        set;
    //    }

    //    //void loadStatus(List<InvestigationStatus> lstStatus);

    //    //PatientInvestigation GetInvestigations(long Vid);
    //    //void LoadData(List<InvestigationValues> lstValues);
    //    //List<InvestigationValues> GetResult(long VID);


    //}

    public class Utilities
    {
        public Utilities()
        {
            //
            // TODO: Add constructor logic here
            //
        }


        public static long ConvertTo(IDataReader dataReader, out StringDictionary objDictionary)
        {
            long returnCode = -1;
            objDictionary = new StringDictionary();
            string key = string.Empty;
            string value = string.Empty;
            try
            {
                while (dataReader.Read())
                {
                    key = Convert.ToString(dataReader.GetValue(0));
                    value = Convert.ToString(dataReader.GetValue(1));
                    if (!objDictionary.ContainsKey(key))
                    {
                        objDictionary.Add(key, value);
                    }
                }
                returnCode = 0;
            }
            catch (Exception ex)
            {
                returnCode = 1000;
                CLogger.LogError("Error while executing ConvertTo<dataReader, StringDictionary> method in Utilities", ex);
            }
            finally
            {
                dataReader.Close();
            }
            return returnCode;
        }

        public static long ConvertTo<T>(IDataReader dataReader, out List<T> resultSet)
        {
            long returnCode = -1;
            T obj = default(T);
            resultSet = new List<T>();
            object columnValue;
            PropertyInfo prop;
            int fieldCount;
            try
            {
                if (dataReader.Read())
                {
                    fieldCount = dataReader.FieldCount;
                    do
                    {
                        obj = Activator.CreateInstance<T>();
                        for (int idx = 0; idx < fieldCount; idx++)
                        {
                            prop = obj.GetType().GetProperty(dataReader.GetName(idx));
                            if (prop != null)
                            {
                                columnValue = dataReader.IsDBNull(idx) ? null : dataReader.GetValue(idx);
                                prop.SetValue(obj, columnValue, null);
                            }
                        }
                        resultSet.Add(obj);
                    } while (dataReader.Read());
                }
                returnCode = 0;
            }
            catch (Exception ex)
            {
                returnCode = 1000;
                CLogger.LogError("Error while executing ConvertTo<dataReader, entity> method in Utilities", ex);
            }
            return returnCode;
        }

        public static long ConvertTo<T>(DataTable table, out List<T> entity)
        {
            long returnCode = -1;
            entity = null;
            if (table == null)
            {
                return -1;
            }

            try
            {
                entity = ConvertTo<T>(table.Rows);
                returnCode = 0;
            }
            catch (Exception ex)
            {
                returnCode = 1000;
                CLogger.LogError("Error while executing ConverTo<> method in Utilities", ex);
            }
            finally
            {
            }
            return returnCode;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="rows"></param>
        /// <returns></returns>
        static List<T> ConvertTo<T>(DataRowCollection rows)
        {
            List<T> list = null;

            if (rows != null)
            {
                list = new List<T>();

                foreach (DataRow row in rows)
                {
                    T item = CreateItem<T>(row);
                    list.Add(item);
                }
            }

            return list;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="row"></param>
        /// <returns></returns>
        static T CreateItem<T>(DataRow row)
        {
            string str = string.Empty;
            string strObj = string.Empty;

            T obj = default(T);

            if (row != null)
            {
                obj = Activator.CreateInstance<T>();
                strObj = obj.ToString();
                NameValueCollection objDictionary = new NameValueCollection();
                foreach (DataColumn column in row.Table.Columns)
                {

                    PropertyInfo prop = obj.GetType().GetProperty(column.ColumnName);
                    if (prop != null)
                    {
                        str = column.ColumnName;
                        try
                        {
                            objDictionary.Add(str, row[str].ToString());
                            object value = row[column.ColumnName];
                            Type vType = obj.GetType();
                            if (value == DBNull.Value)
                            {
                                if (vType == typeof(int)
                                     || vType == typeof(Int16)
                                     || vType == typeof(Int32)
                                     || vType == typeof(Int64)
                                     || vType == typeof(decimal)
                                     || vType == typeof(float)
                                     || vType == typeof(double)) value = 0;

                                else if (vType == typeof(bool)) value = false;

                                else if (vType == typeof(DateTime)) value = DateTime.MinValue;

                                else value = null;

                                prop.SetValue(obj, value, null);
                            }
                            else
                            {
                                prop.SetValue(obj, value, null);
                            }

                        }
                        catch (Exception ex)
                        {
                           // CLogger.LogError("Error while executing CreateItem<> method in Utilities " + " Col: " + str + " Obj: " + strObj, ex);

                        }
                    }
                }
                PropertyInfo Actionprop = obj.GetType().GetProperty("ActionTemplateValue");
                if (Actionprop != null)
                {
                    object Actionvalue = objDictionary;
                    Actionprop.SetValue(obj, Actionvalue, null);
                }
            }

            return obj;
        }




        /// <summary>
        /// convert list to datatable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="table"></param>
        /// <returns></returns>

        public static long ConvertFrom<T>(IList<T> list, out DataTable table)
        {
            table = CreateTable<T>();
            try
            {
                Type entityType = typeof(T);
                PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(entityType);

                foreach (T item in list)
                {
                    DataRow row = table.NewRow();

                    foreach (PropertyDescriptor prop in properties)
                    {
                        row[prop.Name] = prop.GetValue(item);
                    }

                    table.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while generating datatable in ConvertFrom<T> method", ex);
            }
            return 0;
        }

        /// <summary>
        /// Create datatable column
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static DataTable CreateTable<T>()
        {
            Type entityType = typeof(T);
            DataTable table = new DataTable(entityType.Name);
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(entityType);

            foreach (PropertyDescriptor prop in properties)
            {
                table.Columns.Add(prop.Name, prop.PropertyType);
            }

            return table;
        }


        public static long GetInvoiceHashTable(long taskActionID,long InvID,long ClientID,string ClientCode,string CName,string FDate,string TDate,long SID,long RejBill,out Hashtable displayText, out Hashtable urlValue)
        {
            long returnCode = 0;
            displayText = new Hashtable();
            urlValue = new Hashtable();
            try
            {
                DateTime FromDate = Convert.ToDateTime(FDate);
                DateTime ToDate = Convert.ToDateTime(TDate);
              
                //Note : Please add the Key value pair list, Which is not appear in the below Hash Table
                urlValue.Add("InvID", InvID);
                urlValue.Add("CID", ClientID);
                urlValue.Add("CCode", ClientCode);
                urlValue.Add("CName", CName);
                urlValue.Add("FDate", FromDate);
                urlValue.Add("TDate", ToDate);
                urlValue.Add("SID", SID);
                urlValue.Add("RejBill", RejBill); 
                displayText.Add("CName", CName);
             

            }
            catch (Exception ex)
            {
                returnCode = -1;
                CLogger.LogError("Error while creating redirect url hashtable ", ex);
            }

            return returnCode;
        }




        public static long GetHashTable(long taskActionID, long EpisodeID, string EpisodeName, string feeType, string EpisodeNo,
    out Hashtable displayText, out Hashtable urlValue)
        {
            long returnCode = 0;
            displayText = new Hashtable();
            urlValue = new Hashtable();
            try
            {

                //Note : Please add the Key value pair list, Which is not appear in the below Hash Table
                urlValue.Add("EpisodeID", EpisodeID);
                displayText.Add("EpisodeName", EpisodeName);
                displayText.Add("EpisodeNo", EpisodeNo);

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
            out Hashtable displayText, out Hashtable urlValue, string BillID, string patientNumber, long TokenNumber, string gUID, string ExternalVisitID, string VisitNumber,string SampleID)
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

            if (!String.IsNullOrEmpty(SampleID)){
                displayText.Add("SampleID", SampleID);//added for Waters(to display SampleID in approval task)
        }
            
            return returnCode;
        }

        public static long GetHashTable(long taskActionID, long visitID, long physicianID,
        long patientID, string patientName, string physicianName, long procedureID,
        string machineName, long onflowCount, string lastTestTime, long previousTaskID, string feeType,
        out Hashtable displayText, out Hashtable urlValue, long BillID, string patientNumber, long TokenNumber, string gUID)
        {
            long returnCode = 0;
            displayText = new Hashtable();
            urlValue = new Hashtable();
            try
            {
                #region "Commented by Venkat"

                //switch (taskActionID)
                //{
                //    case 1: // CollectANCVitals
                //        displayText.Add("PatientName", patientName);
                //        displayText.Add("PhysicianName", physicianName);
                //        displayText.Add("PatientNumber", patientNumber);
                //        displayText.Add("TokenNumber", TokenNumber);
                //        urlValue.Add("PatientID", patientID);
                //        break;
                //    case 2: // CancelAppointment
                //        displayText.Add("PhysicianName", physicianName);
                //        break;
                //    case 3: // CloseTask
                //        break;
                //    case 4: // CollectANCVitals
                //        displayText.Add("PatientName", patientName);
                //        displayText.Add("PatientNumber", patientNumber);
                //        displayText.Add("TokenNumber", TokenNumber);
                //        displayText.Add("PhysicianName", physicianName);
                //        break;
                //    case 5: // FirstDialysis
                //        displayText.Add("PatientName", patientName);
                //        displayText.Add("PatientNumber", patientNumber);
                //        displayText.Add("TokenNumber", TokenNumber);
                //        urlValue.Add("PatientVisitID", visitID);
                //        urlValue.Add("ProcedureID", procedureID);
                //        break;

                //    case 6: // PreDialysis
                //        displayText.Add("PatientName", patientName);
                //        displayText.Add("PatientNumber", patientNumber);
                //        displayText.Add("TokenNumber", TokenNumber);
                //        urlValue.Add("PatientVisitID", visitID);
                //        urlValue.Add("ProcedureID", procedureID);
                //        break;
                //    case 7: // OnFlowMonitoring
                //        displayText.Add("PatientName", patientName);
                //        displayText.Add("PatientNumber", patientNumber);
                //        displayText.Add("TokenNumber", TokenNumber);
                //        displayText.Add("MachineName", machineName);
                //        displayText.Add("OnflowNo", onflowCount);
                //        displayText.Add("LastTestTime", lastTestTime);
                //        urlValue.Add("PatientVisitID", visitID);
                //        urlValue.Add("ProcedureID", procedureID);
                //        break;
                //    case 8: // PostDialysis
                //        displayText.Add("PatientName", patientName);
                //        displayText.Add("PatientNumber", patientNumber);
                //        displayText.Add("TokenNumber", TokenNumber);
                //        urlValue.Add("PatientVisitID", visitID);
                //        urlValue.Add("ProcedureID", procedureID);
                //        break;
                //    case 9: // CollectPayment
                //        displayText.Add("PatientName", patientName);
                //        displayText.Add("PatientNumber", patientNumber);
                //        displayText.Add("TokenNumber", TokenNumber);
                //        urlValue.Add("PatientVisitID", visitID);
                //        urlValue.Add("PatientID", patientID);
                //        urlValue.Add("PreviousTaskID", previousTaskID);
                //        urlValue.Add("FeeType", feeType);
                //        urlValue.Add("BillID", BillID);
                //        urlValue.Add("UID", gUID);
                //        break;
                //    case 10: // PerformInvestigation
                //        displayText.Add("PatientName", patientName);
                //        displayText.Add("PatientNumber", patientNumber);
                //        displayText.Add("TokenNumber", TokenNumber);
                //        urlValue.Add("PatientVisitID", visitID);
                //        break;
                //    case 11: // PerformDiagnosis
                //        displayText.Add("PatientName", patientName);
                //        urlValue.Add("PatientID", patientID);
                //        displayText.Add("PatientNumber", patientNumber);
                //        displayText.Add("TokenNumber", TokenNumber);
                //        urlValue.Add("PatientVisitID", visitID);
                //        break;
                //    case 12: // PerformDiagnosis
                //        displayText.Add("PatientName", patientName);
                //        displayText.Add("PatientNumber", patientNumber);
                //        displayText.Add("TokenNumber", TokenNumber);
                //        urlValue.Add("PatientID", patientID);
                //        urlValue.Add("PatientVisitID", visitID);
                //        break;
                //    case 13: // SubmitRepords
                //        displayText.Add("PatientName", patientName);
                //        displayText.Add("PatientNumber", patientNumber);
                //        displayText.Add("TokenNumber", TokenNumber);
                //        urlValue.Add("PatientVisitID", visitID);
                //        break;

                //    case 14: // Dialysis Reportrs
                //        displayText.Add("PatientName", patientName);
                //        displayText.Add("PatientNumber", patientNumber);
                //        displayText.Add("TokenNumber", TokenNumber);
                //        urlValue.Add("PatientVisitID", visitID);
                //        break;
                //    case 15: // InvestigationPayment
                //        displayText.Add("PatientName", patientName);
                //        displayText.Add("PatientNumber", patientNumber);
                //        displayText.Add("TokenNumber", TokenNumber);
                //        urlValue.Add("PatientID", patientID);
                //        urlValue.Add("PatientVisitID", visitID);
                //        urlValue.Add("UID", gUID);
                //        break;
                //    case 16: // Collect Samples
                //        displayText.Add("PatientName", patientName);
                //        displayText.Add("PatientNumber", patientNumber);
                //        displayText.Add("TokenNumber", TokenNumber);
                //        urlValue.Add("PatientID", patientID);
                //        urlValue.Add("PatientVisitID", visitID);
                //        break;

                //    case 17: // Refered Investigation
                //        displayText.Add("PatientName", patientName);
                //        displayText.Add("PatientNumber", patientNumber);
                //        displayText.Add("TokenNumber", TokenNumber);
                //        urlValue.Add("PatientID", patientID);
                //        urlValue.Add("PatientVisitID", visitID);
                //        break;


                //    case 18: // Prescription Printing
                //        displayText.Add("PatientName", patientName);
                //        displayText.Add("PatientNumber", patientNumber);
                //        displayText.Add("TokenNumber", TokenNumber);
                //        urlValue.Add("PatientID", patientID);
                //        urlValue.Add("PatientVisitID", visitID);
                //        break;

                //    case 19: // Show Investigation
                //        displayText.Add("PatientName", patientName);
                //        displayText.Add("PatientNumber", patientNumber);
                //        displayText.Add("TokenNumber", TokenNumber);
                //        urlValue.Add("PatientID", patientID);
                //        urlValue.Add("PatientVisitID", visitID);
                //        break;


                //    case 20: // CheckPayment
                //        displayText.Add("PatientName", patientName);
                //        displayText.Add("PatientNumber", patientNumber);
                //        displayText.Add("TokenNumber", TokenNumber);
                //        urlValue.Add("PatientID", patientID);
                //        urlValue.Add("PatientVisitID", visitID);
                //        urlValue.Add("PreviousTaskID", previousTaskID);
                //        urlValue.Add("FeeType", feeType);
                //        urlValue.Add("ProcedureID", procedureID); urlValue.Add("BillID", BillID);
                //        break;

                //    case 22: // Collect Samples
                //        displayText.Add("PatientName", patientName);
                //        displayText.Add("PatientNumber", patientNumber);
                //        displayText.Add("TokenNumber", TokenNumber);
                //        urlValue.Add("PatientID", patientID);
                //        urlValue.Add("PatientVisitID", visitID);
                //        urlValue.Add("UID", gUID);
                //        break;

                //    case 32: // CollectANCInformation
                //        displayText.Add("PatientName", patientName);
                //        displayText.Add("PatientNumber", patientNumber);
                //        displayText.Add("TokenNumber", TokenNumber);
                //        urlValue.Add("PatientID", patientID);
                //        urlValue.Add("PatientVisitID", visitID);
                //        break;

                //    case 33: // PerformANCDiagnosis
                //        displayText.Add("PatientName", patientName);
                //        displayText.Add("PatientNumber", patientNumber);
                //        displayText.Add("TokenNumber", TokenNumber);
                //        urlValue.Add("PatientID", patientID);
                //        urlValue.Add("PatientVisitID", visitID);
                //        break;

                //    case 34: // HandoverANCCaseSheet
                //        displayText.Add("PatientName", patientName);
                //        displayText.Add("PatientNumber", patientNumber);
                //        displayText.Add("TokenNumber", TokenNumber);
                //        urlValue.Add("PatientID", patientID);
                //        urlValue.Add("PatientVisitID", visitID);
                //        break;

                //    case 35: // Immunization
                //        displayText.Add("PatientName", patientName);
                //        displayText.Add("PatientNumber", patientNumber);
                //        displayText.Add("TokenNumber", TokenNumber);
                //        urlValue.Add("PatientID", patientID);
                //        urlValue.Add("PatientVisitID", visitID);
                //        break;

                //    case 36: // CollectSurgeryPayment
                //        displayText.Add("PatientName", patientName);
                //        displayText.Add("PatientNumber", patientNumber);
                //        displayText.Add("TokenNumber", TokenNumber);
                //        urlValue.Add("PatientID", patientID);
                //        urlValue.Add("PatientVisitID", visitID);
                //        break;

                //    case 37: // Pharmacy
                //        displayText.Add("PatientName", patientName);
                //        urlValue.Add("PatientID", patientID);
                //        displayText.Add("PatientNumber", patientNumber);
                //        displayText.Add("TokenNumber", TokenNumber);
                //        urlValue.Add("PatientVisitID", visitID);
                //        urlValue.Add("CreatedBy", physicianID);
                //        break;

                //    case 38: //HealthCheckUpHistory
                //        displayText.Add("PatientName", patientName);
                //        displayText.Add("PatientNumber", patientNumber);
                //        displayText.Add("TokenNumber", TokenNumber);
                //        urlValue.Add("PatientID", patientID);
                //        urlValue.Add("PatientVisitID", visitID);
                //        break;
                //    case 39: //Approval Step
                //        displayText.Add("PatientName", patientName);
                //        displayText.Add("PatientNumber", patientNumber);
                //        displayText.Add("TokenNumber", TokenNumber);
                //        urlValue.Add("PatientID", patientID);
                //        urlValue.Add("PatientVisitID", visitID);
                //        urlValue.Add("UID", gUID);
                //        break;
                //    case 40: //Refund
                //        displayText.Add("PatientName", patientName);
                //        displayText.Add("PatientNumber", patientNumber);
                //        urlValue.Add("PatientID", patientID);
                //        urlValue.Add("PatientVisitID", visitID);
                //        urlValue.Add("BillID", BillID);
                //        break;
                //    case 41: // PerformPhysiotherapy
                //        displayText.Add("PatientName", patientName);
                //        urlValue.Add("PatientID", patientID);
                //        displayText.Add("PatientNumber", patientNumber);
                //        displayText.Add("TokenNumber", TokenNumber);
                //        urlValue.Add("PatientVisitID", visitID);
                //        break;
                //    case 42: //View Investigation
                //        displayText.Add("PatientName", patientName);
                //        displayText.Add("PatientNumber", patientNumber);
                //        urlValue.Add("PatientID", patientID);
                //        urlValue.Add("PatientVisitID", visitID);
                //        urlValue.Add("BillID", BillID);
                //        break;
                //}

                // BillID
                //CreatedBy
                //FeeType
                //LastTestTime
                //MachineName
                //OnflowNo
                //PatientID
                //PatientName
                //PatientNumber
                //PatientVisitID
                //PhysicianName
                //PreviousTaskID
                //ProcedureID
                //TokenNumber
                //UID
                #endregion

                //Note : Please add the Key value pair list, Which is not appear in the below Hash Table

                urlValue.Add("BillID", BillID);
                urlValue.Add("CreatedBy", physicianID);
                urlValue.Add("FeeType", feeType);
                urlValue.Add("PreviousTaskID", previousTaskID);
                urlValue.Add("ProcedureID", procedureID);
                urlValue.Add("PatientID", patientID);
                urlValue.Add("PatientVisitID", visitID);
                urlValue.Add("SpecialityID", procedureID);
                urlValue.Add("UID", gUID);
                urlValue.Add("taskactionid", taskActionID);

                displayText.Add("LastTestTime", lastTestTime);
                displayText.Add("MachineName", machineName);
                displayText.Add("OnflowNo", onflowCount);
                displayText.Add("PatientVisitID", visitID);
                displayText.Add("PatientName", patientName);
                displayText.Add("PatientNumber", patientNumber);
                displayText.Add("SpecialityID", procedureID);

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
        out Hashtable displayText, out Hashtable urlValue, string BillID, string patientNumber, long TokenNumber, string gUID)
        {
            long returnCode = 0;
            displayText = new Hashtable();
            urlValue = new Hashtable();
            try
            {

                //Note : Please add the Key value pair list, Which is not appear in the below Hash Table

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
            string machineName, string lastTestTime, long previousTaskID, string feeType,
        out Hashtable displayText, out Hashtable urlValue)
        {
            long returnCode = 0;
            displayText = new Hashtable();
            urlValue = new Hashtable();
            try
            {

                switch (taskActionID)
                {
                    case (Int64)TaskHelper.TaskAction.IPAdmission: // IPAdmission
                        displayText.Add("PatientName", patientName);
                        urlValue.Add("PatientID", patientID);
                        urlValue.Add("PatientVisitID", visitID);
                        break;
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while creating redirect url hashtable ", ex);
                returnCode = -1;
            }

            return returnCode;
        }

        public static void TaskAction(long taskActionID, long visitID, string patientName, long onflowCount, out Hashtable displayText, out Hashtable urlValue)
        {
            displayText = new Hashtable();
            urlValue = new Hashtable();

            GetHashTable(taskActionID, visitID, 0, 0, patientName, "", 0, "", onflowCount, "", 0, "", out displayText, out urlValue, 0, "", 0, "");

        }

        public void SetConnectionKey(string pCon, string pType, int OrgID)
        {
            CacheProvider _cp = new CacheProvider(1);
            string pkey = _cp.getKey(AttCacheKey.PrimaryDB, OrgID);
            string KeyValue = string.Empty;

            if (pType == "PrimaryDB")
            {
                _cp.Set(pkey, pCon);
            }
            pkey = _cp.getKey(AttCacheKey.SecondaryDB, OrgID);

            if (pType == "PrimaryDB")
            {
                _cp.Set(pkey, pCon);
            }
        }

        public enum PatientDetailOptions
        {
            ContinueSameTreatment = 1,
            AlterPrescription = 2,
            InvestigateFurther = 3,
            ChangeDiagnosis = 4,
            AdmitThePatient = 5,
            AlterHealthInformation = 6,
            AddRecommendations = 7

        }

        //This method removes all the white spaces, Special Characters 
        //and initials from a given string.
        //The return value just contains the string part of the given name
        //e.g.  Input: V. Rama Krish/nan 
        //      Output: Ramakrishnan
        public static string getCompressedName(string strName)
        {
            string retval = strName;
            string[] splitStr;
            string strTemp = string.Empty;

            //Remove all the initials.
            //Split using '.',' ' and concatenate strings only if their length is >0
            splitStr = strName.Split('.', ' ');
            if (splitStr.Length > 0)
            {
                for (int i = 0; i <= splitStr.Length - 1; i++)
                {
                    if (splitStr[i].Length > 2)
                    {
                        strTemp = strTemp + splitStr[i];
                    }
                }
            }

            if (strTemp != string.Empty)
                retval = strTemp;

            //Remove all non-alphabets
            int iAscval;
            strTemp = string.Empty;
            for (int i = 0; i <= retval.Length - 1; i++)
            {
                iAscval = (int)Convert.ToChar(retval.Substring(i, 1));
                if ((iAscval >= 97 && iAscval <= 122) || (iAscval >= 65 && iAscval <= 90))
                {
                    strTemp = strTemp + retval.Substring(i, 1);
                }
            }
            return strTemp;
        }


        public static string removeSCharinName(string strName)
        {
            string retval = strName;
            string strTemp = string.Empty;

            //Remove all non-alphabets
            int iAscval;
            strTemp = string.Empty;
            for (int i = 0; i <= retval.Length - 1; i++)
            {
                iAscval = (int)Convert.ToChar(retval.Substring(i, 1));
                if ((iAscval >= 97 && iAscval <= 122) || (iAscval >= 65 && iAscval <= 90) || (iAscval == 32) || (iAscval == 46))
                {
                    strTemp = strTemp + retval.Substring(i, 1);
                }
            }
            return strTemp;
        }

        //public static string splitINVID(string strName)
        //{
        //    string retval = strName;
        //    string[] splitStr;
        //    string strTemp = string.Empty;

        //    splitStr = strName.Split('~');

        //    strTemp = splitStr[0];
        //    if (strTemp != string.Empty)
        //        retval = strTemp;

        //    return strTemp;
        //}
        //public static string splitINVNAME(string strName)
        //{
        //    string retval = strName;
        //    string[] splitStr;
        //    string strTemp = string.Empty;

        //    splitStr = strName.Split('~');

        //    strTemp = splitStr[1];
        //    if (strTemp != string.Empty)
        //        retval = strTemp;

        //    return strTemp;
        //}
        //public static string splitGrpID(string strName)
        //{
        //    string retval = strName;
        //    string[] splitStr;
        //    string strTemp = string.Empty;

        //    splitStr = strName.Split('~');

        //    strTemp = splitStr[2];
        //    if (strTemp != string.Empty)
        //        retval = strTemp;

        //    return strTemp;
        //}
        public static string ConvertToXML(object objGraph, Type Types)
        {
            System.Text.StringBuilder XmlString = new System.Text.StringBuilder();
            try
            {

                //System.Xml.XmlWriter ml = new System.Xml.XmlWriter();
                //using (System.IO.Stream fStream = new System.IO.FileStream("D:/Smp.xml", System.IO.FileMode.Create, System.IO.FileAccess.Write, System.IO.FileShare.None))
                //{
                //Type t = typeof(List<PatientDetails>);
                System.Xml.Serialization.XmlSerializer xmlFormat = new System.Xml.Serialization.XmlSerializer(Types);
                xmlFormat.Serialize(System.Xml.XmlWriter.Create(XmlString), objGraph);
                //xmlFormat.Serialize(fStream, objGraph);

                //}

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In convert to XML Method in utilities", ex);
            }
            return XmlString.ToString();
        }

        public static string GetConnectionString()
        {
            return GetConnectionString(SqlConnectionKey.Primary);
        }
        public static string GetConnectionString(SqlConnectionKey pKey)
        {
            string pConnectionName = "";
            string sqlConnectionString = string.Empty;
            Attune.Cryptography.CCryptography obj = null;
            CacheProvider _cp = null;
            string pcachekey = string.Empty;
            int OrgID = 0;

            switch (pKey)
            {
            
                case SqlConnectionKey.Primary:
                     _cp = new CacheProvider(1);
                    if (HttpContext.Current != null && HttpContext.Current.Session != null)
                    {
                        if (HttpContext.Current.Session["OrgID"] != null)
                        {
                            int.TryParse(HttpContext.Current.Session["OrgID"].ToString(), out OrgID);
                        }
                        if (HttpContext.Current.Session["RoleName"] != null 
                            && (Convert.ToString(HttpContext.Current.Session["RoleName"]) == "Administrator" || Convert.ToString(HttpContext.Current.Session["RoleName"]) == "Sr Credit Controller"))
                        {

                            obj = new Attune.Cryptography.CCryptFactory().GetDecryptor();
                            sqlConnectionString = ConfigurationManager.ConnectionStrings["AttHealth"].ConnectionString;
                            obj.Crypt(sqlConnectionString, out pConnectionName);
                            break;
                        }
                    }
                    pcachekey= _cp.getKey(AttCacheKey.PrimaryDB, OrgID);
                    if (_cp.IsInCache(pcachekey))
                    {
                        pConnectionName = _cp.Get<string>(pcachekey); 
                        if(string.IsNullOrEmpty(pConnectionName))
                        {
                            obj = new Attune.Cryptography.CCryptFactory().GetDecryptor();
                            sqlConnectionString = ConfigurationManager.ConnectionStrings["AttHealth"].ConnectionString;
                            obj.Crypt(sqlConnectionString, out pConnectionName);
                        }
                    }
                    else
                    {
                        obj = new Attune.Cryptography.CCryptFactory().GetDecryptor();
                        sqlConnectionString = ConfigurationManager.ConnectionStrings["AttHealth"].ConnectionString;
                        obj.Crypt(sqlConnectionString, out pConnectionName);
                    }
                    break;
                case SqlConnectionKey.Shared:
                    obj = new Attune.Cryptography.CCryptFactory().GetDecryptor();
                    sqlConnectionString = ConfigurationManager.ConnectionStrings["AttHealth"].ConnectionString;
                    obj.Crypt(sqlConnectionString, out pConnectionName);
                    break;
                case SqlConnectionKey.Secondary:

                    _cp = new CacheProvider(1);
                    if (HttpContext.Current != null && HttpContext.Current.Session != null && HttpContext.Current.Session["OrgID"] != null)
                    {
                        int.TryParse(HttpContext.Current.Session["OrgID"].ToString(), out OrgID);
                    }
                    pcachekey = _cp.getKey(AttCacheKey.SecondaryDB, OrgID);
                    if (_cp.IsInCache(pcachekey))
                    {
                        pConnectionName = _cp.Get<string>(pcachekey);
                        if (string.IsNullOrEmpty(pConnectionName))
                        {
                            obj = new Attune.Cryptography.CCryptFactory().GetDecryptor();
                            sqlConnectionString = ConfigurationManager.ConnectionStrings["AttHealth"].ConnectionString;
                            obj.Crypt(sqlConnectionString, out pConnectionName);
                        }

                    }
                    else if (_cp.IsInCache(_cp.getKey(AttCacheKey.PrimaryDB, OrgID)))
                    {
                        pcachekey = _cp.getKey(AttCacheKey.PrimaryDB, OrgID);
                        pConnectionName = _cp.Get<string>(pcachekey);
                        if (string.IsNullOrEmpty(pConnectionName))
                        {
                            obj = new Attune.Cryptography.CCryptFactory().GetDecryptor();
                            sqlConnectionString = ConfigurationManager.ConnectionStrings["AttHealth"].ConnectionString;
                            obj.Crypt(sqlConnectionString, out pConnectionName);
                        }
                    }
                    else
                    {
                        obj = new Attune.Cryptography.CCryptFactory().GetDecryptor();
                        sqlConnectionString = ConfigurationManager.ConnectionStrings["AttHealth"].ConnectionString;
                        obj.Crypt(sqlConnectionString, out pConnectionName);
                    }

                    break;
                case SqlConnectionKey.SharedSecondary:
                    obj = new Attune.Cryptography.CCryptFactory().GetDecryptor();
                    sqlConnectionString = ConfigurationManager.ConnectionStrings["AttHealthSecondary"].ConnectionString;
                    if (string.IsNullOrEmpty(sqlConnectionString))
                        {
                           
                            sqlConnectionString = ConfigurationManager.ConnectionStrings["AttHealth"].ConnectionString;
                            
                        }
					obj.Crypt(sqlConnectionString, out pConnectionName);
					
					
                    break;
                default:
                    obj = new Attune.Cryptography.CCryptFactory().GetDecryptor();
                    sqlConnectionString = ConfigurationManager.ConnectionStrings["AttHealth"].ConnectionString;
                    obj.Crypt(sqlConnectionString, out pConnectionName);
                    break;
            }
           
            return pConnectionName;
        }

        /// <summary>
        /// It accepts the Converted Currency in Words as input from "NumberToWord.dll"
        /// and manipulates it on paise part by showing the text "AND" into "and"
        /// as well on absence of rupee part in removes that text "AND".
        /// </summary>
        /// <param name="InputCurrencyWord"></param>
        /// <returns></returns>
        public static string FormatNumber2Word(string InputCurrencyWord)
        {
            string[] strCurrency = InputCurrencyWord.Split(' ');
            if (strCurrency.Contains("and") || strCurrency.Contains("AND"))
            {
                strCurrency[Array.IndexOf(strCurrency, "AND")] = "and";
                strCurrency[0] = strCurrency.ElementAt(0) == "and" || strCurrency.ElementAt(0) == "AND" ? string.Empty : strCurrency[0];
                return string.Join(" ", strCurrency);
            }
            else
            {
                return InputCurrencyWord;
            }
        }
        public static long ConvertTo(IDataReader dataReader, out NameValueCollection objCollection)
        {
            long returnCode = -1;
            objCollection = new NameValueCollection();
            //Dictionary<string, string> dictionary = new Dictionary<string, string>();

            try
            {

                while (dataReader.Read())
                {
                    objCollection.Add(dataReader.GetString(0), dataReader.GetString(1));
                    //objCollection.GetKey(Convert.ToInt32(dataReader.GetString(0)));
                    //objCollection.GetValues(dataReader.GetString(1));

                }
                returnCode = 0;
            }
            catch (Exception ex)
            {
                returnCode = 1000;
                CLogger.LogError("Error while executing ConvertTo<dataReader, IDictionary> method in Utilities", ex);
            }
            finally
            {
                dataReader.Close();
            }
            return returnCode;
        }


       
        public void GetApplicationValue(string KeyName, out string KeyValue)
        {
            KeyValue = string.Empty;
            try
            {
                XmlDocument Doc = new XmlDocument();
                if (HttpContext.Current != null)
                {
                    string XMLPath = HttpContext.Current.Request.PhysicalApplicationPath + "\\App_Data\\ApplicationSettings.XML";
                    Doc.Load(XMLPath);
                    XmlNodeList objXmlNodeList = Doc.GetElementsByTagName(KeyName);
                    if (objXmlNodeList != null && objXmlNodeList.Count > 0)
                    {
                        KeyValue = objXmlNodeList[0].InnerText;
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in while GetRequestValue() in Utilities", ex);
            }
        }

        public long GetEncryptedobj(object InputObj, out object OutputObj)
        {
            long rCode = -1;
            OutputObj = new object();
            string Value = string.Empty;
            Hashtable ht = new Hashtable();
            try
            {
                ht.Add("Name", "Name");
                foreach (string Objpt in ht.Keys)
                {
                    PropertyInfo PropInfo = InputObj.GetType().GetProperty(Objpt);
                    if (PropInfo != null)
                    {
                        Object EncValue = PropInfo.GetValue(InputObj, null);

                        Attune.Cryptography.CCryptography obj = new Attune.Cryptography.CCryptFactory().GetEncryptor();
                        obj.Crypt(EncValue.ToString(), out Value);
                        PropInfo.SetValue(InputObj, Value, null);
                    }
                }
                OutputObj = InputObj;
            }
            catch (Exception ex)
            {
                rCode = 1000;
                CLogger.LogError("Error while executing GetEncryptedobj method in Utilities", ex);
            }
            return rCode;
        }
        public long GetDecryptedobj(object InputObj, out object OutputObj)
        {
            long rCode = -1;
            OutputObj = new object();
            string Value = string.Empty;
            Hashtable ht = new Hashtable();
            try
            {
                ht.Add("PatientName", "PatientName");
                ht.Add("Name", "Name");
                foreach (string Objpt in ht.Keys)
                {
                    PropertyInfo PropInfo = InputObj.GetType().GetProperty(Objpt);
                    if (PropInfo != null)
                    {
                        Object EncValue = PropInfo.GetValue(InputObj, null);
                        if (EncValue != null)
                        {
                            Attune.Cryptography.CCryptography obj = new Attune.Cryptography.CCryptFactory().GetDecryptor();
                            obj.Crypt(EncValue.ToString(), out Value);
                        }
                        PropInfo.SetValue(InputObj, Value, null);
                    }
                }
                OutputObj = InputObj;
                rCode = 0;
            }
            catch (Exception ex)
            {
                rCode = 1000;
                CLogger.LogError("Error while executing GetDecryptedobj method in Utilities", ex);
            }
            return rCode;
        }

        public long GetMaskedobj(object InputObj, out object OutputObj)
        {
            long rCode = -1;
            OutputObj = new object();
            string Value = string.Empty;
            Hashtable ht = new Hashtable();
            try
            {

                ht.Add("PatientName", "PatientName");
                ht.Add("Name", "Name");
                foreach (string Objpt in ht.Keys)
                {
                    PropertyInfo PropInfo = InputObj.GetType().GetProperty(Objpt);
                    if (PropInfo != null)
                    {
                        Object EncValue = PropInfo.GetValue(InputObj, null);
                        switch (Objpt)
                        {
                            case "PatientName":
                                Value = "*****";
                                break;
                            case "Name":
                                Value = "*****";
                                break;
                            case "Age":
                                Value = "*";
                                break;
                            default:
                                Value = "-----";
                                break;
                        }
                        PropInfo.SetValue(InputObj, Value, null);
                    }
                }
                OutputObj = InputObj;
                rCode = 0;
            }
            catch (Exception ex)
            {
                rCode = 1000;
                CLogger.LogError("Error while executing GetMaskedobj method in Utilities", ex);
            }
            return rCode;
        }
        public string GetDefaultEntryForDropDownControl(string sResourceFile, string sKey)
        {
            object oDefaultSelect;
            try
            {
                oDefaultSelect = HttpContext.GetGlobalResourceObject(sResourceFile, sKey);
            }
            catch (System.Resources.MissingManifestResourceException)
            {
                oDefaultSelect = null;
            }
            if (oDefaultSelect != null)
                return oDefaultSelect.ToString();
            else
                return string.Empty;
        }

        public static long GetHashTableForBulckRates(long taskActionID, long ClientID, string ClientNaame, out Hashtable displayText, out Hashtable urlValue)
        {
            long returnCode = 0;
            displayText = new Hashtable();
            urlValue = new Hashtable();
            try
            {
                urlValue.Add("CID", ClientID);
                urlValue.Add("CName", ClientNaame);
                urlValue.Add("taskactionid", taskActionID);
                displayText.Add("CName", ClientNaame);

            }
            catch (Exception ex)
            {
                returnCode = -1;
                CLogger.LogError("Error while creating redirect url hashtable ", ex);
            }

            return returnCode;
        }
        public static long GetHashTableWriteOffDDueAmt(long taskActionID, long visitID, long patientID, string PatientName, string feeType, out Hashtable displayText, out Hashtable urlValue, string BillID, string patientNumber)
        {
            long returnCode = 0;
            displayText = new Hashtable();
            urlValue = new Hashtable();
            try
            {
                urlValue.Add("BillID", BillID);
                urlValue.Add("FeeType", feeType);
                urlValue.Add("PatientID", patientID);
                urlValue.Add("PatientVisitID", visitID);
                urlValue.Add("PatientName", PatientName);
                urlValue.Add("PatientNumber", patientNumber);
                urlValue.Add("taskactionid", taskActionID);
                displayText.Add("PatientName", PatientName);
                displayText.Add("PatientNumber", patientNumber);
            }
            catch (Exception ex)
            {
                returnCode = -1;
                CLogger.LogError("Error while creating redirect url hashtable ", ex);
            }

            return returnCode;
        }
    }

    public class EnumUtils
    {
        public static string stringValueOf(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attributes.Length > 0)
            {
                return attributes[0].Description;
            }
            else
            {
                return value.ToString();
            }
        }

        public static object enumValueOf(string value, Type enumType)
        {
            string[] names = Enum.GetNames(enumType);
            foreach (string name in names)
            {
                if (stringValueOf((Enum)Enum.Parse(enumType, name)).Equals(value))
                {
                    return Enum.Parse(enumType, name);
                }
            }

            throw new ArgumentException("The string is not a description or value of the specified enum.");
        } 

     
    }




}
