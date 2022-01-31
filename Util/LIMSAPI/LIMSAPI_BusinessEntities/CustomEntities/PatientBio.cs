using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class PatientBio
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<PatientAge> AgewiseDistribution { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<PatientGender> GenderwiseDistribution { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<PatientPlayer> PlayerwiseDistribution { get; set; }

    }

    public class PatientGender
    {
        string Date { get; set; }
        int Male { get; set; }
        int female { get; set; }
    }

    public class PatientPlayer
    {
        string Date { get; set; }
        int Player1 { get; set; }
        int Player2 { get; set; }
    }
    public class PatientAge
    {
        string Date { get; set; }
        int AgeRange_below20 { get; set; }
        int AgeRange_21_40 { get; set; }
        int AgeRange_41_60 { get; set; }
        int AgeRange_Above60 { get; set; }
    }

}
