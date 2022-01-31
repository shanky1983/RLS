using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;

namespace Attune.KernelV2.Utilities
{
    public static class Helper
    {
        public static string CalculateValue(string Str, decimal ConvFactorvalue, int convFactorDecimalPt)
        {
            double Num;
            bool isNum = double.TryParse(Str, out Num);

            if (isNum)
            {
                return Convert.ToString(Math.Round((Convert.ToDecimal(Str) * ConvFactorvalue), convFactorDecimalPt));
            }

            return "0";
        }

        public static string GetHash(string input)
        {
            input = input + "_@Attune_#$)(@";
            HashAlgorithm hashAlgorithm = new SHA256CryptoServiceProvider();

            byte[] byteValue = Encoding.UTF8.GetBytes(input);

            byte[] byteHash = hashAlgorithm.ComputeHash(byteValue);

            return Convert.ToBase64String(byteHash);
        }

        public static string ConvertXmlToShowAllRange(string xmlData, string oRangeType, string uom, string pGender)
        {
            string ReferenceRange = string.Empty;
            try
            {
                uom = uom == "" ? "" : uom;

                string[] CatagoryAgeMain = xmlData.Split('|');

                XElement xe = XElement.Parse(xmlData);

                #region Reference Range
                var ageRange = from age in xe.Elements(oRangeType).Elements("property")
                               where (string)age.Attribute("type") == "age" && ((string)age.Attribute("value")).ToLower() == pGender.ToLower()
                               select age;

                var commonRange = from common in xe.Elements(oRangeType).Elements("property")
                                  where (string)common.Attribute("type") == "common" && ((string)common.Attribute("value")).ToLower() == pGender.ToLower()
                                  select common;

                var otherRange = from other in xe.Elements(oRangeType).Elements("property")
                                 where (string)other.Attribute("type") == "other" && ((string)other.Attribute("value")).ToLower() == pGender.ToLower()
                                 select other;

                var ageRangeBoth = from age in xe.Elements(oRangeType).Elements("property")
                                   where (string)age.Attribute("type") == "age" && ((string)age.Attribute("value")).ToLower() == "Both".ToLower()
                                   select age;

                var commonRangeBoth = from common in xe.Elements(oRangeType).Elements("property")
                                      where (string)common.Attribute("type") == "common" && ((string)common.Attribute("value")).ToLower() == "Both".ToLower()
                                      select common;

                var otherRangeBoth = from other in xe.Elements(oRangeType).Elements("property")
                                     where (string)other.Attribute("type") == "other" && ((string)other.Attribute("value")).ToLower() == "Both".ToLower()
                                     select other;

                if (ageRange != null)
                {
                    foreach (var lst in ageRange)
                    {
                        if (lst.Element("lst") != null)
                        {
                            if (lst.Element("lst").Attribute("mode").Value != "ref")
                            {
                                ReferenceRange += lst.Element("lst").Attribute("gender").Value + ": " + ConvertRangeStringOptr("lst") + " " + lst.Element("lst").Value + " " + lst.Element("lst").Attribute("agetype").Value + " : " + (ConvertRangeStringOptr(lst.Element("lst").FirstAttribute.Value)) + " " + lst.Element("lst").Attribute("value").Value + "<br>";
                            }
                            else
                            {
                                ReferenceRange += lst.Element("lst").Attribute("value").Value;
                            }
                        }
                        if (lst.Element("lsq") != null)
                        {
                            if (lst.Element("lsq").Attribute("mode").Value != "ref")
                            {
                                ReferenceRange += lst.Element("lsq").Attribute("gender").Value + ": " + ConvertRangeStringOptr("lsq") + " " + lst.Element("lsq").Value + " " + lst.Element("lsq").Attribute("agetype").Value + " : " + (ConvertRangeStringOptr(lst.Element("lsq").FirstAttribute.Value)) + " " + lst.Element("lsq").Attribute("value").Value + "<br>";
                            }
                            else
                            {
                                ReferenceRange += lst.Element("lsq").Attribute("value").Value;
                            }
                        }
                        if (lst.Element("eql") != null)
                        {
                            if (lst.Element("eql").Attribute("mode").Value != "ref")
                            {
                                ReferenceRange += lst.Element("eql").Attribute("gender").Value + ": " + ConvertRangeStringOptr("eql") + " " + lst.Element("eql").Value + " " + lst.Element("eql").Attribute("agetype").Value + " : " + (ConvertRangeStringOptr(lst.Element("eql").FirstAttribute.Value)) + " " + lst.Element("eql").Attribute("value").Value + "<br>";
                            }
                            else
                            {
                                ReferenceRange += lst.Element("eql").Attribute("value").Value;
                            }
                        }
                        if (lst.Element("grt") != null)
                        {
                            if (lst.Element("grt").Attribute("mode").Value != "ref")
                            {
                                ReferenceRange += lst.Element("grt").Attribute("gender").Value + ": " + ConvertRangeStringOptr("grt") + " " + lst.Element("grt").Value + " " + lst.Element("grt").Attribute("agetype").Value + " : " + (ConvertRangeStringOptr(lst.Element("grt").FirstAttribute.Value)) + " " + lst.Element("grt").Attribute("value").Value + "<br>";
                            }
                            else
                            {
                                ReferenceRange += lst.Element("grt").Attribute("value").Value;
                            }
                        }
                        if (lst.Element("grq") != null)
                        {
                            if (lst.Element("grq").Attribute("mode").Value != "ref")
                            {
                                ReferenceRange += lst.Element("grq").Attribute("gender").Value + ": " + ConvertRangeStringOptr("grq") + " " + lst.Element("grq").Value + " " + lst.Element("grq").Attribute("agetype").Value + " : " + (ConvertRangeStringOptr(lst.Element("grq").FirstAttribute.Value)) + " " + lst.Element("grq").Attribute("value").Value + "<br>";
                            }
                            else
                            {
                                ReferenceRange += lst.Element("grq").Attribute("value").Value;
                            }
                        }
                        if (lst.Element("btw") != null)
                        {
                            if (lst.Element("btw").Attribute("mode").Value != "ref")
                            {
                                ReferenceRange += lst.Element("btw").Attribute("gender").Value + ": " + ConvertRangeStringOptr("btw") + " " + AddSpace(lst.Element("btw").Value) + " " + lst.Element("btw").Attribute("agetype").Value + " : " + (ConvertRangeStringOptr(lst.Element("btw").FirstAttribute.Value)) + " " + AddSpace(lst.Element("btw").Attribute("value").Value) + "<br>";
                            }
                            else
                            {
                                ReferenceRange += lst.Element("btw").Attribute("value").Value;
                            }
                        }
                    }
                }

                if (ageRangeBoth != null)
                {
                    foreach (var lst in ageRangeBoth)
                    {
                        if (lst.Element("lst") != null)
                        {
                            if (lst.Element("lst").Attribute("mode").Value != "ref")
                            {
                                ReferenceRange += lst.Element("lst").Attribute("gender").Value + ": " + ConvertRangeStringOptr("lst") + " " + lst.Element("lst").Value + " " + lst.Element("lst").Attribute("agetype").Value + " : " + (ConvertRangeStringOptr(lst.Element("lst").FirstAttribute.Value)) + " " + lst.Element("lst").Attribute("value").Value + "<br>";
                            }
                            else
                            {
                                ReferenceRange += lst.Element("lst").Attribute("value").Value;
                            }
                        }
                        if (lst.Element("lsq") != null)
                        {
                            if (lst.Element("lsq").Attribute("mode").Value != "ref")
                            {
                                ReferenceRange += lst.Element("lsq").Attribute("gender").Value + ": " + ConvertRangeStringOptr("lsq") + " " + lst.Element("lsq").Value + " " + lst.Element("lsq").Attribute("agetype").Value + " : " + (ConvertRangeStringOptr(lst.Element("lsq").FirstAttribute.Value)) + " " + lst.Element("lsq").Attribute("value").Value + "<br>";
                            }
                            else
                            {
                                ReferenceRange += lst.Element("lsq").Attribute("value").Value;
                            }
                        }
                        if (lst.Element("eql") != null)
                        {
                            if (lst.Element("eql").Attribute("mode").Value != "ref")
                            {
                                ReferenceRange += lst.Element("eql").Attribute("gender").Value + ": " + ConvertRangeStringOptr("eql") + " " + lst.Element("eql").Value + " " + lst.Element("eql").Attribute("agetype").Value + " : " + (ConvertRangeStringOptr(lst.Element("eql").FirstAttribute.Value)) + " " + lst.Element("eql").Attribute("value").Value + "<br>";
                            }
                            else
                            {
                                ReferenceRange += lst.Element("eql").Attribute("value").Value;
                            }
                        }
                        if (lst.Element("grt") != null)
                        {
                            if (lst.Element("grt").Attribute("mode").Value != "ref")
                            {
                                ReferenceRange += lst.Element("grt").Attribute("gender").Value + ": " + ConvertRangeStringOptr("grt") + " " + lst.Element("grt").Value + " " + lst.Element("grt").Attribute("agetype").Value + " : " + (ConvertRangeStringOptr(lst.Element("grt").FirstAttribute.Value)) + " " + lst.Element("grt").Attribute("value").Value + "<br>";
                            }
                            else
                            {
                                ReferenceRange += lst.Element("grt").Attribute("value").Value;
                            }
                        }
                        if (lst.Element("grq") != null)
                        {
                            if (lst.Element("grq").Attribute("mode").Value != "ref")
                            {
                                ReferenceRange += lst.Element("grq").Attribute("gender").Value + ": " + ConvertRangeStringOptr("grq") + " " + lst.Element("grq").Value + " " + lst.Element("grq").Attribute("agetype").Value + " : " + (ConvertRangeStringOptr(lst.Element("grq").FirstAttribute.Value)) + " " + lst.Element("grq").Attribute("value").Value + "<br>";
                            }
                            else
                            {
                                ReferenceRange += lst.Element("grq").Attribute("value").Value;
                            }
                        }
                        if (lst.Element("btw") != null)
                        {
                            if (lst.Element("btw").Attribute("mode").Value != "ref")
                            {
                                ReferenceRange += lst.Element("btw").Attribute("gender").Value + ": " + ConvertRangeStringOptr("btw") + " " + AddSpace(lst.Element("btw").Value) + " " + lst.Element("btw").Attribute("agetype").Value + " : " + (ConvertRangeStringOptr(lst.Element("btw").FirstAttribute.Value)) + " " + AddSpace(lst.Element("btw").Attribute("value").Value) + "<br>";
                            }
                            else
                            {
                                ReferenceRange += lst.Element("btw").Attribute("value").Value;
                            }
                        }
                    }
                }

                if (commonRange != null)
                {
                    foreach (var lst in commonRange)
                    {
                        if (lst.Element("lst") != null)
                        {
                            ReferenceRange += lst.Element("lst").FirstAttribute.Value + ": < " + lst.Element("lst").Value + "<br>";
                        }
                        if (lst.Element("lsq") != null)
                        {
                            ReferenceRange += lst.Element("lsq").FirstAttribute.Value + ": <= " + lst.Element("lsq").Value + "<br>";
                        }
                        if (lst.Element("eql") != null)
                        {
                            ReferenceRange += lst.Element("eql").FirstAttribute.Value + ": = " + lst.Element("eql").Value + "<br>";
                        }
                        if (lst.Element("grt") != null)
                        {
                            ReferenceRange += lst.Element("grt").FirstAttribute.Value + ": > " + lst.Element("grt").Value + "<br>";
                        }
                        if (lst.Element("grq") != null)
                        {
                            ReferenceRange += lst.Element("grq").FirstAttribute.Value + ": => " + lst.Element("grq").Value + "<br>";
                        }
                        if (lst.Element("btw") != null)
                        {
                            ReferenceRange += lst.Element("btw").FirstAttribute.Value + ": " + AddSpace(lst.Element("btw").Value) + "<br>";
                        }
                        if (lst.Element("ref") != null)
                        {
                            ReferenceRange += lst.Element("ref").Value + "<br>";
                        }
                    }
                }

                if (commonRangeBoth != null)
                {
                    foreach (var lst in commonRangeBoth)
                    {
                        if (lst.Element("lst") != null)
                        {
                            ReferenceRange += lst.Element("lst").FirstAttribute.Value + ": < " + lst.Element("lst").Value + "<br>";
                        }
                        if (lst.Element("lsq") != null)
                        {
                            ReferenceRange += lst.Element("lsq").FirstAttribute.Value + ": <= " + lst.Element("lsq").Value + "<br>";
                        }
                        if (lst.Element("eql") != null)
                        {
                            ReferenceRange += lst.Element("eql").FirstAttribute.Value + ": = " + lst.Element("eql").Value + "<br>";
                        }
                        if (lst.Element("grt") != null)
                        {
                            ReferenceRange += lst.Element("grt").FirstAttribute.Value + ": > " + lst.Element("grt").Value + "<br>";
                        }
                        if (lst.Element("grq") != null)
                        {
                            ReferenceRange += lst.Element("grq").FirstAttribute.Value + ": => " + lst.Element("grq").Value + "<br>";
                        }
                        if (lst.Element("btw") != null)
                        {
                            ReferenceRange += lst.Element("btw").FirstAttribute.Value + ": " + AddSpace(lst.Element("btw").Value) + "<br>";
                        }
                        if (lst.Element("ref") != null)
                        {
                            ReferenceRange += lst.Element("ref").Value + "<br>";
                        }
                    }
                }

                if (otherRange != null)
                {
                    foreach (var lst in otherRange)
                    {
                        if (lst.Element("lst") != null)
                        {
                            ReferenceRange += lst.Element("lst").FirstAttribute.Value + ": " + lst.Element("lst").Value + ": < " + lst.Element("lst").LastAttribute.Value + "<br>";

                        }
                        if (lst.Element("lsq") != null)
                        {
                            ReferenceRange += lst.Element("lsq").FirstAttribute.Value + ": " + lst.Element("lsq").Value + ": <= " + lst.Element("lsq").LastAttribute.Value + "<br>";
                        }
                        if (lst.Element("eql") != null)
                        {
                            ReferenceRange += lst.Element("eql").FirstAttribute.Value + ": " + lst.Element("eql").Value + ": = " + lst.Element("eql").LastAttribute.Value + "<br>";
                        }
                        if (lst.Element("grt") != null)
                        {
                            ReferenceRange += lst.Element("grt").FirstAttribute.Value + ": " + lst.Element("grt").Value + ": > " + lst.Element("grt").LastAttribute.Value + "<br>";
                        }
                        if (lst.Element("grq") != null)
                        {
                            ReferenceRange += lst.Element("grq").FirstAttribute.Value + ": " + lst.Element("grq").Value + ": >= " + lst.Element("grq").LastAttribute.Value + "<br>";
                        }
                        if (lst.Element("btw") != null)
                        {
                            ReferenceRange += lst.Element("btw").FirstAttribute.Value + ": " + lst.Element("btw").Value + ": " + AddSpace(lst.Element("btw").LastAttribute.Value) + "<br>";
                        }
                        if (lst.Element("ref") != null)
                        {
                            ReferenceRange += lst.Element("ref").Value + "<br>";
                        }
                    }
                }

                if (otherRangeBoth != null)
                {
                    foreach (var lst in otherRangeBoth)
                    {
                        if (lst.Element("lst") != null)
                        {
                            ReferenceRange += lst.Element("lst").FirstAttribute.Value + ": " + lst.Element("lst").Value + ": < " + lst.Element("lst").LastAttribute.Value + "<br>";
                        }
                        if (lst.Element("lsq") != null)
                        {
                            ReferenceRange += lst.Element("lsq").FirstAttribute.Value + ": " + lst.Element("lsq").Value + ": <= " + lst.Element("lsq").LastAttribute.Value + "<br>";
                        }
                        if (lst.Element("eql") != null)
                        {
                            ReferenceRange += lst.Element("eql").FirstAttribute.Value + ": " + lst.Element("eql").Value + ": = " + lst.Element("eql").LastAttribute.Value + "<br>";
                        }
                        if (lst.Element("grt") != null)
                        {
                            ReferenceRange += lst.Element("grt").FirstAttribute.Value + ": " + lst.Element("grt").Value + ": > " + lst.Element("grt").LastAttribute.Value + "<br>";
                        }
                        if (lst.Element("grq") != null)
                        {
                            ReferenceRange += lst.Element("grq").FirstAttribute.Value + ": " + lst.Element("grq").Value + ": >= " + lst.Element("grq").LastAttribute.Value + "<br>";
                        }
                        if (lst.Element("btw") != null)
                        {
                            ReferenceRange += lst.Element("btw").FirstAttribute.Value + ": " + lst.Element("btw").Value + ": " + AddSpace(lst.Element("btw").LastAttribute.Value) + "<br>";
                        }
                        if (lst.Element("ref") != null)
                        {
                            ReferenceRange += lst.Element("ref").Value + "<br>";
                        }
                    }
                }

                if (ReferenceRange == "")
                {
                    XElement xer = XElement.Parse(xmlData);

                    if (xe.Elements(oRangeType).Elements("property") != null)
                    {
                        ReferenceRange = "";
                    }
                    else
                    {
                        ReferenceRange = xmlData;
                    }
                }
                #endregion
            }
            catch (Exception ex)
            {
                ReferenceRange = string.Empty;
                throw ex;
                //return ex.ToString();
            }
            return ReferenceRange;
        }

