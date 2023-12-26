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

        public PelangganController controllerPelanggan;

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
        private void OnCreatePelangganEventHandler(Pelanggan pelanggan)
        {
            // Add the new pelanggan object to the collection
            ListOfPelanggan.Add(pelanggan);

            int noUrut = lvwAkun.Items.Count + 1;

            // Display the data of the new pelanggan in the list view
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(pelanggan.ID_Pelanggan.ToString());
            item.SubItems.Add(pelanggan.NamaPelanggan);
            item.SubItems.Add(pelanggan.Alamat);
            item.SubItems.Add(pelanggan.Email);
            item.SubItems.Add(pelanggan.NomerHp);
            item.SubItems.Add(pelanggan.Username);
            item.SubItems.Add(pelanggan.Password);
            item.SubItems.Add(pelanggan.SisaWaktu.ToString("hh':'mm':'ss"));

            lvwAkun.Items.Add(item);
        }
        private void OnUpdateEventHandler(Pelanggan pelanggan)
        {
                // Get the index of the selected item
                int index = lvwAkun.SelectedIndices[0];

                // Update information of the selected pelanggan in the list view
                ListViewItem itemRow = lvwAkun.Items[index];
                itemRow.SubItems[1].Text = pelanggan.ID_Pelanggan;
                itemRow.SubItems[2].Text = pelanggan.NamaPelanggan;
                itemRow.SubItems[3].Text = pelanggan.Alamat;
                itemRow.SubItems[4].Text = pelanggan.Email;
                itemRow.SubItems[5].Text = pelanggan.NomerHp;
                itemRow.SubItems[6].Text = pelanggan.Username;
                itemRow.SubItems[7].Text = pelanggan.SisaWaktu.ToString("hh':'mm':'ss");


        }


        private void btnBaruAkun_Click(object sender, EventArgs e)
        {
            FrmCrudAkunPelanggan frmcrudakunpelangggan = new FrmCrudAkunPelanggan("Tambah Data Pelanggan", controllerPelanggan);

            frmcrudakunpelangggan.OnCreate += OnCreatePelangganEventHandler;

            frmcrudakunpelangggan.ShowDialog();

        }
        private void btnEditAkun_Click(object sender, EventArgs e)
        {
            if (lvwAkun.SelectedItems.Count > 0) {
                Pelanggan pelanggan = ListOfPelanggan[lvwAkun.SelectedIndices[0]];
                
                FrmCrudAkunPelanggan frmcrudakunpelanggan = new FrmCrudAkunPelanggan("Edit Data Pelanggan ", pelanggan, controllerPelanggan);

                frmcrudakunpelanggan.OnUpdate += OnUpdateEventHandler;

                frmcrudakunpelanggan.ShowDialog();

            }
            else
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            // kosongkan listview
            lvwAkun.Items.Clear();

            // panggil method ReadByNama dan tampung datanya ke dalam collection
            ListOfPelanggan = controllerPelanggan.ReadByNama(txtCariAkun.Text);

            // ekstrak objek pelanggan dari collection
            foreach (var pelanggan in ListOfPelanggan)
            {
                var noUrut = lvwAkun.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(pelanggan.ID_Pelanggan); // Assuming ID_Pelanggan is the property in Pelanggan class
                item.SubItems.Add(pelanggan.NamaPelanggan);
                item.SubItems.Add(pelanggan.Alamat);
                item.SubItems.Add(pelanggan.Email);
                item.SubItems.Add(pelanggan.NomerHp);
                item.SubItems.Add(pelanggan.Username);
                item.SubItems.Add(pelanggan.Password);
                item.SubItems.Add(pelanggan.SisaWaktu.ToString()); // Assuming SisaWaktu is of TimeSpan type

                // tampilkan data pelanggan ke listview
                lvwAkun.Items.Add(item);
            }
        }

        private void btnCariAkun_Click(object sender, EventArgs e)
        {
            // kosongkan listview
            lvwAkun.Items.Clear();

            // panggil method ReadByNama dan tampung datanya ke dalam collection
            ListOfPelanggan = controllerPelanggan.ReadByNama(txtCariAkun.Text);

            // ekstrak objek pelanggan dari collection
            foreach (var pelanggan in ListOfPelanggan)
            {
                var noUrut = lvwAkun.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(pelanggan.ID_Pelanggan); // Assuming ID_Pelanggan is the property in Pelanggan class
                item.SubItems.Add(pelanggan.NamaPelanggan);
                item.SubItems.Add(pelanggan.Alamat);
                item.SubItems.Add(pelanggan.Email);
                item.SubItems.Add(pelanggan.NomerHp);
                item.SubItems.Add(pelanggan.Username);
                item.SubItems.Add(pelanggan.Password);
                item.SubItems.Add(pelanggan.SisaWaktu.ToString()); // Assuming SisaWaktu is of TimeSpan type

                // tampilkan data pelanggan ke listview
                lvwAkun.Items.Add(item);
            }
        }

        private void btnHapusAkun_Click(object sender, EventArgs e)
        {
            if (lvwAkun.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data mahasiswa ingin dihapus?", "Konfirmasi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (konfirmasi == DialogResult.Yes)
                {
                    // ambil objek mhs yang mau dihapus dari collection
                    Pelanggan pelanggan = ListOfPelanggan[lvwAkun.SelectedIndices[0]];

                    // panggil operasi CRUD
                    var result = controllerPelanggan.Delete(pelanggan);
                    if (result > 0) LoadDataPelanggan();
                }
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data mahasiswa belum dipilih !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void IsiAkun_Load(object sender, EventArgs e)
        {

        }


    }
}

