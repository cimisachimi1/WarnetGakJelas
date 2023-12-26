using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Percobaan2.Model.Entity
{
    public class Transaksi
    {
        public string ID_Transaksi { get; set; }
        public string ID_Pelanggan { get; set; }
        public string ID_Paket { get; set; }
        public string ID_Operator { get; set; }
        public DateTime TanggalTransaksi { get; set; }
        public int WaktuTerpakai { get; set; }
        public int Harga { get; set; }
       

    }
}