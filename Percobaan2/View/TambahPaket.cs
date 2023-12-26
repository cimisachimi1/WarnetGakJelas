using MySql.Data.MySqlClient;
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
        private List<Transaksi> ListOfTransaksi = new List<Transaksi>();

        public TransaksiController transaksiController;

        private List<Paket> ListOfPaket = new List<Paket>();

        public PaketController controllerPaket; // Assuming you have a PaketController
        

        public delegate void CreateUpdateEventHandler(Pelanggan pelanggan);

        // deklarasi event ketika terjadi proses input data baru
        public event CreateUpdateEventHandler OnCreate;

        // deklarasi event ketika terjadi proses update data
        public event CreateUpdateEventHandler OnUpdate;

        // deklarasi objek controller
        private PelangganController controllerPelanggan;

        // deklarasi field untuk menyimpan status entry data (input baru atau update)
        private bool isNewData = true;

        // deklarasi field untuk menyimpan objek pelanggan
        private Pelanggan pelanggan;


        public TambahPaket()
        {
            InitializeComponent();

            controllerPaket = new PaketController(); // Initialize PaketController

            InisialisasiListView();

            LoadDataPaket();
        }

        public TambahPaket(string title, Pelanggan obj, PelangganController controllerPelanggan)
    : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controllerPelanggan = controllerPelanggan;

            isNewData = false; // set status edit data
            pelanggan = obj; // set objek pelanggan yang akan diedit

            // untuk edit data, tampilkan data lama
            txtUsername.Text = pelanggan.Username;
            txtSisaWaktu.Text = pelanggan.SisaWaktu.ToString("hh':'mm':'ss");
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
            string noPaket;
            try
            {
                // set nilai property objek pelanggan yg diambil dari TextBox

                pelanggan.Username = txtUsername.Text;
                switch (cmbPaket.SelectedIndex)
                {
                    case 0: // penambahan
                        pelanggan.SisaWaktu = pelanggan.SisaWaktu.Add(TimeSpan.FromMinutes(30));
                        
                        break;

                    case 1: // pengurangan
                        pelanggan.SisaWaktu = pelanggan.SisaWaktu.Add(TimeSpan.FromHours(1));
                        noPaket = "pkt2";
                        break;

                    case 2: // perkalian
                        pelanggan.SisaWaktu = pelanggan.SisaWaktu.Add(TimeSpan.FromHours(2));
                        noPaket = "pkt3";
                        break;

                    case 3: // pembagian
                        pelanggan.SisaWaktu = pelanggan.SisaWaktu.Add(TimeSpan.FromHours(3));
                        noPaket = "pkt4";
                        break;
                    case 4: // pembagian
                        pelanggan.SisaWaktu = pelanggan.SisaWaktu.Add(TimeSpan.FromHours(4));
                        noPaket = "pkt5";
                        break;
                    case 5: // pembagian
                        pelanggan.SisaWaktu = pelanggan.SisaWaktu.Add(TimeSpan.FromHours(5));
                        noPaket = "pkt6";
                        break;
                }

                // Update the pelanggan data in the controller
                int result = controllerPelanggan.Update(pelanggan);

                // Close the form or perform any other necessary actions
                OnUpdate(pelanggan);
                this.Close();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
            
        }

        }
    }

