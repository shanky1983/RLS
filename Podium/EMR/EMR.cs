using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Attune.Podium.BusinessEntities;
using Attune.Podium.DataAccessLayer;
using Attune.Podium.Common;

namespace Attune.Podium.EMR
{
    public class EMR
    {
        ContextDetails globalContextDetails;
        public EMR()
        {

        }
        public EMR(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        #region properties
        private string name = String.Empty;
        private string attributename = String.Empty;
        private string attributetype = String.Empty;
        private string attributevaluename = String.Empty;
        private long id = 0;
        private long attributeid = 0;
        private long attributevalueid = 0;
        private bool showpopup=false;
        #endregion

        #region methods
        public long Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public long Attributeid
        {
            get
            {
                return attributeid;
            }
            set
            {
                attributeid = value;
            }
        }
        public long Attributevalueid
        {
            get
            {
                return attributevalueid;
            }
            set
            {
                attributevalueid = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Attributename
        {
            get
            {
                return attributename;
            }
            set
            {
                attributename = value;
            }
        }
        public string Attributetype
        {
            get
            {
                return attributetype;
            }
            set
            {
                attributetype = value;
            }
        }
        public string Attributevaluename
        {
            get
            {
                return attributevaluename;
            }
            set
            {
                attributevaluename = value;
            }
        }
        public bool Showpopup
        {
            get
            {
                return showpopup;
            }
            set
            {
                showpopup = value;
            }
        }

        #endregion

        #region Save
        public void EMRsave(string attributename, List<EMRAttributeClass> lstEMR, string flag, out List<EMRAttributeClass> lstResultEMR,out int returncode)
        {
            returncode = 0; long ret = -1;
            lstResultEMR = new List<EMRAttributeClass>();
            try
            {
                DataTable dt = GetAttributesValues(lstEMR);
                ret = new EMRDAL(globalContextDetails).GetEMRAttributeValues(attributename, dt, flag, out lstResultEMR,out returncode);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error occured in saving EMR", ex);
            }
        }
        #endregion
        private DataTable GetAttributesValues(List<EMRAttributeClass> lstattVal)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("AttributeID");
            dt.Columns.Add("AttributevalueID");
            dt.Columns.Add("AttributeValueName");

            DataRow dr;
            foreach (EMRAttributeClass attVal in lstattVal)
            {
                dr = dt.NewRow();
                dr["ID"] = 0;
                dr["AttributeID"] = attVal.AttributeID;
                dr["AttributevalueID"] = attVal.AttributevalueID;
                dr["AttributeValueName"] = attVal.AttributeValueName;
                dt.Rows.Add(dr);
            }
            return dt;
        }
    }
}
