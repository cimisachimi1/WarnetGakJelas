namespace Percobaan2.View
{
    partial class AkunOperator
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
            lvwAkunOperator = new ListView();
            btnBaruOperator = new Button();
            btnEditOperator = new Button();
            btnHapusOperator = new Button();
            btnKeluarOperator = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lvwAkunOperator
            // 
            lvwAkunOperator.Location = new Point(12, 65);
            lvwAkunOperator.Name = "lvwAkunOperator";
            lvwAkunOperator.Size = new Size(791, 193);
            lvwAkunOperator.TabIndex = 0;
            lvwAkunOperator.UseCompatibleStateImageBehavior = false;
            // 
            // btnBaruOperator
            // 
            btnBaruOperator.Location = new Point(12, 11);
            btnBaruOperator.Name = "btnBaruOperator";
            btnBaruOperator.Size = new Size(75, 23);
            btnBaruOperator.TabIndex = 1;
            btnBaruOperator.Text = "Baru";
            btnBaruOperator.UseVisualStyleBackColor = true;
            btnBaruOperator.Click += btnBaruOperator_Click;
            // 
            // btnEditOperator
            // 
            btnEditOperator.Location = new Point(93, 11);
            btnEditOperator.Name = "btnEditOperator";
            btnEditOperator.Size = new Size(75, 23);
            btnEditOperator.TabIndex = 1;
            btnEditOperator.Text = "Edit";
            btnEditOperator.UseVisualStyleBackColor = true;
            btnEditOperator.Click += btnEditOperator_Click;
            // 
            // btnHapusOperator
            // 
            btnHapusOperator.Location = new Point(174, 11);
            btnHapusOperator.Name = "btnHapusOperator";
            btnHapusOperator.Size = new Size(75, 23);
            btnHapusOperator.TabIndex = 1;
            btnHapusOperator.Text = "Hapus";
            btnHapusOperator.UseVisualStyleBackColor = true;
            // 
            // btnKeluarOperator
            // 
            btnKeluarOperator.Location = new Point(681, 265);
            btnKeluarOperator.Name = "btnKeluarOperator";
            btnKeluarOperator.Size = new Size(122, 33);
            btnKeluarOperator.TabIndex = 2;
            btnKeluarOperator.Text = "Oke";
            btnKeluarOperator.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 47);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 3;
            label1.Text = "Daftar Operator";
            label1.Click += label1_Click;
            // 
            // AkunOperator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 310);
            Controls.Add(label1);
            Controls.Add(btnKeluarOperator);
            Controls.Add(btnHapusOperator);
            Controls.Add(btnEditOperator);
            Controls.Add(btnBaruOperator);
            Controls.Add(lvwAkunOperator);
            Name = "AkunOperator";
            Text = "AkunOperator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvwAkunOperator;
        private Button btnBaruOperator;
        private Button btnEditOperator;
        private Button btnHapusOperator;
        private Button btnKeluarOperator;
        private Label label1;
    }
}