using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Attune.Podium.BusinessEntities;
using Attune.Solution.DAL;
using Attune.Podium.Common;
using System.Transactions;
using System.Xml;
using Attune.Podium.ClientEntity;

namespace Attune.Solution.BusinessComponent
{
    public class IntegrationBL
    {
        ContextDetails globalContextDetails;
        public IntegrationBL()
        {

        }
        public IntegrationBL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long SaveIntegrationData(List<IntegrationHistory> lstIntegrationDetails)
        {
            long returnCode = -1;
            try
            {

                returnCode = new IntegrationDAL(globalContextDetails).SaveIntegrationData(lstIntegrationDetails);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in SaveIntegrationData", ex);
            }
            return returnCode;
        }
        //public long UpdateVisitDetails(PatientVisit labVisit, VisitClientMapping lstVisitClientMapping)
        //{
        //    long returnCode = -1;

        //    try
        //    {
        //        returnCode = new IntegrationDAL(globalContextDetails).UpdateVisitDetails(labVisit, lstVisitClientMapping);
        //    }
        //    catch (Exception excep)
        //    {
        //        CLogger.LogError("Error while executing UpdateLabVisitDetails in Integration_BL", excep);
        //    }
        //    return returnCode;
        //}
        public long GetDetailsForExtVisitID(PatientVisit labVisit, out List<PatientVisit> VisitDetail, out long patientCount)
        {
            long returnCode = -1;
            patientCount = -1;
            VisitDetail = new List<PatientVisit>();
            try
            {
                returnCode = new IntegrationDAL(globalContextDetails).GetDetailsForExtVisitID(labVisit, out VisitDetail, out patientCount);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetDetailsForExtVisitID", ex);
            }

            return returnCode;
        }

