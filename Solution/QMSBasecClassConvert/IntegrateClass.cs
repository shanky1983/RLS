using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using Attune.Solution.QMSBusinessEntities;

namespace Attune.Solution.QMSBasecClassConvert
{
    public  class QMS_Integration
    {
        public   Attune.Solution.QMSBusinessEntities.ContextDetails returnContext;
        public QMS_Integration(Attune.Podium.BusinessEntities.ContextDetails cd)
        {

            returnContext = ClassConvertMethod(cd);
        }

        public Attune.Solution.QMSBusinessEntities.ContextDetails ClassConvertMethod(Attune.Podium.BusinessEntities.ContextDetails ongdd)
        {
            //Attune.Solution.QMSBusinessEntities.ContextDetails ongdd = new Attune.Solution.QMSBusinessEntities.ContextDetails();
        //Attune.Solution.QMSBusinessEntities.ContextDetails objDetail=ConvertTo<Attune.Solution.QMSBusinessEntities.ContextDetails>(A
            //var convertProperties = TypeDescriptor.GetProperties(cd).Cast<PropertyDescriptor>();
            //var entityProperties = TypeDescriptor.GetProperties(ongdd).Cast<PropertyDescriptor>();

            //var convert = new Attune.Solution.QMSBusinessEntities.ContextDetails();

            //foreach (var entityProperty in entityProperties)
            //{
            //    var property = entityProperty;
            //    var convertProperty = convertProperties.FirstOrDefault(prop => prop.Name == property.Name);
            //    if (convertProperty != null)
            //    {
            //        convertProperty.SetValue(convert, Convert.ChangeType(entityProperty.GetValue(ongdd), convertProperty.PropertyType));
            //    }
            //}

            //return convert;

            Attune.Solution.QMSBusinessEntities.ContextDetails cd = new ContextDetails();
            cd.AdditionalInfo = ongdd.AdditionalInfo;
            cd.CountryID = ongdd.CountryID;
            cd.DepartmentCode = ongdd.DepartmentCode;//not in HNH
            cd.DepartmentName = ongdd.DepartmentName;
            cd.InventoryLocationID = ongdd.InventoryLocationID;
            cd.LanguageCode = ongdd.LanguageCode ;
            cd.LocationID = ongdd.LocationID;
            cd.LoggedUserID = ongdd.LoggedUserID;//not in HNH
            cd.LoginID = ongdd.LoginID;
            cd.LoginName = ongdd.LoginName;
            cd.Name = ongdd.Name;
            cd.OrgCurrency = ongdd.OrgCurrency;
            cd.OrgCurrencyFormat = ongdd.OrgCurrencyFormat;
            cd.OrgID = ongdd.OrgID;
            cd.OrgName = ongdd.OrgName;
            cd.OrgTimeZone = ongdd.OrgTimeZone;
            cd.PageID = ongdd.PageID;
            cd.RoleID = ongdd.RoleID;
            cd.RoleName = ongdd.RoleName;
            cd.SessionID = ongdd.SessionID;
            cd.StateID = ongdd.StateID;
            cd.ThemeID = ongdd.ThemeID;
            cd.UserID = ongdd.UserID;
            return cd;
        }
    

    }
}
