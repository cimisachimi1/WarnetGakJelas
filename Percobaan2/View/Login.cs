using Percobaan2.Controller;
using Percobaan2.Model.Entity;
using Percobaan2.Model.Repository;

namespace Percobaan2.View
{
    public partial class Login : Form
    {

        private OperatorRepository operatorRepository;
        public Login()
        {
            InitializeComponent();
        }

        private void btnBatalLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoginAwal_Click(object sender, EventArgs e)
        {
            OperatorController controller = new OperatorController();

            bool isValidUser = controller.IsValidOperator(txtUsername.Text, txtPassword.Text);
            if (isValidUser)
            {
                this.DialogResult = DialogResult.OK;
                
                MenuUtama menuutama = new MenuUtama();
                menuutama.Show();
                this.Hide();
            }
        }
    }
}