        public static string ConvertXmlToString(string xmlData, string uom, string Gender, string Age)
        {
            string NormalReferenceRange = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(xmlData) && TryParseXml(xmlData))
                {

                    string OtherReferenceRange = string.Empty;
                    string PrintableRange = string.Empty;

                    string ReferenceRange = string.Empty;
                    List<string> lstRangeType = new List<string>();
                    lstRangeType.Add("referencerange");
                    lstRangeType.Add("printablerange");
                    lstRangeType.Add("panicrange");
                    uom = uom == "" ? "" : uom;
                    string pGender = string.Empty;
                    pGender = !string.IsNullOrEmpty(Gender) && Gender != "0" ? ((Gender == "F" || Gender == "Female") ? "Female" : "Male") : string.Empty;
                    string[] lstAge = Age.Split(' ');
                    string[] pSpecies = lstAge[1].Split('*');
                    string pSpecType = pSpecies[0];
                    string pAge = string.Empty;
                    string pAgetype = string.Empty;
                    if (lstAge != null && lstAge.Count() > 0)
                    {
                        pAge = lstAge[0];
                        pAgetype = lstAge.Count() > 1 && pSpecies[0] != null ? pSpecies[0].Replace("(", "").Replace(")", "") : "";
                    }
                    string[] CatagoryAgeMain = xmlData.Split('|');

                    XElement xe = XElement.Parse(xmlData);

                    foreach (string oRangeType in lstRangeType)
                    {
                        ReferenceRange = string.Empty;

                        var Range = from range in xe.Elements(oRangeType).Elements("property")
                                    select range;
                        if (Range != null && Range.Count() > 0)
                        {
                            var commonRange = from common in xe.Elements(oRangeType).Elements("property")
                                              where (string)common.Attribute("type") == "common" && ((string)common.Attribute("value")).ToLower() == pGender.ToLower()
                                              select common;

                            var commonRangeBoth = from common in xe.Elements(oRangeType).Elements("property")
                                                  where (string)common.Attribute("type") == "common" && ((string)common.Attribute("value")).ToLower() == "Both".ToLower()
                                                  select common;

                            var commonRangeSelectAll = from common in xe.Elements(oRangeType).Elements("property")
                                                       where (string)common.Attribute("type") == "common" && ((string)common.Attribute("value")).ToLower() == "SelectAll".ToLower()
                                                       select common;

                            var commonRangeOthers = from common in xe.Elements(oRangeType).Elements("property")
                                                    where (string)common.Attribute("type") == "common" && ((string)common.Attribute("value")).ToLower() == "Others".ToLower()
                                                    select common;

                            var otherRange = from other in xe.Elements(oRangeType).Elements("property")
                                             where (string)other.Attribute("type") == "other" && ((string)other.Attribute("value")).ToLower() == pGender.ToLower() && (string)other.Attribute("ResultType") != "Text" && (string)other.Attribute("agetype") == null
                                             select other;

                            var otherRangeBoth = from other in xe.Elements(oRangeType).Elements("property")
                                                 where (string)other.Attribute("type") == "other" && ((string)other.Attribute("value")).ToLower() == "Both".ToLower() && (string)other.Attribute("ResultType") != "Text" && (string)other.Attribute("agetype") == null
                                                 select other;

                            var otherRangeText = from other in xe.Elements(oRangeType).Elements("property")
                                                 where (string)other.Attribute("type") == "other" && ((string)other.Attribute("value")).ToLower() == pGender.ToLower() && (string)other.Attribute("ResultType") == "Text" && (string)other.Attribute("agetype") == null
                                                 select other;

                            var otherRangeBothText = from other in xe.Elements(oRangeType).Elements("property")
                                                     where (string)other.Attribute("type") == "other" && ((string)other.Attribute("value")).ToLower() == "Both".ToLower() && (string)other.Attribute("ResultType") == "Text" && (string)other.Attribute("agetype") == null
                                                     select other;

                            if (!string.IsNullOrEmpty(pAge))
                            {
                                double patientAgeInDays = ConvertToDays(Convert.ToDouble(pAge), pAgetype);

                                var ageRange = from age in xe.Elements(oRangeType).Elements("property")
                                               where (string)age.Attribute("type") == "age" && ((string)age.Attribute("value")).ToLower() == pGender.ToLower()
                                               select age;

                                var ageRangeBoth = from age in xe.Elements(oRangeType).Elements("property")
                                                   where (string)age.Attribute("type") == "age" && ((string)age.Attribute("value")).ToLower() == "Both".ToLower()
                                                   select age;

                                var ageRangeSelectAll = from age in xe.Elements(oRangeType).Elements("property")
                                                        where (string)age.Attribute("type") == "age" && ((string)age.Attribute("value")).ToLower() == "SelectAll".ToLower()
                                                        select age;

                                var ageRangeOthers = from age in xe.Elements(oRangeType).Elements("property")
                                                     where (string)age.Attribute("type") == "age" && ((string)age.Attribute("value")).ToLower() == "Others".ToLower()
                                                     select age;

                                var otherRangeWithAge = from other in xe.Elements(oRangeType).Elements("property")
                                                        where (string)other.Attribute("type") == "other" && ((string)other.Attribute("value")).ToLower() == pGender.ToLower() && (string)other.Attribute("ResultType") != "Text" && (string)other.Attribute("agetype") != null
                                                        select other;

                                var otherRangeBothWithAge = from other in xe.Elements(oRangeType).Elements("property")
                                                            where (string)other.Attribute("type") == "other" && ((string)other.Attribute("value")).ToLower() == "Both".ToLower() && (string)other.Attribute("ResultType") != "Text" && (string)other.Attribute("agetype") != null
                                                            select other;
                                var otherRangeTextWithAge = from other in xe.Elements(oRangeType).Elements("property")
                                                            where (string)other.Attribute("type") == "other" && ((string)other.Attribute("value")).ToLower() == pGender.ToLower() && (string)other.Attribute("ResultType") == "Text" && (string)other.Attribute("agetype") != null
                                                            select other;

                                var otherRangeBothTextWithAge = from other in xe.Elements(oRangeType).Elements("property")
                                                                where (string)other.Attribute("type") == "other" && ((string)other.Attribute("value")).ToLower() == "Both".ToLower() && (string)other.Attribute("ResultType") == "Text" && (string)other.Attribute("agetype") != null
                                                                select other;

                                if (ageRange != null && ageRange.Count() > 0)
                                {
                                    foreach (var lst in ageRange)
                                    {
                                        if (lst.Element("lst") != null)
                                        {
                                            if (lst.Element("lst").LastAttribute.Value == lst.Element("lst").Attribute("value").Value)
                                            {
                                                if (patientAgeInDays < ConvertToDays(Convert.ToDouble(lst.Element("lst").Value), lst.Element("lst").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                {
                                                    if (lst.Element("lst").Attribute("mode").Value != "ref")
                                                    {
                                                        ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("lst").FirstAttribute.Value)) + " " + lst.Element("lst").Attribute("value").Value + "<br>";
                                                    }
                                                    else
                                                    {
                                                        ReferenceRange += lst.Element("lst").Attribute("value").Value + "<br>";
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                string spec = lst.Element("lst").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        if (patientAgeInDays < ConvertToDays(Convert.ToDouble(lst.Element("lst").Value), lst.Element("lst").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                        {
                                                            if (lst.Element("lst").Attribute("mode").Value != "ref")
                                                            {
                                                                ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("lst").FirstAttribute.Value)) + " " + lst.Element("lst").Attribute("value").Value + "<br>";
                                                            }
                                                            else
                                                            {
                                                                ReferenceRange += lst.Element("lst").Attribute("value").Value + "<br>";
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        if (lst.Element("lsq") != null)
                                        {

                                            if (lst.Element("lsq").LastAttribute.Value == lst.Element("lsq").Attribute("value").Value)
                                            {
                                                if (patientAgeInDays <= ConvertToDays(Convert.ToDouble(lst.Element("lsq").Value), lst.Element("lsq").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                {
                                                    if (lst.Element("lsq").Attribute("mode").Value != "ref")
                                                    {
                                                        ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("lsq").FirstAttribute.Value)) + " " + lst.Element("lsq").Attribute("value").Value + "<br>";
                                                    }
                                                    else
                                                    {
                                                        ReferenceRange += lst.Element("lsq").Attribute("value").Value + "<br>";
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                string spec = lst.Element("lsq").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        if (patientAgeInDays <= ConvertToDays(Convert.ToDouble(lst.Element("lsq").Value), lst.Element("lsq").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                        {
                                                            if (lst.Element("lsq").Attribute("mode").Value != "ref")
                                                            {
                                                                ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("lsq").FirstAttribute.Value)) + " " + lst.Element("lsq").Attribute("value").Value + "<br>";
                                                            }
                                                            else
                                                            {
                                                                ReferenceRange += lst.Element("lsq").Attribute("value").Value + "<br>";
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        if (lst.Element("eql") != null)
                                        {
                                            if (lst.Element("eql").LastAttribute.Value == lst.Element("eql").Attribute("value").Value)
                                            {
                                                if (patientAgeInDays == ConvertToDays(Convert.ToDouble(lst.Element("eql").Value), lst.Element("eql").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                {
                                                    if (lst.Element("eql").Attribute("mode").Value != "ref")
                                                    {
                                                        ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("eql").FirstAttribute.Value)) + " " + lst.Element("eql").Attribute("value").Value + "<br>";
                                                    }
                                                    else
                                                    {
                                                        ReferenceRange += lst.Element("eql").Attribute("value").Value + "<br>";
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                string spec = lst.Element("eql").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        if (patientAgeInDays == ConvertToDays(Convert.ToDouble(lst.Element("eql").Value), lst.Element("eql").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                        {
                                                            if (lst.Element("eql").Attribute("mode").Value != "ref")
                                                            {
                                                                ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("eql").FirstAttribute.Value)) + " " + lst.Element("eql").Attribute("value").Value + "<br>";
                                                            }
                                                            else
                                                            {
                                                                ReferenceRange += lst.Element("eql").Attribute("value").Value + "<br>";
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        if (lst.Element("grt") != null)
                                        {
                                            if (lst.Element("grt").LastAttribute.Value == lst.Element("grt").Attribute("value").Value)
                                            {
                                                if (patientAgeInDays > ConvertToDays(Convert.ToDouble(lst.Element("grt").Value), lst.Element("grt").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                {
                                                    if (lst.Element("grt").Attribute("mode").Value != "ref")
                                                    {
                                                        ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("grt").FirstAttribute.Value)) + " " + lst.Element("grt").Attribute("value").Value + "<br>";
                                                    }
                                                    else
                                                    {
                                                        ReferenceRange += lst.Element("grt").Attribute("value").Value + "<br>";
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                string spec = lst.Element("grt").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        if (patientAgeInDays > ConvertToDays(Convert.ToDouble(lst.Element("grt").Value), lst.Element("grt").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                        {
                                                            if (lst.Element("grt").Attribute("mode").Value != "ref")
                                                            {
                                                                ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("grt").FirstAttribute.Value)) + " " + lst.Element("grt").Attribute("value").Value + "<br>";
                                                            }
                                                            else
                                                            {
                                                                ReferenceRange += lst.Element("grt").Attribute("value").Value + "<br>";
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        if (lst.Element("grq") != null)
                                        {
                                            if (lst.Element("grq").LastAttribute.Value == lst.Element("grq").Attribute("value").Value)
                                            {
                                                if (patientAgeInDays >= ConvertToDays(Convert.ToDouble(lst.Element("grq").Value), lst.Element("grq").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                {
                                                    if (lst.Element("grq").Attribute("mode").Value != "ref")
                                                    {
                                                        ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("grq").FirstAttribute.Value)) + " " + lst.Element("grq").Attribute("value").Value + "<br>";
                                                    }
                                                    else
                                                    {
                                                        ReferenceRange += lst.Element("grq").Attribute("value").Value + "<br>";
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                string spec = lst.Element("grq").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        if (patientAgeInDays >= ConvertToDays(Convert.ToDouble(lst.Element("grq").Value), lst.Element("grq").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                        {
                                                            if (lst.Element("grq").Attribute("mode").Value != "ref")
                                                            {
                                                                ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("grq").FirstAttribute.Value)) + " " + lst.Element("grq").Attribute("value").Value + "<br>";
                                                            }
                                                            else
                                                            {
                                                                ReferenceRange += lst.Element("grq").Attribute("value").Value + "<br>";
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        if (lst.Element("btw") != null)
                                        {
                                            if (lst.Element("btw").LastAttribute.Value == lst.Element("btw").Attribute("value").Value)
                                            {
                                                string[] between = lst.Element("btw").Value.Split('-');
                                                if (patientAgeInDays > ConvertToDays(Convert.ToDouble(between[0]), lst.Element("btw").Attribute("agetype").Value.Replace("(", "").Replace(")", "")) && patientAgeInDays <= ConvertToDays(Convert.ToDouble(between[1]), lst.Element("btw").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                {
                                                    if (lst.Element("btw").Attribute("mode").Value != "ref")
                                                    {
                                                        ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("btw").FirstAttribute.Value)) + " " + lst.Element("btw").Attribute("value").Value + "<br>";
                                                    }
                                                    else
                                                    {
                                                        ReferenceRange += lst.Element("btw").Attribute("value").Value + "<br>";
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                string spec = lst.Element("btw").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        string[] between = lst.Element("btw").Value.Split('-');
                                                        if (patientAgeInDays > ConvertToDays(Convert.ToDouble(between[0]), lst.Element("btw").Attribute("agetype").Value.Replace("(", "").Replace(")", "")) && patientAgeInDays <= ConvertToDays(Convert.ToDouble(between[1]), lst.Element("btw").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                        {
                                                            if (lst.Element("btw").Attribute("mode").Value != "ref")
                                                            {
                                                                ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("btw").FirstAttribute.Value)) + " " + lst.Element("btw").Attribute("value").Value + "<br>";
                                                            }
                                                            else
                                                            {
                                                                ReferenceRange += lst.Element("btw").Attribute("value").Value + "<br>";
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                else if (ageRangeBoth != null && ageRangeBoth.Count() > 0)
                                {
                                    foreach (var lst in ageRangeBoth)
                                    {

                                        if (lst.Element("lst") != null)
                                        {
                                            if (lst.Element("lst").LastAttribute.Value == lst.Element("lst").Attribute("value").Value)
                                            {
                                                if (patientAgeInDays < ConvertToDays(Convert.ToDouble(lst.Element("lst").Value), lst.Element("lst").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                {
                                                    if (lst.Element("lst").Attribute("mode").Value != "ref")
                                                    {
                                                        ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("lst").FirstAttribute.Value)) + " " + lst.Element("lst").Attribute("value").Value + "<br>";
                                                    }
                                                    else
                                                    {
                                                        ReferenceRange += lst.Element("lst").Attribute("value").Value + "<br>";
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                string spec = lst.Element("lst").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {

                                                        if (patientAgeInDays < ConvertToDays(Convert.ToDouble(lst.Element("lst").Value), lst.Element("lst").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                        {
                                                            if (lst.Element("lst").Attribute("mode").Value != "ref")
                                                            {
                                                                ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("lst").FirstAttribute.Value)) + " " + lst.Element("lst").Attribute("value").Value + "<br>";
                                                            }
                                                            else
                                                            {
                                                                ReferenceRange += lst.Element("lst").Attribute("value").Value + "<br>";
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }

                                        if (lst.Element("lsq") != null)
                                        {
                                            if (lst.Element("lsq").LastAttribute.Value == lst.Element("lsq").Attribute("value").Value)
                                            {
                                                if (patientAgeInDays <= ConvertToDays(Convert.ToDouble(lst.Element("lsq").Value), lst.Element("lsq").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                {
                                                    if (lst.Element("lsq").Attribute("mode").Value != "ref")
                                                    {
                                                        ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("lsq").FirstAttribute.Value)) + " " + lst.Element("lsq").Attribute("value").Value + "<br>";
                                                    }
                                                    else
                                                    {
                                                        ReferenceRange += lst.Element("lsq").Attribute("value").Value + "<br>";
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                string spec = lst.Element("lsq").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {

                                                        if (patientAgeInDays <= ConvertToDays(Convert.ToDouble(lst.Element("lsq").Value), lst.Element("lsq").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                        {
                                                            if (lst.Element("lsq").Attribute("mode").Value != "ref")
                                                            {
                                                                ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("lsq").FirstAttribute.Value)) + " " + lst.Element("lsq").Attribute("value").Value + "<br>";
                                                            }
                                                            else
                                                            {
                                                                ReferenceRange += lst.Element("lsq").Attribute("value").Value + "<br>";
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }

                                        if (lst.Element("eql") != null)
                                        {
                                            if (lst.Element("eql").LastAttribute.Value == lst.Element("eql").Attribute("value").Value)
                                            {
                                                if (patientAgeInDays == ConvertToDays(Convert.ToDouble(lst.Element("eql").Value), lst.Element("eql").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                {
                                                    if (lst.Element("eql").Attribute("mode").Value != "ref")
                                                    {
                                                        ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("eql").FirstAttribute.Value)) + " " + lst.Element("eql").Attribute("value").Value + "<br>";
                                                    }
                                                    else
                                                    {
                                                        ReferenceRange += lst.Element("eql").Attribute("value").Value + "<br>";
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                string spec = lst.Element("eql").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        if (patientAgeInDays == ConvertToDays(Convert.ToDouble(lst.Element("eql").Value), lst.Element("eql").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                        {
                                                            if (lst.Element("eql").Attribute("mode").Value != "ref")
                                                            {
                                                                ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("eql").FirstAttribute.Value)) + " " + lst.Element("eql").Attribute("value").Value + "<br>";
                                                            }
                                                            else
                                                            {
                                                                ReferenceRange += lst.Element("eql").Attribute("value").Value + "<br>";
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }

                                        if (lst.Element("grt") != null)
                                        {
                                            if (lst.Element("grt").LastAttribute.Value == lst.Element("grt").Attribute("value").Value)
                                            {
                                                if (patientAgeInDays > ConvertToDays(Convert.ToDouble(lst.Element("grt").Value), lst.Element("grt").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                {
                                                    if (lst.Element("grt").Attribute("mode").Value != "ref")
                                                    {
                                                        ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("grt").FirstAttribute.Value)) + " " + lst.Element("grt").Attribute("value").Value + "<br>";
                                                    }
                                                    else
                                                    {
                                                        ReferenceRange += lst.Element("grt").Attribute("value").Value + "<br>";
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                string spec = lst.Element("grt").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        if (patientAgeInDays > ConvertToDays(Convert.ToDouble(lst.Element("grt").Value), lst.Element("grt").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                        {
                                                            if (lst.Element("grt").Attribute("mode").Value != "ref")
                                                            {
                                                                ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("grt").FirstAttribute.Value)) + " " + lst.Element("grt").Attribute("value").Value + "<br>";
                                                            }
                                                            else
                                                            {
                                                                ReferenceRange += lst.Element("grt").Attribute("value").Value + "<br>";
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }

                                        if (lst.Element("grq") != null)
                                        {
                                            if (lst.Element("grq").LastAttribute.Value == lst.Element("grq").Attribute("value").Value)
                                            {
                                                if (patientAgeInDays >= ConvertToDays(Convert.ToDouble(lst.Element("grq").Value), lst.Element("grq").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                {
                                                    if (lst.Element("grq").Attribute("mode").Value != "ref")
                                                    {
                                                        ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("grq").FirstAttribute.Value)) + " " + lst.Element("grq").Attribute("value").Value + "<br>";
                                                    }
                                                    else
                                                    {
                                                        ReferenceRange += lst.Element("grq").Attribute("value").Value + "<br>";
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                string spec = lst.Element("grq").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        if (patientAgeInDays >= ConvertToDays(Convert.ToDouble(lst.Element("grq").Value), lst.Element("grq").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                        {
                                                            if (lst.Element("grq").Attribute("mode").Value != "ref")
                                                            {
                                                                ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("grq").FirstAttribute.Value)) + " " + lst.Element("grq").Attribute("value").Value + "<br>";
                                                            }
                                                            else
                                                            {
                                                                ReferenceRange += lst.Element("grq").Attribute("value").Value + "<br>";
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }

                                        if (lst.Element("btw") != null)
                                        {
                                            if (lst.Element("btw").LastAttribute.Value == lst.Element("btw").Attribute("value").Value)
                                            {
                                                string[] between = lst.Element("btw").Value.Split('-');
                                                if (patientAgeInDays > ConvertToDays(Convert.ToDouble(between[0]), lst.Element("btw").Attribute("agetype").Value.Replace("(", "").Replace(")", "")) && patientAgeInDays <= ConvertToDays(Convert.ToDouble(between[1]), lst.Element("btw").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                {
                                                    if (lst.Element("btw").Attribute("mode").Value != "ref")
                                                    {
                                                        ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("btw").FirstAttribute.Value)) + " " + lst.Element("btw").Attribute("value").Value + "<br>";
                                                        //ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("btw").FirstAttribute.Value)) + " " + lst.Element("btw").LastAttribute.Value + "<br>";
                                                    }
                                                    else
                                                    {
                                                        ReferenceRange += lst.Element("btw").Attribute("value").Value + "<br>";
                                                        //ReferenceRange += lst.Element("btw").LastAttribute.Value + "<br>";
                                                    }
                                                }
                                            }
                                            else
                                            {

                                                string spec = lst.Element("btw").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        string[] between = lst.Element("btw").Value.Split('-');
                                                        if (patientAgeInDays > ConvertToDays(Convert.ToDouble(between[0]), lst.Element("btw").Attribute("agetype").Value.Replace("(", "").Replace(")", "")) && patientAgeInDays <= ConvertToDays(Convert.ToDouble(between[1]), lst.Element("btw").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                        {
                                                            if (lst.Element("btw").Attribute("mode").Value != "ref")
                                                            {
                                                                ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("btw").FirstAttribute.Value)) + " " + lst.Element("btw").Attribute("value").Value + "<br>";
                                                                //ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("btw").FirstAttribute.Value)) + " " + lst.Element("btw").LastAttribute.Value + "<br>";
                                                            }
                                                            else
                                                            {
                                                                ReferenceRange += lst.Element("btw").Attribute("value").Value + "<br>";
                                                                //ReferenceRange += lst.Element("btw").LastAttribute.Value + "<br>";
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                else if (ageRangeSelectAll != null && ageRangeSelectAll.Count() > 0)
                                {
                                    foreach (var lst in ageRangeSelectAll)
                                    {
                                        if (lst.Element("lst") != null)
                                        {
                                            if (lst.Element("lst").LastAttribute.Value == lst.Element("lst").Attribute("value").Value)
                                            {
                                                if (patientAgeInDays < ConvertToDays(Convert.ToDouble(lst.Element("lst").Value), lst.Element("lst").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                {
                                                    if (lst.Element("lst").Attribute("mode").Value != "ref")
                                                    {
                                                        ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("lst").FirstAttribute.Value)) + " " + lst.Element("lst").Attribute("value").Value + "<br>";
                                                    }
                                                    else
                                                    {
                                                        ReferenceRange += lst.Element("lst").Attribute("value").Value + "<br>";
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                string spec = lst.Element("lst").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        if (patientAgeInDays < ConvertToDays(Convert.ToDouble(lst.Element("lst").Value), lst.Element("lst").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                        {
                                                            if (lst.Element("lst").Attribute("mode").Value != "ref")
                                                            {
                                                                ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("lst").FirstAttribute.Value)) + " " + lst.Element("lst").Attribute("value").Value + "<br>";
                                                            }
                                                            else
                                                            {
                                                                ReferenceRange += lst.Element("lst").Attribute("value").Value + "<br>";
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        if (lst.Element("lsq") != null)
                                        {
                                            if (lst.Element("lsq").LastAttribute.Value == lst.Element("lsq").Attribute("value").Value)
                                            {
                                                if (patientAgeInDays <= ConvertToDays(Convert.ToDouble(lst.Element("lsq").Value), lst.Element("lsq").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                {
                                                    if (lst.Element("lsq").Attribute("mode").Value != "ref")
                                                    {
                                                        ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("lsq").FirstAttribute.Value)) + " " + lst.Element("lsq").Attribute("value").Value + "<br>";
                                                    }
                                                    else
                                                    {
                                                        ReferenceRange += lst.Element("lsq").Attribute("value").Value + "<br>";
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                string spec = lst.Element("lsq").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        if (patientAgeInDays <= ConvertToDays(Convert.ToDouble(lst.Element("lsq").Value), lst.Element("lsq").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                        {
                                                            if (lst.Element("lsq").Attribute("mode").Value != "ref")
                                                            {
                                                                ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("lsq").FirstAttribute.Value)) + " " + lst.Element("lsq").Attribute("value").Value + "<br>";
                                                            }
                                                            else
                                                            {
                                                                ReferenceRange += lst.Element("lsq").Attribute("value").Value + "<br>";
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        if (lst.Element("eql") != null)
                                        {
                                            if (lst.Element("eql").LastAttribute.Value == lst.Element("eql").Attribute("value").Value)
                                            {
                                                if (patientAgeInDays == ConvertToDays(Convert.ToDouble(lst.Element("eql").Value), lst.Element("eql").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                {
                                                    if (lst.Element("eql").Attribute("mode").Value != "ref")
                                                    {
                                                        ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("eql").FirstAttribute.Value)) + " " + lst.Element("eql").Attribute("value").Value + "<br>";
                                                    }
                                                    else
                                                    {
                                                        ReferenceRange += lst.Element("eql").Attribute("value").Value + "<br>";
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                string spec = lst.Element("eql").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        if (patientAgeInDays == ConvertToDays(Convert.ToDouble(lst.Element("eql").Value), lst.Element("eql").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                        {
                                                            if (lst.Element("eql").Attribute("mode").Value != "ref")
                                                            {
                                                                ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("eql").FirstAttribute.Value)) + " " + lst.Element("eql").Attribute("value").Value + "<br>";
                                                            }
                                                            else
                                                            {
                                                                ReferenceRange += lst.Element("eql").Attribute("value").Value + "<br>";
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        if (lst.Element("grt") != null)
                                        {
                                            if (lst.Element("grt").LastAttribute.Value == lst.Element("grt").Attribute("value").Value)
                                            {
                                                if (patientAgeInDays > ConvertToDays(Convert.ToDouble(lst.Element("grt").Value), lst.Element("grt").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                {
                                                    if (lst.Element("grt").Attribute("mode").Value != "ref")
                                                    {
                                                        ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("grt").FirstAttribute.Value)) + " " + lst.Element("grt").Attribute("value").Value + "<br>";
                                                    }
                                                    else
                                                    {
                                                        ReferenceRange += lst.Element("grt").Attribute("value").Value + "<br>";
                                                    }
                                                }
                                            }
                                            else
                                            {

                                                string spec = lst.Element("grt").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        if (patientAgeInDays > ConvertToDays(Convert.ToDouble(lst.Element("grt").Value), lst.Element("grt").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                        {
                                                            if (lst.Element("grt").Attribute("mode").Value != "ref")
                                                            {
                                                                ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("grt").FirstAttribute.Value)) + " " + lst.Element("grt").Attribute("value").Value + "<br>";
                                                            }
                                                            else
                                                            {
                                                                ReferenceRange += lst.Element("grt").Attribute("value").Value + "<br>";
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        if (lst.Element("grq") != null)
                                        {
                                            if (lst.Element("grq").LastAttribute.Value == lst.Element("grq").Attribute("value").Value)
                                            {
                                                if (patientAgeInDays >= ConvertToDays(Convert.ToDouble(lst.Element("grq").Value), lst.Element("grq").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                {
                                                    if (lst.Element("grq").Attribute("mode").Value != "ref")
                                                    {
                                                        ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("grq").FirstAttribute.Value)) + " " + lst.Element("grq").Attribute("value").Value + "<br>";
                                                    }
                                                    else
                                                    {
                                                        ReferenceRange += lst.Element("grq").Attribute("value").Value + "<br>";
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                string spec = lst.Element("grq").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        if (patientAgeInDays >= ConvertToDays(Convert.ToDouble(lst.Element("grq").Value), lst.Element("grq").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                        {
                                                            if (lst.Element("grq").Attribute("mode").Value != "ref")
                                                            {
                                                                ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("grq").FirstAttribute.Value)) + " " + lst.Element("grq").Attribute("value").Value + "<br>";
                                                            }
                                                            else
                                                            {
                                                                ReferenceRange += lst.Element("grq").Attribute("value").Value + "<br>";
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        if (lst.Element("btw") != null)
                                        {
                                            if (lst.Element("btw").LastAttribute.Value == lst.Element("btw").Attribute("value").Value)
                                            {
                                                string[] between = lst.Element("btw").Value.Split('-');
                                                if (patientAgeInDays > ConvertToDays(Convert.ToDouble(between[0]), lst.Element("btw").Attribute("agetype").Value.Replace("(", "").Replace(")", "")) && patientAgeInDays <= ConvertToDays(Convert.ToDouble(between[1]), lst.Element("btw").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                {
                                                    if (lst.Element("btw").Attribute("mode").Value != "ref")
                                                    {
                                                        ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("btw").FirstAttribute.Value)) + " " + lst.Element("btw").Attribute("value").Value + "<br>";
                                                    }
                                                    else
                                                    {
                                                        ReferenceRange += lst.Element("btw").Attribute("value").Value + "<br>";
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                string spec = lst.Element("btw").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        string[] between = lst.Element("btw").Value.Split('-');
                                                        if (patientAgeInDays > ConvertToDays(Convert.ToDouble(between[0]), lst.Element("btw").Attribute("agetype").Value.Replace("(", "").Replace(")", "")) && patientAgeInDays <= ConvertToDays(Convert.ToDouble(between[1]), lst.Element("btw").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                        {
                                                            if (lst.Element("btw").Attribute("mode").Value != "ref")
                                                            {
                                                                ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("btw").FirstAttribute.Value)) + " " + lst.Element("btw").Attribute("value").Value + "<br>";
                                                            }
                                                            else
                                                            {
                                                                ReferenceRange += lst.Element("btw").Attribute("value").Value + "<br>";
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                else if (ageRangeOthers != null && ageRangeOthers.Count() > 0)
                                {
                                    foreach (var lst in ageRangeOthers)
                                    {
                                        if (lst.Element("lst") != null)
                                        {
                                            if (lst.Element("lst").LastAttribute.Value == lst.Element("lst").Attribute("value").Value)
                                            {
                                                if (patientAgeInDays < ConvertToDays(Convert.ToDouble(lst.Element("lst").Value), lst.Element("lst").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                {
                                                    if (lst.Element("lst").Attribute("mode").Value != "ref")
                                                    {
                                                        ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("lst").FirstAttribute.Value)) + " " + lst.Element("lst").Attribute("value").Value + "<br>";
                                                    }
                                                    else
                                                    {
                                                        ReferenceRange += lst.Element("lst").Attribute("value").Value + "<br>";
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                string spec = lst.Element("lst").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        if (patientAgeInDays < ConvertToDays(Convert.ToDouble(lst.Element("lst").Value), lst.Element("lst").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                        {
                                                            if (lst.Element("lst").Attribute("mode").Value != "ref")
                                                            {
                                                                ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("lst").FirstAttribute.Value)) + " " + lst.Element("lst").Attribute("value").Value + "<br>";
                                                            }
                                                            else
                                                            {
                                                                ReferenceRange += lst.Element("lst").Attribute("value").Value + "<br>";
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        if (lst.Element("lsq") != null)
                                        {
                                            if (lst.Element("lsq").LastAttribute.Value == lst.Element("lsq").Attribute("value").Value)
                                            {
                                                if (patientAgeInDays <= ConvertToDays(Convert.ToDouble(lst.Element("lsq").Value), lst.Element("lsq").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                {
                                                    if (lst.Element("lsq").Attribute("mode").Value != "ref")
                                                    {
                                                        ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("lsq").FirstAttribute.Value)) + " " + lst.Element("lsq").Attribute("value").Value + "<br>";
                                                    }
                                                    else
                                                    {
                                                        ReferenceRange += lst.Element("lsq").Attribute("value").Value + "<br>";
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                string spec = lst.Element("lsq").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        if (patientAgeInDays <= ConvertToDays(Convert.ToDouble(lst.Element("lsq").Value), lst.Element("lsq").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                        {
                                                            if (lst.Element("lsq").Attribute("mode").Value != "ref")
                                                            {
                                                                ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("lsq").FirstAttribute.Value)) + " " + lst.Element("lsq").Attribute("value").Value + "<br>";
                                                            }
                                                            else
                                                            {
                                                                ReferenceRange += lst.Element("lsq").Attribute("value").Value + "<br>";
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        if (lst.Element("eql") != null)
                                        {
                                            if (lst.Element("eql").LastAttribute.Value == lst.Element("eql").Attribute("value").Value)
                                            {
                                                if (patientAgeInDays == ConvertToDays(Convert.ToDouble(lst.Element("eql").Value), lst.Element("eql").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                {
                                                    if (lst.Element("eql").Attribute("mode").Value != "ref")
                                                    {
                                                        ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("eql").FirstAttribute.Value)) + " " + lst.Element("eql").Attribute("value").Value + "<br>";
                                                    }
                                                    else
                                                    {
                                                        ReferenceRange += lst.Element("eql").Attribute("value").Value + "<br>";
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                string spec = lst.Element("eql").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        if (patientAgeInDays == ConvertToDays(Convert.ToDouble(lst.Element("eql").Value), lst.Element("eql").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                        {
                                                            if (lst.Element("eql").Attribute("mode").Value != "ref")
                                                            {
                                                                ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("eql").FirstAttribute.Value)) + " " + lst.Element("eql").Attribute("value").Value + "<br>";
                                                            }
                                                            else
                                                            {
                                                                ReferenceRange += lst.Element("eql").Attribute("value").Value + "<br>";
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        if (lst.Element("grt") != null)
                                        {
                                            if (lst.Element("grt").LastAttribute.Value == lst.Element("grt").Attribute("value").Value)
                                            {
                                                if (patientAgeInDays > ConvertToDays(Convert.ToDouble(lst.Element("grt").Value), lst.Element("grt").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                {
                                                    if (lst.Element("grt").Attribute("mode").Value != "ref")
                                                    {
                                                        ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("grt").FirstAttribute.Value)) + " " + lst.Element("grt").Attribute("value").Value + "<br>";
                                                    }
                                                    else
                                                    {
                                                        ReferenceRange += lst.Element("grt").Attribute("value").Value + "<br>";
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                string spec = lst.Element("grt").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        if (patientAgeInDays > ConvertToDays(Convert.ToDouble(lst.Element("grt").Value), lst.Element("grt").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                        {
                                                            if (lst.Element("grt").Attribute("mode").Value != "ref")
                                                            {
                                                                ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("grt").FirstAttribute.Value)) + " " + lst.Element("grt").Attribute("value").Value + "<br>";
                                                            }
                                                            else
                                                            {
                                                                ReferenceRange += lst.Element("grt").Attribute("value").Value + "<br>";
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        if (lst.Element("grq") != null)
                                        {
                                            if (lst.Element("grq").LastAttribute.Value == lst.Element("grq").Attribute("value").Value)
                                            {
                                                if (patientAgeInDays >= ConvertToDays(Convert.ToDouble(lst.Element("grq").Value), lst.Element("grq").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                {
                                                    if (lst.Element("grq").Attribute("mode").Value != "ref")
                                                    {
                                                        ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("grq").FirstAttribute.Value)) + " " + lst.Element("grq").Attribute("value").Value + "<br>";
                                                    }
                                                    else
                                                    {
                                                        ReferenceRange += lst.Element("grq").Attribute("value").Value + "<br>";
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                string spec = lst.Element("grq").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        if (patientAgeInDays >= ConvertToDays(Convert.ToDouble(lst.Element("grq").Value), lst.Element("grq").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                        {
                                                            if (lst.Element("grq").Attribute("mode").Value != "ref")
                                                            {
                                                                ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("grq").FirstAttribute.Value)) + " " + lst.Element("grq").Attribute("value").Value + "<br>";
                                                            }
                                                            else
                                                            {
                                                                ReferenceRange += lst.Element("grq").Attribute("value").Value + "<br>";
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        if (lst.Element("btw") != null)
                                        {
                                            if (lst.Element("btw").LastAttribute.Value == lst.Element("btw").Attribute("value").Value)
                                            {
                                                string[] between = lst.Element("btw").Value.Split('-');
                                                if (patientAgeInDays > ConvertToDays(Convert.ToDouble(between[0]), lst.Element("btw").Attribute("agetype").Value.Replace("(", "").Replace(")", "")) && patientAgeInDays <= ConvertToDays(Convert.ToDouble(between[1]), lst.Element("btw").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                {
                                                    if (lst.Element("btw").Attribute("mode").Value != "ref")
                                                    {
                                                        ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("btw").FirstAttribute.Value)) + " " + lst.Element("btw").Attribute("value").Value + "<br>";
                                                    }
                                                    else
                                                    {
                                                        ReferenceRange += lst.Element("btw").Attribute("value").Value + "<br>";
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                string spec = lst.Element("btw").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        string[] between = lst.Element("btw").Value.Split('-');
                                                        if (patientAgeInDays > ConvertToDays(Convert.ToDouble(between[0]), lst.Element("btw").Attribute("agetype").Value.Replace("(", "").Replace(")", "")) && patientAgeInDays <= ConvertToDays(Convert.ToDouble(between[1]), lst.Element("btw").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                        {
                                                            if (lst.Element("btw").Attribute("mode").Value != "ref")
                                                            {
                                                                ReferenceRange += " " + (ConvertRangeStringOptr(lst.Element("btw").FirstAttribute.Value)) + " " + lst.Element("btw").Attribute("value").Value + "<br>";
                                                            }
                                                            else
                                                            {
                                                                ReferenceRange += lst.Element("btw").Attribute("value").Value + "<br>";
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                else if (commonRange != null && commonRange.Count() > 0)
                                {
                                    foreach (var lst in commonRange)
                                    {
                                        if (lst.Element("lst") != null)
                                        {
                                            if (lst.Element("lst").LastAttribute.Value == lst.Element("lst").Attribute("value").Value)
                                            {
                                                ReferenceRange += " < " + lst.Element("lst").Value + "<br>";
                                            }
                                            else
                                            {
                                                string spec = lst.Element("lst").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        ReferenceRange += " < " + lst.Element("lst").Value + "<br>";
                                                    }
                                                }
                                            }
                                        }
                                        if (lst.Element("lsq") != null)
                                        {
                                            if (lst.Element("lsq").LastAttribute.Value == lst.Element("lsq").Attribute("value").Value)
                                            {
                                                ReferenceRange += " <= " + lst.Element("lsq").Value + "<br>";
                                            }
                                            else
                                            {
                                                string spec = lst.Element("lsq").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        ReferenceRange += " <= " + lst.Element("lsq").Value + "<br>";
                                                    }
                                                }
                                            }
                                        }
                                        if (lst.Element("eql") != null)
                                        {
                                            if (lst.Element("eql").LastAttribute.Value == lst.Element("eql").Attribute("value").Value)
                                            {
                                                ReferenceRange += " = " + lst.Element("eql").Value + "<br>";
                                            }
                                            else
                                            {
                                                string spec = lst.Element("eql").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        ReferenceRange += " = " + lst.Element("eql").Value + "<br>";
                                                    }
                                                }
                                            }
                                        }
                                        if (lst.Element("grt") != null)
                                        {
                                            if (lst.Element("grt").LastAttribute.Value == lst.Element("grt").Attribute("value").Value)
                                            {
                                                ReferenceRange += " > " + lst.Element("grt").Value + "<br>";
                                            }
                                            else
                                            {
                                                string spec = lst.Element("grt").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        ReferenceRange += " > " + lst.Element("grt").Value + "<br>";
                                                    }
                                                }
                                            }
                                        }
                                        if (lst.Element("grq") != null)
                                        {
                                            if (lst.Element("grq").LastAttribute.Value == lst.Element("grq").Attribute("value").Value)
                                            {
                                                ReferenceRange += " => " + lst.Element("grq").Value + "<br>";
                                            }
                                            else
                                            {
                                                string spec = lst.Element("grq").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        ReferenceRange += " => " + lst.Element("grq").Value + "<br>";
                                                    }
                                                }
                                            }
                                        }
                                        if (lst.Element("btw") != null)
                                        {
                                            if (lst.Element("btw").LastAttribute.Value == lst.Element("btw").Attribute("value").Value)
                                            {
                                                ReferenceRange += "" + lst.Element("btw").Value + "<br>";
                                            }
                                            else
                                            {
                                                string spec = lst.Element("btw").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        ReferenceRange += "" + lst.Element("btw").Value + "<br>";
                                                    }
                                                }
                                            }
                                        }
                                        if (lst.Element("ref") != null)
                                        {
                                            if (lst.Element("ref").LastAttribute.Value == lst.Element("ref").Attribute("value").Value)
                                            {
                                                ReferenceRange += lst.Element("ref").Value + "<br>";
                                            }
                                            else
                                            {

                                                string spec = lst.Element("ref").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        ReferenceRange += lst.Element("ref").Value + "<br>";
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                else if (commonRangeBoth != null && commonRangeBoth.Count() > 0)
                                {
                                    foreach (var lst in commonRangeBoth)
                                    {
                                        if (lst.Element("lst") != null)
                                        {
                                            if (lst.Element("lst").LastAttribute.Value == lst.Element("lst").Attribute("value").Value)
                                            {
                                                ReferenceRange += " < " + lst.Element("lst").Value + "<br>";
                                            }
                                            else
                                            {
                                                string spec = lst.Element("lst").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        ReferenceRange += " < " + lst.Element("lst").Value + "<br>";
                                                    }
                                                }
                                            }
                                        }
                                        if (lst.Element("lsq") != null)
                                        {
                                            if (lst.Element("lsq").LastAttribute.Value == lst.Element("lsq").Attribute("value").Value)
                                            {
                                                ReferenceRange += " <= " + lst.Element("lsq").Value + "<br>";
                                            }
                                            else
                                            {
                                                string spec = lst.Element("lsq").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        ReferenceRange += " <= " + lst.Element("lsq").Value + "<br>";
                                                    }
                                                }
                                            }
                                        }
                                        if (lst.Element("eql") != null)
                                        {
                                            if (lst.Element("eql").LastAttribute.Value == lst.Element("eql").Attribute("value").Value)
                                            {
                                                ReferenceRange += " = " + lst.Element("eql").Value + "<br>";
                                            }
                                            else
                                            {
                                                string spec = lst.Element("eql").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        ReferenceRange += " = " + lst.Element("eql").Value + "<br>";
                                                    }
                                                }
                                            }
                                        }
                                        if (lst.Element("grt") != null)
                                        {
                                            if (lst.Element("grt").LastAttribute.Value == lst.Element("grt").Attribute("value").Value)
                                            {
                                                ReferenceRange += " > " + lst.Element("grt").Value + "<br>";
                                            }
                                            else
                                            {
                                                string spec = lst.Element("grt").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        ReferenceRange += " > " + lst.Element("grt").Value + "<br>";
                                                    }
                                                }
                                            }
                                        }
                                        if (lst.Element("grq") != null)
                                        {
                                            if (lst.Element("grq").LastAttribute.Value == lst.Element("grq").Attribute("value").Value)
                                            {
                                                ReferenceRange += " => " + lst.Element("grq").Value + "<br>";
                                            }
                                            else
                                            {
                                                string spec = lst.Element("grq").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        ReferenceRange += " => " + lst.Element("grq").Value + "<br>";
                                                    }
                                                }
                                            }
                                        }
                                        if (lst.Element("btw") != null)
                                        {
                                            if (lst.Element("btw").LastAttribute.Value == lst.Element("btw").Attribute("value").Value)
                                            {
                                                ReferenceRange += "" + lst.Element("btw").Value + "<br>";
                                            }
                                            else
                                            {
                                                string spec = lst.Element("btw").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        ReferenceRange += "" + lst.Element("btw").Value + "<br>";
                                                    }
                                                }
                                            }
                                        }
                                        if (lst.Element("ref") != null)
                                        {
                                            if (lst.Element("ref").LastAttribute.Value == lst.Element("ref").Attribute("value").Value)
                                            {
                                                ReferenceRange += lst.Element("ref").Value + "<br>";
                                            }
                                            else
                                            {
                                                string spec = lst.Element("ref").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        ReferenceRange += lst.Element("ref").Value + "<br>";
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                else if (commonRangeSelectAll != null && commonRangeSelectAll.Count() > 0)
                                {
                                    foreach (var lst in commonRangeSelectAll)
                                    {
                                        if (lst.Element("lst") != null)
                                        {
                                            if (lst.Element("lst").LastAttribute.Value == lst.Element("lst").Attribute("value").Value)
                                            {
                                                ReferenceRange += " < " + lst.Element("lst").Value + "<br>";
                                            }
                                            else
                                            {
                                                string spec = lst.Element("lst").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        ReferenceRange += " < " + lst.Element("lst").Value + "<br>";
                                                    }
                                                }
                                            }
                                        }
                                        if (lst.Element("lsq") != null)
                                        {
                                            if (lst.Element("lsq").LastAttribute.Value == lst.Element("lsq").Attribute("value").Value)
                                            {
                                                ReferenceRange += " <= " + lst.Element("lsq").Value + "<br>";
                                            }
                                            else
                                            {
                                                string spec = lst.Element("lsq").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        ReferenceRange += " <= " + lst.Element("lsq").Value + "<br>";
                                                    }
                                                }
                                            }
                                        }
                                        if (lst.Element("eql") != null)
                                        {
                                            if (lst.Element("eql").LastAttribute.Value == lst.Element("eql").Attribute("value").Value)
                                            {
                                                ReferenceRange += " = " + lst.Element("eql").Value + "<br>";
                                            }
                                            else
                                            {
                                                string spec = lst.Element("eql").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        ReferenceRange += " = " + lst.Element("eql").Value + "<br>";
                                                    }
                                                }
                                            }
                                        }
                                        if (lst.Element("grt") != null)
                                        {
                                            if (lst.Element("grt").LastAttribute.Value == lst.Element("grt").Attribute("value").Value)
                                            {
                                                ReferenceRange += " > " + lst.Element("grt").Value + "<br>";
                                            }
                                            else
                                            {
                                                string spec = lst.Element("grt").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        ReferenceRange += " > " + lst.Element("grt").Value + "<br>";
                                                    }
                                                }
                                            }
                                        }
                                        if (lst.Element("grq") != null)
                                        {
                                            if (lst.Element("grq").LastAttribute.Value == lst.Element("grq").Attribute("value").Value)
                                            {
                                                ReferenceRange += " => " + lst.Element("grq").Value + "<br>";
                                            }
                                            else
                                            {
                                                string spec = lst.Element("grq").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        ReferenceRange += " => " + lst.Element("grq").Value + "<br>";
                                                    }
                                                }
                                            }
                                        }
                                        if (lst.Element("btw") != null)
                                        {
                                            if (lst.Element("btw").LastAttribute.Value == lst.Element("btw").Attribute("value").Value)
                                            {
                                                ReferenceRange += "" + lst.Element("btw").Value + "<br>";
                                            }
                                            else
                                            {
                                                string spec = lst.Element("btw").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        ReferenceRange += "" + lst.Element("btw").Value + "<br>";
                                                    }
                                                }
                                            }
                                        }
                                        if (lst.Element("ref") != null)
                                        {
                                            if (lst.Element("ref").LastAttribute.Value == lst.Element("ref").Attribute("value").Value)
                                            {
                                                ReferenceRange += lst.Element("ref").Value + "<br>";
                                            }
                                            else
                                            {
                                                string spec = lst.Element("ref").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        ReferenceRange += lst.Element("ref").Value + "<br>";
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                else if (commonRangeOthers != null && commonRangeOthers.Count() > 0)
                                {
                                    foreach (var lst in commonRangeOthers)
                                    {
                                        if (lst.Element("lst") != null)
                                        {
                                            if (lst.Element("lst").LastAttribute.Value == lst.Element("lst").Attribute("value").Value)
                                            {
                                                ReferenceRange += " < " + lst.Element("lst").Value + "<br>";
                                            }
                                            else
                                            {
                                                string spec = lst.Element("lst").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        ReferenceRange += " < " + lst.Element("lst").Value + "<br>";
                                                    }
                                                }
                                            }
                                        }
                                        if (lst.Element("lsq") != null)
                                        {
                                            if (lst.Element("lsq").LastAttribute.Value == lst.Element("lsq").Attribute("value").Value)
                                            {
                                                ReferenceRange += " <= " + lst.Element("lsq").Value + "<br>";
                                            }
                                            else
                                            {
                                                string spec = lst.Element("lsq").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        ReferenceRange += " <= " + lst.Element("lsq").Value + "<br>";
                                                    }
                                                }
                                            }
                                        }
                                        if (lst.Element("eql") != null)
                                        {
                                            if (lst.Element("eql").LastAttribute.Value == lst.Element("eql").Attribute("value").Value)
                                            {
                                                ReferenceRange += " = " + lst.Element("eql").Value + "<br>";
                                            }
                                            else
                                            {
                                                string spec = lst.Element("eql").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        ReferenceRange += " = " + lst.Element("eql").Value + "<br>";
                                                    }
                                                }
                                            }
                                        }
                                        if (lst.Element("grt") != null)
                                        {
                                            if (lst.Element("grt").LastAttribute.Value == lst.Element("grt").Attribute("value").Value)
                                            {
                                                ReferenceRange += " > " + lst.Element("grt").Value + "<br>";
                                            }
                                            else
                                            {
                                                string spec = lst.Element("grt").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        ReferenceRange += " > " + lst.Element("grt").Value + "<br>";
                                                    }
                                                }
                                            }
                                        }
                                        if (lst.Element("grq") != null)
                                        {
                                            if (lst.Element("grq").LastAttribute.Value == lst.Element("grq").Attribute("value").Value)
                                            {
                                                ReferenceRange += " => " + lst.Element("grq").Value + "<br>";
                                            }
                                            else
                                            {
                                                string spec = lst.Element("grq").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        ReferenceRange += " => " + lst.Element("grq").Value + "<br>";
                                                    }
                                                }
                                            }
                                        }
                                        if (lst.Element("btw") != null)
                                        {
                                            if (lst.Element("btw").LastAttribute.Value == lst.Element("btw").Attribute("value").Value)
                                            {
                                                ReferenceRange += "" + lst.Element("btw").Value + "<br>";
                                            }
                                            else
                                            {
                                                string spec = lst.Element("btw").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        ReferenceRange += "" + lst.Element("btw").Value + "<br>";
                                                    }
                                                }
                                            }
                                        }
                                        if (lst.Element("ref") != null)
                                        {
                                            if (lst.Element("ref").LastAttribute.Value == lst.Element("ref").Attribute("value").Value)
                                            {
                                                ReferenceRange += lst.Element("ref").Value + "<br>";
                                            }
                                            else
                                            {
                                                string spec = lst.Element("ref").Attribute("species").Value;
                                                string[] lstSpecies = spec.Split(',');
                                                foreach (var lSpecies in lstSpecies)
                                                {
                                                    if (lSpecies == pSpecType)
                                                    {
                                                        ReferenceRange += lst.Element("ref").Value + "<br>";
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                if ((otherRange != null && otherRange.Count() > 0) || (otherRangeText != null && otherRangeText.Count() > 0) || (otherRangeWithAge != null && otherRangeWithAge.Count() > 0) || (otherRangeTextWithAge != null && otherRangeTextWithAge.Count() > 0))
                                {
                                    if (otherRangeWithAge != null && otherRangeWithAge.Count() > 0)
                                    {
                                        foreach (var lst in otherRangeWithAge)
                                        {
                                            if (lst.Element("lst") != null)
                                            {
                                                if (lst.Element("lst").Attribute("ageopr").Value == "lst")
                                                {
                                                    if (patientAgeInDays < ConvertToDays(Convert.ToDouble(lst.Element("lst").Attribute("agerange").Value), lst.Element("lst").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("lst").Value + ": < " + lst.Element("lst").Attribute("value").Value + "<br>";
                                                        if (lst.Element("lst").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " < " + lst.Element("lst").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("lst").Attribute("ageopr").Value == "lsq")
                                                {
                                                    if (patientAgeInDays <= ConvertToDays(Convert.ToDouble(lst.Element("lst").Attribute("agerange").Value), lst.Element("lst").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("lst").Value + ": < " + lst.Element("lst").Attribute("value").Value + "<br>";
                                                        if (lst.Element("lst").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " < " + lst.Element("lst").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("lst").Attribute("ageopr").Value == "eql")
                                                {
                                                    if (patientAgeInDays == ConvertToDays(Convert.ToDouble(lst.Element("lst").Attribute("agerange").Value), lst.Element("lst").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("lst").Value + ": < " + lst.Element("lst").Attribute("value").Value + "<br>";
                                                        if (lst.Element("lst").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " < " + lst.Element("lst").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("lst").Attribute("ageopr").Value == "grt")
                                                {
                                                    if (patientAgeInDays > ConvertToDays(Convert.ToDouble(lst.Element("lst").Attribute("agerange").Value), lst.Element("lst").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("lst").Value + ": < " + lst.Element("lst").Attribute("value").Value + "<br>";
                                                        if (lst.Element("lst").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " < " + lst.Element("lst").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("lst").Attribute("ageopr").Value == "grq")
                                                {
                                                    if (patientAgeInDays >= ConvertToDays(Convert.ToDouble(lst.Element("lst").Attribute("agerange").Value), lst.Element("lst").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("lst").Value + ": < " + lst.Element("lst").Attribute("value").Value + "<br>";
                                                        if (lst.Element("lst").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " < " + lst.Element("lst").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("lst").Attribute("ageopr").Value == "btw")
                                                {
                                                    string[] between = lst.Element("lst").Attribute("agerange").Value.Split('-');
                                                    if (patientAgeInDays > ConvertToDays(Convert.ToDouble(between[0]), lst.Element("lst").Attribute("agetype").Value.Replace("(", "").Replace(")", "")) && patientAgeInDays <= ConvertToDays(Convert.ToDouble(between[1]), lst.Element("lst").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("lst").Value + ": < " + lst.Element("lst").Attribute("value").Value + "<br>";
                                                        if (lst.Element("lst").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " < " + lst.Element("lst").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                            }
                                            if (lst.Element("lsq") != null)
                                            {
                                                if (lst.Element("lsq").Attribute("ageopr").Value == "lst")
                                                {
                                                    if (patientAgeInDays < ConvertToDays(Convert.ToDouble(lst.Element("lsq").Attribute("agerange").Value), lst.Element("lsq").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("lsq").Value + ": <= " + lst.Element("lsq").Attribute("value").Value + "<br>";
                                                        if (lst.Element("lsq").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " <= " + lst.Element("lsq").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("lsq").Attribute("ageopr").Value == "lsq")
                                                {
                                                    if (patientAgeInDays <= ConvertToDays(Convert.ToDouble(lst.Element("lsq").Attribute("agerange").Value), lst.Element("lsq").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("lsq").Value + ": <= " + lst.Element("lsq").Attribute("value").Value + "<br>";
                                                        if (lst.Element("lsq").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " <= " + lst.Element("lsq").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("lsq").Attribute("ageopr").Value == "eql")
                                                {
                                                    if (patientAgeInDays == ConvertToDays(Convert.ToDouble(lst.Element("lsq").Attribute("agerange").Value), lst.Element("lsq").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("lsq").Value + ": <= " + lst.Element("lsq").Attribute("value").Value + "<br>";
                                                        if (lst.Element("lsq").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " <= " + lst.Element("lsq").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("lsq").Attribute("ageopr").Value == "grt")
                                                {
                                                    if (patientAgeInDays > ConvertToDays(Convert.ToDouble(lst.Element("lsq").Attribute("agerange").Value), lst.Element("lsq").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("lsq").Value + ": <= " + lst.Element("lsq").Attribute("value").Value + "<br>";
                                                        if (lst.Element("lsq").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " <= " + lst.Element("lsq").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("lsq").Attribute("ageopr").Value == "grq")
                                                {
                                                    if (patientAgeInDays >= ConvertToDays(Convert.ToDouble(lst.Element("lsq").Attribute("agerange").Value), lst.Element("lsq").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("lsq").Value + ": <= " + lst.Element("lsq").Attribute("value").Value + "<br>";
                                                        if (lst.Element("lsq").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " <= " + lst.Element("lsq").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("lsq").Attribute("ageopr").Value == "btw")
                                                {
                                                    string[] between = lst.Element("lsq").Attribute("agerange").Value.Split('-');
                                                    if (patientAgeInDays > ConvertToDays(Convert.ToDouble(between[0]), lst.Element("lsq").Attribute("agetype").Value.Replace("(", "").Replace(")", "")) && patientAgeInDays <= ConvertToDays(Convert.ToDouble(between[1]), lst.Element("lsq").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("lsq").Value + ": <= " + lst.Element("lsq").Attribute("value").Value + "<br>";
                                                        if (lst.Element("lsq").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " <= " + lst.Element("lsq").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                            }
                                            if (lst.Element("eql") != null)
                                            {
                                                if (lst.Element("eql").Attribute("ageopr").Value == "lst")
                                                {
                                                    if (patientAgeInDays < ConvertToDays(Convert.ToDouble(lst.Element("eql").Attribute("agerange").Value), lst.Element("eql").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("eql").Value + ": = " + lst.Element("eql").Attribute("value").Value + "<br>";
                                                        if (lst.Element("eql").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " = " + lst.Element("eql").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("eql").Attribute("ageopr").Value == "lsq")
                                                {
                                                    if (patientAgeInDays <= ConvertToDays(Convert.ToDouble(lst.Element("eql").Attribute("agerange").Value), lst.Element("eql").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("eql").Value + ": = " + lst.Element("eql").Attribute("value").Value + "<br>";
                                                        if (lst.Element("eql").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " = " + lst.Element("eql").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("eql").Attribute("ageopr").Value == "eql")
                                                {
                                                    if (patientAgeInDays == ConvertToDays(Convert.ToDouble(lst.Element("eql").Attribute("agerange").Value), lst.Element("eql").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("eql").Value + ": = " + lst.Element("eql").Attribute("value").Value + "<br>";
                                                        if (lst.Element("eql").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " = " + lst.Element("eql").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("eql").Attribute("ageopr").Value == "grt")
                                                {
                                                    if (patientAgeInDays > ConvertToDays(Convert.ToDouble(lst.Element("eql").Attribute("agerange").Value), lst.Element("eql").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("eql").Value + ": = " + lst.Element("eql").Attribute("value").Value + "<br>";
                                                        if (lst.Element("eql").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " = " + lst.Element("eql").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("eql").Attribute("ageopr").Value == "grq")
                                                {
                                                    if (patientAgeInDays >= ConvertToDays(Convert.ToDouble(lst.Element("eql").Attribute("agerange").Value), lst.Element("eql").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("eql").Value + ": = " + lst.Element("eql").Attribute("value").Value + "<br>";
                                                        if (lst.Element("eql").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " = " + lst.Element("eql").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("eql").Attribute("ageopr").Value == "btw")
                                                {
                                                    string[] between = lst.Element("eql").Attribute("agerange").Value.Split('-');
                                                    if (patientAgeInDays > ConvertToDays(Convert.ToDouble(between[0]), lst.Element("eql").Attribute("agetype").Value.Replace("(", "").Replace(")", "")) && patientAgeInDays <= ConvertToDays(Convert.ToDouble(between[1]), lst.Element("eql").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("eql").Value + ": = " + lst.Element("eql").Attribute("value").Value + "<br>";
                                                        if (lst.Element("eql").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " = " + lst.Element("eql").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                            }
                                            if (lst.Element("grt") != null)
                                            {
                                                if (lst.Element("grt").Attribute("ageopr").Value == "lst")
                                                {
                                                    if (patientAgeInDays < ConvertToDays(Convert.ToDouble(lst.Element("grt").Attribute("agerange").Value), lst.Element("grt").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("grt").Value + ": > " + lst.Element("grt").Attribute("value").Value + "<br>";
                                                        if (lst.Element("grt").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += "> " + lst.Element("grt").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("grt").Attribute("ageopr").Value == "lsq")
                                                {
                                                    if (patientAgeInDays <= ConvertToDays(Convert.ToDouble(lst.Element("grt").Attribute("agerange").Value), lst.Element("grt").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("grt").Value + ": > " + lst.Element("grt").Attribute("value").Value + "<br>";
                                                        if (lst.Element("grt").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += "> " + lst.Element("grt").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("grt").Attribute("ageopr").Value == "eql")
                                                {
                                                    if (patientAgeInDays == ConvertToDays(Convert.ToDouble(lst.Element("grt").Attribute("agerange").Value), lst.Element("grt").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("grt").Value + ": > " + lst.Element("grt").Attribute("value").Value + "<br>";
                                                        if (lst.Element("grt").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += "> " + lst.Element("grt").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("grt").Attribute("ageopr").Value == "grt")
                                                {
                                                    if (patientAgeInDays > ConvertToDays(Convert.ToDouble(lst.Element("grt").Attribute("agerange").Value), lst.Element("grt").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("grt").Value + ": > " + lst.Element("grt").Attribute("value").Value + "<br>";
                                                        if (lst.Element("grt").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += "> " + lst.Element("grt").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("grt").Attribute("ageopr").Value == "grq")
                                                {
                                                    if (patientAgeInDays >= ConvertToDays(Convert.ToDouble(lst.Element("grt").Attribute("agerange").Value), lst.Element("grt").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("grt").Value + ": > " + lst.Element("grt").Attribute("value").Value + "<br>";
                                                        if (lst.Element("grt").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += "> " + lst.Element("grt").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("grt").Attribute("ageopr").Value == "btw")
                                                {
                                                    string[] between = lst.Element("grt").Attribute("agerange").Value.Split('-');
                                                    if (patientAgeInDays > ConvertToDays(Convert.ToDouble(between[0]), lst.Element("grt").Attribute("agetype").Value.Replace("(", "").Replace(")", "")) && patientAgeInDays <= ConvertToDays(Convert.ToDouble(between[1]), lst.Element("grt").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("grt").Value + ": > " + lst.Element("grt").Attribute("value").Value + "<br>";
                                                        if (lst.Element("grt").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += "> " + lst.Element("grt").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                            }

                                            if (lst.Element("grq") != null)
                                            {
                                                if (lst.Element("grq").Attribute("ageopr").Value == "lst")
                                                {
                                                    if (patientAgeInDays < ConvertToDays(Convert.ToDouble(lst.Element("grq").Attribute("agerange").Value), lst.Element("grq").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("grq").Value + ": >= " + lst.Element("grq").Attribute("value").Value + "<br>";
                                                        if (lst.Element("grq").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " >= " + lst.Element("grq").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("grq").Attribute("ageopr").Value == "lsq")
                                                {
                                                    if (patientAgeInDays <= ConvertToDays(Convert.ToDouble(lst.Element("grq").Attribute("agerange").Value), lst.Element("grq").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("grq").Value + ": >= " + lst.Element("grq").Attribute("value").Value + "<br>";
                                                        if (lst.Element("grq").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " >= " + lst.Element("grq").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("grq").Attribute("ageopr").Value == "eql")
                                                {
                                                    if (patientAgeInDays == ConvertToDays(Convert.ToDouble(lst.Element("grq").Attribute("agerange").Value), lst.Element("grq").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("grq").Value + ": >= " + lst.Element("grq").Attribute("value").Value + "<br>";
                                                        if (lst.Element("grq").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " >= " + lst.Element("grq").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("grq").Attribute("ageopr").Value == "grt")
                                                {
                                                    if (patientAgeInDays > ConvertToDays(Convert.ToDouble(lst.Element("grq").Attribute("agerange").Value), lst.Element("grq").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("grq").Value + ": >= " + lst.Element("grq").Attribute("value").Value + "<br>";
                                                        if (lst.Element("grq").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " >= " + lst.Element("grq").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("grq").Attribute("ageopr").Value == "grq")
                                                {
                                                    if (patientAgeInDays >= ConvertToDays(Convert.ToDouble(lst.Element("grq").Attribute("agerange").Value), lst.Element("grq").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("grq").Value + ": >= " + lst.Element("grq").Attribute("value").Value + "<br>";
                                                        if (lst.Element("grq").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " >= " + lst.Element("grq").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("grq").Attribute("ageopr").Value == "btw")
                                                {
                                                    string[] between = lst.Element("grq").Attribute("agerange").Value.Split('-');
                                                    if (patientAgeInDays > ConvertToDays(Convert.ToDouble(between[0]), lst.Element("grq").Attribute("agetype").Value.Replace("(", "").Replace(")", "")) && patientAgeInDays <= ConvertToDays(Convert.ToDouble(between[1]), lst.Element("grq").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("grq").Value + ": >= " + lst.Element("grq").Attribute("value").Value + "<br>";
                                                        if (lst.Element("grq").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " >= " + lst.Element("grq").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                            }

                                            if (lst.Element("btw") != null)
                                            {
                                                if (lst.Element("btw").Attribute("ageopr").Value == "lst")
                                                {
                                                    if (patientAgeInDays < ConvertToDays(Convert.ToDouble(lst.Element("btw").Attribute("agerange").Value), lst.Element("btw").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("btw").Value + ": " + lst.Element("btw").Attribute("value").Value + "<br>";
                                                        if (lst.Element("btw").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " " + lst.Element("btw").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("btw").Attribute("ageopr").Value == "lsq")
                                                {
                                                    if (patientAgeInDays <= ConvertToDays(Convert.ToDouble(lst.Element("btw").Attribute("agerange").Value), lst.Element("btw").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("btw").Value + ": " + lst.Element("btw").Attribute("value").Value + "<br>";
                                                        if (lst.Element("btw").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " " + lst.Element("btw").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("btw").Attribute("ageopr").Value == "eql")
                                                {
                                                    if (patientAgeInDays == ConvertToDays(Convert.ToDouble(lst.Element("btw").Attribute("agerange").Value), lst.Element("btw").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("btw").Value + ": " + lst.Element("btw").Attribute("value").Value + "<br>";
                                                        if (lst.Element("btw").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " " + lst.Element("btw").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("btw").Attribute("ageopr").Value == "grt")
                                                {
                                                    if (patientAgeInDays > ConvertToDays(Convert.ToDouble(lst.Element("btw").Attribute("agerange").Value), lst.Element("btw").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("btw").Value + ": " + lst.Element("btw").Attribute("value").Value + "<br>";
                                                        if (lst.Element("btw").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " " + lst.Element("btw").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("btw").Attribute("ageopr").Value == "grq")
                                                {
                                                    if (patientAgeInDays >= ConvertToDays(Convert.ToDouble(lst.Element("btw").Attribute("agerange").Value), lst.Element("btw").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("btw").Value + ": " + lst.Element("btw").Attribute("value").Value + "<br>";
                                                        if (lst.Element("btw").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " " + lst.Element("btw").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("btw").Attribute("ageopr").Value == "btw")
                                                {
                                                    string[] between = lst.Element("btw").Attribute("agerange").Value.Split('-');
                                                    if (patientAgeInDays > ConvertToDays(Convert.ToDouble(between[0]), lst.Element("btw").Attribute("agetype").Value.Replace("(", "").Replace(")", "")) && patientAgeInDays <= ConvertToDays(Convert.ToDouble(between[1]), lst.Element("btw").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("btw").Value + ": " + lst.Element("btw").Attribute("value").Value + "<br>";
                                                        if (lst.Element("btw").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " " + lst.Element("btw").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                            }
                                            if (lst.Element("ref") != null)
                                            {
                                                if (lst.Element("ref").Attribute("ageopr").Value == "lst")
                                                {
                                                    if (patientAgeInDays < ConvertToDays(Convert.ToDouble(lst.Element("ref").Attribute("agerange").Value), lst.Element("ref").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("ref").Value + "<br>";
                                                    }
                                                }
                                                else if (lst.Element("ref").Attribute("ageopr").Value == "lsq")
                                                {
                                                    if (patientAgeInDays <= ConvertToDays(Convert.ToDouble(lst.Element("ref").Attribute("agerange").Value), lst.Element("ref").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("ref").Value + "<br>";
                                                    }
                                                }
                                                else if (lst.Element("ref").Attribute("ageopr").Value == "eql")
                                                {
                                                    if (patientAgeInDays == ConvertToDays(Convert.ToDouble(lst.Element("ref").Attribute("agerange").Value), lst.Element("ref").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("ref").Value + "<br>";
                                                    }
                                                }
                                                else if (lst.Element("ref").Attribute("ageopr").Value == "grt")
                                                {
                                                    if (patientAgeInDays > ConvertToDays(Convert.ToDouble(lst.Element("ref").Attribute("agerange").Value), lst.Element("ref").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("ref").Value + "<br>";
                                                    }
                                                }
                                                else if (lst.Element("ref").Attribute("ageopr").Value == "grq")
                                                {
                                                    if (patientAgeInDays >= ConvertToDays(Convert.ToDouble(lst.Element("ref").Attribute("agerange").Value), lst.Element("ref").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("ref").Value + "<br>";
                                                    }
                                                }
                                                else if (lst.Element("ref").Attribute("ageopr").Value == "btw")
                                                {
                                                    string[] between = lst.Element("ref").Attribute("agerange").Value.Split('-');
                                                    if (patientAgeInDays > ConvertToDays(Convert.ToDouble(between[0]), lst.Element("ref").Attribute("agetype").Value.Replace("(", "").Replace(")", "")) && patientAgeInDays <= ConvertToDays(Convert.ToDouble(between[1]), lst.Element("ref").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("ref").Value + "<br>";
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    if (otherRangeTextWithAge != null && otherRangeTextWithAge.Count() > 0)
                                    {
                                        foreach (var lst in otherRangeTextWithAge)
                                        {
                                            if (lst.Element("txt") != null)
                                            {
                                                if (lst.Element("txt").Attribute("ageopr").Value == "lst")
                                                {
                                                    if (patientAgeInDays < ConvertToDays(Convert.ToDouble(lst.Element("txt").Attribute("agerange").Value), lst.Element("txt").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("txt").Value + "<br>";
                                                    }
                                                }
                                                else if (lst.Element("txt").Attribute("ageopr").Value == "lsq")
                                                {
                                                    if (patientAgeInDays <= ConvertToDays(Convert.ToDouble(lst.Element("txt").Attribute("agerange").Value), lst.Element("txt").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("txt").Value + "<br>";
                                                    }
                                                }
                                                else if (lst.Element("txt").Attribute("ageopr").Value == "eql")
                                                {
                                                    if (patientAgeInDays == ConvertToDays(Convert.ToDouble(lst.Element("txt").Attribute("agerange").Value), lst.Element("txt").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("txt").Value + "<br>";
                                                    }
                                                }
                                                else if (lst.Element("txt").Attribute("ageopr").Value == "grt")
                                                {
                                                    if (patientAgeInDays > ConvertToDays(Convert.ToDouble(lst.Element("txt").Attribute("agerange").Value), lst.Element("txt").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("txt").Value + "<br>";
                                                    }
                                                }
                                                else if (lst.Element("txt").Attribute("ageopr").Value == "grq")
                                                {
                                                    if (patientAgeInDays >= ConvertToDays(Convert.ToDouble(lst.Element("txt").Attribute("agerange").Value), lst.Element("txt").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("txt").Value + "<br>";
                                                    }
                                                }
                                                else if (lst.Element("txt").Attribute("ageopr").Value == "btw")
                                                {
                                                    string[] between = lst.Element("txt").Attribute("agerange").Value.Split('-');
                                                    if (patientAgeInDays > ConvertToDays(Convert.ToDouble(between[0]), lst.Element("txt").Attribute("agetype").Value.Replace("(", "").Replace(")", "")) && patientAgeInDays <= ConvertToDays(Convert.ToDouble(between[1]), lst.Element("txt").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("txt").Value + "<br>";
                                                    }
                                                }
                                            }
                                            if (lst.Element("ref") != null)
                                            {
                                                if (lst.Element("ref").Attribute("ageopr").Value == "lst")
                                                {
                                                    if (patientAgeInDays < ConvertToDays(Convert.ToDouble(lst.Element("ref").Attribute("agerange").Value), lst.Element("ref").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("ref").Value + "<br>";
                                                    }
                                                }
                                                else if (lst.Element("ref").Attribute("ageopr").Value == "lsq")
                                                {
                                                    if (patientAgeInDays <= ConvertToDays(Convert.ToDouble(lst.Element("ref").Attribute("agerange").Value), lst.Element("ref").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("ref").Value + "<br>";
                                                    }
                                                }
                                                else if (lst.Element("ref").Attribute("ageopr").Value == "eql")
                                                {
                                                    if (patientAgeInDays == ConvertToDays(Convert.ToDouble(lst.Element("ref").Attribute("agerange").Value), lst.Element("ref").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("ref").Value + "<br>";
                                                    }
                                                }
                                                else if (lst.Element("ref").Attribute("ageopr").Value == "grt")
                                                {
                                                    if (patientAgeInDays > ConvertToDays(Convert.ToDouble(lst.Element("ref").Attribute("agerange").Value), lst.Element("ref").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("ref").Value + "<br>";
                                                    }
                                                }
                                                else if (lst.Element("ref").Attribute("ageopr").Value == "grq")
                                                {
                                                    if (patientAgeInDays >= ConvertToDays(Convert.ToDouble(lst.Element("ref").Attribute("agerange").Value), lst.Element("ref").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("ref").Value + "<br>";
                                                    }
                                                }
                                                else if (lst.Element("ref").Attribute("ageopr").Value == "btw")
                                                {
                                                    string[] between = lst.Element("ref").Attribute("agerange").Value.Split('-');
                                                    if (patientAgeInDays > ConvertToDays(Convert.ToDouble(between[0]), lst.Element("ref").Attribute("agetype").Value.Replace("(", "").Replace(")", "")) && patientAgeInDays <= ConvertToDays(Convert.ToDouble(between[1]), lst.Element("ref").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("ref").Value + "<br>";
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    if (otherRange != null && otherRange.Count() > 0)
                                    {
                                        foreach (var lst in otherRange)
                                        {
                                            if (lst.Element("lst") != null)
                                            {
                                                ReferenceRange += lst.Element("lst").Value + ": < " + lst.Element("lst").Attribute("value").Value + "<br>";
                                                if (lst.Element("lst").LastAttribute.Name == "ConvReferencevalue")
                                                {
                                                    OtherReferenceRange += " < " + lst.Element("lst").Attribute("ConvReferencevalue").Value + "<br>";
                                                }
                                            }
                                            if (lst.Element("lsq") != null)
                                            {
                                                ReferenceRange += lst.Element("lsq").Value + ": <= " + lst.Element("lsq").Attribute("value").Value + "<br>";
                                                if (lst.Element("lsq").LastAttribute.Name == "ConvReferencevalue")
                                                {
                                                    OtherReferenceRange += " <= " + lst.Element("lsq").Attribute("ConvReferencevalue").Value + "<br>";
                                                }
                                            }

                                            if (lst.Element("eql") != null)
                                            {
                                                ReferenceRange += lst.Element("eql").Value + ": = " + lst.Element("eql").Attribute("value").Value + "<br>";
                                                if (lst.Element("eql").LastAttribute.Name == "ConvReferencevalue")
                                                {
                                                    OtherReferenceRange += " = " + lst.Element("eql").Attribute("ConvReferencevalue").Value + "<br>";
                                                }
                                            }

                                            if (lst.Element("grt") != null)
                                            {
                                                ReferenceRange += lst.Element("grt").Value + ": > " + lst.Element("grt").Attribute("value").Value + "<br>";
                                                if (lst.Element("grt").LastAttribute.Name == "ConvReferencevalue")
                                                {
                                                    OtherReferenceRange += "> " + lst.Element("grt").Attribute("ConvReferencevalue").Value + "<br>";
                                                }
                                            }


                                            if (lst.Element("grq") != null)
                                            {
                                                ReferenceRange += lst.Element("grq").Value + ": >= " + lst.Element("grq").Attribute("value").Value + "<br>";
                                                if (lst.Element("grq").LastAttribute.Name == "ConvReferencevalue")
                                                {
                                                    OtherReferenceRange += " >= " + lst.Element("grq").Attribute("ConvReferencevalue").Value + "<br>";
                                                }
                                            }

                                            if (lst.Element("btw") != null)
                                            {
                                                ReferenceRange += lst.Element("btw").Value + ": " + lst.Element("btw").Attribute("value").Value + "<br>";
                                                if (lst.Element("btw").LastAttribute.Name == "ConvReferencevalue")
                                                {
                                                    OtherReferenceRange += " " + lst.Element("btw").Attribute("ConvReferencevalue").Value + "<br>";
                                                }
                                            }
                                            if (lst.Element("ref") != null)
                                            {
                                                ReferenceRange += lst.Element("ref").Value + "<br>";
                                            }
                                        }
                                    }
                                    if (otherRangeText != null && otherRangeText.Count() > 0)
                                    {
                                        foreach (var lst in otherRangeText)
                                        {
                                            if (lst.Element("txt") != null)
                                            {
                                                ReferenceRange += lst.Element("txt").Value + "<br>";
                                            }
                                            if (lst.Element("ref") != null)
                                            {
                                                ReferenceRange += lst.Element("ref").Value + "<br>";
                                            }
                                        }
                                    }
                                }
                                else if ((otherRangeBoth != null && otherRangeBoth.Count() > 0) || (otherRangeBothText != null && otherRangeBothText.Count() > 0) || (otherRangeBothWithAge != null && otherRangeBothWithAge.Count() > 0) || (otherRangeBothTextWithAge != null && otherRangeBothTextWithAge.Count() > 0))
                                {
                                    if (otherRangeBothWithAge != null && otherRangeBothWithAge.Count() > 0)
                                    {
                                        foreach (var lst in otherRangeBothWithAge)
                                        {
                                            if (lst.Element("lst") != null)
                                            {
                                                if (lst.Element("lst").Attribute("ageopr").Value == "lst")
                                                {
                                                    if (patientAgeInDays < ConvertToDays(Convert.ToDouble(lst.Element("lst").Attribute("agerange").Value), lst.Element("lst").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("lst").Value + ": < " + lst.Element("lst").Attribute("value").Value + "<br>";
                                                        if (lst.Element("lst").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " < " + lst.Element("lst").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("lst").Attribute("ageopr").Value == "lsq")
                                                {
                                                    if (patientAgeInDays <= ConvertToDays(Convert.ToDouble(lst.Element("lst").Attribute("agerange").Value), lst.Element("lst").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("lst").Value + ": < " + lst.Element("lst").Attribute("value").Value + "<br>";
                                                        if (lst.Element("lst").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " < " + lst.Element("lst").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("lst").Attribute("ageopr").Value == "eql")
                                                {
                                                    if (patientAgeInDays == ConvertToDays(Convert.ToDouble(lst.Element("lst").Attribute("agerange").Value), lst.Element("lst").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("lst").Value + ": < " + lst.Element("lst").Attribute("value").Value + "<br>";
                                                        if (lst.Element("lst").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " < " + lst.Element("lst").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("lst").Attribute("ageopr").Value == "grt")
                                                {
                                                    if (patientAgeInDays > ConvertToDays(Convert.ToDouble(lst.Element("lst").Attribute("agerange").Value), lst.Element("lst").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("lst").Value + ": < " + lst.Element("lst").Attribute("value").Value + "<br>";
                                                        if (lst.Element("lst").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " < " + lst.Element("lst").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("lst").Attribute("ageopr").Value == "grq")
                                                {
                                                    if (patientAgeInDays >= ConvertToDays(Convert.ToDouble(lst.Element("lst").Attribute("agerange").Value), lst.Element("lst").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("lst").Value + ": < " + lst.Element("lst").Attribute("value").Value + "<br>";
                                                        if (lst.Element("lst").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " < " + lst.Element("lst").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("lst").Attribute("ageopr").Value == "btw")
                                                {
                                                    string[] between = lst.Element("lst").Attribute("agerange").Value.Split('-');
                                                    if (patientAgeInDays > ConvertToDays(Convert.ToDouble(between[0]), lst.Element("lst").Attribute("agetype").Value.Replace("(", "").Replace(")", "")) && patientAgeInDays <= ConvertToDays(Convert.ToDouble(between[1]), lst.Element("lst").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("lst").Value + ": < " + lst.Element("lst").Attribute("value").Value + "<br>";
                                                        if (lst.Element("lst").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " < " + lst.Element("lst").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                            }
                                            if (lst.Element("lsq") != null)
                                            {
                                                if (lst.Element("lsq").Attribute("ageopr").Value == "lst")
                                                {
                                                    if (patientAgeInDays < ConvertToDays(Convert.ToDouble(lst.Element("lsq").Attribute("agerange").Value), lst.Element("lsq").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("lsq").Value + ": <= " + lst.Element("lsq").Attribute("value").Value + "<br>";
                                                        if (lst.Element("lsq").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " <= " + lst.Element("lsq").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("lsq").Attribute("ageopr").Value == "lsq")
                                                {
                                                    if (patientAgeInDays <= ConvertToDays(Convert.ToDouble(lst.Element("lsq").Attribute("agerange").Value), lst.Element("lsq").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("lsq").Value + ": <= " + lst.Element("lsq").Attribute("value").Value + "<br>";
                                                        if (lst.Element("lsq").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " <= " + lst.Element("lsq").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("lsq").Attribute("ageopr").Value == "eql")
                                                {
                                                    if (patientAgeInDays == ConvertToDays(Convert.ToDouble(lst.Element("lsq").Attribute("agerange").Value), lst.Element("lsq").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("lsq").Value + ": <= " + lst.Element("lsq").Attribute("value").Value + "<br>";
                                                        if (lst.Element("lsq").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " <= " + lst.Element("lsq").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("lsq").Attribute("ageopr").Value == "grt")
                                                {
                                                    if (patientAgeInDays > ConvertToDays(Convert.ToDouble(lst.Element("lsq").Attribute("agerange").Value), lst.Element("lsq").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("lsq").Value + ": <= " + lst.Element("lsq").Attribute("value").Value + "<br>";
                                                        if (lst.Element("lsq").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " <= " + lst.Element("lsq").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("lsq").Attribute("ageopr").Value == "grq")
                                                {
                                                    if (patientAgeInDays >= ConvertToDays(Convert.ToDouble(lst.Element("lsq").Attribute("agerange").Value), lst.Element("lsq").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("lsq").Value + ": <= " + lst.Element("lsq").Attribute("value").Value + "<br>";
                                                        if (lst.Element("lsq").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " <= " + lst.Element("lsq").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("lsq").Attribute("ageopr").Value == "btw")
                                                {
                                                    string[] between = lst.Element("lsq").Attribute("agerange").Value.Split('-');
                                                    if (patientAgeInDays > ConvertToDays(Convert.ToDouble(between[0]), lst.Element("lsq").Attribute("agetype").Value.Replace("(", "").Replace(")", "")) && patientAgeInDays <= ConvertToDays(Convert.ToDouble(between[1]), lst.Element("lsq").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("lsq").Value + ": <= " + lst.Element("lsq").Attribute("value").Value + "<br>";
                                                        if (lst.Element("lsq").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " <= " + lst.Element("lsq").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                            }

                                            if (lst.Element("eql") != null)
                                            {
                                                if (lst.Element("eql").Attribute("ageopr").Value == "lst")
                                                {
                                                    if (patientAgeInDays < ConvertToDays(Convert.ToDouble(lst.Element("eql").Attribute("agerange").Value), lst.Element("eql").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("eql").Value + ": = " + lst.Element("eql").Attribute("value").Value + "<br>";
                                                        if (lst.Element("eql").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " = " + lst.Element("eql").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("eql").Attribute("ageopr").Value == "lsq")
                                                {
                                                    if (patientAgeInDays <= ConvertToDays(Convert.ToDouble(lst.Element("eql").Attribute("agerange").Value), lst.Element("eql").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("eql").Value + ": = " + lst.Element("eql").Attribute("value").Value + "<br>";
                                                        if (lst.Element("eql").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " = " + lst.Element("eql").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("eql").Attribute("ageopr").Value == "eql")
                                                {
                                                    if (patientAgeInDays == ConvertToDays(Convert.ToDouble(lst.Element("eql").Attribute("agerange").Value), lst.Element("eql").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("eql").Value + ": = " + lst.Element("eql").Attribute("value").Value + "<br>";
                                                        if (lst.Element("eql").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " = " + lst.Element("eql").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("eql").Attribute("ageopr").Value == "grt")
                                                {
                                                    if (patientAgeInDays > ConvertToDays(Convert.ToDouble(lst.Element("eql").Attribute("agerange").Value), lst.Element("eql").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("eql").Value + ": = " + lst.Element("eql").Attribute("value").Value + "<br>";
                                                        if (lst.Element("eql").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " = " + lst.Element("eql").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("eql").Attribute("ageopr").Value == "grq")
                                                {
                                                    if (patientAgeInDays >= ConvertToDays(Convert.ToDouble(lst.Element("eql").Attribute("agerange").Value), lst.Element("eql").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("eql").Value + ": = " + lst.Element("eql").Attribute("value").Value + "<br>";
                                                        if (lst.Element("eql").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " = " + lst.Element("eql").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("eql").Attribute("ageopr").Value == "btw")
                                                {
                                                    string[] between = lst.Element("eql").Attribute("agerange").Value.Split('-');
                                                    if (patientAgeInDays > ConvertToDays(Convert.ToDouble(between[0]), lst.Element("eql").Attribute("agetype").Value.Replace("(", "").Replace(")", "")) && patientAgeInDays <= ConvertToDays(Convert.ToDouble(between[1]), lst.Element("eql").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("eql").Value + ": = " + lst.Element("eql").Attribute("value").Value + "<br>";
                                                        if (lst.Element("eql").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " = " + lst.Element("eql").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                            }

                                            if (lst.Element("grt") != null)
                                            {
                                                if (lst.Element("grt").Attribute("ageopr").Value == "lst")
                                                {
                                                    if (patientAgeInDays < ConvertToDays(Convert.ToDouble(lst.Element("grt").Attribute("agerange").Value), lst.Element("grt").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("grt").Value + ": > " + lst.Element("grt").Attribute("value").Value + "<br>";
                                                        if (lst.Element("grt").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += "> " + lst.Element("grt").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("grt").Attribute("ageopr").Value == "lsq")
                                                {
                                                    if (patientAgeInDays <= ConvertToDays(Convert.ToDouble(lst.Element("grt").Attribute("agerange").Value), lst.Element("grt").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("grt").Value + ": > " + lst.Element("grt").Attribute("value").Value + "<br>";
                                                        if (lst.Element("grt").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += "> " + lst.Element("grt").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("grt").Attribute("ageopr").Value == "eql")
                                                {
                                                    if (patientAgeInDays == ConvertToDays(Convert.ToDouble(lst.Element("grt").Attribute("agerange").Value), lst.Element("grt").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("grt").Value + ": > " + lst.Element("grt").Attribute("value").Value + "<br>";
                                                        if (lst.Element("grt").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += "> " + lst.Element("grt").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("grt").Attribute("ageopr").Value == "grt")
                                                {
                                                    if (patientAgeInDays > ConvertToDays(Convert.ToDouble(lst.Element("grt").Attribute("agerange").Value), lst.Element("grt").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("grt").Value + ": > " + lst.Element("grt").Attribute("value").Value + "<br>";
                                                        if (lst.Element("grt").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += "> " + lst.Element("grt").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("grt").Attribute("ageopr").Value == "grq")
                                                {
                                                    if (patientAgeInDays >= ConvertToDays(Convert.ToDouble(lst.Element("grt").Attribute("agerange").Value), lst.Element("grt").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("grt").Value + ": > " + lst.Element("grt").Attribute("value").Value + "<br>";
                                                        if (lst.Element("grt").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += "> " + lst.Element("grt").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("grt").Attribute("ageopr").Value == "btw")
                                                {
                                                    string[] between = lst.Element("grt").Attribute("agerange").Value.Split('-');
                                                    if (patientAgeInDays > ConvertToDays(Convert.ToDouble(between[0]), lst.Element("grt").Attribute("agetype").Value.Replace("(", "").Replace(")", "")) && patientAgeInDays <= ConvertToDays(Convert.ToDouble(between[1]), lst.Element("grt").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("grt").Value + ": > " + lst.Element("grt").Attribute("value").Value + "<br>";
                                                        if (lst.Element("grt").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += "> " + lst.Element("grt").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                            }

                                            if (lst.Element("grq") != null)
                                            {
                                                if (lst.Element("grq").Attribute("ageopr").Value == "lst")
                                                {
                                                    if (patientAgeInDays < ConvertToDays(Convert.ToDouble(lst.Element("grq").Attribute("agerange").Value), lst.Element("grq").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("grq").Value + ": >= " + lst.Element("grq").Attribute("value").Value + "<br>";
                                                        if (lst.Element("grq").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " >= " + lst.Element("grq").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("grq").Attribute("ageopr").Value == "lsq")
                                                {
                                                    if (patientAgeInDays <= ConvertToDays(Convert.ToDouble(lst.Element("grq").Attribute("agerange").Value), lst.Element("grq").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("grq").Value + ": >= " + lst.Element("grq").Attribute("value").Value + "<br>";
                                                        if (lst.Element("grq").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " >= " + lst.Element("grq").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("grq").Attribute("ageopr").Value == "eql")
                                                {
                                                    if (patientAgeInDays == ConvertToDays(Convert.ToDouble(lst.Element("grq").Attribute("agerange").Value), lst.Element("grq").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("grq").Value + ": >= " + lst.Element("grq").Attribute("value").Value + "<br>";
                                                        if (lst.Element("grq").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " >= " + lst.Element("grq").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("grq").Attribute("ageopr").Value == "grt")
                                                {
                                                    if (patientAgeInDays > ConvertToDays(Convert.ToDouble(lst.Element("grq").Attribute("agerange").Value), lst.Element("grq").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("grq").Value + ": >= " + lst.Element("grq").Attribute("value").Value + "<br>";
                                                        if (lst.Element("grq").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " >= " + lst.Element("grq").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("grq").Attribute("ageopr").Value == "grq")
                                                {
                                                    if (patientAgeInDays >= ConvertToDays(Convert.ToDouble(lst.Element("grq").Attribute("agerange").Value), lst.Element("grq").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("grq").Value + ": >= " + lst.Element("grq").Attribute("value").Value + "<br>";
                                                        if (lst.Element("grq").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " >= " + lst.Element("grq").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("grq").Attribute("ageopr").Value == "btw")
                                                {
                                                    string[] between = lst.Element("grq").Attribute("agerange").Value.Split('-');
                                                    if (patientAgeInDays > ConvertToDays(Convert.ToDouble(between[0]), lst.Element("grq").Attribute("agetype").Value.Replace("(", "").Replace(")", "")) && patientAgeInDays <= ConvertToDays(Convert.ToDouble(between[1]), lst.Element("grq").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("grq").Value + ": >= " + lst.Element("grq").Attribute("value").Value + "<br>";
                                                        if (lst.Element("grq").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " >= " + lst.Element("grq").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                            }
                                            if (lst.Element("btw") != null)
                                            {
                                                if (lst.Element("btw").Attribute("ageopr").Value == "lst")
                                                {
                                                    if (patientAgeInDays < ConvertToDays(Convert.ToDouble(lst.Element("btw").Attribute("agerange").Value), lst.Element("btw").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("btw").Value + ": " + lst.Element("btw").Attribute("value").Value + "<br>";
                                                        if (lst.Element("btw").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " " + lst.Element("btw").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("btw").Attribute("ageopr").Value == "lsq")
                                                {
                                                    if (patientAgeInDays <= ConvertToDays(Convert.ToDouble(lst.Element("btw").Attribute("agerange").Value), lst.Element("btw").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("btw").Value + ": " + lst.Element("btw").Attribute("value").Value + "<br>";
                                                        if (lst.Element("btw").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " " + lst.Element("btw").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("btw").Attribute("ageopr").Value == "eql")
                                                {
                                                    if (patientAgeInDays == ConvertToDays(Convert.ToDouble(lst.Element("btw").Attribute("agerange").Value), lst.Element("btw").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("btw").Value + ": " + lst.Element("btw").Attribute("value").Value + "<br>";
                                                        if (lst.Element("btw").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " " + lst.Element("btw").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("btw").Attribute("ageopr").Value == "grt")
                                                {
                                                    if (patientAgeInDays > ConvertToDays(Convert.ToDouble(lst.Element("btw").Attribute("agerange").Value), lst.Element("btw").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("btw").Value + ": " + lst.Element("btw").Attribute("value").Value + "<br>";
                                                        if (lst.Element("btw").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " " + lst.Element("btw").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("btw").Attribute("ageopr").Value == "grq")
                                                {
                                                    if (patientAgeInDays >= ConvertToDays(Convert.ToDouble(lst.Element("btw").Attribute("agerange").Value), lst.Element("btw").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("btw").Value + ": " + lst.Element("btw").Attribute("value").Value + "<br>";
                                                        if (lst.Element("btw").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " " + lst.Element("btw").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("btw").Attribute("ageopr").Value == "btw")
                                                {
                                                    string[] between = lst.Element("btw").Attribute("agerange").Value.Split('-');
                                                    if (patientAgeInDays > ConvertToDays(Convert.ToDouble(between[0]), lst.Element("btw").Attribute("agetype").Value.Replace("(", "").Replace(")", "")) && patientAgeInDays <= ConvertToDays(Convert.ToDouble(between[1]), lst.Element("btw").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("btw").Value + ": " + lst.Element("btw").Attribute("value").Value + "<br>";
                                                        if (lst.Element("btw").LastAttribute.Name == "ConvReferencevalue")
                                                        {
                                                            OtherReferenceRange += " " + lst.Element("btw").Attribute("ConvReferencevalue").Value + "<br>";
                                                        }
                                                    }
                                                }
                                            }
                                            if (lst.Element("ref") != null)
                                            {
                                                if (lst.Element("ref").Attribute("ageopr").Value == "lst")
                                                {
                                                    if (patientAgeInDays < ConvertToDays(Convert.ToDouble(lst.Element("ref").Attribute("agerange").Value), lst.Element("ref").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("ref").Value + "<br>";
                                                    }
                                                }
                                                else if (lst.Element("ref").Attribute("ageopr").Value == "lsq")
                                                {
                                                    if (patientAgeInDays <= ConvertToDays(Convert.ToDouble(lst.Element("ref").Attribute("agerange").Value), lst.Element("ref").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("ref").Value + "<br>";
                                                    }
                                                }
                                                else if (lst.Element("ref").Attribute("ageopr").Value == "eql")
                                                {
                                                    if (patientAgeInDays == ConvertToDays(Convert.ToDouble(lst.Element("ref").Attribute("agerange").Value), lst.Element("ref").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("ref").Value + "<br>";
                                                    }
                                                }
                                                else if (lst.Element("ref").Attribute("ageopr").Value == "grt")
                                                {
                                                    if (patientAgeInDays > ConvertToDays(Convert.ToDouble(lst.Element("ref").Attribute("agerange").Value), lst.Element("ref").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("ref").Value + "<br>";
                                                    }
                                                }
                                                else if (lst.Element("ref").Attribute("ageopr").Value == "grq")
                                                {
                                                    if (patientAgeInDays >= ConvertToDays(Convert.ToDouble(lst.Element("ref").Attribute("agerange").Value), lst.Element("ref").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("ref").Value + "<br>";
                                                    }
                                                }
                                                else if (lst.Element("ref").Attribute("ageopr").Value == "btw")
                                                {
                                                    string[] between = lst.Element("ref").Attribute("agerange").Value.Split('-');
                                                    if (patientAgeInDays > ConvertToDays(Convert.ToDouble(between[0]), lst.Element("ref").Attribute("agetype").Value.Replace("(", "").Replace(")", "")) && patientAgeInDays <= ConvertToDays(Convert.ToDouble(between[1]), lst.Element("ref").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("ref").Value + "<br>";
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    if (otherRangeBothTextWithAge != null && otherRangeBothTextWithAge.Count() > 0)
                                    {
                                        foreach (var lst in otherRangeBothTextWithAge)
                                        {
                                            if (lst.Element("txt") != null)
                                            {
                                                if (lst.Element("txt").Attribute("ageopr").Value == "lst")
                                                {
                                                    if (patientAgeInDays < ConvertToDays(Convert.ToDouble(lst.Element("txt").Attribute("agerange").Value), lst.Element("txt").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("txt").Value + "<br>";
                                                    }
                                                }
                                                else if (lst.Element("txt").Attribute("ageopr").Value == "lsq")
                                                {
                                                    if (patientAgeInDays <= ConvertToDays(Convert.ToDouble(lst.Element("txt").Attribute("agerange").Value), lst.Element("txt").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("txt").Value + "<br>";
                                                    }
                                                }
                                                else if (lst.Element("txt").Attribute("ageopr").Value == "eql")
                                                {
                                                    if (patientAgeInDays == ConvertToDays(Convert.ToDouble(lst.Element("txt").Attribute("agerange").Value), lst.Element("txt").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("txt").Value + "<br>";
                                                    }
                                                }
                                                else if (lst.Element("txt").Attribute("ageopr").Value == "grt")
                                                {
                                                    if (patientAgeInDays > ConvertToDays(Convert.ToDouble(lst.Element("txt").Attribute("agerange").Value), lst.Element("txt").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("txt").Value + "<br>";
                                                    }
                                                }
                                                else if (lst.Element("txt").Attribute("ageopr").Value == "grq")
                                                {
                                                    if (patientAgeInDays >= ConvertToDays(Convert.ToDouble(lst.Element("txt").Attribute("agerange").Value), lst.Element("txt").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("txt").Value + "<br>";
                                                    }
                                                }
                                                else if (lst.Element("txt").Attribute("ageopr").Value == "btw")
                                                {
                                                    string[] between = lst.Element("txt").Attribute("agerange").Value.Split('-');
                                                    if (patientAgeInDays > ConvertToDays(Convert.ToDouble(between[0]), lst.Element("txt").Attribute("agetype").Value.Replace("(", "").Replace(")", "")) && patientAgeInDays <= ConvertToDays(Convert.ToDouble(between[1]), lst.Element("txt").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("txt").Value + "<br>";
                                                    }
                                                }
                                            }
                                            if (lst.Element("ref") != null)
                                            {
                                                if (lst.Element("ref").Attribute("ageopr").Value == "lst")
                                                {
                                                    if (patientAgeInDays < ConvertToDays(Convert.ToDouble(lst.Element("ref").Attribute("agerange").Value), lst.Element("ref").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("ref").Value + "<br>";
                                                    }
                                                }
                                                else if (lst.Element("ref").Attribute("ageopr").Value == "lsq")
                                                {
                                                    if (lst.Element("ref").Attribute("species") != null)
                                                    {
                                                        string spec = lst.Element("ref").Attribute("species").Value;
                                                        string[] lstSpecies = spec.Split(',');
                                                        foreach (var lSpecies in lstSpecies)
                                                        {
                                                            if (lSpecies == pSpecType)
                                                            {
                                                                if (patientAgeInDays <= ConvertToDays(Convert.ToDouble(lst.Element("ref").Attribute("agerange").Value), lst.Element("ref").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                                {
                                                                    ReferenceRange += lst.Element("ref").Value + "<br>";
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                                else if (lst.Element("ref").Attribute("ageopr").Value == "eql")
                                                {
                                                    if (patientAgeInDays == ConvertToDays(Convert.ToDouble(lst.Element("ref").Attribute("agerange").Value), lst.Element("ref").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("ref").Value + "<br>";
                                                    }
                                                }
                                                else if (lst.Element("ref").Attribute("ageopr").Value == "grt")
                                                {
                                                    if (patientAgeInDays > ConvertToDays(Convert.ToDouble(lst.Element("ref").Attribute("agerange").Value), lst.Element("ref").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("ref").Value + "<br>";
                                                    }
                                                }
                                                else if (lst.Element("ref").Attribute("ageopr").Value == "grq")
                                                {
                                                    if (patientAgeInDays >= ConvertToDays(Convert.ToDouble(lst.Element("ref").Attribute("agerange").Value), lst.Element("ref").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                    {
                                                        ReferenceRange += lst.Element("ref").Value + "<br>";
                                                    }
                                                }
                                                else if (lst.Element("ref").Attribute("ageopr").Value == "btw")
                                                {
                                                    string spec = lst.Element("ref").Attribute("species").Value;
                                                    string[] lstSpecies = spec.Split(',');
                                                    foreach (var lSpecies in lstSpecies)
                                                    {
                                                        if (lSpecies == pSpecType)
                                                        {
                                                            string[] between = lst.Element("ref").Attribute("agerange").Value.Split('-');
                                                            if (patientAgeInDays > ConvertToDays(Convert.ToDouble(between[0]), lst.Element("ref").Attribute("agetype").Value.Replace("(", "").Replace(")", "")) && patientAgeInDays <= ConvertToDays(Convert.ToDouble(between[1]), lst.Element("ref").Attribute("agetype").Value.Replace("(", "").Replace(")", "")))
                                                            {
                                                                ReferenceRange += lst.Element("ref").Value + "<br>";
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    if (otherRangeBoth != null && otherRangeBoth.Count() > 0)
                                    {
                                        foreach (var lst in otherRangeBoth)
                                        {
                                            if (lst.Element("lst") != null)
                                            {
                                                ReferenceRange += lst.Element("lst").Value + ": < " + lst.Element("lst").Attribute("value").Value + "<br>";
                                                if (lst.Element("lst").LastAttribute.Name == "ConvReferencevalue")
                                                {
                                                    OtherReferenceRange += " < " + lst.Element("lst").Attribute("ConvReferencevalue").Value + "<br>";
                                                }
                                            }
                                            if (lst.Element("lsq") != null)
                                            {
                                                ReferenceRange += lst.Element("lsq").Value + ": <= " + lst.Element("lsq").Attribute("value").Value + "<br>";
                                                if (lst.Element("lsq").LastAttribute.Name == "ConvReferencevalue")
                                                {
                                                    OtherReferenceRange += " <= " + lst.Element("lsq").Attribute("ConvReferencevalue").Value + "<br>";
                                                }
                                            }

                                            if (lst.Element("eql") != null)
                                            {
                                                ReferenceRange += lst.Element("eql").Value + ": = " + lst.Element("eql").Attribute("value").Value + "<br>";
                                                if (lst.Element("eql").LastAttribute.Name == "ConvReferencevalue")
                                                {
                                                    OtherReferenceRange += " = " + lst.Element("eql").Attribute("ConvReferencevalue").Value + "<br>";
                                                }
                                            }

                                            if (lst.Element("grt") != null)
                                            {
                                                ReferenceRange += lst.Element("grt").Value + ": > " + lst.Element("grt").Attribute("value").Value + "<br>";
                                                if (lst.Element("grt").LastAttribute.Name == "ConvReferencevalue")
                                                {
                                                    OtherReferenceRange += " > " + lst.Element("grt").Attribute("ConvReferencevalue").Value + "<br>";
                                                }
                                            }


                                            if (lst.Element("grq") != null)
                                            {
                                                ReferenceRange += lst.Element("grq").Value + ": >= " + lst.Element("grq").Attribute("value").Value + "<br>";
                                                if (lst.Element("grq").LastAttribute.Name == "ConvReferencevalue")
                                                {
                                                    OtherReferenceRange += " >= " + lst.Element("grq").Attribute("ConvReferencevalue").Value + "<br>";
                                                }
                                            }

                                            if (lst.Element("btw") != null)
                                            {
                                                ReferenceRange += lst.Element("btw").Value + ": " + lst.Element("btw").Attribute("value").Value + "<br>";
                                                if (lst.Element("btw").LastAttribute.Name == "ConvReferencevalue")
                                                {
                                                    OtherReferenceRange += " " + lst.Element("btw").Attribute("ConvReferencevalue").Value + "<br>";
                                                }
                                            }
                                            if (lst.Element("ref") != null)
                                            {
                                                ReferenceRange += lst.Element("ref").Value + "<br>";
                                            }
                                        }
                                    }

                                    if (otherRangeBothText != null && otherRangeBothText.Count() > 0)
                                    {
                                        foreach (var lst in otherRangeBothText)
                                        {
                                            if (lst.Element("txt") != null)
                                            {
                                                ReferenceRange += lst.Element("txt").Value + "<br>";
                                            }
                                            if (lst.Element("ref") != null)
                                            {
                                                ReferenceRange += lst.Element("ref").Value + "<br>";
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (commonRange != null && commonRange.Count() > 0)
                                {
                                    foreach (var lst in commonRange)
                                    {
                                        if (lst.Element("lst") != null)
                                        {
                                            ReferenceRange += " < " + lst.Element("lst").Value + "<br>";
                                        }
                                        if (lst.Element("lsq") != null)
                                        {
                                            ReferenceRange += " <= " + lst.Element("lsq").Value + "<br>";
                                        }
                                        if (lst.Element("eql") != null)
                                        {
                                            ReferenceRange += " = " + lst.Element("eql").Value + "<br>";
                                        }
                                        if (lst.Element("grt") != null)
                                        {
                                            ReferenceRange += " > " + lst.Element("grt").Value + "<br>";
                                        }
                                        if (lst.Element("grq") != null)
                                        {
                                            ReferenceRange += " => " + lst.Element("grq").Value + "<br>";
                                        }
                                        if (lst.Element("btw") != null)
                                        {
                                            ReferenceRange += "" + lst.Element("btw").Value + "<br>";
                                        }
                                        if (lst.Element("ref") != null)
                                        {
                                            ReferenceRange += lst.Element("ref").Value + "<br>";
                                        }
                                    }
                                }
                                else if (commonRangeBoth != null && commonRangeBoth.Count() > 0)
                                {
                                    foreach (var lst in commonRangeBoth)
                                    {
                                        if (lst.Element("lst") != null)
                                        {
                                            ReferenceRange += " < " + lst.Element("lst").Value + "<br>";
                                        }
                                        if (lst.Element("lsq") != null)
                                        {
                                            ReferenceRange += " <= " + lst.Element("lsq").Value + "<br>";
                                        }
                                        if (lst.Element("eql") != null)
                                        {
                                            ReferenceRange += " = " + lst.Element("eql").Value + "<br>";
                                        }
                                        if (lst.Element("grt") != null)
                                        {
                                            ReferenceRange += " > " + lst.Element("grt").Value + "<br>";
                                        }
                                        if (lst.Element("grq") != null)
                                        {
                                            ReferenceRange += " => " + lst.Element("grq").Value + "<br>";
                                        }
                                        if (lst.Element("btw") != null)
                                        {
                                            ReferenceRange += "" + lst.Element("btw").Value + "<br>";
                                        }
                                        if (lst.Element("ref") != null)
                                        {
                                            ReferenceRange += lst.Element("ref").Value + "<br>";
                                        }
                                    }
                                }
                                if ((otherRange != null && otherRange.Count() > 0) || (otherRangeText != null && otherRangeText.Count() > 0))
                                {
                                    if (otherRange != null && otherRange.Count() > 0)
                                    {
                                        foreach (var lst in otherRange)
                                        {
                                            if (lst.Element("lst") != null)
                                            {
                                                ReferenceRange += lst.Element("lst").Value + ": < " + lst.Element("lst").Attribute("value").Value + "<br>";
                                                if (lst.Element("lst").LastAttribute.Name == "ConvReferencevalue")
                                                {
                                                    OtherReferenceRange += " < " + lst.Element("lst").Attribute("ConvReferencevalue").Value + "<br>";
                                                }
                                            }
                                            if (lst.Element("lsq") != null)
                                            {
                                                ReferenceRange += lst.Element("lsq").Value + ": <= " + lst.Element("lsq").Attribute("value").Value + "<br>";
                                                if (lst.Element("lsq").LastAttribute.Name == "ConvReferencevalue")
                                                {
                                                    OtherReferenceRange += " <= " + lst.Element("lsq").Attribute("ConvReferencevalue").Value + "<br>";
                                                }
                                            }

                                            if (lst.Element("eql") != null)
                                            {
                                                ReferenceRange += lst.Element("eql").Value + ": = " + lst.Element("eql").Attribute("value").Value + "<br>";
                                                if (lst.Element("eql").LastAttribute.Name == "ConvReferencevalue")
                                                {
                                                    OtherReferenceRange += " = " + lst.Element("eql").Attribute("ConvReferencevalue").Value + "<br>";
                                                }
                                            }

                                            if (lst.Element("grt") != null)
                                            {
                                                ReferenceRange += lst.Element("grt").Value + ": > " + lst.Element("grt").Attribute("value").Value + "<br>";
                                                if (lst.Element("grt").LastAttribute.Name == "ConvReferencevalue")
                                                {
                                                    OtherReferenceRange += "> " + lst.Element("grt").Attribute("ConvReferencevalue").Value + "<br>";
                                                    //lst.Element("grt").Value + ":
                                                }
                                            }


                                            if (lst.Element("grq") != null)
                                            {
                                                ReferenceRange += lst.Element("grq").Value + ": >= " + lst.Element("grq").Attribute("value").Value + "<br>";
                                                if (lst.Element("grq").LastAttribute.Name == "ConvReferencevalue")
                                                {
                                                    OtherReferenceRange += " >= " + lst.Element("grq").Attribute("ConvReferencevalue").Value + "<br>";
                                                }
                                            }

                                            if (lst.Element("btw") != null)
                                            {
                                                ReferenceRange += lst.Element("btw").Value + ": " + lst.Element("btw").Attribute("value").Value + "<br>";
                                                if (lst.Element("btw").LastAttribute.Name == "ConvReferencevalue")
                                                {
                                                    OtherReferenceRange += " " + lst.Element("btw").Attribute("ConvReferencevalue").Value + "<br>";
                                                }
                                            }
                                            if (lst.Element("ref") != null)
                                            {
                                                ReferenceRange += lst.Element("ref").Value + "<br>";
                                            }
                                        }
                                    }
                                    if (otherRangeText != null && otherRangeText.Count() > 0)
                                    {
                                        foreach (var lst in otherRangeText)
                                        {
                                            if (lst.Element("txt") != null)
                                            {
                                                ReferenceRange += lst.Element("txt").Value + "<br>";
                                            }
                                            if (lst.Element("ref") != null)
                                            {
                                                ReferenceRange += lst.Element("ref").Value + "<br>";
                                            }
                                        }
                                    }
                                }
                                else if ((otherRangeBoth != null && otherRangeBoth.Count() > 0) || (otherRangeBothText != null && otherRangeBothText.Count() > 0))
                                {
                                    if (otherRangeBoth != null && otherRangeBoth.Count() > 0)
                                    {
                                        foreach (var lst in otherRangeBoth)
                                        {
                                            if (lst.Element("lst") != null)
                                            {
                                                //ReferenceRange += lst.Element("lst").FirstAttribute.Value + " :  " + lst.Element("lst").Value + " < " + lst.Element("lst").LastAttribute.Value + " " + uom + "\n";
                                                ReferenceRange += lst.Element("lst").Value + ": < " + lst.Element("lst").Attribute("value").Value + "<br>";
                                                if (lst.Element("lst").LastAttribute.Name == "ConvReferencevalue")
                                                {
                                                    OtherReferenceRange += " < " + lst.Element("lst").Attribute("ConvReferencevalue").Value + "<br>";
                                                    //lst.Element("lst").Value + ":
                                                }
                                            }
                                            if (lst.Element("lsq") != null)
                                            {
                                                //ReferenceRange += lst.Element("lsq").FirstAttribute.Value + " :  " + lst.Element("lsq").Value + " <= " + lst.Element("lsq").LastAttribute.Value + " " + uom + "\n";
                                                ReferenceRange += lst.Element("lsq").Value + ": <= " + lst.Element("lsq").Attribute("value").Value + "<br>";
                                                if (lst.Element("lsq").LastAttribute.Name == "ConvReferencevalue")
                                                {
                                                    OtherReferenceRange += " <= " + lst.Element("lsq").Attribute("ConvReferencevalue").Value + "<br>";
                                                    //lst.Element("lsq").Value + ":
                                                }
                                            }

                                            if (lst.Element("eql") != null)
                                            {
                                                //ReferenceRange += lst.Element("eql").FirstAttribute.Value + " :  " + lst.Element("eql").Value + " = " + lst.Element("eql").LastAttribute.Value + " " + uom + "\n";
                                                ReferenceRange += lst.Element("eql").Value + ": = " + lst.Element("eql").Attribute("value").Value + "<br>";
                                                if (lst.Element("eql").LastAttribute.Name == "ConvReferencevalue")
                                                {
                                                    OtherReferenceRange += " = " + lst.Element("eql").Attribute("ConvReferencevalue").Value + "<br>";
                                                    //lst.Element("eql").Value + ":
                                                }
                                            }

                                            if (lst.Element("grt") != null)
                                            {
                                                //ReferenceRange += lst.Element("grt").FirstAttribute.Value + " :  " + lst.Element("grt").Value + " > " + lst.Element("grt").LastAttribute.Value + " " + uom + "\n";
                                                ReferenceRange += lst.Element("grt").Value + ": > " + lst.Element("grt").Attribute("value").Value + "<br>";
                                                if (lst.Element("grt").LastAttribute.Name == "ConvReferencevalue")
                                                {
                                                    OtherReferenceRange += " > " + lst.Element("grt").Attribute("ConvReferencevalue").Value + "<br>";
                                                    //lst.Element("grt").Value + ":
                                                }
                                            }


                                            if (lst.Element("grq") != null)
                                            {
                                                //ReferenceRange += lst.Element("grq").FirstAttribute.Value + " :  " + lst.Element("grq").Value + " >= " + lst.Element("grq").LastAttribute.Value + " " + uom + "\n";
                                                ReferenceRange += lst.Element("grq").Value + ": >= " + lst.Element("grq").Attribute("value").Value + "<br>";
                                                if (lst.Element("grq").LastAttribute.Name == "ConvReferencevalue")
                                                {
                                                    OtherReferenceRange += " >= " + lst.Element("grq").Attribute("ConvReferencevalue").Value + "<br>";
                                                    //lst.Element("grq").Value + ":
                                                }
                                            }

                                            if (lst.Element("btw") != null)
                                            {
                                                //ReferenceRange += lst.Element("btw").FirstAttribute.Value + " :  " + lst.Element("btw").Value + " Between " + lst.Element("btw").LastAttribute.Value + " " + uom + "\n";
                                                ReferenceRange += lst.Element("btw").Value + ": " + lst.Element("btw").Attribute("value").Value + "<br>";
                                                if (lst.Element("btw").LastAttribute.Name == "ConvReferencevalue")
                                                {
                                                    OtherReferenceRange += " " + lst.Element("btw").Attribute("ConvReferencevalue").Value + "<br>";
                                                    //lst.Element("btw").Value + ":
                                                }
                                            }
                                            if (lst.Element("ref") != null)
                                            {
                                                ReferenceRange += lst.Element("ref").Value + "<br>";
                                            }
                                        }
                                    }

                                    if (otherRangeBothText != null && otherRangeBothText.Count() > 0)
                                    {
                                        foreach (var lst in otherRangeBothText)
                                        {
                                            if (lst.Element("txt") != null)
                                            {
                                                ReferenceRange += lst.Element("txt").Value + "<br>";
                                            }
                                            if (lst.Element("ref") != null)
                                            {
                                                ReferenceRange += lst.Element("ref").Value + "<br>";
                                            }
                                        }
                                    }
                                }
                            }
                            if (ReferenceRange == "")
                            {
                                XElement xer = XElement.Parse(xmlData);

                                if (xe.Elements(oRangeType).Elements("property") != null)
                                {
                                    ReferenceRange = ConvertXmlToShowAllRange(xmlData, oRangeType, uom, pGender);
                                }
                                else
                                {
                                    ReferenceRange = xmlData;
                                }
                            }
                        }
                        if (oRangeType == "referencerange")
                        {
                            NormalReferenceRange = ReferenceRange;
                        }
                        else if (oRangeType == "printablerange")
                        {
                            PrintableRange = ReferenceRange;
                        }
                        else if (oRangeType == "panicrange")
                        {
                            OtherReferenceRange = ReferenceRange;
                        }
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(xmlData))
                    {
                        NormalReferenceRange = xmlData.Trim().Replace("<br>", "\n");
                    }
                }
            }
            catch (Exception)
            {
                NormalReferenceRange = string.Empty;

            }
            return NormalReferenceRange;
        }

        public static bool TryParseXml(string xml)
        {
            try
            {
                XElement xe = XElement.Parse(xml);
                return true;
            }
            catch (XmlException)
            {
                return false;
            }
        }

        public static string xmltoJSON(string ReferenceRange)
        {
            string jsonText = "";
            if (!string.IsNullOrEmpty(ReferenceRange) && ReferenceRange.StartsWith("<?xml"))
            {

                XElement xe = XElement.Parse(ReferenceRange);
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xe.ToString());
                jsonText = (Regex.Replace((JsonConvert.SerializeXmlNode(doc, Formatting.Indented, false)), "(?<=\")(@)(?!.*\":\\s )", string.Empty, RegexOptions.IgnoreCase)).Replace("#", ""); //JsonConvert.SerializeObject(xe, Newtonsoft.Json.Formatting.);
            }
            return jsonText;
        }

        public static double ConvertToDays(double age, string agetype)
        {
            double ageInDays = 0;
            if (agetype == "Week(s)")
            {
                agetype = "Weeks";
            }
            else if (agetype == "Month(s)")
            {
                agetype = "Months";
            }
            else if (agetype == "Year(s)")
            {
                agetype = "Years";
            }
            else if (agetype == "Day(s)")
            {
                agetype = "Days";
            }

            switch (agetype)
            {
                case "Weeks":
                    ageInDays = Math.Round(age * 7);
                    break;
                case "Months":
                    ageInDays = Math.Round(age * 30.416666667);
                    break;
                case "Years":
                    ageInDays = Math.Round(age * 365);
                    break;
                case "Days":
                    ageInDays = Math.Round(age);
                    break;
            }
            return ageInDays;

        }

        public static string ConvertRangeStringOptr(string symbol)
        {
            string ReturnValue = "";
            switch (symbol)
            {
                case "lst":
                    ReturnValue = "<";
                    break;
                case "lsq":
                    ReturnValue = "<=";
                    break;
                case "eql":
                    ReturnValue = "=";
                    break;
                case "grt":
                    ReturnValue = ">";
                    break;
                case "grq":
                    ReturnValue = "=>";
                    break;
                case "btw":
                    ReturnValue = " ";
                    break;
                case "ref":
                    ReturnValue = "Source";
                    break;
            }
            return ReturnValue;

        }

        public static string AddSpace(string text)
        {
            string spacedText = string.Empty;
            try
            {
                string[] rawText = text.Split('-');
                if (rawText.Count() == 2)
                {
                    spacedText = rawText[0] + " - " + rawText[1];
                }
                else
                {
                    spacedText = text;
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return spacedText;
        }        

        #region SaveBillingPart
        public static string CreateUniqueDecimalString()
        {
            string uniqueDecimalString = "1.2.840.113619.";
            uniqueDecimalString += GetUniqueKey() + ".";
            uniqueDecimalString += GetUniqueKey();
            return uniqueDecimalString;
        }

        public static string GetUniqueKey()
        {
            int maxSize = 10;
            char[] chars = new char[62];
            string a;
            //a = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            a = "0123456789012345678901234567890123456789012345678901234567890123456789";
            chars = a.ToCharArray();
            int size = maxSize;
            byte[] data = new byte[1];
            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
            crypto.GetNonZeroBytes(data);
            size = maxSize;
            data = new byte[size];
            crypto.GetNonZeroBytes(data);
            StringBuilder result = new StringBuilder(size);
            foreach (byte b in data)
            { result.Append(chars[b % (chars.Length - 1)]); }
            return result.ToString();
        }
        #endregion
    }
}
