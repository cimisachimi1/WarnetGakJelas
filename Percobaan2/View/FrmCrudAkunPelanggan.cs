
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Percobaan2.Controller;
    using Percobaan2.Model.Entity;

namespace Percobaan2.View
    {
    public partial class FrmCrudAkunPelanggan : Form
    {
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

        // constructor default
        public FrmCrudAkunPelanggan()
        {
            InitializeComponent();
        }

        // constructor untuk inisialisasi data ketika entri data baru
        public FrmCrudAkunPelanggan(string title, PelangganController controllerPelanggan)
            : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controllerPelanggan = controllerPelanggan;
        }

        // constructor untuk inisialisasi data ketika mengedit data
        public FrmCrudAkunPelanggan(string title, Pelanggan obj, PelangganController controllerPelanggan)
            : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controllerPelanggan = controllerPelanggan;

            isNewData = false; // set status edit data
            pelanggan = obj; // set objek pelanggan yang akan diedit

            // untuk edit data, tampilkan data lama
            txtIDPelanggan.Text = pelanggan.ID_Pelanggan;
            txtNamaPelanggan.Text = pelanggan.NamaPelanggan;
            txtEmailPelanggan.Text = pelanggan.Email;
            txtNomerHp.Text = pelanggan.NomerHp;
            txtAlamat.Text = pelanggan.Alamat;
            txtUsername.Text = pelanggan.Username;
            txtSisaWaktu.Text = pelanggan.SisaWaktu.ToString("hh':'mm':'ss");
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {

        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            // tutup form entry pelanggan
            this.Close();
        }


        private void btnKirim_Click(object sender, EventArgs e)
        {
            // jika data baru, inisialisasi objek pelanggan
            if (isNewData) pelanggan = new Pelanggan();

            // set nilai property objek pelanggan yg diambil dari TextBox
            pelanggan.ID_Pelanggan = txtIDPelanggan.Text;
            pelanggan.NamaPelanggan = txtNamaPelanggan.Text;
            pelanggan.Alamat = txtAlamat.Text;
            pelanggan.Email = txtEmailPelanggan.Text;
            pelanggan.NomerHp = txtNomerHp.Text;
            pelanggan.Username = txtUsername.Text;
            pelanggan.Password = txtPassword.Text;


            int result = 0;

            if (isNewData) // tambah data baru, panggil method Create
            {
                // panggil operasi CRUD
                result = controllerPelanggan.Create(pelanggan);

                if (result > 0) // tambah data berhasil
                {
                    OnCreate(pelanggan); // panggil event OnCreate

                    // reset form input, utk persiapan input data berikutnya
                    txtIDPelanggan.Clear();
                    txtNamaPelanggan.Clear();
                    txtAlamat.Clear();
                    txtEmailPelanggan.Clear();
                    txtNomerHp.Clear();
                    txtUsername.Clear();

                    txtIDPelanggan.Focus();
                }
            }
            else // edit data, panggil method Update
            {
                // panggil operasi CRUD
                result = controllerPelanggan.Update(pelanggan);

                if (result > 0)
                {

                    OnUpdate(pelanggan); // panggil event OnUpdate
                    this.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCrudAkunPelanggan_Load(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TambahPaket tambahpaket = new TambahPaket();
            tambahpaket.ShowDialog();
        }
    }
}