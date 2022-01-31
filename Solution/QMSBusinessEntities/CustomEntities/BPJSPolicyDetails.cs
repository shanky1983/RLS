using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class BPJSPolicyDetails
    {
        public response response { get; set; }
        public string response1 { get; set; }
        public metaData metaData { get; set; }
    }

    public class response
    {
        public peserta peserta { get; set; }

        public int start { get; set; }
        public int limit { get; set; }
        public int count { get; set; }

        public List<list> list { get; set; }

    }

    public class metaData
    {
        public string message { get; set; }
        public string code { get; set; }
    }

    public class peserta
    {
        public string noKartu { get; set; }
        public string nik { get; set; }
        public string nama { get; set; }
        public string pisa { get; set; }
        public string sex { get; set; }
        public string tglLahir { get; set; }
        public string tglCetakKartu { get; set; }

        public provUmum provUmum { get; set; }
        public jenisPeserta jenisPeserta { get; set; }
        public kelasTanggungan kelasTanggungan { get; set; }
    }
    public class provUmum
    {
        public string kdProvider { get; set; }
        public string nmProvider { get; set; }
        public string kdCabang { get; set; }
        public string nmCabang { get; set; }
    }

    public class jenisPeserta
    {
        public string kdJenisPeserta { get; set; }
        public string nmJenisPeserta { get; set; }
    }

    public class kelasTanggungan
    {
        public string kdKelas { get; set; }
        public string nmKelas { get; set; }
    }

    public class BPJSPatientHistDetails
    {
        public response response { get; set; }
        public metaData metaData { get; set; }
    }

    public class list
    {
        public string noSep { get; set; }
        public string tglSep { get; set; }
        public string tglPulang { get; set; }
        public string jnsPelayanan { get; set; }

        public poliTujuan poliTujuan { get; set; }

        public string noKartu { get; set; }
        public string nik { get; set; }
        public string nama { get; set; }
        public string pisa { get; set; }
        public string sex { get; set; }
        public string tglLahir { get; set; }
        public string tglCetakKartu { get; set; }

        public provUmum provUmum { get; set; }
        public jenisPeserta jenisPeserta { get; set; }
        public kelasTanggungan kelasTanggungan { get; set; }

    }
    public class poliTujuan
    {
        public string kdPoli { get; set; }
        public string nmPoli { get; set; }
    }

    public class GenereateSEPNumber
    {
        public string response { get; set; }
        public metaData metaData { get; set; }
    }

    public class ResponseMessage
    {
        public int status { get; set; }
        public string status_msg { get; set; }
        public string cbg_code { get; set; }
        public string tariff { get; set; }
        public string kelas_1 { get; set; }
        public string kelas_2 { get; set; }
        public string kelas_3 { get; set; }
    }

    public class BPJSInValidPolicyDetails
    {        
        public string response { get; set; }
        public metaData metaData { get; set; }
    }

}
