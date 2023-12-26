using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Percobaan2.Model.Entity
{
    public class TransaksiWarnet
    {
        public string ID_Transaksi { get; set; }
        public string Username { get; set; }
        public DateTime Tanggal{  get; set; }
        public int Harga{ get; set; }
        public int Waktu { get; set; }
        public string Operator { get; set; }
    }
}
