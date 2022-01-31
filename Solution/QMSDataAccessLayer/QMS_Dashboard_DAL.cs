using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Attune.Podium.DataAccessEngine;
using System.Data.SqlClient;
using Attune.Podium.Common;
using Attune.Solution.QMSBusinessEntities;
using Attune.Solution.QMSBusinessEntities.CustomEntities;

namespace Attune.Solution.QMSDataAccessLayer
{
    public class QMS_Dashboard_DAL
    {
        ContextDetails globalContextDetails;
        public QMS_Dashboard_DAL(ContextDetails _globalContextDetails)
        {
            globalContextDetails = _globalContextDetails;
        }
        public long Dashboard_AnalyzerDetails_DAL(int OrgID, int LocationID, int DepartmentID, DateTime fromDate, DateTime toDate,int checkDiff, out List<DashboardContent> InstrumentList)
        {
            InstrumentList = new List<DashboardContent>();
            long returncode = -1;
            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = Command.pGetAnalyzerDetailsQMSCommand(OrgID, LocationID, DepartmentID, fromDate,toDate, checkDiff,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    System.Data.IDataReader IdR = dbEngine.ExecuteReader(cmd);
                    returncode = Attune.Podium.Common.Utilities.ConvertTo<DashboardContent>(IdR, out InstrumentList);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while loading in QMS_LoadAnalyte_DAL", e);
            }
            return returncode;
        }
        public long pgetGeneralStatistics(string year, int month, out List<DropDownKeyValue> lstCharData)
        {
            lstCharData = new List<DropDownKeyValue>();
            long returncode = -1;
            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = Command.pgetGeneralStatistics_QMSCommand(year, month, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    System.Data.IDataReader IdR = dbEngine.ExecuteReader(cmd);
                    returncode = Attune.Podium.Common.Utilities.ConvertTo<DropDownKeyValue>(IdR, out lstCharData);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while loading in pgetGeneralStatistics_DAL", e);
            }
            return returncode;
        }
        public long Dashboard_LoadDept_DAL(int LoginID,int OrgID, int RoleID,out List<Department> deptList)
        {
            deptList = new List<Department>();
            long returncode = -1;
            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = Command.pGetLoginDeptCommand(LoginID, OrgID, RoleID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    System.Data.IDataReader IdR = dbEngine.ExecuteReader(cmd);
                    returncode = Attune.Podium.Common.Utilities.ConvertTo<Department>(IdR, out deptList);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while loading in QMS_LoadAnalyte_DAL", e);
            }
            return returncode;
        }
    }
}
