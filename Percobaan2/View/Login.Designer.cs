namespace Percobaan2.View
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnBatalLogin = new Button();
            btnLoginAwal = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(31, 46);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 2;
            label1.Text = "Username : ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(31, 93);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 2;
            label2.Text = "Password :";
            label2.Click += label1_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(144, 43);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(168, 23);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(144, 90);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(168, 23);
            txtPassword.TabIndex = 3;
            // 
            // btnBatalLogin
            // 
            btnBatalLogin.Location = new Point(369, 43);
            btnBatalLogin.Name = "btnBatalLogin";
            btnBatalLogin.Size = new Size(75, 23);
            btnBatalLogin.TabIndex = 4;
            btnBatalLogin.Text = "Batal ";
            btnBatalLogin.UseVisualStyleBackColor = true;
            btnBatalLogin.Click += btnBatalLogin_Click;
            // 
            // btnLoginAwal
            // 
            btnLoginAwal.Location = new Point(369, 90);
            btnLoginAwal.Name = "btnLoginAwal";
            btnLoginAwal.Size = new Size(75, 23);
            btnLoginAwal.TabIndex = 4;
            btnLoginAwal.Text = "Login";
            btnLoginAwal.UseVisualStyleBackColor = true;
            btnLoginAwal.Click += btnLoginAwal_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 159);
            Controls.Add(btnLoginAwal);
            Controls.Add(btnBatalLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

#endregion
        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnBatalLogin;
        private Button btnLoginAwal;
    }
}