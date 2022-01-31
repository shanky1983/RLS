using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
  public  class ClientNameInfo
    {
           public int OrgID { get; set; }
            public int LocationID { get; set; }
        public string Type { get; set; }
        public string ClientType { get; set; }
        public string    Salutation { get; set; }
       public string   ClientName { get; set; }
        public string ClientCode { get; set; }

        public string Businesstype { get; set; }
        public string   Password { get; set; }
       
        public string PanNo { get; set; }
     //   public int RoleID { get; set; }
     
    


public int ClientAccess { get; set; }
public int RemoteRegistration { get; set; }
public string ClientPaymentType{ get; set; }
public string InvoiceCycleDuration { get; set; }
public string ContactPersonType { get; set; }
public string ContactPersonName { get; set; }
public string ContactPersonMobileNumber  { get; set; }
public string ContactPersonEmailID { get; set; }
public string Status { get; set; }
        
       
     
     
     
     
        
      

    }
    public class ClientNameDetailsInfo
    {
    //    public int OrgID { get; set; }
    //    public int OrgAddressID { get; set; }
     //   public string Type { get; set; }
        public string ClientType { get; set; }
        public string Salutation { get; set; }
        public string ClientName { get; set; }
        public string ClientCode { get; set; }

        public string Businesstype { get; set; }
        public string Password { get; set; }

        public string PanNo { get; set; }
        //   public int RoleID { get; set; }




        public string ClientAccess { get; set; }
        public string RemoteRegistration { get; set; }
        public string ClientPaymentType { get; set; }
        public string InvoiceCycleDuration { get; set; }
        public string ContactPersonType { get; set; }
        public string ContactPersonName { get; set; }
        public string ContactPersonMobileNumber { get; set; }
        public string ContactPersonEmailID { get; set; }
        public string Status { get; set; }


    }
}
