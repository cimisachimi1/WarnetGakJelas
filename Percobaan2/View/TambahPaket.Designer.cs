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
            SuspendLayout();
            // 
            // cmbPaket
            // 
            cmbPaket.FormattingEnabled = true;
            cmbPaket.Items.AddRange(new object[] { "Paket 1 (30 menit) ", "Paket 2 (1 Jam)", "Paket 3 (2 Jam)", "Paket 4 (3 Jam)", "Paket 5 (4 Jam)", "Paket 6 (5 Jam)", " " });
            cmbPaket.Location = new Point(12, 189);
            cmbPaket.Name = "cmbPaket";
            cmbPaket.Size = new Size(263, 23);
            cmbPaket.TabIndex = 0;
            // 
            // lvwPaket
            // 
            lvwPaket.Location = new Point(12, 12);
            lvwPaket.Name = "lvwPaket";
            lvwPaket.Size = new Size(396, 162);
            lvwPaket.TabIndex = 1;
            lvwPaket.UseCompatibleStateImageBehavior = false;
            lvwPaket.SelectedIndexChanged += lvwPaket_SelectedIndexChanged;
            // 
            // btnBeliPaket
            // 
            btnBeliPaket.Location = new Point(129, 266);
            btnBeliPaket.Name = "btnBeliPaket";
            btnBeliPaket.Size = new Size(75, 23);
            btnBeliPaket.TabIndex = 2;
            btnBeliPaket.Text = "Ok";
            btnBeliPaket.UseVisualStyleBackColor = true;
            btnBeliPaket.Click += btnBeliPaket_Click;
            // 
            // btnCancelBeli
            // 
            btnCancelBeli.Location = new Point(210, 266);
            btnCancelBeli.Name = "btnCancelBeli";
            btnCancelBeli.Size = new Size(75, 23);
            btnCancelBeli.TabIndex = 2;
            btnCancelBeli.Text = "Cancel";
            btnCancelBeli.UseVisualStyleBackColor = true;
            // 
            // TambahPaket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 301);
            Controls.Add(btnCancelBeli);
            Controls.Add(btnBeliPaket);
            Controls.Add(lvwPaket);
            Controls.Add(cmbPaket);
            Name = "TambahPaket";
            Text = "TambahPaket";
            Load += TambahPaket_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbPaket;
        private ListView lvwPaket;
        private Button btnBeliPaket;
        private Button btnCancelBeli;
    }
}