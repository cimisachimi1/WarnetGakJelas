using Percobaan2.Model.Entity;
using Percobaan2.Model.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Percobaan2.View
{
    public partial class MenuUtama : Form
    {
        private readonly PelangganRepository _pelangganRepository;
        private Pelanggan _currentPelanggan;
        private System.Threading.Timer _updateTimer;
        public MenuUtama()
        {
            InitializeComponent();
            isiKomputer1.BringToFront();
        }

        private void btnKomputer_Click(object sender, EventArgs e)
        {
            isiKomputer1.BringToFront();

        }

        private void btnAkun_Click(object sender, EventArgs e)
        {
            isiAkun1.BringToFront();
            

        }

        private void btnTambahan_Click(object sender, EventArgs e)
        {

        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            isiTransaksi1.BringToFront();
        }

        private void akunOperatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AkunOperator akunOperator = new AkunOperator();

            akunOperator.ShowDialog();
        }
    }
}