        public long PushintegratedData(Patient patient, PatientAddress PatientAddress, PatientVisit PatientVisit,
            List<InvestigationDetail> InvestigationDetails, List<VisitClientMapping> lstVisitClientMapping)
        {
            long returnCode = -1;
            int OrgID =0;
            if (patient.OrgID != null && patient.OrgID > 0)
            {
                OrgID = patient.OrgID;
            }
            long pVisitID = 0;
            Role roleName = new Role();
            Role roleName1 = new Role();
            long PatientID = -1;
            long OrgAddressID = -1;
            List<Role> lRole = new List<Role>();
            List<OrganizationAddress> lAddress = new List<OrganizationAddress>();
            List<Patient> lPatient = new List<Patient>();
            int patientCount = -1;
            System.Collections.Hashtable dText = new System.Collections.Hashtable();
            System.Collections.Hashtable urlVal = new System.Collections.Hashtable();
            string GUID = System.Guid.NewGuid().ToString();


            int RowsAffected = -1;
            //returnCode = new Referrals_DAL().GetALLLocation(OrgID, out lAddress);
            if (PatientVisit.OrgAddressID !=null && PatientVisit.OrgAddressID > 0)
            {
                OrgAddressID = PatientVisit.OrgAddressID;
            }

            new Role_DAL(globalContextDetails).GetRoleName(OrgID, out lRole);
            if (lRole.Count > 0)
            {
                roleName = lRole.Find(O => O.RoleName == Attune.Podium.Common.RoleHelper.LabTech);
                roleName1 = lRole.Find(O => O.RoleName == Attune.Podium.Common.RoleHelper.Phlebotomist);
            }
            returnCode = new Patient_DAL(globalContextDetails).GetRegistrationStatus(patient.PatientNumber, OrgID, out patientCount, out lPatient);
            using (System.Transactions.TransactionScope tr = new TransactionScope())
            {
                try
                {
                    if (patientCount == 0)
                    {
                        returnCode = new Patient_BL(globalContextDetails).SaveSampleRegistrationDetails(patient, PatientAddress, PatientVisit,
                            out pVisitID, OrgAddressID, out PatientID, 0, "", 0, "", lstVisitClientMapping);

                        if ((returnCode == -1) || (InvestigationDetails.Count == 0))
                        {
                            throw new Exception("SaveSampleRegistrationDetails");
                        }

                        List<OrderedInvestigations> ordInves = new List<OrderedInvestigations>();
                        ordInves = GetInvManipulatedlist(InvestigationDetails, pVisitID, OrgID, GUID);
                        returnCode = new Investigation_DAL(globalContextDetails).SaveOrderedInvestigation(ordInves, OrgID);
                        RowsAffected = 1;
                        if (returnCode == -1) { throw new Exception("SaveOrderedInvestigation Method"); }
                    }
                    else
                    {
                        long ExVisitCount = -1;
                        returnCode = new Patient_BL(globalContextDetails).UpdatePatientDetailsForIntegration(patient, PatientAddress);

                        if (returnCode == -1) { throw new Exception("UpdatePatientDetailsForIntegration"); }

                        List<PatientVisit> ExVisitDetails = new List<PatientVisit>();
                        returnCode = new IntegrationDAL(globalContextDetails).GetDetailsForExtVisitID(PatientVisit, out ExVisitDetails, out ExVisitCount);
                        if (returnCode == -1) { throw new Exception("GetDetailsForExtVisitID"); }
                        if (lPatient.Count > 0)
                        {
                            PatientID = lPatient[0].PatientID;

                        }
                        if (ExVisitDetails.Count == 0)
                        {
                            if (lPatient.Count > 0)
                            {
                                PatientID = lPatient[0].PatientID;

                            }
                            PatientVisit.PatientID = PatientID;
                            PatientVisit.OrgAddressID = OrgAddressID;
                            PatientVisit.OrgID = OrgID;
                            
                            returnCode = new Patient_DAL(globalContextDetails).SaveLabVisitDetails(PatientVisit, out pVisitID);
                            if ((returnCode == -1) || (InvestigationDetails.Count == 0)) { throw new Exception("SaveLabVisitDetails"); }

                            List<OrderedInvestigations> ordInves = new List<OrderedInvestigations>();
                            ordInves = (GetInvManipulatedlist(InvestigationDetails, pVisitID, OrgID, GUID));

                            returnCode = new Investigation_DAL(globalContextDetails).SaveOrderedInvestigation(ordInves, OrgID);
                            if (returnCode == -1) { throw new Exception("SaveOrderedInvestigation"); }
                        }
                        else
                        {
                            List<PatientInvestigation> InvDetails = new List<PatientInvestigation>();
                            returnCode = new IntegrationDAL(globalContextDetails).UpdateVisitDetails(PatientVisit, lstVisitClientMapping);
                            if (returnCode == -1) { throw new Exception("UpdateVisitDetails"); }
                            List<OrderedInvestigations> ordInves = new List<OrderedInvestigations>();
                            ordInves = (GetInvManipulatedlist(InvestigationDetails, ExVisitDetails[0].PatientVisitId, OrgID, GUID));

                            returnCode = new Investigation_DAL(globalContextDetails).GetPatInvDetailsForVisit(ordInves, ExVisitDetails[0].PatientVisitId, OrgID, out InvDetails, out RowsAffected);
                            if (returnCode == -1) { throw new Exception("GetPatInvDetailsForVisit"); }
                            if (ExVisitDetails.Count > 0)
                            {
                                pVisitID = ExVisitDetails[0].PatientVisitId;
                            }
                        }
                    }
                    if (RowsAffected != 0)
                    {
                        long taskactionID;

                        PatientVisit_BL objPatientVisit_BL = new PatientVisit_BL();
                        //            long TaskActionID = -1;
                        int VisitPurposeID = Convert.ToInt32(TaskHelper.VisitPurpose.LabInvestigation);

                        List<TaskActions> lstTaskActions = new List<TaskActions>();
                        objPatientVisit_BL.GetTaskActionID(OrgID, VisitPurposeID, roleName1.RoleID, out lstTaskActions);
                        if (lstTaskActions.Count > 0)
                        {
                            if (lstTaskActions[0].TaskActionID > 0)
                            {
                                taskactionID = lstTaskActions[0].TaskActionID;
                            }
                            else
                            {
                                taskactionID = (long)TaskHelper.TaskAction.CollectSample;
                            }
                        }
                        else
                        {
                            taskactionID = (long)TaskHelper.TaskAction.CollectSample;
                        }
                        Tasks task = new Tasks();
                        long createTaskID = -1;
                        List<PatientVisitDetails> lstPatientVisitDetails = new List<PatientVisitDetails>();
                        returnCode = new PatientVisit_BL(globalContextDetails).GetVisitDetails(pVisitID, out lstPatientVisitDetails);
                        if (returnCode == -1) { throw new Exception("GetVisitDetails"); }

                        string sExternalVisitID = string.Empty;
                        string PatientNumber = string.Empty;
                        string VisitNumber = string.Empty;
                        string TitleName = string.Empty;
                        string PatientName = string.Empty;
                        if (lstPatientVisitDetails.Count > 0)
                        {
                           sExternalVisitID = lstPatientVisitDetails[0].ExternalVisitID;
                           PatientNumber= lstPatientVisitDetails[0].PatientNumber;
                           TitleName= lstPatientVisitDetails[0].TitleName;
                           VisitNumber = lstPatientVisitDetails[0].VisitNumber;
                           PatientName = lstPatientVisitDetails[0].PatientName;

                        }
                        //returnCode = Attune.Podium.Common.Utilities.GetHashTable(Convert.ToInt64(Attune.Podium.Common.TaskHelper.TaskAction.CollectSample),
                        returnCode = Attune.Podium.Common.Utilities.GetHashTable(Convert.ToInt64(taskactionID),
                                     pVisitID, 0, PatientID, TitleName + " " +
                                     PatientName, "", 0, "", 0, "", 0, "INV"
                                     , out dText, out urlVal, "0", PatientNumber, 0, GUID, sExternalVisitID, VisitNumber,"");
                        if (returnCode == -1) { throw new Exception("GetHashTable"); }

                        task.TaskActionID = Convert.ToInt32(taskactionID);
                        task.DispTextFiller = dText;
                        task.URLFiller = urlVal;
                        task.RoleID = roleName.RoleID;
                        task.OrgID = OrgID;
                        task.PatientVisitID = pVisitID;
                        task.PatientID = PatientID;
                        task.TaskStatusID = (int)Attune.Podium.Common.TaskHelper.TaskStatus.Pending;
                        if (!String.IsNullOrEmpty(lstPatientVisitDetails[0].Labno))
                        {
                            task.RefernceID = lstPatientVisitDetails[0].Labno;
                        }
                        returnCode = new Tasks_BL(globalContextDetails).CreateTask(task, out createTaskID);
                        //Vijayalakshmi.M 
                        if (createTaskID >= 0)
                        {
                            returnCode = 0;
                        }
                        else
                        {
                            returnCode = -1;
                        }
                        //End
                        if (returnCode == -1) { throw new Exception("CreateTask"); }
                    }
                    tr.Complete();

                }
                catch (Exception ex)
                {
                    returnCode = -1;
                    CLogger.LogError("Error in integration dal", ex);
                }
                return returnCode;
            }
        }
        private string GetUniqueKey()
        {
            int maxSize = 10;
            char[] chars = new char[62];
            string a;
            //a = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            a = "0123456789012345678901234567890123456789012345678901234567890123456789";
            chars = a.ToCharArray();
            int size = maxSize;
            byte[] data = new byte[1];
            System.Security.Cryptography.RNGCryptoServiceProvider crypto = new System.Security.Cryptography.RNGCryptoServiceProvider();
            crypto.GetNonZeroBytes(data);
            size = maxSize;
            data = new byte[size];
            crypto.GetNonZeroBytes(data);
            System.Text.StringBuilder result = new System.Text.StringBuilder(size);
            foreach (byte b in data)
            { result.Append(chars[b % (chars.Length - 1)]); }
            return result.ToString();
        }
        private string CreateUniqueDecimalString()
        {
            string uniqueDecimalString = "1.2.840.113619.";
            uniqueDecimalString += GetUniqueKey() + ".";
            uniqueDecimalString += GetUniqueKey();
            return uniqueDecimalString;
        }

