using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Attune.Podium.Common
{
    public class RoleHelper
    {
        public enum RoleEnum
        {
            Physician = 1,
            Nurse = 2,
            LabTech = 3,
            Patient = 4,
            Reception = 5,
            SrLabTech =6,
            Phlebotomist=7,
            Physiotherapist=8
        }

        /*SELECT 'public const string ' + Convert(varchar,Replace(RoleName,' ','')) +  ' = "' + Convert(varchar,RoleName) + '";'
FROM Role Group BY RoleName */

        public const string Accounts = "Accounts";
        public const string Admin = "Administrator";
        public const string Billing = "Billing";
        public const string BioChemistryLab = "BioChemistryLab";
        public const string ClinicalPathologyLab = "ClinicalPathologyLab";
        public const string CTLabTech = "CTLabTech";
        public const string DialysisTech = "Dialysis Technician";
        public const string HematologyLab = "HematologyLab";
        public const string HistoPathologyLab = "HistoPathologyLab";
        public const string LabTech = "Lab Technician";
        public const string MicroBiologyLab = "MicroBiologyLab";
        public const string MRILabTech = "MRILabTech";
        public const string Nurse = "Nurse";
        public const string Patient = "Patient";
        public const string Pharmacist = "Pharmacist";
        public const string Physician = "Physician";
        public const string Reception = "Receptionist";
        public const string SrLabTech = "SrLabTech";
        public const string UltraSoundTech = "UltraSoundTech";
        public const string Xray = "Xray";
        public const string XrayTech = "XrayTech";
        public const string MRO = "MRO";
        public const string Cashier = "Cashier";
        public const string Inventory = "Inventory";
        public const string LabAdmin = "LabAdmin";
        public const string ReferringPhysician = "Referring Physician";
        public const string Wardsecretary = "Wardsecretary";
        public const string InventoryAdmin = "InventoryAdmin";
        public const string Phlebotomist = "Phlebotomist";
        public const string Physiotherapist = "Physiotherapist";
        public const string Counselor = "Counselor";
        public const string CustomerCare = "CustomerCare";
        public const string Doctor = "Doctor";
        public const string Pathologist = "Pathologist";
        public const string Accession = "Accession";
        public const string SrCreditControler = "Sr Credit Controller";
        public const string CreditControler = "Credit Controller";
        public const string DispatchController = "Dispatch Controller";
        public const string Labtypist = "Lab typist";
        public const string SeniorDoctor = "Senior Doctor";
        public const string SectionHeadsLab = "Section Heads Lab";
        public const string JuniorDoctor = "Junior Doctor";
        public const string ChiefPathologist = "Chief Pathologist";
        public const string LabManager = "Lab Manager";
        public const string LabReception = "LabReception";
        
    }
}
