using System;
using System.Collections.Generic;
using System.Linq;
using Attune.KernelV2.DAL;
using Attune.KernelV2.Entities;
using Attune.KernelV2.Utilities;
using System.Transactions;
using System.Collections;
using System.IO;

namespace Attune.KernelV2.BL
{
    public class Billing_BL : IDisposable
    {
        UI_ContextDetails globalContextDetails;

        public Billing_BL(UI_ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        public UI_BillingPatientMetaData GetPatientBillingDetails(int OrgID, string LanguageCode)
        {
            UI_BillingPatientMetaData objPatientBilling = new UI_BillingPatientMetaData();

            using (Master_BL BL = new Master_BL(globalContextDetails))
            {
                objPatientBilling.Titles = BL.GetSalutation(OrgID, LanguageCode);
            }
            using (MetaData_BL BL = new MetaData_BL(globalContextDetails))
            {
                objPatientBilling.Country = BL.GetCountryList().Find(p => p.CountryID == globalContextDetails.CountryID);
                objPatientBilling.State = BL.GetStateByCountry(Convert.ToInt16(globalContextDetails.CountryID)).Find(p => p.StateID == globalContextDetails.StateID);
                objPatientBilling.AgeType = BL.GetMetaData("DateAttributes", OrgID, LanguageCode);
                objPatientBilling.Gender = BL.GetMetaData("Gender", OrgID, LanguageCode);
                objPatientBilling.MaritalStatus = BL.GetMetaData("MaritalStatus", OrgID, LanguageCode);
                objPatientBilling.PatientStatus = BL.GetMetaData("PatientStatus", OrgID, LanguageCode);
                objPatientBilling.ReportDeliveryMode = BL.GetMetaData("ReportDeliveryMode", OrgID, LanguageCode);
                objPatientBilling.DispatchType = BL.GetMetaData("DespatchType", OrgID, LanguageCode);
                objPatientBilling.DispatchMode = BL.GetMetaValues("DisM", OrgID);
            }
            return objPatientBilling;
        }

        public UI_BillingMetaData GetBillingDetails(int OrgID, string LanguageCode)
        {
            UI_BillingMetaData objBillingMetaData = new UI_BillingMetaData();

            using (Master_BL BL = new Master_BL(globalContextDetails))
            {
                objBillingMetaData.Discount = BL.GetDiscount(OrgID);
                objBillingMetaData.DiscountReason = BL.GetDiscountReason(0, 14, "");
                objBillingMetaData.Tax = BL.GetTax(OrgID);
            }
            using (MetaData_BL BL = new MetaData_BL(globalContextDetails))
            {
                objBillingMetaData.DiscountType = BL.GetMetaData("DiscountType", OrgID, LanguageCode);
            }
            return objBillingMetaData;
        }

        public List<UI_PatientBanner> GetPatientBilling(string PrefixText, int OrgID)
        {
            List<UI_PatientBanner> lstPatient;

            using (Billing_DAL BL = new Billing_DAL(globalContextDetails))
            {
                lstPatient = BL.GetPatientBilling(PrefixText, OrgID);
            }
            return lstPatient;
        }

        public UI_BillingPatientDetails GetPatientDetailsBilling(long PatientID, int OrgID, int OrgAddressID, string LanguageCode)
        {
            UI_BillingPatientContext objPatient;
            UI_BillingPatientVisitContext objPatientVisit;
            UI_BillingPatientDetails objPatientBilling = new UI_BillingPatientDetails();
            List<UI_ClientMaster> lstClientMaster;
            using (Billing_DAL BL = new Billing_DAL(globalContextDetails))
            {
                objPatient = BL.GetPatientDetailsBilling(PatientID, OrgID);

                if (objPatient != null)
                {
                    if (objPatient.VisitID > 0)
                    {
                        objPatientBilling.Patient = new UI_Patient();
                        using (Master_BL mBL = new Master_BL(globalContextDetails))
                        {
                            objPatientBilling.Patient.Salutation = mBL.GetSalutation(OrgID, LanguageCode).Find(p => p.TitleID == objPatient.TITLECode);
                        }
                        objPatientVisit = BL.GetPatientVisitDetailsBilling(objPatient.VisitID, OrgID);
                        using (MetaData_BL mdBL = new MetaData_BL(globalContextDetails))
                        {
                            objPatientBilling.Patient.Gender = mdBL.GetMetaData("Gender", OrgID, LanguageCode).Find(p => p.Code == objPatient.Sex);
                            objPatientBilling.Country = mdBL.GetCountryList().Find(p => p.CountryID == objPatient.CountryID);
                            objPatientBilling.State = mdBL.GetStateByCountry(Convert.ToInt16(objPatient.CountryID)).Find(p => p.StateID == objPatient.StateID);
                            objPatientBilling.DispatchType = (from a in (mdBL.GetMetaData("DespatchType", OrgID, LanguageCode))
                                                              select new UI_MetaData
                                                              {
                                                                  Code = a.Code,
                                                                  DisplayText = a.DisplayText,
                                                                  Domain = a.Domain,
                                                                  LangCode = a.LangCode,
                                                                  MetaDataID = a.MetaDataID,
                                                                  ParentID = a.ParentID,
                                                                  SeqNo = a.SeqNo,
                                                                  IsChecked = false
                                                              }).ToList();
                            objPatientBilling.DispatchMode = (mdBL.GetMetaValues("DisM", OrgID));

                            if (objPatientVisit!=null && objPatientVisit.DisPatch != null)
                            {
                                objPatientBilling.DispatchMode = (from a in objPatientBilling.DispatchMode
                                                                  select new UI_MetaValues
                                                                  {
                                                                      ActionCode = a.ActionCode,
                                                                      ActionType = a.ActionType,
                                                                      ActionTypeID = a.ActionTypeID,
                                                                      IsDisplay = a.IsDisplay,
                                                                      Type = a.Type,
                                                                      IsChecked = objPatientVisit.DisPatch.Where(p => p.DispatchType == "M" && p.DispatchValue == a.ActionTypeID.ToString()).ToList().Count > 0 ? true : false
                                                                  }).ToList();
                            }
                        }

                        objPatientBilling.Patient.PatientID = objPatient.PatientID;
                        objPatientBilling.Patient.PatientNumber = objPatient.PatientNumber;
                        objPatientBilling.Patient.PatientName = objPatient.PatientName;
                        objPatientBilling.Patient.FirstName = objPatient.FirstName;
                        objPatientBilling.Patient.MiddleName = objPatient.MiddleName;
                        objPatientBilling.Patient.LastName = objPatient.LastName;
                        objPatientBilling.Patient.Age = objPatient.Age.Split(' ')[0];
                        objPatientBilling.Patient.AgeTypeCode = objPatient.Age.Split(' ')[1];
                        objPatientBilling.Patient.DOB = objPatient.DOB;
                        objPatientBilling.Patient.MartialStatus = objPatient.MartialStatus;
                        objPatientBilling.Patient.EMail = objPatient.EMail;
                        objPatientBilling.Patient.PatientStatus = objPatient.PatientStatus;
                        objPatientBilling.Patient.Add1 = objPatient.Add1;
                        objPatientBilling.Patient.City = objPatient.City;
                        objPatientBilling.Patient.MobileNumber = objPatient.MobileNumber;
                        objPatientBilling.Patient.LandLineNumber = objPatient.LandLineNumber;
                        objPatientBilling.Patient.PostalCode = objPatient.PostalCode;
                        objPatientBilling.Patient.ExternalPatientNumber = objPatient.ExternalPatientNumber;

                        objPatientBilling.URN = new UI_URNTypes { URN = objPatient.URNO, URNofId = objPatient.URNofId, URNTypeId = objPatient.URNTypeId };

                        if (objPatientVisit != null)
                        {
                            objPatientBilling.ClientReference = new UI_ClientMaster();
                            using (Client_BL cBL = new Client_BL(globalContextDetails))
                            {
                                lstClientMaster = cBL.GetClientForBilling(objPatientVisit.ClientID, "", OrgID, OrgAddressID);
                                if (lstClientMaster != null)
                                {
                                    objPatientBilling.ClientReference = lstClientMaster.SingleOrDefault();
                                }

                                if (objPatientBilling.ClientReference != null)
                                {
                                    objPatientBilling.ClientReference.ReferringPhysician = new UI_ReferringPhysician
                                    {
                                        ReferringPhysicianID = objPatientVisit.ReferingPhysicianID,
                                        ReferringPhysicianName = objPatientVisit.ReferingPhysicianName
                                    };
                                    objPatientBilling.ClientReference.ReferringHospital = new UI_ReferringHospital
                                    {
                                        ReferringHospitalID = objPatientVisit.HospitalID,
                                        ReferringHospitalName = objPatientVisit.HospitalName
                                    };
                                    objPatientBilling.ClientReference.KnowledgeOfServiceID =
                                        objPatientVisit.KnowledgeOfServiceID;
                                    objPatientBilling.ClientReference.ClientID = objPatientVisit.ClientID;
                                    objPatientBilling.ClientReference.VisiTypeCode = objPatientVisit.VisitType;
                                    objPatientBilling.ClientReference.RoundNo = objPatientVisit.RoundNo;
                                    objPatientBilling.ClientReference.WardNo = objPatientVisit.WardNo;
                                }
                            }
                        }
                    }
                    objPatientBilling.PreviousVisitBilling = BL.GetPreviousVisitBilling(objPatient.PatientID, 0, OrgID);
                }
            }
            return objPatientBilling;
        }
        public List<UI_BillingItems> GetBillingItems(string Description, string FeeType, int OrgID, int OrgAddressID, string Gender, long ClientID, long RateID, string IsMapped)
        {
            List<UI_BillingItems> lstBillingItems;

            using (Billing_DAL DAL = new Billing_DAL(globalContextDetails))
            {
                lstBillingItems = DAL.GetBillingItems(Description, FeeType, OrgID, OrgAddressID, Gender, ClientID, RateID, IsMapped);
            }
            return lstBillingItems;
        }

        public UI_BillingItemsDetails GetBillingItemsDetails(int OrgID, int FeeID, string FeeType, long ClientID, long VisitID, string IsCollected, DateTime CollectedDatetime)
        {
            UI_BillingItemsDetails objBillingDetailsItems;

            using (Billing_DAL DAL = new Billing_DAL(globalContextDetails))
            {
                objBillingDetailsItems = DAL.GetBillingItemsDetails(OrgID, FeeID, FeeType, ClientID, VisitID, IsCollected, CollectedDatetime);
            }
            return objBillingDetailsItems;
        }

        public List<UI_Patient> GetPatientAdvanceSearch(string FirstName, string MiddleName, string LastName, string PatientNo, string PhoneNo, string BookingNo, long ClientID,
            string ClientCode, int OrgID)
        {
            List<UI_Patient> lstPatient;
            List<UI_MetaData> lstGender;
            using (Billing_DAL BL = new Billing_DAL(globalContextDetails))
            {
                lstPatient = BL.GetPatientAdvanceSearch(FirstName, MiddleName, LastName, PatientNo, PhoneNo, BookingNo, ClientID, ClientCode, OrgID);
            }
            using (MetaData_BL BL = new MetaData_BL(globalContextDetails))
            {
                lstGender = BL.GetMetaData("Gender", OrgID, globalContextDetails.LanguageCode);
            }
            if (lstPatient != null && lstGender != null && lstPatient.Count > 0 && lstGender.Count > 0)
            {
                for (int i = 0; i < lstPatient.Count; i++)
                {
                    lstPatient[i].Gender = lstGender.Find(p => p.Code == lstPatient[i].Add3);
                }
            }

            return lstPatient;
        }

        public List<UI_OrderedInvestigations> GetHealthPackageDataSearch(int OrgID, string GroupName, int PkgID)
        {
            List<UI_OrderedInvestigations> lstOrderedInvestigations;

            using (Billing_DAL BL = new Billing_DAL(globalContextDetails))
            {
                lstOrderedInvestigations = BL.GetHealthPackageDataSearch(OrgID, GroupName, PkgID);
            }
            return lstOrderedInvestigations;
        }

        public long SaveDocument(List<UI_TRFFileUpload> lstTRFFileUpload)
        {
            long returnstatus;
            using (Billing_DAL DAL = new Billing_DAL(globalContextDetails))
            {
                returnstatus = DAL.SaveDocument(lstTRFFileUpload);
            }
            return returnstatus;
        }

        public UI_BillingPart InsertPatientBilling(UI_BillingPatient objPatientBilling)
        {
            UI_BillingPart BillingPart;

            List<UI_OrderedInvestigations> UnOrderedInvestigations = new List<UI_OrderedInvestigations>();
            List<UI_ControlMappingDetails> ControlMappingDetails = new List<UI_ControlMappingDetails>();

            List<UI_PatientRedemDetails> PatientRedemDetails = new List<UI_PatientRedemDetails>();
            List<UI_TRFFileUpload> TRFFileUpload =new List<UI_TRFFileUpload>();
            var UID = Guid.NewGuid().ToString();
            List<UI_OrderedInvestigations> OrderedInvestigations = (from d in objPatientBilling.PatientDueChart
                                                                    select new UI_OrderedInvestigations
                                                                    {
                                                                        Name = d.Description,
                                                                        ID = d.FeeID,
                                                                        CreatedBy = globalContextDetails.LoginID,
                                                                        ModifiedBy = 0,
                                                                        Status = "Ordered",
                                                                        Type = d.FeeType,
                                                                        OrgID = globalContextDetails.OrgID,
                                                                        StudyInstanceUId = Helper.CreateUniqueDecimalString(),
                                                                        UID= UID,
                                                                        IsStat = d.IsSTAT,
                                                                    }).ToList();
            List<UI_VisitClientMapping> VisitClientMapping = new List<UI_VisitClientMapping> { new UI_VisitClientMapping{
              VisitClientMappingID = 0,
                VisitID = objPatientBilling.Patient.PatientVisitID,
                ClientID = objPatientBilling.ClientReference.ClientID,
                PreAuthAmount = objPatientBilling.FinalBillDetails.GrossBillValue
            } };


            using (Billing_DAL DAL = new Billing_DAL(globalContextDetails))
            {
                objPatientBilling.Patient.PatientName = string.Format("{0} {1} {2}", objPatientBilling.Patient.FirstName , objPatientBilling.Patient.MiddleName  , objPatientBilling.Patient.LastName);
                objPatientBilling.Patient.VisitPurposeID = 3;
                objPatientBilling.Patient.OrgID = globalContextDetails.OrgID;
                objPatientBilling.Patient.OrgAddressID = globalContextDetails.LocationID;
                objPatientBilling.DispatchType = objPatientBilling.DispatchType.Where(p => p.IsChecked == true).ToList();
                objPatientBilling.DispatchMode = objPatientBilling.DispatchMode.Where(p => p.IsChecked == true).ToList();
                objPatientBilling.Patient.Age = objPatientBilling.Patient.Age + " " + objPatientBilling.Patient.AgeTypeCode;
                using (TransactionScope tranScope = new TransactionScope())
                {
                    try
                    {
                        
                        objPatientBilling.DispatchMode= objPatientBilling.DispatchMode.Select(c => new UI_MetaValues()
                               {
                                   ActionCode = c.ActionTypeID.ToString(),
                                   ActionType = "M",
                               }).ToList();

                        objPatientBilling.DispatchMode.AddRange(
                               objPatientBilling.DispatchType.Select(c => new UI_MetaValues()
                               {
                                   ActionCode=c.Code,
                                   ActionType= "N",
                               }).ToList());

                        foreach (var amountrec in objPatientBilling.AmountReceivedDetails)
                        {
                            amountrec.BankNameorCardType = amountrec.BankNameorCardType ?? "";
                            amountrec.ChequeorCardNumber = amountrec.ChequeorCardNumber ?? "";
                            amountrec.Remarks = amountrec.Remarks ?? "";
                            amountrec.CardHolderName = amountrec.CardHolderName ?? "";

                        }


                        BillingPart = DAL.InsertPatientBilling(objPatientBilling.Patient, objPatientBilling.DispatchMode,
                                        objPatientBilling.ClientReference, objPatientBilling.AdditionalDetails, objPatientBilling.PatientDueChart,
                                        objPatientBilling.AmountReceivedDetails, OrderedInvestigations, UnOrderedInvestigations, ControlMappingDetails,
                                        VisitClientMapping, PatientRedemDetails, objPatientBilling.URN, objPatientBilling.FinalBillDetails,
                                        objPatientBilling.Country.NationalityID, objPatientBilling.Country.CountryID, objPatientBilling.State.StateID,
                                        objPatientBilling.City == null ? new UI_City() : objPatientBilling.City);

                       


                        if (objPatientBilling.ClientReference.ClientAttributes != null && objPatientBilling.ClientReference.ClientAttributes.Count > 0 && BillingPart.VisitID > 0)
                        {
                            List<UI_ClientAttributesKeyFields> lstClientAttributes = new List<UI_ClientAttributesKeyFields>();
                            lstClientAttributes = (from a in objPatientBilling.ClientReference.ClientAttributes
                                                   select new UI_ClientAttributesKeyFields
                                     {
                                         Key = a.Domain,
                                         ReferenceID = objPatientBilling.ClientReference.ClientID,
                                         ReferenceType = "CLIENT",
                                         Valuedata = a.Valuedata

                                     }).ToList();
                            using (Client_BL BL = new Client_BL(globalContextDetails))
                            {
                                BL.InsertClientAttributesFieldDetails(BillingPart.VisitID, lstClientAttributes);
                            }
                        }
                        if (BillingPart != null && BillingPart.FinalBillID > 0)
                        {

                            List<UI_HistoryAttributes> lstHistoryAttributes = new List<UI_HistoryAttributes>();

                            foreach (UI_PatientDueChart PatientDueChart in objPatientBilling.PatientDueChart)
                            {
                                if (PatientDueChart.Historys != null )
                                {
                                    if (PatientDueChart.Historys.History != null)
                                    {
                                        lstHistoryAttributes.AddRange(
                                                    PatientDueChart.Historys.History.Select(p => new UI_HistoryAttributes()
                                                    {
                                                        InvestigationID = PatientDueChart.FeeID,
                                                        HistoryName = p.ComplaintName,
                                                        AttributeName = "Background Problem",
                                                        AttributeValueName = p.ICDCode,
                                                        Description = p.ComplaintName
                                                    }).ToList());
                                    }
                                    if (PatientDueChart.Historys.PatientPreference != null)
                                    {
                                        lstHistoryAttributes.AddRange(
                                                    PatientDueChart.Historys.PatientPreference.Select(p => new UI_HistoryAttributes()
                                                    {
                                                        InvestigationID = PatientDueChart.FeeID,
                                                        HistoryName = "Patient Preference",
                                                        AttributeName = "Patient Preference",
                                                        AttributeValueName = p.Preference,
                                                        Description = "Patient Preference"
                                                    }).ToList());
                                    }
                                }
                            }
                            if(lstHistoryAttributes.Count>0)
                            {
                                SaveHistoryQuickBilling(BillingPart.PatientID, BillingPart.VisitID, lstHistoryAttributes);

                            }




                            string IsSTAT;

                            string gUID = OrderedInvestigations.FirstOrDefault().UID.ToString();
                            if (OrderedInvestigations.FindAll(p => p.IsStat == "Y").Count > 0)
                            {
                                IsSTAT = "Y";
                            }
                            else
                            {
                                IsSTAT = "N";
                            }
                            using (Master_BL BL = new Master_BL(globalContextDetails))
                            {
                                string IsReceptionPhlebotomist = BL.GetConfigDetails("IsReceptionPhlebotomist", globalContextDetails.OrgID);
                                CollectSampleTaskCreator(globalContextDetails.OrgID, globalContextDetails.LoginID, OrderedInvestigations, BillingPart.LabNo,
                                BillingPart.BillNumber, BillingPart.PatientID, BillingPart.VisitID, gUID, globalContextDetails.RoleID, IsReceptionPhlebotomist, "", IsSTAT);
                            }

                            if (objPatientBilling.TRFFile != null && objPatientBilling.TRFFile.Count > 0)
                            {
                                string pathname = string.Empty;
                                string RootPath = String.Empty;
                                using (Master_BL BL = new Master_BL(globalContextDetails))
                                {
                                    pathname = BL.GetConfigDetails("TRF_UploadPath", globalContextDetails.OrgID);
                                }
                                DateTime dt = DateTime.Now;

                                RootPath = string.Format("{0}TRF_Upload\\\\{1}\\\\{2}\\\\{3}\\\\{4}\\\\",pathname,globalContextDetails.OrgID ,dt.Year ,dt.Month ,dt.Day);

                                if (!System.IO.Directory.Exists(RootPath))
                                {
                                    System.IO.Directory.CreateDirectory(RootPath);
                                }
                                 
                                string patientFileName = string.Empty;
                                foreach (UI_FileProperties file in objPatientBilling.TRFFile)
                                {
                                    if (File.Exists(file.FilePath))
                                    {
                                        patientFileName = string.Format("{0}_{1}_{2}_{3}", BillingPart.PatientID, BillingPart.VisitID, globalContextDetails.OrgID, file.Name);
                                        File.Move(file.FilePath, string.Format("{0}{1}", RootPath, patientFileName));
                                    }


                                    TRFFileUpload.Add(new UI_TRFFileUpload()
                                    {
                                        FileID = 0,
                                        FileName = patientFileName,
                                        Createdby = globalContextDetails.LoginID,
                                        Createdat = DateTime.Now,
                                        FilePath = RootPath,
                                        FileUrl = "",
                                        IdentifyingID = 0,
                                        IdentifyingType = "TRF_Upload",
                                        Isactive = "Y",
                                        OrgID = globalContextDetails.OrgID,
                                        PatientID = BillingPart.PatientID,
                                        VisitID = BillingPart.VisitID

                                    });
                                }

                                SaveDocument(TRFFileUpload);
                                
                                 
                            }


                            tranScope.Complete();
                        }
                        else
                        {
                           
                            foreach (UI_TRFFileUpload file in TRFFileUpload)
                            {
                                if (File.Exists(file.FilePath+file.FileName))
                                {
                                    File.Delete(file.FilePath + file.FileName);
                                }
                            }
                            tranScope.Dispose();
                        }
                    }
                    catch (Exception)
                    {
                        

                        foreach (UI_TRFFileUpload file in TRFFileUpload)
                        {
                            if (File.Exists(file.FilePath + file.FileName))
                            {
                                File.Delete(file.FilePath + file.FileName);
                            }
                        }
                        tranScope.Dispose();

                        throw;
                    }

                }
            }
            return BillingPart;
        }


        public void SaveHistoryQuickBilling(long PatientID, long patientVisitID, List<UI_HistoryAttributes> lstHistoryAttributes)
        {
            using (Billing_DAL DAL = new Billing_DAL(globalContextDetails))
            {
               DAL.SaveHistoryQuickBilling(PatientID, patientVisitID, globalContextDetails.OrgID, globalContextDetails.LoginID, lstHistoryAttributes);
                
            }
        }

        private long CollectSampleTaskCreator(int OrgID, long LID, List<UI_OrderedInvestigations> lstOrderedInvestigations, string labno,
             string BillNumber, long patientID, long patientVisitID, string gUID, int RoleID, string IsReceptionPhlebotomist,
            string IsSamplePickUP, string IsSTAT)
        {
            long taskID = -1;
            long returnCode = -1;
            UI_Tasks task = new UI_Tasks();
            Hashtable dText = new Hashtable();
            Hashtable urlVal = new Hashtable();
            List<UI_InvestigationValues> lstInvResult;

             
            using (Task_BL taskBL = new Task_BL(globalContextDetails))
            {
                List<UI_TaskActions> lstTaskAction = taskBL.GetTaskActionID(Convert.ToInt64(globalContextDetails.OrgID), Convert.ToInt64(VisitPurpose.LabInvestigation), Convert.ToInt64(globalContextDetails.RoleID));

                using (Investigation_BL invBL = new Investigation_BL(globalContextDetails))
                {
                    List<UI_PatientInvestigation> lstSampleDept = invBL.GetDeptToTrackSamplesForQucikBill(patientVisitID, OrgID, RoleID, gUID);

                    lstInvResult = new List<UI_InvestigationValues>();
                    UI_InvestigationValues inValues;
                    foreach (var item in lstSampleDept)
                    {
                        if (item.Display == "N")
                        {
                            inValues = new UI_InvestigationValues();
                            inValues.InvestigationID = item.InvestigationID;
                            inValues.PerformingPhysicainName = item.PerformingPhysicainName;
                            inValues.PackageID = item.PackageID;
                            inValues.PackageName = item.PackageName;

                            lstInvResult.Add(inValues);
                        }
                         
                    }
                    if (lstInvResult.Count > 0)
                    {
                        invBL.UpdateInvestigationStatus(patientVisitID, "SampleReceived", OrgID, lstInvResult);
                    }
                    if ((IsReceptionPhlebotomist != "Y") || (IsReceptionPhlebotomist == "Y"))
                    {
                        #region INV
                        using (Master_BL masterBL = new Master_BL(globalContextDetails))
                        {
                            string sVal = masterBL.GetConfigDetails("SampleCollect", OrgID);

                            if (sVal.Trim() != "N")
                            {
                                using (Patient_BL patientBL = new Patient_BL(globalContextDetails))
                                {
                                    List<UI_PatientVisitDetails> lstPatientVisitDetails = patientBL.GetPatientVisitDetails(patientVisitID);

                                    if (lstPatientVisitDetails != null && lstPatientVisitDetails.Count > 0)
                                    {
                                        foreach (var item in lstSampleDept)
                                        {
                                            if (item.Display == "Y")
                                            {
                                                //long createTaskID = -1;
                                                Int32 TaskActionID = -1;
                                                if (IsSamplePickUP == "Y")
                                                {
                                                    TaskActionID = Convert.ToInt32(TaskAction.GenerateBarCode);
                                                }
                                                else
                                                {
                                                    TaskActionID = Convert.ToInt32(TaskAction.CollectSample);

                                                }
                                                string patientName = lstPatientVisitDetails[0].PatientName + "-" + lstPatientVisitDetails[0].Age;
                                                returnCode = Utility.GetHashTable(Convert.ToInt64(TaskActionID),
                                                             patientVisitID, 0, patientID, lstPatientVisitDetails[0].TitleName + " " +
                                                             patientName, "", 0, "", 0, "", 0, "INV"
                                                             , out dText, out urlVal, "0", lstPatientVisitDetails[0].PatientNumber, 0, gUID, lstPatientVisitDetails[0].ExternalVisitID,
                                                             lstPatientVisitDetails[0].VisitNumber, "");
                                                task.TaskActionID = TaskActionID;// Convert.ToInt32(TaskHelper.TaskAction.CollectSample);
                                                task.DispTextFiller = dText;
                                                task.URLFiller = urlVal;
                                                task.RoleID = RoleID;
                                                task.OrgID = OrgID;
                                                task.PatientVisitID = patientVisitID;
                                                task.PatientID = patientID;
                                                task.TaskStatusID = (int)TaskStatus.Pending;
                                                task.CreatedBy = LID;
                                                task.RefernceID = labno.ToString();
                                                //Create task               
                                                task.IsStat = IsSTAT;
                                                task = taskBL.CreateTaskAllowDuplicate(task);
                                                break;

                                            }
                                        }
                                    }

                                    if (task.TaskID > 0)
                                    {
                                        returnCode = invBL.UpdateOrderedInvestigation(patientVisitID, labno, OrgID, taskID, BillNumber);
                                    }
                                }
                            }
                            else
                            {
                                returnCode = 0;
                            }
                        }
                        #endregion

                        #region Helath Package
                        //Add By Syed                                                                      
                        List<UI_GeneralHealthCheckUpMaster> lstCollectedHealthCheckUpMaster = new List<UI_GeneralHealthCheckUpMaster>();
                        int PkgID = -1;
                        UI_HealthPackage objHealthPackage = invBL.GetHealthPackageData(OrgID, PkgID);
                        

                        foreach (UI_OrderedInvestigations objItems in lstOrderedInvestigations)
                        {
                            if (objItems.Type == "PKG")
                            {
                                //Get Speciality

                                foreach (UI_InvGroupMaster PkgMaster in objHealthPackage.lstPackages)
                                {
                                    if (objItems.ID == PkgMaster.AttGroupID)
                                    {
                                        PkgID = PkgMaster.GroupID;
                                    }

                                }
                                var invPMList = from invPM in objHealthPackage.lstPackageMapping
                                                where invPM.PackageID == Convert.ToInt32(PkgID) && invPM.Type == "CON"
                                                select invPM;
                                //List<UI_InvPackageMapping> lstPI1 = invPMList.ToList<UI_InvPackageMapping>();
                                // foreach (UI_InvPackageMapping objPMTTT in lstPI1)
                                //{
                                //    Speciality objCollectedSpeciality = new Speciality();
                                //    objCollectedSpeciality.SpecialityID = Convert.ToInt32(objPMTTT.ID);
                                //    objCollectedSpeciality.SpecialityName = "";
                                //    lstCollectedSpeciality.Add(objCollectedSpeciality);
                                //}
                                //Get HealthCheckUpMaster
                                var invGHList = from invPM in objHealthPackage.lstPackageMapping
                                                where invPM.PackageID == Convert.ToInt32(PkgID) && invPM.Type == "GHC"
                                                select invPM;
                                List<UI_InvPackageMapping> lstPI2 = invGHList.ToList<UI_InvPackageMapping>();

                                foreach (UI_InvPackageMapping objGHTTT in lstPI2)
                                {
                                    UI_GeneralHealthCheckUpMaster objGeneralHealthCheckUpMaster = new UI_GeneralHealthCheckUpMaster();
                                    objGeneralHealthCheckUpMaster.GeneralHealthCheckUpID = Convert.ToInt32(objGHTTT.ID);
                                    objGeneralHealthCheckUpMaster.GeneralHealthCheckUpName = "";
                                    lstCollectedHealthCheckUpMaster.Add(objGeneralHealthCheckUpMaster);
                                }



                                UI_PatientVisit pVisit = new UI_PatientVisit();
                                UI_PatientandAddress objPatient = new UI_PatientandAddress();
                                // int purpID = 1;
                                long phyID = -1;
                                int otherID = -1;
                                objPatient = new Patient_BL(globalContextDetails).GetPatientDemoandAddress(patientID);


                                string feeType = String.Empty;
                                string otherName = String.Empty;
                                string physicianName = String.Empty;
                                string referrerName = string.Empty;
                                
                                //  string gUID = string.Empty;
                                string PaymentLogic = string.Empty;
                                long visitID = patientVisitID;

                                #region for HealthScreen Task
                                if (lstCollectedHealthCheckUpMaster.Count > 0)
                                {
                                    
                                    feeType = "HEALTHPKG";
                                    otherID = 0;
                                    int visitPurposeID = 4;
                                    phyID = 0;
                                    if (PaymentLogic == string.Empty)
                                    {
                                        string ConfigValue = string.Empty;
                                        using (Master_BL masterBL = new Master_BL(globalContextDetails))
                                        {
                                            ConfigValue = masterBL.GetConfigDetails(feeType, OrgID);
                                        }
                                        if (!String.IsNullOrEmpty(ConfigValue))
                                            PaymentLogic = ConfigValue.Trim();
                                    }
                                    pVisit.PhysicianName = "";
                                    UI_TaskActions taskActionHC = new UI_TaskActions();

                                    lstTaskAction = taskBL.GetTaskActionID(OrgID, visitPurposeID, otherID);
                                    //Perform
                                    taskActionHC = lstTaskAction[0];
                                    returnCode = Utility.GetHashTable(taskActionHC.TaskActionID, visitID, phyID,
                                                                  patientID, /*objPatient.Patient[0].TitleName*/ "" + " " + objPatient.Patient[0].PatientName,
                                                                  physicianName, otherID, "", 0, "", 0, "", out dText, out urlVal, "",
                                                                  objPatient.Patient[0].PatientNumber, /*objPatient.Patient[0].TokenNumber*/0, ""); // Other Id meand Procedure ID

                                    task.TaskActionID = taskActionHC.TaskActionID;
                                    task.DispTextFiller = dText;
                                    task.URLFiller = urlVal;
                                    task.PatientID = patientID;
                                    task.AssignedTo = phyID;
                                    task.OrgID = OrgID;
                                    task.PatientVisitID = visitID;
                                    //task.SpecialityID = specialityID;
                                    task.CreatedBy = LID;
                                    task = taskBL.InsertTask(task);
                                }
                                #endregion
                                //foreach (Speciality objSpeciality in lstCollectedSpeciality)
                                //{
                                //    purpID = 1;
                                //    otherID = objSpeciality.SpecialityID; //21; 
                                //    //specialityID = objSpeciality.SpecialityID; //1;// 
                                //    lstTaskAction = taskBL.GetTaskActionID(OrgID, purpID, otherID);
                                //    UI_TaskActions taskAction = new UI_TaskActions();
                                //    taskAction = lstTaskAction[0];
                                //    if (returnCode == 0)
                                //    {
                                //        //*******for Task*******************
                                //        //Created by ashok to add multiple tasks
                                //        //Evaluate
                                //        for (int i = 0; i < lstTaskAction.Count; i++)
                                //        {
                                //            taskAction = lstTaskAction[i];

                                //            returnCode = Utility.GetHashTable(taskAction.TaskActionID, visitID, phyID,
                                //                                      patientID, patient.TitleName + " " + objPatient.Patient[0].PatientName, physicianName, otherID, "", 0,
                                //                                      "", 0, "", out dText, out urlVal, 0, objPatient.Patient[0].PatientNumber,
                                //                                      objPatient.Patient[0].TokenNumber, ""); // Other Id meand Procedure ID
                                //            task.TaskActionID = taskAction.TaskActionID;
                                //            task.DispTextFiller = dText;
                                //            task.URLFiller = urlVal;
                                //            task.PatientID = patientID;

                                //            task.AssignedTo = 0;
                                //            task.OrgID = OrgID;
                                //            task.PatientVisitID = visitID;
                                //            //task.SpecialityID = specialityID;
                                //            task.CreatedBy = LID;
                                //            task = taskBL.InsertTask(task);
                                //        }
                                //    }
                                //}
                            }
                        }
                        #endregion
                    }
                    else
                    {
                        returnCode = 0;
                    }

                }
            }
            return returnCode;
        }

        public UI_BillPrint GetBillPrinting(long VisitID, string PhysicianName, long BillID, string SplitStatus)
        {
            UI_BillPrint objBillPrint;
            using (Billing_DAL DAL = new Billing_DAL(globalContextDetails))
            {
                objBillPrint = DAL.GetBillPrinting(VisitID, PhysicianName, BillID, SplitStatus);
            }
            return objBillPrint;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}

