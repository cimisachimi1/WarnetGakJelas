using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Percobaan2.Model.Entity;
using Percobaan2.Controller;
using Percobaan2.Model.Repository;
using Microsoft.VisualBasic.Devices;


namespace Percobaan2.View
{
    public partial class IsiKomputer : UserControl
    {


        private List<KomputerWarnet> listOfKomputer = new List<KomputerWarnet>();
        private KomputerWarnetController controllerKomputer;

        private List<KomputerWarnet> komputer;

        public IsiKomputer()
        {
            InitializeComponent();

            controllerKomputer = new KomputerWarnetController();
            InisialisasiListView();
            LoadDataKomputer();
        }


        private void InisialisasiListView()
        {

            lvwKomputer.View = System.Windows.Forms.View.Details;
            lvwKomputer.FullRowSelect = true;
            lvwKomputer.GridLines = true;

            lvwKomputer.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwKomputer.Columns.Add("ID Komputer", 91, HorizontalAlignment.Center);
            lvwKomputer.Columns.Add("Ketersediaan", 150, HorizontalAlignment.Center);
            lvwKomputer.Columns.Add("Jenis Komputer", 150, HorizontalAlignment.Left);

        }


        private void LoadDataKomputer()
        {
            lvwKomputer.Items.Clear();
            listOfKomputer = controllerKomputer.ReadAll();

            foreach (var komputer in listOfKomputer)
            {
                var noUrut = lvwKomputer.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(komputer.ID_Komputer.ToString());
                item.SubItems.Add(komputer.Ketersediaan.ToString());
                item.SubItems.Add(komputer.Jenis_Komputer);

                lvwKomputer.Items.Add(item);
            }
        }

        private void IsiKomputer_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
