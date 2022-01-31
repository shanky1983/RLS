using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
  
    public class MasterData
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<CountryData> CountryListInfo { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<StateData> StateListInfo { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<GenderData> GenderListInfo { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<SalutationData> SalutationListInfo { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<URNTypesData> URNTypesListInfo { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<LocationData> LocationListInfo { get; set; } 

    }
    public class CountryData
    {
       public  int CountryID { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
    }
    public class StateData
    {
        public int  StateID { get; set; }
        public string StateName { get; set; }
    }
    public class GenderData
    {
        public string Code { get; set; }
        public string DisplayText { get; set; }
    }

    public class SalutationData
        {
        public int TitleID { get; set; }
        public string TitleName { get; set; }
    }
    public class URNTypesData

{
        public long URNTypeId { get; set; }
        public string URNType { get; set; }
    }
public class   LocationData
{
        public string LocationID { get; set; }
        public string LocationName { get; set; }
        public string IsProcessingLocationYN { get; set; }
        public string CollectionCenterYN { get; set; }
    }
}
