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

        public TransaksiWarnetController controllerTransaksi;

        public IsiTransaksi()
        {
            InitializeComponent();
            controllerTransaksi = new TransaksiWarnetController();
            InisialisasiListView();
            LoadDataTransaksiWarnet();
        }

        private void InisialisasiListView()
        {
            lvwTransaksi.View = System.Windows.Forms.View.Details;
            lvwTransaksi.FullRowSelect = true;
            lvwTransaksi.GridLines = true;

            // Adjusted column headers and widths for TransaksiWarnet entity
            lvwTransaksi.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwTransaksi.Columns.Add("ID Transaksi", 91, HorizontalAlignment.Center);
            lvwTransaksi.Columns.Add("Username", 91, HorizontalAlignment.Center); // Assuming Username is a property in TransaksiWarnet
            lvwTransaksi.Columns.Add("Tanggal", 150, HorizontalAlignment.Left); // Assuming Tanggal is a property in TransaksiWarnet
            lvwTransaksi.Columns.Add("Waktu Terpakai", 100, HorizontalAlignment.Center);
            lvwTransaksi.Columns.Add("Harga", 100, HorizontalAlignment.Center);
            lvwTransaksi.Columns.Add("Operator", 100, HorizontalAlignment.Center); // Assuming Operator is a property in TransaksiWarnet

        }
        private void LoadDataTransaksiWarnet()
        {
            lvwTransaksi.Items.Clear();
            List<TransaksiWarnet> listOfTransaksiWarnet = controllerTransaksi.ReadAll();

            foreach (var transaksiWarnet in listOfTransaksiWarnet)
            {
                var noUrut = lvwTransaksi.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(transaksiWarnet.ID_Transaksi.ToString());
                item.SubItems.Add(transaksiWarnet.Username.ToString()); // Assuming Username is a property in TransaksiWarnet
                item.SubItems.Add(transaksiWarnet.Tanggal.ToString()); // Assuming Tanggal is a property in TransaksiWarnet
                item.SubItems.Add(transaksiWarnet.Waktu.ToString());
                item.SubItems.Add(transaksiWarnet.Harga.ToString());
                item.SubItems.Add(transaksiWarnet.Operator.ToString()); // Assuming Operator is a property in TransaksiWarnet

                lvwTransaksi.Items.Add(item);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
