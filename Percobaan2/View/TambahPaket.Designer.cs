namespace Percobaan2.View
{
    partial class TambahPaket
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
            cmbPaket = new ComboBox();
            lvwPaket = new ListView();
            btnBeliPaket = new Button();
            btnCancelBeli = new Button();
            txtUsername = new TextBox();
            txtSisaWaktu = new TextBox();
            txtP = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // cmbPaket
            // 
            cmbPaket.FormattingEnabled = true;
            cmbPaket.Items.AddRange(new object[] { "Paket 1 (30 menit) ", "Paket 2 (1 Jam)", "Paket 3 (2 Jam)", "Paket 4 (3 Jam)", "Paket 5 (4 Jam)", "Paket 6 (5 Jam)", " " });
            cmbPaket.Location = new Point(12, 353);
            cmbPaket.Name = "cmbPaket";
            cmbPaket.Size = new Size(263, 23);
            cmbPaket.TabIndex = 0;
            // 
            // lvwPaket
            // 
            lvwPaket.Location = new Point(12, 103);
            lvwPaket.Name = "lvwPaket";
            lvwPaket.Size = new Size(396, 234);
            lvwPaket.TabIndex = 1;
            lvwPaket.UseCompatibleStateImageBehavior = false;
            lvwPaket.SelectedIndexChanged += lvwPaket_SelectedIndexChanged;
            // 
            // btnBeliPaket
            // 
            btnBeliPaket.Location = new Point(119, 449);
            btnBeliPaket.Name = "btnBeliPaket";
            btnBeliPaket.Size = new Size(75, 23);
            btnBeliPaket.TabIndex = 2;
            btnBeliPaket.Text = "Ok";
            btnBeliPaket.UseVisualStyleBackColor = true;
            btnBeliPaket.Click += btnBeliPaket_Click;
            // 
            // btnCancelBeli
            // 
            btnCancelBeli.Location = new Point(200, 449);
            btnCancelBeli.Name = "btnCancelBeli";
            btnCancelBeli.Size = new Size(75, 23);
            btnCancelBeli.TabIndex = 2;
            btnCancelBeli.Text = "Cancel";
            btnCancelBeli.UseVisualStyleBackColor = true;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(129, 12);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(100, 23);
            txtUsername.TabIndex = 3;
            // 
            // txtSisaWaktu
            // 
            txtSisaWaktu.Location = new Point(129, 41);
            txtSisaWaktu.Name = "txtSisaWaktu";
            txtSisaWaktu.Size = new Size(100, 23);
            txtSisaWaktu.TabIndex = 4;
            // 
            // txtP
            // 
            txtP.AutoSize = true;
            txtP.Location = new Point(12, 20);
            txtP.Name = "txtP";
            txtP.Size = new Size(69, 15);
            txtP.TabIndex = 5;
            txtP.Text = "Username : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 49);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 5;
            label1.Text = "Sisa waktu : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 85);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 5;
            label2.Text = "Paket Billing : ";
            // 
            // TambahPaket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 484);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtP);
            Controls.Add(txtSisaWaktu);
            Controls.Add(txtUsername);
            Controls.Add(btnCancelBeli);
            Controls.Add(btnBeliPaket);
            Controls.Add(lvwPaket);
            Controls.Add(cmbPaket);
            Name = "TambahPaket";
            Text = "TambahPaket";
            Load += TambahPaket_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbPaket;
        private ListView lvwPaket;
        private Button btnBeliPaket;
        private Button btnCancelBeli;
        private TextBox txtUsername;
        private TextBox txtSisaWaktu;
        private Label txtP;
        private Label label1;
        private Label label2;
    }
}