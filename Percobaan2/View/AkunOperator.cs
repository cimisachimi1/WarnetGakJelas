
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
    public partial class AkunOperator : Form
    {

        private List<Operator> listOfOperators = new List<Operator>();
        private OperatorController controllerOperator;
        public AkunOperator()
        {
            InitializeComponent();

            controllerOperator = new OperatorController();
            InisialisasiListView();
            LoadDataOperators();
        }
        private void InisialisasiListView()
        {
            lvwAkunOperator.View = System.Windows.Forms.View.Details;
            lvwAkunOperator.FullRowSelect = true;
            lvwAkunOperator.GridLines = true;

            lvwAkunOperator.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwAkunOperator.Columns.Add("ID Operator", 91, HorizontalAlignment.Center);
            lvwAkunOperator.Columns.Add("Nama", 150, HorizontalAlignment.Left);
            lvwAkunOperator.Columns.Add("Alamat", 150, HorizontalAlignment.Left);
            lvwAkunOperator.Columns.Add("Umur", 50, HorizontalAlignment.Center);
            lvwAkunOperator.Columns.Add("Mulai Shift", 120, HorizontalAlignment.Center);
            lvwAkunOperator.Columns.Add("Akhir Shift", 120, HorizontalAlignment.Center);
            lvwAkunOperator.Columns.Add("Username", 100, HorizontalAlignment.Center);
            // Password is not displayed for security reasons, but you can customize as needed.
        }

        private void LoadDataOperators()
        {
            lvwAkunOperator.Items.Clear();
            listOfOperators = controllerOperator.ReadAll();

            foreach (var op in listOfOperators)
            {
                var noUrut = lvwAkunOperator.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(op.ID_Operator.ToString());
                item.SubItems.Add(op.Nama);
                item.SubItems.Add(op.Alamat);
                item.SubItems.Add(op.Umur.ToString());
                item.SubItems.Add(op.Mulai_Shift.ToString("HH:mm:ss"));
                item.SubItems.Add(op.Akhir_Shift.ToString("HH:mm:ss"));
                item.SubItems.Add(op.Username);

                lvwAkunOperator.Items.Add(item);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBaruOperator_Click(object sender, EventArgs e)
        {
            CrudOperator crudOperator = new CrudOperator();

            crudOperator.ShowDialog();
        }

        private void btnEditOperator_Click(object sender, EventArgs e)
        {
            CrudOperator crudOperator = new CrudOperator();

            crudOperator.ShowDialog();
        }
    }
}
