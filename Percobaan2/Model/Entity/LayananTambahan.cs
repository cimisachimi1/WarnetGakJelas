using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Percobaan2.Model.Entity
{
    internal class LayananTambahan
    {
        public int ID_LayananTambahan { get; set; }
        public int ID_Pelanggan { get; set; }
        public string Name { get; set; }
        public string Makanan { get; set; }
        public string Minuman { get; set; }
        public string PrintKertas { get; set; }
        public int Total_Layanan { get; set; }
    }
}
