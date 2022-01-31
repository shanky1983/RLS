using Attune.Kernel.LIMSAPI.BusinessEntities; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LIMSAPI.Models
{
    public class MasterDataDetails : Paging
    {
      
        public string OrgCode { get; set; }
     
        public List<MasterData> MasterListInfo { get; set; }
    }
    public class CountryDetails : Paging
    {

        public string OrgCode { get; set; }

        public List<CountryData> CountryListInfo { get; set; }
    }
    public class StateDetails : Paging
    {

        public string OrgCode { get; set; }

        public List<StateData> StateListInfo { get; set; }
    }
    public class GenderDetails : Paging
    {

        public string OrgCode { get; set; }

        public List<GenderData> GenderListInfo { get; set; }
    }
    public class SalutationDetails : Paging
    {

        public string OrgCode { get; set; }

        public List<SalutationData> SalutationListInfo { get; set; }
    }
    public class URNTypesDetails : Paging
    {

        public string OrgCode { get; set; }

        public List<URNTypesData> URNTypesListInfo { get; set; }
    }
    public class LocationDetails : Paging
    {

        public string OrgCode { get; set; }

        public List<LocationData> LocationListInfo { get; set; }
    }

}