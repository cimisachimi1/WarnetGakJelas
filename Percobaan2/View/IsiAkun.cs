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
    public partial class IsiAkun : UserControl
    {
        private List<Pelanggan> ListOfPelanggan = new List<Pelanggan>();

        private PelangganController controllerPelanggan;

        public IsiAkun()
        {
            InitializeComponent();

            controllerPelanggan = new PelangganController();

            InisialisasiListView();

            LoadDataPelanggan();
        }
        private void InisialisasiListView()
        {
            lvwAkun.View = System.Windows.Forms.View.Details;
            lvwAkun.FullRowSelect = true;
            lvwAkun.GridLines = true;

            lvwAkun.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwAkun.Columns.Add("ID Pelanggan", 91, HorizontalAlignment.Center);
            lvwAkun.Columns.Add("Nama", 150, HorizontalAlignment.Left);
            lvwAkun.Columns.Add("Alamat", 150, HorizontalAlignment.Left);
            lvwAkun.Columns.Add("Email", 100, HorizontalAlignment.Center);
            lvwAkun.Columns.Add("Nomer HP", 100, HorizontalAlignment.Center);
            lvwAkun.Columns.Add("Username", 100, HorizontalAlignment.Center);
            lvwAkun.Columns.Add("Sisa Waktu", 100, HorizontalAlignment.Center);

        }
        private void LoadDataPelanggan()
        {
            lvwAkun.Items.Clear();
            ListOfPelanggan = controllerPelanggan.ReadAll();

            foreach (var pelanggan in ListOfPelanggan)
            {
                var noUrut = lvwAkun.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(pelanggan.ID_Pelanggan.ToString());
                item.SubItems.Add(pelanggan.NamaPelanggan);
                item.SubItems.Add(pelanggan.Alamat);
                item.SubItems.Add(pelanggan.Email);
                item.SubItems.Add(pelanggan.NomerHp);
                item.SubItems.Add(pelanggan.Username);
                item.SubItems.Add(pelanggan.SisaWaktu.ToString("hh':'mm':'ss")); 

                lvwAkun.Items.Add(item);
            }


        }
    }
}
