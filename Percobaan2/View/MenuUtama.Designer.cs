namespace Percobaan2.View
{
    partial class MenuUtama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuUtama));
            btnTransaksi = new Button();
            btnAkun = new Button();
            btnKomputer = new Button();
            isiKomputer1 = new IsiKomputer();
            isiAkun1 = new IsiAkun();
            isiTransaksi1 = new IsiTransaksi();
            laporan1 = new Laporan();
            menuStrip1 = new MenuStrip();
            dfd = new ToolStripMenuItem();
            akunOperatorToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnTransaksi
            // 
            btnTransaksi.BackColor = SystemColors.WindowFrame;
            btnTransaksi.FlatAppearance.BorderSize = 0;
            btnTransaksi.FlatStyle = FlatStyle.Flat;
            btnTransaksi.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnTransaksi.ForeColor = Color.White;
            btnTransaksi.Image = (Image)resources.GetObject("btnTransaksi.Image");
            btnTransaksi.ImageAlign = ContentAlignment.MiddleLeft;
            btnTransaksi.Location = new Point(621, 25);
            btnTransaksi.Margin = new Padding(4, 3, 4, 3);
            btnTransaksi.Name = "btnTransaksi";
            btnTransaksi.Size = new Size(144, 50);
            btnTransaksi.TabIndex = 10;
            btnTransaksi.Text = "Transaksi";
            btnTransaksi.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTransaksi.UseVisualStyleBackColor = false;
            btnTransaksi.Click += btnTransaksi_Click;
            // 
            // btnAkun
            // 
            btnAkun.BackColor = SystemColors.WindowFrame;
            btnAkun.FlatAppearance.BorderSize = 0;
            btnAkun.FlatStyle = FlatStyle.Flat;
            btnAkun.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAkun.ForeColor = Color.White;
            btnAkun.Image = (Image)resources.GetObject("btnAkun.Image");
            btnAkun.ImageAlign = ContentAlignment.MiddleLeft;
            btnAkun.Location = new Point(469, 25);
            btnAkun.Margin = new Padding(4, 3, 4, 3);
            btnAkun.Name = "btnAkun";
            btnAkun.Size = new Size(144, 50);
            btnAkun.TabIndex = 12;
            btnAkun.Text = "Akun";
            btnAkun.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAkun.UseVisualStyleBackColor = false;
            btnAkun.Click += btnAkun_Click;
            // 
            // btnKomputer
            // 
            btnKomputer.BackColor = SystemColors.WindowFrame;
            btnKomputer.FlatAppearance.BorderSize = 0;
            btnKomputer.FlatStyle = FlatStyle.Flat;
            btnKomputer.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnKomputer.ForeColor = Color.White;
            btnKomputer.Image = (Image)resources.GetObject("btnKomputer.Image");
            btnKomputer.ImageAlign = ContentAlignment.MiddleLeft;
            btnKomputer.Location = new Point(317, 25);
            btnKomputer.Margin = new Padding(4, 3, 4, 3);
            btnKomputer.Name = "btnKomputer";
            btnKomputer.Size = new Size(144, 50);
            btnKomputer.TabIndex = 13;
            btnKomputer.Text = "Komputer";
            btnKomputer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnKomputer.UseVisualStyleBackColor = false;
            btnKomputer.Click += btnKomputer_Click;
            // 
            // isiKomputer1
            // 
            isiKomputer1.Location = new Point(12, 90);
            isiKomputer1.Name = "isiKomputer1";
            isiKomputer1.Size = new Size(1066, 569);
            isiKomputer1.TabIndex = 14;
            // 
            // isiAkun1
            // 
            isiAkun1.Location = new Point(12, 90);
            isiAkun1.Name = "isiAkun1";
            isiAkun1.Size = new Size(1066, 569);
            isiAkun1.TabIndex = 15;
            // 
            // isiTransaksi1
            // 
            isiTransaksi1.Location = new Point(12, 90);
            isiTransaksi1.Name = "isiTransaksi1";
            isiTransaksi1.Size = new Size(1066, 569);
            isiTransaksi1.TabIndex = 17;
            // 
            // laporan1
            // 
            laporan1.Location = new Point(24, 90);
            laporan1.Name = "laporan1";
            laporan1.Size = new Size(1066, 569);
            laporan1.TabIndex = 18;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { dfd });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1077, 24);
            menuStrip1.TabIndex = 19;
            menuStrip1.Text = "menuStrip1";
            // 
            // dfd
            // 
            dfd.DropDownItems.AddRange(new ToolStripItem[] { akunOperatorToolStripMenuItem });
            dfd.Name = "dfd";
            dfd.Size = new Size(50, 20);
            dfd.Text = "Menu";
            // 
            // akunOperatorToolStripMenuItem
            // 
            akunOperatorToolStripMenuItem.Name = "akunOperatorToolStripMenuItem";
            akunOperatorToolStripMenuItem.Size = new Size(152, 22);
            akunOperatorToolStripMenuItem.Text = "Akun Operator";
            akunOperatorToolStripMenuItem.Click += akunOperatorToolStripMenuItem_Click;
            // 
            // MenuUtama
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 685);
            Controls.Add(laporan1);
            Controls.Add(isiTransaksi1);
            Controls.Add(isiKomputer1);
            Controls.Add(isiAkun1);
            Controls.Add(btnTransaksi);
            Controls.Add(btnAkun);
            Controls.Add(btnKomputer);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MenuUtama";
            Text = "MenuUtama";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTransaksi;
        private Button btnAkun;
        private Button btnKomputer;
        private IsiKomputer isiKomputer1;
        private IsiAkun isiAkun1;
        private IsiTransaksi isiTransaksi1;
        private Laporan laporan1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dfd;
        private ToolStripMenuItem akunOperatorToolStripMenuItem;
    }
}