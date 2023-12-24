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
            lvwAkun.Columns.Add("No.", 91, HorizontalAlignment.Center);
            lvwAkun.Columns.Add("ID_Pelanggan", 91, HorizontalAlignment.Center);
            lvwAkun.Columns.Add("NamaPelanggan", 170, HorizontalAlignment.Left);
            lvwAkun.Columns.Add("email", 80, HorizontalAlignment.Center);
            lvwAkun.Columns.Add("NomerHp", 91, HorizontalAlignment.Center);
        }
        private void LoadDataPelanggan()
        {
            // kosongkan listview
            lvwAkun.Items.Clear();

            // panggil method ReadAll dan tampung datanya ke dalam collection
            ListOfPelanggan = controllerPelanggan.ReadAll();

            // ekstrak objek mhs dari collection
            foreach (var mhs in ListOfPelanggan)
            {
                var noUrut = lvwAkun.Items.Count + 1;


                var item = new ListViewItem(noUrut.ToString());

                item.SubItems.Add(mhs.NamaPelanggan);
                item.SubItems.Add(mhs.Email);
                item.SubItems.Add(mhs.NomerHp);
                // tampilkan data mhs ke listview
                lvwAkun.Items.Add(item);
            }


        }
    }
}
