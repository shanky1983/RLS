using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using Attune.Podium.Common;
using Attune.Solution.QMSBusinessEntities;
using Attune.Solution.QMSBusinessEntities.CustomEntities;




namespace Attune.Solution.QMSDataAccessLayer
{
    public class QMS_Dashboard_BL
    {
        ContextDetails globalContextDetails;
        public QMS_Dashboard_BL(ContextDetails _globalContextDetails)
        {
            globalContextDetails = _globalContextDetails;
        }
        public long Dashboard_AnalyzerDetails_BL(int OrgID, int LocationID, int DepartmentID, DateTime fromDate, DateTime toDate,int checkDiff, out List<DashboardContent> InstrumentList)
        {
            InstrumentList = new List<DashboardContent>();
            long returncode = -1;
           
            try
            {
                QMS_Dashboard_DAL objDal=new QMS_Dashboard_DAL(globalContextDetails);
                returncode = objDal.Dashboard_AnalyzerDetails_DAL(OrgID, LocationID, DepartmentID, fromDate,toDate,checkDiff, out InstrumentList);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while loading in QMS_LoadAnalyte_DAL", e);
            }
            return returncode;
        }

        public long pgetGeneralStatistics(string year, int month, out List<DropDownKeyValue> InstrumentList)
          {
              InstrumentList = new List<DropDownKeyValue>();
            long returncode = -1;
           
            try
            {
                QMS_Dashboard_DAL objDal=new QMS_Dashboard_DAL(globalContextDetails);
                returncode = objDal.pgetGeneralStatistics(year, month,out InstrumentList);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while loading in pgetGeneralStatistics_BL", e);
            }
            return returncode;
        }
        public long Dashboard_LoadDept_BL(int LoginID, int OrgID, int RoleID, out List<Department> deptList)
        {
            deptList = new List<Department>();
            long returncode = -1;

            try
            {
                QMS_Dashboard_DAL objDal = new QMS_Dashboard_DAL(globalContextDetails);
                returncode = objDal.Dashboard_LoadDept_DAL(LoginID, OrgID, RoleID, out deptList);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while loading in QMS_LoadAnalyte_DAL", e);
            }
            return returncode;
        }
    }
}
