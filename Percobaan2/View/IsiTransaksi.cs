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
    public partial class IsiTransaksi : UserControl
    {

        private List<Transaksi> ListOfTransaksi = new List<Transaksi>();

        public TransaksiController controllerTransaksi;

        public IsiTransaksi()
        {
            InitializeComponent();
            controllerTransaksi = new TransaksiController();
            InisialisasiListView();
            LoadDataTransaksi();
        }

        private void InisialisasiListView()
        {
            lvwTransaksi.View = System.Windows.Forms.View.Details;
            lvwTransaksi.FullRowSelect = true;
            lvwTransaksi.GridLines = true;
            lvwTransaksi.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwTransaksi.Columns.Add("ID Transaksi", 91, HorizontalAlignment.Center);
            lvwTransaksi.Columns.Add("ID Pelanggan", 91, HorizontalAlignment.Center);
            lvwTransaksi.Columns.Add("Tanggal Transaksi", 150, HorizontalAlignment.Left);
            lvwTransaksi.Columns.Add("Waktu Terpakai", 100, HorizontalAlignment.Center);
            lvwTransaksi.Columns.Add("Harga", 100, HorizontalAlignment.Center);
            lvwTransaksi.Columns.Add("ID Operator", 100, HorizontalAlignment.Center);
        }
        private void LoadDataTransaksi()
        {
            lvwTransaksi.Items.Clear();
            ListOfTransaksi = controllerTransaksi.ReadAll();

            foreach (var transaksi in ListOfTransaksi)
            {
                var noUrut = lvwTransaksi.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(transaksi.ID_Transaksi.ToString());
                item.SubItems.Add(transaksi.ID_Pelanggan.ToString());
                item.SubItems.Add(transaksi.TanggalTransaksi.ToString());
                item.SubItems.Add(transaksi.WaktuTerpakai.ToString("hh':'mm':'ss"));
                item.SubItems.Add(transaksi.Harga.ToString());
                item.SubItems.Add(transaksi.ID_Operator.ToString());

                lvwTransaksi.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
