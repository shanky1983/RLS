﻿using System;
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
 
 
    public class Utilities
    {
        public Utilities()
        {
            //
            // TODO: Add constructor logic here
            //
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


    }
