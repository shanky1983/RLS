using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class NewWorkList
    {
        private string externalVisitId = String.Empty;
        private string name = String.Empty;
        private string appearance = String.Empty;
        private string colour = String.Empty;
        private string specificGravity = String.Empty;
        private string ph= String.Empty;
        private string leucocytes = String.Empty;
        private string nitrite = String.Empty;
        private string protein = String.Empty;
        private string glucose = String.Empty;
        private string ketones = String.Empty;
        private string urobilinogen = String.Empty;
        private string bilirubin = String.Empty;
        private string blood = String.Empty;
        private string whiteBloodCellCount = String.Empty;
        private string redBloodCellCount = String.Empty;
        private string epithelialCellCount = String.Empty;
        private string bacteria = String.Empty;
        private string casts = String.Empty;
        private string others = String.Empty;
        private string antiA = String.Empty;
        private string antiB = String.Empty;
        private string antiAB = String.Empty;
        private string aCell = String.Empty;
        private string bCell = String.Empty;
        private string oCell = String.Empty;
        private string rhesus = String.Empty;
        private string aBO = String.Empty;
        private string bloodGrp = String.Empty;
        private string consistency = String.Empty;
        private string mucusStrands = String.Empty;
        private string yeastCells = String.Empty;
        private string fatGlobules = String.Empty;
        private string protozoa = String.Empty;
        private string flagellates = String.Empty;
        private string ciliates = String.Empty;
        private string parasites = String.Empty;
        private string leukocytesPusCell = String.Empty;
        private string redBloodCells = String.Empty;
        private string undigestedParticles = String.Empty;
        private string leptospiraIgG = String.Empty;
        private string leptospiraIgM = String.Empty;
        private string hPyloriAntibody = String.Empty;
        private string hPyloriStoolAntigen = String.Empty;
        private string salmonellaIgG = String.Empty;
        private string salmonellaIgM = String.Empty;
        private string dengueNS1Antigen = String.Empty;
        private string dengueIgG = String.Empty;
        private string dengueIgM = String.Empty;
        private string chikungunyaIgM = String.Empty;
        private string tpha = String.Empty;
        private string monospotIM = String.Empty;
        private string chlamydiaIgG = String.Empty;
        private string chlamydiaIgM = String.Empty;
        private string antiNuclearFactorANF = String.Empty;
        private string antistreptolysinOTitreASOT = String.Empty;

        private string sTyphiTO = String.Empty;
        private string sParatyphiAO = String.Empty;
        private string sParatyphiBO = String.Empty;
        private string sParatyphiCO = String.Empty;
        private string styphiTH = String.Empty;
        private string sParatyphiAH = String.Empty;
        private string sParatyphiBH = String.Empty;
        private string sParatyphiCH = String.Empty;
        private string proteusOXK = String.Empty;
        private string proteusOX2 = String.Empty;
        private string proteusOX19 = String.Empty;

        private string amphetamine = String.Empty;
        private string cannabinoids = String.Empty;
        private string cOCCocaine = String.Empty;
        private string ketamine = String.Empty;
        private string opiates = String.Empty;
        private string metanephrine = String.Empty;

        private string performed = String.Empty;
        private string entered = String.Empty;
        private long patientVisitId = 0;
        private string uid = String.Empty;
        private long workListID = 0;
        private string vdrl = String.Empty;
        private string urinePregnancyTest = String.Empty;

        private int seqNo=0;
        private long accessionNumber=0;
        private string searchType = String.Empty;

        private string cYTOREFNO = String.Empty;
        private string lMPDATE = String.Empty;
        private string sSPECI = String.Empty;
        private string sPECADEQ = String.Empty;
        private string eNDOCELL = String.Empty;
        private string hORMON = String.Empty;
        private string cYTOMICROP = String.Empty;
        private string iNFLAM = String.Empty;
        private string mICROINFECT = String.Empty;
        private string tRICHO_CAND = String.Empty;
        private string i_D = String.Empty;
        private string rCMMD = String.Empty;
        private string summary = String.Empty;
        #region Widal & Weil Felix

        public string STyphiTO
        {
            get { return sTyphiTO; }
            set { sTyphiTO = value; }
        }

        public string SParatyphiAO
        {
            get { return sParatyphiAO; }
            set { sParatyphiAO = value; }
        }

        public string SParatyphiBO
        {
            get { return sParatyphiBO; }
            set { sParatyphiBO = value; }
        }

        public string SParatyphiCO
        {
            get { return sParatyphiCO; }
            set { sParatyphiCO = value; }
        }

        public string StyphiTH
        {
            get { return styphiTH; }
            set { styphiTH = value; }
        }

        public string SParatyphiAH
        {
            get { return sParatyphiAH; }
            set { sParatyphiAH = value; }
        }

        public string SParatyphiBH
        {
            get { return sParatyphiBH; }
            set { sParatyphiBH = value; }
        }

        public string SParatyphiCH
        {
            get { return sParatyphiCH; }
            set { sParatyphiCH = value; }
        }

        public string ProteusOXK
        {
            get { return proteusOXK; }
            set { proteusOXK = value; }
        }

        public string ProteusOX2
        {
            get { return proteusOX2; }
            set { proteusOX2 = value; }
        }

        public string ProteusOX19
        {
            get { return proteusOX19; }
            set { proteusOX19 = value; }
        }

        #endregion

        #region Urinalysis

        public string ExternalVisitId
        {
            get { return externalVisitId; }
            set { externalVisitId = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Appearance
        {
            get { return appearance; }
            set { appearance = value; }
        }
        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }
        public string SpecificGravity
        {
            get { return specificGravity; }
            set { specificGravity = value; }
        }
        public string pH
        {
            get { return ph; }
            set { ph = value; }
        }
        public string Leucocytes
        {
            get { return leucocytes; }
            set { leucocytes = value; }
        }
        public string Nitrite
        {
            get { return nitrite; }
            set { nitrite = value; }
        }
        public string Protein
        {
            get { return protein; }
            set { protein = value; }
        }
        public string Glucose
        {
            get { return glucose; }
            set { glucose = value; }
        }
        public string Ketones
        {
            get { return ketones; }
            set { ketones = value; }
        }
        public string Urobilinogen
        {
            get { return urobilinogen; }
            set { urobilinogen = value; }
        }
        public string Bilirubin
        {
            get { return bilirubin; }
            set { bilirubin = value; }
        }
        public string Blood
        {
            get { return blood; }
            set { blood = value; }
        }
        public string WhiteBloodCellCount
        {
            get { return whiteBloodCellCount; }
            set { whiteBloodCellCount = value; }
        }
        public string RedBloodCellCount
        {
            get { return redBloodCellCount; }
            set { redBloodCellCount = value; }
        }
        public string EpithelialCellCount
        {
            get { return epithelialCellCount; }
            set { epithelialCellCount = value; }
        }
        public string Bacteria
        {
            get { return bacteria; }
            set { bacteria = value; }
        }
        public string Casts
        {
            get { return casts; }
            set { casts = value; }
        }
        public string Others
        {
            get { return others; }
            set { others = value; }
        }
        public string Performed
        {
            get { return performed; }
            set { performed = value; }
        }
        public string Entered
        {
            get { return entered; }
            set { entered = value; }
        }
        #endregion

        #region Blood Group

        public string AntiA
        {
            get { return antiA; }
            set { antiA = value; }
        }
        public string AntiB
        {
            get { return antiB; }
            set { antiB = value; }
        }
        public string AntiAB
        {
            get { return antiAB; }
            set { antiAB = value; }
        }
        public string ACell
        {
            get { return aCell; }
            set { aCell = value; }
        }
        public string BCell
        {
            get { return bCell; }
            set { bCell = value; }
        }
        public string OCell
        {
            get { return oCell; }
            set { oCell = value; }
        }
        public string Rhesus
        {
            get { return rhesus; }
            set { rhesus = value; }
        }

        public string ABO
        {
            get { return aBO; }
            set { aBO = value; }
        }

        public string BloodGrp
        {
            get { return bloodGrp; }
            set { bloodGrp = value; }
        }

        #endregion 

        #region Fecalysis

        public string Consistency
        {
            get { return consistency; }
            set { consistency = value; }
        }

        public string MucusStrands
        {
            get { return mucusStrands; }
            set { mucusStrands = value; }
        }

        public string YeastCells
        {
            get { return yeastCells; }
            set { yeastCells = value; }
        }

        public string FatGlobules
        {
            get { return fatGlobules; }
            set { fatGlobules = value; }
        }

        public string Protozoa
        {
            get { return protozoa; }
            set { protozoa = value; }
        }

        public string Flagellates
        {
            get { return flagellates; }
            set { flagellates = value; }
        }

        public string Ciliates
        {
            get { return ciliates; }
            set { ciliates = value; }
        }

        public string Parasites
        {
            get { return parasites; }
            set { parasites = value; }
        }

        public string LeukocytesPusCell
        {
            get { return leukocytesPusCell; }
            set { leukocytesPusCell = value; }
        }

        public string RedBloodCells
        {
            get { return redBloodCells; }
            set { redBloodCells = value; }
        }

        public string UndigestedParticles
        {
            get { return undigestedParticles; }
            set { undigestedParticles = value; }
        }

        #endregion

        #region UrinePregnancyTest

        public string UrinePregnancyTest
        {
            get { return urinePregnancyTest; }
            set { urinePregnancyTest = value; }
        }

        #endregion

        #region MicroSerology

        public string LeptospiraIgG
        {
            get { return leptospiraIgG; }
            set { leptospiraIgG = value; }
        }

        public string LeptospiraIgM
        {
            get { return leptospiraIgM; }
            set { leptospiraIgM = value; }
        }

        public string HPyloriAntibody
        {
            get { return hPyloriAntibody; }
            set { hPyloriAntibody = value; }
        }

        public string HPyloriStoolAntigen
        {
            get { return hPyloriStoolAntigen; }
            set { hPyloriStoolAntigen = value; }
        }

        public string SalmonellaIgG
        {
            get { return salmonellaIgG; }
            set { salmonellaIgG = value; }
        }

        public string SalmonellaIgM
        {
            get { return salmonellaIgM; }
            set { salmonellaIgM = value; }
        }

        public string DengueNS1Antigen
        {
            get { return dengueNS1Antigen; }
            set { dengueNS1Antigen = value; }
        }

        public string DengueIgG
        {
            get { return dengueIgG; }
            set { dengueIgG = value; }
        }

        public string DengueIgM
        {
            get { return dengueIgM; }
            set { dengueIgM = value; }
        }

        public string ChikungunyaIgM
        {
            get { return chikungunyaIgM; }
            set { chikungunyaIgM = value; }
        }

        public string Tpha
        {
            get { return tpha; }
            set { tpha = value; }
        }

        public string MonospotIM
        {
            get { return monospotIM; }
            set { monospotIM = value; }
        }

        public string ChlamydiaIgG
        {
            get { return chlamydiaIgG; }
            set { chlamydiaIgG = value; }
        }
        public string ChlamydiaIgM
        {
            get { return chlamydiaIgM; }
            set { chlamydiaIgM = value; }
        }
        public string AntiNuclearFactorANF
        {
            get { return antiNuclearFactorANF; }
            set { antiNuclearFactorANF = value; }
        }
        public string AntistreptolysinOTitreASOT
        {
            get { return antistreptolysinOTitreASOT; }
            set { antistreptolysinOTitreASOT = value; }
        }

        #endregion

        #region Urine Drug

        public string Amphetamine
        {
            get { return amphetamine; }
            set { amphetamine = value; }
        }
        public string Cannabinoids
        {
            get { return cannabinoids; }
            set { cannabinoids = value; }
        }
        public string COCCocaine
        {
            get { return cOCCocaine; }
            set { cOCCocaine = value; }
        }
        public string Ketamine
        {
            get { return ketamine; }
            set { ketamine = value; }
        }
        public string Opiates
        {
            get { return opiates; }
            set { opiates = value; }
        }
        public string Metanephrine
        {
            get { return metanephrine; }
            set { metanephrine = value; }
        }

        #endregion

        #region VDRL

        public string VDRL
        {
            get { return vdrl; }
            set { vdrl = value; }
        }

        #endregion

        #region PAP Smear

        public string CYTOREFNO
        {
            get { return cYTOREFNO; }
            set { cYTOREFNO = value; }
        }

        public string LMPDATE
        {
            get { return lMPDATE; }
            set { lMPDATE = value; }
        }

        public string SSPECI
        {
            get { return sSPECI; }
            set { sSPECI = value; }
        }

        public string SPECADEQ
        {
            get { return sPECADEQ; }
            set { sPECADEQ = value; }
        }

        public string ENDOCELL
        {
            get { return eNDOCELL; }
            set { eNDOCELL = value; }
        }

        public string HORMON
        {
            get { return hORMON; }
            set { hORMON = value; }
        }

        public string CYTOMICROP
        {
            get { return cYTOMICROP; }
            set { cYTOMICROP = value; }
        }

        public string INFLAM
        {
            get { return iNFLAM; }
            set { iNFLAM = value; }
        }

        public string MICROINFECT
        {
            get { return mICROINFECT; }
            set { mICROINFECT = value; }
        }

        public string TRICHO_CAND
        {
            get { return tRICHO_CAND; }
            set { tRICHO_CAND = value; }
        }

        public string I_D
        {
            get { return i_D; }
            set { i_D = value; }
        }

        public string RCMMD
        {
            get { return rCMMD; }
            set { rCMMD = value; }
        }

        public string Summary
        {
            get { return summary; }
            set { summary = value; }
        }

        #endregion
        public long PatientVisitId
        {
            get{return patientVisitId;}
            set { patientVisitId = value; }
        }

        public string UID
        {
            get { return uid; }
            set { uid = value; }
        }

        public long WorkListID
        {
            get { return workListID; }
            set { workListID = value; }
        }

        public int SeqNo
        {
            get { return seqNo; }
            set { seqNo = value; }
        }
        public long AccessionNumber
        {
            get { return accessionNumber; }
            set { accessionNumber = value; }
        }

        public string SearchType
        {
            get { return searchType; }
            set { searchType = value; }
        }
        
    }
}