        public string GetConfigValue(string configKey, int orgID)
        {
            string configValue = string.Empty;
            long returncode = -1;
            GateWay objGateway = new GateWay();
            List<Config> lstConfig = new List<Config>();

            returncode = new GateWay(globalContextDetails).GetConfigDetails(configKey, orgID, out lstConfig);
            if (lstConfig.Count > 0)
                configValue = lstConfig[0].ConfigValue;

            return configValue;
        }

        private List<OrderedInvestigations> GetInvManipulatedlist(List<InvestigationDetail> lstInvestigationDetails, long PatientVisitID, int OrgID, string GUID)
        {
            List<OrderedInvestigations> orderedList = new List<OrderedInvestigations>();
            OrderedInvestigations objInvest = null;
            string TAT = string.Empty;
            string ConfigValue = string.Empty;
            try
            {
                foreach (var invs in lstInvestigationDetails)
                {
                    if (invs.ID.Contains("-"))
                    {

                        string[] splitID = invs.ID.Split('-');
                        objInvest = new OrderedInvestigations();
                        objInvest.ID = Convert.ToInt64(splitID[0]);
                        objInvest.Name = invs.Name;
                        objInvest.VisitID = PatientVisitID;
                        objInvest.Status = "Paid";
                        objInvest.PaymentStatus = "Paid";
                        //objInvest.CreatedBy = LID;
                        objInvest.Type = splitID[1];
                        objInvest.OrgID = OrgID;
                        objInvest.UID = GUID;
                        objInvest.IsStat = invs.IsSTAT;
                        objInvest.StudyInstanceUId = CreateUniqueDecimalString();
                       // objInvest.IsStat = "N";

                        ConfigValue = GetConfigValue("TAT", OrgID);
                        if (!String.IsNullOrEmpty(ConfigValue) && ConfigValue.Length > 0)
                        {
                            if (ConfigValue == "Y")
                            {
                                CreateReportTAT(OrgID, Convert.ToInt32(splitID[0]), splitID[1].ToString(), invs.Name, 0, "N", "01/01/2000", out TAT);

                                if (!String.IsNullOrEmpty(TAT) && TAT.Length > 0)
                                {
                                    objInvest.TatDateTime = Convert.ToDateTime(TAT);
                                    objInvest.ReportDateTime = Convert.ToDateTime(TAT);

                                }
                            }

                        }
                        orderedList.Add(objInvest);
                    }
                }
            }
            catch (Exception ex)
            {
                objInvest = new OrderedInvestigations();
                orderedList.Add(objInvest);
                CLogger.LogError(" Error in GetTAT_DAL", ex);
            }

            return orderedList;

        }

