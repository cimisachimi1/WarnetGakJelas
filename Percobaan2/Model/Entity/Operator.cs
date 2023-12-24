using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Percobaan2.Model.Entity
{
    public class Operator
    {
        public string ID_Operator { get; set; }
        public string Nama { get; set; }
        public string Alamat { get; set; }
        public int Umur { get; set; }
        public DateTime Mulai_Shift { get; set; }
        public DateTime Akhir_Shift { get; set; }
        public string Username {  get; set; }
        public string Password { get; set; }


    }
}
