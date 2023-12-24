namespace Percobaan2.View
{
    partial class IsiAkun
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lvwAkun = new ListView();
            txtCariAkun = new TextBox();
            cmbCariAkun = new ComboBox();
            btnCariAkun = new Button();
            SuspendLayout();
            // 
            // lvwAkun
            // 
            lvwAkun.ForeColor = SystemColors.ActiveCaption;
            lvwAkun.Location = new Point(235, 48);
            lvwAkun.Name = "lvwAkun";
            lvwAkun.Size = new Size(700, 468);
            lvwAkun.TabIndex = 0;
            lvwAkun.UseCompatibleStateImageBehavior = false;
            // 
            // txtCariAkun
            // 
            txtCariAkun.Location = new Point(48, 77);
            txtCariAkun.Name = "txtCariAkun";
            txtCariAkun.Size = new Size(121, 23);
            txtCariAkun.TabIndex = 1;
            // 
            // cmbCariAkun
            // 
            cmbCariAkun.FormattingEnabled = true;
            cmbCariAkun.Items.AddRange(new object[] { "Username", "Nama" });
            cmbCariAkun.Location = new Point(48, 48);
            cmbCariAkun.Name = "cmbCariAkun";
            cmbCariAkun.Size = new Size(121, 23);
            cmbCariAkun.TabIndex = 2;
            // 
            // btnCariAkun
            // 
            btnCariAkun.Location = new Point(89, 106);
            btnCariAkun.Name = "btnCariAkun";
            btnCariAkun.Size = new Size(80, 23);
            btnCariAkun.TabIndex = 3;
            btnCariAkun.Text = "Cari";
            btnCariAkun.UseVisualStyleBackColor = true;
            // 
            // IsiAkun
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCariAkun);
            Controls.Add(cmbCariAkun);
            Controls.Add(txtCariAkun);
            Controls.Add(lvwAkun);
            Name = "IsiAkun";
            Size = new Size(1066, 569);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvwAkun;
        private TextBox txtCariAkun;
        private ComboBox cmbCariAkun;
        private Button btnCariAkun;
    }
}
