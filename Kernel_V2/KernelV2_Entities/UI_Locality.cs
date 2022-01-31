using System;
using System.Collections.Generic;

namespace Attune.KernelV2.Entities
{
    public class UI_Country
    {
        public long CountryID { get; set; }
        public string CountryName { get; set; }
        public long CountryCode { get; set; }
        public string Nationality { get; set; }
        public short NationalityID { get; set; }
        public int ISDCode { get; set; }
        public int PhoneNo_Length { get; set; }
    }
    public class UI_State
    {
        public short StateID { get; set; }
        public short CountryID { get; set; }
        public string StateName { get; set; }
        public int StateCode { get; set; }
        public string IsDefault { get; set; }
        public int ISDCode { get; set; }
    }
    public class UI_City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public short StateID { get; set; }
    }
    public class UI_Address
    {
        public int CountryID { get; set; }
        public int CountryCode { get; set; }
        public string CountryName { get; set; }
        public int ISDCode { get; set; }
        public int PhoneNo_Length { get; set; }
        public int NationalityID { get; set; }
        public string Nationality { get; set; }
        public string IsDefault { get; set; }
        public int StateID { get; set; }
        public int StateCode { get; set; }
        public string StateName { get; set; }
        public long CityID { get; set; }
        public string CityName { get; set; }
        public string Locality { get; set; }
        public string Pincode { get; set; }
    }

    public class UI_AddressDetails
    {
        public List<UI_Country> lstCountry { get; set; }
        public List<UI_State> lstState { get; set; }
        public List<UI_City> lstCity { get; set; }
        public string Address { get; set; }
    }
}
