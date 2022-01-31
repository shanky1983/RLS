using System;
using System.Collections.Generic;
using System.Linq;
using Attune.KernelV2.DAL;
using Attune.KernelV2.Entities;
using Attune.KernelV2.Utilities;
using System.Collections;

namespace Attune.KernelV2.BL
{
    public class Investigation_BL : IDisposable
    {
        UI_ContextDetails globalContextDetails;

        public Investigation_BL(UI_ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        public List<UI_InvestigationIDs> fnValidateResulValue(string resultValue, List<UI_InvValueRangeMaster> lstInvValueRangeMaster)
        {
            List<UI_InvestigationIDs> lstReflexPatientInvestigation = new List<UI_InvestigationIDs>();

            Boolean ISNumericResultValue;
            Decimal ResultValueS;
            UI_InvestigationIDs objpinv;
            ResultValueS = ConvertResultValue(resultValue, out ISNumericResultValue);
            foreach (var item in lstInvValueRangeMaster)
            {
                objpinv = new UI_InvestigationIDs();
                switch (item.Range)
                {
                    case "EQ":
                        if (resultValue.ToLower().Trim() == item.ValueRange.ToLower().Trim())
                        {
                            objpinv.InvestigationID = item.ReflexInvestigationID;
                        }
                        break;
                    case "NEQ":
                        if (resultValue.ToLower().Trim() != item.ValueRange.ToLower().Trim())
                        {
                            objpinv.InvestigationID = item.ReflexInvestigationID;
                        }
                        break;
                    case "LT":
                        if (Convert.ToDecimal(ResultValueS) < Convert.ToDecimal(item.ValueRange))
                        {
                            objpinv.InvestigationID = item.ReflexInvestigationID;
                        }
                        break;
                    case "GT":
                        if (Convert.ToDecimal(ResultValueS) > Convert.ToDecimal(item.ValueRange))
                        {
                            objpinv.InvestigationID = item.ReflexInvestigationID;
                        }
                        break;
                    case "LTEQ":
                        if (Convert.ToDecimal(ResultValueS) <= Convert.ToDecimal(item.ValueRange))
                        {
                            objpinv.InvestigationID = item.ReflexInvestigationID;
                        }
                        break;
                    case "GTEQ":
                        if (Convert.ToDecimal(ResultValueS) >= Convert.ToDecimal(item.ValueRange))
                        {
                            objpinv.InvestigationID = item.ReflexInvestigationID;
                        }
                        break;
                    case "BTW":
                        string[] resultval = item.ValueRange.Split('-');
                        if ((Convert.ToDecimal(resultval[0]) <= Convert.ToDecimal(ResultValueS)) && (Convert.ToDecimal(ResultValueS) <= Convert.ToDecimal(resultval[1])))
                        {
                            objpinv.InvestigationID = item.ReflexInvestigationID;
                        }
                        break;
                }
                lstReflexPatientInvestigation.Add(objpinv);
            }
            return lstReflexPatientInvestigation;
        }

        public decimal ConvertResultValue(string result, out bool isNumericValue)
        {
            isNumericValue = false;
            decimal returnValue = 0;

            if (!string.IsNullOrEmpty(result))
            {
                decimal numericResult;
                string opr = string.Empty;
                if (result.Contains("<") || result.ToLower().Contains("below"))
                {
                    opr = "lst";
                    result = result.Replace("<", "").Replace("Below", "").Replace("below", "");
                }
                if (result.Contains(">") || result.ToLower().Contains("above"))
                {
                    opr = "grt";
                    result = result.Replace(">", "").Replace("Above", "").Replace("above", "");
                }
                if (result.Contains(','))
                {
                    string[] lstresultinter = result.Split(',');
                    if (lstresultinter.Length > 1)
                    {
                        result = lstresultinter[1];
                    }
                }
                if (decimal.TryParse(result, out numericResult))
                {
                    isNumericValue = true;
                    if (opr == "lst")
                    {
                        numericResult = numericResult - 1;
                    }
                    else if (opr == "grt")
                    {
                        numericResult = numericResult + 1;
                    }
                    returnValue = numericResult;
                }
            }
            return returnValue;
        }

        private List<UI_InvGroupValidation> ValidateFormula(IEnumerable<UI_InvGroupValidation> lstGroup)
        {
            var uiInvGroupValidations = lstGroup.ToList();
            List<UI_InvGroupValidation> lst = uiInvGroupValidations.Select(s => new UI_InvGroupValidation { GroupID = s.GroupID, DeptID = s.DeptID, ValidationText = s.ValidationText }).Distinct().ToList();
            string shead = "(function() { ";
            string send = " })();";
            foreach (var item in lst)
            {
                item.ValidationText = shead + item.ValidationText;
                foreach (UI_InvGroupValidation grop in uiInvGroupValidations.Where(p => p.GroupID == item.GroupID && p.DeptID == item.DeptID))
                {
                    if (!string.IsNullOrEmpty(item.ValidationText))
                    {
                        // item.ValidationText = item.ValidationText.Replace("if(document.getElementById('hdnEditableFormulaFields') != null){txtEditable1 = document.getElementById('hdnEditableFormulaFields').value.indexOf('[" + grop.InvestigationID + "]') >= 0 ? true : false;}", "$scope.EditableFormula");
                        item.ValidationText = item.ValidationText.Replace("indexOf('[" + grop.InvestigationID + "]')", "indexOf('[" + grop.InvestigationID + "_" + grop.RowNumber + "]')");
                        if (item.ValidationText.Replace(" ", "").Contains("[" + grop.InvestigationID + "]="))
                        {
                            item.InvestigationID = grop.InvestigationID;
                            item.ValidationText = item.ValidationText.Replace("[" + grop.InvestigationID + "] = ", "document.getElementById('" + grop.InvestigationID + "_" + grop.RowNumber + "').value=");
                            item.ValidationText = item.ValidationText + " $('#" + grop.InvestigationID + "_" + grop.RowNumber + "').trigger('change');";
                        }
                        item.ValidationText = item.ValidationText.Replace("[" + grop.InvestigationID + "]", "document.getElementById('" + grop.InvestigationID + "_" + grop.RowNumber + "').value");

                    }
                }
                item.ValidationText = item.ValidationText + send;

            }
            return lst;
        }

        public List<UI_OrderedInvestigations> GetpatientInvestigationForVisit(long visitID, int OrgID, int OrgAddressID, int LocationID, string gUID)
        {
            List<UI_OrderedInvestigations> lstPatientInvestigation;

            using (Investigation_DAL DAL = new Investigation_DAL(globalContextDetails))
            {
                lstPatientInvestigation = DAL.GetpatientInvestigationForVisit(visitID, OrgID, OrgAddressID, gUID);
            }

            return lstPatientInvestigation;
        }

        public List<UI_ReferenceRangeType> GetReferenceRangeType(int Orgid, string LangCode)
        {
            List<UI_ReferenceRangeType> lstReferenceRangeType;

            using (Investigation_DAL DAL = new Investigation_DAL(globalContextDetails))
            {
                lstReferenceRangeType = DAL.GetReferenceRangeType(Orgid, LangCode);
            }
            return lstReferenceRangeType;
        }

        public List<UI_InvReasonMasters> GetInvReasons(int OrgID)
        {
            List<UI_InvReasonMasters> lstInvReasonMasters;

            using (Investigation_DAL DAL = new Investigation_DAL(globalContextDetails))
            {
                lstInvReasonMasters = DAL.GetInvReasons(OrgID);
            }
            return lstInvReasonMasters;
        }

        public List<UI_InvQualitativeResultMaster> GetInvQualitativeResult()
        {
            List<UI_InvQualitativeResultMaster> lstInvQualitativeResult;

            using (Investigation_DAL DAL = new Investigation_DAL(globalContextDetails))
            {
                lstInvQualitativeResult = DAL.GetInvQualitativeResult();
            }
            return lstInvQualitativeResult;
        }

        public UI_ResultCapture GetInvestigatonResultsCapture(long VID, int OrgID, long RoleID, string gUID,
            long DeptID, string InvIDs, int LocationID, UI_LoginDetail LDetail, long TaskID, string IsTrustedDetails, string Status)
        {

            UI_ResultCapture objResultCapture = new UI_ResultCapture();
            UI_PatientVisit objPatientLabVisitDetails = null;

            using (Investigation_DAL DAL = new Investigation_DAL(globalContextDetails))
            {

                UI_InvResultsCapture lstUI_InvResultsCapture = DAL.GetInvestigatonResultsCapture(VID, OrgID, RoleID, gUID, DeptID, InvIDs, LocationID,
                                          LDetail, TaskID, IsTrustedDetails, Status);

                List<UI_PatientVisit> lstPatientLabVisitDetails;
                using (Patient_BL BL = new Patient_BL(globalContextDetails))
                {
                    lstPatientLabVisitDetails = BL.GetPatientBannerDetails(VID, OrgID, gUID);
                }

                if (lstPatientLabVisitDetails != null && lstPatientLabVisitDetails.Count > 0)
                {
                    objPatientLabVisitDetails = lstPatientLabVisitDetails.FirstOrDefault();
                    objPatientLabVisitDetails.ReferenceRangeAge = objPatientLabVisitDetails.ReferenceRangeAge + '*' + objPatientLabVisitDetails.SpeciesName;
                }

                var lstGroup = lstUI_InvResultsCapture.lstUI_PatientInvestigation.Where(t => t.ValidationText != "")
                                .Select(c => new UI_InvGroupValidation
                                {
                                    ValidationText = c.ValidationText,
                                    GroupID = c.GroupID,
                                    DeptID = c.DeptID,
                                    InvestigationID = c.InvestigationID,
                                    RowNumber = c.RowNumber
                                }).Distinct();


                List<UI_InvGroupValidation> pval = ValidateFormula(lstGroup);
                int counter = 1;
                objResultCapture.InvDept = (from b in lstUI_InvResultsCapture.lstUI_PatientInvestigation
                                            where b.DeptID != 0 && b.DeptName != ""
                                            group b by new
                                             {
                                                 b.DeptID,
                                                 b.DeptName
                                             } into newlist

                                            select new UI_InvDept
                                            {
                                                DeptID = newlist.Key.DeptID,
                                                DeptName = newlist.Key.DeptName,
                                                InvStatus = lstUI_InvResultsCapture.lstUI_InvestigationStatus.GroupBy(c => c.Status).Select(g => g.First()).ToList(),
                                                lstUI_Group = (from c in lstUI_InvResultsCapture.lstUI_PatientInvestigation
                                                               group c by new
                                                               {
                                                                   c.DeptID,
                                                                   c.DeptName,
                                                                   c.GroupID,
                                                                   c.GroupName
                                                               } into newGrouplist
                                                               where newlist.Key.DeptID == newGrouplist.Key.DeptID &&
                                                               newlist.Key.DeptName == newGrouplist.Key.DeptName && newGrouplist.Key.GroupName != "" && newGrouplist.Key.GroupID > 0
                                                               select new UI_Group
                                                               {
                                                                   GroupindexID = string.Format("{0}_{1}", (newGrouplist.Key.GroupID), (counter++)),
                                                                   GroupID = newGrouplist.Key.GroupID,
                                                                   GroupName = newGrouplist.Key.GroupName,
                                                                   Comment = lstUI_InvResultsCapture.lstUI_PatientInvestigation.Find(p =>
                                                                       p.DeptID == newGrouplist.Key.DeptID
                                                                       && p.DeptName == newGrouplist.Key.DeptName
                                                                       && p.GroupID == newGrouplist.Key.GroupID
                                                                       && p.GroupName == newGrouplist.Key.GroupName).GroupComment,
                                                                   Remarks = lstUI_InvResultsCapture.lstUI_PatientInvestigation.Find(p =>
                                                                       p.DeptID == newGrouplist.Key.DeptID
                                                                       && p.DeptName == newGrouplist.Key.DeptName
                                                                       && p.GroupID == newGrouplist.Key.GroupID
                                                                       && p.GroupName == newGrouplist.Key.GroupName).GroupMedicalRemarks,
                                                                   InvStatus = lstUI_InvResultsCapture.lstUI_InvestigationStatus.GroupBy(c => c.Status)
                                                                   .Select(g => g.First()).ToList(),
                                                                   lstUI_PatientInvestigation = (from d in lstUI_InvResultsCapture.lstUI_PatientInvestigation
                                                                                                 orderby d.SequenceNo
                                                                                                 where d.DeptID == newlist.Key.DeptID &&
                                                                                                 d.DeptName == newlist.Key.DeptName &&
                                                                                                 d.GroupName == newGrouplist.Key.GroupName &&
                                                                                                 d.GroupID == newGrouplist.Key.GroupID
                                                                                                 select new UI_PatientInvestigation
                                                                                                 {
                                                                                                     RowNumber = d.RowNumber,
                                                                                                     InvestigationID = d.InvestigationID,
                                                                                                     InvestigationName = d.InvestigationName,
                                                                                                     GroupID = d.GroupID,
                                                                                                     GroupName = d.GroupName,
                                                                                                     DeptID = d.DeptID,
                                                                                                     DeptName = d.DeptName,
                                                                                                     CONV_UOMID = d.CONV_UOMID,
                                                                                                     UOMCode = d.UOMCode,
                                                                                                     ReferenceRange = Helper.ConvertXmlToString(d.ReferenceRange, d.UOMCode,
                                                                                                     objPatientLabVisitDetails.Sex, objPatientLabVisitDetails.ReferenceRangeAge),
                                                                                                     AutoApproveLoginID = d.AutoApproveLoginID,
                                                                                                     RefSuffixText = d.RefSuffixText,
                                                                                                     PatternID = d.PatternID,
                                                                                                     PatternName = d.PatternName,
                                                                                                     GroupComment = d.GroupComment,
                                                                                                     ValidationText = d.ValidationText != "" ? pval.Find(p =>
                                                                                                         p.GroupID == d.GroupID).ValidationText : "",
                                                                                                     IsNonEditable = pval.Exists(p =>
                                                                                                         p.GroupID == d.GroupID && p.InvestigationID == d.InvestigationID),
                                                                                                     IsAbnormal = d.IsAbnormal,
                                                                                                     InvValidationText = d.InvValidationText,
                                                                                                     Reason = d.Reason,
                                                                                                     MedicalRemarks = d.MedicalRemarks,
                                                                                                     GroupMedicalRemarks = d.GroupMedicalRemarks,
                                                                                                     ResultValueType = d.ResultValueType,
                                                                                                     DecimalPlaces = d.DecimalPlaces,
                                                                                                     PackageID = d.PackageID,
                                                                                                     PackageName = d.PackageName,
                                                                                                     SequenceNo = d.SequenceNo,
                                                                                                     AccessionNumber = d.AccessionNumber,
                                                                                                     Display = d.Display,
                                                                                                     RootGroupID = d.RootGroupID,
                                                                                                     Status = d.Status,
                                                                                                     IsCoAuthorized = d.IsCoAuthorized,
                                                                                                     UserID = d.UserID,
                                                                                                     CONV_UOMCode = d.CONV_UOMCode,
                                                                                                     CONV_Factor = d.CONV_Factor,
                                                                                                     CONVFactorDecimalPt = d.CONVFactorDecimalPt,
                                                                                                     ConvReferenceRange = d.ConvReferenceRange,
                                                                                                     IsSensitive = d.IsSensitive,
                                                                                                     MethodName = d.MethodName,
                                                                                                     Value = d.Value,
                                                                                                     DeviceID = d.DeviceID,
                                                                                                     ValidationRule = d.ValidationRule,
                                                                                                     IOMReferenceRange = Helper.xmltoJSON(d.IOMReferenceRange),
                                                                                                     ErrorCode = d.ErrorCode,
                                                                                                     IsFormulaField = d.IsFormulaField,
                                                                                                     DisplayStatus = d.DisplayStatus,
                                                                                                     DeviceActualValue = d.DeviceActualValue,
                                                                                                     HeaderName = d.HeaderName,
                                                                                                     PdfStatus = d.PdfStatus,
                                                                                                     IsFormulaCalculateOnDevice = d.IsFormulaCalculateOnDevice,
                                                                                                     IsAutoValidate = d.IsAutoValidate,
                                                                                                     TestStatus = d.TestStatus,
                                                                                                     InvStatus = lstUI_InvResultsCapture.lstUI_InvestigationStatus.FindAll(p =>
                                                                                                         p.InvestigationID == d.InvestigationID),
                                                                                                     InvestigationValues = lstUI_InvResultsCapture.InvestigationValues.FindAll(p =>
                                                                                                         p.InvestigationID == d.InvestigationID)
                                                                                                 }).ToList()
                                                               }).ToList(),
                                                lstUI_PatientInvestigation = (from e in lstUI_InvResultsCapture.lstUI_PatientInvestigation
                                                                              orderby e.SequenceNo
                                                                              where e.DeptID == newlist.Key.DeptID &&
                                                                              e.DeptName == newlist.Key.DeptName &&
                                                                              e.GroupID == 0 && e.GroupName == ""
                                                                              select new UI_PatientInvestigation
                                                                              {
                                                                                  RowNumber = e.RowNumber,
                                                                                  InvestigationID = e.InvestigationID,
                                                                                  InvestigationName = e.InvestigationName,
                                                                                  GroupID = e.GroupID,
                                                                                  GroupName = e.GroupName,
                                                                                  DeptID = e.DeptID,
                                                                                  DeptName = e.DeptName,
                                                                                  CONV_UOMID = e.CONV_UOMID,
                                                                                  UOMCode = e.UOMCode,
                                                                                  ReferenceRange = Helper.ConvertXmlToString(e.ReferenceRange, e.UOMCode,
                                                                                  objPatientLabVisitDetails.Sex, objPatientLabVisitDetails.ReferenceRangeAge),
                                                                                  AutoApproveLoginID = e.AutoApproveLoginID,
                                                                                  RefSuffixText = e.RefSuffixText,
                                                                                  PatternID = e.PatternID,
                                                                                  PatternName = e.PatternName,
                                                                                  GroupComment = e.GroupComment,
                                                                                  ValidationText = e.ValidationText,
                                                                                  IsAbnormal = e.IsAbnormal,
                                                                                  InvValidationText = e.InvValidationText,
                                                                                  Reason = e.Reason,
                                                                                  MedicalRemarks = e.MedicalRemarks,
                                                                                  GroupMedicalRemarks = e.GroupMedicalRemarks,
                                                                                  ResultValueType = e.ResultValueType,
                                                                                  DecimalPlaces = e.DecimalPlaces,
                                                                                  PackageID = e.PackageID,
                                                                                  PackageName = e.PackageName,
                                                                                  SequenceNo = e.SequenceNo,
                                                                                  AccessionNumber = e.AccessionNumber,
                                                                                  Display = e.Display,
                                                                                  RootGroupID = e.RootGroupID,
                                                                                  Status = e.Status,
                                                                                  IsCoAuthorized = e.IsCoAuthorized,
                                                                                  UserID = e.UserID,
                                                                                  CONV_UOMCode = e.CONV_UOMCode,
                                                                                  CONV_Factor = e.CONV_Factor,
                                                                                  CONVFactorDecimalPt = e.CONVFactorDecimalPt,
                                                                                  ConvReferenceRange = e.ConvReferenceRange,
                                                                                  IsSensitive = e.IsSensitive,
                                                                                  MethodName = e.MethodName,
                                                                                  Value = e.Value,
                                                                                  DeviceID = e.DeviceID,
                                                                                  ValidationRule = e.ValidationRule,
                                                                                  IOMReferenceRange = Helper.xmltoJSON(e.IOMReferenceRange),
                                                                                  ErrorCode = e.ErrorCode,
                                                                                  IsFormulaField = e.IsFormulaField,
                                                                                  DisplayStatus = e.DisplayStatus,
                                                                                  DeviceActualValue = e.DeviceActualValue,
                                                                                  HeaderName = e.HeaderName,
                                                                                  PdfStatus = e.PdfStatus,
                                                                                  IsFormulaCalculateOnDevice = e.IsFormulaCalculateOnDevice,
                                                                                  IsAutoValidate = e.IsAutoValidate,
                                                                                  TestStatus = e.TestStatus,
                                                                                  InvStatus = lstUI_InvResultsCapture.lstUI_InvestigationStatus.FindAll(p =>
                                                                                      p.InvestigationID == e.InvestigationID),
                                                                                  InvestigationValues = lstUI_InvResultsCapture.InvestigationValues.FindAll(p =>
                                                                                      p.InvestigationID == e.InvestigationID)
                                                                              }).ToList()
                                            }).ToList();

                List<UI_InvReasonMasters> lstInvReason = GetInvReasons(OrgID);

                List<UI_InvQualitativeResultMaster> InvQualitativeResult = GetInvQualitativeResult();
                objResultCapture.InvReasons = lstInvReason;
                objResultCapture.InvQualitativeResult = InvQualitativeResult;

            }
            return objResultCapture;
        }

        public List<UI_InvValueRangeMaster> GetReflexTestDetails(List<UI_PatientInvestigation> lstPatientInvestigation, int OrgID)
        {
            List<UI_InvValueRangeMaster> lstInvValueRangeMaster;

            using (Investigation_DAL DAL = new Investigation_DAL(globalContextDetails))
            {
                lstInvValueRangeMaster = DAL.GetReflexTestDetails(lstPatientInvestigation, OrgID);
            }
            return lstInvValueRangeMaster;
        }

        public string GetNextBarcode(long OrgID, string IDType, string ID, long OrgAddressID, long RefID, string RefType)
        {
            string Barcode;
            using (Investigation_DAL DAL = new Investigation_DAL(globalContextDetails))
            {
                Barcode = DAL.GetNextBarcode(OrgID, IDType, ID, OrgAddressID, RefID, RefType);
            }
            return Barcode;
        }

        private List<UI_PatientInvestigation> GetInvestigationSamplesCollect(long PatientVisitID, int OrgID, long roleID, string gUID, int LocationID, int taskactionID)
        {
            List<UI_PatientInvestigation> lstPatientInvestigation;

            using (Investigation_DAL DAL = new Investigation_DAL(globalContextDetails))
            {
                lstPatientInvestigation = DAL.GetInvestigationSamplesCollect(PatientVisitID, OrgID, roleID, gUID, LocationID, taskactionID);
            }
            return lstPatientInvestigation;
        }

        public List<UI_PatientInvestigation> GetPatientInvestigationStatus(long VisitID, int OrgID)
        {
            List<UI_PatientInvestigation> lstPatientInvestigation;
            using (Investigation_DAL DAL = new Investigation_DAL(globalContextDetails))
            {
                lstPatientInvestigation = DAL.GetPatientInvestigationStatus(VisitID, OrgID);
            }
            return lstPatientInvestigation;
        }

        public List<UI_PatientInvestigation> Grouplevelvalidation(long VisitID, int TaskActionID, int OrgID, int Lid, List<UI_PatientInvestigation> lstPatientInvestigation)
        {
            using (Investigation_DAL DAL = new Investigation_DAL(globalContextDetails))
            {
                lstPatientInvestigation = DAL.Grouplevelvalidation(VisitID, TaskActionID, OrgID, Lid, lstPatientInvestigation);
            }
            return lstPatientInvestigation;
        }

        public long InsertInvQualitativeResult(List<UI_InvestigationBulkData> lstInvestigationBulkData)
        {
            long returncode;

            using (Investigation_DAL DAL = new Investigation_DAL(globalContextDetails))
            {
                returncode = DAL.InsertInvQualitativeResult(lstInvestigationBulkData);
            }
            return returncode;
        }

        public long InsertINVSampleResults(List<UI_PatientInvSampleResults> lstPatientInvSampleResults, long VisitID, int OrgID)
        {
            long returncode;

            using (Investigation_DAL DAL = new Investigation_DAL(globalContextDetails))
            {
                returncode = DAL.InsertINVSampleResults(lstPatientInvSampleResults, VisitID, OrgID);
            }
            return returncode;
        }

        public long InsertINVSampleMapping(List<UI_PatientInvSampleMapping> lstPatientInvSampleMapping, long VisitID, int OrgID, int DeptID)
        {
            long returncode;

            using (Investigation_DAL DAL = new Investigation_DAL(globalContextDetails))
            {
                returncode = DAL.InsertINVSampleMapping(lstPatientInvSampleMapping, VisitID, OrgID, DeptID);
            }
            return returncode;
        }

        private long InsertInvestigationResults(List<UI_InvestigationValues> lstInvestigationValues, long pSCMID, long VisitID, string GUID, string IsFromDevice)
        {
            long returncode;
            using (Investigation_DAL DAL = new Investigation_DAL(globalContextDetails))
            {
                returncode = DAL.InsertInvestigationResults(lstInvestigationValues, pSCMID, VisitID, GUID, IsFromDevice);
            }
            return returncode;
        }

        private long UpdatePatientInvestigationComplete(List<UI_PatientInvestigation> lstPatientInvestigation, List<UI_InvestigationIDs> lstReflexPatientInvestigation, long SCMID,
                long ApprovedBy, string UID)
        {
            long returncode;

            using (Investigation_DAL DAL = new Investigation_DAL(globalContextDetails))
            {
                returncode = DAL.UpdatePatientInvestigationComplete(lstPatientInvestigation, lstReflexPatientInvestigation, SCMID, ApprovedBy, UID);
            }
            return returncode;
        }

        public long UpdateGroupComment(List<UI_PatientInvestigation> lstPatientInvestigation, string GUID)
        {
            long returncode;
            using (Investigation_DAL DAL = new Investigation_DAL(globalContextDetails))
            {
                returncode = DAL.UpdateGroupComment(lstPatientInvestigation, GUID);
            }
            return returncode;
        }

        public long UpdateInvestigationHoldonApproval(List<UI_PatientInvestigation> lstPInvestigation, string GUID)
        {
            long returncode;

            using (Investigation_DAL DAL = new Investigation_DAL(globalContextDetails))
            {
                returncode = DAL.UpdateInvestigationHoldonApproval(lstPInvestigation, GUID);
            }
            return returncode;
        }

        private int SavePatientInvestigation(List<UI_PatientInvestigation> PatientInvestigation, long OrgID, string gUID)
        {
            int returnstatus;

            using (Investigation_DAL DAL = new Investigation_DAL(globalContextDetails))
            {
                returnstatus = DAL.SavePatientInvestigation(PatientInvestigation, OrgID, gUID);
            }
            return returnstatus;
        }

        private long SavePatientInvSampleNMapping(List<UI_PatientInvSample> LstPinvsample, List<UI_PatientInvSampleMapping> LstPinvsamplemapping, string GUID, int OrgID)
        {
            long returnstatus;

            using (Investigation_DAL DAL = new Investigation_DAL(globalContextDetails))
            {
                returnstatus = DAL.SavePatientInvSampleNMapping(LstPinvsample, LstPinvsamplemapping, GUID, OrgID);
            }
            return returnstatus;
        }

        public long SaveInvestigationQueue(List<UI_InvestigationQueue> InvQueue, int OrgID)
        {
            long returncode;

            using (Investigation_DAL DAL = new Investigation_DAL(globalContextDetails))
            {
                returncode = DAL.SaveInvestigationQueue(InvQueue, OrgID);
            }
            return returncode;
        }

        public long SaveInvestigationValues(UI_ResultCapturePost ResultCapture, string gUID, long VisitID)
        {
            long returncode = -1;
            List<UI_InvestigationValues> lstInvestigationValues = new List<UI_InvestigationValues>();
            List<UI_PatientInvestigation> lstPatientInvestigation = new List<UI_PatientInvestigation>();
            List<UI_PatientInvestigation> lstPatientInvestigationStatus = new List<UI_PatientInvestigation>();

            lstPatientInvestigationStatus = GetPatientInvestigationStatus(VisitID, globalContextDetails.OrgID);

            var IsAutoAuthRecollect = (from IL in lstPatientInvestigationStatus where IL.ReferredType == "Retest" select IL).Count();

            foreach (UI_InvDept dept in ResultCapture.lstDept)
            {
                foreach (UI_Group group in dept.lstUI_Group)
                {

                    lstInvestigationValues.AddRange(group.lstUI_PatientInvestigation.Select(t => new UI_InvestigationValues
                        {
                            Name = t.InvestigationName,
                            InvestigationID = t.InvestigationID,
                            PatientVisitID = VisitID,
                            Value = t.Value,
                            UOMCode = t.UOMCode,
                            CreatedBy = globalContextDetails.LoginID,
                            GroupID = t.GroupID,
                            GroupName = t.GroupName,
                            Orgid = globalContextDetails.OrgID,
                            Status = t.Status,
                            PackageID = t.PackageID,
                            PackageName = t.PackageName,
                            Dilution = "",
                            UID = t.UID,
                            DeviceID = t.DeviceID,
                            DeviceValue = t.DeviceValue,
                            DeviceActualValue = t.DeviceActualValue,
                            DeviceErrorCode = t.DeviceErrorCode,
                            ConvUOMCode = t.CONV_UOMCode,
                            ConvValue = Helper.CalculateValue(t.Value, t.CONV_Factor, t.CONVFactorDecimalPt)
                        }).ToList());

                    lstPatientInvestigation.AddRange(group.lstUI_PatientInvestigation.Select(t => new UI_PatientInvestigation
                        {

                            InvestigationID = t.InvestigationID,
                            PatientVisitID = VisitID,
                            Status = t.Status,
                            ReferenceRange = t.ReferenceRange.Trim().Replace("\n", "<br>"),
                            TechnicalRemarks = t.TechnicalRemarks,
                            MedicalRemarks = t.MedicalRemarks,
                            OrgID = globalContextDetails.OrgID,
                            AutoApproveLoginID = t.AutoApproveLoginID,
                            AccessionNumber = t.AccessionNumber,
                            UID = t.UID,
                            LabNo = t.LabNo,
                            InvStatusReasonID = (int)(t.InvReasons == null ? 0 : t.InvReasons.ReasonID),
                            Reason = t.InvReasons == null ? t.Reason : t.InvReasons.Reason,
                            LoginID = globalContextDetails.LoginID,
                            GroupID = t.GroupID,
                            IsAbnormal = t.IsAbnormal,
                            RemarksID = t.RemarksID,
                            GroupName = t.GroupName,
                            AuthorizedBy = t.Status == "Approve" ? globalContextDetails.LoginID : 0,
                            IsAutoAuthorize = "N",
                            IsSensitive = t.IsSensitive ?? "N",
                            ManualAbnormal = t.ManualAbnormal ?? "N",
                            //Pinv.ConvReferenceRange = ConReferenceRange;
                            //Pinv.PrintableRange = hdnPrintableRange.Value.Trim().Replace("\n", "<br>");
                            GroupComment = group.Comment,
                            GroupMedicalRemarks = group.Remarks
                            //if((group.Comment!=null && group.Comment!="") || (group.Remarks !=null && group.Remarks!="")){
                            //    isGroupComment=true;
                            //}
                        }).ToList());
                }

                lstInvestigationValues.AddRange(dept.lstUI_PatientInvestigation.Select(t => new UI_InvestigationValues
                {
                    Name = t.InvestigationName,
                    InvestigationID = t.InvestigationID,
                    PatientVisitID = VisitID,
                    Value = t.Value,
                    UOMCode = t.UOMCode,
                    CreatedBy = globalContextDetails.LoginID,
                    GroupID = t.GroupID,
                    GroupName = t.GroupName,
                    Orgid = globalContextDetails.OrgID,
                    Status = t.Status,
                    PackageID = t.PackageID,
                    PackageName = t.PackageName,
                    Dilution = "",
                    UID = t.UID,
                    DeviceID = t.DeviceID,
                    DeviceValue = t.DeviceValue,
                    DeviceActualValue = t.DeviceActualValue,
                    DeviceErrorCode = t.DeviceErrorCode,

                    ConvUOMCode = t.CONV_UOMCode,
                    ConvValue = Helper.CalculateValue(t.Value, t.CONV_Factor, t.CONVFactorDecimalPt)
                }).ToList());

                lstPatientInvestigation.AddRange(dept.lstUI_PatientInvestigation.Select(t => new UI_PatientInvestigation
                {

                    InvestigationID = t.InvestigationID,
                    PatientVisitID = VisitID,
                    Status = t.Status,
                    ReferenceRange = t.ReferenceRange.Trim().Replace("\n", "<br>"),
                    TechnicalRemarks = t.TechnicalRemarks,
                    MedicalRemarks = t.MedicalRemarks,
                    OrgID = globalContextDetails.OrgID,
                    AutoApproveLoginID = t.AutoApproveLoginID,
                    AccessionNumber = t.AccessionNumber,
                    UID = t.UID,
                    LabNo = t.LabNo,
                    InvStatusReasonID = (int)(t.InvReasons == null ? 0 : t.InvReasons.ReasonID),
                    Reason = t.InvReasons == null ? t.Reason : t.InvReasons.Reason,
                    LoginID = globalContextDetails.LoginID,
                    GroupID = t.GroupID,
                    IsAbnormal = t.IsAbnormal,
                    RemarksID = t.RemarksID,
                    GroupName = t.GroupName,
                    AuthorizedBy = t.Status == "Approve" ? globalContextDetails.LoginID : 0,
                    IsAutoAuthorize = "N",
                    IsSensitive = t.IsSensitive ?? "N",
                    ManualAbnormal = t.ManualAbnormal ?? "N"
                    //Pinv.ConvReferenceRange = ConReferenceRange;
                    //Pinv.PrintableRange = hdnPrintableRange.Value.Trim().Replace("\n", "<br>");                    
                }).ToList());
            }
            //IsAutoAuthorize



            List<UI_InvValueRangeMaster> lstInvValueRangeMaster = GetReflexTestDetails(lstPatientInvestigation, globalContextDetails.OrgID);
            List<UI_InvestigationIDs> lstFinalReflexPatientinvestigation = new List<UI_InvestigationIDs>();
            foreach (UI_PatientInvestigation _list in lstPatientInvestigation)
            {
                var pResult = lstInvValueRangeMaster.FindAll(p => p.InvestigationID == _list.InvestigationID);
                if (pResult.Count > 0)
                {
                    List<UI_InvestigationIDs> lstReflexPatientInvestigation = fnValidateResulValue(_list.Value, pResult);
                    lstFinalReflexPatientinvestigation = lstFinalReflexPatientinvestigation.Union(lstReflexPatientInvestigation).ToList();
                }
            }

            if (ResultCapture.InvQualitativeResult != null && ResultCapture.InvQualitativeResult.Count > 0)
            {
                InsertInvQualitativeResult(ResultCapture.InvQualitativeResult);
            }
            var GroupComments = lstPatientInvestigation.FindAll(p => !String.IsNullOrEmpty(p.GroupComment) || !String.IsNullOrEmpty(p.GroupMedicalRemarks));
            if (GroupComments.Count > 0)
            {
                UpdateGroupComment(GroupComments, gUID);
            }

            UpdatePatientInvestigationComplete(lstPatientInvestigation, lstFinalReflexPatientinvestigation, -1, 0, gUID);
            InsertInvestigationResults(lstInvestigationValues, -1, VisitID, gUID, "");

            List<UI_PatientInvestigation> lstReflex = lstPatientInvestigation.FindAll(P => P.Status == InvStatus.ReflexWithNewSample || P.Status == InvStatus.ReflexWithSameSample);
            if (lstReflex.Any())
            {
                //Phase 2 Items
                //SaveInvestigationQueue(lstReflex,globalContextDetails.OrgID);
            }


            List<UI_PatientInvestigation> access = lstPatientInvestigation.FindAll(P => P.Status == InvStatus.Retest);
            UI_PageContext PC;
            if (access.Count > 0)
            {
                string accessionnumber = string.Empty;
                foreach (UI_PatientInvestigation pinv in access)
                {

                    accessionnumber = string.Format("{0},{1}", accessionnumber, pinv.AccessionNumber);
                }

                PC = new UI_PageContext();
                PC.ID = globalContextDetails.LocationID;
                PC.PatientID = ResultCapture.PageContext.PatientID;
                PC.RoleID = globalContextDetails.RoleID;
                PC.OrgID = globalContextDetails.OrgID;
                PC.PatientVisitID = VisitID;
                PC.PageID = ResultCapture.PageContext.PageID;
                PC.ButtonName = ResultCapture.PageContext.ButtonName;
                PC.ButtonValue = ResultCapture.PageContext.ButtonValue;
                PC.IDS = accessionnumber;
                using (ActionManager_BL BL = new ActionManager_BL(globalContextDetails))
                {
                    BL.PerformingNextStepNotification(PC, "", "");
                }
            }

            if (lstPatientInvestigation.FindAll(p => p.Status == InvStatus.Approved).Any() || lstPatientInvestigation.FindAll(p => p.Status == InvStatus.PartialyApproved).Any()
                || lstPatientInvestigation.FindAll(p => p.Status == InvStatus.WithHeld).Any() || lstPatientInvestigation.FindAll(p => p.Status == InvStatus.Rejected).Any())
            {
                PC = new UI_PageContext();
                PC.ID = globalContextDetails.LocationID;
                PC.PatientID = ResultCapture.PageContext.PatientID;
                PC.RoleID = globalContextDetails.RoleID;
                PC.OrgID = globalContextDetails.OrgID;
                PC.PatientVisitID = VisitID;
                PC.PageID = ResultCapture.PageContext.PageID;
                PC.ButtonName = ResultCapture.PageContext.ButtonName;
                PC.ButtonValue = ResultCapture.PageContext.ButtonValue;
                using (ActionManager_BL BL = new ActionManager_BL(globalContextDetails))
                {
                    BL.PerformingNextStepNotification(PC, "", "");
                }
            }


            List<UI_PatientInvestigation> lstRecheck = lstPatientInvestigation.FindAll(P => P.Status == InvStatus.Recheck);
            if (lstRecheck.Count > 0)
            {
                List<UI_PatientInvestigation> SaveInvestigation = new List<UI_PatientInvestigation>();
                List<UI_PatientInvSample> LstPinvsample = new List<UI_PatientInvSample>();
                List<UI_PatientInvSampleMapping> LstPinvsamplemapping = new List<UI_PatientInvSampleMapping>();


                lstPatientInvestigation = GetInvestigationSamplesCollect(VisitID, globalContextDetails.OrgID, globalContextDetails.RoleID, gUID, globalContextDetails.LocationID, 22);
                UI_PatientInvestigation objPinvest;
                foreach (UI_PatientInvestigation patient in lstPatientInvestigation)
                {
                    objPinvest = new UI_PatientInvestigation
                    {
                        InvestigationID = patient.InvestigationID,
                        InvestigationName = patient.InvestigationName,
                        PatientVisitID = patient.PatientVisitID,
                        GroupID = patient.GroupID,
                        GroupName = patient.GroupName.Replace(":", ""),
                        Status = patient.Status,
                        CollectedDateTime = patient.CreatedAt,
                        CreatedBy = globalContextDetails.LoginID,
                        Type = patient.Type,
                        OrgID = globalContextDetails.OrgID,
                        InvestigationMethodID = 0,
                        KitID = 0,
                        InstrumentID = 0,
                        UID = patient.UID
                    };
                    SaveInvestigation.Add(objPinvest);
                }
                UI_PatientInvSample objPinvsample;

                foreach (UI_PatientInvestigation patient in lstPatientInvestigation)
                {
                    objPinvsample = new UI_PatientInvSample
                    {
                        PatientVisitID = patient.PatientVisitID,
                        Status = patient.Status,
                        CollectedDateTime = patient.CreatedAt,
                        CreatedBy = globalContextDetails.LoginID,
                        OrgID = globalContextDetails.OrgID,
                        UID = patient.UID
                    };
                    LstPinvsample.Add(objPinvsample);
                }
                UI_PatientInvSampleMapping objPinvsamplemapping;
                foreach (UI_PatientInvestigation patient in lstPatientInvestigation)
                {
                    objPinvsamplemapping = new UI_PatientInvSampleMapping
                    {
                        VisitID = patient.PatientVisitID,
                        ID = patient.InvestigationID,
                        CreatedAt = patient.CreatedAt,
                        OrgID = globalContextDetails.OrgID,
                        UID = patient.UID
                    };
                    LstPinvsamplemapping.Add(objPinvsamplemapping);
                }
                if (lstPatientInvestigation.Count > 0)
                {
                    if (lstPatientInvestigation[0].UID != null)
                    {
                        gUID = lstPatientInvestigation[0].UID;
                    }
                }
                if (SaveInvestigation.Count > 0)
                {
                    SavePatientInvestigation(SaveInvestigation, globalContextDetails.OrgID, gUID);
                }
                if (LstPinvsample.Count > 0 || LstPinvsamplemapping.Count > 0)
                {
                    SavePatientInvSampleNMapping(LstPinvsample, LstPinvsamplemapping, gUID, globalContextDetails.OrgID);
                }
            }

            UpdateInvestigationHoldonApproval(lstPatientInvestigation, gUID);

            UI_PatientVisit objPatientVisit;
            using (Patient_BL BL = new Patient_BL(globalContextDetails))
            {
                objPatientVisit = BL.GetPatientBannerDetails(VisitID, globalContextDetails.OrgID, gUID).SingleOrDefault();
            }

            //var completedCount = lstPatientInvestigation.Where(p => p.ExcludeVIDlock == "N" && (p.Status == InvStatus.Completed
            //                        || p.Status == InvStatus.PartiallyCompleted)).Count();

            var completedCount = lstPatientInvestigation.Where(p => (p.Status == InvStatus.Completed
                                    || p.Status == InvStatus.PartiallyCompleted)).Count();

            //IsAutoAuthRecollect = lstPatientInvestigation.Where(p => p.ReferredType == InvStatus.Retest).Count();
            if (IsAutoAuthRecollect == 0)
            {
                IsAutoAuthRecollect = lstPatientInvestigationStatus.Where(p => p.IsAutoApproveQueue == "Y").Count();
            }

            if (completedCount > 0)
            {
                string STATUS;
                using (Master_BL BL = new Master_BL(globalContextDetails))
                {
                    STATUS = BL.GetConfigDetails("SampleStatusAllCompleted", globalContextDetails.OrgID);
                }

                Hashtable dText = new Hashtable();
                Hashtable urlVal = new Hashtable();
                using (Task_BL BL = new Task_BL(globalContextDetails))
                {
                    List<UI_TaskActions> lstTaskAction = BL.GetTaskActionID(Convert.ToInt64(globalContextDetails.OrgID), Convert.ToInt64(VisitPurpose.LabInvestigation), Convert.ToInt64(globalContextDetails.RoleID));
                    if (lstTaskAction == null || lstTaskAction.Count == 0)
                    {
                        lstTaskAction = new List<UI_TaskActions>();
                        lstTaskAction.Add(new UI_TaskActions { TaskActionID = (int)TaskAction.Approval });
                    }


                    if (lstTaskAction != null && lstTaskAction.Count > 0)
                    {
                        //string SampleID = string.Empty;
                        //PatientDetail.GetSampleID(out SampleID);

                        List<UI_PatientInvestigation> lstPatInvTask = null;
                        UI_Tasks task = new UI_Tasks();

                        foreach (var taskAction in lstTaskAction)
                        {
                            Utility.GetHashTable(taskAction.TaskActionID, VisitID, 0, objPatientVisit.PatientID, objPatientVisit.TitleName + " " +
                                                 objPatientVisit.PatientName, "", 0, "", 0, "", 0, "INV"
                                                 , out dText, out urlVal, "0", objPatientVisit.PatientNumber, 0,
                                                 gUID, objPatientVisit.ExternalVisitID, objPatientVisit.VisitNumber, "");

                            task.TaskActionID = taskAction.TaskActionID;
                            task.DispTextFiller = dText;
                            task.URLFiller = urlVal;
                            task.RoleID = globalContextDetails.RoleID;
                            task.OrgID = globalContextDetails.OrgID;
                            task.PatientVisitID = VisitID;
                            task.PatientID = objPatientVisit.PatientID;
                            task.TaskStatusID = (int)TaskStatus.Pending;
                            task.CreatedBy = globalContextDetails.LoginID;
                            task.RefernceID = ResultCapture.PageContext.LabNo;


                            if (lstPatientInvestigation.Count > 0)
                            {
                                lstPatientInvestigation.Select(e => new { e.AccessionNumber }).Distinct().ToList();
                                lstPatInvTask = Grouplevelvalidation(VisitID, task.TaskActionID, Convert.ToInt32(globalContextDetails.OrgID), Convert.ToInt32(globalContextDetails.LoginID), lstPatientInvestigation);

                            }
                            if (lstPatInvTask.Count > 0)
                            {
                                task = BL.InsertTask(task);
                                returncode = task.TaskID > 0 ? 0 : -1;
                            }
                        }
                    }
                }

            }
            return returncode;
        }

        public List<UI_PatientInvestigation> GetDeptToTrackSamplesForQucikBill(long PatientVisitID, int OrgID, long roleID, string gUID)
        {
            List<UI_PatientInvestigation> lstSampleDept;
            using (Investigation_DAL DAL = new Investigation_DAL(globalContextDetails))
            {
                lstSampleDept = DAL.GetDeptToTrackSamplesForQucikBill(PatientVisitID, OrgID, roleID, gUID);
            }
            return lstSampleDept;
        }

        public long UpdateInvestigationStatus(long patientVisitID, string status, int OrgID, List<UI_InvestigationValues> lstInvValues)
        {
            using (Investigation_DAL DAL = new Investigation_DAL(globalContextDetails))
            {
                return DAL.UpdateInvestigationStatus(patientVisitID, status, OrgID, lstInvValues);
            }
        }

        public long UpdateOrderedInvestigation(long PatientVisitID, string Labno, int OrgID, long TaskID, string BillNo)
        {
            using (Investigation_DAL DAL = new Investigation_DAL(globalContextDetails))
            {
                return DAL.UpdateOrderedInvestigation(PatientVisitID, Labno, OrgID, TaskID, BillNo);
            }
        }

        public UI_HealthPackage GetHealthPackageData(int OrgID, int PackaeID)
        {
            UI_HealthPackage objHealthPackage;
            using (Investigation_DAL DAL = new Investigation_DAL(globalContextDetails))
            {
                objHealthPackage = DAL.GetHealthPackageData(OrgID, PackaeID);
            }
            return objHealthPackage;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