        public long CreateReportTAT(int OrgID, int FeeID, string FeeType, string Description, long ClientID, string IsCollected, string CollectedDatetime, out string TAT)
        {
            long returncode = -1;
            TAT = string.Empty;
            string ReportTATDateandTime = string.Empty;
           
            try
            {
                returncode = new Investigation_DAL(globalContextDetails).GetTAT_DAL(OrgID, FeeID, FeeType, Description, ClientID, IsCollected, CollectedDatetime, out TAT, out TAT);
            }
            catch (Exception ex)
            {
                CLogger.LogError(" Error in GetTAT_DAL", ex);
            }
            return returncode;
        }

        public long GetImageServerDetails(int OrgID, long OrgAddressID, out List<ImageServerDetails> ImgServerDetails)
        {
            long returnCode = -1;
            ImgServerDetails = new List<ImageServerDetails>();
            try
            {
                returnCode = new IntegrationDAL(globalContextDetails).GetImageServerDetails(OrgID, OrgAddressID, out ImgServerDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError(" Error in GetImageServerDetails", ex);
            }
            return returnCode;
        }

        public long GetIntegrationVisitDetail(string sampleInstanceID, out Int64 visitID, out int visitCount, out string UID, out int intOrgID)
        {
            long returnCode = -1;
            visitID = -1;
            visitCount = -1;
            UID = string.Empty;
            intOrgID = 0;
            try
            {
                returnCode = new IntegrationDAL(globalContextDetails).GetIntegrationVisitDetail(sampleInstanceID, out visitID, out visitCount, out UID, out intOrgID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Excecuting GetIntegrationVisitDetail in IntegrationBL ", ex);
            }
            return returnCode;
        }

        public long GetTestCodeInvestigation(List<InvestigationMaster> lstIM, int OrgID, long PatientVisitID, string UID, string BarCode, string DeviceID, out List<PatientInvestigation> lstPI)
        {
            long returnCode = -1;
            lstPI = new List<PatientInvestigation>();
            try
            {
                returnCode = new IntegrationDAL(globalContextDetails).GetTestCodeInvestigation(lstIM, OrgID, PatientVisitID, UID, BarCode, DeviceID, out lstPI);
            }
            catch (Exception ex)
            {
                CLogger.LogError(" Error in GetImageServerDetails", ex);
            }
            return returnCode;
        }
        public long InsertInvestigationHistory(List<List<InvestigationValues>> InvestigationValues, string gUID)
        {
            long returnCode = -1;
            try
            {
                returnCode = new IntegrationDAL(globalContextDetails).InsertInvestigationHistory(InvestigationValues, gUID);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing InsertInvestigationHistory Integration_BL", excp);
            }
            return returnCode;
        }



        public long GetTestCodesForBarCodes(string DeviceID, List<DeviceImportData> lstBarCode, out List<DeviceImportData> lstTestCode)
        {
            long returnCode = -1;
            lstTestCode = new List<DeviceImportData>();
            try
            {
                returnCode = new IntegrationDAL(globalContextDetails).GetTestCodesForBarCodes(DeviceID, lstBarCode, out lstTestCode);
            }
            catch (Exception ex)
            {
                CLogger.LogError(" Error in GetTestCodesForBarCodes IntegrationBL", ex);
            }
            return returnCode;
        }

        public long GetDuplicateIDforIntegration(long OrgID, List<InvestigationDetail> lstIds, out List<InvestigationDetail> lstIdExists, out List<InvestigationDetail> lstDupIds)
        {
            long returnCode = -1;
            lstIdExists = new List<InvestigationDetail>();
            lstDupIds = new List<InvestigationDetail>();


            try
            {

                returnCode = new IntegrationDAL(globalContextDetails).GetDuplicateIDforIntegration(OrgID, lstIds, out   lstIdExists, out   lstDupIds);
            }
            catch (Exception ex)
            {
                CLogger.LogError(" Error in GetDuplicateIDforIntegration IntegrationDAL", ex);
            }

            return returnCode;
        }
        public long GetDeviceIntegrationFormula(long OrgID, string DeviceID, int InvID, out string Formula)
        {
            long lresult = -1;
            IntegrationDAL Dal = new IntegrationDAL();
            lresult = Dal.GetDeviceIntegrationFormula(OrgID, DeviceID, InvID, out Formula);
            return lresult;
        }
        public long GetInvClient(string Name, int orgid, out List<ClientMaster> lstClientMaster)
        {
            lstClientMaster = new List<ClientMaster>();
            long returnCode = -1;
            try
            {
                Attune.Solution.DAL.Investigation_DAL ObjDAL = new Investigation_DAL(globalContextDetails);
                returnCode = ObjDAL.GetInvClient(Name, orgid, out lstClientMaster);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetInvClient BL", excp);
            }

            return returnCode;
        }

        public long GetInvSampleMasterTransfer(string Name, int orgid, out List<InvSampleMaster> lstInvSampleMaster)
        {
            lstInvSampleMaster = new List<InvSampleMaster>();
            long returnCode = -1;
            try
            {
                Attune.Solution.DAL.Investigation_DAL ObjDAL = new Investigation_DAL(globalContextDetails);
                returnCode = ObjDAL.GetInvSampleMasterTransfer(Name, orgid, out lstInvSampleMaster);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetInvSampleMasterTransfer BL", excp);
            }

            return returnCode;
        }


        public long GetTransferInvestionStatus(int OrgID, out List<InvestigationStatus> lstInvestigationStatus, out List<LabReferenceOrg> lstLabReferenceOrg)
        {
            long returncode = -1;
            lstInvestigationStatus = new List<InvestigationStatus>();
            lstLabReferenceOrg = new List<LabReferenceOrg>();
            try
            {
                returncode = new Investigation_DAL(globalContextDetails).GetTransferInvestionStatus(OrgID, out lstInvestigationStatus, out lstLabReferenceOrg);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetTransferInvestionStatus", ex);
            }
            return returncode;
        }

        public long UpdateDeviceSampleStatus(int OrgID, long OrgAddressID, List<DeviceImportData> lstBarCode)
        {
            long returnCode = -1;
            try
            {
                returnCode = new IntegrationDAL(globalContextDetails).UpdateDeviceSampleStatus(OrgID, OrgAddressID, lstBarCode);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing InsertInvestigationHistory Integration_BL", excp);
            }
            return returnCode;
        }

        public long SaveVitekDeviceIntegrationResult(List<VitekDeviceIntegrationResult> lstVitekDeviceIntegrationResult)
        {
            long returnCode = -1;
            try
            {
                returnCode = new IntegrationDAL(globalContextDetails).SaveVitekDeviceIntegrationResult(lstVitekDeviceIntegrationResult);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveVitekDeviceIntegrationResult Integration_BL", ex);
            }
            return returnCode;
        }

        public long GetVitekDeviceIntegrationResult(List<VitekDeviceIntegrationResult> UDTVitekDeviceIntegrationResult, out List<VitekDeviceIntegrationResult> lstVitekDeviceIntegrationResult)
        {
            long returnCode = -1;
            lstVitekDeviceIntegrationResult = new List<VitekDeviceIntegrationResult>();
            try
            {
                returnCode = new IntegrationDAL(globalContextDetails).GetVitekDeviceIntegrationResult(UDTVitekDeviceIntegrationResult, out lstVitekDeviceIntegrationResult);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetVitekDeviceIntegrationResult Integration_BL", ex);
            }
            return returnCode;
        }
        public long GetBidirectionalBarCodeDetails(DateTime FromDate, DateTime ToDate, int OrgID, string DeviceID, out List<BidirectionalBarcodes> lstBarCode)
        {
            long returnCode = -1;
            lstBarCode = new List<BidirectionalBarcodes>();
            try
            {
                returnCode = new IntegrationDAL(globalContextDetails).GetBidirectionalBarCodeDetails(FromDate, ToDate, OrgID, DeviceID, out lstBarCode);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetBidirectionalBarCodeDetails", ex);
            }

            return returnCode;
        }
        public long UpdateBidirectionalBarCodeDetails(List<BidirectionalBarcodes> lstBarCode)
        {
            long returnCode = -1;
            try
            {
                returnCode = new IntegrationDAL(globalContextDetails).UpdateBidirectionalBarCodeDetails(lstBarCode);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing InsertInvestigationHistory Integration_BL", excp);
            }
            return returnCode;
        }
        public long UpdateDueBillvisit(String ExternalVisitID, int IsDuebill, int Orgid)
        {

            long returnCode = -1;
            try
            {
                returnCode = new Patient_DAL(globalContextDetails).UpdateDueBillvisit(ExternalVisitID, IsDuebill, Orgid);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing UpdateDueBillvisit Integration_BL", excp);
            }
            return returnCode;
        }
        public long GetBarCodeForSample(string ExternalVisitId, int OrgID, out List<PatientInvSample> lstinvsample, out List<BarcodeIntegrationResults> lstbarcode, out int TranStatus)
        {
            long returnCode = -1;
            lstbarcode = new List<BarcodeIntegrationResults>();
            lstinvsample = new List<PatientInvSample>();
            TranStatus = -1;
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).GetBarCodeForSample(ExternalVisitId, OrgID, out lstinvsample, out lstbarcode, out TranStatus);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetBarCodeForSample Integration_BL", excp);
            }
            return returnCode;
        }
        //Vijayalakshmi.M
        public long GetBarCodeDetails(string ExternalVistiId, int OrgId, out int TranStatus, out List<BarcodeIntegrationResults> lstsample)
        {
            long returnCode = -1;
            TranStatus = -1;
            lstsample = new List<BarcodeIntegrationResults>();
            IntegrationDAL integDAL = new IntegrationDAL();
            try
            {
                returnCode = integDAL.GetBarCodeDetails(ExternalVistiId, OrgId, out TranStatus, out lstsample);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetBarCodeDetails Integration_BL", excp);
            }
            return returnCode;
        }
        #region HL7 integration
        public string ResponseXml(string HistoryID)
        {
            XmlDocument doc = new XmlDocument();
            XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-16", null);
            doc.AppendChild(docNode);

            XmlNode responseNode = doc.CreateElement("Response");
            doc.AppendChild(responseNode);

            XmlNode integrationIDNode = doc.CreateElement("IntegrationHistoryID");

            integrationIDNode.AppendChild(doc.CreateTextNode(HistoryID));

            responseNode.AppendChild(integrationIDNode);

            XmlNode statusNode = doc.CreateElement("Status");

            statusNode.AppendChild(doc.CreateTextNode("0"));
            responseNode.AppendChild(statusNode);

            StringWriter sw = new StringWriter();
            XmlTextWriter tw = new XmlTextWriter(sw);
            doc.WriteTo(tw);
            return sw.ToString();

        }
        public string ResponseFailureXml(string error)
        {
            XmlDocument doc = new XmlDocument();
            XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-16", null);
            doc.AppendChild(docNode);

            XmlNode responseNode = doc.CreateElement("Response");
            doc.AppendChild(responseNode);

            XmlNode integrationIDNode = doc.CreateElement("Error");

            integrationIDNode.AppendChild(doc.CreateTextNode(error));

            responseNode.AppendChild(integrationIDNode);

            XmlNode statusNode = doc.CreateElement("Status");

            statusNode.AppendChild(doc.CreateTextNode("1"));
            responseNode.AppendChild(statusNode);

            StringWriter sw = new StringWriter();
            XmlTextWriter tw = new XmlTextWriter(sw);
            doc.WriteTo(tw);
            return sw.ToString();

        }
        public long InsertIntegrationHistoryAck(long IntegrationHistoryID, string Reason, string Status, int OrgID, int LocationID, string Acknowledgement)
        {
            long returnCode = -1;
            try
            {
                returnCode = new IntegrationDAL(globalContextDetails).InsertIntegrationHistoryAck(IntegrationHistoryID, Reason, Status, OrgID, LocationID, Acknowledgement);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing InsertIntegrationHistoryAck Integration_BL", excp);
            }
            return returnCode;
        }
        public long SaveIntegrationHistory(List<IntegrationHistory> lstIntegrationDetails, out long HistoryID)
        {
            long returnCode = -1;
            HistoryID = 0;
            try
            {
                returnCode = new IntegrationDAL(globalContextDetails).InsertIntegrationHistory(lstIntegrationDetails, out HistoryID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in SaveIntegrationData", ex);
            }
            return returnCode;
        }
        #endregion
        public long SaveClientDetails(List<ClientDetails_Integration> pClientDetails, out long ClientID)
        {
            long returncode = -1;
            ClientID = 0;
            try
            {
                returncode = new IntegrationDAL(globalContextDetails).SaveClientDetails(pClientDetails, out ClientID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in SaveClientDetails", ex.InnerException);
            }
            return returncode;
        }
        public long GetIntegrationError(string type, int orgid, out List<Status> lststatus)
        {
            long returncode = -1;
            lststatus = new List<Status>();
            try
            {
                returncode = new IntegrationDAL(globalContextDetails).GetIntegrationError(type,orgid, out lststatus);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetIntegrationError", ex.InnerException);
            }

            return returncode;
        }
        public long SaveReferingphysiciandetails(List<ReferingPhysicianDetails> lstrefphy, out long Refferingphysicianid)
        {
            long returncode = -1;
            Refferingphysicianid = 0;
            try
            {
                returncode = new IntegrationDAL(globalContextDetails).SaveReferingphysiciandetails(lstrefphy, out Refferingphysicianid);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in SaveReferingphysiciandetails", ex.InnerException);
            }
            return returncode;
        }
        public long GetRateforInvestigation(string Testcode,int Orgid,long Clientid, out int investigationid, out decimal Rate, out int Rateid, out int LoginID, out int Roleid, out string type)
       
        {
            long returncode = -1;
            investigationid = 0;
            Rate = decimal.Zero;
            Rateid = 0;
            LoginID = 0;
            Roleid = 0;
            type = string.Empty;
          
            try
            {
                returncode = new IntegrationDAL(globalContextDetails).GetRateforInvestigation(Testcode, Orgid,Clientid,out investigationid, out Rate, out Rateid, out LoginID, out Roleid, out type);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetRateforInvestigation", ex.InnerException);
            }

            return returncode;
        }
        public long GetRegistrationStatus_integration(string ExternalPatientNo,string ExternalVisitid, int OrgID, out int count, out List<Patient> lPatientDetails, out List<PatientVisit> LstPatientvisit)
        {
            long returnCode = -1;
            count = -1;
            lPatientDetails = new List<Patient>();
            LstPatientvisit = new List<PatientVisit>();
            try
            {
                returnCode = new IntegrationDAL(globalContextDetails).GetRegistrationStatus_integration(ExternalPatientNo, ExternalVisitid, OrgID, out count, out lPatientDetails, out LstPatientvisit);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while check patient registration status", ex);
            }
            return returnCode;
        }
        public long GetOrderedStatus(string ExternalVisitID, out List<OrderedStatus> lstOrderedStatus)
        {
            long returncode = -1;
            lstOrderedStatus = new List<OrderedStatus>();
            try
            {
                returncode = new IntegrationDAL(globalContextDetails).GetOrderedStatus(ExternalVisitID, out lstOrderedStatus);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetOrderedStatus", ex.InnerException);
            }
            return returncode;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="OrgID"></param>
        /// <param name="OrgAddressID"></param>
        /// <param name="DeviceID"></param>
        /// <param name="lstBarCode"></param>
        /// <returns></returns>
        public long GetBidirectionalBarCodeDetails(int OrgID, int OrgAddressID, string DeviceID, out List<BidirectionalBarcodesDetails> lstBarCode)
        {
            long returnCode = -1;
            lstBarCode = new List<BidirectionalBarcodesDetails>();
            try
            {
                //BiDirectional_DL BiDirectionalDL = new BiDirectional_DL();
                returnCode = new IntegrationDAL(globalContextDetails).GetBidirectionalBarCodeDetails(OrgID, OrgAddressID, DeviceID, out lstBarCode);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetBidirectionalBarCodeDetails", ex);
            }

            return returnCode;
        }

        public long InsertDeviceInvestigationData(List<DeviceInvestigationData> oDeviceTranData, int OrgID)
        {
            long returnCode = -1;
            try
            {
                //BiDirectional_DL BDL = new BiDirectional_DL();
                returnCode = new IntegrationDAL(globalContextDetails).InsertDeviceInvestigationData(oDeviceTranData, OrgID);
            }
            catch (Exception exception)
            {
                CLogger.LogError("Error while executing InsertDeviceInvestigationData Investigation_BL", exception);
            }
            return returnCode;
        }

        public long UpdateBidirectionalBarCodeDetails(List<BidirectionalBarcodesDetails> lstBarCode)
        {
            long returnCode = -1;
            try
            {
                //BiDirectional_DL BDL = new BiDirectional_DL();
                returnCode = new IntegrationDAL(globalContextDetails).UpdateBidirectionalBarCodeDetails(lstBarCode);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing UpdateBidirectionalBarCodeDetails Integration_BL", excp);
            }
            return returnCode;
        }

        public long GetIntegrationVisitDetailforExternalBarcode(string sampleInstanceID, string DeviceID, string AssayCode, out Int64 visitID, out int visitCount, out string UID, out int intOrgID)
        {
            long returnCode = -1;
            visitID = -1;
            visitCount = -1;
            UID = string.Empty;
            intOrgID = 0;
            try
            {
                returnCode = new IntegrationDAL(globalContextDetails).GetIntegrationVisitDetailforExternalBarcode(sampleInstanceID, DeviceID, AssayCode, out visitID, out visitCount, out UID, out intOrgID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Excecuting GetIntegrationVisitDetail in IntegrationBL ", ex);
            }
            return returnCode;
        }

        public long SaveIntegrationData(List<IntegrationHistory> lstIntegrationDetails, string OrgCode, string Location, string VisitTypeCode, string PatientTitle, out int OrgID, out int LocationID, out int VisitType, out long ClientID, out byte titlecode)
        {
            long returnCode = -1;
            OrgID = -1;
            LocationID = -1;
            VisitType = -1;
            ClientID = -1;
            titlecode = 0x00;
            try
            {
                returnCode = new IntegrationDAL(globalContextDetails).SaveIntegrationData(lstIntegrationDetails, OrgCode, Location, VisitTypeCode, PatientTitle, out  OrgID, out  LocationID, out VisitType, out ClientID, out titlecode);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in SaveIntegrationData", ex);
            }
            return returnCode;
        }

        public long GetIntegrationVisitDetailforLabCode(string sampleInstanceID, string DeviceID, string AssayCode, out Int64 visitID, out int visitCount, out string UID, out int intOrgID, out string barcode)
        {
            long returnCode = -1;
            visitID = -1;
            visitCount = -1;
            UID = string.Empty;
            barcode = string.Empty;
            intOrgID = 0;
            try
            {
                returnCode = new IntegrationDAL(globalContextDetails).GetIntegrationVisitDetailforLabCode(sampleInstanceID, DeviceID, AssayCode, out visitID, out visitCount, out UID, out intOrgID, out barcode);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Excecuting GetIntegrationVisitDetail in IntegrationBL ", ex);
            }
            return returnCode;
        }
    }
}
