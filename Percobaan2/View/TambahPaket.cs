using MySqlX.XDevAPI.Common;
using Percobaan2.Controller;
using Percobaan2.Model.Entity;
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
    public partial class TambahPaket : Form
    {
        private List<Paket> ListOfPaket = new List<Paket>();

        public PaketController controllerPaket; // Assuming you have a PaketController

        public TambahPaket()
        {
            InitializeComponent();

            controllerPaket = new PaketController(); // Initialize PaketController

            InisialisasiListView();

            LoadDataPaket();
        }
        private void InisialisasiListView()
        {
            lvwPaket.View = System.Windows.Forms.View.Details;
            lvwPaket.FullRowSelect = true;
            lvwPaket.GridLines = true;

            lvwPaket.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwPaket.Columns.Add("ID Paket", 91, HorizontalAlignment.Center);
            lvwPaket.Columns.Add("Nama", 150, HorizontalAlignment.Left);
            lvwPaket.Columns.Add("Menit", 100, HorizontalAlignment.Center);
            lvwPaket.Columns.Add("Harga", 100, HorizontalAlignment.Center);
            lvwPaket.Columns.Add("Jumlah", 100, HorizontalAlignment.Center);
        }
        private void LoadDataPaket()
        {
            lvwPaket.Items.Clear();
            ListOfPaket = controllerPaket.ReadAll();

            foreach (var paket in ListOfPaket)
            {
                var noUrut = lvwPaket.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(paket.ID_Paket.ToString());
                item.SubItems.Add(paket.Nama);
                item.SubItems.Add(paket.Menit.ToString());
                item.SubItems.Add(paket.Harga.ToString());
                item.SubItems.Add(paket.Jumlah.ToString());

                lvwPaket.Items.Add(item);
            }
        }
















        private void lvwPaket_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TambahPaket_Load(object sender, EventArgs e)
        {

        }

        private void btnBeliPaket_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cmbPaket.SelectedIndex)
                {
                    case 0: // penambahan

                        break;

                    case 1: // pengurangan

                        break;
                    case 2: // perkalian

                        break;

                    default: // pembagian

                        break;
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
    }
}
