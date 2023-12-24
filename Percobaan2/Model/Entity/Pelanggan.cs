using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Percobaan2.Model.Entity
{
    public class Pelanggan
    {
        public string ID_Pelanggan { get; set; }
        public string NamaPelanggan { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Alamat { get; set; }
        public string Email { get; set; }
        public string NomerHp { get; set; }
        public TimeSpan SisaWaktu { get; set; }
    }
}
