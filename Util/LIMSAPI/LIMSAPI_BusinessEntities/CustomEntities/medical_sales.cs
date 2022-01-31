using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class medical_sales
    {
       public string clinic_speciality { get; set; }
        public string related_hospital { get; set; }
        public string hospital_address { get; set; }
        public string hospital_district { get; set; }
        public string hospital_district_id { get; set; }
        public string medical_acc_type { get; set; }
        public string medical_acc_type_id { get; set; }


        public bool home_visit { get; set; }

        public string courier_status { get; set; }
        public bool nurse_staffing { get; set;}
        public bool x_ray_service { get; set; }
        public bool ultrasound_service { get; set; }
        public string account_discount { get; set; }

      
        }
    }
