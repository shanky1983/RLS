using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class sales_operation
    {

        public bool pursuit_approval { get; set; }
        public string new_renewal_lost_account { get; set; }

        public string onboarding_month_year { get; set; }

        public string legal_entity { get; set; }

        public string legal_address { get; set; }

        public string legal_email { get; set; }
        public long tax_code { get; set; }

        public long new_account_code { get; set; }

          
        }
    }
